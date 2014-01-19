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
    /// Defines the contract for the UndoRedoGroup class
    /// </summary>
    [ComVisible(true)]
    [Guid("16bc4334-706b-d0b7-fb99-7a3342166ff0")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IUndoRedoGroup
	{
		bool Exists { get; }
		System.Int64 Id { get; set; }
		System.String EntryName { get; set; }
		System.String UndoRedoEntityType { get; set; }
		System.Int64 UndoRedoRecordId { get; set; }

		void Read(System.Int64 __Id, System.String __UndoRedoEntityType);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(UndoRedoGroup _object);
		void CopyWithKeysTo(UndoRedoGroup _object);
		void CopyFrom(UndoRedoGroup _object);
		void CopyTo(UndoRedoGroup _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Platform.Module.UndoRedo.Services.Packages.UndoRedoGroup type.
    /// </summary>
    [ComVisible(true)]
    [Guid("9577a647-1e13-02a4-8c12-18783d52560d")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IUndoRedoGroupService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(UndoRedoGroup _UndoRedoGroup);
		[OperationContract]
        UndoRedoGroup Read(System.Int64 __Id, System.String __UndoRedoEntityType);
        [OperationContract]
        UndoRedoGroup Reload(UndoRedoGroup _UndoRedoGroup);
        [OperationContract]
        UndoRedoGroup Create(System.Int64 __Id, System.String __UndoRedoEntityType);
        [OperationContract]
        void Delete(System.Int64 __Id, System.String __UndoRedoEntityType);
        [OperationContract]
        void UpdateObject(UndoRedoGroup _UndoRedoGroup);
        [OperationContract]
        void CreateObject(UndoRedoGroup _UndoRedoGroup);
        [OperationContract]
        void DeleteObject(UndoRedoGroup _UndoRedoGroup);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		UndoRedoGroupCollection SearchByEntityType(System.String UndoRedoEntityType );
		[OperationContract]
		UndoRedoGroupCollection SearchByEntityTypePaged(System.String UndoRedoEntityType , long PagingStart, long PagingCount);
		[OperationContract]
		long SearchByEntityTypeCount(System.String UndoRedoEntityType );

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Platform.Module.UndoRedo.Services.Packages.UndoRedoGroup type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("216659dc-ee3f-6856-39a6-2949ab623b08")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class UndoRedoGroupService : IUndoRedoGroupService
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
        public bool Exists(UndoRedoGroup _UndoRedoGroup)
        {
			return _UndoRedoGroup.Exists;
        }
		
		[WebMethod]
		public UndoRedoGroup Read(System.Int64 __Id, System.String __UndoRedoEntityType)
		{
			return new UndoRedoGroup(__Id, __UndoRedoEntityType);
		}
		
		[WebMethod]
        public UndoRedoGroup Reload(UndoRedoGroup _UndoRedoGroup)
        {
			_UndoRedoGroup.Reload();
			return _UndoRedoGroup;
        }
		
		[WebMethod]
        public UndoRedoGroup Create(System.Int64 __Id, System.String __UndoRedoEntityType)
        {
			return UndoRedoGroup.CreateUndoRedoGroup(__Id, __UndoRedoEntityType);
        }
        
        [WebMethod]
        public void Delete(System.Int64 __Id, System.String __UndoRedoEntityType)
        {
			UndoRedoGroup.DeleteUndoRedoGroup(__Id, __UndoRedoEntityType);
        }
        
        [WebMethod]
        public void UpdateObject(UndoRedoGroup _UndoRedoGroup)
        {
			_UndoRedoGroup.Update();
        }
		
		[WebMethod]
        public void CreateObject(UndoRedoGroup _UndoRedoGroup)
        {
			_UndoRedoGroup.Create();
        }
        
        [WebMethod]
        public void DeleteObject(UndoRedoGroup _UndoRedoGroup)
        {
			_UndoRedoGroup.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			UndoRedoGroup.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			UndoRedoGroup.Redo();
        }
		[WebMethod]
		public UndoRedoGroupCollection SearchByEntityType(System.String UndoRedoEntityType )
		{
			return UndoRedoGroup.SearchByEntityType(UndoRedoEntityType );
		}
		[WebMethod]
		public UndoRedoGroupCollection SearchByEntityTypePaged(System.String UndoRedoEntityType , long PagingStart, long PagingCount)
		{
			return UndoRedoGroup.SearchByEntityTypePaged(UndoRedoEntityType , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByEntityTypeCount(System.String UndoRedoEntityType )
		{
			return UndoRedoGroup.SearchByEntityTypeCount(UndoRedoEntityType );
		}

    }
	
	/// <summary>
    /// Provides the implementation of Platform.Module.UndoRedo.Services.Packages.UndoRedoGroup model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("e141a570-ef42-154a-9fb9-8958583f92a9")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class UndoRedoGroup : IUndoRedoGroup, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<IUndoRedoGroupService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<IUndoRedoGroupService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<IUndoRedoGroupService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Platform.Module.UndoRedo.Services.Packages.UndoRedoGroup"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Platform.Module.UndoRedo.Services.Packages.UndoRedoGroup"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Platform.Module.UndoRedo.Services.Packages.UndoRedoGroup.ProviderType");
				
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


		System.Int64 _Id;
		
		// Key member
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Int64 Id
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

		System.String _EntryName;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String EntryName
		{
            get
            {
                return _EntryName;
            }
            set
            {
                _EntryName = value;
            }
		}

		System.String _UndoRedoEntityType;
		
		// Key member
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String UndoRedoEntityType
		{
            get
            {
                return _UndoRedoEntityType;
            }
            set
            {
				if (_UndoRedoEntityType != value)
					__hasBeenReadOnce = false;
                _UndoRedoEntityType = value;
            }
		}

		System.Int64 _UndoRedoRecordId;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Int64 UndoRedoRecordId
		{
            get
            {
                return _UndoRedoRecordId;
            }
            set
            {
                _UndoRedoRecordId = value;
            }
		}

		public static UndoRedoGroupCollection SearchByEntityType(System.String _UndoRedoEntityType)
        {
			UndoRedoGroupCollection _UndoRedoGroupCollection = new UndoRedoGroupCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("UnReGrSeByEnTy", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UndoRedoEntityType = ClassConnectionProvider.Escape(_UndoRedoEntityType);
				
                
                DbParameter param_UndoRedoEntityType = ClassConnectionProvider.GetDatabaseParameter("UndoRedoEntityType", typeof(System.String), -1);
				param_UndoRedoEntityType.Value = ClassConnectionProvider.FromValueToSqlModelType(_UndoRedoEntityType);
				command.Parameters.Add(param_UndoRedoEntityType);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					UndoRedoGroup o = new UndoRedoGroup();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int64));
				o._EntryName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["EntryName"], typeof(System.String));
				o._UndoRedoEntityType = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoEntityType"], typeof(System.String));
				o._UndoRedoRecordId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoRecordId"], typeof(System.Int64));
				
                    
                    _UndoRedoGroupCollection.Add(o);
                }

                dr.Close();
            }
            
            return _UndoRedoGroupCollection;
        }
        
        public static UndoRedoGroupCollection SearchByEntityTypePaged(System.String _UndoRedoEntityType, long PagingStart, long PagingCount)
        {
			UndoRedoGroupCollection _UndoRedoGroupCollection = new UndoRedoGroupCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("UnReGrSeByEnTyPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UndoRedoEntityType = ClassConnectionProvider.Escape(_UndoRedoEntityType);
				
                
                DbParameter param_UndoRedoEntityType = ClassConnectionProvider.GetDatabaseParameter("UndoRedoEntityType", typeof(System.String), -1);
				param_UndoRedoEntityType.Value = ClassConnectionProvider.FromValueToSqlModelType(_UndoRedoEntityType);
				command.Parameters.Add(param_UndoRedoEntityType);
				
                
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
					UndoRedoGroup o = new UndoRedoGroup();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int64));
				o._EntryName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["EntryName"], typeof(System.String));
				o._UndoRedoEntityType = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoEntityType"], typeof(System.String));
				o._UndoRedoRecordId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoRecordId"], typeof(System.Int64));
				
                    
                    _UndoRedoGroupCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _UndoRedoGroupCollection;
        }
        
        public static long SearchByEntityTypeCount(System.String _UndoRedoEntityType)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("UnReGrSeByEnTyCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UndoRedoEntityType = ClassConnectionProvider.Escape(_UndoRedoEntityType);
				
                
                DbParameter param_UndoRedoEntityType = ClassConnectionProvider.GetDatabaseParameter("UndoRedoEntityType", typeof(System.String), -1);
				param_UndoRedoEntityType.Value = ClassConnectionProvider.FromValueToSqlModelType(_UndoRedoEntityType);
				command.Parameters.Add(param_UndoRedoEntityType);
				
                
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
        
        public UndoRedoGroup() {}
        
        public UndoRedoGroup(System.Int64 __Id, System.String __UndoRedoEntityType)
        {
			Read(__Id, __UndoRedoEntityType);
        }
        
        #region CRUD
        
        void Exist()
        {
			// sql read - should be changed to specific exist implementation
			using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
			{
				dbconn.Open();
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("UnReGrRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
				DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int64), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				DbParameter param_UndoRedoEntityType = ClassConnectionProvider.GetDatabaseParameter("UndoRedoEntityType", typeof(System.String), 128);
				param_UndoRedoEntityType.Value = ClassConnectionProvider.FromValueToSqlModelType(_UndoRedoEntityType);
				command.Parameters.Add(param_UndoRedoEntityType);
				
                
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
        
        public void Read(System.Int64 __Id, System.String __UndoRedoEntityType)
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].Read(__Id, __UndoRedoEntityType);
					return;
				}

                // Get a service via an algorithm
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "UnReGr");
                // Perfect for read operations, but not for write
                // scalingServices[nextIndex].Read(__Id, __UndoRedoEntityType);
				// return;

				throw new NotImplementedException();
            }

            try
            {
				// sql read
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("UnReGrRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					_Id = __Id;
				DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int64), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(__Id);
				command.Parameters.Add(param_Id);
				_UndoRedoEntityType = __UndoRedoEntityType;
				DbParameter param_UndoRedoEntityType = ClassConnectionProvider.GetDatabaseParameter("UndoRedoEntityType", typeof(System.String), 128);
				param_UndoRedoEntityType.Value = ClassConnectionProvider.FromValueToSqlModelType(__UndoRedoEntityType);
				command.Parameters.Add(param_UndoRedoEntityType);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_Id = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int64));
				_EntryName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["EntryName"], typeof(System.String));
				_UndoRedoEntityType = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoEntityType"], typeof(System.String));
				_UndoRedoRecordId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoRecordId"], typeof(System.Int64));
				
                    
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
                            failoverServices[n].Read(__Id, __UndoRedoEntityType);
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "UnReGr");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("UnReGrRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int64), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				DbParameter param_UndoRedoEntityType = ClassConnectionProvider.GetDatabaseParameter("UndoRedoEntityType", typeof(System.String), 128);
				param_UndoRedoEntityType.Value = ClassConnectionProvider.FromValueToSqlModelType(_UndoRedoEntityType);
				command.Parameters.Add(param_UndoRedoEntityType);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_Id = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int64));
				_EntryName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["EntryName"], typeof(System.String));
				_UndoRedoEntityType = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoEntityType"], typeof(System.String));
				_UndoRedoRecordId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoRecordId"], typeof(System.Int64));
				
                    
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("UnReGrCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_EntryName = ClassConnectionProvider.GetDatabaseParameter("EntryName", typeof(System.String), 128);
				param_EntryName.Value = ClassConnectionProvider.FromValueToSqlModelType(_EntryName);
				command.Parameters.Add(param_EntryName);
				DbParameter param_UndoRedoEntityType = ClassConnectionProvider.GetDatabaseParameter("UndoRedoEntityType", typeof(System.String), 128);
				param_UndoRedoEntityType.Value = ClassConnectionProvider.FromValueToSqlModelType(_UndoRedoEntityType);
				command.Parameters.Add(param_UndoRedoEntityType);
				DbParameter param_UndoRedoRecordId = ClassConnectionProvider.GetDatabaseParameter("UndoRedoRecordId", typeof(System.Int64), -1);
				param_UndoRedoRecordId.Value = ClassConnectionProvider.FromValueToSqlModelType(_UndoRedoRecordId);
				command.Parameters.Add(param_UndoRedoRecordId);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_Id = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int64));
				_EntryName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["EntryName"], typeof(System.String));
				_UndoRedoEntityType = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoEntityType"], typeof(System.String));
				_UndoRedoRecordId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoRecordId"], typeof(System.Int64));
				
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
        
        static public UndoRedoGroup CreateUndoRedoGroup(System.Int64 __Id, System.String __UndoRedoEntityType)
        {
            UndoRedoGroup o = new UndoRedoGroup(__Id, __UndoRedoEntityType);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("UnReGrUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int64), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				DbParameter param_EntryName = ClassConnectionProvider.GetDatabaseParameter("EntryName", typeof(System.String), 128);
				param_EntryName.Value = ClassConnectionProvider.FromValueToSqlModelType(_EntryName);
				command.Parameters.Add(param_EntryName);
				DbParameter param_UndoRedoEntityType = ClassConnectionProvider.GetDatabaseParameter("UndoRedoEntityType", typeof(System.String), 128);
				param_UndoRedoEntityType.Value = ClassConnectionProvider.FromValueToSqlModelType(_UndoRedoEntityType);
				command.Parameters.Add(param_UndoRedoEntityType);
				DbParameter param_UndoRedoRecordId = ClassConnectionProvider.GetDatabaseParameter("UndoRedoRecordId", typeof(System.Int64), -1);
				param_UndoRedoRecordId.Value = ClassConnectionProvider.FromValueToSqlModelType(_UndoRedoRecordId);
				command.Parameters.Add(param_UndoRedoRecordId);
				

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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("UnReGrDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int64), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				DbParameter param_UndoRedoEntityType = ClassConnectionProvider.GetDatabaseParameter("UndoRedoEntityType", typeof(System.String), 128);
				param_UndoRedoEntityType.Value = ClassConnectionProvider.FromValueToSqlModelType(_UndoRedoEntityType);
				command.Parameters.Add(param_UndoRedoEntityType);
				
				
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
        
        static public void DeleteUndoRedoGroup(System.Int64 __Id, System.String __UndoRedoEntityType)
        {
            UndoRedoGroup o = new UndoRedoGroup(__Id, __UndoRedoEntityType);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(UndoRedoGroup _object)
        {
			_Id = _object._Id;
			_EntryName = _object._EntryName;
			_UndoRedoEntityType = _object._UndoRedoEntityType;
			_UndoRedoRecordId = _object._UndoRedoRecordId;
			
        }
        
        public void CopyWithKeysTo(UndoRedoGroup _object)
        {
			_object._Id = _Id;
			_object._EntryName = _EntryName;
			_object._UndoRedoEntityType = _UndoRedoEntityType;
			_object._UndoRedoRecordId = _UndoRedoRecordId;
			
        }
        
        static public void CopyWithKeysObject(UndoRedoGroup _objectFrom, UndoRedoGroup _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(UndoRedoGroup _object)
        {
			_EntryName = _object._EntryName;
			_UndoRedoRecordId = _object._UndoRedoRecordId;
			
        }
        
        public void CopyTo(UndoRedoGroup _object)
        {
			_object._EntryName = _EntryName;
			_object._UndoRedoRecordId = _UndoRedoRecordId;
			
        }
        
        static public void CopyObject(UndoRedoGroup _objectFrom, UndoRedoGroup _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(UndoRedoGroup).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(UndoRedoGroup).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(UndoRedoGroup _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			UndoRedoGroupUndoRedoCollection allUndidAndNotRedoneEntries = UndoRedoGroupUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			UndoRedoGroupUndoRedo _urobject = new UndoRedoGroupUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.Id = _object._Id;
			_urobject.EntryName = _object._EntryName;
			_urobject.UndoRedoEntityType = _object._UndoRedoEntityType;
			_urobject.UndoRedoRecordId = _object._UndoRedoRecordId;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(UndoRedoGroup).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = UndoRedoGroupUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				UndoRedoGroupUndoRedoCollection allOldUndoEntries = UndoRedoGroupUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			UndoRedoGroupUndoRedoCollection firstUndoEntries = UndoRedoGroupUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			UndoRedoGroupUndoRedo _urobject = firstUndoEntries[0];
			
			UndoRedoGroup _object = new UndoRedoGroup();
			_object._Id = _urobject.Id;
			_object._EntryName = _urobject.EntryName;
			_object._UndoRedoEntityType = _urobject.UndoRedoEntityType;
			_object._UndoRedoRecordId = _urobject.UndoRedoRecordId;
			

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
			UndoRedoGroupUndoRedoCollection firstEntryToRedoEntries = UndoRedoGroupUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			UndoRedoGroupUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			UndoRedoGroup _object = new UndoRedoGroup();
			_object._Id = _urobject.Id;
			_object._EntryName = _urobject.EntryName;
			_object._UndoRedoEntityType = _urobject.UndoRedoEntityType;
			_object._UndoRedoRecordId = _urobject.UndoRedoRecordId;
			

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
    /// Defines the contract for the UndoRedoGroupCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("e9566d43-4eb0-59b1-500f-5b6df45a572a")]
    public interface IUndoRedoGroupCollection : IEnumerable<UndoRedoGroup>
    {
        int IndexOf(UndoRedoGroup item);
        void Insert(int index, UndoRedoGroup item);
        void RemoveAt(int index);
        UndoRedoGroup this[int index] { get; set; }
        void Add(UndoRedoGroup item);
        void Clear();
        bool Contains(UndoRedoGroup item);
        void CopyTo(UndoRedoGroup[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(UndoRedoGroup item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Platform.Module.UndoRedo.Services.Packages.UndoRedoGroup
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("970710d7-7511-edcb-0e50-828564fd0ffa")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class UndoRedoGroupCollection : IUndoRedoGroupCollection, IList<UndoRedoGroup>, IHierarchicalEnumerable
    {
        List<UndoRedoGroup> _list = new List<UndoRedoGroup>();
        
        public static implicit operator List<UndoRedoGroup>(UndoRedoGroupCollection collection)
        {
            return collection._list;
        }

        #region IList<UndoRedoGroup> Members

        public int IndexOf(UndoRedoGroup item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, UndoRedoGroup item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public UndoRedoGroup this[int index]
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

        #region ICollection<UndoRedoGroup> Members

        public void Add(UndoRedoGroup item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(UndoRedoGroup item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(UndoRedoGroup[] array, int arrayIndex)
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

        public bool Remove(UndoRedoGroup item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<UndoRedoGroup> Members

        public IEnumerator<UndoRedoGroup> GetEnumerator()
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
	/// that share Platform.Module.UndoRedo.Services.Packages.UndoRedoGroup objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Platform.Module.UndoRedo.Services.Packages.Web.UndoRedoGroupWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class UndoRedoGroupWebService : WebService, IUndoRedoGroupService
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
        public bool Exists(UndoRedoGroup _UndoRedoGroup)
        {
			return _UndoRedoGroup.Exists;
        }
		
		[WebMethod]
		public UndoRedoGroup Read(System.Int64 __Id, System.String __UndoRedoEntityType)
		{
			return new UndoRedoGroup(__Id, __UndoRedoEntityType);
		}
		
		[WebMethod]
        public UndoRedoGroup Reload(UndoRedoGroup _UndoRedoGroup)
        {
			_UndoRedoGroup.Reload();
			return _UndoRedoGroup;
        }
		
		[WebMethod]
        public UndoRedoGroup Create(System.Int64 __Id, System.String __UndoRedoEntityType)
        {
			return UndoRedoGroup.CreateUndoRedoGroup(__Id, __UndoRedoEntityType);
        }
        
        [WebMethod]
        public void Delete(System.Int64 __Id, System.String __UndoRedoEntityType)
        {
			UndoRedoGroup.DeleteUndoRedoGroup(__Id, __UndoRedoEntityType);
        }
        
        [WebMethod]
        public void UpdateObject(UndoRedoGroup _UndoRedoGroup)
        {
			_UndoRedoGroup.Update();
        }
		
		[WebMethod]
        public void CreateObject(UndoRedoGroup _UndoRedoGroup)
        {
			_UndoRedoGroup.Create();
        }
        
        [WebMethod]
        public void DeleteObject(UndoRedoGroup _UndoRedoGroup)
        {
			_UndoRedoGroup.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			UndoRedoGroup.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			UndoRedoGroup.Redo();
        }
		[WebMethod]
		public UndoRedoGroupCollection SearchByEntityType(System.String UndoRedoEntityType )
		{
			return UndoRedoGroup.SearchByEntityType(UndoRedoEntityType );
		}
		[WebMethod]
		public UndoRedoGroupCollection SearchByEntityTypePaged(System.String UndoRedoEntityType , long PagingStart, long PagingCount)
		{
			return UndoRedoGroup.SearchByEntityTypePaged(UndoRedoEntityType , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByEntityTypeCount(System.String UndoRedoEntityType )
		{
			return UndoRedoGroup.SearchByEntityTypeCount(UndoRedoEntityType );
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="UndoRedoGroupWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("3e068013-510b-2258-f4e7-913393dd2144")]
    sealed public class UndoRedoGroupWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IUndoRedoGroupService
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
		public UndoRedoGroupWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public UndoRedoGroupWebServiceClient()
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
		public bool Exists(UndoRedoGroup _UndoRedoGroup)
        {
			object[] results = this.Invoke("Exists", new object[] {_UndoRedoGroup});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public UndoRedoGroup Read(System.Int64 __Id, System.String __UndoRedoEntityType)
		{
			object[] results = this.Invoke("Read", new object[] {__Id, __UndoRedoEntityType});
			return ((UndoRedoGroup)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public UndoRedoGroup Reload(UndoRedoGroup _UndoRedoGroup)
        {
			object[] results = this.Invoke("Reload", new object[] {_UndoRedoGroup});
			return ((UndoRedoGroup)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public UndoRedoGroup Create(System.Int64 __Id, System.String __UndoRedoEntityType)
        {
			object[] results = this.Invoke("Create", new object[] {__Id, __UndoRedoEntityType});
			return ((UndoRedoGroup)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.Int64 __Id, System.String __UndoRedoEntityType)
        {
			this.Invoke("Delete", new object[] {__Id, __UndoRedoEntityType});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(UndoRedoGroup _UndoRedoGroup)
        {
			this.Invoke("UpdateObject", new object[] {_UndoRedoGroup});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(UndoRedoGroup _UndoRedoGroup)
        {
			this.Invoke("CreateObject", new object[] {_UndoRedoGroup});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(UndoRedoGroup _UndoRedoGroup)
        {
			this.Invoke("DeleteObject", new object[] {_UndoRedoGroup});
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
		public UndoRedoGroupCollection SearchByEntityType(System.String UndoRedoEntityType ) {
			object[] results = this.Invoke("SearchByEntityType", new object[] {UndoRedoEntityType});
			return ((UndoRedoGroupCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByEntityTypePaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public UndoRedoGroupCollection SearchByEntityTypePaged(System.String UndoRedoEntityType , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("SearchByEntityTypePaged", new object[] {UndoRedoEntityType,PagingStart,PagingCount});
			return ((UndoRedoGroupCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByEntityTypeCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByEntityTypeCount(System.String UndoRedoEntityType ) {
			object[] results = this.Invoke("SearchByEntityTypeCount", new object[] {UndoRedoEntityType});
			return ((long)(results[0]));
		}

	}
	
	
} // namespace Web

} // namespace Platform.Module.UndoRedo.Services.Packages
