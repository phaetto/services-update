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

namespace Services.Packages.Log.Security
{	
	/// <summary>
    /// Defines the secure contract for all the service-based types which can
    /// apply servicing on Services.Packages.Log.ApplicationException type.
    /// </summary>
    [ComVisible(true)]
    [Guid("72633f1e-d066-f23c-44ca-cb794c66c147")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IApplicationExceptionSecureService
    {
		#region Securable interface definitions
        void EnableDisableSecurity(bool secure, string sessionToken);
        
        string[] GetUserRightDescriptors();
        bool HasRights(string userName, string userRightDescriptor, string SessionToken);
		void ChangeRights(string userName, string userRightDescriptor, bool allow, string SessionToken);
		void ChangeAccess(Services.Packages.Log.ApplicationException _object, string userName, string securityDescriptor, bool allow, string SessionToken);
		bool HasAccess(Services.Packages.Log.ApplicationException _object, string userName, string securityDescriptor, string SessionToken);
        
        void SetObjectOwner(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken);
        void SetDatabaseOwner(string userName);
        
        string[] GetSecurityDescriptors();
        void AllowTraverse(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken);
        void AllowRead(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken);
        void AllowUpdate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken);
        void AllowCreate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken);
        void AllowReadAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken);
        void AllowChangeAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken);
        bool HasTraverse(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken);
        bool HasRead(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken);
        bool HasUpdate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken);
        bool HasCreate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken);
        bool HasReadAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken);
        bool HasChangeAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken);
        void DisallowTraverse(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken);
        void DisallowRead(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken);
        void DisallowUpdate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken);
        void DisallowCreate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken);
        void DisallowReadAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken);
        void DisallowChangeAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken);
        
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
        bool Exists(ApplicationException _ApplicationException, string SessionToken);
		[OperationContract]
        ApplicationException Read(System.Int32 __Id, string SessionToken);
        [OperationContract]
        ApplicationException Reload(ApplicationException _ApplicationException, string SessionToken);
        [OperationContract]
        ApplicationException Create(System.Int32 __Id, string SessionToken);
        [OperationContract]
        void Delete(System.Int32 __Id, string SessionToken);
        [OperationContract]
        void UpdateObject(ApplicationException _ApplicationException, string SessionToken);
        [OperationContract]
        void CreateObject(ApplicationException _ApplicationException, string SessionToken);
        [OperationContract]
        void DeleteObject(ApplicationException _ApplicationException, string SessionToken);
        [OperationContract]
        void Undo(string SessionToken);
        [OperationContract]
        void Redo(string SessionToken);
        		
		[OperationContract]
        ApplicationException CreateFromApiKey(System.Int32 __Id, Services.Packages.ApiKey _ApiKey, string SessionToken);
        [OperationContract]
        void CreateObjectFromApiKey(ApplicationException _ApplicationException, Services.Packages.ApiKey _ApiKey, string SessionToken);
        [OperationContract]
        void AllowCreateFromApiKey(Services.Packages.ApiKey _ApiKey, string userName, string SessionToken);
		[OperationContract]
        bool HasCreateFromApiKey(Services.Packages.ApiKey _ApiKey, string userName, string SessionToken);
        [OperationContract]
        void DisallowCreateFromApiKey(Services.Packages.ApiKey _ApiKey, string userName, string SessionToken);
		
		[OperationContract]
        ApplicationException CreateFromParentException(System.Int32 __Id, Services.Packages.Log.ApplicationException _ParentException, string SessionToken);
        [OperationContract]
        void CreateObjectFromParentException(ApplicationException _ApplicationException, Services.Packages.Log.ApplicationException _ParentException, string SessionToken);
        [OperationContract]
        void AllowCreateFromParentException(Services.Packages.Log.ApplicationException _ParentException, string userName, string SessionToken);
		[OperationContract]
        bool HasCreateFromParentException(Services.Packages.Log.ApplicationException _ParentException, string userName, string SessionToken);
        [OperationContract]
        void DisallowCreateFromParentException(Services.Packages.Log.ApplicationException _ParentException, string userName, string SessionToken);
		
		[OperationContract]
        ApplicationException CreateFromOwner(System.Int32 __Id, Services.Packages.Security.ModelUser _Owner, string SessionToken);
        [OperationContract]
        void CreateObjectFromOwner(ApplicationException _ApplicationException, Services.Packages.Security.ModelUser _Owner, string SessionToken);
        [OperationContract]
        void AllowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken);
		[OperationContract]
        bool HasCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken);
        [OperationContract]
        void DisallowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken);

		[OperationContract]
		ApplicationExceptionCollection GetByApiKey(Services.Packages.ApiKey _ApiKey, string SessionToken);
		[OperationContract]
		ApplicationExceptionCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey, string SessionToken);
		[OperationContract]
		Services.Packages.ApiKey GetApiKey(ApplicationException _ApplicationException, string SessionToken);
		[OperationContract]
		void SetApiKey(ApplicationException _ApplicationException, Services.Packages.ApiKey _ApiKey, string SessionToken);
		[OperationContract]
		ApplicationExceptionCollection GetByParentException(Services.Packages.Log.ApplicationException _ApplicationException, string SessionToken);
		[OperationContract]
		ApplicationExceptionCollection GetByParentExceptionPaged(Services.Packages.Log.ApplicationException _ApplicationException, long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long GetByParentExceptionCount(Services.Packages.Log.ApplicationException _ApplicationException, string SessionToken);
		[OperationContract]
		Services.Packages.Log.ApplicationException GetParentException(ApplicationException _ApplicationException, string SessionToken);
		[OperationContract]
		void SetParentException(ApplicationException _ApplicationException, Services.Packages.Log.ApplicationException _ParentException, string SessionToken);
		[OperationContract]
		ApplicationExceptionCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		ApplicationExceptionCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		Services.Packages.Security.ModelUser GetOwner(ApplicationException _ApplicationException, string SessionToken);
		[OperationContract]
		void SetOwner(ApplicationException _ApplicationException, Services.Packages.Security.ModelUser _Owner, string SessionToken);
		[OperationContract]
		ApplicationExceptionCollection SearchByName(System.String Message , string SessionToken);
		[OperationContract]
		ApplicationExceptionCollection SearchByNamePaged(System.String Message , long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long SearchByNameCount(System.String Message , string SessionToken);
		[OperationContract]
		ApplicationExceptionCollection SearchByNameSolved(System.String Message, System.Boolean IsSolved , string SessionToken);
		[OperationContract]
		ApplicationExceptionCollection SearchByNameSolvedPaged(System.String Message, System.Boolean IsSolved , long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long SearchByNameSolvedCount(System.String Message, System.Boolean IsSolved , string SessionToken);
		[OperationContract]
		ApplicationExceptionCollection SearchByNameOnApiKey(System.String Message, Services.Packages.ApiKey _ApiKey, string SessionToken);
		[OperationContract]
		ApplicationExceptionCollection SearchByNameOnApiKeyPaged(System.String Message, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long SearchByNameOnApiKeyCount(System.String Message, Services.Packages.ApiKey _ApiKey, string SessionToken);
		[OperationContract]
		ApplicationExceptionCollection SearchByNameSolvedOnApiKey(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey, string SessionToken);
		[OperationContract]
		ApplicationExceptionCollection SearchByNameSolvedOnApiKeyPaged(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long SearchByNameSolvedOnApiKeyCount(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey, string SessionToken);
		[OperationContract]
		Services.Packages.Log.ApplicationExceptionCollection GetInnerExceptions(ApplicationException _ApplicationException, string SessionToken);
		[OperationContract]
		void SetInnerExceptions(ApplicationException _ApplicationException, Services.Packages.Log.ApplicationExceptionCollection _InnerExceptions, string SessionToken);
		[OperationContract]
		Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection GetACLs(ApplicationException _ApplicationException, string SessionToken);
		[OperationContract]
		void SetACLs(ApplicationException _ApplicationException, Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection _ACLs, string SessionToken);

    }
    
    /// <summary>
    /// WCF and default secure implementation of a service object for Services.Packages.Log.ApplicationException type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("3683dd68-130d-8ce2-554d-427219864a57")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class ApplicationExceptionSecureService : IApplicationExceptionSecureService
    {
		#region Securable persistence

        internal static bool IsSecurableImp
        {
            get
            {
                Securable s = new Securable(typeof(ApplicationExceptionSecureService).FullName);
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

            Securable s = new Securable(typeof(ApplicationExceptionSecureService).FullName);
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
		
		internal static void ChangeAccessImp(Services.Packages.Log.ApplicationException _object, string userName, string securityDescriptor, bool allow, string SessionToken)
		{
			// Check if user can do that
            ModelSession session = CheckSessionImp(SessionToken);

            if (CheckAccessImp(_object, SessionToken, "ChangeAccess"))
            {
                try
                {
                    ApplicationExceptionAccessControlListCollection acls = _object.GetACLs(userName);
                    ApplicationExceptionAccessControlList acl;

                    if (acls.Count == 0)
                    {
                        acl = new ApplicationExceptionAccessControlList();
                        acl.UserName = userName;
                        acl.ApplicationException = _object;
                        acl.Create();
                    }
                    else
                    {
                        acl = acls[0];
                    }

                    ApplicationExceptionAccessControlEntry entry = new ApplicationExceptionAccessControlEntry();
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
        
        internal static void SetOwnerImp(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
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
		
        internal static void AllowTraverseImp(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Traverse", true, SessionToken);
        }

        internal static void AllowReadImp(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Read", true, SessionToken);
        }

        internal static void AllowUpdateImp(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Update", true, SessionToken);
        }

        internal static void AllowCreateImp(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
            // ChangeAccessImp(_object, userName, "Create " + typeof(Services.Packages.Log.ApplicationException).FullName, true, SessionToken);
            throw new NotImplementedException();
        }

        internal static void AllowReadAccessImp(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "ReadAccess", true, SessionToken);
        }

        internal static void AllowChangeAccessImp(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "ChangeAccess", true, SessionToken);
        }
        
        // Security check
		
        internal static bool HasTraverseImp(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			return HasAccessImp(_object, userName, "Traverse", SessionToken);
		}

        internal static bool HasReadImp(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			return HasAccessImp(_object, userName, "Read", SessionToken);
		}

        internal static bool HasUpdateImp(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
            return HasAccessImp(_object, userName, "Update", SessionToken);
		}

        internal static bool HasCreateImp(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
            // ChangeAccessImp(_object, userName, "Create " + typeof(Services.Packages.Log.ApplicationException).FullName, true, SessionToken);
            throw new NotImplementedException();
        }

        internal static bool HasReadAccessImp(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
            return HasAccessImp(_object, userName, "ReadAccess", SessionToken);
        }

        internal static bool HasChangeAccessImp(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
            return HasAccessImp(_object, userName, "ChangeAccess", SessionToken);
        }
        
        // Disallow
        
        internal static void DisallowTraverseImp(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Traverse", false, SessionToken);
        }

        internal static void DisallowReadImp(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Read", false, SessionToken);
        }

        internal static void DisallowUpdateImp(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Update", false, SessionToken);
        }

        internal static void DisallowCreateImp(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
            // ChangeAccessImp(_object, userName, "Create " + typeof(Services.Packages.Log.ApplicationException).FullName, false, SessionToken);
            throw new NotImplementedException();
        }

        internal static void DisallowReadAccessImp(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "ReadAccess", false, SessionToken);
        }

        internal static void DisallowChangeAccessImp(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "ChangeAccess", false, SessionToken);
        }
        
        // General object security methods
        
        internal static void AllowAllTraverseImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Traverse " + typeof(Services.Packages.Log.ApplicationException).FullName, true, SessionToken);
        }
        
        internal static void AllowAllReadImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Read " + typeof(Services.Packages.Log.ApplicationException).FullName, true, SessionToken);
        }
        
        internal static void AllowAllUpdateImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Update " + typeof(Services.Packages.Log.ApplicationException).FullName, true, SessionToken);
        }
        
        internal static void AllowAllCreateImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Create " + typeof(Services.Packages.Log.ApplicationException).FullName, true, SessionToken);
        }
        
        internal static void AllowAllReadAccessImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "ReadAccess " + typeof(Services.Packages.Log.ApplicationException).FullName, true, SessionToken);
        }
        
        internal static void AllowAllChangeAccessImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "ChangeAccess " + typeof(Services.Packages.Log.ApplicationException).FullName, true, SessionToken);
        }
        
        internal static bool HasAllTraverseImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "Traverse " + typeof(Services.Packages.Log.ApplicationException).FullName, SessionToken);
        }
        
        internal static bool HasAllReadImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "Read " + typeof(Services.Packages.Log.ApplicationException).FullName, SessionToken);
        }
        
        internal static bool HasAllUpdateImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "Update " + typeof(Services.Packages.Log.ApplicationException).FullName, SessionToken);
        }
        
        internal static bool HasAllCreateImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "Create " + typeof(Services.Packages.Log.ApplicationException).FullName, SessionToken);
        }
        
        internal static bool HasAllReadAccessImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "ReadAccess " + typeof(Services.Packages.Log.ApplicationException).FullName, SessionToken);
        }
        
        internal static bool HasAllChangeAccessImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "ChangeAccess " + typeof(Services.Packages.Log.ApplicationException).FullName, SessionToken);
        }
        
        internal static void DisallowAllTraverseImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Traverse " + typeof(Services.Packages.Log.ApplicationException).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllReadImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Read " + typeof(Services.Packages.Log.ApplicationException).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllUpdateImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Update " + typeof(Services.Packages.Log.ApplicationException).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllCreateImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Create " + typeof(Services.Packages.Log.ApplicationException).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllReadAccessImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "ReadAccess " + typeof(Services.Packages.Log.ApplicationException).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllChangeAccessImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "ChangeAccess " + typeof(Services.Packages.Log.ApplicationException).FullName, false, SessionToken);
        }
        
        #endregion
        
        #region Login / Logout

        internal static string GeneratePasswordImp()
        {
            char[] allowedCharacters = "qwertyuiopasdfghjklzxcvbnm1234567890-=!@#$%^&*()_+".ToCharArray();
            List<char> characterList = new List<char>();

            Random random = new Random();

            SetupImp();

            Securable s = new Securable(typeof(ApplicationExceptionSecureService).FullName);

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
			
            Securable s = new Securable(typeof(ApplicationExceptionSecureService).FullName);
            
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
				Securable s = new Securable(typeof(ApplicationExceptionSecureService).FullName);
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
            
            Securable s = new Securable(typeof(ApplicationExceptionSecureService).FullName);

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
            
            if (!mu.Enabled && !ApplicationExceptionSecureService.CheckUserRightsImp(userName, "CannotBeDisabled"))
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
        
        internal static bool HasAccessImp(Services.Packages.Log.ApplicationException _object, string userName, string securityDescriptor, string SessionToken)
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
				s = new Securable(typeof(ApplicationExceptionSecureService).FullName);
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
		
		internal static bool CheckAccessImp(Services.Packages.Log.ApplicationException _object, string sessionToken, string securityDescriptor)
		{
			// Check the ModelUser and ModelSession tables
			// using ApplicationExceptionAccessControlList and ApplicationExceptionAccessControlEntry
			ModelSession session = CheckSessionImp(sessionToken);
			
			return CheckAccessFromUserNameImp(_object, session.User.Name, securityDescriptor);
		}
		
		internal static bool CheckAccessFromUserNameImp(Services.Packages.Log.ApplicationException _object, string userName, string securityDescriptor)
		{	
			if (!ApplicationExceptionSecureService.IsSecurableImp)
				return true;
			
			// Owner can do anything
			if (CheckUserRightsImp(userName, "Owner"))
				return true;
			
			// User could have constant rights on the class
			if (CheckUserRightsImp(userName, securityDescriptor + " " + typeof(Services.Packages.Log.ApplicationException).FullName))
				return true;
			
			if (_object.Owner != null && _object.Owner.Name == userName)
				return true;
			
			ApplicationExceptionAccessControlListCollection acls = _object.GetACLs(userName);
			if (acls.Count == 0)
			{
				if (userName.ToLowerInvariant() != "everyone")
					return CheckAccessFromUserNameImp(_object, "Everyone", securityDescriptor);
				else return false;
			}
			
			ApplicationExceptionAccessControlList acl = acls[0];
			
			ApplicationExceptionAccessControlEntryCollection entries = ApplicationExceptionAccessControlEntry.GetEntries(securityDescriptor.ToLowerInvariant(), acl);
			if (entries.Count == 0)
			{
				// Descriptor missing; Add-it
				ApplicationExceptionAccessControlEntry entry = new ApplicationExceptionAccessControlEntry();
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
			if (!ApplicationExceptionSecureService.IsSecurableImp)
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
            
            Securable s = new Securable(typeof(ApplicationExceptionSecureService).FullName);
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
				Securable s = new Securable(typeof(ApplicationExceptionSecureService).FullName);
				return s;
            }
			
			throw new UnauthorizedAccessException("Access Denied");
        }
		
		#endregion
		
		#region Secure service instance methods
		
		public ModelUser GetCurrentUser(string SessionToken)
		{
			return ApplicationExceptionSecureService.GetCurrentUserImp(SessionToken);
        }
        
        public ModelUser GetUser(string userName, string SessionToken)
		{
			return ApplicationExceptionSecureService.GetUserImp(userName, SessionToken);
        }
        
        public void SetUserByObject(ModelUser userObject, string SessionToken)
        {
			ApplicationExceptionSecureService.SetUserByObjectImp(userObject, SessionToken);
        }
		
		public bool IsSecurable
        {
            get
			{
				return ApplicationExceptionSecureService.IsSecurableImp;
			}
        }
        
        public void EnableDisableSecurity(bool secure, string sessionToken)
        {
			ApplicationExceptionSecureService.EnableDisableSecurityImp(secure, sessionToken);
        }
        
        public string[] GetUserRightDescriptors()
        {
			return ApplicationExceptionSecureService.GetUserRightDescriptorsImp();
        }
        
        public void ChangeRights(string userName, string userRightDescriptor, bool allow, string SessionToken)
        {
			ApplicationExceptionSecureService.ChangeRightsImp(userName, userRightDescriptor, allow, SessionToken);
        }
        
        public bool HasRights(string userName, string userRightDescriptor, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasRightsImp(userName, userRightDescriptor, SessionToken);
        }
        
		public bool HasAccess(Services.Packages.Log.ApplicationException _object, string userName, string securityDescriptor, string SessionToken)
		{
			return ApplicationExceptionSecureService.HasAccessImp(_object, userName, securityDescriptor, SessionToken);
		}
		
		public void ChangeAccess(Services.Packages.Log.ApplicationException _object, string userName, string securityDescriptor, bool allow, string SessionToken)
        {
			ApplicationExceptionSecureService.ChangeAccessImp(_object, userName, securityDescriptor, allow, SessionToken);
        }

        public void SetObjectOwner(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.SetOwnerImp(_object, userName, SessionToken);
        }
		
		public bool IsFirstTimeUsed
		{
			get
			{
				return ApplicationExceptionSecureService.IsFirstTimeUsedImp;
			}
		}

        public void SetDatabaseOwner(string userName)
        {
			ApplicationExceptionSecureService.SetDatabaseOwnerImp(userName);
        }
		
        public string[] GetSecurityDescriptors()
        {
			return ApplicationExceptionSecureService.GetSecurityDescriptorsImp();
        }
        
        public void AllowTraverse(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowTraverseImp(_object, userName, SessionToken);
        }

        public void AllowRead(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowReadImp(_object, userName, SessionToken);
        }

        public void AllowUpdate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowUpdateImp(_object, userName, SessionToken);
        }

        public void AllowCreate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowCreateImp(_object, userName, SessionToken);
        }

        public void AllowReadAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowReadAccessImp(_object, userName, SessionToken);
        }

        public void AllowChangeAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowChangeAccessImp(_object, userName, SessionToken);
        }
		
        public bool HasTraverse(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasTraverseImp(_object, userName, SessionToken);
        }

        public bool HasRead(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasReadImp(_object, userName, SessionToken);
        }

        public bool HasUpdate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasUpdateImp(_object, userName, SessionToken);
        }

        public bool HasCreate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasCreateImp(_object, userName, SessionToken);
        }

        public bool HasReadAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasReadAccessImp(_object, userName, SessionToken);
        }

        public bool HasChangeAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasChangeAccessImp(_object, userName, SessionToken);
        }
        
        public void DisallowTraverse(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowTraverseImp(_object, userName, SessionToken);
        }

        public void DisallowRead(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowReadImp(_object, userName, SessionToken);
        }

        public void DisallowUpdate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowUpdateImp(_object, userName, SessionToken);
        }

        public void DisallowCreate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowCreateImp(_object, userName, SessionToken);
        }

        public void DisallowReadAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowReadAccessImp(_object, userName, SessionToken);
        }

        public void DisallowChangeAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowChangeAccessImp(_object, userName, SessionToken);
        }
        
        public void AllowAllTraverse(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowAllTraverseImp(userName, SessionToken);
        }
        
        public void AllowAllRead(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowAllReadImp(userName, SessionToken);
        }
        
        public void AllowAllUpdate(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowAllUpdateImp(userName, SessionToken);
        }
        
        public void AllowAllCreate(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowAllCreateImp(userName, SessionToken);
        }
        
        public void AllowAllReadAccess(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowAllReadAccessImp(userName, SessionToken);
        }
        
        public void AllowAllChangeAccess(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowAllChangeAccessImp(userName, SessionToken);
        }
        
        public bool HasAllTraverse(string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasAllTraverseImp(userName, SessionToken);
        }
        
        public bool HasAllRead(string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasAllReadImp(userName, SessionToken);
        }
        
        public bool HasAllUpdate(string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasAllUpdateImp(userName, SessionToken);
        }
        
        public bool HasAllCreate(string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasAllCreateImp(userName, SessionToken);
        }
        
        public bool HasAllReadAccess(string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasAllReadAccessImp(userName, SessionToken);
        }
        
        public bool HasAllChangeAccess(string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasAllChangeAccessImp(userName, SessionToken);
        }
        
        public void DisallowAllTraverse(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowAllTraverseImp(userName, SessionToken);
        }
        
        public void DisallowAllRead(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowAllReadImp(userName, SessionToken);
        }
        
        public void DisallowAllUpdate(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowAllUpdateImp(userName, SessionToken);
        }
        
        public void DisallowAllCreate(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowAllCreateImp(userName, SessionToken);
        }
        
        public void DisallowAllReadAccess(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowAllReadAccessImp(userName, SessionToken);
        }
        
        public void DisallowAllChangeAccess(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowAllChangeAccessImp(userName, SessionToken);
        }
        
        public string LoginAnonymous()
        {
			return ApplicationExceptionSecureService.LoginAnonymousImp();
        }
        
        public string Login(string userName, string password)
        {
			return ApplicationExceptionSecureService.LoginImp(userName, password);
        }
        
        public void SwitchUser(string userName, string password, string existingSessionToken)
        {
			ApplicationExceptionSecureService.SwitchUserImp(userName, password, existingSessionToken);
        }

        public bool SessionExists(string sessionToken)
        {
			return ApplicationExceptionSecureService.SessionExistsImp(sessionToken);
        }

        public void LogoutSession(string sessionToken, bool keepSession)
        {
			ApplicationExceptionSecureService.LogoutSessionImp(sessionToken, keepSession);
        }
        
        public void LogoutAllSessions(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.LogoutAllSessionsImp(userName, SessionToken);
        }

        public void AddUser(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			ApplicationExceptionSecureService.AddUserImp(userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken);
        }

        public void UpdateUser(string userName, string oldPassword, string email, string secretQuestion,
            string secretAnswer, string SessionToken)
        {
			ApplicationExceptionSecureService.UpdateUserImp(userName, oldPassword, email, secretQuestion,
				secretAnswer, SessionToken);
        }
        
        public void UpdateUserWithEnable(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			ApplicationExceptionSecureService.UpdateUserImp(userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken);
        }
        
        public void DeleteUser(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DeleteUserImp(userName, SessionToken);
        }
        
        public void ChangePassword(string userName, string oldPassword, string newPassword, string SessionToken)
        {
			ApplicationExceptionSecureService.ChangePasswordImp(userName, oldPassword, newPassword, SessionToken);
        }
        
        public string CreateRandomPassword(string userName, string answer, string SessionToken)
        {
			return ApplicationExceptionSecureService.CreateRandomPasswordImp(userName, answer, SessionToken);
        }

        public Securable GetSecurable(string SessionToken)
        {
			return ApplicationExceptionSecureService.GetSecurableImp(SessionToken);
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
        public bool Exists(ApplicationException _ApplicationException, string SessionToken)
        {
			if (!ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _ApplicationException.Exists;
        }
		
		[WebMethod]
		public ApplicationException Read(System.Int32 __Id, string SessionToken)
		{
			ApplicationException _ApplicationException = new ApplicationException(__Id);
			
			if (!ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _ApplicationException;
		}
		
		[WebMethod]
        public ApplicationException Reload(ApplicationException _ApplicationException, string SessionToken)
        {
			_ApplicationException.Reload();
			
			if (!ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _ApplicationException;
        }
		
		[WebMethod]
        public ApplicationException Create(System.Int32 __Id, string SessionToken)
        {
			ModelSession session = ApplicationExceptionSecureService.CheckSessionImp(SessionToken);

            if (!ApplicationExceptionSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ApplicationException).FullName))
				throw new UnauthorizedAccessException("Access Denied");
            
            ApplicationException _ApplicationException = ApplicationException.CreateApplicationException(__Id);
            _ApplicationException.Owner = session.User;
            _ApplicationException.Update();
			return _ApplicationException;
        }
        
        [WebMethod]
        public void Delete(System.Int32 __Id, string SessionToken)
        {
			ApplicationException _ApplicationException = new ApplicationException(__Id);
			
			if (!ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Delete"))
				throw new UnauthorizedAccessException("Access Denied");
			
			ApplicationException.DeleteApplicationException(__Id);
        }
        
        [WebMethod]
        public void UpdateObject(ApplicationException _ApplicationException, string SessionToken)
        {
			if (!ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApplicationException.Update();
        }
		
		[WebMethod]
        public void CreateObject(ApplicationException _ApplicationException, string SessionToken)
        {
			ModelSession session = ApplicationExceptionSecureService.CheckSessionImp(SessionToken);

            if (!ApplicationExceptionSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ApplicationException).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApplicationException.Owner = session.User;
            _ApplicationException.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ApplicationException _ApplicationException, string SessionToken)
        {
			if (!ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Delete"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApplicationException.Delete();
        }

		[WebMethod]
        public void Undo(string SessionToken)
        {
			ModelSession session = ApplicationExceptionSecureService.CheckSessionImp(SessionToken);

			// Must have all available access to the class level (all objects)
			if (!ApplicationExceptionSecureService.CheckUserRightsImp(session.User.Name, "Update " + typeof(ApplicationException).FullName) ||
				!ApplicationExceptionSecureService.CheckUserRightsImp(session.User.Name, "Delete " + typeof(ApplicationException).FullName) ||
				!ApplicationExceptionSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ApplicationException).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			ApplicationException.Undo();
        }

		[WebMethod]
        public void Redo(string SessionToken)
        {
			ModelSession session = ApplicationExceptionSecureService.CheckSessionImp(SessionToken);

			// Must have all available access to the class level (all objects)
			if (!ApplicationExceptionSecureService.CheckUserRightsImp(session.User.Name, "Update " + typeof(ApplicationException).FullName) ||
				!ApplicationExceptionSecureService.CheckUserRightsImp(session.User.Name, "Delete " + typeof(ApplicationException).FullName) ||
				!ApplicationExceptionSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ApplicationException).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			ApplicationException.Redo();
        }

        		
		[WebMethod]
        public ApplicationException CreateFromApiKey(System.Int32 __Id, Services.Packages.ApiKey _ApiKey, string SessionToken)
        {
			ModelSession session = ApplicationExceptionSecureService.CheckSessionImp(SessionToken);

			ApplicationException _ApplicationException = new ApplicationException(__Id);
            
            if (!_ApplicationException.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Create ApplicationExceptionsLogged"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ApplicationException.Exists && !ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // ApplicationException _ApplicationException = ApplicationException.CreateApplicationException(__Id);
            _ApplicationException.Owner = session.User;
            _ApplicationException.ApiKey = _ApiKey;
            _ApplicationException.Update();
			return _ApplicationException;
        }
        
        [WebMethod]
        public void CreateObjectFromApiKey(ApplicationException _ApplicationException, Services.Packages.ApiKey _ApiKey, string SessionToken)
        {
			ModelSession session = ApplicationExceptionSecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Create ApplicationExceptionsLogged"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_ApplicationException.Reload();
			
			if (!_ApplicationException.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Create ApplicationExceptionsLogged"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ApplicationException.Exists && !ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApplicationException.Owner = session.User;
            _ApplicationException.ApiKey = _ApiKey;
            _ApplicationException.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromApiKey(Services.Packages.ApiKey _ApiKey, string userName, string SessionToken)
        {
            Services.Packages.Security.ApiKeySecureService.ChangeAccessImp(_ApiKey, userName, "Create ApplicationExceptionsLogged", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromApiKey(Services.Packages.ApiKey _ApiKey, string userName, string SessionToken)
        {
            return Services.Packages.Security.ApiKeySecureService.HasAccessImp(_ApiKey, userName, "Create ApplicationExceptionsLogged", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromApiKey(Services.Packages.ApiKey _ApiKey, string userName, string SessionToken)
        {
            Services.Packages.Security.ApiKeySecureService.ChangeAccessImp(_ApiKey, userName, "Create ApplicationExceptionsLogged", false, SessionToken);
        }
		
		[WebMethod]
        public ApplicationException CreateFromParentException(System.Int32 __Id, Services.Packages.Log.ApplicationException _ParentException, string SessionToken)
        {
			ModelSession session = ApplicationExceptionSecureService.CheckSessionImp(SessionToken);

			ApplicationException _ApplicationException = new ApplicationException(__Id);
            
            if (!_ApplicationException.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ParentException, SessionToken, "Create InnerExceptions"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ApplicationException.Exists && !ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // ApplicationException _ApplicationException = ApplicationException.CreateApplicationException(__Id);
            _ApplicationException.Owner = session.User;
            _ApplicationException.ParentException = _ParentException;
            _ApplicationException.Update();
			return _ApplicationException;
        }
        
        [WebMethod]
        public void CreateObjectFromParentException(ApplicationException _ApplicationException, Services.Packages.Log.ApplicationException _ParentException, string SessionToken)
        {
			ModelSession session = ApplicationExceptionSecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ParentException, SessionToken, "Create InnerExceptions"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_ApplicationException.Reload();
			
			if (!_ApplicationException.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ParentException, SessionToken, "Create InnerExceptions"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ApplicationException.Exists && !ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApplicationException.Owner = session.User;
            _ApplicationException.ParentException = _ParentException;
            _ApplicationException.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromParentException(Services.Packages.Log.ApplicationException _ParentException, string userName, string SessionToken)
        {
            Services.Packages.Log.Security.ApplicationExceptionSecureService.ChangeAccessImp(_ParentException, userName, "Create InnerExceptions", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromParentException(Services.Packages.Log.ApplicationException _ParentException, string userName, string SessionToken)
        {
            return Services.Packages.Log.Security.ApplicationExceptionSecureService.HasAccessImp(_ParentException, userName, "Create InnerExceptions", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromParentException(Services.Packages.Log.ApplicationException _ParentException, string userName, string SessionToken)
        {
            Services.Packages.Log.Security.ApplicationExceptionSecureService.ChangeAccessImp(_ParentException, userName, "Create InnerExceptions", false, SessionToken);
        }
		
		[WebMethod]
        public ApplicationException CreateFromOwner(System.Int32 __Id, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			ModelSession session = ApplicationExceptionSecureService.CheckSessionImp(SessionToken);

			ApplicationException _ApplicationException = new ApplicationException(__Id);
            
            if (!_ApplicationException.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create ApplicationExceptionOwning"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ApplicationException.Exists && !ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // ApplicationException _ApplicationException = ApplicationException.CreateApplicationException(__Id);
            _ApplicationException.Owner = session.User;
            _ApplicationException.Owner = _Owner;
            _ApplicationException.Update();
			return _ApplicationException;
        }
        
        [WebMethod]
        public void CreateObjectFromOwner(ApplicationException _ApplicationException, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			ModelSession session = ApplicationExceptionSecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create ApplicationExceptionOwning"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_ApplicationException.Reload();
			
			if (!_ApplicationException.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create ApplicationExceptionOwning"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ApplicationException.Exists && !ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApplicationException.Owner = session.User;
            _ApplicationException.Owner = _Owner;
            _ApplicationException.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_Owner, userName, "Create ApplicationExceptionOwning", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            return Services.Packages.Security.Security.ModelUserSecureService.HasAccessImp(_Owner, userName, "Create ApplicationExceptionOwning", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_Owner, userName, "Create ApplicationExceptionOwning", false, SessionToken);
        }

		[WebMethod]
		public ApplicationExceptionCollection GetByApiKey(Services.Packages.ApiKey _ApiKey, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.GetByApiKey( _ApiKey);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApplicationExceptionCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.GetByApiKeyPaged( _ApiKey, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ApplicationException.GetByApiKeyCount( _ApiKey);
		}
		[WebMethod]
		public Services.Packages.ApiKey GetApiKey(ApplicationException _ApplicationException, string SessionToken)
		{
			_ApplicationException.Reload();
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApplicationException.ApiKey, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApplicationException.ApiKey;
		}
		[WebMethod]
		public void SetApiKey(ApplicationException _ApplicationException, Services.Packages.ApiKey _ApiKey, string SessionToken)
		{
			_ApplicationException.Reload();
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_ApiKey.Reload();
			if (_ApiKey.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ApiKey.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Create ApplicationExceptionsLogged"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApplicationException.ApiKey = _ApiKey;
			_ApplicationException.Update();
		}
		[WebMethod]
		public ApplicationExceptionCollection GetByParentException(Services.Packages.Log.ApplicationException _ApplicationException, string SessionToken)
		{
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.GetByParentException( _ApplicationException);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApplicationExceptionCollection GetByParentExceptionPaged(Services.Packages.Log.ApplicationException _ApplicationException, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.GetByParentExceptionPaged( _ApplicationException, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long GetByParentExceptionCount(Services.Packages.Log.ApplicationException _ApplicationException, string SessionToken)
		{
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ApplicationException.GetByParentExceptionCount( _ApplicationException);
		}
		[WebMethod]
		public Services.Packages.Log.ApplicationException GetParentException(ApplicationException _ApplicationException, string SessionToken)
		{
			_ApplicationException.Reload();
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException.ParentException, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApplicationException.ParentException;
		}
		[WebMethod]
		public void SetParentException(ApplicationException _ApplicationException, Services.Packages.Log.ApplicationException _ParentException, string SessionToken)
		{
			_ApplicationException.Reload();
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_ParentException.Reload();
			if (_ParentException.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ParentException, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ParentException.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Create InnerExceptions"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApplicationException.ParentException = _ParentException;
			_ApplicationException.Update();
		}
		[WebMethod]
		public ApplicationExceptionCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.GetByOwner( _ModelUser);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApplicationExceptionCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
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
			
			return ApplicationException.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(ApplicationException _ApplicationException, string SessionToken)
		{
			_ApplicationException.Reload();
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ApplicationException.Owner, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApplicationException.Owner;
		}
		[WebMethod]
		public void SetOwner(ApplicationException _ApplicationException, Services.Packages.Security.ModelUser _Owner, string SessionToken)
		{
			_ApplicationException.Reload();
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_Owner.Reload();
			if (_Owner.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Owner.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Create ApplicationExceptionOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApplicationException.Owner = _Owner;
			_ApplicationException.Update();
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByName(System.String Message , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.SearchByName(Message );
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNamePaged(System.String Message , long PagingStart, long PagingCount, string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.SearchByNamePaged(Message , PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByNameCount(System.String Message , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ApplicationException.SearchByNameCount(Message );
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameSolved(System.String Message, System.Boolean IsSolved , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.SearchByNameSolved(Message, IsSolved );
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameSolvedPaged(System.String Message, System.Boolean IsSolved , long PagingStart, long PagingCount, string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.SearchByNameSolvedPaged(Message, IsSolved , PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByNameSolvedCount(System.String Message, System.Boolean IsSolved , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ApplicationException.SearchByNameSolvedCount(Message, IsSolved );
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameOnApiKey(System.String Message, Services.Packages.ApiKey _ApiKey, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.SearchByNameOnApiKey(Message,  _ApiKey);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameOnApiKeyPaged(System.String Message, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.SearchByNameOnApiKeyPaged(Message,  _ApiKey, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByNameOnApiKeyCount(System.String Message, Services.Packages.ApiKey _ApiKey, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ApplicationException.SearchByNameOnApiKeyCount(Message,  _ApiKey);
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameSolvedOnApiKey(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.SearchByNameSolvedOnApiKey(Message, IsSolved,  _ApiKey);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameSolvedOnApiKeyPaged(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.SearchByNameSolvedOnApiKeyPaged(Message, IsSolved,  _ApiKey, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByNameSolvedOnApiKeyCount(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ApplicationException.SearchByNameSolvedOnApiKeyCount(Message, IsSolved,  _ApiKey);
		}
		[WebMethod]
		public Services.Packages.Log.ApplicationExceptionCollection GetInnerExceptions(ApplicationException _ApplicationException, string SessionToken)
		{
			_ApplicationException.Reload();
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException.InnerExceptions, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApplicationException.InnerExceptions;
		}
		[WebMethod]
		public void SetInnerExceptions(ApplicationException _ApplicationException, Services.Packages.Log.ApplicationExceptionCollection _InnerExceptions, string SessionToken)
		{
			_ApplicationException.Reload();
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_InnerExceptions.Reload();
			if (_InnerExceptions.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_InnerExceptions, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_InnerExceptions.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Create InnerExceptions"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApplicationException.InnerExceptions = _InnerExceptions;
			_ApplicationException.Update();
		}
		[WebMethod]
		public Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection GetACLs(ApplicationException _ApplicationException, string SessionToken)
		{
			_ApplicationException.Reload();
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Log.Security.Security.ApplicationExceptionAccessControlListSecureService.CheckAccessImp(_ApplicationException.ACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApplicationException.ACLs;
		}
		[WebMethod]
		public void SetACLs(ApplicationException _ApplicationException, Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection _ACLs, string SessionToken)
		{
			_ApplicationException.Reload();
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ACLs.Reload();
			if (_ACLs.Exists && !Services.Packages.Log.Security.Security.ApplicationExceptionAccessControlListSecureService.CheckAccessImp(_ACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ACLs.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Create ACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApplicationException.ACLs = _ACLs;
			_ApplicationException.Update();
		}

    }
    
namespace Web
{
	/// <summary>
	/// The WebService secure service provider that allows to create web services
	/// that share Services.Packages.Log.ApplicationException objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Log.Security.Web.ApplicationExceptionSecureWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class ApplicationExceptionSecureWebService : WebService, IApplicationExceptionSecureService
	{
		#region Secure service instance methods
        
        [WebMethod]
        public void EnableDisableSecurity(bool secure, string sessionToken)
        {
			ApplicationExceptionSecureService.EnableDisableSecurityImp(secure, sessionToken);
        }
        
        [WebMethod]
        public string[] GetUserRightDescriptors()
        {
			return ApplicationExceptionSecureService.GetUserRightDescriptorsImp();
        }
        
        [WebMethod]
        public void ChangeRights(string userName, string userRightDescriptor, bool allow, string SessionToken)
        {
			ApplicationExceptionSecureService.ChangeRightsImp(userName, userRightDescriptor, allow, SessionToken);
        }
        
        [WebMethod]
        public bool HasRights(string userName, string userRightDescriptor, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasRightsImp(userName, userRightDescriptor, SessionToken);
        }
        
		[WebMethod]
        public bool HasAccess(Services.Packages.Log.ApplicationException _object, string userName, string securityDescriptor, string SessionToken)
		{
			return ApplicationExceptionSecureService.HasAccessImp(_object, userName, securityDescriptor, SessionToken);
		}
		
		[WebMethod]
        public void ChangeAccess(Services.Packages.Log.ApplicationException _object, string userName, string securityDescriptor, bool allow, string SessionToken)
        {
			ApplicationExceptionSecureService.ChangeAccessImp(_object, userName, securityDescriptor, allow, SessionToken);
        }

        [WebMethod]
        public void SetObjectOwner(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.SetOwnerImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void SetDatabaseOwner(string userName)
        {
			ApplicationExceptionSecureService.SetDatabaseOwnerImp(userName);
        }
		
        [WebMethod]
        public string[] GetSecurityDescriptors()
        {
			return ApplicationExceptionSecureService.GetSecurityDescriptorsImp();
        }
        
        [WebMethod]
        public void AllowTraverse(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowTraverseImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowRead(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowReadImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowUpdate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowUpdateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowCreate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowCreateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowReadAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowReadAccessImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowChangeAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowChangeAccessImp(_object, userName, SessionToken);
        }
		
        [WebMethod]
        public bool HasTraverse(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasTraverseImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasRead(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasReadImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasUpdate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasUpdateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasCreate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasCreateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasReadAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasReadAccessImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasChangeAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasChangeAccessImp(_object, userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowTraverse(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowTraverseImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowRead(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowReadImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowUpdate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowUpdateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowCreate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowCreateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowReadAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowReadAccessImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowChangeAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowChangeAccessImp(_object, userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllTraverse(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowAllTraverseImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllRead(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowAllReadImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllUpdate(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowAllUpdateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllCreate(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowAllCreateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllReadAccess(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowAllReadAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllChangeAccess(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.AllowAllChangeAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllTraverse(string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasAllTraverseImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllRead(string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasAllReadImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllUpdate(string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasAllUpdateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllCreate(string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasAllCreateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllReadAccess(string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasAllReadAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllChangeAccess(string userName, string SessionToken)
        {
			return ApplicationExceptionSecureService.HasAllChangeAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllTraverse(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowAllTraverseImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllRead(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowAllReadImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllUpdate(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowAllUpdateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllCreate(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowAllCreateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllReadAccess(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowAllReadAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllChangeAccess(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DisallowAllChangeAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public string LoginAnonymous()
        {
			return ApplicationExceptionSecureService.LoginAnonymousImp();
        }
        
        [WebMethod]
        public string Login(string userName, string password)
        {
			return ApplicationExceptionSecureService.LoginImp(userName, password);
        }
        
        [WebMethod]
        public void SwitchUser(string userName, string password, string existingSessionToken)
        {
			ApplicationExceptionSecureService.SwitchUserImp(userName, password, existingSessionToken);
        }

        [WebMethod]
        public bool SessionExists(string sessionToken)
        {
			return ApplicationExceptionSecureService.SessionExistsImp(sessionToken);
        }

        [WebMethod]
        public void LogoutSession(string sessionToken, bool keepSession)
        {
			ApplicationExceptionSecureService.LogoutSessionImp(sessionToken, keepSession);
        }
        
        [WebMethod]
        public void LogoutAllSessions(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.LogoutAllSessionsImp(userName, SessionToken);
        }
		
		[WebMethod]
        public ModelUser GetCurrentUser(string SessionToken)
		{
			return ApplicationExceptionSecureService.GetCurrentUserImp(SessionToken);
        }

		[WebMethod]
        public ModelUser GetUser(string userName, string SessionToken)
		{
			return ApplicationExceptionSecureService.GetUserImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void SetUserByObject(ModelUser userObject, string SessionToken)
		{
			ApplicationExceptionSecureService.SetUserByObjectImp(userObject, SessionToken);
        }
        
        [WebMethod]
        public void AddUser(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			ApplicationExceptionSecureService.AddUserImp(userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken);
        }

        [WebMethod]
        public void UpdateUser(string userName, string oldPassword, string email, string secretQuestion,
            string secretAnswer, string SessionToken)
        {
			ApplicationExceptionSecureService.UpdateUserImp(userName, oldPassword, email, secretQuestion,
				secretAnswer, SessionToken);
        }
        
        [WebMethod]
        public void UpdateUserWithEnable(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			ApplicationExceptionSecureService.UpdateUserImp(userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken);
        }
        
        [WebMethod]
        public void DeleteUser(string userName, string SessionToken)
        {
			ApplicationExceptionSecureService.DeleteUserImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void ChangePassword(string userName, string oldPassword, string newPassword, string SessionToken)
        {
			ApplicationExceptionSecureService.ChangePasswordImp(userName, oldPassword, newPassword, SessionToken);
        }
        
        [WebMethod]
        public string CreateRandomPassword(string userName, string answer, string SessionToken)
        {
			return ApplicationExceptionSecureService.CreateRandomPasswordImp(userName, answer, SessionToken);
        }

        [WebMethod]
        public Securable GetSecurable(string SessionToken)
        {
			return ApplicationExceptionSecureService.GetSecurableImp(SessionToken);
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
        public bool Exists(ApplicationException _ApplicationException, string SessionToken)
        {
			if (!ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _ApplicationException.Exists;
        }
		
		[WebMethod]
		public ApplicationException Read(System.Int32 __Id, string SessionToken)
		{
			ApplicationException _ApplicationException = new ApplicationException(__Id);
			
			if (!ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _ApplicationException;
		}
		
		[WebMethod]
        public ApplicationException Reload(ApplicationException _ApplicationException, string SessionToken)
        {
			_ApplicationException.Reload();
			
			if (!ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _ApplicationException;
        }
		
		[WebMethod]
        public ApplicationException Create(System.Int32 __Id, string SessionToken)
        {
			ModelSession session = ApplicationExceptionSecureService.CheckSessionImp(SessionToken);

            if (!ApplicationExceptionSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ApplicationException).FullName))
				throw new UnauthorizedAccessException("Access Denied");
            
            ApplicationException _ApplicationException = ApplicationException.CreateApplicationException(__Id);
            _ApplicationException.Owner = session.User;
            _ApplicationException.Update();
			return _ApplicationException;
        }
        
        [WebMethod]
        public void Delete(System.Int32 __Id, string SessionToken)
        {
			ApplicationException _ApplicationException = new ApplicationException(__Id);
			
			if (!ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Delete"))
				throw new UnauthorizedAccessException("Access Denied");
			
			ApplicationException.DeleteApplicationException(__Id);
        }
        
        [WebMethod]
        public void UpdateObject(ApplicationException _ApplicationException, string SessionToken)
        {
			if (!ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApplicationException.Update();
        }
		
		[WebMethod]
        public void CreateObject(ApplicationException _ApplicationException, string SessionToken)
        {
			ModelSession session = ApplicationExceptionSecureService.CheckSessionImp(SessionToken);

            if (!ApplicationExceptionSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ApplicationException).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApplicationException.Owner = session.User;
            _ApplicationException.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ApplicationException _ApplicationException, string SessionToken)
        {
			if (!ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Delete"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApplicationException.Delete();
        }

		[WebMethod]
        public void Undo(string SessionToken)
        {
			ModelSession session = ApplicationExceptionSecureService.CheckSessionImp(SessionToken);

			// Must have all available access to the class level (all objects)
			if (!ApplicationExceptionSecureService.CheckUserRightsImp(session.User.Name, "Update " + typeof(ApplicationException).FullName) ||
				!ApplicationExceptionSecureService.CheckUserRightsImp(session.User.Name, "Delete " + typeof(ApplicationException).FullName) ||
				!ApplicationExceptionSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ApplicationException).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			ApplicationException.Undo();
        }

		[WebMethod]
        public void Redo(string SessionToken)
        {
			ModelSession session = ApplicationExceptionSecureService.CheckSessionImp(SessionToken);

			// Must have all available access to the class level (all objects)
			if (!ApplicationExceptionSecureService.CheckUserRightsImp(session.User.Name, "Update " + typeof(ApplicationException).FullName) ||
				!ApplicationExceptionSecureService.CheckUserRightsImp(session.User.Name, "Delete " + typeof(ApplicationException).FullName) ||
				!ApplicationExceptionSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ApplicationException).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			ApplicationException.Redo();
        }

        		
		[WebMethod]
        public ApplicationException CreateFromApiKey(System.Int32 __Id, Services.Packages.ApiKey _ApiKey, string SessionToken)
        {
			ModelSession session = ApplicationExceptionSecureService.CheckSessionImp(SessionToken);

			ApplicationException _ApplicationException = new ApplicationException(__Id);
            
            if (!_ApplicationException.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Create ApplicationExceptionsLogged"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ApplicationException.Exists && !ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // ApplicationException _ApplicationException = ApplicationException.CreateApplicationException(__Id);
            _ApplicationException.Owner = session.User;
            _ApplicationException.ApiKey = _ApiKey;
            _ApplicationException.Update();
			return _ApplicationException;
        }
        
        [WebMethod]
        public void CreateObjectFromApiKey(ApplicationException _ApplicationException, Services.Packages.ApiKey _ApiKey, string SessionToken)
        {
			ModelSession session = ApplicationExceptionSecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Create ApplicationExceptionsLogged"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_ApplicationException.Reload();
			
			if (!_ApplicationException.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Create ApplicationExceptionsLogged"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ApplicationException.Exists && !ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApplicationException.Owner = session.User;
            _ApplicationException.ApiKey = _ApiKey;
            _ApplicationException.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromApiKey(Services.Packages.ApiKey _ApiKey, string userName, string SessionToken)
        {
            Services.Packages.Security.ApiKeySecureService.ChangeAccessImp(_ApiKey, userName, "Create ApplicationExceptionsLogged", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromApiKey(Services.Packages.ApiKey _ApiKey, string userName, string SessionToken)
        {
            return Services.Packages.Security.ApiKeySecureService.HasAccessImp(_ApiKey, userName, "Create ApplicationExceptionsLogged", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromApiKey(Services.Packages.ApiKey _ApiKey, string userName, string SessionToken)
        {
            Services.Packages.Security.ApiKeySecureService.ChangeAccessImp(_ApiKey, userName, "Create ApplicationExceptionsLogged", false, SessionToken);
        }
		
		[WebMethod]
        public ApplicationException CreateFromParentException(System.Int32 __Id, Services.Packages.Log.ApplicationException _ParentException, string SessionToken)
        {
			ModelSession session = ApplicationExceptionSecureService.CheckSessionImp(SessionToken);

			ApplicationException _ApplicationException = new ApplicationException(__Id);
            
            if (!_ApplicationException.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ParentException, SessionToken, "Create InnerExceptions"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ApplicationException.Exists && !ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // ApplicationException _ApplicationException = ApplicationException.CreateApplicationException(__Id);
            _ApplicationException.Owner = session.User;
            _ApplicationException.ParentException = _ParentException;
            _ApplicationException.Update();
			return _ApplicationException;
        }
        
        [WebMethod]
        public void CreateObjectFromParentException(ApplicationException _ApplicationException, Services.Packages.Log.ApplicationException _ParentException, string SessionToken)
        {
			ModelSession session = ApplicationExceptionSecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ParentException, SessionToken, "Create InnerExceptions"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_ApplicationException.Reload();
			
			if (!_ApplicationException.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ParentException, SessionToken, "Create InnerExceptions"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ApplicationException.Exists && !ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApplicationException.Owner = session.User;
            _ApplicationException.ParentException = _ParentException;
            _ApplicationException.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromParentException(Services.Packages.Log.ApplicationException _ParentException, string userName, string SessionToken)
        {
            Services.Packages.Log.Security.ApplicationExceptionSecureService.ChangeAccessImp(_ParentException, userName, "Create InnerExceptions", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromParentException(Services.Packages.Log.ApplicationException _ParentException, string userName, string SessionToken)
        {
            return Services.Packages.Log.Security.ApplicationExceptionSecureService.HasAccessImp(_ParentException, userName, "Create InnerExceptions", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromParentException(Services.Packages.Log.ApplicationException _ParentException, string userName, string SessionToken)
        {
            Services.Packages.Log.Security.ApplicationExceptionSecureService.ChangeAccessImp(_ParentException, userName, "Create InnerExceptions", false, SessionToken);
        }
		
		[WebMethod]
        public ApplicationException CreateFromOwner(System.Int32 __Id, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			ModelSession session = ApplicationExceptionSecureService.CheckSessionImp(SessionToken);

			ApplicationException _ApplicationException = new ApplicationException(__Id);
            
            if (!_ApplicationException.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create ApplicationExceptionOwning"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ApplicationException.Exists && !ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // ApplicationException _ApplicationException = ApplicationException.CreateApplicationException(__Id);
            _ApplicationException.Owner = session.User;
            _ApplicationException.Owner = _Owner;
            _ApplicationException.Update();
			return _ApplicationException;
        }
        
        [WebMethod]
        public void CreateObjectFromOwner(ApplicationException _ApplicationException, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			ModelSession session = ApplicationExceptionSecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create ApplicationExceptionOwning"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_ApplicationException.Reload();
			
			if (!_ApplicationException.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create ApplicationExceptionOwning"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ApplicationException.Exists && !ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ApplicationException.Owner = session.User;
            _ApplicationException.Owner = _Owner;
            _ApplicationException.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_Owner, userName, "Create ApplicationExceptionOwning", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            return Services.Packages.Security.Security.ModelUserSecureService.HasAccessImp(_Owner, userName, "Create ApplicationExceptionOwning", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_Owner, userName, "Create ApplicationExceptionOwning", false, SessionToken);
        }

		[WebMethod]
		public ApplicationExceptionCollection GetByApiKey(Services.Packages.ApiKey _ApiKey, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.GetByApiKey( _ApiKey);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApplicationExceptionCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.GetByApiKeyPaged( _ApiKey, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ApplicationException.GetByApiKeyCount( _ApiKey);
		}
		[WebMethod]
		public Services.Packages.ApiKey GetApiKey(ApplicationException _ApplicationException, string SessionToken)
		{
			_ApplicationException.Reload();
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApplicationException.ApiKey, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApplicationException.ApiKey;
		}
		[WebMethod]
		public void SetApiKey(ApplicationException _ApplicationException, Services.Packages.ApiKey _ApiKey, string SessionToken)
		{
			_ApplicationException.Reload();
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_ApiKey.Reload();
			if (_ApiKey.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ApiKey.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Create ApplicationExceptionsLogged"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApplicationException.ApiKey = _ApiKey;
			_ApplicationException.Update();
		}
		[WebMethod]
		public ApplicationExceptionCollection GetByParentException(Services.Packages.Log.ApplicationException _ApplicationException, string SessionToken)
		{
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.GetByParentException( _ApplicationException);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApplicationExceptionCollection GetByParentExceptionPaged(Services.Packages.Log.ApplicationException _ApplicationException, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.GetByParentExceptionPaged( _ApplicationException, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long GetByParentExceptionCount(Services.Packages.Log.ApplicationException _ApplicationException, string SessionToken)
		{
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ApplicationException.GetByParentExceptionCount( _ApplicationException);
		}
		[WebMethod]
		public Services.Packages.Log.ApplicationException GetParentException(ApplicationException _ApplicationException, string SessionToken)
		{
			_ApplicationException.Reload();
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException.ParentException, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApplicationException.ParentException;
		}
		[WebMethod]
		public void SetParentException(ApplicationException _ApplicationException, Services.Packages.Log.ApplicationException _ParentException, string SessionToken)
		{
			_ApplicationException.Reload();
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_ParentException.Reload();
			if (_ParentException.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ParentException, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ParentException.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Create InnerExceptions"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApplicationException.ParentException = _ParentException;
			_ApplicationException.Update();
		}
		[WebMethod]
		public ApplicationExceptionCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.GetByOwner( _ModelUser);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApplicationExceptionCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
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
			
			return ApplicationException.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(ApplicationException _ApplicationException, string SessionToken)
		{
			_ApplicationException.Reload();
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ApplicationException.Owner, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApplicationException.Owner;
		}
		[WebMethod]
		public void SetOwner(ApplicationException _ApplicationException, Services.Packages.Security.ModelUser _Owner, string SessionToken)
		{
			_ApplicationException.Reload();
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_Owner.Reload();
			if (_Owner.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Owner.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Create ApplicationExceptionOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApplicationException.Owner = _Owner;
			_ApplicationException.Update();
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByName(System.String Message , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.SearchByName(Message );
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNamePaged(System.String Message , long PagingStart, long PagingCount, string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.SearchByNamePaged(Message , PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByNameCount(System.String Message , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ApplicationException.SearchByNameCount(Message );
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameSolved(System.String Message, System.Boolean IsSolved , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.SearchByNameSolved(Message, IsSolved );
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameSolvedPaged(System.String Message, System.Boolean IsSolved , long PagingStart, long PagingCount, string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.SearchByNameSolvedPaged(Message, IsSolved , PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByNameSolvedCount(System.String Message, System.Boolean IsSolved , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ApplicationException.SearchByNameSolvedCount(Message, IsSolved );
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameOnApiKey(System.String Message, Services.Packages.ApiKey _ApiKey, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.SearchByNameOnApiKey(Message,  _ApiKey);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameOnApiKeyPaged(System.String Message, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.SearchByNameOnApiKeyPaged(Message,  _ApiKey, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByNameOnApiKeyCount(System.String Message, Services.Packages.ApiKey _ApiKey, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ApplicationException.SearchByNameOnApiKeyCount(Message,  _ApiKey);
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameSolvedOnApiKey(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.SearchByNameSolvedOnApiKey(Message, IsSolved,  _ApiKey);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameSolvedOnApiKeyPaged(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ApplicationExceptionCollection c = ApplicationException.SearchByNameSolvedOnApiKeyPaged(Message, IsSolved,  _ApiKey, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ApplicationExceptionSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByNameSolvedOnApiKeyCount(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKey, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ApplicationException.SearchByNameSolvedOnApiKeyCount(Message, IsSolved,  _ApiKey);
		}
		[WebMethod]
		public Services.Packages.Log.ApplicationExceptionCollection GetInnerExceptions(ApplicationException _ApplicationException, string SessionToken)
		{
			_ApplicationException.Reload();
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException.InnerExceptions, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApplicationException.InnerExceptions;
		}
		[WebMethod]
		public void SetInnerExceptions(ApplicationException _ApplicationException, Services.Packages.Log.ApplicationExceptionCollection _InnerExceptions, string SessionToken)
		{
			_ApplicationException.Reload();
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_InnerExceptions.Reload();
			if (_InnerExceptions.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_InnerExceptions, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_InnerExceptions.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Create InnerExceptions"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApplicationException.InnerExceptions = _InnerExceptions;
			_ApplicationException.Update();
		}
		[WebMethod]
		public Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection GetACLs(ApplicationException _ApplicationException, string SessionToken)
		{
			_ApplicationException.Reload();
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Log.Security.Security.ApplicationExceptionAccessControlListSecureService.CheckAccessImp(_ApplicationException.ACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ApplicationException.ACLs;
		}
		[WebMethod]
		public void SetACLs(ApplicationException _ApplicationException, Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection _ACLs, string SessionToken)
		{
			_ApplicationException.Reload();
			
			//*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ACLs.Reload();
			if (_ACLs.Exists && !Services.Packages.Log.Security.Security.ApplicationExceptionAccessControlListSecureService.CheckAccessImp(_ACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ACLs.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationException, SessionToken, "Create ACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ApplicationException.ACLs = _ACLs;
			_ApplicationException.Update();
		}

	}
	
	/// <summary>
	/// The WebService secure client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="ApplicationExceptionWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("d65994ea-55c9-6407-980f-c58c3b65fe2f")]
    sealed public class ApplicationExceptionSecureWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IApplicationExceptionSecureService
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
		public ApplicationExceptionSecureWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public ApplicationExceptionSecureWebServiceClient()
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
		public bool HasAccess(Services.Packages.Log.ApplicationException _object, string userName, string securityDescriptor, string SessionToken)
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
		public void ChangeAccess(Services.Packages.Log.ApplicationException _object, string userName, string securityDescriptor, bool allow, string SessionToken)
        {
			this.Invoke("ChangeAccess", new object[] {_object, userName, securityDescriptor, allow, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetObjectOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetObjectOwner(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
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
		public void AllowTraverse(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			this.Invoke("AllowTraverse", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowRead", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowRead(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			this.Invoke("AllowRead", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowUpdate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowUpdate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			this.Invoke("AllowUpdate", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowCreate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowCreate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			this.Invoke("AllowCreate", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowReadAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowReadAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			this.Invoke("AllowReadAccess", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowChangeAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowChangeAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			this.Invoke("AllowChangeAccess", new object[] {_object, userName, SessionToken});
			return;
        }
		
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasTraverse", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasTraverse(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasTraverse", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasRead", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasRead(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasRead", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasUpdate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasUpdate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasUpdate", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasCreate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasCreate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasCreate", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasReadAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasReadAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasReadAccess", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasChangeAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasChangeAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasChangeAccess", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowTraverse", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowTraverse(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowTraverse", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowRead", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowRead(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowRead", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowUpdate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowUpdate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowUpdate", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowCreate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowCreate(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowCreate", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowReadAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowReadAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowReadAccess", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowChangeAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowChangeAccess(Services.Packages.Log.ApplicationException _object, string userName, string SessionToken)
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
		public bool Exists(ApplicationException _ApplicationException, string SessionToken)
        {
			object[] results = this.Invoke("Exists", new object[] {_ApplicationException,SessionToken});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationException Read(System.Int32 __Id, string SessionToken)
		{
			object[] results = this.Invoke("Read", new object[] {__Id, SessionToken});
			return ((ApplicationException)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationException Reload(ApplicationException _ApplicationException, string SessionToken)
        {
			object[] results = this.Invoke("Reload", new object[] {_ApplicationException,SessionToken});
			return ((ApplicationException)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationException Create(System.Int32 __Id, string SessionToken)
        {
			object[] results = this.Invoke("Create", new object[] {__Id, SessionToken});
			return ((ApplicationException)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.Int32 __Id, string SessionToken)
        {
			this.Invoke("Delete", new object[] {__Id, SessionToken});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(ApplicationException _ApplicationException, string SessionToken)
        {
			this.Invoke("UpdateObject", new object[] {_ApplicationException,SessionToken});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(ApplicationException _ApplicationException, string SessionToken)
        {
			this.Invoke("CreateObject", new object[] {_ApplicationException,SessionToken});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(ApplicationException _ApplicationException, string SessionToken)
        {
			this.Invoke("DeleteObject", new object[] {_ApplicationException,SessionToken});
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
        		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateFromApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationException CreateFromApiKey(System.Int32 __Id, Services.Packages.ApiKey _ApiKey, string SessionToken)
        {
			object[] results = this.Invoke("Create", new object[] {__Id, _ApiKey,SessionToken});
			return ((ApplicationException)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObjectFromApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObjectFromApiKey(ApplicationException _ApplicationException, Services.Packages.ApiKey _ApiKey, string SessionToken)
        {
			this.Invoke("CreateObjectFromApiKey", new object[] {_ApplicationException,_ApiKey,SessionToken});
			return;
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowCreateObjectFromApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowCreateFromApiKey(Services.Packages.ApiKey _ApiKey, string userName, string SessionToken)
        {
            this.Invoke("AllowCreateFromApiKey", new object[] {_ApiKey, userName, SessionToken});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasCreateObjectFromApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasCreateFromApiKey(Services.Packages.ApiKey _ApiKey, string userName, string SessionToken)
        {
            object[] results = this.Invoke("HasCreateFromApiKey", new object[] {_ApiKey, userName, SessionToken});
			return ((bool)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowCreateObjectFromApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowCreateFromApiKey(Services.Packages.ApiKey _ApiKey, string userName, string SessionToken)
        {
            this.Invoke("DisallowObjectFromApiKey", new object[] {_ApiKey, userName, SessionToken});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateFromParentException", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationException CreateFromParentException(System.Int32 __Id, Services.Packages.Log.ApplicationException _ParentException, string SessionToken)
        {
			object[] results = this.Invoke("Create", new object[] {__Id, _ParentException,SessionToken});
			return ((ApplicationException)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObjectFromParentException", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObjectFromParentException(ApplicationException _ApplicationException, Services.Packages.Log.ApplicationException _ParentException, string SessionToken)
        {
			this.Invoke("CreateObjectFromParentException", new object[] {_ApplicationException,_ParentException,SessionToken});
			return;
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowCreateObjectFromParentException", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowCreateFromParentException(Services.Packages.Log.ApplicationException _ParentException, string userName, string SessionToken)
        {
            this.Invoke("AllowCreateFromParentException", new object[] {_ParentException, userName, SessionToken});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasCreateObjectFromParentException", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasCreateFromParentException(Services.Packages.Log.ApplicationException _ParentException, string userName, string SessionToken)
        {
            object[] results = this.Invoke("HasCreateFromParentException", new object[] {_ParentException, userName, SessionToken});
			return ((bool)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowCreateObjectFromParentException", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowCreateFromParentException(Services.Packages.Log.ApplicationException _ParentException, string userName, string SessionToken)
        {
            this.Invoke("DisallowObjectFromParentException", new object[] {_ParentException, userName, SessionToken});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateFromOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationException CreateFromOwner(System.Int32 __Id, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			object[] results = this.Invoke("Create", new object[] {__Id, _Owner,SessionToken});
			return ((ApplicationException)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObjectFromOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObjectFromOwner(ApplicationException _ApplicationException, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			this.Invoke("CreateObjectFromOwner", new object[] {_ApplicationException,_Owner,SessionToken});
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

		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection GetByApiKey(Services.Packages.ApiKey _ApiKey, string SessionToken) {
			object[] results = this.Invoke("GetByApiKey", new object[] {_ApiKey,SessionToken});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByApiKeyPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("GetByApiKeyPaged", new object[] {_ApiKey,PagingStart,PagingCount,SessionToken});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByApiKeyCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey, string SessionToken) {
			object[] results = this.Invoke("GetByApiKeyCount", new object[] {_ApiKey,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.ApiKey GetApiKey(ApplicationException _ApplicationException, string SessionToken)
		{
			object[] results = this.Invoke("GetApiKey", new object[] {_ApplicationException,SessionToken});
			return ((Services.Packages.ApiKey)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetApiKey(ApplicationException _ApplicationException, Services.Packages.ApiKey _ApiKey, string SessionToken)
		{
			this.Invoke("GetApiKey", new object[] {_ApplicationException,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByParentException", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection GetByParentException(Services.Packages.Log.ApplicationException _ApplicationException, string SessionToken) {
			object[] results = this.Invoke("GetByParentException", new object[] {_ApplicationException,SessionToken});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByParentExceptionPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection GetByParentExceptionPaged(Services.Packages.Log.ApplicationException _ApplicationException, long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("GetByParentExceptionPaged", new object[] {_ApplicationException,PagingStart,PagingCount,SessionToken});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByParentExceptionCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByParentExceptionCount(Services.Packages.Log.ApplicationException _ApplicationException, string SessionToken) {
			object[] results = this.Invoke("GetByParentExceptionCount", new object[] {_ApplicationException,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetParentException", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Log.ApplicationException GetParentException(ApplicationException _ApplicationException, string SessionToken)
		{
			object[] results = this.Invoke("GetParentException", new object[] {_ApplicationException,SessionToken});
			return ((Services.Packages.Log.ApplicationException)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetParentException", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetParentException(ApplicationException _ApplicationException, Services.Packages.Log.ApplicationException _ParentException, string SessionToken)
		{
			this.Invoke("GetParentException", new object[] {_ApplicationException,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser, string SessionToken) {
			object[] results = this.Invoke("GetByOwner", new object[] {_ModelUser,SessionToken});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("GetByOwnerPaged", new object[] {_ModelUser,PagingStart,PagingCount,SessionToken});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser, string SessionToken) {
			object[] results = this.Invoke("GetByOwnerCount", new object[] {_ModelUser,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetOwner(ApplicationException _ApplicationException, string SessionToken)
		{
			object[] results = this.Invoke("GetOwner", new object[] {_ApplicationException,SessionToken});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetOwner(ApplicationException _ApplicationException, Services.Packages.Security.ModelUser _Owner, string SessionToken)
		{
			this.Invoke("GetOwner", new object[] {_ApplicationException,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByName", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection SearchByName(System.String Message , string SessionToken) {
			object[] results = this.Invoke("SearchByName", new object[] {Message,SessionToken});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNamePaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection SearchByNamePaged(System.String Message , long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("SearchByNamePaged", new object[] {Message,PagingStart,PagingCount,SessionToken});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByNameCount(System.String Message , string SessionToken) {
			object[] results = this.Invoke("SearchByNameCount", new object[] {Message,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameSolved", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection SearchByNameSolved(System.String Message, System.Boolean IsSolved , string SessionToken) {
			object[] results = this.Invoke("SearchByNameSolved", new object[] {Message, IsSolved,SessionToken});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameSolvedPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection SearchByNameSolvedPaged(System.String Message, System.Boolean IsSolved , long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("SearchByNameSolvedPaged", new object[] {Message, IsSolved,PagingStart,PagingCount,SessionToken});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameSolvedCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByNameSolvedCount(System.String Message, System.Boolean IsSolved , string SessionToken) {
			object[] results = this.Invoke("SearchByNameSolvedCount", new object[] {Message, IsSolved,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameOnApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection SearchByNameOnApiKey(System.String Message, Services.Packages.ApiKey _ApiKey, string SessionToken) {
			object[] results = this.Invoke("SearchByNameOnApiKey", new object[] {Message, _ApiKey,SessionToken});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameOnApiKeyPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection SearchByNameOnApiKeyPaged(System.String Message, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("SearchByNameOnApiKeyPaged", new object[] {Message, _ApiKey,PagingStart,PagingCount,SessionToken});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameOnApiKeyCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByNameOnApiKeyCount(System.String Message, Services.Packages.ApiKey _ApiKey, string SessionToken) {
			object[] results = this.Invoke("SearchByNameOnApiKeyCount", new object[] {Message, _ApiKey,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameSolvedOnApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection SearchByNameSolvedOnApiKey(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey, string SessionToken) {
			object[] results = this.Invoke("SearchByNameSolvedOnApiKey", new object[] {Message, IsSolved, _ApiKey,SessionToken});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameSolvedOnApiKeyPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection SearchByNameSolvedOnApiKeyPaged(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("SearchByNameSolvedOnApiKeyPaged", new object[] {Message, IsSolved, _ApiKey,PagingStart,PagingCount,SessionToken});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameSolvedOnApiKeyCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByNameSolvedOnApiKeyCount(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey, string SessionToken) {
			object[] results = this.Invoke("SearchByNameSolvedOnApiKeyCount", new object[] {Message, IsSolved, _ApiKey,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetInnerExceptions", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Log.ApplicationExceptionCollection GetInnerExceptions(ApplicationException _ApplicationException, string SessionToken)
		{
			object[] results = this.Invoke("GetInnerExceptions", new object[] {_ApplicationException,SessionToken});
			return ((Services.Packages.Log.ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetInnerExceptions", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetInnerExceptions(ApplicationException _ApplicationException, Services.Packages.Log.ApplicationExceptionCollection _InnerExceptions, string SessionToken)
		{
			this.Invoke("GetInnerExceptions", new object[] {_ApplicationException,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection GetACLs(ApplicationException _ApplicationException, string SessionToken)
		{
			object[] results = this.Invoke("GetACLs", new object[] {_ApplicationException,SessionToken});
			return ((Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACLs(ApplicationException _ApplicationException, Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection _ACLs, string SessionToken)
		{
			this.Invoke("GetACLs", new object[] {_ApplicationException,SessionToken});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages.Log
