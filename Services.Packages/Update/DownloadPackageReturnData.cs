namespace Services.Packages.Update
{
    using System;
    using Chains.Play;

    [Serializable]
    public sealed class DownloadPackageReturnData : SerializableSpecification
    {
        public PackageDescription PackageDownloaded;

        public byte[] ZipFile;

        public override int DataStructureVersionNumber
        {
            get
            {
                return 1;
            }
        }
    }
}
