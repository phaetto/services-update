namespace MicroServicesStarter.Deploy
{
    using System.IO;
    using System.Xml;
    using Chains;
    using MicroServicesStarter.ServiceManagement;

    public sealed class DeploySetupContext : ChainWithParent<DeploySetupContext, AdminSetupContext>
    {
        public readonly string CurrentVersion;

        public readonly string NugetFolder;

        public readonly string UpdateFolder;

        public readonly string NugetApiKey;

        public readonly string NugetServer;

        public readonly string UpdateHost;

        public readonly int UpdatePort;

        public readonly string UpdateApiKey;

        public DeploySetupContext(
            AdminSetupContext adminSetupContext)
            : base(adminSetupContext)
        {
            var versionFile = string.Format("{0}version.txt", adminSetupContext.SolutionDirectory);
            var xmlOptionsFile = string.Format("{0}options.xml", adminSetupContext.SolutionDirectory);

            if (!File.Exists(versionFile))
            {
                File.WriteAllText(versionFile, "0.0.0.0");
            }

            CurrentVersion = File.ReadAllText(versionFile);

            NugetFolder = string.Format(@"{0}Nuget\", Parent.SolutionDirectory);
            UpdateFolder = string.Format(@"{0}Update\", Parent.SolutionDirectory);

            if (!File.Exists(xmlOptionsFile))
            {
                File.WriteAllText(xmlOptionsFile, "<?xml version=\"1.0\" encoding=\"utf-8\" ?><options><nuget api-key=\"\" server=\"https://www.nuget.org/\" /><update host=\"\" port=\"\" api-key=\"\" /></options>");
            }

            var optionsXmlDocument = new XmlDocument();
            optionsXmlDocument.Load(xmlOptionsFile);

            var nugetNode = optionsXmlDocument.SelectSingleNode("/options/nuget");
            if (nugetNode != null)
            {
                NugetApiKey = nugetNode.Attributes["api-key"].Value;
                NugetServer = nugetNode.Attributes["server"].Value;
            }

            var updateNode = optionsXmlDocument.SelectSingleNode("/options/update");
            if (updateNode != null)
            {
                UpdateApiKey = updateNode.Attributes["api-key"].Value;
                UpdateHost = updateNode.Attributes["host"].Value;
                UpdatePort = int.Parse(updateNode.Attributes["port"].Value);
            }
        }

        public DeploySetupContext LogToUi(string text)
        {
            Parent.LogToUi(text);
            return this;
        }
    }
}
