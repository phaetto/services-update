namespace Services.Package.Download
{
    using System;
    using System.Collections.Concurrent;
    using System.IO;
    using System.Threading.Tasks;
    using Chains.Play;
    using Chains.Play.Web;
    using Ionic.Zip;
    using Services.Communication.Protocol;
    using Services.Packages;
    using Services.Packages.Client;
    using Services.Packages.Update;

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && (args[0] == "--update" || args[0] == Update.UpdatePackagesArgument))
            {
                // Check for update
                Console.WriteLine("Checking for update...");
                Update.CheckAndUpdate("update.msd.am", 12345, new[] { "Services.Packages.Tools" }, arguments: args);

                // If we reach this point the update has not closed this process
                Console.WriteLine("No update needed!");
                return;
            }

            // Start program
            if (args.Length != 1)
            {
                var examplePackageUploadData = new PackageDownloadData
                                               {
                                                   YourApiKey = "YourApiKey",
                                                   PackageFolder = @".\package\folder",
                                                   PackageNames = new[]
                                                                  {
                                                                      "Package.name.1",
                                                                      "Package.name.2",
                                                                      "Package.name.3"
                                                                  },
                                                   UpdateServerHostname = "localhost",
                                                   UpdateServerPort = 10999
                                               };

                Console.WriteLine("One argument is allowed of type JSON like:");
                Console.WriteLine("Services.Package.Download \"{0}\"", examplePackageUploadData.SerializeToJsonForCommandPrompt());
                return;
            }

            var packageDownloadData = Json<PackageDownloadData>.Deserialize(args[0]);

            Console.WriteLine("Connecting to server...");
            using (var updateServerConnection = new Client(packageDownloadData.UpdateServerHostname, packageDownloadData.UpdateServerPort).Do(new OpenConnection()))
            {
                if (!Directory.Exists(packageDownloadData.PackageFolder))
                {
                    Directory.CreateDirectory(packageDownloadData.PackageFolder);
                }

                var applicationRepository = new Repository(packageDownloadData.PackageFolder);

                foreach (var packageName in packageDownloadData.PackageNames)
                {
                    applicationRepository.RegisterPackage(packageName);
                }

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
                                ApiKey = packageDownloadData.YourApiKey
                            }));

                if (packagesToUpdate.Packages.Count > 0)
                {
                    Console.WriteLine("Found {0} updates!", packagesToUpdate.Packages.Count);

                    var downloadedPackages = new ConcurrentBag<DownloadPackageReturnData>();
                    Parallel.ForEach(packagesToUpdate.Packages,
                        x =>
                        {
                            downloadedPackages.Add(updateServerConnection.Do(new DownloadPackage(
                                new DownloadPackageData
                                {
                                    PackageRequested = x
                                })
                            {
                                ApiKey = packageDownloadData.YourApiKey
                            }));
                        });

                    Console.WriteLine("Zip files downloaded...");

                    foreach (var downloadedPackage in downloadedPackages)
                    {
                        using (var zipFile = ZipFile.Read(new MemoryStream(downloadedPackage.ZipFile)))
                        {
                            foreach (var zipEntry in zipFile)
                            {
                                zipEntry.Extract(packageDownloadData.PackageFolder, ExtractExistingFileAction.OverwriteSilently);
                            }
                        }

                        Console.WriteLine("Extracted package {0}, {1}...", downloadedPackage.PackageDownloaded.PackageName, downloadedPackage.PackageDownloaded.VersionLabel);
                    }

                    foreach (var downloadedPackage in downloadedPackages)
                    {
                        var localPackage = new LocalPackage(downloadedPackage.PackageDownloaded.PackageName);
                        localPackage.Id = downloadedPackage.PackageDownloaded.Id;
                        localPackage.VersionLabel = downloadedPackage.PackageDownloaded.VersionLabel;
                        localPackage.Update();

                        Console.WriteLine(
                            "Package {0}, {1} has been successfully installed",
                            localPackage.PackageName,
                            localPackage.VersionLabel);
                    }
                }
            }
        }
    }
}
