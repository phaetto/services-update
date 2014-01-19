namespace Services.Packages.Client.Actions
{
    using Chains;
    using Chains.Play.Security;
    using Chains.Play.Web;
    using Services.Communication.Protocol;
    using Services.Packages.Update;

    public sealed class NeedsUpdate : IChainableAction<Repository, bool>, IApplicationAuthorizableAction
    {
        private readonly string hostname;

        private readonly int port;

        public string ApiKey { get; set; }

        public NeedsUpdate(string hostname, int port)
        {
            this.hostname = hostname;
            this.port = port;
        }

        public bool Act(Repository context)
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
                    return true;
                }
            }

            return false;
        }
    }
}
