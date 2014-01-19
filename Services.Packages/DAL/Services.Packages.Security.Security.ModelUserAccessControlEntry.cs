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
    /// Defines the contract for the ModelUserAccessControlEntry class
    /// </summary>
    [ComVisible(true)]
    [Guid("c3958d6e-4181-2f38-60aa-1bbe90ababa5")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IModelUserAccessControlEntry
	{
		bool Exists { get; }
		System.String Descriptor { get; set; }
		System.String UserName { get; set; }
		System.Boolean Allow { get; set; }
		System.String Name { get; set; }
		Services.Packages.Security.Security.ModelUserAccessControlList ACL { get; set; }

		void Read(System.String __Descriptor, System.String __UserName, System.String __Name);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(ModelUserAccessControlEntry _object);
		void CopyWithKeysTo(ModelUserAccessControlEntry _object);
		void CopyFrom(ModelUserAccessControlEntry _object);
		void CopyTo(ModelUserAccessControlEntry _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.Security.Security.ModelUserAccessControlEntry type.
    /// </summary>
    [ComVisible(true)]
    [Guid("458c3acc-f34b-11b9-5366-5c9cb792dbd4")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IModelUserAccessControlEntryService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(ModelUserAccessControlEntry _ModelUserAccessControlEntry);
		[OperationContract]
        ModelUserAccessControlEntry Read(System.String __Descriptor, System.String __UserName, System.String __Name);
        [OperationContract]
        ModelUserAccessControlEntry Reload(ModelUserAccessControlEntry _ModelUserAccessControlEntry);
        [OperationContract]
        ModelUserAccessControlEntry Create(System.String __Descriptor, System.String __UserName, System.String __Name);
        [OperationContract]
        void Delete(System.String __Descriptor, System.String __UserName, System.String __Name);
        [OperationContract]
        void UpdateObject(ModelUserAccessControlEntry _ModelUserAccessControlEntry);
        [OperationContract]
        void CreateObject(ModelUserAccessControlEntry _ModelUserAccessControlEntry);
        [OperationContract]
        void DeleteObject(ModelUserAccessControlEntry _ModelUserAccessControlEntry);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		ModelUserAccessControlEntryCollection GetByACL(Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList);
		[OperationContract]
		ModelUserAccessControlEntryCollection GetByACLPaged(Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByACLCount(Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList);
		[OperationContract]
		Services.Packages.Security.Security.ModelUserAccessControlList GetACL(ModelUserAccessControlEntry _ModelUserAccessControlEntry);
		[OperationContract]
		void SetACL(ModelUserAccessControlEntry _ModelUserAccessControlEntry, Services.Packages.Security.Security.ModelUserAccessControlList _ACL);
		[OperationContract]
		ModelUserAccessControlEntryCollection GetEntries(System.String Descriptor, Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList);
		[OperationContract]
		ModelUserAccessControlEntryCollection GetEntriesPaged(System.String Descriptor, Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList, long PagingStart, long PagingCount);
		[OperationContract]
		long GetEntriesCount(System.String Descriptor, Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.Security.Security.ModelUserAccessControlEntry type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("2457dce3-1dd1-9618-0091-94b0cb152892")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class ModelUserAccessControlEntryService : IModelUserAccessControlEntryService
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
        public bool Exists(ModelUserAccessControlEntry _ModelUserAccessControlEntry)
        {
			return _ModelUserAccessControlEntry.Exists;
        }
		
		[WebMethod]
		public ModelUserAccessControlEntry Read(System.String __Descriptor, System.String __UserName, System.String __Name)
		{
			return new ModelUserAccessControlEntry(__Descriptor, __UserName, __Name);
		}
		
		[WebMethod]
        public ModelUserAccessControlEntry Reload(ModelUserAccessControlEntry _ModelUserAccessControlEntry)
        {
			_ModelUserAccessControlEntry.Reload();
			return _ModelUserAccessControlEntry;
        }
		
		[WebMethod]
        public ModelUserAccessControlEntry Create(System.String __Descriptor, System.String __UserName, System.String __Name)
        {
			return ModelUserAccessControlEntry.CreateModelUserAccessControlEntry(__Descriptor, __UserName, __Name);
        }
        
        [WebMethod]
        public void Delete(System.String __Descriptor, System.String __UserName, System.String __Name)
        {
			ModelUserAccessControlEntry.DeleteModelUserAccessControlEntry(__Descriptor, __UserName, __Name);
        }
        
        [WebMethod]
        public void UpdateObject(ModelUserAccessControlEntry _ModelUserAccessControlEntry)
        {
			_ModelUserAccessControlEntry.Update();
        }
		
		[WebMethod]
        public void CreateObject(ModelUserAccessControlEntry _ModelUserAccessControlEntry)
        {
			_ModelUserAccessControlEntry.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ModelUserAccessControlEntry _ModelUserAccessControlEntry)
        {
			_ModelUserAccessControlEntry.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			ModelUserAccessControlEntry.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			ModelUserAccessControlEntry.Redo();
        }
		[WebMethod]
		public ModelUserAccessControlEntryCollection GetByACL(Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList)
		{
			return ModelUserAccessControlEntry.GetByACL( _ModelUserAccessControlList);
		}
		[WebMethod]
		public ModelUserAccessControlEntryCollection GetByACLPaged(Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList, long PagingStart, long PagingCount)
		{
			return ModelUserAccessControlEntry.GetByACLPaged( _ModelUserAccessControlList, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByACLCount(Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList)
		{
			return ModelUserAccessControlEntry.GetByACLCount( _ModelUserAccessControlList);
		}
		[WebMethod]
		public Services.Packages.Security.Security.ModelUserAccessControlList GetACL(ModelUserAccessControlEntry _ModelUserAccessControlEntry)
		{
			_ModelUserAccessControlEntry.Reload();
			return _ModelUserAccessControlEntry.ACL;
		}
		[WebMethod]
		public void SetACL(ModelUserAccessControlEntry _ModelUserAccessControlEntry, Services.Packages.Security.Security.ModelUserAccessControlList _ACL)
		{
			_ModelUserAccessControlEntry.Reload();
			_ModelUserAccessControlEntry.ACL = _ACL;
			_ModelUserAccessControlEntry.Update();
		}
		[WebMethod]
		public ModelUserAccessControlEntryCollection GetEntries(System.String Descriptor, Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList)
		{
			return ModelUserAccessControlEntry.GetEntries(Descriptor,  _ModelUserAccessControlList);
		}
		[WebMethod]
		public ModelUserAccessControlEntryCollection GetEntriesPaged(System.String Descriptor, Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList, long PagingStart, long PagingCount)
		{
			return ModelUserAccessControlEntry.GetEntriesPaged(Descriptor,  _ModelUserAccessControlList, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetEntriesCount(System.String Descriptor, Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList)
		{
			return ModelUserAccessControlEntry.GetEntriesCount(Descriptor,  _ModelUserAccessControlList);
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.Security.Security.ModelUserAccessControlEntry model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("0977b39e-4165-7a6e-d383-701be49c78ce")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class ModelUserAccessControlEntry : IModelUserAccessControlEntry, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<IModelUserAccessControlEntryService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<IModelUserAccessControlEntryService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<IModelUserAccessControlEntryService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.Security.ModelUserAccessControlEntry"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.Security.ModelUserAccessControlEntry"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.Security.Security.ModelUserAccessControlEntry.ProviderType");
				
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


		System.String _Descriptor;
		
		// Key member
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String Descriptor
		{
            get
            {
                return _Descriptor;
            }
            set
            {
				if (_Descriptor != value)
					__hasBeenReadOnce = false;
                _Descriptor = value;
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

		System.Boolean _Allow;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Boolean Allow
		{
            get
            {
                return _Allow;
            }
            set
            {
                _Allow = value;
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

		bool _ACLIsLoaded = false;
		Services.Packages.Security.Security.ModelUserAccessControlList _ACL;
		
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.Security.ModelUserAccessControlList ACL
		{
            get
            {
				if (!_ACLIsLoaded)
				{
					_ACL = new Services.Packages.Security.Security.ModelUserAccessControlList(_UserName, _Name);
					if (_ACL.Exists)
						_ACLIsLoaded = true;
					else _ACL = null;
				}
                return _ACL;
            }
            set
            {
                _ACL = value;
                _ACLIsLoaded = true;
                if (_ACL != null)
                {
					if (_ACL.Exists)
					{
						_UserName = _ACL.UserName;
						_Name = _ACL.Name;
						
					}
					else
					{
						_ACL = null;
					}
				}
            }
		}
		
		public static Services.Packages.Security.Security.ModelUserAccessControlList GetACL(ModelUserAccessControlEntry _ModelUserAccessControlEntry)
		{
			return _ModelUserAccessControlEntry.ACL;
		}

		public static ModelUserAccessControlEntryCollection GetByACL(Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList)
        {
			ModelUserAccessControlEntryCollection _ModelUserAccessControlEntryCollection = new ModelUserAccessControlEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsAcCoEnGetByACL", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_UserName;
				if (_ModelUserAccessControlList != null) {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_ModelUserAccessControlList.UserName);
				} else {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", DBNull.Value);
				}
				command.Parameters.Add(param_UserName);
				DbParameter param_Name;
				if (_ModelUserAccessControlList != null) {
				param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_ModelUserAccessControlList.Name);
				} else {
				param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", DBNull.Value);
				}
				command.Parameters.Add(param_Name);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					ModelUserAccessControlEntry o = new ModelUserAccessControlEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Name"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
                    _ModelUserAccessControlEntryCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ModelUserAccessControlEntryCollection;
        }
        
        public static ModelUserAccessControlEntryCollection GetByACLPaged(Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList, long PagingStart, long PagingCount)
        {
			ModelUserAccessControlEntryCollection _ModelUserAccessControlEntryCollection = new ModelUserAccessControlEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsAcCoEnGetByACLPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_UserName;
				if (_ModelUserAccessControlList != null) {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_ModelUserAccessControlList.UserName);
				} else {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", DBNull.Value);
				}
				command.Parameters.Add(param_UserName);
				DbParameter param_Name;
				if (_ModelUserAccessControlList != null) {
				param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_ModelUserAccessControlList.Name);
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
					ModelUserAccessControlEntry o = new ModelUserAccessControlEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Name"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
                    _ModelUserAccessControlEntryCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ModelUserAccessControlEntryCollection;
        }
        
        public static long GetByACLCount(Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsAcCoEnGetByACLCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_UserName;
				if (_ModelUserAccessControlList != null) {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_ModelUserAccessControlList.UserName);
				} else {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", DBNull.Value);
				}
				command.Parameters.Add(param_UserName);
				DbParameter param_Name;
				if (_ModelUserAccessControlList != null) {
				param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_ModelUserAccessControlList.Name);
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

		public static ModelUserAccessControlEntryCollection GetEntries(System.String _Descriptor, Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList)
        {
			ModelUserAccessControlEntryCollection _ModelUserAccessControlEntryCollection = new ModelUserAccessControlEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsAcCoEnGeEn", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Descriptor = ClassConnectionProvider.Escape(_Descriptor);
				
                
                DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), -1);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_ModelUserAccessControlList_UserName;
				if (_ModelUserAccessControlList != null) {
				param_ModelUserAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("MoUsAcCoLiUsNa", typeof(System.String), 128);
				param_ModelUserAccessControlList_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_ModelUserAccessControlList.UserName);
				} else {
				param_ModelUserAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("MoUsAcCoLiUsNa", DBNull.Value);
				}
				command.Parameters.Add(param_ModelUserAccessControlList_UserName);
				DbParameter param_ModelUserAccessControlList_Name;
				if (_ModelUserAccessControlList != null) {
				param_ModelUserAccessControlList_Name = ClassConnectionProvider.GetDatabaseParameter("MoUsAcCoLiNa", typeof(System.String), 128);
				param_ModelUserAccessControlList_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_ModelUserAccessControlList.Name);
				} else {
				param_ModelUserAccessControlList_Name = ClassConnectionProvider.GetDatabaseParameter("MoUsAcCoLiNa", DBNull.Value);
				}
				command.Parameters.Add(param_ModelUserAccessControlList_Name);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					ModelUserAccessControlEntry o = new ModelUserAccessControlEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Name"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
                    _ModelUserAccessControlEntryCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ModelUserAccessControlEntryCollection;
        }
        
        public static ModelUserAccessControlEntryCollection GetEntriesPaged(System.String _Descriptor, Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList, long PagingStart, long PagingCount)
        {
			ModelUserAccessControlEntryCollection _ModelUserAccessControlEntryCollection = new ModelUserAccessControlEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsAcCoEnGeEnPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Descriptor = ClassConnectionProvider.Escape(_Descriptor);
				
                
                DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), -1);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_ModelUserAccessControlList_UserName;
				if (_ModelUserAccessControlList != null) {
				param_ModelUserAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("MoUsAcCoLiUsNa", typeof(System.String), 128);
				param_ModelUserAccessControlList_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_ModelUserAccessControlList.UserName);
				} else {
				param_ModelUserAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("MoUsAcCoLiUsNa", DBNull.Value);
				}
				command.Parameters.Add(param_ModelUserAccessControlList_UserName);
				DbParameter param_ModelUserAccessControlList_Name;
				if (_ModelUserAccessControlList != null) {
				param_ModelUserAccessControlList_Name = ClassConnectionProvider.GetDatabaseParameter("MoUsAcCoLiNa", typeof(System.String), 128);
				param_ModelUserAccessControlList_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_ModelUserAccessControlList.Name);
				} else {
				param_ModelUserAccessControlList_Name = ClassConnectionProvider.GetDatabaseParameter("MoUsAcCoLiNa", DBNull.Value);
				}
				command.Parameters.Add(param_ModelUserAccessControlList_Name);
				
                
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
					ModelUserAccessControlEntry o = new ModelUserAccessControlEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Name"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
                    _ModelUserAccessControlEntryCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ModelUserAccessControlEntryCollection;
        }
        
        public static long GetEntriesCount(System.String _Descriptor, Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("MoUsAcCoEnGeEnCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Descriptor = ClassConnectionProvider.Escape(_Descriptor);
				
                
                DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), -1);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_ModelUserAccessControlList_UserName;
				if (_ModelUserAccessControlList != null) {
				param_ModelUserAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("MoUsAcCoLiUsNa", typeof(System.String), 128);
				param_ModelUserAccessControlList_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_ModelUserAccessControlList.UserName);
				} else {
				param_ModelUserAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("MoUsAcCoLiUsNa", DBNull.Value);
				}
				command.Parameters.Add(param_ModelUserAccessControlList_UserName);
				DbParameter param_ModelUserAccessControlList_Name;
				if (_ModelUserAccessControlList != null) {
				param_ModelUserAccessControlList_Name = ClassConnectionProvider.GetDatabaseParameter("MoUsAcCoLiNa", typeof(System.String), 128);
				param_ModelUserAccessControlList_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_ModelUserAccessControlList.Name);
				} else {
				param_ModelUserAccessControlList_Name = ClassConnectionProvider.GetDatabaseParameter("MoUsAcCoLiNa", DBNull.Value);
				}
				command.Parameters.Add(param_ModelUserAccessControlList_Name);
				
                
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
        
        public ModelUserAccessControlEntry() {}
        
        public ModelUserAccessControlEntry(System.String __Descriptor, System.String __UserName, System.String __Name)
        {
			Read(__Descriptor, __UserName, __Name);
        }
        
        #region CRUD
        
        void Exist()
        {
			// sql read - should be changed to specific exist implementation
			using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
			{
				dbconn.Open();
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsAcCoEnRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
				DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), 128);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
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
        
        public void Read(System.String __Descriptor, System.String __UserName, System.String __Name)
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].Read(__Descriptor, __UserName, __Name);
					return;
				}

                // Get a service via an algorithm
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "MoUsAcCoEn");
                // Perfect for read operations, but not for write
                // scalingServices[nextIndex].Read(__Descriptor, __UserName, __Name);
				// return;

				throw new NotImplementedException();
            }

            try
            {
				// sql read
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsAcCoEnRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					_Descriptor = __Descriptor;
				DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), 128);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(__Descriptor);
				command.Parameters.Add(param_Descriptor);
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
						_Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				_ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Name"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
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
                            failoverServices[n].Read(__Descriptor, __UserName, __Name);
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "MoUsAcCoEn");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsAcCoEnRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), 128);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
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
						_Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				_ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Name"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
                    
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsAcCoEnCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), 128);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_Allow = ClassConnectionProvider.GetDatabaseParameter("Allow", typeof(System.Boolean), -1);
				param_Allow.Value = ClassConnectionProvider.FromValueToSqlModelType(_Allow);
				command.Parameters.Add(param_Allow);
				DbParameter param_ACL_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_ACL_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				if (_ACL == null && _ACLIsLoaded == true) param_ACL_UserName.Value = DBNull.Value;
				command.Parameters.Add(param_ACL_UserName);
				DbParameter param_ACL_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_ACL_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				if (_ACL == null && _ACLIsLoaded == true) param_ACL_Name.Value = DBNull.Value;
				command.Parameters.Add(param_ACL_Name);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				_ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Name"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				
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
        
        static public ModelUserAccessControlEntry CreateModelUserAccessControlEntry(System.String __Descriptor, System.String __UserName, System.String __Name)
        {
            ModelUserAccessControlEntry o = new ModelUserAccessControlEntry(__Descriptor, __UserName, __Name);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsAcCoEnUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), 128);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_Allow = ClassConnectionProvider.GetDatabaseParameter("Allow", typeof(System.Boolean), -1);
				param_Allow.Value = ClassConnectionProvider.FromValueToSqlModelType(_Allow);
				command.Parameters.Add(param_Allow);
				DbParameter param_ACLHasChanged = ClassConnectionProvider.GetDatabaseParameter("ACLHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_ACLIsLoaded));
				command.Parameters.Add(param_ACLHasChanged);
				DbParameter param_ACL_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_ACL_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				if (_ACL == null && _ACLIsLoaded == true) param_ACL_UserName.Value = DBNull.Value;
				command.Parameters.Add(param_ACL_UserName);
				DbParameter param_ACL_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 128);
				param_ACL_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				if (_ACL == null && _ACLIsLoaded == true) param_ACL_Name.Value = DBNull.Value;
				command.Parameters.Add(param_ACL_Name);
				

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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("MoUsAcCoEnDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), 128);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
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
        
        static public void DeleteModelUserAccessControlEntry(System.String __Descriptor, System.String __UserName, System.String __Name)
        {
            ModelUserAccessControlEntry o = new ModelUserAccessControlEntry(__Descriptor, __UserName, __Name);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(ModelUserAccessControlEntry _object)
        {
			_ACL = null;
			_ACLIsLoaded = false;
			_Descriptor = _object._Descriptor;
			_UserName = _object._UserName;
			_Allow = _object._Allow;
			_Name = _object._Name;
			
        }
        
        public void CopyWithKeysTo(ModelUserAccessControlEntry _object)
        {
			_object._ACL = null;
			_object._ACLIsLoaded = false;
			_object._Descriptor = _Descriptor;
			_object._UserName = _UserName;
			_object._Allow = _Allow;
			_object._Name = _Name;
			
        }
        
        static public void CopyWithKeysObject(ModelUserAccessControlEntry _objectFrom, ModelUserAccessControlEntry _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(ModelUserAccessControlEntry _object)
        {
			_ACL = null;
			_ACLIsLoaded = false;
			_Allow = _object._Allow;
			
        }
        
        public void CopyTo(ModelUserAccessControlEntry _object)
        {
			_object._ACL = null;
			_object._ACLIsLoaded = false;
			_object._Allow = _Allow;
			
        }
        
        static public void CopyObject(ModelUserAccessControlEntry _objectFrom, ModelUserAccessControlEntry _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(ModelUserAccessControlEntry).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(ModelUserAccessControlEntry).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(ModelUserAccessControlEntry _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			ModelUserAccessControlEntryUndoRedoCollection allUndidAndNotRedoneEntries = ModelUserAccessControlEntryUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			ModelUserAccessControlEntryUndoRedo _urobject = new ModelUserAccessControlEntryUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.ACL_UserName = _object._ACL_UserName;
			_urobject.ACL_Name = _object._ACL_Name;
			_urobject.Descriptor = _object._Descriptor;
			_urobject.UserName = _object._UserName;
			_urobject.Allow = _object._Allow;
			_urobject.Name = _object._Name;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(ModelUserAccessControlEntry).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = ModelUserAccessControlEntryUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				ModelUserAccessControlEntryUndoRedoCollection allOldUndoEntries = ModelUserAccessControlEntryUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			ModelUserAccessControlEntryUndoRedoCollection firstUndoEntries = ModelUserAccessControlEntryUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			ModelUserAccessControlEntryUndoRedo _urobject = firstUndoEntries[0];
			
			ModelUserAccessControlEntry _object = new ModelUserAccessControlEntry();
			_object._ACL = null;
			_object._ACLIsLoaded = false;
			_object._ACL_UserName = _urobject.ACL_UserName;
			_object._ACL = null;
			_object._ACLIsLoaded = false;
			_object._ACL_Name = _urobject.ACL_Name;
			_object._Descriptor = _urobject.Descriptor;
			_object._UserName = _urobject.UserName;
			_object._Allow = _urobject.Allow;
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
			ModelUserAccessControlEntryUndoRedoCollection firstEntryToRedoEntries = ModelUserAccessControlEntryUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			ModelUserAccessControlEntryUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			ModelUserAccessControlEntry _object = new ModelUserAccessControlEntry();
			_object._ACL = null;
			_object._ACLIsLoaded = false;
			_object._ACL_UserName = _urobject.ACL_UserName;
			_object._ACL = null;
			_object._ACLIsLoaded = false;
			_object._ACL_Name = _urobject.ACL_Name;
			_object._Descriptor = _urobject.Descriptor;
			_object._UserName = _urobject.UserName;
			_object._Allow = _urobject.Allow;
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
    /// Defines the contract for the ModelUserAccessControlEntryCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("b4da46cf-8753-afd4-21f5-44b95f09453e")]
    public interface IModelUserAccessControlEntryCollection : IEnumerable<ModelUserAccessControlEntry>
    {
        int IndexOf(ModelUserAccessControlEntry item);
        void Insert(int index, ModelUserAccessControlEntry item);
        void RemoveAt(int index);
        ModelUserAccessControlEntry this[int index] { get; set; }
        void Add(ModelUserAccessControlEntry item);
        void Clear();
        bool Contains(ModelUserAccessControlEntry item);
        void CopyTo(ModelUserAccessControlEntry[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(ModelUserAccessControlEntry item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.Security.Security.ModelUserAccessControlEntry
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("03fdc93d-d11a-a26e-6ddc-504dacfcb164")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class ModelUserAccessControlEntryCollection : IModelUserAccessControlEntryCollection, IList<ModelUserAccessControlEntry>, IHierarchicalEnumerable
    {
        List<ModelUserAccessControlEntry> _list = new List<ModelUserAccessControlEntry>();
        
        public static implicit operator List<ModelUserAccessControlEntry>(ModelUserAccessControlEntryCollection collection)
        {
            return collection._list;
        }

        #region IList<ModelUserAccessControlEntry> Members

        public int IndexOf(ModelUserAccessControlEntry item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, ModelUserAccessControlEntry item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public ModelUserAccessControlEntry this[int index]
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

        #region ICollection<ModelUserAccessControlEntry> Members

        public void Add(ModelUserAccessControlEntry item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(ModelUserAccessControlEntry item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(ModelUserAccessControlEntry[] array, int arrayIndex)
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

        public bool Remove(ModelUserAccessControlEntry item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<ModelUserAccessControlEntry> Members

        public IEnumerator<ModelUserAccessControlEntry> GetEnumerator()
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
	/// that share Services.Packages.Security.Security.ModelUserAccessControlEntry objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Security.Security.Web.ModelUserAccessControlEntryWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class ModelUserAccessControlEntryWebService : WebService, IModelUserAccessControlEntryService
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
        public bool Exists(ModelUserAccessControlEntry _ModelUserAccessControlEntry)
        {
			return _ModelUserAccessControlEntry.Exists;
        }
		
		[WebMethod]
		public ModelUserAccessControlEntry Read(System.String __Descriptor, System.String __UserName, System.String __Name)
		{
			return new ModelUserAccessControlEntry(__Descriptor, __UserName, __Name);
		}
		
		[WebMethod]
        public ModelUserAccessControlEntry Reload(ModelUserAccessControlEntry _ModelUserAccessControlEntry)
        {
			_ModelUserAccessControlEntry.Reload();
			return _ModelUserAccessControlEntry;
        }
		
		[WebMethod]
        public ModelUserAccessControlEntry Create(System.String __Descriptor, System.String __UserName, System.String __Name)
        {
			return ModelUserAccessControlEntry.CreateModelUserAccessControlEntry(__Descriptor, __UserName, __Name);
        }
        
        [WebMethod]
        public void Delete(System.String __Descriptor, System.String __UserName, System.String __Name)
        {
			ModelUserAccessControlEntry.DeleteModelUserAccessControlEntry(__Descriptor, __UserName, __Name);
        }
        
        [WebMethod]
        public void UpdateObject(ModelUserAccessControlEntry _ModelUserAccessControlEntry)
        {
			_ModelUserAccessControlEntry.Update();
        }
		
		[WebMethod]
        public void CreateObject(ModelUserAccessControlEntry _ModelUserAccessControlEntry)
        {
			_ModelUserAccessControlEntry.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ModelUserAccessControlEntry _ModelUserAccessControlEntry)
        {
			_ModelUserAccessControlEntry.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			ModelUserAccessControlEntry.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			ModelUserAccessControlEntry.Redo();
        }
		[WebMethod]
		public ModelUserAccessControlEntryCollection GetByACL(Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList)
		{
			return ModelUserAccessControlEntry.GetByACL( _ModelUserAccessControlList);
		}
		[WebMethod]
		public ModelUserAccessControlEntryCollection GetByACLPaged(Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList, long PagingStart, long PagingCount)
		{
			return ModelUserAccessControlEntry.GetByACLPaged( _ModelUserAccessControlList, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByACLCount(Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList)
		{
			return ModelUserAccessControlEntry.GetByACLCount( _ModelUserAccessControlList);
		}
		[WebMethod]
		public Services.Packages.Security.Security.ModelUserAccessControlList GetACL(ModelUserAccessControlEntry _ModelUserAccessControlEntry)
		{
			_ModelUserAccessControlEntry.Reload();
			return _ModelUserAccessControlEntry.ACL;
		}
		[WebMethod]
		public void SetACL(ModelUserAccessControlEntry _ModelUserAccessControlEntry, Services.Packages.Security.Security.ModelUserAccessControlList _ACL)
		{
			_ModelUserAccessControlEntry.Reload();
			_ModelUserAccessControlEntry.ACL = _ACL;
			_ModelUserAccessControlEntry.Update();
		}
		[WebMethod]
		public ModelUserAccessControlEntryCollection GetEntries(System.String Descriptor, Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList)
		{
			return ModelUserAccessControlEntry.GetEntries(Descriptor,  _ModelUserAccessControlList);
		}
		[WebMethod]
		public ModelUserAccessControlEntryCollection GetEntriesPaged(System.String Descriptor, Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList, long PagingStart, long PagingCount)
		{
			return ModelUserAccessControlEntry.GetEntriesPaged(Descriptor,  _ModelUserAccessControlList, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetEntriesCount(System.String Descriptor, Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList)
		{
			return ModelUserAccessControlEntry.GetEntriesCount(Descriptor,  _ModelUserAccessControlList);
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="ModelUserAccessControlEntryWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("84e0c619-743a-173f-dfc8-e870fdb41bca")]
    sealed public class ModelUserAccessControlEntryWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IModelUserAccessControlEntryService
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
		public ModelUserAccessControlEntryWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public ModelUserAccessControlEntryWebServiceClient()
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
		public bool Exists(ModelUserAccessControlEntry _ModelUserAccessControlEntry)
        {
			object[] results = this.Invoke("Exists", new object[] {_ModelUserAccessControlEntry});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserAccessControlEntry Read(System.String __Descriptor, System.String __UserName, System.String __Name)
		{
			object[] results = this.Invoke("Read", new object[] {__Descriptor, __UserName, __Name});
			return ((ModelUserAccessControlEntry)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserAccessControlEntry Reload(ModelUserAccessControlEntry _ModelUserAccessControlEntry)
        {
			object[] results = this.Invoke("Reload", new object[] {_ModelUserAccessControlEntry});
			return ((ModelUserAccessControlEntry)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserAccessControlEntry Create(System.String __Descriptor, System.String __UserName, System.String __Name)
        {
			object[] results = this.Invoke("Create", new object[] {__Descriptor, __UserName, __Name});
			return ((ModelUserAccessControlEntry)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __Descriptor, System.String __UserName, System.String __Name)
        {
			this.Invoke("Delete", new object[] {__Descriptor, __UserName, __Name});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(ModelUserAccessControlEntry _ModelUserAccessControlEntry)
        {
			this.Invoke("UpdateObject", new object[] {_ModelUserAccessControlEntry});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(ModelUserAccessControlEntry _ModelUserAccessControlEntry)
        {
			this.Invoke("CreateObject", new object[] {_ModelUserAccessControlEntry});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(ModelUserAccessControlEntry _ModelUserAccessControlEntry)
        {
			this.Invoke("DeleteObject", new object[] {_ModelUserAccessControlEntry});
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
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByACL", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserAccessControlEntryCollection GetByACL(Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList) {
			object[] results = this.Invoke("GetByACL", new object[] {_ModelUserAccessControlList});
			return ((ModelUserAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByACLPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserAccessControlEntryCollection GetByACLPaged(Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByACLPaged", new object[] {_ModelUserAccessControlList,PagingStart,PagingCount});
			return ((ModelUserAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByACLCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByACLCount(Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList) {
			object[] results = this.Invoke("GetByACLCount", new object[] {_ModelUserAccessControlList});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACL", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.Security.ModelUserAccessControlList GetACL(ModelUserAccessControlEntry _ModelUserAccessControlEntry)
		{
			object[] results = this.Invoke("GetACL", new object[] {_ModelUserAccessControlEntry});
			return ((Services.Packages.Security.Security.ModelUserAccessControlList)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACL", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACL(ModelUserAccessControlEntry _ModelUserAccessControlEntry, Services.Packages.Security.Security.ModelUserAccessControlList _ACL)
		{
			this.Invoke("GetACL", new object[] {_ModelUserAccessControlEntry});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetEntries", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserAccessControlEntryCollection GetEntries(System.String Descriptor, Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList) {
			object[] results = this.Invoke("GetEntries", new object[] {Descriptor, _ModelUserAccessControlList});
			return ((ModelUserAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetEntriesPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ModelUserAccessControlEntryCollection GetEntriesPaged(System.String Descriptor, Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetEntriesPaged", new object[] {Descriptor, _ModelUserAccessControlList,PagingStart,PagingCount});
			return ((ModelUserAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetEntriesCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetEntriesCount(System.String Descriptor, Services.Packages.Security.Security.ModelUserAccessControlList _ModelUserAccessControlList) {
			object[] results = this.Invoke("GetEntriesCount", new object[] {Descriptor, _ModelUserAccessControlList});
			return ((long)(results[0]));
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages.Security.Security
