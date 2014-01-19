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
    /// Defines the contract for the Securable class
    /// </summary>
    [ComVisible(true)]
    [Guid("65c7aaaa-0a25-8867-ced6-6a1a268c70bc")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface ISecurable
	{
		bool Exists { get; }
		System.String Type { get; set; }
		System.Boolean Enabled { get; set; }
		System.Int32 TimeSessionIsIssued { get; set; }
		System.Boolean AllowAnonymousAccess { get; set; }
		System.Int32 GenerationPasswordLength { get; set; }
		System.Boolean IPsMustBePreregistered { get; set; }
		System.Int32 AllowedIPFailures { get; set; }
		System.Int32 IPFailureTimeDenying { get; set; }
		System.Boolean DisableIPFiltering { get; set; }
		System.Int32 SessionsPerIPAllowed { get; set; }

		void Read(System.String __Type);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(Securable _object);
		void CopyWithKeysTo(Securable _object);
		void CopyFrom(Securable _object);
		void CopyTo(Securable _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.Security.Securable type.
    /// </summary>
    [ComVisible(true)]
    [Guid("20f803e3-8533-3637-a1a0-dd1bfc7e3d19")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface ISecurableService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(Securable _Securable);
		[OperationContract]
        Securable Read(System.String __Type);
        [OperationContract]
        Securable Reload(Securable _Securable);
        [OperationContract]
        Securable Create(System.String __Type);
        [OperationContract]
        void Delete(System.String __Type);
        [OperationContract]
        void UpdateObject(Securable _Securable);
        [OperationContract]
        void CreateObject(Securable _Securable);
        [OperationContract]
        void DeleteObject(Securable _Securable);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.Security.Securable type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("bda30dcc-b3d9-e26c-9f0f-230cd4f8ce51")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class SecurableService : ISecurableService
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
        public bool Exists(Securable _Securable)
        {
			return _Securable.Exists;
        }
		
		[WebMethod]
		public Securable Read(System.String __Type)
		{
			return new Securable(__Type);
		}
		
		[WebMethod]
        public Securable Reload(Securable _Securable)
        {
			_Securable.Reload();
			return _Securable;
        }
		
		[WebMethod]
        public Securable Create(System.String __Type)
        {
			return Securable.CreateSecurable(__Type);
        }
        
        [WebMethod]
        public void Delete(System.String __Type)
        {
			Securable.DeleteSecurable(__Type);
        }
        
        [WebMethod]
        public void UpdateObject(Securable _Securable)
        {
			_Securable.Update();
        }
		
		[WebMethod]
        public void CreateObject(Securable _Securable)
        {
			_Securable.Create();
        }
        
        [WebMethod]
        public void DeleteObject(Securable _Securable)
        {
			_Securable.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			Securable.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			Securable.Redo();
        }

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.Security.Securable model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("b6cda8e3-4783-256b-7291-c4852d4b8c50")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class Securable : ISecurable, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<ISecurableService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<ISecurableService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<ISecurableService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.Securable"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.Securable"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.Security.Securable.ProviderType");
				
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


		System.String _Type;
		
		// Key member
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String Type
		{
            get
            {
                return _Type;
            }
            set
            {
				if (_Type != value)
					__hasBeenReadOnce = false;
                _Type = value;
            }
		}

		System.Boolean _Enabled;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Boolean Enabled
		{
            get
            {
                return _Enabled;
            }
            set
            {
                _Enabled = value;
            }
		}

		System.Int32 _TimeSessionIsIssued;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Int32 TimeSessionIsIssued
		{
            get
            {
                return _TimeSessionIsIssued;
            }
            set
            {
                _TimeSessionIsIssued = value;
            }
		}

		System.Boolean _AllowAnonymousAccess;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Boolean AllowAnonymousAccess
		{
            get
            {
                return _AllowAnonymousAccess;
            }
            set
            {
                _AllowAnonymousAccess = value;
            }
		}

		System.Int32 _GenerationPasswordLength;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Int32 GenerationPasswordLength
		{
            get
            {
                return _GenerationPasswordLength;
            }
            set
            {
                _GenerationPasswordLength = value;
            }
		}

		System.Boolean _IPsMustBePreregistered;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Boolean IPsMustBePreregistered
		{
            get
            {
                return _IPsMustBePreregistered;
            }
            set
            {
                _IPsMustBePreregistered = value;
            }
		}

		System.Int32 _AllowedIPFailures;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Int32 AllowedIPFailures
		{
            get
            {
                return _AllowedIPFailures;
            }
            set
            {
                _AllowedIPFailures = value;
            }
		}

		System.Int32 _IPFailureTimeDenying;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Int32 IPFailureTimeDenying
		{
            get
            {
                return _IPFailureTimeDenying;
            }
            set
            {
                _IPFailureTimeDenying = value;
            }
		}

		System.Boolean _DisableIPFiltering;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Boolean DisableIPFiltering
		{
            get
            {
                return _DisableIPFiltering;
            }
            set
            {
                _DisableIPFiltering = value;
            }
		}

		System.Int32 _SessionsPerIPAllowed;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Int32 SessionsPerIPAllowed
		{
            get
            {
                return _SessionsPerIPAllowed;
            }
            set
            {
                _SessionsPerIPAllowed = value;
            }
		}

		public bool Exists
        {
            get {
				if (!__hasBeenReadOnce)
					Exist();
				
				return __databaseState == RowState.Initialized;
			}
        }
        
        public Securable() {}
        
        public Securable(System.String __Type)
        {
			Read(__Type);
        }
        
        #region CRUD
        
        void Exist()
        {
			// sql read - should be changed to specific exist implementation
			using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
			{
				dbconn.Open();
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("SeRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
				DbParameter param_Type = ClassConnectionProvider.GetDatabaseParameter("Type", typeof(System.String), 256);
				param_Type.Value = ClassConnectionProvider.FromValueToSqlModelType(_Type);
				command.Parameters.Add(param_Type);
				
                
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
        
        public void Read(System.String __Type)
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].Read(__Type);
					return;
				}

                // Get a service via an algorithm
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "Se");
                // Perfect for read operations, but not for write
                // scalingServices[nextIndex].Read(__Type);
				// return;

				throw new NotImplementedException();
            }

            try
            {
				// sql read
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("SeRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					_Type = __Type;
				DbParameter param_Type = ClassConnectionProvider.GetDatabaseParameter("Type", typeof(System.String), 256);
				param_Type.Value = ClassConnectionProvider.FromValueToSqlModelType(__Type);
				command.Parameters.Add(param_Type);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_Type = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Type"], typeof(System.String));
				_Enabled = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Enabled"], typeof(System.Boolean));
				_TimeSessionIsIssued = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["TimeSessionIsIssued"], typeof(System.Int32));
				_AllowAnonymousAccess = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["AllowAnonymousAccess"], typeof(System.Boolean));
				_GenerationPasswordLength = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["GenerationPasswordLength"], typeof(System.Int32));
				_IPsMustBePreregistered = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IPsMustBePreregistered"], typeof(System.Boolean));
				_AllowedIPFailures = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["AllowedIPFailures"], typeof(System.Int32));
				_IPFailureTimeDenying = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IPFailureTimeDenying"], typeof(System.Int32));
				_DisableIPFiltering = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["DisableIPFiltering"], typeof(System.Boolean));
				_SessionsPerIPAllowed = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SessionsPerIPAllowed"], typeof(System.Int32));
				
                    
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
                            failoverServices[n].Read(__Type);
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "Se");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("SeRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Type = ClassConnectionProvider.GetDatabaseParameter("Type", typeof(System.String), 256);
				param_Type.Value = ClassConnectionProvider.FromValueToSqlModelType(_Type);
				command.Parameters.Add(param_Type);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_Type = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Type"], typeof(System.String));
				_Enabled = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Enabled"], typeof(System.Boolean));
				_TimeSessionIsIssued = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["TimeSessionIsIssued"], typeof(System.Int32));
				_AllowAnonymousAccess = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["AllowAnonymousAccess"], typeof(System.Boolean));
				_GenerationPasswordLength = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["GenerationPasswordLength"], typeof(System.Int32));
				_IPsMustBePreregistered = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IPsMustBePreregistered"], typeof(System.Boolean));
				_AllowedIPFailures = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["AllowedIPFailures"], typeof(System.Int32));
				_IPFailureTimeDenying = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IPFailureTimeDenying"], typeof(System.Int32));
				_DisableIPFiltering = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["DisableIPFiltering"], typeof(System.Boolean));
				_SessionsPerIPAllowed = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SessionsPerIPAllowed"], typeof(System.Int32));
				
                    
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("SeCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_Type = ClassConnectionProvider.GetDatabaseParameter("Type", typeof(System.String), 256);
				param_Type.Value = ClassConnectionProvider.FromValueToSqlModelType(_Type);
				command.Parameters.Add(param_Type);
				DbParameter param_Enabled = ClassConnectionProvider.GetDatabaseParameter("Enabled", typeof(System.Boolean), -1);
				param_Enabled.Value = ClassConnectionProvider.FromValueToSqlModelType(_Enabled);
				command.Parameters.Add(param_Enabled);
				DbParameter param_TimeSessionIsIssued = ClassConnectionProvider.GetDatabaseParameter("TimeSessionIsIssued", typeof(System.Int32), -1);
				param_TimeSessionIsIssued.Value = ClassConnectionProvider.FromValueToSqlModelType(_TimeSessionIsIssued);
				command.Parameters.Add(param_TimeSessionIsIssued);
				DbParameter param_AllowAnonymousAccess = ClassConnectionProvider.GetDatabaseParameter("AllowAnonymousAccess", typeof(System.Boolean), -1);
				param_AllowAnonymousAccess.Value = ClassConnectionProvider.FromValueToSqlModelType(_AllowAnonymousAccess);
				command.Parameters.Add(param_AllowAnonymousAccess);
				DbParameter param_GenerationPasswordLength = ClassConnectionProvider.GetDatabaseParameter("GenerationPasswordLength", typeof(System.Int32), -1);
				param_GenerationPasswordLength.Value = ClassConnectionProvider.FromValueToSqlModelType(_GenerationPasswordLength);
				command.Parameters.Add(param_GenerationPasswordLength);
				DbParameter param_IPsMustBePreregistered = ClassConnectionProvider.GetDatabaseParameter("IPsMustBePreregistered", typeof(System.Boolean), -1);
				param_IPsMustBePreregistered.Value = ClassConnectionProvider.FromValueToSqlModelType(_IPsMustBePreregistered);
				command.Parameters.Add(param_IPsMustBePreregistered);
				DbParameter param_AllowedIPFailures = ClassConnectionProvider.GetDatabaseParameter("AllowedIPFailures", typeof(System.Int32), -1);
				param_AllowedIPFailures.Value = ClassConnectionProvider.FromValueToSqlModelType(_AllowedIPFailures);
				command.Parameters.Add(param_AllowedIPFailures);
				DbParameter param_IPFailureTimeDenying = ClassConnectionProvider.GetDatabaseParameter("IPFailureTimeDenying", typeof(System.Int32), -1);
				param_IPFailureTimeDenying.Value = ClassConnectionProvider.FromValueToSqlModelType(_IPFailureTimeDenying);
				command.Parameters.Add(param_IPFailureTimeDenying);
				DbParameter param_DisableIPFiltering = ClassConnectionProvider.GetDatabaseParameter("DisableIPFiltering", typeof(System.Boolean), -1);
				param_DisableIPFiltering.Value = ClassConnectionProvider.FromValueToSqlModelType(_DisableIPFiltering);
				command.Parameters.Add(param_DisableIPFiltering);
				DbParameter param_SessionsPerIPAllowed = ClassConnectionProvider.GetDatabaseParameter("SessionsPerIPAllowed", typeof(System.Int32), -1);
				param_SessionsPerIPAllowed.Value = ClassConnectionProvider.FromValueToSqlModelType(_SessionsPerIPAllowed);
				command.Parameters.Add(param_SessionsPerIPAllowed);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_Type = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Type"], typeof(System.String));
				_Enabled = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Enabled"], typeof(System.Boolean));
				_TimeSessionIsIssued = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["TimeSessionIsIssued"], typeof(System.Int32));
				_AllowAnonymousAccess = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["AllowAnonymousAccess"], typeof(System.Boolean));
				_GenerationPasswordLength = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["GenerationPasswordLength"], typeof(System.Int32));
				_IPsMustBePreregistered = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IPsMustBePreregistered"], typeof(System.Boolean));
				_AllowedIPFailures = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["AllowedIPFailures"], typeof(System.Int32));
				_IPFailureTimeDenying = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IPFailureTimeDenying"], typeof(System.Int32));
				_DisableIPFiltering = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["DisableIPFiltering"], typeof(System.Boolean));
				_SessionsPerIPAllowed = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["SessionsPerIPAllowed"], typeof(System.Int32));
				
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
        
        static public Securable CreateSecurable(System.String __Type)
        {
            Securable o = new Securable(__Type);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("SeUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Type = ClassConnectionProvider.GetDatabaseParameter("Type", typeof(System.String), 256);
				param_Type.Value = ClassConnectionProvider.FromValueToSqlModelType(_Type);
				command.Parameters.Add(param_Type);
				DbParameter param_Enabled = ClassConnectionProvider.GetDatabaseParameter("Enabled", typeof(System.Boolean), -1);
				param_Enabled.Value = ClassConnectionProvider.FromValueToSqlModelType(_Enabled);
				command.Parameters.Add(param_Enabled);
				DbParameter param_TimeSessionIsIssued = ClassConnectionProvider.GetDatabaseParameter("TimeSessionIsIssued", typeof(System.Int32), -1);
				param_TimeSessionIsIssued.Value = ClassConnectionProvider.FromValueToSqlModelType(_TimeSessionIsIssued);
				command.Parameters.Add(param_TimeSessionIsIssued);
				DbParameter param_AllowAnonymousAccess = ClassConnectionProvider.GetDatabaseParameter("AllowAnonymousAccess", typeof(System.Boolean), -1);
				param_AllowAnonymousAccess.Value = ClassConnectionProvider.FromValueToSqlModelType(_AllowAnonymousAccess);
				command.Parameters.Add(param_AllowAnonymousAccess);
				DbParameter param_GenerationPasswordLength = ClassConnectionProvider.GetDatabaseParameter("GenerationPasswordLength", typeof(System.Int32), -1);
				param_GenerationPasswordLength.Value = ClassConnectionProvider.FromValueToSqlModelType(_GenerationPasswordLength);
				command.Parameters.Add(param_GenerationPasswordLength);
				DbParameter param_IPsMustBePreregistered = ClassConnectionProvider.GetDatabaseParameter("IPsMustBePreregistered", typeof(System.Boolean), -1);
				param_IPsMustBePreregistered.Value = ClassConnectionProvider.FromValueToSqlModelType(_IPsMustBePreregistered);
				command.Parameters.Add(param_IPsMustBePreregistered);
				DbParameter param_AllowedIPFailures = ClassConnectionProvider.GetDatabaseParameter("AllowedIPFailures", typeof(System.Int32), -1);
				param_AllowedIPFailures.Value = ClassConnectionProvider.FromValueToSqlModelType(_AllowedIPFailures);
				command.Parameters.Add(param_AllowedIPFailures);
				DbParameter param_IPFailureTimeDenying = ClassConnectionProvider.GetDatabaseParameter("IPFailureTimeDenying", typeof(System.Int32), -1);
				param_IPFailureTimeDenying.Value = ClassConnectionProvider.FromValueToSqlModelType(_IPFailureTimeDenying);
				command.Parameters.Add(param_IPFailureTimeDenying);
				DbParameter param_DisableIPFiltering = ClassConnectionProvider.GetDatabaseParameter("DisableIPFiltering", typeof(System.Boolean), -1);
				param_DisableIPFiltering.Value = ClassConnectionProvider.FromValueToSqlModelType(_DisableIPFiltering);
				command.Parameters.Add(param_DisableIPFiltering);
				DbParameter param_SessionsPerIPAllowed = ClassConnectionProvider.GetDatabaseParameter("SessionsPerIPAllowed", typeof(System.Int32), -1);
				param_SessionsPerIPAllowed.Value = ClassConnectionProvider.FromValueToSqlModelType(_SessionsPerIPAllowed);
				command.Parameters.Add(param_SessionsPerIPAllowed);
				

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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("SeDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Type = ClassConnectionProvider.GetDatabaseParameter("Type", typeof(System.String), 256);
				param_Type.Value = ClassConnectionProvider.FromValueToSqlModelType(_Type);
				command.Parameters.Add(param_Type);
				
				
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
        
        static public void DeleteSecurable(System.String __Type)
        {
            Securable o = new Securable(__Type);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(Securable _object)
        {
			_Type = _object._Type;
			_Enabled = _object._Enabled;
			_TimeSessionIsIssued = _object._TimeSessionIsIssued;
			_AllowAnonymousAccess = _object._AllowAnonymousAccess;
			_GenerationPasswordLength = _object._GenerationPasswordLength;
			_IPsMustBePreregistered = _object._IPsMustBePreregistered;
			_AllowedIPFailures = _object._AllowedIPFailures;
			_IPFailureTimeDenying = _object._IPFailureTimeDenying;
			_DisableIPFiltering = _object._DisableIPFiltering;
			_SessionsPerIPAllowed = _object._SessionsPerIPAllowed;
			
        }
        
        public void CopyWithKeysTo(Securable _object)
        {
			_object._Type = _Type;
			_object._Enabled = _Enabled;
			_object._TimeSessionIsIssued = _TimeSessionIsIssued;
			_object._AllowAnonymousAccess = _AllowAnonymousAccess;
			_object._GenerationPasswordLength = _GenerationPasswordLength;
			_object._IPsMustBePreregistered = _IPsMustBePreregistered;
			_object._AllowedIPFailures = _AllowedIPFailures;
			_object._IPFailureTimeDenying = _IPFailureTimeDenying;
			_object._DisableIPFiltering = _DisableIPFiltering;
			_object._SessionsPerIPAllowed = _SessionsPerIPAllowed;
			
        }
        
        static public void CopyWithKeysObject(Securable _objectFrom, Securable _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(Securable _object)
        {
			_Enabled = _object._Enabled;
			_TimeSessionIsIssued = _object._TimeSessionIsIssued;
			_AllowAnonymousAccess = _object._AllowAnonymousAccess;
			_GenerationPasswordLength = _object._GenerationPasswordLength;
			_IPsMustBePreregistered = _object._IPsMustBePreregistered;
			_AllowedIPFailures = _object._AllowedIPFailures;
			_IPFailureTimeDenying = _object._IPFailureTimeDenying;
			_DisableIPFiltering = _object._DisableIPFiltering;
			_SessionsPerIPAllowed = _object._SessionsPerIPAllowed;
			
        }
        
        public void CopyTo(Securable _object)
        {
			_object._Enabled = _Enabled;
			_object._TimeSessionIsIssued = _TimeSessionIsIssued;
			_object._AllowAnonymousAccess = _AllowAnonymousAccess;
			_object._GenerationPasswordLength = _GenerationPasswordLength;
			_object._IPsMustBePreregistered = _IPsMustBePreregistered;
			_object._AllowedIPFailures = _AllowedIPFailures;
			_object._IPFailureTimeDenying = _IPFailureTimeDenying;
			_object._DisableIPFiltering = _DisableIPFiltering;
			_object._SessionsPerIPAllowed = _SessionsPerIPAllowed;
			
        }
        
        static public void CopyObject(Securable _objectFrom, Securable _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(Securable).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(Securable).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(Securable _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			SecurableUndoRedoCollection allUndidAndNotRedoneEntries = SecurableUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			SecurableUndoRedo _urobject = new SecurableUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.Type = _object._Type;
			_urobject.Enabled = _object._Enabled;
			_urobject.TimeSessionIsIssued = _object._TimeSessionIsIssued;
			_urobject.AllowAnonymousAccess = _object._AllowAnonymousAccess;
			_urobject.GenerationPasswordLength = _object._GenerationPasswordLength;
			_urobject.IPsMustBePreregistered = _object._IPsMustBePreregistered;
			_urobject.AllowedIPFailures = _object._AllowedIPFailures;
			_urobject.IPFailureTimeDenying = _object._IPFailureTimeDenying;
			_urobject.DisableIPFiltering = _object._DisableIPFiltering;
			_urobject.SessionsPerIPAllowed = _object._SessionsPerIPAllowed;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(Securable).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = SecurableUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				SecurableUndoRedoCollection allOldUndoEntries = SecurableUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			SecurableUndoRedoCollection firstUndoEntries = SecurableUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			SecurableUndoRedo _urobject = firstUndoEntries[0];
			
			Securable _object = new Securable();
			_object._Type = _urobject.Type;
			_object._Enabled = _urobject.Enabled;
			_object._TimeSessionIsIssued = _urobject.TimeSessionIsIssued;
			_object._AllowAnonymousAccess = _urobject.AllowAnonymousAccess;
			_object._GenerationPasswordLength = _urobject.GenerationPasswordLength;
			_object._IPsMustBePreregistered = _urobject.IPsMustBePreregistered;
			_object._AllowedIPFailures = _urobject.AllowedIPFailures;
			_object._IPFailureTimeDenying = _urobject.IPFailureTimeDenying;
			_object._DisableIPFiltering = _urobject.DisableIPFiltering;
			_object._SessionsPerIPAllowed = _urobject.SessionsPerIPAllowed;
			

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
			SecurableUndoRedoCollection firstEntryToRedoEntries = SecurableUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			SecurableUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			Securable _object = new Securable();
			_object._Type = _urobject.Type;
			_object._Enabled = _urobject.Enabled;
			_object._TimeSessionIsIssued = _urobject.TimeSessionIsIssued;
			_object._AllowAnonymousAccess = _urobject.AllowAnonymousAccess;
			_object._GenerationPasswordLength = _urobject.GenerationPasswordLength;
			_object._IPsMustBePreregistered = _urobject.IPsMustBePreregistered;
			_object._AllowedIPFailures = _urobject.AllowedIPFailures;
			_object._IPFailureTimeDenying = _urobject.IPFailureTimeDenying;
			_object._DisableIPFiltering = _urobject.DisableIPFiltering;
			_object._SessionsPerIPAllowed = _urobject.SessionsPerIPAllowed;
			

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
    /// Defines the contract for the SecurableCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("184e5198-b3e8-2fe3-9716-8024622b61a9")]
    public interface ISecurableCollection : IEnumerable<Securable>
    {
        int IndexOf(Securable item);
        void Insert(int index, Securable item);
        void RemoveAt(int index);
        Securable this[int index] { get; set; }
        void Add(Securable item);
        void Clear();
        bool Contains(Securable item);
        void CopyTo(Securable[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(Securable item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.Security.Securable
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("53378cd1-86b0-8595-a27e-4a47efe6b553")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class SecurableCollection : ISecurableCollection, IList<Securable>, IHierarchicalEnumerable
    {
        List<Securable> _list = new List<Securable>();
        
        public static implicit operator List<Securable>(SecurableCollection collection)
        {
            return collection._list;
        }

        #region IList<Securable> Members

        public int IndexOf(Securable item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, Securable item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public Securable this[int index]
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

        #region ICollection<Securable> Members

        public void Add(Securable item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(Securable item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(Securable[] array, int arrayIndex)
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

        public bool Remove(Securable item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<Securable> Members

        public IEnumerator<Securable> GetEnumerator()
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
	/// that share Services.Packages.Security.Securable objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Security.Web.SecurableWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class SecurableWebService : WebService, ISecurableService
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
        public bool Exists(Securable _Securable)
        {
			return _Securable.Exists;
        }
		
		[WebMethod]
		public Securable Read(System.String __Type)
		{
			return new Securable(__Type);
		}
		
		[WebMethod]
        public Securable Reload(Securable _Securable)
        {
			_Securable.Reload();
			return _Securable;
        }
		
		[WebMethod]
        public Securable Create(System.String __Type)
        {
			return Securable.CreateSecurable(__Type);
        }
        
        [WebMethod]
        public void Delete(System.String __Type)
        {
			Securable.DeleteSecurable(__Type);
        }
        
        [WebMethod]
        public void UpdateObject(Securable _Securable)
        {
			_Securable.Update();
        }
		
		[WebMethod]
        public void CreateObject(Securable _Securable)
        {
			_Securable.Create();
        }
        
        [WebMethod]
        public void DeleteObject(Securable _Securable)
        {
			_Securable.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			Securable.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			Securable.Redo();
        }

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="SecurableWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("8373d282-b5aa-3069-c59e-1f6cc647c346")]
    sealed public class SecurableWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, ISecurableService
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
		public SecurableWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public SecurableWebServiceClient()
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
		public bool Exists(Securable _Securable)
        {
			object[] results = this.Invoke("Exists", new object[] {_Securable});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Securable Read(System.String __Type)
		{
			object[] results = this.Invoke("Read", new object[] {__Type});
			return ((Securable)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Securable Reload(Securable _Securable)
        {
			object[] results = this.Invoke("Reload", new object[] {_Securable});
			return ((Securable)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Securable Create(System.String __Type)
        {
			object[] results = this.Invoke("Create", new object[] {__Type});
			return ((Securable)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __Type)
        {
			this.Invoke("Delete", new object[] {__Type});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(Securable _Securable)
        {
			this.Invoke("UpdateObject", new object[] {_Securable});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(Securable _Securable)
        {
			this.Invoke("CreateObject", new object[] {_Securable});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(Securable _Securable)
        {
			this.Invoke("DeleteObject", new object[] {_Securable});
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

	}
	
	
} // namespace Web

} // namespace Services.Packages.Security
