namespace Services.Packages.Client.Actions
{
    using System.IO;
    using System.Linq;
    using Chains;
    using Chains.Play;
    using Chains.Play.Security;
    using Chains.Play.Web;
    using Ionic.Zip;
    using Services.Communication.Protocol;
    using Services.Packages.Update;

    public sealed class UpdateClientApplication : Reproducible, IChainableAction<Repository, Repository>, IApplicationAuthorizableAction
    {
        private readonly string hostname;

        private readonly int port;

        private readonly string updateDirectory;

        public string ApiKey { get; set; }

        public UpdateClientApplication(string hostname, int port, string updateDirectory)
        {
            this.hostname = hostname;
            this.port = port;
            this.updateDirectory = updateDirectory;
        }

        public Repository Act(Repository context)
        {
            using (var updateServerConnection = new Client(hostname, port).Do(new OpenConnection()))
            {
                var checkPackagesForUpdateData = new CheckPackagesForUpdateData();
                var dbPackages = LocalPackage.SearchByPackageName("*");
                foreach (var dbPackage in dbPackages)
                {
                    checkPackagesForUpdateData.Packages.Add(
                        new PackageDescription
                        {
                            Id = dbPackage.Id,
                            PackageName = dbPackage.PackageName,
                            VersionLabel = dbPackage.VersionLabel
                        });
                }

                var packagesToUpdate =
                    updateServerConnection.Do(
                        new Send<CheckPackagesForUpdateReturnData>(
                            new CheckPackagesForUpdate(checkPackagesForUpdateData)
                            {
                                ApiKey = ApiKey
                            }));

                if (packagesToUpdate.Packages.Count > 0)
                {
                    var downloadedPackages =
                        updateServerConnection.DoParallelFor(
                            packagesToUpdate.Packages.Select(
                                x => new Send<DownloadPackageReturnData>(
                                    new DownloadPackage(
                                        new DownloadPackageData
                                        {
                                            PackageRequested = x
                                        })
                                    {
                                        ApiKey = ApiKey
                                    })).ToArray<IChainableAction<ClientConnectionContext, DownloadPackageReturnData>>())
                        .ToArray();

                    Directory.CreateDirectory(updateDirectory);

                    foreach (var downloadedPackage in downloadedPackages)
                    {
                        using (var zipFile = ZipFile.Read(new MemoryStream(downloadedPackage.ZipFile)))
                        {
                            foreach (var zipEntry in zipFile)
                            {
                                zipEntry.Extract(updateDirectory, ExtractExistingFileAction.OverwriteSilently);
                            }
                        }
                    }

                    foreach (var downloadedPackage in downloadedPackages)
                    {
                        var localPackage = new LocalPackage(downloadedPackage.PackageDownloaded.PackageName);
                        localPackage.Id = downloadedPackage.PackageDownloaded.Id;
                        localPackage.VersionLabel = downloadedPackage.PackageDownloaded.VersionLabel;
                        localPackage.Update();
                    }
                }
            }

            return context;
        }
    }
}
