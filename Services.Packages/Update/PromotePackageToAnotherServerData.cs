namespace Services.Packages.Update
{
    using System;
    using Chains.Play;

    [Serializable]
    public sealed class PromotePackageToAnotherServerData : SerializableSpecification
    {
        public PackageDescription PackageRequested;

        public string OtherServerHostname;

        public int OtherServerPort;

        public override int DataStructureVersionNumber
        {
            get
            {
                return 1;
            }
        }
    }
}
