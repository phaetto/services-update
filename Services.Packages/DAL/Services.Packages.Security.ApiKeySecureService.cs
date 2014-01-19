using System;
using System.Collections.Generic;
using System.Text;
using Platform.Runtime;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Web.Services;
using Services.Packages.Security;

/*
 * High performance automated object model (security part)
 * Created by an automatic tool
 * */

namespace Services.Packages.Security
{	
	/// <summary>
    /// Defines the secure contract for all the service-based types which can
    /// apply servicing on Services.Packages.ApiKey type.
    /// </summary>
    [ComVisible(true)]
    [Guid("4761f85f-ee22-ed78-1355-f7092d39a891")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IApiKeySecureService
    {
		#region Securable interface definitions
        void EnableDisableSecurity(bool secure, string sessionToken);
        
        string[] GetUserRightDescriptors();
        bool HasRights(string userName, string userRightDescriptor, string SessionToken);
		void ChangeRights(string userName, string userRightDescriptor, bool allow, string SessionToken);
		void ChangeAccess(Services.Packages.ApiKey _object, string userName, string securityDescriptor, bool allow, string SessionToken);
		bool HasAccess(Services.Packages.ApiKey _object, string userName, string securityDescriptor, string SessionToken);
        
        void SetObjectOwner(Services.Packages.ApiKey _object, string userName, string SessionToken);
        void SetDatabaseOwner(string userName);
        
        string[] GetSecurityDescriptors();
        void AllowTraverse(Services.Packages.ApiKey _object, string userName, string SessionToken);
        void AllowRead(Services.Packages.ApiKey _object, string userName, string SessionToken);
        void AllowUpdate(Services.Packages.ApiKey _object, string userName, string SessionToken);
        void AllowCreate(Services.Packages.ApiKey _object, string userName, string SessionToken);
        void AllowReadAccess(Services.Packages.ApiKey _object, string userName, string SessionToken);
        void AllowChangeAccess(Services.Packages.ApiKey _object, string userName, string SessionToken);
        bool HasTraverse(Services.Packages.ApiKey _object, string userName, string SessionToken);
        bool HasRead(Services.Packages.ApiKey _object, string userName, string SessionToken);
        bool HasUpdate(Services.Packages.ApiKey _object, string userName, string SessionToken);
        bool HasCreate(Services.Packages.ApiKey _object, string userName, string SessionToken);
        bool HasReadAccess(Services.Packages.ApiKey _object, string userName, string SessionToken);
        bool HasChangeAccess(Services.Packages.ApiKey _object, string userName, string SessionToken);
        void DisallowTraverse(Services.Packages.ApiKey _object, string userName, string SessionToken);
        void DisallowRead(Services.Packages.ApiKey _object, string userName, string SessionToken);
        void DisallowUpdate(Services.Packages.ApiKey _object, string userName, string SessionToken);
        void DisallowCreate(Services.Packages.ApiKey _object, string userName, string SessionToken);
        void DisallowReadAccess(Services.Packages.ApiKey _object, string userName, string SessionToken);
        void DisallowChangeAccess(Services.Packages.ApiKey _object, string userName, string SessionToken);
        
        void AllowAllTraverse(string userName, string SessionToken);
        void AllowAllRead(string userName, string SessionToken);
        void AllowAllUpdate(string userName, string SessionToken);
        void AllowAllCreate(string userName, string SessionToken);
        void AllowAllReadAccess(string userName, string SessionToken);
        void AllowAllChangeAccess(string userName, string SessionToken);
        bool HasAllTraverse(string userName, string SessionToken);
        bool HasAllRead(string userName, string SessionToken);
        bool HasAllUpdate(string userName, string SessionToken);
        bool HasAllCreate(string userName, string SessionToken);
        bool HasAllReadAccess(string userName, string SessionToken);
        bool HasAllChangeAccess(string userName, string SessionToken);
        void DisallowAllTraverse(string userName, string SessionToken);
        void DisallowAllRead(string userName, string SessionToken);
        void DisallowAllUpdate(string userName, string SessionToken);
        void DisallowAllCreate(string userName, string SessionToken);
        void DisallowAllReadAccess(string userName, string SessionToken);
        void DisallowAllChangeAccess(string userName, string SessionToken);
        
        string LoginAnonymous();
        string Login(string userName, string password);
        void SwitchUser(string userName, string password, string existingSessionToken);
        bool SessionExists(string sessionToken);
        void LogoutSession(string sessionToken, bool keepSession);
        void LogoutAllSessions(string userName, string SessionToken);
        
        ModelUser GetCurrentUser(string SessionToken);
        ModelUser GetUser(string userName, string SessionToken);
        void SetUserByObject(ModelUser userObject, string SessionToken);
        void AddUser(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken);
        void UpdateUser(string userName, string oldPassword, string email, string secretQuestion,
            string secretAnswer, string SessionToken);
        void UpdateUserWithEnable(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken);
        void DeleteUser(string userName, string SessionToken);
        void ChangePassword(string userName, string oldPassword, string newPassword, string SessionToken);
        string CreateRandomPassword(string userName, string answer, string SessionToken);
        
        Securable GetSecurable(string SessionToken);
		#endregion
		
		string Uri { get; set; }

		[OperationContract]
        bool Exists(ApiKey _ApiKey, string SessionToken);
		[OperationContract]
        ApiKey Read(System.Guid __Id, string SessionToken);
        [OperationContract]
        ApiKey Reload(ApiKey _ApiKey, string SessionToken);
        [OperationContract]
        ApiKey Create(System.Guid __Id, string SessionToken);
        [OperationContract]
        void Delete(System.Guid __Id, string SessionToken);
        [OperationContract]
        void UpdateObject(ApiKey _ApiKey, string SessionToken);
        [OperationContract]
        void CreateObject(ApiKey _ApiKey, string SessionToken);
        [OperationContract]
        void DeleteObject(ApiKey _ApiKey, string SessionToken);
        [OperationContract]
        void Undo(string SessionToken);
        [OperationContract]
        void Redo(string SessionToken);
        		
		[OperationContract]
        ApiKey CreateFromCustomer(System.Guid __Id, Services.Packages.Customer _Customer, string SessionToken);
        [OperationContract]
        void CreateObjectFromCustomer(ApiKey _ApiKey, Services.Packages.Customer _Customer, string SessionToken);
        [OperationContract]
        void AllowCreateFromCustomer(Services.Packages.Customer _Customer, string userName, string SessionToken);
		[OperationContract]
        bool HasCreateFromCustomer(Services.Packages.Customer _Customer, string userName, string SessionToken);
        [OperationContract]
        void DisallowCreateFromCustomer(Services.Packages.Customer _Customer, string userName, string SessionToken);
		
		[OperationContract]
        ApiKey CreateFromOwner(System.Guid __Id, Services.Packages.Security.ModelUser _Owner, string SessionToken);
        [OperationContract]
        void CreateObjectFromOwner(ApiKey _ApiKey, Services.Packages.Security.ModelUser _Owner, string SessionToken);
        [OperationContract]
        void AllowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken);
		[OperationContract]
        bool HasCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken);
        [OperationContract]
        void DisallowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken);

		[OperationContract]
		ApiKeyCollection GetByCustomer(Services.Packages.Customer _Customer, string SessionToken);
		[OperationContract]
		ApiKeyCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long GetByCustomerCount(Services.Packages.Customer _Customer, string SessionToken);
		[OperationContract]
		Services.Packages.Customer GetCustomer(ApiKey _ApiKey, string SessionToken);
		[OperationContract]
		void SetCustomer(ApiKey _ApiKey, Services.Packages.Customer _Customer, string SessionToken);
		[OperationContract]
		ApiKeyCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		ApiKeyCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		Services.Packages.Security.ModelUser GetOwner(ApiKey _ApiKey, string SessionToken);
		[OperationContract]
		void SetOwner(ApiKey _ApiKey, Services.Packages.Security.ModelUser _Owner, string SessionToken);
		[OperationContract]
		ApiKeyCollection SearchByCompanyInfo(System.String CompanyInfo , string SessionToken);
		[OperationContract]
		ApiKeyCollection SearchByCompanyInfoPaged(System.String CompanyInfo , long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long SearchByCompanyInfoCount(System.String CompanyInfo , string SessionToken);
		[OperationContract]
		ApiKeyCollection SearchByCompanyInfoOnCustomer(System.String CompanyInfo, Services.Packages.Customer _Customer, string SessionToken);
		[OperationContract]
		ApiKeyCollection SearchByCompanyInfoOnCustomerPaged(System.String CompanyInfo, Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long SearchByCompanyInfoOnCustomerCount(System.String CompanyInfo, Services.Packages.Customer _Customer, string SessionToken);
		[OperationContract]
		Services.Packages.PackageCollection GetPackagesUploaded(ApiKey _ApiKey, string SessionToken);
		[OperationContract]
		void SetPackagesUploaded(ApiKey _ApiKey, Services.Packages.PackageCollection _PackagesUploaded, string SessionToken);
		[OperationContract]
		Services.Packages.Log.ApplicationExceptionCollection GetApplicationExceptionsLogged(ApiKey _ApiKey, string SessionToken);
		[OperationContract]
		void SetApplicationExceptionsLogged(ApiKey _ApiKey, Services.Packages.Log.ApplicationExceptionCollection _ApplicationExceptionsLogged, string SessionToken);
		[OperationContract]
		Services.Packages.PurchaseCollection GetOrders(ApiKey _ApiKey, string SessionToken);
		[OperationContract]
		void SetOrders(ApiKey _ApiKey, Services.Packages.PurchaseCollection _Orders, string SessionToken);
		[OperationContract]
		Services.Packages.Security.ApiKeyAccessControlListCollection GetACLs(ApiKey _ApiKey, string SessionToken);
		[OperationContract]
		void SetACLs(ApiKey _ApiKey, Services.Packages.Security.ApiKeyAccessControlListCollection _ACLs, string SessionToken);

    }
    
    /// <summary>
    /// WCF and default secure implementation of a service object for Services.Packages.ApiKey type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("90b86df6-0e7f-2911-8763-e230b30da218")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class ApiKeySecureService : IApiKeySecureService
    {
		#region Securable persistence

        internal static bool IsSecurableImp
        {
            get
            {
                Securable s = new Securable(typeof(ApiKeySecureService).FullName);
                if (s.Exists)
					return s.Enabled;
				
				SetupImp();
				return true;
            }
        }
        
        #endregion
        
        #region Checking security

        internal static void EnableDisableSecurityImp(bool secure, string sessionToken)
        {
			ModelSession session = CheckSessionImp(sessionToken);
			
            // Check access "TakeSecurityOffline"
            if (!CheckUserRightsImp(session.User.Name, "TakeSecurityOffline"))
				throw new UnauthorizedAccessException("Access Denied");

            Securable s = new Securable(typeof(ApiKeySecureService).FullName);
            s.Enabled = secure;
            s.Update();
        }
        
        internal static string[] GetUserRightDescriptorsImp()
        {
			return new string[] { "Owner", "ManageApplication", "ManageUsers", "ManageDataAccess", "CannotBeDisabled" };
        }
        
        internal static bool HasRightsImp(string userName, string userRightDescriptor, string SessionToken)
        {
			ModelSession session = CheckSessionImp(SessionToken);
			
            return CheckUserRightsImp(userName, userRightDescriptor.ToLowerInvariant());
        }
        
        internal static void ChangeRightsImp(string userName, string userRightDescriptor, bool allow, string SessionToken)
        {
			ModelSession session = CheckSessionImp(SessionToken);
			
            if (CheckUserRightsImp(session.User.Name, "ManageDataAccess"))
            {
				if (allow)
				{
					if (userRightDescriptor.ToLowerInvariant() == "owner")
					{
						if (!CheckUserRightsImp(session.User.Name, "owner"))
						{
							throw new UnauthorizedAccessException("Access Denied");
						}
						else
						{
							new ModelUserRights("owner", session.User.Name).Delete();
						}
					}
					
					ModelUserRights ur = new ModelUserRights(userRightDescriptor.ToLowerInvariant(), userName);
					ur.Create();
					return;
				}
				else
				{
					ModelUserRights ur = new ModelUserRights(userRightDescriptor.ToLowerInvariant(), userName);
					ur.Delete();
					return;
				}
			}
			
			throw new UnauthorizedAccessException("Access Denied");
        }
		
		internal static void ChangeAccessImp(Services.Packages.ApiKey _object, string userName, string securityDescriptor, bool allow, string SessionToken)
		{
			// Check if user can do that
            ModelSession session = CheckSessionImp(SessionToken);

            if (CheckAccessImp(_object, SessionToken, "ChangeAccess"))
            {
                try
                {
                    ApiKeyAccessControlListCollection acls = _object.GetACLs(userName);
                    ApiKeyAccessControlList acl;

                    if (acls.Count == 0)
                    {
                        acl = new ApiKeyAccessControlList();
                        acl.UserName = userName;
                        acl.ApiKey = _object;
                        acl.Create();
                    }
                    else
                    {
                        acl = acls[0];
                    }

                    ApiKeyAccessControlEntry entry = new ApiKeyAccessControlEntry();
                    entry.Descriptor = securityDescriptor.ToLowerInvariant();
                    entry.UserName = userName;
                    entry.Allow = allow;
                    entry.ACL = acl;
                    entry.Create();

                    return;
                }
                catch
                {
                }
            }
			
			throw new UnauthorizedAccessException("Access Denied");
		}
        
        internal static void SetOwnerImp(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			if (CheckAccessImp(_object, SessionToken, "ChangeAccess"))
            {
				ModelUser mu = new ModelUser(userName);
				if (!mu.Exists)
					throw new InvalidOperationException("User does not exist in this context.");
				
				_object.Owner = mu;
				_object.Update();
				return;
            }
            
			throw new UnauthorizedAccessException("Access Denied");
        }
		
		internal static bool IsFirstTimeUsedImp
		{
			get
			{
				// This is after the installation of the application
                ModelUserRightsCollection rights = ModelUserRights.GetByName("owner");
				return ( rights.Count == 0 || (rights.Count == 1 && rights[0].UserName == "Everyone"));
			}
		}

        internal static void SetDatabaseOwnerImp(string userName)
        {
			if (IsFirstTimeUsedImp)
			{
                SetupImp();
                
                ModelUserRightsCollection rights = ModelUserRights.GetByName("owner");
                foreach(ModelUserRights mur in rights)
					mur.Delete();
				
				ModelUserRights ur = new ModelUserRights("owner", userName);
				ur.Create();
				return;
			}
			
			throw new UnauthorizedAccessException("Access Denied");
        }
        
        #endregion
        
        #region Default provided descriptor abstractions (read, write, create ...)
        
        internal static string[] GetSecurityDescriptorsImp()
        {
			return new string[] { "Traverse", "Read", "Update", "Delete", "ReadAccess", "ChangeAccess" };
        }

		// Allow
		
        internal static void AllowTraverseImp(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Traverse", true, SessionToken);
        }

        internal static void AllowReadImp(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Read", true, SessionToken);
        }

        internal static void AllowUpdateImp(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Update", true, SessionToken);
        }

        internal static void AllowCreateImp(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
            // ChangeAccessImp(_object, userName, "Create " + typeof(Services.Packages.ApiKey).FullName, true, SessionToken);
            throw new NotImplementedException();
        }

        internal static void AllowReadAccessImp(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "ReadAccess", true, SessionToken);
        }

        internal static void AllowChangeAccessImp(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "ChangeAccess", true, SessionToken);
        }
        
        // Security check
		
        internal static bool HasTraverseImp(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			return HasAccessImp(_object, userName, "Traverse", SessionToken);
		}

        internal static bool HasReadImp(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			return HasAccessImp(_object, userName, "Read", SessionToken);
		}

        internal static bool HasUpdateImp(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
            return HasAccessImp(_object, userName, "Update", SessionToken);
		}

        internal static bool HasCreateImp(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
            // ChangeAccessImp(_object, userName, "Create " + typeof(Services.Packages.ApiKey).FullName, true, SessionToken);
            throw new NotImplementedException();
        }

        internal static bool HasReadAccessImp(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
            return HasAccessImp(_object, userName, "ReadAccess", SessionToken);
        }

        internal static bool HasChangeAccessImp(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
            return HasAccessImp(_object, userName, "ChangeAccess", SessionToken);
        }
        
        // Disallow
        
        internal static void DisallowTraverseImp(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Traverse", false, SessionToken);
        }

        internal static void DisallowReadImp(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Read", false, SessionToken);
        }

        internal static void DisallowUpdateImp(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Update", false, SessionToken);
        }

        internal static void DisallowCreateImp(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
            // ChangeAccessImp(_object, userName, "Create " + typeof(Services.Packages.ApiKey).FullName, false, SessionToken);
            throw new NotImplementedException();
        }

        internal static void DisallowReadAccessImp(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "ReadAccess", false, SessionToken);
        }

        internal static void DisallowChangeAccessImp(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "ChangeAccess", false, SessionToken);
        }
        
        // General object security methods
        
        internal static void AllowAllTraverseImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Traverse " + typeof(Services.Packages.ApiKey).FullName, true, SessionToken);
        }
        
        internal static void AllowAllReadImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Read " + typeof(Services.Packages.ApiKey).FullName, true, SessionToken);
        }
        
        internal static void AllowAllUpdateImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Update " + typeof(Services.Packages.ApiKey).FullName, true, SessionToken);
        }
        
        internal static void AllowAllCreateImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Create " + typeof(Services.Packages.ApiKey).FullName, true, SessionToken);
        }
        
        internal static void AllowAllReadAccessImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "ReadAccess " + typeof(Services.Packages.ApiKey).FullName, true, SessionToken);
        }
        
        internal static void AllowAllChangeAccessImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "ChangeAccess " + typeof(Services.Packages.ApiKey).FullName, true, SessionToken);
        }
        
        internal static bool HasAllTraverseImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "Traverse " + typeof(Services.Packages.ApiKey).FullName, SessionToken);
        }
        
        internal static bool HasAllReadImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "Read " + typeof(Services.Packages.ApiKey).FullName, SessionToken);
        }
        
        internal static bool HasAllUpdateImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "Update " + typeof(Services.Packages.ApiKey).FullName, SessionToken);
        }
        
        internal static bool HasAllCreateImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "Create " + typeof(Services.Packages.ApiKey).FullName, SessionToken);
        }
        
        internal static bool HasAllReadAccessImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "ReadAccess " + typeof(Services.Packages.ApiKey).FullName, SessionToken);
        }
        
        internal static bool HasAllChangeAccessImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "ChangeAccess " + typeof(Services.Packages.ApiKey).FullName, SessionToken);
        }
        
        internal static void DisallowAllTraverseImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Traverse " + typeof(Services.Packages.ApiKey).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllReadImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Read " + typeof(Services.Packages.ApiKey).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllUpdateImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Update " + typeof(Services.Packages.ApiKey).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllCreateImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Create " + typeof(Services.Packages.ApiKey).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllReadAccessImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "ReadAccess " + typeof(Services.Packages.ApiKey).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllChangeAccessImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "ChangeAccess " + typeof(Services.Packages.ApiKey).FullName, false, SessionToken);
        }
        
        #endregion
        
        #region Login / Logout

        internal static string GeneratePasswordImp()
        {
            char[] allowedCharacters = "qwertyuiopasdfghjklzxcvbnm1234567890-=!@#$%^&*()_+".ToCharArray();
            List<char> characterList = new List<char>();

            Random random = new Random();

            SetupImp();

            Securable s = new Securable(typeof(ApiKeySecureService).FullName);

            for (int n = 0; n < s.GenerationPasswordLength; ++n)
            {
                characterList.Add(allowedCharacters[random.Next(0, allowedCharacters.Length)]);
            }

            return new String(characterList.ToArray());
        }

        internal static string GenerateSessionTokenImp()
        {
            Random r = new Random();
            int randomLength = r.Next(200, 300);

            byte[] randomString = new byte[randomLength];
            r.NextBytes(randomString);

            string session = Convert.ToBase64String(randomString);
            if (session.Length > 384)
                return session.Substring(0, 384);
            else return session.ToLowerInvariant();
        }

        internal static string LoginAnonymousImp()
        {
            SetupImp();
			
            Securable s = new Securable(typeof(ApiKeySecureService).FullName);
            
            if (!s.AllowAnonymousAccess)
				return null;
			
			if (System.Web.HttpContext.Current != null)
			{
				IPRegistered ipr = new IPRegistered(System.Web.HttpContext.Current.Request.UserHostAddress);
				
				ipr = AddIPImp(s);
				
				// ipr.SessionsCreated = ipr.SessionsCreated + 1;
				// ipr.Update();
				// IPSessionRegistration
				
				CheckIPImp(s, ipr);
			}

            ModelSession ms = new ModelSession(GenerateSessionTokenImp());
            ms.User = new ModelUser("Everyone");
            ms.TimeIssued = DateTime.Now;
            ms.TimeIssuedFor = s.TimeSessionIsIssued;
            ms.Create();

            return ms.SessionToken;
        }
        
        internal static string LoginImp(string userName, string password)
        {
            SetupImp();
			
			if (System.Web.HttpContext.Current != null)
			{
				Securable s = new Securable(typeof(ApiKeySecureService).FullName);
				IPRegistered ipr = new IPRegistered(System.Web.HttpContext.Current.Request.UserHostAddress);
				
				ipr = AddIPImp(s);
				
				// ipr.SessionsCreated = ipr.SessionsCreated + 1;
				// ipr.Update();
				// IPSessionRegistration
				
				CheckIPImp(s, ipr);
			}
			
            ModelSession ms = new ModelSession(GenerateSessionTokenImp());
            CreateSessionImp(ref ms, userName, password);

            return ms.SessionToken;
        }

        internal static void SwitchUserImp(string userName, string password, string existingSessionToken)
        {
            ModelSession ms = CheckSessionImp(existingSessionToken);
            if (ms.User.Name == userName)
                return;

            CreateSessionImp(ref ms, userName, password);

            return;
        }

        internal static void CreateSessionImp(ref ModelSession ms, string userName, string password)
        {
			if (userName.ToLowerInvariant() == "everyone")
                throw new InvalidOperationException("Wrong API call for anonymous access.");
            
            Securable s = new Securable(typeof(ApiKeySecureService).FullName);

            ModelUser mu = new ModelUser(userName);
            if (!mu.Exists)
            {
				if (System.Web.HttpContext.Current != null)
				{
					IPRegistered ipr = new IPRegistered(System.Web.HttpContext.Current.Request.UserHostAddress);
					RegisterIPFailureImp(s, ipr);
				}
				
                throw new UnauthorizedAccessException("Access Denied");
            }
            
            if (!Platform.Runtime.Security.Hash.VerifyHash(password, "SHA512", mu.PasswordHash))
            {
				if (System.Web.HttpContext.Current != null)
				{
					IPRegistered ipr = new IPRegistered(System.Web.HttpContext.Current.Request.UserHostAddress);
					RegisterIPFailureImp(s, ipr);
				}
				
                throw new UnauthorizedAccessException("Access Denied");
            }
            
            if (!mu.Enabled && !ApiKeySecureService.CheckUserRightsImp(userName, "CannotBeDisabled"))
            {
				if (System.Web.HttpContext.Current != null)
				{
					IPRegistered ipr = new IPRegistered(System.Web.HttpContext.Current.Request.UserHostAddress);
					RegisterIPFailureImp(s, ipr);
				}
				
                throw new UnauthorizedAccessException("Access Denied"); // LoginDisabledException
            }
            
            ms.User = mu;
            ms.TimeIssued = DateTime.Now;
            ms.TimeIssuedFor = s.TimeSessionIsIssued;
            ms.Create();
        }

        internal static bool SessionExistsImp(string sessionToken)
        {
            try
            {
                ModelSession session = CheckSessionImp(sessionToken);
                return true;
            }
            catch
            {
                return false;
            }
        }

        internal static void LogoutSessionImp(string sessionToken, bool keepSession)
        {
			ModelSession session = CheckSessionImp(sessionToken);

            if (keepSession)
            {
                ModelSession ms = new ModelSession(sessionToken);
                ms.User = new ModelUser("Everyone");
                ms.Update();
            }
            else
            {
                session.Delete();
            }
        }
        
        internal static void LogoutAllSessionsImp(string userName, string SessionToken)
        {
			ModelSession session = CheckSessionImp(SessionToken);

            if (CheckUserRightsImp(session.User.Name, "ManageUsers"))
            {
				foreach(ModelSession ms in new ModelUser(userName).Sessions)
					ms.Delete();
				
				return;
			}
            
            throw new UnauthorizedAccessException("Access Denied");
        }
        
        #endregion

        #region User Management
        
        internal static ModelUser GetCurrentUserImp(string SessionToken)
        {
			ModelSession session = CheckSessionImp(SessionToken);
			
			if (session.User.Name.ToLowerInvariant() == "everyone")
				throw new UnauthorizedAccessException("Access Denied");

            ModelUser mu = new ModelUser(session.User.Name);

			// Reset sensitive data
			mu.PasswordHash = null;
            mu.SecretAnswer = null;

            // mu.Email = null;
            // mu.SecretQuestion = null;

            return mu;
        }

		internal static ModelUser GetUserImp(string userName, string SessionToken)
        {
			if (String.IsNullOrEmpty(userName))
            {
                throw new InvalidOperationException("One of the requested fields is empty.");
            }
            
            ModelSession session = CheckSessionImp(SessionToken);
			
			if (userName.ToLowerInvariant() == "everyone")
				throw new UnauthorizedAccessException("Access Denied");

            if (CheckUserRightsImp(session.User.Name, "ManageUsers"))
            {
                ModelUser mu = new ModelUser(userName);

                if (!mu.Exists)
                    throw new InvalidOperationException("User does not exist.");
                
                return mu;
            }
            
            throw new UnauthorizedAccessException("Access Denied");
        }
        
        internal static void SetUserByObjectImp(ModelUser userObject, string SessionToken)
        {
			// This function actually does nothing
			// You have another function of setting user data; and password cannot be set this way (direct hash)

			ModelSession session = CheckSessionImp(SessionToken);
			
			if (userObject.Name.ToLowerInvariant() == "everyone")
				throw new UnauthorizedAccessException("Access Denied");

            if ( (session.User.Name == userObject.Name) || 
				CheckUserRightsImp(session.User.Name, "ManageUsers"))
            {
                ModelUser mu = new ModelUser(userObject.Name);

                if (!mu.Exists)
                    throw new InvalidOperationException("User does not exist.");
                
                // userObject.Update();
                
                return;
            }
            
            throw new UnauthorizedAccessException("Access Denied");
        }
        
        internal static void AddUserImp(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			if (String.IsNullOrEmpty(userName) ||
                String.IsNullOrEmpty(password) ||
                String.IsNullOrEmpty(email) ||
                String.IsNullOrEmpty(secretQuestion) ||
                String.IsNullOrEmpty(secretAnswer))
            {
                throw new InvalidOperationException("One of the requested fields is empty.");
            }
            
            ModelSession session = CheckSessionImp(SessionToken);

            if (CheckUserRightsImp(session.User.Name, "ManageUsers"))
            {
                ModelUser mu = new ModelUser(userName);

                if (mu.Exists)
                    throw new InvalidOperationException("User already exists.");

                mu.PasswordHash = Platform.Runtime.Security.Hash.ComputeHash(password, "SHA512", null);
                mu.Email = email;
                mu.SecretQuestion = secretQuestion;
                mu.SecretAnswer = secretAnswer;
                mu.Enabled = enabled;
                mu.Create();

                return;
            }
            
            throw new UnauthorizedAccessException("Access Denied");
        }

        internal static void UpdateUserImp(string userName, string oldPassword, string email, string secretQuestion,
            string secretAnswer, string SessionToken)
        {
			if (String.IsNullOrEmpty(userName) ||
				String.IsNullOrEmpty(oldPassword) ||
                String.IsNullOrEmpty(email) ||
                String.IsNullOrEmpty(secretQuestion) ||
                String.IsNullOrEmpty(secretAnswer))
            {
                throw new InvalidOperationException("One of the requested fields is empty.");
            }
            
            ModelSession session = CheckSessionImp(SessionToken);

            if ( (session.User.Name == userName) || 
				CheckUserRightsImp(session.User.Name, "ManageUsers"))
            {
                ModelUser mu = new ModelUser(userName);
				
				string oldPasswordHash = Platform.Runtime.Security.Hash.ComputeHash(oldPassword, "SHA512", null);

				if (mu.PasswordHash != oldPasswordHash)
                    throw new InvalidOperationException("Old password is invalid.");

                if (!mu.Exists)
                    throw new InvalidOperationException("User does not exist.");

                mu.Email = email;
                mu.SecretQuestion = secretQuestion;
                mu.SecretAnswer = secretAnswer;
                mu.Update();

				return;
            }

            throw new UnauthorizedAccessException("Access Denied");
        }
        
        internal static void UpdateUserImp(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			if (String.IsNullOrEmpty(userName) ||
                String.IsNullOrEmpty(password) ||
                String.IsNullOrEmpty(email) ||
                String.IsNullOrEmpty(secretQuestion) ||
                String.IsNullOrEmpty(secretAnswer))
            {
                throw new InvalidOperationException("One of the requested fields is empty.");
            }
            
            if (userName.ToLowerInvariant() == "everyone")
                throw new InvalidOperationException("Anonymous user update is not allowed.");
            
            ModelSession session = CheckSessionImp(SessionToken);

            if (CheckUserRightsImp(session.User.Name, "ManageUsers"))
            {
                ModelUser mu = new ModelUser(userName);

                if (!mu.Exists)
                    throw new InvalidOperationException("User does not exist.");

                mu.PasswordHash = Platform.Runtime.Security.Hash.ComputeHash(password, "SHA512", null);
                mu.Email = email;
                mu.SecretQuestion = secretQuestion;
                mu.SecretAnswer = secretAnswer;
                mu.Enabled = enabled;
                mu.Update();

				return;
            }

            throw new UnauthorizedAccessException("Access Denied");
        }

        internal static void DeleteUserImp(string userName, string SessionToken)
        {
			if (String.IsNullOrEmpty(userName))
            {
                throw new InvalidOperationException("One of the requested fields is empty.");
            }
            
            if (userName.ToLowerInvariant() == "everyone")
                throw new InvalidOperationException("Anonymous user delete is not allowed.");
            
            ModelSession session = CheckSessionImp(SessionToken);

            if (CheckUserRightsImp(session.User.Name, "ManageUsers"))
            {
                ModelUser mu = new ModelUser(userName);

                if (!mu.Exists)
                    throw new InvalidOperationException("User does not exist.");

                mu.Delete();

				return;
            }

            throw new UnauthorizedAccessException("Access Denied");
        }
        
        internal static void ChangePasswordImp(string userName, string oldPassword, string newPassword, string SessionToken)
        {
			if (String.IsNullOrEmpty(userName) ||
				String.IsNullOrEmpty(oldPassword) ||
                String.IsNullOrEmpty(newPassword))
            {
                throw new InvalidOperationException("One of the requested fields is empty.");
            }
            
            if (userName.ToLowerInvariant() == "everyone")
                throw new InvalidOperationException("Anonymous user cannot have a password.");
            
            ModelSession session = CheckSessionImp(SessionToken);

            if ( (session.User.Name == userName) || 
				CheckUserRightsImp(session.User.Name, "ManageUsers"))
            {
                ModelUser mu = new ModelUser(userName);

				string oldPasswordHash = Platform.Runtime.Security.Hash.ComputeHash(oldPassword, "SHA512", null);

				if (mu.PasswordHash != oldPasswordHash)
                    throw new InvalidOperationException("Old password is invalid.");

                if (!mu.Exists)
                    throw new InvalidOperationException("User does not exist.");

                mu.PasswordHash = Platform.Runtime.Security.Hash.ComputeHash(newPassword, "SHA512", null);
                mu.Update();

				return;
            }

            throw new UnauthorizedAccessException("Access Denied");
        }
        
        internal static string CreateRandomPasswordImp(string userName, string answer, string SessionToken)
        {
			// This must change - only anonymous can request new account
			// Must be sent in the email address <- We do not know the delivery of password here :-(

			if (String.IsNullOrEmpty(userName) ||
                String.IsNullOrEmpty(answer))
            {
                throw new InvalidOperationException("One of the requested fields is empty.");
            }
            
            if (userName.ToLowerInvariant() == "everyone")
                throw new InvalidOperationException("Anonymous user cannot have a password.");
            
            ModelSession session = CheckSessionImp(SessionToken);

            if (CheckUserRightsImp(session.User.Name, "ManageUsers")) // this should be removed - must be only everyone
            {
                ModelUser mu = new ModelUser(userName);

                if (!mu.Exists)
                    throw new InvalidOperationException("User does not exist.");
                
                if (mu.SecretAnswer.ToLowerInvariant() == answer.ToLowerInvariant())
                {
					string password = GeneratePasswordImp();

					mu.PasswordHash = Platform.Runtime.Security.Hash.ComputeHash(password, "SHA512", null);
					mu.Update();
	                
					return password;
                }
            }

            throw new UnauthorizedAccessException("Access Denied");
        }

        #endregion
        
        #region Secure checks
        
        internal static bool HasAccessImp(Services.Packages.ApiKey _object, string userName, string securityDescriptor, string SessionToken)
        {	
			ModelSession session = CheckSessionImp(SessionToken);
			
            if (CheckAccessImp(_object, SessionToken, "ReadAccess"))
            {
				return CheckAccessFromUserNameImp(_object, userName, securityDescriptor);
            }
			
			throw new UnauthorizedAccessException("Access Denied");
        }
        
		internal static ModelSession CheckSessionImp(string sessionToken)
		{
			// Mark IP first
			Securable s = null;
			IPRegistered ipr = null;
			if (System.Web.HttpContext.Current != null)
			{
				s = new Securable(typeof(ApiKeySecureService).FullName);
				ipr = new IPRegistered(System.Web.HttpContext.Current.Request.UserHostAddress);
				
				CheckIPImp(s, ipr);
			}
			else
			{
				// What other unique data can be gathered?
			}
			
			if (String.IsNullOrEmpty(sessionToken))
			{
				// Invalid data is a security error
				if (s != null)
					RegisterIPFailureImp(s, ipr);
					
				throw new UnauthorizedAccessException("The session is invalid");
			}
			
			// Check the consistency of the session
			ModelSession session = new ModelSession(sessionToken.ToLowerInvariant());
			if (!session.Exists)
			{
				if (s != null)
					RegisterIPFailureImp(s, ipr);
				
				throw new UnauthorizedAccessException("The session is invalid");
			}
			
			if (session.User == null)
			{
				if (s != null)
					RegisterIPFailureImp(s, ipr);
				
				session.Delete();
				throw new UnauthorizedAccessException("The session is invalid");
			}
			
			DateTime until = session.TimeIssued.AddMinutes(session.TimeIssuedFor);
            if (until < DateTime.Now)
			{
				session.Delete();
				throw new UnauthorizedAccessException("Your session has expired");
			}
			
			return session;
		}
		
		internal static IPRegistered AddIPImp(Securable s)
		{
			IPRegistered ipr = null;
			if (System.Web.HttpContext.Current != null)
			{
				ipr = new IPRegistered(System.Web.HttpContext.Current.Request.UserHostAddress);
					
				if (!ipr.Exists)
				{
					if (!s.IPsMustBePreregistered)
					{
						ipr.Allowed = true;
						ipr.DenialIssuedUntilTime = DateTime.Now;
						ipr.Create();
					}
					else
						throw new UnauthorizedAccessException("Your IP is not registered in our allowed range");
				}
				else
				{
					CheckIPImp(s, ipr);
				}
			}
			
			return ipr;
		}
		
		internal static void CheckIPImp(Securable s, IPRegistered ipr)
		{
			if (!ipr.Exists)
			{
				throw new UnauthorizedAccessException("IP has not been authenticated in any way");
			}
				
			if (!ipr.Allowed && ipr.DenialIssuedUntilTime >= DateTime.Now)
			{
				throw new UnauthorizedAccessException("IP has been blocked until " + ipr.DenialIssuedUntilTime.ToString() + " (Server time)");
			}
			else if (!ipr.Allowed)
			{
				ipr.Allowed = true;
				ipr.Failures = 0;
				ipr.Update();
			}
			else
			{
				ipr.DenialIssuedUntilTime = DateTime.Now;
				ipr.Update();
			}
			
			// Very expensive
			/*if (!ipr.SessionsRegisteredOnIP.Count >= s.SessionsPerIPAllowed)
			{
				// Check how many are valid (also clean up the expired ones)
				throw new UnauthorizedAccessException("Too many sessions");
			}*/
		}
		
		internal static void RegisterIPFailureImp(Securable s, IPRegistered ipr)
		{
			ipr.Failures = ipr.Failures + 1;
					
			if (ipr.Failures >= s.AllowedIPFailures)
			{
				ipr.Allowed = false;
				ipr.DenialIssuedUntilTime = DateTime.Now.AddMinutes(s.IPFailureTimeDenying);
			}
			
			ipr.Update();
		}
		
		internal static bool CheckAccessImp(Services.Packages.ApiKey _object, string sessionToken, string securityDescriptor)
		{
			// Check the ModelUser and ModelSession tables
			// using ApiKeyAccessControlList and ApiKeyAccessControlEntry
			ModelSession session = CheckSessionImp(sessionToken);
			
			return CheckAccessFromUserNameImp(_object, session.User.Name, securityDescriptor);
		}
		
		internal static bool CheckAccessFromUserNameImp(Services.Packages.ApiKey _object, string userName, string securityDescriptor)
		{	
			if (!ApiKeySecureService.IsSecurableImp)
				return true;
			
			// Owner can do anything
			if (CheckUserRightsImp(userName, "Owner"))
				return true;
			
			// User could have constant rights on the class
			if (CheckUserRightsImp(userName, securityDescriptor + " " + typeof(Services.Packages.ApiKey).FullName))
				return true;
			
			if (_object.Owner != null && _object.Owner.Name == userName)
				return true;
			
			ApiKeyAccessControlListCollection acls = _object.GetACLs(userName);
			if (acls.Count == 0)
			{
				if (userName.ToLowerInvariant() != "everyone")
					return CheckAccessFromUserNameImp(_object, "Everyone", securityDescriptor);
				else return false;
			}
			
			ApiKeyAccessControlList acl = acls[0];
			
			ApiKeyAccessControlEntryCollection entries = ApiKeyAccessControlEntry.GetEntries(securityDescriptor.ToLowerInvariant(), acl);
			if (entries.Count == 0)
			{
				// Descriptor missing; Add-it
				ApiKeyAccessControlEntry entry = new ApiKeyAccessControlEntry();
                entry.Descriptor = securityDescriptor.ToLowerInvariant();
                entry.UserName = userName;
                entry.Allow = false;
				entry.ACL = acl;
				entry.Create();
				return false;
			}
			
			if (!entries[0].Allow)
			{
				if (userName.ToLowerInvariant() != "everyone")
					return CheckAccessFromUserNameImp(_object, "Everyone", securityDescriptor);
				else return false;
			}
			
			return true;
		}
		
		internal static bool CheckUserRightsImp(string userName, string userRightDescriptor)
		{
			if (!ApiKeySecureService.IsSecurableImp)
				return true;
			
			// Owner can do everything
			ModelUserRights ur = new ModelUserRights("owner", userName);
			
			if (ur.Exists)
				return true;
			
			// Check the user's rights
			ur = new ModelUserRights(userRightDescriptor.ToLowerInvariant(), userName);
			
			if (!ur.Exists)
				return false;
			return true;
		}

        internal static void SetupImp()
        {	
            ModelUser mu = new ModelUser("Everyone");
            
            if (!mu.Exists)
            {
				mu.PasswordHash = null;
				mu.Enabled = false;
				mu.Create();
				
				ModelUserRights ur = new ModelUserRights("owner", "Everyone");
				ur.Create();
            }
            
            Securable s = new Securable(typeof(ApiKeySecureService).FullName);
            if (!s.Exists)
            {
				// Default configuration - the safe way.
				s.TimeSessionIsIssued = 20;
				s.AllowAnonymousAccess = true;
				s.Enabled = true;
				s.GenerationPasswordLength = 6;
				s.AllowedIPFailures = 10;
				s.IPsMustBePreregistered = false;
				s.IPFailureTimeDenying = 60;
				s.DisableIPFiltering = false;
				s.SessionsPerIPAllowed = 2;
				s.Create();
            }
        }

        internal static Securable GetSecurableImp(string SessionToken)
        {
			SetupImp();
			
			ModelSession session = CheckSessionImp(SessionToken);

            if (CheckUserRightsImp(session.User.Name, "ManageApplication"))
            {
				Securable s = new Securable(typeof(ApiKeySecureService).FullName);
				return s;
            }
			
			throw new UnauthorizedAccessException("Access Denied");
        }
		
		#endregion
		
		#region Secure service instance methods
		
		public ModelUser GetCurrentUser(string SessionToken)
		{
			return ApiKeySecureService.GetCurrentUserImp(SessionToken);
        }
        
        public ModelUser GetUser(string userName, string SessionToken)
		{
			return ApiKeySecureService.GetUserImp(userName, SessionToken);
        }
        
        public void SetUserByObject(ModelUser userObject, string SessionToken)
        {
			ApiKeySecureService.SetUserByObjectImp(userObject, SessionToken);
        }
		
		public bool IsSecurable
        {
            get
			{
				return ApiKeySecureService.IsSecurableImp;
			}
        }
        
        public void EnableDisableSecurity(bool secure, string sessionToken)
        {
			ApiKeySecureService.EnableDisableSecurityImp(secure, sessionToken);
        }
        
        public string[] GetUserRightDescriptors()
        {
			return ApiKeySecureService.GetUserRightDescriptorsImp();
        }
        
        public void ChangeRights(string userName, string userRightDescriptor, bool allow, string SessionToken)
        {
			ApiKeySecureService.ChangeRightsImp(userName, userRightDescriptor, allow, SessionToken);
        }
        
        public bool HasRights(string userName, string userRightDescriptor, string SessionToken)
        {
			return ApiKeySecureService.HasRightsImp(userName, userRightDescriptor, SessionToken);
        }
        
		public bool HasAccess(Services.Packages.ApiKey _object, string userName, string securityDescriptor, string SessionToken)
		{
			return ApiKeySecureService.HasAccessImp(_object, userName, securityDescriptor, SessionToken);
		}
		
		public void ChangeAccess(Services.Packages.ApiKey _object, string userName, string securityDescriptor, bool allow, string SessionToken)
        {
			ApiKeySecureService.ChangeAccessImp(_object, userName, securityDescriptor, allow, SessionToken);
        }

        public void SetObjectOwner(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.SetOwnerImp(_object, userName, SessionToken);
        }
		
		public bool IsFirstTimeUsed
		{
			get
			{
				return ApiKeySecureService.IsFirstTimeUsedImp;
			}
		}

        public void SetDatabaseOwner(string userName)
        {
			ApiKeySecureService.SetDatabaseOwnerImp(userName);
        }
		
        public string[] GetSecurityDescriptors()
        {
			return ApiKeySecureService.GetSecurityDescriptorsImp();
        }
        
        public void AllowTraverse(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.AllowTraverseImp(_object, userName, SessionToken);
        }

        public void AllowRead(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.AllowReadImp(_object, userName, SessionToken);
        }

        public void AllowUpdate(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.AllowUpdateImp(_object, userName, SessionToken);
        }

        public void AllowCreate(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.AllowCreateImp(_object, userName, SessionToken);
        }

        public void AllowReadAccess(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.AllowReadAccessImp(_object, userName, SessionToken);
        }

        public void AllowChangeAccess(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.AllowChangeAccessImp(_object, userName, SessionToken);
        }
		
        public bool HasTraverse(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			return ApiKeySecureService.HasTraverseImp(_object, userName, SessionToken);
        }

        public bool HasRead(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			return ApiKeySecureService.HasReadImp(_object, userName, SessionToken);
        }

        public bool HasUpdate(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			return ApiKeySecureService.HasUpdateImp(_object, userName, SessionToken);
        }

        public bool HasCreate(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			return ApiKeySecureService.HasCreateImp(_object, userName, SessionToken);
        }

        public bool HasReadAccess(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			return ApiKeySecureService.HasReadAccessImp(_object, userName, SessionToken);
        }

        public bool HasChangeAccess(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			return ApiKeySecureService.HasChangeAccessImp(_object, userName, SessionToken);
        }
        
        public void DisallowTraverse(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowTraverseImp(_object, userName, SessionToken);
        }

        public void DisallowRead(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowReadImp(_object, userName, SessionToken);
        }

        public void DisallowUpdate(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowUpdateImp(_object, userName, SessionToken);
        }

        public void DisallowCreate(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowCreateImp(_object, userName, SessionToken);
        }

        public void DisallowReadAccess(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowReadAccessImp(_object, userName, SessionToken);
        }

        public void DisallowChangeAccess(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowChangeAccessImp(_object, userName, SessionToken);
        }
        
        public void AllowAllTraverse(string userName, string SessionToken)
        {
			ApiKeySecureService.AllowAllTraverseImp(userName, SessionToken);
        }
        
        public void AllowAllRead(string userName, string SessionToken)
        {
			ApiKeySecureService.AllowAllReadImp(userName, SessionToken);
        }
        
        public void AllowAllUpdate(string userName, string SessionToken)
        {
			ApiKeySecureService.AllowAllUpdateImp(userName, SessionToken);
        }
        
        public void AllowAllCreate(string userName, string SessionToken)
        {
			ApiKeySecureService.AllowAllCreateImp(userName, SessionToken);
        }
        
        public void AllowAllReadAccess(string userName, string SessionToken)
        {
			ApiKeySecureService.AllowAllReadAccessImp(userName, SessionToken);
        }
        
        public void AllowAllChangeAccess(string userName, string SessionToken)
        {
			ApiKeySecureService.AllowAllChangeAccessImp(userName, SessionToken);
        }
        
        public bool HasAllTraverse(string userName, string SessionToken)
        {
			return ApiKeySecureService.HasAllTraverseImp(userName, SessionToken);
        }
        
        public bool HasAllRead(string userName, string SessionToken)
        {
			return ApiKeySecureService.HasAllReadImp(userName, SessionToken);
        }
        
        public bool HasAllUpdate(string userName, string SessionToken)
        {
			return ApiKeySecureService.HasAllUpdateImp(userName, SessionToken);
        }
        
        public bool HasAllCreate(string userName, string SessionToken)
        {
			return ApiKeySecureService.HasAllCreateImp(userName, SessionToken);
        }
        
        public bool HasAllReadAccess(string userName, string SessionToken)
        {
			return ApiKeySecureService.HasAllReadAccessImp(userName, SessionToken);
        }
        
        public bool HasAllChangeAccess(string userName, string SessionToken)
        {
			return ApiKeySecureService.HasAllChangeAccessImp(userName, SessionToken);
        }
        
        public void DisallowAllTraverse(string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowAllTraverseImp(userName, SessionToken);
        }
        
        public void DisallowAllRead(string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowAllReadImp(userName, SessionToken);
        }
        
        public void DisallowAllUpdate(string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowAllUpdateImp(userName, SessionToken);
        }
        
        public void DisallowAllCreate(string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowAllCreateImp(userName, SessionToken);
        }
        
        public void DisallowAllReadAccess(string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowAllReadAccessImp(userName, SessionToken);
        }
        
        public void DisallowAllChangeAccess(string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowAllChangeAccessImp(userName, SessionToken);
        }
        
        public string LoginAnonymous()
        {
			return ApiKeySecureService.LoginAnonymousImp();
        }
        
        public string Login(string userName, string password)
        {
			return ApiKeySecureService.LoginImp(userName, password);
        }
        
        public void SwitchUser(string userName, string password, string existingSessionToken)
        {
			ApiKeySecureService.SwitchUserImp(userName, password, existingSessionToken);
        }

        public bool SessionExists(string sessionToken)
        {
			return ApiKeySecureService.SessionExistsImp(sessionToken);
        }

        public void LogoutSession(string sessionToken, bool keepSession)
        {
			ApiKeySecureService.LogoutSessionImp(sessionToken, keepSession);
        }
        
        public void LogoutAllSessions(string userName, string SessionToken)
        {
			ApiKeySecureService.LogoutAllSessionsImp(userName, SessionToken);
        }

        public void AddUser(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			ApiKeySecureService.AddUserImp(userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken);
        }

        public void UpdateUser(string userName, string oldPassword, string email, string secretQuestion,
            string secretAnswer, string SessionToken)
        {
			ApiKeySecureService.UpdateUserImp(userName, oldPassword, email, secretQuestion,
				secretAnswer, SessionToken);
        }
        
        public void UpdateUserWithEnable(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			ApiKeySecureService.UpdateUserImp(userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken);
        }
        
        public void DeleteUser(string userName, string SessionToken)
        {
			ApiKeySecureService.DeleteUserImp(userName, SessionToken);
        }
        
        public void ChangePassword(string userName, string oldPassword, string newPassword, string SessionToken)
        {
			ApiKeySecureService.ChangePasswordImp(userName, oldPassword, newPassword, SessionToken);
        }
        
        public string CreateRandomPassword(string userName, string answer, string SessionToken)
        {
			return ApiKeySecureService.CreateRandomPasswordImp(userName, answer, SessionToken);
        }

        public Securable GetSecurable(string SessionToken)
        {
			return ApiKeySecureService.GetSecurableImp(SessionToken);
        }
        
		#endregion
		
		/// <summary>
        /// Not supported. Throws a NotSupportedException on get or set.
        /// </summary>
		public string Uri
		{
			get { throw new NotSupportedException(); }
			set { throw new NotSupportedException(); }
		}

		[WebMethod]
        public bool Exists(ApiKey _ApiKey, string SessionToken)
        {
			if (!ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _ApiKey.Exists;
        }
		
		[WebMethod]
		public ApiKey Read(System.Guid __Id, string SessionToken)
		{
			ApiKey _ApiKey = new ApiKey(__Id);
			
			if (!ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _ApiKey;
		}
		
		[WebMethod]
        public ApiKey Reload(ApiKey _ApiKey, string SessionToken)
        {
			_ApiKey.Reload();
			
			if (!ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _ApiKey;
        }
		
		[WebMethod]
        public ApiKey Create(System.Guid __Id, string SessionToken)
        {
			ModelSession session = ApiKeySecureService.CheckSessionImp(SessionToken);

            if (!ApiKeySecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ApiKey).FullName))
				throw new UnauthorizedAccessException("Access Denied");
            
            ApiKey _ApiKey = ApiKey.CreateApiKey(__Id);
            _ApiKey.Owner = session.User;
            _ApiKey.Update();
			return _ApiKey;
        }
        
        [WebMethod]
        public void Delete(System.Guid __Id, string SessionToken)
        {
			ApiKey _ApiKey = new ApiKey(__Id);
			
			if (!ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Delete"))
				throw new UnauthorizedAccessException("Access Denied");
			
			ApiKey.DeleteApiKey(__Id);
        }
        
        [WebMethod]
        public void UpdateObject(ApiKey _ApiKey, string SessionToken)
        {
			if (!ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApiKey.Update();
        }
		
		[WebMethod]
        public void CreateObject(ApiKey _ApiKey, string SessionToken)
        {
			ModelSession session = ApiKeySecureService.CheckSessionImp(SessionToken);

            if (!ApiKeySecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ApiKey).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApiKey.Owner = session.User;
            _ApiKey.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ApiKey _ApiKey, string SessionToken)
        {
			if (!ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Delete"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApiKey.Delete();
        }

		[WebMethod]
        public void Undo(string SessionToken)
        {
			ModelSession session = ApiKeySecureService.CheckSessionImp(SessionToken);

			// Must have all available access to the class level (all objects)
			if (!ApiKeySecureService.CheckUserRightsImp(session.User.Name, "Update " + typeof(ApiKey).FullName) ||
				!ApiKeySecureService.CheckUserRightsImp(session.User.Name, "Delete " + typeof(ApiKey).FullName) ||
				!ApiKeySecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ApiKey).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			ApiKey.Undo();
        }

		[WebMethod]
        public void Redo(string SessionToken)
        {
			ModelSession session = ApiKeySecureService.CheckSessionImp(SessionToken);

			// Must have all available access to the class level (all objects)
			if (!ApiKeySecureService.CheckUserRightsImp(session.User.Name, "Update " + typeof(ApiKey).FullName) ||
				!ApiKeySecureService.CheckUserRightsImp(session.User.Name, "Delete " + typeof(ApiKey).FullName) ||
				!ApiKeySecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ApiKey).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			ApiKey.Redo();
        }

        		
		[WebMethod]
        public ApiKey CreateFromCustomer(System.Guid __Id, Services.Packages.Customer _Customer, string SessionToken)
        {
			ModelSession session = ApiKeySecureService.CheckSessionImp(SessionToken);

			ApiKey _ApiKey = new ApiKey(__Id);
            
            if (!_ApiKey.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create LicensesIssued"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ApiKey.Exists && !ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // ApiKey _ApiKey = ApiKey.CreateApiKey(__Id);
            _ApiKey.Owner = session.User;
            _ApiKey.Customer = _Customer;
            _ApiKey.Update();
			return _ApiKey;
        }
        
        [WebMethod]
        public void CreateObjectFromCustomer(ApiKey _ApiKey, Services.Packages.Customer _Customer, string SessionToken)
        {
			ModelSession session = ApiKeySecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create LicensesIssued"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_ApiKey.Reload();
			
			if (!_ApiKey.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create LicensesIssued"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ApiKey.Exists && !ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApiKey.Owner = session.User;
            _ApiKey.Customer = _Customer;
            _ApiKey.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromCustomer(Services.Packages.Customer _Customer, string userName, string SessionToken)
        {
            Services.Packages.Security.CustomerSecureService.ChangeAccessImp(_Customer, userName, "Create LicensesIssued", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromCustomer(Services.Packages.Customer _Customer, string userName, string SessionToken)
        {
            return Services.Packages.Security.CustomerSecureService.HasAccessImp(_Customer, userName, "Create LicensesIssued", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromCustomer(Services.Packages.Customer _Customer, string userName, string SessionToken)
        {
            Services.Packages.Security.CustomerSecureService.ChangeAccessImp(_Customer, userName, "Create LicensesIssued", false, SessionToken);
        }
		
		[WebMethod]
        public ApiKey CreateFromOwner(System.Guid __Id, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			ModelSession session = ApiKeySecureService.CheckSessionImp(SessionToken);

			ApiKey _ApiKey = new ApiKey(__Id);
            
            if (!_ApiKey.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create ApiKeyOwning"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ApiKey.Exists && !ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // ApiKey _ApiKey = ApiKey.CreateApiKey(__Id);
            _ApiKey.Owner = session.User;
            _ApiKey.Owner = _Owner;
            _ApiKey.Update();
			return _ApiKey;
        }
        
        [WebMethod]
        public void CreateObjectFromOwner(ApiKey _ApiKey, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			ModelSession session = ApiKeySecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create ApiKeyOwning"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_ApiKey.Reload();
			
			if (!_ApiKey.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create ApiKeyOwning"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ApiKey.Exists && !ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApiKey.Owner = session.User;
            _ApiKey.Owner = _Owner;
            _ApiKey.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_Owner, userName, "Create ApiKeyOwning", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            return Services.Packages.Security.Security.ModelUserSecureService.HasAccessImp(_Owner, userName, "Create ApiKeyOwning", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_Owner, userName, "Create ApiKeyOwning", false, SessionToken);
        }

		[WebMethod]
		public ApiKeyCollection GetByCustomer(Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApiKeyCollection c = ApiKey.GetByCustomer( _Customer);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApiKeySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApiKeyCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApiKeyCollection c = ApiKey.GetByCustomerPaged( _Customer, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApiKeySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long GetByCustomerCount(Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ApiKey.GetByCustomerCount( _Customer);
		}
		[WebMethod]
		public Services.Packages.Customer GetCustomer(ApiKey _ApiKey, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_ApiKey.Customer, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApiKey.Customer;
		}
		[WebMethod]
		public void SetCustomer(ApiKey _ApiKey, Services.Packages.Customer _Customer, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_Customer.Reload();
			if (_Customer.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Customer.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Create LicensesIssued"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApiKey.Customer = _Customer;
			_ApiKey.Update();
		}
		[WebMethod]
		public ApiKeyCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApiKeyCollection c = ApiKey.GetByOwner( _ModelUser);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApiKeySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApiKeyCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApiKeyCollection c = ApiKey.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApiKeySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ApiKey.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(ApiKey _ApiKey, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ApiKey.Owner, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApiKey.Owner;
		}
		[WebMethod]
		public void SetOwner(ApiKey _ApiKey, Services.Packages.Security.ModelUser _Owner, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_Owner.Reload();
			if (_Owner.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Owner.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Create ApiKeyOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApiKey.Owner = _Owner;
			_ApiKey.Update();
		}
		[WebMethod]
		public ApiKeyCollection SearchByCompanyInfo(System.String CompanyInfo , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApiKeyCollection c = ApiKey.SearchByCompanyInfo(CompanyInfo );
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApiKeySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApiKeyCollection SearchByCompanyInfoPaged(System.String CompanyInfo , long PagingStart, long PagingCount, string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApiKeyCollection c = ApiKey.SearchByCompanyInfoPaged(CompanyInfo , PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApiKeySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByCompanyInfoCount(System.String CompanyInfo , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ApiKey.SearchByCompanyInfoCount(CompanyInfo );
		}
		[WebMethod]
		public ApiKeyCollection SearchByCompanyInfoOnCustomer(System.String CompanyInfo, Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApiKeyCollection c = ApiKey.SearchByCompanyInfoOnCustomer(CompanyInfo,  _Customer);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApiKeySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApiKeyCollection SearchByCompanyInfoOnCustomerPaged(System.String CompanyInfo, Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApiKeyCollection c = ApiKey.SearchByCompanyInfoOnCustomerPaged(CompanyInfo,  _Customer, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApiKeySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByCompanyInfoOnCustomerCount(System.String CompanyInfo, Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ApiKey.SearchByCompanyInfoOnCustomerCount(CompanyInfo,  _Customer);
		}
		[WebMethod]
		public Services.Packages.PackageCollection GetPackagesUploaded(ApiKey _ApiKey, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.PackageSecureService.CheckAccessImp(_ApiKey.PackagesUploaded, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApiKey.PackagesUploaded;
		}
		[WebMethod]
		public void SetPackagesUploaded(ApiKey _ApiKey, Services.Packages.PackageCollection _PackagesUploaded, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_PackagesUploaded.Reload();
			if (_PackagesUploaded.Exists && !Services.Packages.Security.PackageSecureService.CheckAccessImp(_PackagesUploaded, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_PackagesUploaded.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Create PackagesUploaded"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApiKey.PackagesUploaded = _PackagesUploaded;
			_ApiKey.Update();
		}
		[WebMethod]
		public Services.Packages.Log.ApplicationExceptionCollection GetApplicationExceptionsLogged(ApiKey _ApiKey, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApiKey.ApplicationExceptionsLogged, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApiKey.ApplicationExceptionsLogged;
		}
		[WebMethod]
		public void SetApplicationExceptionsLogged(ApiKey _ApiKey, Services.Packages.Log.ApplicationExceptionCollection _ApplicationExceptionsLogged, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ApplicationExceptionsLogged.Reload();
			if (_ApplicationExceptionsLogged.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationExceptionsLogged, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ApplicationExceptionsLogged.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Create ApplicationExceptionsLogged"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApiKey.ApplicationExceptionsLogged = _ApplicationExceptionsLogged;
			_ApiKey.Update();
		}
		[WebMethod]
		public Services.Packages.PurchaseCollection GetOrders(ApiKey _ApiKey, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.PurchaseSecureService.CheckAccessImp(_ApiKey.Orders, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApiKey.Orders;
		}
		[WebMethod]
		public void SetOrders(ApiKey _ApiKey, Services.Packages.PurchaseCollection _Orders, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_Orders.Reload();
			if (_Orders.Exists && !Services.Packages.Security.PurchaseSecureService.CheckAccessImp(_Orders, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Orders.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Create Orders"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApiKey.Orders = _Orders;
			_ApiKey.Update();
		}
		[WebMethod]
		public Services.Packages.Security.ApiKeyAccessControlListCollection GetACLs(ApiKey _ApiKey, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.ApiKeyAccessControlListSecureService.CheckAccessImp(_ApiKey.ACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApiKey.ACLs;
		}
		[WebMethod]
		public void SetACLs(ApiKey _ApiKey, Services.Packages.Security.ApiKeyAccessControlListCollection _ACLs, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ACLs.Reload();
			if (_ACLs.Exists && !Services.Packages.Security.Security.ApiKeyAccessControlListSecureService.CheckAccessImp(_ACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ACLs.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Create ACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApiKey.ACLs = _ACLs;
			_ApiKey.Update();
		}

    }
    
namespace Web
{
	/// <summary>
	/// The WebService secure service provider that allows to create web services
	/// that share Services.Packages.ApiKey objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Security.Web.ApiKeySecureWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class ApiKeySecureWebService : WebService, IApiKeySecureService
	{
		#region Secure service instance methods
        
        [WebMethod]
        public void EnableDisableSecurity(bool secure, string sessionToken)
        {
			ApiKeySecureService.EnableDisableSecurityImp(secure, sessionToken);
        }
        
        [WebMethod]
        public string[] GetUserRightDescriptors()
        {
			return ApiKeySecureService.GetUserRightDescriptorsImp();
        }
        
        [WebMethod]
        public void ChangeRights(string userName, string userRightDescriptor, bool allow, string SessionToken)
        {
			ApiKeySecureService.ChangeRightsImp(userName, userRightDescriptor, allow, SessionToken);
        }
        
        [WebMethod]
        public bool HasRights(string userName, string userRightDescriptor, string SessionToken)
        {
			return ApiKeySecureService.HasRightsImp(userName, userRightDescriptor, SessionToken);
        }
        
		[WebMethod]
        public bool HasAccess(Services.Packages.ApiKey _object, string userName, string securityDescriptor, string SessionToken)
		{
			return ApiKeySecureService.HasAccessImp(_object, userName, securityDescriptor, SessionToken);
		}
		
		[WebMethod]
        public void ChangeAccess(Services.Packages.ApiKey _object, string userName, string securityDescriptor, bool allow, string SessionToken)
        {
			ApiKeySecureService.ChangeAccessImp(_object, userName, securityDescriptor, allow, SessionToken);
        }

        [WebMethod]
        public void SetObjectOwner(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.SetOwnerImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void SetDatabaseOwner(string userName)
        {
			ApiKeySecureService.SetDatabaseOwnerImp(userName);
        }
		
        [WebMethod]
        public string[] GetSecurityDescriptors()
        {
			return ApiKeySecureService.GetSecurityDescriptorsImp();
        }
        
        [WebMethod]
        public void AllowTraverse(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.AllowTraverseImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowRead(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.AllowReadImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowUpdate(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.AllowUpdateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowCreate(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.AllowCreateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowReadAccess(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.AllowReadAccessImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowChangeAccess(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.AllowChangeAccessImp(_object, userName, SessionToken);
        }
		
        [WebMethod]
        public bool HasTraverse(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			return ApiKeySecureService.HasTraverseImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasRead(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			return ApiKeySecureService.HasReadImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasUpdate(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			return ApiKeySecureService.HasUpdateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasCreate(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			return ApiKeySecureService.HasCreateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasReadAccess(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			return ApiKeySecureService.HasReadAccessImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasChangeAccess(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			return ApiKeySecureService.HasChangeAccessImp(_object, userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowTraverse(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowTraverseImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowRead(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowReadImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowUpdate(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowUpdateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowCreate(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowCreateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowReadAccess(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowReadAccessImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowChangeAccess(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowChangeAccessImp(_object, userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllTraverse(string userName, string SessionToken)
        {
			ApiKeySecureService.AllowAllTraverseImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllRead(string userName, string SessionToken)
        {
			ApiKeySecureService.AllowAllReadImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllUpdate(string userName, string SessionToken)
        {
			ApiKeySecureService.AllowAllUpdateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllCreate(string userName, string SessionToken)
        {
			ApiKeySecureService.AllowAllCreateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllReadAccess(string userName, string SessionToken)
        {
			ApiKeySecureService.AllowAllReadAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllChangeAccess(string userName, string SessionToken)
        {
			ApiKeySecureService.AllowAllChangeAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllTraverse(string userName, string SessionToken)
        {
			return ApiKeySecureService.HasAllTraverseImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllRead(string userName, string SessionToken)
        {
			return ApiKeySecureService.HasAllReadImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllUpdate(string userName, string SessionToken)
        {
			return ApiKeySecureService.HasAllUpdateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllCreate(string userName, string SessionToken)
        {
			return ApiKeySecureService.HasAllCreateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllReadAccess(string userName, string SessionToken)
        {
			return ApiKeySecureService.HasAllReadAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllChangeAccess(string userName, string SessionToken)
        {
			return ApiKeySecureService.HasAllChangeAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllTraverse(string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowAllTraverseImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllRead(string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowAllReadImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllUpdate(string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowAllUpdateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllCreate(string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowAllCreateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllReadAccess(string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowAllReadAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllChangeAccess(string userName, string SessionToken)
        {
			ApiKeySecureService.DisallowAllChangeAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public string LoginAnonymous()
        {
			return ApiKeySecureService.LoginAnonymousImp();
        }
        
        [WebMethod]
        public string Login(string userName, string password)
        {
			return ApiKeySecureService.LoginImp(userName, password);
        }
        
        [WebMethod]
        public void SwitchUser(string userName, string password, string existingSessionToken)
        {
			ApiKeySecureService.SwitchUserImp(userName, password, existingSessionToken);
        }

        [WebMethod]
        public bool SessionExists(string sessionToken)
        {
			return ApiKeySecureService.SessionExistsImp(sessionToken);
        }

        [WebMethod]
        public void LogoutSession(string sessionToken, bool keepSession)
        {
			ApiKeySecureService.LogoutSessionImp(sessionToken, keepSession);
        }
        
        [WebMethod]
        public void LogoutAllSessions(string userName, string SessionToken)
        {
			ApiKeySecureService.LogoutAllSessionsImp(userName, SessionToken);
        }
		
		[WebMethod]
        public ModelUser GetCurrentUser(string SessionToken)
		{
			return ApiKeySecureService.GetCurrentUserImp(SessionToken);
        }

		[WebMethod]
        public ModelUser GetUser(string userName, string SessionToken)
		{
			return ApiKeySecureService.GetUserImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void SetUserByObject(ModelUser userObject, string SessionToken)
		{
			ApiKeySecureService.SetUserByObjectImp(userObject, SessionToken);
        }
        
        [WebMethod]
        public void AddUser(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			ApiKeySecureService.AddUserImp(userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken);
        }

        [WebMethod]
        public void UpdateUser(string userName, string oldPassword, string email, string secretQuestion,
            string secretAnswer, string SessionToken)
        {
			ApiKeySecureService.UpdateUserImp(userName, oldPassword, email, secretQuestion,
				secretAnswer, SessionToken);
        }
        
        [WebMethod]
        public void UpdateUserWithEnable(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			ApiKeySecureService.UpdateUserImp(userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken);
        }
        
        [WebMethod]
        public void DeleteUser(string userName, string SessionToken)
        {
			ApiKeySecureService.DeleteUserImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void ChangePassword(string userName, string oldPassword, string newPassword, string SessionToken)
        {
			ApiKeySecureService.ChangePasswordImp(userName, oldPassword, newPassword, SessionToken);
        }
        
        [WebMethod]
        public string CreateRandomPassword(string userName, string answer, string SessionToken)
        {
			return ApiKeySecureService.CreateRandomPasswordImp(userName, answer, SessionToken);
        }

        [WebMethod]
        public Securable GetSecurable(string SessionToken)
        {
			return ApiKeySecureService.GetSecurableImp(SessionToken);
        }
        
		#endregion
		
		/// <summary>
        /// Gets the Uri if the service. Setting property is not supported.
        /// </summary>
		public string Uri
		{
			get { return "http://services.msd.com"; }
			set { throw new NotSupportedException(); }
		}

		[WebMethod]
        public bool Exists(ApiKey _ApiKey, string SessionToken)
        {
			if (!ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _ApiKey.Exists;
        }
		
		[WebMethod]
		public ApiKey Read(System.Guid __Id, string SessionToken)
		{
			ApiKey _ApiKey = new ApiKey(__Id);
			
			if (!ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _ApiKey;
		}
		
		[WebMethod]
        public ApiKey Reload(ApiKey _ApiKey, string SessionToken)
        {
			_ApiKey.Reload();
			
			if (!ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _ApiKey;
        }
		
		[WebMethod]
        public ApiKey Create(System.Guid __Id, string SessionToken)
        {
			ModelSession session = ApiKeySecureService.CheckSessionImp(SessionToken);

            if (!ApiKeySecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ApiKey).FullName))
				throw new UnauthorizedAccessException("Access Denied");
            
            ApiKey _ApiKey = ApiKey.CreateApiKey(__Id);
            _ApiKey.Owner = session.User;
            _ApiKey.Update();
			return _ApiKey;
        }
        
        [WebMethod]
        public void Delete(System.Guid __Id, string SessionToken)
        {
			ApiKey _ApiKey = new ApiKey(__Id);
			
			if (!ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Delete"))
				throw new UnauthorizedAccessException("Access Denied");
			
			ApiKey.DeleteApiKey(__Id);
        }
        
        [WebMethod]
        public void UpdateObject(ApiKey _ApiKey, string SessionToken)
        {
			if (!ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApiKey.Update();
        }
		
		[WebMethod]
        public void CreateObject(ApiKey _ApiKey, string SessionToken)
        {
			ModelSession session = ApiKeySecureService.CheckSessionImp(SessionToken);

            if (!ApiKeySecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ApiKey).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApiKey.Owner = session.User;
            _ApiKey.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ApiKey _ApiKey, string SessionToken)
        {
			if (!ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Delete"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApiKey.Delete();
        }

		[WebMethod]
        public void Undo(string SessionToken)
        {
			ModelSession session = ApiKeySecureService.CheckSessionImp(SessionToken);

			// Must have all available access to the class level (all objects)
			if (!ApiKeySecureService.CheckUserRightsImp(session.User.Name, "Update " + typeof(ApiKey).FullName) ||
				!ApiKeySecureService.CheckUserRightsImp(session.User.Name, "Delete " + typeof(ApiKey).FullName) ||
				!ApiKeySecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ApiKey).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			ApiKey.Undo();
        }

		[WebMethod]
        public void Redo(string SessionToken)
        {
			ModelSession session = ApiKeySecureService.CheckSessionImp(SessionToken);

			// Must have all available access to the class level (all objects)
			if (!ApiKeySecureService.CheckUserRightsImp(session.User.Name, "Update " + typeof(ApiKey).FullName) ||
				!ApiKeySecureService.CheckUserRightsImp(session.User.Name, "Delete " + typeof(ApiKey).FullName) ||
				!ApiKeySecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ApiKey).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			ApiKey.Redo();
        }

        		
		[WebMethod]
        public ApiKey CreateFromCustomer(System.Guid __Id, Services.Packages.Customer _Customer, string SessionToken)
        {
			ModelSession session = ApiKeySecureService.CheckSessionImp(SessionToken);

			ApiKey _ApiKey = new ApiKey(__Id);
            
            if (!_ApiKey.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create LicensesIssued"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ApiKey.Exists && !ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // ApiKey _ApiKey = ApiKey.CreateApiKey(__Id);
            _ApiKey.Owner = session.User;
            _ApiKey.Customer = _Customer;
            _ApiKey.Update();
			return _ApiKey;
        }
        
        [WebMethod]
        public void CreateObjectFromCustomer(ApiKey _ApiKey, Services.Packages.Customer _Customer, string SessionToken)
        {
			ModelSession session = ApiKeySecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create LicensesIssued"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_ApiKey.Reload();
			
			if (!_ApiKey.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create LicensesIssued"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ApiKey.Exists && !ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApiKey.Owner = session.User;
            _ApiKey.Customer = _Customer;
            _ApiKey.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromCustomer(Services.Packages.Customer _Customer, string userName, string SessionToken)
        {
            Services.Packages.Security.CustomerSecureService.ChangeAccessImp(_Customer, userName, "Create LicensesIssued", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromCustomer(Services.Packages.Customer _Customer, string userName, string SessionToken)
        {
            return Services.Packages.Security.CustomerSecureService.HasAccessImp(_Customer, userName, "Create LicensesIssued", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromCustomer(Services.Packages.Customer _Customer, string userName, string SessionToken)
        {
            Services.Packages.Security.CustomerSecureService.ChangeAccessImp(_Customer, userName, "Create LicensesIssued", false, SessionToken);
        }
		
		[WebMethod]
        public ApiKey CreateFromOwner(System.Guid __Id, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			ModelSession session = ApiKeySecureService.CheckSessionImp(SessionToken);

			ApiKey _ApiKey = new ApiKey(__Id);
            
            if (!_ApiKey.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create ApiKeyOwning"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ApiKey.Exists && !ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // ApiKey _ApiKey = ApiKey.CreateApiKey(__Id);
            _ApiKey.Owner = session.User;
            _ApiKey.Owner = _Owner;
            _ApiKey.Update();
			return _ApiKey;
        }
        
        [WebMethod]
        public void CreateObjectFromOwner(ApiKey _ApiKey, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			ModelSession session = ApiKeySecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create ApiKeyOwning"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_ApiKey.Reload();
			
			if (!_ApiKey.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create ApiKeyOwning"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ApiKey.Exists && !ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApiKey.Owner = session.User;
            _ApiKey.Owner = _Owner;
            _ApiKey.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_Owner, userName, "Create ApiKeyOwning", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            return Services.Packages.Security.Security.ModelUserSecureService.HasAccessImp(_Owner, userName, "Create ApiKeyOwning", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_Owner, userName, "Create ApiKeyOwning", false, SessionToken);
        }

		[WebMethod]
		public ApiKeyCollection GetByCustomer(Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApiKeyCollection c = ApiKey.GetByCustomer( _Customer);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApiKeySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApiKeyCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApiKeyCollection c = ApiKey.GetByCustomerPaged( _Customer, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApiKeySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long GetByCustomerCount(Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ApiKey.GetByCustomerCount( _Customer);
		}
		[WebMethod]
		public Services.Packages.Customer GetCustomer(ApiKey _ApiKey, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_ApiKey.Customer, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApiKey.Customer;
		}
		[WebMethod]
		public void SetCustomer(ApiKey _ApiKey, Services.Packages.Customer _Customer, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_Customer.Reload();
			if (_Customer.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Customer.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Create LicensesIssued"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApiKey.Customer = _Customer;
			_ApiKey.Update();
		}
		[WebMethod]
		public ApiKeyCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApiKeyCollection c = ApiKey.GetByOwner( _ModelUser);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApiKeySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApiKeyCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApiKeyCollection c = ApiKey.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApiKeySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ApiKey.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(ApiKey _ApiKey, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ApiKey.Owner, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApiKey.Owner;
		}
		[WebMethod]
		public void SetOwner(ApiKey _ApiKey, Services.Packages.Security.ModelUser _Owner, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_Owner.Reload();
			if (_Owner.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Owner.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Create ApiKeyOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApiKey.Owner = _Owner;
			_ApiKey.Update();
		}
		[WebMethod]
		public ApiKeyCollection SearchByCompanyInfo(System.String CompanyInfo , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApiKeyCollection c = ApiKey.SearchByCompanyInfo(CompanyInfo );
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApiKeySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApiKeyCollection SearchByCompanyInfoPaged(System.String CompanyInfo , long PagingStart, long PagingCount, string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApiKeyCollection c = ApiKey.SearchByCompanyInfoPaged(CompanyInfo , PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApiKeySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByCompanyInfoCount(System.String CompanyInfo , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ApiKey.SearchByCompanyInfoCount(CompanyInfo );
		}
		[WebMethod]
		public ApiKeyCollection SearchByCompanyInfoOnCustomer(System.String CompanyInfo, Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApiKeyCollection c = ApiKey.SearchByCompanyInfoOnCustomer(CompanyInfo,  _Customer);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApiKeySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApiKeyCollection SearchByCompanyInfoOnCustomerPaged(System.String CompanyInfo, Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApiKeyCollection c = ApiKey.SearchByCompanyInfoOnCustomerPaged(CompanyInfo,  _Customer, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApiKeySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByCompanyInfoOnCustomerCount(System.String CompanyInfo, Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ApiKey.SearchByCompanyInfoOnCustomerCount(CompanyInfo,  _Customer);
		}
		[WebMethod]
		public Services.Packages.PackageCollection GetPackagesUploaded(ApiKey _ApiKey, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.PackageSecureService.CheckAccessImp(_ApiKey.PackagesUploaded, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApiKey.PackagesUploaded;
		}
		[WebMethod]
		public void SetPackagesUploaded(ApiKey _ApiKey, Services.Packages.PackageCollection _PackagesUploaded, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_PackagesUploaded.Reload();
			if (_PackagesUploaded.Exists && !Services.Packages.Security.PackageSecureService.CheckAccessImp(_PackagesUploaded, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_PackagesUploaded.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Create PackagesUploaded"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApiKey.PackagesUploaded = _PackagesUploaded;
			_ApiKey.Update();
		}
		[WebMethod]
		public Services.Packages.Log.ApplicationExceptionCollection GetApplicationExceptionsLogged(ApiKey _ApiKey, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApiKey.ApplicationExceptionsLogged, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApiKey.ApplicationExceptionsLogged;
		}
		[WebMethod]
		public void SetApplicationExceptionsLogged(ApiKey _ApiKey, Services.Packages.Log.ApplicationExceptionCollection _ApplicationExceptionsLogged, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ApplicationExceptionsLogged.Reload();
			if (_ApplicationExceptionsLogged.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationExceptionsLogged, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ApplicationExceptionsLogged.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Create ApplicationExceptionsLogged"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApiKey.ApplicationExceptionsLogged = _ApplicationExceptionsLogged;
			_ApiKey.Update();
		}
		[WebMethod]
		public Services.Packages.PurchaseCollection GetOrders(ApiKey _ApiKey, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.PurchaseSecureService.CheckAccessImp(_ApiKey.Orders, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApiKey.Orders;
		}
		[WebMethod]
		public void SetOrders(ApiKey _ApiKey, Services.Packages.PurchaseCollection _Orders, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_Orders.Reload();
			if (_Orders.Exists && !Services.Packages.Security.PurchaseSecureService.CheckAccessImp(_Orders, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Orders.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Create Orders"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApiKey.Orders = _Orders;
			_ApiKey.Update();
		}
		[WebMethod]
		public Services.Packages.Security.ApiKeyAccessControlListCollection GetACLs(ApiKey _ApiKey, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.ApiKeyAccessControlListSecureService.CheckAccessImp(_ApiKey.ACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApiKey.ACLs;
		}
		[WebMethod]
		public void SetACLs(ApiKey _ApiKey, Services.Packages.Security.ApiKeyAccessControlListCollection _ACLs, string SessionToken)
		{
			_ApiKey.Reload();
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ACLs.Reload();
			if (_ACLs.Exists && !Services.Packages.Security.Security.ApiKeyAccessControlListSecureService.CheckAccessImp(_ACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ACLs.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Create ACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApiKey.ACLs = _ACLs;
			_ApiKey.Update();
		}

	}
	
	/// <summary>
	/// The WebService secure client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="ApiKeyWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("96fcb3c2-9559-62b3-c658-b049b5632888")]
    sealed public class ApiKeySecureWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IApiKeySecureService
	{
		static string globalUrl;
		
		/// <summary>
        /// By setting this value, all the subsequent clients that using the default
        /// constructor will point to the service that this url points to.
        /// </summary>
		static public string GlobalUrl
		{
			get { return globalUrl; }
			set { globalUrl = value; }
		}
		
		/// <summary>
        /// Initializes a web service client using the url as the service endpoint.
        /// </summary>
        /// <param name="url">The service url that the object will point to</param>
		public ApiKeySecureWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public ApiKeySecureWebServiceClient()
		{
			if (!String.IsNullOrEmpty(globalUrl))
				this.Url = globalUrl;
		}
		
		/// <summary>
        /// Allows the service to set the Uri for COM compatibility. Is the same with Url property.
        /// </summary>
		public string Uri
		{
			get { return this.Url; }
			set { this.Url = value; }
		}
		
		#region Secure service instance methods
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetUserRightDescriptors", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public string[] GetUserRightDescriptors()
        {
			object[] results = this.Invoke("GetUserRightDescriptors", new object[] {});
			return ((string[])(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/ChangeRights", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void ChangeRights(string userName, string userRightDescriptor, bool allow, string SessionToken)
        {
			this.Invoke("ChangeRights", new object[] {userName, userRightDescriptor, allow, SessionToken});
			return;
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasRights", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasRights(string userName, string userRightDescriptor, string SessionToken)
        {
			object[] results = this.Invoke("HasRights", new object[] {userName, userRightDescriptor, SessionToken});
			return ((bool)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasAccess(Services.Packages.ApiKey _object, string userName, string securityDescriptor, string SessionToken)
		{
			object[] results = this.Invoke("HasAccess", new object[] {_object, userName, securityDescriptor, SessionToken});
			return ((bool)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetSecurityDescriptors", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public string[] GetSecurityDescriptors()
        {
			object[] results = this.Invoke("GetSecurityDescriptors", new object[] {});
			return ((string[])(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/EnableDisableSecurity", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void EnableDisableSecurity(bool secure, string sessionToken)
        {
			this.Invoke("EnableDisableSecurity", new object[] {secure, sessionToken});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/ChangeAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void ChangeAccess(Services.Packages.ApiKey _object, string userName, string securityDescriptor, bool allow, string SessionToken)
        {
			this.Invoke("ChangeAccess", new object[] {_object, userName, securityDescriptor, allow, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetObjectOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetObjectOwner(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			this.Invoke("SetObjectOwner", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetDatabaseOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetDatabaseOwner(string userName)
        {
			this.Invoke("SetDatabaseOwner", new object[] {userName});
			return;
        }
		
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowTraverse", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowTraverse(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			this.Invoke("AllowTraverse", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowRead", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowRead(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			this.Invoke("AllowRead", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowUpdate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowUpdate(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			this.Invoke("AllowUpdate", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowCreate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowCreate(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			this.Invoke("AllowCreate", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowReadAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowReadAccess(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			this.Invoke("AllowReadAccess", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowChangeAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowChangeAccess(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			this.Invoke("AllowChangeAccess", new object[] {_object, userName, SessionToken});
			return;
        }
		
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasTraverse", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasTraverse(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasTraverse", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasRead", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasRead(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasRead", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasUpdate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasUpdate(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasUpdate", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasCreate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasCreate(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasCreate", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasReadAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasReadAccess(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasReadAccess", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasChangeAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasChangeAccess(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasChangeAccess", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowTraverse", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowTraverse(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowTraverse", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowRead", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowRead(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowRead", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowUpdate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowUpdate(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowUpdate", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowCreate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowCreate(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowCreate", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowReadAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowReadAccess(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowReadAccess", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowChangeAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowChangeAccess(Services.Packages.ApiKey _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowChangeAccess", new object[] {_object, userName, SessionToken});
			return;
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowAllTraverse", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowAllTraverse(string userName, string SessionToken)
        {
			this.Invoke("AllowAllTraverse", new object[] {userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowAllRead", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowAllRead(string userName, string SessionToken)
        {
			this.Invoke("AllowAllRead", new object[] {userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowAllUpdate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowAllUpdate(string userName, string SessionToken)
        {
			this.Invoke("AllowAllUpdate", new object[] {userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowAllCreate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowAllCreate(string userName, string SessionToken)
        {
			this.Invoke("AllowAllCreate", new object[] {userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowAllReadAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowAllReadAccess(string userName, string SessionToken)
        {
			this.Invoke("AllowAllReadAccess", new object[] {userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowAllChangeAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowAllChangeAccess(string userName, string SessionToken)
        {
			this.Invoke("AllowAllChangeAccess", new object[] {userName, SessionToken});
			return;
        }
		
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasAllTraverse", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasAllTraverse(string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasAllTraverse", new object[] {userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasAllRead", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasAllRead(string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasAllRead", new object[] {userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasAllUpdate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasAllUpdate(string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasAllUpdate", new object[] {userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasAllCreate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasAllCreate(string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasAllCreate", new object[] {userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasAllReadAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasAllReadAccess(string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasAllReadAccess", new object[] {userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasAllChangeAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasAllChangeAccess(string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasAllChangeAccess", new object[] {userName, SessionToken});
			return ((bool)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowAllTraverse", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowAllTraverse(string userName, string SessionToken)
        {
			this.Invoke("DisallowAllTraverse", new object[] {userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowAllRead", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowAllRead(string userName, string SessionToken)
        {
			this.Invoke("DisallowAllRead", new object[] {userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowAllUpdate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowAllUpdate(string userName, string SessionToken)
        {
			this.Invoke("DisallowAllUpdate", new object[] {userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowAllCreate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowAllCreate(string userName, string SessionToken)
        {
			this.Invoke("DisallowAllCreate", new object[] {userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowAllReadAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowAllReadAccess(string userName, string SessionToken)
        {
			this.Invoke("DisallowAllReadAccess", new object[] {userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowAllChangeAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowAllChangeAccess(string userName, string SessionToken)
        {
			this.Invoke("DisallowAllChangeAccess", new object[] {userName, SessionToken});
			return;
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/LoginAnonymous", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public string LoginAnonymous()
        {
			object[] results = this.Invoke("LoginAnonymous", new object[] {});
			return ((string)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Login", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public string Login(string userName, string password)
        {
			object[] results = this.Invoke("Login", new object[] {userName, password});
			return ((string)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SwitchUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SwitchUser(string userName, string password, string existingSessionToken)
        {
			this.Invoke("SwitchUser", new object[] {userName, password, existingSessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SessionExists", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool SessionExists(string sessionToken)
        {
			object[] results = this.Invoke("SessionExists", new object[] {sessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/LogoutSession", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void LogoutSession(string sessionToken, bool keepSession)
        {
			this.Invoke("LogoutSession", new object[] {sessionToken,keepSession});
			return;
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/LogoutAllSessions", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void LogoutAllSessions(string userName, string SessionToken)
        {
			this.Invoke("LogoutAllSessions", new object[] {userName, SessionToken});
			return;
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetCurrentUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUser GetCurrentUser(string SessionToken)
		{
			object[] results = this.Invoke("GetCurrentUser", new object[] {SessionToken});
			return ((ModelUser)(results[0]));
        }

		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUser GetUser(string userName, string SessionToken)
		{
			object[] results = this.Invoke("GetUser", new object[] {userName, SessionToken});
			return ((ModelUser)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetUserByObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetUserByObject(ModelUser userObject, string SessionToken)
		{
			this.Invoke("SetUserByObject", new object[] {userObject, SessionToken});
			return;
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AddUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AddUser(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			this.Invoke("AddUser", new object[] {userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void UpdateUser(string userName, string oldPassword, string email, string secretQuestion,
            string secretAnswer, string SessionToken)
        {
			this.Invoke("UpdateUser", new object[] {userName, oldPassword, email, secretQuestion,
				secretAnswer, SessionToken});
			return;
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateUserWithEnable", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void UpdateUserWithEnable(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			this.Invoke("UpdateUserWithEnable", new object[] {userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken});
			return;
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DeleteUser(string userName, string SessionToken)
        {
			this.Invoke("DeleteUser", new object[] {userName, SessionToken});
			return;
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/ChangePassword", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void ChangePassword(string userName, string oldPassword, string newPassword, string SessionToken)
        {
			this.Invoke("ChangePassword", new object[] {userName, oldPassword, newPassword, SessionToken});
			return;
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateRandomPassword", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public string CreateRandomPassword(string userName, string answer, string SessionToken)
        {
			object[] results = this.Invoke("CreateRandomPassword", new object[] {userName, answer, SessionToken});
			return ((string)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetSecurable", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Securable GetSecurable(string SessionToken)
        {
			object[] results = this.Invoke("GetSecurable", new object[] {SessionToken});
			return ((Securable)(results[0]));
        }
        
		#endregion
		

		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Exists", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool Exists(ApiKey _ApiKey, string SessionToken)
        {
			object[] results = this.Invoke("Exists", new object[] {_ApiKey,SessionToken});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKey Read(System.Guid __Id, string SessionToken)
		{
			object[] results = this.Invoke("Read", new object[] {__Id, SessionToken});
			return ((ApiKey)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKey Reload(ApiKey _ApiKey, string SessionToken)
        {
			object[] results = this.Invoke("Reload", new object[] {_ApiKey,SessionToken});
			return ((ApiKey)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKey Create(System.Guid __Id, string SessionToken)
        {
			object[] results = this.Invoke("Create", new object[] {__Id, SessionToken});
			return ((ApiKey)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.Guid __Id, string SessionToken)
        {
			this.Invoke("Delete", new object[] {__Id, SessionToken});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(ApiKey _ApiKey, string SessionToken)
        {
			this.Invoke("UpdateObject", new object[] {_ApiKey,SessionToken});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(ApiKey _ApiKey, string SessionToken)
        {
			this.Invoke("CreateObject", new object[] {_ApiKey,SessionToken});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(ApiKey _ApiKey, string SessionToken)
        {
			this.Invoke("DeleteObject", new object[] {_ApiKey,SessionToken});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Undo", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void Undo(string SessionToken)
        {
			this.Invoke("Undo", new object[] {SessionToken});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Redo", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Redo(string SessionToken)
        {
			this.Invoke("Redo", new object[] {SessionToken});
			return;
        }
        		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateFromCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKey CreateFromCustomer(System.Guid __Id, Services.Packages.Customer _Customer, string SessionToken)
        {
			object[] results = this.Invoke("Create", new object[] {__Id, _Customer,SessionToken});
			return ((ApiKey)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObjectFromCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObjectFromCustomer(ApiKey _ApiKey, Services.Packages.Customer _Customer, string SessionToken)
        {
			this.Invoke("CreateObjectFromCustomer", new object[] {_ApiKey,_Customer,SessionToken});
			return;
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowCreateObjectFromCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowCreateFromCustomer(Services.Packages.Customer _Customer, string userName, string SessionToken)
        {
            this.Invoke("AllowCreateFromCustomer", new object[] {_Customer, userName, SessionToken});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasCreateObjectFromCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasCreateFromCustomer(Services.Packages.Customer _Customer, string userName, string SessionToken)
        {
            object[] results = this.Invoke("HasCreateFromCustomer", new object[] {_Customer, userName, SessionToken});
			return ((bool)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowCreateObjectFromCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowCreateFromCustomer(Services.Packages.Customer _Customer, string userName, string SessionToken)
        {
            this.Invoke("DisallowObjectFromCustomer", new object[] {_Customer, userName, SessionToken});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateFromOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKey CreateFromOwner(System.Guid __Id, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			object[] results = this.Invoke("Create", new object[] {__Id, _Owner,SessionToken});
			return ((ApiKey)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObjectFromOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObjectFromOwner(ApiKey _ApiKey, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			this.Invoke("CreateObjectFromOwner", new object[] {_ApiKey,_Owner,SessionToken});
			return;
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowCreateObjectFromOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            this.Invoke("AllowCreateFromOwner", new object[] {_Owner, userName, SessionToken});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasCreateObjectFromOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            object[] results = this.Invoke("HasCreateFromOwner", new object[] {_Owner, userName, SessionToken});
			return ((bool)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowCreateObjectFromOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            this.Invoke("DisallowObjectFromOwner", new object[] {_Owner, userName, SessionToken});
			return;
        }

		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyCollection GetByCustomer(Services.Packages.Customer _Customer, string SessionToken) {
			object[] results = this.Invoke("GetByCustomer", new object[] {_Customer,SessionToken});
			return ((ApiKeyCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByCustomerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("GetByCustomerPaged", new object[] {_Customer,PagingStart,PagingCount,SessionToken});
			return ((ApiKeyCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByCustomerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByCustomerCount(Services.Packages.Customer _Customer, string SessionToken) {
			object[] results = this.Invoke("GetByCustomerCount", new object[] {_Customer,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Customer GetCustomer(ApiKey _ApiKey, string SessionToken)
		{
			object[] results = this.Invoke("GetCustomer", new object[] {_ApiKey,SessionToken});
			return ((Services.Packages.Customer)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetCustomer(ApiKey _ApiKey, Services.Packages.Customer _Customer, string SessionToken)
		{
			this.Invoke("GetCustomer", new object[] {_ApiKey,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser, string SessionToken) {
			object[] results = this.Invoke("GetByOwner", new object[] {_ModelUser,SessionToken});
			return ((ApiKeyCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("GetByOwnerPaged", new object[] {_ModelUser,PagingStart,PagingCount,SessionToken});
			return ((ApiKeyCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser, string SessionToken) {
			object[] results = this.Invoke("GetByOwnerCount", new object[] {_ModelUser,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetOwner(ApiKey _ApiKey, string SessionToken)
		{
			object[] results = this.Invoke("GetOwner", new object[] {_ApiKey,SessionToken});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetOwner(ApiKey _ApiKey, Services.Packages.Security.ModelUser _Owner, string SessionToken)
		{
			this.Invoke("GetOwner", new object[] {_ApiKey,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByCompanyInfo", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyCollection SearchByCompanyInfo(System.String CompanyInfo , string SessionToken) {
			object[] results = this.Invoke("SearchByCompanyInfo", new object[] {CompanyInfo,SessionToken});
			return ((ApiKeyCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByCompanyInfoPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyCollection SearchByCompanyInfoPaged(System.String CompanyInfo , long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("SearchByCompanyInfoPaged", new object[] {CompanyInfo,PagingStart,PagingCount,SessionToken});
			return ((ApiKeyCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByCompanyInfoCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByCompanyInfoCount(System.String CompanyInfo , string SessionToken) {
			object[] results = this.Invoke("SearchByCompanyInfoCount", new object[] {CompanyInfo,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByCompanyInfoOnCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyCollection SearchByCompanyInfoOnCustomer(System.String CompanyInfo, Services.Packages.Customer _Customer, string SessionToken) {
			object[] results = this.Invoke("SearchByCompanyInfoOnCustomer", new object[] {CompanyInfo, _Customer,SessionToken});
			return ((ApiKeyCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByCompanyInfoOnCustomerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyCollection SearchByCompanyInfoOnCustomerPaged(System.String CompanyInfo, Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("SearchByCompanyInfoOnCustomerPaged", new object[] {CompanyInfo, _Customer,PagingStart,PagingCount,SessionToken});
			return ((ApiKeyCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByCompanyInfoOnCustomerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByCompanyInfoOnCustomerCount(System.String CompanyInfo, Services.Packages.Customer _Customer, string SessionToken) {
			object[] results = this.Invoke("SearchByCompanyInfoOnCustomerCount", new object[] {CompanyInfo, _Customer,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPackagesUploaded", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.PackageCollection GetPackagesUploaded(ApiKey _ApiKey, string SessionToken)
		{
			object[] results = this.Invoke("GetPackagesUploaded", new object[] {_ApiKey,SessionToken});
			return ((Services.Packages.PackageCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPackagesUploaded", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPackagesUploaded(ApiKey _ApiKey, Services.Packages.PackageCollection _PackagesUploaded, string SessionToken)
		{
			this.Invoke("GetPackagesUploaded", new object[] {_ApiKey,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetApplicationExceptionsLogged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Log.ApplicationExceptionCollection GetApplicationExceptionsLogged(ApiKey _ApiKey, string SessionToken)
		{
			object[] results = this.Invoke("GetApplicationExceptionsLogged", new object[] {_ApiKey,SessionToken});
			return ((Services.Packages.Log.ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetApplicationExceptionsLogged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetApplicationExceptionsLogged(ApiKey _ApiKey, Services.Packages.Log.ApplicationExceptionCollection _ApplicationExceptionsLogged, string SessionToken)
		{
			this.Invoke("GetApplicationExceptionsLogged", new object[] {_ApiKey,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetOrders", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.PurchaseCollection GetOrders(ApiKey _ApiKey, string SessionToken)
		{
			object[] results = this.Invoke("GetOrders", new object[] {_ApiKey,SessionToken});
			return ((Services.Packages.PurchaseCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetOrders", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetOrders(ApiKey _ApiKey, Services.Packages.PurchaseCollection _Orders, string SessionToken)
		{
			this.Invoke("GetOrders", new object[] {_ApiKey,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ApiKeyAccessControlListCollection GetACLs(ApiKey _ApiKey, string SessionToken)
		{
			object[] results = this.Invoke("GetACLs", new object[] {_ApiKey,SessionToken});
			return ((Services.Packages.Security.ApiKeyAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACLs(ApiKey _ApiKey, Services.Packages.Security.ApiKeyAccessControlListCollection _ACLs, string SessionToken)
		{
			this.Invoke("GetACLs", new object[] {_ApiKey,SessionToken});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages
