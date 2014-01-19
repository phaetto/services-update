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
    /// Defines the contract for the ModelSession class
    /// </summary>
    [ComVisible(true)]
    [Guid("622acb46-4b0e-e50e-0c58-236dd414e868")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IModelSession
	{
		bool Exists { get; }
		System.String SessionToken { get; set; }
		System.DateTime TimeIssued { get; set; }
		System.Int32 TimeIssuedFor { get; set; }
		Services.Packages.Security.ModelUser User { get; set; }
		Services.Packages.Security.IPSessionRegistrationCollection SessionsRegisteredOnIP { get; set; }

		void Read(System.String __SessionToken);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(ModelSession _object);
		void CopyWithKeysTo(ModelSession _object);
		void CopyFrom(ModelSession _object);
		void CopyTo(ModelSession _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.Security.ModelSession type.
    /// </summary>
    [ComVisible(true)]
    [Guid("43887f03-1c2f-a5e1-d999-068631e60061")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IModelSessionService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(ModelSession _ModelSession);
		[OperationContract]
        ModelSession Read(System.String __SessionToken);
        [OperationContract]
        ModelSession Reload(ModelSession _ModelSession);
        [OperationContract]
        ModelSession Create(System.String __SessionToken);
        [OperationContract]
        void Delete(System.String __SessionToken);
        [OperationContract]
        void UpdateObject(ModelSession _ModelSession);
        [OperationContract]
        void CreateObject(ModelSession _ModelSession);
        [OperationContract]
        void DeleteObject(ModelSession _ModelSession);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		ModelSessionCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		ModelSessionCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		Services.Packages.Security.ModelUser GetUser(ModelSession _ModelSession);
		[OperationContract]
		void SetUser(ModelSession _ModelSession, Services.Packages.Security.ModelUser _User);
		[OperationContract]
		Services.Packages.Security.IPSessionRegistrationCollection GetSessionsRegisteredOnIP(ModelSession _ModelSession);
		[OperationContract]
		void SetSessionsRegisteredOnIP(ModelSession _ModelSession, Services.Packages.Security.IPSessionRegistrationCollection _SessionsRegisteredOnIP);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.Security.ModelSession type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("d8c0aa89-ea8a-0ae6-44da-55523e2a880a")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class ModelSessionService : IModelSessionService
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
        public bool Exists(ModelSession _ModelSession)
        {
			return _ModelSession.Exists;
        }
		
		[WebMethod]
		public ModelSession Read(System.String __SessionToken)
		{
			return new ModelSession(__SessionToken);
		}
		
		[WebMethod]
        public ModelSession Reload(ModelSession _ModelSession)
        {
			_ModelSession.Reload();
			return _ModelSession;
        }
		
		[WebMethod]
        public ModelSession Create(System.String __SessionToken)
        {
			return ModelSession.CreateModelSession(__SessionToken);
        }
        
        [WebMethod]
        public void Delete(System.String __SessionToken)
        {
			ModelSession.DeleteModelSession(__SessionToken);
        }
        
        [WebMethod]
        public void UpdateObject(ModelSession _ModelSession)
        {
			_ModelSession.Update();
        }
		
		[WebMethod]
        public void CreateObject(ModelSession _ModelSession)
        {
			_ModelSession.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ModelSession _ModelSession)
        {
			_ModelSession.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			ModelSession.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			ModelSession.Redo();
        }
		[WebMethod]
		public ModelSessionCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelSession.GetByUser( _ModelUser);
		}
		[WebMethod]
		public ModelSessionCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ModelSession.GetByUserPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelSession.GetByUserCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUser(ModelSession _ModelSession)
		{
			_ModelSession.Reload();
			return _ModelSession.User;
		}
		[WebMethod]
		public void SetUser(ModelSession _ModelSession, Services.Packages.Security.ModelUser _User)
		{
			_ModelSession.Reload();
			_ModelSession.User = _User;
			_ModelSession.Update();
		}
		[WebMethod]
		public Services.Packages.Security.IPSessionRegistrationCollection GetSessionsRegisteredOnIP(ModelSession _ModelSession)
		{
			_ModelSession.Reload();
			return _ModelSession.SessionsRegisteredOnIP;
		}
		[WebMethod]
		public void SetSessionsRegisteredOnIP(ModelSession _ModelSession, Services.Packages.Security.IPSessionRegistrationCollection _SessionsRegisteredOnIP)
		{
			_ModelSession.Reload();
			_ModelSession.SessionsRegisteredOnIP = _SessionsRegisteredOnIP;
			_ModelSession.Update();
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.Security.ModelSession model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("273582ec-9629-2a11-ea85-88744588b425")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class ModelSession : IModelSession, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<IModelSessionService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<IModelSessionService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<IModelSessionService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.ModelSession"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.ModelSession"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.Security.ModelSession.ProviderType");
				
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


		System.String _SessionToken;
		
		// Key member
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String SessionToken
		{
            get
            {
                return _SessionToken;
            }
            set
            {
				if (_SessionToken != value)
					__hasBeenReadOnce = false;
                _SessionToken = value;
            }
		}

		System.DateTime _TimeIssued;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.DateTime TimeIssued
		{
            get
            {
                return _TimeIssued;
            }
            set
            {
                _TimeIssued = value;
            }
		}

		System.Int32 _TimeIssuedFor;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Int32 TimeIssuedFor
		{
            get
            {
                return _TimeIssuedFor;
            }
            set
            {
                _TimeIssuedFor = value;
            }
		}

		bool _UserIsLoaded = false;
		Services.Packages.Security.ModelUser _User;
		System.String _User_Name; 
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.ModelUser User
		{
            get
            {
				if (!_UserIsLoaded)
				{
					_User = new Services.Packages.Security.ModelUser(_User_Name);
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
						_User_Name = _User.Name;
						
					}
					else
					{
						_User = null;
					}
				}
            }
		}
		
		public static Services.Packages.Security.ModelUser GetUser(ModelSession _ModelSession)
		{
			return _ModelSession.User;
		}

		public static ModelSessionCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
        {
			ModelSessionCollection _ModelSessionCollection = new ModelSessionCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoSeGetByUs", dbconn);
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
					ModelSession o = new ModelSession();
                
					o.__databaseState = RowState.Initialized;
                    o._SessionToken = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SessionToken"], typeof(System.String));
				o._TimeIssued = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["TimeIssued"], typeof(System.DateTime));
				o._TimeIssuedFor = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["TimeIssuedFor"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["User_Name"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._User_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["User_Name"], typeof(System.String));
				
                    
                    _ModelSessionCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ModelSessionCollection;
        }
        
        public static ModelSessionCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			ModelSessionCollection _ModelSessionCollection = new ModelSessionCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoSeGetByUsPaged", dbconn);
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
					ModelSession o = new ModelSession();
                
					o.__databaseState = RowState.Initialized;
                    o._SessionToken = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SessionToken"], typeof(System.String));
				o._TimeIssued = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["TimeIssued"], typeof(System.DateTime));
				o._TimeIssuedFor = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["TimeIssuedFor"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["User_Name"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._User_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["User_Name"], typeof(System.String));
				
                    
                    _ModelSessionCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ModelSessionCollection;
        }
        
        public static long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoSeGetByUsCount", dbconn);
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

		Services.Packages.Security.IPSessionRegistrationCollection _SessionsRegisteredOnIP;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.IPSessionRegistrationCollection SessionsRegisteredOnIP
		{
            get
            {
				if (_SessionsRegisteredOnIP == null)
					_SessionsRegisteredOnIP = Services.Packages.Security.IPSessionRegistration.GetBySession(this);
				
				return _SessionsRegisteredOnIP;
            }
            set
            {
				if (this.Exists)
				{
					if (_SessionsRegisteredOnIP != null)
					{
						for(int n = 0; n < _SessionsRegisteredOnIP.Count; ++n)
						{
							_SessionsRegisteredOnIP[n].Session = null;
							_SessionsRegisteredOnIP[n].Update();
						}
					}
	                
					_SessionsRegisteredOnIP = value;
					
					if (_SessionsRegisteredOnIP != null)
					{
						for(int n = 0; n < _SessionsRegisteredOnIP.Count; ++n)
						{
							_SessionsRegisteredOnIP[n].Session = this;
							_SessionsRegisteredOnIP[n].Create();
						}
					}
				}
				else
				{
					_SessionsRegisteredOnIP = value;
				}
            }
		}
		
		public void ReloadSessionsRegisteredOnIP()
		{
			_SessionsRegisteredOnIP = Services.Packages.Security.IPSessionRegistration.GetBySession(this);
		}

		public bool Exists
        {
            get {
				if (!__hasBeenReadOnce)
					Exist();
				
				return __databaseState == RowState.Initialized;
			}
        }
        
        public ModelSession() {}
        
        public ModelSession(System.String __SessionToken)
        {
			Read(__SessionToken);
        }
        
        #region CRUD
        
        void Exist()
        {
			// sql read - should be changed to specific exist implementation
			using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
			{
				dbconn.Open();
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoSeRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
				DbParameter param_SessionToken = ClassConnectionProvider.GetDatabaseParameter("SessionToken", typeof(System.String), 384);
				param_SessionToken.Value = ClassConnectionProvider.FromValueToSqlModelType(_SessionToken);
				command.Parameters.Add(param_SessionToken);
				
                
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
        
        public void Read(System.String __SessionToken)
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].Read(__SessionToken);
					return;
				}

                // Get a service via an algorithm
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "MoSe");
                // Perfect for read operations, but not for write
                // scalingServices[nextIndex].Read(__SessionToken);
				// return;

				throw new NotImplementedException();
            }

            try
            {
				// sql read
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoSeRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					_SessionToken = __SessionToken;
				DbParameter param_SessionToken = ClassConnectionProvider.GetDatabaseParameter("SessionToken", typeof(System.String), 384);
				param_SessionToken.Value = ClassConnectionProvider.FromValueToSqlModelType(__SessionToken);
				command.Parameters.Add(param_SessionToken);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_SessionToken = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SessionToken"], typeof(System.String));
				_TimeIssued = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["TimeIssued"], typeof(System.DateTime));
				_TimeIssuedFor = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["TimeIssuedFor"], typeof(System.Int32));
				_UserIsLoaded = false; if (dr["User_Name"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _User_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["User_Name"], typeof(System.String));
				
                    
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
                            failoverServices[n].Read(__SessionToken);
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "MoSe");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoSeRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_SessionToken = ClassConnectionProvider.GetDatabaseParameter("SessionToken", typeof(System.String), 384);
				param_SessionToken.Value = ClassConnectionProvider.FromValueToSqlModelType(_SessionToken);
				command.Parameters.Add(param_SessionToken);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_SessionToken = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SessionToken"], typeof(System.String));
				_TimeIssued = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["TimeIssued"], typeof(System.DateTime));
				_TimeIssuedFor = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["TimeIssuedFor"], typeof(System.Int32));
				_UserIsLoaded = false; if (dr["User_Name"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _User_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["User_Name"], typeof(System.String));
				
                    
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoSeCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_SessionToken = ClassConnectionProvider.GetDatabaseParameter("SessionToken", typeof(System.String), 384);
				param_SessionToken.Value = ClassConnectionProvider.FromValueToSqlModelType(_SessionToken);
				command.Parameters.Add(param_SessionToken);
				DbParameter param_TimeIssued = ClassConnectionProvider.GetDatabaseParameter("TimeIssued", typeof(System.DateTime), -1);
				param_TimeIssued.Value = ClassConnectionProvider.FromValueToSqlModelType(_TimeIssued);
				command.Parameters.Add(param_TimeIssued);
				DbParameter param_TimeIssuedFor = ClassConnectionProvider.GetDatabaseParameter("TimeIssuedFor", typeof(System.Int32), -1);
				param_TimeIssuedFor.Value = ClassConnectionProvider.FromValueToSqlModelType(_TimeIssuedFor);
				command.Parameters.Add(param_TimeIssuedFor);
				DbParameter param_User_Name = ClassConnectionProvider.GetDatabaseParameter("User_Name", typeof(System.String), 128);
				param_User_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_User_Name);
				if (_User == null) param_User_Name.Value = DBNull.Value;
				else param_User_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_User.Name);
				command.Parameters.Add(param_User_Name);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_SessionToken = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SessionToken"], typeof(System.String));
				_TimeIssued = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["TimeIssued"], typeof(System.DateTime));
				_TimeIssuedFor = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["TimeIssuedFor"], typeof(System.Int32));
				_UserIsLoaded = false; if (dr["User_Name"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _User_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["User_Name"], typeof(System.String));
				
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
        
        static public ModelSession CreateModelSession(System.String __SessionToken)
        {
            ModelSession o = new ModelSession(__SessionToken);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoSeUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_SessionToken = ClassConnectionProvider.GetDatabaseParameter("SessionToken", typeof(System.String), 384);
				param_SessionToken.Value = ClassConnectionProvider.FromValueToSqlModelType(_SessionToken);
				command.Parameters.Add(param_SessionToken);
				DbParameter param_TimeIssued = ClassConnectionProvider.GetDatabaseParameter("TimeIssued", typeof(System.DateTime), -1);
				param_TimeIssued.Value = ClassConnectionProvider.FromValueToSqlModelType(_TimeIssued);
				command.Parameters.Add(param_TimeIssued);
				DbParameter param_TimeIssuedFor = ClassConnectionProvider.GetDatabaseParameter("TimeIssuedFor", typeof(System.Int32), -1);
				param_TimeIssuedFor.Value = ClassConnectionProvider.FromValueToSqlModelType(_TimeIssuedFor);
				command.Parameters.Add(param_TimeIssuedFor);
				DbParameter param_UserHasChanged = ClassConnectionProvider.GetDatabaseParameter("UserHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_UserIsLoaded));
				command.Parameters.Add(param_UserHasChanged);
				DbParameter param_User_Name = ClassConnectionProvider.GetDatabaseParameter("User_Name", typeof(System.String), 128);
				param_User_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_User_Name);
				if (_User == null) param_User_Name.Value = DBNull.Value;
				else param_User_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_User.Name);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoSeDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_SessionToken = ClassConnectionProvider.GetDatabaseParameter("SessionToken", typeof(System.String), 384);
				param_SessionToken.Value = ClassConnectionProvider.FromValueToSqlModelType(_SessionToken);
				command.Parameters.Add(param_SessionToken);
				
				
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
        
        static public void DeleteModelSession(System.String __SessionToken)
        {
            ModelSession o = new ModelSession(__SessionToken);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(ModelSession _object)
        {
			_User = null;
			_UserIsLoaded = false;
			_SessionToken = _object._SessionToken;
			_TimeIssued = _object._TimeIssued;
			_TimeIssuedFor = _object._TimeIssuedFor;
			
        }
        
        public void CopyWithKeysTo(ModelSession _object)
        {
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._SessionToken = _SessionToken;
			_object._TimeIssued = _TimeIssued;
			_object._TimeIssuedFor = _TimeIssuedFor;
			
        }
        
        static public void CopyWithKeysObject(ModelSession _objectFrom, ModelSession _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(ModelSession _object)
        {
			_User = null;
			_UserIsLoaded = false;
			_TimeIssued = _object._TimeIssued;
			_TimeIssuedFor = _object._TimeIssuedFor;
			
        }
        
        public void CopyTo(ModelSession _object)
        {
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._TimeIssued = _TimeIssued;
			_object._TimeIssuedFor = _TimeIssuedFor;
			
        }
        
        static public void CopyObject(ModelSession _objectFrom, ModelSession _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(ModelSession).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(ModelSession).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(ModelSession _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			ModelSessionUndoRedoCollection allUndidAndNotRedoneEntries = ModelSessionUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			ModelSessionUndoRedo _urobject = new ModelSessionUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.User_Name = _object._User_Name;
			_urobject.SessionToken = _object._SessionToken;
			_urobject.TimeIssued = _object._TimeIssued;
			_urobject.TimeIssuedFor = _object._TimeIssuedFor;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(ModelSession).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = ModelSessionUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				ModelSessionUndoRedoCollection allOldUndoEntries = ModelSessionUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			ModelSessionUndoRedoCollection firstUndoEntries = ModelSessionUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			ModelSessionUndoRedo _urobject = firstUndoEntries[0];
			
			ModelSession _object = new ModelSession();
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._User_Name = _urobject.User_Name;
			_object._SessionToken = _urobject.SessionToken;
			_object._TimeIssued = _urobject.TimeIssued;
			_object._TimeIssuedFor = _urobject.TimeIssuedFor;
			

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
			ModelSessionUndoRedoCollection firstEntryToRedoEntries = ModelSessionUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			ModelSessionUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			ModelSession _object = new ModelSession();
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._User_Name = _urobject.User_Name;
			_object._SessionToken = _urobject.SessionToken;
			_object._TimeIssued = _urobject.TimeIssued;
			_object._TimeIssuedFor = _urobject.TimeIssuedFor;
			

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
    /// Defines the contract for the ModelSessionCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("2ae3c157-0f53-19dd-987d-ff54c78e66af")]
    public interface IModelSessionCollection : IEnumerable<ModelSession>
    {
        int IndexOf(ModelSession item);
        void Insert(int index, ModelSession item);
        void RemoveAt(int index);
        ModelSession this[int index] { get; set; }
        void Add(ModelSession item);
        void Clear();
        bool Contains(ModelSession item);
        void CopyTo(ModelSession[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(ModelSession item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.Security.ModelSession
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("ae9afb11-d9b1-f338-9896-ee056171c5bb")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class ModelSessionCollection : IModelSessionCollection, IList<ModelSession>, IHierarchicalEnumerable
    {
        List<ModelSession> _list = new List<ModelSession>();
        
        public static implicit operator List<ModelSession>(ModelSessionCollection collection)
        {
            return collection._list;
        }

        #region IList<ModelSession> Members

        public int IndexOf(ModelSession item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, ModelSession item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public ModelSession this[int index]
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

        #region ICollection<ModelSession> Members

        public void Add(ModelSession item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(ModelSession item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(ModelSession[] array, int arrayIndex)
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

        public bool Remove(ModelSession item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<ModelSession> Members

        public IEnumerator<ModelSession> GetEnumerator()
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
	/// that share Services.Packages.Security.ModelSession objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Security.Web.ModelSessionWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class ModelSessionWebService : WebService, IModelSessionService
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
        public bool Exists(ModelSession _ModelSession)
        {
			return _ModelSession.Exists;
        }
		
		[WebMethod]
		public ModelSession Read(System.String __SessionToken)
		{
			return new ModelSession(__SessionToken);
		}
		
		[WebMethod]
        public ModelSession Reload(ModelSession _ModelSession)
        {
			_ModelSession.Reload();
			return _ModelSession;
        }
		
		[WebMethod]
        public ModelSession Create(System.String __SessionToken)
        {
			return ModelSession.CreateModelSession(__SessionToken);
        }
        
        [WebMethod]
        public void Delete(System.String __SessionToken)
        {
			ModelSession.DeleteModelSession(__SessionToken);
        }
        
        [WebMethod]
        public void UpdateObject(ModelSession _ModelSession)
        {
			_ModelSession.Update();
        }
		
		[WebMethod]
        public void CreateObject(ModelSession _ModelSession)
        {
			_ModelSession.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ModelSession _ModelSession)
        {
			_ModelSession.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			ModelSession.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			ModelSession.Redo();
        }
		[WebMethod]
		public ModelSessionCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelSession.GetByUser( _ModelUser);
		}
		[WebMethod]
		public ModelSessionCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ModelSession.GetByUserPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ModelSession.GetByUserCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUser(ModelSession _ModelSession)
		{
			_ModelSession.Reload();
			return _ModelSession.User;
		}
		[WebMethod]
		public void SetUser(ModelSession _ModelSession, Services.Packages.Security.ModelUser _User)
		{
			_ModelSession.Reload();
			_ModelSession.User = _User;
			_ModelSession.Update();
		}
		[WebMethod]
		public Services.Packages.Security.IPSessionRegistrationCollection GetSessionsRegisteredOnIP(ModelSession _ModelSession)
		{
			_ModelSession.Reload();
			return _ModelSession.SessionsRegisteredOnIP;
		}
		[WebMethod]
		public void SetSessionsRegisteredOnIP(ModelSession _ModelSession, Services.Packages.Security.IPSessionRegistrationCollection _SessionsRegisteredOnIP)
		{
			_ModelSession.Reload();
			_ModelSession.SessionsRegisteredOnIP = _SessionsRegisteredOnIP;
			_ModelSession.Update();
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="ModelSessionWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("7dfb2f26-5d47-dcb6-a51c-8eab97bc635b")]
    sealed public class ModelSessionWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IModelSessionService
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
		public ModelSessionWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public ModelSessionWebServiceClient()
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
		public bool Exists(ModelSession _ModelSession)
        {
			object[] results = this.Invoke("Exists", new object[] {_ModelSession});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelSession Read(System.String __SessionToken)
		{
			object[] results = this.Invoke("Read", new object[] {__SessionToken});
			return ((ModelSession)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelSession Reload(ModelSession _ModelSession)
        {
			object[] results = this.Invoke("Reload", new object[] {_ModelSession});
			return ((ModelSession)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelSession Create(System.String __SessionToken)
        {
			object[] results = this.Invoke("Create", new object[] {__SessionToken});
			return ((ModelSession)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __SessionToken)
        {
			this.Invoke("Delete", new object[] {__SessionToken});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(ModelSession _ModelSession)
        {
			this.Invoke("UpdateObject", new object[] {_ModelSession});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(ModelSession _ModelSession)
        {
			this.Invoke("CreateObject", new object[] {_ModelSession});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(ModelSession _ModelSession)
        {
			this.Invoke("DeleteObject", new object[] {_ModelSession});
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
		public ModelSessionCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByUser", new object[] {_ModelUser});
			return ((ModelSessionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelSessionCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByUserPaged", new object[] {_ModelUser,PagingStart,PagingCount});
			return ((ModelSessionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByUserCount", new object[] {_ModelUser});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetUser(ModelSession _ModelSession)
		{
			object[] results = this.Invoke("GetUser", new object[] {_ModelSession});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetUser(ModelSession _ModelSession, Services.Packages.Security.ModelUser _User)
		{
			this.Invoke("GetUser", new object[] {_ModelSession});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetSessionsRegisteredOnIP", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.IPSessionRegistrationCollection GetSessionsRegisteredOnIP(ModelSession _ModelSession)
		{
			object[] results = this.Invoke("GetSessionsRegisteredOnIP", new object[] {_ModelSession});
			return ((Services.Packages.Security.IPSessionRegistrationCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetSessionsRegisteredOnIP", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetSessionsRegisteredOnIP(ModelSession _ModelSession, Services.Packages.Security.IPSessionRegistrationCollection _SessionsRegisteredOnIP)
		{
			this.Invoke("GetSessionsRegisteredOnIP", new object[] {_ModelSession});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages.Security
