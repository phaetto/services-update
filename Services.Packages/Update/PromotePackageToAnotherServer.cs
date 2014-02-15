namespace Services.Packages.Update
{
    using System.IO;
    using Chains;
    using Chains.Play;
    using Chains.Play.Web;
    using Services.Communication.Protocol;

    public sealed class PromotePackageToAnotherServer : ReproducibleWithData<PromotePackageToAnotherServerData>,
        IChainableAction<Repository, Repository>
    {
        public PromotePackageToAnotherServer(PromotePackageToAnotherServerData data)
            : base(data)
        {
        }

        public Repository Act(Repository context)
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

            using (var connectionToOtherServer = new Client(Data.OtherServerHostname, Data.OtherServerPort).Do(new OpenConnection()))
            {
                var packageUploadData = new UploadPackageData
                                        {
                                            PackageToUpload = packageToUpdate,
                                            ZipData = File.ReadAllBytes(zipFile),
                                        };

                connectionToOtherServer.Do(new Send(new UploadPackage(packageUploadData)));
            }

            return context;
        }
    }
}
