using System;
using System.Collections.Generic;
using System.Text;
using Platform.Runtime;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Web.Services;
using System.Web.UI;

/*
 * High performance automated object model
 * Created by an automatic tool
 * */

namespace Services.Packages.Security
{
	/// <summary>
    /// Defines the contract for the ModelUser class
    /// </summary>
    [ComVisible(true)]
    [Guid("e8169f6e-850b-34a9-a248-db97fd9c8bbd")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IModelUser
	{
		bool Exists { get; }
		System.String Name { get; set; }
		System.String PasswordHash { get; set; }
		System.String Email { get; set; }
		System.Boolean Enabled { get; set; }
		System.String SecretQuestion { get; set; }
		System.String SecretAnswer { get; set; }
		Services.Packages.Security.ModelUser Owner { get; set; }
		Services.Packages.PackageCollection PackageOwning { get; set; }
		Services.Packages.ApiKeyCollection ApiKeyOwning { get; set; }
		Services.Packages.Log.ApplicationExceptionCollection ApplicationExceptionOwning { get; set; }
		Services.Packages.CustomerCollection CustomerOwning { get; set; }
		Services.Packages.CustomerUserEntryCollection CustomerUserEntries { get; set; }
		Services.Packages.CustomerUserEntryCollection CustomerUserEntryOwning { get; set; }
		Services.Packages.PurchaseCollection Purchases { get; set; }
		Services.Packages.PurchaseCollection PurchaseOwning { get; set; }
		Services.Packages.PurchaseLineCollection PurchaseLineOwning { get; set; }
		Services.Packages.Security.ModelUserCollection ModelUserOwning { get; set; }
		Services.Packages.Security.ModelSessionCollection Sessions { get; set; }
		Services.Packages.Security.ModelUserRightsCollection Rights { get; set; }
		Services.Packages.Security.ModelUserRightsCollection GetByNameAndUser(System.String Name);
		Services.Packages.Security.PackageAccessControlListCollection PackageACLs { get; set; }
		Services.Packages.Security.ApiKeyAccessControlListCollection ApiKeyACLs { get; set; }
		Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection ApplicationExceptionACLs { get; set; }
		Services.Packages.Security.CustomerAccessControlListCollection CustomerACLs { get; set; }
		Services.Packages.Security.CustomerUserEntryAccessControlListCollection CustomerUserEntryACLs { get; set; }
		Services.Packages.Security.PurchaseAccessControlListCollection PurchaseACLs { get; set; }
		Services.Packages.Security.PurchaseLineAccessControlListCollection PurchaseLineACLs { get; set; }
		Services.Packages.Security.Security.ModelUserAccessControlListCollection ModelUserACLs { get; set; }
		Services.Packages.Security.Security.ModelUserAccessControlListCollection GetACLs(System.String UserName);
		Services.Packages.Security.Security.ModelUserAccessControlListCollection ACLs { get; set; }

		void Read(System.String __Name);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(ModelUser _object);
		void CopyWithKeysTo(ModelUser _object);
		void CopyFrom(ModelUser _object);
		void CopyTo(ModelUser _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.Security.ModelUser type.
    /// </summary>
    [ComVisible(true)]
    [Guid("e29b12cd-62ea-7469-0ef7-23ec0ff98737")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IModelUserService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(ModelUser _ModelUser);
		[OperationContract]
        ModelUser Read(System.String __Name);
        [OperationContract]
        ModelUser Reload(ModelUser _ModelUser);
        [OperationContract]
        ModelUser Create(System.String __Name);
        [OperationContract]
        void Delete(System.String __Name);
        [OperationContract]
        void UpdateObject(ModelUser _ModelUser);
        [OperationContract]
        void CreateObject(ModelUser _ModelUser);
        [OperationContract]
        void DeleteObject(ModelUser _ModelUser);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		ModelUserCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		ModelUserCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		Services.Packages.Security.ModelUser GetOwner(ModelUser _ModelUser);
		[OperationContract]
		void SetOwner(ModelUser _ModelUser, Services.Packages.Security.ModelUser _Owner);
		[OperationContract]
		ModelUserCollection SearchByName(System.String Name );
		[OperationContract]
		ModelUserCollection SearchByNamePaged(System.String Name , long PagingStart, long PagingCount);
		[OperationContract]
		long SearchByNameCount(System.String Name );
		[OperationContract]
		ModelUserCollection SearchByEmail(System.String Email );
		[OperationContract]
		ModelUserCollection SearchByEmailPaged(System.String Email , long PagingStart, long PagingCount);
		[OperationContract]
		long SearchByEmailCount(System.String Email );
		[OperationContract]
		ModelUserCollection SearchEnabledByNameAndEmail(System.String Name, System.String Email, System.Boolean Enabled );
		[OperationContract]
		ModelUserCollection SearchEnabledByNameAndEmailPaged(System.String Name, System.String Email, System.Boolean Enabled , long PagingStart, long PagingCount);
		[OperationContract]
		long SearchEnabledByNameAndEmailCount(System.String Name, System.String Email, System.Boolean Enabled );
		[OperationContract]
		Services.Packages.PackageCollection GetPackageOwning(ModelUser _ModelUser);
		[OperationContract]
		void SetPackageOwning(ModelUser _ModelUser, Services.Packages.PackageCollection _PackageOwning);
		[OperationContract]
		Services.Packages.ApiKeyCollection GetApiKeyOwning(ModelUser _ModelUser);
		[OperationContract]
		void SetApiKeyOwning(ModelUser _ModelUser, Services.Packages.ApiKeyCollection _ApiKeyOwning);
		[OperationContract]
		Services.Packages.Log.ApplicationExceptionCollection GetApplicationExceptionOwning(ModelUser _ModelUser);
		[OperationContract]
		void SetApplicationExceptionOwning(ModelUser _ModelUser, Services.Packages.Log.ApplicationExceptionCollection _ApplicationExceptionOwning);
		[OperationContract]
		Services.Packages.CustomerCollection GetCustomerOwning(ModelUser _ModelUser);
		[OperationContract]
		void SetCustomerOwning(ModelUser _ModelUser, Services.Packages.CustomerCollection _CustomerOwning);
		[OperationContract]
		Services.Packages.CustomerUserEntryCollection GetCustomerUserEntries(ModelUser _ModelUser);
		[OperationContract]
		void SetCustomerUserEntries(ModelUser _ModelUser, Services.Packages.CustomerUserEntryCollection _CustomerUserEntries);
		[OperationContract]
		Services.Packages.CustomerUserEntryCollection GetCustomerUserEntryOwning(ModelUser _ModelUser);
		[OperationContract]
		void SetCustomerUserEntryOwning(ModelUser _ModelUser, Services.Packages.CustomerUserEntryCollection _CustomerUserEntryOwning);
		[OperationContract]
		Services.Packages.PurchaseCollection GetPurchases(ModelUser _ModelUser);
		[OperationContract]
		void SetPurchases(ModelUser _ModelUser, Services.Packages.PurchaseCollection _Purchases);
		[OperationContract]
		Services.Packages.PurchaseCollection GetPurchaseOwning(ModelUser _ModelUser);
		[OperationContract]
		void SetPurchaseOwning(ModelUser _ModelUser, Services.Packages.PurchaseCollection _PurchaseOwning);
		[OperationContract]
		Services.Packages.PurchaseLineCollection GetPurchaseLineOwning(ModelUser _ModelUser);
		[OperationContract]
		void SetPurchaseLineOwning(ModelUser _ModelUser, Services.Packages.PurchaseLineCollection _PurchaseLineOwning);
		[OperationContract]
		Services.Packages.Security.ModelUserCollection GetModelUserOwning(ModelUser _ModelUser);
		[OperationContract]
		void SetModelUserOwning(ModelUser _ModelUser, Services.Packages.Security.ModelUserCollection _ModelUserOwning);
		[OperationContract]
		Services.Packages.Security.ModelSessionCollection GetSessions(ModelUser _ModelUser);
		[OperationContract]
		void SetSessions(ModelUser _ModelUser, Services.Packages.Security.ModelSessionCollection _Sessions);
		[OperationContract]
		Services.Packages.Security.ModelUserRightsCollection GetRights(ModelUser _ModelUser);
		[OperationContract]
		void SetRights(ModelUser _ModelUser, Services.Packages.Security.ModelUserRightsCollection _Rights);
		[OperationContract]
		Services.Packages.Security.PackageAccessControlListCollection GetPackageACLs(ModelUser _ModelUser);
		[OperationContract]
		void SetPackageACLs(ModelUser _ModelUser, Services.Packages.Security.PackageAccessControlListCollection _PackageACLs);
		[OperationContract]
		Services.Packages.Security.ApiKeyAccessControlListCollection GetApiKeyACLs(ModelUser _ModelUser);
		[OperationContract]
		void SetApiKeyACLs(ModelUser _ModelUser, Services.Packages.Security.ApiKeyAccessControlListCollection _ApiKeyACLs);
		[OperationContract]
		Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection GetApplicationExceptionACLs(ModelUser _ModelUser);
		[OperationContract]
		void SetApplicationExceptionACLs(ModelUser _ModelUser, Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection _ApplicationExceptionACLs);
		[OperationContract]
		Services.Packages.Security.CustomerAccessControlListCollection GetCustomerACLs(ModelUser _ModelUser);
		[OperationContract]
		void SetCustomerACLs(ModelUser _ModelUser, Services.Packages.Security.CustomerAccessControlListCollection _CustomerACLs);
		[OperationContract]
		Services.Packages.Security.CustomerUserEntryAccessControlListCollection GetCustomerUserEntryACLs(ModelUser _ModelUser);
		[OperationContract]
		void SetCustomerUserEntryACLs(ModelUser _ModelUser, Services.Packages.Security.CustomerUserEntryAccessControlListCollection _CustomerUserEntryACLs);
		[OperationContract]
		Services.Packages.Security.PurchaseAccessControlListCollection GetPurchaseACLs(ModelUser _ModelUser);
		[OperationContract]
		void SetPurchaseACLs(ModelUser _ModelUser, Services.Packages.Security.PurchaseAccessControlListCollection _PurchaseACLs);
		[OperationContract]
		Services.Packages.Security.PurchaseLineAccessControlListCollection GetPurchaseLineACLs(ModelUser _ModelUser);
		[OperationContract]
		void SetPurchaseLineACLs(ModelUser _ModelUser, Services.Packages.Security.PurchaseLineAccessControlListCollection _PurchaseLineACLs);
		[OperationContract]
		Services.Packages.Security.Security.ModelUserAccessControlListCollection GetModelUserACLs(ModelUser _ModelUser);
		[OperationContract]
		void SetModelUserACLs(ModelUser _ModelUser, Services.Packages.Security.Security.ModelUserAccessControlListCollection _ModelUserACLs);
		[OperationContract]
		Services.Packages.Security.Security.ModelUserAccessControlListCollection GetACLs(ModelUser _ModelUser);
		[OperationContract]
		void SetACLs(ModelUser _ModelUser, Services.Packages.Security.Security.ModelUserAccessControlListCollection _ACLs);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.Security.ModelUser type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("8ed0e3c2-add4-d319-2627-d4bfdba5dae8")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class ModelUserService : IModelUserService
    {
		/// <summary>
        /// Not supported. Throws a NotSupportedException on get or set.
        /// </summary>
		public string Uri
		{
			get { throw new NotSupportedException(); }
			set { throw new NotSupportedException(); }
		}

		[WebMethod]
        public bool Exists(ModelUser _ModelUser)
        {
			return _ModelUser.Exists;
        }
		
		[WebMethod]
		public ModelUser Read(System.String __Name)
		{
			return new ModelUser(__Name);
		}
		
		[WebMethod]
        public ModelUser Reload(ModelUser _ModelUser)
        {
			_ModelUser.Reload();
			return _ModelUser;
        }
		
		[WebMethod]
        public ModelUser Create(System.String __Name)
        {
			return ModelUser.CreateModelUser(__Name);
        }
        
        [WebMethod]
        public void Delete(System.String __Name)
        {
			ModelUser.DeleteModelUser(__Name);
        }
        
        [WebMethod]
        public void UpdateObject(ModelUser _ModelUser)
        {
			_ModelUser.Update();
        }
		
		[WebMethod]
        public void CreateObject(ModelUser _ModelUser)
        {
			_ModelUser.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ModelUser _ModelUser)
        {
			_ModelUser.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			ModelUser.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			ModelUser.Redo();
        }
		[WebMethod]
		public ModelUserCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUser.GetByOwner( _ModelUser);
		}
		[WebMethod]
		public ModelUserCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ModelUser.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUser.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.Owner;
		}
		[WebMethod]
		public void SetOwner(ModelUser _ModelUser, Services.Packages.Security.ModelUser _Owner)
		{
			_ModelUser.Reload();
			_ModelUser.Owner = _Owner;
			_ModelUser.Update();
		}
		[WebMethod]
		public ModelUserCollection SearchByName(System.String Name )
		{
			return ModelUser.SearchByName(Name );
		}
		[WebMethod]
		public ModelUserCollection SearchByNamePaged(System.String Name , long PagingStart, long PagingCount)
		{
			return ModelUser.SearchByNamePaged(Name , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByNameCount(System.String Name )
		{
			return ModelUser.SearchByNameCount(Name );
		}
		[WebMethod]
		public ModelUserCollection SearchByEmail(System.String Email )
		{
			return ModelUser.SearchByEmail(Email );
		}
		[WebMethod]
		public ModelUserCollection SearchByEmailPaged(System.String Email , long PagingStart, long PagingCount)
		{
			return ModelUser.SearchByEmailPaged(Email , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByEmailCount(System.String Email )
		{
			return ModelUser.SearchByEmailCount(Email );
		}
		[WebMethod]
		public ModelUserCollection SearchEnabledByNameAndEmail(System.String Name, System.String Email, System.Boolean Enabled )
		{
			return ModelUser.SearchEnabledByNameAndEmail(Name, Email, Enabled );
		}
		[WebMethod]
		public ModelUserCollection SearchEnabledByNameAndEmailPaged(System.String Name, System.String Email, System.Boolean Enabled , long PagingStart, long PagingCount)
		{
			return ModelUser.SearchEnabledByNameAndEmailPaged(Name, Email, Enabled , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchEnabledByNameAndEmailCount(System.String Name, System.String Email, System.Boolean Enabled )
		{
			return ModelUser.SearchEnabledByNameAndEmailCount(Name, Email, Enabled );
		}
		[WebMethod]
		public Services.Packages.PackageCollection GetPackageOwning(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.PackageOwning;
		}
		[WebMethod]
		public void SetPackageOwning(ModelUser _ModelUser, Services.Packages.PackageCollection _PackageOwning)
		{
			_ModelUser.Reload();
			_ModelUser.PackageOwning = _PackageOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.ApiKeyCollection GetApiKeyOwning(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.ApiKeyOwning;
		}
		[WebMethod]
		public void SetApiKeyOwning(ModelUser _ModelUser, Services.Packages.ApiKeyCollection _ApiKeyOwning)
		{
			_ModelUser.Reload();
			_ModelUser.ApiKeyOwning = _ApiKeyOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Log.ApplicationExceptionCollection GetApplicationExceptionOwning(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.ApplicationExceptionOwning;
		}
		[WebMethod]
		public void SetApplicationExceptionOwning(ModelUser _ModelUser, Services.Packages.Log.ApplicationExceptionCollection _ApplicationExceptionOwning)
		{
			_ModelUser.Reload();
			_ModelUser.ApplicationExceptionOwning = _ApplicationExceptionOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.CustomerCollection GetCustomerOwning(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.CustomerOwning;
		}
		[WebMethod]
		public void SetCustomerOwning(ModelUser _ModelUser, Services.Packages.CustomerCollection _CustomerOwning)
		{
			_ModelUser.Reload();
			_ModelUser.CustomerOwning = _CustomerOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.CustomerUserEntryCollection GetCustomerUserEntries(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.CustomerUserEntries;
		}
		[WebMethod]
		public void SetCustomerUserEntries(ModelUser _ModelUser, Services.Packages.CustomerUserEntryCollection _CustomerUserEntries)
		{
			_ModelUser.Reload();
			_ModelUser.CustomerUserEntries = _CustomerUserEntries;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.CustomerUserEntryCollection GetCustomerUserEntryOwning(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.CustomerUserEntryOwning;
		}
		[WebMethod]
		public void SetCustomerUserEntryOwning(ModelUser _ModelUser, Services.Packages.CustomerUserEntryCollection _CustomerUserEntryOwning)
		{
			_ModelUser.Reload();
			_ModelUser.CustomerUserEntryOwning = _CustomerUserEntryOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.PurchaseCollection GetPurchases(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.Purchases;
		}
		[WebMethod]
		public void SetPurchases(ModelUser _ModelUser, Services.Packages.PurchaseCollection _Purchases)
		{
			_ModelUser.Reload();
			_ModelUser.Purchases = _Purchases;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.PurchaseCollection GetPurchaseOwning(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.PurchaseOwning;
		}
		[WebMethod]
		public void SetPurchaseOwning(ModelUser _ModelUser, Services.Packages.PurchaseCollection _PurchaseOwning)
		{
			_ModelUser.Reload();
			_ModelUser.PurchaseOwning = _PurchaseOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.PurchaseLineCollection GetPurchaseLineOwning(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.PurchaseLineOwning;
		}
		[WebMethod]
		public void SetPurchaseLineOwning(ModelUser _ModelUser, Services.Packages.PurchaseLineCollection _PurchaseLineOwning)
		{
			_ModelUser.Reload();
			_ModelUser.PurchaseLineOwning = _PurchaseLineOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.ModelUserCollection GetModelUserOwning(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.ModelUserOwning;
		}
		[WebMethod]
		public void SetModelUserOwning(ModelUser _ModelUser, Services.Packages.Security.ModelUserCollection _ModelUserOwning)
		{
			_ModelUser.Reload();
			_ModelUser.ModelUserOwning = _ModelUserOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.ModelSessionCollection GetSessions(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.Sessions;
		}
		[WebMethod]
		public void SetSessions(ModelUser _ModelUser, Services.Packages.Security.ModelSessionCollection _Sessions)
		{
			_ModelUser.Reload();
			_ModelUser.Sessions = _Sessions;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.ModelUserRightsCollection GetRights(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.Rights;
		}
		[WebMethod]
		public void SetRights(ModelUser _ModelUser, Services.Packages.Security.ModelUserRightsCollection _Rights)
		{
			_ModelUser.Reload();
			_ModelUser.Rights = _Rights;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.PackageAccessControlListCollection GetPackageACLs(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.PackageACLs;
		}
		[WebMethod]
		public void SetPackageACLs(ModelUser _ModelUser, Services.Packages.Security.PackageAccessControlListCollection _PackageACLs)
		{
			_ModelUser.Reload();
			_ModelUser.PackageACLs = _PackageACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.ApiKeyAccessControlListCollection GetApiKeyACLs(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.ApiKeyACLs;
		}
		[WebMethod]
		public void SetApiKeyACLs(ModelUser _ModelUser, Services.Packages.Security.ApiKeyAccessControlListCollection _ApiKeyACLs)
		{
			_ModelUser.Reload();
			_ModelUser.ApiKeyACLs = _ApiKeyACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection GetApplicationExceptionACLs(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.ApplicationExceptionACLs;
		}
		[WebMethod]
		public void SetApplicationExceptionACLs(ModelUser _ModelUser, Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection _ApplicationExceptionACLs)
		{
			_ModelUser.Reload();
			_ModelUser.ApplicationExceptionACLs = _ApplicationExceptionACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.CustomerAccessControlListCollection GetCustomerACLs(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.CustomerACLs;
		}
		[WebMethod]
		public void SetCustomerACLs(ModelUser _ModelUser, Services.Packages.Security.CustomerAccessControlListCollection _CustomerACLs)
		{
			_ModelUser.Reload();
			_ModelUser.CustomerACLs = _CustomerACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.CustomerUserEntryAccessControlListCollection GetCustomerUserEntryACLs(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.CustomerUserEntryACLs;
		}
		[WebMethod]
		public void SetCustomerUserEntryACLs(ModelUser _ModelUser, Services.Packages.Security.CustomerUserEntryAccessControlListCollection _CustomerUserEntryACLs)
		{
			_ModelUser.Reload();
			_ModelUser.CustomerUserEntryACLs = _CustomerUserEntryACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.PurchaseAccessControlListCollection GetPurchaseACLs(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.PurchaseACLs;
		}
		[WebMethod]
		public void SetPurchaseACLs(ModelUser _ModelUser, Services.Packages.Security.PurchaseAccessControlListCollection _PurchaseACLs)
		{
			_ModelUser.Reload();
			_ModelUser.PurchaseACLs = _PurchaseACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.PurchaseLineAccessControlListCollection GetPurchaseLineACLs(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.PurchaseLineACLs;
		}
		[WebMethod]
		public void SetPurchaseLineACLs(ModelUser _ModelUser, Services.Packages.Security.PurchaseLineAccessControlListCollection _PurchaseLineACLs)
		{
			_ModelUser.Reload();
			_ModelUser.PurchaseLineACLs = _PurchaseLineACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.Security.ModelUserAccessControlListCollection GetModelUserACLs(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.ModelUserACLs;
		}
		[WebMethod]
		public void SetModelUserACLs(ModelUser _ModelUser, Services.Packages.Security.Security.ModelUserAccessControlListCollection _ModelUserACLs)
		{
			_ModelUser.Reload();
			_ModelUser.ModelUserACLs = _ModelUserACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.Security.ModelUserAccessControlListCollection GetACLs(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.ACLs;
		}
		[WebMethod]
		public void SetACLs(ModelUser _ModelUser, Services.Packages.Security.Security.ModelUserAccessControlListCollection _ACLs)
		{
			_ModelUser.Reload();
			_ModelUser.ACLs = _ACLs;
			_ModelUser.Update();
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.Security.ModelUser model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("6d70068a-52a7-0cb2-36a1-d91361bc25a8")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class ModelUser : IModelUser, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<IModelUserService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<IModelUserService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<IModelUserService> failoverServices = null;

		#endregion
		
		#region Connection provider and DbConnection selection support

		[NonSerialized]
		static string classConnectionString = null;
		[NonSerialized]
		string instanceConnectionString = null;

        [System.Xml.Serialization.XmlIgnoreAttribute]
		public static string ClassConnectionString
        {
            get
            {
				if (!String.IsNullOrEmpty(classConnectionString))
					return classConnectionString;
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.ModelUser"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.ModelUser"].ConnectionString;
				
				if (!String.IsNullOrEmpty(classConnectionString))
					return classConnectionString;
					
				if (!String.IsNullOrEmpty(Platform.Module.Packages.ConnectionString))
					return Platform.Module.Packages.ConnectionString;
					
				throw new InvalidOperationException("The sql connection string has not been set up in any level");
			}
			set
			{
				classConnectionString = value;
			}
        }
		
        [System.Xml.Serialization.XmlIgnoreAttribute]
		public string ConnectionString
        {
            get
            {
				if (!String.IsNullOrEmpty(instanceConnectionString))
					return instanceConnectionString;
				return ClassConnectionString;
			}
			set
			{
				instanceConnectionString = value;
			}
        }
        
        [NonSerialized]
		static global::Platform.Runtime.SqlProviderType classSqlProviderType = global::Platform.Runtime.SqlProviderType.NotSpecified;
		[NonSerialized]
		global::Platform.Runtime.SqlProviderType instanceSqlProviderType = global::Platform.Runtime.SqlProviderType.NotSpecified;
		
        [System.Xml.Serialization.XmlIgnoreAttribute]
		public static global::Platform.Runtime.SqlProviderType ClassSqlProviderType
        {
            get
            {
				if (classSqlProviderType != global::Platform.Runtime.SqlProviderType.NotSpecified)
					return classSqlProviderType;
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.Security.ModelUser.ProviderType");
				
				if (classSqlProviderType != global::Platform.Runtime.SqlProviderType.NotSpecified)
					return classSqlProviderType;
					
				if (global::Platform.Module.Packages.SqlProviderType != global::Platform.Runtime.SqlProviderType.NotSpecified)
					return Platform.Module.Packages.SqlProviderType;
					
				throw new InvalidOperationException("The sql provider type has not been set up in any level");
			}
			set
			{
				classSqlProviderType = value;
			}
        }
		
        [System.Xml.Serialization.XmlIgnoreAttribute]
		public global::Platform.Runtime.SqlProviderType InstanceSqlProviderType
        {
            get
            {
				if (instanceSqlProviderType != global::Platform.Runtime.SqlProviderType.NotSpecified)
					return instanceSqlProviderType;
				return ClassSqlProviderType;
			}
			set
			{
				instanceSqlProviderType = value;
			}
        }

        [NonSerialized]
		private static global::Platform.Runtime.IConnectionProvider instanceConnectionProvider;
        [NonSerialized]
		private static global::Platform.Runtime.IConnectionProvider classConnectionProvider;

        [System.Xml.Serialization.XmlIgnoreAttribute]
		public global::Platform.Runtime.IConnectionProvider InstanceConnectionProvider {
            get
            {
				if (String.IsNullOrEmpty(ConnectionString)
					|| InstanceSqlProviderType == Platform.Runtime.SqlProviderType.NotSpecified)
					return ClassConnectionProvider;

                if (instanceConnectionProvider == null)
                {
                    instanceConnectionProvider = Platform.Runtime.Sql.CreateProvider(InstanceSqlProviderType, ConnectionString);
                }

                return instanceConnectionProvider;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
		public static global::Platform.Runtime.IConnectionProvider ClassConnectionProvider {
            get
            {
				if (String.IsNullOrEmpty(ClassConnectionString)
					|| ClassSqlProviderType == Platform.Runtime.SqlProviderType.NotSpecified)
					return Platform.Module.Packages.ConnectionProvider;

                if (classConnectionProvider == null)
                {
                    classConnectionProvider = Platform.Runtime.Sql.CreateProvider(ClassSqlProviderType, ClassConnectionString);
                }

                return classConnectionProvider;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
		public global::Platform.Runtime.IConnectionProvider ConnectionProvider {
            get
            {
				if (InstanceConnectionProvider != null)
					return InstanceConnectionProvider;

                return ClassConnectionProvider;
            }
        }

		#endregion
        
		#region Data row consistency and state
        RowState __databaseState = RowState.Empty;
        bool __hasBeenReadOnce = false;
		#endregion

		#region Main implementation - Properties, Relations, CRUD


		System.String _Name;
		
		// Key member
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String Name
		{
            get
            {
                return _Name;
            }
            set
            {
				if (_Name != value)
					__hasBeenReadOnce = false;
                _Name = value;
            }
		}

		System.String _PasswordHash;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String PasswordHash
		{
            get
            {
                return _PasswordHash;
            }
            set
            {
                _PasswordHash = value;
            }
		}

		System.String _Email;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String Email
		{
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
		}

		System.Boolean _Enabled;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Boolean Enabled
		{
            get
            {
                return _Enabled;
            }
            set
            {
                _Enabled = value;
            }
		}

		System.String _SecretQuestion;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String SecretQuestion
		{
            get
            {
                return _SecretQuestion;
            }
            set
            {
                _SecretQuestion = value;
            }
		}

		System.String _SecretAnswer;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String SecretAnswer
		{
            get
            {
                return _SecretAnswer;
            }
            set
            {
                _SecretAnswer = value;
            }
		}

		bool _OwnerIsLoaded = false;
		Services.Packages.Security.ModelUser _Owner;
		System.String _Owner_Name; 
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.ModelUser Owner
		{
            get
            {
				if (!_OwnerIsLoaded)
				{
					_Owner = new Services.Packages.Security.ModelUser(_Owner_Name);
					if (_Owner.Exists)
						_OwnerIsLoaded = true;
					else _Owner = null;
				}
                return _Owner;
            }
            set
            {
                _Owner = value;
                _OwnerIsLoaded = true;
                if (_Owner != null)
                {
					if (_Owner.Exists)
					{
						_Owner_Name = _Owner.Name;
						
					}
					else
					{
						_Owner = null;
					}
				}
            }
		}
		
		public static Services.Packages.Security.ModelUser GetOwner(ModelUser _ModelUser)
		{
			return _ModelUser.Owner;
		}

		public static ModelUserCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
        {
			ModelUserCollection _ModelUserCollection = new ModelUserCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsGetByOw", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Name;
				if (_ModelUser != null) {
				param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_ModelUser.Name);
				} else {
				param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", DBNull.Value);
				}
				command.Parameters.Add(param_Name);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					ModelUser o = new ModelUser();
                
					o.__databaseState = RowState.Initialized;
                    o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._PasswordHash = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PasswordHash"], typeof(System.String));
				o._Email = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Email"], typeof(System.String));
				o._Enabled = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Enabled"], typeof(System.Boolean));
				o._SecretQuestion = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretQuestion"], typeof(System.String));
				o._SecretAnswer = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretAnswer"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ModelUserCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ModelUserCollection;
        }
        
        public static ModelUserCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			ModelUserCollection _ModelUserCollection = new ModelUserCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsGetByOwPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Name;
				if (_ModelUser != null) {
				param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_ModelUser.Name);
				} else {
				param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", DBNull.Value);
				}
				command.Parameters.Add(param_Name);
				
                
                DbParameter __param_PagingStart = ClassConnectionProvider.GetDatabaseParameter("PagingStart", PagingStart);
                command.Parameters.Add(__param_PagingStart);
                DbParameter __param_PagingCount = ClassConnectionProvider.GetDatabaseParameter("PagingCount", PagingCount);
                command.Parameters.Add(__param_PagingCount);
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);
				
				if (ClassSqlProviderType == global::Platform.Runtime.SqlProviderType.SqlServer)
                {
                    while (PagingStart > 0 && dr.Read())
                        --PagingStart;
                }

                while (PagingCount > 0 && dr.Read())
                {
					ModelUser o = new ModelUser();
                
					o.__databaseState = RowState.Initialized;
                    o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._PasswordHash = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PasswordHash"], typeof(System.String));
				o._Email = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Email"], typeof(System.String));
				o._Enabled = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Enabled"], typeof(System.Boolean));
				o._SecretQuestion = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretQuestion"], typeof(System.String));
				o._SecretAnswer = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretAnswer"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ModelUserCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ModelUserCollection;
        }
        
        public static long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsGetByOwCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Name;
				if (_ModelUser != null) {
				param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_ModelUser.Name);
				} else {
				param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", DBNull.Value);
				}
				command.Parameters.Add(param_Name);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		public static ModelUserCollection SearchByName(System.String _Name)
        {
			ModelUserCollection _ModelUserCollection = new ModelUserCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsSeByNa", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					ModelUser o = new ModelUser();
                
					o.__databaseState = RowState.Initialized;
                    o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._PasswordHash = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PasswordHash"], typeof(System.String));
				o._Email = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Email"], typeof(System.String));
				o._Enabled = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Enabled"], typeof(System.Boolean));
				o._SecretQuestion = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretQuestion"], typeof(System.String));
				o._SecretAnswer = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretAnswer"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ModelUserCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ModelUserCollection;
        }
        
        public static ModelUserCollection SearchByNamePaged(System.String _Name, long PagingStart, long PagingCount)
        {
			ModelUserCollection _ModelUserCollection = new ModelUserCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsSeByNaPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				
                
                DbParameter __param_PagingStart = ClassConnectionProvider.GetDatabaseParameter("PagingStart", PagingStart);
                command.Parameters.Add(__param_PagingStart);
                DbParameter __param_PagingCount = ClassConnectionProvider.GetDatabaseParameter("PagingCount", PagingCount);
                command.Parameters.Add(__param_PagingCount);
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

               if (ClassSqlProviderType == global::Platform.Runtime.SqlProviderType.SqlServer)
                {
                    while (PagingStart > 0 && dr.Read())
                        --PagingStart;
                }

                while (PagingCount > 0 && dr.Read())
                {
					ModelUser o = new ModelUser();
                
					o.__databaseState = RowState.Initialized;
                    o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._PasswordHash = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PasswordHash"], typeof(System.String));
				o._Email = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Email"], typeof(System.String));
				o._Enabled = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Enabled"], typeof(System.Boolean));
				o._SecretQuestion = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretQuestion"], typeof(System.String));
				o._SecretAnswer = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretAnswer"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ModelUserCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ModelUserCollection;
        }
        
        public static long SearchByNameCount(System.String _Name)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsSeByNaCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		public static ModelUserCollection SearchByEmail(System.String _Email)
        {
			ModelUserCollection _ModelUserCollection = new ModelUserCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsSeByEm", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Email = ClassConnectionProvider.Escape(_Email);
				
                
                DbParameter param_Email = ClassConnectionProvider.GetDatabaseParameter("Email", typeof(System.String), -1);
				param_Email.Value = ClassConnectionProvider.FromValueToSqlModelType(_Email);
				command.Parameters.Add(param_Email);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					ModelUser o = new ModelUser();
                
					o.__databaseState = RowState.Initialized;
                    o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._PasswordHash = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PasswordHash"], typeof(System.String));
				o._Email = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Email"], typeof(System.String));
				o._Enabled = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Enabled"], typeof(System.Boolean));
				o._SecretQuestion = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretQuestion"], typeof(System.String));
				o._SecretAnswer = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretAnswer"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ModelUserCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ModelUserCollection;
        }
        
        public static ModelUserCollection SearchByEmailPaged(System.String _Email, long PagingStart, long PagingCount)
        {
			ModelUserCollection _ModelUserCollection = new ModelUserCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsSeByEmPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Email = ClassConnectionProvider.Escape(_Email);
				
                
                DbParameter param_Email = ClassConnectionProvider.GetDatabaseParameter("Email", typeof(System.String), -1);
				param_Email.Value = ClassConnectionProvider.FromValueToSqlModelType(_Email);
				command.Parameters.Add(param_Email);
				
                
                DbParameter __param_PagingStart = ClassConnectionProvider.GetDatabaseParameter("PagingStart", PagingStart);
                command.Parameters.Add(__param_PagingStart);
                DbParameter __param_PagingCount = ClassConnectionProvider.GetDatabaseParameter("PagingCount", PagingCount);
                command.Parameters.Add(__param_PagingCount);
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

               if (ClassSqlProviderType == global::Platform.Runtime.SqlProviderType.SqlServer)
                {
                    while (PagingStart > 0 && dr.Read())
                        --PagingStart;
                }

                while (PagingCount > 0 && dr.Read())
                {
					ModelUser o = new ModelUser();
                
					o.__databaseState = RowState.Initialized;
                    o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._PasswordHash = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PasswordHash"], typeof(System.String));
				o._Email = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Email"], typeof(System.String));
				o._Enabled = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Enabled"], typeof(System.Boolean));
				o._SecretQuestion = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretQuestion"], typeof(System.String));
				o._SecretAnswer = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretAnswer"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ModelUserCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ModelUserCollection;
        }
        
        public static long SearchByEmailCount(System.String _Email)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsSeByEmCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Email = ClassConnectionProvider.Escape(_Email);
				
                
                DbParameter param_Email = ClassConnectionProvider.GetDatabaseParameter("Email", typeof(System.String), -1);
				param_Email.Value = ClassConnectionProvider.FromValueToSqlModelType(_Email);
				command.Parameters.Add(param_Email);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		public static ModelUserCollection SearchEnabledByNameAndEmail(System.String _Name, System.String _Email, System.Boolean _Enabled)
        {
			ModelUserCollection _ModelUserCollection = new ModelUserCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsSeEnByNaAnEm", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				_Email = ClassConnectionProvider.Escape(_Email);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_Email = ClassConnectionProvider.GetDatabaseParameter("Email", typeof(System.String), -1);
				param_Email.Value = ClassConnectionProvider.FromValueToSqlModelType(_Email);
				command.Parameters.Add(param_Email);
				DbParameter param_Enabled = ClassConnectionProvider.GetDatabaseParameter("Enabled", typeof(System.Boolean), -1);
				param_Enabled.Value = ClassConnectionProvider.FromValueToSqlModelType(_Enabled);
				command.Parameters.Add(param_Enabled);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					ModelUser o = new ModelUser();
                
					o.__databaseState = RowState.Initialized;
                    o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._PasswordHash = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PasswordHash"], typeof(System.String));
				o._Email = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Email"], typeof(System.String));
				o._Enabled = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Enabled"], typeof(System.Boolean));
				o._SecretQuestion = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretQuestion"], typeof(System.String));
				o._SecretAnswer = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretAnswer"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ModelUserCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ModelUserCollection;
        }
        
        public static ModelUserCollection SearchEnabledByNameAndEmailPaged(System.String _Name, System.String _Email, System.Boolean _Enabled, long PagingStart, long PagingCount)
        {
			ModelUserCollection _ModelUserCollection = new ModelUserCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsSeEnByNaAnEmPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				_Email = ClassConnectionProvider.Escape(_Email);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_Email = ClassConnectionProvider.GetDatabaseParameter("Email", typeof(System.String), -1);
				param_Email.Value = ClassConnectionProvider.FromValueToSqlModelType(_Email);
				command.Parameters.Add(param_Email);
				DbParameter param_Enabled = ClassConnectionProvider.GetDatabaseParameter("Enabled", typeof(System.Boolean), -1);
				param_Enabled.Value = ClassConnectionProvider.FromValueToSqlModelType(_Enabled);
				command.Parameters.Add(param_Enabled);
				
                
                DbParameter __param_PagingStart = ClassConnectionProvider.GetDatabaseParameter("PagingStart", PagingStart);
                command.Parameters.Add(__param_PagingStart);
                DbParameter __param_PagingCount = ClassConnectionProvider.GetDatabaseParameter("PagingCount", PagingCount);
                command.Parameters.Add(__param_PagingCount);
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

               if (ClassSqlProviderType == global::Platform.Runtime.SqlProviderType.SqlServer)
                {
                    while (PagingStart > 0 && dr.Read())
                        --PagingStart;
                }

                while (PagingCount > 0 && dr.Read())
                {
					ModelUser o = new ModelUser();
                
					o.__databaseState = RowState.Initialized;
                    o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._PasswordHash = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PasswordHash"], typeof(System.String));
				o._Email = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Email"], typeof(System.String));
				o._Enabled = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Enabled"], typeof(System.Boolean));
				o._SecretQuestion = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretQuestion"], typeof(System.String));
				o._SecretAnswer = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretAnswer"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ModelUserCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ModelUserCollection;
        }
        
        public static long SearchEnabledByNameAndEmailCount(System.String _Name, System.String _Email, System.Boolean _Enabled)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsSeEnByNaAnEmCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				_Email = ClassConnectionProvider.Escape(_Email);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_Email = ClassConnectionProvider.GetDatabaseParameter("Email", typeof(System.String), -1);
				param_Email.Value = ClassConnectionProvider.FromValueToSqlModelType(_Email);
				command.Parameters.Add(param_Email);
				DbParameter param_Enabled = ClassConnectionProvider.GetDatabaseParameter("Enabled", typeof(System.Boolean), -1);
				param_Enabled.Value = ClassConnectionProvider.FromValueToSqlModelType(_Enabled);
				command.Parameters.Add(param_Enabled);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		Services.Packages.PackageCollection _PackageOwning;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.PackageCollection PackageOwning
		{
            get
            {
				if (_PackageOwning == null)
					_PackageOwning = Services.Packages.Package.GetByOwner(this);
				
				return _PackageOwning;
            }
            set
            {
				if (this.Exists)
				{
					if (_PackageOwning != null)
					{
						for(int n = 0; n < _PackageOwning.Count; ++n)
						{
							_PackageOwning[n].Owner = null;
							_PackageOwning[n].Update();
						}
					}
	                
					_PackageOwning = value;
					
					if (_PackageOwning != null)
					{
						for(int n = 0; n < _PackageOwning.Count; ++n)
						{
							_PackageOwning[n].Owner = this;
							_PackageOwning[n].Create();
						}
					}
				}
				else
				{
					_PackageOwning = value;
				}
            }
		}
		
		public void ReloadPackageOwning()
		{
			_PackageOwning = Services.Packages.Package.GetByOwner(this);
		}

		Services.Packages.ApiKeyCollection _ApiKeyOwning;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.ApiKeyCollection ApiKeyOwning
		{
            get
            {
				if (_ApiKeyOwning == null)
					_ApiKeyOwning = Services.Packages.ApiKey.GetByOwner(this);
				
				return _ApiKeyOwning;
            }
            set
            {
				if (this.Exists)
				{
					if (_ApiKeyOwning != null)
					{
						for(int n = 0; n < _ApiKeyOwning.Count; ++n)
						{
							_ApiKeyOwning[n].Owner = null;
							_ApiKeyOwning[n].Update();
						}
					}
	                
					_ApiKeyOwning = value;
					
					if (_ApiKeyOwning != null)
					{
						for(int n = 0; n < _ApiKeyOwning.Count; ++n)
						{
							_ApiKeyOwning[n].Owner = this;
							_ApiKeyOwning[n].Create();
						}
					}
				}
				else
				{
					_ApiKeyOwning = value;
				}
            }
		}
		
		public void ReloadApiKeyOwning()
		{
			_ApiKeyOwning = Services.Packages.ApiKey.GetByOwner(this);
		}

		Services.Packages.Log.ApplicationExceptionCollection _ApplicationExceptionOwning;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Log.ApplicationExceptionCollection ApplicationExceptionOwning
		{
            get
            {
				if (_ApplicationExceptionOwning == null)
					_ApplicationExceptionOwning = Services.Packages.Log.ApplicationException.GetByOwner(this);
				
				return _ApplicationExceptionOwning;
            }
            set
            {
				if (this.Exists)
				{
					if (_ApplicationExceptionOwning != null)
					{
						for(int n = 0; n < _ApplicationExceptionOwning.Count; ++n)
						{
							_ApplicationExceptionOwning[n].Owner = null;
							_ApplicationExceptionOwning[n].Update();
						}
					}
	                
					_ApplicationExceptionOwning = value;
					
					if (_ApplicationExceptionOwning != null)
					{
						for(int n = 0; n < _ApplicationExceptionOwning.Count; ++n)
						{
							_ApplicationExceptionOwning[n].Owner = this;
							_ApplicationExceptionOwning[n].Create();
						}
					}
				}
				else
				{
					_ApplicationExceptionOwning = value;
				}
            }
		}
		
		public void ReloadApplicationExceptionOwning()
		{
			_ApplicationExceptionOwning = Services.Packages.Log.ApplicationException.GetByOwner(this);
		}

		Services.Packages.CustomerCollection _CustomerOwning;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.CustomerCollection CustomerOwning
		{
            get
            {
				if (_CustomerOwning == null)
					_CustomerOwning = Services.Packages.Customer.GetByOwner(this);
				
				return _CustomerOwning;
            }
            set
            {
				if (this.Exists)
				{
					if (_CustomerOwning != null)
					{
						for(int n = 0; n < _CustomerOwning.Count; ++n)
						{
							_CustomerOwning[n].Owner = null;
							_CustomerOwning[n].Update();
						}
					}
	                
					_CustomerOwning = value;
					
					if (_CustomerOwning != null)
					{
						for(int n = 0; n < _CustomerOwning.Count; ++n)
						{
							_CustomerOwning[n].Owner = this;
							_CustomerOwning[n].Create();
						}
					}
				}
				else
				{
					_CustomerOwning = value;
				}
            }
		}
		
		public void ReloadCustomerOwning()
		{
			_CustomerOwning = Services.Packages.Customer.GetByOwner(this);
		}

		Services.Packages.CustomerUserEntryCollection _CustomerUserEntries;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.CustomerUserEntryCollection CustomerUserEntries
		{
            get
            {
				if (_CustomerUserEntries == null)
					_CustomerUserEntries = Services.Packages.CustomerUserEntry.GetByUserLogin(this);
				
				return _CustomerUserEntries;
            }
            set
            {
				if (this.Exists)
				{
					if (_CustomerUserEntries != null)
					{
						for(int n = 0; n < _CustomerUserEntries.Count; ++n)
						{
							_CustomerUserEntries[n].UserLogin = null;
							_CustomerUserEntries[n].Update();
						}
					}
	                
					_CustomerUserEntries = value;
					
					if (_CustomerUserEntries != null)
					{
						for(int n = 0; n < _CustomerUserEntries.Count; ++n)
						{
							_CustomerUserEntries[n].UserLogin = this;
							_CustomerUserEntries[n].Create();
						}
					}
				}
				else
				{
					_CustomerUserEntries = value;
				}
            }
		}
		
		public void ReloadCustomerUserEntries()
		{
			_CustomerUserEntries = Services.Packages.CustomerUserEntry.GetByUserLogin(this);
		}

		Services.Packages.CustomerUserEntryCollection _CustomerUserEntryOwning;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.CustomerUserEntryCollection CustomerUserEntryOwning
		{
            get
            {
				if (_CustomerUserEntryOwning == null)
					_CustomerUserEntryOwning = Services.Packages.CustomerUserEntry.GetByOwner(this);
				
				return _CustomerUserEntryOwning;
            }
            set
            {
				if (this.Exists)
				{
					if (_CustomerUserEntryOwning != null)
					{
						for(int n = 0; n < _CustomerUserEntryOwning.Count; ++n)
						{
							_CustomerUserEntryOwning[n].Owner = null;
							_CustomerUserEntryOwning[n].Update();
						}
					}
	                
					_CustomerUserEntryOwning = value;
					
					if (_CustomerUserEntryOwning != null)
					{
						for(int n = 0; n < _CustomerUserEntryOwning.Count; ++n)
						{
							_CustomerUserEntryOwning[n].Owner = this;
							_CustomerUserEntryOwning[n].Create();
						}
					}
				}
				else
				{
					_CustomerUserEntryOwning = value;
				}
            }
		}
		
		public void ReloadCustomerUserEntryOwning()
		{
			_CustomerUserEntryOwning = Services.Packages.CustomerUserEntry.GetByOwner(this);
		}

		Services.Packages.PurchaseCollection _Purchases;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.PurchaseCollection Purchases
		{
            get
            {
				if (_Purchases == null)
					_Purchases = Services.Packages.Purchase.GetByClient(this);
				
				return _Purchases;
            }
            set
            {
				if (this.Exists)
				{
					if (_Purchases != null)
					{
						for(int n = 0; n < _Purchases.Count; ++n)
						{
							_Purchases[n].Client = null;
							_Purchases[n].Update();
						}
					}
	                
					_Purchases = value;
					
					if (_Purchases != null)
					{
						for(int n = 0; n < _Purchases.Count; ++n)
						{
							_Purchases[n].Client = this;
							_Purchases[n].Create();
						}
					}
				}
				else
				{
					_Purchases = value;
				}
            }
		}
		
		public void ReloadPurchases()
		{
			_Purchases = Services.Packages.Purchase.GetByClient(this);
		}

		Services.Packages.PurchaseCollection _PurchaseOwning;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.PurchaseCollection PurchaseOwning
		{
            get
            {
				if (_PurchaseOwning == null)
					_PurchaseOwning = Services.Packages.Purchase.GetByOwner(this);
				
				return _PurchaseOwning;
            }
            set
            {
				if (this.Exists)
				{
					if (_PurchaseOwning != null)
					{
						for(int n = 0; n < _PurchaseOwning.Count; ++n)
						{
							_PurchaseOwning[n].Owner = null;
							_PurchaseOwning[n].Update();
						}
					}
	                
					_PurchaseOwning = value;
					
					if (_PurchaseOwning != null)
					{
						for(int n = 0; n < _PurchaseOwning.Count; ++n)
						{
							_PurchaseOwning[n].Owner = this;
							_PurchaseOwning[n].Create();
						}
					}
				}
				else
				{
					_PurchaseOwning = value;
				}
            }
		}
		
		public void ReloadPurchaseOwning()
		{
			_PurchaseOwning = Services.Packages.Purchase.GetByOwner(this);
		}

		Services.Packages.PurchaseLineCollection _PurchaseLineOwning;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.PurchaseLineCollection PurchaseLineOwning
		{
            get
            {
				if (_PurchaseLineOwning == null)
					_PurchaseLineOwning = Services.Packages.PurchaseLine.GetByOwner(this);
				
				return _PurchaseLineOwning;
            }
            set
            {
				if (this.Exists)
				{
					if (_PurchaseLineOwning != null)
					{
						for(int n = 0; n < _PurchaseLineOwning.Count; ++n)
						{
							_PurchaseLineOwning[n].Owner = null;
							_PurchaseLineOwning[n].Update();
						}
					}
	                
					_PurchaseLineOwning = value;
					
					if (_PurchaseLineOwning != null)
					{
						for(int n = 0; n < _PurchaseLineOwning.Count; ++n)
						{
							_PurchaseLineOwning[n].Owner = this;
							_PurchaseLineOwning[n].Create();
						}
					}
				}
				else
				{
					_PurchaseLineOwning = value;
				}
            }
		}
		
		public void ReloadPurchaseLineOwning()
		{
			_PurchaseLineOwning = Services.Packages.PurchaseLine.GetByOwner(this);
		}

		Services.Packages.Security.ModelUserCollection _ModelUserOwning;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.ModelUserCollection ModelUserOwning
		{
            get
            {
				if (_ModelUserOwning == null)
					_ModelUserOwning = Services.Packages.Security.ModelUser.GetByOwner(this);
				
				return _ModelUserOwning;
            }
            set
            {
				if (this.Exists)
				{
					if (_ModelUserOwning != null)
					{
						for(int n = 0; n < _ModelUserOwning.Count; ++n)
						{
							_ModelUserOwning[n].Owner = null;
							_ModelUserOwning[n].Update();
						}
					}
	                
					_ModelUserOwning = value;
					
					if (_ModelUserOwning != null)
					{
						for(int n = 0; n < _ModelUserOwning.Count; ++n)
						{
							_ModelUserOwning[n].Owner = this;
							_ModelUserOwning[n].Create();
						}
					}
				}
				else
				{
					_ModelUserOwning = value;
				}
            }
		}
		
		public void ReloadModelUserOwning()
		{
			_ModelUserOwning = Services.Packages.Security.ModelUser.GetByOwner(this);
		}

		Services.Packages.Security.ModelSessionCollection _Sessions;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.ModelSessionCollection Sessions
		{
            get
            {
				if (_Sessions == null)
					_Sessions = Services.Packages.Security.ModelSession.GetByUser(this);
				
				return _Sessions;
            }
            set
            {
				if (this.Exists)
				{
					if (_Sessions != null)
					{
						for(int n = 0; n < _Sessions.Count; ++n)
						{
							_Sessions[n].User = null;
							_Sessions[n].Update();
						}
					}
	                
					_Sessions = value;
					
					if (_Sessions != null)
					{
						for(int n = 0; n < _Sessions.Count; ++n)
						{
							_Sessions[n].User = this;
							_Sessions[n].Create();
						}
					}
				}
				else
				{
					_Sessions = value;
				}
            }
		}
		
		public void ReloadSessions()
		{
			_Sessions = Services.Packages.Security.ModelSession.GetByUser(this);
		}

		Services.Packages.Security.ModelUserRightsCollection _Rights;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.ModelUserRightsCollection Rights
		{
            get
            {
				if (_Rights == null)
					_Rights = Services.Packages.Security.ModelUserRights.GetByUser(this);
				
				return _Rights;
            }
            set
            {
				if (this.Exists)
				{
					if (_Rights != null)
					{
						for(int n = 0; n < _Rights.Count; ++n)
						{
							_Rights[n].User = null;
							_Rights[n].Update();
						}
					}
	                
					_Rights = value;
					
					if (_Rights != null)
					{
						for(int n = 0; n < _Rights.Count; ++n)
						{
							_Rights[n].User = this;
							_Rights[n].Create();
						}
					}
				}
				else
				{
					_Rights = value;
				}
            }
		}
		
		public void ReloadRights()
		{
			_Rights = Services.Packages.Security.ModelUserRights.GetByUser(this);
		}

		public Services.Packages.Security.ModelUserRightsCollection GetByNameAndUser(System.String Name)
		{
			return Services.Packages.Security.ModelUserRights.GetByNameAndUser(Name,  this);
		}

		Services.Packages.Security.PackageAccessControlListCollection _PackageACLs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.PackageAccessControlListCollection PackageACLs
		{
            get
            {
				if (_PackageACLs == null)
					_PackageACLs = Services.Packages.Security.PackageAccessControlList.GetByUser(this);
				
				return _PackageACLs;
            }
            set
            {
				if (this.Exists)
				{
					if (_PackageACLs != null)
					{
						for(int n = 0; n < _PackageACLs.Count; ++n)
						{
							_PackageACLs[n].User = null;
							_PackageACLs[n].Update();
						}
					}
	                
					_PackageACLs = value;
					
					if (_PackageACLs != null)
					{
						for(int n = 0; n < _PackageACLs.Count; ++n)
						{
							_PackageACLs[n].User = this;
							_PackageACLs[n].Create();
						}
					}
				}
				else
				{
					_PackageACLs = value;
				}
            }
		}
		
		public void ReloadPackageACLs()
		{
			_PackageACLs = Services.Packages.Security.PackageAccessControlList.GetByUser(this);
		}

		Services.Packages.Security.ApiKeyAccessControlListCollection _ApiKeyACLs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.ApiKeyAccessControlListCollection ApiKeyACLs
		{
            get
            {
				if (_ApiKeyACLs == null)
					_ApiKeyACLs = Services.Packages.Security.ApiKeyAccessControlList.GetByUser(this);
				
				return _ApiKeyACLs;
            }
            set
            {
				if (this.Exists)
				{
					if (_ApiKeyACLs != null)
					{
						for(int n = 0; n < _ApiKeyACLs.Count; ++n)
						{
							_ApiKeyACLs[n].User = null;
							_ApiKeyACLs[n].Update();
						}
					}
	                
					_ApiKeyACLs = value;
					
					if (_ApiKeyACLs != null)
					{
						for(int n = 0; n < _ApiKeyACLs.Count; ++n)
						{
							_ApiKeyACLs[n].User = this;
							_ApiKeyACLs[n].Create();
						}
					}
				}
				else
				{
					_ApiKeyACLs = value;
				}
            }
		}
		
		public void ReloadApiKeyACLs()
		{
			_ApiKeyACLs = Services.Packages.Security.ApiKeyAccessControlList.GetByUser(this);
		}

		Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection _ApplicationExceptionACLs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection ApplicationExceptionACLs
		{
            get
            {
				if (_ApplicationExceptionACLs == null)
					_ApplicationExceptionACLs = Services.Packages.Log.Security.ApplicationExceptionAccessControlList.GetByUser(this);
				
				return _ApplicationExceptionACLs;
            }
            set
            {
				if (this.Exists)
				{
					if (_ApplicationExceptionACLs != null)
					{
						for(int n = 0; n < _ApplicationExceptionACLs.Count; ++n)
						{
							_ApplicationExceptionACLs[n].User = null;
							_ApplicationExceptionACLs[n].Update();
						}
					}
	                
					_ApplicationExceptionACLs = value;
					
					if (_ApplicationExceptionACLs != null)
					{
						for(int n = 0; n < _ApplicationExceptionACLs.Count; ++n)
						{
							_ApplicationExceptionACLs[n].User = this;
							_ApplicationExceptionACLs[n].Create();
						}
					}
				}
				else
				{
					_ApplicationExceptionACLs = value;
				}
            }
		}
		
		public void ReloadApplicationExceptionACLs()
		{
			_ApplicationExceptionACLs = Services.Packages.Log.Security.ApplicationExceptionAccessControlList.GetByUser(this);
		}

		Services.Packages.Security.CustomerAccessControlListCollection _CustomerACLs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.CustomerAccessControlListCollection CustomerACLs
		{
            get
            {
				if (_CustomerACLs == null)
					_CustomerACLs = Services.Packages.Security.CustomerAccessControlList.GetByUser(this);
				
				return _CustomerACLs;
            }
            set
            {
				if (this.Exists)
				{
					if (_CustomerACLs != null)
					{
						for(int n = 0; n < _CustomerACLs.Count; ++n)
						{
							_CustomerACLs[n].User = null;
							_CustomerACLs[n].Update();
						}
					}
	                
					_CustomerACLs = value;
					
					if (_CustomerACLs != null)
					{
						for(int n = 0; n < _CustomerACLs.Count; ++n)
						{
							_CustomerACLs[n].User = this;
							_CustomerACLs[n].Create();
						}
					}
				}
				else
				{
					_CustomerACLs = value;
				}
            }
		}
		
		public void ReloadCustomerACLs()
		{
			_CustomerACLs = Services.Packages.Security.CustomerAccessControlList.GetByUser(this);
		}

		Services.Packages.Security.CustomerUserEntryAccessControlListCollection _CustomerUserEntryACLs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.CustomerUserEntryAccessControlListCollection CustomerUserEntryACLs
		{
            get
            {
				if (_CustomerUserEntryACLs == null)
					_CustomerUserEntryACLs = Services.Packages.Security.CustomerUserEntryAccessControlList.GetByUser(this);
				
				return _CustomerUserEntryACLs;
            }
            set
            {
				if (this.Exists)
				{
					if (_CustomerUserEntryACLs != null)
					{
						for(int n = 0; n < _CustomerUserEntryACLs.Count; ++n)
						{
							_CustomerUserEntryACLs[n].User = null;
							_CustomerUserEntryACLs[n].Update();
						}
					}
	                
					_CustomerUserEntryACLs = value;
					
					if (_CustomerUserEntryACLs != null)
					{
						for(int n = 0; n < _CustomerUserEntryACLs.Count; ++n)
						{
							_CustomerUserEntryACLs[n].User = this;
							_CustomerUserEntryACLs[n].Create();
						}
					}
				}
				else
				{
					_CustomerUserEntryACLs = value;
				}
            }
		}
		
		public void ReloadCustomerUserEntryACLs()
		{
			_CustomerUserEntryACLs = Services.Packages.Security.CustomerUserEntryAccessControlList.GetByUser(this);
		}

		Services.Packages.Security.PurchaseAccessControlListCollection _PurchaseACLs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.PurchaseAccessControlListCollection PurchaseACLs
		{
            get
            {
				if (_PurchaseACLs == null)
					_PurchaseACLs = Services.Packages.Security.PurchaseAccessControlList.GetByUser(this);
				
				return _PurchaseACLs;
            }
            set
            {
				if (this.Exists)
				{
					if (_PurchaseACLs != null)
					{
						for(int n = 0; n < _PurchaseACLs.Count; ++n)
						{
							_PurchaseACLs[n].User = null;
							_PurchaseACLs[n].Update();
						}
					}
	                
					_PurchaseACLs = value;
					
					if (_PurchaseACLs != null)
					{
						for(int n = 0; n < _PurchaseACLs.Count; ++n)
						{
							_PurchaseACLs[n].User = this;
							_PurchaseACLs[n].Create();
						}
					}
				}
				else
				{
					_PurchaseACLs = value;
				}
            }
		}
		
		public void ReloadPurchaseACLs()
		{
			_PurchaseACLs = Services.Packages.Security.PurchaseAccessControlList.GetByUser(this);
		}

		Services.Packages.Security.PurchaseLineAccessControlListCollection _PurchaseLineACLs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.PurchaseLineAccessControlListCollection PurchaseLineACLs
		{
            get
            {
				if (_PurchaseLineACLs == null)
					_PurchaseLineACLs = Services.Packages.Security.PurchaseLineAccessControlList.GetByUser(this);
				
				return _PurchaseLineACLs;
            }
            set
            {
				if (this.Exists)
				{
					if (_PurchaseLineACLs != null)
					{
						for(int n = 0; n < _PurchaseLineACLs.Count; ++n)
						{
							_PurchaseLineACLs[n].User = null;
							_PurchaseLineACLs[n].Update();
						}
					}
	                
					_PurchaseLineACLs = value;
					
					if (_PurchaseLineACLs != null)
					{
						for(int n = 0; n < _PurchaseLineACLs.Count; ++n)
						{
							_PurchaseLineACLs[n].User = this;
							_PurchaseLineACLs[n].Create();
						}
					}
				}
				else
				{
					_PurchaseLineACLs = value;
				}
            }
		}
		
		public void ReloadPurchaseLineACLs()
		{
			_PurchaseLineACLs = Services.Packages.Security.PurchaseLineAccessControlList.GetByUser(this);
		}

		Services.Packages.Security.Security.ModelUserAccessControlListCollection _ModelUserACLs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.Security.ModelUserAccessControlListCollection ModelUserACLs
		{
            get
            {
				if (_ModelUserACLs == null)
					_ModelUserACLs = Services.Packages.Security.Security.ModelUserAccessControlList.GetByUser(this);
				
				return _ModelUserACLs;
            }
            set
            {
				if (this.Exists)
				{
					if (_ModelUserACLs != null)
					{
						for(int n = 0; n < _ModelUserACLs.Count; ++n)
						{
							_ModelUserACLs[n].User = null;
							_ModelUserACLs[n].Update();
						}
					}
	                
					_ModelUserACLs = value;
					
					if (_ModelUserACLs != null)
					{
						for(int n = 0; n < _ModelUserACLs.Count; ++n)
						{
							_ModelUserACLs[n].User = this;
							_ModelUserACLs[n].Create();
						}
					}
				}
				else
				{
					_ModelUserACLs = value;
				}
            }
		}
		
		public void ReloadModelUserACLs()
		{
			_ModelUserACLs = Services.Packages.Security.Security.ModelUserAccessControlList.GetByUser(this);
		}

		public Services.Packages.Security.Security.ModelUserAccessControlListCollection GetACLs(System.String UserName)
		{
			return Services.Packages.Security.Security.ModelUserAccessControlList.GetACLs(UserName,  this);
		}

		Services.Packages.Security.Security.ModelUserAccessControlListCollection _ACLs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.Security.ModelUserAccessControlListCollection ACLs
		{
            get
            {
				if (_ACLs == null)
					_ACLs = Services.Packages.Security.Security.ModelUserAccessControlList.GetByModelUser(this);
				
				return _ACLs;
            }
            set
            {
				if (this.Exists)
				{
					if (_ACLs != null)
					{
						for(int n = 0; n < _ACLs.Count; ++n)
						{
							_ACLs[n].ModelUser = null;
							_ACLs[n].Update();
						}
					}
	                
					_ACLs = value;
					
					if (_ACLs != null)
					{
						for(int n = 0; n < _ACLs.Count; ++n)
						{
							_ACLs[n].ModelUser = this;
							_ACLs[n].Create();
						}
					}
				}
				else
				{
					_ACLs = value;
				}
            }
		}
		
		public void ReloadACLs()
		{
			_ACLs = Services.Packages.Security.Security.ModelUserAccessControlList.GetByModelUser(this);
		}

		public bool Exists
        {
            get {
				if (!__hasBeenReadOnce)
					Exist();
				
				return __databaseState == RowState.Initialized;
			}
        }
        
        public ModelUser() {}
        
        public ModelUser(System.String __Name)
        {
			Read(__Name);
        }
        
        #region CRUD
        
        void Exist()
        {
			// sql read - should be changed to specific exist implementation
			using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
			{
				dbconn.Open();
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
				DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				
                
				InstanceConnectionProvider.OnBeforeExecuted(command);

				DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

				if (dr.Read())
				{
					__databaseState = RowState.Initialized;
				}
				else
				{
					__databaseState = RowState.Empty;
				}
                
				__hasBeenReadOnce = true;

				dr.Close();
			}
        }
        
        public void Read(System.String __Name)
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].Read(__Name);
					return;
				}

                // Get a service via an algorithm
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "MoUs");
                // Perfect for read operations, but not for write
                // scalingServices[nextIndex].Read(__Name);
				// return;

				throw new NotImplementedException();
            }

            try
            {
				// sql read
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					_Name = __Name;
				DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(__Name);
				command.Parameters.Add(param_Name);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				_PasswordHash = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PasswordHash"], typeof(System.String));
				_Email = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Email"], typeof(System.String));
				_Enabled = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Enabled"], typeof(System.Boolean));
				_SecretQuestion = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretQuestion"], typeof(System.String));
				_SecretAnswer = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretAnswer"], typeof(System.String));
				_OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { _Owner = null; _OwnerIsLoaded = true; }  else _Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
						__databaseState = RowState.Initialized;
					}
					else
					{
						__databaseState = RowState.Empty;
					}
                
					__hasBeenReadOnce = true;

					dr.Close();
				}
			}
			catch (Exception ex)
            {
                if (failoverServices != null)
                {
                    bool foundFailsafe = false;
                    for (int n = 0; n < failoverServices.Count; ++n)
                    {
                        try
                        {
                            failoverServices[n].Read(__Name);
                            foundFailsafe = true;
                            break;
                        }
                        catch
                        {
                            // Do not request again from failed services
                            failoverServices.RemoveAt(n);
                            --n;
                        }
                    }

                    if (failoverServices.Count == 0)
                        failoverServices = null;

                    if (!foundFailsafe)
                        throw ex;
                }
                else throw ex;
            }
        }
        
        public void Reload()
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].Reload(this);
					return;
				}

                // Get a service via an algorithm
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "MoUs");
                // Perfect for read operations, but not for write
                // return scalingServices[nextIndex].Reload();

				throw new NotImplementedException();
            }

            try
            {
				// sql read
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				_PasswordHash = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PasswordHash"], typeof(System.String));
				_Email = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Email"], typeof(System.String));
				_Enabled = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Enabled"], typeof(System.Boolean));
				_SecretQuestion = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretQuestion"], typeof(System.String));
				_SecretAnswer = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretAnswer"], typeof(System.String));
				_OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { _Owner = null; _OwnerIsLoaded = true; }  else _Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
						__databaseState = RowState.Initialized;
					}
					else
					{
						__databaseState = RowState.Empty;
					}
                
					__hasBeenReadOnce = true;

					dr.Close();
				}
			}
			catch (Exception ex)
            {
                if (failoverServices != null)
                {
                    bool foundFailsafe = false;
                    for (int n = 0; n < failoverServices.Count; ++n)
                    {
                        try
                        {
                            failoverServices[n].Reload(this);
                            foundFailsafe = true;
                            break;
                        }
                        catch
                        {
                            // Do not request again from failed services
                            failoverServices.RemoveAt(n);
                            --n;
                        }
                    }

                    if (failoverServices.Count == 0)
                        failoverServices = null;

                    if (!foundFailsafe)
                        throw ex;
                }
                else throw ex;
            }
        }

        public void Create()
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].CreateObject(this);
					return;
				}

                // Create/Update/Delete supports scaling only by synchronizing
				// scalingServices[0].CreateObject(this);
				// scalingServices[0].SynchronizeTo(scalingServices);

				throw new NotImplementedException();
            }

            try
            {		
				if (!Exists)
				{
					// Mark undo if possible
					/*
					if (IsUndoRedoSupported) MarkUndo(this, true, false, false);
					//*/

					// sql create
					using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
					{
						dbconn.Open();
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_PasswordHash = ClassConnectionProvider.GetDatabaseParameter("PasswordHash", typeof(System.String), 256);
				param_PasswordHash.Value = ClassConnectionProvider.FromValueToSqlModelType(_PasswordHash);
				command.Parameters.Add(param_PasswordHash);
				DbParameter param_Email = ClassConnectionProvider.GetDatabaseParameter("Email", typeof(System.String), 256);
				param_Email.Value = ClassConnectionProvider.FromValueToSqlModelType(_Email);
				command.Parameters.Add(param_Email);
				DbParameter param_Enabled = ClassConnectionProvider.GetDatabaseParameter("Enabled", typeof(System.Boolean), -1);
				param_Enabled.Value = ClassConnectionProvider.FromValueToSqlModelType(_Enabled);
				command.Parameters.Add(param_Enabled);
				DbParameter param_SecretQuestion = ClassConnectionProvider.GetDatabaseParameter("SecretQuestion", typeof(System.String), 512);
				param_SecretQuestion.Value = ClassConnectionProvider.FromValueToSqlModelType(_SecretQuestion);
				command.Parameters.Add(param_SecretQuestion);
				DbParameter param_SecretAnswer = ClassConnectionProvider.GetDatabaseParameter("SecretAnswer", typeof(System.String), 512);
				param_SecretAnswer.Value = ClassConnectionProvider.FromValueToSqlModelType(_SecretAnswer);
				command.Parameters.Add(param_SecretAnswer);
				DbParameter param_Owner_Name = ClassConnectionProvider.GetDatabaseParameter("Owner_Name", typeof(System.String), 128);
				param_Owner_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Owner_Name);
				if (_Owner == null) param_Owner_Name.Value = DBNull.Value;
				else param_Owner_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Owner.Name);
				command.Parameters.Add(param_Owner_Name);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				_PasswordHash = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PasswordHash"], typeof(System.String));
				_Email = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Email"], typeof(System.String));
				_Enabled = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Enabled"], typeof(System.Boolean));
				_SecretQuestion = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretQuestion"], typeof(System.String));
				_SecretAnswer = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SecretAnswer"], typeof(System.String));
				_OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { _Owner = null; _OwnerIsLoaded = true; }  else _Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
						}
					
						__databaseState = RowState.Initialized;
					}
				}
				else Update();
			}
			catch (Exception)
            {
				// Failsafe scenarios cannot be used for create/update/delete
				// Must be handled as an error
                throw;
            }

            // Everything went ok; now replicate in a synchronous way
            if (replicationServices != null)
            {
                // this is only for write/delete operations
                for (int n = 0; n < replicationServices.Count; ++n)
                {
                    try
                    {
                        replicationServices[n].CreateObject(this);
                    }
                    catch
                    {
                        // Do not request again from failed services
                        replicationServices.RemoveAt(n);
                        --n;
                    }
                }

                if (replicationServices.Count == 0)
                    replicationServices = null;
            }
        }
        
        static public ModelUser CreateModelUser(System.String __Name)
        {
            ModelUser o = new ModelUser(__Name);
            if (!o.Exists) o.Create();
            return o;
        }

        public void Update()
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].UpdateObject(this);
					return;
				}

                // Create/Update/Delete supports scaling only by synchronizing
				// scalingServices[0].UpdateObject(this);

				throw new NotImplementedException();
            }

            try
            {			
				if (!Exists)
				{
					this.Create();
					return;
				}

				// Mark undo if possible
				/*
				if (IsUndoRedoSupported) MarkUndo(this, false, false, true);
				//*/
				
				// sql update
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_PasswordHash = ClassConnectionProvider.GetDatabaseParameter("PasswordHash", typeof(System.String), 256);
				param_PasswordHash.Value = ClassConnectionProvider.FromValueToSqlModelType(_PasswordHash);
				command.Parameters.Add(param_PasswordHash);
				DbParameter param_Email = ClassConnectionProvider.GetDatabaseParameter("Email", typeof(System.String), 256);
				param_Email.Value = ClassConnectionProvider.FromValueToSqlModelType(_Email);
				command.Parameters.Add(param_Email);
				DbParameter param_Enabled = ClassConnectionProvider.GetDatabaseParameter("Enabled", typeof(System.Boolean), -1);
				param_Enabled.Value = ClassConnectionProvider.FromValueToSqlModelType(_Enabled);
				command.Parameters.Add(param_Enabled);
				DbParameter param_SecretQuestion = ClassConnectionProvider.GetDatabaseParameter("SecretQuestion", typeof(System.String), 512);
				param_SecretQuestion.Value = ClassConnectionProvider.FromValueToSqlModelType(_SecretQuestion);
				command.Parameters.Add(param_SecretQuestion);
				DbParameter param_SecretAnswer = ClassConnectionProvider.GetDatabaseParameter("SecretAnswer", typeof(System.String), 512);
				param_SecretAnswer.Value = ClassConnectionProvider.FromValueToSqlModelType(_SecretAnswer);
				command.Parameters.Add(param_SecretAnswer);
				DbParameter param_OwnerHasChanged = ClassConnectionProvider.GetDatabaseParameter("OwnerHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_OwnerIsLoaded));
				command.Parameters.Add(param_OwnerHasChanged);
				DbParameter param_Owner_Name = ClassConnectionProvider.GetDatabaseParameter("Owner_Name", typeof(System.String), 128);
				param_Owner_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Owner_Name);
				if (_Owner == null) param_Owner_Name.Value = DBNull.Value;
				else param_Owner_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Owner.Name);
				command.Parameters.Add(param_Owner_Name);
				

					command.ExecuteNonQuery();
				}
			}
			catch (Exception)
            {
				// Failsafe scenarios cannot be used for create/update/delete
				// Must be handled as an error
                throw;
            }

            // Everything went ok; now replicate in a synchronous way
            if (replicationServices != null)
            {
                // this is only for write/delete operations
                for (int n = 0; n < replicationServices.Count; ++n)
                {
                    try
                    {
                        replicationServices[n].UpdateObject(this);
                    }
                    catch
                    {
                        // Do not request again from failed services
                        replicationServices.RemoveAt(n);
                        --n;
                    }
                }

                if (replicationServices.Count == 0)
                    replicationServices = null;
            }
        }

        public void Delete()
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].DeleteObject(this);
					return;
				}

                // Create/Update/Delete supports scaling only by synchronizing
				// scalingServices[0].DeleteObject(this);

				throw new NotImplementedException();
            }

            try
            {			
				if (!Exists)
					return;

				// Mark undo if possible
				/*
				if (IsUndoRedoSupported) MarkUndo(this, false, true, false);
				//*/

				// sql-delete
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				
				
					command.ExecuteNonQuery();
				
					__databaseState = RowState.Empty;
				}
			}
			catch (Exception)
            {
				// Failsafe scenarios cannot be used for create/update/delete
				// Must be handled as an error
                throw;
            }

            // Everything went ok; now replicate in a synchronous way
            if (replicationServices != null)
            {
                // this is only for write/delete operations
                for (int n = 0; n < replicationServices.Count; ++n)
                {
                    try
                    {
                        replicationServices[n].DeleteObject(this);
                    }
                    catch
                    {
                        // Do not request again from failed services
                        replicationServices.RemoveAt(n);
                        --n;
                    }
                }

                if (replicationServices.Count == 0)
                    replicationServices = null;
            }
        }
        
        static public void DeleteModelUser(System.String __Name)
        {
            ModelUser o = new ModelUser(__Name);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(ModelUser _object)
        {
			_Owner = null;
			_OwnerIsLoaded = false;
			_Name = _object._Name;
			_PasswordHash = _object._PasswordHash;
			_Email = _object._Email;
			_Enabled = _object._Enabled;
			_SecretQuestion = _object._SecretQuestion;
			_SecretAnswer = _object._SecretAnswer;
			
        }
        
        public void CopyWithKeysTo(ModelUser _object)
        {
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Name = _Name;
			_object._PasswordHash = _PasswordHash;
			_object._Email = _Email;
			_object._Enabled = _Enabled;
			_object._SecretQuestion = _SecretQuestion;
			_object._SecretAnswer = _SecretAnswer;
			
        }
        
        static public void CopyWithKeysObject(ModelUser _objectFrom, ModelUser _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(ModelUser _object)
        {
			_Owner = null;
			_OwnerIsLoaded = false;
			_PasswordHash = _object._PasswordHash;
			_Email = _object._Email;
			_Enabled = _object._Enabled;
			_SecretQuestion = _object._SecretQuestion;
			_SecretAnswer = _object._SecretAnswer;
			
        }
        
        public void CopyTo(ModelUser _object)
        {
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._PasswordHash = _PasswordHash;
			_object._Email = _Email;
			_object._Enabled = _Enabled;
			_object._SecretQuestion = _SecretQuestion;
			_object._SecretAnswer = _SecretAnswer;
			
        }
        
        static public void CopyObject(ModelUser _objectFrom, ModelUser _objectTo)
        {
			_objectFrom.CopyTo(_objectTo);
        }
        
        #endregion

		#region Undo / Redo functionality

		/*
		private static bool isUndoRedoSupported = false;
		private static bool isUndoRedoSupportedHasBeenLoaded = false;
		private static long undoRedoMaximumObjects = -1;
		public static bool IsUndoRedoSupported
		{
			get {
				if (!isUndoRedoSupportedHasBeenLoaded) {
					// Load options undo entity once
					isUndoRedoSupportedHasBeenLoaded = true;

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(ModelUser).FullName);
                    if (!options.Exists)
                    {
                        undoRedoMaximumObjects = options.ItemsAllowed = 1000;
                        options.IsEnabled = true;
                        options.Create();

                        isUndoRedoSupported = true;
                    }
                    else
                    {
                        isUndoRedoSupported = options.IsEnabled;
                        undoRedoMaximumObjects = options.ItemsAllowed;
                    }
				}

				return isUndoRedoSupported;
			}

			set {
				isUndoRedoSupportedHasBeenLoaded = true;
				isUndoRedoSupported = value;

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(ModelUser).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(ModelUser _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			ModelUserUndoRedoCollection allUndidAndNotRedoneEntries = ModelUserUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			ModelUserUndoRedo _urobject = new ModelUserUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.Owner_Name = _object._Owner_Name;
			_urobject.Name = _object._Name;
			_urobject.PasswordHash = _object._PasswordHash;
			_urobject.Email = _object._Email;
			_urobject.Enabled = _object._Enabled;
			_urobject.SecretQuestion = _object._SecretQuestion;
			_urobject.SecretAnswer = _object._SecretAnswer;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(ModelUser).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = ModelUserUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				ModelUserUndoRedoCollection allOldUndoEntries = ModelUserUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			ModelUserUndoRedoCollection firstUndoEntries = ModelUserUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			ModelUserUndoRedo _urobject = firstUndoEntries[0];
			
			ModelUser _object = new ModelUser();
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Owner_Name = _urobject.Owner_Name;
			_object._Name = _urobject.Name;
			_object._PasswordHash = _urobject.PasswordHash;
			_object._Email = _urobject.Email;
			_object._Enabled = _urobject.Enabled;
			_object._SecretQuestion = _urobject.SecretQuestion;
			_object._SecretAnswer = _urobject.SecretAnswer;
			

			_urobject.IsUndone = true;
			_urobject.Update();

			// Do the opposite action
			if (_urobject.IsDeletedUndoCreates || _urobject.IsUpdatedUndoUpdates)
				_object.Create(); // Create or update store
			else if (_urobject.IsCreatedUndoDeletes)
				_object.Delete(); // Delete
        }

        static public void Redo()
        {
			// Get the last already undone and load it
			ModelUserUndoRedoCollection firstEntryToRedoEntries = ModelUserUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			ModelUserUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			ModelUser _object = new ModelUser();
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Owner_Name = _urobject.Owner_Name;
			_object._Name = _urobject.Name;
			_object._PasswordHash = _urobject.PasswordHash;
			_object._Email = _urobject.Email;
			_object._Enabled = _urobject.Enabled;
			_object._SecretQuestion = _urobject.SecretQuestion;
			_object._SecretAnswer = _urobject.SecretAnswer;
			

			_urobject.IsUndone = false;
			_urobject.Update();

			// Do the opposite action
			if (_urobject.IsDeletedUndoCreates)
				_object.Delete(); // Delete again
			else if (_urobject.IsCreatedUndoDeletes || _urobject.IsUpdatedUndoUpdates)
				_object.Create(); // Create or update again
        }

		//*/ // Undo redo enabled

		//*
		
		static public void Undo()
		{
			throw new NotImplementedException("This feature is not implemented in this class.");
		}
		
		static public void Redo()
		{
			throw new NotImplementedException("This feature is not implemented in this class.");
		}

		//*/ // Undo redo disabled

		#endregion


		#endregion

		#region IHierarchyData Members

        IHierarchicalEnumerable IHierarchyData.GetChildren()
        {
            string selectedProperty = (__level < __childProperties.Length ? __childProperties[__level] : __childProperties[__childProperties.Length - 1]);

            global::System.Reflection.PropertyInfo pi = this.GetType().GetProperty(selectedProperty);
            if (pi == null)
                throw new NullReferenceException("Property '" + selectedProperty + "' does not exist in type " + this.GetType().FullName);

            IHierarchicalEnumerable dataSource = pi.GetValue(this, null) as IHierarchicalEnumerable;

            foreach (IHierarchyData ihd in dataSource)
            {
                global::Platform.Runtime.Data.IModelHierachyData imhd = ihd as global::Platform.Runtime.Data.IModelHierachyData;
                if (imhd != null)
                {
                    imhd.Level = __level + 1;
                    imhd.ParentProperties = __parentProperties;
                    imhd.ChildProperties = __childProperties;
                }
            }

            return dataSource;
        }

        IHierarchyData IHierarchyData.GetParent()
        {
            string selectedProperty = (__level < __parentProperties.Length ? __parentProperties[__level] : __parentProperties[__parentProperties.Length - 1]);

            global::System.Reflection.PropertyInfo pi = this.GetType().GetProperty(selectedProperty);
            if (pi == null)
                throw new NullReferenceException("Property '" + selectedProperty + "' does not exist in type " + this.GetType().FullName);

            IHierarchyData data = pi.GetValue(this, null) as IHierarchyData;

            global::Platform.Runtime.Data.IModelHierachyData imhd = data as global::Platform.Runtime.Data.IModelHierachyData;
            if (imhd != null)
            {
                imhd.Level = __level - 1;
                imhd.ParentProperties = __parentProperties;
                imhd.ChildProperties = __childProperties;
            }

            return data;
        }

        bool IHierarchyData.HasChildren
        {
            get
            {
                string selectedProperty = (__level < __childProperties.Length ? __childProperties[__level] : __childProperties[__childProperties.Length - 1]);

                global::System.Reflection.PropertyInfo pi = this.GetType().GetProperty(selectedProperty);
                if (pi == null)
                    throw new NullReferenceException("Property '" + selectedProperty + "' does not exist in type " + this.GetType().FullName);

                IHierarchicalEnumerable value = pi.GetValue(this, null) as IHierarchicalEnumerable;

                bool exists = false;
                foreach(IHierarchyData ihd in value)
                {
                    exists = true;
                    break;
                }

                return exists;
            }
        }

        object IHierarchyData.Item
        {
            get { return this; }
        }

        string IHierarchyData.Path
        {
            get { return ""; }
        }

        string IHierarchyData.Type
        {
            get { return this.GetType().FullName; }
        }

        #endregion

        #region Platform.Runtime.Data.IHierarchyData explicit Members

        [NonSerialized]
        string[] __childProperties = null;
        [NonSerialized]
        string[] __parentProperties = null;
        [NonSerialized]
        int __level = -1;

        string[] Platform.Runtime.Data.IModelHierachyData.ChildProperties
        {
            get
            {
                return __childProperties;
            }
            set
            {
                __childProperties = value;
            }
        }

        string[] Platform.Runtime.Data.IModelHierachyData.ParentProperties
        {
            get
            {
                return __parentProperties;
            }
            set
            {
                __parentProperties = value;
            }
        }

        int Platform.Runtime.Data.IModelHierachyData.Level
        {
            get
            {
                return __level;
            }
            set
            {
                __level = value;
            }
        }

        #endregion
    }
    
    /// <summary>
    /// Defines the contract for the ModelUserCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("1ad4a4c0-fccc-20e8-f9c8-bcc28da99968")]
    public interface IModelUserCollection : IEnumerable<ModelUser>
    {
        int IndexOf(ModelUser item);
        void Insert(int index, ModelUser item);
        void RemoveAt(int index);
        ModelUser this[int index] { get; set; }
        void Add(ModelUser item);
        void Clear();
        bool Contains(ModelUser item);
        void CopyTo(ModelUser[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(ModelUser item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.Security.ModelUser
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("08613b1c-1989-7090-30c4-5833d3057169")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class ModelUserCollection : IModelUserCollection, IList<ModelUser>, IHierarchicalEnumerable
    {
        List<ModelUser> _list = new List<ModelUser>();
        
        public static implicit operator List<ModelUser>(ModelUserCollection collection)
        {
            return collection._list;
        }

        #region IList<ModelUser> Members

        public int IndexOf(ModelUser item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, ModelUser item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public ModelUser this[int index]
        {
            get
            {
                return _list[index];
            }
            set
            {
                _list[index] = value;
            }
        }

        #endregion

        #region ICollection<ModelUser> Members

        public void Add(ModelUser item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(ModelUser item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(ModelUser[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _list.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(ModelUser item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<ModelUser> Members

        public IEnumerator<ModelUser> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((System.Collections.IEnumerable)_list).GetEnumerator();
        }

        #endregion

        #region IHierarchicalEnumerable Members

        public IHierarchyData GetHierarchyData(object enumeratedItem)
        {
            return enumeratedItem as IHierarchyData;
        }

        #endregion
    }
    
namespace Web
{
	/// <summary>
	/// The WebService service provider that allows to create web services
	/// that share Services.Packages.Security.ModelUser objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Security.Web.ModelUserWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class ModelUserWebService : WebService, IModelUserService
	{
		/// <summary>
        /// Gets the Uri if the service. Setting property is not supported.
        /// </summary>
		public string Uri
		{
			get { return "http://services.msd.com"; }
			set { throw new NotSupportedException(); }
		}

		[WebMethod]
        public bool Exists(ModelUser _ModelUser)
        {
			return _ModelUser.Exists;
        }
		
		[WebMethod]
		public ModelUser Read(System.String __Name)
		{
			return new ModelUser(__Name);
		}
		
		[WebMethod]
        public ModelUser Reload(ModelUser _ModelUser)
        {
			_ModelUser.Reload();
			return _ModelUser;
        }
		
		[WebMethod]
        public ModelUser Create(System.String __Name)
        {
			return ModelUser.CreateModelUser(__Name);
        }
        
        [WebMethod]
        public void Delete(System.String __Name)
        {
			ModelUser.DeleteModelUser(__Name);
        }
        
        [WebMethod]
        public void UpdateObject(ModelUser _ModelUser)
        {
			_ModelUser.Update();
        }
		
		[WebMethod]
        public void CreateObject(ModelUser _ModelUser)
        {
			_ModelUser.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ModelUser _ModelUser)
        {
			_ModelUser.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			ModelUser.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			ModelUser.Redo();
        }
		[WebMethod]
		public ModelUserCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUser.GetByOwner( _ModelUser);
		}
		[WebMethod]
		public ModelUserCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ModelUser.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUser.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.Owner;
		}
		[WebMethod]
		public void SetOwner(ModelUser _ModelUser, Services.Packages.Security.ModelUser _Owner)
		{
			_ModelUser.Reload();
			_ModelUser.Owner = _Owner;
			_ModelUser.Update();
		}
		[WebMethod]
		public ModelUserCollection SearchByName(System.String Name )
		{
			return ModelUser.SearchByName(Name );
		}
		[WebMethod]
		public ModelUserCollection SearchByNamePaged(System.String Name , long PagingStart, long PagingCount)
		{
			return ModelUser.SearchByNamePaged(Name , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByNameCount(System.String Name )
		{
			return ModelUser.SearchByNameCount(Name );
		}
		[WebMethod]
		public ModelUserCollection SearchByEmail(System.String Email )
		{
			return ModelUser.SearchByEmail(Email );
		}
		[WebMethod]
		public ModelUserCollection SearchByEmailPaged(System.String Email , long PagingStart, long PagingCount)
		{
			return ModelUser.SearchByEmailPaged(Email , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByEmailCount(System.String Email )
		{
			return ModelUser.SearchByEmailCount(Email );
		}
		[WebMethod]
		public ModelUserCollection SearchEnabledByNameAndEmail(System.String Name, System.String Email, System.Boolean Enabled )
		{
			return ModelUser.SearchEnabledByNameAndEmail(Name, Email, Enabled );
		}
		[WebMethod]
		public ModelUserCollection SearchEnabledByNameAndEmailPaged(System.String Name, System.String Email, System.Boolean Enabled , long PagingStart, long PagingCount)
		{
			return ModelUser.SearchEnabledByNameAndEmailPaged(Name, Email, Enabled , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchEnabledByNameAndEmailCount(System.String Name, System.String Email, System.Boolean Enabled )
		{
			return ModelUser.SearchEnabledByNameAndEmailCount(Name, Email, Enabled );
		}
		[WebMethod]
		public Services.Packages.PackageCollection GetPackageOwning(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.PackageOwning;
		}
		[WebMethod]
		public void SetPackageOwning(ModelUser _ModelUser, Services.Packages.PackageCollection _PackageOwning)
		{
			_ModelUser.Reload();
			_ModelUser.PackageOwning = _PackageOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.ApiKeyCollection GetApiKeyOwning(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.ApiKeyOwning;
		}
		[WebMethod]
		public void SetApiKeyOwning(ModelUser _ModelUser, Services.Packages.ApiKeyCollection _ApiKeyOwning)
		{
			_ModelUser.Reload();
			_ModelUser.ApiKeyOwning = _ApiKeyOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Log.ApplicationExceptionCollection GetApplicationExceptionOwning(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.ApplicationExceptionOwning;
		}
		[WebMethod]
		public void SetApplicationExceptionOwning(ModelUser _ModelUser, Services.Packages.Log.ApplicationExceptionCollection _ApplicationExceptionOwning)
		{
			_ModelUser.Reload();
			_ModelUser.ApplicationExceptionOwning = _ApplicationExceptionOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.CustomerCollection GetCustomerOwning(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.CustomerOwning;
		}
		[WebMethod]
		public void SetCustomerOwning(ModelUser _ModelUser, Services.Packages.CustomerCollection _CustomerOwning)
		{
			_ModelUser.Reload();
			_ModelUser.CustomerOwning = _CustomerOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.CustomerUserEntryCollection GetCustomerUserEntries(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.CustomerUserEntries;
		}
		[WebMethod]
		public void SetCustomerUserEntries(ModelUser _ModelUser, Services.Packages.CustomerUserEntryCollection _CustomerUserEntries)
		{
			_ModelUser.Reload();
			_ModelUser.CustomerUserEntries = _CustomerUserEntries;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.CustomerUserEntryCollection GetCustomerUserEntryOwning(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.CustomerUserEntryOwning;
		}
		[WebMethod]
		public void SetCustomerUserEntryOwning(ModelUser _ModelUser, Services.Packages.CustomerUserEntryCollection _CustomerUserEntryOwning)
		{
			_ModelUser.Reload();
			_ModelUser.CustomerUserEntryOwning = _CustomerUserEntryOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.PurchaseCollection GetPurchases(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.Purchases;
		}
		[WebMethod]
		public void SetPurchases(ModelUser _ModelUser, Services.Packages.PurchaseCollection _Purchases)
		{
			_ModelUser.Reload();
			_ModelUser.Purchases = _Purchases;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.PurchaseCollection GetPurchaseOwning(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.PurchaseOwning;
		}
		[WebMethod]
		public void SetPurchaseOwning(ModelUser _ModelUser, Services.Packages.PurchaseCollection _PurchaseOwning)
		{
			_ModelUser.Reload();
			_ModelUser.PurchaseOwning = _PurchaseOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.PurchaseLineCollection GetPurchaseLineOwning(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.PurchaseLineOwning;
		}
		[WebMethod]
		public void SetPurchaseLineOwning(ModelUser _ModelUser, Services.Packages.PurchaseLineCollection _PurchaseLineOwning)
		{
			_ModelUser.Reload();
			_ModelUser.PurchaseLineOwning = _PurchaseLineOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.ModelUserCollection GetModelUserOwning(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.ModelUserOwning;
		}
		[WebMethod]
		public void SetModelUserOwning(ModelUser _ModelUser, Services.Packages.Security.ModelUserCollection _ModelUserOwning)
		{
			_ModelUser.Reload();
			_ModelUser.ModelUserOwning = _ModelUserOwning;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.ModelSessionCollection GetSessions(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.Sessions;
		}
		[WebMethod]
		public void SetSessions(ModelUser _ModelUser, Services.Packages.Security.ModelSessionCollection _Sessions)
		{
			_ModelUser.Reload();
			_ModelUser.Sessions = _Sessions;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.ModelUserRightsCollection GetRights(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.Rights;
		}
		[WebMethod]
		public void SetRights(ModelUser _ModelUser, Services.Packages.Security.ModelUserRightsCollection _Rights)
		{
			_ModelUser.Reload();
			_ModelUser.Rights = _Rights;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.PackageAccessControlListCollection GetPackageACLs(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.PackageACLs;
		}
		[WebMethod]
		public void SetPackageACLs(ModelUser _ModelUser, Services.Packages.Security.PackageAccessControlListCollection _PackageACLs)
		{
			_ModelUser.Reload();
			_ModelUser.PackageACLs = _PackageACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.ApiKeyAccessControlListCollection GetApiKeyACLs(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.ApiKeyACLs;
		}
		[WebMethod]
		public void SetApiKeyACLs(ModelUser _ModelUser, Services.Packages.Security.ApiKeyAccessControlListCollection _ApiKeyACLs)
		{
			_ModelUser.Reload();
			_ModelUser.ApiKeyACLs = _ApiKeyACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection GetApplicationExceptionACLs(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.ApplicationExceptionACLs;
		}
		[WebMethod]
		public void SetApplicationExceptionACLs(ModelUser _ModelUser, Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection _ApplicationExceptionACLs)
		{
			_ModelUser.Reload();
			_ModelUser.ApplicationExceptionACLs = _ApplicationExceptionACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.CustomerAccessControlListCollection GetCustomerACLs(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.CustomerACLs;
		}
		[WebMethod]
		public void SetCustomerACLs(ModelUser _ModelUser, Services.Packages.Security.CustomerAccessControlListCollection _CustomerACLs)
		{
			_ModelUser.Reload();
			_ModelUser.CustomerACLs = _CustomerACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.CustomerUserEntryAccessControlListCollection GetCustomerUserEntryACLs(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.CustomerUserEntryACLs;
		}
		[WebMethod]
		public void SetCustomerUserEntryACLs(ModelUser _ModelUser, Services.Packages.Security.CustomerUserEntryAccessControlListCollection _CustomerUserEntryACLs)
		{
			_ModelUser.Reload();
			_ModelUser.CustomerUserEntryACLs = _CustomerUserEntryACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.PurchaseAccessControlListCollection GetPurchaseACLs(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.PurchaseACLs;
		}
		[WebMethod]
		public void SetPurchaseACLs(ModelUser _ModelUser, Services.Packages.Security.PurchaseAccessControlListCollection _PurchaseACLs)
		{
			_ModelUser.Reload();
			_ModelUser.PurchaseACLs = _PurchaseACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.PurchaseLineAccessControlListCollection GetPurchaseLineACLs(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.PurchaseLineACLs;
		}
		[WebMethod]
		public void SetPurchaseLineACLs(ModelUser _ModelUser, Services.Packages.Security.PurchaseLineAccessControlListCollection _PurchaseLineACLs)
		{
			_ModelUser.Reload();
			_ModelUser.PurchaseLineACLs = _PurchaseLineACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.Security.ModelUserAccessControlListCollection GetModelUserACLs(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.ModelUserACLs;
		}
		[WebMethod]
		public void SetModelUserACLs(ModelUser _ModelUser, Services.Packages.Security.Security.ModelUserAccessControlListCollection _ModelUserACLs)
		{
			_ModelUser.Reload();
			_ModelUser.ModelUserACLs = _ModelUserACLs;
			_ModelUser.Update();
		}
		[WebMethod]
		public Services.Packages.Security.Security.ModelUserAccessControlListCollection GetACLs(ModelUser _ModelUser)
		{
			_ModelUser.Reload();
			return _ModelUser.ACLs;
		}
		[WebMethod]
		public void SetACLs(ModelUser _ModelUser, Services.Packages.Security.Security.ModelUserAccessControlListCollection _ACLs)
		{
			_ModelUser.Reload();
			_ModelUser.ACLs = _ACLs;
			_ModelUser.Update();
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="ModelUserWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("37ff2b02-bfd1-8d1c-1d50-73de96ef7e8c")]
    sealed public class ModelUserWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IModelUserService
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
		public ModelUserWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public ModelUserWebServiceClient()
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

		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Exists", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool Exists(ModelUser _ModelUser)
        {
			object[] results = this.Invoke("Exists", new object[] {_ModelUser});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUser Read(System.String __Name)
		{
			object[] results = this.Invoke("Read", new object[] {__Name});
			return ((ModelUser)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUser Reload(ModelUser _ModelUser)
        {
			object[] results = this.Invoke("Reload", new object[] {_ModelUser});
			return ((ModelUser)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUser Create(System.String __Name)
        {
			object[] results = this.Invoke("Create", new object[] {__Name});
			return ((ModelUser)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __Name)
        {
			this.Invoke("Delete", new object[] {__Name});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(ModelUser _ModelUser)
        {
			this.Invoke("UpdateObject", new object[] {_ModelUser});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(ModelUser _ModelUser)
        {
			this.Invoke("CreateObject", new object[] {_ModelUser});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(ModelUser _ModelUser)
        {
			this.Invoke("DeleteObject", new object[] {_ModelUser});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Undo", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void Undo()
        {
			this.Invoke("Undo", new object[] {});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Redo", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Redo()
        {
			this.Invoke("Redo", new object[] {});
			return;
        }
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByOwner", new object[] {_ModelUser});
			return ((ModelUserCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByOwnerPaged", new object[] {_ModelUser,PagingStart,PagingCount});
			return ((ModelUserCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByOwnerCount", new object[] {_ModelUser});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetOwner(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetOwner", new object[] {_ModelUser});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetOwner(ModelUser _ModelUser, Services.Packages.Security.ModelUser _Owner)
		{
			this.Invoke("GetOwner", new object[] {_ModelUser});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByName", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserCollection SearchByName(System.String Name ) {
			object[] results = this.Invoke("SearchByName", new object[] {Name});
			return ((ModelUserCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNamePaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserCollection SearchByNamePaged(System.String Name , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("SearchByNamePaged", new object[] {Name,PagingStart,PagingCount});
			return ((ModelUserCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByNameCount(System.String Name ) {
			object[] results = this.Invoke("SearchByNameCount", new object[] {Name});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByEmail", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserCollection SearchByEmail(System.String Email ) {
			object[] results = this.Invoke("SearchByEmail", new object[] {Email});
			return ((ModelUserCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByEmailPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserCollection SearchByEmailPaged(System.String Email , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("SearchByEmailPaged", new object[] {Email,PagingStart,PagingCount});
			return ((ModelUserCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByEmailCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByEmailCount(System.String Email ) {
			object[] results = this.Invoke("SearchByEmailCount", new object[] {Email});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchEnabledByNameAndEmail", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserCollection SearchEnabledByNameAndEmail(System.String Name, System.String Email, System.Boolean Enabled ) {
			object[] results = this.Invoke("SearchEnabledByNameAndEmail", new object[] {Name, Email, Enabled});
			return ((ModelUserCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchEnabledByNameAndEmailPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserCollection SearchEnabledByNameAndEmailPaged(System.String Name, System.String Email, System.Boolean Enabled , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("SearchEnabledByNameAndEmailPaged", new object[] {Name, Email, Enabled,PagingStart,PagingCount});
			return ((ModelUserCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchEnabledByNameAndEmailCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchEnabledByNameAndEmailCount(System.String Name, System.String Email, System.Boolean Enabled ) {
			object[] results = this.Invoke("SearchEnabledByNameAndEmailCount", new object[] {Name, Email, Enabled});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPackageOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.PackageCollection GetPackageOwning(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetPackageOwning", new object[] {_ModelUser});
			return ((Services.Packages.PackageCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPackageOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPackageOwning(ModelUser _ModelUser, Services.Packages.PackageCollection _PackageOwning)
		{
			this.Invoke("GetPackageOwning", new object[] {_ModelUser});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetApiKeyOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.ApiKeyCollection GetApiKeyOwning(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetApiKeyOwning", new object[] {_ModelUser});
			return ((Services.Packages.ApiKeyCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetApiKeyOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetApiKeyOwning(ModelUser _ModelUser, Services.Packages.ApiKeyCollection _ApiKeyOwning)
		{
			this.Invoke("GetApiKeyOwning", new object[] {_ModelUser});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetApplicationExceptionOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Log.ApplicationExceptionCollection GetApplicationExceptionOwning(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetApplicationExceptionOwning", new object[] {_ModelUser});
			return ((Services.Packages.Log.ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetApplicationExceptionOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetApplicationExceptionOwning(ModelUser _ModelUser, Services.Packages.Log.ApplicationExceptionCollection _ApplicationExceptionOwning)
		{
			this.Invoke("GetApplicationExceptionOwning", new object[] {_ModelUser});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetCustomerOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.CustomerCollection GetCustomerOwning(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetCustomerOwning", new object[] {_ModelUser});
			return ((Services.Packages.CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetCustomerOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetCustomerOwning(ModelUser _ModelUser, Services.Packages.CustomerCollection _CustomerOwning)
		{
			this.Invoke("GetCustomerOwning", new object[] {_ModelUser});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetCustomerUserEntries", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.CustomerUserEntryCollection GetCustomerUserEntries(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetCustomerUserEntries", new object[] {_ModelUser});
			return ((Services.Packages.CustomerUserEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetCustomerUserEntries", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetCustomerUserEntries(ModelUser _ModelUser, Services.Packages.CustomerUserEntryCollection _CustomerUserEntries)
		{
			this.Invoke("GetCustomerUserEntries", new object[] {_ModelUser});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetCustomerUserEntryOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.CustomerUserEntryCollection GetCustomerUserEntryOwning(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetCustomerUserEntryOwning", new object[] {_ModelUser});
			return ((Services.Packages.CustomerUserEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetCustomerUserEntryOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetCustomerUserEntryOwning(ModelUser _ModelUser, Services.Packages.CustomerUserEntryCollection _CustomerUserEntryOwning)
		{
			this.Invoke("GetCustomerUserEntryOwning", new object[] {_ModelUser});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPurchases", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.PurchaseCollection GetPurchases(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetPurchases", new object[] {_ModelUser});
			return ((Services.Packages.PurchaseCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPurchases", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPurchases(ModelUser _ModelUser, Services.Packages.PurchaseCollection _Purchases)
		{
			this.Invoke("GetPurchases", new object[] {_ModelUser});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPurchaseOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.PurchaseCollection GetPurchaseOwning(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetPurchaseOwning", new object[] {_ModelUser});
			return ((Services.Packages.PurchaseCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPurchaseOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPurchaseOwning(ModelUser _ModelUser, Services.Packages.PurchaseCollection _PurchaseOwning)
		{
			this.Invoke("GetPurchaseOwning", new object[] {_ModelUser});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPurchaseLineOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.PurchaseLineCollection GetPurchaseLineOwning(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetPurchaseLineOwning", new object[] {_ModelUser});
			return ((Services.Packages.PurchaseLineCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPurchaseLineOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPurchaseLineOwning(ModelUser _ModelUser, Services.Packages.PurchaseLineCollection _PurchaseLineOwning)
		{
			this.Invoke("GetPurchaseLineOwning", new object[] {_ModelUser});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetModelUserOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUserCollection GetModelUserOwning(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetModelUserOwning", new object[] {_ModelUser});
			return ((Services.Packages.Security.ModelUserCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetModelUserOwning", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetModelUserOwning(ModelUser _ModelUser, Services.Packages.Security.ModelUserCollection _ModelUserOwning)
		{
			this.Invoke("GetModelUserOwning", new object[] {_ModelUser});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetSessions", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelSessionCollection GetSessions(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetSessions", new object[] {_ModelUser});
			return ((Services.Packages.Security.ModelSessionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetSessions", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetSessions(ModelUser _ModelUser, Services.Packages.Security.ModelSessionCollection _Sessions)
		{
			this.Invoke("GetSessions", new object[] {_ModelUser});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetRights", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUserRightsCollection GetRights(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetRights", new object[] {_ModelUser});
			return ((Services.Packages.Security.ModelUserRightsCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetRights", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetRights(ModelUser _ModelUser, Services.Packages.Security.ModelUserRightsCollection _Rights)
		{
			this.Invoke("GetRights", new object[] {_ModelUser});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPackageACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.PackageAccessControlListCollection GetPackageACLs(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetPackageACLs", new object[] {_ModelUser});
			return ((Services.Packages.Security.PackageAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPackageACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPackageACLs(ModelUser _ModelUser, Services.Packages.Security.PackageAccessControlListCollection _PackageACLs)
		{
			this.Invoke("GetPackageACLs", new object[] {_ModelUser});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetApiKeyACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ApiKeyAccessControlListCollection GetApiKeyACLs(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetApiKeyACLs", new object[] {_ModelUser});
			return ((Services.Packages.Security.ApiKeyAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetApiKeyACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetApiKeyACLs(ModelUser _ModelUser, Services.Packages.Security.ApiKeyAccessControlListCollection _ApiKeyACLs)
		{
			this.Invoke("GetApiKeyACLs", new object[] {_ModelUser});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetApplicationExceptionACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection GetApplicationExceptionACLs(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetApplicationExceptionACLs", new object[] {_ModelUser});
			return ((Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetApplicationExceptionACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetApplicationExceptionACLs(ModelUser _ModelUser, Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection _ApplicationExceptionACLs)
		{
			this.Invoke("GetApplicationExceptionACLs", new object[] {_ModelUser});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetCustomerACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.CustomerAccessControlListCollection GetCustomerACLs(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetCustomerACLs", new object[] {_ModelUser});
			return ((Services.Packages.Security.CustomerAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetCustomerACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetCustomerACLs(ModelUser _ModelUser, Services.Packages.Security.CustomerAccessControlListCollection _CustomerACLs)
		{
			this.Invoke("GetCustomerACLs", new object[] {_ModelUser});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetCustomerUserEntryACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.CustomerUserEntryAccessControlListCollection GetCustomerUserEntryACLs(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetCustomerUserEntryACLs", new object[] {_ModelUser});
			return ((Services.Packages.Security.CustomerUserEntryAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetCustomerUserEntryACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetCustomerUserEntryACLs(ModelUser _ModelUser, Services.Packages.Security.CustomerUserEntryAccessControlListCollection _CustomerUserEntryACLs)
		{
			this.Invoke("GetCustomerUserEntryACLs", new object[] {_ModelUser});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPurchaseACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.PurchaseAccessControlListCollection GetPurchaseACLs(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetPurchaseACLs", new object[] {_ModelUser});
			return ((Services.Packages.Security.PurchaseAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPurchaseACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPurchaseACLs(ModelUser _ModelUser, Services.Packages.Security.PurchaseAccessControlListCollection _PurchaseACLs)
		{
			this.Invoke("GetPurchaseACLs", new object[] {_ModelUser});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPurchaseLineACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.PurchaseLineAccessControlListCollection GetPurchaseLineACLs(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetPurchaseLineACLs", new object[] {_ModelUser});
			return ((Services.Packages.Security.PurchaseLineAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPurchaseLineACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPurchaseLineACLs(ModelUser _ModelUser, Services.Packages.Security.PurchaseLineAccessControlListCollection _PurchaseLineACLs)
		{
			this.Invoke("GetPurchaseLineACLs", new object[] {_ModelUser});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetModelUserACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.Security.ModelUserAccessControlListCollection GetModelUserACLs(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetModelUserACLs", new object[] {_ModelUser});
			return ((Services.Packages.Security.Security.ModelUserAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetModelUserACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetModelUserACLs(ModelUser _ModelUser, Services.Packages.Security.Security.ModelUserAccessControlListCollection _ModelUserACLs)
		{
			this.Invoke("GetModelUserACLs", new object[] {_ModelUser});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.Security.ModelUserAccessControlListCollection GetACLs(ModelUser _ModelUser)
		{
			object[] results = this.Invoke("GetACLs", new object[] {_ModelUser});
			return ((Services.Packages.Security.Security.ModelUserAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACLs(ModelUser _ModelUser, Services.Packages.Security.Security.ModelUserAccessControlListCollection _ACLs)
		{
			this.Invoke("GetACLs", new object[] {_ModelUser});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages.Security
