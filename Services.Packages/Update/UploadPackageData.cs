namespace Services.Packages.Update
{
    using System;
    using Chains.Play;

    [Serializable]
    public sealed class UploadPackageData : SerializableSpecification
    {
        public PackageDescription PackageToUpload;

        public byte[] ZipData;

        public override int DataStructureVersionNumber
        {
            get
            {
                return 1;
            }
        }
    }
}
