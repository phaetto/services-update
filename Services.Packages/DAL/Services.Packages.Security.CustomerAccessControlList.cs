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
    /// Defines the contract for the CustomerAccessControlList class
    /// </summary>
    [ComVisible(true)]
    [Guid("d316f9fb-76c2-cffb-ca95-7ffc5dd01b4a")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface ICustomerAccessControlList
	{
		bool Exists { get; }
		System.String UserName { get; set; }
		System.String Name { get; set; }
		Services.Packages.Security.ModelUser User { get; set; }
		Services.Packages.Customer Customer { get; set; }
		Services.Packages.Security.CustomerAccessControlEntryCollection ACEs { get; set; }
		Services.Packages.Security.CustomerAccessControlEntryCollection GetEntries(System.String Descriptor);

		void Read(System.String __UserName, System.String __Name);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(CustomerAccessControlList _object);
		void CopyWithKeysTo(CustomerAccessControlList _object);
		void CopyFrom(CustomerAccessControlList _object);
		void CopyTo(CustomerAccessControlList _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.Security.CustomerAccessControlList type.
    /// </summary>
    [ComVisible(true)]
    [Guid("7e666ca5-eb23-e366-8c53-c6a5b01626aa")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface ICustomerAccessControlListService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(CustomerAccessControlList _CustomerAccessControlList);
		[OperationContract]
        CustomerAccessControlList Read(System.String __UserName, System.String __Name);
        [OperationContract]
        CustomerAccessControlList Reload(CustomerAccessControlList _CustomerAccessControlList);
        [OperationContract]
        CustomerAccessControlList Create(System.String __UserName, System.String __Name);
        [OperationContract]
        void Delete(System.String __UserName, System.String __Name);
        [OperationContract]
        void UpdateObject(CustomerAccessControlList _CustomerAccessControlList);
        [OperationContract]
        void CreateObject(CustomerAccessControlList _CustomerAccessControlList);
        [OperationContract]
        void DeleteObject(CustomerAccessControlList _CustomerAccessControlList);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		CustomerAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		CustomerAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		Services.Packages.Security.ModelUser GetUser(CustomerAccessControlList _CustomerAccessControlList);
		[OperationContract]
		void SetUser(CustomerAccessControlList _CustomerAccessControlList, Services.Packages.Security.ModelUser _User);
		[OperationContract]
		CustomerAccessControlListCollection GetByCustomer(Services.Packages.Customer _Customer);
		[OperationContract]
		CustomerAccessControlListCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByCustomerCount(Services.Packages.Customer _Customer);
		[OperationContract]
		Services.Packages.Customer GetCustomer(CustomerAccessControlList _CustomerAccessControlList);
		[OperationContract]
		void SetCustomer(CustomerAccessControlList _CustomerAccessControlList, Services.Packages.Customer _Customer);
		[OperationContract]
		CustomerAccessControlListCollection GetACLs(System.String UserName, Services.Packages.Customer _Customer);
		[OperationContract]
		CustomerAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.Customer _Customer, long PagingStart, long PagingCount);
		[OperationContract]
		long GetACLsCount(System.String UserName, Services.Packages.Customer _Customer);
		[OperationContract]
		Services.Packages.Security.CustomerAccessControlEntryCollection GetACEs(CustomerAccessControlList _CustomerAccessControlList);
		[OperationContract]
		void SetACEs(CustomerAccessControlList _CustomerAccessControlList, Services.Packages.Security.CustomerAccessControlEntryCollection _ACEs);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.Security.CustomerAccessControlList type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("e9984e21-0f9f-586d-99bf-51b931c74f64")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class CustomerAccessControlListService : ICustomerAccessControlListService
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
        public bool Exists(CustomerAccessControlList _CustomerAccessControlList)
        {
			return _CustomerAccessControlList.Exists;
        }
		
		[WebMethod]
		public CustomerAccessControlList Read(System.String __UserName, System.String __Name)
		{
			return new CustomerAccessControlList(__UserName, __Name);
		}
		
		[WebMethod]
        public CustomerAccessControlList Reload(CustomerAccessControlList _CustomerAccessControlList)
        {
			_CustomerAccessControlList.Reload();
			return _CustomerAccessControlList;
        }
		
		[WebMethod]
        public CustomerAccessControlList Create(System.String __UserName, System.String __Name)
        {
			return CustomerAccessControlList.CreateCustomerAccessControlList(__UserName, __Name);
        }
        
        [WebMethod]
        public void Delete(System.String __UserName, System.String __Name)
        {
			CustomerAccessControlList.DeleteCustomerAccessControlList(__UserName, __Name);
        }
        
        [WebMethod]
        public void UpdateObject(CustomerAccessControlList _CustomerAccessControlList)
        {
			_CustomerAccessControlList.Update();
        }
		
		[WebMethod]
        public void CreateObject(CustomerAccessControlList _CustomerAccessControlList)
        {
			_CustomerAccessControlList.Create();
        }
        
        [WebMethod]
        public void DeleteObject(CustomerAccessControlList _CustomerAccessControlList)
        {
			_CustomerAccessControlList.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			CustomerAccessControlList.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			CustomerAccessControlList.Redo();
        }
		[WebMethod]
		public CustomerAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
		{
			return CustomerAccessControlList.GetByUser( _ModelUser);
		}
		[WebMethod]
		public CustomerAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return CustomerAccessControlList.GetByUserPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return CustomerAccessControlList.GetByUserCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUser(CustomerAccessControlList _CustomerAccessControlList)
		{
			_CustomerAccessControlList.Reload();
			return _CustomerAccessControlList.User;
		}
		[WebMethod]
		public void SetUser(CustomerAccessControlList _CustomerAccessControlList, Services.Packages.Security.ModelUser _User)
		{
			_CustomerAccessControlList.Reload();
			_CustomerAccessControlList.User = _User;
			_CustomerAccessControlList.Update();
		}
		[WebMethod]
		public CustomerAccessControlListCollection GetByCustomer(Services.Packages.Customer _Customer)
		{
			return CustomerAccessControlList.GetByCustomer( _Customer);
		}
		[WebMethod]
		public CustomerAccessControlListCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
		{
			return CustomerAccessControlList.GetByCustomerPaged( _Customer, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByCustomerCount(Services.Packages.Customer _Customer)
		{
			return CustomerAccessControlList.GetByCustomerCount( _Customer);
		}
		[WebMethod]
		public Services.Packages.Customer GetCustomer(CustomerAccessControlList _CustomerAccessControlList)
		{
			_CustomerAccessControlList.Reload();
			return _CustomerAccessControlList.Customer;
		}
		[WebMethod]
		public void SetCustomer(CustomerAccessControlList _CustomerAccessControlList, Services.Packages.Customer _Customer)
		{
			_CustomerAccessControlList.Reload();
			_CustomerAccessControlList.Customer = _Customer;
			_CustomerAccessControlList.Update();
		}
		[WebMethod]
		public CustomerAccessControlListCollection GetACLs(System.String UserName, Services.Packages.Customer _Customer)
		{
			return CustomerAccessControlList.GetACLs(UserName,  _Customer);
		}
		[WebMethod]
		public CustomerAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
		{
			return CustomerAccessControlList.GetACLsPaged(UserName,  _Customer, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetACLsCount(System.String UserName, Services.Packages.Customer _Customer)
		{
			return CustomerAccessControlList.GetACLsCount(UserName,  _Customer);
		}
		[WebMethod]
		public Services.Packages.Security.CustomerAccessControlEntryCollection GetACEs(CustomerAccessControlList _CustomerAccessControlList)
		{
			_CustomerAccessControlList.Reload();
			return _CustomerAccessControlList.ACEs;
		}
		[WebMethod]
		public void SetACEs(CustomerAccessControlList _CustomerAccessControlList, Services.Packages.Security.CustomerAccessControlEntryCollection _ACEs)
		{
			_CustomerAccessControlList.Reload();
			_CustomerAccessControlList.ACEs = _ACEs;
			_CustomerAccessControlList.Update();
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.Security.CustomerAccessControlList model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("7acf8814-85d1-0f1f-9232-466fb0561fb4")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class CustomerAccessControlList : ICustomerAccessControlList, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<ICustomerAccessControlListService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<ICustomerAccessControlListService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<ICustomerAccessControlListService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.CustomerAccessControlList"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.CustomerAccessControlList"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.Security.CustomerAccessControlList.ProviderType");
				
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


		System.String _UserName;
		
		// Key member
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String UserName
		{
            get
            {
                return _UserName;
            }
            set
            {
				if (_UserName != value)
					__hasBeenReadOnce = false;
                _UserName = value;
            }
		}

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

		bool _UserIsLoaded = false;
		Services.Packages.Security.ModelUser _User;
		
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.ModelUser User
		{
            get
            {
				if (!_UserIsLoaded)
				{
					_User = new Services.Packages.Security.ModelUser(_UserName);
					if (_User.Exists)
						_UserIsLoaded = true;
					else _User = null;
				}
                return _User;
            }
            set
            {
                _User = value;
                _UserIsLoaded = true;
                if (_User != null)
                {
					if (_User.Exists)
					{
						_UserName = _User.Name;
						
					}
					else
					{
						_User = null;
					}
				}
            }
		}
		
		public static Services.Packages.Security.ModelUser GetUser(CustomerAccessControlList _CustomerAccessControlList)
		{
			return _CustomerAccessControlList.User;
		}

		bool _CustomerIsLoaded = false;
		Services.Packages.Customer _Customer;
		
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Customer Customer
		{
            get
            {
				if (!_CustomerIsLoaded)
				{
					_Customer = new Services.Packages.Customer(_Name);
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
						_Name = _Customer.Name;
						
					}
					else
					{
						_Customer = null;
					}
				}
            }
		}
		
		public static Services.Packages.Customer GetCustomer(CustomerAccessControlList _CustomerAccessControlList)
		{
			return _CustomerAccessControlList.Customer;
		}

		public static CustomerAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
        {
			CustomerAccessControlListCollection _CustomerAccessControlListCollection = new CustomerAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuAcCoLiGetByUs", dbconn);
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
					CustomerAccessControlList o = new CustomerAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._CustomerIsLoaded = false; if (dr["Name"] == DBNull.Value) { o._Customer = null; o._CustomerIsLoaded = true; }  else o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
                    _CustomerAccessControlListCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerAccessControlListCollection;
        }
        
        public static CustomerAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			CustomerAccessControlListCollection _CustomerAccessControlListCollection = new CustomerAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuAcCoLiGetByUsPaged", dbconn);
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
					CustomerAccessControlList o = new CustomerAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._CustomerIsLoaded = false; if (dr["Name"] == DBNull.Value) { o._Customer = null; o._CustomerIsLoaded = true; }  else o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
                    _CustomerAccessControlListCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerAccessControlListCollection;
        }
        
        public static long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuAcCoLiGetByUsCount", dbconn);
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

		public static CustomerAccessControlListCollection GetByCustomer(Services.Packages.Customer _Customer)
        {
			CustomerAccessControlListCollection _CustomerAccessControlListCollection = new CustomerAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuAcCoLiGetByCu", dbconn);
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
					CustomerAccessControlList o = new CustomerAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._CustomerIsLoaded = false; if (dr["Name"] == DBNull.Value) { o._Customer = null; o._CustomerIsLoaded = true; }  else o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
                    _CustomerAccessControlListCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerAccessControlListCollection;
        }
        
        public static CustomerAccessControlListCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
        {
			CustomerAccessControlListCollection _CustomerAccessControlListCollection = new CustomerAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuAcCoLiGetByCuPaged", dbconn);
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
					CustomerAccessControlList o = new CustomerAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._CustomerIsLoaded = false; if (dr["Name"] == DBNull.Value) { o._Customer = null; o._CustomerIsLoaded = true; }  else o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
                    _CustomerAccessControlListCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerAccessControlListCollection;
        }
        
        public static long GetByCustomerCount(Services.Packages.Customer _Customer)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuAcCoLiGetByCuCount", dbconn);
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

		public static CustomerAccessControlListCollection GetACLs(System.String _UserName, Services.Packages.Customer _Customer)
        {
			CustomerAccessControlListCollection _CustomerAccessControlListCollection = new CustomerAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuAcCoLiGeACLs", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UserName = ClassConnectionProvider.Escape(_UserName);
				
                
                DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), -1);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
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
					CustomerAccessControlList o = new CustomerAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._CustomerIsLoaded = false; if (dr["Name"] == DBNull.Value) { o._Customer = null; o._CustomerIsLoaded = true; }  else o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
                    _CustomerAccessControlListCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerAccessControlListCollection;
        }
        
        public static CustomerAccessControlListCollection GetACLsPaged(System.String _UserName, Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
        {
			CustomerAccessControlListCollection _CustomerAccessControlListCollection = new CustomerAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuAcCoLiGeACLsPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UserName = ClassConnectionProvider.Escape(_UserName);
				
                
                DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), -1);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
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
					CustomerAccessControlList o = new CustomerAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._CustomerIsLoaded = false; if (dr["Name"] == DBNull.Value) { o._Customer = null; o._CustomerIsLoaded = true; }  else o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
                    _CustomerAccessControlListCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerAccessControlListCollection;
        }
        
        public static long GetACLsCount(System.String _UserName, Services.Packages.Customer _Customer)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuAcCoLiGeACLsCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UserName = ClassConnectionProvider.Escape(_UserName);
				
                
                DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), -1);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
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

		Services.Packages.Security.CustomerAccessControlEntryCollection _ACEs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.CustomerAccessControlEntryCollection ACEs
		{
            get
            {
				if (_ACEs == null)
					_ACEs = Services.Packages.Security.CustomerAccessControlEntry.GetByACL(this);
				
				return _ACEs;
            }
            set
            {
				if (this.Exists)
				{
					if (_ACEs != null)
					{
						for(int n = 0; n < _ACEs.Count; ++n)
						{
							_ACEs[n].ACL = null;
							_ACEs[n].Update();
						}
					}
	                
					_ACEs = value;
					
					if (_ACEs != null)
					{
						for(int n = 0; n < _ACEs.Count; ++n)
						{
							_ACEs[n].ACL = this;
							_ACEs[n].Create();
						}
					}
				}
				else
				{
					_ACEs = value;
				}
            }
		}
		
		public void ReloadACEs()
		{
			_ACEs = Services.Packages.Security.CustomerAccessControlEntry.GetByACL(this);
		}

		public Services.Packages.Security.CustomerAccessControlEntryCollection GetEntries(System.String Descriptor)
		{
			return Services.Packages.Security.CustomerAccessControlEntry.GetEntries(Descriptor,  this);
		}

		public bool Exists
        {
            get {
				if (!__hasBeenReadOnce)
					Exist();
				
				return __databaseState == RowState.Initialized;
			}
        }
        
        public CustomerAccessControlList() {}
        
        public CustomerAccessControlList(System.String __UserName, System.String __Name)
        {
			Read(__UserName, __Name);
        }
        
        #region CRUD
        
        void Exist()
        {
			// sql read - should be changed to specific exist implementation
			using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
			{
				dbconn.Open();
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuAcCoLiRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
				DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 256);
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
        
        public void Read(System.String __UserName, System.String __Name)
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].Read(__UserName, __Name);
					return;
				}

                // Get a service via an algorithm
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "CuAcCoLi");
                // Perfect for read operations, but not for write
                // scalingServices[nextIndex].Read(__UserName, __Name);
				// return;

				throw new NotImplementedException();
            }

            try
            {
				// sql read
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuAcCoLiRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					_UserName = __UserName;
				DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(__UserName);
				command.Parameters.Add(param_UserName);
				_Name = __Name;
				DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 256);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(__Name);
				command.Parameters.Add(param_Name);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				_UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_CustomerIsLoaded = false; if (dr["Name"] == DBNull.Value) { _Customer = null; _CustomerIsLoaded = true; }  else _Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
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
                            failoverServices[n].Read(__UserName, __Name);
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "CuAcCoLi");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuAcCoLiRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 256);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				_UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_CustomerIsLoaded = false; if (dr["Name"] == DBNull.Value) { _Customer = null; _CustomerIsLoaded = true; }  else _Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuAcCoLiCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_User_Name = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_User_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				if (_User == null && _UserIsLoaded == true) param_User_Name.Value = DBNull.Value;
				command.Parameters.Add(param_User_Name);
				DbParameter param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 256);
				param_Customer_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				if (_Customer == null && _CustomerIsLoaded == true) param_Customer_Name.Value = DBNull.Value;
				command.Parameters.Add(param_Customer_Name);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				_UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_CustomerIsLoaded = false; if (dr["Name"] == DBNull.Value) { _Customer = null; _CustomerIsLoaded = true; }  else _Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
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
        
        static public CustomerAccessControlList CreateCustomerAccessControlList(System.String __UserName, System.String __Name)
        {
            CustomerAccessControlList o = new CustomerAccessControlList(__UserName, __Name);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuAcCoLiUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_UserHasChanged = ClassConnectionProvider.GetDatabaseParameter("UserHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_UserIsLoaded));
				command.Parameters.Add(param_UserHasChanged);
				DbParameter param_User_Name = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_User_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				if (_User == null && _UserIsLoaded == true) param_User_Name.Value = DBNull.Value;
				command.Parameters.Add(param_User_Name);
				DbParameter param_CustomerHasChanged = ClassConnectionProvider.GetDatabaseParameter("CustomerHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_CustomerIsLoaded));
				command.Parameters.Add(param_CustomerHasChanged);
				DbParameter param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 256);
				param_Customer_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				if (_Customer == null && _CustomerIsLoaded == true) param_Customer_Name.Value = DBNull.Value;
				command.Parameters.Add(param_Customer_Name);
				

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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuAcCoLiDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 256);
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
        
        static public void DeleteCustomerAccessControlList(System.String __UserName, System.String __Name)
        {
            CustomerAccessControlList o = new CustomerAccessControlList(__UserName, __Name);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(CustomerAccessControlList _object)
        {
			_User = null;
			_UserIsLoaded = false;
			_Customer = null;
			_CustomerIsLoaded = false;
			_UserName = _object._UserName;
			_Name = _object._Name;
			
        }
        
        public void CopyWithKeysTo(CustomerAccessControlList _object)
        {
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._Customer = null;
			_object._CustomerIsLoaded = false;
			_object._UserName = _UserName;
			_object._Name = _Name;
			
        }
        
        static public void CopyWithKeysObject(CustomerAccessControlList _objectFrom, CustomerAccessControlList _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(CustomerAccessControlList _object)
        {
			_User = null;
			_UserIsLoaded = false;
			_Customer = null;
			_CustomerIsLoaded = false;
			
        }
        
        public void CopyTo(CustomerAccessControlList _object)
        {
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._Customer = null;
			_object._CustomerIsLoaded = false;
			
        }
        
        static public void CopyObject(CustomerAccessControlList _objectFrom, CustomerAccessControlList _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(CustomerAccessControlList).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(CustomerAccessControlList).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(CustomerAccessControlList _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			CustomerAccessControlListUndoRedoCollection allUndidAndNotRedoneEntries = CustomerAccessControlListUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			CustomerAccessControlListUndoRedo _urobject = new CustomerAccessControlListUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.User_Name = _object._User_Name;
			_urobject.Customer_Name = _object._Customer_Name;
			_urobject.UserName = _object._UserName;
			_urobject.Name = _object._Name;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(CustomerAccessControlList).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = CustomerAccessControlListUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				CustomerAccessControlListUndoRedoCollection allOldUndoEntries = CustomerAccessControlListUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			CustomerAccessControlListUndoRedoCollection firstUndoEntries = CustomerAccessControlListUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			CustomerAccessControlListUndoRedo _urobject = firstUndoEntries[0];
			
			CustomerAccessControlList _object = new CustomerAccessControlList();
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._User_Name = _urobject.User_Name;
			_object._Customer = null;
			_object._CustomerIsLoaded = false;
			_object._Customer_Name = _urobject.Customer_Name;
			_object._UserName = _urobject.UserName;
			_object._Name = _urobject.Name;
			

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
			CustomerAccessControlListUndoRedoCollection firstEntryToRedoEntries = CustomerAccessControlListUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			CustomerAccessControlListUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			CustomerAccessControlList _object = new CustomerAccessControlList();
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._User_Name = _urobject.User_Name;
			_object._Customer = null;
			_object._CustomerIsLoaded = false;
			_object._Customer_Name = _urobject.Customer_Name;
			_object._UserName = _urobject.UserName;
			_object._Name = _urobject.Name;
			

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
    /// Defines the contract for the CustomerAccessControlListCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("0edad56f-3238-96ab-ff0d-e5649aacb1c4")]
    public interface ICustomerAccessControlListCollection : IEnumerable<CustomerAccessControlList>
    {
        int IndexOf(CustomerAccessControlList item);
        void Insert(int index, CustomerAccessControlList item);
        void RemoveAt(int index);
        CustomerAccessControlList this[int index] { get; set; }
        void Add(CustomerAccessControlList item);
        void Clear();
        bool Contains(CustomerAccessControlList item);
        void CopyTo(CustomerAccessControlList[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(CustomerAccessControlList item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.Security.CustomerAccessControlList
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("28906204-ac46-9bd9-2f88-566cc8fda843")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class CustomerAccessControlListCollection : ICustomerAccessControlListCollection, IList<CustomerAccessControlList>, IHierarchicalEnumerable
    {
        List<CustomerAccessControlList> _list = new List<CustomerAccessControlList>();
        
        public static implicit operator List<CustomerAccessControlList>(CustomerAccessControlListCollection collection)
        {
            return collection._list;
        }

        #region IList<CustomerAccessControlList> Members

        public int IndexOf(CustomerAccessControlList item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, CustomerAccessControlList item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public CustomerAccessControlList this[int index]
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

        #region ICollection<CustomerAccessControlList> Members

        public void Add(CustomerAccessControlList item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(CustomerAccessControlList item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(CustomerAccessControlList[] array, int arrayIndex)
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

        public bool Remove(CustomerAccessControlList item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<CustomerAccessControlList> Members

        public IEnumerator<CustomerAccessControlList> GetEnumerator()
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
	/// that share Services.Packages.Security.CustomerAccessControlList objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Security.Web.CustomerAccessControlListWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class CustomerAccessControlListWebService : WebService, ICustomerAccessControlListService
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
        public bool Exists(CustomerAccessControlList _CustomerAccessControlList)
        {
			return _CustomerAccessControlList.Exists;
        }
		
		[WebMethod]
		public CustomerAccessControlList Read(System.String __UserName, System.String __Name)
		{
			return new CustomerAccessControlList(__UserName, __Name);
		}
		
		[WebMethod]
        public CustomerAccessControlList Reload(CustomerAccessControlList _CustomerAccessControlList)
        {
			_CustomerAccessControlList.Reload();
			return _CustomerAccessControlList;
        }
		
		[WebMethod]
        public CustomerAccessControlList Create(System.String __UserName, System.String __Name)
        {
			return CustomerAccessControlList.CreateCustomerAccessControlList(__UserName, __Name);
        }
        
        [WebMethod]
        public void Delete(System.String __UserName, System.String __Name)
        {
			CustomerAccessControlList.DeleteCustomerAccessControlList(__UserName, __Name);
        }
        
        [WebMethod]
        public void UpdateObject(CustomerAccessControlList _CustomerAccessControlList)
        {
			_CustomerAccessControlList.Update();
        }
		
		[WebMethod]
        public void CreateObject(CustomerAccessControlList _CustomerAccessControlList)
        {
			_CustomerAccessControlList.Create();
        }
        
        [WebMethod]
        public void DeleteObject(CustomerAccessControlList _CustomerAccessControlList)
        {
			_CustomerAccessControlList.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			CustomerAccessControlList.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			CustomerAccessControlList.Redo();
        }
		[WebMethod]
		public CustomerAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
		{
			return CustomerAccessControlList.GetByUser( _ModelUser);
		}
		[WebMethod]
		public CustomerAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return CustomerAccessControlList.GetByUserPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return CustomerAccessControlList.GetByUserCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUser(CustomerAccessControlList _CustomerAccessControlList)
		{
			_CustomerAccessControlList.Reload();
			return _CustomerAccessControlList.User;
		}
		[WebMethod]
		public void SetUser(CustomerAccessControlList _CustomerAccessControlList, Services.Packages.Security.ModelUser _User)
		{
			_CustomerAccessControlList.Reload();
			_CustomerAccessControlList.User = _User;
			_CustomerAccessControlList.Update();
		}
		[WebMethod]
		public CustomerAccessControlListCollection GetByCustomer(Services.Packages.Customer _Customer)
		{
			return CustomerAccessControlList.GetByCustomer( _Customer);
		}
		[WebMethod]
		public CustomerAccessControlListCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
		{
			return CustomerAccessControlList.GetByCustomerPaged( _Customer, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByCustomerCount(Services.Packages.Customer _Customer)
		{
			return CustomerAccessControlList.GetByCustomerCount( _Customer);
		}
		[WebMethod]
		public Services.Packages.Customer GetCustomer(CustomerAccessControlList _CustomerAccessControlList)
		{
			_CustomerAccessControlList.Reload();
			return _CustomerAccessControlList.Customer;
		}
		[WebMethod]
		public void SetCustomer(CustomerAccessControlList _CustomerAccessControlList, Services.Packages.Customer _Customer)
		{
			_CustomerAccessControlList.Reload();
			_CustomerAccessControlList.Customer = _Customer;
			_CustomerAccessControlList.Update();
		}
		[WebMethod]
		public CustomerAccessControlListCollection GetACLs(System.String UserName, Services.Packages.Customer _Customer)
		{
			return CustomerAccessControlList.GetACLs(UserName,  _Customer);
		}
		[WebMethod]
		public CustomerAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
		{
			return CustomerAccessControlList.GetACLsPaged(UserName,  _Customer, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetACLsCount(System.String UserName, Services.Packages.Customer _Customer)
		{
			return CustomerAccessControlList.GetACLsCount(UserName,  _Customer);
		}
		[WebMethod]
		public Services.Packages.Security.CustomerAccessControlEntryCollection GetACEs(CustomerAccessControlList _CustomerAccessControlList)
		{
			_CustomerAccessControlList.Reload();
			return _CustomerAccessControlList.ACEs;
		}
		[WebMethod]
		public void SetACEs(CustomerAccessControlList _CustomerAccessControlList, Services.Packages.Security.CustomerAccessControlEntryCollection _ACEs)
		{
			_CustomerAccessControlList.Reload();
			_CustomerAccessControlList.ACEs = _ACEs;
			_CustomerAccessControlList.Update();
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="CustomerAccessControlListWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("5c4a9ca0-40ec-e22c-dc39-7bc3a0bb75e5")]
    sealed public class CustomerAccessControlListWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, ICustomerAccessControlListService
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
		public CustomerAccessControlListWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public CustomerAccessControlListWebServiceClient()
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
		public bool Exists(CustomerAccessControlList _CustomerAccessControlList)
        {
			object[] results = this.Invoke("Exists", new object[] {_CustomerAccessControlList});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerAccessControlList Read(System.String __UserName, System.String __Name)
		{
			object[] results = this.Invoke("Read", new object[] {__UserName, __Name});
			return ((CustomerAccessControlList)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerAccessControlList Reload(CustomerAccessControlList _CustomerAccessControlList)
        {
			object[] results = this.Invoke("Reload", new object[] {_CustomerAccessControlList});
			return ((CustomerAccessControlList)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerAccessControlList Create(System.String __UserName, System.String __Name)
        {
			object[] results = this.Invoke("Create", new object[] {__UserName, __Name});
			return ((CustomerAccessControlList)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __UserName, System.String __Name)
        {
			this.Invoke("Delete", new object[] {__UserName, __Name});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(CustomerAccessControlList _CustomerAccessControlList)
        {
			this.Invoke("UpdateObject", new object[] {_CustomerAccessControlList});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(CustomerAccessControlList _CustomerAccessControlList)
        {
			this.Invoke("CreateObject", new object[] {_CustomerAccessControlList});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(CustomerAccessControlList _CustomerAccessControlList)
        {
			this.Invoke("DeleteObject", new object[] {_CustomerAccessControlList});
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
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByUser", new object[] {_ModelUser});
			return ((CustomerAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByUserPaged", new object[] {_ModelUser,PagingStart,PagingCount});
			return ((CustomerAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByUserCount", new object[] {_ModelUser});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetUser(CustomerAccessControlList _CustomerAccessControlList)
		{
			object[] results = this.Invoke("GetUser", new object[] {_CustomerAccessControlList});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetUser(CustomerAccessControlList _CustomerAccessControlList, Services.Packages.Security.ModelUser _User)
		{
			this.Invoke("GetUser", new object[] {_CustomerAccessControlList});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerAccessControlListCollection GetByCustomer(Services.Packages.Customer _Customer) {
			object[] results = this.Invoke("GetByCustomer", new object[] {_Customer});
			return ((CustomerAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByCustomerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerAccessControlListCollection GetByCustomerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByCustomerPaged", new object[] {_Customer,PagingStart,PagingCount});
			return ((CustomerAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByCustomerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByCustomerCount(Services.Packages.Customer _Customer) {
			object[] results = this.Invoke("GetByCustomerCount", new object[] {_Customer});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Customer GetCustomer(CustomerAccessControlList _CustomerAccessControlList)
		{
			object[] results = this.Invoke("GetCustomer", new object[] {_CustomerAccessControlList});
			return ((Services.Packages.Customer)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetCustomer", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetCustomer(CustomerAccessControlList _CustomerAccessControlList, Services.Packages.Customer _Customer)
		{
			this.Invoke("GetCustomer", new object[] {_CustomerAccessControlList});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerAccessControlListCollection GetACLs(System.String UserName, Services.Packages.Customer _Customer) {
			object[] results = this.Invoke("GetACLs", new object[] {UserName, _Customer});
			return ((CustomerAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLsPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.Customer _Customer, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetACLsPaged", new object[] {UserName, _Customer,PagingStart,PagingCount});
			return ((CustomerAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLsCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetACLsCount(System.String UserName, Services.Packages.Customer _Customer) {
			object[] results = this.Invoke("GetACLsCount", new object[] {UserName, _Customer});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACEs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.CustomerAccessControlEntryCollection GetACEs(CustomerAccessControlList _CustomerAccessControlList)
		{
			object[] results = this.Invoke("GetACEs", new object[] {_CustomerAccessControlList});
			return ((Services.Packages.Security.CustomerAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACEs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACEs(CustomerAccessControlList _CustomerAccessControlList, Services.Packages.Security.CustomerAccessControlEntryCollection _ACEs)
		{
			this.Invoke("GetACEs", new object[] {_CustomerAccessControlList});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages.Security
