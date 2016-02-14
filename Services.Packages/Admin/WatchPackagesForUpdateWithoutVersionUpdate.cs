namespace Services.Packages.Admin
{
    using System;
    using System.Collections.Concurrent;
    using System.IO;
    using System.Linq;
    using System.Net.Sockets;
    using System.Threading;
    using System.Threading.Tasks;
    using Chains;
    using Chains.Play.Web;
    using Ionic.Zip;
    using Services.Communication.Protocol;
    using Services.Management.Administration.Server;
    using Services.Management.Administration.Update;
    using Services.Management.Administration.Worker;
    using Services.Packages.Update;

    public sealed class WatchPackagesForUpdateWithoutVersionUpdate : Chain<WatchPackagesForUpdateWithoutVersionUpdate>,
        IDisposable,
        IWorkerEvents
    {
        public readonly Thread checkThread = null;

        private readonly string hostname;

        private readonly int port;

        public readonly int secondsChecking;

        private ClientConnectionContext adminServer;

        private readonly WorkUnitContext workUnitContext;

        private readonly string[] packages;

        private readonly string[] services;

        public WatchPackagesForUpdateWithoutVersionUpdate(
            string hostname,
            int port,
            string commaSeparatedPackages,
            string commaSeparatedServices,
            int secondsChecking = 60,
            WorkUnitContext workUnitContext = null)
        {
            this.hostname = hostname;
            this.port = port;
            this.packages = commaSeparatedPackages.Split(new [] { ',' }).Select(x => x.Trim()).ToArray();
            this.services = commaSeparatedServices.Split(new[] { ',' }).Select(x => x.Trim()).ToArray();
            this.secondsChecking = secondsChecking;
            this.workUnitContext = workUnitContext;
            checkThread = new Thread(CheckFileSystemThread);
        }

        private void CheckFileSystemThread()
        {
            workUnitContext.LogLine(string.Format("Updater started looking at 'tcp://{0}:{1}'", hostname, port));

            var repo = new Repository(workUnitContext: workUnitContext);
            foreach (var package in packages)
            {
                repo.RegisterPackage(package);
            }

            var tempDir = string.Format(
                "{0}package-temp{1}",
                AppDomain.CurrentDomain.BaseDirectory,
                Path.DirectorySeparatorChar);

            while (true)
            {
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
                                        ApiKey = workUnitContext.ApiKey
                                    }));
                                });


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

                            workUnitContext.LogLine("Copying zip packages to services' repos from '{0}' (no version update)...", tempDir);

                            Parallel.ForEach(services,
                                x =>
                                {
                                    adminServer.Do(new ApplyServiceUpdateOnLastVersion(
                                        new UpdateWorkUnitData
                                        {
                                            ServiceName = x,
                                            UpdateFolderOrFile = tempDir,
                                        })
                                    {
                                        ApiKey = workUnitContext.ApiKey,
                                        Session = workUnitContext.Session,
                                    });
                                });

                            Directory.Delete(tempDir, true);

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
                        workUnitContext.CanStop = true;
                        Thread.Sleep(secondsChecking * 1000);
                    }
                }
                catch (SocketException)
                {
                    adminServer.Do(new RetryConnection());
                    workUnitContext.LogLine("Server down... Trying again later...");
                }
                catch (Exception exception)
                {
                    workUnitContext.LogException(exception);
                }

                workUnitContext.CanStop = true;
            }

            workUnitContext.LogLine("Waiting to restart...");

            Thread.Sleep(10 * 1000);

            workUnitContext.LogLine("Sending the restart signal...");

            adminServer.Do(new WaitUntilServerIsUp())
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
