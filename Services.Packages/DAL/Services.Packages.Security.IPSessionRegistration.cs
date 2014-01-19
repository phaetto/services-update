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
    /// Defines the contract for the IPSessionRegistration class
    /// </summary>
    [ComVisible(true)]
    [Guid("f22daf76-7b04-6b51-ea9f-1c50f5a969cc")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IIPSessionRegistration
	{
		bool Exists { get; }
		System.String HostName { get; set; }
		System.String UserAgent { get; set; }
		Services.Packages.Security.IPRegistered IP { get; set; }
		Services.Packages.Security.ModelSession Session { get; set; }

		void Read(System.String __HostName, System.String __UserAgent);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(IPSessionRegistration _object);
		void CopyWithKeysTo(IPSessionRegistration _object);
		void CopyFrom(IPSessionRegistration _object);
		void CopyTo(IPSessionRegistration _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.Security.IPSessionRegistration type.
    /// </summary>
    [ComVisible(true)]
    [Guid("8758f878-8fdb-31a9-05d9-b579c1af56ae")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IIPSessionRegistrationService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(IPSessionRegistration _IPSessionRegistration);
		[OperationContract]
        IPSessionRegistration Read(System.String __HostName, System.String __UserAgent);
        [OperationContract]
        IPSessionRegistration Reload(IPSessionRegistration _IPSessionRegistration);
        [OperationContract]
        IPSessionRegistration Create(System.String __HostName, System.String __UserAgent);
        [OperationContract]
        void Delete(System.String __HostName, System.String __UserAgent);
        [OperationContract]
        void UpdateObject(IPSessionRegistration _IPSessionRegistration);
        [OperationContract]
        void CreateObject(IPSessionRegistration _IPSessionRegistration);
        [OperationContract]
        void DeleteObject(IPSessionRegistration _IPSessionRegistration);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		IPSessionRegistrationCollection GetByIP(Services.Packages.Security.IPRegistered _IPRegistered);
		[OperationContract]
		IPSessionRegistrationCollection GetByIPPaged(Services.Packages.Security.IPRegistered _IPRegistered, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByIPCount(Services.Packages.Security.IPRegistered _IPRegistered);
		[OperationContract]
		Services.Packages.Security.IPRegistered GetIP(IPSessionRegistration _IPSessionRegistration);
		[OperationContract]
		void SetIP(IPSessionRegistration _IPSessionRegistration, Services.Packages.Security.IPRegistered _IP);
		[OperationContract]
		IPSessionRegistrationCollection GetBySession(Services.Packages.Security.ModelSession _ModelSession);
		[OperationContract]
		IPSessionRegistrationCollection GetBySessionPaged(Services.Packages.Security.ModelSession _ModelSession, long PagingStart, long PagingCount);
		[OperationContract]
		long GetBySessionCount(Services.Packages.Security.ModelSession _ModelSession);
		[OperationContract]
		Services.Packages.Security.ModelSession GetSession(IPSessionRegistration _IPSessionRegistration);
		[OperationContract]
		void SetSession(IPSessionRegistration _IPSessionRegistration, Services.Packages.Security.ModelSession _Session);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.Security.IPSessionRegistration type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("c4b3c78a-53bf-8b0a-a023-36f63e6610dc")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class IPSessionRegistrationService : IIPSessionRegistrationService
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
        public bool Exists(IPSessionRegistration _IPSessionRegistration)
        {
			return _IPSessionRegistration.Exists;
        }
		
		[WebMethod]
		public IPSessionRegistration Read(System.String __HostName, System.String __UserAgent)
		{
			return new IPSessionRegistration(__HostName, __UserAgent);
		}
		
		[WebMethod]
        public IPSessionRegistration Reload(IPSessionRegistration _IPSessionRegistration)
        {
			_IPSessionRegistration.Reload();
			return _IPSessionRegistration;
        }
		
		[WebMethod]
        public IPSessionRegistration Create(System.String __HostName, System.String __UserAgent)
        {
			return IPSessionRegistration.CreateIPSessionRegistration(__HostName, __UserAgent);
        }
        
        [WebMethod]
        public void Delete(System.String __HostName, System.String __UserAgent)
        {
			IPSessionRegistration.DeleteIPSessionRegistration(__HostName, __UserAgent);
        }
        
        [WebMethod]
        public void UpdateObject(IPSessionRegistration _IPSessionRegistration)
        {
			_IPSessionRegistration.Update();
        }
		
		[WebMethod]
        public void CreateObject(IPSessionRegistration _IPSessionRegistration)
        {
			_IPSessionRegistration.Create();
        }
        
        [WebMethod]
        public void DeleteObject(IPSessionRegistration _IPSessionRegistration)
        {
			_IPSessionRegistration.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			IPSessionRegistration.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			IPSessionRegistration.Redo();
        }
		[WebMethod]
		public IPSessionRegistrationCollection GetByIP(Services.Packages.Security.IPRegistered _IPRegistered)
		{
			return IPSessionRegistration.GetByIP( _IPRegistered);
		}
		[WebMethod]
		public IPSessionRegistrationCollection GetByIPPaged(Services.Packages.Security.IPRegistered _IPRegistered, long PagingStart, long PagingCount)
		{
			return IPSessionRegistration.GetByIPPaged( _IPRegistered, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByIPCount(Services.Packages.Security.IPRegistered _IPRegistered)
		{
			return IPSessionRegistration.GetByIPCount( _IPRegistered);
		}
		[WebMethod]
		public Services.Packages.Security.IPRegistered GetIP(IPSessionRegistration _IPSessionRegistration)
		{
			_IPSessionRegistration.Reload();
			return _IPSessionRegistration.IP;
		}
		[WebMethod]
		public void SetIP(IPSessionRegistration _IPSessionRegistration, Services.Packages.Security.IPRegistered _IP)
		{
			_IPSessionRegistration.Reload();
			_IPSessionRegistration.IP = _IP;
			_IPSessionRegistration.Update();
		}
		[WebMethod]
		public IPSessionRegistrationCollection GetBySession(Services.Packages.Security.ModelSession _ModelSession)
		{
			return IPSessionRegistration.GetBySession( _ModelSession);
		}
		[WebMethod]
		public IPSessionRegistrationCollection GetBySessionPaged(Services.Packages.Security.ModelSession _ModelSession, long PagingStart, long PagingCount)
		{
			return IPSessionRegistration.GetBySessionPaged( _ModelSession, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetBySessionCount(Services.Packages.Security.ModelSession _ModelSession)
		{
			return IPSessionRegistration.GetBySessionCount( _ModelSession);
		}
		[WebMethod]
		public Services.Packages.Security.ModelSession GetSession(IPSessionRegistration _IPSessionRegistration)
		{
			_IPSessionRegistration.Reload();
			return _IPSessionRegistration.Session;
		}
		[WebMethod]
		public void SetSession(IPSessionRegistration _IPSessionRegistration, Services.Packages.Security.ModelSession _Session)
		{
			_IPSessionRegistration.Reload();
			_IPSessionRegistration.Session = _Session;
			_IPSessionRegistration.Update();
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.Security.IPSessionRegistration model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("b3a3c384-e2bb-e71e-06fc-ec2bc5d8aa3a")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class IPSessionRegistration : IIPSessionRegistration, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<IIPSessionRegistrationService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<IIPSessionRegistrationService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<IIPSessionRegistrationService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.IPSessionRegistration"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.IPSessionRegistration"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.Security.IPSessionRegistration.ProviderType");
				
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


		System.String _HostName;
		
		// Key member
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String HostName
		{
            get
            {
                return _HostName;
            }
            set
            {
				if (_HostName != value)
					__hasBeenReadOnce = false;
                _HostName = value;
            }
		}

		System.String _UserAgent;
		
		// Key member
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String UserAgent
		{
            get
            {
                return _UserAgent;
            }
            set
            {
				if (_UserAgent != value)
					__hasBeenReadOnce = false;
                _UserAgent = value;
            }
		}

		bool _IPIsLoaded = false;
		Services.Packages.Security.IPRegistered _IP;
		System.String _IP_IP; 
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.IPRegistered IP
		{
            get
            {
				if (!_IPIsLoaded)
				{
					_IP = new Services.Packages.Security.IPRegistered(_IP_IP);
					if (_IP.Exists)
						_IPIsLoaded = true;
					else _IP = null;
				}
                return _IP;
            }
            set
            {
                _IP = value;
                _IPIsLoaded = true;
                if (_IP != null)
                {
					if (_IP.Exists)
					{
						_IP_IP = _IP.IP;
						
					}
					else
					{
						_IP = null;
					}
				}
            }
		}
		
		public static Services.Packages.Security.IPRegistered GetIP(IPSessionRegistration _IPSessionRegistration)
		{
			return _IPSessionRegistration.IP;
		}

		bool _SessionIsLoaded = false;
		Services.Packages.Security.ModelSession _Session;
		System.String _Session_SessionToken; 
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.ModelSession Session
		{
            get
            {
				if (!_SessionIsLoaded)
				{
					_Session = new Services.Packages.Security.ModelSession(_Session_SessionToken);
					if (_Session.Exists)
						_SessionIsLoaded = true;
					else _Session = null;
				}
                return _Session;
            }
            set
            {
                _Session = value;
                _SessionIsLoaded = true;
                if (_Session != null)
                {
					if (_Session.Exists)
					{
						_Session_SessionToken = _Session.SessionToken;
						
					}
					else
					{
						_Session = null;
					}
				}
            }
		}
		
		public static Services.Packages.Security.ModelSession GetSession(IPSessionRegistration _IPSessionRegistration)
		{
			return _IPSessionRegistration.Session;
		}

		public static IPSessionRegistrationCollection GetByIP(Services.Packages.Security.IPRegistered _IPRegistered)
        {
			IPSessionRegistrationCollection _IPSessionRegistrationCollection = new IPSessionRegistrationCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("IPSeReGetByIP", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_IP;
				if (_IPRegistered != null) {
				param_IP = ClassConnectionProvider.GetDatabaseParameter("IP", typeof(System.String), 64);
				param_IP.Value = ClassConnectionProvider.FromValueToSqlModelType(_IPRegistered.IP);
				} else {
				param_IP = ClassConnectionProvider.GetDatabaseParameter("IP", DBNull.Value);
				}
				command.Parameters.Add(param_IP);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					IPSessionRegistration o = new IPSessionRegistration();
                
					o.__databaseState = RowState.Initialized;
                    o._HostName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["HostName"], typeof(System.String));
				o._UserAgent = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserAgent"], typeof(System.String));
				o._IPIsLoaded = false; if (dr["IP_IP"] == DBNull.Value) { o._IP = null; o._IPIsLoaded = true; }  else o._IP_IP = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IP_IP"], typeof(System.String));
				o._SessionIsLoaded = false; if (dr["Session_SessionToken"] == DBNull.Value) { o._Session = null; o._SessionIsLoaded = true; }  else o._Session_SessionToken = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Session_SessionToken"], typeof(System.String));
				
                    
                    _IPSessionRegistrationCollection.Add(o);
                }

                dr.Close();
            }
            
            return _IPSessionRegistrationCollection;
        }
        
        public static IPSessionRegistrationCollection GetByIPPaged(Services.Packages.Security.IPRegistered _IPRegistered, long PagingStart, long PagingCount)
        {
			IPSessionRegistrationCollection _IPSessionRegistrationCollection = new IPSessionRegistrationCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("IPSeReGetByIPPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_IP;
				if (_IPRegistered != null) {
				param_IP = ClassConnectionProvider.GetDatabaseParameter("IP", typeof(System.String), 64);
				param_IP.Value = ClassConnectionProvider.FromValueToSqlModelType(_IPRegistered.IP);
				} else {
				param_IP = ClassConnectionProvider.GetDatabaseParameter("IP", DBNull.Value);
				}
				command.Parameters.Add(param_IP);
				
                
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
					IPSessionRegistration o = new IPSessionRegistration();
                
					o.__databaseState = RowState.Initialized;
                    o._HostName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["HostName"], typeof(System.String));
				o._UserAgent = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserAgent"], typeof(System.String));
				o._IPIsLoaded = false; if (dr["IP_IP"] == DBNull.Value) { o._IP = null; o._IPIsLoaded = true; }  else o._IP_IP = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IP_IP"], typeof(System.String));
				o._SessionIsLoaded = false; if (dr["Session_SessionToken"] == DBNull.Value) { o._Session = null; o._SessionIsLoaded = true; }  else o._Session_SessionToken = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Session_SessionToken"], typeof(System.String));
				
                    
                    _IPSessionRegistrationCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _IPSessionRegistrationCollection;
        }
        
        public static long GetByIPCount(Services.Packages.Security.IPRegistered _IPRegistered)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("IPSeReGetByIPCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_IP;
				if (_IPRegistered != null) {
				param_IP = ClassConnectionProvider.GetDatabaseParameter("IP", typeof(System.String), 64);
				param_IP.Value = ClassConnectionProvider.FromValueToSqlModelType(_IPRegistered.IP);
				} else {
				param_IP = ClassConnectionProvider.GetDatabaseParameter("IP", DBNull.Value);
				}
				command.Parameters.Add(param_IP);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		public static IPSessionRegistrationCollection GetBySession(Services.Packages.Security.ModelSession _ModelSession)
        {
			IPSessionRegistrationCollection _IPSessionRegistrationCollection = new IPSessionRegistrationCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("IPSeReGetBySe", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_SessionToken;
				if (_ModelSession != null) {
				param_SessionToken = ClassConnectionProvider.GetDatabaseParameter("SessionToken", typeof(System.String), 384);
				param_SessionToken.Value = ClassConnectionProvider.FromValueToSqlModelType(_ModelSession.SessionToken);
				} else {
				param_SessionToken = ClassConnectionProvider.GetDatabaseParameter("SessionToken", DBNull.Value);
				}
				command.Parameters.Add(param_SessionToken);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					IPSessionRegistration o = new IPSessionRegistration();
                
					o.__databaseState = RowState.Initialized;
                    o._HostName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["HostName"], typeof(System.String));
				o._UserAgent = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserAgent"], typeof(System.String));
				o._IPIsLoaded = false; if (dr["IP_IP"] == DBNull.Value) { o._IP = null; o._IPIsLoaded = true; }  else o._IP_IP = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IP_IP"], typeof(System.String));
				o._SessionIsLoaded = false; if (dr["Session_SessionToken"] == DBNull.Value) { o._Session = null; o._SessionIsLoaded = true; }  else o._Session_SessionToken = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Session_SessionToken"], typeof(System.String));
				
                    
                    _IPSessionRegistrationCollection.Add(o);
                }

                dr.Close();
            }
            
            return _IPSessionRegistrationCollection;
        }
        
        public static IPSessionRegistrationCollection GetBySessionPaged(Services.Packages.Security.ModelSession _ModelSession, long PagingStart, long PagingCount)
        {
			IPSessionRegistrationCollection _IPSessionRegistrationCollection = new IPSessionRegistrationCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("IPSeReGetBySePaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_SessionToken;
				if (_ModelSession != null) {
				param_SessionToken = ClassConnectionProvider.GetDatabaseParameter("SessionToken", typeof(System.String), 384);
				param_SessionToken.Value = ClassConnectionProvider.FromValueToSqlModelType(_ModelSession.SessionToken);
				} else {
				param_SessionToken = ClassConnectionProvider.GetDatabaseParameter("SessionToken", DBNull.Value);
				}
				command.Parameters.Add(param_SessionToken);
				
                
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
					IPSessionRegistration o = new IPSessionRegistration();
                
					o.__databaseState = RowState.Initialized;
                    o._HostName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["HostName"], typeof(System.String));
				o._UserAgent = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserAgent"], typeof(System.String));
				o._IPIsLoaded = false; if (dr["IP_IP"] == DBNull.Value) { o._IP = null; o._IPIsLoaded = true; }  else o._IP_IP = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IP_IP"], typeof(System.String));
				o._SessionIsLoaded = false; if (dr["Session_SessionToken"] == DBNull.Value) { o._Session = null; o._SessionIsLoaded = true; }  else o._Session_SessionToken = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Session_SessionToken"], typeof(System.String));
				
                    
                    _IPSessionRegistrationCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _IPSessionRegistrationCollection;
        }
        
        public static long GetBySessionCount(Services.Packages.Security.ModelSession _ModelSession)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("IPSeReGetBySeCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_SessionToken;
				if (_ModelSession != null) {
				param_SessionToken = ClassConnectionProvider.GetDatabaseParameter("SessionToken", typeof(System.String), 384);
				param_SessionToken.Value = ClassConnectionProvider.FromValueToSqlModelType(_ModelSession.SessionToken);
				} else {
				param_SessionToken = ClassConnectionProvider.GetDatabaseParameter("SessionToken", DBNull.Value);
				}
				command.Parameters.Add(param_SessionToken);
				
                
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
        
        public IPSessionRegistration() {}
        
        public IPSessionRegistration(System.String __HostName, System.String __UserAgent)
        {
			Read(__HostName, __UserAgent);
        }
        
        #region CRUD
        
        void Exist()
        {
			// sql read - should be changed to specific exist implementation
			using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
			{
				dbconn.Open();
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("IPSeReRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
				DbParameter param_HostName = ClassConnectionProvider.GetDatabaseParameter("HostName", typeof(System.String), 128);
				param_HostName.Value = ClassConnectionProvider.FromValueToSqlModelType(_HostName);
				command.Parameters.Add(param_HostName);
				DbParameter param_UserAgent = ClassConnectionProvider.GetDatabaseParameter("UserAgent", typeof(System.String), 128);
				param_UserAgent.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserAgent);
				command.Parameters.Add(param_UserAgent);
				
                
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
        
        public void Read(System.String __HostName, System.String __UserAgent)
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].Read(__HostName, __UserAgent);
					return;
				}

                // Get a service via an algorithm
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "IPSeRe");
                // Perfect for read operations, but not for write
                // scalingServices[nextIndex].Read(__HostName, __UserAgent);
				// return;

				throw new NotImplementedException();
            }

            try
            {
				// sql read
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("IPSeReRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					_HostName = __HostName;
				DbParameter param_HostName = ClassConnectionProvider.GetDatabaseParameter("HostName", typeof(System.String), 128);
				param_HostName.Value = ClassConnectionProvider.FromValueToSqlModelType(__HostName);
				command.Parameters.Add(param_HostName);
				_UserAgent = __UserAgent;
				DbParameter param_UserAgent = ClassConnectionProvider.GetDatabaseParameter("UserAgent", typeof(System.String), 128);
				param_UserAgent.Value = ClassConnectionProvider.FromValueToSqlModelType(__UserAgent);
				command.Parameters.Add(param_UserAgent);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_HostName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["HostName"], typeof(System.String));
				_UserAgent = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserAgent"], typeof(System.String));
				_IPIsLoaded = false; if (dr["IP_IP"] == DBNull.Value) { _IP = null; _IPIsLoaded = true; }  else _IP_IP = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IP_IP"], typeof(System.String));
				_SessionIsLoaded = false; if (dr["Session_SessionToken"] == DBNull.Value) { _Session = null; _SessionIsLoaded = true; }  else _Session_SessionToken = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Session_SessionToken"], typeof(System.String));
				
                    
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
                            failoverServices[n].Read(__HostName, __UserAgent);
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "IPSeRe");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("IPSeReRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_HostName = ClassConnectionProvider.GetDatabaseParameter("HostName", typeof(System.String), 128);
				param_HostName.Value = ClassConnectionProvider.FromValueToSqlModelType(_HostName);
				command.Parameters.Add(param_HostName);
				DbParameter param_UserAgent = ClassConnectionProvider.GetDatabaseParameter("UserAgent", typeof(System.String), 128);
				param_UserAgent.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserAgent);
				command.Parameters.Add(param_UserAgent);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_HostName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["HostName"], typeof(System.String));
				_UserAgent = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserAgent"], typeof(System.String));
				_IPIsLoaded = false; if (dr["IP_IP"] == DBNull.Value) { _IP = null; _IPIsLoaded = true; }  else _IP_IP = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IP_IP"], typeof(System.String));
				_SessionIsLoaded = false; if (dr["Session_SessionToken"] == DBNull.Value) { _Session = null; _SessionIsLoaded = true; }  else _Session_SessionToken = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Session_SessionToken"], typeof(System.String));
				
                    
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("IPSeReCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_HostName = ClassConnectionProvider.GetDatabaseParameter("HostName", typeof(System.String), 128);
				param_HostName.Value = ClassConnectionProvider.FromValueToSqlModelType(_HostName);
				command.Parameters.Add(param_HostName);
				DbParameter param_UserAgent = ClassConnectionProvider.GetDatabaseParameter("UserAgent", typeof(System.String), 128);
				param_UserAgent.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserAgent);
				command.Parameters.Add(param_UserAgent);
				DbParameter param_IP_IP = ClassConnectionProvider.GetDatabaseParameter("IP_IP", typeof(System.String), 64);
				param_IP_IP.Value = ClassConnectionProvider.FromValueToSqlModelType(_IP_IP);
				if (_IP == null) param_IP_IP.Value = DBNull.Value;
				else param_IP_IP.Value = ClassConnectionProvider.FromValueToSqlModelType(_IP.IP);
				command.Parameters.Add(param_IP_IP);
				DbParameter param_Session_SessionToken = ClassConnectionProvider.GetDatabaseParameter("Session_SessionToken", typeof(System.String), 384);
				param_Session_SessionToken.Value = ClassConnectionProvider.FromValueToSqlModelType(_Session_SessionToken);
				if (_Session == null) param_Session_SessionToken.Value = DBNull.Value;
				else param_Session_SessionToken.Value = ClassConnectionProvider.FromValueToSqlModelType(_Session.SessionToken);
				command.Parameters.Add(param_Session_SessionToken);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_HostName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["HostName"], typeof(System.String));
				_UserAgent = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserAgent"], typeof(System.String));
				_IPIsLoaded = false; if (dr["IP_IP"] == DBNull.Value) { _IP = null; _IPIsLoaded = true; }  else _IP_IP = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IP_IP"], typeof(System.String));
				_SessionIsLoaded = false; if (dr["Session_SessionToken"] == DBNull.Value) { _Session = null; _SessionIsLoaded = true; }  else _Session_SessionToken = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Session_SessionToken"], typeof(System.String));
				
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
        
        static public IPSessionRegistration CreateIPSessionRegistration(System.String __HostName, System.String __UserAgent)
        {
            IPSessionRegistration o = new IPSessionRegistration(__HostName, __UserAgent);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("IPSeReUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_HostName = ClassConnectionProvider.GetDatabaseParameter("HostName", typeof(System.String), 128);
				param_HostName.Value = ClassConnectionProvider.FromValueToSqlModelType(_HostName);
				command.Parameters.Add(param_HostName);
				DbParameter param_UserAgent = ClassConnectionProvider.GetDatabaseParameter("UserAgent", typeof(System.String), 128);
				param_UserAgent.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserAgent);
				command.Parameters.Add(param_UserAgent);
				DbParameter param_IPHasChanged = ClassConnectionProvider.GetDatabaseParameter("IPHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_IPIsLoaded));
				command.Parameters.Add(param_IPHasChanged);
				DbParameter param_IP_IP = ClassConnectionProvider.GetDatabaseParameter("IP_IP", typeof(System.String), 64);
				param_IP_IP.Value = ClassConnectionProvider.FromValueToSqlModelType(_IP_IP);
				if (_IP == null) param_IP_IP.Value = DBNull.Value;
				else param_IP_IP.Value = ClassConnectionProvider.FromValueToSqlModelType(_IP.IP);
				command.Parameters.Add(param_IP_IP);
				DbParameter param_SessionHasChanged = ClassConnectionProvider.GetDatabaseParameter("SessionHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_SessionIsLoaded));
				command.Parameters.Add(param_SessionHasChanged);
				DbParameter param_Session_SessionToken = ClassConnectionProvider.GetDatabaseParameter("Session_SessionToken", typeof(System.String), 384);
				param_Session_SessionToken.Value = ClassConnectionProvider.FromValueToSqlModelType(_Session_SessionToken);
				if (_Session == null) param_Session_SessionToken.Value = DBNull.Value;
				else param_Session_SessionToken.Value = ClassConnectionProvider.FromValueToSqlModelType(_Session.SessionToken);
				command.Parameters.Add(param_Session_SessionToken);
				

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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("IPSeReDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_HostName = ClassConnectionProvider.GetDatabaseParameter("HostName", typeof(System.String), 128);
				param_HostName.Value = ClassConnectionProvider.FromValueToSqlModelType(_HostName);
				command.Parameters.Add(param_HostName);
				DbParameter param_UserAgent = ClassConnectionProvider.GetDatabaseParameter("UserAgent", typeof(System.String), 128);
				param_UserAgent.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserAgent);
				command.Parameters.Add(param_UserAgent);
				
				
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
        
        static public void DeleteIPSessionRegistration(System.String __HostName, System.String __UserAgent)
        {
            IPSessionRegistration o = new IPSessionRegistration(__HostName, __UserAgent);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(IPSessionRegistration _object)
        {
			_IP = null;
			_IPIsLoaded = false;
			_Session = null;
			_SessionIsLoaded = false;
			_HostName = _object._HostName;
			_UserAgent = _object._UserAgent;
			
        }
        
        public void CopyWithKeysTo(IPSessionRegistration _object)
        {
			_object._IP = null;
			_object._IPIsLoaded = false;
			_object._Session = null;
			_object._SessionIsLoaded = false;
			_object._HostName = _HostName;
			_object._UserAgent = _UserAgent;
			
        }
        
        static public void CopyWithKeysObject(IPSessionRegistration _objectFrom, IPSessionRegistration _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(IPSessionRegistration _object)
        {
			_IP = null;
			_IPIsLoaded = false;
			_Session = null;
			_SessionIsLoaded = false;
			
        }
        
        public void CopyTo(IPSessionRegistration _object)
        {
			_object._IP = null;
			_object._IPIsLoaded = false;
			_object._Session = null;
			_object._SessionIsLoaded = false;
			
        }
        
        static public void CopyObject(IPSessionRegistration _objectFrom, IPSessionRegistration _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(IPSessionRegistration).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(IPSessionRegistration).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(IPSessionRegistration _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			IPSessionRegistrationUndoRedoCollection allUndidAndNotRedoneEntries = IPSessionRegistrationUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			IPSessionRegistrationUndoRedo _urobject = new IPSessionRegistrationUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.IP_IP = _object._IP_IP;
			_urobject.Session_SessionToken = _object._Session_SessionToken;
			_urobject.HostName = _object._HostName;
			_urobject.UserAgent = _object._UserAgent;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(IPSessionRegistration).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = IPSessionRegistrationUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				IPSessionRegistrationUndoRedoCollection allOldUndoEntries = IPSessionRegistrationUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			IPSessionRegistrationUndoRedoCollection firstUndoEntries = IPSessionRegistrationUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			IPSessionRegistrationUndoRedo _urobject = firstUndoEntries[0];
			
			IPSessionRegistration _object = new IPSessionRegistration();
			_object._IP = null;
			_object._IPIsLoaded = false;
			_object._IP_IP = _urobject.IP_IP;
			_object._Session = null;
			_object._SessionIsLoaded = false;
			_object._Session_SessionToken = _urobject.Session_SessionToken;
			_object._HostName = _urobject.HostName;
			_object._UserAgent = _urobject.UserAgent;
			

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
			IPSessionRegistrationUndoRedoCollection firstEntryToRedoEntries = IPSessionRegistrationUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			IPSessionRegistrationUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			IPSessionRegistration _object = new IPSessionRegistration();
			_object._IP = null;
			_object._IPIsLoaded = false;
			_object._IP_IP = _urobject.IP_IP;
			_object._Session = null;
			_object._SessionIsLoaded = false;
			_object._Session_SessionToken = _urobject.Session_SessionToken;
			_object._HostName = _urobject.HostName;
			_object._UserAgent = _urobject.UserAgent;
			

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
    /// Defines the contract for the IPSessionRegistrationCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("2ec56d48-a5f6-240d-eecd-e6b758b3f29e")]
    public interface IIPSessionRegistrationCollection : IEnumerable<IPSessionRegistration>
    {
        int IndexOf(IPSessionRegistration item);
        void Insert(int index, IPSessionRegistration item);
        void RemoveAt(int index);
        IPSessionRegistration this[int index] { get; set; }
        void Add(IPSessionRegistration item);
        void Clear();
        bool Contains(IPSessionRegistration item);
        void CopyTo(IPSessionRegistration[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(IPSessionRegistration item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.Security.IPSessionRegistration
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("fef4d8c8-a20c-a8f3-a8cb-bdc267dfc5c8")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class IPSessionRegistrationCollection : IIPSessionRegistrationCollection, IList<IPSessionRegistration>, IHierarchicalEnumerable
    {
        List<IPSessionRegistration> _list = new List<IPSessionRegistration>();
        
        public static implicit operator List<IPSessionRegistration>(IPSessionRegistrationCollection collection)
        {
            return collection._list;
        }

        #region IList<IPSessionRegistration> Members

        public int IndexOf(IPSessionRegistration item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, IPSessionRegistration item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public IPSessionRegistration this[int index]
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

        #region ICollection<IPSessionRegistration> Members

        public void Add(IPSessionRegistration item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(IPSessionRegistration item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(IPSessionRegistration[] array, int arrayIndex)
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

        public bool Remove(IPSessionRegistration item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<IPSessionRegistration> Members

        public IEnumerator<IPSessionRegistration> GetEnumerator()
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
	/// that share Services.Packages.Security.IPSessionRegistration objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Security.Web.IPSessionRegistrationWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class IPSessionRegistrationWebService : WebService, IIPSessionRegistrationService
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
        public bool Exists(IPSessionRegistration _IPSessionRegistration)
        {
			return _IPSessionRegistration.Exists;
        }
		
		[WebMethod]
		public IPSessionRegistration Read(System.String __HostName, System.String __UserAgent)
		{
			return new IPSessionRegistration(__HostName, __UserAgent);
		}
		
		[WebMethod]
        public IPSessionRegistration Reload(IPSessionRegistration _IPSessionRegistration)
        {
			_IPSessionRegistration.Reload();
			return _IPSessionRegistration;
        }
		
		[WebMethod]
        public IPSessionRegistration Create(System.String __HostName, System.String __UserAgent)
        {
			return IPSessionRegistration.CreateIPSessionRegistration(__HostName, __UserAgent);
        }
        
        [WebMethod]
        public void Delete(System.String __HostName, System.String __UserAgent)
        {
			IPSessionRegistration.DeleteIPSessionRegistration(__HostName, __UserAgent);
        }
        
        [WebMethod]
        public void UpdateObject(IPSessionRegistration _IPSessionRegistration)
        {
			_IPSessionRegistration.Update();
        }
		
		[WebMethod]
        public void CreateObject(IPSessionRegistration _IPSessionRegistration)
        {
			_IPSessionRegistration.Create();
        }
        
        [WebMethod]
        public void DeleteObject(IPSessionRegistration _IPSessionRegistration)
        {
			_IPSessionRegistration.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			IPSessionRegistration.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			IPSessionRegistration.Redo();
        }
		[WebMethod]
		public IPSessionRegistrationCollection GetByIP(Services.Packages.Security.IPRegistered _IPRegistered)
		{
			return IPSessionRegistration.GetByIP( _IPRegistered);
		}
		[WebMethod]
		public IPSessionRegistrationCollection GetByIPPaged(Services.Packages.Security.IPRegistered _IPRegistered, long PagingStart, long PagingCount)
		{
			return IPSessionRegistration.GetByIPPaged( _IPRegistered, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByIPCount(Services.Packages.Security.IPRegistered _IPRegistered)
		{
			return IPSessionRegistration.GetByIPCount( _IPRegistered);
		}
		[WebMethod]
		public Services.Packages.Security.IPRegistered GetIP(IPSessionRegistration _IPSessionRegistration)
		{
			_IPSessionRegistration.Reload();
			return _IPSessionRegistration.IP;
		}
		[WebMethod]
		public void SetIP(IPSessionRegistration _IPSessionRegistration, Services.Packages.Security.IPRegistered _IP)
		{
			_IPSessionRegistration.Reload();
			_IPSessionRegistration.IP = _IP;
			_IPSessionRegistration.Update();
		}
		[WebMethod]
		public IPSessionRegistrationCollection GetBySession(Services.Packages.Security.ModelSession _ModelSession)
		{
			return IPSessionRegistration.GetBySession( _ModelSession);
		}
		[WebMethod]
		public IPSessionRegistrationCollection GetBySessionPaged(Services.Packages.Security.ModelSession _ModelSession, long PagingStart, long PagingCount)
		{
			return IPSessionRegistration.GetBySessionPaged( _ModelSession, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetBySessionCount(Services.Packages.Security.ModelSession _ModelSession)
		{
			return IPSessionRegistration.GetBySessionCount( _ModelSession);
		}
		[WebMethod]
		public Services.Packages.Security.ModelSession GetSession(IPSessionRegistration _IPSessionRegistration)
		{
			_IPSessionRegistration.Reload();
			return _IPSessionRegistration.Session;
		}
		[WebMethod]
		public void SetSession(IPSessionRegistration _IPSessionRegistration, Services.Packages.Security.ModelSession _Session)
		{
			_IPSessionRegistration.Reload();
			_IPSessionRegistration.Session = _Session;
			_IPSessionRegistration.Update();
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="IPSessionRegistrationWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("d0adfb79-e1a1-dfe5-b57f-c5edfc668e53")]
    sealed public class IPSessionRegistrationWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IIPSessionRegistrationService
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
		public IPSessionRegistrationWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public IPSessionRegistrationWebServiceClient()
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
		public bool Exists(IPSessionRegistration _IPSessionRegistration)
        {
			object[] results = this.Invoke("Exists", new object[] {_IPSessionRegistration});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public IPSessionRegistration Read(System.String __HostName, System.String __UserAgent)
		{
			object[] results = this.Invoke("Read", new object[] {__HostName, __UserAgent});
			return ((IPSessionRegistration)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public IPSessionRegistration Reload(IPSessionRegistration _IPSessionRegistration)
        {
			object[] results = this.Invoke("Reload", new object[] {_IPSessionRegistration});
			return ((IPSessionRegistration)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public IPSessionRegistration Create(System.String __HostName, System.String __UserAgent)
        {
			object[] results = this.Invoke("Create", new object[] {__HostName, __UserAgent});
			return ((IPSessionRegistration)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __HostName, System.String __UserAgent)
        {
			this.Invoke("Delete", new object[] {__HostName, __UserAgent});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(IPSessionRegistration _IPSessionRegistration)
        {
			this.Invoke("UpdateObject", new object[] {_IPSessionRegistration});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(IPSessionRegistration _IPSessionRegistration)
        {
			this.Invoke("CreateObject", new object[] {_IPSessionRegistration});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(IPSessionRegistration _IPSessionRegistration)
        {
			this.Invoke("DeleteObject", new object[] {_IPSessionRegistration});
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
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByIP", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public IPSessionRegistrationCollection GetByIP(Services.Packages.Security.IPRegistered _IPRegistered) {
			object[] results = this.Invoke("GetByIP", new object[] {_IPRegistered});
			return ((IPSessionRegistrationCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByIPPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public IPSessionRegistrationCollection GetByIPPaged(Services.Packages.Security.IPRegistered _IPRegistered, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByIPPaged", new object[] {_IPRegistered,PagingStart,PagingCount});
			return ((IPSessionRegistrationCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByIPCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByIPCount(Services.Packages.Security.IPRegistered _IPRegistered) {
			object[] results = this.Invoke("GetByIPCount", new object[] {_IPRegistered});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetIP", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.IPRegistered GetIP(IPSessionRegistration _IPSessionRegistration)
		{
			object[] results = this.Invoke("GetIP", new object[] {_IPSessionRegistration});
			return ((Services.Packages.Security.IPRegistered)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetIP", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetIP(IPSessionRegistration _IPSessionRegistration, Services.Packages.Security.IPRegistered _IP)
		{
			this.Invoke("GetIP", new object[] {_IPSessionRegistration});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetBySession", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public IPSessionRegistrationCollection GetBySession(Services.Packages.Security.ModelSession _ModelSession) {
			object[] results = this.Invoke("GetBySession", new object[] {_ModelSession});
			return ((IPSessionRegistrationCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetBySessionPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public IPSessionRegistrationCollection GetBySessionPaged(Services.Packages.Security.ModelSession _ModelSession, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetBySessionPaged", new object[] {_ModelSession,PagingStart,PagingCount});
			return ((IPSessionRegistrationCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetBySessionCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetBySessionCount(Services.Packages.Security.ModelSession _ModelSession) {
			object[] results = this.Invoke("GetBySessionCount", new object[] {_ModelSession});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetSession", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelSession GetSession(IPSessionRegistration _IPSessionRegistration)
		{
			object[] results = this.Invoke("GetSession", new object[] {_IPSessionRegistration});
			return ((Services.Packages.Security.ModelSession)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetSession", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetSession(IPSessionRegistration _IPSessionRegistration, Services.Packages.Security.ModelSession _Session)
		{
			this.Invoke("GetSession", new object[] {_IPSessionRegistration});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages.Security
