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
    /// apply servicing on Services.Packages.CustomerUserEntry type.
    /// </summary>
    [ComVisible(true)]
    [Guid("9de9a013-2ded-d23e-c6bd-c505906fd79b")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface ICustomerUserEntrySecureService
    {
		#region Securable interface definitions
        void EnableDisableSecurity(bool secure, string sessionToken);
        
        string[] GetUserRightDescriptors();
        bool HasRights(string userName, string userRightDescriptor, string SessionToken);
		void ChangeRights(string userName, string userRightDescriptor, bool allow, string SessionToken);
		void ChangeAccess(Services.Packages.CustomerUserEntry _object, string userName, string securityDescriptor, bool allow, string SessionToken);
		bool HasAccess(Services.Packages.CustomerUserEntry _object, string userName, string securityDescriptor, string SessionToken);
        
        void SetObjectOwner(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken);
        void SetDatabaseOwner(string userName);
        
        string[] GetSecurityDescriptors();
        void AllowTraverse(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken);
        void AllowRead(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken);
        void AllowUpdate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken);
        void AllowCreate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken);
        void AllowReadAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken);
        void AllowChangeAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken);
        bool HasTraverse(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken);
        bool HasRead(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken);
        bool HasUpdate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken);
        bool HasCreate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken);
        bool HasReadAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken);
        bool HasChangeAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken);
        void DisallowTraverse(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken);
        void DisallowRead(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken);
        void DisallowUpdate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken);
        void DisallowCreate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken);
        void DisallowReadAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken);
        void DisallowChangeAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken);
        
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
        bool Exists(CustomerUserEntry _CustomerUserEntry, string SessionToken);
		[OperationContract]
        CustomerUserEntry Read(System.Int32 __Id, string SessionToken);
        [OperationContract]
        CustomerUserEntry Reload(CustomerUserEntry _CustomerUserEntry, string SessionToken);
        [OperationContract]
        CustomerUserEntry Create(System.Int32 __Id, string SessionToken);
        [OperationContract]
        void Delete(System.Int32 __Id, string SessionToken);
        [OperationContract]
        void UpdateObject(CustomerUserEntry _CustomerUserEntry, string SessionToken);
        [OperationContract]
        void CreateObject(CustomerUserEntry _CustomerUserEntry, string SessionToken);
        [OperationContract]
        void DeleteObject(CustomerUserEntry _CustomerUserEntry, string SessionToken);
        [OperationContract]
        void Undo(string SessionToken);
        [OperationContract]
        void Redo(string SessionToken);
        		
		[OperationContract]
        CustomerUserEntry CreateFromUserLogin(System.Int32 __Id, Services.Packages.Security.ModelUser _UserLogin, string SessionToken);
        [OperationContract]
        void CreateObjectFromUserLogin(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _UserLogin, string SessionToken);
        [OperationContract]
        void AllowCreateFromUserLogin(Services.Packages.Security.ModelUser _UserLogin, string userName, string SessionToken);
		[OperationContract]
        bool HasCreateFromUserLogin(Services.Packages.Security.ModelUser _UserLogin, string userName, string SessionToken);
        [OperationContract]
        void DisallowCreateFromUserLogin(Services.Packages.Security.ModelUser _UserLogin, string userName, string SessionToken);
		
		[OperationContract]
        CustomerUserEntry CreateFromCustomer(System.Int32 __Id, Services.Packages.Customer _Customer, string SessionToken);
        [OperationContract]
        void CreateObjectFromCustomer(CustomerUserEntry _CustomerUserEntry, Services.Packages.Customer _Customer, string SessionToken);
        [OperationContract]
        void AllowCreateFromCustomer(Services.Packages.Customer _Customer, string userName, string SessionToken);
		[OperationContract]
        bool HasCreateFromCustomer(Services.Packages.Customer _Customer, string userName, string SessionToken);
        [OperationContract]
        void DisallowCreateFromCustomer(Services.Packages.Customer _Customer, string userName, string SessionToken);
		
		[OperationContract]
        CustomerUserEntry CreateFromOwner(System.Int32 __Id, Services.Packages.Security.ModelUser _Owner, string SessionToken);
        [OperationContract]
        void CreateObjectFromOwner(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _Owner, string SessionToken);
        [OperationContract]
        void AllowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken);
		[OperationContract]
        bool HasCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken);
        [OperationContract]
        void DisallowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken);

		[OperationContract]
		CustomerUserEntryCollection GetByUserLogin(Services.Packages.Security.ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		CustomerUserEntryCollection GetByUserLoginPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long GetByUserLoginCount(Services.Packages.Security.ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		Services.Packages.Security.ModelUser GetUserLogin(CustomerUserEntry _CustomerUserEntry, string SessionToken);
		[OperationContract]
		void SetUserLogin(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _UserLogin, string SessionToken);
		[OperationContract]
		CustomerUserEntryCollection GetByCustomer(Services.Packages.Customer _Customer, string SessionToken);
		[OperationContract]
		CustomerUserEntryCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long GetByCustomerCount(Services.Packages.Customer _Customer, string SessionToken);
		[OperationContract]
		Services.Packages.Customer GetCustomer(CustomerUserEntry _CustomerUserEntry, string SessionToken);
		[OperationContract]
		void SetCustomer(CustomerUserEntry _CustomerUserEntry, Services.Packages.Customer _Customer, string SessionToken);
		[OperationContract]
		CustomerUserEntryCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		CustomerUserEntryCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		Services.Packages.Security.ModelUser GetOwner(CustomerUserEntry _CustomerUserEntry, string SessionToken);
		[OperationContract]
		void SetOwner(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _Owner, string SessionToken);
		[OperationContract]
		Services.Packages.Security.CustomerUserEntryAccessControlListCollection GetACLs(CustomerUserEntry _CustomerUserEntry, string SessionToken);
		[OperationContract]
		void SetACLs(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.CustomerUserEntryAccessControlListCollection _ACLs, string SessionToken);

    }
    
    /// <summary>
    /// WCF and default secure implementation of a service object for Services.Packages.CustomerUserEntry type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("49287586-25b3-8208-4f71-c48dae7051ef")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class CustomerUserEntrySecureService : ICustomerUserEntrySecureService
    {
		#region Securable persistence

        internal static bool IsSecurableImp
        {
            get
            {
                Securable s = new Securable(typeof(CustomerUserEntrySecureService).FullName);
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

            Securable s = new Securable(typeof(CustomerUserEntrySecureService).FullName);
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
		
		internal static void ChangeAccessImp(Services.Packages.CustomerUserEntry _object, string userName, string securityDescriptor, bool allow, string SessionToken)
		{
			// Check if user can do that
            ModelSession session = CheckSessionImp(SessionToken);

            if (CheckAccessImp(_object, SessionToken, "ChangeAccess"))
            {
                try
                {
                    CustomerUserEntryAccessControlListCollection acls = _object.GetACLs(userName);
                    CustomerUserEntryAccessControlList acl;

                    if (acls.Count == 0)
                    {
                        acl = new CustomerUserEntryAccessControlList();
                        acl.UserName = userName;
                        acl.CustomerUserEntry = _object;
                        acl.Create();
                    }
                    else
                    {
                        acl = acls[0];
                    }

                    CustomerUserEntryAccessControlEntry entry = new CustomerUserEntryAccessControlEntry();
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
        
        internal static void SetOwnerImp(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
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
		
        internal static void AllowTraverseImp(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Traverse", true, SessionToken);
        }

        internal static void AllowReadImp(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Read", true, SessionToken);
        }

        internal static void AllowUpdateImp(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Update", true, SessionToken);
        }

        internal static void AllowCreateImp(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
            // ChangeAccessImp(_object, userName, "Create " + typeof(Services.Packages.CustomerUserEntry).FullName, true, SessionToken);
            throw new NotImplementedException();
        }

        internal static void AllowReadAccessImp(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "ReadAccess", true, SessionToken);
        }

        internal static void AllowChangeAccessImp(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "ChangeAccess", true, SessionToken);
        }
        
        // Security check
		
        internal static bool HasTraverseImp(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			return HasAccessImp(_object, userName, "Traverse", SessionToken);
		}

        internal static bool HasReadImp(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			return HasAccessImp(_object, userName, "Read", SessionToken);
		}

        internal static bool HasUpdateImp(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
            return HasAccessImp(_object, userName, "Update", SessionToken);
		}

        internal static bool HasCreateImp(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
            // ChangeAccessImp(_object, userName, "Create " + typeof(Services.Packages.CustomerUserEntry).FullName, true, SessionToken);
            throw new NotImplementedException();
        }

        internal static bool HasReadAccessImp(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
            return HasAccessImp(_object, userName, "ReadAccess", SessionToken);
        }

        internal static bool HasChangeAccessImp(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
            return HasAccessImp(_object, userName, "ChangeAccess", SessionToken);
        }
        
        // Disallow
        
        internal static void DisallowTraverseImp(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Traverse", false, SessionToken);
        }

        internal static void DisallowReadImp(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Read", false, SessionToken);
        }

        internal static void DisallowUpdateImp(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Update", false, SessionToken);
        }

        internal static void DisallowCreateImp(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
            // ChangeAccessImp(_object, userName, "Create " + typeof(Services.Packages.CustomerUserEntry).FullName, false, SessionToken);
            throw new NotImplementedException();
        }

        internal static void DisallowReadAccessImp(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "ReadAccess", false, SessionToken);
        }

        internal static void DisallowChangeAccessImp(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "ChangeAccess", false, SessionToken);
        }
        
        // General object security methods
        
        internal static void AllowAllTraverseImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Traverse " + typeof(Services.Packages.CustomerUserEntry).FullName, true, SessionToken);
        }
        
        internal static void AllowAllReadImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Read " + typeof(Services.Packages.CustomerUserEntry).FullName, true, SessionToken);
        }
        
        internal static void AllowAllUpdateImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Update " + typeof(Services.Packages.CustomerUserEntry).FullName, true, SessionToken);
        }
        
        internal static void AllowAllCreateImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Create " + typeof(Services.Packages.CustomerUserEntry).FullName, true, SessionToken);
        }
        
        internal static void AllowAllReadAccessImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "ReadAccess " + typeof(Services.Packages.CustomerUserEntry).FullName, true, SessionToken);
        }
        
        internal static void AllowAllChangeAccessImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "ChangeAccess " + typeof(Services.Packages.CustomerUserEntry).FullName, true, SessionToken);
        }
        
        internal static bool HasAllTraverseImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "Traverse " + typeof(Services.Packages.CustomerUserEntry).FullName, SessionToken);
        }
        
        internal static bool HasAllReadImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "Read " + typeof(Services.Packages.CustomerUserEntry).FullName, SessionToken);
        }
        
        internal static bool HasAllUpdateImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "Update " + typeof(Services.Packages.CustomerUserEntry).FullName, SessionToken);
        }
        
        internal static bool HasAllCreateImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "Create " + typeof(Services.Packages.CustomerUserEntry).FullName, SessionToken);
        }
        
        internal static bool HasAllReadAccessImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "ReadAccess " + typeof(Services.Packages.CustomerUserEntry).FullName, SessionToken);
        }
        
        internal static bool HasAllChangeAccessImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "ChangeAccess " + typeof(Services.Packages.CustomerUserEntry).FullName, SessionToken);
        }
        
        internal static void DisallowAllTraverseImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Traverse " + typeof(Services.Packages.CustomerUserEntry).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllReadImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Read " + typeof(Services.Packages.CustomerUserEntry).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllUpdateImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Update " + typeof(Services.Packages.CustomerUserEntry).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllCreateImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Create " + typeof(Services.Packages.CustomerUserEntry).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllReadAccessImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "ReadAccess " + typeof(Services.Packages.CustomerUserEntry).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllChangeAccessImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "ChangeAccess " + typeof(Services.Packages.CustomerUserEntry).FullName, false, SessionToken);
        }
        
        #endregion
        
        #region Login / Logout

        internal static string GeneratePasswordImp()
        {
            char[] allowedCharacters = "qwertyuiopasdfghjklzxcvbnm1234567890-=!@#$%^&*()_+".ToCharArray();
            List<char> characterList = new List<char>();

            Random random = new Random();

            SetupImp();

            Securable s = new Securable(typeof(CustomerUserEntrySecureService).FullName);

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
			
            Securable s = new Securable(typeof(CustomerUserEntrySecureService).FullName);
            
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
				Securable s = new Securable(typeof(CustomerUserEntrySecureService).FullName);
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
            
            Securable s = new Securable(typeof(CustomerUserEntrySecureService).FullName);

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
            
            if (!mu.Enabled && !CustomerUserEntrySecureService.CheckUserRightsImp(userName, "CannotBeDisabled"))
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
        
        internal static bool HasAccessImp(Services.Packages.CustomerUserEntry _object, string userName, string securityDescriptor, string SessionToken)
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
				s = new Securable(typeof(CustomerUserEntrySecureService).FullName);
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
		
		internal static bool CheckAccessImp(Services.Packages.CustomerUserEntry _object, string sessionToken, string securityDescriptor)
		{
			// Check the ModelUser and ModelSession tables
			// using CustomerUserEntryAccessControlList and CustomerUserEntryAccessControlEntry
			ModelSession session = CheckSessionImp(sessionToken);
			
			return CheckAccessFromUserNameImp(_object, session.User.Name, securityDescriptor);
		}
		
		internal static bool CheckAccessFromUserNameImp(Services.Packages.CustomerUserEntry _object, string userName, string securityDescriptor)
		{	
			if (!CustomerUserEntrySecureService.IsSecurableImp)
				return true;
			
			// Owner can do anything
			if (CheckUserRightsImp(userName, "Owner"))
				return true;
			
			// User could have constant rights on the class
			if (CheckUserRightsImp(userName, securityDescriptor + " " + typeof(Services.Packages.CustomerUserEntry).FullName))
				return true;
			
			if (_object.Owner != null && _object.Owner.Name == userName)
				return true;
			
			CustomerUserEntryAccessControlListCollection acls = _object.GetACLs(userName);
			if (acls.Count == 0)
			{
				if (userName.ToLowerInvariant() != "everyone")
					return CheckAccessFromUserNameImp(_object, "Everyone", securityDescriptor);
				else return false;
			}
			
			CustomerUserEntryAccessControlList acl = acls[0];
			
			CustomerUserEntryAccessControlEntryCollection entries = CustomerUserEntryAccessControlEntry.GetEntries(securityDescriptor.ToLowerInvariant(), acl);
			if (entries.Count == 0)
			{
				// Descriptor missing; Add-it
				CustomerUserEntryAccessControlEntry entry = new CustomerUserEntryAccessControlEntry();
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
			if (!CustomerUserEntrySecureService.IsSecurableImp)
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
            
            Securable s = new Securable(typeof(CustomerUserEntrySecureService).FullName);
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
				Securable s = new Securable(typeof(CustomerUserEntrySecureService).FullName);
				return s;
            }
			
			throw new UnauthorizedAccessException("Access Denied");
        }
		
		#endregion
		
		#region Secure service instance methods
		
		public ModelUser GetCurrentUser(string SessionToken)
		{
			return CustomerUserEntrySecureService.GetCurrentUserImp(SessionToken);
        }
        
        public ModelUser GetUser(string userName, string SessionToken)
		{
			return CustomerUserEntrySecureService.GetUserImp(userName, SessionToken);
        }
        
        public void SetUserByObject(ModelUser userObject, string SessionToken)
        {
			CustomerUserEntrySecureService.SetUserByObjectImp(userObject, SessionToken);
        }
		
		public bool IsSecurable
        {
            get
			{
				return CustomerUserEntrySecureService.IsSecurableImp;
			}
        }
        
        public void EnableDisableSecurity(bool secure, string sessionToken)
        {
			CustomerUserEntrySecureService.EnableDisableSecurityImp(secure, sessionToken);
        }
        
        public string[] GetUserRightDescriptors()
        {
			return CustomerUserEntrySecureService.GetUserRightDescriptorsImp();
        }
        
        public void ChangeRights(string userName, string userRightDescriptor, bool allow, string SessionToken)
        {
			CustomerUserEntrySecureService.ChangeRightsImp(userName, userRightDescriptor, allow, SessionToken);
        }
        
        public bool HasRights(string userName, string userRightDescriptor, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasRightsImp(userName, userRightDescriptor, SessionToken);
        }
        
		public bool HasAccess(Services.Packages.CustomerUserEntry _object, string userName, string securityDescriptor, string SessionToken)
		{
			return CustomerUserEntrySecureService.HasAccessImp(_object, userName, securityDescriptor, SessionToken);
		}
		
		public void ChangeAccess(Services.Packages.CustomerUserEntry _object, string userName, string securityDescriptor, bool allow, string SessionToken)
        {
			CustomerUserEntrySecureService.ChangeAccessImp(_object, userName, securityDescriptor, allow, SessionToken);
        }

        public void SetObjectOwner(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.SetOwnerImp(_object, userName, SessionToken);
        }
		
		public bool IsFirstTimeUsed
		{
			get
			{
				return CustomerUserEntrySecureService.IsFirstTimeUsedImp;
			}
		}

        public void SetDatabaseOwner(string userName)
        {
			CustomerUserEntrySecureService.SetDatabaseOwnerImp(userName);
        }
		
        public string[] GetSecurityDescriptors()
        {
			return CustomerUserEntrySecureService.GetSecurityDescriptorsImp();
        }
        
        public void AllowTraverse(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowTraverseImp(_object, userName, SessionToken);
        }

        public void AllowRead(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowReadImp(_object, userName, SessionToken);
        }

        public void AllowUpdate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowUpdateImp(_object, userName, SessionToken);
        }

        public void AllowCreate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowCreateImp(_object, userName, SessionToken);
        }

        public void AllowReadAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowReadAccessImp(_object, userName, SessionToken);
        }

        public void AllowChangeAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowChangeAccessImp(_object, userName, SessionToken);
        }
		
        public bool HasTraverse(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasTraverseImp(_object, userName, SessionToken);
        }

        public bool HasRead(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasReadImp(_object, userName, SessionToken);
        }

        public bool HasUpdate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasUpdateImp(_object, userName, SessionToken);
        }

        public bool HasCreate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasCreateImp(_object, userName, SessionToken);
        }

        public bool HasReadAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasReadAccessImp(_object, userName, SessionToken);
        }

        public bool HasChangeAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasChangeAccessImp(_object, userName, SessionToken);
        }
        
        public void DisallowTraverse(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowTraverseImp(_object, userName, SessionToken);
        }

        public void DisallowRead(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowReadImp(_object, userName, SessionToken);
        }

        public void DisallowUpdate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowUpdateImp(_object, userName, SessionToken);
        }

        public void DisallowCreate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowCreateImp(_object, userName, SessionToken);
        }

        public void DisallowReadAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowReadAccessImp(_object, userName, SessionToken);
        }

        public void DisallowChangeAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowChangeAccessImp(_object, userName, SessionToken);
        }
        
        public void AllowAllTraverse(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowAllTraverseImp(userName, SessionToken);
        }
        
        public void AllowAllRead(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowAllReadImp(userName, SessionToken);
        }
        
        public void AllowAllUpdate(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowAllUpdateImp(userName, SessionToken);
        }
        
        public void AllowAllCreate(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowAllCreateImp(userName, SessionToken);
        }
        
        public void AllowAllReadAccess(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowAllReadAccessImp(userName, SessionToken);
        }
        
        public void AllowAllChangeAccess(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowAllChangeAccessImp(userName, SessionToken);
        }
        
        public bool HasAllTraverse(string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasAllTraverseImp(userName, SessionToken);
        }
        
        public bool HasAllRead(string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasAllReadImp(userName, SessionToken);
        }
        
        public bool HasAllUpdate(string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasAllUpdateImp(userName, SessionToken);
        }
        
        public bool HasAllCreate(string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasAllCreateImp(userName, SessionToken);
        }
        
        public bool HasAllReadAccess(string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasAllReadAccessImp(userName, SessionToken);
        }
        
        public bool HasAllChangeAccess(string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasAllChangeAccessImp(userName, SessionToken);
        }
        
        public void DisallowAllTraverse(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowAllTraverseImp(userName, SessionToken);
        }
        
        public void DisallowAllRead(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowAllReadImp(userName, SessionToken);
        }
        
        public void DisallowAllUpdate(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowAllUpdateImp(userName, SessionToken);
        }
        
        public void DisallowAllCreate(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowAllCreateImp(userName, SessionToken);
        }
        
        public void DisallowAllReadAccess(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowAllReadAccessImp(userName, SessionToken);
        }
        
        public void DisallowAllChangeAccess(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowAllChangeAccessImp(userName, SessionToken);
        }
        
        public string LoginAnonymous()
        {
			return CustomerUserEntrySecureService.LoginAnonymousImp();
        }
        
        public string Login(string userName, string password)
        {
			return CustomerUserEntrySecureService.LoginImp(userName, password);
        }
        
        public void SwitchUser(string userName, string password, string existingSessionToken)
        {
			CustomerUserEntrySecureService.SwitchUserImp(userName, password, existingSessionToken);
        }

        public bool SessionExists(string sessionToken)
        {
			return CustomerUserEntrySecureService.SessionExistsImp(sessionToken);
        }

        public void LogoutSession(string sessionToken, bool keepSession)
        {
			CustomerUserEntrySecureService.LogoutSessionImp(sessionToken, keepSession);
        }
        
        public void LogoutAllSessions(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.LogoutAllSessionsImp(userName, SessionToken);
        }

        public void AddUser(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			CustomerUserEntrySecureService.AddUserImp(userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken);
        }

        public void UpdateUser(string userName, string oldPassword, string email, string secretQuestion,
            string secretAnswer, string SessionToken)
        {
			CustomerUserEntrySecureService.UpdateUserImp(userName, oldPassword, email, secretQuestion,
				secretAnswer, SessionToken);
        }
        
        public void UpdateUserWithEnable(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			CustomerUserEntrySecureService.UpdateUserImp(userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken);
        }
        
        public void DeleteUser(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DeleteUserImp(userName, SessionToken);
        }
        
        public void ChangePassword(string userName, string oldPassword, string newPassword, string SessionToken)
        {
			CustomerUserEntrySecureService.ChangePasswordImp(userName, oldPassword, newPassword, SessionToken);
        }
        
        public string CreateRandomPassword(string userName, string answer, string SessionToken)
        {
			return CustomerUserEntrySecureService.CreateRandomPasswordImp(userName, answer, SessionToken);
        }

        public Securable GetSecurable(string SessionToken)
        {
			return CustomerUserEntrySecureService.GetSecurableImp(SessionToken);
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
        public bool Exists(CustomerUserEntry _CustomerUserEntry, string SessionToken)
        {
			if (!CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _CustomerUserEntry.Exists;
        }
		
		[WebMethod]
		public CustomerUserEntry Read(System.Int32 __Id, string SessionToken)
		{
			CustomerUserEntry _CustomerUserEntry = new CustomerUserEntry(__Id);
			
			if (!CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _CustomerUserEntry;
		}
		
		[WebMethod]
        public CustomerUserEntry Reload(CustomerUserEntry _CustomerUserEntry, string SessionToken)
        {
			_CustomerUserEntry.Reload();
			
			if (!CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _CustomerUserEntry;
        }
		
		[WebMethod]
        public CustomerUserEntry Create(System.Int32 __Id, string SessionToken)
        {
			ModelSession session = CustomerUserEntrySecureService.CheckSessionImp(SessionToken);

            if (!CustomerUserEntrySecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(CustomerUserEntry).FullName))
				throw new UnauthorizedAccessException("Access Denied");
            
            CustomerUserEntry _CustomerUserEntry = CustomerUserEntry.CreateCustomerUserEntry(__Id);
            _CustomerUserEntry.Owner = session.User;
            _CustomerUserEntry.Update();
			return _CustomerUserEntry;
        }
        
        [WebMethod]
        public void Delete(System.Int32 __Id, string SessionToken)
        {
			CustomerUserEntry _CustomerUserEntry = new CustomerUserEntry(__Id);
			
			if (!CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Delete"))
				throw new UnauthorizedAccessException("Access Denied");
			
			CustomerUserEntry.DeleteCustomerUserEntry(__Id);
        }
        
        [WebMethod]
        public void UpdateObject(CustomerUserEntry _CustomerUserEntry, string SessionToken)
        {
			if (!CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_CustomerUserEntry.Update();
        }
		
		[WebMethod]
        public void CreateObject(CustomerUserEntry _CustomerUserEntry, string SessionToken)
        {
			ModelSession session = CustomerUserEntrySecureService.CheckSessionImp(SessionToken);

            if (!CustomerUserEntrySecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(CustomerUserEntry).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			_CustomerUserEntry.Owner = session.User;
            _CustomerUserEntry.Create();
        }
        
        [WebMethod]
        public void DeleteObject(CustomerUserEntry _CustomerUserEntry, string SessionToken)
        {
			if (!CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Delete"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_CustomerUserEntry.Delete();
        }

		[WebMethod]
        public void Undo(string SessionToken)
        {
			ModelSession session = CustomerUserEntrySecureService.CheckSessionImp(SessionToken);

			// Must have all available access to the class level (all objects)
			if (!CustomerUserEntrySecureService.CheckUserRightsImp(session.User.Name, "Update " + typeof(CustomerUserEntry).FullName) ||
				!CustomerUserEntrySecureService.CheckUserRightsImp(session.User.Name, "Delete " + typeof(CustomerUserEntry).FullName) ||
				!CustomerUserEntrySecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(CustomerUserEntry).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			CustomerUserEntry.Undo();
        }

		[WebMethod]
        public void Redo(string SessionToken)
        {
			ModelSession session = CustomerUserEntrySecureService.CheckSessionImp(SessionToken);

			// Must have all available access to the class level (all objects)
			if (!CustomerUserEntrySecureService.CheckUserRightsImp(session.User.Name, "Update " + typeof(CustomerUserEntry).FullName) ||
				!CustomerUserEntrySecureService.CheckUserRightsImp(session.User.Name, "Delete " + typeof(CustomerUserEntry).FullName) ||
				!CustomerUserEntrySecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(CustomerUserEntry).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			CustomerUserEntry.Redo();
        }

        		
		[WebMethod]
        public CustomerUserEntry CreateFromUserLogin(System.Int32 __Id, Services.Packages.Security.ModelUser _UserLogin, string SessionToken)
        {
			ModelSession session = CustomerUserEntrySecureService.CheckSessionImp(SessionToken);

			CustomerUserEntry _CustomerUserEntry = new CustomerUserEntry(__Id);
            
            if (!_CustomerUserEntry.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_UserLogin, SessionToken, "Create CustomerUserEntries"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_CustomerUserEntry.Exists && !CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // CustomerUserEntry _CustomerUserEntry = CustomerUserEntry.CreateCustomerUserEntry(__Id);
            _CustomerUserEntry.Owner = session.User;
            _CustomerUserEntry.UserLogin = _UserLogin;
            _CustomerUserEntry.Update();
			return _CustomerUserEntry;
        }
        
        [WebMethod]
        public void CreateObjectFromUserLogin(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _UserLogin, string SessionToken)
        {
			ModelSession session = CustomerUserEntrySecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_UserLogin, SessionToken, "Create CustomerUserEntries"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_CustomerUserEntry.Reload();
			
			if (!_CustomerUserEntry.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_UserLogin, SessionToken, "Create CustomerUserEntries"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_CustomerUserEntry.Exists && !CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_CustomerUserEntry.Owner = session.User;
            _CustomerUserEntry.UserLogin = _UserLogin;
            _CustomerUserEntry.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromUserLogin(Services.Packages.Security.ModelUser _UserLogin, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_UserLogin, userName, "Create CustomerUserEntries", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromUserLogin(Services.Packages.Security.ModelUser _UserLogin, string userName, string SessionToken)
        {
            return Services.Packages.Security.Security.ModelUserSecureService.HasAccessImp(_UserLogin, userName, "Create CustomerUserEntries", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromUserLogin(Services.Packages.Security.ModelUser _UserLogin, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_UserLogin, userName, "Create CustomerUserEntries", false, SessionToken);
        }
		
		[WebMethod]
        public CustomerUserEntry CreateFromCustomer(System.Int32 __Id, Services.Packages.Customer _Customer, string SessionToken)
        {
			ModelSession session = CustomerUserEntrySecureService.CheckSessionImp(SessionToken);

			CustomerUserEntry _CustomerUserEntry = new CustomerUserEntry(__Id);
            
            if (!_CustomerUserEntry.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create CustomerUserEntries"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_CustomerUserEntry.Exists && !CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // CustomerUserEntry _CustomerUserEntry = CustomerUserEntry.CreateCustomerUserEntry(__Id);
            _CustomerUserEntry.Owner = session.User;
            _CustomerUserEntry.Customer = _Customer;
            _CustomerUserEntry.Update();
			return _CustomerUserEntry;
        }
        
        [WebMethod]
        public void CreateObjectFromCustomer(CustomerUserEntry _CustomerUserEntry, Services.Packages.Customer _Customer, string SessionToken)
        {
			ModelSession session = CustomerUserEntrySecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create CustomerUserEntries"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_CustomerUserEntry.Reload();
			
			if (!_CustomerUserEntry.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create CustomerUserEntries"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_CustomerUserEntry.Exists && !CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_CustomerUserEntry.Owner = session.User;
            _CustomerUserEntry.Customer = _Customer;
            _CustomerUserEntry.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromCustomer(Services.Packages.Customer _Customer, string userName, string SessionToken)
        {
            Services.Packages.Security.CustomerSecureService.ChangeAccessImp(_Customer, userName, "Create CustomerUserEntries", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromCustomer(Services.Packages.Customer _Customer, string userName, string SessionToken)
        {
            return Services.Packages.Security.CustomerSecureService.HasAccessImp(_Customer, userName, "Create CustomerUserEntries", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromCustomer(Services.Packages.Customer _Customer, string userName, string SessionToken)
        {
            Services.Packages.Security.CustomerSecureService.ChangeAccessImp(_Customer, userName, "Create CustomerUserEntries", false, SessionToken);
        }
		
		[WebMethod]
        public CustomerUserEntry CreateFromOwner(System.Int32 __Id, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			ModelSession session = CustomerUserEntrySecureService.CheckSessionImp(SessionToken);

			CustomerUserEntry _CustomerUserEntry = new CustomerUserEntry(__Id);
            
            if (!_CustomerUserEntry.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create CustomerUserEntryOwning"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_CustomerUserEntry.Exists && !CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // CustomerUserEntry _CustomerUserEntry = CustomerUserEntry.CreateCustomerUserEntry(__Id);
            _CustomerUserEntry.Owner = session.User;
            _CustomerUserEntry.Owner = _Owner;
            _CustomerUserEntry.Update();
			return _CustomerUserEntry;
        }
        
        [WebMethod]
        public void CreateObjectFromOwner(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			ModelSession session = CustomerUserEntrySecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create CustomerUserEntryOwning"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_CustomerUserEntry.Reload();
			
			if (!_CustomerUserEntry.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create CustomerUserEntryOwning"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_CustomerUserEntry.Exists && !CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_CustomerUserEntry.Owner = session.User;
            _CustomerUserEntry.Owner = _Owner;
            _CustomerUserEntry.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_Owner, userName, "Create CustomerUserEntryOwning", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            return Services.Packages.Security.Security.ModelUserSecureService.HasAccessImp(_Owner, userName, "Create CustomerUserEntryOwning", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_Owner, userName, "Create CustomerUserEntryOwning", false, SessionToken);
        }

		[WebMethod]
		public CustomerUserEntryCollection GetByUserLogin(Services.Packages.Security.ModelUser _ModelUser, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerUserEntryCollection c = CustomerUserEntry.GetByUserLogin( _ModelUser);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerUserEntrySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public CustomerUserEntryCollection GetByUserLoginPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerUserEntryCollection c = CustomerUserEntry.GetByUserLoginPaged( _ModelUser, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerUserEntrySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long GetByUserLoginCount(Services.Packages.Security.ModelUser _ModelUser, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return CustomerUserEntry.GetByUserLoginCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUserLogin(CustomerUserEntry _CustomerUserEntry, string SessionToken)
		{
			_CustomerUserEntry.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_CustomerUserEntry.UserLogin, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _CustomerUserEntry.UserLogin;
		}
		[WebMethod]
		public void SetUserLogin(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _UserLogin, string SessionToken)
		{
			_CustomerUserEntry.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_UserLogin.Reload();
			if (_UserLogin.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_UserLogin, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_UserLogin.Exists && !Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Create CustomerUserEntries"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_CustomerUserEntry.UserLogin = _UserLogin;
			_CustomerUserEntry.Update();
		}
		[WebMethod]
		public CustomerUserEntryCollection GetByCustomer(Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerUserEntryCollection c = CustomerUserEntry.GetByCustomer( _Customer);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerUserEntrySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public CustomerUserEntryCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerUserEntryCollection c = CustomerUserEntry.GetByCustomerPaged( _Customer, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerUserEntrySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
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
			
			return CustomerUserEntry.GetByCustomerCount( _Customer);
		}
		[WebMethod]
		public Services.Packages.Customer GetCustomer(CustomerUserEntry _CustomerUserEntry, string SessionToken)
		{
			_CustomerUserEntry.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_CustomerUserEntry.Customer, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _CustomerUserEntry.Customer;
		}
		[WebMethod]
		public void SetCustomer(CustomerUserEntry _CustomerUserEntry, Services.Packages.Customer _Customer, string SessionToken)
		{
			_CustomerUserEntry.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_Customer.Reload();
			if (_Customer.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Customer.Exists && !Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Create CustomerUserEntries"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_CustomerUserEntry.Customer = _Customer;
			_CustomerUserEntry.Update();
		}
		[WebMethod]
		public CustomerUserEntryCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerUserEntryCollection c = CustomerUserEntry.GetByOwner( _ModelUser);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerUserEntrySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public CustomerUserEntryCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerUserEntryCollection c = CustomerUserEntry.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerUserEntrySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
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
			
			return CustomerUserEntry.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(CustomerUserEntry _CustomerUserEntry, string SessionToken)
		{
			_CustomerUserEntry.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_CustomerUserEntry.Owner, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _CustomerUserEntry.Owner;
		}
		[WebMethod]
		public void SetOwner(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _Owner, string SessionToken)
		{
			_CustomerUserEntry.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_Owner.Reload();
			if (_Owner.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Owner.Exists && !Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Create CustomerUserEntryOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_CustomerUserEntry.Owner = _Owner;
			_CustomerUserEntry.Update();
		}
		[WebMethod]
		public Services.Packages.Security.CustomerUserEntryAccessControlListCollection GetACLs(CustomerUserEntry _CustomerUserEntry, string SessionToken)
		{
			_CustomerUserEntry.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.CustomerUserEntryAccessControlListSecureService.CheckAccessImp(_CustomerUserEntry.ACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _CustomerUserEntry.ACLs;
		}
		[WebMethod]
		public void SetACLs(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.CustomerUserEntryAccessControlListCollection _ACLs, string SessionToken)
		{
			_CustomerUserEntry.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ACLs.Reload();
			if (_ACLs.Exists && !Services.Packages.Security.Security.CustomerUserEntryAccessControlListSecureService.CheckAccessImp(_ACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ACLs.Exists && !Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Create ACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_CustomerUserEntry.ACLs = _ACLs;
			_CustomerUserEntry.Update();
		}

    }
    
namespace Web
{
	/// <summary>
	/// The WebService secure service provider that allows to create web services
	/// that share Services.Packages.CustomerUserEntry objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Security.Web.CustomerUserEntrySecureWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class CustomerUserEntrySecureWebService : WebService, ICustomerUserEntrySecureService
	{
		#region Secure service instance methods
        
        [WebMethod]
        public void EnableDisableSecurity(bool secure, string sessionToken)
        {
			CustomerUserEntrySecureService.EnableDisableSecurityImp(secure, sessionToken);
        }
        
        [WebMethod]
        public string[] GetUserRightDescriptors()
        {
			return CustomerUserEntrySecureService.GetUserRightDescriptorsImp();
        }
        
        [WebMethod]
        public void ChangeRights(string userName, string userRightDescriptor, bool allow, string SessionToken)
        {
			CustomerUserEntrySecureService.ChangeRightsImp(userName, userRightDescriptor, allow, SessionToken);
        }
        
        [WebMethod]
        public bool HasRights(string userName, string userRightDescriptor, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasRightsImp(userName, userRightDescriptor, SessionToken);
        }
        
		[WebMethod]
        public bool HasAccess(Services.Packages.CustomerUserEntry _object, string userName, string securityDescriptor, string SessionToken)
		{
			return CustomerUserEntrySecureService.HasAccessImp(_object, userName, securityDescriptor, SessionToken);
		}
		
		[WebMethod]
        public void ChangeAccess(Services.Packages.CustomerUserEntry _object, string userName, string securityDescriptor, bool allow, string SessionToken)
        {
			CustomerUserEntrySecureService.ChangeAccessImp(_object, userName, securityDescriptor, allow, SessionToken);
        }

        [WebMethod]
        public void SetObjectOwner(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.SetOwnerImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void SetDatabaseOwner(string userName)
        {
			CustomerUserEntrySecureService.SetDatabaseOwnerImp(userName);
        }
		
        [WebMethod]
        public string[] GetSecurityDescriptors()
        {
			return CustomerUserEntrySecureService.GetSecurityDescriptorsImp();
        }
        
        [WebMethod]
        public void AllowTraverse(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowTraverseImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowRead(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowReadImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowUpdate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowUpdateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowCreate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowCreateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowReadAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowReadAccessImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowChangeAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowChangeAccessImp(_object, userName, SessionToken);
        }
		
        [WebMethod]
        public bool HasTraverse(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasTraverseImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasRead(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasReadImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasUpdate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasUpdateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasCreate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasCreateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasReadAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasReadAccessImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasChangeAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasChangeAccessImp(_object, userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowTraverse(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowTraverseImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowRead(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowReadImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowUpdate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowUpdateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowCreate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowCreateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowReadAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowReadAccessImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowChangeAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowChangeAccessImp(_object, userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllTraverse(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowAllTraverseImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllRead(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowAllReadImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllUpdate(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowAllUpdateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllCreate(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowAllCreateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllReadAccess(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowAllReadAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllChangeAccess(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.AllowAllChangeAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllTraverse(string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasAllTraverseImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllRead(string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasAllReadImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllUpdate(string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasAllUpdateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllCreate(string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasAllCreateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllReadAccess(string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasAllReadAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllChangeAccess(string userName, string SessionToken)
        {
			return CustomerUserEntrySecureService.HasAllChangeAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllTraverse(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowAllTraverseImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllRead(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowAllReadImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllUpdate(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowAllUpdateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllCreate(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowAllCreateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllReadAccess(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowAllReadAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllChangeAccess(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DisallowAllChangeAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public string LoginAnonymous()
        {
			return CustomerUserEntrySecureService.LoginAnonymousImp();
        }
        
        [WebMethod]
        public string Login(string userName, string password)
        {
			return CustomerUserEntrySecureService.LoginImp(userName, password);
        }
        
        [WebMethod]
        public void SwitchUser(string userName, string password, string existingSessionToken)
        {
			CustomerUserEntrySecureService.SwitchUserImp(userName, password, existingSessionToken);
        }

        [WebMethod]
        public bool SessionExists(string sessionToken)
        {
			return CustomerUserEntrySecureService.SessionExistsImp(sessionToken);
        }

        [WebMethod]
        public void LogoutSession(string sessionToken, bool keepSession)
        {
			CustomerUserEntrySecureService.LogoutSessionImp(sessionToken, keepSession);
        }
        
        [WebMethod]
        public void LogoutAllSessions(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.LogoutAllSessionsImp(userName, SessionToken);
        }
		
		[WebMethod]
        public ModelUser GetCurrentUser(string SessionToken)
		{
			return CustomerUserEntrySecureService.GetCurrentUserImp(SessionToken);
        }

		[WebMethod]
        public ModelUser GetUser(string userName, string SessionToken)
		{
			return CustomerUserEntrySecureService.GetUserImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void SetUserByObject(ModelUser userObject, string SessionToken)
		{
			CustomerUserEntrySecureService.SetUserByObjectImp(userObject, SessionToken);
        }
        
        [WebMethod]
        public void AddUser(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			CustomerUserEntrySecureService.AddUserImp(userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken);
        }

        [WebMethod]
        public void UpdateUser(string userName, string oldPassword, string email, string secretQuestion,
            string secretAnswer, string SessionToken)
        {
			CustomerUserEntrySecureService.UpdateUserImp(userName, oldPassword, email, secretQuestion,
				secretAnswer, SessionToken);
        }
        
        [WebMethod]
        public void UpdateUserWithEnable(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			CustomerUserEntrySecureService.UpdateUserImp(userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken);
        }
        
        [WebMethod]
        public void DeleteUser(string userName, string SessionToken)
        {
			CustomerUserEntrySecureService.DeleteUserImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void ChangePassword(string userName, string oldPassword, string newPassword, string SessionToken)
        {
			CustomerUserEntrySecureService.ChangePasswordImp(userName, oldPassword, newPassword, SessionToken);
        }
        
        [WebMethod]
        public string CreateRandomPassword(string userName, string answer, string SessionToken)
        {
			return CustomerUserEntrySecureService.CreateRandomPasswordImp(userName, answer, SessionToken);
        }

        [WebMethod]
        public Securable GetSecurable(string SessionToken)
        {
			return CustomerUserEntrySecureService.GetSecurableImp(SessionToken);
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
        public bool Exists(CustomerUserEntry _CustomerUserEntry, string SessionToken)
        {
			if (!CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _CustomerUserEntry.Exists;
        }
		
		[WebMethod]
		public CustomerUserEntry Read(System.Int32 __Id, string SessionToken)
		{
			CustomerUserEntry _CustomerUserEntry = new CustomerUserEntry(__Id);
			
			if (!CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _CustomerUserEntry;
		}
		
		[WebMethod]
        public CustomerUserEntry Reload(CustomerUserEntry _CustomerUserEntry, string SessionToken)
        {
			_CustomerUserEntry.Reload();
			
			if (!CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _CustomerUserEntry;
        }
		
		[WebMethod]
        public CustomerUserEntry Create(System.Int32 __Id, string SessionToken)
        {
			ModelSession session = CustomerUserEntrySecureService.CheckSessionImp(SessionToken);

            if (!CustomerUserEntrySecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(CustomerUserEntry).FullName))
				throw new UnauthorizedAccessException("Access Denied");
            
            CustomerUserEntry _CustomerUserEntry = CustomerUserEntry.CreateCustomerUserEntry(__Id);
            _CustomerUserEntry.Owner = session.User;
            _CustomerUserEntry.Update();
			return _CustomerUserEntry;
        }
        
        [WebMethod]
        public void Delete(System.Int32 __Id, string SessionToken)
        {
			CustomerUserEntry _CustomerUserEntry = new CustomerUserEntry(__Id);
			
			if (!CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Delete"))
				throw new UnauthorizedAccessException("Access Denied");
			
			CustomerUserEntry.DeleteCustomerUserEntry(__Id);
        }
        
        [WebMethod]
        public void UpdateObject(CustomerUserEntry _CustomerUserEntry, string SessionToken)
        {
			if (!CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_CustomerUserEntry.Update();
        }
		
		[WebMethod]
        public void CreateObject(CustomerUserEntry _CustomerUserEntry, string SessionToken)
        {
			ModelSession session = CustomerUserEntrySecureService.CheckSessionImp(SessionToken);

            if (!CustomerUserEntrySecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(CustomerUserEntry).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			_CustomerUserEntry.Owner = session.User;
            _CustomerUserEntry.Create();
        }
        
        [WebMethod]
        public void DeleteObject(CustomerUserEntry _CustomerUserEntry, string SessionToken)
        {
			if (!CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Delete"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_CustomerUserEntry.Delete();
        }

		[WebMethod]
        public void Undo(string SessionToken)
        {
			ModelSession session = CustomerUserEntrySecureService.CheckSessionImp(SessionToken);

			// Must have all available access to the class level (all objects)
			if (!CustomerUserEntrySecureService.CheckUserRightsImp(session.User.Name, "Update " + typeof(CustomerUserEntry).FullName) ||
				!CustomerUserEntrySecureService.CheckUserRightsImp(session.User.Name, "Delete " + typeof(CustomerUserEntry).FullName) ||
				!CustomerUserEntrySecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(CustomerUserEntry).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			CustomerUserEntry.Undo();
        }

		[WebMethod]
        public void Redo(string SessionToken)
        {
			ModelSession session = CustomerUserEntrySecureService.CheckSessionImp(SessionToken);

			// Must have all available access to the class level (all objects)
			if (!CustomerUserEntrySecureService.CheckUserRightsImp(session.User.Name, "Update " + typeof(CustomerUserEntry).FullName) ||
				!CustomerUserEntrySecureService.CheckUserRightsImp(session.User.Name, "Delete " + typeof(CustomerUserEntry).FullName) ||
				!CustomerUserEntrySecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(CustomerUserEntry).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			CustomerUserEntry.Redo();
        }

        		
		[WebMethod]
        public CustomerUserEntry CreateFromUserLogin(System.Int32 __Id, Services.Packages.Security.ModelUser _UserLogin, string SessionToken)
        {
			ModelSession session = CustomerUserEntrySecureService.CheckSessionImp(SessionToken);

			CustomerUserEntry _CustomerUserEntry = new CustomerUserEntry(__Id);
            
            if (!_CustomerUserEntry.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_UserLogin, SessionToken, "Create CustomerUserEntries"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_CustomerUserEntry.Exists && !CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // CustomerUserEntry _CustomerUserEntry = CustomerUserEntry.CreateCustomerUserEntry(__Id);
            _CustomerUserEntry.Owner = session.User;
            _CustomerUserEntry.UserLogin = _UserLogin;
            _CustomerUserEntry.Update();
			return _CustomerUserEntry;
        }
        
        [WebMethod]
        public void CreateObjectFromUserLogin(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _UserLogin, string SessionToken)
        {
			ModelSession session = CustomerUserEntrySecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_UserLogin, SessionToken, "Create CustomerUserEntries"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_CustomerUserEntry.Reload();
			
			if (!_CustomerUserEntry.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_UserLogin, SessionToken, "Create CustomerUserEntries"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_CustomerUserEntry.Exists && !CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_CustomerUserEntry.Owner = session.User;
            _CustomerUserEntry.UserLogin = _UserLogin;
            _CustomerUserEntry.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromUserLogin(Services.Packages.Security.ModelUser _UserLogin, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_UserLogin, userName, "Create CustomerUserEntries", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromUserLogin(Services.Packages.Security.ModelUser _UserLogin, string userName, string SessionToken)
        {
            return Services.Packages.Security.Security.ModelUserSecureService.HasAccessImp(_UserLogin, userName, "Create CustomerUserEntries", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromUserLogin(Services.Packages.Security.ModelUser _UserLogin, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_UserLogin, userName, "Create CustomerUserEntries", false, SessionToken);
        }
		
		[WebMethod]
        public CustomerUserEntry CreateFromCustomer(System.Int32 __Id, Services.Packages.Customer _Customer, string SessionToken)
        {
			ModelSession session = CustomerUserEntrySecureService.CheckSessionImp(SessionToken);

			CustomerUserEntry _CustomerUserEntry = new CustomerUserEntry(__Id);
            
            if (!_CustomerUserEntry.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create CustomerUserEntries"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_CustomerUserEntry.Exists && !CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // CustomerUserEntry _CustomerUserEntry = CustomerUserEntry.CreateCustomerUserEntry(__Id);
            _CustomerUserEntry.Owner = session.User;
            _CustomerUserEntry.Customer = _Customer;
            _CustomerUserEntry.Update();
			return _CustomerUserEntry;
        }
        
        [WebMethod]
        public void CreateObjectFromCustomer(CustomerUserEntry _CustomerUserEntry, Services.Packages.Customer _Customer, string SessionToken)
        {
			ModelSession session = CustomerUserEntrySecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create CustomerUserEntries"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_CustomerUserEntry.Reload();
			
			if (!_CustomerUserEntry.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create CustomerUserEntries"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_CustomerUserEntry.Exists && !CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_CustomerUserEntry.Owner = session.User;
            _CustomerUserEntry.Customer = _Customer;
            _CustomerUserEntry.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromCustomer(Services.Packages.Customer _Customer, string userName, string SessionToken)
        {
            Services.Packages.Security.CustomerSecureService.ChangeAccessImp(_Customer, userName, "Create CustomerUserEntries", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromCustomer(Services.Packages.Customer _Customer, string userName, string SessionToken)
        {
            return Services.Packages.Security.CustomerSecureService.HasAccessImp(_Customer, userName, "Create CustomerUserEntries", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromCustomer(Services.Packages.Customer _Customer, string userName, string SessionToken)
        {
            Services.Packages.Security.CustomerSecureService.ChangeAccessImp(_Customer, userName, "Create CustomerUserEntries", false, SessionToken);
        }
		
		[WebMethod]
        public CustomerUserEntry CreateFromOwner(System.Int32 __Id, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			ModelSession session = CustomerUserEntrySecureService.CheckSessionImp(SessionToken);

			CustomerUserEntry _CustomerUserEntry = new CustomerUserEntry(__Id);
            
            if (!_CustomerUserEntry.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create CustomerUserEntryOwning"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_CustomerUserEntry.Exists && !CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // CustomerUserEntry _CustomerUserEntry = CustomerUserEntry.CreateCustomerUserEntry(__Id);
            _CustomerUserEntry.Owner = session.User;
            _CustomerUserEntry.Owner = _Owner;
            _CustomerUserEntry.Update();
			return _CustomerUserEntry;
        }
        
        [WebMethod]
        public void CreateObjectFromOwner(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			ModelSession session = CustomerUserEntrySecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create CustomerUserEntryOwning"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_CustomerUserEntry.Reload();
			
			if (!_CustomerUserEntry.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create CustomerUserEntryOwning"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_CustomerUserEntry.Exists && !CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_CustomerUserEntry.Owner = session.User;
            _CustomerUserEntry.Owner = _Owner;
            _CustomerUserEntry.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_Owner, userName, "Create CustomerUserEntryOwning", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            return Services.Packages.Security.Security.ModelUserSecureService.HasAccessImp(_Owner, userName, "Create CustomerUserEntryOwning", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_Owner, userName, "Create CustomerUserEntryOwning", false, SessionToken);
        }

		[WebMethod]
		public CustomerUserEntryCollection GetByUserLogin(Services.Packages.Security.ModelUser _ModelUser, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerUserEntryCollection c = CustomerUserEntry.GetByUserLogin( _ModelUser);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerUserEntrySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public CustomerUserEntryCollection GetByUserLoginPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerUserEntryCollection c = CustomerUserEntry.GetByUserLoginPaged( _ModelUser, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerUserEntrySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long GetByUserLoginCount(Services.Packages.Security.ModelUser _ModelUser, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return CustomerUserEntry.GetByUserLoginCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUserLogin(CustomerUserEntry _CustomerUserEntry, string SessionToken)
		{
			_CustomerUserEntry.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_CustomerUserEntry.UserLogin, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _CustomerUserEntry.UserLogin;
		}
		[WebMethod]
		public void SetUserLogin(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _UserLogin, string SessionToken)
		{
			_CustomerUserEntry.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_UserLogin.Reload();
			if (_UserLogin.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_UserLogin, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_UserLogin.Exists && !Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Create CustomerUserEntries"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_CustomerUserEntry.UserLogin = _UserLogin;
			_CustomerUserEntry.Update();
		}
		[WebMethod]
		public CustomerUserEntryCollection GetByCustomer(Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerUserEntryCollection c = CustomerUserEntry.GetByCustomer( _Customer);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerUserEntrySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public CustomerUserEntryCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerUserEntryCollection c = CustomerUserEntry.GetByCustomerPaged( _Customer, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerUserEntrySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
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
			
			return CustomerUserEntry.GetByCustomerCount( _Customer);
		}
		[WebMethod]
		public Services.Packages.Customer GetCustomer(CustomerUserEntry _CustomerUserEntry, string SessionToken)
		{
			_CustomerUserEntry.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_CustomerUserEntry.Customer, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _CustomerUserEntry.Customer;
		}
		[WebMethod]
		public void SetCustomer(CustomerUserEntry _CustomerUserEntry, Services.Packages.Customer _Customer, string SessionToken)
		{
			_CustomerUserEntry.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_Customer.Reload();
			if (_Customer.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Customer.Exists && !Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Create CustomerUserEntries"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_CustomerUserEntry.Customer = _Customer;
			_CustomerUserEntry.Update();
		}
		[WebMethod]
		public CustomerUserEntryCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerUserEntryCollection c = CustomerUserEntry.GetByOwner( _ModelUser);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerUserEntrySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public CustomerUserEntryCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerUserEntryCollection c = CustomerUserEntry.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerUserEntrySecureService.CheckAccessImp(c[n], SessionToken, "Read"))
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
			
			return CustomerUserEntry.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(CustomerUserEntry _CustomerUserEntry, string SessionToken)
		{
			_CustomerUserEntry.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_CustomerUserEntry.Owner, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _CustomerUserEntry.Owner;
		}
		[WebMethod]
		public void SetOwner(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _Owner, string SessionToken)
		{
			_CustomerUserEntry.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_Owner.Reload();
			if (_Owner.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Owner.Exists && !Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Create CustomerUserEntryOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_CustomerUserEntry.Owner = _Owner;
			_CustomerUserEntry.Update();
		}
		[WebMethod]
		public Services.Packages.Security.CustomerUserEntryAccessControlListCollection GetACLs(CustomerUserEntry _CustomerUserEntry, string SessionToken)
		{
			_CustomerUserEntry.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.CustomerUserEntryAccessControlListSecureService.CheckAccessImp(_CustomerUserEntry.ACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _CustomerUserEntry.ACLs;
		}
		[WebMethod]
		public void SetACLs(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.CustomerUserEntryAccessControlListCollection _ACLs, string SessionToken)
		{
			_CustomerUserEntry.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ACLs.Reload();
			if (_ACLs.Exists && !Services.Packages.Security.Security.CustomerUserEntryAccessControlListSecureService.CheckAccessImp(_ACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ACLs.Exists && !Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntry, SessionToken, "Create ACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_CustomerUserEntry.ACLs = _ACLs;
			_CustomerUserEntry.Update();
		}

	}
	
	/// <summary>
	/// The WebService secure client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="CustomerUserEntryWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("480f7050-baa3-1c89-7381-e629cd622212")]
    sealed public class CustomerUserEntrySecureWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, ICustomerUserEntrySecureService
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
		public CustomerUserEntrySecureWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public CustomerUserEntrySecureWebServiceClient()
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
		public bool HasAccess(Services.Packages.CustomerUserEntry _object, string userName, string securityDescriptor, string SessionToken)
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
		public void ChangeAccess(Services.Packages.CustomerUserEntry _object, string userName, string securityDescriptor, bool allow, string SessionToken)
        {
			this.Invoke("ChangeAccess", new object[] {_object, userName, securityDescriptor, allow, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetObjectOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetObjectOwner(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
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
		public void AllowTraverse(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			this.Invoke("AllowTraverse", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowRead", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowRead(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			this.Invoke("AllowRead", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowUpdate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowUpdate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			this.Invoke("AllowUpdate", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowCreate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowCreate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			this.Invoke("AllowCreate", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowReadAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowReadAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			this.Invoke("AllowReadAccess", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowChangeAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowChangeAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			this.Invoke("AllowChangeAccess", new object[] {_object, userName, SessionToken});
			return;
        }
		
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasTraverse", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasTraverse(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasTraverse", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasRead", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasRead(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasRead", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasUpdate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasUpdate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasUpdate", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasCreate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasCreate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasCreate", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasReadAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasReadAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasReadAccess", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasChangeAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasChangeAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasChangeAccess", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowTraverse", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowTraverse(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowTraverse", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowRead", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowRead(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowRead", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowUpdate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowUpdate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowUpdate", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowCreate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowCreate(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowCreate", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowReadAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowReadAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowReadAccess", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowChangeAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowChangeAccess(Services.Packages.CustomerUserEntry _object, string userName, string SessionToken)
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
		public bool Exists(CustomerUserEntry _CustomerUserEntry, string SessionToken)
        {
			object[] results = this.Invoke("Exists", new object[] {_CustomerUserEntry,SessionToken});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntry Read(System.Int32 __Id, string SessionToken)
		{
			object[] results = this.Invoke("Read", new object[] {__Id, SessionToken});
			return ((CustomerUserEntry)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntry Reload(CustomerUserEntry _CustomerUserEntry, string SessionToken)
        {
			object[] results = this.Invoke("Reload", new object[] {_CustomerUserEntry,SessionToken});
			return ((CustomerUserEntry)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntry Create(System.Int32 __Id, string SessionToken)
        {
			object[] results = this.Invoke("Create", new object[] {__Id, SessionToken});
			return ((CustomerUserEntry)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.Int32 __Id, string SessionToken)
        {
			this.Invoke("Delete", new object[] {__Id, SessionToken});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(CustomerUserEntry _CustomerUserEntry, string SessionToken)
        {
			this.Invoke("UpdateObject", new object[] {_CustomerUserEntry,SessionToken});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(CustomerUserEntry _CustomerUserEntry, string SessionToken)
        {
			this.Invoke("CreateObject", new object[] {_CustomerUserEntry,SessionToken});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(CustomerUserEntry _CustomerUserEntry, string SessionToken)
        {
			this.Invoke("DeleteObject", new object[] {_CustomerUserEntry,SessionToken});
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
        		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateFromUserLogin", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntry CreateFromUserLogin(System.Int32 __Id, Services.Packages.Security.ModelUser _UserLogin, string SessionToken)
        {
			object[] results = this.Invoke("Create", new object[] {__Id, _UserLogin,SessionToken});
			return ((CustomerUserEntry)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObjectFromUserLogin", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObjectFromUserLogin(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _UserLogin, string SessionToken)
        {
			this.Invoke("CreateObjectFromUserLogin", new object[] {_CustomerUserEntry,_UserLogin,SessionToken});
			return;
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowCreateObjectFromUserLogin", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowCreateFromUserLogin(Services.Packages.Security.ModelUser _UserLogin, string userName, string SessionToken)
        {
            this.Invoke("AllowCreateFromUserLogin", new object[] {_UserLogin, userName, SessionToken});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasCreateObjectFromUserLogin", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasCreateFromUserLogin(Services.Packages.Security.ModelUser _UserLogin, string userName, string SessionToken)
        {
            object[] results = this.Invoke("HasCreateFromUserLogin", new object[] {_UserLogin, userName, SessionToken});
			return ((bool)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowCreateObjectFromUserLogin", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowCreateFromUserLogin(Services.Packages.Security.ModelUser _UserLogin, string userName, string SessionToken)
        {
            this.Invoke("DisallowObjectFromUserLogin", new object[] {_UserLogin, userName, SessionToken});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateFromCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntry CreateFromCustomer(System.Int32 __Id, Services.Packages.Customer _Customer, string SessionToken)
        {
			object[] results = this.Invoke("Create", new object[] {__Id, _Customer,SessionToken});
			return ((CustomerUserEntry)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObjectFromCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObjectFromCustomer(CustomerUserEntry _CustomerUserEntry, Services.Packages.Customer _Customer, string SessionToken)
        {
			this.Invoke("CreateObjectFromCustomer", new object[] {_CustomerUserEntry,_Customer,SessionToken});
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
		public CustomerUserEntry CreateFromOwner(System.Int32 __Id, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			object[] results = this.Invoke("Create", new object[] {__Id, _Owner,SessionToken});
			return ((CustomerUserEntry)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObjectFromOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObjectFromOwner(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			this.Invoke("CreateObjectFromOwner", new object[] {_CustomerUserEntry,_Owner,SessionToken});
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

		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserLogin", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryCollection GetByUserLogin(Services.Packages.Security.ModelUser _ModelUser, string SessionToken) {
			object[] results = this.Invoke("GetByUserLogin", new object[] {_ModelUser,SessionToken});
			return ((CustomerUserEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserLoginPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryCollection GetByUserLoginPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("GetByUserLoginPaged", new object[] {_ModelUser,PagingStart,PagingCount,SessionToken});
			return ((CustomerUserEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserLoginCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByUserLoginCount(Services.Packages.Security.ModelUser _ModelUser, string SessionToken) {
			object[] results = this.Invoke("GetByUserLoginCount", new object[] {_ModelUser,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetUserLogin", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetUserLogin(CustomerUserEntry _CustomerUserEntry, string SessionToken)
		{
			object[] results = this.Invoke("GetUserLogin", new object[] {_CustomerUserEntry,SessionToken});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetUserLogin", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetUserLogin(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _UserLogin, string SessionToken)
		{
			this.Invoke("GetUserLogin", new object[] {_CustomerUserEntry,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryCollection GetByCustomer(Services.Packages.Customer _Customer, string SessionToken) {
			object[] results = this.Invoke("GetByCustomer", new object[] {_Customer,SessionToken});
			return ((CustomerUserEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByCustomerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("GetByCustomerPaged", new object[] {_Customer,PagingStart,PagingCount,SessionToken});
			return ((CustomerUserEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByCustomerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByCustomerCount(Services.Packages.Customer _Customer, string SessionToken) {
			object[] results = this.Invoke("GetByCustomerCount", new object[] {_Customer,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Customer GetCustomer(CustomerUserEntry _CustomerUserEntry, string SessionToken)
		{
			object[] results = this.Invoke("GetCustomer", new object[] {_CustomerUserEntry,SessionToken});
			return ((Services.Packages.Customer)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetCustomer(CustomerUserEntry _CustomerUserEntry, Services.Packages.Customer _Customer, string SessionToken)
		{
			this.Invoke("GetCustomer", new object[] {_CustomerUserEntry,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser, string SessionToken) {
			object[] results = this.Invoke("GetByOwner", new object[] {_ModelUser,SessionToken});
			return ((CustomerUserEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("GetByOwnerPaged", new object[] {_ModelUser,PagingStart,PagingCount,SessionToken});
			return ((CustomerUserEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser, string SessionToken) {
			object[] results = this.Invoke("GetByOwnerCount", new object[] {_ModelUser,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetOwner(CustomerUserEntry _CustomerUserEntry, string SessionToken)
		{
			object[] results = this.Invoke("GetOwner", new object[] {_CustomerUserEntry,SessionToken});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetOwner(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _Owner, string SessionToken)
		{
			this.Invoke("GetOwner", new object[] {_CustomerUserEntry,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.CustomerUserEntryAccessControlListCollection GetACLs(CustomerUserEntry _CustomerUserEntry, string SessionToken)
		{
			object[] results = this.Invoke("GetACLs", new object[] {_CustomerUserEntry,SessionToken});
			return ((Services.Packages.Security.CustomerUserEntryAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACLs(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.CustomerUserEntryAccessControlListCollection _ACLs, string SessionToken)
		{
			this.Invoke("GetACLs", new object[] {_CustomerUserEntry,SessionToken});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages
