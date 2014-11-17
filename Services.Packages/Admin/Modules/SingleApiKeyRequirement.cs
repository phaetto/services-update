namespace Services.Packages.Admin.Modules
{
    using System.Security;
    using Chains;
    using Chains.Play.Modules;
    using Chains.Play.Security;
    using Services.Packages.Update;

    public sealed class SingleApiKeyRequirement : Chain<SingleApiKeyRequirement>, IModuleRequirement
    {
        private readonly string apiKey;

        private readonly bool isOnlyUploadRestricted;

        public SingleApiKeyRequirement(string apiKey, bool isOnlyUploadRestricted)
        {
            this.apiKey = apiKey;
            this.isOnlyUploadRestricted = isOnlyUploadRestricted;
        }

        public bool CanExecute(object action)
        {
            var appSecurableAction = action as IApplicationAuthorizableAction;
            if (appSecurableAction == null)
            {
                return true;
            }

            var canBeChecked = false;

            canBeChecked = canBeChecked || isOnlyUploadRestricted && appSecurableAction is UploadPackage;
            canBeChecked = canBeChecked || !isOnlyUploadRestricted;

            if (canBeChecked && apiKey != appSecurableAction.ApiKey)
            {
                throw new SecurityException("Access denied.");
            }

            return true;
        }
    }
}
