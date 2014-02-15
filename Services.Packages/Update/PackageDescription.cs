namespace Services.Packages.Update
{
    using System;

    [Serializable]
    public sealed class PackageDescription
    {
        public int Id;

        public string PackageName;

        public string VersionLabel;
    }
}
