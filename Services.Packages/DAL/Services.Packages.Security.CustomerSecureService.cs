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
    /// apply servicing on Services.Packages.Customer type.
    /// </summary>
    [ComVisible(true)]
    [Guid("00b38737-0536-4dbe-2e17-ae2ab5239e05")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface ICustomerSecureService
    {
		#region Securable interface definitions
        void EnableDisableSecurity(bool secure, string sessionToken);
        
        string[] GetUserRightDescriptors();
        bool HasRights(string userName, string userRightDescriptor, string SessionToken);
		void ChangeRights(string userName, string userRightDescriptor, bool allow, string SessionToken);
		void ChangeAccess(Services.Packages.Customer _object, string userName, string securityDescriptor, bool allow, string SessionToken);
		bool HasAccess(Services.Packages.Customer _object, string userName, string securityDescriptor, string SessionToken);
        
        void SetObjectOwner(Services.Packages.Customer _object, string userName, string SessionToken);
        void SetDatabaseOwner(string userName);
        
        string[] GetSecurityDescriptors();
        void AllowTraverse(Services.Packages.Customer _object, string userName, string SessionToken);
        void AllowRead(Services.Packages.Customer _object, string userName, string SessionToken);
        void AllowUpdate(Services.Packages.Customer _object, string userName, string SessionToken);
        void AllowCreate(Services.Packages.Customer _object, string userName, string SessionToken);
        void AllowReadAccess(Services.Packages.Customer _object, string userName, string SessionToken);
        void AllowChangeAccess(Services.Packages.Customer _object, string userName, string SessionToken);
        bool HasTraverse(Services.Packages.Customer _object, string userName, string SessionToken);
        bool HasRead(Services.Packages.Customer _object, string userName, string SessionToken);
        bool HasUpdate(Services.Packages.Customer _object, string userName, string SessionToken);
        bool HasCreate(Services.Packages.Customer _object, string userName, string SessionToken);
        bool HasReadAccess(Services.Packages.Customer _object, string userName, string SessionToken);
        bool HasChangeAccess(Services.Packages.Customer _object, string userName, string SessionToken);
        void DisallowTraverse(Services.Packages.Customer _object, string userName, string SessionToken);
        void DisallowRead(Services.Packages.Customer _object, string userName, string SessionToken);
        void DisallowUpdate(Services.Packages.Customer _object, string userName, string SessionToken);
        void DisallowCreate(Services.Packages.Customer _object, string userName, string SessionToken);
        void DisallowReadAccess(Services.Packages.Customer _object, string userName, string SessionToken);
        void DisallowChangeAccess(Services.Packages.Customer _object, string userName, string SessionToken);
        
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
        bool Exists(Customer _Customer, string SessionToken);
		[OperationContract]
        Customer Read(System.String __Name, string SessionToken);
        [OperationContract]
        Customer Reload(Customer _Customer, string SessionToken);
        [OperationContract]
        Customer Create(System.String __Name, string SessionToken);
        [OperationContract]
        void Delete(System.String __Name, string SessionToken);
        [OperationContract]
        void UpdateObject(Customer _Customer, string SessionToken);
        [OperationContract]
        void CreateObject(Customer _Customer, string SessionToken);
        [OperationContract]
        void DeleteObject(Customer _Customer, string SessionToken);
        [OperationContract]
        void Undo(string SessionToken);
        [OperationContract]
        void Redo(string SessionToken);
        		
		[OperationContract]
        Customer CreateFromPartner(System.String __Name, Services.Packages.Customer _Partner, string SessionToken);
        [OperationContract]
        void CreateObjectFromPartner(Customer _Customer, Services.Packages.Customer _Partner, string SessionToken);
        [OperationContract]
        void AllowCreateFromPartner(Services.Packages.Customer _Partner, string userName, string SessionToken);
		[OperationContract]
        bool HasCreateFromPartner(Services.Packages.Customer _Partner, string userName, string SessionToken);
        [OperationContract]
        void DisallowCreateFromPartner(Services.Packages.Customer _Partner, string userName, string SessionToken);
		
		[OperationContract]
        Customer CreateFromOwner(System.String __Name, Services.Packages.Security.ModelUser _Owner, string SessionToken);
        [OperationContract]
        void CreateObjectFromOwner(Customer _Customer, Services.Packages.Security.ModelUser _Owner, string SessionToken);
        [OperationContract]
        void AllowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken);
		[OperationContract]
        bool HasCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken);
        [OperationContract]
        void DisallowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken);

		[OperationContract]
		CustomerCollection GetByPartner(Services.Packages.Customer _Customer, string SessionToken);
		[OperationContract]
		CustomerCollection GetByPartnerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long GetByPartnerCount(Services.Packages.Customer _Customer, string SessionToken);
		[OperationContract]
		Services.Packages.Customer GetPartner(Customer _Customer, string SessionToken);
		[OperationContract]
		void SetPartner(Customer _Customer, Services.Packages.Customer _Partner, string SessionToken);
		[OperationContract]
		CustomerCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		CustomerCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser, string SessionToken);
		[OperationContract]
		Services.Packages.Security.ModelUser GetOwner(Customer _Customer, string SessionToken);
		[OperationContract]
		void SetOwner(Customer _Customer, Services.Packages.Security.ModelUser _Owner, string SessionToken);
		[OperationContract]
		CustomerCollection SearchByNameAndPartner(System.String Name, System.Boolean IsPartner , string SessionToken);
		[OperationContract]
		CustomerCollection SearchByNameAndPartnerPaged(System.String Name, System.Boolean IsPartner , long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long SearchByNameAndPartnerCount(System.String Name, System.Boolean IsPartner , string SessionToken);
		[OperationContract]
		CustomerCollection SearchByName(System.String Name , string SessionToken);
		[OperationContract]
		CustomerCollection SearchByNamePaged(System.String Name , long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long SearchByNameCount(System.String Name , string SessionToken);
		[OperationContract]
		CustomerCollection SearchByNameAndPartnerPayment(System.String Name, System.Boolean IsPaymentAccepted , string SessionToken);
		[OperationContract]
		CustomerCollection SearchByNameAndPartnerPaymentPaged(System.String Name, System.Boolean IsPaymentAccepted , long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long SearchByNameAndPartnerPaymentCount(System.String Name, System.Boolean IsPaymentAccepted , string SessionToken);
		[OperationContract]
		CustomerCollection SearchByNameOnPartners(System.String Name, Services.Packages.Customer _Customer, string SessionToken);
		[OperationContract]
		CustomerCollection SearchByNameOnPartnersPaged(System.String Name, Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long SearchByNameOnPartnersCount(System.String Name, Services.Packages.Customer _Customer, string SessionToken);
		[OperationContract]
		CustomerCollection SearchByNameAndPaymentOnPartners(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer, string SessionToken);
		[OperationContract]
		CustomerCollection SearchByNameAndPaymentOnPartnersPaged(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken);
		[OperationContract]
		long SearchByNameAndPaymentOnPartnersCount(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer, string SessionToken);
		[OperationContract]
		Services.Packages.ApiKeyCollection GetLicensesIssued(Customer _Customer, string SessionToken);
		[OperationContract]
		void SetLicensesIssued(Customer _Customer, Services.Packages.ApiKeyCollection _LicensesIssued, string SessionToken);
		[OperationContract]
		Services.Packages.CustomerCollection GetPartnerCustomers(Customer _Customer, string SessionToken);
		[OperationContract]
		void SetPartnerCustomers(Customer _Customer, Services.Packages.CustomerCollection _PartnerCustomers, string SessionToken);
		[OperationContract]
		Services.Packages.CustomerUserEntryCollection GetCustomerUserEntries(Customer _Customer, string SessionToken);
		[OperationContract]
		void SetCustomerUserEntries(Customer _Customer, Services.Packages.CustomerUserEntryCollection _CustomerUserEntries, string SessionToken);
		[OperationContract]
		Services.Packages.Security.CustomerAccessControlListCollection GetACLs(Customer _Customer, string SessionToken);
		[OperationContract]
		void SetACLs(Customer _Customer, Services.Packages.Security.CustomerAccessControlListCollection _ACLs, string SessionToken);

    }
    
    /// <summary>
    /// WCF and default secure implementation of a service object for Services.Packages.Customer type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("73609ed8-c918-f560-7684-c68f89d76dbe")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class CustomerSecureService : ICustomerSecureService
    {
		#region Securable persistence

        internal static bool IsSecurableImp
        {
            get
            {
                Securable s = new Securable(typeof(CustomerSecureService).FullName);
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

            Securable s = new Securable(typeof(CustomerSecureService).FullName);
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
		
		internal static void ChangeAccessImp(Services.Packages.Customer _object, string userName, string securityDescriptor, bool allow, string SessionToken)
		{
			// Check if user can do that
            ModelSession session = CheckSessionImp(SessionToken);

            if (CheckAccessImp(_object, SessionToken, "ChangeAccess"))
            {
                try
                {
                    CustomerAccessControlListCollection acls = _object.GetACLs(userName);
                    CustomerAccessControlList acl;

                    if (acls.Count == 0)
                    {
                        acl = new CustomerAccessControlList();
                        acl.UserName = userName;
                        acl.Customer = _object;
                        acl.Create();
                    }
                    else
                    {
                        acl = acls[0];
                    }

                    CustomerAccessControlEntry entry = new CustomerAccessControlEntry();
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
        
        internal static void SetOwnerImp(Services.Packages.Customer _object, string userName, string SessionToken)
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
		
        internal static void AllowTraverseImp(Services.Packages.Customer _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Traverse", true, SessionToken);
        }

        internal static void AllowReadImp(Services.Packages.Customer _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Read", true, SessionToken);
        }

        internal static void AllowUpdateImp(Services.Packages.Customer _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Update", true, SessionToken);
        }

        internal static void AllowCreateImp(Services.Packages.Customer _object, string userName, string SessionToken)
        {
            // ChangeAccessImp(_object, userName, "Create " + typeof(Services.Packages.Customer).FullName, true, SessionToken);
            throw new NotImplementedException();
        }

        internal static void AllowReadAccessImp(Services.Packages.Customer _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "ReadAccess", true, SessionToken);
        }

        internal static void AllowChangeAccessImp(Services.Packages.Customer _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "ChangeAccess", true, SessionToken);
        }
        
        // Security check
		
        internal static bool HasTraverseImp(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			return HasAccessImp(_object, userName, "Traverse", SessionToken);
		}

        internal static bool HasReadImp(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			return HasAccessImp(_object, userName, "Read", SessionToken);
		}

        internal static bool HasUpdateImp(Services.Packages.Customer _object, string userName, string SessionToken)
        {
            return HasAccessImp(_object, userName, "Update", SessionToken);
		}

        internal static bool HasCreateImp(Services.Packages.Customer _object, string userName, string SessionToken)
        {
            // ChangeAccessImp(_object, userName, "Create " + typeof(Services.Packages.Customer).FullName, true, SessionToken);
            throw new NotImplementedException();
        }

        internal static bool HasReadAccessImp(Services.Packages.Customer _object, string userName, string SessionToken)
        {
            return HasAccessImp(_object, userName, "ReadAccess", SessionToken);
        }

        internal static bool HasChangeAccessImp(Services.Packages.Customer _object, string userName, string SessionToken)
        {
            return HasAccessImp(_object, userName, "ChangeAccess", SessionToken);
        }
        
        // Disallow
        
        internal static void DisallowTraverseImp(Services.Packages.Customer _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Traverse", false, SessionToken);
        }

        internal static void DisallowReadImp(Services.Packages.Customer _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Read", false, SessionToken);
        }

        internal static void DisallowUpdateImp(Services.Packages.Customer _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "Update", false, SessionToken);
        }

        internal static void DisallowCreateImp(Services.Packages.Customer _object, string userName, string SessionToken)
        {
            // ChangeAccessImp(_object, userName, "Create " + typeof(Services.Packages.Customer).FullName, false, SessionToken);
            throw new NotImplementedException();
        }

        internal static void DisallowReadAccessImp(Services.Packages.Customer _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "ReadAccess", false, SessionToken);
        }

        internal static void DisallowChangeAccessImp(Services.Packages.Customer _object, string userName, string SessionToken)
        {
            ChangeAccessImp(_object, userName, "ChangeAccess", false, SessionToken);
        }
        
        // General object security methods
        
        internal static void AllowAllTraverseImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Traverse " + typeof(Services.Packages.Customer).FullName, true, SessionToken);
        }
        
        internal static void AllowAllReadImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Read " + typeof(Services.Packages.Customer).FullName, true, SessionToken);
        }
        
        internal static void AllowAllUpdateImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Update " + typeof(Services.Packages.Customer).FullName, true, SessionToken);
        }
        
        internal static void AllowAllCreateImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Create " + typeof(Services.Packages.Customer).FullName, true, SessionToken);
        }
        
        internal static void AllowAllReadAccessImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "ReadAccess " + typeof(Services.Packages.Customer).FullName, true, SessionToken);
        }
        
        internal static void AllowAllChangeAccessImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "ChangeAccess " + typeof(Services.Packages.Customer).FullName, true, SessionToken);
        }
        
        internal static bool HasAllTraverseImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "Traverse " + typeof(Services.Packages.Customer).FullName, SessionToken);
        }
        
        internal static bool HasAllReadImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "Read " + typeof(Services.Packages.Customer).FullName, SessionToken);
        }
        
        internal static bool HasAllUpdateImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "Update " + typeof(Services.Packages.Customer).FullName, SessionToken);
        }
        
        internal static bool HasAllCreateImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "Create " + typeof(Services.Packages.Customer).FullName, SessionToken);
        }
        
        internal static bool HasAllReadAccessImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "ReadAccess " + typeof(Services.Packages.Customer).FullName, SessionToken);
        }
        
        internal static bool HasAllChangeAccessImp(string userName, string SessionToken)
        {
			return HasRightsImp(userName, "ChangeAccess " + typeof(Services.Packages.Customer).FullName, SessionToken);
        }
        
        internal static void DisallowAllTraverseImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Traverse " + typeof(Services.Packages.Customer).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllReadImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Read " + typeof(Services.Packages.Customer).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllUpdateImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Update " + typeof(Services.Packages.Customer).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllCreateImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "Create " + typeof(Services.Packages.Customer).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllReadAccessImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "ReadAccess " + typeof(Services.Packages.Customer).FullName, false, SessionToken);
        }
        
        internal static void DisallowAllChangeAccessImp(string userName, string SessionToken)
        {
            ChangeRightsImp(userName, "ChangeAccess " + typeof(Services.Packages.Customer).FullName, false, SessionToken);
        }
        
        #endregion
        
        #region Login / Logout

        internal static string GeneratePasswordImp()
        {
            char[] allowedCharacters = "qwertyuiopasdfghjklzxcvbnm1234567890-=!@#$%^&*()_+".ToCharArray();
            List<char> characterList = new List<char>();

            Random random = new Random();

            SetupImp();

            Securable s = new Securable(typeof(CustomerSecureService).FullName);

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
			
            Securable s = new Securable(typeof(CustomerSecureService).FullName);
            
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
				Securable s = new Securable(typeof(CustomerSecureService).FullName);
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
            
            Securable s = new Securable(typeof(CustomerSecureService).FullName);

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
            
            if (!mu.Enabled && !CustomerSecureService.CheckUserRightsImp(userName, "CannotBeDisabled"))
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
        
        internal static bool HasAccessImp(Services.Packages.Customer _object, string userName, string securityDescriptor, string SessionToken)
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
				s = new Securable(typeof(CustomerSecureService).FullName);
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
		
		internal static bool CheckAccessImp(Services.Packages.Customer _object, string sessionToken, string securityDescriptor)
		{
			// Check the ModelUser and ModelSession tables
			// using CustomerAccessControlList and CustomerAccessControlEntry
			ModelSession session = CheckSessionImp(sessionToken);
			
			return CheckAccessFromUserNameImp(_object, session.User.Name, securityDescriptor);
		}
		
		internal static bool CheckAccessFromUserNameImp(Services.Packages.Customer _object, string userName, string securityDescriptor)
		{	
			if (!CustomerSecureService.IsSecurableImp)
				return true;
			
			// Owner can do anything
			if (CheckUserRightsImp(userName, "Owner"))
				return true;
			
			// User could have constant rights on the class
			if (CheckUserRightsImp(userName, securityDescriptor + " " + typeof(Services.Packages.Customer).FullName))
				return true;
			
			if (_object.Owner != null && _object.Owner.Name == userName)
				return true;
			
			CustomerAccessControlListCollection acls = _object.GetACLs(userName);
			if (acls.Count == 0)
			{
				if (userName.ToLowerInvariant() != "everyone")
					return CheckAccessFromUserNameImp(_object, "Everyone", securityDescriptor);
				else return false;
			}
			
			CustomerAccessControlList acl = acls[0];
			
			CustomerAccessControlEntryCollection entries = CustomerAccessControlEntry.GetEntries(securityDescriptor.ToLowerInvariant(), acl);
			if (entries.Count == 0)
			{
				// Descriptor missing; Add-it
				CustomerAccessControlEntry entry = new CustomerAccessControlEntry();
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
			if (!CustomerSecureService.IsSecurableImp)
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
            
            Securable s = new Securable(typeof(CustomerSecureService).FullName);
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
				Securable s = new Securable(typeof(CustomerSecureService).FullName);
				return s;
            }
			
			throw new UnauthorizedAccessException("Access Denied");
        }
		
		#endregion
		
		#region Secure service instance methods
		
		public ModelUser GetCurrentUser(string SessionToken)
		{
			return CustomerSecureService.GetCurrentUserImp(SessionToken);
        }
        
        public ModelUser GetUser(string userName, string SessionToken)
		{
			return CustomerSecureService.GetUserImp(userName, SessionToken);
        }
        
        public void SetUserByObject(ModelUser userObject, string SessionToken)
        {
			CustomerSecureService.SetUserByObjectImp(userObject, SessionToken);
        }
		
		public bool IsSecurable
        {
            get
			{
				return CustomerSecureService.IsSecurableImp;
			}
        }
        
        public void EnableDisableSecurity(bool secure, string sessionToken)
        {
			CustomerSecureService.EnableDisableSecurityImp(secure, sessionToken);
        }
        
        public string[] GetUserRightDescriptors()
        {
			return CustomerSecureService.GetUserRightDescriptorsImp();
        }
        
        public void ChangeRights(string userName, string userRightDescriptor, bool allow, string SessionToken)
        {
			CustomerSecureService.ChangeRightsImp(userName, userRightDescriptor, allow, SessionToken);
        }
        
        public bool HasRights(string userName, string userRightDescriptor, string SessionToken)
        {
			return CustomerSecureService.HasRightsImp(userName, userRightDescriptor, SessionToken);
        }
        
		public bool HasAccess(Services.Packages.Customer _object, string userName, string securityDescriptor, string SessionToken)
		{
			return CustomerSecureService.HasAccessImp(_object, userName, securityDescriptor, SessionToken);
		}
		
		public void ChangeAccess(Services.Packages.Customer _object, string userName, string securityDescriptor, bool allow, string SessionToken)
        {
			CustomerSecureService.ChangeAccessImp(_object, userName, securityDescriptor, allow, SessionToken);
        }

        public void SetObjectOwner(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.SetOwnerImp(_object, userName, SessionToken);
        }
		
		public bool IsFirstTimeUsed
		{
			get
			{
				return CustomerSecureService.IsFirstTimeUsedImp;
			}
		}

        public void SetDatabaseOwner(string userName)
        {
			CustomerSecureService.SetDatabaseOwnerImp(userName);
        }
		
        public string[] GetSecurityDescriptors()
        {
			return CustomerSecureService.GetSecurityDescriptorsImp();
        }
        
        public void AllowTraverse(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.AllowTraverseImp(_object, userName, SessionToken);
        }

        public void AllowRead(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.AllowReadImp(_object, userName, SessionToken);
        }

        public void AllowUpdate(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.AllowUpdateImp(_object, userName, SessionToken);
        }

        public void AllowCreate(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.AllowCreateImp(_object, userName, SessionToken);
        }

        public void AllowReadAccess(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.AllowReadAccessImp(_object, userName, SessionToken);
        }

        public void AllowChangeAccess(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.AllowChangeAccessImp(_object, userName, SessionToken);
        }
		
        public bool HasTraverse(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			return CustomerSecureService.HasTraverseImp(_object, userName, SessionToken);
        }

        public bool HasRead(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			return CustomerSecureService.HasReadImp(_object, userName, SessionToken);
        }

        public bool HasUpdate(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			return CustomerSecureService.HasUpdateImp(_object, userName, SessionToken);
        }

        public bool HasCreate(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			return CustomerSecureService.HasCreateImp(_object, userName, SessionToken);
        }

        public bool HasReadAccess(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			return CustomerSecureService.HasReadAccessImp(_object, userName, SessionToken);
        }

        public bool HasChangeAccess(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			return CustomerSecureService.HasChangeAccessImp(_object, userName, SessionToken);
        }
        
        public void DisallowTraverse(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.DisallowTraverseImp(_object, userName, SessionToken);
        }

        public void DisallowRead(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.DisallowReadImp(_object, userName, SessionToken);
        }

        public void DisallowUpdate(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.DisallowUpdateImp(_object, userName, SessionToken);
        }

        public void DisallowCreate(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.DisallowCreateImp(_object, userName, SessionToken);
        }

        public void DisallowReadAccess(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.DisallowReadAccessImp(_object, userName, SessionToken);
        }

        public void DisallowChangeAccess(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.DisallowChangeAccessImp(_object, userName, SessionToken);
        }
        
        public void AllowAllTraverse(string userName, string SessionToken)
        {
			CustomerSecureService.AllowAllTraverseImp(userName, SessionToken);
        }
        
        public void AllowAllRead(string userName, string SessionToken)
        {
			CustomerSecureService.AllowAllReadImp(userName, SessionToken);
        }
        
        public void AllowAllUpdate(string userName, string SessionToken)
        {
			CustomerSecureService.AllowAllUpdateImp(userName, SessionToken);
        }
        
        public void AllowAllCreate(string userName, string SessionToken)
        {
			CustomerSecureService.AllowAllCreateImp(userName, SessionToken);
        }
        
        public void AllowAllReadAccess(string userName, string SessionToken)
        {
			CustomerSecureService.AllowAllReadAccessImp(userName, SessionToken);
        }
        
        public void AllowAllChangeAccess(string userName, string SessionToken)
        {
			CustomerSecureService.AllowAllChangeAccessImp(userName, SessionToken);
        }
        
        public bool HasAllTraverse(string userName, string SessionToken)
        {
			return CustomerSecureService.HasAllTraverseImp(userName, SessionToken);
        }
        
        public bool HasAllRead(string userName, string SessionToken)
        {
			return CustomerSecureService.HasAllReadImp(userName, SessionToken);
        }
        
        public bool HasAllUpdate(string userName, string SessionToken)
        {
			return CustomerSecureService.HasAllUpdateImp(userName, SessionToken);
        }
        
        public bool HasAllCreate(string userName, string SessionToken)
        {
			return CustomerSecureService.HasAllCreateImp(userName, SessionToken);
        }
        
        public bool HasAllReadAccess(string userName, string SessionToken)
        {
			return CustomerSecureService.HasAllReadAccessImp(userName, SessionToken);
        }
        
        public bool HasAllChangeAccess(string userName, string SessionToken)
        {
			return CustomerSecureService.HasAllChangeAccessImp(userName, SessionToken);
        }
        
        public void DisallowAllTraverse(string userName, string SessionToken)
        {
			CustomerSecureService.DisallowAllTraverseImp(userName, SessionToken);
        }
        
        public void DisallowAllRead(string userName, string SessionToken)
        {
			CustomerSecureService.DisallowAllReadImp(userName, SessionToken);
        }
        
        public void DisallowAllUpdate(string userName, string SessionToken)
        {
			CustomerSecureService.DisallowAllUpdateImp(userName, SessionToken);
        }
        
        public void DisallowAllCreate(string userName, string SessionToken)
        {
			CustomerSecureService.DisallowAllCreateImp(userName, SessionToken);
        }
        
        public void DisallowAllReadAccess(string userName, string SessionToken)
        {
			CustomerSecureService.DisallowAllReadAccessImp(userName, SessionToken);
        }
        
        public void DisallowAllChangeAccess(string userName, string SessionToken)
        {
			CustomerSecureService.DisallowAllChangeAccessImp(userName, SessionToken);
        }
        
        public string LoginAnonymous()
        {
			return CustomerSecureService.LoginAnonymousImp();
        }
        
        public string Login(string userName, string password)
        {
			return CustomerSecureService.LoginImp(userName, password);
        }
        
        public void SwitchUser(string userName, string password, string existingSessionToken)
        {
			CustomerSecureService.SwitchUserImp(userName, password, existingSessionToken);
        }

        public bool SessionExists(string sessionToken)
        {
			return CustomerSecureService.SessionExistsImp(sessionToken);
        }

        public void LogoutSession(string sessionToken, bool keepSession)
        {
			CustomerSecureService.LogoutSessionImp(sessionToken, keepSession);
        }
        
        public void LogoutAllSessions(string userName, string SessionToken)
        {
			CustomerSecureService.LogoutAllSessionsImp(userName, SessionToken);
        }

        public void AddUser(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			CustomerSecureService.AddUserImp(userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken);
        }

        public void UpdateUser(string userName, string oldPassword, string email, string secretQuestion,
            string secretAnswer, string SessionToken)
        {
			CustomerSecureService.UpdateUserImp(userName, oldPassword, email, secretQuestion,
				secretAnswer, SessionToken);
        }
        
        public void UpdateUserWithEnable(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			CustomerSecureService.UpdateUserImp(userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken);
        }
        
        public void DeleteUser(string userName, string SessionToken)
        {
			CustomerSecureService.DeleteUserImp(userName, SessionToken);
        }
        
        public void ChangePassword(string userName, string oldPassword, string newPassword, string SessionToken)
        {
			CustomerSecureService.ChangePasswordImp(userName, oldPassword, newPassword, SessionToken);
        }
        
        public string CreateRandomPassword(string userName, string answer, string SessionToken)
        {
			return CustomerSecureService.CreateRandomPasswordImp(userName, answer, SessionToken);
        }

        public Securable GetSecurable(string SessionToken)
        {
			return CustomerSecureService.GetSecurableImp(SessionToken);
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
        public bool Exists(Customer _Customer, string SessionToken)
        {
			if (!CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _Customer.Exists;
        }
		
		[WebMethod]
		public Customer Read(System.String __Name, string SessionToken)
		{
			Customer _Customer = new Customer(__Name);
			
			if (!CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _Customer;
		}
		
		[WebMethod]
        public Customer Reload(Customer _Customer, string SessionToken)
        {
			_Customer.Reload();
			
			if (!CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _Customer;
        }
		
		[WebMethod]
        public Customer Create(System.String __Name, string SessionToken)
        {
			ModelSession session = CustomerSecureService.CheckSessionImp(SessionToken);

            if (!CustomerSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(Customer).FullName))
				throw new UnauthorizedAccessException("Access Denied");
            
            Customer _Customer = Customer.CreateCustomer(__Name);
            _Customer.Owner = session.User;
            _Customer.Update();
			return _Customer;
        }
        
        [WebMethod]
        public void Delete(System.String __Name, string SessionToken)
        {
			Customer _Customer = new Customer(__Name);
			
			if (!CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Delete"))
				throw new UnauthorizedAccessException("Access Denied");
			
			Customer.DeleteCustomer(__Name);
        }
        
        [WebMethod]
        public void UpdateObject(Customer _Customer, string SessionToken)
        {
			if (!CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_Customer.Update();
        }
		
		[WebMethod]
        public void CreateObject(Customer _Customer, string SessionToken)
        {
			ModelSession session = CustomerSecureService.CheckSessionImp(SessionToken);

            if (!CustomerSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(Customer).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			_Customer.Owner = session.User;
            _Customer.Create();
        }
        
        [WebMethod]
        public void DeleteObject(Customer _Customer, string SessionToken)
        {
			if (!CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Delete"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_Customer.Delete();
        }

		[WebMethod]
        public void Undo(string SessionToken)
        {
			ModelSession session = CustomerSecureService.CheckSessionImp(SessionToken);

			// Must have all available access to the class level (all objects)
			if (!CustomerSecureService.CheckUserRightsImp(session.User.Name, "Update " + typeof(Customer).FullName) ||
				!CustomerSecureService.CheckUserRightsImp(session.User.Name, "Delete " + typeof(Customer).FullName) ||
				!CustomerSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(Customer).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			Customer.Undo();
        }

		[WebMethod]
        public void Redo(string SessionToken)
        {
			ModelSession session = CustomerSecureService.CheckSessionImp(SessionToken);

			// Must have all available access to the class level (all objects)
			if (!CustomerSecureService.CheckUserRightsImp(session.User.Name, "Update " + typeof(Customer).FullName) ||
				!CustomerSecureService.CheckUserRightsImp(session.User.Name, "Delete " + typeof(Customer).FullName) ||
				!CustomerSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(Customer).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			Customer.Redo();
        }

        		
		[WebMethod]
        public Customer CreateFromPartner(System.String __Name, Services.Packages.Customer _Partner, string SessionToken)
        {
			ModelSession session = CustomerSecureService.CheckSessionImp(SessionToken);

			Customer _Customer = new Customer(__Name);
            
            if (!_Customer.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Partner, SessionToken, "Create PartnerCustomers"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_Customer.Exists && !CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // Customer _Customer = Customer.CreateCustomer(__Name);
            _Customer.Owner = session.User;
            _Customer.Partner = _Partner;
            _Customer.Update();
			return _Customer;
        }
        
        [WebMethod]
        public void CreateObjectFromPartner(Customer _Customer, Services.Packages.Customer _Partner, string SessionToken)
        {
			ModelSession session = CustomerSecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Partner, SessionToken, "Create PartnerCustomers"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_Customer.Reload();
			
			if (!_Customer.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Partner, SessionToken, "Create PartnerCustomers"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_Customer.Exists && !CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_Customer.Owner = session.User;
            _Customer.Partner = _Partner;
            _Customer.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromPartner(Services.Packages.Customer _Partner, string userName, string SessionToken)
        {
            Services.Packages.Security.CustomerSecureService.ChangeAccessImp(_Partner, userName, "Create PartnerCustomers", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromPartner(Services.Packages.Customer _Partner, string userName, string SessionToken)
        {
            return Services.Packages.Security.CustomerSecureService.HasAccessImp(_Partner, userName, "Create PartnerCustomers", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromPartner(Services.Packages.Customer _Partner, string userName, string SessionToken)
        {
            Services.Packages.Security.CustomerSecureService.ChangeAccessImp(_Partner, userName, "Create PartnerCustomers", false, SessionToken);
        }
		
		[WebMethod]
        public Customer CreateFromOwner(System.String __Name, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			ModelSession session = CustomerSecureService.CheckSessionImp(SessionToken);

			Customer _Customer = new Customer(__Name);
            
            if (!_Customer.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create CustomerOwning"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_Customer.Exists && !CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // Customer _Customer = Customer.CreateCustomer(__Name);
            _Customer.Owner = session.User;
            _Customer.Owner = _Owner;
            _Customer.Update();
			return _Customer;
        }
        
        [WebMethod]
        public void CreateObjectFromOwner(Customer _Customer, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			ModelSession session = CustomerSecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create CustomerOwning"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_Customer.Reload();
			
			if (!_Customer.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create CustomerOwning"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_Customer.Exists && !CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_Customer.Owner = session.User;
            _Customer.Owner = _Owner;
            _Customer.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_Owner, userName, "Create CustomerOwning", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            return Services.Packages.Security.Security.ModelUserSecureService.HasAccessImp(_Owner, userName, "Create CustomerOwning", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_Owner, userName, "Create CustomerOwning", false, SessionToken);
        }

		[WebMethod]
		public CustomerCollection GetByPartner(Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.GetByPartner( _Customer);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public CustomerCollection GetByPartnerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.GetByPartnerPaged( _Customer, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long GetByPartnerCount(Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return Customer.GetByPartnerCount( _Customer);
		}
		[WebMethod]
		public Services.Packages.Customer GetPartner(Customer _Customer, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer.Partner, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _Customer.Partner;
		}
		[WebMethod]
		public void SetPartner(Customer _Customer, Services.Packages.Customer _Partner, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_Partner.Reload();
			if (_Partner.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Partner, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Partner.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create PartnerCustomers"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_Customer.Partner = _Partner;
			_Customer.Update();
		}
		[WebMethod]
		public CustomerCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.GetByOwner( _ModelUser);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public CustomerCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
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
			
			return Customer.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(Customer _Customer, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Customer.Owner, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _Customer.Owner;
		}
		[WebMethod]
		public void SetOwner(Customer _Customer, Services.Packages.Security.ModelUser _Owner, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_Owner.Reload();
			if (_Owner.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Owner.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create CustomerOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_Customer.Owner = _Owner;
			_Customer.Update();
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPartner(System.String Name, System.Boolean IsPartner , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.SearchByNameAndPartner(Name, IsPartner );
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPartnerPaged(System.String Name, System.Boolean IsPartner , long PagingStart, long PagingCount, string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.SearchByNameAndPartnerPaged(Name, IsPartner , PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByNameAndPartnerCount(System.String Name, System.Boolean IsPartner , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return Customer.SearchByNameAndPartnerCount(Name, IsPartner );
		}
		[WebMethod]
		public CustomerCollection SearchByName(System.String Name , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.SearchByName(Name );
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public CustomerCollection SearchByNamePaged(System.String Name , long PagingStart, long PagingCount, string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.SearchByNamePaged(Name , PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
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
			
			return Customer.SearchByNameCount(Name );
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPartnerPayment(System.String Name, System.Boolean IsPaymentAccepted , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.SearchByNameAndPartnerPayment(Name, IsPaymentAccepted );
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPartnerPaymentPaged(System.String Name, System.Boolean IsPaymentAccepted , long PagingStart, long PagingCount, string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.SearchByNameAndPartnerPaymentPaged(Name, IsPaymentAccepted , PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByNameAndPartnerPaymentCount(System.String Name, System.Boolean IsPaymentAccepted , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return Customer.SearchByNameAndPartnerPaymentCount(Name, IsPaymentAccepted );
		}
		[WebMethod]
		public CustomerCollection SearchByNameOnPartners(System.String Name, Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.SearchByNameOnPartners(Name,  _Customer);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public CustomerCollection SearchByNameOnPartnersPaged(System.String Name, Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.SearchByNameOnPartnersPaged(Name,  _Customer, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByNameOnPartnersCount(System.String Name, Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return Customer.SearchByNameOnPartnersCount(Name,  _Customer);
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPaymentOnPartners(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.SearchByNameAndPaymentOnPartners(Name, IsPaymentAccepted,  _Customer);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPaymentOnPartnersPaged(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.SearchByNameAndPaymentOnPartnersPaged(Name, IsPaymentAccepted,  _Customer, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByNameAndPaymentOnPartnersCount(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return Customer.SearchByNameAndPaymentOnPartnersCount(Name, IsPaymentAccepted,  _Customer);
		}
		[WebMethod]
		public Services.Packages.ApiKeyCollection GetLicensesIssued(Customer _Customer, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_Customer.LicensesIssued, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _Customer.LicensesIssued;
		}
		[WebMethod]
		public void SetLicensesIssued(Customer _Customer, Services.Packages.ApiKeyCollection _LicensesIssued, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_LicensesIssued.Reload();
			if (_LicensesIssued.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_LicensesIssued, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_LicensesIssued.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create LicensesIssued"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_Customer.LicensesIssued = _LicensesIssued;
			_Customer.Update();
		}
		[WebMethod]
		public Services.Packages.CustomerCollection GetPartnerCustomers(Customer _Customer, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer.PartnerCustomers, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _Customer.PartnerCustomers;
		}
		[WebMethod]
		public void SetPartnerCustomers(Customer _Customer, Services.Packages.CustomerCollection _PartnerCustomers, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_PartnerCustomers.Reload();
			if (_PartnerCustomers.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_PartnerCustomers, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_PartnerCustomers.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create PartnerCustomers"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_Customer.PartnerCustomers = _PartnerCustomers;
			_Customer.Update();
		}
		[WebMethod]
		public Services.Packages.CustomerUserEntryCollection GetCustomerUserEntries(Customer _Customer, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_Customer.CustomerUserEntries, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _Customer.CustomerUserEntries;
		}
		[WebMethod]
		public void SetCustomerUserEntries(Customer _Customer, Services.Packages.CustomerUserEntryCollection _CustomerUserEntries, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_CustomerUserEntries.Reload();
			if (_CustomerUserEntries.Exists && !Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntries, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_CustomerUserEntries.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create CustomerUserEntries"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_Customer.CustomerUserEntries = _CustomerUserEntries;
			_Customer.Update();
		}
		[WebMethod]
		public Services.Packages.Security.CustomerAccessControlListCollection GetACLs(Customer _Customer, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.CustomerAccessControlListSecureService.CheckAccessImp(_Customer.ACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _Customer.ACLs;
		}
		[WebMethod]
		public void SetACLs(Customer _Customer, Services.Packages.Security.CustomerAccessControlListCollection _ACLs, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ACLs.Reload();
			if (_ACLs.Exists && !Services.Packages.Security.Security.CustomerAccessControlListSecureService.CheckAccessImp(_ACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ACLs.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create ACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_Customer.ACLs = _ACLs;
			_Customer.Update();
		}

    }
    
namespace Web
{
	/// <summary>
	/// The WebService secure service provider that allows to create web services
	/// that share Services.Packages.Customer objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Security.Web.CustomerSecureWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class CustomerSecureWebService : WebService, ICustomerSecureService
	{
		#region Secure service instance methods
        
        [WebMethod]
        public void EnableDisableSecurity(bool secure, string sessionToken)
        {
			CustomerSecureService.EnableDisableSecurityImp(secure, sessionToken);
        }
        
        [WebMethod]
        public string[] GetUserRightDescriptors()
        {
			return CustomerSecureService.GetUserRightDescriptorsImp();
        }
        
        [WebMethod]
        public void ChangeRights(string userName, string userRightDescriptor, bool allow, string SessionToken)
        {
			CustomerSecureService.ChangeRightsImp(userName, userRightDescriptor, allow, SessionToken);
        }
        
        [WebMethod]
        public bool HasRights(string userName, string userRightDescriptor, string SessionToken)
        {
			return CustomerSecureService.HasRightsImp(userName, userRightDescriptor, SessionToken);
        }
        
		[WebMethod]
        public bool HasAccess(Services.Packages.Customer _object, string userName, string securityDescriptor, string SessionToken)
		{
			return CustomerSecureService.HasAccessImp(_object, userName, securityDescriptor, SessionToken);
		}
		
		[WebMethod]
        public void ChangeAccess(Services.Packages.Customer _object, string userName, string securityDescriptor, bool allow, string SessionToken)
        {
			CustomerSecureService.ChangeAccessImp(_object, userName, securityDescriptor, allow, SessionToken);
        }

        [WebMethod]
        public void SetObjectOwner(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.SetOwnerImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void SetDatabaseOwner(string userName)
        {
			CustomerSecureService.SetDatabaseOwnerImp(userName);
        }
		
        [WebMethod]
        public string[] GetSecurityDescriptors()
        {
			return CustomerSecureService.GetSecurityDescriptorsImp();
        }
        
        [WebMethod]
        public void AllowTraverse(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.AllowTraverseImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowRead(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.AllowReadImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowUpdate(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.AllowUpdateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowCreate(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.AllowCreateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowReadAccess(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.AllowReadAccessImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void AllowChangeAccess(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.AllowChangeAccessImp(_object, userName, SessionToken);
        }
		
        [WebMethod]
        public bool HasTraverse(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			return CustomerSecureService.HasTraverseImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasRead(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			return CustomerSecureService.HasReadImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasUpdate(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			return CustomerSecureService.HasUpdateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasCreate(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			return CustomerSecureService.HasCreateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasReadAccess(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			return CustomerSecureService.HasReadAccessImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public bool HasChangeAccess(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			return CustomerSecureService.HasChangeAccessImp(_object, userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowTraverse(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.DisallowTraverseImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowRead(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.DisallowReadImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowUpdate(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.DisallowUpdateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowCreate(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.DisallowCreateImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowReadAccess(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.DisallowReadAccessImp(_object, userName, SessionToken);
        }

        [WebMethod]
        public void DisallowChangeAccess(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			CustomerSecureService.DisallowChangeAccessImp(_object, userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllTraverse(string userName, string SessionToken)
        {
			CustomerSecureService.AllowAllTraverseImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllRead(string userName, string SessionToken)
        {
			CustomerSecureService.AllowAllReadImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllUpdate(string userName, string SessionToken)
        {
			CustomerSecureService.AllowAllUpdateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllCreate(string userName, string SessionToken)
        {
			CustomerSecureService.AllowAllCreateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllReadAccess(string userName, string SessionToken)
        {
			CustomerSecureService.AllowAllReadAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void AllowAllChangeAccess(string userName, string SessionToken)
        {
			CustomerSecureService.AllowAllChangeAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllTraverse(string userName, string SessionToken)
        {
			return CustomerSecureService.HasAllTraverseImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllRead(string userName, string SessionToken)
        {
			return CustomerSecureService.HasAllReadImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllUpdate(string userName, string SessionToken)
        {
			return CustomerSecureService.HasAllUpdateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllCreate(string userName, string SessionToken)
        {
			return CustomerSecureService.HasAllCreateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllReadAccess(string userName, string SessionToken)
        {
			return CustomerSecureService.HasAllReadAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public bool HasAllChangeAccess(string userName, string SessionToken)
        {
			return CustomerSecureService.HasAllChangeAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllTraverse(string userName, string SessionToken)
        {
			CustomerSecureService.DisallowAllTraverseImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllRead(string userName, string SessionToken)
        {
			CustomerSecureService.DisallowAllReadImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllUpdate(string userName, string SessionToken)
        {
			CustomerSecureService.DisallowAllUpdateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllCreate(string userName, string SessionToken)
        {
			CustomerSecureService.DisallowAllCreateImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllReadAccess(string userName, string SessionToken)
        {
			CustomerSecureService.DisallowAllReadAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void DisallowAllChangeAccess(string userName, string SessionToken)
        {
			CustomerSecureService.DisallowAllChangeAccessImp(userName, SessionToken);
        }
        
        [WebMethod]
        public string LoginAnonymous()
        {
			return CustomerSecureService.LoginAnonymousImp();
        }
        
        [WebMethod]
        public string Login(string userName, string password)
        {
			return CustomerSecureService.LoginImp(userName, password);
        }
        
        [WebMethod]
        public void SwitchUser(string userName, string password, string existingSessionToken)
        {
			CustomerSecureService.SwitchUserImp(userName, password, existingSessionToken);
        }

        [WebMethod]
        public bool SessionExists(string sessionToken)
        {
			return CustomerSecureService.SessionExistsImp(sessionToken);
        }

        [WebMethod]
        public void LogoutSession(string sessionToken, bool keepSession)
        {
			CustomerSecureService.LogoutSessionImp(sessionToken, keepSession);
        }
        
        [WebMethod]
        public void LogoutAllSessions(string userName, string SessionToken)
        {
			CustomerSecureService.LogoutAllSessionsImp(userName, SessionToken);
        }
		
		[WebMethod]
        public ModelUser GetCurrentUser(string SessionToken)
		{
			return CustomerSecureService.GetCurrentUserImp(SessionToken);
        }

		[WebMethod]
        public ModelUser GetUser(string userName, string SessionToken)
		{
			return CustomerSecureService.GetUserImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void SetUserByObject(ModelUser userObject, string SessionToken)
		{
			CustomerSecureService.SetUserByObjectImp(userObject, SessionToken);
        }
        
        [WebMethod]
        public void AddUser(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			CustomerSecureService.AddUserImp(userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken);
        }

        [WebMethod]
        public void UpdateUser(string userName, string oldPassword, string email, string secretQuestion,
            string secretAnswer, string SessionToken)
        {
			CustomerSecureService.UpdateUserImp(userName, oldPassword, email, secretQuestion,
				secretAnswer, SessionToken);
        }
        
        [WebMethod]
        public void UpdateUserWithEnable(string userName, string password, string email, string secretQuestion,
            string secretAnswer, bool enabled, string SessionToken)
        {
			CustomerSecureService.UpdateUserImp(userName, password, email, secretQuestion,
				secretAnswer, enabled, SessionToken);
        }
        
        [WebMethod]
        public void DeleteUser(string userName, string SessionToken)
        {
			CustomerSecureService.DeleteUserImp(userName, SessionToken);
        }
        
        [WebMethod]
        public void ChangePassword(string userName, string oldPassword, string newPassword, string SessionToken)
        {
			CustomerSecureService.ChangePasswordImp(userName, oldPassword, newPassword, SessionToken);
        }
        
        [WebMethod]
        public string CreateRandomPassword(string userName, string answer, string SessionToken)
        {
			return CustomerSecureService.CreateRandomPasswordImp(userName, answer, SessionToken);
        }

        [WebMethod]
        public Securable GetSecurable(string SessionToken)
        {
			return CustomerSecureService.GetSecurableImp(SessionToken);
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
        public bool Exists(Customer _Customer, string SessionToken)
        {
			if (!CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _Customer.Exists;
        }
		
		[WebMethod]
		public Customer Read(System.String __Name, string SessionToken)
		{
			Customer _Customer = new Customer(__Name);
			
			if (!CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _Customer;
		}
		
		[WebMethod]
        public Customer Reload(Customer _Customer, string SessionToken)
        {
			_Customer.Reload();
			
			if (!CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			
			return _Customer;
        }
		
		[WebMethod]
        public Customer Create(System.String __Name, string SessionToken)
        {
			ModelSession session = CustomerSecureService.CheckSessionImp(SessionToken);

            if (!CustomerSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(Customer).FullName))
				throw new UnauthorizedAccessException("Access Denied");
            
            Customer _Customer = Customer.CreateCustomer(__Name);
            _Customer.Owner = session.User;
            _Customer.Update();
			return _Customer;
        }
        
        [WebMethod]
        public void Delete(System.String __Name, string SessionToken)
        {
			Customer _Customer = new Customer(__Name);
			
			if (!CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Delete"))
				throw new UnauthorizedAccessException("Access Denied");
			
			Customer.DeleteCustomer(__Name);
        }
        
        [WebMethod]
        public void UpdateObject(Customer _Customer, string SessionToken)
        {
			if (!CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_Customer.Update();
        }
		
		[WebMethod]
        public void CreateObject(Customer _Customer, string SessionToken)
        {
			ModelSession session = CustomerSecureService.CheckSessionImp(SessionToken);

            if (!CustomerSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(Customer).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			_Customer.Owner = session.User;
            _Customer.Create();
        }
        
        [WebMethod]
        public void DeleteObject(Customer _Customer, string SessionToken)
        {
			if (!CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Delete"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_Customer.Delete();
        }

		[WebMethod]
        public void Undo(string SessionToken)
        {
			ModelSession session = CustomerSecureService.CheckSessionImp(SessionToken);

			// Must have all available access to the class level (all objects)
			if (!CustomerSecureService.CheckUserRightsImp(session.User.Name, "Update " + typeof(Customer).FullName) ||
				!CustomerSecureService.CheckUserRightsImp(session.User.Name, "Delete " + typeof(Customer).FullName) ||
				!CustomerSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(Customer).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			Customer.Undo();
        }

		[WebMethod]
        public void Redo(string SessionToken)
        {
			ModelSession session = CustomerSecureService.CheckSessionImp(SessionToken);

			// Must have all available access to the class level (all objects)
			if (!CustomerSecureService.CheckUserRightsImp(session.User.Name, "Update " + typeof(Customer).FullName) ||
				!CustomerSecureService.CheckUserRightsImp(session.User.Name, "Delete " + typeof(Customer).FullName) ||
				!CustomerSecureService.CheckUserRightsImp(session.User.Name, "Create " + typeof(Customer).FullName))
				throw new UnauthorizedAccessException("Access Denied");
			
			Customer.Redo();
        }

        		
		[WebMethod]
        public Customer CreateFromPartner(System.String __Name, Services.Packages.Customer _Partner, string SessionToken)
        {
			ModelSession session = CustomerSecureService.CheckSessionImp(SessionToken);

			Customer _Customer = new Customer(__Name);
            
            if (!_Customer.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Partner, SessionToken, "Create PartnerCustomers"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_Customer.Exists && !CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // Customer _Customer = Customer.CreateCustomer(__Name);
            _Customer.Owner = session.User;
            _Customer.Partner = _Partner;
            _Customer.Update();
			return _Customer;
        }
        
        [WebMethod]
        public void CreateObjectFromPartner(Customer _Customer, Services.Packages.Customer _Partner, string SessionToken)
        {
			ModelSession session = CustomerSecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Partner, SessionToken, "Create PartnerCustomers"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_Customer.Reload();
			
			if (!_Customer.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Partner, SessionToken, "Create PartnerCustomers"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_Customer.Exists && !CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_Customer.Owner = session.User;
            _Customer.Partner = _Partner;
            _Customer.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromPartner(Services.Packages.Customer _Partner, string userName, string SessionToken)
        {
            Services.Packages.Security.CustomerSecureService.ChangeAccessImp(_Partner, userName, "Create PartnerCustomers", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromPartner(Services.Packages.Customer _Partner, string userName, string SessionToken)
        {
            return Services.Packages.Security.CustomerSecureService.HasAccessImp(_Partner, userName, "Create PartnerCustomers", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromPartner(Services.Packages.Customer _Partner, string userName, string SessionToken)
        {
            Services.Packages.Security.CustomerSecureService.ChangeAccessImp(_Partner, userName, "Create PartnerCustomers", false, SessionToken);
        }
		
		[WebMethod]
        public Customer CreateFromOwner(System.String __Name, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			ModelSession session = CustomerSecureService.CheckSessionImp(SessionToken);

			Customer _Customer = new Customer(__Name);
            
            if (!_Customer.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create CustomerOwning"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_Customer.Exists && !CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
            
            // Customer _Customer = Customer.CreateCustomer(__Name);
            _Customer.Owner = session.User;
            _Customer.Owner = _Owner;
            _Customer.Update();
			return _Customer;
        }
        
        [WebMethod]
        public void CreateObjectFromOwner(Customer _Customer, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			ModelSession session = CustomerSecureService.CheckSessionImp(SessionToken);

            //if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create CustomerOwning"))
			//	throw new UnauthorizedAccessException("Access Denied");
			
			_Customer.Reload();
			
			if (!_Customer.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Create CustomerOwning"))
				throw new UnauthorizedAccessException("Access Denied");
            else if (_Customer.Exists && !CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			
			_Customer.Owner = session.User;
            _Customer.Owner = _Owner;
            _Customer.Create();
        }
        
        [WebMethod]
        public void AllowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_Owner, userName, "Create CustomerOwning", true, SessionToken);
        }
        
		[WebMethod]
        public bool HasCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            return Services.Packages.Security.Security.ModelUserSecureService.HasAccessImp(_Owner, userName, "Create CustomerOwning", SessionToken);
        }
        
        [WebMethod]
        public void DisallowCreateFromOwner(Services.Packages.Security.ModelUser _Owner, string userName, string SessionToken)
        {
            Services.Packages.Security.Security.ModelUserSecureService.ChangeAccessImp(_Owner, userName, "Create CustomerOwning", false, SessionToken);
        }

		[WebMethod]
		public CustomerCollection GetByPartner(Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.GetByPartner( _Customer);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public CustomerCollection GetByPartnerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.GetByPartnerPaged( _Customer, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long GetByPartnerCount(Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return Customer.GetByPartnerCount( _Customer);
		}
		[WebMethod]
		public Services.Packages.Customer GetPartner(Customer _Customer, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer.Partner, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _Customer.Partner;
		}
		[WebMethod]
		public void SetPartner(Customer _Customer, Services.Packages.Customer _Partner, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_Partner.Reload();
			if (_Partner.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Partner, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Partner.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create PartnerCustomers"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_Customer.Partner = _Partner;
			_Customer.Update();
		}
		[WebMethod]
		public CustomerCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.GetByOwner( _ModelUser);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public CustomerCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_ModelUser, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
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
			
			return Customer.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(Customer _Customer, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			if (!Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Customer.Owner, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _Customer.Owner;
		}
		[WebMethod]
		public void SetOwner(Customer _Customer, Services.Packages.Security.ModelUser _Owner, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			//*
			_Owner.Reload();
			if (_Owner.Exists && !Services.Packages.Security.Security.ModelUserSecureService.CheckAccessImp(_Owner, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_Owner.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create CustomerOwning"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_Customer.Owner = _Owner;
			_Customer.Update();
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPartner(System.String Name, System.Boolean IsPartner , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.SearchByNameAndPartner(Name, IsPartner );
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPartnerPaged(System.String Name, System.Boolean IsPartner , long PagingStart, long PagingCount, string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.SearchByNameAndPartnerPaged(Name, IsPartner , PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByNameAndPartnerCount(System.String Name, System.Boolean IsPartner , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return Customer.SearchByNameAndPartnerCount(Name, IsPartner );
		}
		[WebMethod]
		public CustomerCollection SearchByName(System.String Name , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.SearchByName(Name );
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public CustomerCollection SearchByNamePaged(System.String Name , long PagingStart, long PagingCount, string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.SearchByNamePaged(Name , PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
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
			
			return Customer.SearchByNameCount(Name );
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPartnerPayment(System.String Name, System.Boolean IsPaymentAccepted , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.SearchByNameAndPartnerPayment(Name, IsPaymentAccepted );
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPartnerPaymentPaged(System.String Name, System.Boolean IsPaymentAccepted , long PagingStart, long PagingCount, string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.SearchByNameAndPartnerPaymentPaged(Name, IsPaymentAccepted , PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByNameAndPartnerPaymentCount(System.String Name, System.Boolean IsPaymentAccepted , string SessionToken)
		{
			/*
			if (!%rns.Security.%rcnSecureService.CheckAccessImp(, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return Customer.SearchByNameAndPartnerPaymentCount(Name, IsPaymentAccepted );
		}
		[WebMethod]
		public CustomerCollection SearchByNameOnPartners(System.String Name, Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.SearchByNameOnPartners(Name,  _Customer);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public CustomerCollection SearchByNameOnPartnersPaged(System.String Name, Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.SearchByNameOnPartnersPaged(Name,  _Customer, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByNameOnPartnersCount(System.String Name, Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return Customer.SearchByNameOnPartnersCount(Name,  _Customer);
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPaymentOnPartners(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.SearchByNameAndPaymentOnPartners(Name, IsPaymentAccepted,  _Customer);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPaymentOnPartnersPaged(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			CustomerCollection c = Customer.SearchByNameAndPaymentOnPartnersPaged(Name, IsPaymentAccepted,  _Customer, PagingStart, PagingCount);
			for(int n = 0; n < c.Count; ++n)
			{
				if (!CustomerSecureService.CheckAccessImp(c[n], SessionToken, "Read"))
				{
					c.RemoveAt(n);
					--n;
				}
			}
			return c;
		}
		[WebMethod]
		public long SearchByNameAndPaymentOnPartnersCount(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer, string SessionToken)
		{
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return Customer.SearchByNameAndPaymentOnPartnersCount(Name, IsPaymentAccepted,  _Customer);
		}
		[WebMethod]
		public Services.Packages.ApiKeyCollection GetLicensesIssued(Customer _Customer, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_Customer.LicensesIssued, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _Customer.LicensesIssued;
		}
		[WebMethod]
		public void SetLicensesIssued(Customer _Customer, Services.Packages.ApiKeyCollection _LicensesIssued, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_LicensesIssued.Reload();
			if (_LicensesIssued.Exists && !Services.Packages.Security.ApiKeySecureService.CheckAccessImp(_LicensesIssued, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_LicensesIssued.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create LicensesIssued"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_Customer.LicensesIssued = _LicensesIssued;
			_Customer.Update();
		}
		[WebMethod]
		public Services.Packages.CustomerCollection GetPartnerCustomers(Customer _Customer, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer.PartnerCustomers, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _Customer.PartnerCustomers;
		}
		[WebMethod]
		public void SetPartnerCustomers(Customer _Customer, Services.Packages.CustomerCollection _PartnerCustomers, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_PartnerCustomers.Reload();
			if (_PartnerCustomers.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_PartnerCustomers, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_PartnerCustomers.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create PartnerCustomers"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_Customer.PartnerCustomers = _PartnerCustomers;
			_Customer.Update();
		}
		[WebMethod]
		public Services.Packages.CustomerUserEntryCollection GetCustomerUserEntries(Customer _Customer, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_Customer.CustomerUserEntries, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _Customer.CustomerUserEntries;
		}
		[WebMethod]
		public void SetCustomerUserEntries(Customer _Customer, Services.Packages.CustomerUserEntryCollection _CustomerUserEntries, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_CustomerUserEntries.Reload();
			if (_CustomerUserEntries.Exists && !Services.Packages.Security.CustomerUserEntrySecureService.CheckAccessImp(_CustomerUserEntries, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_CustomerUserEntries.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create CustomerUserEntries"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_Customer.CustomerUserEntries = _CustomerUserEntries;
			_Customer.Update();
		}
		[WebMethod]
		public Services.Packages.Security.CustomerAccessControlListCollection GetACLs(Customer _Customer, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			if (!Services.Packages.Security.Security.CustomerAccessControlListSecureService.CheckAccessImp(_Customer.ACLs, SessionToken, "Read"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			return _Customer.ACLs;
		}
		[WebMethod]
		public void SetACLs(Customer _Customer, Services.Packages.Security.CustomerAccessControlListCollection _ACLs, string SessionToken)
		{
			_Customer.Reload();
			
			//*
			if (!Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Traverse"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			/*
			_ACLs.Reload();
			if (_ACLs.Exists && !Services.Packages.Security.Security.CustomerAccessControlListSecureService.CheckAccessImp(_ACLs, SessionToken, "Update"))
				throw new UnauthorizedAccessException("Access Denied");
			else if (!_ACLs.Exists && !Services.Packages.Security.CustomerSecureService.CheckAccessImp(_Customer, SessionToken, "Create ACLs"))
				throw new UnauthorizedAccessException("Access Denied");
			//*/
			
			_Customer.ACLs = _ACLs;
			_Customer.Update();
		}

	}
	
	/// <summary>
	/// The WebService secure client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="CustomerWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("154cb68f-4d93-a070-c998-2be74a10b421")]
    sealed public class CustomerSecureWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, ICustomerSecureService
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
		public CustomerSecureWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public CustomerSecureWebServiceClient()
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
		public bool HasAccess(Services.Packages.Customer _object, string userName, string securityDescriptor, string SessionToken)
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
		public void ChangeAccess(Services.Packages.Customer _object, string userName, string securityDescriptor, bool allow, string SessionToken)
        {
			this.Invoke("ChangeAccess", new object[] {_object, userName, securityDescriptor, allow, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetObjectOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetObjectOwner(Services.Packages.Customer _object, string userName, string SessionToken)
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
		public void AllowTraverse(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			this.Invoke("AllowTraverse", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowRead", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowRead(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			this.Invoke("AllowRead", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowUpdate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowUpdate(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			this.Invoke("AllowUpdate", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowCreate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowCreate(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			this.Invoke("AllowCreate", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowReadAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowReadAccess(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			this.Invoke("AllowReadAccess", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowChangeAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowChangeAccess(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			this.Invoke("AllowChangeAccess", new object[] {_object, userName, SessionToken});
			return;
        }
		
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasTraverse", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasTraverse(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasTraverse", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasRead", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasRead(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasRead", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasUpdate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasUpdate(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasUpdate", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasCreate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasCreate(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasCreate", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasReadAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasReadAccess(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasReadAccess", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasChangeAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasChangeAccess(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			object[] results = this.Invoke("HasChangeAccess", new object[] {_object, userName, SessionToken});
			return ((bool)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowTraverse", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowTraverse(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowTraverse", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowRead", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowRead(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowRead", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowUpdate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowUpdate(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowUpdate", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowCreate", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowCreate(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowCreate", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowReadAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowReadAccess(Services.Packages.Customer _object, string userName, string SessionToken)
        {
			this.Invoke("DisallowReadAccess", new object[] {_object, userName, SessionToken});
			return;
        }

        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowChangeAccess", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowChangeAccess(Services.Packages.Customer _object, string userName, string SessionToken)
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
		public bool Exists(Customer _Customer, string SessionToken)
        {
			object[] results = this.Invoke("Exists", new object[] {_Customer,SessionToken});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Customer Read(System.String __Name, string SessionToken)
		{
			object[] results = this.Invoke("Read", new object[] {__Name, SessionToken});
			return ((Customer)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Customer Reload(Customer _Customer, string SessionToken)
        {
			object[] results = this.Invoke("Reload", new object[] {_Customer,SessionToken});
			return ((Customer)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Customer Create(System.String __Name, string SessionToken)
        {
			object[] results = this.Invoke("Create", new object[] {__Name, SessionToken});
			return ((Customer)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __Name, string SessionToken)
        {
			this.Invoke("Delete", new object[] {__Name, SessionToken});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(Customer _Customer, string SessionToken)
        {
			this.Invoke("UpdateObject", new object[] {_Customer,SessionToken});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(Customer _Customer, string SessionToken)
        {
			this.Invoke("CreateObject", new object[] {_Customer,SessionToken});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(Customer _Customer, string SessionToken)
        {
			this.Invoke("DeleteObject", new object[] {_Customer,SessionToken});
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
        		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateFromPartner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Customer CreateFromPartner(System.String __Name, Services.Packages.Customer _Partner, string SessionToken)
        {
			object[] results = this.Invoke("Create", new object[] {__Name, _Partner,SessionToken});
			return ((Customer)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObjectFromPartner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObjectFromPartner(Customer _Customer, Services.Packages.Customer _Partner, string SessionToken)
        {
			this.Invoke("CreateObjectFromPartner", new object[] {_Customer,_Partner,SessionToken});
			return;
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/AllowCreateObjectFromPartner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AllowCreateFromPartner(Services.Packages.Customer _Partner, string userName, string SessionToken)
        {
            this.Invoke("AllowCreateFromPartner", new object[] {_Partner, userName, SessionToken});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/HasCreateObjectFromPartner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool HasCreateFromPartner(Services.Packages.Customer _Partner, string userName, string SessionToken)
        {
            object[] results = this.Invoke("HasCreateFromPartner", new object[] {_Partner, userName, SessionToken});
			return ((bool)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DisallowCreateObjectFromPartner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void DisallowCreateFromPartner(Services.Packages.Customer _Partner, string userName, string SessionToken)
        {
            this.Invoke("DisallowObjectFromPartner", new object[] {_Partner, userName, SessionToken});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateFromOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Customer CreateFromOwner(System.String __Name, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			object[] results = this.Invoke("Create", new object[] {__Name, _Owner,SessionToken});
			return ((Customer)(results[0]));
        }
        
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObjectFromOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObjectFromOwner(Customer _Customer, Services.Packages.Security.ModelUser _Owner, string SessionToken)
        {
			this.Invoke("CreateObjectFromOwner", new object[] {_Customer,_Owner,SessionToken});
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

		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByPartner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection GetByPartner(Services.Packages.Customer _Customer, string SessionToken) {
			object[] results = this.Invoke("GetByPartner", new object[] {_Customer,SessionToken});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByPartnerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection GetByPartnerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("GetByPartnerPaged", new object[] {_Customer,PagingStart,PagingCount,SessionToken});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByPartnerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByPartnerCount(Services.Packages.Customer _Customer, string SessionToken) {
			object[] results = this.Invoke("GetByPartnerCount", new object[] {_Customer,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPartner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Customer GetPartner(Customer _Customer, string SessionToken)
		{
			object[] results = this.Invoke("GetPartner", new object[] {_Customer,SessionToken});
			return ((Services.Packages.Customer)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPartner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPartner(Customer _Customer, Services.Packages.Customer _Partner, string SessionToken)
		{
			this.Invoke("GetPartner", new object[] {_Customer,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser, string SessionToken) {
			object[] results = this.Invoke("GetByOwner", new object[] {_ModelUser,SessionToken});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("GetByOwnerPaged", new object[] {_ModelUser,PagingStart,PagingCount,SessionToken});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser, string SessionToken) {
			object[] results = this.Invoke("GetByOwnerCount", new object[] {_ModelUser,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetOwner(Customer _Customer, string SessionToken)
		{
			object[] results = this.Invoke("GetOwner", new object[] {_Customer,SessionToken});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetOwner(Customer _Customer, Services.Packages.Security.ModelUser _Owner, string SessionToken)
		{
			this.Invoke("GetOwner", new object[] {_Customer,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameAndPartner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection SearchByNameAndPartner(System.String Name, System.Boolean IsPartner , string SessionToken) {
			object[] results = this.Invoke("SearchByNameAndPartner", new object[] {Name, IsPartner,SessionToken});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameAndPartnerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection SearchByNameAndPartnerPaged(System.String Name, System.Boolean IsPartner , long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("SearchByNameAndPartnerPaged", new object[] {Name, IsPartner,PagingStart,PagingCount,SessionToken});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameAndPartnerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByNameAndPartnerCount(System.String Name, System.Boolean IsPartner , string SessionToken) {
			object[] results = this.Invoke("SearchByNameAndPartnerCount", new object[] {Name, IsPartner,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByName", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection SearchByName(System.String Name , string SessionToken) {
			object[] results = this.Invoke("SearchByName", new object[] {Name,SessionToken});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNamePaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection SearchByNamePaged(System.String Name , long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("SearchByNamePaged", new object[] {Name,PagingStart,PagingCount,SessionToken});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByNameCount(System.String Name , string SessionToken) {
			object[] results = this.Invoke("SearchByNameCount", new object[] {Name,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameAndPartnerPayment", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection SearchByNameAndPartnerPayment(System.String Name, System.Boolean IsPaymentAccepted , string SessionToken) {
			object[] results = this.Invoke("SearchByNameAndPartnerPayment", new object[] {Name, IsPaymentAccepted,SessionToken});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameAndPartnerPaymentPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection SearchByNameAndPartnerPaymentPaged(System.String Name, System.Boolean IsPaymentAccepted , long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("SearchByNameAndPartnerPaymentPaged", new object[] {Name, IsPaymentAccepted,PagingStart,PagingCount,SessionToken});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameAndPartnerPaymentCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByNameAndPartnerPaymentCount(System.String Name, System.Boolean IsPaymentAccepted , string SessionToken) {
			object[] results = this.Invoke("SearchByNameAndPartnerPaymentCount", new object[] {Name, IsPaymentAccepted,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameOnPartners", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection SearchByNameOnPartners(System.String Name, Services.Packages.Customer _Customer, string SessionToken) {
			object[] results = this.Invoke("SearchByNameOnPartners", new object[] {Name, _Customer,SessionToken});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameOnPartnersPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection SearchByNameOnPartnersPaged(System.String Name, Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("SearchByNameOnPartnersPaged", new object[] {Name, _Customer,PagingStart,PagingCount,SessionToken});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameOnPartnersCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByNameOnPartnersCount(System.String Name, Services.Packages.Customer _Customer, string SessionToken) {
			object[] results = this.Invoke("SearchByNameOnPartnersCount", new object[] {Name, _Customer,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameAndPaymentOnPartners", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection SearchByNameAndPaymentOnPartners(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer, string SessionToken) {
			object[] results = this.Invoke("SearchByNameAndPaymentOnPartners", new object[] {Name, IsPaymentAccepted, _Customer,SessionToken});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameAndPaymentOnPartnersPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection SearchByNameAndPaymentOnPartnersPaged(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer, long PagingStart, long PagingCount, string SessionToken) {
			object[] results = this.Invoke("SearchByNameAndPaymentOnPartnersPaged", new object[] {Name, IsPaymentAccepted, _Customer,PagingStart,PagingCount,SessionToken});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameAndPaymentOnPartnersCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByNameAndPaymentOnPartnersCount(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer, string SessionToken) {
			object[] results = this.Invoke("SearchByNameAndPaymentOnPartnersCount", new object[] {Name, IsPaymentAccepted, _Customer,SessionToken});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetLicensesIssued", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.ApiKeyCollection GetLicensesIssued(Customer _Customer, string SessionToken)
		{
			object[] results = this.Invoke("GetLicensesIssued", new object[] {_Customer,SessionToken});
			return ((Services.Packages.ApiKeyCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetLicensesIssued", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetLicensesIssued(Customer _Customer, Services.Packages.ApiKeyCollection _LicensesIssued, string SessionToken)
		{
			this.Invoke("GetLicensesIssued", new object[] {_Customer,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPartnerCustomers", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.CustomerCollection GetPartnerCustomers(Customer _Customer, string SessionToken)
		{
			object[] results = this.Invoke("GetPartnerCustomers", new object[] {_Customer,SessionToken});
			return ((Services.Packages.CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPartnerCustomers", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPartnerCustomers(Customer _Customer, Services.Packages.CustomerCollection _PartnerCustomers, string SessionToken)
		{
			this.Invoke("GetPartnerCustomers", new object[] {_Customer,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetCustomerUserEntries", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.CustomerUserEntryCollection GetCustomerUserEntries(Customer _Customer, string SessionToken)
		{
			object[] results = this.Invoke("GetCustomerUserEntries", new object[] {_Customer,SessionToken});
			return ((Services.Packages.CustomerUserEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetCustomerUserEntries", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetCustomerUserEntries(Customer _Customer, Services.Packages.CustomerUserEntryCollection _CustomerUserEntries, string SessionToken)
		{
			this.Invoke("GetCustomerUserEntries", new object[] {_Customer,SessionToken});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.CustomerAccessControlListCollection GetACLs(Customer _Customer, string SessionToken)
		{
			object[] results = this.Invoke("GetACLs", new object[] {_Customer,SessionToken});
			return ((Services.Packages.Security.CustomerAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACLs(Customer _Customer, Services.Packages.Security.CustomerAccessControlListCollection _ACLs, string SessionToken)
		{
			this.Invoke("GetACLs", new object[] {_Customer,SessionToken});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages
