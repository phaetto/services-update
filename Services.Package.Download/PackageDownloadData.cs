namespace Services.Package.Download
{
    using System;
    using Chains.Play;

    [Serializable]
    public sealed class PackageDownloadData : SerializableSpecification
    {
        public string UpdateServerHostname;

        public int UpdateServerPort;

        public string YourApiKey;

        public string PackageFolder;

        public string[] PackageNames;

        public override int DataStructureVersionNumber
        {
            get
            {
                return 1;
            }
        }
    }
}
