namespace Services.Packages.Client
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using Chains.Play;
    using Services.Packages.Client.Actions;
    using Services.Packages.Client.Data;

    public static class Update
    {
        public const string UpdatePackagesArgument = "--update-packages";

        public static void CheckAndUpdate(
            string hostname,
            int port,
            string[] packages,
            string apiKey = null,
            string[] arguments = null,
            bool restartApplication = false)
        {
            if (arguments != null && arguments.Length == 2 && arguments[0] == UpdatePackagesArgument)
            {
                // The application has requested an update
                var sentExecutableActionSpecification = DeserializableSpecification<ExecutableActionSpecification>.DeserializeFromJson(arguments[1]);
                var originalApplicationUpdateInfo = sentExecutableActionSpecification.Data as ApplicationUpdateInfo;

                var applicationRepository = new Repository(originalApplicationUpdateInfo.ApplicationFolder);

                // Update directly to application folder
                applicationRepository.Do(new UpdateClientApplication(hostname, port, originalApplicationUpdateInfo.ApplicationFolder)
                                         {
                                             ApiKey = apiKey
                                         });

                if (restartApplication)
                {
                    // Restart the application
                    Process.Start(
                        new ProcessStartInfo
                        {
                            FileName =
                                originalApplicationUpdateInfo.ApplicationFolder
                                    + originalApplicationUpdateInfo.OriginalProcessName,
                            Arguments = string.Join(" ", originalApplicationUpdateInfo.OriginalArguments),
                            WorkingDirectory = originalApplicationUpdateInfo.ApplicationFolder,
                        });

                    Process.GetCurrentProcess().Kill();
                }

                return;
            }

            var repository = new Repository(AppDomain.CurrentDomain.BaseDirectory);

            foreach (var package in packages)
            {
                repository.RegisterPackage(package);
            }

            if (!repository.Do(
                new NeedsUpdate(hostname, port)
                {
                    ApiKey = apiKey
                }))
            {
                return;
            }

            // Process must be updated
            var processName = Path.GetFileName(Environment.GetCommandLineArgs()[0]);
                
            // Copy the application files to new temp folder
            var tempFolder = Path.GetTempPath() + processName + Path.DirectorySeparatorChar;

            if (Directory.Exists(tempFolder))
            {
                Directory.Delete(tempFolder, true);
            }

            Directory.CreateDirectory(tempFolder);
            var files = Directory.EnumerateFiles(AppDomain.CurrentDomain.BaseDirectory);
            foreach (var file in files)
            {
                File.Copy(file, tempFolder + Path.GetFileName(file));
            }

            if (arguments == null)
            {
                arguments = new string[0];
            }

            // Start the update and close process
            var applicationUpdateInfo = new ApplicationUpdateInfo
                                        {
                                            ApplicationFolder = AppDomain.CurrentDomain.BaseDirectory,
                                            OriginalProcessName = processName,
                                            OriginalArguments = arguments.ToList(),
                                        };

            var cmdArguments = UpdatePackagesArgument + " \""
                + applicationUpdateInfo.AsSpecification().SerializeToJsonForCommandPrompt()
                + "\"";

            Process.Start(
                new ProcessStartInfo
                {
                    FileName = tempFolder + applicationUpdateInfo.OriginalProcessName,
                    Arguments = cmdArguments,
                    WorkingDirectory = tempFolder,
                    UseShellExecute = true,
                    CreateNoWindow = true,
                    RedirectStandardInput = false,
                    RedirectStandardOutput = false,
                    RedirectStandardError = false,
                });

            Process.GetCurrentProcess().Kill();
        }
    }
}
