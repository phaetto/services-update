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
    /// Defines the contract for the ApiKeyAccessControlEntry class
    /// </summary>
    [ComVisible(true)]
    [Guid("c59155de-aa28-a525-75c7-a1e2a4ee346c")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IApiKeyAccessControlEntry
	{
		bool Exists { get; }
		System.String Descriptor { get; set; }
		System.String UserName { get; set; }
		System.Boolean Allow { get; set; }
		System.Guid Id { get; set; }
		Services.Packages.Security.ApiKeyAccessControlList ACL { get; set; }

		void Read(System.String __Descriptor, System.String __UserName, System.Guid __Id);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(ApiKeyAccessControlEntry _object);
		void CopyWithKeysTo(ApiKeyAccessControlEntry _object);
		void CopyFrom(ApiKeyAccessControlEntry _object);
		void CopyTo(ApiKeyAccessControlEntry _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.Security.ApiKeyAccessControlEntry type.
    /// </summary>
    [ComVisible(true)]
    [Guid("c42e729f-0403-fed3-36db-9d0b9b27b640")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IApiKeyAccessControlEntryService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry);
		[OperationContract]
        ApiKeyAccessControlEntry Read(System.String __Descriptor, System.String __UserName, System.Guid __Id);
        [OperationContract]
        ApiKeyAccessControlEntry Reload(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry);
        [OperationContract]
        ApiKeyAccessControlEntry Create(System.String __Descriptor, System.String __UserName, System.Guid __Id);
        [OperationContract]
        void Delete(System.String __Descriptor, System.String __UserName, System.Guid __Id);
        [OperationContract]
        void UpdateObject(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry);
        [OperationContract]
        void CreateObject(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry);
        [OperationContract]
        void DeleteObject(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		ApiKeyAccessControlEntryCollection GetByACL(Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList);
		[OperationContract]
		ApiKeyAccessControlEntryCollection GetByACLPaged(Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByACLCount(Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList);
		[OperationContract]
		Services.Packages.Security.ApiKeyAccessControlList GetACL(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry);
		[OperationContract]
		void SetACL(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry, Services.Packages.Security.ApiKeyAccessControlList _ACL);
		[OperationContract]
		ApiKeyAccessControlEntryCollection GetEntries(System.String Descriptor, Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList);
		[OperationContract]
		ApiKeyAccessControlEntryCollection GetEntriesPaged(System.String Descriptor, Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList, long PagingStart, long PagingCount);
		[OperationContract]
		long GetEntriesCount(System.String Descriptor, Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.Security.ApiKeyAccessControlEntry type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("d5cb55a5-44f0-1b90-fce6-b5d80e6d6977")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class ApiKeyAccessControlEntryService : IApiKeyAccessControlEntryService
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
        public bool Exists(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry)
        {
			return _ApiKeyAccessControlEntry.Exists;
        }
		
		[WebMethod]
		public ApiKeyAccessControlEntry Read(System.String __Descriptor, System.String __UserName, System.Guid __Id)
		{
			return new ApiKeyAccessControlEntry(__Descriptor, __UserName, __Id);
		}
		
		[WebMethod]
        public ApiKeyAccessControlEntry Reload(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry)
        {
			_ApiKeyAccessControlEntry.Reload();
			return _ApiKeyAccessControlEntry;
        }
		
		[WebMethod]
        public ApiKeyAccessControlEntry Create(System.String __Descriptor, System.String __UserName, System.Guid __Id)
        {
			return ApiKeyAccessControlEntry.CreateApiKeyAccessControlEntry(__Descriptor, __UserName, __Id);
        }
        
        [WebMethod]
        public void Delete(System.String __Descriptor, System.String __UserName, System.Guid __Id)
        {
			ApiKeyAccessControlEntry.DeleteApiKeyAccessControlEntry(__Descriptor, __UserName, __Id);
        }
        
        [WebMethod]
        public void UpdateObject(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry)
        {
			_ApiKeyAccessControlEntry.Update();
        }
		
		[WebMethod]
        public void CreateObject(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry)
        {
			_ApiKeyAccessControlEntry.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry)
        {
			_ApiKeyAccessControlEntry.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			ApiKeyAccessControlEntry.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			ApiKeyAccessControlEntry.Redo();
        }
		[WebMethod]
		public ApiKeyAccessControlEntryCollection GetByACL(Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList)
		{
			return ApiKeyAccessControlEntry.GetByACL( _ApiKeyAccessControlList);
		}
		[WebMethod]
		public ApiKeyAccessControlEntryCollection GetByACLPaged(Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList, long PagingStart, long PagingCount)
		{
			return ApiKeyAccessControlEntry.GetByACLPaged( _ApiKeyAccessControlList, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByACLCount(Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList)
		{
			return ApiKeyAccessControlEntry.GetByACLCount( _ApiKeyAccessControlList);
		}
		[WebMethod]
		public Services.Packages.Security.ApiKeyAccessControlList GetACL(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry)
		{
			_ApiKeyAccessControlEntry.Reload();
			return _ApiKeyAccessControlEntry.ACL;
		}
		[WebMethod]
		public void SetACL(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry, Services.Packages.Security.ApiKeyAccessControlList _ACL)
		{
			_ApiKeyAccessControlEntry.Reload();
			_ApiKeyAccessControlEntry.ACL = _ACL;
			_ApiKeyAccessControlEntry.Update();
		}
		[WebMethod]
		public ApiKeyAccessControlEntryCollection GetEntries(System.String Descriptor, Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList)
		{
			return ApiKeyAccessControlEntry.GetEntries(Descriptor,  _ApiKeyAccessControlList);
		}
		[WebMethod]
		public ApiKeyAccessControlEntryCollection GetEntriesPaged(System.String Descriptor, Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList, long PagingStart, long PagingCount)
		{
			return ApiKeyAccessControlEntry.GetEntriesPaged(Descriptor,  _ApiKeyAccessControlList, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetEntriesCount(System.String Descriptor, Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList)
		{
			return ApiKeyAccessControlEntry.GetEntriesCount(Descriptor,  _ApiKeyAccessControlList);
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.Security.ApiKeyAccessControlEntry model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("1b80d09e-e9f9-da05-8293-8e4d0d190a4d")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class ApiKeyAccessControlEntry : IApiKeyAccessControlEntry, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<IApiKeyAccessControlEntryService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<IApiKeyAccessControlEntryService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<IApiKeyAccessControlEntryService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.ApiKeyAccessControlEntry"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.ApiKeyAccessControlEntry"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.Security.ApiKeyAccessControlEntry.ProviderType");
				
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

		bool _ACLIsLoaded = false;
		Services.Packages.Security.ApiKeyAccessControlList _ACL;
		
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.ApiKeyAccessControlList ACL
		{
            get
            {
				if (!_ACLIsLoaded)
				{
					_ACL = new Services.Packages.Security.ApiKeyAccessControlList(_UserName, _Id);
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
		
		public static Services.Packages.Security.ApiKeyAccessControlList GetACL(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry)
		{
			return _ApiKeyAccessControlEntry.ACL;
		}

		public static ApiKeyAccessControlEntryCollection GetByACL(Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList)
        {
			ApiKeyAccessControlEntryCollection _ApiKeyAccessControlEntryCollection = new ApiKeyAccessControlEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeAcCoEnGetByACL", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_UserName;
				if (_ApiKeyAccessControlList != null) {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKeyAccessControlList.UserName);
				} else {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", DBNull.Value);
				}
				command.Parameters.Add(param_UserName);
				DbParameter param_Id;
				if (_ApiKeyAccessControlList != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Guid), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKeyAccessControlList.Id);
				} else {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", DBNull.Value);
				}
				command.Parameters.Add(param_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					ApiKeyAccessControlEntry o = new ApiKeyAccessControlEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				o._ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Id"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				
                    
                    _ApiKeyAccessControlEntryCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ApiKeyAccessControlEntryCollection;
        }
        
        public static ApiKeyAccessControlEntryCollection GetByACLPaged(Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList, long PagingStart, long PagingCount)
        {
			ApiKeyAccessControlEntryCollection _ApiKeyAccessControlEntryCollection = new ApiKeyAccessControlEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeAcCoEnGetByACLPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_UserName;
				if (_ApiKeyAccessControlList != null) {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKeyAccessControlList.UserName);
				} else {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", DBNull.Value);
				}
				command.Parameters.Add(param_UserName);
				DbParameter param_Id;
				if (_ApiKeyAccessControlList != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Guid), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKeyAccessControlList.Id);
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
					ApiKeyAccessControlEntry o = new ApiKeyAccessControlEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				o._ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Id"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				
                    
                    _ApiKeyAccessControlEntryCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ApiKeyAccessControlEntryCollection;
        }
        
        public static long GetByACLCount(Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeAcCoEnGetByACLCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_UserName;
				if (_ApiKeyAccessControlList != null) {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKeyAccessControlList.UserName);
				} else {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", DBNull.Value);
				}
				command.Parameters.Add(param_UserName);
				DbParameter param_Id;
				if (_ApiKeyAccessControlList != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Guid), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKeyAccessControlList.Id);
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

		public static ApiKeyAccessControlEntryCollection GetEntries(System.String _Descriptor, Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList)
        {
			ApiKeyAccessControlEntryCollection _ApiKeyAccessControlEntryCollection = new ApiKeyAccessControlEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeAcCoEnGeEn", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Descriptor = ClassConnectionProvider.Escape(_Descriptor);
				
                
                DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), -1);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_ApiKeyAccessControlList_UserName;
				if (_ApiKeyAccessControlList != null) {
				param_ApiKeyAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("ApKeAcCoLiUsNa", typeof(System.String), 128);
				param_ApiKeyAccessControlList_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKeyAccessControlList.UserName);
				} else {
				param_ApiKeyAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("ApKeAcCoLiUsNa", DBNull.Value);
				}
				command.Parameters.Add(param_ApiKeyAccessControlList_UserName);
				DbParameter param_ApiKeyAccessControlList_Id;
				if (_ApiKeyAccessControlList != null) {
				param_ApiKeyAccessControlList_Id = ClassConnectionProvider.GetDatabaseParameter("ApKeAcCoLiId", typeof(System.Guid), -1);
				param_ApiKeyAccessControlList_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKeyAccessControlList.Id);
				} else {
				param_ApiKeyAccessControlList_Id = ClassConnectionProvider.GetDatabaseParameter("ApKeAcCoLiId", DBNull.Value);
				}
				command.Parameters.Add(param_ApiKeyAccessControlList_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					ApiKeyAccessControlEntry o = new ApiKeyAccessControlEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				o._ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Id"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				
                    
                    _ApiKeyAccessControlEntryCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ApiKeyAccessControlEntryCollection;
        }
        
        public static ApiKeyAccessControlEntryCollection GetEntriesPaged(System.String _Descriptor, Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList, long PagingStart, long PagingCount)
        {
			ApiKeyAccessControlEntryCollection _ApiKeyAccessControlEntryCollection = new ApiKeyAccessControlEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeAcCoEnGeEnPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Descriptor = ClassConnectionProvider.Escape(_Descriptor);
				
                
                DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), -1);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_ApiKeyAccessControlList_UserName;
				if (_ApiKeyAccessControlList != null) {
				param_ApiKeyAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("ApKeAcCoLiUsNa", typeof(System.String), 128);
				param_ApiKeyAccessControlList_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKeyAccessControlList.UserName);
				} else {
				param_ApiKeyAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("ApKeAcCoLiUsNa", DBNull.Value);
				}
				command.Parameters.Add(param_ApiKeyAccessControlList_UserName);
				DbParameter param_ApiKeyAccessControlList_Id;
				if (_ApiKeyAccessControlList != null) {
				param_ApiKeyAccessControlList_Id = ClassConnectionProvider.GetDatabaseParameter("ApKeAcCoLiId", typeof(System.Guid), -1);
				param_ApiKeyAccessControlList_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKeyAccessControlList.Id);
				} else {
				param_ApiKeyAccessControlList_Id = ClassConnectionProvider.GetDatabaseParameter("ApKeAcCoLiId", DBNull.Value);
				}
				command.Parameters.Add(param_ApiKeyAccessControlList_Id);
				
                
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
					ApiKeyAccessControlEntry o = new ApiKeyAccessControlEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				o._ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Id"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				
                    
                    _ApiKeyAccessControlEntryCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ApiKeyAccessControlEntryCollection;
        }
        
        public static long GetEntriesCount(System.String _Descriptor, Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeAcCoEnGeEnCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Descriptor = ClassConnectionProvider.Escape(_Descriptor);
				
                
                DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), -1);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_ApiKeyAccessControlList_UserName;
				if (_ApiKeyAccessControlList != null) {
				param_ApiKeyAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("ApKeAcCoLiUsNa", typeof(System.String), 128);
				param_ApiKeyAccessControlList_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKeyAccessControlList.UserName);
				} else {
				param_ApiKeyAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("ApKeAcCoLiUsNa", DBNull.Value);
				}
				command.Parameters.Add(param_ApiKeyAccessControlList_UserName);
				DbParameter param_ApiKeyAccessControlList_Id;
				if (_ApiKeyAccessControlList != null) {
				param_ApiKeyAccessControlList_Id = ClassConnectionProvider.GetDatabaseParameter("ApKeAcCoLiId", typeof(System.Guid), -1);
				param_ApiKeyAccessControlList_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKeyAccessControlList.Id);
				} else {
				param_ApiKeyAccessControlList_Id = ClassConnectionProvider.GetDatabaseParameter("ApKeAcCoLiId", DBNull.Value);
				}
				command.Parameters.Add(param_ApiKeyAccessControlList_Id);
				
                
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
        
        public ApiKeyAccessControlEntry() {}
        
        public ApiKeyAccessControlEntry(System.String __Descriptor, System.String __UserName, System.Guid __Id)
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
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApKeAcCoEnRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
				DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), 128);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
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
        
        public void Read(System.String __Descriptor, System.String __UserName, System.Guid __Id)
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
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "ApKeAcCoEn");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApKeAcCoEnRead", dbconn);
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
				DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Guid), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(__Id);
				command.Parameters.Add(param_Id);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				_ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Id"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				
                    
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "ApKeAcCoEn");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApKeAcCoEnRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), 128);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Guid), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				_ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Id"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				
                    
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApKeAcCoEnCreate", dbconn);
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
				DbParameter param_ACL_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Guid), -1);
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
				_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				_ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Id"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				
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
        
        static public ApiKeyAccessControlEntry CreateApiKeyAccessControlEntry(System.String __Descriptor, System.String __UserName, System.Guid __Id)
        {
            ApiKeyAccessControlEntry o = new ApiKeyAccessControlEntry(__Descriptor, __UserName, __Id);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApKeAcCoEnUpdate", dbconn);
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
				DbParameter param_ACL_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Guid), -1);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApKeAcCoEnDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), 128);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
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
        
        static public void DeleteApiKeyAccessControlEntry(System.String __Descriptor, System.String __UserName, System.Guid __Id)
        {
            ApiKeyAccessControlEntry o = new ApiKeyAccessControlEntry(__Descriptor, __UserName, __Id);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(ApiKeyAccessControlEntry _object)
        {
			_ACL = null;
			_ACLIsLoaded = false;
			_Descriptor = _object._Descriptor;
			_UserName = _object._UserName;
			_Allow = _object._Allow;
			_Id = _object._Id;
			
        }
        
        public void CopyWithKeysTo(ApiKeyAccessControlEntry _object)
        {
			_object._ACL = null;
			_object._ACLIsLoaded = false;
			_object._Descriptor = _Descriptor;
			_object._UserName = _UserName;
			_object._Allow = _Allow;
			_object._Id = _Id;
			
        }
        
        static public void CopyWithKeysObject(ApiKeyAccessControlEntry _objectFrom, ApiKeyAccessControlEntry _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(ApiKeyAccessControlEntry _object)
        {
			_ACL = null;
			_ACLIsLoaded = false;
			_Allow = _object._Allow;
			
        }
        
        public void CopyTo(ApiKeyAccessControlEntry _object)
        {
			_object._ACL = null;
			_object._ACLIsLoaded = false;
			_object._Allow = _Allow;
			
        }
        
        static public void CopyObject(ApiKeyAccessControlEntry _objectFrom, ApiKeyAccessControlEntry _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(ApiKeyAccessControlEntry).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(ApiKeyAccessControlEntry).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(ApiKeyAccessControlEntry _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			ApiKeyAccessControlEntryUndoRedoCollection allUndidAndNotRedoneEntries = ApiKeyAccessControlEntryUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			ApiKeyAccessControlEntryUndoRedo _urobject = new ApiKeyAccessControlEntryUndoRedo();
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
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(ApiKeyAccessControlEntry).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = ApiKeyAccessControlEntryUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				ApiKeyAccessControlEntryUndoRedoCollection allOldUndoEntries = ApiKeyAccessControlEntryUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			ApiKeyAccessControlEntryUndoRedoCollection firstUndoEntries = ApiKeyAccessControlEntryUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			ApiKeyAccessControlEntryUndoRedo _urobject = firstUndoEntries[0];
			
			ApiKeyAccessControlEntry _object = new ApiKeyAccessControlEntry();
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
			ApiKeyAccessControlEntryUndoRedoCollection firstEntryToRedoEntries = ApiKeyAccessControlEntryUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			ApiKeyAccessControlEntryUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			ApiKeyAccessControlEntry _object = new ApiKeyAccessControlEntry();
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
    /// Defines the contract for the ApiKeyAccessControlEntryCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("4f3c6010-5f23-5a7c-e212-c81c4efaefc8")]
    public interface IApiKeyAccessControlEntryCollection : IEnumerable<ApiKeyAccessControlEntry>
    {
        int IndexOf(ApiKeyAccessControlEntry item);
        void Insert(int index, ApiKeyAccessControlEntry item);
        void RemoveAt(int index);
        ApiKeyAccessControlEntry this[int index] { get; set; }
        void Add(ApiKeyAccessControlEntry item);
        void Clear();
        bool Contains(ApiKeyAccessControlEntry item);
        void CopyTo(ApiKeyAccessControlEntry[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(ApiKeyAccessControlEntry item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.Security.ApiKeyAccessControlEntry
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("ca6d2572-9ba7-bc47-4ff0-525cb5430ee2")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class ApiKeyAccessControlEntryCollection : IApiKeyAccessControlEntryCollection, IList<ApiKeyAccessControlEntry>, IHierarchicalEnumerable
    {
        List<ApiKeyAccessControlEntry> _list = new List<ApiKeyAccessControlEntry>();
        
        public static implicit operator List<ApiKeyAccessControlEntry>(ApiKeyAccessControlEntryCollection collection)
        {
            return collection._list;
        }

        #region IList<ApiKeyAccessControlEntry> Members

        public int IndexOf(ApiKeyAccessControlEntry item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, ApiKeyAccessControlEntry item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public ApiKeyAccessControlEntry this[int index]
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

        #region ICollection<ApiKeyAccessControlEntry> Members

        public void Add(ApiKeyAccessControlEntry item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(ApiKeyAccessControlEntry item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(ApiKeyAccessControlEntry[] array, int arrayIndex)
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

        public bool Remove(ApiKeyAccessControlEntry item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<ApiKeyAccessControlEntry> Members

        public IEnumerator<ApiKeyAccessControlEntry> GetEnumerator()
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
	/// that share Services.Packages.Security.ApiKeyAccessControlEntry objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Security.Web.ApiKeyAccessControlEntryWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class ApiKeyAccessControlEntryWebService : WebService, IApiKeyAccessControlEntryService
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
        public bool Exists(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry)
        {
			return _ApiKeyAccessControlEntry.Exists;
        }
		
		[WebMethod]
		public ApiKeyAccessControlEntry Read(System.String __Descriptor, System.String __UserName, System.Guid __Id)
		{
			return new ApiKeyAccessControlEntry(__Descriptor, __UserName, __Id);
		}
		
		[WebMethod]
        public ApiKeyAccessControlEntry Reload(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry)
        {
			_ApiKeyAccessControlEntry.Reload();
			return _ApiKeyAccessControlEntry;
        }
		
		[WebMethod]
        public ApiKeyAccessControlEntry Create(System.String __Descriptor, System.String __UserName, System.Guid __Id)
        {
			return ApiKeyAccessControlEntry.CreateApiKeyAccessControlEntry(__Descriptor, __UserName, __Id);
        }
        
        [WebMethod]
        public void Delete(System.String __Descriptor, System.String __UserName, System.Guid __Id)
        {
			ApiKeyAccessControlEntry.DeleteApiKeyAccessControlEntry(__Descriptor, __UserName, __Id);
        }
        
        [WebMethod]
        public void UpdateObject(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry)
        {
			_ApiKeyAccessControlEntry.Update();
        }
		
		[WebMethod]
        public void CreateObject(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry)
        {
			_ApiKeyAccessControlEntry.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry)
        {
			_ApiKeyAccessControlEntry.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			ApiKeyAccessControlEntry.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			ApiKeyAccessControlEntry.Redo();
        }
		[WebMethod]
		public ApiKeyAccessControlEntryCollection GetByACL(Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList)
		{
			return ApiKeyAccessControlEntry.GetByACL( _ApiKeyAccessControlList);
		}
		[WebMethod]
		public ApiKeyAccessControlEntryCollection GetByACLPaged(Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList, long PagingStart, long PagingCount)
		{
			return ApiKeyAccessControlEntry.GetByACLPaged( _ApiKeyAccessControlList, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByACLCount(Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList)
		{
			return ApiKeyAccessControlEntry.GetByACLCount( _ApiKeyAccessControlList);
		}
		[WebMethod]
		public Services.Packages.Security.ApiKeyAccessControlList GetACL(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry)
		{
			_ApiKeyAccessControlEntry.Reload();
			return _ApiKeyAccessControlEntry.ACL;
		}
		[WebMethod]
		public void SetACL(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry, Services.Packages.Security.ApiKeyAccessControlList _ACL)
		{
			_ApiKeyAccessControlEntry.Reload();
			_ApiKeyAccessControlEntry.ACL = _ACL;
			_ApiKeyAccessControlEntry.Update();
		}
		[WebMethod]
		public ApiKeyAccessControlEntryCollection GetEntries(System.String Descriptor, Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList)
		{
			return ApiKeyAccessControlEntry.GetEntries(Descriptor,  _ApiKeyAccessControlList);
		}
		[WebMethod]
		public ApiKeyAccessControlEntryCollection GetEntriesPaged(System.String Descriptor, Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList, long PagingStart, long PagingCount)
		{
			return ApiKeyAccessControlEntry.GetEntriesPaged(Descriptor,  _ApiKeyAccessControlList, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetEntriesCount(System.String Descriptor, Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList)
		{
			return ApiKeyAccessControlEntry.GetEntriesCount(Descriptor,  _ApiKeyAccessControlList);
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="ApiKeyAccessControlEntryWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("adc867dc-1a31-3e54-5425-38e621e88b87")]
    sealed public class ApiKeyAccessControlEntryWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IApiKeyAccessControlEntryService
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
		public ApiKeyAccessControlEntryWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public ApiKeyAccessControlEntryWebServiceClient()
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
		public bool Exists(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry)
        {
			object[] results = this.Invoke("Exists", new object[] {_ApiKeyAccessControlEntry});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyAccessControlEntry Read(System.String __Descriptor, System.String __UserName, System.Guid __Id)
		{
			object[] results = this.Invoke("Read", new object[] {__Descriptor, __UserName, __Id});
			return ((ApiKeyAccessControlEntry)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyAccessControlEntry Reload(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry)
        {
			object[] results = this.Invoke("Reload", new object[] {_ApiKeyAccessControlEntry});
			return ((ApiKeyAccessControlEntry)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyAccessControlEntry Create(System.String __Descriptor, System.String __UserName, System.Guid __Id)
        {
			object[] results = this.Invoke("Create", new object[] {__Descriptor, __UserName, __Id});
			return ((ApiKeyAccessControlEntry)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __Descriptor, System.String __UserName, System.Guid __Id)
        {
			this.Invoke("Delete", new object[] {__Descriptor, __UserName, __Id});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry)
        {
			this.Invoke("UpdateObject", new object[] {_ApiKeyAccessControlEntry});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry)
        {
			this.Invoke("CreateObject", new object[] {_ApiKeyAccessControlEntry});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry)
        {
			this.Invoke("DeleteObject", new object[] {_ApiKeyAccessControlEntry});
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
		public ApiKeyAccessControlEntryCollection GetByACL(Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList) {
			object[] results = this.Invoke("GetByACL", new object[] {_ApiKeyAccessControlList});
			return ((ApiKeyAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByACLPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyAccessControlEntryCollection GetByACLPaged(Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByACLPaged", new object[] {_ApiKeyAccessControlList,PagingStart,PagingCount});
			return ((ApiKeyAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByACLCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByACLCount(Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList) {
			object[] results = this.Invoke("GetByACLCount", new object[] {_ApiKeyAccessControlList});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACL", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ApiKeyAccessControlList GetACL(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry)
		{
			object[] results = this.Invoke("GetACL", new object[] {_ApiKeyAccessControlEntry});
			return ((Services.Packages.Security.ApiKeyAccessControlList)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACL", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACL(ApiKeyAccessControlEntry _ApiKeyAccessControlEntry, Services.Packages.Security.ApiKeyAccessControlList _ACL)
		{
			this.Invoke("GetACL", new object[] {_ApiKeyAccessControlEntry});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetEntries", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyAccessControlEntryCollection GetEntries(System.String Descriptor, Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList) {
			object[] results = this.Invoke("GetEntries", new object[] {Descriptor, _ApiKeyAccessControlList});
			return ((ApiKeyAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetEntriesPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyAccessControlEntryCollection GetEntriesPaged(System.String Descriptor, Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetEntriesPaged", new object[] {Descriptor, _ApiKeyAccessControlList,PagingStart,PagingCount});
			return ((ApiKeyAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetEntriesCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetEntriesCount(System.String Descriptor, Services.Packages.Security.ApiKeyAccessControlList _ApiKeyAccessControlList) {
			object[] results = this.Invoke("GetEntriesCount", new object[] {Descriptor, _ApiKeyAccessControlList});
			return ((long)(results[0]));
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages.Security
