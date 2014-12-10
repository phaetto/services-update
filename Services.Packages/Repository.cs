namespace Services.Packages
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Chains;
    using Chains.Play.Modules;
    using Platform.Runtime;
    using Platform.Runtime.Extensions.Xml;
    using Services.Management.Administration.Server;
    using Services.Management.Administration.Worker;
    using Services.Packages.Update;
    using Services.Communication.Protocol;

    public sealed class Repository : Chain<Repository>, IModular
    {
        public readonly WorkUnitContext workUnitContext;

        public List<AbstractChain> Modules { get; set; }

        public readonly string BaseFolder;

        public Repository(string baseFolder = null, WorkUnitContext workUnitContext = null)
        {
            this.workUnitContext = workUnitContext;
            BaseFolder = baseFolder;
            Modules = new List<AbstractChain>();

            if (string.IsNullOrWhiteSpace(baseFolder))
            {
                var adminData = workUnitContext.AdminServer.Do(new GetAdministratorData());

                baseFolder = adminData.DataFolder + "XmlDatabases" + Path.DirectorySeparatorChar
                    + workUnitContext.WorkerData.ServiceName + Path.DirectorySeparatorChar
                    + workUnitContext.WorkerData.Version + Path.DirectorySeparatorChar;
            }

            if (string.IsNullOrWhiteSpace(XmlConnection.SchemaPath))
            {
                XmlConnection.SchemaPath = AppDomain.CurrentDomain.BaseDirectory + "schema.dbxml";
                XmlConnection.UseMemoryOperationsOnly = false;
            }

            Platform.Module.Packages.ModuleSqlProviderType = SqlProviderType.Xml;
            Platform.Module.Packages.ModuleConnectionString = baseFolder + "services.packages.database.dbxml";

            if (workUnitContext != null)
            {
                var dbPackages = Package.SearchByPackageName("*");
                if (dbPackages.Count > 0)
                {
                    workUnitContext.LogLine("Repository has been initialized at '{0}'.", Sql.ConnectionString);

                    var packageInThisRepo = "Packages included in this repo:\n"
                        + string.Join("\n", dbPackages.Select(x => x.PackageName).Distinct()) + "\n";

                    workUnitContext.LogLine(packageInThisRepo);
                }

                var dbLocalPackages = LocalPackage.SearchByPackageName("*");
                if (dbLocalPackages.Count > 0)
                {
                    workUnitContext.LogLine("Application repo has loaded at '{0}'.", Sql.ConnectionString);

                    var packageInThisRepo = "Packages exist in this app:\n"
                        + string.Join("\n", dbLocalPackages.Select(x => x.PackageName).Distinct()) + "\n";

                    workUnitContext.LogLine(packageInThisRepo);
                }
            }
        }

        internal string ToFile(PackageDescription package)
        {
            return BaseFolder + "Repo" + Path.DirectorySeparatorChar + package.PackageName
                + Path.DirectorySeparatorChar + package.Id + "." + package.VersionLabel + ".zip";
        }

        public Repository RegisterPackage(string name)
        {
            name = name.Trim();

            var dbPackages = LocalPackage.SearchByPackageNamePaged(name, 0, 1);
            if (dbPackages.Count == 0)
            {
                new LocalPackage
                {
                    PackageName = name
                }.Create();

                if (workUnitContext != null)
                {
                    workUnitContext.LogLine("Package '{0}' has been registered.", name);
                }
            }

            return this;
        }
    }
}
