namespace Services.Packages.Admin
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Net.Sockets;
    using System.Threading;
    using Chains;
    using Chains.Play.Web;
    using Ionic.Zip;
    using Services.Communication.Protocol;
    using Services.Management.Administration.Server;
    using Services.Management.Administration.Update;
    using Services.Management.Administration.Worker;
    using Services.Packages.Update;

    public sealed class WatchForAdminUpdate : Chain<WatchFilesystemForAdminUpdate>,
        IDisposable,
        IWorkerEvents
    {
        public const string ServicesExecutionerPackageName = "Services.Executioner";

        public readonly Thread checkThread = null;

        private readonly string hostname;

        private readonly int port;

        public readonly int secondsChecking;

        private ClientConnectionContext adminServer;

        private readonly WorkUnitContext workUnitContext;

        public WatchForAdminUpdate(string hostname, int port, int secondsChecking = 60, WorkUnitContext workUnitContext = null)
        {
            this.hostname = hostname;
            this.port = port;
            this.secondsChecking = secondsChecking;
            this.workUnitContext = workUnitContext;
            checkThread = new Thread(CheckFileSystemThread);
        }

        private void CheckFileSystemThread()
        {
            workUnitContext.LogLine(string.Format("Updater started looking at 'tcp://{0}:{1}'", hostname, port));

            new Repository(workUnitContext: workUnitContext).RegisterPackage(ServicesExecutionerPackageName);

            var tempDir = string.Format(
                "{0}admin-temp{1}",
                AppDomain.CurrentDomain.BaseDirectory,
                Path.DirectorySeparatorChar);

            var serverDateTimeStarted = DateTime.MinValue;

            while (true)
            {
                if (Directory.Exists(tempDir))
                {
                    Directory.Delete(tempDir, true);
                }

                try
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
                                        ApiKey = workUnitContext.ApiKey
                                    }));

                        if (packagesToUpdate.Packages.Count > 0)
                        {
                            workUnitContext.CanStop = false;

                            workUnitContext.LogLine(
                                string.Format(
                                    "Found #{0} new update(s)! Starting process...", packagesToUpdate.Packages.Count));

                            // Start download process
                            workUnitContext.LogLine("Downloading packages...");

                            var downloadedPackages =
                                updateServerConnection.DoParallelFor(
                                    packagesToUpdate.Packages.Select(
                                        x =>
                                            new Send<DownloadPackageReturnData>(
                                                new DownloadPackage(
                                                    new DownloadPackageData
                                                    {
                                                        PackageRequested = x
                                                    })
                                                {
                                                    ApiKey = workUnitContext.ApiKey
                                                }))
                                                .ToArray<IChainableAction<ClientConnectionContext, DownloadPackageReturnData>>())
                                                .ToArray();


                            workUnitContext.LogLine("Unzipping packages...");

                            Directory.CreateDirectory(tempDir);

                            foreach (var downloadedPackage in downloadedPackages)
                            {
                                using (var zipFile = ZipFile.Read(new MemoryStream(downloadedPackage.ZipFile)))
                                {
                                    foreach (var zipEntry in zipFile)
                                    {
                                        zipEntry.Extract(tempDir, ExtractExistingFileAction.OverwriteSilently);
                                    }
                                }
                            }

                            workUnitContext.LogLine("Sending signal to admin to update from '{0}'...", tempDir);

                            serverDateTimeStarted =
                                adminServer.Do(new Send<AdministrationData>(new GetAdministratorData())).StartedOn;

                            adminServer.Do(
                                new Send(
                                    new ApplyAdminUpdate(tempDir)
                                    {
                                        ApiKey = workUnitContext.ApiKey,
                                        Session = workUnitContext.Session
                                    }));

                            workUnitContext.LogLine("Registering new versions...");

                            foreach (var downloadedPackage in downloadedPackages)
                            {
                                var localPackage = new LocalPackage(downloadedPackage.PackageDownloaded.PackageName);
                                localPackage.Id = downloadedPackage.PackageDownloaded.Id;
                                localPackage.VersionLabel = downloadedPackage.PackageDownloaded.VersionLabel;
                                localPackage.Update();
                            }

                            break;
                        }

                        workUnitContext.LogLine("Next update date: {0} (utc)", DateTime.UtcNow.AddSeconds(secondsChecking));
                        Thread.Sleep(secondsChecking * 1000);
                    }
                }
                catch (SocketException)
                {
                    adminServer.Do(new RetryConnection());
                    workUnitContext.LogLine("Server down... Trying again later...");
                    Thread.Sleep(1000);
                }
                catch (Exception exception)
                {
                    workUnitContext.LogException(exception);
                    Thread.Sleep(1000);
                }

                workUnitContext.CanStop = true;
            }

            workUnitContext.LogLine("Now, waiting for the new admin instance to come up...");

            adminServer.Do(new WaitUntilNewAdminServerIsUp(serverDateTimeStarted))
                       .Do(
                           new Send(
                               new StartWorkerProcessWithDelay(
                                   new WorkerDataWithDelay
                                   {
                                       WorkerData = workUnitContext.WorkerData,
                                       DelayInSeconds = 10
                                   })
                               {
                                   ApiKey = workUnitContext.ApiKey,
                                   Session = workUnitContext.Session
                               }));

            workUnitContext.CanStop = true;
            workUnitContext.Stop();
        }

        public void Dispose()
        {
            try
            {
                adminServer.Close();
            }
            catch
            {
            }

            try
            {
                checkThread.Abort();
            }
            catch
            {
            }
        }

        public void OnStart()
        {
            adminServer =
                new Client(workUnitContext.WorkerData.AdminHost, workUnitContext.WorkerData.AdminPort).Do(
                    new OpenConnection());

            checkThread.Start();
        }

        public void OnStop()
        {
            checkThread.Abort();
        }
    }
}
