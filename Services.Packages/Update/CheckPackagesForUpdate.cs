namespace Services.Packages.Update
{
    using System.Linq;
    using Chains.Play;
    using Chains.Play.Security;

    public sealed class CheckPackagesForUpdate :
        RemotableActionWithData<CheckPackagesForUpdateData, CheckPackagesForUpdateReturnData, Repository>,
        IApplicationAuthorizableAction
    {
        public CheckPackagesForUpdate(CheckPackagesForUpdateData data)
            : base(data)
        {
        }

        protected override CheckPackagesForUpdateReturnData ActRemotely(Repository context)
        {
            var returnData = new CheckPackagesForUpdateReturnData();

            foreach (var packageEntry in Data.Packages)
            {
                var packageToUpdate = VerifyPackageToUpdate(packageEntry);
                if (packageToUpdate != null)
                {
                    returnData.Packages.Add(packageToUpdate);
                }
            }

            return returnData;
        }

        internal static PackageDescription VerifyPackageToUpdate(PackageDescription packageEntry)
        {
            var packageInDb = Package.SearchByPackageName(packageEntry.PackageName).OrderByDescending(x => x.UploadDate).FirstOrDefault();

            // TODO: Find/Implement dependencies

            if (packageInDb != null && packageInDb.Id > packageEntry.Id)
            {
                return new PackageDescription
                       {
                           Id = packageInDb.Id,
                           PackageName = packageInDb.PackageName,
                           VersionLabel = packageInDb.VersionLabel,
                       };
            }

            return null;
        }

        public string ApiKey { get; set; }
    }
}
