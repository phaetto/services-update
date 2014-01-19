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

namespace Services.Packages
{
	/// <summary>
    /// Defines the contract for the LocalPackage class
    /// </summary>
    [ComVisible(true)]
    [Guid("809b654f-9180-98fa-92b6-4984490462e4")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface ILocalPackage
	{
		bool Exists { get; }
		System.String PackageName { get; set; }
		System.Int32 Id { get; set; }
		System.String VersionLabel { get; set; }

		void Read(System.String __PackageName);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(LocalPackage _object);
		void CopyWithKeysTo(LocalPackage _object);
		void CopyFrom(LocalPackage _object);
		void CopyTo(LocalPackage _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.LocalPackage type.
    /// </summary>
    [ComVisible(true)]
    [Guid("212760b9-5ea9-f17a-b7d5-a3526d5b8a41")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface ILocalPackageService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(LocalPackage _LocalPackage);
		[OperationContract]
        LocalPackage Read(System.String __PackageName);
        [OperationContract]
        LocalPackage Reload(LocalPackage _LocalPackage);
        [OperationContract]
        LocalPackage Create(System.String __PackageName);
        [OperationContract]
        void Delete(System.String __PackageName);
        [OperationContract]
        void UpdateObject(LocalPackage _LocalPackage);
        [OperationContract]
        void CreateObject(LocalPackage _LocalPackage);
        [OperationContract]
        void DeleteObject(LocalPackage _LocalPackage);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		LocalPackageCollection SearchByPackageName(System.String PackageName );
		[OperationContract]
		LocalPackageCollection SearchByPackageNamePaged(System.String PackageName , long PagingStart, long PagingCount);
		[OperationContract]
		long SearchByPackageNameCount(System.String PackageName );

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.LocalPackage type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("8358e20d-5270-4751-3242-2005322d0b2d")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class LocalPackageService : ILocalPackageService
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
        public bool Exists(LocalPackage _LocalPackage)
        {
			return _LocalPackage.Exists;
        }
		
		[WebMethod]
		public LocalPackage Read(System.String __PackageName)
		{
			return new LocalPackage(__PackageName);
		}
		
		[WebMethod]
        public LocalPackage Reload(LocalPackage _LocalPackage)
        {
			_LocalPackage.Reload();
			return _LocalPackage;
        }
		
		[WebMethod]
        public LocalPackage Create(System.String __PackageName)
        {
			return LocalPackage.CreateLocalPackage(__PackageName);
        }
        
        [WebMethod]
        public void Delete(System.String __PackageName)
        {
			LocalPackage.DeleteLocalPackage(__PackageName);
        }
        
        [WebMethod]
        public void UpdateObject(LocalPackage _LocalPackage)
        {
			_LocalPackage.Update();
        }
		
		[WebMethod]
        public void CreateObject(LocalPackage _LocalPackage)
        {
			_LocalPackage.Create();
        }
        
        [WebMethod]
        public void DeleteObject(LocalPackage _LocalPackage)
        {
			_LocalPackage.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			LocalPackage.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			LocalPackage.Redo();
        }
		[WebMethod]
		public LocalPackageCollection SearchByPackageName(System.String PackageName )
		{
			return LocalPackage.SearchByPackageName(PackageName );
		}
		[WebMethod]
		public LocalPackageCollection SearchByPackageNamePaged(System.String PackageName , long PagingStart, long PagingCount)
		{
			return LocalPackage.SearchByPackageNamePaged(PackageName , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByPackageNameCount(System.String PackageName )
		{
			return LocalPackage.SearchByPackageNameCount(PackageName );
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.LocalPackage model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("647b34f0-9526-f111-eaaa-c8abeea72a36")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class LocalPackage : ILocalPackage, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<ILocalPackageService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<ILocalPackageService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<ILocalPackageService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.LocalPackage"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.LocalPackage"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.LocalPackage.ProviderType");
				
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


		System.String _PackageName;
		
		// Key member
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String PackageName
		{
            get
            {
                return _PackageName;
            }
            set
            {
				if (_PackageName != value)
					__hasBeenReadOnce = false;
                _PackageName = value;
            }
		}

		System.Int32 _Id;
		
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
                _Id = value;
            }
		}

		System.String _VersionLabel;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String VersionLabel
		{
            get
            {
                return _VersionLabel;
            }
            set
            {
                _VersionLabel = value;
            }
		}

		public static LocalPackageCollection SearchByPackageName(System.String _PackageName)
        {
			LocalPackageCollection _LocalPackageCollection = new LocalPackageCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("LoPaSeByPaNa", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _PackageName = ClassConnectionProvider.Escape(_PackageName);
				
                
                DbParameter param_PackageName = ClassConnectionProvider.GetDatabaseParameter("PackageName", typeof(System.String), -1);
				param_PackageName.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageName);
				command.Parameters.Add(param_PackageName);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					LocalPackage o = new LocalPackage();
                
					o.__databaseState = RowState.Initialized;
                    o._PackageName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PackageName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._VersionLabel = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VersionLabel"], typeof(System.String));
				
                    
                    _LocalPackageCollection.Add(o);
                }

                dr.Close();
            }
            
            return _LocalPackageCollection;
        }
        
        public static LocalPackageCollection SearchByPackageNamePaged(System.String _PackageName, long PagingStart, long PagingCount)
        {
			LocalPackageCollection _LocalPackageCollection = new LocalPackageCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("LoPaSeByPaNaPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _PackageName = ClassConnectionProvider.Escape(_PackageName);
				
                
                DbParameter param_PackageName = ClassConnectionProvider.GetDatabaseParameter("PackageName", typeof(System.String), -1);
				param_PackageName.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageName);
				command.Parameters.Add(param_PackageName);
				
                
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
					LocalPackage o = new LocalPackage();
                
					o.__databaseState = RowState.Initialized;
                    o._PackageName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PackageName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._VersionLabel = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VersionLabel"], typeof(System.String));
				
                    
                    _LocalPackageCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _LocalPackageCollection;
        }
        
        public static long SearchByPackageNameCount(System.String _PackageName)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("LoPaSeByPaNaCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _PackageName = ClassConnectionProvider.Escape(_PackageName);
				
                
                DbParameter param_PackageName = ClassConnectionProvider.GetDatabaseParameter("PackageName", typeof(System.String), -1);
				param_PackageName.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageName);
				command.Parameters.Add(param_PackageName);
				
                
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
        
        public LocalPackage() {}
        
        public LocalPackage(System.String __PackageName)
        {
			Read(__PackageName);
        }
        
        #region CRUD
        
        void Exist()
        {
			// sql read - should be changed to specific exist implementation
			using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
			{
				dbconn.Open();
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("LoPaRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
				DbParameter param_PackageName = ClassConnectionProvider.GetDatabaseParameter("PackageName", typeof(System.String), 1024);
				param_PackageName.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageName);
				command.Parameters.Add(param_PackageName);
				
                
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
        
        public void Read(System.String __PackageName)
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].Read(__PackageName);
					return;
				}

                // Get a service via an algorithm
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "LoPa");
                // Perfect for read operations, but not for write
                // scalingServices[nextIndex].Read(__PackageName);
				// return;

				throw new NotImplementedException();
            }

            try
            {
				// sql read
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("LoPaRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					_PackageName = __PackageName;
				DbParameter param_PackageName = ClassConnectionProvider.GetDatabaseParameter("PackageName", typeof(System.String), 1024);
				param_PackageName.Value = ClassConnectionProvider.FromValueToSqlModelType(__PackageName);
				command.Parameters.Add(param_PackageName);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_PackageName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PackageName"], typeof(System.String));
				_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_VersionLabel = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VersionLabel"], typeof(System.String));
				
                    
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
                            failoverServices[n].Read(__PackageName);
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "LoPa");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("LoPaRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_PackageName = ClassConnectionProvider.GetDatabaseParameter("PackageName", typeof(System.String), 1024);
				param_PackageName.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageName);
				command.Parameters.Add(param_PackageName);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_PackageName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PackageName"], typeof(System.String));
				_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_VersionLabel = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VersionLabel"], typeof(System.String));
				
                    
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("LoPaCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_PackageName = ClassConnectionProvider.GetDatabaseParameter("PackageName", typeof(System.String), 1024);
				param_PackageName.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageName);
				command.Parameters.Add(param_PackageName);
				DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				DbParameter param_VersionLabel = ClassConnectionProvider.GetDatabaseParameter("VersionLabel", typeof(System.String), 1024);
				param_VersionLabel.Value = ClassConnectionProvider.FromValueToSqlModelType(_VersionLabel);
				command.Parameters.Add(param_VersionLabel);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_PackageName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PackageName"], typeof(System.String));
				_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_VersionLabel = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VersionLabel"], typeof(System.String));
				
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
        
        static public LocalPackage CreateLocalPackage(System.String __PackageName)
        {
            LocalPackage o = new LocalPackage(__PackageName);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("LoPaUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_PackageName = ClassConnectionProvider.GetDatabaseParameter("PackageName", typeof(System.String), 1024);
				param_PackageName.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageName);
				command.Parameters.Add(param_PackageName);
				DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				DbParameter param_VersionLabel = ClassConnectionProvider.GetDatabaseParameter("VersionLabel", typeof(System.String), 1024);
				param_VersionLabel.Value = ClassConnectionProvider.FromValueToSqlModelType(_VersionLabel);
				command.Parameters.Add(param_VersionLabel);
				

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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("LoPaDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_PackageName = ClassConnectionProvider.GetDatabaseParameter("PackageName", typeof(System.String), 1024);
				param_PackageName.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageName);
				command.Parameters.Add(param_PackageName);
				
				
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
        
        static public void DeleteLocalPackage(System.String __PackageName)
        {
            LocalPackage o = new LocalPackage(__PackageName);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(LocalPackage _object)
        {
			_PackageName = _object._PackageName;
			_Id = _object._Id;
			_VersionLabel = _object._VersionLabel;
			
        }
        
        public void CopyWithKeysTo(LocalPackage _object)
        {
			_object._PackageName = _PackageName;
			_object._Id = _Id;
			_object._VersionLabel = _VersionLabel;
			
        }
        
        static public void CopyWithKeysObject(LocalPackage _objectFrom, LocalPackage _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(LocalPackage _object)
        {
			_Id = _object._Id;
			_VersionLabel = _object._VersionLabel;
			
        }
        
        public void CopyTo(LocalPackage _object)
        {
			_object._Id = _Id;
			_object._VersionLabel = _VersionLabel;
			
        }
        
        static public void CopyObject(LocalPackage _objectFrom, LocalPackage _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(LocalPackage).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(LocalPackage).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(LocalPackage _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			LocalPackageUndoRedoCollection allUndidAndNotRedoneEntries = LocalPackageUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			LocalPackageUndoRedo _urobject = new LocalPackageUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.PackageName = _object._PackageName;
			_urobject.Id = _object._Id;
			_urobject.VersionLabel = _object._VersionLabel;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(LocalPackage).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = LocalPackageUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				LocalPackageUndoRedoCollection allOldUndoEntries = LocalPackageUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			LocalPackageUndoRedoCollection firstUndoEntries = LocalPackageUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			LocalPackageUndoRedo _urobject = firstUndoEntries[0];
			
			LocalPackage _object = new LocalPackage();
			_object._PackageName = _urobject.PackageName;
			_object._Id = _urobject.Id;
			_object._VersionLabel = _urobject.VersionLabel;
			

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
			LocalPackageUndoRedoCollection firstEntryToRedoEntries = LocalPackageUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			LocalPackageUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			LocalPackage _object = new LocalPackage();
			_object._PackageName = _urobject.PackageName;
			_object._Id = _urobject.Id;
			_object._VersionLabel = _urobject.VersionLabel;
			

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
    /// Defines the contract for the LocalPackageCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("6676072b-deac-6673-0edf-ef663d75bf8a")]
    public interface ILocalPackageCollection : IEnumerable<LocalPackage>
    {
        int IndexOf(LocalPackage item);
        void Insert(int index, LocalPackage item);
        void RemoveAt(int index);
        LocalPackage this[int index] { get; set; }
        void Add(LocalPackage item);
        void Clear();
        bool Contains(LocalPackage item);
        void CopyTo(LocalPackage[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(LocalPackage item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.LocalPackage
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("396175c9-26df-781a-d166-98c689a6598a")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class LocalPackageCollection : ILocalPackageCollection, IList<LocalPackage>, IHierarchicalEnumerable
    {
        List<LocalPackage> _list = new List<LocalPackage>();
        
        public static implicit operator List<LocalPackage>(LocalPackageCollection collection)
        {
            return collection._list;
        }

        #region IList<LocalPackage> Members

        public int IndexOf(LocalPackage item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, LocalPackage item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public LocalPackage this[int index]
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

        #region ICollection<LocalPackage> Members

        public void Add(LocalPackage item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(LocalPackage item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(LocalPackage[] array, int arrayIndex)
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

        public bool Remove(LocalPackage item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<LocalPackage> Members

        public IEnumerator<LocalPackage> GetEnumerator()
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
	/// that share Services.Packages.LocalPackage objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Web.LocalPackageWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class LocalPackageWebService : WebService, ILocalPackageService
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
        public bool Exists(LocalPackage _LocalPackage)
        {
			return _LocalPackage.Exists;
        }
		
		[WebMethod]
		public LocalPackage Read(System.String __PackageName)
		{
			return new LocalPackage(__PackageName);
		}
		
		[WebMethod]
        public LocalPackage Reload(LocalPackage _LocalPackage)
        {
			_LocalPackage.Reload();
			return _LocalPackage;
        }
		
		[WebMethod]
        public LocalPackage Create(System.String __PackageName)
        {
			return LocalPackage.CreateLocalPackage(__PackageName);
        }
        
        [WebMethod]
        public void Delete(System.String __PackageName)
        {
			LocalPackage.DeleteLocalPackage(__PackageName);
        }
        
        [WebMethod]
        public void UpdateObject(LocalPackage _LocalPackage)
        {
			_LocalPackage.Update();
        }
		
		[WebMethod]
        public void CreateObject(LocalPackage _LocalPackage)
        {
			_LocalPackage.Create();
        }
        
        [WebMethod]
        public void DeleteObject(LocalPackage _LocalPackage)
        {
			_LocalPackage.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			LocalPackage.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			LocalPackage.Redo();
        }
		[WebMethod]
		public LocalPackageCollection SearchByPackageName(System.String PackageName )
		{
			return LocalPackage.SearchByPackageName(PackageName );
		}
		[WebMethod]
		public LocalPackageCollection SearchByPackageNamePaged(System.String PackageName , long PagingStart, long PagingCount)
		{
			return LocalPackage.SearchByPackageNamePaged(PackageName , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByPackageNameCount(System.String PackageName )
		{
			return LocalPackage.SearchByPackageNameCount(PackageName );
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalPackageWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("2ad9ea17-a5b7-1281-c015-5547a6aab375")]
    sealed public class LocalPackageWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, ILocalPackageService
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
		public LocalPackageWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public LocalPackageWebServiceClient()
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
		public bool Exists(LocalPackage _LocalPackage)
        {
			object[] results = this.Invoke("Exists", new object[] {_LocalPackage});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public LocalPackage Read(System.String __PackageName)
		{
			object[] results = this.Invoke("Read", new object[] {__PackageName});
			return ((LocalPackage)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public LocalPackage Reload(LocalPackage _LocalPackage)
        {
			object[] results = this.Invoke("Reload", new object[] {_LocalPackage});
			return ((LocalPackage)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public LocalPackage Create(System.String __PackageName)
        {
			object[] results = this.Invoke("Create", new object[] {__PackageName});
			return ((LocalPackage)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __PackageName)
        {
			this.Invoke("Delete", new object[] {__PackageName});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(LocalPackage _LocalPackage)
        {
			this.Invoke("UpdateObject", new object[] {_LocalPackage});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(LocalPackage _LocalPackage)
        {
			this.Invoke("CreateObject", new object[] {_LocalPackage});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(LocalPackage _LocalPackage)
        {
			this.Invoke("DeleteObject", new object[] {_LocalPackage});
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
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByPackageName", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public LocalPackageCollection SearchByPackageName(System.String PackageName ) {
			object[] results = this.Invoke("SearchByPackageName", new object[] {PackageName});
			return ((LocalPackageCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByPackageNamePaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public LocalPackageCollection SearchByPackageNamePaged(System.String PackageName , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("SearchByPackageNamePaged", new object[] {PackageName,PagingStart,PagingCount});
			return ((LocalPackageCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByPackageNameCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByPackageNameCount(System.String PackageName ) {
			object[] results = this.Invoke("SearchByPackageNameCount", new object[] {PackageName});
			return ((long)(results[0]));
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages
