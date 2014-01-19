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
    /// Defines the contract for the IPRegistered class
    /// </summary>
    [ComVisible(true)]
    [Guid("d51804bb-1432-483f-3361-c8e13ffec72a")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IIPRegistered
	{
		bool Exists { get; }
		System.String IP { get; set; }
		System.Boolean Allowed { get; set; }
		System.Int32 Failures { get; set; }
		System.DateTime DenialIssuedUntilTime { get; set; }
		Services.Packages.Security.IPSessionRegistrationCollection SessionsRegisteredOnIP { get; set; }

		void Read(System.String __IP);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(IPRegistered _object);
		void CopyWithKeysTo(IPRegistered _object);
		void CopyFrom(IPRegistered _object);
		void CopyTo(IPRegistered _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.Security.IPRegistered type.
    /// </summary>
    [ComVisible(true)]
    [Guid("990b6e5f-33a5-508e-1a98-7e0cac8dab91")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IIPRegisteredService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(IPRegistered _IPRegistered);
		[OperationContract]
        IPRegistered Read(System.String __IP);
        [OperationContract]
        IPRegistered Reload(IPRegistered _IPRegistered);
        [OperationContract]
        IPRegistered Create(System.String __IP);
        [OperationContract]
        void Delete(System.String __IP);
        [OperationContract]
        void UpdateObject(IPRegistered _IPRegistered);
        [OperationContract]
        void CreateObject(IPRegistered _IPRegistered);
        [OperationContract]
        void DeleteObject(IPRegistered _IPRegistered);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		Services.Packages.Security.IPSessionRegistrationCollection GetSessionsRegisteredOnIP(IPRegistered _IPRegistered);
		[OperationContract]
		void SetSessionsRegisteredOnIP(IPRegistered _IPRegistered, Services.Packages.Security.IPSessionRegistrationCollection _SessionsRegisteredOnIP);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.Security.IPRegistered type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("64ae1a09-6982-4d7d-ed59-5c57161ddb24")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class IPRegisteredService : IIPRegisteredService
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
        public bool Exists(IPRegistered _IPRegistered)
        {
			return _IPRegistered.Exists;
        }
		
		[WebMethod]
		public IPRegistered Read(System.String __IP)
		{
			return new IPRegistered(__IP);
		}
		
		[WebMethod]
        public IPRegistered Reload(IPRegistered _IPRegistered)
        {
			_IPRegistered.Reload();
			return _IPRegistered;
        }
		
		[WebMethod]
        public IPRegistered Create(System.String __IP)
        {
			return IPRegistered.CreateIPRegistered(__IP);
        }
        
        [WebMethod]
        public void Delete(System.String __IP)
        {
			IPRegistered.DeleteIPRegistered(__IP);
        }
        
        [WebMethod]
        public void UpdateObject(IPRegistered _IPRegistered)
        {
			_IPRegistered.Update();
        }
		
		[WebMethod]
        public void CreateObject(IPRegistered _IPRegistered)
        {
			_IPRegistered.Create();
        }
        
        [WebMethod]
        public void DeleteObject(IPRegistered _IPRegistered)
        {
			_IPRegistered.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			IPRegistered.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			IPRegistered.Redo();
        }
		[WebMethod]
		public Services.Packages.Security.IPSessionRegistrationCollection GetSessionsRegisteredOnIP(IPRegistered _IPRegistered)
		{
			_IPRegistered.Reload();
			return _IPRegistered.SessionsRegisteredOnIP;
		}
		[WebMethod]
		public void SetSessionsRegisteredOnIP(IPRegistered _IPRegistered, Services.Packages.Security.IPSessionRegistrationCollection _SessionsRegisteredOnIP)
		{
			_IPRegistered.Reload();
			_IPRegistered.SessionsRegisteredOnIP = _SessionsRegisteredOnIP;
			_IPRegistered.Update();
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.Security.IPRegistered model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("f8b36240-251d-87b6-75c7-ba9a96339ba5")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class IPRegistered : IIPRegistered, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<IIPRegisteredService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<IIPRegisteredService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<IIPRegisteredService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.IPRegistered"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.IPRegistered"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.Security.IPRegistered.ProviderType");
				
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


		System.String _IP;
		
		// Key member
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String IP
		{
            get
            {
                return _IP;
            }
            set
            {
				if (_IP != value)
					__hasBeenReadOnce = false;
                _IP = value;
            }
		}

		System.Boolean _Allowed;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Boolean Allowed
		{
            get
            {
                return _Allowed;
            }
            set
            {
                _Allowed = value;
            }
		}

		System.Int32 _Failures;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Int32 Failures
		{
            get
            {
                return _Failures;
            }
            set
            {
                _Failures = value;
            }
		}

		System.DateTime _DenialIssuedUntilTime;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.DateTime DenialIssuedUntilTime
		{
            get
            {
                return _DenialIssuedUntilTime;
            }
            set
            {
                _DenialIssuedUntilTime = value;
            }
		}

		Services.Packages.Security.IPSessionRegistrationCollection _SessionsRegisteredOnIP;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.IPSessionRegistrationCollection SessionsRegisteredOnIP
		{
            get
            {
				if (_SessionsRegisteredOnIP == null)
					_SessionsRegisteredOnIP = Services.Packages.Security.IPSessionRegistration.GetByIP(this);
				
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
							_SessionsRegisteredOnIP[n].IP = null;
							_SessionsRegisteredOnIP[n].Update();
						}
					}
	                
					_SessionsRegisteredOnIP = value;
					
					if (_SessionsRegisteredOnIP != null)
					{
						for(int n = 0; n < _SessionsRegisteredOnIP.Count; ++n)
						{
							_SessionsRegisteredOnIP[n].IP = this;
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
			_SessionsRegisteredOnIP = Services.Packages.Security.IPSessionRegistration.GetByIP(this);
		}

		public bool Exists
        {
            get {
				if (!__hasBeenReadOnce)
					Exist();
				
				return __databaseState == RowState.Initialized;
			}
        }
        
        public IPRegistered() {}
        
        public IPRegistered(System.String __IP)
        {
			Read(__IP);
        }
        
        #region CRUD
        
        void Exist()
        {
			// sql read - should be changed to specific exist implementation
			using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
			{
				dbconn.Open();
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("IPReRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
				DbParameter param_IP = ClassConnectionProvider.GetDatabaseParameter("IP", typeof(System.String), 64);
				param_IP.Value = ClassConnectionProvider.FromValueToSqlModelType(_IP);
				command.Parameters.Add(param_IP);
				
                
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
        
        public void Read(System.String __IP)
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].Read(__IP);
					return;
				}

                // Get a service via an algorithm
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "IPRe");
                // Perfect for read operations, but not for write
                // scalingServices[nextIndex].Read(__IP);
				// return;

				throw new NotImplementedException();
            }

            try
            {
				// sql read
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("IPReRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					_IP = __IP;
				DbParameter param_IP = ClassConnectionProvider.GetDatabaseParameter("IP", typeof(System.String), 64);
				param_IP.Value = ClassConnectionProvider.FromValueToSqlModelType(__IP);
				command.Parameters.Add(param_IP);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_IP = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IP"], typeof(System.String));
				_Allowed = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allowed"], typeof(System.Boolean));
				_Failures = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Failures"], typeof(System.Int32));
				_DenialIssuedUntilTime = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["DenialIssuedUntilTime"], typeof(System.DateTime));
				
                    
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
                            failoverServices[n].Read(__IP);
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "IPRe");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("IPReRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_IP = ClassConnectionProvider.GetDatabaseParameter("IP", typeof(System.String), 64);
				param_IP.Value = ClassConnectionProvider.FromValueToSqlModelType(_IP);
				command.Parameters.Add(param_IP);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_IP = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IP"], typeof(System.String));
				_Allowed = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allowed"], typeof(System.Boolean));
				_Failures = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Failures"], typeof(System.Int32));
				_DenialIssuedUntilTime = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["DenialIssuedUntilTime"], typeof(System.DateTime));
				
                    
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("IPReCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_IP = ClassConnectionProvider.GetDatabaseParameter("IP", typeof(System.String), 64);
				param_IP.Value = ClassConnectionProvider.FromValueToSqlModelType(_IP);
				command.Parameters.Add(param_IP);
				DbParameter param_Allowed = ClassConnectionProvider.GetDatabaseParameter("Allowed", typeof(System.Boolean), -1);
				param_Allowed.Value = ClassConnectionProvider.FromValueToSqlModelType(_Allowed);
				command.Parameters.Add(param_Allowed);
				DbParameter param_Failures = ClassConnectionProvider.GetDatabaseParameter("Failures", typeof(System.Int32), -1);
				param_Failures.Value = ClassConnectionProvider.FromValueToSqlModelType(_Failures);
				command.Parameters.Add(param_Failures);
				DbParameter param_DenialIssuedUntilTime = ClassConnectionProvider.GetDatabaseParameter("DenialIssuedUntilTime", typeof(System.DateTime), -1);
				param_DenialIssuedUntilTime.Value = ClassConnectionProvider.FromValueToSqlModelType(_DenialIssuedUntilTime);
				command.Parameters.Add(param_DenialIssuedUntilTime);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_IP = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IP"], typeof(System.String));
				_Allowed = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allowed"], typeof(System.Boolean));
				_Failures = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Failures"], typeof(System.Int32));
				_DenialIssuedUntilTime = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["DenialIssuedUntilTime"], typeof(System.DateTime));
				
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
        
        static public IPRegistered CreateIPRegistered(System.String __IP)
        {
            IPRegistered o = new IPRegistered(__IP);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("IPReUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_IP = ClassConnectionProvider.GetDatabaseParameter("IP", typeof(System.String), 64);
				param_IP.Value = ClassConnectionProvider.FromValueToSqlModelType(_IP);
				command.Parameters.Add(param_IP);
				DbParameter param_Allowed = ClassConnectionProvider.GetDatabaseParameter("Allowed", typeof(System.Boolean), -1);
				param_Allowed.Value = ClassConnectionProvider.FromValueToSqlModelType(_Allowed);
				command.Parameters.Add(param_Allowed);
				DbParameter param_Failures = ClassConnectionProvider.GetDatabaseParameter("Failures", typeof(System.Int32), -1);
				param_Failures.Value = ClassConnectionProvider.FromValueToSqlModelType(_Failures);
				command.Parameters.Add(param_Failures);
				DbParameter param_DenialIssuedUntilTime = ClassConnectionProvider.GetDatabaseParameter("DenialIssuedUntilTime", typeof(System.DateTime), -1);
				param_DenialIssuedUntilTime.Value = ClassConnectionProvider.FromValueToSqlModelType(_DenialIssuedUntilTime);
				command.Parameters.Add(param_DenialIssuedUntilTime);
				

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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("IPReDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_IP = ClassConnectionProvider.GetDatabaseParameter("IP", typeof(System.String), 64);
				param_IP.Value = ClassConnectionProvider.FromValueToSqlModelType(_IP);
				command.Parameters.Add(param_IP);
				
				
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
        
        static public void DeleteIPRegistered(System.String __IP)
        {
            IPRegistered o = new IPRegistered(__IP);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(IPRegistered _object)
        {
			_IP = _object._IP;
			_Allowed = _object._Allowed;
			_Failures = _object._Failures;
			_DenialIssuedUntilTime = _object._DenialIssuedUntilTime;
			
        }
        
        public void CopyWithKeysTo(IPRegistered _object)
        {
			_object._IP = _IP;
			_object._Allowed = _Allowed;
			_object._Failures = _Failures;
			_object._DenialIssuedUntilTime = _DenialIssuedUntilTime;
			
        }
        
        static public void CopyWithKeysObject(IPRegistered _objectFrom, IPRegistered _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(IPRegistered _object)
        {
			_Allowed = _object._Allowed;
			_Failures = _object._Failures;
			_DenialIssuedUntilTime = _object._DenialIssuedUntilTime;
			
        }
        
        public void CopyTo(IPRegistered _object)
        {
			_object._Allowed = _Allowed;
			_object._Failures = _Failures;
			_object._DenialIssuedUntilTime = _DenialIssuedUntilTime;
			
        }
        
        static public void CopyObject(IPRegistered _objectFrom, IPRegistered _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(IPRegistered).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(IPRegistered).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(IPRegistered _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			IPRegisteredUndoRedoCollection allUndidAndNotRedoneEntries = IPRegisteredUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			IPRegisteredUndoRedo _urobject = new IPRegisteredUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.IP = _object._IP;
			_urobject.Allowed = _object._Allowed;
			_urobject.Failures = _object._Failures;
			_urobject.DenialIssuedUntilTime = _object._DenialIssuedUntilTime;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(IPRegistered).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = IPRegisteredUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				IPRegisteredUndoRedoCollection allOldUndoEntries = IPRegisteredUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			IPRegisteredUndoRedoCollection firstUndoEntries = IPRegisteredUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			IPRegisteredUndoRedo _urobject = firstUndoEntries[0];
			
			IPRegistered _object = new IPRegistered();
			_object._IP = _urobject.IP;
			_object._Allowed = _urobject.Allowed;
			_object._Failures = _urobject.Failures;
			_object._DenialIssuedUntilTime = _urobject.DenialIssuedUntilTime;
			

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
			IPRegisteredUndoRedoCollection firstEntryToRedoEntries = IPRegisteredUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			IPRegisteredUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			IPRegistered _object = new IPRegistered();
			_object._IP = _urobject.IP;
			_object._Allowed = _urobject.Allowed;
			_object._Failures = _urobject.Failures;
			_object._DenialIssuedUntilTime = _urobject.DenialIssuedUntilTime;
			

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
    /// Defines the contract for the IPRegisteredCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("25d836b5-6250-f5a8-f1be-ac4cd7363afd")]
    public interface IIPRegisteredCollection : IEnumerable<IPRegistered>
    {
        int IndexOf(IPRegistered item);
        void Insert(int index, IPRegistered item);
        void RemoveAt(int index);
        IPRegistered this[int index] { get; set; }
        void Add(IPRegistered item);
        void Clear();
        bool Contains(IPRegistered item);
        void CopyTo(IPRegistered[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(IPRegistered item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.Security.IPRegistered
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("4acb5abc-b3d9-e373-6426-eebaafe2b7b9")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class IPRegisteredCollection : IIPRegisteredCollection, IList<IPRegistered>, IHierarchicalEnumerable
    {
        List<IPRegistered> _list = new List<IPRegistered>();
        
        public static implicit operator List<IPRegistered>(IPRegisteredCollection collection)
        {
            return collection._list;
        }

        #region IList<IPRegistered> Members

        public int IndexOf(IPRegistered item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, IPRegistered item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public IPRegistered this[int index]
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

        #region ICollection<IPRegistered> Members

        public void Add(IPRegistered item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(IPRegistered item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(IPRegistered[] array, int arrayIndex)
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

        public bool Remove(IPRegistered item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<IPRegistered> Members

        public IEnumerator<IPRegistered> GetEnumerator()
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
	/// that share Services.Packages.Security.IPRegistered objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Security.Web.IPRegisteredWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class IPRegisteredWebService : WebService, IIPRegisteredService
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
        public bool Exists(IPRegistered _IPRegistered)
        {
			return _IPRegistered.Exists;
        }
		
		[WebMethod]
		public IPRegistered Read(System.String __IP)
		{
			return new IPRegistered(__IP);
		}
		
		[WebMethod]
        public IPRegistered Reload(IPRegistered _IPRegistered)
        {
			_IPRegistered.Reload();
			return _IPRegistered;
        }
		
		[WebMethod]
        public IPRegistered Create(System.String __IP)
        {
			return IPRegistered.CreateIPRegistered(__IP);
        }
        
        [WebMethod]
        public void Delete(System.String __IP)
        {
			IPRegistered.DeleteIPRegistered(__IP);
        }
        
        [WebMethod]
        public void UpdateObject(IPRegistered _IPRegistered)
        {
			_IPRegistered.Update();
        }
		
		[WebMethod]
        public void CreateObject(IPRegistered _IPRegistered)
        {
			_IPRegistered.Create();
        }
        
        [WebMethod]
        public void DeleteObject(IPRegistered _IPRegistered)
        {
			_IPRegistered.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			IPRegistered.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			IPRegistered.Redo();
        }
		[WebMethod]
		public Services.Packages.Security.IPSessionRegistrationCollection GetSessionsRegisteredOnIP(IPRegistered _IPRegistered)
		{
			_IPRegistered.Reload();
			return _IPRegistered.SessionsRegisteredOnIP;
		}
		[WebMethod]
		public void SetSessionsRegisteredOnIP(IPRegistered _IPRegistered, Services.Packages.Security.IPSessionRegistrationCollection _SessionsRegisteredOnIP)
		{
			_IPRegistered.Reload();
			_IPRegistered.SessionsRegisteredOnIP = _SessionsRegisteredOnIP;
			_IPRegistered.Update();
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="IPRegisteredWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("dfa1b6bd-b645-ddd3-babe-065f796ab03e")]
    sealed public class IPRegisteredWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IIPRegisteredService
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
		public IPRegisteredWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public IPRegisteredWebServiceClient()
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
		public bool Exists(IPRegistered _IPRegistered)
        {
			object[] results = this.Invoke("Exists", new object[] {_IPRegistered});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public IPRegistered Read(System.String __IP)
		{
			object[] results = this.Invoke("Read", new object[] {__IP});
			return ((IPRegistered)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public IPRegistered Reload(IPRegistered _IPRegistered)
        {
			object[] results = this.Invoke("Reload", new object[] {_IPRegistered});
			return ((IPRegistered)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public IPRegistered Create(System.String __IP)
        {
			object[] results = this.Invoke("Create", new object[] {__IP});
			return ((IPRegistered)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __IP)
        {
			this.Invoke("Delete", new object[] {__IP});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(IPRegistered _IPRegistered)
        {
			this.Invoke("UpdateObject", new object[] {_IPRegistered});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(IPRegistered _IPRegistered)
        {
			this.Invoke("CreateObject", new object[] {_IPRegistered});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(IPRegistered _IPRegistered)
        {
			this.Invoke("DeleteObject", new object[] {_IPRegistered});
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
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetSessionsRegisteredOnIP", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.IPSessionRegistrationCollection GetSessionsRegisteredOnIP(IPRegistered _IPRegistered)
		{
			object[] results = this.Invoke("GetSessionsRegisteredOnIP", new object[] {_IPRegistered});
			return ((Services.Packages.Security.IPSessionRegistrationCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetSessionsRegisteredOnIP", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetSessionsRegisteredOnIP(IPRegistered _IPRegistered, Services.Packages.Security.IPSessionRegistrationCollection _SessionsRegisteredOnIP)
		{
			this.Invoke("GetSessionsRegisteredOnIP", new object[] {_IPRegistered});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages.Security
