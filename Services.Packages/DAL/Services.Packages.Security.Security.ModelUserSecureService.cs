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

namespace Services.Packages.Security.Security
{	
	/// <summary>
    /// Defines the secure contract for all the service-based types which can
    /// apply servicing on Services.Packages.Security.ModelUser type.
    /// </summary>
    [ComVisible(true)]
    [Guid("8b90b01b-e76f-d213-81ee-6bf2221a40eb")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IModelUserSecureService
    {
		#region Securable interface definitions
        void EnableDisableSecurity(bool secure, string sessionToken);
        
        string[] GetUserRightDescriptors();
        bool HasRights(string userName, string userRightDescriptor, string SessionToken);
		void ChangeRights(string userName, string userRightDescriptor, bool allow, string SessionToken);
		void ChangeAccess(Services.Packages.Security.ModelUser _object, string userName, string securityDescriptor, bool allow, string SessionToken);
		bool HasAccess(Services.Packages.Security.ModelUser _object, string userName, string securityDescriptor, string SessionToken);
        
        void SetObjectOwner(Services.Packages.Security.ModelUser _object, string userName, string SessionToken);
        void SetDatabaseOwner(string userName);
        
        string[] GetSecurityDescriptors();
        void AllowTraverse(Services.Packages.Security.ModelUser _object, string userName, string SessionToken);
        void AllowRead(Services.Packages.Security.ModelUser _object, string userName, string SessionToken);
        void AllowUpdate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken);
        void AllowCreate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken);
        void AllowReadAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken);
        void AllowChangeAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken);
        bool HasTraverse(Services.Packages.Security.ModelUser _object, string userName, string SessionToken);
        bool HasRead(Services.Packages.Security.ModelUser _object, string userName, string SessionToken);
        bool HasUpdate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken);
        bool HasCreate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken);
        bool HasReadAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken);
        bool HasChangeAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken);
        void DisallowTraverse(Services.Packages.Security.ModelUser _object, string userName, string SessionToken);
        void DisallowRead(Services.Packages.Security.ModelUser _object, string userName, string SessionToken);
        void DisallowUpdate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken);
        void DisallowCreate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken);
        void DisallowReadAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken);
        void DisallowChangeAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken);
        
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
        bool Exists(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
        ModelUser Read(System.String __Name, string SessionToken);
        [OperationContract]
        ModelUser Reload(ModelUser _ModelUser, string SessionToken);
        [OperationContract]
        ModelUser Create(System.String __Name, string SessionToken);
        [OperationContract]
        void Delete(System.String __Name, string SessionToken);
        [OperationContract]
        void UpdateObject(ModelUser _ModelUser, string SessionToken);
        [OperationContract]
        void CreateObject(ModelUser _ModelUser, string SessionToken);
        [OperationContract]
        void DeleteObject(ModelUser _ModelUser, string SessionToken);
        [OperationContract]
        void Undo(string SessionToken);
        [OperationContract]
        void Redo(string SessionToken);
        		
		[OperationContract]
        ModelUser CreateFromOwner(System.String __Name, Services.Packages.Security.ModelUser _Owner, string SessionToken);
        [OperationContract]
        void CreateObjectFromOwner(ModelUser _ModelUser, Services.Packages.Security.ModelUser _Owner, string SessionToken);
        [OperationContract]
        void AllowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken);
		[OperationContract]
        bool HasCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken);
        [OperationContract]
        void DisallowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken);

		[OperationContract]
		ModelUserCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		ModelUserCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		Services.Packages.Security.ModelUser GetOwner(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetOwner(ModelUser _ModelUser, Services.Packages.Security.ModelUser _Owner, string SessionToken);
		[OperationContract]
		ModelUserCollection SearchByName(System.String Name , string SessionToken);
		[OperationContract]
		ModelUserCollection SearchByNamePaged(System.String Name , long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long SearchByNameCount(System.String Name , string SessionToken);
		[OperationContract]
		ModelUserCollection SearchByEmail(System.String Email , string SessionToken);
		[OperationContract]
		ModelUserCollection SearchByEmailPaged(System.String Email , long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long SearchByEmailCount(System.String Email , string SessionToken);
		[OperationContract]
		ModelUserCollection SearchEnabledByNameAndEmail(System.String Name, System.String Email, System.Boolean Enabled , string SessionToken);
		[OperationContract]
		ModelUserCollection SearchEnabledByNameAndEmailPaged(System.String Name, System.String Email, System.Boolean Enabled , long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long SearchEnabledByNameAndEmailCount(System.String Name, System.String Email, System.Boolean Enabled , string SessionToken);
		[OperationContract]
		Services.Packages.PackageCollection GetPackageOwning(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetPackageOwning(ModelUser _ModelUser, Services.Packages.PackageCollection _PackageOwning, string SessionToken);
		[OperationContract]
		Services.Packages.ApiKeyCollection GetApiKeyOwning(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetApiKeyOwning(ModelUser _ModelUser, Services.Packages.ApiKeyCollection _ApiKeyOwning, string SessionToken);
		[OperationContract]
		Services.Packages.Log.ApplicationExceptionCollection GetApplicationExceptionOwning(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetApplicationExceptionOwning(ModelUser _ModelUser, Services.Packages.Log.ApplicationExceptionCollection _ApplicationExceptionOwning, string SessionToken);
		[OperationContract]
		Services.Packages.CustomerCollection GetCustomerOwning(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetCustomerOwning(ModelUser _ModelUser, Services.Packages.CustomerCollection _CustomerOwning, string SessionToken);
		[OperationContract]
		Services.Packages.CustomerUserEntryCollection GetCustomerUserEntries(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetCustomerUserEntries(ModelUser _ModelUser, Services.Packages.CustomerUserEntryCollection _CustomerUserEntries, string SessionToken);
		[OperationContract]
		Services.Packages.CustomerUserEntryCollection GetCustomerUserEntryOwning(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetCustomerUserEntryOwning(ModelUser _ModelUser, Services.Packages.CustomerUserEntryCollection _CustomerUserEntryOwning, string SessionToken);
		[OperationContract]
		Services.Packages.PurchaseCollection GetPurchases(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetPurchases(ModelUser _ModelUser, Services.Packages.PurchaseCollection _Purchases, string SessionToken);
		[OperationContract]
		Services.Packages.PurchaseCollection GetPurchaseOwning(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetPurchaseOwning(ModelUser _ModelUser, Services.Packages.PurchaseCollection _PurchaseOwning, string SessionToken);
		[OperationContract]
		Services.Packages.PurchaseLineCollection GetPurchaseLineOwning(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetPurchaseLineOwning(ModelUser _ModelUser, Services.Packages.PurchaseLineCollection _PurchaseLineOwning, string SessionToken);
		[OperationContract]
		Services.Packages.Security.ModelUserCollection GetModelUserOwning(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetModelUserOwning(ModelUser _ModelUser, Services.Packages.Security.ModelUserCollection _ModelUserOwning, string SessionToken);
		[OperationContract]
		Services.Packages.Security.ModelSessionCollection GetSessions(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetSessions(ModelUser _ModelUser, Services.Packages.Security.ModelSessionCollection _Sessions, string SessionToken);
		[OperationContract]
		Services.Packages.Security.ModelUserRightsCollection GetRights(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetRights(ModelUser _ModelUser, Services.Packages.Security.ModelUserRightsCollection _Rights, string SessionToken);
		[OperationContract]
		Services.Packages.Security.PackageAccessControlListCollection GetPackageACLs(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetPackageACLs(ModelUser _ModelUser, Services.Packages.Security.PackageAccessControlListCollection _PackageACLs, string SessionToken);
		[OperationContract]
		Services.Packages.Security.ApiKeyAccessControlListCollection GetApiKeyACLs(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetApiKeyACLs(ModelUser _ModelUser, Services.Packages.Security.ApiKeyAccessControlListCollection _ApiKeyACLs, string SessionToken);
		[OperationContract]
		Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection GetApplicationExceptionACLs(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetApplicationExceptionACLs(ModelUser _ModelUser, Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection _ApplicationExceptionACLs, string SessionToken);
		[OperationContract]
		Services.Packages.Security.CustomerAccessControlListCollection GetCustomerACLs(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetCustomerACLs(ModelUser _ModelUser, Services.Packages.Security.CustomerAccessControlListCollection _CustomerACLs, string SessionToken);
		[OperationContract]
		Services.Packages.Security.CustomerUserEntryAccessControlListCollection GetCustomerUserEntryACLs(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetCustomerUserEntryACLs(ModelUser _ModelUser, Services.Packages.Security.CustomerUserEntryAccessControlListCollection _CustomerUserEntryACLs, string SessionToken);
		[OperationContract]
		Services.Packages.Security.PurchaseAccessControlListCollection GetPurchaseACLs(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetPurchaseACLs(ModelUser _ModelUser, Services.Packages.Security.PurchaseAccessControlListCollection _PurchaseACLs, string SessionToken);
		[OperationContract]
		Services.Packages.Security.PurchaseLineAccessControlListCollection GetPurchaseLineACLs(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetPurchaseLineACLs(ModelUser _ModelUser, Services.Packages.Security.PurchaseLineAccessControlListCollection _PurchaseLineACLs, string SessionToken);
		[OperationContract]
		Services.Packages.Security.Security.ModelUserAccessControlListCollection GetModelUserACLs(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetModelUserACLs(ModelUser _ModelUser, Services.Packages.Security.Security.ModelUserAccessControlListCollection _ModelUserACLs, string SessionToken);
		[OperationContract]
		Services.Packages.Security.Security.ModelUserAccessControlListCollection GetACLs(ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		void SetACLs(ModelUser _ModelUser, Services.Packages.Security.Security.ModelUserAccessControlListCollection _ACLs, string SessionToken);

    }
    
    /// <summary>
    /// WCF and default secure implementation of a service object for Services.Packages.Security.ModelUser type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("0e06b191-0271-820d-208d-7b5dff4c1a4d")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class ModelUserSecureService : IModelUserSecureService
    {
		#region Securable persistence

        internal static bool IsSecurableImp
        {
            get
            {
                Securable s = new Securable(typeof(ModelUserSecureService).FullName);
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

            Securable s = new Securable(typeof(ModelUserSecureService).FullName);
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
		
		internal static void ChangeAccessImp(Services.Packages.Security.ModelUser _object, string userName, string securityDescriptor, bool allow, string SessionToken)
		{
			// Check if user can do that
            ModelSession session = CheckSessionImp(SessionToken);

            if (CheckAccessImp(_object, SessionToken, "ChangeAccess"))
            {
                try
                {
                    ModelUserAccessControlListCollection acls = _object.GetACLs(userName);
                    ModelUserAccessControlList acl;

                    if (acls.Count == 0)
                    {
                        acl = new ModelUserAccessControlList();
                        acl.UserName = userName;
                        acl.ModelUser = _object;
                        acl.Create();
                    }
                    else
                    {
                        acl = acls[0];
                    }

                    ModelUserAccessControlEntry entry = new ModelUserAccessControlEntry();
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
        
        internal static void SetOwnerImp(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
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
		
        internal static void AllowTraverseImp(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Traverse", true, SessionToken);
        }

        internal static void AllowReadImp(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Read", true, SessionToken);
        }

        internal static void AllowUpdateImp(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Update", true, SessionToken);
        }

        internal static void AllowCreateImp(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
            // ChangeAccessImp(_object, userName, "Create " + typeof(Services.Packages.Security.ModelUser).FullName, true, SessionToken);
            throw new NotImplementedException();
        }

        internal static void AllowReadAccessImp(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "ReadAccess", true, SessionToken);
        }

        internal static void AllowChangeAccessImp(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "ChangeAccess", true, SessionToken);
        }
        
        // Security check
		
        internal static bool HasTraverseImp(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			return HasAccessImp(_object, userName, "Traverse", SessionToken);
		}

        internal static bool HasReadImp(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			return HasAccessImp(_object, userName, "Read", SessionToken);
		}

        internal static bool HasUpdateImp(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
            return HasAccessImp(_object, userName, "Update", SessionToken);
		}

        internal static bool HasCreateImp(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
            // ChangeAccessImp(_object, userName, "Create " + typeof(Services.Packages.Security.ModelUser).FullName, true, SessionToken);
            throw new NotImplementedException();
        }

        internal static bool HasReadAccessImp(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
            return HasAccessImp(_object, userName, "ReadAccess", SessionToken);
        }

        internal static bool HasChangeAccessImp(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
            return HasAccessImp(_object, userName, "ChangeAccess", SessionToken);
        }
        
        // Disallow
        
        internal static void DisallowTraverseImp(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Traverse", false, SessionToken);
        }

        internal static void DisallowReadImp(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Read", false, SessionToken);
        }

        internal static void DisallowUpdateImp(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Update", false, SessionToken);
        }

        internal static void DisallowCreateImp(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
            // ChangeAccessImp(_object, userName, "Create " + typeof(Services.Packages.Security.ModelUser).FullName, false, SessionToken);
            throw new NotImplementedException();
        }

        internal static void DisallowReadAccessImp(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "ReadAccess", false, SessionToken);
        }

        internal static void DisallowChangeAccessImp(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "ChangeAccess", false, SessionToken);
        }
        
        // General object security methods
        
        internal static void AllowAllTraverseImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Traverse " + typeof(Services.Packages.Security.ModelUser).FullName, true, SessionToken);
        }
        
        internal static void AllowAllReadImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Read " + typeof(Services.Packages.Security.ModelUser).FullName, true, SessionToken);
        }
        
        internal static void AllowAllUpdateImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Update " + typeof(Services.Packages.Security.ModelUser).FullName, true, SessionToken);
        }
        
        internal static void AllowAllCreateImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Create " + typeof(Services.Packages.Security.ModelUser).FullName, true, SessionToken);
        }
        
        internal static void AllowAllReadAccessImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "ReadAccess " + typeof(Services.Packages.Security.ModelUser).FullName, true, SessionToken);
        }
        
        internal static void AllowAllChangeAccessImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "ChangeAccess " + typeof(Services.Packages.Security.ModelUser).FullName, true, SessionToken);
        }
        
        internal static bool HasAllTraverseImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "Traverse " + typeof(Services.Packages.Security.ModelUser).FullName, SessionToken);
        }
        
        internal static bool HasAllReadImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "Read " + typeof(Services.Packages.Security.ModelUser).FullName, SessionToken);
        }
        
        internal static bool HasAllUpdateImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "Update " + typeof(Services.Packages.Security.ModelUser).FullName, SessionToken);
        }
        
        internal static bool HasAllCreateImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "Create " + typeof(Services.Packages.Security.ModelUser).FullName, SessionToken);
        }
        
        internal static bool HasAllReadAccessImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "ReadAccess " + typeof(Services.Packages.Security.ModelUser).FullName, SessionToken);
        }
        
        internal static bool HasAllChangeAccessImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "ChangeAccess " + typeof(Services.Packages.Security.ModelUser).FullName, SessionToken);
        }
        
        internal static void DisallowAllTraverseImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Traverse " + typeof(Services.Packages.Security.ModelUser).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllReadImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Read " + typeof(Services.Packages.Security.ModelUser).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllUpdateImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Update " + typeof(Services.Packages.Security.ModelUser).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllCreateImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Create " + typeof(Services.Packages.Security.ModelUser).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllReadAccessImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "ReadAccess " + typeof(Services.Packages.Security.ModelUser).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllChangeAccessImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "ChangeAccess " + typeof(Services.Packages.Security.ModelUser).FullName, false, SessionToken);
        }
        
        #endregion
        
        #region Login / Logout

        internal static string GeneratePasswordImp()
        {
            char[] allowedCharacters = "qwertyuiopasdfghjklzxcvbnm1234567890-=!@#$%^&*()_+".ToCharArray();
            List<char> characterList = new List<char>();

            Random random = new Random();

            SetupImp();

            Securable s = new Securable(typeof(ModelUserSecureService).FullName);

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
			
            Securable s = new Securable(typeof(ModelUserSecureService).FullName);
            
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
				Securable s = new Securable(typeof(ModelUserSecureService).FullName);
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
            
            Securable s = new Securable(typeof(ModelUserSecureService).FullName);

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
            
            if (!mu.Enabled && !ModelUserSecureService.CheckUserRightsImp(userName, "CannotBeDisabled"))
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
        
        internal static bool HasAccessImp(Services.Packages.Security.ModelUser _object, string userName, string securityDescriptor, string SessionToken)
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
				s = new Securable(typeof(ModelUserSecureService).FullName);
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
		
		internal static bool CheckAccessImp(Services.Packages.Security.ModelUser _object, string sessionToken, string securityDescriptor)
		{
			// Check the ModelUser and ModelSession tables
			// using ModelUserAccessControlList and ModelUserAccessControlEntry
			ModelSession session = CheckSessionImp(sessionToken);
			
			return CheckAccessFromUserNameImp(_object, session.User.Name, securityDescriptor);
		}
		
		internal static bool CheckAccessFromUserNameImp(Services.Packages.Security.ModelUser _object, string userName, string securityDescriptor)
		{	
			if (!ModelUserSecureService.IsSecurableImp)
				return true;
			
			// Owner can do anything
			if (CheckUserRightsImp(userName, "Owner"))
				return true;
			
			// User could have constant rights on the class
			if (CheckUserRightsImp(userName, securityDescriptor + " " + typeof(Services.Packages.Security.ModelUser).FullName))
				return true;
			
			if (_object.Owner != null && _object.Owner.Name == userName)
				return true;
			
			ModelUserAccessControlListCollection acls = _object.GetACLs(userName);
			if (acls.Count == 0)
			{
				if (userName.ToLowerInvariant() != "everyone")
					return CheckAccessFromUserNameImp(_object, "Everyone", securityDescriptor);
				else return false;
			}
			
			ModelUserAccessControlList acl = acls[0];
			
			ModelUserAccessControlEntryCollection entries = ModelUserAccessControlEntry.GetEntries(securityDescriptor.ToLowerInvariant(), acl);
			if (entries.Count == 0)
			{
				// Descriptor missing; Add-it
				ModelUserAccessControlEntry entry = new ModelUserAccessControlEntry();
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
			if (!ModelUserSecureService.IsSecurableImp)
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
            
            Securable s = new Securable(typeof(ModelUserSecureService).FullName);
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
				Securable s = new Securable(typeof(ModelUserSecureService).FullName);
				return s;
            }
			
			throw new UnauthorizedAccessException("Access Denied");
        }
		
		#endregion
		
		#region Secure service instance methods
		
		public ModelUser GetCurrentUser(string SessionToken)
		{
			return ModelUserSecureService.GetCurrentUserImp(SessionToken);
        }
        
        public ModelUser GetUser(string userName, string SessionToken)
		{
			return ModelUserSecureService.GetUserImp(userName, SessionToken);
        }
        
        public void SetUserByObject(ModelUser userObject, string SessionToken)
        {
			ModelUserSecureService.SetUserByObjectImp(userObject, SessionToken);
        }
		
		public bool IsSecurable
        {
            get
			{
				return ModelUserSecureService.IsSecurableImp;
			}
        }
        
        public void EnableDisableSecurity(bool secure, string sessionToken)
        {
			ModelUserSecureService.EnableDisableSecurityImp(secure, sessionToken);
        }
        
        public string[] GetUserRightDescriptors()
        {
			return ModelUserSecureService.GetUserRightDescriptorsImp();
        }
        
        public void ChangeRights(string userName, string userRightDescriptor, bool allow, string SessionToken)
        {
			ModelUserSecureService.ChangeRightsImp(userName, userRightDescriptor, allow, SessionToken);
        }
        
        public bool HasRights(string userName, string userRightDescriptor, string SessionToken)
        {
			return ModelUserSecureService.HasRightsImp(userName, userRightDescriptor, SessionToken);
        }
        
		public bool HasAccess(Services.Packages.Security.ModelUser _object, string userName, string securityDescriptor, string SessionToken)
		{
			return ModelUserSecureService.HasAccessImp(_object, userName, securityDescriptor, SessionToken);
		}
		
		public void ChangeAccess(Services.Packages.Security.ModelUser _object, string userName, string securityDescriptor, bool allow, string SessionToken)
        {
			ModelUserSecureService.ChangeAccessImp(_object, userName, securityDescriptor, allow, SessionToken);
        }

        public void SetObjectOwner(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.SetOwnerImp(_object, userName, SessionToken);
        }
		
		public bool IsFirstTimeUsed
		{
			get
			{
				return ModelUserSecureService.IsFirstTimeUsedImp;
			}
		}

        public void SetDatabaseOwner(string userName)
        {
			ModelUserSecureService.SetDatabaseOwnerImp(userName);
        }
		
        public string[] GetSecurityDescriptors()
        {
			return ModelUserSecureService.GetSecurityDescriptorsImp();
        }
        
        public void AllowTraverse(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.AllowTraverseImp(_object, userName, SessionToken);
        }

        public void AllowRead(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.AllowReadImp(_object, userName, SessionToken);
        }

        public void AllowUpdate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.AllowUpdateImp(_object, userName, SessionToken);
        }

        public void AllowCreate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.AllowCreateImp(_object, userName, SessionToken);
        }

        public void AllowReadAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.AllowReadAccessImp(_object, userName, SessionToken);
        }

        public void AllowChangeAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.AllowChangeAccessImp(_object, userName, SessionToken);
        }
		
        public bool HasTraverse(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			return ModelUserSecureService.HasTraverseImp(_object, userName, SessionToken);
        }

        public bool HasRead(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			return ModelUserSecureService.HasReadImp(_object, userName, SessionToken);
        }

        public bool HasUpdate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			return ModelUserSecureService.HasUpdateImp(_object, userName, SessionToken);
        }

        public bool HasCreate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			return ModelUserSecureService.HasCreateImp(_object, userName, SessionToken);
        }

        public bool HasReadAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			return ModelUserSecureService.HasReadAccessImp(_object, userName, SessionToken);
        }

        public bool HasChangeAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			return ModelUserSecureService.HasChangeAccessImp(_object, userName, SessionToken);
        }
        
        public void DisallowTraverse(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowTraverseImp(_object, userName, SessionToken);
        }

        public void DisallowRead(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowReadImp(_object, userName, SessionToken);
        }

        public void DisallowUpdate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowUpdateImp(_object, userName, SessionToken);
        }

        public void DisallowCreate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowCreateImp(_object, userName, SessionToken);
        }

        public void DisallowReadAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowReadAccessImp(_object, userName, SessionToken);
        }

        public void DisallowChangeAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowChangeAccessImp(_object, userName, SessionToken);
        }
        
        public void AllowAllTraverse(string userName, string SessionToken)
        {
			ModelUserSecureService.AllowAllTraverseImp(userName, SessionToken);
        }
        
        public void AllowAllRead(string userName, string SessionToken)
        {
			ModelUserSecureService.AllowAllReadImp(userName, SessionToken);
        }
        
        public void AllowAllUpdate(string userName, string SessionToken)
        {
			ModelUserSecureService.AllowAllUpdateImp(userName, SessionToken);
        }
        
        public void AllowAllCreate(string userName, string SessionToken)
        {
			ModelUserSecureService.AllowAllCreateImp(userName, SessionToken);
        }
        
        public void AllowAllReadAccess(string userName, string SessionToken)
        {
			ModelUserSecureService.AllowAllReadAccessImp(userName, SessionToken);
        }
        
        public void AllowAllChangeAccess(string userName, string SessionToken)
        {
			ModelUserSecureService.AllowAllChangeAccessImp(userName, SessionToken);
        }
        
        public bool HasAllTraverse(string userName, string SessionToken)
        {
			return ModelUserSecureService.HasAllTraverseImp(userName, SessionToken);
        }
        
        public bool HasAllRead(string userName, string SessionToken)
        {
			return ModelUserSecureService.HasAllReadImp(userName, SessionToken);
        }
        
        public bool HasAllUpdate(string userName, string SessionToken)
        {
			return ModelUserSecureService.HasAllUpdateImp(userName, SessionToken);
        }
        
        public bool HasAllCreate(string userName, string SessionToken)
        {
			return ModelUserSecureService.HasAllCreateImp(userName, SessionToken);
        }
        
        public bool HasAllReadAccess(string userName, string SessionToken)
        {
			return ModelUserSecureService.HasAllReadAccessImp(userName, SessionToken);
        }
        
        public bool HasAllChangeAccess(string userName, string SessionToken)
        {
			return ModelUserSecureService.HasAllChangeAccessImp(userName, SessionToken);
        }
        
        public void DisallowAllTraverse(string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowAllTraverseImp(userName, SessionToken);
        }
        
        public void DisallowAllRead(string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowAllReadImp(userName, SessionToken);
        }
        
        public void DisallowAllUpdate(string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowAllUpdateImp(userName, SessionToken);
        }
        
        public void DisallowAllCreate(string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowAllCreateImp(userName, SessionToken);
        }
        
        public void DisallowAllReadAccess(string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowAllReadAccessImp(userName, SessionToken);
        }
        
        public void DisallowAllChangeAccess(string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowAllChangeAccessImp(userName, SessionToken);
        }
        
        public string LoginAnonymous()
        {
			return ModelUserSecureService.LoginAnonymousImp();
        }
        
        public string Login(string userName, string password)
        {
			return ModelUserSecureService.LoginImp(userName, password);
        }
        
        public void SwitchUser(string userName, string password, string existingSessionToken)
        {
			ModelUserSecureService.SwitchUserImp(userName, password, existingSessionToken);
        }

        public bool SessionExists(string sessionToken)
        {
			return ModelUserSecureService.SessionExistsImp(sessionToken);
        }

        public void LogoutSession(string sessionToken, bool keepSession)
        {
			ModelUserSecureService.LogoutSessionImp(sessionToken, keepSession);
        }
        
        public void LogoutAllSessions(string userName, string SessionToken)
        {
			ModelUserSecureService.LogoutAllSessionsImp(userName, SessionToken);
        }

        public void AddUser(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			ModelUserSecureService.AddUserImp(userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken);
        }

        public void UpdateUser(string userName, string oldPassword, string email, string secretQuestion,
            string secretAnswer, string SessionToken)
        {
			ModelUserSecureService.UpdateUserImp(userName, oldPassword, email, secretQuestion,
				secretAnswer, SessionToken);
        }
        
        public void UpdateUserWithEnable(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			ModelUserSecureService.UpdateUserImp(userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken);
        }
        
        public void DeleteUser(string userName, string SessionToken)
        {
			ModelUserSecureService.DeleteUserImp(userName, SessionToken);
        }
        
        public void ChangePassword(string userName, string oldPassword, string newPassword, string SessionToken)
        {
			ModelUserSecureService.ChangePasswordImp(userName, oldPassword, newPassword, SessionToken);
        }
        
        public string CreateRandomPassword(string userName, string answer, string SessionToken)
        {
			return ModelUserSecureService.CreateRandomPasswordImp(userName, answer, SessionToken);
        }

        public Securable GetSecurable(string SessionToken)
        {
			return ModelUserSecureService.GetSecurableImp(SessionToken);
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
        public bool Exists(ModelUser _ModelUser, string SessionToken)
        {
			if (!ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _ModelUser.Exists;
        }
		
		[WebMethod]
		public ModelUser Read(System.String __Name, string SessionToken)
		{
			ModelUser _ModelUser = new ModelUser(__Name);
			
			if (!ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _ModelUser;
		}
		
		[WebMethod]
        public ModelUser Reload(ModelUser _ModelUser, string SessionToken)
        {
			_ModelUser.Reload();
			
			if (!ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _ModelUser;
        }
		
		[WebMethod]
        public ModelUser Create(System.String __Name, string SessionToken)
        {
			ModelSession session = ModelUserSecureService.CheckSessionImp(SessionToken);

            if (!ModelUserSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ModelUser).FullName))
				throw new UnauthorizedAccessException("Access Denied");
            
            ModelUser _ModelUser = ModelUser.CreateModelUser(__Name);
            _ModelUser.Owner = session.User;
            _ModelUser.Update();
			return _ModelUser;
        }
        
        [WebMethod]
        public void Delete(System.String __Name, string SessionToken)
        {
			ModelUser _ModelUser = new ModelUser(__Name);
			
			if (!ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Delete"))
				throw new UnauthorizedAccessException("Access Denied");
			
			ModelUser.DeleteModelUser(__Name);
        }
        
        [WebMethod]
        public void UpdateObject(ModelUser _ModelUser, string SessionToken)
        {
			if (!ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ModelUser.Update();
        }
		
		[WebMethod]
        public void CreateObject(ModelUser _ModelUser, string SessionToken)
        {
			ModelSession session = ModelUserSecureService.CheckSessionImp(SessionToken);

            if (!ModelUserSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ModelUser).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ModelUser.Owner = session.User;
            _ModelUser.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ModelUser _ModelUser, string SessionToken)
        {
			if (!ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Delete"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ModelUser.Delete();
        }

		[WebMethod]
        public void Undo(string SessionToken)
        {
			ModelSession session = ModelUserSecureService.CheckSessionImp(SessionToken);

			// Must have all available access to the class level (all objects)
			if (!ModelUserSecureService.CheckUserRightsImp(session.User.Name, "Update " + typeof(ModelUser).FullName) ||
				!ModelUserSecureService.CheckUserRightsImp(session.User.Name, "Delete " + typeof(ModelUser).FullName) ||
				!ModelUserSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ModelUser).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			ModelUser.Undo();
        }

		[WebMethod]
        public void Redo(string SessionToken)
        {
			ModelSession session = ModelUserSecureService.CheckSessionImp(SessionToken);

			// Must have all available access to the class level (all objects)
			if (!ModelUserSecureService.CheckUserRightsImp(session.User.Name, "Update " + typeof(ModelUser).FullName) ||
				!ModelUserSecureService.CheckUserRightsImp(session.User.Name, "Delete " + typeof(ModelUser).FullName) ||
				!ModelUserSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ModelUser).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			ModelUser.Redo();
        }

        		
		[WebMethod]
        public ModelUser CreateFromOwner(System.String __Name, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			ModelSession session = ModelUserSecureService.CheckSessionImp(SessionToken);

			ModelUser _ModelUser = new ModelUser(__Name);
            
            if (!_ModelUser.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create ModelUserOwning"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ModelUser.Exists && !ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // ModelUser _ModelUser = ModelUser.CreateModelUser(__Name);
            _ModelUser.Owner = session.User;
            _ModelUser.Owner = _Owner;
            _ModelUser.Update();
			return _ModelUser;
        }
        
        [WebMethod]
        public void CreateObjectFromOwner(ModelUser _ModelUser, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			ModelSession session = ModelUserSecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create ModelUserOwning"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_ModelUser.Reload();
			
			if (!_ModelUser.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create ModelUserOwning"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ModelUser.Exists && !ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ModelUser.Owner = session.User;
            _ModelUser.Owner = _Owner;
            _ModelUser.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_Owner, userName, "Create ModelUserOwning", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            return Services.Packages.Security.Security.ModelUserSecureService.HasAccessImp(_Owner, userName, "Create ModelUserOwning", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_Owner, userName, "Create ModelUserOwning", false, SessionToken);
        }

		[WebMethod]
		public ModelUserCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ModelUserCollection c = ModelUser.GetByOwner( _ModelUser);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ModelUserSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ModelUserCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ModelUserCollection c = ModelUser.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ModelUserSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
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
			
			return ModelUser.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser.Owner, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.Owner;
		}
		[WebMethod]
		public void SetOwner(ModelUser _ModelUser, Services.Packages.Security.ModelUser _Owner, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_Owner.Reload();
			if (_Owner.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Owner.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create ModelUserOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.Owner = _Owner;
			_ModelUser.Update();
		}
		[WebMethod]
		public ModelUserCollection SearchByName(System.String Name , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ModelUserCollection c = ModelUser.SearchByName(Name );
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ModelUserSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ModelUserCollection SearchByNamePaged(System.String Name , long PagingStart, long PagingCount, string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ModelUserCollection c = ModelUser.SearchByNamePaged(Name , PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ModelUserSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByNameCount(System.String Name , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ModelUser.SearchByNameCount(Name );
		}
		[WebMethod]
		public ModelUserCollection SearchByEmail(System.String Email , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ModelUserCollection c = ModelUser.SearchByEmail(Email );
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ModelUserSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ModelUserCollection SearchByEmailPaged(System.String Email , long PagingStart, long PagingCount, string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ModelUserCollection c = ModelUser.SearchByEmailPaged(Email , PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ModelUserSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByEmailCount(System.String Email , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ModelUser.SearchByEmailCount(Email );
		}
		[WebMethod]
		public ModelUserCollection SearchEnabledByNameAndEmail(System.String Name, System.String Email, System.Boolean Enabled , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ModelUserCollection c = ModelUser.SearchEnabledByNameAndEmail(Name, Email, Enabled );
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ModelUserSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ModelUserCollection SearchEnabledByNameAndEmailPaged(System.String Name, System.String Email, System.Boolean Enabled , long PagingStart, long PagingCount, string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ModelUserCollection c = ModelUser.SearchEnabledByNameAndEmailPaged(Name, Email, Enabled , PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ModelUserSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchEnabledByNameAndEmailCount(System.String Name, System.String Email, System.Boolean Enabled , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ModelUser.SearchEnabledByNameAndEmailCount(Name, Email, Enabled );
		}
		[WebMethod]
		public Services.Packages.PackageCollection GetPackageOwning(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.PackageSecureService.CheckAccessImp(_ModelUser.PackageOwning, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.PackageOwning;
		}
		[WebMethod]
		public void SetPackageOwning(ModelUser _ModelUser, Services.Packages.PackageCollection _PackageOwning, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_PackageOwning.Reload();
			if (_PackageOwning.Exists && !Services.Packages.Security.PackageSecureService.CheckAccessImp(_PackageOwning, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_PackageOwning.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create PackageOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.PackageOwning = _PackageOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.ApiKeyCollection GetApiKeyOwning(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ModelUser.ApiKeyOwning, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.ApiKeyOwning;
		}
		[WebMethod]
		public void SetApiKeyOwning(ModelUser _ModelUser, Services.Packages.ApiKeyCollection _ApiKeyOwning, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ApiKeyOwning.Reload();
			if (_ApiKeyOwning.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKeyOwning, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ApiKeyOwning.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create ApiKeyOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.ApiKeyOwning = _ApiKeyOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Log.ApplicationExceptionCollection GetApplicationExceptionOwning(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ModelUser.ApplicationExceptionOwning, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.ApplicationExceptionOwning;
		}
		[WebMethod]
		public void SetApplicationExceptionOwning(ModelUser _ModelUser, Services.Packages.Log.ApplicationExceptionCollection _ApplicationExceptionOwning, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ApplicationExceptionOwning.Reload();
			if (_ApplicationExceptionOwning.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationExceptionOwning, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ApplicationExceptionOwning.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create ApplicationExceptionOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.ApplicationExceptionOwning = _ApplicationExceptionOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.CustomerCollection GetCustomerOwning(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_ModelUser.CustomerOwning, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.CustomerOwning;
		}
		[WebMethod]
		public void SetCustomerOwning(ModelUser _ModelUser, Services.Packages.CustomerCollection _CustomerOwning, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_CustomerOwning.Reload();
			if (_CustomerOwning.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_CustomerOwning, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_CustomerOwning.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create CustomerOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.CustomerOwning = _CustomerOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.CustomerUserEntryCollection GetCustomerUserEntries(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_ModelUser.CustomerUserEntries, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.CustomerUserEntries;
		}
		[WebMethod]
		public void SetCustomerUserEntries(ModelUser _ModelUser, Services.Packages.CustomerUserEntryCollection _CustomerUserEntries, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_CustomerUserEntries.Reload();
			if (_CustomerUserEntries.Exists && !Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntries, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_CustomerUserEntries.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create CustomerUserEntries"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.CustomerUserEntries = _CustomerUserEntries;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.CustomerUserEntryCollection GetCustomerUserEntryOwning(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_ModelUser.CustomerUserEntryOwning, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.CustomerUserEntryOwning;
		}
		[WebMethod]
		public void SetCustomerUserEntryOwning(ModelUser _ModelUser, Services.Packages.CustomerUserEntryCollection _CustomerUserEntryOwning, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_CustomerUserEntryOwning.Reload();
			if (_CustomerUserEntryOwning.Exists && !Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntryOwning, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_CustomerUserEntryOwning.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create CustomerUserEntryOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.CustomerUserEntryOwning = _CustomerUserEntryOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.PurchaseCollection GetPurchases(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.PurchaseSecureService.CheckAccessImp(_ModelUser.Purchases, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.Purchases;
		}
		[WebMethod]
		public void SetPurchases(ModelUser _ModelUser, Services.Packages.PurchaseCollection _Purchases, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_Purchases.Reload();
			if (_Purchases.Exists && !Services.Packages.Security.PurchaseSecureService.CheckAccessImp(_Purchases, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Purchases.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create Purchases"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.Purchases = _Purchases;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.PurchaseCollection GetPurchaseOwning(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.PurchaseSecureService.CheckAccessImp(_ModelUser.PurchaseOwning, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.PurchaseOwning;
		}
		[WebMethod]
		public void SetPurchaseOwning(ModelUser _ModelUser, Services.Packages.PurchaseCollection _PurchaseOwning, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_PurchaseOwning.Reload();
			if (_PurchaseOwning.Exists && !Services.Packages.Security.PurchaseSecureService.CheckAccessImp(_PurchaseOwning, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_PurchaseOwning.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create PurchaseOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.PurchaseOwning = _PurchaseOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.PurchaseLineCollection GetPurchaseLineOwning(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.PurchaseLineSecureService.CheckAccessImp(_ModelUser.PurchaseLineOwning, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.PurchaseLineOwning;
		}
		[WebMethod]
		public void SetPurchaseLineOwning(ModelUser _ModelUser, Services.Packages.PurchaseLineCollection _PurchaseLineOwning, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_PurchaseLineOwning.Reload();
			if (_PurchaseLineOwning.Exists && !Services.Packages.Security.PurchaseLineSecureService.CheckAccessImp(_PurchaseLineOwning, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_PurchaseLineOwning.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create PurchaseLineOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.PurchaseLineOwning = _PurchaseLineOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.ModelUserCollection GetModelUserOwning(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser.ModelUserOwning, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.ModelUserOwning;
		}
		[WebMethod]
		public void SetModelUserOwning(ModelUser _ModelUser, Services.Packages.Security.ModelUserCollection _ModelUserOwning, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ModelUserOwning.Reload();
			if (_ModelUserOwning.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUserOwning, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ModelUserOwning.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create ModelUserOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.ModelUserOwning = _ModelUserOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.ModelSessionCollection GetSessions(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.ModelSessionSecureService.CheckAccessImp(_ModelUser.Sessions, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.Sessions;
		}
		[WebMethod]
		public void SetSessions(ModelUser _ModelUser, Services.Packages.Security.ModelSessionCollection _Sessions, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_Sessions.Reload();
			if (_Sessions.Exists && !Services.Packages.Security.Security.ModelSessionSecureService.CheckAccessImp(_Sessions, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Sessions.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create Sessions"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.Sessions = _Sessions;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.ModelUserRightsCollection GetRights(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.ModelUserRightsSecureService.CheckAccessImp(_ModelUser.Rights, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.Rights;
		}
		[WebMethod]
		public void SetRights(ModelUser _ModelUser, Services.Packages.Security.ModelUserRightsCollection _Rights, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_Rights.Reload();
			if (_Rights.Exists && !Services.Packages.Security.Security.ModelUserRightsSecureService.CheckAccessImp(_Rights, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Rights.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create Rights"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.Rights = _Rights;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.PackageAccessControlListCollection GetPackageACLs(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.PackageAccessControlListSecureService.CheckAccessImp(_ModelUser.PackageACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.PackageACLs;
		}
		[WebMethod]
		public void SetPackageACLs(ModelUser _ModelUser, Services.Packages.Security.PackageAccessControlListCollection _PackageACLs, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_PackageACLs.Reload();
			if (_PackageACLs.Exists && !Services.Packages.Security.Security.PackageAccessControlListSecureService.CheckAccessImp(_PackageACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_PackageACLs.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create PackageACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.PackageACLs = _PackageACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.ApiKeyAccessControlListCollection GetApiKeyACLs(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.ApiKeyAccessControlListSecureService.CheckAccessImp(_ModelUser.ApiKeyACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.ApiKeyACLs;
		}
		[WebMethod]
		public void SetApiKeyACLs(ModelUser _ModelUser, Services.Packages.Security.ApiKeyAccessControlListCollection _ApiKeyACLs, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ApiKeyACLs.Reload();
			if (_ApiKeyACLs.Exists && !Services.Packages.Security.Security.ApiKeyAccessControlListSecureService.CheckAccessImp(_ApiKeyACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ApiKeyACLs.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create ApiKeyACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.ApiKeyACLs = _ApiKeyACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection GetApplicationExceptionACLs(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Log.Security.Security.ApplicationExceptionAccessControlListSecureService.CheckAccessImp(_ModelUser.ApplicationExceptionACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.ApplicationExceptionACLs;
		}
		[WebMethod]
		public void SetApplicationExceptionACLs(ModelUser _ModelUser, Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection _ApplicationExceptionACLs, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ApplicationExceptionACLs.Reload();
			if (_ApplicationExceptionACLs.Exists && !Services.Packages.Log.Security.Security.ApplicationExceptionAccessControlListSecureService.CheckAccessImp(_ApplicationExceptionACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ApplicationExceptionACLs.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create ApplicationExceptionACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.ApplicationExceptionACLs = _ApplicationExceptionACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.CustomerAccessControlListCollection GetCustomerACLs(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.CustomerAccessControlListSecureService.CheckAccessImp(_ModelUser.CustomerACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.CustomerACLs;
		}
		[WebMethod]
		public void SetCustomerACLs(ModelUser _ModelUser, Services.Packages.Security.CustomerAccessControlListCollection _CustomerACLs, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_CustomerACLs.Reload();
			if (_CustomerACLs.Exists && !Services.Packages.Security.Security.CustomerAccessControlListSecureService.CheckAccessImp(_CustomerACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_CustomerACLs.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create CustomerACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.CustomerACLs = _CustomerACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.CustomerUserEntryAccessControlListCollection GetCustomerUserEntryACLs(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.CustomerUserEntryAccessControlListSecureService.CheckAccessImp(_ModelUser.CustomerUserEntryACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.CustomerUserEntryACLs;
		}
		[WebMethod]
		public void SetCustomerUserEntryACLs(ModelUser _ModelUser, Services.Packages.Security.CustomerUserEntryAccessControlListCollection _CustomerUserEntryACLs, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_CustomerUserEntryACLs.Reload();
			if (_CustomerUserEntryACLs.Exists && !Services.Packages.Security.Security.CustomerUserEntryAccessControlListSecureService.CheckAccessImp(_CustomerUserEntryACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_CustomerUserEntryACLs.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create CustomerUserEntryACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.CustomerUserEntryACLs = _CustomerUserEntryACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.PurchaseAccessControlListCollection GetPurchaseACLs(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.PurchaseAccessControlListSecureService.CheckAccessImp(_ModelUser.PurchaseACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.PurchaseACLs;
		}
		[WebMethod]
		public void SetPurchaseACLs(ModelUser _ModelUser, Services.Packages.Security.PurchaseAccessControlListCollection _PurchaseACLs, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_PurchaseACLs.Reload();
			if (_PurchaseACLs.Exists && !Services.Packages.Security.Security.PurchaseAccessControlListSecureService.CheckAccessImp(_PurchaseACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_PurchaseACLs.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create PurchaseACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.PurchaseACLs = _PurchaseACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.PurchaseLineAccessControlListCollection GetPurchaseLineACLs(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.PurchaseLineAccessControlListSecureService.CheckAccessImp(_ModelUser.PurchaseLineACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.PurchaseLineACLs;
		}
		[WebMethod]
		public void SetPurchaseLineACLs(ModelUser _ModelUser, Services.Packages.Security.PurchaseLineAccessControlListCollection _PurchaseLineACLs, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_PurchaseLineACLs.Reload();
			if (_PurchaseLineACLs.Exists && !Services.Packages.Security.Security.PurchaseLineAccessControlListSecureService.CheckAccessImp(_PurchaseLineACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_PurchaseLineACLs.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create PurchaseLineACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.PurchaseLineACLs = _PurchaseLineACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.Security.ModelUserAccessControlListCollection GetModelUserACLs(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.Security.ModelUserAccessControlListSecureService.CheckAccessImp(_ModelUser.ModelUserACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.ModelUserACLs;
		}
		[WebMethod]
		public void SetModelUserACLs(ModelUser _ModelUser, Services.Packages.Security.Security.ModelUserAccessControlListCollection _ModelUserACLs, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ModelUserACLs.Reload();
			if (_ModelUserACLs.Exists && !Services.Packages.Security.Security.Security.ModelUserAccessControlListSecureService.CheckAccessImp(_ModelUserACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ModelUserACLs.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create ModelUserACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.ModelUserACLs = _ModelUserACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.Security.ModelUserAccessControlListCollection GetACLs(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.Security.ModelUserAccessControlListSecureService.CheckAccessImp(_ModelUser.ACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.ACLs;
		}
		[WebMethod]
		public void SetACLs(ModelUser _ModelUser, Services.Packages.Security.Security.ModelUserAccessControlListCollection _ACLs, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ACLs.Reload();
			if (_ACLs.Exists && !Services.Packages.Security.Security.Security.ModelUserAccessControlListSecureService.CheckAccessImp(_ACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ACLs.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create ACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.ACLs = _ACLs;
			_ModelUser.Update();
		}

    }
    
namespace Web
{
	/// <summary>
	/// The WebService secure service provider that allows to create web services
	/// that share Services.Packages.Security.ModelUser objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Security.Security.Web.ModelUserSecureWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class ModelUserSecureWebService : WebService, IModelUserSecureService
	{
		#region Secure service instance methods
        
        [WebMethod]
        public void EnableDisableSecurity(bool secure, string sessionToken)
        {
			ModelUserSecureService.EnableDisableSecurityImp(secure, sessionToken);
        }
        
        [WebMethod]
        public string[] GetUserRightDescriptors()
        {
			return ModelUserSecureService.GetUserRightDescriptorsImp();
        }
        
        [WebMethod]
        public void ChangeRights(string userName, string userRightDescriptor, bool allow, string SessionToken)
        {
			ModelUserSecureService.ChangeRightsImp(userName, userRightDescriptor, allow, SessionToken);
        }
        
        [WebMethod]
        public bool HasRights(string userName, string userRightDescriptor, string SessionToken)
        {
			return ModelUserSecureService.HasRightsImp(userName, userRightDescriptor, SessionToken);
        }
        
		[WebMethod]
        public bool HasAccess(Services.Packages.Security.ModelUser _object, string userName, string securityDescriptor, string SessionToken)
		{
			return ModelUserSecureService.HasAccessImp(_object, userName, securityDescriptor, SessionToken);
		}
		
		[WebMethod]
        public void ChangeAccess(Services.Packages.Security.ModelUser _object, string userName, string securityDescriptor, bool allow, string SessionToken)
        {
			ModelUserSecureService.ChangeAccessImp(_object, userName, securityDescriptor, allow, SessionToken);
        }

        [WebMethod]
        public void SetObjectOwner(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.SetOwnerImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void SetDatabaseOwner(string userName)
        {
			ModelUserSecureService.SetDatabaseOwnerImp(userName);
        }
		
        [WebMethod]
        public string[] GetSecurityDescriptors()
        {
			return ModelUserSecureService.GetSecurityDescriptorsImp();
        }
        
        [WebMethod]
        public void AllowTraverse(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.AllowTraverseImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowRead(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.AllowReadImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowUpdate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.AllowUpdateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowCreate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.AllowCreateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowReadAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.AllowReadAccessImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowChangeAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.AllowChangeAccessImp(_object, userName, SessionToken);
        }
		
        [WebMethod]
        public bool HasTraverse(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			return ModelUserSecureService.HasTraverseImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasRead(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			return ModelUserSecureService.HasReadImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasUpdate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			return ModelUserSecureService.HasUpdateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasCreate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			return ModelUserSecureService.HasCreateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasReadAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			return ModelUserSecureService.HasReadAccessImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasChangeAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			return ModelUserSecureService.HasChangeAccessImp(_object, userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowTraverse(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowTraverseImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowRead(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowReadImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowUpdate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowUpdateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowCreate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowCreateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowReadAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowReadAccessImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowChangeAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowChangeAccessImp(_object, userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllTraverse(string userName, string SessionToken)
        {
			ModelUserSecureService.AllowAllTraverseImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllRead(string userName, string SessionToken)
        {
			ModelUserSecureService.AllowAllReadImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllUpdate(string userName, string SessionToken)
        {
			ModelUserSecureService.AllowAllUpdateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllCreate(string userName, string SessionToken)
        {
			ModelUserSecureService.AllowAllCreateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllReadAccess(string userName, string SessionToken)
        {
			ModelUserSecureService.AllowAllReadAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllChangeAccess(string userName, string SessionToken)
        {
			ModelUserSecureService.AllowAllChangeAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllTraverse(string userName, string SessionToken)
        {
			return ModelUserSecureService.HasAllTraverseImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllRead(string userName, string SessionToken)
        {
			return ModelUserSecureService.HasAllReadImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllUpdate(string userName, string SessionToken)
        {
			return ModelUserSecureService.HasAllUpdateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllCreate(string userName, string SessionToken)
        {
			return ModelUserSecureService.HasAllCreateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllReadAccess(string userName, string SessionToken)
        {
			return ModelUserSecureService.HasAllReadAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllChangeAccess(string userName, string SessionToken)
        {
			return ModelUserSecureService.HasAllChangeAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllTraverse(string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowAllTraverseImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllRead(string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowAllReadImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllUpdate(string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowAllUpdateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllCreate(string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowAllCreateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllReadAccess(string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowAllReadAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllChangeAccess(string userName, string SessionToken)
        {
			ModelUserSecureService.DisallowAllChangeAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public string LoginAnonymous()
        {
			return ModelUserSecureService.LoginAnonymousImp();
        }
        
        [WebMethod]
        public string Login(string userName, string password)
        {
			return ModelUserSecureService.LoginImp(userName, password);
        }
        
        [WebMethod]
        public void SwitchUser(string userName, string password, string existingSessionToken)
        {
			ModelUserSecureService.SwitchUserImp(userName, password, existingSessionToken);
        }

        [WebMethod]
        public bool SessionExists(string sessionToken)
        {
			return ModelUserSecureService.SessionExistsImp(sessionToken);
        }

        [WebMethod]
        public void LogoutSession(string sessionToken, bool keepSession)
        {
			ModelUserSecureService.LogoutSessionImp(sessionToken, keepSession);
        }
        
        [WebMethod]
        public void LogoutAllSessions(string userName, string SessionToken)
        {
			ModelUserSecureService.LogoutAllSessionsImp(userName, SessionToken);
        }
		
		[WebMethod]
        public ModelUser GetCurrentUser(string SessionToken)
		{
			return ModelUserSecureService.GetCurrentUserImp(SessionToken);
        }

		[WebMethod]
        public ModelUser GetUser(string userName, string SessionToken)
		{
			return ModelUserSecureService.GetUserImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void SetUserByObject(ModelUser userObject, string SessionToken)
		{
			ModelUserSecureService.SetUserByObjectImp(userObject, SessionToken);
        }
        
        [WebMethod]
        public void AddUser(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			ModelUserSecureService.AddUserImp(userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken);
        }

        [WebMethod]
        public void UpdateUser(string userName, string oldPassword, string email, string secretQuestion,
            string secretAnswer, string SessionToken)
        {
			ModelUserSecureService.UpdateUserImp(userName, oldPassword, email, secretQuestion,
				secretAnswer, SessionToken);
        }
        
        [WebMethod]
        public void UpdateUserWithEnable(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			ModelUserSecureService.UpdateUserImp(userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken);
        }
        
        [WebMethod]
        public void DeleteUser(string userName, string SessionToken)
        {
			ModelUserSecureService.DeleteUserImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void ChangePassword(string userName, string oldPassword, string newPassword, string SessionToken)
        {
			ModelUserSecureService.ChangePasswordImp(userName, oldPassword, newPassword, SessionToken);
        }
        
        [WebMethod]
        public string CreateRandomPassword(string userName, string answer, string SessionToken)
        {
			return ModelUserSecureService.CreateRandomPasswordImp(userName, answer, SessionToken);
        }

        [WebMethod]
        public Securable GetSecurable(string SessionToken)
        {
			return ModelUserSecureService.GetSecurableImp(SessionToken);
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
        public bool Exists(ModelUser _ModelUser, string SessionToken)
        {
			if (!ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _ModelUser.Exists;
        }
		
		[WebMethod]
		public ModelUser Read(System.String __Name, string SessionToken)
		{
			ModelUser _ModelUser = new ModelUser(__Name);
			
			if (!ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _ModelUser;
		}
		
		[WebMethod]
        public ModelUser Reload(ModelUser _ModelUser, string SessionToken)
        {
			_ModelUser.Reload();
			
			if (!ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _ModelUser;
        }
		
		[WebMethod]
        public ModelUser Create(System.String __Name, string SessionToken)
        {
			ModelSession session = ModelUserSecureService.CheckSessionImp(SessionToken);

            if (!ModelUserSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ModelUser).FullName))
				throw new UnauthorizedAccessException("Access Denied");
            
            ModelUser _ModelUser = ModelUser.CreateModelUser(__Name);
            _ModelUser.Owner = session.User;
            _ModelUser.Update();
			return _ModelUser;
        }
        
        [WebMethod]
        public void Delete(System.String __Name, string SessionToken)
        {
			ModelUser _ModelUser = new ModelUser(__Name);
			
			if (!ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Delete"))
				throw new UnauthorizedAccessException("Access Denied");
			
			ModelUser.DeleteModelUser(__Name);
        }
        
        [WebMethod]
        public void UpdateObject(ModelUser _ModelUser, string SessionToken)
        {
			if (!ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ModelUser.Update();
        }
		
		[WebMethod]
        public void CreateObject(ModelUser _ModelUser, string SessionToken)
        {
			ModelSession session = ModelUserSecureService.CheckSessionImp(SessionToken);

            if (!ModelUserSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ModelUser).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ModelUser.Owner = session.User;
            _ModelUser.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ModelUser _ModelUser, string SessionToken)
        {
			if (!ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Delete"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ModelUser.Delete();
        }

		[WebMethod]
        public void Undo(string SessionToken)
        {
			ModelSession session = ModelUserSecureService.CheckSessionImp(SessionToken);

			// Must have all available access to the class level (all objects)
			if (!ModelUserSecureService.CheckUserRightsImp(session.User.Name, "Update " + typeof(ModelUser).FullName) ||
				!ModelUserSecureService.CheckUserRightsImp(session.User.Name, "Delete " + typeof(ModelUser).FullName) ||
				!ModelUserSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ModelUser).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			ModelUser.Undo();
        }

		[WebMethod]
        public void Redo(string SessionToken)
        {
			ModelSession session = ModelUserSecureService.CheckSessionImp(SessionToken);

			// Must have all available access to the class level (all objects)
			if (!ModelUserSecureService.CheckUserRightsImp(session.User.Name, "Update " + typeof(ModelUser).FullName) ||
				!ModelUserSecureService.CheckUserRightsImp(session.User.Name, "Delete " + typeof(ModelUser).FullName) ||
				!ModelUserSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(ModelUser).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			ModelUser.Redo();
        }

        		
		[WebMethod]
        public ModelUser CreateFromOwner(System.String __Name, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			ModelSession session = ModelUserSecureService.CheckSessionImp(SessionToken);

			ModelUser _ModelUser = new ModelUser(__Name);
            
            if (!_ModelUser.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create ModelUserOwning"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ModelUser.Exists && !ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // ModelUser _ModelUser = ModelUser.CreateModelUser(__Name);
            _ModelUser.Owner = session.User;
            _ModelUser.Owner = _Owner;
            _ModelUser.Update();
			return _ModelUser;
        }
        
        [WebMethod]
        public void CreateObjectFromOwner(ModelUser _ModelUser, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			ModelSession session = ModelUserSecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create ModelUserOwning"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_ModelUser.Reload();
			
			if (!_ModelUser.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create ModelUserOwning"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_ModelUser.Exists && !ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_ModelUser.Owner = session.User;
            _ModelUser.Owner = _Owner;
            _ModelUser.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_Owner, userName, "Create ModelUserOwning", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            return Services.Packages.Security.Security.ModelUserSecureService.HasAccessImp(_Owner, userName, "Create ModelUserOwning", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_Owner, userName, "Create ModelUserOwning", false, SessionToken);
        }

		[WebMethod]
		public ModelUserCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ModelUserCollection c = ModelUser.GetByOwner( _ModelUser);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ModelUserSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ModelUserCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ModelUserCollection c = ModelUser.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ModelUserSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
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
			
			return ModelUser.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser.Owner, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.Owner;
		}
		[WebMethod]
		public void SetOwner(ModelUser _ModelUser, Services.Packages.Security.ModelUser _Owner, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_Owner.Reload();
			if (_Owner.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Owner.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create ModelUserOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.Owner = _Owner;
			_ModelUser.Update();
		}
		[WebMethod]
		public ModelUserCollection SearchByName(System.String Name , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ModelUserCollection c = ModelUser.SearchByName(Name );
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ModelUserSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ModelUserCollection SearchByNamePaged(System.String Name , long PagingStart, long PagingCount, string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ModelUserCollection c = ModelUser.SearchByNamePaged(Name , PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ModelUserSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByNameCount(System.String Name , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ModelUser.SearchByNameCount(Name );
		}
		[WebMethod]
		public ModelUserCollection SearchByEmail(System.String Email , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ModelUserCollection c = ModelUser.SearchByEmail(Email );
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ModelUserSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ModelUserCollection SearchByEmailPaged(System.String Email , long PagingStart, long PagingCount, string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ModelUserCollection c = ModelUser.SearchByEmailPaged(Email , PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ModelUserSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByEmailCount(System.String Email , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ModelUser.SearchByEmailCount(Email );
		}
		[WebMethod]
		public ModelUserCollection SearchEnabledByNameAndEmail(System.String Name, System.String Email, System.Boolean Enabled , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ModelUserCollection c = ModelUser.SearchEnabledByNameAndEmail(Name, Email, Enabled );
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ModelUserSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public ModelUserCollection SearchEnabledByNameAndEmailPaged(System.String Name, System.String Email, System.Boolean Enabled , long PagingStart, long PagingCount, string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			ModelUserCollection c = ModelUser.SearchEnabledByNameAndEmailPaged(Name, Email, Enabled , PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!ModelUserSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchEnabledByNameAndEmailCount(System.String Name, System.String Email, System.Boolean Enabled , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return ModelUser.SearchEnabledByNameAndEmailCount(Name, Email, Enabled );
		}
		[WebMethod]
		public Services.Packages.PackageCollection GetPackageOwning(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.PackageSecureService.CheckAccessImp(_ModelUser.PackageOwning, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.PackageOwning;
		}
		[WebMethod]
		public void SetPackageOwning(ModelUser _ModelUser, Services.Packages.PackageCollection _PackageOwning, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_PackageOwning.Reload();
			if (_PackageOwning.Exists && !Services.Packages.Security.PackageSecureService.CheckAccessImp(_PackageOwning, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_PackageOwning.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create PackageOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.PackageOwning = _PackageOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.ApiKeyCollection GetApiKeyOwning(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ModelUser.ApiKeyOwning, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.ApiKeyOwning;
		}
		[WebMethod]
		public void SetApiKeyOwning(ModelUser _ModelUser, Services.Packages.ApiKeyCollection _ApiKeyOwning, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ApiKeyOwning.Reload();
			if (_ApiKeyOwning.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_ApiKeyOwning, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ApiKeyOwning.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create ApiKeyOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.ApiKeyOwning = _ApiKeyOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Log.ApplicationExceptionCollection GetApplicationExceptionOwning(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ModelUser.ApplicationExceptionOwning, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.ApplicationExceptionOwning;
		}
		[WebMethod]
		public void SetApplicationExceptionOwning(ModelUser _ModelUser, Services.Packages.Log.ApplicationExceptionCollection _ApplicationExceptionOwning, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ApplicationExceptionOwning.Reload();
			if (_ApplicationExceptionOwning.Exists && !Services.Packages.Log.Security.ApplicationExceptionSecureService.CheckAccessImp(_ApplicationExceptionOwning, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ApplicationExceptionOwning.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create ApplicationExceptionOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.ApplicationExceptionOwning = _ApplicationExceptionOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.CustomerCollection GetCustomerOwning(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_ModelUser.CustomerOwning, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.CustomerOwning;
		}
		[WebMethod]
		public void SetCustomerOwning(ModelUser _ModelUser, Services.Packages.CustomerCollection _CustomerOwning, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_CustomerOwning.Reload();
			if (_CustomerOwning.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_CustomerOwning, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_CustomerOwning.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create CustomerOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.CustomerOwning = _CustomerOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.CustomerUserEntryCollection GetCustomerUserEntries(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_ModelUser.CustomerUserEntries, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.CustomerUserEntries;
		}
		[WebMethod]
		public void SetCustomerUserEntries(ModelUser _ModelUser, Services.Packages.CustomerUserEntryCollection _CustomerUserEntries, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_CustomerUserEntries.Reload();
			if (_CustomerUserEntries.Exists && !Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntries, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_CustomerUserEntries.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create CustomerUserEntries"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.CustomerUserEntries = _CustomerUserEntries;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.CustomerUserEntryCollection GetCustomerUserEntryOwning(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_ModelUser.CustomerUserEntryOwning, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.CustomerUserEntryOwning;
		}
		[WebMethod]
		public void SetCustomerUserEntryOwning(ModelUser _ModelUser, Services.Packages.CustomerUserEntryCollection _CustomerUserEntryOwning, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_CustomerUserEntryOwning.Reload();
			if (_CustomerUserEntryOwning.Exists && !Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntryOwning, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_CustomerUserEntryOwning.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create CustomerUserEntryOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.CustomerUserEntryOwning = _CustomerUserEntryOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.PurchaseCollection GetPurchases(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.PurchaseSecureService.CheckAccessImp(_ModelUser.Purchases, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.Purchases;
		}
		[WebMethod]
		public void SetPurchases(ModelUser _ModelUser, Services.Packages.PurchaseCollection _Purchases, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_Purchases.Reload();
			if (_Purchases.Exists && !Services.Packages.Security.PurchaseSecureService.CheckAccessImp(_Purchases, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Purchases.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create Purchases"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.Purchases = _Purchases;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.PurchaseCollection GetPurchaseOwning(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.PurchaseSecureService.CheckAccessImp(_ModelUser.PurchaseOwning, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.PurchaseOwning;
		}
		[WebMethod]
		public void SetPurchaseOwning(ModelUser _ModelUser, Services.Packages.PurchaseCollection _PurchaseOwning, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_PurchaseOwning.Reload();
			if (_PurchaseOwning.Exists && !Services.Packages.Security.PurchaseSecureService.CheckAccessImp(_PurchaseOwning, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_PurchaseOwning.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create PurchaseOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.PurchaseOwning = _PurchaseOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.PurchaseLineCollection GetPurchaseLineOwning(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.PurchaseLineSecureService.CheckAccessImp(_ModelUser.PurchaseLineOwning, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.PurchaseLineOwning;
		}
		[WebMethod]
		public void SetPurchaseLineOwning(ModelUser _ModelUser, Services.Packages.PurchaseLineCollection _PurchaseLineOwning, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_PurchaseLineOwning.Reload();
			if (_PurchaseLineOwning.Exists && !Services.Packages.Security.PurchaseLineSecureService.CheckAccessImp(_PurchaseLineOwning, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_PurchaseLineOwning.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create PurchaseLineOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.PurchaseLineOwning = _PurchaseLineOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.ModelUserCollection GetModelUserOwning(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser.ModelUserOwning, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.ModelUserOwning;
		}
		[WebMethod]
		public void SetModelUserOwning(ModelUser _ModelUser, Services.Packages.Security.ModelUserCollection _ModelUserOwning, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ModelUserOwning.Reload();
			if (_ModelUserOwning.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUserOwning, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ModelUserOwning.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create ModelUserOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.ModelUserOwning = _ModelUserOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.ModelSessionCollection GetSessions(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.ModelSessionSecureService.CheckAccessImp(_ModelUser.Sessions, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.Sessions;
		}
		[WebMethod]
		public void SetSessions(ModelUser _ModelUser, Services.Packages.Security.ModelSessionCollection _Sessions, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_Sessions.Reload();
			if (_Sessions.Exists && !Services.Packages.Security.Security.ModelSessionSecureService.CheckAccessImp(_Sessions, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Sessions.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create Sessions"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.Sessions = _Sessions;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.ModelUserRightsCollection GetRights(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.ModelUserRightsSecureService.CheckAccessImp(_ModelUser.Rights, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.Rights;
		}
		[WebMethod]
		public void SetRights(ModelUser _ModelUser, Services.Packages.Security.ModelUserRightsCollection _Rights, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_Rights.Reload();
			if (_Rights.Exists && !Services.Packages.Security.Security.ModelUserRightsSecureService.CheckAccessImp(_Rights, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Rights.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create Rights"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.Rights = _Rights;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.PackageAccessControlListCollection GetPackageACLs(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.PackageAccessControlListSecureService.CheckAccessImp(_ModelUser.PackageACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.PackageACLs;
		}
		[WebMethod]
		public void SetPackageACLs(ModelUser _ModelUser, Services.Packages.Security.PackageAccessControlListCollection _PackageACLs, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_PackageACLs.Reload();
			if (_PackageACLs.Exists && !Services.Packages.Security.Security.PackageAccessControlListSecureService.CheckAccessImp(_PackageACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_PackageACLs.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create PackageACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.PackageACLs = _PackageACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.ApiKeyAccessControlListCollection GetApiKeyACLs(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.ApiKeyAccessControlListSecureService.CheckAccessImp(_ModelUser.ApiKeyACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.ApiKeyACLs;
		}
		[WebMethod]
		public void SetApiKeyACLs(ModelUser _ModelUser, Services.Packages.Security.ApiKeyAccessControlListCollection _ApiKeyACLs, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ApiKeyACLs.Reload();
			if (_ApiKeyACLs.Exists && !Services.Packages.Security.Security.ApiKeyAccessControlListSecureService.CheckAccessImp(_ApiKeyACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ApiKeyACLs.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create ApiKeyACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.ApiKeyACLs = _ApiKeyACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection GetApplicationExceptionACLs(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Log.Security.Security.ApplicationExceptionAccessControlListSecureService.CheckAccessImp(_ModelUser.ApplicationExceptionACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.ApplicationExceptionACLs;
		}
		[WebMethod]
		public void SetApplicationExceptionACLs(ModelUser _ModelUser, Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection _ApplicationExceptionACLs, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ApplicationExceptionACLs.Reload();
			if (_ApplicationExceptionACLs.Exists && !Services.Packages.Log.Security.Security.ApplicationExceptionAccessControlListSecureService.CheckAccessImp(_ApplicationExceptionACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ApplicationExceptionACLs.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create ApplicationExceptionACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.ApplicationExceptionACLs = _ApplicationExceptionACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.CustomerAccessControlListCollection GetCustomerACLs(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.CustomerAccessControlListSecureService.CheckAccessImp(_ModelUser.CustomerACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.CustomerACLs;
		}
		[WebMethod]
		public void SetCustomerACLs(ModelUser _ModelUser, Services.Packages.Security.CustomerAccessControlListCollection _CustomerACLs, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_CustomerACLs.Reload();
			if (_CustomerACLs.Exists && !Services.Packages.Security.Security.CustomerAccessControlListSecureService.CheckAccessImp(_CustomerACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_CustomerACLs.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create CustomerACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.CustomerACLs = _CustomerACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.CustomerUserEntryAccessControlListCollection GetCustomerUserEntryACLs(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.CustomerUserEntryAccessControlListSecureService.CheckAccessImp(_ModelUser.CustomerUserEntryACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.CustomerUserEntryACLs;
		}
		[WebMethod]
		public void SetCustomerUserEntryACLs(ModelUser _ModelUser, Services.Packages.Security.CustomerUserEntryAccessControlListCollection _CustomerUserEntryACLs, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_CustomerUserEntryACLs.Reload();
			if (_CustomerUserEntryACLs.Exists && !Services.Packages.Security.Security.CustomerUserEntryAccessControlListSecureService.CheckAccessImp(_CustomerUserEntryACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_CustomerUserEntryACLs.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create CustomerUserEntryACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.CustomerUserEntryACLs = _CustomerUserEntryACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.PurchaseAccessControlListCollection GetPurchaseACLs(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.PurchaseAccessControlListSecureService.CheckAccessImp(_ModelUser.PurchaseACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.PurchaseACLs;
		}
		[WebMethod]
		public void SetPurchaseACLs(ModelUser _ModelUser, Services.Packages.Security.PurchaseAccessControlListCollection _PurchaseACLs, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_PurchaseACLs.Reload();
			if (_PurchaseACLs.Exists && !Services.Packages.Security.Security.PurchaseAccessControlListSecureService.CheckAccessImp(_PurchaseACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_PurchaseACLs.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create PurchaseACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.PurchaseACLs = _PurchaseACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.PurchaseLineAccessControlListCollection GetPurchaseLineACLs(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.PurchaseLineAccessControlListSecureService.CheckAccessImp(_ModelUser.PurchaseLineACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.PurchaseLineACLs;
		}
		[WebMethod]
		public void SetPurchaseLineACLs(ModelUser _ModelUser, Services.Packages.Security.PurchaseLineAccessControlListCollection _PurchaseLineACLs, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_PurchaseLineACLs.Reload();
			if (_PurchaseLineACLs.Exists && !Services.Packages.Security.Security.PurchaseLineAccessControlListSecureService.CheckAccessImp(_PurchaseLineACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_PurchaseLineACLs.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create PurchaseLineACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.PurchaseLineACLs = _PurchaseLineACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.Security.ModelUserAccessControlListCollection GetModelUserACLs(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.Security.ModelUserAccessControlListSecureService.CheckAccessImp(_ModelUser.ModelUserACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.ModelUserACLs;
		}
		[WebMethod]
		public void SetModelUserACLs(ModelUser _ModelUser, Services.Packages.Security.Security.ModelUserAccessControlListCollection _ModelUserACLs, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ModelUserACLs.Reload();
			if (_ModelUserACLs.Exists && !Services.Packages.Security.Security.Security.ModelUserAccessControlListSecureService.CheckAccessImp(_ModelUserACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ModelUserACLs.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create ModelUserACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.ModelUserACLs = _ModelUserACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.Security.ModelUserAccessControlListCollection GetACLs(ModelUser _ModelUser, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.Security.ModelUserAccessControlListSecureService.CheckAccessImp(_ModelUser.ACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _ModelUser.ACLs;
		}
		[WebMethod]
		public void SetACLs(ModelUser _ModelUser, Services.Packages.Security.Security.ModelUserAccessControlListCollection _ACLs, string SessionToken)
		{
			_ModelUser.Reload();
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ACLs.Reload();
			if (_ACLs.Exists && !Services.Packages.Security.Security.Security.ModelUserAccessControlListSecureService.CheckAccessImp(_ACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ACLs.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Create ACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_ModelUser.ACLs = _ACLs;
			_ModelUser.Update();
		}

	}
	
	/// <summary>
	/// The WebService secure client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="ModelUserWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("764f95d5-6ea0-139e-8289-655b07620d81")]
    sealed public class ModelUserSecureWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IModelUserSecureService
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
		public ModelUserSecureWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public ModelUserSecureWebServiceClient()
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
		public bool HasAccess(Services.Packages.Security.ModelUser _object, string userName, string securityDescriptor, string SessionToken)
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
		public void ChangeAccess(Services.Packages.Security.ModelUser _object, string userName, string securityDescriptor, bool allow, string SessionToken)
        {
			this.Invoke("ChangeAccess", new object[] {_object, userName, securityDescriptor, allow, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetObjectOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetObjectOwner(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
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
		public void AllowTraverse(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			this.Invoke("AllowTraverse", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowRead", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowRead(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			this.Invoke("AllowRead", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowUpdate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowUpdate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			this.Invoke("AllowUpdate", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowCreate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowCreate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			this.Invoke("AllowCreate", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowReadAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowReadAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			this.Invoke("AllowReadAccess", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowChangeAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowChangeAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			this.Invoke("AllowChangeAccess", new object[] {_object, userName, SessionToken});
			return;
        }
		
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasTraverse", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasTraverse(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasTraverse", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasRead", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasRead(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasRead", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasUpdate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasUpdate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasUpdate", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasCreate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasCreate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasCreate", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasReadAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasReadAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasReadAccess", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasChangeAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasChangeAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasChangeAccess", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowTraverse", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowTraverse(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowTraverse", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowRead", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowRead(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowRead", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowUpdate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowUpdate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowUpdate", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowCreate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowCreate(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowCreate", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowReadAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowReadAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowReadAccess", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowChangeAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowChangeAccess(Services.Packages.Security.ModelUser _object, string userName, string SessionToken)
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
		public bool Exists(ModelUser _ModelUser, string SessionToken)
        {
			object[] results = this.Invoke("Exists", new object[] {_ModelUser,SessionToken});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUser Read(System.String __Name, string SessionToken)
		{
			object[] results = this.Invoke("Read", new object[] {__Name, SessionToken});
			return ((ModelUser)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUser Reload(ModelUser _ModelUser, string SessionToken)
        {
			object[] results = this.Invoke("Reload", new object[] {_ModelUser,SessionToken});
			return ((ModelUser)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUser Create(System.String __Name, string SessionToken)
        {
			object[] results = this.Invoke("Create", new object[] {__Name, SessionToken});
			return ((ModelUser)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __Name, string SessionToken)
        {
			this.Invoke("Delete", new object[] {__Name, SessionToken});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(ModelUser _ModelUser, string SessionToken)
        {
			this.Invoke("UpdateObject", new object[] {_ModelUser,SessionToken});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(ModelUser _ModelUser, string SessionToken)
        {
			this.Invoke("CreateObject", new object[] {_ModelUser,SessionToken});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(ModelUser _ModelUser, string SessionToken)
        {
			this.Invoke("DeleteObject", new object[] {_ModelUser,SessionToken});
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
        		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateFromOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUser CreateFromOwner(System.String __Name, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			object[] results = this.Invoke("Create", new object[] {__Name, _Owner,SessionToken});
			return ((ModelUser)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObjectFromOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObjectFromOwner(ModelUser _ModelUser, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			this.Invoke("CreateObjectFromOwner", new object[] {_ModelUser,_Owner,SessionToken});
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

		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser, string SessionToken) {
			object[] results = this.Invoke("GetByOwner", new object[] {_ModelUser,SessionToken});
			return ((ModelUserCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("GetByOwnerPaged", new object[] {_ModelUser,PagingStart,PagingCount,SessionToken});
			return ((ModelUserCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser, string SessionToken) {
			object[] results = this.Invoke("GetByOwnerCount", new object[] {_ModelUser,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetOwner(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetOwner", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetOwner(ModelUser _ModelUser, Services.Packages.Security.ModelUser _Owner, string SessionToken)
		{
			this.Invoke("GetOwner", new object[] {_ModelUser,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByName", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserCollection SearchByName(System.String Name , string SessionToken) {
			object[] results = this.Invoke("SearchByName", new object[] {Name,SessionToken});
			return ((ModelUserCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNamePaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserCollection SearchByNamePaged(System.String Name , long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("SearchByNamePaged", new object[] {Name,PagingStart,PagingCount,SessionToken});
			return ((ModelUserCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByNameCount(System.String Name , string SessionToken) {
			object[] results = this.Invoke("SearchByNameCount", new object[] {Name,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByEmail", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserCollection SearchByEmail(System.String Email , string SessionToken) {
			object[] results = this.Invoke("SearchByEmail", new object[] {Email,SessionToken});
			return ((ModelUserCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByEmailPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserCollection SearchByEmailPaged(System.String Email , long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("SearchByEmailPaged", new object[] {Email,PagingStart,PagingCount,SessionToken});
			return ((ModelUserCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByEmailCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByEmailCount(System.String Email , string SessionToken) {
			object[] results = this.Invoke("SearchByEmailCount", new object[] {Email,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchEnabledByNameAndEmail", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserCollection SearchEnabledByNameAndEmail(System.String Name, System.String Email, System.Boolean Enabled , string SessionToken) {
			object[] results = this.Invoke("SearchEnabledByNameAndEmail", new object[] {Name, Email, Enabled,SessionToken});
			return ((ModelUserCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchEnabledByNameAndEmailPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserCollection SearchEnabledByNameAndEmailPaged(System.String Name, System.String Email, System.Boolean Enabled , long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("SearchEnabledByNameAndEmailPaged", new object[] {Name, Email, Enabled,PagingStart,PagingCount,SessionToken});
			return ((ModelUserCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchEnabledByNameAndEmailCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchEnabledByNameAndEmailCount(System.String Name, System.String Email, System.Boolean Enabled , string SessionToken) {
			object[] results = this.Invoke("SearchEnabledByNameAndEmailCount", new object[] {Name, Email, Enabled,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPackageOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.PackageCollection GetPackageOwning(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetPackageOwning", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.PackageCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPackageOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPackageOwning(ModelUser _ModelUser, Services.Packages.PackageCollection _PackageOwning, string SessionToken)
		{
			this.Invoke("GetPackageOwning", new object[] {_ModelUser,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetApiKeyOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.ApiKeyCollection GetApiKeyOwning(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetApiKeyOwning", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.ApiKeyCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetApiKeyOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetApiKeyOwning(ModelUser _ModelUser, Services.Packages.ApiKeyCollection _ApiKeyOwning, string SessionToken)
		{
			this.Invoke("GetApiKeyOwning", new object[] {_ModelUser,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetApplicationExceptionOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Log.ApplicationExceptionCollection GetApplicationExceptionOwning(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetApplicationExceptionOwning", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.Log.ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetApplicationExceptionOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetApplicationExceptionOwning(ModelUser _ModelUser, Services.Packages.Log.ApplicationExceptionCollection _ApplicationExceptionOwning, string SessionToken)
		{
			this.Invoke("GetApplicationExceptionOwning", new object[] {_ModelUser,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetCustomerOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.CustomerCollection GetCustomerOwning(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetCustomerOwning", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetCustomerOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetCustomerOwning(ModelUser _ModelUser, Services.Packages.CustomerCollection _CustomerOwning, string SessionToken)
		{
			this.Invoke("GetCustomerOwning", new object[] {_ModelUser,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetCustomerUserEntries", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.CustomerUserEntryCollection GetCustomerUserEntries(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetCustomerUserEntries", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.CustomerUserEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetCustomerUserEntries", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetCustomerUserEntries(ModelUser _ModelUser, Services.Packages.CustomerUserEntryCollection _CustomerUserEntries, string SessionToken)
		{
			this.Invoke("GetCustomerUserEntries", new object[] {_ModelUser,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetCustomerUserEntryOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.CustomerUserEntryCollection GetCustomerUserEntryOwning(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetCustomerUserEntryOwning", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.CustomerUserEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetCustomerUserEntryOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetCustomerUserEntryOwning(ModelUser _ModelUser, Services.Packages.CustomerUserEntryCollection _CustomerUserEntryOwning, string SessionToken)
		{
			this.Invoke("GetCustomerUserEntryOwning", new object[] {_ModelUser,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPurchases", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.PurchaseCollection GetPurchases(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetPurchases", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.PurchaseCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPurchases", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPurchases(ModelUser _ModelUser, Services.Packages.PurchaseCollection _Purchases, string SessionToken)
		{
			this.Invoke("GetPurchases", new object[] {_ModelUser,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPurchaseOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.PurchaseCollection GetPurchaseOwning(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetPurchaseOwning", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.PurchaseCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPurchaseOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPurchaseOwning(ModelUser _ModelUser, Services.Packages.PurchaseCollection _PurchaseOwning, string SessionToken)
		{
			this.Invoke("GetPurchaseOwning", new object[] {_ModelUser,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPurchaseLineOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.PurchaseLineCollection GetPurchaseLineOwning(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetPurchaseLineOwning", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.PurchaseLineCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPurchaseLineOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPurchaseLineOwning(ModelUser _ModelUser, Services.Packages.PurchaseLineCollection _PurchaseLineOwning, string SessionToken)
		{
			this.Invoke("GetPurchaseLineOwning", new object[] {_ModelUser,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetModelUserOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUserCollection GetModelUserOwning(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetModelUserOwning", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.Security.ModelUserCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetModelUserOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetModelUserOwning(ModelUser _ModelUser, Services.Packages.Security.ModelUserCollection _ModelUserOwning, string SessionToken)
		{
			this.Invoke("GetModelUserOwning", new object[] {_ModelUser,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetSessions", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelSessionCollection GetSessions(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetSessions", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.Security.ModelSessionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetSessions", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetSessions(ModelUser _ModelUser, Services.Packages.Security.ModelSessionCollection _Sessions, string SessionToken)
		{
			this.Invoke("GetSessions", new object[] {_ModelUser,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetRights", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUserRightsCollection GetRights(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetRights", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.Security.ModelUserRightsCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetRights", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetRights(ModelUser _ModelUser, Services.Packages.Security.ModelUserRightsCollection _Rights, string SessionToken)
		{
			this.Invoke("GetRights", new object[] {_ModelUser,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPackageACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.PackageAccessControlListCollection GetPackageACLs(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetPackageACLs", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.Security.PackageAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPackageACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPackageACLs(ModelUser _ModelUser, Services.Packages.Security.PackageAccessControlListCollection _PackageACLs, string SessionToken)
		{
			this.Invoke("GetPackageACLs", new object[] {_ModelUser,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetApiKeyACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ApiKeyAccessControlListCollection GetApiKeyACLs(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetApiKeyACLs", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.Security.ApiKeyAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetApiKeyACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetApiKeyACLs(ModelUser _ModelUser, Services.Packages.Security.ApiKeyAccessControlListCollection _ApiKeyACLs, string SessionToken)
		{
			this.Invoke("GetApiKeyACLs", new object[] {_ModelUser,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetApplicationExceptionACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection GetApplicationExceptionACLs(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetApplicationExceptionACLs", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetApplicationExceptionACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetApplicationExceptionACLs(ModelUser _ModelUser, Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection _ApplicationExceptionACLs, string SessionToken)
		{
			this.Invoke("GetApplicationExceptionACLs", new object[] {_ModelUser,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetCustomerACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.CustomerAccessControlListCollection GetCustomerACLs(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetCustomerACLs", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.Security.CustomerAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetCustomerACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetCustomerACLs(ModelUser _ModelUser, Services.Packages.Security.CustomerAccessControlListCollection _CustomerACLs, string SessionToken)
		{
			this.Invoke("GetCustomerACLs", new object[] {_ModelUser,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetCustomerUserEntryACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.CustomerUserEntryAccessControlListCollection GetCustomerUserEntryACLs(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetCustomerUserEntryACLs", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.Security.CustomerUserEntryAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetCustomerUserEntryACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetCustomerUserEntryACLs(ModelUser _ModelUser, Services.Packages.Security.CustomerUserEntryAccessControlListCollection _CustomerUserEntryACLs, string SessionToken)
		{
			this.Invoke("GetCustomerUserEntryACLs", new object[] {_ModelUser,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPurchaseACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.PurchaseAccessControlListCollection GetPurchaseACLs(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetPurchaseACLs", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.Security.PurchaseAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPurchaseACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPurchaseACLs(ModelUser _ModelUser, Services.Packages.Security.PurchaseAccessControlListCollection _PurchaseACLs, string SessionToken)
		{
			this.Invoke("GetPurchaseACLs", new object[] {_ModelUser,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPurchaseLineACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.PurchaseLineAccessControlListCollection GetPurchaseLineACLs(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetPurchaseLineACLs", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.Security.PurchaseLineAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPurchaseLineACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPurchaseLineACLs(ModelUser _ModelUser, Services.Packages.Security.PurchaseLineAccessControlListCollection _PurchaseLineACLs, string SessionToken)
		{
			this.Invoke("GetPurchaseLineACLs", new object[] {_ModelUser,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetModelUserACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.Security.ModelUserAccessControlListCollection GetModelUserACLs(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetModelUserACLs", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.Security.Security.ModelUserAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetModelUserACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetModelUserACLs(ModelUser _ModelUser, Services.Packages.Security.Security.ModelUserAccessControlListCollection _ModelUserACLs, string SessionToken)
		{
			this.Invoke("GetModelUserACLs", new object[] {_ModelUser,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.Security.ModelUserAccessControlListCollection GetACLs(ModelUser _ModelUser, string SessionToken)
		{
			object[] results = this.Invoke("GetACLs", new object[] {_ModelUser,SessionToken});
			return ((Services.Packages.Security.Security.ModelUserAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACLs(ModelUser _ModelUser, Services.Packages.Security.Security.ModelUserAccessControlListCollection _ACLs, string SessionToken)
		{
			this.Invoke("GetACLs", new object[] {_ModelUser,SessionToken});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages.Security
