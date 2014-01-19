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

namespace Platform.Module.UndoRedo.Services.Packages
{
	/// <summary>
    /// Defines the contract for the UndoRedoOptions class
    /// </summary>
    [ComVisible(true)]
    [Guid("7b0f86c0-961e-a5c4-12e2-ac012dc7e158")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IUndoRedoOptions
	{
		bool Exists { get; }
		System.String EntityType { get; set; }
		System.Int64 ItemsAllowed { get; set; }
		System.Boolean IsEnabled { get; set; }

		void Read(System.String __EntityType);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(UndoRedoOptions _object);
		void CopyWithKeysTo(UndoRedoOptions _object);
		void CopyFrom(UndoRedoOptions _object);
		void CopyTo(UndoRedoOptions _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions type.
    /// </summary>
    [ComVisible(true)]
    [Guid("1c2dc3c6-8214-7da1-2d14-91b84f6114da")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IUndoRedoOptionsService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(UndoRedoOptions _UndoRedoOptions);
		[OperationContract]
        UndoRedoOptions Read(System.String __EntityType);
        [OperationContract]
        UndoRedoOptions Reload(UndoRedoOptions _UndoRedoOptions);
        [OperationContract]
        UndoRedoOptions Create(System.String __EntityType);
        [OperationContract]
        void Delete(System.String __EntityType);
        [OperationContract]
        void UpdateObject(UndoRedoOptions _UndoRedoOptions);
        [OperationContract]
        void CreateObject(UndoRedoOptions _UndoRedoOptions);
        [OperationContract]
        void DeleteObject(UndoRedoOptions _UndoRedoOptions);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		UndoRedoOptionsCollection SearchByEntityType(System.String EntityType );
		[OperationContract]
		UndoRedoOptionsCollection SearchByEntityTypePaged(System.String EntityType , long PagingStart, long PagingCount);
		[OperationContract]
		long SearchByEntityTypeCount(System.String EntityType );

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("b0b68d93-8777-ac06-1bfa-864614029bc2")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class UndoRedoOptionsService : IUndoRedoOptionsService
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
        public bool Exists(UndoRedoOptions _UndoRedoOptions)
        {
			return _UndoRedoOptions.Exists;
        }
		
		[WebMethod]
		public UndoRedoOptions Read(System.String __EntityType)
		{
			return new UndoRedoOptions(__EntityType);
		}
		
		[WebMethod]
        public UndoRedoOptions Reload(UndoRedoOptions _UndoRedoOptions)
        {
			_UndoRedoOptions.Reload();
			return _UndoRedoOptions;
        }
		
		[WebMethod]
        public UndoRedoOptions Create(System.String __EntityType)
        {
			return UndoRedoOptions.CreateUndoRedoOptions(__EntityType);
        }
        
        [WebMethod]
        public void Delete(System.String __EntityType)
        {
			UndoRedoOptions.DeleteUndoRedoOptions(__EntityType);
        }
        
        [WebMethod]
        public void UpdateObject(UndoRedoOptions _UndoRedoOptions)
        {
			_UndoRedoOptions.Update();
        }
		
		[WebMethod]
        public void CreateObject(UndoRedoOptions _UndoRedoOptions)
        {
			_UndoRedoOptions.Create();
        }
        
        [WebMethod]
        public void DeleteObject(UndoRedoOptions _UndoRedoOptions)
        {
			_UndoRedoOptions.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			UndoRedoOptions.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			UndoRedoOptions.Redo();
        }
		[WebMethod]
		public UndoRedoOptionsCollection SearchByEntityType(System.String EntityType )
		{
			return UndoRedoOptions.SearchByEntityType(EntityType );
		}
		[WebMethod]
		public UndoRedoOptionsCollection SearchByEntityTypePaged(System.String EntityType , long PagingStart, long PagingCount)
		{
			return UndoRedoOptions.SearchByEntityTypePaged(EntityType , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByEntityTypeCount(System.String EntityType )
		{
			return UndoRedoOptions.SearchByEntityTypeCount(EntityType );
		}

    }
	
	/// <summary>
    /// Provides the implementation of Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("258bcc05-88d0-3ea4-e492-4d09050b56b0")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class UndoRedoOptions : IUndoRedoOptions, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<IUndoRedoOptionsService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<IUndoRedoOptionsService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<IUndoRedoOptionsService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions.ProviderType");
				
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


		System.String _EntityType;
		
		// Key member
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String EntityType
		{
            get
            {
                return _EntityType;
            }
            set
            {
				if (_EntityType != value)
					__hasBeenReadOnce = false;
                _EntityType = value;
            }
		}

		System.Int64 _ItemsAllowed;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Int64 ItemsAllowed
		{
            get
            {
                return _ItemsAllowed;
            }
            set
            {
                _ItemsAllowed = value;
            }
		}

		System.Boolean _IsEnabled;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Boolean IsEnabled
		{
            get
            {
                return _IsEnabled;
            }
            set
            {
                _IsEnabled = value;
            }
		}

		public static UndoRedoOptionsCollection SearchByEntityType(System.String _EntityType)
        {
			UndoRedoOptionsCollection _UndoRedoOptionsCollection = new UndoRedoOptionsCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("UnReOpSeByEnTy", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _EntityType = ClassConnectionProvider.Escape(_EntityType);
				
                
                DbParameter param_EntityType = ClassConnectionProvider.GetDatabaseParameter("EntityType", typeof(System.String), -1);
				param_EntityType.Value = ClassConnectionProvider.FromValueToSqlModelType(_EntityType);
				command.Parameters.Add(param_EntityType);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					UndoRedoOptions o = new UndoRedoOptions();
                
					o.__databaseState = RowState.Initialized;
                    o._EntityType = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["EntityType"], typeof(System.String));
				o._ItemsAllowed = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ItemsAllowed"], typeof(System.Int64));
				o._IsEnabled = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsEnabled"], typeof(System.Boolean));
				
                    
                    _UndoRedoOptionsCollection.Add(o);
                }

                dr.Close();
            }
            
            return _UndoRedoOptionsCollection;
        }
        
        public static UndoRedoOptionsCollection SearchByEntityTypePaged(System.String _EntityType, long PagingStart, long PagingCount)
        {
			UndoRedoOptionsCollection _UndoRedoOptionsCollection = new UndoRedoOptionsCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("UnReOpSeByEnTyPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _EntityType = ClassConnectionProvider.Escape(_EntityType);
				
                
                DbParameter param_EntityType = ClassConnectionProvider.GetDatabaseParameter("EntityType", typeof(System.String), -1);
				param_EntityType.Value = ClassConnectionProvider.FromValueToSqlModelType(_EntityType);
				command.Parameters.Add(param_EntityType);
				
                
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
					UndoRedoOptions o = new UndoRedoOptions();
                
					o.__databaseState = RowState.Initialized;
                    o._EntityType = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["EntityType"], typeof(System.String));
				o._ItemsAllowed = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ItemsAllowed"], typeof(System.Int64));
				o._IsEnabled = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsEnabled"], typeof(System.Boolean));
				
                    
                    _UndoRedoOptionsCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _UndoRedoOptionsCollection;
        }
        
        public static long SearchByEntityTypeCount(System.String _EntityType)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("UnReOpSeByEnTyCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _EntityType = ClassConnectionProvider.Escape(_EntityType);
				
                
                DbParameter param_EntityType = ClassConnectionProvider.GetDatabaseParameter("EntityType", typeof(System.String), -1);
				param_EntityType.Value = ClassConnectionProvider.FromValueToSqlModelType(_EntityType);
				command.Parameters.Add(param_EntityType);
				
                
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
        
        public UndoRedoOptions() {}
        
        public UndoRedoOptions(System.String __EntityType)
        {
			Read(__EntityType);
        }
        
        #region CRUD
        
        void Exist()
        {
			// sql read - should be changed to specific exist implementation
			using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
			{
				dbconn.Open();
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("UnReOpRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
				DbParameter param_EntityType = ClassConnectionProvider.GetDatabaseParameter("EntityType", typeof(System.String), 128);
				param_EntityType.Value = ClassConnectionProvider.FromValueToSqlModelType(_EntityType);
				command.Parameters.Add(param_EntityType);
				
                
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
        
        public void Read(System.String __EntityType)
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].Read(__EntityType);
					return;
				}

                // Get a service via an algorithm
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "UnReOp");
                // Perfect for read operations, but not for write
                // scalingServices[nextIndex].Read(__EntityType);
				// return;

				throw new NotImplementedException();
            }

            try
            {
				// sql read
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("UnReOpRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					_EntityType = __EntityType;
				DbParameter param_EntityType = ClassConnectionProvider.GetDatabaseParameter("EntityType", typeof(System.String), 128);
				param_EntityType.Value = ClassConnectionProvider.FromValueToSqlModelType(__EntityType);
				command.Parameters.Add(param_EntityType);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_EntityType = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["EntityType"], typeof(System.String));
				_ItemsAllowed = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ItemsAllowed"], typeof(System.Int64));
				_IsEnabled = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsEnabled"], typeof(System.Boolean));
				
                    
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
                            failoverServices[n].Read(__EntityType);
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "UnReOp");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("UnReOpRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_EntityType = ClassConnectionProvider.GetDatabaseParameter("EntityType", typeof(System.String), 128);
				param_EntityType.Value = ClassConnectionProvider.FromValueToSqlModelType(_EntityType);
				command.Parameters.Add(param_EntityType);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_EntityType = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["EntityType"], typeof(System.String));
				_ItemsAllowed = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ItemsAllowed"], typeof(System.Int64));
				_IsEnabled = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsEnabled"], typeof(System.Boolean));
				
                    
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("UnReOpCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_EntityType = ClassConnectionProvider.GetDatabaseParameter("EntityType", typeof(System.String), 128);
				param_EntityType.Value = ClassConnectionProvider.FromValueToSqlModelType(_EntityType);
				command.Parameters.Add(param_EntityType);
				DbParameter param_ItemsAllowed = ClassConnectionProvider.GetDatabaseParameter("ItemsAllowed", typeof(System.Int64), -1);
				param_ItemsAllowed.Value = ClassConnectionProvider.FromValueToSqlModelType(_ItemsAllowed);
				command.Parameters.Add(param_ItemsAllowed);
				DbParameter param_IsEnabled = ClassConnectionProvider.GetDatabaseParameter("IsEnabled", typeof(System.Boolean), -1);
				param_IsEnabled.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsEnabled);
				command.Parameters.Add(param_IsEnabled);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_EntityType = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["EntityType"], typeof(System.String));
				_ItemsAllowed = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ItemsAllowed"], typeof(System.Int64));
				_IsEnabled = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsEnabled"], typeof(System.Boolean));
				
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
        
        static public UndoRedoOptions CreateUndoRedoOptions(System.String __EntityType)
        {
            UndoRedoOptions o = new UndoRedoOptions(__EntityType);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("UnReOpUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_EntityType = ClassConnectionProvider.GetDatabaseParameter("EntityType", typeof(System.String), 128);
				param_EntityType.Value = ClassConnectionProvider.FromValueToSqlModelType(_EntityType);
				command.Parameters.Add(param_EntityType);
				DbParameter param_ItemsAllowed = ClassConnectionProvider.GetDatabaseParameter("ItemsAllowed", typeof(System.Int64), -1);
				param_ItemsAllowed.Value = ClassConnectionProvider.FromValueToSqlModelType(_ItemsAllowed);
				command.Parameters.Add(param_ItemsAllowed);
				DbParameter param_IsEnabled = ClassConnectionProvider.GetDatabaseParameter("IsEnabled", typeof(System.Boolean), -1);
				param_IsEnabled.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsEnabled);
				command.Parameters.Add(param_IsEnabled);
				

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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("UnReOpDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_EntityType = ClassConnectionProvider.GetDatabaseParameter("EntityType", typeof(System.String), 128);
				param_EntityType.Value = ClassConnectionProvider.FromValueToSqlModelType(_EntityType);
				command.Parameters.Add(param_EntityType);
				
				
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
        
        static public void DeleteUndoRedoOptions(System.String __EntityType)
        {
            UndoRedoOptions o = new UndoRedoOptions(__EntityType);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(UndoRedoOptions _object)
        {
			_EntityType = _object._EntityType;
			_ItemsAllowed = _object._ItemsAllowed;
			_IsEnabled = _object._IsEnabled;
			
        }
        
        public void CopyWithKeysTo(UndoRedoOptions _object)
        {
			_object._EntityType = _EntityType;
			_object._ItemsAllowed = _ItemsAllowed;
			_object._IsEnabled = _IsEnabled;
			
        }
        
        static public void CopyWithKeysObject(UndoRedoOptions _objectFrom, UndoRedoOptions _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(UndoRedoOptions _object)
        {
			_ItemsAllowed = _object._ItemsAllowed;
			_IsEnabled = _object._IsEnabled;
			
        }
        
        public void CopyTo(UndoRedoOptions _object)
        {
			_object._ItemsAllowed = _ItemsAllowed;
			_object._IsEnabled = _IsEnabled;
			
        }
        
        static public void CopyObject(UndoRedoOptions _objectFrom, UndoRedoOptions _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(UndoRedoOptions).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(UndoRedoOptions).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(UndoRedoOptions _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			UndoRedoOptionsUndoRedoCollection allUndidAndNotRedoneEntries = UndoRedoOptionsUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			UndoRedoOptionsUndoRedo _urobject = new UndoRedoOptionsUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.EntityType = _object._EntityType;
			_urobject.ItemsAllowed = _object._ItemsAllowed;
			_urobject.IsEnabled = _object._IsEnabled;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(UndoRedoOptions).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = UndoRedoOptionsUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				UndoRedoOptionsUndoRedoCollection allOldUndoEntries = UndoRedoOptionsUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			UndoRedoOptionsUndoRedoCollection firstUndoEntries = UndoRedoOptionsUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			UndoRedoOptionsUndoRedo _urobject = firstUndoEntries[0];
			
			UndoRedoOptions _object = new UndoRedoOptions();
			_object._EntityType = _urobject.EntityType;
			_object._ItemsAllowed = _urobject.ItemsAllowed;
			_object._IsEnabled = _urobject.IsEnabled;
			

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
			UndoRedoOptionsUndoRedoCollection firstEntryToRedoEntries = UndoRedoOptionsUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			UndoRedoOptionsUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			UndoRedoOptions _object = new UndoRedoOptions();
			_object._EntityType = _urobject.EntityType;
			_object._ItemsAllowed = _urobject.ItemsAllowed;
			_object._IsEnabled = _urobject.IsEnabled;
			

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
    /// Defines the contract for the UndoRedoOptionsCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("a06dd1cd-3011-3ee0-bd80-011afb5b682a")]
    public interface IUndoRedoOptionsCollection : IEnumerable<UndoRedoOptions>
    {
        int IndexOf(UndoRedoOptions item);
        void Insert(int index, UndoRedoOptions item);
        void RemoveAt(int index);
        UndoRedoOptions this[int index] { get; set; }
        void Add(UndoRedoOptions item);
        void Clear();
        bool Contains(UndoRedoOptions item);
        void CopyTo(UndoRedoOptions[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(UndoRedoOptions item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("82b3ce79-efd5-0b0a-e877-cce539fca70f")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class UndoRedoOptionsCollection : IUndoRedoOptionsCollection, IList<UndoRedoOptions>, IHierarchicalEnumerable
    {
        List<UndoRedoOptions> _list = new List<UndoRedoOptions>();
        
        public static implicit operator List<UndoRedoOptions>(UndoRedoOptionsCollection collection)
        {
            return collection._list;
        }

        #region IList<UndoRedoOptions> Members

        public int IndexOf(UndoRedoOptions item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, UndoRedoOptions item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public UndoRedoOptions this[int index]
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

        #region ICollection<UndoRedoOptions> Members

        public void Add(UndoRedoOptions item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(UndoRedoOptions item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(UndoRedoOptions[] array, int arrayIndex)
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

        public bool Remove(UndoRedoOptions item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<UndoRedoOptions> Members

        public IEnumerator<UndoRedoOptions> GetEnumerator()
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
	/// that share Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Platform.Module.UndoRedo.Services.Packages.Web.UndoRedoOptionsWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class UndoRedoOptionsWebService : WebService, IUndoRedoOptionsService
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
        public bool Exists(UndoRedoOptions _UndoRedoOptions)
        {
			return _UndoRedoOptions.Exists;
        }
		
		[WebMethod]
		public UndoRedoOptions Read(System.String __EntityType)
		{
			return new UndoRedoOptions(__EntityType);
		}
		
		[WebMethod]
        public UndoRedoOptions Reload(UndoRedoOptions _UndoRedoOptions)
        {
			_UndoRedoOptions.Reload();
			return _UndoRedoOptions;
        }
		
		[WebMethod]
        public UndoRedoOptions Create(System.String __EntityType)
        {
			return UndoRedoOptions.CreateUndoRedoOptions(__EntityType);
        }
        
        [WebMethod]
        public void Delete(System.String __EntityType)
        {
			UndoRedoOptions.DeleteUndoRedoOptions(__EntityType);
        }
        
        [WebMethod]
        public void UpdateObject(UndoRedoOptions _UndoRedoOptions)
        {
			_UndoRedoOptions.Update();
        }
		
		[WebMethod]
        public void CreateObject(UndoRedoOptions _UndoRedoOptions)
        {
			_UndoRedoOptions.Create();
        }
        
        [WebMethod]
        public void DeleteObject(UndoRedoOptions _UndoRedoOptions)
        {
			_UndoRedoOptions.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			UndoRedoOptions.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			UndoRedoOptions.Redo();
        }
		[WebMethod]
		public UndoRedoOptionsCollection SearchByEntityType(System.String EntityType )
		{
			return UndoRedoOptions.SearchByEntityType(EntityType );
		}
		[WebMethod]
		public UndoRedoOptionsCollection SearchByEntityTypePaged(System.String EntityType , long PagingStart, long PagingCount)
		{
			return UndoRedoOptions.SearchByEntityTypePaged(EntityType , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByEntityTypeCount(System.String EntityType )
		{
			return UndoRedoOptions.SearchByEntityTypeCount(EntityType );
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="UndoRedoOptionsWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("4278d6a4-fa95-d4b0-ec4d-6750868a4388")]
    sealed public class UndoRedoOptionsWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IUndoRedoOptionsService
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
		public UndoRedoOptionsWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public UndoRedoOptionsWebServiceClient()
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
		public bool Exists(UndoRedoOptions _UndoRedoOptions)
        {
			object[] results = this.Invoke("Exists", new object[] {_UndoRedoOptions});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public UndoRedoOptions Read(System.String __EntityType)
		{
			object[] results = this.Invoke("Read", new object[] {__EntityType});
			return ((UndoRedoOptions)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public UndoRedoOptions Reload(UndoRedoOptions _UndoRedoOptions)
        {
			object[] results = this.Invoke("Reload", new object[] {_UndoRedoOptions});
			return ((UndoRedoOptions)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public UndoRedoOptions Create(System.String __EntityType)
        {
			object[] results = this.Invoke("Create", new object[] {__EntityType});
			return ((UndoRedoOptions)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __EntityType)
        {
			this.Invoke("Delete", new object[] {__EntityType});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(UndoRedoOptions _UndoRedoOptions)
        {
			this.Invoke("UpdateObject", new object[] {_UndoRedoOptions});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(UndoRedoOptions _UndoRedoOptions)
        {
			this.Invoke("CreateObject", new object[] {_UndoRedoOptions});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(UndoRedoOptions _UndoRedoOptions)
        {
			this.Invoke("DeleteObject", new object[] {_UndoRedoOptions});
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
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByEntityType", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public UndoRedoOptionsCollection SearchByEntityType(System.String EntityType ) {
			object[] results = this.Invoke("SearchByEntityType", new object[] {EntityType});
			return ((UndoRedoOptionsCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByEntityTypePaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public UndoRedoOptionsCollection SearchByEntityTypePaged(System.String EntityType , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("SearchByEntityTypePaged", new object[] {EntityType,PagingStart,PagingCount});
			return ((UndoRedoOptionsCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByEntityTypeCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByEntityTypeCount(System.String EntityType ) {
			object[] results = this.Invoke("SearchByEntityTypeCount", new object[] {EntityType});
			return ((long)(results[0]));
		}

	}
	
	
} // namespace Web

} // namespace Platform.Module.UndoRedo.Services.Packages
