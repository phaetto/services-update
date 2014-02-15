namespace Services.Packages.Update
{
    using System;
    using System.Collections.Generic;
    using Chains.Play;

    [Serializable]
    public sealed class CheckPackagesForUpdateReturnData : SerializableSpecification
    {
        public List<PackageDescription> Packages = new List<PackageDescription>();

        public override int DataStructureVersionNumber
        {
            get
            {
                return 1;
            }
        }
    }
}
