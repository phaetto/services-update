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

namespace Services.Packages.Security.Security
{
	/// <summary>
    /// Defines the contract for the ModelUserAccessControlList class
    /// </summary>
    [ComVisible(true)]
    [Guid("bc865e3e-8662-dae7-335f-8a4d2f862e42")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IModelUserAccessControlList
	{
		bool Exists { get; }
		System.String UserName { get; set; }
		System.String Name { get; set; }
		Services.Packages.Security.ModelUser User { get; set; }
		Services.Packages.Security.ModelUser ModelUser { get; set; }
		Services.Packages.Security.Security.ModelUserAccessControlEntryCollection ACEs { get; set; }
		Services.Packages.Security.Security.ModelUserAccessControlEntryCollection GetEntries(System.String Descriptor);

		void Read(System.String __UserName, System.String __Name);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(ModelUserAccessControlList _object);
		void CopyWithKeysTo(ModelUserAccessControlList _object);
		void CopyFrom(ModelUserAccessControlList _object);
		void CopyTo(ModelUserAccessControlList _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.Security.Security.ModelUserAccessControlList type.
    /// </summary>
    [ComVisible(true)]
    [Guid("05d8dcdb-2ab5-c525-9763-3c59656b276d")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IModelUserAccessControlListService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(ModelUserAccessControlList _ModelUserAccessControlList);
		[OperationContract]
        ModelUserAccessControlList Read(System.String __UserName, System.String __Name);
        [OperationContract]
        ModelUserAccessControlList Reload(ModelUserAccessControlList _ModelUserAccessControlList);
        [OperationContract]
        ModelUserAccessControlList Create(System.String __UserName, System.String __Name);
        [OperationContract]
        void Delete(System.String __UserName, System.String __Name);
        [OperationContract]
        void UpdateObject(ModelUserAccessControlList _ModelUserAccessControlList);
        [OperationContract]
        void CreateObject(ModelUserAccessControlList _ModelUserAccessControlList);
        [OperationContract]
        void DeleteObject(ModelUserAccessControlList _ModelUserAccessControlList);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		ModelUserAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		ModelUserAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		Services.Packages.Security.ModelUser GetUser(ModelUserAccessControlList _ModelUserAccessControlList);
		[OperationContract]
		void SetUser(ModelUserAccessControlList _ModelUserAccessControlList, Services.Packages.Security.ModelUser _User);
		[OperationContract]
		ModelUserAccessControlListCollection GetByModelUser(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		ModelUserAccessControlListCollection GetByModelUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByModelUserCount(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		Services.Packages.Security.ModelUser GetModelUser(ModelUserAccessControlList _ModelUserAccessControlList);
		[OperationContract]
		void SetModelUser(ModelUserAccessControlList _ModelUserAccessControlList, Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		ModelUserAccessControlListCollection GetACLs(System.String UserName, Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		ModelUserAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetACLsCount(System.String UserName, Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		Services.Packages.Security.Security.ModelUserAccessControlEntryCollection GetACEs(ModelUserAccessControlList _ModelUserAccessControlList);
		[OperationContract]
		void SetACEs(ModelUserAccessControlList _ModelUserAccessControlList, Services.Packages.Security.Security.ModelUserAccessControlEntryCollection _ACEs);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.Security.Security.ModelUserAccessControlList type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("da69d3dc-0f4e-24a0-adb4-ff01fd9a838d")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class ModelUserAccessControlListService : IModelUserAccessControlListService
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
        public bool Exists(ModelUserAccessControlList _ModelUserAccessControlList)
        {
			return _ModelUserAccessControlList.Exists;
        }
		
		[WebMethod]
		public ModelUserAccessControlList Read(System.String __UserName, System.String __Name)
		{
			return new ModelUserAccessControlList(__UserName, __Name);
		}
		
		[WebMethod]
        public ModelUserAccessControlList Reload(ModelUserAccessControlList _ModelUserAccessControlList)
        {
			_ModelUserAccessControlList.Reload();
			return _ModelUserAccessControlList;
        }
		
		[WebMethod]
        public ModelUserAccessControlList Create(System.String __UserName, System.String __Name)
        {
			return ModelUserAccessControlList.CreateModelUserAccessControlList(__UserName, __Name);
        }
        
        [WebMethod]
        public void Delete(System.String __UserName, System.String __Name)
        {
			ModelUserAccessControlList.DeleteModelUserAccessControlList(__UserName, __Name);
        }
        
        [WebMethod]
        public void UpdateObject(ModelUserAccessControlList _ModelUserAccessControlList)
        {
			_ModelUserAccessControlList.Update();
        }
		
		[WebMethod]
        public void CreateObject(ModelUserAccessControlList _ModelUserAccessControlList)
        {
			_ModelUserAccessControlList.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ModelUserAccessControlList _ModelUserAccessControlList)
        {
			_ModelUserAccessControlList.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			ModelUserAccessControlList.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			ModelUserAccessControlList.Redo();
        }
		[WebMethod]
		public ModelUserAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUserAccessControlList.GetByUser( _ModelUser);
		}
		[WebMethod]
		public ModelUserAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ModelUserAccessControlList.GetByUserPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUserAccessControlList.GetByUserCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUser(ModelUserAccessControlList _ModelUserAccessControlList)
		{
			_ModelUserAccessControlList.Reload();
			return _ModelUserAccessControlList.User;
		}
		[WebMethod]
		public void SetUser(ModelUserAccessControlList _ModelUserAccessControlList, Services.Packages.Security.ModelUser _User)
		{
			_ModelUserAccessControlList.Reload();
			_ModelUserAccessControlList.User = _User;
			_ModelUserAccessControlList.Update();
		}
		[WebMethod]
		public ModelUserAccessControlListCollection GetByModelUser(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUserAccessControlList.GetByModelUser( _ModelUser);
		}
		[WebMethod]
		public ModelUserAccessControlListCollection GetByModelUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ModelUserAccessControlList.GetByModelUserPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByModelUserCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUserAccessControlList.GetByModelUserCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetModelUser(ModelUserAccessControlList _ModelUserAccessControlList)
		{
			_ModelUserAccessControlList.Reload();
			return _ModelUserAccessControlList.ModelUser;
		}
		[WebMethod]
		public void SetModelUser(ModelUserAccessControlList _ModelUserAccessControlList, Services.Packages.Security.ModelUser _ModelUser)
		{
			_ModelUserAccessControlList.Reload();
			_ModelUserAccessControlList.ModelUser = _ModelUser;
			_ModelUserAccessControlList.Update();
		}
		[WebMethod]
		public ModelUserAccessControlListCollection GetACLs(System.String UserName, Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUserAccessControlList.GetACLs(UserName,  _ModelUser);
		}
		[WebMethod]
		public ModelUserAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ModelUserAccessControlList.GetACLsPaged(UserName,  _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetACLsCount(System.String UserName, Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUserAccessControlList.GetACLsCount(UserName,  _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.Security.ModelUserAccessControlEntryCollection GetACEs(ModelUserAccessControlList _ModelUserAccessControlList)
		{
			_ModelUserAccessControlList.Reload();
			return _ModelUserAccessControlList.ACEs;
		}
		[WebMethod]
		public void SetACEs(ModelUserAccessControlList _ModelUserAccessControlList, Services.Packages.Security.Security.ModelUserAccessControlEntryCollection _ACEs)
		{
			_ModelUserAccessControlList.Reload();
			_ModelUserAccessControlList.ACEs = _ACEs;
			_ModelUserAccessControlList.Update();
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.Security.Security.ModelUserAccessControlList model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("0f7900b1-d617-130d-38c0-24ff498e75c8")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class ModelUserAccessControlList : IModelUserAccessControlList, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<IModelUserAccessControlListService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<IModelUserAccessControlListService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<IModelUserAccessControlListService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.Security.ModelUserAccessControlList"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.Security.ModelUserAccessControlList"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.Security.Security.ModelUserAccessControlList.ProviderType");
				
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
		
		public static Services.Packages.Security.ModelUser GetUser(ModelUserAccessControlList _ModelUserAccessControlList)
		{
			return _ModelUserAccessControlList.User;
		}

		bool _ModelUserIsLoaded = false;
		Services.Packages.Security.ModelUser _ModelUser;
		
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.ModelUser ModelUser
		{
            get
            {
				if (!_ModelUserIsLoaded)
				{
					_ModelUser = new Services.Packages.Security.ModelUser(_Name);
					if (_ModelUser.Exists)
						_ModelUserIsLoaded = true;
					else _ModelUser = null;
				}
                return _ModelUser;
            }
            set
            {
                _ModelUser = value;
                _ModelUserIsLoaded = true;
                if (_ModelUser != null)
                {
					if (_ModelUser.Exists)
					{
						_Name = _ModelUser.Name;
						
					}
					else
					{
						_ModelUser = null;
					}
				}
            }
		}
		
		public static Services.Packages.Security.ModelUser GetModelUser(ModelUserAccessControlList _ModelUserAccessControlList)
		{
			return _ModelUserAccessControlList.ModelUser;
		}

		public static ModelUserAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
        {
			ModelUserAccessControlListCollection _ModelUserAccessControlListCollection = new ModelUserAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsAcCoLiGetByUs", dbconn);
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
					ModelUserAccessControlList o = new ModelUserAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._ModelUserIsLoaded = false; if (dr["Name"] == DBNull.Value) { o._ModelUser = null; o._ModelUserIsLoaded = true; }  else o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
                    _ModelUserAccessControlListCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ModelUserAccessControlListCollection;
        }
        
        public static ModelUserAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			ModelUserAccessControlListCollection _ModelUserAccessControlListCollection = new ModelUserAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsAcCoLiGetByUsPaged", dbconn);
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
					ModelUserAccessControlList o = new ModelUserAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._ModelUserIsLoaded = false; if (dr["Name"] == DBNull.Value) { o._ModelUser = null; o._ModelUserIsLoaded = true; }  else o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
                    _ModelUserAccessControlListCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ModelUserAccessControlListCollection;
        }
        
        public static long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsAcCoLiGetByUsCount", dbconn);
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

		public static ModelUserAccessControlListCollection GetByModelUser(Services.Packages.Security.ModelUser _ModelUser)
        {
			ModelUserAccessControlListCollection _ModelUserAccessControlListCollection = new ModelUserAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsAcCoLiGetByMoUs", dbconn);
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
					ModelUserAccessControlList o = new ModelUserAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._ModelUserIsLoaded = false; if (dr["Name"] == DBNull.Value) { o._ModelUser = null; o._ModelUserIsLoaded = true; }  else o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
                    _ModelUserAccessControlListCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ModelUserAccessControlListCollection;
        }
        
        public static ModelUserAccessControlListCollection GetByModelUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			ModelUserAccessControlListCollection _ModelUserAccessControlListCollection = new ModelUserAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsAcCoLiGetByMoUsPaged", dbconn);
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
					ModelUserAccessControlList o = new ModelUserAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._ModelUserIsLoaded = false; if (dr["Name"] == DBNull.Value) { o._ModelUser = null; o._ModelUserIsLoaded = true; }  else o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
                    _ModelUserAccessControlListCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ModelUserAccessControlListCollection;
        }
        
        public static long GetByModelUserCount(Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsAcCoLiGetByMoUsCount", dbconn);
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

		public static ModelUserAccessControlListCollection GetACLs(System.String _UserName, Services.Packages.Security.ModelUser _ModelUser)
        {
			ModelUserAccessControlListCollection _ModelUserAccessControlListCollection = new ModelUserAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsAcCoLiGeACLs", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UserName = ClassConnectionProvider.Escape(_UserName);
				
                
                DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), -1);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_ModelUser_Name;
				if (_ModelUser != null) {
				param_ModelUser_Name = ClassConnectionProvider.GetDatabaseParameter("MoUsNa", typeof(System.String), 128);
				param_ModelUser_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_ModelUser.Name);
				} else {
				param_ModelUser_Name = ClassConnectionProvider.GetDatabaseParameter("MoUsNa", DBNull.Value);
				}
				command.Parameters.Add(param_ModelUser_Name);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					ModelUserAccessControlList o = new ModelUserAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._ModelUserIsLoaded = false; if (dr["Name"] == DBNull.Value) { o._ModelUser = null; o._ModelUserIsLoaded = true; }  else o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
                    _ModelUserAccessControlListCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ModelUserAccessControlListCollection;
        }
        
        public static ModelUserAccessControlListCollection GetACLsPaged(System.String _UserName, Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			ModelUserAccessControlListCollection _ModelUserAccessControlListCollection = new ModelUserAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsAcCoLiGeACLsPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UserName = ClassConnectionProvider.Escape(_UserName);
				
                
                DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), -1);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_ModelUser_Name;
				if (_ModelUser != null) {
				param_ModelUser_Name = ClassConnectionProvider.GetDatabaseParameter("MoUsNa", typeof(System.String), 128);
				param_ModelUser_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_ModelUser.Name);
				} else {
				param_ModelUser_Name = ClassConnectionProvider.GetDatabaseParameter("MoUsNa", DBNull.Value);
				}
				command.Parameters.Add(param_ModelUser_Name);
				
                
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
					ModelUserAccessControlList o = new ModelUserAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._ModelUserIsLoaded = false; if (dr["Name"] == DBNull.Value) { o._ModelUser = null; o._ModelUserIsLoaded = true; }  else o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
                    _ModelUserAccessControlListCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ModelUserAccessControlListCollection;
        }
        
        public static long GetACLsCount(System.String _UserName, Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsAcCoLiGeACLsCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UserName = ClassConnectionProvider.Escape(_UserName);
				
                
                DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), -1);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_ModelUser_Name;
				if (_ModelUser != null) {
				param_ModelUser_Name = ClassConnectionProvider.GetDatabaseParameter("MoUsNa", typeof(System.String), 128);
				param_ModelUser_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_ModelUser.Name);
				} else {
				param_ModelUser_Name = ClassConnectionProvider.GetDatabaseParameter("MoUsNa", DBNull.Value);
				}
				command.Parameters.Add(param_ModelUser_Name);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		Services.Packages.Security.Security.ModelUserAccessControlEntryCollection _ACEs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.Security.ModelUserAccessControlEntryCollection ACEs
		{
            get
            {
				if (_ACEs == null)
					_ACEs = Services.Packages.Security.Security.ModelUserAccessControlEntry.GetByACL(this);
				
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
			_ACEs = Services.Packages.Security.Security.ModelUserAccessControlEntry.GetByACL(this);
		}

		public Services.Packages.Security.Security.ModelUserAccessControlEntryCollection GetEntries(System.String Descriptor)
		{
			return Services.Packages.Security.Security.ModelUserAccessControlEntry.GetEntries(Descriptor,  this);
		}

		public bool Exists
        {
            get {
				if (!__hasBeenReadOnce)
					Exist();
				
				return __databaseState == RowState.Initialized;
			}
        }
        
        public ModelUserAccessControlList() {}
        
        public ModelUserAccessControlList(System.String __UserName, System.String __Name)
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
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsAcCoLiRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
				DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
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
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "MoUsAcCoLi");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsAcCoLiRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					_UserName = __UserName;
				DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(__UserName);
				command.Parameters.Add(param_UserName);
				_Name = __Name;
				DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(__Name);
				command.Parameters.Add(param_Name);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				_UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_ModelUserIsLoaded = false; if (dr["Name"] == DBNull.Value) { _ModelUser = null; _ModelUserIsLoaded = true; }  else _Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "MoUsAcCoLi");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsAcCoLiRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				_UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_ModelUserIsLoaded = false; if (dr["Name"] == DBNull.Value) { _ModelUser = null; _ModelUserIsLoaded = true; }  else _Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsAcCoLiCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_User_Name = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_User_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				if (_User == null && _UserIsLoaded == true) param_User_Name.Value = DBNull.Value;
				command.Parameters.Add(param_User_Name);
				DbParameter param_ModelUser_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_ModelUser_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				if (_ModelUser == null && _ModelUserIsLoaded == true) param_ModelUser_Name.Value = DBNull.Value;
				command.Parameters.Add(param_ModelUser_Name);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				_UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_ModelUserIsLoaded = false; if (dr["Name"] == DBNull.Value) { _ModelUser = null; _ModelUserIsLoaded = true; }  else _Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
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
        
        static public ModelUserAccessControlList CreateModelUserAccessControlList(System.String __UserName, System.String __Name)
        {
            ModelUserAccessControlList o = new ModelUserAccessControlList(__UserName, __Name);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsAcCoLiUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_UserHasChanged = ClassConnectionProvider.GetDatabaseParameter("UserHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_UserIsLoaded));
				command.Parameters.Add(param_UserHasChanged);
				DbParameter param_User_Name = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_User_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				if (_User == null && _UserIsLoaded == true) param_User_Name.Value = DBNull.Value;
				command.Parameters.Add(param_User_Name);
				DbParameter param_ModelUserHasChanged = ClassConnectionProvider.GetDatabaseParameter("ModelUserHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_ModelUserIsLoaded));
				command.Parameters.Add(param_ModelUserHasChanged);
				DbParameter param_ModelUser_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_ModelUser_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				if (_ModelUser == null && _ModelUserIsLoaded == true) param_ModelUser_Name.Value = DBNull.Value;
				command.Parameters.Add(param_ModelUser_Name);
				

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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsAcCoLiDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
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
        
        static public void DeleteModelUserAccessControlList(System.String __UserName, System.String __Name)
        {
            ModelUserAccessControlList o = new ModelUserAccessControlList(__UserName, __Name);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(ModelUserAccessControlList _object)
        {
			_User = null;
			_UserIsLoaded = false;
			_ModelUser = null;
			_ModelUserIsLoaded = false;
			_UserName = _object._UserName;
			_Name = _object._Name;
			
        }
        
        public void CopyWithKeysTo(ModelUserAccessControlList _object)
        {
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._ModelUser = null;
			_object._ModelUserIsLoaded = false;
			_object._UserName = _UserName;
			_object._Name = _Name;
			
        }
        
        static public void CopyWithKeysObject(ModelUserAccessControlList _objectFrom, ModelUserAccessControlList _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(ModelUserAccessControlList _object)
        {
			_User = null;
			_UserIsLoaded = false;
			_ModelUser = null;
			_ModelUserIsLoaded = false;
			
        }
        
        public void CopyTo(ModelUserAccessControlList _object)
        {
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._ModelUser = null;
			_object._ModelUserIsLoaded = false;
			
        }
        
        static public void CopyObject(ModelUserAccessControlList _objectFrom, ModelUserAccessControlList _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(ModelUserAccessControlList).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(ModelUserAccessControlList).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(ModelUserAccessControlList _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			ModelUserAccessControlListUndoRedoCollection allUndidAndNotRedoneEntries = ModelUserAccessControlListUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			ModelUserAccessControlListUndoRedo _urobject = new ModelUserAccessControlListUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.User_Name = _object._User_Name;
			_urobject.ModelUser_Name = _object._ModelUser_Name;
			_urobject.UserName = _object._UserName;
			_urobject.Name = _object._Name;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(ModelUserAccessControlList).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = ModelUserAccessControlListUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				ModelUserAccessControlListUndoRedoCollection allOldUndoEntries = ModelUserAccessControlListUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			ModelUserAccessControlListUndoRedoCollection firstUndoEntries = ModelUserAccessControlListUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			ModelUserAccessControlListUndoRedo _urobject = firstUndoEntries[0];
			
			ModelUserAccessControlList _object = new ModelUserAccessControlList();
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._User_Name = _urobject.User_Name;
			_object._ModelUser = null;
			_object._ModelUserIsLoaded = false;
			_object._ModelUser_Name = _urobject.ModelUser_Name;
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
			ModelUserAccessControlListUndoRedoCollection firstEntryToRedoEntries = ModelUserAccessControlListUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			ModelUserAccessControlListUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			ModelUserAccessControlList _object = new ModelUserAccessControlList();
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._User_Name = _urobject.User_Name;
			_object._ModelUser = null;
			_object._ModelUserIsLoaded = false;
			_object._ModelUser_Name = _urobject.ModelUser_Name;
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
    /// Defines the contract for the ModelUserAccessControlListCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("5c701c37-531c-cbf4-3bb3-58002b24c8fd")]
    public interface IModelUserAccessControlListCollection : IEnumerable<ModelUserAccessControlList>
    {
        int IndexOf(ModelUserAccessControlList item);
        void Insert(int index, ModelUserAccessControlList item);
        void RemoveAt(int index);
        ModelUserAccessControlList this[int index] { get; set; }
        void Add(ModelUserAccessControlList item);
        void Clear();
        bool Contains(ModelUserAccessControlList item);
        void CopyTo(ModelUserAccessControlList[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(ModelUserAccessControlList item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.Security.Security.ModelUserAccessControlList
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("64a7afe0-18f1-0556-c656-a18deaa1db1e")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class ModelUserAccessControlListCollection : IModelUserAccessControlListCollection, IList<ModelUserAccessControlList>, IHierarchicalEnumerable
    {
        List<ModelUserAccessControlList> _list = new List<ModelUserAccessControlList>();
        
        public static implicit operator List<ModelUserAccessControlList>(ModelUserAccessControlListCollection collection)
        {
            return collection._list;
        }

        #region IList<ModelUserAccessControlList> Members

        public int IndexOf(ModelUserAccessControlList item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, ModelUserAccessControlList item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public ModelUserAccessControlList this[int index]
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

        #region ICollection<ModelUserAccessControlList> Members

        public void Add(ModelUserAccessControlList item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(ModelUserAccessControlList item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(ModelUserAccessControlList[] array, int arrayIndex)
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

        public bool Remove(ModelUserAccessControlList item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<ModelUserAccessControlList> Members

        public IEnumerator<ModelUserAccessControlList> GetEnumerator()
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
	/// that share Services.Packages.Security.Security.ModelUserAccessControlList objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Security.Security.Web.ModelUserAccessControlListWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class ModelUserAccessControlListWebService : WebService, IModelUserAccessControlListService
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
        public bool Exists(ModelUserAccessControlList _ModelUserAccessControlList)
        {
			return _ModelUserAccessControlList.Exists;
        }
		
		[WebMethod]
		public ModelUserAccessControlList Read(System.String __UserName, System.String __Name)
		{
			return new ModelUserAccessControlList(__UserName, __Name);
		}
		
		[WebMethod]
        public ModelUserAccessControlList Reload(ModelUserAccessControlList _ModelUserAccessControlList)
        {
			_ModelUserAccessControlList.Reload();
			return _ModelUserAccessControlList;
        }
		
		[WebMethod]
        public ModelUserAccessControlList Create(System.String __UserName, System.String __Name)
        {
			return ModelUserAccessControlList.CreateModelUserAccessControlList(__UserName, __Name);
        }
        
        [WebMethod]
        public void Delete(System.String __UserName, System.String __Name)
        {
			ModelUserAccessControlList.DeleteModelUserAccessControlList(__UserName, __Name);
        }
        
        [WebMethod]
        public void UpdateObject(ModelUserAccessControlList _ModelUserAccessControlList)
        {
			_ModelUserAccessControlList.Update();
        }
		
		[WebMethod]
        public void CreateObject(ModelUserAccessControlList _ModelUserAccessControlList)
        {
			_ModelUserAccessControlList.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ModelUserAccessControlList _ModelUserAccessControlList)
        {
			_ModelUserAccessControlList.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			ModelUserAccessControlList.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			ModelUserAccessControlList.Redo();
        }
		[WebMethod]
		public ModelUserAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUserAccessControlList.GetByUser( _ModelUser);
		}
		[WebMethod]
		public ModelUserAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ModelUserAccessControlList.GetByUserPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUserAccessControlList.GetByUserCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUser(ModelUserAccessControlList _ModelUserAccessControlList)
		{
			_ModelUserAccessControlList.Reload();
			return _ModelUserAccessControlList.User;
		}
		[WebMethod]
		public void SetUser(ModelUserAccessControlList _ModelUserAccessControlList, Services.Packages.Security.ModelUser _User)
		{
			_ModelUserAccessControlList.Reload();
			_ModelUserAccessControlList.User = _User;
			_ModelUserAccessControlList.Update();
		}
		[WebMethod]
		public ModelUserAccessControlListCollection GetByModelUser(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUserAccessControlList.GetByModelUser( _ModelUser);
		}
		[WebMethod]
		public ModelUserAccessControlListCollection GetByModelUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ModelUserAccessControlList.GetByModelUserPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByModelUserCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUserAccessControlList.GetByModelUserCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetModelUser(ModelUserAccessControlList _ModelUserAccessControlList)
		{
			_ModelUserAccessControlList.Reload();
			return _ModelUserAccessControlList.ModelUser;
		}
		[WebMethod]
		public void SetModelUser(ModelUserAccessControlList _ModelUserAccessControlList, Services.Packages.Security.ModelUser _ModelUser)
		{
			_ModelUserAccessControlList.Reload();
			_ModelUserAccessControlList.ModelUser = _ModelUser;
			_ModelUserAccessControlList.Update();
		}
		[WebMethod]
		public ModelUserAccessControlListCollection GetACLs(System.String UserName, Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUserAccessControlList.GetACLs(UserName,  _ModelUser);
		}
		[WebMethod]
		public ModelUserAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ModelUserAccessControlList.GetACLsPaged(UserName,  _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetACLsCount(System.String UserName, Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUserAccessControlList.GetACLsCount(UserName,  _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.Security.ModelUserAccessControlEntryCollection GetACEs(ModelUserAccessControlList _ModelUserAccessControlList)
		{
			_ModelUserAccessControlList.Reload();
			return _ModelUserAccessControlList.ACEs;
		}
		[WebMethod]
		public void SetACEs(ModelUserAccessControlList _ModelUserAccessControlList, Services.Packages.Security.Security.ModelUserAccessControlEntryCollection _ACEs)
		{
			_ModelUserAccessControlList.Reload();
			_ModelUserAccessControlList.ACEs = _ACEs;
			_ModelUserAccessControlList.Update();
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="ModelUserAccessControlListWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("e1c9363f-2629-5d71-0cad-d4647e0ce814")]
    sealed public class ModelUserAccessControlListWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IModelUserAccessControlListService
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
		public ModelUserAccessControlListWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public ModelUserAccessControlListWebServiceClient()
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
		public bool Exists(ModelUserAccessControlList _ModelUserAccessControlList)
        {
			object[] results = this.Invoke("Exists", new object[] {_ModelUserAccessControlList});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserAccessControlList Read(System.String __UserName, System.String __Name)
		{
			object[] results = this.Invoke("Read", new object[] {__UserName, __Name});
			return ((ModelUserAccessControlList)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserAccessControlList Reload(ModelUserAccessControlList _ModelUserAccessControlList)
        {
			object[] results = this.Invoke("Reload", new object[] {_ModelUserAccessControlList});
			return ((ModelUserAccessControlList)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserAccessControlList Create(System.String __UserName, System.String __Name)
        {
			object[] results = this.Invoke("Create", new object[] {__UserName, __Name});
			return ((ModelUserAccessControlList)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __UserName, System.String __Name)
        {
			this.Invoke("Delete", new object[] {__UserName, __Name});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(ModelUserAccessControlList _ModelUserAccessControlList)
        {
			this.Invoke("UpdateObject", new object[] {_ModelUserAccessControlList});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(ModelUserAccessControlList _ModelUserAccessControlList)
        {
			this.Invoke("CreateObject", new object[] {_ModelUserAccessControlList});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(ModelUserAccessControlList _ModelUserAccessControlList)
        {
			this.Invoke("DeleteObject", new object[] {_ModelUserAccessControlList});
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
		public ModelUserAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByUser", new object[] {_ModelUser});
			return ((ModelUserAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByUserPaged", new object[] {_ModelUser,PagingStart,PagingCount});
			return ((ModelUserAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByUserCount", new object[] {_ModelUser});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetUser(ModelUserAccessControlList _ModelUserAccessControlList)
		{
			object[] results = this.Invoke("GetUser", new object[] {_ModelUserAccessControlList});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetUser(ModelUserAccessControlList _ModelUserAccessControlList, Services.Packages.Security.ModelUser _User)
		{
			this.Invoke("GetUser", new object[] {_ModelUserAccessControlList});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByModelUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserAccessControlListCollection GetByModelUser(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByModelUser", new object[] {_ModelUser});
			return ((ModelUserAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByModelUserPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserAccessControlListCollection GetByModelUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByModelUserPaged", new object[] {_ModelUser,PagingStart,PagingCount});
			return ((ModelUserAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByModelUserCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByModelUserCount(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByModelUserCount", new object[] {_ModelUser});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetModelUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetModelUser(ModelUserAccessControlList _ModelUserAccessControlList)
		{
			object[] results = this.Invoke("GetModelUser", new object[] {_ModelUserAccessControlList});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetModelUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetModelUser(ModelUserAccessControlList _ModelUserAccessControlList, Services.Packages.Security.ModelUser _ModelUser)
		{
			this.Invoke("GetModelUser", new object[] {_ModelUserAccessControlList});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserAccessControlListCollection GetACLs(System.String UserName, Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetACLs", new object[] {UserName, _ModelUser});
			return ((ModelUserAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLsPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetACLsPaged", new object[] {UserName, _ModelUser,PagingStart,PagingCount});
			return ((ModelUserAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLsCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetACLsCount(System.String UserName, Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetACLsCount", new object[] {UserName, _ModelUser});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACEs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.Security.ModelUserAccessControlEntryCollection GetACEs(ModelUserAccessControlList _ModelUserAccessControlList)
		{
			object[] results = this.Invoke("GetACEs", new object[] {_ModelUserAccessControlList});
			return ((Services.Packages.Security.Security.ModelUserAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACEs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACEs(ModelUserAccessControlList _ModelUserAccessControlList, Services.Packages.Security.Security.ModelUserAccessControlEntryCollection _ACEs)
		{
			this.Invoke("GetACEs", new object[] {_ModelUserAccessControlList});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages.Security.Security
