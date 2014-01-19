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
    /// Defines the contract for the ModelUserRights class
    /// </summary>
    [ComVisible(true)]
    [Guid("87e79233-7b0d-20cd-bb7c-f357cbf9bacd")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IModelUserRights
	{
		bool Exists { get; }
		System.String Name { get; set; }
		System.String UserName { get; set; }
		Services.Packages.Security.ModelUser User { get; set; }

		void Read(System.String __Name, System.String __UserName);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(ModelUserRights _object);
		void CopyWithKeysTo(ModelUserRights _object);
		void CopyFrom(ModelUserRights _object);
		void CopyTo(ModelUserRights _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.Security.ModelUserRights type.
    /// </summary>
    [ComVisible(true)]
    [Guid("54f26764-cb8f-34c7-71b0-0430fdde33fc")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IModelUserRightsService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(ModelUserRights _ModelUserRights);
		[OperationContract]
        ModelUserRights Read(System.String __Name, System.String __UserName);
        [OperationContract]
        ModelUserRights Reload(ModelUserRights _ModelUserRights);
        [OperationContract]
        ModelUserRights Create(System.String __Name, System.String __UserName);
        [OperationContract]
        void Delete(System.String __Name, System.String __UserName);
        [OperationContract]
        void UpdateObject(ModelUserRights _ModelUserRights);
        [OperationContract]
        void CreateObject(ModelUserRights _ModelUserRights);
        [OperationContract]
        void DeleteObject(ModelUserRights _ModelUserRights);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		ModelUserRightsCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		ModelUserRightsCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		Services.Packages.Security.ModelUser GetUser(ModelUserRights _ModelUserRights);
		[OperationContract]
		void SetUser(ModelUserRights _ModelUserRights, Services.Packages.Security.ModelUser _User);
		[OperationContract]
		ModelUserRightsCollection GetByName(System.String Name );
		[OperationContract]
		ModelUserRightsCollection GetByNamePaged(System.String Name , long PagingStart, long PagingCount);
		[OperationContract]
		long GetByNameCount(System.String Name );
		[OperationContract]
		ModelUserRightsCollection GetByNameAndUser(System.String Name, Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		ModelUserRightsCollection GetByNameAndUserPaged(System.String Name, Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByNameAndUserCount(System.String Name, Services.Packages.Security.ModelUser _ModelUser);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.Security.ModelUserRights type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("8f89b694-30f0-3d19-750d-db17f610e84b")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class ModelUserRightsService : IModelUserRightsService
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
        public bool Exists(ModelUserRights _ModelUserRights)
        {
			return _ModelUserRights.Exists;
        }
		
		[WebMethod]
		public ModelUserRights Read(System.String __Name, System.String __UserName)
		{
			return new ModelUserRights(__Name, __UserName);
		}
		
		[WebMethod]
        public ModelUserRights Reload(ModelUserRights _ModelUserRights)
        {
			_ModelUserRights.Reload();
			return _ModelUserRights;
        }
		
		[WebMethod]
        public ModelUserRights Create(System.String __Name, System.String __UserName)
        {
			return ModelUserRights.CreateModelUserRights(__Name, __UserName);
        }
        
        [WebMethod]
        public void Delete(System.String __Name, System.String __UserName)
        {
			ModelUserRights.DeleteModelUserRights(__Name, __UserName);
        }
        
        [WebMethod]
        public void UpdateObject(ModelUserRights _ModelUserRights)
        {
			_ModelUserRights.Update();
        }
		
		[WebMethod]
        public void CreateObject(ModelUserRights _ModelUserRights)
        {
			_ModelUserRights.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ModelUserRights _ModelUserRights)
        {
			_ModelUserRights.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			ModelUserRights.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			ModelUserRights.Redo();
        }
		[WebMethod]
		public ModelUserRightsCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUserRights.GetByUser( _ModelUser);
		}
		[WebMethod]
		public ModelUserRightsCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ModelUserRights.GetByUserPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUserRights.GetByUserCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUser(ModelUserRights _ModelUserRights)
		{
			_ModelUserRights.Reload();
			return _ModelUserRights.User;
		}
		[WebMethod]
		public void SetUser(ModelUserRights _ModelUserRights, Services.Packages.Security.ModelUser _User)
		{
			_ModelUserRights.Reload();
			_ModelUserRights.User = _User;
			_ModelUserRights.Update();
		}
		[WebMethod]
		public ModelUserRightsCollection GetByName(System.String Name )
		{
			return ModelUserRights.GetByName(Name );
		}
		[WebMethod]
		public ModelUserRightsCollection GetByNamePaged(System.String Name , long PagingStart, long PagingCount)
		{
			return ModelUserRights.GetByNamePaged(Name , PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByNameCount(System.String Name )
		{
			return ModelUserRights.GetByNameCount(Name );
		}
		[WebMethod]
		public ModelUserRightsCollection GetByNameAndUser(System.String Name, Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUserRights.GetByNameAndUser(Name,  _ModelUser);
		}
		[WebMethod]
		public ModelUserRightsCollection GetByNameAndUserPaged(System.String Name, Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ModelUserRights.GetByNameAndUserPaged(Name,  _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByNameAndUserCount(System.String Name, Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUserRights.GetByNameAndUserCount(Name,  _ModelUser);
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.Security.ModelUserRights model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("e3313a03-069a-674c-cab3-155d769d23dd")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class ModelUserRights : IModelUserRights, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<IModelUserRightsService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<IModelUserRightsService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<IModelUserRightsService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.ModelUserRights"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.ModelUserRights"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.Security.ModelUserRights.ProviderType");
				
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
		
		public static Services.Packages.Security.ModelUser GetUser(ModelUserRights _ModelUserRights)
		{
			return _ModelUserRights.User;
		}

		public static ModelUserRightsCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
        {
			ModelUserRightsCollection _ModelUserRightsCollection = new ModelUserRightsCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsRiGetByUs", dbconn);
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
					ModelUserRights o = new ModelUserRights();
                
					o.__databaseState = RowState.Initialized;
                    o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				
                    
                    _ModelUserRightsCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ModelUserRightsCollection;
        }
        
        public static ModelUserRightsCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			ModelUserRightsCollection _ModelUserRightsCollection = new ModelUserRightsCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsRiGetByUsPaged", dbconn);
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
					ModelUserRights o = new ModelUserRights();
                
					o.__databaseState = RowState.Initialized;
                    o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				
                    
                    _ModelUserRightsCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ModelUserRightsCollection;
        }
        
        public static long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsRiGetByUsCount", dbconn);
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

		public static ModelUserRightsCollection GetByName(System.String _Name)
        {
			ModelUserRightsCollection _ModelUserRightsCollection = new ModelUserRightsCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsRiGeByNa", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					ModelUserRights o = new ModelUserRights();
                
					o.__databaseState = RowState.Initialized;
                    o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				
                    
                    _ModelUserRightsCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ModelUserRightsCollection;
        }
        
        public static ModelUserRightsCollection GetByNamePaged(System.String _Name, long PagingStart, long PagingCount)
        {
			ModelUserRightsCollection _ModelUserRightsCollection = new ModelUserRightsCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsRiGeByNaPaged", dbconn);
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
					ModelUserRights o = new ModelUserRights();
                
					o.__databaseState = RowState.Initialized;
                    o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				
                    
                    _ModelUserRightsCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ModelUserRightsCollection;
        }
        
        public static long GetByNameCount(System.String _Name)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsRiGeByNaCount", dbconn);
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

		public static ModelUserRightsCollection GetByNameAndUser(System.String _Name, Services.Packages.Security.ModelUser _ModelUser)
        {
			ModelUserRightsCollection _ModelUserRightsCollection = new ModelUserRightsCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsRiGeByNaAnUs", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
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
					ModelUserRights o = new ModelUserRights();
                
					o.__databaseState = RowState.Initialized;
                    o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				
                    
                    _ModelUserRightsCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ModelUserRightsCollection;
        }
        
        public static ModelUserRightsCollection GetByNameAndUserPaged(System.String _Name, Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			ModelUserRightsCollection _ModelUserRightsCollection = new ModelUserRightsCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsRiGeByNaAnUsPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
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
					ModelUserRights o = new ModelUserRights();
                
					o.__databaseState = RowState.Initialized;
                    o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				
                    
                    _ModelUserRightsCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ModelUserRightsCollection;
        }
        
        public static long GetByNameAndUserCount(System.String _Name, Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsRiGeByNaAnUsCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
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

		public bool Exists
        {
            get {
				if (!__hasBeenReadOnce)
					Exist();
				
				return __databaseState == RowState.Initialized;
			}
        }
        
        public ModelUserRights() {}
        
        public ModelUserRights(System.String __Name, System.String __UserName)
        {
			Read(__Name, __UserName);
        }
        
        #region CRUD
        
        void Exist()
        {
			// sql read - should be changed to specific exist implementation
			using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
			{
				dbconn.Open();
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsRiRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
				DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				
                
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
        
        public void Read(System.String __Name, System.String __UserName)
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].Read(__Name, __UserName);
					return;
				}

                // Get a service via an algorithm
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "MoUsRi");
                // Perfect for read operations, but not for write
                // scalingServices[nextIndex].Read(__Name, __UserName);
				// return;

				throw new NotImplementedException();
            }

            try
            {
				// sql read
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsRiRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					_Name = __Name;
				DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(__Name);
				command.Parameters.Add(param_Name);
				_UserName = __UserName;
				DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(__UserName);
				command.Parameters.Add(param_UserName);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				
                    
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
                            failoverServices[n].Read(__Name, __UserName);
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "MoUsRi");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsRiRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				
                    
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsRiCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_User_Name = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_User_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				if (_User == null && _UserIsLoaded == true) param_User_Name.Value = DBNull.Value;
				command.Parameters.Add(param_User_Name);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				
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
        
        static public ModelUserRights CreateModelUserRights(System.String __Name, System.String __UserName)
        {
            ModelUserRights o = new ModelUserRights(__Name, __UserName);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsRiUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_UserHasChanged = ClassConnectionProvider.GetDatabaseParameter("UserHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_UserIsLoaded));
				command.Parameters.Add(param_UserHasChanged);
				DbParameter param_User_Name = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_User_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				if (_User == null && _UserIsLoaded == true) param_User_Name.Value = DBNull.Value;
				command.Parameters.Add(param_User_Name);
				

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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsRiDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				
				
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
        
        static public void DeleteModelUserRights(System.String __Name, System.String __UserName)
        {
            ModelUserRights o = new ModelUserRights(__Name, __UserName);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(ModelUserRights _object)
        {
			_User = null;
			_UserIsLoaded = false;
			_Name = _object._Name;
			_UserName = _object._UserName;
			
        }
        
        public void CopyWithKeysTo(ModelUserRights _object)
        {
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._Name = _Name;
			_object._UserName = _UserName;
			
        }
        
        static public void CopyWithKeysObject(ModelUserRights _objectFrom, ModelUserRights _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(ModelUserRights _object)
        {
			_User = null;
			_UserIsLoaded = false;
			
        }
        
        public void CopyTo(ModelUserRights _object)
        {
			_object._User = null;
			_object._UserIsLoaded = false;
			
        }
        
        static public void CopyObject(ModelUserRights _objectFrom, ModelUserRights _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(ModelUserRights).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(ModelUserRights).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(ModelUserRights _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			ModelUserRightsUndoRedoCollection allUndidAndNotRedoneEntries = ModelUserRightsUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			ModelUserRightsUndoRedo _urobject = new ModelUserRightsUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.User_Name = _object._User_Name;
			_urobject.Name = _object._Name;
			_urobject.UserName = _object._UserName;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(ModelUserRights).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = ModelUserRightsUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				ModelUserRightsUndoRedoCollection allOldUndoEntries = ModelUserRightsUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			ModelUserRightsUndoRedoCollection firstUndoEntries = ModelUserRightsUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			ModelUserRightsUndoRedo _urobject = firstUndoEntries[0];
			
			ModelUserRights _object = new ModelUserRights();
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._User_Name = _urobject.User_Name;
			_object._Name = _urobject.Name;
			_object._UserName = _urobject.UserName;
			

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
			ModelUserRightsUndoRedoCollection firstEntryToRedoEntries = ModelUserRightsUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			ModelUserRightsUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			ModelUserRights _object = new ModelUserRights();
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._User_Name = _urobject.User_Name;
			_object._Name = _urobject.Name;
			_object._UserName = _urobject.UserName;
			

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
    /// Defines the contract for the ModelUserRightsCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("15c2f648-2b70-34dd-4db4-df81f0b03e61")]
    public interface IModelUserRightsCollection : IEnumerable<ModelUserRights>
    {
        int IndexOf(ModelUserRights item);
        void Insert(int index, ModelUserRights item);
        void RemoveAt(int index);
        ModelUserRights this[int index] { get; set; }
        void Add(ModelUserRights item);
        void Clear();
        bool Contains(ModelUserRights item);
        void CopyTo(ModelUserRights[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(ModelUserRights item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.Security.ModelUserRights
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("c22cb9c8-50ad-8e61-6921-c43c1abbc7d8")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class ModelUserRightsCollection : IModelUserRightsCollection, IList<ModelUserRights>, IHierarchicalEnumerable
    {
        List<ModelUserRights> _list = new List<ModelUserRights>();
        
        public static implicit operator List<ModelUserRights>(ModelUserRightsCollection collection)
        {
            return collection._list;
        }

        #region IList<ModelUserRights> Members

        public int IndexOf(ModelUserRights item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, ModelUserRights item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public ModelUserRights this[int index]
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

        #region ICollection<ModelUserRights> Members

        public void Add(ModelUserRights item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(ModelUserRights item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(ModelUserRights[] array, int arrayIndex)
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

        public bool Remove(ModelUserRights item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<ModelUserRights> Members

        public IEnumerator<ModelUserRights> GetEnumerator()
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
	/// that share Services.Packages.Security.ModelUserRights objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Security.Web.ModelUserRightsWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class ModelUserRightsWebService : WebService, IModelUserRightsService
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
        public bool Exists(ModelUserRights _ModelUserRights)
        {
			return _ModelUserRights.Exists;
        }
		
		[WebMethod]
		public ModelUserRights Read(System.String __Name, System.String __UserName)
		{
			return new ModelUserRights(__Name, __UserName);
		}
		
		[WebMethod]
        public ModelUserRights Reload(ModelUserRights _ModelUserRights)
        {
			_ModelUserRights.Reload();
			return _ModelUserRights;
        }
		
		[WebMethod]
        public ModelUserRights Create(System.String __Name, System.String __UserName)
        {
			return ModelUserRights.CreateModelUserRights(__Name, __UserName);
        }
        
        [WebMethod]
        public void Delete(System.String __Name, System.String __UserName)
        {
			ModelUserRights.DeleteModelUserRights(__Name, __UserName);
        }
        
        [WebMethod]
        public void UpdateObject(ModelUserRights _ModelUserRights)
        {
			_ModelUserRights.Update();
        }
		
		[WebMethod]
        public void CreateObject(ModelUserRights _ModelUserRights)
        {
			_ModelUserRights.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ModelUserRights _ModelUserRights)
        {
			_ModelUserRights.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			ModelUserRights.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			ModelUserRights.Redo();
        }
		[WebMethod]
		public ModelUserRightsCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUserRights.GetByUser( _ModelUser);
		}
		[WebMethod]
		public ModelUserRightsCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ModelUserRights.GetByUserPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUserRights.GetByUserCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUser(ModelUserRights _ModelUserRights)
		{
			_ModelUserRights.Reload();
			return _ModelUserRights.User;
		}
		[WebMethod]
		public void SetUser(ModelUserRights _ModelUserRights, Services.Packages.Security.ModelUser _User)
		{
			_ModelUserRights.Reload();
			_ModelUserRights.User = _User;
			_ModelUserRights.Update();
		}
		[WebMethod]
		public ModelUserRightsCollection GetByName(System.String Name )
		{
			return ModelUserRights.GetByName(Name );
		}
		[WebMethod]
		public ModelUserRightsCollection GetByNamePaged(System.String Name , long PagingStart, long PagingCount)
		{
			return ModelUserRights.GetByNamePaged(Name , PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByNameCount(System.String Name )
		{
			return ModelUserRights.GetByNameCount(Name );
		}
		[WebMethod]
		public ModelUserRightsCollection GetByNameAndUser(System.String Name, Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUserRights.GetByNameAndUser(Name,  _ModelUser);
		}
		[WebMethod]
		public ModelUserRightsCollection GetByNameAndUserPaged(System.String Name, Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ModelUserRights.GetByNameAndUserPaged(Name,  _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByNameAndUserCount(System.String Name, Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelUserRights.GetByNameAndUserCount(Name,  _ModelUser);
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="ModelUserRightsWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("ffcefee9-d24e-d8db-5dfc-95e527cb771a")]
    sealed public class ModelUserRightsWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IModelUserRightsService
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
		public ModelUserRightsWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public ModelUserRightsWebServiceClient()
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
		public bool Exists(ModelUserRights _ModelUserRights)
        {
			object[] results = this.Invoke("Exists", new object[] {_ModelUserRights});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserRights Read(System.String __Name, System.String __UserName)
		{
			object[] results = this.Invoke("Read", new object[] {__Name, __UserName});
			return ((ModelUserRights)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserRights Reload(ModelUserRights _ModelUserRights)
        {
			object[] results = this.Invoke("Reload", new object[] {_ModelUserRights});
			return ((ModelUserRights)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserRights Create(System.String __Name, System.String __UserName)
        {
			object[] results = this.Invoke("Create", new object[] {__Name, __UserName});
			return ((ModelUserRights)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __Name, System.String __UserName)
        {
			this.Invoke("Delete", new object[] {__Name, __UserName});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(ModelUserRights _ModelUserRights)
        {
			this.Invoke("UpdateObject", new object[] {_ModelUserRights});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(ModelUserRights _ModelUserRights)
        {
			this.Invoke("CreateObject", new object[] {_ModelUserRights});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(ModelUserRights _ModelUserRights)
        {
			this.Invoke("DeleteObject", new object[] {_ModelUserRights});
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
		public ModelUserRightsCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByUser", new object[] {_ModelUser});
			return ((ModelUserRightsCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserRightsCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByUserPaged", new object[] {_ModelUser,PagingStart,PagingCount});
			return ((ModelUserRightsCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByUserCount", new object[] {_ModelUser});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetUser(ModelUserRights _ModelUserRights)
		{
			object[] results = this.Invoke("GetUser", new object[] {_ModelUserRights});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetUser(ModelUserRights _ModelUserRights, Services.Packages.Security.ModelUser _User)
		{
			this.Invoke("GetUser", new object[] {_ModelUserRights});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByName", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserRightsCollection GetByName(System.String Name ) {
			object[] results = this.Invoke("GetByName", new object[] {Name});
			return ((ModelUserRightsCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByNamePaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserRightsCollection GetByNamePaged(System.String Name , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByNamePaged", new object[] {Name,PagingStart,PagingCount});
			return ((ModelUserRightsCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByNameCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByNameCount(System.String Name ) {
			object[] results = this.Invoke("GetByNameCount", new object[] {Name});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByNameAndUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserRightsCollection GetByNameAndUser(System.String Name, Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByNameAndUser", new object[] {Name, _ModelUser});
			return ((ModelUserRightsCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByNameAndUserPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserRightsCollection GetByNameAndUserPaged(System.String Name, Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByNameAndUserPaged", new object[] {Name, _ModelUser,PagingStart,PagingCount});
			return ((ModelUserRightsCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByNameAndUserCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByNameAndUserCount(System.String Name, Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByNameAndUserCount", new object[] {Name, _ModelUser});
			return ((long)(results[0]));
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages.Security
