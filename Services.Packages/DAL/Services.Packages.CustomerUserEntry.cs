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
    /// Defines the contract for the CustomerUserEntry class
    /// </summary>
    [ComVisible(true)]
    [Guid("c4fcb0ae-0645-c705-3de3-ca5d1814336f")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface ICustomerUserEntry
	{
		bool Exists { get; }
		System.Int32 Id { get; set; }
		Services.Packages.Security.ModelUser UserLogin { get; set; }
		Services.Packages.Customer Customer { get; set; }
		Services.Packages.Security.ModelUser Owner { get; set; }
		Services.Packages.Security.CustomerUserEntryAccessControlListCollection ACLs { get; set; }
		Services.Packages.Security.CustomerUserEntryAccessControlListCollection GetACLs(System.String UserName);

		void Read(System.Int32 __Id);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(CustomerUserEntry _object);
		void CopyWithKeysTo(CustomerUserEntry _object);
		void CopyFrom(CustomerUserEntry _object);
		void CopyTo(CustomerUserEntry _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.CustomerUserEntry type.
    /// </summary>
    [ComVisible(true)]
    [Guid("0dcc8990-f39c-7831-c62c-e9d5ffa22a05")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface ICustomerUserEntryService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(CustomerUserEntry _CustomerUserEntry);
		[OperationContract]
        CustomerUserEntry Read(System.Int32 __Id);
        [OperationContract]
        CustomerUserEntry Reload(CustomerUserEntry _CustomerUserEntry);
        [OperationContract]
        CustomerUserEntry Create(System.Int32 __Id);
        [OperationContract]
        void Delete(System.Int32 __Id);
        [OperationContract]
        void UpdateObject(CustomerUserEntry _CustomerUserEntry);
        [OperationContract]
        void CreateObject(CustomerUserEntry _CustomerUserEntry);
        [OperationContract]
        void DeleteObject(CustomerUserEntry _CustomerUserEntry);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		CustomerUserEntryCollection GetByUserLogin(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		CustomerUserEntryCollection GetByUserLoginPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByUserLoginCount(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		Services.Packages.Security.ModelUser GetUserLogin(CustomerUserEntry _CustomerUserEntry);
		[OperationContract]
		void SetUserLogin(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _UserLogin);
		[OperationContract]
		CustomerUserEntryCollection GetByCustomer(Services.Packages.Customer _Customer);
		[OperationContract]
		CustomerUserEntryCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByCustomerCount(Services.Packages.Customer _Customer);
		[OperationContract]
		Services.Packages.Customer GetCustomer(CustomerUserEntry _CustomerUserEntry);
		[OperationContract]
		void SetCustomer(CustomerUserEntry _CustomerUserEntry, Services.Packages.Customer _Customer);
		[OperationContract]
		CustomerUserEntryCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		CustomerUserEntryCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		Services.Packages.Security.ModelUser GetOwner(CustomerUserEntry _CustomerUserEntry);
		[OperationContract]
		void SetOwner(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _Owner);
		[OperationContract]
		Services.Packages.Security.CustomerUserEntryAccessControlListCollection GetACLs(CustomerUserEntry _CustomerUserEntry);
		[OperationContract]
		void SetACLs(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.CustomerUserEntryAccessControlListCollection _ACLs);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.CustomerUserEntry type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("07245369-8168-04ff-71e8-398bb4e757d2")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class CustomerUserEntryService : ICustomerUserEntryService
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
        public bool Exists(CustomerUserEntry _CustomerUserEntry)
        {
			return _CustomerUserEntry.Exists;
        }
		
		[WebMethod]
		public CustomerUserEntry Read(System.Int32 __Id)
		{
			return new CustomerUserEntry(__Id);
		}
		
		[WebMethod]
        public CustomerUserEntry Reload(CustomerUserEntry _CustomerUserEntry)
        {
			_CustomerUserEntry.Reload();
			return _CustomerUserEntry;
        }
		
		[WebMethod]
        public CustomerUserEntry Create(System.Int32 __Id)
        {
			return CustomerUserEntry.CreateCustomerUserEntry(__Id);
        }
        
        [WebMethod]
        public void Delete(System.Int32 __Id)
        {
			CustomerUserEntry.DeleteCustomerUserEntry(__Id);
        }
        
        [WebMethod]
        public void UpdateObject(CustomerUserEntry _CustomerUserEntry)
        {
			_CustomerUserEntry.Update();
        }
		
		[WebMethod]
        public void CreateObject(CustomerUserEntry _CustomerUserEntry)
        {
			_CustomerUserEntry.Create();
        }
        
        [WebMethod]
        public void DeleteObject(CustomerUserEntry _CustomerUserEntry)
        {
			_CustomerUserEntry.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			CustomerUserEntry.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			CustomerUserEntry.Redo();
        }
		[WebMethod]
		public CustomerUserEntryCollection GetByUserLogin(Services.Packages.Security.ModelUser _ModelUser)
		{
			return CustomerUserEntry.GetByUserLogin( _ModelUser);
		}
		[WebMethod]
		public CustomerUserEntryCollection GetByUserLoginPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return CustomerUserEntry.GetByUserLoginPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByUserLoginCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return CustomerUserEntry.GetByUserLoginCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUserLogin(CustomerUserEntry _CustomerUserEntry)
		{
			_CustomerUserEntry.Reload();
			return _CustomerUserEntry.UserLogin;
		}
		[WebMethod]
		public void SetUserLogin(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _UserLogin)
		{
			_CustomerUserEntry.Reload();
			_CustomerUserEntry.UserLogin = _UserLogin;
			_CustomerUserEntry.Update();
		}
		[WebMethod]
		public CustomerUserEntryCollection GetByCustomer(Services.Packages.Customer _Customer)
		{
			return CustomerUserEntry.GetByCustomer( _Customer);
		}
		[WebMethod]
		public CustomerUserEntryCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
		{
			return CustomerUserEntry.GetByCustomerPaged( _Customer, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByCustomerCount(Services.Packages.Customer _Customer)
		{
			return CustomerUserEntry.GetByCustomerCount( _Customer);
		}
		[WebMethod]
		public Services.Packages.Customer GetCustomer(CustomerUserEntry _CustomerUserEntry)
		{
			_CustomerUserEntry.Reload();
			return _CustomerUserEntry.Customer;
		}
		[WebMethod]
		public void SetCustomer(CustomerUserEntry _CustomerUserEntry, Services.Packages.Customer _Customer)
		{
			_CustomerUserEntry.Reload();
			_CustomerUserEntry.Customer = _Customer;
			_CustomerUserEntry.Update();
		}
		[WebMethod]
		public CustomerUserEntryCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
		{
			return CustomerUserEntry.GetByOwner( _ModelUser);
		}
		[WebMethod]
		public CustomerUserEntryCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return CustomerUserEntry.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return CustomerUserEntry.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(CustomerUserEntry _CustomerUserEntry)
		{
			_CustomerUserEntry.Reload();
			return _CustomerUserEntry.Owner;
		}
		[WebMethod]
		public void SetOwner(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _Owner)
		{
			_CustomerUserEntry.Reload();
			_CustomerUserEntry.Owner = _Owner;
			_CustomerUserEntry.Update();
		}
		[WebMethod]
		public Services.Packages.Security.CustomerUserEntryAccessControlListCollection GetACLs(CustomerUserEntry _CustomerUserEntry)
		{
			_CustomerUserEntry.Reload();
			return _CustomerUserEntry.ACLs;
		}
		[WebMethod]
		public void SetACLs(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.CustomerUserEntryAccessControlListCollection _ACLs)
		{
			_CustomerUserEntry.Reload();
			_CustomerUserEntry.ACLs = _ACLs;
			_CustomerUserEntry.Update();
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.CustomerUserEntry model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("ee55ba1d-1d95-ba46-7f84-fd191c30c79a")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class CustomerUserEntry : ICustomerUserEntry, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<ICustomerUserEntryService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<ICustomerUserEntryService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<ICustomerUserEntryService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.CustomerUserEntry"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.CustomerUserEntry"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.CustomerUserEntry.ProviderType");
				
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


		System.Int32 _Id;
		
		// Key member
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Int32 Id
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

		bool _UserLoginIsLoaded = false;
		Services.Packages.Security.ModelUser _UserLogin;
		System.String _UserLogin_Name; 
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.ModelUser UserLogin
		{
            get
            {
				if (!_UserLoginIsLoaded)
				{
					_UserLogin = new Services.Packages.Security.ModelUser(_UserLogin_Name);
					if (_UserLogin.Exists)
						_UserLoginIsLoaded = true;
					else _UserLogin = null;
				}
                return _UserLogin;
            }
            set
            {
                _UserLogin = value;
                _UserLoginIsLoaded = true;
                if (_UserLogin != null)
                {
					if (_UserLogin.Exists)
					{
						_UserLogin_Name = _UserLogin.Name;
						
					}
					else
					{
						_UserLogin = null;
					}
				}
            }
		}
		
		public static Services.Packages.Security.ModelUser GetUserLogin(CustomerUserEntry _CustomerUserEntry)
		{
			return _CustomerUserEntry.UserLogin;
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
		
		public static Services.Packages.Customer GetCustomer(CustomerUserEntry _CustomerUserEntry)
		{
			return _CustomerUserEntry.Customer;
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
		
		public static Services.Packages.Security.ModelUser GetOwner(CustomerUserEntry _CustomerUserEntry)
		{
			return _CustomerUserEntry.Owner;
		}

		public static CustomerUserEntryCollection GetByUserLogin(Services.Packages.Security.ModelUser _ModelUser)
        {
			CustomerUserEntryCollection _CustomerUserEntryCollection = new CustomerUserEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnGetByUsLo", dbconn);
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
					CustomerUserEntry o = new CustomerUserEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserLoginIsLoaded = false; if (dr["UserLogin_Name"] == DBNull.Value) { o._UserLogin = null; o._UserLoginIsLoaded = true; }  else o._UserLogin_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserLogin_Name"], typeof(System.String));
				o._CustomerIsLoaded = false; if (dr["Customer_Name"] == DBNull.Value) { o._Customer = null; o._CustomerIsLoaded = true; }  else o._Customer_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Customer_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerUserEntryCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerUserEntryCollection;
        }
        
        public static CustomerUserEntryCollection GetByUserLoginPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			CustomerUserEntryCollection _CustomerUserEntryCollection = new CustomerUserEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnGetByUsLoPaged", dbconn);
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
					CustomerUserEntry o = new CustomerUserEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserLoginIsLoaded = false; if (dr["UserLogin_Name"] == DBNull.Value) { o._UserLogin = null; o._UserLoginIsLoaded = true; }  else o._UserLogin_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserLogin_Name"], typeof(System.String));
				o._CustomerIsLoaded = false; if (dr["Customer_Name"] == DBNull.Value) { o._Customer = null; o._CustomerIsLoaded = true; }  else o._Customer_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Customer_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerUserEntryCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerUserEntryCollection;
        }
        
        public static long GetByUserLoginCount(Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnGetByUsLoCount", dbconn);
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

		public static CustomerUserEntryCollection GetByCustomer(Services.Packages.Customer _Customer)
        {
			CustomerUserEntryCollection _CustomerUserEntryCollection = new CustomerUserEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnGetByCu", dbconn);
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
					CustomerUserEntry o = new CustomerUserEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserLoginIsLoaded = false; if (dr["UserLogin_Name"] == DBNull.Value) { o._UserLogin = null; o._UserLoginIsLoaded = true; }  else o._UserLogin_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserLogin_Name"], typeof(System.String));
				o._CustomerIsLoaded = false; if (dr["Customer_Name"] == DBNull.Value) { o._Customer = null; o._CustomerIsLoaded = true; }  else o._Customer_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Customer_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerUserEntryCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerUserEntryCollection;
        }
        
        public static CustomerUserEntryCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
        {
			CustomerUserEntryCollection _CustomerUserEntryCollection = new CustomerUserEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnGetByCuPaged", dbconn);
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
					CustomerUserEntry o = new CustomerUserEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserLoginIsLoaded = false; if (dr["UserLogin_Name"] == DBNull.Value) { o._UserLogin = null; o._UserLoginIsLoaded = true; }  else o._UserLogin_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserLogin_Name"], typeof(System.String));
				o._CustomerIsLoaded = false; if (dr["Customer_Name"] == DBNull.Value) { o._Customer = null; o._CustomerIsLoaded = true; }  else o._Customer_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Customer_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerUserEntryCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerUserEntryCollection;
        }
        
        public static long GetByCustomerCount(Services.Packages.Customer _Customer)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnGetByCuCount", dbconn);
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

		public static CustomerUserEntryCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
        {
			CustomerUserEntryCollection _CustomerUserEntryCollection = new CustomerUserEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnGetByOw", dbconn);
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
					CustomerUserEntry o = new CustomerUserEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserLoginIsLoaded = false; if (dr["UserLogin_Name"] == DBNull.Value) { o._UserLogin = null; o._UserLoginIsLoaded = true; }  else o._UserLogin_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserLogin_Name"], typeof(System.String));
				o._CustomerIsLoaded = false; if (dr["Customer_Name"] == DBNull.Value) { o._Customer = null; o._CustomerIsLoaded = true; }  else o._Customer_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Customer_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerUserEntryCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerUserEntryCollection;
        }
        
        public static CustomerUserEntryCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			CustomerUserEntryCollection _CustomerUserEntryCollection = new CustomerUserEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnGetByOwPaged", dbconn);
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
					CustomerUserEntry o = new CustomerUserEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserLoginIsLoaded = false; if (dr["UserLogin_Name"] == DBNull.Value) { o._UserLogin = null; o._UserLoginIsLoaded = true; }  else o._UserLogin_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserLogin_Name"], typeof(System.String));
				o._CustomerIsLoaded = false; if (dr["Customer_Name"] == DBNull.Value) { o._Customer = null; o._CustomerIsLoaded = true; }  else o._Customer_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Customer_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerUserEntryCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerUserEntryCollection;
        }
        
        public static long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnGetByOwCount", dbconn);
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

		Services.Packages.Security.CustomerUserEntryAccessControlListCollection _ACLs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.CustomerUserEntryAccessControlListCollection ACLs
		{
            get
            {
				if (_ACLs == null)
					_ACLs = Services.Packages.Security.CustomerUserEntryAccessControlList.GetByCustomerUserEntry(this);
				
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
							_ACLs[n].CustomerUserEntry = null;
							_ACLs[n].Update();
						}
					}
	                
					_ACLs = value;
					
					if (_ACLs != null)
					{
						for(int n = 0; n < _ACLs.Count; ++n)
						{
							_ACLs[n].CustomerUserEntry = this;
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
			_ACLs = Services.Packages.Security.CustomerUserEntryAccessControlList.GetByCustomerUserEntry(this);
		}

		public Services.Packages.Security.CustomerUserEntryAccessControlListCollection GetACLs(System.String UserName)
		{
			return Services.Packages.Security.CustomerUserEntryAccessControlList.GetACLs(UserName,  this);
		}

		public bool Exists
        {
            get {
				if (!__hasBeenReadOnce)
					Exist();
				
				return __databaseState == RowState.Initialized;
			}
        }
        
        public CustomerUserEntry() {}
        
        public CustomerUserEntry(System.Int32 __Id)
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
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUsEnRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
				DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
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
        
        public void Read(System.Int32 __Id)
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
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "CuUsEn");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUsEnRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					_Id = __Id;
				DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(__Id);
				command.Parameters.Add(param_Id);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_UserLoginIsLoaded = false; if (dr["UserLogin_Name"] == DBNull.Value) { _UserLogin = null; _UserLoginIsLoaded = true; }  else _UserLogin_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserLogin_Name"], typeof(System.String));
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "CuUsEn");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUsEnRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_UserLoginIsLoaded = false; if (dr["UserLogin_Name"] == DBNull.Value) { _UserLogin = null; _UserLoginIsLoaded = true; }  else _UserLogin_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserLogin_Name"], typeof(System.String));
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUsEnCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_UserLogin_Name = ClassConnectionProvider.GetDatabaseParameter("UserLogin_Name", typeof(System.String), 128);
				param_UserLogin_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserLogin_Name);
				if (_UserLogin == null) param_UserLogin_Name.Value = DBNull.Value;
				else param_UserLogin_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserLogin.Name);
				command.Parameters.Add(param_UserLogin_Name);
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
							_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_UserLoginIsLoaded = false; if (dr["UserLogin_Name"] == DBNull.Value) { _UserLogin = null; _UserLoginIsLoaded = true; }  else _UserLogin_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserLogin_Name"], typeof(System.String));
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
        
        static public CustomerUserEntry CreateCustomerUserEntry(System.Int32 __Id)
        {
            CustomerUserEntry o = new CustomerUserEntry(__Id);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUsEnUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				DbParameter param_UserLoginHasChanged = ClassConnectionProvider.GetDatabaseParameter("UserLoginHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_UserLoginIsLoaded));
				command.Parameters.Add(param_UserLoginHasChanged);
				DbParameter param_UserLogin_Name = ClassConnectionProvider.GetDatabaseParameter("UserLogin_Name", typeof(System.String), 128);
				param_UserLogin_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserLogin_Name);
				if (_UserLogin == null) param_UserLogin_Name.Value = DBNull.Value;
				else param_UserLogin_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserLogin.Name);
				command.Parameters.Add(param_UserLogin_Name);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUsEnDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
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
        
        static public void DeleteCustomerUserEntry(System.Int32 __Id)
        {
            CustomerUserEntry o = new CustomerUserEntry(__Id);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(CustomerUserEntry _object)
        {
			_UserLogin = null;
			_UserLoginIsLoaded = false;
			_Customer = null;
			_CustomerIsLoaded = false;
			_Owner = null;
			_OwnerIsLoaded = false;
			_Id = _object._Id;
			
        }
        
        public void CopyWithKeysTo(CustomerUserEntry _object)
        {
			_object._UserLogin = null;
			_object._UserLoginIsLoaded = false;
			_object._Customer = null;
			_object._CustomerIsLoaded = false;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Id = _Id;
			
        }
        
        static public void CopyWithKeysObject(CustomerUserEntry _objectFrom, CustomerUserEntry _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(CustomerUserEntry _object)
        {
			_UserLogin = null;
			_UserLoginIsLoaded = false;
			_Customer = null;
			_CustomerIsLoaded = false;
			_Owner = null;
			_OwnerIsLoaded = false;
			
        }
        
        public void CopyTo(CustomerUserEntry _object)
        {
			_object._UserLogin = null;
			_object._UserLoginIsLoaded = false;
			_object._Customer = null;
			_object._CustomerIsLoaded = false;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			
        }
        
        static public void CopyObject(CustomerUserEntry _objectFrom, CustomerUserEntry _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(CustomerUserEntry).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(CustomerUserEntry).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(CustomerUserEntry _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			CustomerUserEntryUndoRedoCollection allUndidAndNotRedoneEntries = CustomerUserEntryUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			CustomerUserEntryUndoRedo _urobject = new CustomerUserEntryUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.UserLogin_Name = _object._UserLogin_Name;
			_urobject.Customer_Name = _object._Customer_Name;
			_urobject.Owner_Name = _object._Owner_Name;
			_urobject.Id = _object._Id;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(CustomerUserEntry).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = CustomerUserEntryUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				CustomerUserEntryUndoRedoCollection allOldUndoEntries = CustomerUserEntryUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			CustomerUserEntryUndoRedoCollection firstUndoEntries = CustomerUserEntryUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			CustomerUserEntryUndoRedo _urobject = firstUndoEntries[0];
			
			CustomerUserEntry _object = new CustomerUserEntry();
			_object._UserLogin = null;
			_object._UserLoginIsLoaded = false;
			_object._UserLogin_Name = _urobject.UserLogin_Name;
			_object._Customer = null;
			_object._CustomerIsLoaded = false;
			_object._Customer_Name = _urobject.Customer_Name;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Owner_Name = _urobject.Owner_Name;
			_object._Id = _urobject.Id;
			

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
			CustomerUserEntryUndoRedoCollection firstEntryToRedoEntries = CustomerUserEntryUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			CustomerUserEntryUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			CustomerUserEntry _object = new CustomerUserEntry();
			_object._UserLogin = null;
			_object._UserLoginIsLoaded = false;
			_object._UserLogin_Name = _urobject.UserLogin_Name;
			_object._Customer = null;
			_object._CustomerIsLoaded = false;
			_object._Customer_Name = _urobject.Customer_Name;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Owner_Name = _urobject.Owner_Name;
			_object._Id = _urobject.Id;
			

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
    /// Defines the contract for the CustomerUserEntryCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("c4f3c4b8-2cef-0e06-8ac8-9cb4baa5c3df")]
    public interface ICustomerUserEntryCollection : IEnumerable<CustomerUserEntry>
    {
        int IndexOf(CustomerUserEntry item);
        void Insert(int index, CustomerUserEntry item);
        void RemoveAt(int index);
        CustomerUserEntry this[int index] { get; set; }
        void Add(CustomerUserEntry item);
        void Clear();
        bool Contains(CustomerUserEntry item);
        void CopyTo(CustomerUserEntry[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(CustomerUserEntry item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.CustomerUserEntry
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("45b717d4-3b4d-4c6f-0d69-87e483e6e741")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class CustomerUserEntryCollection : ICustomerUserEntryCollection, IList<CustomerUserEntry>, IHierarchicalEnumerable
    {
        List<CustomerUserEntry> _list = new List<CustomerUserEntry>();
        
        public static implicit operator List<CustomerUserEntry>(CustomerUserEntryCollection collection)
        {
            return collection._list;
        }

        #region IList<CustomerUserEntry> Members

        public int IndexOf(CustomerUserEntry item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, CustomerUserEntry item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public CustomerUserEntry this[int index]
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

        #region ICollection<CustomerUserEntry> Members

        public void Add(CustomerUserEntry item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(CustomerUserEntry item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(CustomerUserEntry[] array, int arrayIndex)
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

        public bool Remove(CustomerUserEntry item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<CustomerUserEntry> Members

        public IEnumerator<CustomerUserEntry> GetEnumerator()
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
	/// that share Services.Packages.CustomerUserEntry objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Web.CustomerUserEntryWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class CustomerUserEntryWebService : WebService, ICustomerUserEntryService
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
        public bool Exists(CustomerUserEntry _CustomerUserEntry)
        {
			return _CustomerUserEntry.Exists;
        }
		
		[WebMethod]
		public CustomerUserEntry Read(System.Int32 __Id)
		{
			return new CustomerUserEntry(__Id);
		}
		
		[WebMethod]
        public CustomerUserEntry Reload(CustomerUserEntry _CustomerUserEntry)
        {
			_CustomerUserEntry.Reload();
			return _CustomerUserEntry;
        }
		
		[WebMethod]
        public CustomerUserEntry Create(System.Int32 __Id)
        {
			return CustomerUserEntry.CreateCustomerUserEntry(__Id);
        }
        
        [WebMethod]
        public void Delete(System.Int32 __Id)
        {
			CustomerUserEntry.DeleteCustomerUserEntry(__Id);
        }
        
        [WebMethod]
        public void UpdateObject(CustomerUserEntry _CustomerUserEntry)
        {
			_CustomerUserEntry.Update();
        }
		
		[WebMethod]
        public void CreateObject(CustomerUserEntry _CustomerUserEntry)
        {
			_CustomerUserEntry.Create();
        }
        
        [WebMethod]
        public void DeleteObject(CustomerUserEntry _CustomerUserEntry)
        {
			_CustomerUserEntry.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			CustomerUserEntry.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			CustomerUserEntry.Redo();
        }
		[WebMethod]
		public CustomerUserEntryCollection GetByUserLogin(Services.Packages.Security.ModelUser _ModelUser)
		{
			return CustomerUserEntry.GetByUserLogin( _ModelUser);
		}
		[WebMethod]
		public CustomerUserEntryCollection GetByUserLoginPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return CustomerUserEntry.GetByUserLoginPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByUserLoginCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return CustomerUserEntry.GetByUserLoginCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUserLogin(CustomerUserEntry _CustomerUserEntry)
		{
			_CustomerUserEntry.Reload();
			return _CustomerUserEntry.UserLogin;
		}
		[WebMethod]
		public void SetUserLogin(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _UserLogin)
		{
			_CustomerUserEntry.Reload();
			_CustomerUserEntry.UserLogin = _UserLogin;
			_CustomerUserEntry.Update();
		}
		[WebMethod]
		public CustomerUserEntryCollection GetByCustomer(Services.Packages.Customer _Customer)
		{
			return CustomerUserEntry.GetByCustomer( _Customer);
		}
		[WebMethod]
		public CustomerUserEntryCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
		{
			return CustomerUserEntry.GetByCustomerPaged( _Customer, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByCustomerCount(Services.Packages.Customer _Customer)
		{
			return CustomerUserEntry.GetByCustomerCount( _Customer);
		}
		[WebMethod]
		public Services.Packages.Customer GetCustomer(CustomerUserEntry _CustomerUserEntry)
		{
			_CustomerUserEntry.Reload();
			return _CustomerUserEntry.Customer;
		}
		[WebMethod]
		public void SetCustomer(CustomerUserEntry _CustomerUserEntry, Services.Packages.Customer _Customer)
		{
			_CustomerUserEntry.Reload();
			_CustomerUserEntry.Customer = _Customer;
			_CustomerUserEntry.Update();
		}
		[WebMethod]
		public CustomerUserEntryCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
		{
			return CustomerUserEntry.GetByOwner( _ModelUser);
		}
		[WebMethod]
		public CustomerUserEntryCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return CustomerUserEntry.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return CustomerUserEntry.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(CustomerUserEntry _CustomerUserEntry)
		{
			_CustomerUserEntry.Reload();
			return _CustomerUserEntry.Owner;
		}
		[WebMethod]
		public void SetOwner(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _Owner)
		{
			_CustomerUserEntry.Reload();
			_CustomerUserEntry.Owner = _Owner;
			_CustomerUserEntry.Update();
		}
		[WebMethod]
		public Services.Packages.Security.CustomerUserEntryAccessControlListCollection GetACLs(CustomerUserEntry _CustomerUserEntry)
		{
			_CustomerUserEntry.Reload();
			return _CustomerUserEntry.ACLs;
		}
		[WebMethod]
		public void SetACLs(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.CustomerUserEntryAccessControlListCollection _ACLs)
		{
			_CustomerUserEntry.Reload();
			_CustomerUserEntry.ACLs = _ACLs;
			_CustomerUserEntry.Update();
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="CustomerUserEntryWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("f0d29e21-92f3-f1e2-b346-64cd819200d9")]
    sealed public class CustomerUserEntryWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, ICustomerUserEntryService
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
		public CustomerUserEntryWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public CustomerUserEntryWebServiceClient()
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
		public bool Exists(CustomerUserEntry _CustomerUserEntry)
        {
			object[] results = this.Invoke("Exists", new object[] {_CustomerUserEntry});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntry Read(System.Int32 __Id)
		{
			object[] results = this.Invoke("Read", new object[] {__Id});
			return ((CustomerUserEntry)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntry Reload(CustomerUserEntry _CustomerUserEntry)
        {
			object[] results = this.Invoke("Reload", new object[] {_CustomerUserEntry});
			return ((CustomerUserEntry)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntry Create(System.Int32 __Id)
        {
			object[] results = this.Invoke("Create", new object[] {__Id});
			return ((CustomerUserEntry)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.Int32 __Id)
        {
			this.Invoke("Delete", new object[] {__Id});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(CustomerUserEntry _CustomerUserEntry)
        {
			this.Invoke("UpdateObject", new object[] {_CustomerUserEntry});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(CustomerUserEntry _CustomerUserEntry)
        {
			this.Invoke("CreateObject", new object[] {_CustomerUserEntry});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(CustomerUserEntry _CustomerUserEntry)
        {
			this.Invoke("DeleteObject", new object[] {_CustomerUserEntry});
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
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserLogin", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryCollection GetByUserLogin(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByUserLogin", new object[] {_ModelUser});
			return ((CustomerUserEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserLoginPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryCollection GetByUserLoginPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByUserLoginPaged", new object[] {_ModelUser,PagingStart,PagingCount});
			return ((CustomerUserEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserLoginCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByUserLoginCount(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByUserLoginCount", new object[] {_ModelUser});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetUserLogin", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetUserLogin(CustomerUserEntry _CustomerUserEntry)
		{
			object[] results = this.Invoke("GetUserLogin", new object[] {_CustomerUserEntry});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetUserLogin", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetUserLogin(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _UserLogin)
		{
			this.Invoke("GetUserLogin", new object[] {_CustomerUserEntry});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryCollection GetByCustomer(Services.Packages.Customer _Customer) {
			object[] results = this.Invoke("GetByCustomer", new object[] {_Customer});
			return ((CustomerUserEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByCustomerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByCustomerPaged", new object[] {_Customer,PagingStart,PagingCount});
			return ((CustomerUserEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByCustomerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByCustomerCount(Services.Packages.Customer _Customer) {
			object[] results = this.Invoke("GetByCustomerCount", new object[] {_Customer});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Customer GetCustomer(CustomerUserEntry _CustomerUserEntry)
		{
			object[] results = this.Invoke("GetCustomer", new object[] {_CustomerUserEntry});
			return ((Services.Packages.Customer)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetCustomer(CustomerUserEntry _CustomerUserEntry, Services.Packages.Customer _Customer)
		{
			this.Invoke("GetCustomer", new object[] {_CustomerUserEntry});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByOwner", new object[] {_ModelUser});
			return ((CustomerUserEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByOwnerPaged", new object[] {_ModelUser,PagingStart,PagingCount});
			return ((CustomerUserEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByOwnerCount", new object[] {_ModelUser});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetOwner(CustomerUserEntry _CustomerUserEntry)
		{
			object[] results = this.Invoke("GetOwner", new object[] {_CustomerUserEntry});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetOwner(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.ModelUser _Owner)
		{
			this.Invoke("GetOwner", new object[] {_CustomerUserEntry});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.CustomerUserEntryAccessControlListCollection GetACLs(CustomerUserEntry _CustomerUserEntry)
		{
			object[] results = this.Invoke("GetACLs", new object[] {_CustomerUserEntry});
			return ((Services.Packages.Security.CustomerUserEntryAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACLs(CustomerUserEntry _CustomerUserEntry, Services.Packages.Security.CustomerUserEntryAccessControlListCollection _ACLs)
		{
			this.Invoke("GetACLs", new object[] {_CustomerUserEntry});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages
