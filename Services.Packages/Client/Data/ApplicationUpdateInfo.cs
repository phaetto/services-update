namespace Services.Packages.Client.Data
{
    using System;
    using System.Collections.Generic;
    using Chains.Play;

    [Serializable]
    public sealed class ApplicationUpdateInfo : SerializableSpecification
    {
        public string ApplicationFolder;

        public List<string> OriginalArguments;

        public string OriginalProcessName;

        public override int DataStructureVersionNumber
        {
            get
            {
                return 1;
            }
        }
    }
}
