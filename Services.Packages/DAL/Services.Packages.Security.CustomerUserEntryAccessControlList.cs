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
    /// Defines the contract for the CustomerUserEntryAccessControlList class
    /// </summary>
    [ComVisible(true)]
    [Guid("d0083810-e5de-1bc9-f4ca-2e9a62fbeaa8")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface ICustomerUserEntryAccessControlList
	{
		bool Exists { get; }
		System.String UserName { get; set; }
		System.Int32 Id { get; set; }
		Services.Packages.Security.ModelUser User { get; set; }
		Services.Packages.CustomerUserEntry CustomerUserEntry { get; set; }
		Services.Packages.Security.CustomerUserEntryAccessControlEntryCollection ACEs { get; set; }
		Services.Packages.Security.CustomerUserEntryAccessControlEntryCollection GetEntries(System.String Descriptor);

		void Read(System.String __UserName, System.Int32 __Id);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(CustomerUserEntryAccessControlList _object);
		void CopyWithKeysTo(CustomerUserEntryAccessControlList _object);
		void CopyFrom(CustomerUserEntryAccessControlList _object);
		void CopyTo(CustomerUserEntryAccessControlList _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.Security.CustomerUserEntryAccessControlList type.
    /// </summary>
    [ComVisible(true)]
    [Guid("0bd725c6-49e0-cc81-5bcc-5d8f650aec7e")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface ICustomerUserEntryAccessControlListService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList);
		[OperationContract]
        CustomerUserEntryAccessControlList Read(System.String __UserName, System.Int32 __Id);
        [OperationContract]
        CustomerUserEntryAccessControlList Reload(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList);
        [OperationContract]
        CustomerUserEntryAccessControlList Create(System.String __UserName, System.Int32 __Id);
        [OperationContract]
        void Delete(System.String __UserName, System.Int32 __Id);
        [OperationContract]
        void UpdateObject(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList);
        [OperationContract]
        void CreateObject(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList);
        [OperationContract]
        void DeleteObject(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		CustomerUserEntryAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		CustomerUserEntryAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		Services.Packages.Security.ModelUser GetUser(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList);
		[OperationContract]
		void SetUser(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, Services.Packages.Security.ModelUser _User);
		[OperationContract]
		CustomerUserEntryAccessControlListCollection GetByCustomerUserEntry(Services.Packages.CustomerUserEntry _CustomerUserEntry);
		[OperationContract]
		CustomerUserEntryAccessControlListCollection GetByCustomerUserEntryPaged(Services.Packages.CustomerUserEntry _CustomerUserEntry, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByCustomerUserEntryCount(Services.Packages.CustomerUserEntry _CustomerUserEntry);
		[OperationContract]
		Services.Packages.CustomerUserEntry GetCustomerUserEntry(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList);
		[OperationContract]
		void SetCustomerUserEntry(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, Services.Packages.CustomerUserEntry _CustomerUserEntry);
		[OperationContract]
		CustomerUserEntryAccessControlListCollection GetACLs(System.String UserName, Services.Packages.CustomerUserEntry _CustomerUserEntry);
		[OperationContract]
		CustomerUserEntryAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.CustomerUserEntry _CustomerUserEntry, long PagingStart, long PagingCount);
		[OperationContract]
		long GetACLsCount(System.String UserName, Services.Packages.CustomerUserEntry _CustomerUserEntry);
		[OperationContract]
		Services.Packages.Security.CustomerUserEntryAccessControlEntryCollection GetACEs(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList);
		[OperationContract]
		void SetACEs(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, Services.Packages.Security.CustomerUserEntryAccessControlEntryCollection _ACEs);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.Security.CustomerUserEntryAccessControlList type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("e7cdbd05-26b1-a5a7-50a4-b2f88e25768a")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class CustomerUserEntryAccessControlListService : ICustomerUserEntryAccessControlListService
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
        public bool Exists(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
        {
			return _CustomerUserEntryAccessControlList.Exists;
        }
		
		[WebMethod]
		public CustomerUserEntryAccessControlList Read(System.String __UserName, System.Int32 __Id)
		{
			return new CustomerUserEntryAccessControlList(__UserName, __Id);
		}
		
		[WebMethod]
        public CustomerUserEntryAccessControlList Reload(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
        {
			_CustomerUserEntryAccessControlList.Reload();
			return _CustomerUserEntryAccessControlList;
        }
		
		[WebMethod]
        public CustomerUserEntryAccessControlList Create(System.String __UserName, System.Int32 __Id)
        {
			return CustomerUserEntryAccessControlList.CreateCustomerUserEntryAccessControlList(__UserName, __Id);
        }
        
        [WebMethod]
        public void Delete(System.String __UserName, System.Int32 __Id)
        {
			CustomerUserEntryAccessControlList.DeleteCustomerUserEntryAccessControlList(__UserName, __Id);
        }
        
        [WebMethod]
        public void UpdateObject(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
        {
			_CustomerUserEntryAccessControlList.Update();
        }
		
		[WebMethod]
        public void CreateObject(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
        {
			_CustomerUserEntryAccessControlList.Create();
        }
        
        [WebMethod]
        public void DeleteObject(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
        {
			_CustomerUserEntryAccessControlList.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			CustomerUserEntryAccessControlList.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			CustomerUserEntryAccessControlList.Redo();
        }
		[WebMethod]
		public CustomerUserEntryAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
		{
			return CustomerUserEntryAccessControlList.GetByUser( _ModelUser);
		}
		[WebMethod]
		public CustomerUserEntryAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return CustomerUserEntryAccessControlList.GetByUserPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return CustomerUserEntryAccessControlList.GetByUserCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUser(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
		{
			_CustomerUserEntryAccessControlList.Reload();
			return _CustomerUserEntryAccessControlList.User;
		}
		[WebMethod]
		public void SetUser(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, Services.Packages.Security.ModelUser _User)
		{
			_CustomerUserEntryAccessControlList.Reload();
			_CustomerUserEntryAccessControlList.User = _User;
			_CustomerUserEntryAccessControlList.Update();
		}
		[WebMethod]
		public CustomerUserEntryAccessControlListCollection GetByCustomerUserEntry(Services.Packages.CustomerUserEntry _CustomerUserEntry)
		{
			return CustomerUserEntryAccessControlList.GetByCustomerUserEntry( _CustomerUserEntry);
		}
		[WebMethod]
		public CustomerUserEntryAccessControlListCollection GetByCustomerUserEntryPaged(Services.Packages.CustomerUserEntry _CustomerUserEntry, long PagingStart, long PagingCount)
		{
			return CustomerUserEntryAccessControlList.GetByCustomerUserEntryPaged( _CustomerUserEntry, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByCustomerUserEntryCount(Services.Packages.CustomerUserEntry _CustomerUserEntry)
		{
			return CustomerUserEntryAccessControlList.GetByCustomerUserEntryCount( _CustomerUserEntry);
		}
		[WebMethod]
		public Services.Packages.CustomerUserEntry GetCustomerUserEntry(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
		{
			_CustomerUserEntryAccessControlList.Reload();
			return _CustomerUserEntryAccessControlList.CustomerUserEntry;
		}
		[WebMethod]
		public void SetCustomerUserEntry(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, Services.Packages.CustomerUserEntry _CustomerUserEntry)
		{
			_CustomerUserEntryAccessControlList.Reload();
			_CustomerUserEntryAccessControlList.CustomerUserEntry = _CustomerUserEntry;
			_CustomerUserEntryAccessControlList.Update();
		}
		[WebMethod]
		public CustomerUserEntryAccessControlListCollection GetACLs(System.String UserName, Services.Packages.CustomerUserEntry _CustomerUserEntry)
		{
			return CustomerUserEntryAccessControlList.GetACLs(UserName,  _CustomerUserEntry);
		}
		[WebMethod]
		public CustomerUserEntryAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.CustomerUserEntry _CustomerUserEntry, long PagingStart, long PagingCount)
		{
			return CustomerUserEntryAccessControlList.GetACLsPaged(UserName,  _CustomerUserEntry, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetACLsCount(System.String UserName, Services.Packages.CustomerUserEntry _CustomerUserEntry)
		{
			return CustomerUserEntryAccessControlList.GetACLsCount(UserName,  _CustomerUserEntry);
		}
		[WebMethod]
		public Services.Packages.Security.CustomerUserEntryAccessControlEntryCollection GetACEs(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
		{
			_CustomerUserEntryAccessControlList.Reload();
			return _CustomerUserEntryAccessControlList.ACEs;
		}
		[WebMethod]
		public void SetACEs(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, Services.Packages.Security.CustomerUserEntryAccessControlEntryCollection _ACEs)
		{
			_CustomerUserEntryAccessControlList.Reload();
			_CustomerUserEntryAccessControlList.ACEs = _ACEs;
			_CustomerUserEntryAccessControlList.Update();
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.Security.CustomerUserEntryAccessControlList model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("093bf27c-14f5-c76b-b73b-7412873ab6e9")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class CustomerUserEntryAccessControlList : ICustomerUserEntryAccessControlList, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<ICustomerUserEntryAccessControlListService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<ICustomerUserEntryAccessControlListService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<ICustomerUserEntryAccessControlListService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.CustomerUserEntryAccessControlList"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.CustomerUserEntryAccessControlList"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.Security.CustomerUserEntryAccessControlList.ProviderType");
				
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
		
		public static Services.Packages.Security.ModelUser GetUser(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
		{
			return _CustomerUserEntryAccessControlList.User;
		}

		bool _CustomerUserEntryIsLoaded = false;
		Services.Packages.CustomerUserEntry _CustomerUserEntry;
		
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.CustomerUserEntry CustomerUserEntry
		{
            get
            {
				if (!_CustomerUserEntryIsLoaded)
				{
					_CustomerUserEntry = new Services.Packages.CustomerUserEntry(_Id);
					if (_CustomerUserEntry.Exists)
						_CustomerUserEntryIsLoaded = true;
					else _CustomerUserEntry = null;
				}
                return _CustomerUserEntry;
            }
            set
            {
                _CustomerUserEntry = value;
                _CustomerUserEntryIsLoaded = true;
                if (_CustomerUserEntry != null)
                {
					if (_CustomerUserEntry.Exists)
					{
						_Id = _CustomerUserEntry.Id;
						
					}
					else
					{
						_CustomerUserEntry = null;
					}
				}
            }
		}
		
		public static Services.Packages.CustomerUserEntry GetCustomerUserEntry(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
		{
			return _CustomerUserEntryAccessControlList.CustomerUserEntry;
		}

		public static CustomerUserEntryAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
        {
			CustomerUserEntryAccessControlListCollection _CustomerUserEntryAccessControlListCollection = new CustomerUserEntryAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnAcCoLiGetByUs", dbconn);
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
					CustomerUserEntryAccessControlList o = new CustomerUserEntryAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._CustomerUserEntryIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._CustomerUserEntry = null; o._CustomerUserEntryIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _CustomerUserEntryAccessControlListCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerUserEntryAccessControlListCollection;
        }
        
        public static CustomerUserEntryAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			CustomerUserEntryAccessControlListCollection _CustomerUserEntryAccessControlListCollection = new CustomerUserEntryAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnAcCoLiGetByUsPaged", dbconn);
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
					CustomerUserEntryAccessControlList o = new CustomerUserEntryAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._CustomerUserEntryIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._CustomerUserEntry = null; o._CustomerUserEntryIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _CustomerUserEntryAccessControlListCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerUserEntryAccessControlListCollection;
        }
        
        public static long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnAcCoLiGetByUsCount", dbconn);
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

		public static CustomerUserEntryAccessControlListCollection GetByCustomerUserEntry(Services.Packages.CustomerUserEntry _CustomerUserEntry)
        {
			CustomerUserEntryAccessControlListCollection _CustomerUserEntryAccessControlListCollection = new CustomerUserEntryAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnAcCoLiGetByCuUsEn", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Id;
				if (_CustomerUserEntry != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_CustomerUserEntry.Id);
				} else {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", DBNull.Value);
				}
				command.Parameters.Add(param_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					CustomerUserEntryAccessControlList o = new CustomerUserEntryAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._CustomerUserEntryIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._CustomerUserEntry = null; o._CustomerUserEntryIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _CustomerUserEntryAccessControlListCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerUserEntryAccessControlListCollection;
        }
        
        public static CustomerUserEntryAccessControlListCollection GetByCustomerUserEntryPaged(Services.Packages.CustomerUserEntry _CustomerUserEntry, long PagingStart, long PagingCount)
        {
			CustomerUserEntryAccessControlListCollection _CustomerUserEntryAccessControlListCollection = new CustomerUserEntryAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnAcCoLiGetByCuUsEnPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Id;
				if (_CustomerUserEntry != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_CustomerUserEntry.Id);
				} else {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", DBNull.Value);
				}
				command.Parameters.Add(param_Id);
				
                
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
					CustomerUserEntryAccessControlList o = new CustomerUserEntryAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._CustomerUserEntryIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._CustomerUserEntry = null; o._CustomerUserEntryIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _CustomerUserEntryAccessControlListCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerUserEntryAccessControlListCollection;
        }
        
        public static long GetByCustomerUserEntryCount(Services.Packages.CustomerUserEntry _CustomerUserEntry)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnAcCoLiGetByCuUsEnCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Id;
				if (_CustomerUserEntry != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_CustomerUserEntry.Id);
				} else {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", DBNull.Value);
				}
				command.Parameters.Add(param_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		public static CustomerUserEntryAccessControlListCollection GetACLs(System.String _UserName, Services.Packages.CustomerUserEntry _CustomerUserEntry)
        {
			CustomerUserEntryAccessControlListCollection _CustomerUserEntryAccessControlListCollection = new CustomerUserEntryAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnAcCoLiGeACLs", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UserName = ClassConnectionProvider.Escape(_UserName);
				
                
                DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), -1);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_CustomerUserEntry_Id;
				if (_CustomerUserEntry != null) {
				param_CustomerUserEntry_Id = ClassConnectionProvider.GetDatabaseParameter("CuUsEnId", typeof(System.Int32), -1);
				param_CustomerUserEntry_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_CustomerUserEntry.Id);
				} else {
				param_CustomerUserEntry_Id = ClassConnectionProvider.GetDatabaseParameter("CuUsEnId", DBNull.Value);
				}
				command.Parameters.Add(param_CustomerUserEntry_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					CustomerUserEntryAccessControlList o = new CustomerUserEntryAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._CustomerUserEntryIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._CustomerUserEntry = null; o._CustomerUserEntryIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _CustomerUserEntryAccessControlListCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerUserEntryAccessControlListCollection;
        }
        
        public static CustomerUserEntryAccessControlListCollection GetACLsPaged(System.String _UserName, Services.Packages.CustomerUserEntry _CustomerUserEntry, long PagingStart, long PagingCount)
        {
			CustomerUserEntryAccessControlListCollection _CustomerUserEntryAccessControlListCollection = new CustomerUserEntryAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnAcCoLiGeACLsPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UserName = ClassConnectionProvider.Escape(_UserName);
				
                
                DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), -1);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_CustomerUserEntry_Id;
				if (_CustomerUserEntry != null) {
				param_CustomerUserEntry_Id = ClassConnectionProvider.GetDatabaseParameter("CuUsEnId", typeof(System.Int32), -1);
				param_CustomerUserEntry_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_CustomerUserEntry.Id);
				} else {
				param_CustomerUserEntry_Id = ClassConnectionProvider.GetDatabaseParameter("CuUsEnId", DBNull.Value);
				}
				command.Parameters.Add(param_CustomerUserEntry_Id);
				
                
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
					CustomerUserEntryAccessControlList o = new CustomerUserEntryAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._CustomerUserEntryIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._CustomerUserEntry = null; o._CustomerUserEntryIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _CustomerUserEntryAccessControlListCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerUserEntryAccessControlListCollection;
        }
        
        public static long GetACLsCount(System.String _UserName, Services.Packages.CustomerUserEntry _CustomerUserEntry)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnAcCoLiGeACLsCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UserName = ClassConnectionProvider.Escape(_UserName);
				
                
                DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), -1);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_CustomerUserEntry_Id;
				if (_CustomerUserEntry != null) {
				param_CustomerUserEntry_Id = ClassConnectionProvider.GetDatabaseParameter("CuUsEnId", typeof(System.Int32), -1);
				param_CustomerUserEntry_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_CustomerUserEntry.Id);
				} else {
				param_CustomerUserEntry_Id = ClassConnectionProvider.GetDatabaseParameter("CuUsEnId", DBNull.Value);
				}
				command.Parameters.Add(param_CustomerUserEntry_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		Services.Packages.Security.CustomerUserEntryAccessControlEntryCollection _ACEs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.CustomerUserEntryAccessControlEntryCollection ACEs
		{
            get
            {
				if (_ACEs == null)
					_ACEs = Services.Packages.Security.CustomerUserEntryAccessControlEntry.GetByACL(this);
				
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
			_ACEs = Services.Packages.Security.CustomerUserEntryAccessControlEntry.GetByACL(this);
		}

		public Services.Packages.Security.CustomerUserEntryAccessControlEntryCollection GetEntries(System.String Descriptor)
		{
			return Services.Packages.Security.CustomerUserEntryAccessControlEntry.GetEntries(Descriptor,  this);
		}

		public bool Exists
        {
            get {
				if (!__hasBeenReadOnce)
					Exist();
				
				return __databaseState == RowState.Initialized;
			}
        }
        
        public CustomerUserEntryAccessControlList() {}
        
        public CustomerUserEntryAccessControlList(System.String __UserName, System.Int32 __Id)
        {
			Read(__UserName, __Id);
        }
        
        #region CRUD
        
        void Exist()
        {
			// sql read - should be changed to specific exist implementation
			using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
			{
				dbconn.Open();
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUsEnAcCoLiRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
				DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
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
        
        public void Read(System.String __UserName, System.Int32 __Id)
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].Read(__UserName, __Id);
					return;
				}

                // Get a service via an algorithm
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "CuUsEnAcCoLi");
                // Perfect for read operations, but not for write
                // scalingServices[nextIndex].Read(__UserName, __Id);
				// return;

				throw new NotImplementedException();
            }

            try
            {
				// sql read
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUsEnAcCoLiRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					_UserName = __UserName;
				DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(__UserName);
				command.Parameters.Add(param_UserName);
				_Id = __Id;
				DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(__Id);
				command.Parameters.Add(param_Id);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_CustomerUserEntryIsLoaded = false; if (dr["Id"] == DBNull.Value) { _CustomerUserEntry = null; _CustomerUserEntryIsLoaded = true; }  else _Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
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
                            failoverServices[n].Read(__UserName, __Id);
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "CuUsEnAcCoLi");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUsEnAcCoLiRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_CustomerUserEntryIsLoaded = false; if (dr["Id"] == DBNull.Value) { _CustomerUserEntry = null; _CustomerUserEntryIsLoaded = true; }  else _Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUsEnAcCoLiCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_User_Name = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_User_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				if (_User == null && _UserIsLoaded == true) param_User_Name.Value = DBNull.Value;
				command.Parameters.Add(param_User_Name);
				DbParameter param_CustomerUserEntry_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_CustomerUserEntry_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				if (_CustomerUserEntry == null && _CustomerUserEntryIsLoaded == true) param_CustomerUserEntry_Id.Value = DBNull.Value;
				command.Parameters.Add(param_CustomerUserEntry_Id);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_CustomerUserEntryIsLoaded = false; if (dr["Id"] == DBNull.Value) { _CustomerUserEntry = null; _CustomerUserEntryIsLoaded = true; }  else _Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
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
        
        static public CustomerUserEntryAccessControlList CreateCustomerUserEntryAccessControlList(System.String __UserName, System.Int32 __Id)
        {
            CustomerUserEntryAccessControlList o = new CustomerUserEntryAccessControlList(__UserName, __Id);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUsEnAcCoLiUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_UserHasChanged = ClassConnectionProvider.GetDatabaseParameter("UserHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_UserIsLoaded));
				command.Parameters.Add(param_UserHasChanged);
				DbParameter param_User_Name = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_User_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				if (_User == null && _UserIsLoaded == true) param_User_Name.Value = DBNull.Value;
				command.Parameters.Add(param_User_Name);
				DbParameter param_CustomerUserEntryHasChanged = ClassConnectionProvider.GetDatabaseParameter("CustomerUserEntryHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_CustomerUserEntryIsLoaded));
				command.Parameters.Add(param_CustomerUserEntryHasChanged);
				DbParameter param_CustomerUserEntry_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_CustomerUserEntry_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				if (_CustomerUserEntry == null && _CustomerUserEntryIsLoaded == true) param_CustomerUserEntry_Id.Value = DBNull.Value;
				command.Parameters.Add(param_CustomerUserEntry_Id);
				

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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUsEnAcCoLiDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
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
        
        static public void DeleteCustomerUserEntryAccessControlList(System.String __UserName, System.Int32 __Id)
        {
            CustomerUserEntryAccessControlList o = new CustomerUserEntryAccessControlList(__UserName, __Id);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(CustomerUserEntryAccessControlList _object)
        {
			_User = null;
			_UserIsLoaded = false;
			_CustomerUserEntry = null;
			_CustomerUserEntryIsLoaded = false;
			_UserName = _object._UserName;
			_Id = _object._Id;
			
        }
        
        public void CopyWithKeysTo(CustomerUserEntryAccessControlList _object)
        {
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._CustomerUserEntry = null;
			_object._CustomerUserEntryIsLoaded = false;
			_object._UserName = _UserName;
			_object._Id = _Id;
			
        }
        
        static public void CopyWithKeysObject(CustomerUserEntryAccessControlList _objectFrom, CustomerUserEntryAccessControlList _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(CustomerUserEntryAccessControlList _object)
        {
			_User = null;
			_UserIsLoaded = false;
			_CustomerUserEntry = null;
			_CustomerUserEntryIsLoaded = false;
			
        }
        
        public void CopyTo(CustomerUserEntryAccessControlList _object)
        {
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._CustomerUserEntry = null;
			_object._CustomerUserEntryIsLoaded = false;
			
        }
        
        static public void CopyObject(CustomerUserEntryAccessControlList _objectFrom, CustomerUserEntryAccessControlList _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(CustomerUserEntryAccessControlList).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(CustomerUserEntryAccessControlList).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(CustomerUserEntryAccessControlList _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			CustomerUserEntryAccessControlListUndoRedoCollection allUndidAndNotRedoneEntries = CustomerUserEntryAccessControlListUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			CustomerUserEntryAccessControlListUndoRedo _urobject = new CustomerUserEntryAccessControlListUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.User_Name = _object._User_Name;
			_urobject.CustomerUserEntry_Id = _object._CustomerUserEntry_Id;
			_urobject.UserName = _object._UserName;
			_urobject.Id = _object._Id;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(CustomerUserEntryAccessControlList).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = CustomerUserEntryAccessControlListUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				CustomerUserEntryAccessControlListUndoRedoCollection allOldUndoEntries = CustomerUserEntryAccessControlListUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			CustomerUserEntryAccessControlListUndoRedoCollection firstUndoEntries = CustomerUserEntryAccessControlListUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			CustomerUserEntryAccessControlListUndoRedo _urobject = firstUndoEntries[0];
			
			CustomerUserEntryAccessControlList _object = new CustomerUserEntryAccessControlList();
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._User_Name = _urobject.User_Name;
			_object._CustomerUserEntry = null;
			_object._CustomerUserEntryIsLoaded = false;
			_object._CustomerUserEntry_Id = _urobject.CustomerUserEntry_Id;
			_object._UserName = _urobject.UserName;
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
			CustomerUserEntryAccessControlListUndoRedoCollection firstEntryToRedoEntries = CustomerUserEntryAccessControlListUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			CustomerUserEntryAccessControlListUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			CustomerUserEntryAccessControlList _object = new CustomerUserEntryAccessControlList();
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._User_Name = _urobject.User_Name;
			_object._CustomerUserEntry = null;
			_object._CustomerUserEntryIsLoaded = false;
			_object._CustomerUserEntry_Id = _urobject.CustomerUserEntry_Id;
			_object._UserName = _urobject.UserName;
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
    /// Defines the contract for the CustomerUserEntryAccessControlListCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("a595b0de-022d-a0f7-7d32-bb3b96883d36")]
    public interface ICustomerUserEntryAccessControlListCollection : IEnumerable<CustomerUserEntryAccessControlList>
    {
        int IndexOf(CustomerUserEntryAccessControlList item);
        void Insert(int index, CustomerUserEntryAccessControlList item);
        void RemoveAt(int index);
        CustomerUserEntryAccessControlList this[int index] { get; set; }
        void Add(CustomerUserEntryAccessControlList item);
        void Clear();
        bool Contains(CustomerUserEntryAccessControlList item);
        void CopyTo(CustomerUserEntryAccessControlList[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(CustomerUserEntryAccessControlList item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.Security.CustomerUserEntryAccessControlList
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("7213d355-e2cf-f089-5106-3075b1941d15")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class CustomerUserEntryAccessControlListCollection : ICustomerUserEntryAccessControlListCollection, IList<CustomerUserEntryAccessControlList>, IHierarchicalEnumerable
    {
        List<CustomerUserEntryAccessControlList> _list = new List<CustomerUserEntryAccessControlList>();
        
        public static implicit operator List<CustomerUserEntryAccessControlList>(CustomerUserEntryAccessControlListCollection collection)
        {
            return collection._list;
        }

        #region IList<CustomerUserEntryAccessControlList> Members

        public int IndexOf(CustomerUserEntryAccessControlList item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, CustomerUserEntryAccessControlList item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public CustomerUserEntryAccessControlList this[int index]
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

        #region ICollection<CustomerUserEntryAccessControlList> Members

        public void Add(CustomerUserEntryAccessControlList item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(CustomerUserEntryAccessControlList item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(CustomerUserEntryAccessControlList[] array, int arrayIndex)
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

        public bool Remove(CustomerUserEntryAccessControlList item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<CustomerUserEntryAccessControlList> Members

        public IEnumerator<CustomerUserEntryAccessControlList> GetEnumerator()
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
	/// that share Services.Packages.Security.CustomerUserEntryAccessControlList objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Security.Web.CustomerUserEntryAccessControlListWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class CustomerUserEntryAccessControlListWebService : WebService, ICustomerUserEntryAccessControlListService
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
        public bool Exists(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
        {
			return _CustomerUserEntryAccessControlList.Exists;
        }
		
		[WebMethod]
		public CustomerUserEntryAccessControlList Read(System.String __UserName, System.Int32 __Id)
		{
			return new CustomerUserEntryAccessControlList(__UserName, __Id);
		}
		
		[WebMethod]
        public CustomerUserEntryAccessControlList Reload(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
        {
			_CustomerUserEntryAccessControlList.Reload();
			return _CustomerUserEntryAccessControlList;
        }
		
		[WebMethod]
        public CustomerUserEntryAccessControlList Create(System.String __UserName, System.Int32 __Id)
        {
			return CustomerUserEntryAccessControlList.CreateCustomerUserEntryAccessControlList(__UserName, __Id);
        }
        
        [WebMethod]
        public void Delete(System.String __UserName, System.Int32 __Id)
        {
			CustomerUserEntryAccessControlList.DeleteCustomerUserEntryAccessControlList(__UserName, __Id);
        }
        
        [WebMethod]
        public void UpdateObject(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
        {
			_CustomerUserEntryAccessControlList.Update();
        }
		
		[WebMethod]
        public void CreateObject(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
        {
			_CustomerUserEntryAccessControlList.Create();
        }
        
        [WebMethod]
        public void DeleteObject(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
        {
			_CustomerUserEntryAccessControlList.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			CustomerUserEntryAccessControlList.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			CustomerUserEntryAccessControlList.Redo();
        }
		[WebMethod]
		public CustomerUserEntryAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
		{
			return CustomerUserEntryAccessControlList.GetByUser( _ModelUser);
		}
		[WebMethod]
		public CustomerUserEntryAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return CustomerUserEntryAccessControlList.GetByUserPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return CustomerUserEntryAccessControlList.GetByUserCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUser(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
		{
			_CustomerUserEntryAccessControlList.Reload();
			return _CustomerUserEntryAccessControlList.User;
		}
		[WebMethod]
		public void SetUser(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, Services.Packages.Security.ModelUser _User)
		{
			_CustomerUserEntryAccessControlList.Reload();
			_CustomerUserEntryAccessControlList.User = _User;
			_CustomerUserEntryAccessControlList.Update();
		}
		[WebMethod]
		public CustomerUserEntryAccessControlListCollection GetByCustomerUserEntry(Services.Packages.CustomerUserEntry _CustomerUserEntry)
		{
			return CustomerUserEntryAccessControlList.GetByCustomerUserEntry( _CustomerUserEntry);
		}
		[WebMethod]
		public CustomerUserEntryAccessControlListCollection GetByCustomerUserEntryPaged(Services.Packages.CustomerUserEntry _CustomerUserEntry, long PagingStart, long PagingCount)
		{
			return CustomerUserEntryAccessControlList.GetByCustomerUserEntryPaged( _CustomerUserEntry, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByCustomerUserEntryCount(Services.Packages.CustomerUserEntry _CustomerUserEntry)
		{
			return CustomerUserEntryAccessControlList.GetByCustomerUserEntryCount( _CustomerUserEntry);
		}
		[WebMethod]
		public Services.Packages.CustomerUserEntry GetCustomerUserEntry(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
		{
			_CustomerUserEntryAccessControlList.Reload();
			return _CustomerUserEntryAccessControlList.CustomerUserEntry;
		}
		[WebMethod]
		public void SetCustomerUserEntry(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, Services.Packages.CustomerUserEntry _CustomerUserEntry)
		{
			_CustomerUserEntryAccessControlList.Reload();
			_CustomerUserEntryAccessControlList.CustomerUserEntry = _CustomerUserEntry;
			_CustomerUserEntryAccessControlList.Update();
		}
		[WebMethod]
		public CustomerUserEntryAccessControlListCollection GetACLs(System.String UserName, Services.Packages.CustomerUserEntry _CustomerUserEntry)
		{
			return CustomerUserEntryAccessControlList.GetACLs(UserName,  _CustomerUserEntry);
		}
		[WebMethod]
		public CustomerUserEntryAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.CustomerUserEntry _CustomerUserEntry, long PagingStart, long PagingCount)
		{
			return CustomerUserEntryAccessControlList.GetACLsPaged(UserName,  _CustomerUserEntry, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetACLsCount(System.String UserName, Services.Packages.CustomerUserEntry _CustomerUserEntry)
		{
			return CustomerUserEntryAccessControlList.GetACLsCount(UserName,  _CustomerUserEntry);
		}
		[WebMethod]
		public Services.Packages.Security.CustomerUserEntryAccessControlEntryCollection GetACEs(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
		{
			_CustomerUserEntryAccessControlList.Reload();
			return _CustomerUserEntryAccessControlList.ACEs;
		}
		[WebMethod]
		public void SetACEs(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, Services.Packages.Security.CustomerUserEntryAccessControlEntryCollection _ACEs)
		{
			_CustomerUserEntryAccessControlList.Reload();
			_CustomerUserEntryAccessControlList.ACEs = _ACEs;
			_CustomerUserEntryAccessControlList.Update();
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="CustomerUserEntryAccessControlListWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("de1ac8ee-d190-795c-fb9b-8bc25930302f")]
    sealed public class CustomerUserEntryAccessControlListWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, ICustomerUserEntryAccessControlListService
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
		public CustomerUserEntryAccessControlListWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public CustomerUserEntryAccessControlListWebServiceClient()
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
		public bool Exists(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
        {
			object[] results = this.Invoke("Exists", new object[] {_CustomerUserEntryAccessControlList});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryAccessControlList Read(System.String __UserName, System.Int32 __Id)
		{
			object[] results = this.Invoke("Read", new object[] {__UserName, __Id});
			return ((CustomerUserEntryAccessControlList)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryAccessControlList Reload(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
        {
			object[] results = this.Invoke("Reload", new object[] {_CustomerUserEntryAccessControlList});
			return ((CustomerUserEntryAccessControlList)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryAccessControlList Create(System.String __UserName, System.Int32 __Id)
        {
			object[] results = this.Invoke("Create", new object[] {__UserName, __Id});
			return ((CustomerUserEntryAccessControlList)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __UserName, System.Int32 __Id)
        {
			this.Invoke("Delete", new object[] {__UserName, __Id});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
        {
			this.Invoke("UpdateObject", new object[] {_CustomerUserEntryAccessControlList});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
        {
			this.Invoke("CreateObject", new object[] {_CustomerUserEntryAccessControlList});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
        {
			this.Invoke("DeleteObject", new object[] {_CustomerUserEntryAccessControlList});
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
		public CustomerUserEntryAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByUser", new object[] {_ModelUser});
			return ((CustomerUserEntryAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByUserPaged", new object[] {_ModelUser,PagingStart,PagingCount});
			return ((CustomerUserEntryAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByUserCount", new object[] {_ModelUser});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetUser(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
		{
			object[] results = this.Invoke("GetUser", new object[] {_CustomerUserEntryAccessControlList});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetUser(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, Services.Packages.Security.ModelUser _User)
		{
			this.Invoke("GetUser", new object[] {_CustomerUserEntryAccessControlList});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByCustomerUserEntry", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryAccessControlListCollection GetByCustomerUserEntry(Services.Packages.CustomerUserEntry _CustomerUserEntry) {
			object[] results = this.Invoke("GetByCustomerUserEntry", new object[] {_CustomerUserEntry});
			return ((CustomerUserEntryAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByCustomerUserEntryPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryAccessControlListCollection GetByCustomerUserEntryPaged(Services.Packages.CustomerUserEntry _CustomerUserEntry, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByCustomerUserEntryPaged", new object[] {_CustomerUserEntry,PagingStart,PagingCount});
			return ((CustomerUserEntryAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByCustomerUserEntryCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByCustomerUserEntryCount(Services.Packages.CustomerUserEntry _CustomerUserEntry) {
			object[] results = this.Invoke("GetByCustomerUserEntryCount", new object[] {_CustomerUserEntry});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetCustomerUserEntry", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.CustomerUserEntry GetCustomerUserEntry(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
		{
			object[] results = this.Invoke("GetCustomerUserEntry", new object[] {_CustomerUserEntryAccessControlList});
			return ((Services.Packages.CustomerUserEntry)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetCustomerUserEntry", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetCustomerUserEntry(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, Services.Packages.CustomerUserEntry _CustomerUserEntry)
		{
			this.Invoke("GetCustomerUserEntry", new object[] {_CustomerUserEntryAccessControlList});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryAccessControlListCollection GetACLs(System.String UserName, Services.Packages.CustomerUserEntry _CustomerUserEntry) {
			object[] results = this.Invoke("GetACLs", new object[] {UserName, _CustomerUserEntry});
			return ((CustomerUserEntryAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLsPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.CustomerUserEntry _CustomerUserEntry, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetACLsPaged", new object[] {UserName, _CustomerUserEntry,PagingStart,PagingCount});
			return ((CustomerUserEntryAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLsCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetACLsCount(System.String UserName, Services.Packages.CustomerUserEntry _CustomerUserEntry) {
			object[] results = this.Invoke("GetACLsCount", new object[] {UserName, _CustomerUserEntry});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACEs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.CustomerUserEntryAccessControlEntryCollection GetACEs(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
		{
			object[] results = this.Invoke("GetACEs", new object[] {_CustomerUserEntryAccessControlList});
			return ((Services.Packages.Security.CustomerUserEntryAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACEs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACEs(CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, Services.Packages.Security.CustomerUserEntryAccessControlEntryCollection _ACEs)
		{
			this.Invoke("GetACEs", new object[] {_CustomerUserEntryAccessControlList});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages.Security
