namespace Services.Packages.Modules
{
    using System;
    using System.Security;
    using Chains;
    using Chains.Play.Modules;
    using Chains.Play.Security;

    public sealed class ApiKeyAuthorizationProvider : Chain<ApiKeyAuthorizationProvider>, IModuleRequirement
    {
        public bool CanExecute(object action)
        {
            var appAuthorizable = action as IApplicationAuthorizableAction;
            if (appAuthorizable == null)
            {
                return true;
            }

            var apiKey = new ApiKey(Guid.Parse(appAuthorizable.ApiKey));
            if (!apiKey.Exists)
            {
                throw new SecurityException("Access Denied");
            }

            return false;
        }
    }
}
