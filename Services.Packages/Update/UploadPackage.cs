namespace Services.Packages.Update
{
    using System;
    using System.IO;
    using Chains;
    using Chains.Play;
    using Chains.Play.Security;

    public sealed class UploadPackage : ReproducibleWithData<UploadPackageData>,
        IChainableAction<Repository, Repository>,
        IApplicationAuthorizableAction
    {
        public string ApiKey { get; set; }

        public UploadPackage(UploadPackageData data)
            : base(data)
        {
        }

        public Repository Act(Repository context)
        {
            var packageInDb = new Package
                              {
                                  PackageName = Data.PackageToUpload.PackageName,
                                  VersionLabel = Data.PackageToUpload.VersionLabel,
                                  UploadDate = DateTime.UtcNow,
                              };
            packageInDb.Create();

            var zipFile = context.ToFile(
                new PackageDescription
                {
                    PackageName = packageInDb.PackageName,
                    VersionLabel = packageInDb.VersionLabel,
                    Id = packageInDb.Id
                });

            if (File.Exists(zipFile))
            {
                File.Delete(zipFile);
            }

            var zipDirectory = Path.GetDirectoryName(zipFile);
            if (!Directory.Exists(zipDirectory))
            {
                Directory.CreateDirectory(zipDirectory);
            }

            File.WriteAllBytes(zipFile, Data.ZipData);

            if (context.workUnitContext != null)
            {
                context.workUnitContext.LogLine("Package " + packageInDb.PackageName
                    + " uploaded with version " + packageInDb.VersionLabel);
            }

            return context;
        }
    }
}
