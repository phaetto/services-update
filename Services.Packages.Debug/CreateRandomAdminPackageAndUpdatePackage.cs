namespace Services.Packages.Debug
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using Chains.Play.Web;
    using Services.Communication.Protocol;
    using Services.Management.Administration.Worker;
    using Services.Packages.Admin;
    using Services.Packages.Update;

    public sealed class CreateRandomAdminPackageAndUpdatePackage
    {
        private readonly string localHostname;

        private readonly int localPort;

        private readonly string remoteHostname;

        private readonly int remotePort;

        private readonly WorkUnitContext workUnitContext;

        private readonly Random random = new Random();

        public CreateRandomAdminPackageAndUpdatePackage(
            string localHostname,
            int localPort,
            string remoteHostname,
            int remotePort,
            WorkUnitContext workUnitContext)
        {
            this.localHostname = localHostname;
            this.localPort = localPort;
            this.remoteHostname = remoteHostname;
            this.remotePort = remotePort;
            this.workUnitContext = workUnitContext;
            ThreadPool.QueueUserWorkItem(DoWork);
        }

        private void DoWork(object state)
        {
            while (true)
            {
                workUnitContext.LogLine("Getting package from {0}:{1}", remoteHostname, remotePort);

                CheckPackagesForUpdateReturnData checkPackagesForUpdateReturnData = null;

                using (var connectionToOtherServer = new Client(remoteHostname, remotePort).Do(new OpenConnection()))
                {
                    workUnitContext.LogLine("Checking for packages to be updated (fixed to download the last versions)");

                    checkPackagesForUpdateReturnData =
                        connectionToOtherServer.Do(
                            new Send<CheckPackagesForUpdateReturnData>(
                                new CheckPackagesForUpdate(
                                    new CheckPackagesForUpdateData
                                    {
                                        Packages = new List<PackageDescription>
                                                   {
                                                       new PackageDescription
                                                       {
                                                           Id = 0,
                                                           PackageName =
                                                               WatchForAdminUpdate.ServicesExecutionerPackageName,
                                                       },

                                                       new PackageDescription
                                                       {
                                                           Id = 0,
                                                           PackageName = "Services.Update",
                                                       },
                                                   }
                                    })));

                    workUnitContext.LogLine(
                        "Done! {0} packages found!",
                        checkPackagesForUpdateReturnData.Packages.Count);

                    using (
                        var connectionToLocalServer =
                            new Client(localHostname, localPort).Do(new WaitUntilClientConnects()))
                    {
                        foreach (var package in checkPackagesForUpdateReturnData.Packages)
                        {
                            var randomMillisecondsBetweenPackages = random.Next(60000);

                            workUnitContext.LogLine("Waiting random {0}ms between packages...", randomMillisecondsBetweenPackages);
                            workUnitContext.ReportToAdmin();

                            Thread.Sleep(randomMillisecondsBetweenPackages);

                            workUnitContext.LogLine(
                                "Downloading {0} v {1} package...",
                                package.PackageName,
                                package.VersionLabel);

                            var downloadPackageReturnData =
                                connectionToOtherServer.Do(
                                    new Send<DownloadPackageReturnData>(
                                        new DownloadPackage(
                                            new DownloadPackageData
                                            {
                                                PackageRequested = package,
                                            })));

                            workUnitContext.LogLine(
                                "Uploading {0} v {1} package...",
                                package.PackageName,
                                package.VersionLabel);

                            var packageUploadData = new UploadPackageData
                                                    {
                                                        PackageToUpload = package,
                                                        ZipData = downloadPackageReturnData.ZipFile,
                                                    };

                            connectionToLocalServer.Do(new Send(new UploadPackage(packageUploadData)));
                        }
                    }
                }

                workUnitContext.LogLine("Upload done!");

                var randomMilliseconds = random.Next(120000) + 120000;

                workUnitContext.LogLine("Waiting {0}ms", randomMilliseconds);
                workUnitContext.ReportToAdmin();

                Thread.Sleep(randomMilliseconds);
            }
        }
    }
}
