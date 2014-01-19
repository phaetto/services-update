namespace Services.Package.Upload
{
    using System;
    using System.IO;
    using Chains.Play;
    using Chains.Play.Web;
    using Ionic.Zip;
    using Services.Communication.Protocol;
    using Services.Packages.Client;
    using Services.Packages.Update;

    class Program
    {
        private const string ArchiveFilename = "package-temp.zip";

        static void Main(string[] args)
        {
            if (args.Length > 0 && (args[0] == "--update" || args[0] == Update.UpdatePackagesArgument))
            {
                // Check for update
                Console.WriteLine("Checking for update...");
                Update.CheckAndUpdate("update.msd.am", 12345, new[] { "Services.Packages.Tools" }, arguments: args);

                // If we reach this point the update has not closed this process
                Console.WriteLine("No update needed!");
                return;
            }

            // Start program
            if (args.Length != 1)
            {
                var examplePackageUploadData = new PackageUploadData
                                               {
                                                   YourApiKey = "YourApiKey",
                                                   PackageFolder = @".\package\folder",
                                                   PackageName = "Package.name",
                                                   PackageVersionLabel = "0.0.0.1",
                                                   UpdateServerHostname = "localhost",
                                                   UpdateServerPort = 10999
                                               };

                Console.WriteLine("One argument is allowed of type JSON like:");
                Console.WriteLine(string.Format("Services.Package.Upload \"{0}\"", examplePackageUploadData.SerializeToJsonForCommandPrompt()));
                return;
            }

            var packageUploadData = DeserializableSpecification<PackageUploadData>.DeserializeFromJson(args[0]);

            Console.WriteLine("Connecting to server...");
            using (var updateServer = new Client(packageUploadData.UpdateServerHostname, packageUploadData.UpdateServerPort).Do(new OpenConnection()))
            {
                Console.WriteLine("Zipping folder {0}...", packageUploadData.PackageFolder);
                using (var zip = new ZipFile())
                {
                    zip.AddDirectory(packageUploadData.PackageFolder);
                    zip.Save(ArchiveFilename);
                }

                Console.WriteLine("Uploading package...");
                updateServer.Do(
                    new Send(
                        new UploadPackage(
                            new UploadPackageData
                            {
                                PackageToUpload = new PackageDescription
                                                  {
                                                      PackageName = packageUploadData.PackageName,
                                                      VersionLabel = packageUploadData.PackageVersionLabel
                                                  },
                                ZipData = File.ReadAllBytes(ArchiveFilename)
                            })
                        {
                            ApiKey = packageUploadData.YourApiKey
                        }));

                File.Delete(ArchiveFilename);

                Console.WriteLine(
                    "Package {0}, {1} has been successfully uploaded to tcp://{2}:{3}",
                    packageUploadData.PackageName,
                    packageUploadData.PackageVersionLabel,
                    packageUploadData.UpdateServerHostname,
                    packageUploadData.UpdateServerPort);
            }
        }
    }
}
