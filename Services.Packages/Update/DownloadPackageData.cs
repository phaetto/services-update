namespace Services.Packages.Update
{
    using System;
    using Chains.Play;

    [Serializable]
    public sealed class DownloadPackageData : SerializableSpecification
    {
        public PackageDescription PackageRequested;

        public override int DataStructureVersionNumber
        {
            get
            {
                return 1;
            }
        }
    }
}
