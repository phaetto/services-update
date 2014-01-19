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
    /// Defines the contract for the CustomerUserEntryAccessControlEntry class
    /// </summary>
    [ComVisible(true)]
    [Guid("737701d6-69d8-abee-ae1e-b7eb7e35a879")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface ICustomerUserEntryAccessControlEntry
	{
		bool Exists { get; }
		System.String Descriptor { get; set; }
		System.String UserName { get; set; }
		System.Boolean Allow { get; set; }
		System.Int32 Id { get; set; }
		Services.Packages.Security.CustomerUserEntryAccessControlList ACL { get; set; }

		void Read(System.String __Descriptor, System.String __UserName, System.Int32 __Id);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(CustomerUserEntryAccessControlEntry _object);
		void CopyWithKeysTo(CustomerUserEntryAccessControlEntry _object);
		void CopyFrom(CustomerUserEntryAccessControlEntry _object);
		void CopyTo(CustomerUserEntryAccessControlEntry _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.Security.CustomerUserEntryAccessControlEntry type.
    /// </summary>
    [ComVisible(true)]
    [Guid("b3ada2ac-61e3-9fc0-9738-3d8ecbe6a360")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface ICustomerUserEntryAccessControlEntryService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry);
		[OperationContract]
        CustomerUserEntryAccessControlEntry Read(System.String __Descriptor, System.String __UserName, System.Int32 __Id);
        [OperationContract]
        CustomerUserEntryAccessControlEntry Reload(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry);
        [OperationContract]
        CustomerUserEntryAccessControlEntry Create(System.String __Descriptor, System.String __UserName, System.Int32 __Id);
        [OperationContract]
        void Delete(System.String __Descriptor, System.String __UserName, System.Int32 __Id);
        [OperationContract]
        void UpdateObject(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry);
        [OperationContract]
        void CreateObject(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry);
        [OperationContract]
        void DeleteObject(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		CustomerUserEntryAccessControlEntryCollection GetByACL(Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList);
		[OperationContract]
		CustomerUserEntryAccessControlEntryCollection GetByACLPaged(Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByACLCount(Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList);
		[OperationContract]
		Services.Packages.Security.CustomerUserEntryAccessControlList GetACL(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry);
		[OperationContract]
		void SetACL(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry, Services.Packages.Security.CustomerUserEntryAccessControlList _ACL);
		[OperationContract]
		CustomerUserEntryAccessControlEntryCollection GetEntries(System.String Descriptor, Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList);
		[OperationContract]
		CustomerUserEntryAccessControlEntryCollection GetEntriesPaged(System.String Descriptor, Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, long PagingStart, long PagingCount);
		[OperationContract]
		long GetEntriesCount(System.String Descriptor, Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.Security.CustomerUserEntryAccessControlEntry type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("cf51310d-7b0a-ab10-b7a0-204fa7bb0641")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class CustomerUserEntryAccessControlEntryService : ICustomerUserEntryAccessControlEntryService
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
        public bool Exists(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry)
        {
			return _CustomerUserEntryAccessControlEntry.Exists;
        }
		
		[WebMethod]
		public CustomerUserEntryAccessControlEntry Read(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
		{
			return new CustomerUserEntryAccessControlEntry(__Descriptor, __UserName, __Id);
		}
		
		[WebMethod]
        public CustomerUserEntryAccessControlEntry Reload(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry)
        {
			_CustomerUserEntryAccessControlEntry.Reload();
			return _CustomerUserEntryAccessControlEntry;
        }
		
		[WebMethod]
        public CustomerUserEntryAccessControlEntry Create(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
        {
			return CustomerUserEntryAccessControlEntry.CreateCustomerUserEntryAccessControlEntry(__Descriptor, __UserName, __Id);
        }
        
        [WebMethod]
        public void Delete(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
        {
			CustomerUserEntryAccessControlEntry.DeleteCustomerUserEntryAccessControlEntry(__Descriptor, __UserName, __Id);
        }
        
        [WebMethod]
        public void UpdateObject(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry)
        {
			_CustomerUserEntryAccessControlEntry.Update();
        }
		
		[WebMethod]
        public void CreateObject(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry)
        {
			_CustomerUserEntryAccessControlEntry.Create();
        }
        
        [WebMethod]
        public void DeleteObject(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry)
        {
			_CustomerUserEntryAccessControlEntry.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			CustomerUserEntryAccessControlEntry.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			CustomerUserEntryAccessControlEntry.Redo();
        }
		[WebMethod]
		public CustomerUserEntryAccessControlEntryCollection GetByACL(Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
		{
			return CustomerUserEntryAccessControlEntry.GetByACL( _CustomerUserEntryAccessControlList);
		}
		[WebMethod]
		public CustomerUserEntryAccessControlEntryCollection GetByACLPaged(Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, long PagingStart, long PagingCount)
		{
			return CustomerUserEntryAccessControlEntry.GetByACLPaged( _CustomerUserEntryAccessControlList, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByACLCount(Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
		{
			return CustomerUserEntryAccessControlEntry.GetByACLCount( _CustomerUserEntryAccessControlList);
		}
		[WebMethod]
		public Services.Packages.Security.CustomerUserEntryAccessControlList GetACL(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry)
		{
			_CustomerUserEntryAccessControlEntry.Reload();
			return _CustomerUserEntryAccessControlEntry.ACL;
		}
		[WebMethod]
		public void SetACL(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry, Services.Packages.Security.CustomerUserEntryAccessControlList _ACL)
		{
			_CustomerUserEntryAccessControlEntry.Reload();
			_CustomerUserEntryAccessControlEntry.ACL = _ACL;
			_CustomerUserEntryAccessControlEntry.Update();
		}
		[WebMethod]
		public CustomerUserEntryAccessControlEntryCollection GetEntries(System.String Descriptor, Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
		{
			return CustomerUserEntryAccessControlEntry.GetEntries(Descriptor,  _CustomerUserEntryAccessControlList);
		}
		[WebMethod]
		public CustomerUserEntryAccessControlEntryCollection GetEntriesPaged(System.String Descriptor, Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, long PagingStart, long PagingCount)
		{
			return CustomerUserEntryAccessControlEntry.GetEntriesPaged(Descriptor,  _CustomerUserEntryAccessControlList, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetEntriesCount(System.String Descriptor, Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
		{
			return CustomerUserEntryAccessControlEntry.GetEntriesCount(Descriptor,  _CustomerUserEntryAccessControlList);
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.Security.CustomerUserEntryAccessControlEntry model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("b588fef0-e318-743e-40d8-dba02b5fe0c7")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class CustomerUserEntryAccessControlEntry : ICustomerUserEntryAccessControlEntry, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<ICustomerUserEntryAccessControlEntryService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<ICustomerUserEntryAccessControlEntryService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<ICustomerUserEntryAccessControlEntryService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.CustomerUserEntryAccessControlEntry"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.CustomerUserEntryAccessControlEntry"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.Security.CustomerUserEntryAccessControlEntry.ProviderType");
				
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


		System.String _Descriptor;
		
		// Key member
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String Descriptor
		{
            get
            {
                return _Descriptor;
            }
            set
            {
				if (_Descriptor != value)
					__hasBeenReadOnce = false;
                _Descriptor = value;
            }
		}

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

		System.Boolean _Allow;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Boolean Allow
		{
            get
            {
                return _Allow;
            }
            set
            {
                _Allow = value;
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

		bool _ACLIsLoaded = false;
		Services.Packages.Security.CustomerUserEntryAccessControlList _ACL;
		
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.CustomerUserEntryAccessControlList ACL
		{
            get
            {
				if (!_ACLIsLoaded)
				{
					_ACL = new Services.Packages.Security.CustomerUserEntryAccessControlList(_UserName, _Id);
					if (_ACL.Exists)
						_ACLIsLoaded = true;
					else _ACL = null;
				}
                return _ACL;
            }
            set
            {
                _ACL = value;
                _ACLIsLoaded = true;
                if (_ACL != null)
                {
					if (_ACL.Exists)
					{
						_UserName = _ACL.UserName;
						_Id = _ACL.Id;
						
					}
					else
					{
						_ACL = null;
					}
				}
            }
		}
		
		public static Services.Packages.Security.CustomerUserEntryAccessControlList GetACL(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry)
		{
			return _CustomerUserEntryAccessControlEntry.ACL;
		}

		public static CustomerUserEntryAccessControlEntryCollection GetByACL(Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
        {
			CustomerUserEntryAccessControlEntryCollection _CustomerUserEntryAccessControlEntryCollection = new CustomerUserEntryAccessControlEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnAcCoEnGetByACL", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_UserName;
				if (_CustomerUserEntryAccessControlList != null) {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_CustomerUserEntryAccessControlList.UserName);
				} else {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", DBNull.Value);
				}
				command.Parameters.Add(param_UserName);
				DbParameter param_Id;
				if (_CustomerUserEntryAccessControlList != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_CustomerUserEntryAccessControlList.Id);
				} else {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", DBNull.Value);
				}
				command.Parameters.Add(param_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					CustomerUserEntryAccessControlEntry o = new CustomerUserEntryAccessControlEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Id"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _CustomerUserEntryAccessControlEntryCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerUserEntryAccessControlEntryCollection;
        }
        
        public static CustomerUserEntryAccessControlEntryCollection GetByACLPaged(Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, long PagingStart, long PagingCount)
        {
			CustomerUserEntryAccessControlEntryCollection _CustomerUserEntryAccessControlEntryCollection = new CustomerUserEntryAccessControlEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnAcCoEnGetByACLPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_UserName;
				if (_CustomerUserEntryAccessControlList != null) {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_CustomerUserEntryAccessControlList.UserName);
				} else {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", DBNull.Value);
				}
				command.Parameters.Add(param_UserName);
				DbParameter param_Id;
				if (_CustomerUserEntryAccessControlList != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_CustomerUserEntryAccessControlList.Id);
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
					CustomerUserEntryAccessControlEntry o = new CustomerUserEntryAccessControlEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Id"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _CustomerUserEntryAccessControlEntryCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerUserEntryAccessControlEntryCollection;
        }
        
        public static long GetByACLCount(Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnAcCoEnGetByACLCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_UserName;
				if (_CustomerUserEntryAccessControlList != null) {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_CustomerUserEntryAccessControlList.UserName);
				} else {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", DBNull.Value);
				}
				command.Parameters.Add(param_UserName);
				DbParameter param_Id;
				if (_CustomerUserEntryAccessControlList != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_CustomerUserEntryAccessControlList.Id);
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

		public static CustomerUserEntryAccessControlEntryCollection GetEntries(System.String _Descriptor, Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
        {
			CustomerUserEntryAccessControlEntryCollection _CustomerUserEntryAccessControlEntryCollection = new CustomerUserEntryAccessControlEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnAcCoEnGeEn", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Descriptor = ClassConnectionProvider.Escape(_Descriptor);
				
                
                DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), -1);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_CustomerUserEntryAccessControlList_UserName;
				if (_CustomerUserEntryAccessControlList != null) {
				param_CustomerUserEntryAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("CuUsEnAcCoLiUsNa", typeof(System.String), 128);
				param_CustomerUserEntryAccessControlList_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_CustomerUserEntryAccessControlList.UserName);
				} else {
				param_CustomerUserEntryAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("CuUsEnAcCoLiUsNa", DBNull.Value);
				}
				command.Parameters.Add(param_CustomerUserEntryAccessControlList_UserName);
				DbParameter param_CustomerUserEntryAccessControlList_Id;
				if (_CustomerUserEntryAccessControlList != null) {
				param_CustomerUserEntryAccessControlList_Id = ClassConnectionProvider.GetDatabaseParameter("CuUsEnAcCoLiId", typeof(System.Int32), -1);
				param_CustomerUserEntryAccessControlList_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_CustomerUserEntryAccessControlList.Id);
				} else {
				param_CustomerUserEntryAccessControlList_Id = ClassConnectionProvider.GetDatabaseParameter("CuUsEnAcCoLiId", DBNull.Value);
				}
				command.Parameters.Add(param_CustomerUserEntryAccessControlList_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					CustomerUserEntryAccessControlEntry o = new CustomerUserEntryAccessControlEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Id"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _CustomerUserEntryAccessControlEntryCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerUserEntryAccessControlEntryCollection;
        }
        
        public static CustomerUserEntryAccessControlEntryCollection GetEntriesPaged(System.String _Descriptor, Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, long PagingStart, long PagingCount)
        {
			CustomerUserEntryAccessControlEntryCollection _CustomerUserEntryAccessControlEntryCollection = new CustomerUserEntryAccessControlEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnAcCoEnGeEnPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Descriptor = ClassConnectionProvider.Escape(_Descriptor);
				
                
                DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), -1);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_CustomerUserEntryAccessControlList_UserName;
				if (_CustomerUserEntryAccessControlList != null) {
				param_CustomerUserEntryAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("CuUsEnAcCoLiUsNa", typeof(System.String), 128);
				param_CustomerUserEntryAccessControlList_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_CustomerUserEntryAccessControlList.UserName);
				} else {
				param_CustomerUserEntryAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("CuUsEnAcCoLiUsNa", DBNull.Value);
				}
				command.Parameters.Add(param_CustomerUserEntryAccessControlList_UserName);
				DbParameter param_CustomerUserEntryAccessControlList_Id;
				if (_CustomerUserEntryAccessControlList != null) {
				param_CustomerUserEntryAccessControlList_Id = ClassConnectionProvider.GetDatabaseParameter("CuUsEnAcCoLiId", typeof(System.Int32), -1);
				param_CustomerUserEntryAccessControlList_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_CustomerUserEntryAccessControlList.Id);
				} else {
				param_CustomerUserEntryAccessControlList_Id = ClassConnectionProvider.GetDatabaseParameter("CuUsEnAcCoLiId", DBNull.Value);
				}
				command.Parameters.Add(param_CustomerUserEntryAccessControlList_Id);
				
                
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
					CustomerUserEntryAccessControlEntry o = new CustomerUserEntryAccessControlEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Id"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _CustomerUserEntryAccessControlEntryCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerUserEntryAccessControlEntryCollection;
        }
        
        public static long GetEntriesCount(System.String _Descriptor, Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUsEnAcCoEnGeEnCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Descriptor = ClassConnectionProvider.Escape(_Descriptor);
				
                
                DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), -1);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_CustomerUserEntryAccessControlList_UserName;
				if (_CustomerUserEntryAccessControlList != null) {
				param_CustomerUserEntryAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("CuUsEnAcCoLiUsNa", typeof(System.String), 128);
				param_CustomerUserEntryAccessControlList_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_CustomerUserEntryAccessControlList.UserName);
				} else {
				param_CustomerUserEntryAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("CuUsEnAcCoLiUsNa", DBNull.Value);
				}
				command.Parameters.Add(param_CustomerUserEntryAccessControlList_UserName);
				DbParameter param_CustomerUserEntryAccessControlList_Id;
				if (_CustomerUserEntryAccessControlList != null) {
				param_CustomerUserEntryAccessControlList_Id = ClassConnectionProvider.GetDatabaseParameter("CuUsEnAcCoLiId", typeof(System.Int32), -1);
				param_CustomerUserEntryAccessControlList_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_CustomerUserEntryAccessControlList.Id);
				} else {
				param_CustomerUserEntryAccessControlList_Id = ClassConnectionProvider.GetDatabaseParameter("CuUsEnAcCoLiId", DBNull.Value);
				}
				command.Parameters.Add(param_CustomerUserEntryAccessControlList_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		public bool Exists
        {
            get {
				if (!__hasBeenReadOnce)
					Exist();
				
				return __databaseState == RowState.Initialized;
			}
        }
        
        public CustomerUserEntryAccessControlEntry() {}
        
        public CustomerUserEntryAccessControlEntry(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
        {
			Read(__Descriptor, __UserName, __Id);
        }
        
        #region CRUD
        
        void Exist()
        {
			// sql read - should be changed to specific exist implementation
			using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
			{
				dbconn.Open();
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUsEnAcCoEnRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
				DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), 128);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
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
        
        public void Read(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].Read(__Descriptor, __UserName, __Id);
					return;
				}

                // Get a service via an algorithm
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "CuUsEnAcCoEn");
                // Perfect for read operations, but not for write
                // scalingServices[nextIndex].Read(__Descriptor, __UserName, __Id);
				// return;

				throw new NotImplementedException();
            }

            try
            {
				// sql read
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUsEnAcCoEnRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					_Descriptor = __Descriptor;
				DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), 128);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(__Descriptor);
				command.Parameters.Add(param_Descriptor);
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
						_Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Id"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
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
                            failoverServices[n].Read(__Descriptor, __UserName, __Id);
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "CuUsEnAcCoEn");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUsEnAcCoEnRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), 128);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
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
						_Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Id"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUsEnAcCoEnCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), 128);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_Allow = ClassConnectionProvider.GetDatabaseParameter("Allow", typeof(System.Boolean), -1);
				param_Allow.Value = ClassConnectionProvider.FromValueToSqlModelType(_Allow);
				command.Parameters.Add(param_Allow);
				DbParameter param_ACL_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_ACL_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				if (_ACL == null && _ACLIsLoaded == true) param_ACL_UserName.Value = DBNull.Value;
				command.Parameters.Add(param_ACL_UserName);
				DbParameter param_ACL_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_ACL_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				if (_ACL == null && _ACLIsLoaded == true) param_ACL_Id.Value = DBNull.Value;
				command.Parameters.Add(param_ACL_Id);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Id"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
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
        
        static public CustomerUserEntryAccessControlEntry CreateCustomerUserEntryAccessControlEntry(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
        {
            CustomerUserEntryAccessControlEntry o = new CustomerUserEntryAccessControlEntry(__Descriptor, __UserName, __Id);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUsEnAcCoEnUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), 128);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_Allow = ClassConnectionProvider.GetDatabaseParameter("Allow", typeof(System.Boolean), -1);
				param_Allow.Value = ClassConnectionProvider.FromValueToSqlModelType(_Allow);
				command.Parameters.Add(param_Allow);
				DbParameter param_ACLHasChanged = ClassConnectionProvider.GetDatabaseParameter("ACLHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_ACLIsLoaded));
				command.Parameters.Add(param_ACLHasChanged);
				DbParameter param_ACL_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_ACL_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				if (_ACL == null && _ACLIsLoaded == true) param_ACL_UserName.Value = DBNull.Value;
				command.Parameters.Add(param_ACL_UserName);
				DbParameter param_ACL_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_ACL_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				if (_ACL == null && _ACLIsLoaded == true) param_ACL_Id.Value = DBNull.Value;
				command.Parameters.Add(param_ACL_Id);
				

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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUsEnAcCoEnDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), 128);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
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
        
        static public void DeleteCustomerUserEntryAccessControlEntry(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
        {
            CustomerUserEntryAccessControlEntry o = new CustomerUserEntryAccessControlEntry(__Descriptor, __UserName, __Id);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(CustomerUserEntryAccessControlEntry _object)
        {
			_ACL = null;
			_ACLIsLoaded = false;
			_Descriptor = _object._Descriptor;
			_UserName = _object._UserName;
			_Allow = _object._Allow;
			_Id = _object._Id;
			
        }
        
        public void CopyWithKeysTo(CustomerUserEntryAccessControlEntry _object)
        {
			_object._ACL = null;
			_object._ACLIsLoaded = false;
			_object._Descriptor = _Descriptor;
			_object._UserName = _UserName;
			_object._Allow = _Allow;
			_object._Id = _Id;
			
        }
        
        static public void CopyWithKeysObject(CustomerUserEntryAccessControlEntry _objectFrom, CustomerUserEntryAccessControlEntry _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(CustomerUserEntryAccessControlEntry _object)
        {
			_ACL = null;
			_ACLIsLoaded = false;
			_Allow = _object._Allow;
			
        }
        
        public void CopyTo(CustomerUserEntryAccessControlEntry _object)
        {
			_object._ACL = null;
			_object._ACLIsLoaded = false;
			_object._Allow = _Allow;
			
        }
        
        static public void CopyObject(CustomerUserEntryAccessControlEntry _objectFrom, CustomerUserEntryAccessControlEntry _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(CustomerUserEntryAccessControlEntry).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(CustomerUserEntryAccessControlEntry).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(CustomerUserEntryAccessControlEntry _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			CustomerUserEntryAccessControlEntryUndoRedoCollection allUndidAndNotRedoneEntries = CustomerUserEntryAccessControlEntryUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			CustomerUserEntryAccessControlEntryUndoRedo _urobject = new CustomerUserEntryAccessControlEntryUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.ACL_UserName = _object._ACL_UserName;
			_urobject.ACL_Id = _object._ACL_Id;
			_urobject.Descriptor = _object._Descriptor;
			_urobject.UserName = _object._UserName;
			_urobject.Allow = _object._Allow;
			_urobject.Id = _object._Id;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(CustomerUserEntryAccessControlEntry).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = CustomerUserEntryAccessControlEntryUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				CustomerUserEntryAccessControlEntryUndoRedoCollection allOldUndoEntries = CustomerUserEntryAccessControlEntryUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			CustomerUserEntryAccessControlEntryUndoRedoCollection firstUndoEntries = CustomerUserEntryAccessControlEntryUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			CustomerUserEntryAccessControlEntryUndoRedo _urobject = firstUndoEntries[0];
			
			CustomerUserEntryAccessControlEntry _object = new CustomerUserEntryAccessControlEntry();
			_object._ACL = null;
			_object._ACLIsLoaded = false;
			_object._ACL_UserName = _urobject.ACL_UserName;
			_object._ACL = null;
			_object._ACLIsLoaded = false;
			_object._ACL_Id = _urobject.ACL_Id;
			_object._Descriptor = _urobject.Descriptor;
			_object._UserName = _urobject.UserName;
			_object._Allow = _urobject.Allow;
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
			CustomerUserEntryAccessControlEntryUndoRedoCollection firstEntryToRedoEntries = CustomerUserEntryAccessControlEntryUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			CustomerUserEntryAccessControlEntryUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			CustomerUserEntryAccessControlEntry _object = new CustomerUserEntryAccessControlEntry();
			_object._ACL = null;
			_object._ACLIsLoaded = false;
			_object._ACL_UserName = _urobject.ACL_UserName;
			_object._ACL = null;
			_object._ACLIsLoaded = false;
			_object._ACL_Id = _urobject.ACL_Id;
			_object._Descriptor = _urobject.Descriptor;
			_object._UserName = _urobject.UserName;
			_object._Allow = _urobject.Allow;
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
    /// Defines the contract for the CustomerUserEntryAccessControlEntryCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("4ddd567a-d8e3-306f-9101-fc424171f7dc")]
    public interface ICustomerUserEntryAccessControlEntryCollection : IEnumerable<CustomerUserEntryAccessControlEntry>
    {
        int IndexOf(CustomerUserEntryAccessControlEntry item);
        void Insert(int index, CustomerUserEntryAccessControlEntry item);
        void RemoveAt(int index);
        CustomerUserEntryAccessControlEntry this[int index] { get; set; }
        void Add(CustomerUserEntryAccessControlEntry item);
        void Clear();
        bool Contains(CustomerUserEntryAccessControlEntry item);
        void CopyTo(CustomerUserEntryAccessControlEntry[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(CustomerUserEntryAccessControlEntry item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.Security.CustomerUserEntryAccessControlEntry
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("cc9dfb32-ee5e-2a47-f2dc-8e31a0708057")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class CustomerUserEntryAccessControlEntryCollection : ICustomerUserEntryAccessControlEntryCollection, IList<CustomerUserEntryAccessControlEntry>, IHierarchicalEnumerable
    {
        List<CustomerUserEntryAccessControlEntry> _list = new List<CustomerUserEntryAccessControlEntry>();
        
        public static implicit operator List<CustomerUserEntryAccessControlEntry>(CustomerUserEntryAccessControlEntryCollection collection)
        {
            return collection._list;
        }

        #region IList<CustomerUserEntryAccessControlEntry> Members

        public int IndexOf(CustomerUserEntryAccessControlEntry item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, CustomerUserEntryAccessControlEntry item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public CustomerUserEntryAccessControlEntry this[int index]
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

        #region ICollection<CustomerUserEntryAccessControlEntry> Members

        public void Add(CustomerUserEntryAccessControlEntry item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(CustomerUserEntryAccessControlEntry item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(CustomerUserEntryAccessControlEntry[] array, int arrayIndex)
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

        public bool Remove(CustomerUserEntryAccessControlEntry item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<CustomerUserEntryAccessControlEntry> Members

        public IEnumerator<CustomerUserEntryAccessControlEntry> GetEnumerator()
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
	/// that share Services.Packages.Security.CustomerUserEntryAccessControlEntry objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Security.Web.CustomerUserEntryAccessControlEntryWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class CustomerUserEntryAccessControlEntryWebService : WebService, ICustomerUserEntryAccessControlEntryService
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
        public bool Exists(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry)
        {
			return _CustomerUserEntryAccessControlEntry.Exists;
        }
		
		[WebMethod]
		public CustomerUserEntryAccessControlEntry Read(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
		{
			return new CustomerUserEntryAccessControlEntry(__Descriptor, __UserName, __Id);
		}
		
		[WebMethod]
        public CustomerUserEntryAccessControlEntry Reload(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry)
        {
			_CustomerUserEntryAccessControlEntry.Reload();
			return _CustomerUserEntryAccessControlEntry;
        }
		
		[WebMethod]
        public CustomerUserEntryAccessControlEntry Create(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
        {
			return CustomerUserEntryAccessControlEntry.CreateCustomerUserEntryAccessControlEntry(__Descriptor, __UserName, __Id);
        }
        
        [WebMethod]
        public void Delete(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
        {
			CustomerUserEntryAccessControlEntry.DeleteCustomerUserEntryAccessControlEntry(__Descriptor, __UserName, __Id);
        }
        
        [WebMethod]
        public void UpdateObject(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry)
        {
			_CustomerUserEntryAccessControlEntry.Update();
        }
		
		[WebMethod]
        public void CreateObject(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry)
        {
			_CustomerUserEntryAccessControlEntry.Create();
        }
        
        [WebMethod]
        public void DeleteObject(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry)
        {
			_CustomerUserEntryAccessControlEntry.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			CustomerUserEntryAccessControlEntry.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			CustomerUserEntryAccessControlEntry.Redo();
        }
		[WebMethod]
		public CustomerUserEntryAccessControlEntryCollection GetByACL(Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
		{
			return CustomerUserEntryAccessControlEntry.GetByACL( _CustomerUserEntryAccessControlList);
		}
		[WebMethod]
		public CustomerUserEntryAccessControlEntryCollection GetByACLPaged(Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, long PagingStart, long PagingCount)
		{
			return CustomerUserEntryAccessControlEntry.GetByACLPaged( _CustomerUserEntryAccessControlList, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByACLCount(Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
		{
			return CustomerUserEntryAccessControlEntry.GetByACLCount( _CustomerUserEntryAccessControlList);
		}
		[WebMethod]
		public Services.Packages.Security.CustomerUserEntryAccessControlList GetACL(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry)
		{
			_CustomerUserEntryAccessControlEntry.Reload();
			return _CustomerUserEntryAccessControlEntry.ACL;
		}
		[WebMethod]
		public void SetACL(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry, Services.Packages.Security.CustomerUserEntryAccessControlList _ACL)
		{
			_CustomerUserEntryAccessControlEntry.Reload();
			_CustomerUserEntryAccessControlEntry.ACL = _ACL;
			_CustomerUserEntryAccessControlEntry.Update();
		}
		[WebMethod]
		public CustomerUserEntryAccessControlEntryCollection GetEntries(System.String Descriptor, Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
		{
			return CustomerUserEntryAccessControlEntry.GetEntries(Descriptor,  _CustomerUserEntryAccessControlList);
		}
		[WebMethod]
		public CustomerUserEntryAccessControlEntryCollection GetEntriesPaged(System.String Descriptor, Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, long PagingStart, long PagingCount)
		{
			return CustomerUserEntryAccessControlEntry.GetEntriesPaged(Descriptor,  _CustomerUserEntryAccessControlList, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetEntriesCount(System.String Descriptor, Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList)
		{
			return CustomerUserEntryAccessControlEntry.GetEntriesCount(Descriptor,  _CustomerUserEntryAccessControlList);
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="CustomerUserEntryAccessControlEntryWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("50d558c0-b8dd-175d-8f57-2316e6fc32cf")]
    sealed public class CustomerUserEntryAccessControlEntryWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, ICustomerUserEntryAccessControlEntryService
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
		public CustomerUserEntryAccessControlEntryWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public CustomerUserEntryAccessControlEntryWebServiceClient()
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
		public bool Exists(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry)
        {
			object[] results = this.Invoke("Exists", new object[] {_CustomerUserEntryAccessControlEntry});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryAccessControlEntry Read(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
		{
			object[] results = this.Invoke("Read", new object[] {__Descriptor, __UserName, __Id});
			return ((CustomerUserEntryAccessControlEntry)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryAccessControlEntry Reload(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry)
        {
			object[] results = this.Invoke("Reload", new object[] {_CustomerUserEntryAccessControlEntry});
			return ((CustomerUserEntryAccessControlEntry)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryAccessControlEntry Create(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
        {
			object[] results = this.Invoke("Create", new object[] {__Descriptor, __UserName, __Id});
			return ((CustomerUserEntryAccessControlEntry)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
        {
			this.Invoke("Delete", new object[] {__Descriptor, __UserName, __Id});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry)
        {
			this.Invoke("UpdateObject", new object[] {_CustomerUserEntryAccessControlEntry});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry)
        {
			this.Invoke("CreateObject", new object[] {_CustomerUserEntryAccessControlEntry});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry)
        {
			this.Invoke("DeleteObject", new object[] {_CustomerUserEntryAccessControlEntry});
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
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByACL", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryAccessControlEntryCollection GetByACL(Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList) {
			object[] results = this.Invoke("GetByACL", new object[] {_CustomerUserEntryAccessControlList});
			return ((CustomerUserEntryAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByACLPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryAccessControlEntryCollection GetByACLPaged(Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByACLPaged", new object[] {_CustomerUserEntryAccessControlList,PagingStart,PagingCount});
			return ((CustomerUserEntryAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByACLCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByACLCount(Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList) {
			object[] results = this.Invoke("GetByACLCount", new object[] {_CustomerUserEntryAccessControlList});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACL", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.CustomerUserEntryAccessControlList GetACL(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry)
		{
			object[] results = this.Invoke("GetACL", new object[] {_CustomerUserEntryAccessControlEntry});
			return ((Services.Packages.Security.CustomerUserEntryAccessControlList)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACL", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACL(CustomerUserEntryAccessControlEntry _CustomerUserEntryAccessControlEntry, Services.Packages.Security.CustomerUserEntryAccessControlList _ACL)
		{
			this.Invoke("GetACL", new object[] {_CustomerUserEntryAccessControlEntry});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetEntries", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryAccessControlEntryCollection GetEntries(System.String Descriptor, Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList) {
			object[] results = this.Invoke("GetEntries", new object[] {Descriptor, _CustomerUserEntryAccessControlList});
			return ((CustomerUserEntryAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetEntriesPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUserEntryAccessControlEntryCollection GetEntriesPaged(System.String Descriptor, Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetEntriesPaged", new object[] {Descriptor, _CustomerUserEntryAccessControlList,PagingStart,PagingCount});
			return ((CustomerUserEntryAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetEntriesCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetEntriesCount(System.String Descriptor, Services.Packages.Security.CustomerUserEntryAccessControlList _CustomerUserEntryAccessControlList) {
			object[] results = this.Invoke("GetEntriesCount", new object[] {Descriptor, _CustomerUserEntryAccessControlList});
			return ((long)(results[0]));
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages.Security
