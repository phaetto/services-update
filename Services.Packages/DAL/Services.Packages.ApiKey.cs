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

namespace Services.Packages
{
	/// <summary>
    /// Defines the contract for the ApiKey class
    /// </summary>
    [ComVisible(true)]
    [Guid("4adb23b3-e1c5-2644-93d3-3db9103bcc13")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IApiKey
	{
		bool Exists { get; }
		System.Guid Id { get; set; }
		System.String CompanyInfo { get; set; }
		System.DateTime IssueDate { get; set; }
		System.DateTime FromDate { get; set; }
		System.DateTime ToDate { get; set; }
		System.Boolean IsTest { get; set; }
		Services.Packages.Customer Customer { get; set; }
		Services.Packages.Security.ModelUser Owner { get; set; }
		Services.Packages.PackageCollection PackagesUploaded { get; set; }
		Services.Packages.PackageCollection SearchByPackageNameForApiKey(System.String PackageName);
		Services.Packages.Log.ApplicationExceptionCollection ApplicationExceptionsLogged { get; set; }
		Services.Packages.Log.ApplicationExceptionCollection SearchByNameOnApiKey(System.String Message);
		Services.Packages.Log.ApplicationExceptionCollection SearchByNameSolvedOnApiKey(System.String Message, System.Boolean IsSolved);
		Services.Packages.PurchaseCollection Orders { get; set; }
		Services.Packages.Security.ApiKeyAccessControlListCollection ACLs { get; set; }
		Services.Packages.Security.ApiKeyAccessControlListCollection GetACLs(System.String UserName);

		void Read(System.Guid __Id);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(ApiKey _object);
		void CopyWithKeysTo(ApiKey _object);
		void CopyFrom(ApiKey _object);
		void CopyTo(ApiKey _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.ApiKey type.
    /// </summary>
    [ComVisible(true)]
    [Guid("42c1ed37-5f5b-56d8-6bbc-83f6788b3519")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IApiKeyService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(ApiKey _ApiKey);
		[OperationContract]
        ApiKey Read(System.Guid __Id);
        [OperationContract]
        ApiKey Reload(ApiKey _ApiKey);
        [OperationContract]
        ApiKey Create(System.Guid __Id);
        [OperationContract]
        void Delete(System.Guid __Id);
        [OperationContract]
        void UpdateObject(ApiKey _ApiKey);
        [OperationContract]
        void CreateObject(ApiKey _ApiKey);
        [OperationContract]
        void DeleteObject(ApiKey _ApiKey);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		ApiKeyCollection GetByCustomer(Services.Packages.Customer _Customer);
		[OperationContract]
		ApiKeyCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByCustomerCount(Services.Packages.Customer _Customer);
		[OperationContract]
		Services.Packages.Customer GetCustomer(ApiKey _ApiKey);
		[OperationContract]
		void SetCustomer(ApiKey _ApiKey, Services.Packages.Customer _Customer);
		[OperationContract]
		ApiKeyCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		ApiKeyCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		Services.Packages.Security.ModelUser GetOwner(ApiKey _ApiKey);
		[OperationContract]
		void SetOwner(ApiKey _ApiKey, Services.Packages.Security.ModelUser _Owner);
		[OperationContract]
		ApiKeyCollection SearchByCompanyInfo(System.String CompanyInfo );
		[OperationContract]
		ApiKeyCollection SearchByCompanyInfoPaged(System.String CompanyInfo , long PagingStart, long PagingCount);
		[OperationContract]
		long SearchByCompanyInfoCount(System.String CompanyInfo );
		[OperationContract]
		ApiKeyCollection SearchByCompanyInfoOnCustomer(System.String CompanyInfo, Services.Packages.Customer _Customer);
		[OperationContract]
		ApiKeyCollection SearchByCompanyInfoOnCustomerPaged(System.String CompanyInfo, Services.Packages.Customer _Customer, long PagingStart, long PagingCount);
		[OperationContract]
		long SearchByCompanyInfoOnCustomerCount(System.String CompanyInfo, Services.Packages.Customer _Customer);
		[OperationContract]
		Services.Packages.PackageCollection GetPackagesUploaded(ApiKey _ApiKey);
		[OperationContract]
		void SetPackagesUploaded(ApiKey _ApiKey, Services.Packages.PackageCollection _PackagesUploaded);
		[OperationContract]
		Services.Packages.Log.ApplicationExceptionCollection GetApplicationExceptionsLogged(ApiKey _ApiKey);
		[OperationContract]
		void SetApplicationExceptionsLogged(ApiKey _ApiKey, Services.Packages.Log.ApplicationExceptionCollection _ApplicationExceptionsLogged);
		[OperationContract]
		Services.Packages.PurchaseCollection GetOrders(ApiKey _ApiKey);
		[OperationContract]
		void SetOrders(ApiKey _ApiKey, Services.Packages.PurchaseCollection _Orders);
		[OperationContract]
		Services.Packages.Security.ApiKeyAccessControlListCollection GetACLs(ApiKey _ApiKey);
		[OperationContract]
		void SetACLs(ApiKey _ApiKey, Services.Packages.Security.ApiKeyAccessControlListCollection _ACLs);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.ApiKey type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("21926e2c-92d1-a4a2-1f28-bfc8571914b9")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class ApiKeyService : IApiKeyService
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
        public bool Exists(ApiKey _ApiKey)
        {
			return _ApiKey.Exists;
        }
		
		[WebMethod]
		public ApiKey Read(System.Guid __Id)
		{
			return new ApiKey(__Id);
		}
		
		[WebMethod]
        public ApiKey Reload(ApiKey _ApiKey)
        {
			_ApiKey.Reload();
			return _ApiKey;
        }
		
		[WebMethod]
        public ApiKey Create(System.Guid __Id)
        {
			return ApiKey.CreateApiKey(__Id);
        }
        
        [WebMethod]
        public void Delete(System.Guid __Id)
        {
			ApiKey.DeleteApiKey(__Id);
        }
        
        [WebMethod]
        public void UpdateObject(ApiKey _ApiKey)
        {
			_ApiKey.Update();
        }
		
		[WebMethod]
        public void CreateObject(ApiKey _ApiKey)
        {
			_ApiKey.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ApiKey _ApiKey)
        {
			_ApiKey.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			ApiKey.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			ApiKey.Redo();
        }
		[WebMethod]
		public ApiKeyCollection GetByCustomer(Services.Packages.Customer _Customer)
		{
			return ApiKey.GetByCustomer( _Customer);
		}
		[WebMethod]
		public ApiKeyCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
		{
			return ApiKey.GetByCustomerPaged( _Customer, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByCustomerCount(Services.Packages.Customer _Customer)
		{
			return ApiKey.GetByCustomerCount( _Customer);
		}
		[WebMethod]
		public Services.Packages.Customer GetCustomer(ApiKey _ApiKey)
		{
			_ApiKey.Reload();
			return _ApiKey.Customer;
		}
		[WebMethod]
		public void SetCustomer(ApiKey _ApiKey, Services.Packages.Customer _Customer)
		{
			_ApiKey.Reload();
			_ApiKey.Customer = _Customer;
			_ApiKey.Update();
		}
		[WebMethod]
		public ApiKeyCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ApiKey.GetByOwner( _ModelUser);
		}
		[WebMethod]
		public ApiKeyCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ApiKey.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ApiKey.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(ApiKey _ApiKey)
		{
			_ApiKey.Reload();
			return _ApiKey.Owner;
		}
		[WebMethod]
		public void SetOwner(ApiKey _ApiKey, Services.Packages.Security.ModelUser _Owner)
		{
			_ApiKey.Reload();
			_ApiKey.Owner = _Owner;
			_ApiKey.Update();
		}
		[WebMethod]
		public ApiKeyCollection SearchByCompanyInfo(System.String CompanyInfo )
		{
			return ApiKey.SearchByCompanyInfo(CompanyInfo );
		}
		[WebMethod]
		public ApiKeyCollection SearchByCompanyInfoPaged(System.String CompanyInfo , long PagingStart, long PagingCount)
		{
			return ApiKey.SearchByCompanyInfoPaged(CompanyInfo , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByCompanyInfoCount(System.String CompanyInfo )
		{
			return ApiKey.SearchByCompanyInfoCount(CompanyInfo );
		}
		[WebMethod]
		public ApiKeyCollection SearchByCompanyInfoOnCustomer(System.String CompanyInfo, Services.Packages.Customer _Customer)
		{
			return ApiKey.SearchByCompanyInfoOnCustomer(CompanyInfo,  _Customer);
		}
		[WebMethod]
		public ApiKeyCollection SearchByCompanyInfoOnCustomerPaged(System.String CompanyInfo, Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
		{
			return ApiKey.SearchByCompanyInfoOnCustomerPaged(CompanyInfo,  _Customer, PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByCompanyInfoOnCustomerCount(System.String CompanyInfo, Services.Packages.Customer _Customer)
		{
			return ApiKey.SearchByCompanyInfoOnCustomerCount(CompanyInfo,  _Customer);
		}
		[WebMethod]
		public Services.Packages.PackageCollection GetPackagesUploaded(ApiKey _ApiKey)
		{
			_ApiKey.Reload();
			return _ApiKey.PackagesUploaded;
		}
		[WebMethod]
		public void SetPackagesUploaded(ApiKey _ApiKey, Services.Packages.PackageCollection _PackagesUploaded)
		{
			_ApiKey.Reload();
			_ApiKey.PackagesUploaded = _PackagesUploaded;
			_ApiKey.Update();
		}
		[WebMethod]
		public Services.Packages.Log.ApplicationExceptionCollection GetApplicationExceptionsLogged(ApiKey _ApiKey)
		{
			_ApiKey.Reload();
			return _ApiKey.ApplicationExceptionsLogged;
		}
		[WebMethod]
		public void SetApplicationExceptionsLogged(ApiKey _ApiKey, Services.Packages.Log.ApplicationExceptionCollection _ApplicationExceptionsLogged)
		{
			_ApiKey.Reload();
			_ApiKey.ApplicationExceptionsLogged = _ApplicationExceptionsLogged;
			_ApiKey.Update();
		}
		[WebMethod]
		public Services.Packages.PurchaseCollection GetOrders(ApiKey _ApiKey)
		{
			_ApiKey.Reload();
			return _ApiKey.Orders;
		}
		[WebMethod]
		public void SetOrders(ApiKey _ApiKey, Services.Packages.PurchaseCollection _Orders)
		{
			_ApiKey.Reload();
			_ApiKey.Orders = _Orders;
			_ApiKey.Update();
		}
		[WebMethod]
		public Services.Packages.Security.ApiKeyAccessControlListCollection GetACLs(ApiKey _ApiKey)
		{
			_ApiKey.Reload();
			return _ApiKey.ACLs;
		}
		[WebMethod]
		public void SetACLs(ApiKey _ApiKey, Services.Packages.Security.ApiKeyAccessControlListCollection _ACLs)
		{
			_ApiKey.Reload();
			_ApiKey.ACLs = _ACLs;
			_ApiKey.Update();
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.ApiKey model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("e2926583-8f11-53ca-4b85-df085d4dad07")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class ApiKey : IApiKey, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<IApiKeyService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<IApiKeyService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<IApiKeyService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.ApiKey"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.ApiKey"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.ApiKey.ProviderType");
				
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


		System.Guid _Id;
		
		// Key member
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Guid Id
		{
            get
            {
                return _Id;
            }
            set
            {
				if (_Id != value)
					__hasBeenReadOnce = false;
                _Id = value;
            }
		}

		System.String _CompanyInfo;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String CompanyInfo
		{
            get
            {
                return _CompanyInfo;
            }
            set
            {
                _CompanyInfo = value;
            }
		}

		System.DateTime _IssueDate;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.DateTime IssueDate
		{
            get
            {
                return _IssueDate;
            }
            set
            {
                _IssueDate = value;
            }
		}

		System.DateTime _FromDate;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.DateTime FromDate
		{
            get
            {
                return _FromDate;
            }
            set
            {
                _FromDate = value;
            }
		}

		System.DateTime _ToDate;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.DateTime ToDate
		{
            get
            {
                return _ToDate;
            }
            set
            {
                _ToDate = value;
            }
		}

		System.Boolean _IsTest;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Boolean IsTest
		{
            get
            {
                return _IsTest;
            }
            set
            {
                _IsTest = value;
            }
		}

		bool _CustomerIsLoaded = false;
		Services.Packages.Customer _Customer;
		System.String _Customer_Name; 
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Customer Customer
		{
            get
            {
				if (!_CustomerIsLoaded)
				{
					_Customer = new Services.Packages.Customer(_Customer_Name);
					if (_Customer.Exists)
						_CustomerIsLoaded = true;
					else _Customer = null;
				}
                return _Customer;
            }
            set
            {
                _Customer = value;
                _CustomerIsLoaded = true;
                if (_Customer != null)
                {
					if (_Customer.Exists)
					{
						_Customer_Name = _Customer.Name;
						
					}
					else
					{
						_Customer = null;
					}
				}
            }
		}
		
		public static Services.Packages.Customer GetCustomer(ApiKey _ApiKey)
		{
			return _ApiKey.Customer;
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
		
		public static Services.Packages.Security.ModelUser GetOwner(ApiKey _ApiKey)
		{
			return _ApiKey.Owner;
		}

		public static ApiKeyCollection GetByCustomer(Services.Packages.Customer _Customer)
        {
			ApiKeyCollection _ApiKeyCollection = new ApiKeyCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeGetByCu", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Name;
				if (_Customer != null) {
				param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 256);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Customer.Name);
				} else {
				param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", DBNull.Value);
				}
				command.Parameters.Add(param_Name);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					ApiKey o = new ApiKey();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				o._CompanyInfo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyInfo"], typeof(System.String));
				o._IssueDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IssueDate"], typeof(System.DateTime));
				o._FromDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FromDate"], typeof(System.DateTime));
				o._ToDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ToDate"], typeof(System.DateTime));
				o._IsTest = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsTest"], typeof(System.Boolean));
				o._CustomerIsLoaded = false; if (dr["Customer_Name"] == DBNull.Value) { o._Customer = null; o._CustomerIsLoaded = true; }  else o._Customer_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Customer_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApiKeyCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ApiKeyCollection;
        }
        
        public static ApiKeyCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
        {
			ApiKeyCollection _ApiKeyCollection = new ApiKeyCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeGetByCuPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Name;
				if (_Customer != null) {
				param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 256);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Customer.Name);
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
					ApiKey o = new ApiKey();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				o._CompanyInfo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyInfo"], typeof(System.String));
				o._IssueDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IssueDate"], typeof(System.DateTime));
				o._FromDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FromDate"], typeof(System.DateTime));
				o._ToDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ToDate"], typeof(System.DateTime));
				o._IsTest = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsTest"], typeof(System.Boolean));
				o._CustomerIsLoaded = false; if (dr["Customer_Name"] == DBNull.Value) { o._Customer = null; o._CustomerIsLoaded = true; }  else o._Customer_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Customer_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApiKeyCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ApiKeyCollection;
        }
        
        public static long GetByCustomerCount(Services.Packages.Customer _Customer)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeGetByCuCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Name;
				if (_Customer != null) {
				param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 256);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Customer.Name);
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

		public static ApiKeyCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
        {
			ApiKeyCollection _ApiKeyCollection = new ApiKeyCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeGetByOw", dbconn);
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
					ApiKey o = new ApiKey();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				o._CompanyInfo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyInfo"], typeof(System.String));
				o._IssueDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IssueDate"], typeof(System.DateTime));
				o._FromDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FromDate"], typeof(System.DateTime));
				o._ToDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ToDate"], typeof(System.DateTime));
				o._IsTest = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsTest"], typeof(System.Boolean));
				o._CustomerIsLoaded = false; if (dr["Customer_Name"] == DBNull.Value) { o._Customer = null; o._CustomerIsLoaded = true; }  else o._Customer_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Customer_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApiKeyCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ApiKeyCollection;
        }
        
        public static ApiKeyCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			ApiKeyCollection _ApiKeyCollection = new ApiKeyCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeGetByOwPaged", dbconn);
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
					ApiKey o = new ApiKey();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				o._CompanyInfo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyInfo"], typeof(System.String));
				o._IssueDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IssueDate"], typeof(System.DateTime));
				o._FromDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FromDate"], typeof(System.DateTime));
				o._ToDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ToDate"], typeof(System.DateTime));
				o._IsTest = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsTest"], typeof(System.Boolean));
				o._CustomerIsLoaded = false; if (dr["Customer_Name"] == DBNull.Value) { o._Customer = null; o._CustomerIsLoaded = true; }  else o._Customer_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Customer_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApiKeyCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ApiKeyCollection;
        }
        
        public static long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeGetByOwCount", dbconn);
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

		public static ApiKeyCollection SearchByCompanyInfo(System.String _CompanyInfo)
        {
			ApiKeyCollection _ApiKeyCollection = new ApiKeyCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeSeByCoIn", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _CompanyInfo = ClassConnectionProvider.Escape(_CompanyInfo);
				
                
                DbParameter param_CompanyInfo = ClassConnectionProvider.GetDatabaseParameter("CompanyInfo", typeof(System.String), -1);
				param_CompanyInfo.Value = ClassConnectionProvider.FromValueToSqlModelType(_CompanyInfo);
				command.Parameters.Add(param_CompanyInfo);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					ApiKey o = new ApiKey();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				o._CompanyInfo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyInfo"], typeof(System.String));
				o._IssueDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IssueDate"], typeof(System.DateTime));
				o._FromDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FromDate"], typeof(System.DateTime));
				o._ToDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ToDate"], typeof(System.DateTime));
				o._IsTest = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsTest"], typeof(System.Boolean));
				o._CustomerIsLoaded = false; if (dr["Customer_Name"] == DBNull.Value) { o._Customer = null; o._CustomerIsLoaded = true; }  else o._Customer_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Customer_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApiKeyCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ApiKeyCollection;
        }
        
        public static ApiKeyCollection SearchByCompanyInfoPaged(System.String _CompanyInfo, long PagingStart, long PagingCount)
        {
			ApiKeyCollection _ApiKeyCollection = new ApiKeyCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeSeByCoInPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _CompanyInfo = ClassConnectionProvider.Escape(_CompanyInfo);
				
                
                DbParameter param_CompanyInfo = ClassConnectionProvider.GetDatabaseParameter("CompanyInfo", typeof(System.String), -1);
				param_CompanyInfo.Value = ClassConnectionProvider.FromValueToSqlModelType(_CompanyInfo);
				command.Parameters.Add(param_CompanyInfo);
				
                
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
					ApiKey o = new ApiKey();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				o._CompanyInfo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyInfo"], typeof(System.String));
				o._IssueDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IssueDate"], typeof(System.DateTime));
				o._FromDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FromDate"], typeof(System.DateTime));
				o._ToDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ToDate"], typeof(System.DateTime));
				o._IsTest = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsTest"], typeof(System.Boolean));
				o._CustomerIsLoaded = false; if (dr["Customer_Name"] == DBNull.Value) { o._Customer = null; o._CustomerIsLoaded = true; }  else o._Customer_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Customer_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApiKeyCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ApiKeyCollection;
        }
        
        public static long SearchByCompanyInfoCount(System.String _CompanyInfo)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeSeByCoInCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _CompanyInfo = ClassConnectionProvider.Escape(_CompanyInfo);
				
                
                DbParameter param_CompanyInfo = ClassConnectionProvider.GetDatabaseParameter("CompanyInfo", typeof(System.String), -1);
				param_CompanyInfo.Value = ClassConnectionProvider.FromValueToSqlModelType(_CompanyInfo);
				command.Parameters.Add(param_CompanyInfo);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		public static ApiKeyCollection SearchByCompanyInfoOnCustomer(System.String _CompanyInfo, Services.Packages.Customer _Customer)
        {
			ApiKeyCollection _ApiKeyCollection = new ApiKeyCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeSeByCoInOnCu", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _CompanyInfo = ClassConnectionProvider.Escape(_CompanyInfo);
				
                
                DbParameter param_CompanyInfo = ClassConnectionProvider.GetDatabaseParameter("CompanyInfo", typeof(System.String), -1);
				param_CompanyInfo.Value = ClassConnectionProvider.FromValueToSqlModelType(_CompanyInfo);
				command.Parameters.Add(param_CompanyInfo);
				DbParameter param_Customer_Name;
				if (_Customer != null) {
				param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("CuNa", typeof(System.String), 256);
				param_Customer_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Customer.Name);
				} else {
				param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("CuNa", DBNull.Value);
				}
				command.Parameters.Add(param_Customer_Name);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					ApiKey o = new ApiKey();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				o._CompanyInfo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyInfo"], typeof(System.String));
				o._IssueDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IssueDate"], typeof(System.DateTime));
				o._FromDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FromDate"], typeof(System.DateTime));
				o._ToDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ToDate"], typeof(System.DateTime));
				o._IsTest = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsTest"], typeof(System.Boolean));
				o._CustomerIsLoaded = false; if (dr["Customer_Name"] == DBNull.Value) { o._Customer = null; o._CustomerIsLoaded = true; }  else o._Customer_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Customer_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApiKeyCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ApiKeyCollection;
        }
        
        public static ApiKeyCollection SearchByCompanyInfoOnCustomerPaged(System.String _CompanyInfo, Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
        {
			ApiKeyCollection _ApiKeyCollection = new ApiKeyCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeSeByCoInOnCuPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _CompanyInfo = ClassConnectionProvider.Escape(_CompanyInfo);
				
                
                DbParameter param_CompanyInfo = ClassConnectionProvider.GetDatabaseParameter("CompanyInfo", typeof(System.String), -1);
				param_CompanyInfo.Value = ClassConnectionProvider.FromValueToSqlModelType(_CompanyInfo);
				command.Parameters.Add(param_CompanyInfo);
				DbParameter param_Customer_Name;
				if (_Customer != null) {
				param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("CuNa", typeof(System.String), 256);
				param_Customer_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Customer.Name);
				} else {
				param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("CuNa", DBNull.Value);
				}
				command.Parameters.Add(param_Customer_Name);
				
                
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
					ApiKey o = new ApiKey();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				o._CompanyInfo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyInfo"], typeof(System.String));
				o._IssueDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IssueDate"], typeof(System.DateTime));
				o._FromDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FromDate"], typeof(System.DateTime));
				o._ToDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ToDate"], typeof(System.DateTime));
				o._IsTest = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsTest"], typeof(System.Boolean));
				o._CustomerIsLoaded = false; if (dr["Customer_Name"] == DBNull.Value) { o._Customer = null; o._CustomerIsLoaded = true; }  else o._Customer_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Customer_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApiKeyCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ApiKeyCollection;
        }
        
        public static long SearchByCompanyInfoOnCustomerCount(System.String _CompanyInfo, Services.Packages.Customer _Customer)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeSeByCoInOnCuCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _CompanyInfo = ClassConnectionProvider.Escape(_CompanyInfo);
				
                
                DbParameter param_CompanyInfo = ClassConnectionProvider.GetDatabaseParameter("CompanyInfo", typeof(System.String), -1);
				param_CompanyInfo.Value = ClassConnectionProvider.FromValueToSqlModelType(_CompanyInfo);
				command.Parameters.Add(param_CompanyInfo);
				DbParameter param_Customer_Name;
				if (_Customer != null) {
				param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("CuNa", typeof(System.String), 256);
				param_Customer_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Customer.Name);
				} else {
				param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("CuNa", DBNull.Value);
				}
				command.Parameters.Add(param_Customer_Name);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		Services.Packages.PackageCollection _PackagesUploaded;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.PackageCollection PackagesUploaded
		{
            get
            {
				if (_PackagesUploaded == null)
					_PackagesUploaded = Services.Packages.Package.GetByApiKey(this);
				
				return _PackagesUploaded;
            }
            set
            {
				if (this.Exists)
				{
					if (_PackagesUploaded != null)
					{
						for(int n = 0; n < _PackagesUploaded.Count; ++n)
						{
							_PackagesUploaded[n].ApiKey = null;
							_PackagesUploaded[n].Update();
						}
					}
	                
					_PackagesUploaded = value;
					
					if (_PackagesUploaded != null)
					{
						for(int n = 0; n < _PackagesUploaded.Count; ++n)
						{
							_PackagesUploaded[n].ApiKey = this;
							_PackagesUploaded[n].Create();
						}
					}
				}
				else
				{
					_PackagesUploaded = value;
				}
            }
		}
		
		public void ReloadPackagesUploaded()
		{
			_PackagesUploaded = Services.Packages.Package.GetByApiKey(this);
		}

		public Services.Packages.PackageCollection SearchByPackageNameForApiKey(System.String PackageName)
		{
			return Services.Packages.Package.SearchByPackageNameForApiKey(PackageName,  this);
		}

		Services.Packages.Log.ApplicationExceptionCollection _ApplicationExceptionsLogged;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Log.ApplicationExceptionCollection ApplicationExceptionsLogged
		{
            get
            {
				if (_ApplicationExceptionsLogged == null)
					_ApplicationExceptionsLogged = Services.Packages.Log.ApplicationException.GetByApiKey(this);
				
				return _ApplicationExceptionsLogged;
            }
            set
            {
				if (this.Exists)
				{
					if (_ApplicationExceptionsLogged != null)
					{
						for(int n = 0; n < _ApplicationExceptionsLogged.Count; ++n)
						{
							_ApplicationExceptionsLogged[n].ApiKey = null;
							_ApplicationExceptionsLogged[n].Update();
						}
					}
	                
					_ApplicationExceptionsLogged = value;
					
					if (_ApplicationExceptionsLogged != null)
					{
						for(int n = 0; n < _ApplicationExceptionsLogged.Count; ++n)
						{
							_ApplicationExceptionsLogged[n].ApiKey = this;
							_ApplicationExceptionsLogged[n].Create();
						}
					}
				}
				else
				{
					_ApplicationExceptionsLogged = value;
				}
            }
		}
		
		public void ReloadApplicationExceptionsLogged()
		{
			_ApplicationExceptionsLogged = Services.Packages.Log.ApplicationException.GetByApiKey(this);
		}

		public Services.Packages.Log.ApplicationExceptionCollection SearchByNameOnApiKey(System.String Message)
		{
			return Services.Packages.Log.ApplicationException.SearchByNameOnApiKey(Message,  this);
		}

		public Services.Packages.Log.ApplicationExceptionCollection SearchByNameSolvedOnApiKey(System.String Message, System.Boolean IsSolved)
		{
			return Services.Packages.Log.ApplicationException.SearchByNameSolvedOnApiKey(Message, IsSolved,  this);
		}

		Services.Packages.PurchaseCollection _Orders;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.PurchaseCollection Orders
		{
            get
            {
				if (_Orders == null)
					_Orders = Services.Packages.Purchase.GetByApiKey(this);
				
				return _Orders;
            }
            set
            {
				if (this.Exists)
				{
					if (_Orders != null)
					{
						for(int n = 0; n < _Orders.Count; ++n)
						{
							_Orders[n].ApiKey = null;
							_Orders[n].Update();
						}
					}
	                
					_Orders = value;
					
					if (_Orders != null)
					{
						for(int n = 0; n < _Orders.Count; ++n)
						{
							_Orders[n].ApiKey = this;
							_Orders[n].Create();
						}
					}
				}
				else
				{
					_Orders = value;
				}
            }
		}
		
		public void ReloadOrders()
		{
			_Orders = Services.Packages.Purchase.GetByApiKey(this);
		}

		Services.Packages.Security.ApiKeyAccessControlListCollection _ACLs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.ApiKeyAccessControlListCollection ACLs
		{
            get
            {
				if (_ACLs == null)
					_ACLs = Services.Packages.Security.ApiKeyAccessControlList.GetByApiKey(this);
				
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
							_ACLs[n].ApiKey = null;
							_ACLs[n].Update();
						}
					}
	                
					_ACLs = value;
					
					if (_ACLs != null)
					{
						for(int n = 0; n < _ACLs.Count; ++n)
						{
							_ACLs[n].ApiKey = this;
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
			_ACLs = Services.Packages.Security.ApiKeyAccessControlList.GetByApiKey(this);
		}

		public Services.Packages.Security.ApiKeyAccessControlListCollection GetACLs(System.String UserName)
		{
			return Services.Packages.Security.ApiKeyAccessControlList.GetACLs(UserName,  this);
		}

		public bool Exists
        {
            get {
				if (!__hasBeenReadOnce)
					Exist();
				
				return __databaseState == RowState.Initialized;
			}
        }
        
        public ApiKey() {}
        
        public ApiKey(System.Guid __Id)
        {
			Read(__Id);
        }
        
        #region CRUD
        
        void Exist()
        {
			// sql read - should be changed to specific exist implementation
			using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
			{
				dbconn.Open();
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApKeRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
				DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Guid), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				
                
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
        
        public void Read(System.Guid __Id)
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].Read(__Id);
					return;
				}

                // Get a service via an algorithm
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "ApKe");
                // Perfect for read operations, but not for write
                // scalingServices[nextIndex].Read(__Id);
				// return;

				throw new NotImplementedException();
            }

            try
            {
				// sql read
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApKeRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					_Id = __Id;
				DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Guid), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(__Id);
				command.Parameters.Add(param_Id);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				_CompanyInfo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyInfo"], typeof(System.String));
				_IssueDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IssueDate"], typeof(System.DateTime));
				_FromDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FromDate"], typeof(System.DateTime));
				_ToDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ToDate"], typeof(System.DateTime));
				_IsTest = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsTest"], typeof(System.Boolean));
				_CustomerIsLoaded = false; if (dr["Customer_Name"] == DBNull.Value) { _Customer = null; _CustomerIsLoaded = true; }  else _Customer_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Customer_Name"], typeof(System.String));
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
                            failoverServices[n].Read(__Id);
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "ApKe");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApKeRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Guid), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				_CompanyInfo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyInfo"], typeof(System.String));
				_IssueDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IssueDate"], typeof(System.DateTime));
				_FromDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FromDate"], typeof(System.DateTime));
				_ToDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ToDate"], typeof(System.DateTime));
				_IsTest = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsTest"], typeof(System.Boolean));
				_CustomerIsLoaded = false; if (dr["Customer_Name"] == DBNull.Value) { _Customer = null; _CustomerIsLoaded = true; }  else _Customer_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Customer_Name"], typeof(System.String));
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApKeCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Guid), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				DbParameter param_CompanyInfo = ClassConnectionProvider.GetDatabaseParameter("CompanyInfo", typeof(System.String), 1024);
				param_CompanyInfo.Value = ClassConnectionProvider.FromValueToSqlModelType(_CompanyInfo);
				command.Parameters.Add(param_CompanyInfo);
				DbParameter param_IssueDate = ClassConnectionProvider.GetDatabaseParameter("IssueDate", typeof(System.DateTime), -1);
				param_IssueDate.Value = ClassConnectionProvider.FromValueToSqlModelType(_IssueDate);
				command.Parameters.Add(param_IssueDate);
				DbParameter param_FromDate = ClassConnectionProvider.GetDatabaseParameter("FromDate", typeof(System.DateTime), -1);
				param_FromDate.Value = ClassConnectionProvider.FromValueToSqlModelType(_FromDate);
				command.Parameters.Add(param_FromDate);
				DbParameter param_ToDate = ClassConnectionProvider.GetDatabaseParameter("ToDate", typeof(System.DateTime), -1);
				param_ToDate.Value = ClassConnectionProvider.FromValueToSqlModelType(_ToDate);
				command.Parameters.Add(param_ToDate);
				DbParameter param_IsTest = ClassConnectionProvider.GetDatabaseParameter("IsTest", typeof(System.Boolean), -1);
				param_IsTest.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsTest);
				command.Parameters.Add(param_IsTest);
				DbParameter param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("Customer_Name", typeof(System.String), 256);
				param_Customer_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Customer_Name);
				if (_Customer == null) param_Customer_Name.Value = DBNull.Value;
				else param_Customer_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Customer.Name);
				command.Parameters.Add(param_Customer_Name);
				DbParameter param_Owner_Name = ClassConnectionProvider.GetDatabaseParameter("Owner_Name", typeof(System.String), 128);
				param_Owner_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Owner_Name);
				if (_Owner == null) param_Owner_Name.Value = DBNull.Value;
				else param_Owner_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Owner.Name);
				command.Parameters.Add(param_Owner_Name);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				_CompanyInfo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyInfo"], typeof(System.String));
				_IssueDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IssueDate"], typeof(System.DateTime));
				_FromDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FromDate"], typeof(System.DateTime));
				_ToDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ToDate"], typeof(System.DateTime));
				_IsTest = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsTest"], typeof(System.Boolean));
				_CustomerIsLoaded = false; if (dr["Customer_Name"] == DBNull.Value) { _Customer = null; _CustomerIsLoaded = true; }  else _Customer_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Customer_Name"], typeof(System.String));
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
        
        static public ApiKey CreateApiKey(System.Guid __Id)
        {
            ApiKey o = new ApiKey(__Id);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApKeUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Guid), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				DbParameter param_CompanyInfo = ClassConnectionProvider.GetDatabaseParameter("CompanyInfo", typeof(System.String), 1024);
				param_CompanyInfo.Value = ClassConnectionProvider.FromValueToSqlModelType(_CompanyInfo);
				command.Parameters.Add(param_CompanyInfo);
				DbParameter param_IssueDate = ClassConnectionProvider.GetDatabaseParameter("IssueDate", typeof(System.DateTime), -1);
				param_IssueDate.Value = ClassConnectionProvider.FromValueToSqlModelType(_IssueDate);
				command.Parameters.Add(param_IssueDate);
				DbParameter param_FromDate = ClassConnectionProvider.GetDatabaseParameter("FromDate", typeof(System.DateTime), -1);
				param_FromDate.Value = ClassConnectionProvider.FromValueToSqlModelType(_FromDate);
				command.Parameters.Add(param_FromDate);
				DbParameter param_ToDate = ClassConnectionProvider.GetDatabaseParameter("ToDate", typeof(System.DateTime), -1);
				param_ToDate.Value = ClassConnectionProvider.FromValueToSqlModelType(_ToDate);
				command.Parameters.Add(param_ToDate);
				DbParameter param_IsTest = ClassConnectionProvider.GetDatabaseParameter("IsTest", typeof(System.Boolean), -1);
				param_IsTest.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsTest);
				command.Parameters.Add(param_IsTest);
				DbParameter param_CustomerHasChanged = ClassConnectionProvider.GetDatabaseParameter("CustomerHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_CustomerIsLoaded));
				command.Parameters.Add(param_CustomerHasChanged);
				DbParameter param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("Customer_Name", typeof(System.String), 256);
				param_Customer_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Customer_Name);
				if (_Customer == null) param_Customer_Name.Value = DBNull.Value;
				else param_Customer_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Customer.Name);
				command.Parameters.Add(param_Customer_Name);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApKeDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Guid), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				
				
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
        
        static public void DeleteApiKey(System.Guid __Id)
        {
            ApiKey o = new ApiKey(__Id);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(ApiKey _object)
        {
			_Customer = null;
			_CustomerIsLoaded = false;
			_Owner = null;
			_OwnerIsLoaded = false;
			_Id = _object._Id;
			_CompanyInfo = _object._CompanyInfo;
			_IssueDate = _object._IssueDate;
			_FromDate = _object._FromDate;
			_ToDate = _object._ToDate;
			_IsTest = _object._IsTest;
			
        }
        
        public void CopyWithKeysTo(ApiKey _object)
        {
			_object._Customer = null;
			_object._CustomerIsLoaded = false;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Id = _Id;
			_object._CompanyInfo = _CompanyInfo;
			_object._IssueDate = _IssueDate;
			_object._FromDate = _FromDate;
			_object._ToDate = _ToDate;
			_object._IsTest = _IsTest;
			
        }
        
        static public void CopyWithKeysObject(ApiKey _objectFrom, ApiKey _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(ApiKey _object)
        {
			_Customer = null;
			_CustomerIsLoaded = false;
			_Owner = null;
			_OwnerIsLoaded = false;
			_CompanyInfo = _object._CompanyInfo;
			_IssueDate = _object._IssueDate;
			_FromDate = _object._FromDate;
			_ToDate = _object._ToDate;
			_IsTest = _object._IsTest;
			
        }
        
        public void CopyTo(ApiKey _object)
        {
			_object._Customer = null;
			_object._CustomerIsLoaded = false;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._CompanyInfo = _CompanyInfo;
			_object._IssueDate = _IssueDate;
			_object._FromDate = _FromDate;
			_object._ToDate = _ToDate;
			_object._IsTest = _IsTest;
			
        }
        
        static public void CopyObject(ApiKey _objectFrom, ApiKey _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(ApiKey).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(ApiKey).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(ApiKey _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			ApiKeyUndoRedoCollection allUndidAndNotRedoneEntries = ApiKeyUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			ApiKeyUndoRedo _urobject = new ApiKeyUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.Customer_Name = _object._Customer_Name;
			_urobject.Owner_Name = _object._Owner_Name;
			_urobject.Id = _object._Id;
			_urobject.CompanyInfo = _object._CompanyInfo;
			_urobject.IssueDate = _object._IssueDate;
			_urobject.FromDate = _object._FromDate;
			_urobject.ToDate = _object._ToDate;
			_urobject.IsTest = _object._IsTest;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(ApiKey).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = ApiKeyUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				ApiKeyUndoRedoCollection allOldUndoEntries = ApiKeyUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			ApiKeyUndoRedoCollection firstUndoEntries = ApiKeyUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			ApiKeyUndoRedo _urobject = firstUndoEntries[0];
			
			ApiKey _object = new ApiKey();
			_object._Customer = null;
			_object._CustomerIsLoaded = false;
			_object._Customer_Name = _urobject.Customer_Name;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Owner_Name = _urobject.Owner_Name;
			_object._Id = _urobject.Id;
			_object._CompanyInfo = _urobject.CompanyInfo;
			_object._IssueDate = _urobject.IssueDate;
			_object._FromDate = _urobject.FromDate;
			_object._ToDate = _urobject.ToDate;
			_object._IsTest = _urobject.IsTest;
			

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
			ApiKeyUndoRedoCollection firstEntryToRedoEntries = ApiKeyUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			ApiKeyUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			ApiKey _object = new ApiKey();
			_object._Customer = null;
			_object._CustomerIsLoaded = false;
			_object._Customer_Name = _urobject.Customer_Name;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Owner_Name = _urobject.Owner_Name;
			_object._Id = _urobject.Id;
			_object._CompanyInfo = _urobject.CompanyInfo;
			_object._IssueDate = _urobject.IssueDate;
			_object._FromDate = _urobject.FromDate;
			_object._ToDate = _urobject.ToDate;
			_object._IsTest = _urobject.IsTest;
			

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
    /// Defines the contract for the ApiKeyCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("a18c239e-aaa9-a541-4b1d-2233a010fe52")]
    public interface IApiKeyCollection : IEnumerable<ApiKey>
    {
        int IndexOf(ApiKey item);
        void Insert(int index, ApiKey item);
        void RemoveAt(int index);
        ApiKey this[int index] { get; set; }
        void Add(ApiKey item);
        void Clear();
        bool Contains(ApiKey item);
        void CopyTo(ApiKey[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(ApiKey item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.ApiKey
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("1373caa7-52f8-9c08-a33e-d64bb39a46d1")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class ApiKeyCollection : IApiKeyCollection, IList<ApiKey>, IHierarchicalEnumerable
    {
        List<ApiKey> _list = new List<ApiKey>();
        
        public static implicit operator List<ApiKey>(ApiKeyCollection collection)
        {
            return collection._list;
        }

        #region IList<ApiKey> Members

        public int IndexOf(ApiKey item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, ApiKey item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public ApiKey this[int index]
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

        #region ICollection<ApiKey> Members

        public void Add(ApiKey item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(ApiKey item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(ApiKey[] array, int arrayIndex)
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

        public bool Remove(ApiKey item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<ApiKey> Members

        public IEnumerator<ApiKey> GetEnumerator()
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
	/// that share Services.Packages.ApiKey objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Web.ApiKeyWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class ApiKeyWebService : WebService, IApiKeyService
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
        public bool Exists(ApiKey _ApiKey)
        {
			return _ApiKey.Exists;
        }
		
		[WebMethod]
		public ApiKey Read(System.Guid __Id)
		{
			return new ApiKey(__Id);
		}
		
		[WebMethod]
        public ApiKey Reload(ApiKey _ApiKey)
        {
			_ApiKey.Reload();
			return _ApiKey;
        }
		
		[WebMethod]
        public ApiKey Create(System.Guid __Id)
        {
			return ApiKey.CreateApiKey(__Id);
        }
        
        [WebMethod]
        public void Delete(System.Guid __Id)
        {
			ApiKey.DeleteApiKey(__Id);
        }
        
        [WebMethod]
        public void UpdateObject(ApiKey _ApiKey)
        {
			_ApiKey.Update();
        }
		
		[WebMethod]
        public void CreateObject(ApiKey _ApiKey)
        {
			_ApiKey.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ApiKey _ApiKey)
        {
			_ApiKey.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			ApiKey.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			ApiKey.Redo();
        }
		[WebMethod]
		public ApiKeyCollection GetByCustomer(Services.Packages.Customer _Customer)
		{
			return ApiKey.GetByCustomer( _Customer);
		}
		[WebMethod]
		public ApiKeyCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
		{
			return ApiKey.GetByCustomerPaged( _Customer, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByCustomerCount(Services.Packages.Customer _Customer)
		{
			return ApiKey.GetByCustomerCount( _Customer);
		}
		[WebMethod]
		public Services.Packages.Customer GetCustomer(ApiKey _ApiKey)
		{
			_ApiKey.Reload();
			return _ApiKey.Customer;
		}
		[WebMethod]
		public void SetCustomer(ApiKey _ApiKey, Services.Packages.Customer _Customer)
		{
			_ApiKey.Reload();
			_ApiKey.Customer = _Customer;
			_ApiKey.Update();
		}
		[WebMethod]
		public ApiKeyCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ApiKey.GetByOwner( _ModelUser);
		}
		[WebMethod]
		public ApiKeyCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ApiKey.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ApiKey.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(ApiKey _ApiKey)
		{
			_ApiKey.Reload();
			return _ApiKey.Owner;
		}
		[WebMethod]
		public void SetOwner(ApiKey _ApiKey, Services.Packages.Security.ModelUser _Owner)
		{
			_ApiKey.Reload();
			_ApiKey.Owner = _Owner;
			_ApiKey.Update();
		}
		[WebMethod]
		public ApiKeyCollection SearchByCompanyInfo(System.String CompanyInfo )
		{
			return ApiKey.SearchByCompanyInfo(CompanyInfo );
		}
		[WebMethod]
		public ApiKeyCollection SearchByCompanyInfoPaged(System.String CompanyInfo , long PagingStart, long PagingCount)
		{
			return ApiKey.SearchByCompanyInfoPaged(CompanyInfo , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByCompanyInfoCount(System.String CompanyInfo )
		{
			return ApiKey.SearchByCompanyInfoCount(CompanyInfo );
		}
		[WebMethod]
		public ApiKeyCollection SearchByCompanyInfoOnCustomer(System.String CompanyInfo, Services.Packages.Customer _Customer)
		{
			return ApiKey.SearchByCompanyInfoOnCustomer(CompanyInfo,  _Customer);
		}
		[WebMethod]
		public ApiKeyCollection SearchByCompanyInfoOnCustomerPaged(System.String CompanyInfo, Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
		{
			return ApiKey.SearchByCompanyInfoOnCustomerPaged(CompanyInfo,  _Customer, PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByCompanyInfoOnCustomerCount(System.String CompanyInfo, Services.Packages.Customer _Customer)
		{
			return ApiKey.SearchByCompanyInfoOnCustomerCount(CompanyInfo,  _Customer);
		}
		[WebMethod]
		public Services.Packages.PackageCollection GetPackagesUploaded(ApiKey _ApiKey)
		{
			_ApiKey.Reload();
			return _ApiKey.PackagesUploaded;
		}
		[WebMethod]
		public void SetPackagesUploaded(ApiKey _ApiKey, Services.Packages.PackageCollection _PackagesUploaded)
		{
			_ApiKey.Reload();
			_ApiKey.PackagesUploaded = _PackagesUploaded;
			_ApiKey.Update();
		}
		[WebMethod]
		public Services.Packages.Log.ApplicationExceptionCollection GetApplicationExceptionsLogged(ApiKey _ApiKey)
		{
			_ApiKey.Reload();
			return _ApiKey.ApplicationExceptionsLogged;
		}
		[WebMethod]
		public void SetApplicationExceptionsLogged(ApiKey _ApiKey, Services.Packages.Log.ApplicationExceptionCollection _ApplicationExceptionsLogged)
		{
			_ApiKey.Reload();
			_ApiKey.ApplicationExceptionsLogged = _ApplicationExceptionsLogged;
			_ApiKey.Update();
		}
		[WebMethod]
		public Services.Packages.PurchaseCollection GetOrders(ApiKey _ApiKey)
		{
			_ApiKey.Reload();
			return _ApiKey.Orders;
		}
		[WebMethod]
		public void SetOrders(ApiKey _ApiKey, Services.Packages.PurchaseCollection _Orders)
		{
			_ApiKey.Reload();
			_ApiKey.Orders = _Orders;
			_ApiKey.Update();
		}
		[WebMethod]
		public Services.Packages.Security.ApiKeyAccessControlListCollection GetACLs(ApiKey _ApiKey)
		{
			_ApiKey.Reload();
			return _ApiKey.ACLs;
		}
		[WebMethod]
		public void SetACLs(ApiKey _ApiKey, Services.Packages.Security.ApiKeyAccessControlListCollection _ACLs)
		{
			_ApiKey.Reload();
			_ApiKey.ACLs = _ACLs;
			_ApiKey.Update();
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="ApiKeyWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("342ab77b-738c-d810-23ed-97f36c97b33a")]
    sealed public class ApiKeyWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IApiKeyService
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
		public ApiKeyWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public ApiKeyWebServiceClient()
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
		public bool Exists(ApiKey _ApiKey)
        {
			object[] results = this.Invoke("Exists", new object[] {_ApiKey});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKey Read(System.Guid __Id)
		{
			object[] results = this.Invoke("Read", new object[] {__Id});
			return ((ApiKey)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKey Reload(ApiKey _ApiKey)
        {
			object[] results = this.Invoke("Reload", new object[] {_ApiKey});
			return ((ApiKey)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKey Create(System.Guid __Id)
        {
			object[] results = this.Invoke("Create", new object[] {__Id});
			return ((ApiKey)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.Guid __Id)
        {
			this.Invoke("Delete", new object[] {__Id});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(ApiKey _ApiKey)
        {
			this.Invoke("UpdateObject", new object[] {_ApiKey});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(ApiKey _ApiKey)
        {
			this.Invoke("CreateObject", new object[] {_ApiKey});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(ApiKey _ApiKey)
        {
			this.Invoke("DeleteObject", new object[] {_ApiKey});
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
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyCollection GetByCustomer(Services.Packages.Customer _Customer) {
			object[] results = this.Invoke("GetByCustomer", new object[] {_Customer});
			return ((ApiKeyCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByCustomerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByCustomerPaged", new object[] {_Customer,PagingStart,PagingCount});
			return ((ApiKeyCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByCustomerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByCustomerCount(Services.Packages.Customer _Customer) {
			object[] results = this.Invoke("GetByCustomerCount", new object[] {_Customer});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Customer GetCustomer(ApiKey _ApiKey)
		{
			object[] results = this.Invoke("GetCustomer", new object[] {_ApiKey});
			return ((Services.Packages.Customer)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetCustomer(ApiKey _ApiKey, Services.Packages.Customer _Customer)
		{
			this.Invoke("GetCustomer", new object[] {_ApiKey});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByOwner", new object[] {_ModelUser});
			return ((ApiKeyCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByOwnerPaged", new object[] {_ModelUser,PagingStart,PagingCount});
			return ((ApiKeyCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByOwnerCount", new object[] {_ModelUser});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetOwner(ApiKey _ApiKey)
		{
			object[] results = this.Invoke("GetOwner", new object[] {_ApiKey});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetOwner(ApiKey _ApiKey, Services.Packages.Security.ModelUser _Owner)
		{
			this.Invoke("GetOwner", new object[] {_ApiKey});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByCompanyInfo", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyCollection SearchByCompanyInfo(System.String CompanyInfo ) {
			object[] results = this.Invoke("SearchByCompanyInfo", new object[] {CompanyInfo});
			return ((ApiKeyCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByCompanyInfoPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyCollection SearchByCompanyInfoPaged(System.String CompanyInfo , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("SearchByCompanyInfoPaged", new object[] {CompanyInfo,PagingStart,PagingCount});
			return ((ApiKeyCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByCompanyInfoCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByCompanyInfoCount(System.String CompanyInfo ) {
			object[] results = this.Invoke("SearchByCompanyInfoCount", new object[] {CompanyInfo});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByCompanyInfoOnCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyCollection SearchByCompanyInfoOnCustomer(System.String CompanyInfo, Services.Packages.Customer _Customer) {
			object[] results = this.Invoke("SearchByCompanyInfoOnCustomer", new object[] {CompanyInfo, _Customer});
			return ((ApiKeyCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByCompanyInfoOnCustomerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyCollection SearchByCompanyInfoOnCustomerPaged(System.String CompanyInfo, Services.Packages.Customer _Customer, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("SearchByCompanyInfoOnCustomerPaged", new object[] {CompanyInfo, _Customer,PagingStart,PagingCount});
			return ((ApiKeyCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByCompanyInfoOnCustomerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByCompanyInfoOnCustomerCount(System.String CompanyInfo, Services.Packages.Customer _Customer) {
			object[] results = this.Invoke("SearchByCompanyInfoOnCustomerCount", new object[] {CompanyInfo, _Customer});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPackagesUploaded", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.PackageCollection GetPackagesUploaded(ApiKey _ApiKey)
		{
			object[] results = this.Invoke("GetPackagesUploaded", new object[] {_ApiKey});
			return ((Services.Packages.PackageCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPackagesUploaded", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPackagesUploaded(ApiKey _ApiKey, Services.Packages.PackageCollection _PackagesUploaded)
		{
			this.Invoke("GetPackagesUploaded", new object[] {_ApiKey});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetApplicationExceptionsLogged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Log.ApplicationExceptionCollection GetApplicationExceptionsLogged(ApiKey _ApiKey)
		{
			object[] results = this.Invoke("GetApplicationExceptionsLogged", new object[] {_ApiKey});
			return ((Services.Packages.Log.ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetApplicationExceptionsLogged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetApplicationExceptionsLogged(ApiKey _ApiKey, Services.Packages.Log.ApplicationExceptionCollection _ApplicationExceptionsLogged)
		{
			this.Invoke("GetApplicationExceptionsLogged", new object[] {_ApiKey});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetOrders", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.PurchaseCollection GetOrders(ApiKey _ApiKey)
		{
			object[] results = this.Invoke("GetOrders", new object[] {_ApiKey});
			return ((Services.Packages.PurchaseCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetOrders", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetOrders(ApiKey _ApiKey, Services.Packages.PurchaseCollection _Orders)
		{
			this.Invoke("GetOrders", new object[] {_ApiKey});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ApiKeyAccessControlListCollection GetACLs(ApiKey _ApiKey)
		{
			object[] results = this.Invoke("GetACLs", new object[] {_ApiKey});
			return ((Services.Packages.Security.ApiKeyAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACLs(ApiKey _ApiKey, Services.Packages.Security.ApiKeyAccessControlListCollection _ACLs)
		{
			this.Invoke("GetACLs", new object[] {_ApiKey});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages
