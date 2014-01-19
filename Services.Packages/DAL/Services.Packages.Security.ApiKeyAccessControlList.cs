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
    /// Defines the contract for the ApiKeyAccessControlList class
    /// </summary>
    [ComVisible(true)]
    [Guid("b1acd3c9-5007-dc94-d9ad-07882bdada66")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IApiKeyAccessControlList
	{
		bool Exists { get; }
		System.String UserName { get; set; }
		System.Guid Id { get; set; }
		Services.Packages.Security.ModelUser User { get; set; }
		Services.Packages.ApiKey ApiKey { get; set; }
		Services.Packages.Security.ApiKeyAccessControlEntryCollection ACEs { get; set; }
		Services.Packages.Security.ApiKeyAccessControlEntryCollection GetEntries(System.String Descriptor);

		void Read(System.String __UserName, System.Guid __Id);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(ApiKeyAccessControlList _object);
		void CopyWithKeysTo(ApiKeyAccessControlList _object);
		void CopyFrom(ApiKeyAccessControlList _object);
		void CopyTo(ApiKeyAccessControlList _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.Security.ApiKeyAccessControlList type.
    /// </summary>
    [ComVisible(true)]
    [Guid("3823d7af-b38b-46b4-a50c-4e84d9c9af83")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IApiKeyAccessControlListService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(ApiKeyAccessControlList _ApiKeyAccessControlList);
		[OperationContract]
        ApiKeyAccessControlList Read(System.String __UserName, System.Guid __Id);
        [OperationContract]
        ApiKeyAccessControlList Reload(ApiKeyAccessControlList _ApiKeyAccessControlList);
        [OperationContract]
        ApiKeyAccessControlList Create(System.String __UserName, System.Guid __Id);
        [OperationContract]
        void Delete(System.String __UserName, System.Guid __Id);
        [OperationContract]
        void UpdateObject(ApiKeyAccessControlList _ApiKeyAccessControlList);
        [OperationContract]
        void CreateObject(ApiKeyAccessControlList _ApiKeyAccessControlList);
        [OperationContract]
        void DeleteObject(ApiKeyAccessControlList _ApiKeyAccessControlList);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		ApiKeyAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		ApiKeyAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		Services.Packages.Security.ModelUser GetUser(ApiKeyAccessControlList _ApiKeyAccessControlList);
		[OperationContract]
		void SetUser(ApiKeyAccessControlList _ApiKeyAccessControlList, Services.Packages.Security.ModelUser _User);
		[OperationContract]
		ApiKeyAccessControlListCollection GetByApiKey(Services.Packages.ApiKey _ApiKey);
		[OperationContract]
		ApiKeyAccessControlListCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey);
		[OperationContract]
		Services.Packages.ApiKey GetApiKey(ApiKeyAccessControlList _ApiKeyAccessControlList);
		[OperationContract]
		void SetApiKey(ApiKeyAccessControlList _ApiKeyAccessControlList, Services.Packages.ApiKey _ApiKey);
		[OperationContract]
		ApiKeyAccessControlListCollection GetACLs(System.String UserName, Services.Packages.ApiKey _ApiKey);
		[OperationContract]
		ApiKeyAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount);
		[OperationContract]
		long GetACLsCount(System.String UserName, Services.Packages.ApiKey _ApiKey);
		[OperationContract]
		Services.Packages.Security.ApiKeyAccessControlEntryCollection GetACEs(ApiKeyAccessControlList _ApiKeyAccessControlList);
		[OperationContract]
		void SetACEs(ApiKeyAccessControlList _ApiKeyAccessControlList, Services.Packages.Security.ApiKeyAccessControlEntryCollection _ACEs);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.Security.ApiKeyAccessControlList type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("e723339f-58a6-af0c-1381-cc098d1efb4f")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class ApiKeyAccessControlListService : IApiKeyAccessControlListService
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
        public bool Exists(ApiKeyAccessControlList _ApiKeyAccessControlList)
        {
			return _ApiKeyAccessControlList.Exists;
        }
		
		[WebMethod]
		public ApiKeyAccessControlList Read(System.String __UserName, System.Guid __Id)
		{
			return new ApiKeyAccessControlList(__UserName, __Id);
		}
		
		[WebMethod]
        public ApiKeyAccessControlList Reload(ApiKeyAccessControlList _ApiKeyAccessControlList)
        {
			_ApiKeyAccessControlList.Reload();
			return _ApiKeyAccessControlList;
        }
		
		[WebMethod]
        public ApiKeyAccessControlList Create(System.String __UserName, System.Guid __Id)
        {
			return ApiKeyAccessControlList.CreateApiKeyAccessControlList(__UserName, __Id);
        }
        
        [WebMethod]
        public void Delete(System.String __UserName, System.Guid __Id)
        {
			ApiKeyAccessControlList.DeleteApiKeyAccessControlList(__UserName, __Id);
        }
        
        [WebMethod]
        public void UpdateObject(ApiKeyAccessControlList _ApiKeyAccessControlList)
        {
			_ApiKeyAccessControlList.Update();
        }
		
		[WebMethod]
        public void CreateObject(ApiKeyAccessControlList _ApiKeyAccessControlList)
        {
			_ApiKeyAccessControlList.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ApiKeyAccessControlList _ApiKeyAccessControlList)
        {
			_ApiKeyAccessControlList.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			ApiKeyAccessControlList.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			ApiKeyAccessControlList.Redo();
        }
		[WebMethod]
		public ApiKeyAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ApiKeyAccessControlList.GetByUser( _ModelUser);
		}
		[WebMethod]
		public ApiKeyAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ApiKeyAccessControlList.GetByUserPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ApiKeyAccessControlList.GetByUserCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUser(ApiKeyAccessControlList _ApiKeyAccessControlList)
		{
			_ApiKeyAccessControlList.Reload();
			return _ApiKeyAccessControlList.User;
		}
		[WebMethod]
		public void SetUser(ApiKeyAccessControlList _ApiKeyAccessControlList, Services.Packages.Security.ModelUser _User)
		{
			_ApiKeyAccessControlList.Reload();
			_ApiKeyAccessControlList.User = _User;
			_ApiKeyAccessControlList.Update();
		}
		[WebMethod]
		public ApiKeyAccessControlListCollection GetByApiKey(Services.Packages.ApiKey _ApiKey)
		{
			return ApiKeyAccessControlList.GetByApiKey( _ApiKey);
		}
		[WebMethod]
		public ApiKeyAccessControlListCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
		{
			return ApiKeyAccessControlList.GetByApiKeyPaged( _ApiKey, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey)
		{
			return ApiKeyAccessControlList.GetByApiKeyCount( _ApiKey);
		}
		[WebMethod]
		public Services.Packages.ApiKey GetApiKey(ApiKeyAccessControlList _ApiKeyAccessControlList)
		{
			_ApiKeyAccessControlList.Reload();
			return _ApiKeyAccessControlList.ApiKey;
		}
		[WebMethod]
		public void SetApiKey(ApiKeyAccessControlList _ApiKeyAccessControlList, Services.Packages.ApiKey _ApiKey)
		{
			_ApiKeyAccessControlList.Reload();
			_ApiKeyAccessControlList.ApiKey = _ApiKey;
			_ApiKeyAccessControlList.Update();
		}
		[WebMethod]
		public ApiKeyAccessControlListCollection GetACLs(System.String UserName, Services.Packages.ApiKey _ApiKey)
		{
			return ApiKeyAccessControlList.GetACLs(UserName,  _ApiKey);
		}
		[WebMethod]
		public ApiKeyAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
		{
			return ApiKeyAccessControlList.GetACLsPaged(UserName,  _ApiKey, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetACLsCount(System.String UserName, Services.Packages.ApiKey _ApiKey)
		{
			return ApiKeyAccessControlList.GetACLsCount(UserName,  _ApiKey);
		}
		[WebMethod]
		public Services.Packages.Security.ApiKeyAccessControlEntryCollection GetACEs(ApiKeyAccessControlList _ApiKeyAccessControlList)
		{
			_ApiKeyAccessControlList.Reload();
			return _ApiKeyAccessControlList.ACEs;
		}
		[WebMethod]
		public void SetACEs(ApiKeyAccessControlList _ApiKeyAccessControlList, Services.Packages.Security.ApiKeyAccessControlEntryCollection _ACEs)
		{
			_ApiKeyAccessControlList.Reload();
			_ApiKeyAccessControlList.ACEs = _ACEs;
			_ApiKeyAccessControlList.Update();
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.Security.ApiKeyAccessControlList model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("f6ffae52-0b68-159a-1e66-0cfa02100310")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class ApiKeyAccessControlList : IApiKeyAccessControlList, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<IApiKeyAccessControlListService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<IApiKeyAccessControlListService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<IApiKeyAccessControlListService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.ApiKeyAccessControlList"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.ApiKeyAccessControlList"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.Security.ApiKeyAccessControlList.ProviderType");
				
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
		
		public static Services.Packages.Security.ModelUser GetUser(ApiKeyAccessControlList _ApiKeyAccessControlList)
		{
			return _ApiKeyAccessControlList.User;
		}

		bool _ApiKeyIsLoaded = false;
		Services.Packages.ApiKey _ApiKey;
		
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.ApiKey ApiKey
		{
            get
            {
				if (!_ApiKeyIsLoaded)
				{
					_ApiKey = new Services.Packages.ApiKey(_Id);
					if (_ApiKey.Exists)
						_ApiKeyIsLoaded = true;
					else _ApiKey = null;
				}
                return _ApiKey;
            }
            set
            {
                _ApiKey = value;
                _ApiKeyIsLoaded = true;
                if (_ApiKey != null)
                {
					if (_ApiKey.Exists)
					{
						_Id = _ApiKey.Id;
						
					}
					else
					{
						_ApiKey = null;
					}
				}
            }
		}
		
		public static Services.Packages.ApiKey GetApiKey(ApiKeyAccessControlList _ApiKeyAccessControlList)
		{
			return _ApiKeyAccessControlList.ApiKey;
		}

		public static ApiKeyAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
        {
			ApiKeyAccessControlListCollection _ApiKeyAccessControlListCollection = new ApiKeyAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeAcCoLiGetByUs", dbconn);
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
					ApiKeyAccessControlList o = new ApiKeyAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._ApiKeyIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				
                    
                    _ApiKeyAccessControlListCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ApiKeyAccessControlListCollection;
        }
        
        public static ApiKeyAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			ApiKeyAccessControlListCollection _ApiKeyAccessControlListCollection = new ApiKeyAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeAcCoLiGetByUsPaged", dbconn);
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
					ApiKeyAccessControlList o = new ApiKeyAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._ApiKeyIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				
                    
                    _ApiKeyAccessControlListCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ApiKeyAccessControlListCollection;
        }
        
        public static long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeAcCoLiGetByUsCount", dbconn);
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

		public static ApiKeyAccessControlListCollection GetByApiKey(Services.Packages.ApiKey _ApiKey)
        {
			ApiKeyAccessControlListCollection _ApiKeyAccessControlListCollection = new ApiKeyAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeAcCoLiGetByApKe", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Id;
				if (_ApiKey != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Guid), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey.Id);
				} else {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", DBNull.Value);
				}
				command.Parameters.Add(param_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					ApiKeyAccessControlList o = new ApiKeyAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._ApiKeyIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				
                    
                    _ApiKeyAccessControlListCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ApiKeyAccessControlListCollection;
        }
        
        public static ApiKeyAccessControlListCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
        {
			ApiKeyAccessControlListCollection _ApiKeyAccessControlListCollection = new ApiKeyAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeAcCoLiGetByApKePaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Id;
				if (_ApiKey != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Guid), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey.Id);
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
					ApiKeyAccessControlList o = new ApiKeyAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._ApiKeyIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				
                    
                    _ApiKeyAccessControlListCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ApiKeyAccessControlListCollection;
        }
        
        public static long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeAcCoLiGetByApKeCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Id;
				if (_ApiKey != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Guid), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey.Id);
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

		public static ApiKeyAccessControlListCollection GetACLs(System.String _UserName, Services.Packages.ApiKey _ApiKey)
        {
			ApiKeyAccessControlListCollection _ApiKeyAccessControlListCollection = new ApiKeyAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeAcCoLiGeACLs", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UserName = ClassConnectionProvider.Escape(_UserName);
				
                
                DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), -1);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_ApiKey_Id;
				if (_ApiKey != null) {
				param_ApiKey_Id = ClassConnectionProvider.GetDatabaseParameter("ApKeId", typeof(System.Guid), -1);
				param_ApiKey_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey.Id);
				} else {
				param_ApiKey_Id = ClassConnectionProvider.GetDatabaseParameter("ApKeId", DBNull.Value);
				}
				command.Parameters.Add(param_ApiKey_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					ApiKeyAccessControlList o = new ApiKeyAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._ApiKeyIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				
                    
                    _ApiKeyAccessControlListCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ApiKeyAccessControlListCollection;
        }
        
        public static ApiKeyAccessControlListCollection GetACLsPaged(System.String _UserName, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
        {
			ApiKeyAccessControlListCollection _ApiKeyAccessControlListCollection = new ApiKeyAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeAcCoLiGeACLsPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UserName = ClassConnectionProvider.Escape(_UserName);
				
                
                DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), -1);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_ApiKey_Id;
				if (_ApiKey != null) {
				param_ApiKey_Id = ClassConnectionProvider.GetDatabaseParameter("ApKeId", typeof(System.Guid), -1);
				param_ApiKey_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey.Id);
				} else {
				param_ApiKey_Id = ClassConnectionProvider.GetDatabaseParameter("ApKeId", DBNull.Value);
				}
				command.Parameters.Add(param_ApiKey_Id);
				
                
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
					ApiKeyAccessControlList o = new ApiKeyAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._ApiKeyIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				
                    
                    _ApiKeyAccessControlListCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ApiKeyAccessControlListCollection;
        }
        
        public static long GetACLsCount(System.String _UserName, Services.Packages.ApiKey _ApiKey)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApKeAcCoLiGeACLsCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UserName = ClassConnectionProvider.Escape(_UserName);
				
                
                DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), -1);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_ApiKey_Id;
				if (_ApiKey != null) {
				param_ApiKey_Id = ClassConnectionProvider.GetDatabaseParameter("ApKeId", typeof(System.Guid), -1);
				param_ApiKey_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey.Id);
				} else {
				param_ApiKey_Id = ClassConnectionProvider.GetDatabaseParameter("ApKeId", DBNull.Value);
				}
				command.Parameters.Add(param_ApiKey_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		Services.Packages.Security.ApiKeyAccessControlEntryCollection _ACEs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.ApiKeyAccessControlEntryCollection ACEs
		{
            get
            {
				if (_ACEs == null)
					_ACEs = Services.Packages.Security.ApiKeyAccessControlEntry.GetByACL(this);
				
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
			_ACEs = Services.Packages.Security.ApiKeyAccessControlEntry.GetByACL(this);
		}

		public Services.Packages.Security.ApiKeyAccessControlEntryCollection GetEntries(System.String Descriptor)
		{
			return Services.Packages.Security.ApiKeyAccessControlEntry.GetEntries(Descriptor,  this);
		}

		public bool Exists
        {
            get {
				if (!__hasBeenReadOnce)
					Exist();
				
				return __databaseState == RowState.Initialized;
			}
        }
        
        public ApiKeyAccessControlList() {}
        
        public ApiKeyAccessControlList(System.String __UserName, System.Guid __Id)
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
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApKeAcCoLiRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
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
        
        public void Read(System.String __UserName, System.Guid __Id)
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
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "ApKeAcCoLi");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApKeAcCoLiRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
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
						_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				_UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_ApiKeyIsLoaded = false; if (dr["Id"] == DBNull.Value) { _ApiKey = null; _ApiKeyIsLoaded = true; }  else _Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				
                    
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "ApKeAcCoLi");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApKeAcCoLiRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
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
						_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				_UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_ApiKeyIsLoaded = false; if (dr["Id"] == DBNull.Value) { _ApiKey = null; _ApiKeyIsLoaded = true; }  else _Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				
                    
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApKeAcCoLiCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_User_Name = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_User_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				if (_User == null && _UserIsLoaded == true) param_User_Name.Value = DBNull.Value;
				command.Parameters.Add(param_User_Name);
				DbParameter param_ApiKey_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Guid), -1);
				param_ApiKey_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				if (_ApiKey == null && _ApiKeyIsLoaded == true) param_ApiKey_Id.Value = DBNull.Value;
				command.Parameters.Add(param_ApiKey_Id);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				_UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_ApiKeyIsLoaded = false; if (dr["Id"] == DBNull.Value) { _ApiKey = null; _ApiKeyIsLoaded = true; }  else _Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Guid));
				
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
        
        static public ApiKeyAccessControlList CreateApiKeyAccessControlList(System.String __UserName, System.Guid __Id)
        {
            ApiKeyAccessControlList o = new ApiKeyAccessControlList(__UserName, __Id);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApKeAcCoLiUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_UserHasChanged = ClassConnectionProvider.GetDatabaseParameter("UserHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_UserIsLoaded));
				command.Parameters.Add(param_UserHasChanged);
				DbParameter param_User_Name = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_User_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				if (_User == null && _UserIsLoaded == true) param_User_Name.Value = DBNull.Value;
				command.Parameters.Add(param_User_Name);
				DbParameter param_ApiKeyHasChanged = ClassConnectionProvider.GetDatabaseParameter("ApiKeyHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_ApiKeyIsLoaded));
				command.Parameters.Add(param_ApiKeyHasChanged);
				DbParameter param_ApiKey_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Guid), -1);
				param_ApiKey_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				if (_ApiKey == null && _ApiKeyIsLoaded == true) param_ApiKey_Id.Value = DBNull.Value;
				command.Parameters.Add(param_ApiKey_Id);
				

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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApKeAcCoLiDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
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
        
        static public void DeleteApiKeyAccessControlList(System.String __UserName, System.Guid __Id)
        {
            ApiKeyAccessControlList o = new ApiKeyAccessControlList(__UserName, __Id);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(ApiKeyAccessControlList _object)
        {
			_User = null;
			_UserIsLoaded = false;
			_ApiKey = null;
			_ApiKeyIsLoaded = false;
			_UserName = _object._UserName;
			_Id = _object._Id;
			
        }
        
        public void CopyWithKeysTo(ApiKeyAccessControlList _object)
        {
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._ApiKey = null;
			_object._ApiKeyIsLoaded = false;
			_object._UserName = _UserName;
			_object._Id = _Id;
			
        }
        
        static public void CopyWithKeysObject(ApiKeyAccessControlList _objectFrom, ApiKeyAccessControlList _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(ApiKeyAccessControlList _object)
        {
			_User = null;
			_UserIsLoaded = false;
			_ApiKey = null;
			_ApiKeyIsLoaded = false;
			
        }
        
        public void CopyTo(ApiKeyAccessControlList _object)
        {
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._ApiKey = null;
			_object._ApiKeyIsLoaded = false;
			
        }
        
        static public void CopyObject(ApiKeyAccessControlList _objectFrom, ApiKeyAccessControlList _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(ApiKeyAccessControlList).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(ApiKeyAccessControlList).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(ApiKeyAccessControlList _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			ApiKeyAccessControlListUndoRedoCollection allUndidAndNotRedoneEntries = ApiKeyAccessControlListUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			ApiKeyAccessControlListUndoRedo _urobject = new ApiKeyAccessControlListUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.User_Name = _object._User_Name;
			_urobject.ApiKey_Id = _object._ApiKey_Id;
			_urobject.UserName = _object._UserName;
			_urobject.Id = _object._Id;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(ApiKeyAccessControlList).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = ApiKeyAccessControlListUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				ApiKeyAccessControlListUndoRedoCollection allOldUndoEntries = ApiKeyAccessControlListUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			ApiKeyAccessControlListUndoRedoCollection firstUndoEntries = ApiKeyAccessControlListUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			ApiKeyAccessControlListUndoRedo _urobject = firstUndoEntries[0];
			
			ApiKeyAccessControlList _object = new ApiKeyAccessControlList();
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._User_Name = _urobject.User_Name;
			_object._ApiKey = null;
			_object._ApiKeyIsLoaded = false;
			_object._ApiKey_Id = _urobject.ApiKey_Id;
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
			ApiKeyAccessControlListUndoRedoCollection firstEntryToRedoEntries = ApiKeyAccessControlListUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			ApiKeyAccessControlListUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			ApiKeyAccessControlList _object = new ApiKeyAccessControlList();
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._User_Name = _urobject.User_Name;
			_object._ApiKey = null;
			_object._ApiKeyIsLoaded = false;
			_object._ApiKey_Id = _urobject.ApiKey_Id;
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
    /// Defines the contract for the ApiKeyAccessControlListCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("f8e883fd-f3b7-56c0-ca73-240ae7abb886")]
    public interface IApiKeyAccessControlListCollection : IEnumerable<ApiKeyAccessControlList>
    {
        int IndexOf(ApiKeyAccessControlList item);
        void Insert(int index, ApiKeyAccessControlList item);
        void RemoveAt(int index);
        ApiKeyAccessControlList this[int index] { get; set; }
        void Add(ApiKeyAccessControlList item);
        void Clear();
        bool Contains(ApiKeyAccessControlList item);
        void CopyTo(ApiKeyAccessControlList[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(ApiKeyAccessControlList item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.Security.ApiKeyAccessControlList
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("2b32fe11-b9c9-941b-990d-c83f4c11ad03")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class ApiKeyAccessControlListCollection : IApiKeyAccessControlListCollection, IList<ApiKeyAccessControlList>, IHierarchicalEnumerable
    {
        List<ApiKeyAccessControlList> _list = new List<ApiKeyAccessControlList>();
        
        public static implicit operator List<ApiKeyAccessControlList>(ApiKeyAccessControlListCollection collection)
        {
            return collection._list;
        }

        #region IList<ApiKeyAccessControlList> Members

        public int IndexOf(ApiKeyAccessControlList item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, ApiKeyAccessControlList item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public ApiKeyAccessControlList this[int index]
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

        #region ICollection<ApiKeyAccessControlList> Members

        public void Add(ApiKeyAccessControlList item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(ApiKeyAccessControlList item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(ApiKeyAccessControlList[] array, int arrayIndex)
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

        public bool Remove(ApiKeyAccessControlList item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<ApiKeyAccessControlList> Members

        public IEnumerator<ApiKeyAccessControlList> GetEnumerator()
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
	/// that share Services.Packages.Security.ApiKeyAccessControlList objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Security.Web.ApiKeyAccessControlListWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class ApiKeyAccessControlListWebService : WebService, IApiKeyAccessControlListService
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
        public bool Exists(ApiKeyAccessControlList _ApiKeyAccessControlList)
        {
			return _ApiKeyAccessControlList.Exists;
        }
		
		[WebMethod]
		public ApiKeyAccessControlList Read(System.String __UserName, System.Guid __Id)
		{
			return new ApiKeyAccessControlList(__UserName, __Id);
		}
		
		[WebMethod]
        public ApiKeyAccessControlList Reload(ApiKeyAccessControlList _ApiKeyAccessControlList)
        {
			_ApiKeyAccessControlList.Reload();
			return _ApiKeyAccessControlList;
        }
		
		[WebMethod]
        public ApiKeyAccessControlList Create(System.String __UserName, System.Guid __Id)
        {
			return ApiKeyAccessControlList.CreateApiKeyAccessControlList(__UserName, __Id);
        }
        
        [WebMethod]
        public void Delete(System.String __UserName, System.Guid __Id)
        {
			ApiKeyAccessControlList.DeleteApiKeyAccessControlList(__UserName, __Id);
        }
        
        [WebMethod]
        public void UpdateObject(ApiKeyAccessControlList _ApiKeyAccessControlList)
        {
			_ApiKeyAccessControlList.Update();
        }
		
		[WebMethod]
        public void CreateObject(ApiKeyAccessControlList _ApiKeyAccessControlList)
        {
			_ApiKeyAccessControlList.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ApiKeyAccessControlList _ApiKeyAccessControlList)
        {
			_ApiKeyAccessControlList.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			ApiKeyAccessControlList.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			ApiKeyAccessControlList.Redo();
        }
		[WebMethod]
		public ApiKeyAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ApiKeyAccessControlList.GetByUser( _ModelUser);
		}
		[WebMethod]
		public ApiKeyAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ApiKeyAccessControlList.GetByUserPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ApiKeyAccessControlList.GetByUserCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUser(ApiKeyAccessControlList _ApiKeyAccessControlList)
		{
			_ApiKeyAccessControlList.Reload();
			return _ApiKeyAccessControlList.User;
		}
		[WebMethod]
		public void SetUser(ApiKeyAccessControlList _ApiKeyAccessControlList, Services.Packages.Security.ModelUser _User)
		{
			_ApiKeyAccessControlList.Reload();
			_ApiKeyAccessControlList.User = _User;
			_ApiKeyAccessControlList.Update();
		}
		[WebMethod]
		public ApiKeyAccessControlListCollection GetByApiKey(Services.Packages.ApiKey _ApiKey)
		{
			return ApiKeyAccessControlList.GetByApiKey( _ApiKey);
		}
		[WebMethod]
		public ApiKeyAccessControlListCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
		{
			return ApiKeyAccessControlList.GetByApiKeyPaged( _ApiKey, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey)
		{
			return ApiKeyAccessControlList.GetByApiKeyCount( _ApiKey);
		}
		[WebMethod]
		public Services.Packages.ApiKey GetApiKey(ApiKeyAccessControlList _ApiKeyAccessControlList)
		{
			_ApiKeyAccessControlList.Reload();
			return _ApiKeyAccessControlList.ApiKey;
		}
		[WebMethod]
		public void SetApiKey(ApiKeyAccessControlList _ApiKeyAccessControlList, Services.Packages.ApiKey _ApiKey)
		{
			_ApiKeyAccessControlList.Reload();
			_ApiKeyAccessControlList.ApiKey = _ApiKey;
			_ApiKeyAccessControlList.Update();
		}
		[WebMethod]
		public ApiKeyAccessControlListCollection GetACLs(System.String UserName, Services.Packages.ApiKey _ApiKey)
		{
			return ApiKeyAccessControlList.GetACLs(UserName,  _ApiKey);
		}
		[WebMethod]
		public ApiKeyAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
		{
			return ApiKeyAccessControlList.GetACLsPaged(UserName,  _ApiKey, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetACLsCount(System.String UserName, Services.Packages.ApiKey _ApiKey)
		{
			return ApiKeyAccessControlList.GetACLsCount(UserName,  _ApiKey);
		}
		[WebMethod]
		public Services.Packages.Security.ApiKeyAccessControlEntryCollection GetACEs(ApiKeyAccessControlList _ApiKeyAccessControlList)
		{
			_ApiKeyAccessControlList.Reload();
			return _ApiKeyAccessControlList.ACEs;
		}
		[WebMethod]
		public void SetACEs(ApiKeyAccessControlList _ApiKeyAccessControlList, Services.Packages.Security.ApiKeyAccessControlEntryCollection _ACEs)
		{
			_ApiKeyAccessControlList.Reload();
			_ApiKeyAccessControlList.ACEs = _ACEs;
			_ApiKeyAccessControlList.Update();
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="ApiKeyAccessControlListWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("090bbc7d-0336-5f98-eda9-2bf4e6902e72")]
    sealed public class ApiKeyAccessControlListWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IApiKeyAccessControlListService
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
		public ApiKeyAccessControlListWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public ApiKeyAccessControlListWebServiceClient()
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
		public bool Exists(ApiKeyAccessControlList _ApiKeyAccessControlList)
        {
			object[] results = this.Invoke("Exists", new object[] {_ApiKeyAccessControlList});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyAccessControlList Read(System.String __UserName, System.Guid __Id)
		{
			object[] results = this.Invoke("Read", new object[] {__UserName, __Id});
			return ((ApiKeyAccessControlList)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyAccessControlList Reload(ApiKeyAccessControlList _ApiKeyAccessControlList)
        {
			object[] results = this.Invoke("Reload", new object[] {_ApiKeyAccessControlList});
			return ((ApiKeyAccessControlList)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyAccessControlList Create(System.String __UserName, System.Guid __Id)
        {
			object[] results = this.Invoke("Create", new object[] {__UserName, __Id});
			return ((ApiKeyAccessControlList)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __UserName, System.Guid __Id)
        {
			this.Invoke("Delete", new object[] {__UserName, __Id});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(ApiKeyAccessControlList _ApiKeyAccessControlList)
        {
			this.Invoke("UpdateObject", new object[] {_ApiKeyAccessControlList});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(ApiKeyAccessControlList _ApiKeyAccessControlList)
        {
			this.Invoke("CreateObject", new object[] {_ApiKeyAccessControlList});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(ApiKeyAccessControlList _ApiKeyAccessControlList)
        {
			this.Invoke("DeleteObject", new object[] {_ApiKeyAccessControlList});
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
		public ApiKeyAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByUser", new object[] {_ModelUser});
			return ((ApiKeyAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByUserPaged", new object[] {_ModelUser,PagingStart,PagingCount});
			return ((ApiKeyAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByUserCount", new object[] {_ModelUser});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetUser(ApiKeyAccessControlList _ApiKeyAccessControlList)
		{
			object[] results = this.Invoke("GetUser", new object[] {_ApiKeyAccessControlList});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetUser(ApiKeyAccessControlList _ApiKeyAccessControlList, Services.Packages.Security.ModelUser _User)
		{
			this.Invoke("GetUser", new object[] {_ApiKeyAccessControlList});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyAccessControlListCollection GetByApiKey(Services.Packages.ApiKey _ApiKey) {
			object[] results = this.Invoke("GetByApiKey", new object[] {_ApiKey});
			return ((ApiKeyAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByApiKeyPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyAccessControlListCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByApiKeyPaged", new object[] {_ApiKey,PagingStart,PagingCount});
			return ((ApiKeyAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByApiKeyCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey) {
			object[] results = this.Invoke("GetByApiKeyCount", new object[] {_ApiKey});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.ApiKey GetApiKey(ApiKeyAccessControlList _ApiKeyAccessControlList)
		{
			object[] results = this.Invoke("GetApiKey", new object[] {_ApiKeyAccessControlList});
			return ((Services.Packages.ApiKey)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetApiKey(ApiKeyAccessControlList _ApiKeyAccessControlList, Services.Packages.ApiKey _ApiKey)
		{
			this.Invoke("GetApiKey", new object[] {_ApiKeyAccessControlList});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyAccessControlListCollection GetACLs(System.String UserName, Services.Packages.ApiKey _ApiKey) {
			object[] results = this.Invoke("GetACLs", new object[] {UserName, _ApiKey});
			return ((ApiKeyAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLsPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApiKeyAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetACLsPaged", new object[] {UserName, _ApiKey,PagingStart,PagingCount});
			return ((ApiKeyAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLsCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetACLsCount(System.String UserName, Services.Packages.ApiKey _ApiKey) {
			object[] results = this.Invoke("GetACLsCount", new object[] {UserName, _ApiKey});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACEs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ApiKeyAccessControlEntryCollection GetACEs(ApiKeyAccessControlList _ApiKeyAccessControlList)
		{
			object[] results = this.Invoke("GetACEs", new object[] {_ApiKeyAccessControlList});
			return ((Services.Packages.Security.ApiKeyAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACEs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACEs(ApiKeyAccessControlList _ApiKeyAccessControlList, Services.Packages.Security.ApiKeyAccessControlEntryCollection _ACEs)
		{
			this.Invoke("GetACEs", new object[] {_ApiKeyAccessControlList});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages.Security
