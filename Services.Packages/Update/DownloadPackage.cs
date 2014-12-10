namespace Services.Packages.Update
{
    using System.IO;
    using Chains.Play;
    using Chains.Play.Security;

    public sealed class DownloadPackage : RemotableActionWithData<DownloadPackageData, DownloadPackageReturnData,Repository>, IApplicationAuthorizableAction
    {
        public string ApiKey { get; set; }

        public DownloadPackage(DownloadPackageData data)
            : base(data)
        {
        }

        public override DownloadPackageReturnData Act(Repository context)
        {
            var packageInDb = new Package(Data.PackageRequested.Id);

            if (!packageInDb.Exists)
            {
                throw new InvalidDataException("The package could not be found in this database.");
            }

            var packageToUpdate = new PackageDescription
            {
                Id = packageInDb.Id,
                PackageName = packageInDb.PackageName,
                VersionLabel = packageInDb.VersionLabel,
            };

            var zipFile = context.ToFile(packageToUpdate);

            if (!File.Exists(zipFile))
            {
                throw new FileNotFoundException("The zip package does not exist in the repository.");
            }

            return new DownloadPackageReturnData
                   {
                       PackageDownloaded = packageToUpdate,
                       ZipFile = File.ReadAllBytes(zipFile)
                   };
        }
    }
}
