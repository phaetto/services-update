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
    /// Defines the contract for the PackageAccessControlEntry class
    /// </summary>
    [ComVisible(true)]
    [Guid("e6099079-327b-23c3-0d2a-5cfa8a8084eb")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IPackageAccessControlEntry
	{
		bool Exists { get; }
		System.String Descriptor { get; set; }
		System.String UserName { get; set; }
		System.Boolean Allow { get; set; }
		System.Int32 Id { get; set; }
		Services.Packages.Security.PackageAccessControlList ACL { get; set; }

		void Read(System.String __Descriptor, System.String __UserName, System.Int32 __Id);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(PackageAccessControlEntry _object);
		void CopyWithKeysTo(PackageAccessControlEntry _object);
		void CopyFrom(PackageAccessControlEntry _object);
		void CopyTo(PackageAccessControlEntry _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.Security.PackageAccessControlEntry type.
    /// </summary>
    [ComVisible(true)]
    [Guid("aaff6967-29b5-8243-869a-c74f642bf39e")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IPackageAccessControlEntryService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(PackageAccessControlEntry _PackageAccessControlEntry);
		[OperationContract]
        PackageAccessControlEntry Read(System.String __Descriptor, System.String __UserName, System.Int32 __Id);
        [OperationContract]
        PackageAccessControlEntry Reload(PackageAccessControlEntry _PackageAccessControlEntry);
        [OperationContract]
        PackageAccessControlEntry Create(System.String __Descriptor, System.String __UserName, System.Int32 __Id);
        [OperationContract]
        void Delete(System.String __Descriptor, System.String __UserName, System.Int32 __Id);
        [OperationContract]
        void UpdateObject(PackageAccessControlEntry _PackageAccessControlEntry);
        [OperationContract]
        void CreateObject(PackageAccessControlEntry _PackageAccessControlEntry);
        [OperationContract]
        void DeleteObject(PackageAccessControlEntry _PackageAccessControlEntry);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		PackageAccessControlEntryCollection GetByACL(Services.Packages.Security.PackageAccessControlList _PackageAccessControlList);
		[OperationContract]
		PackageAccessControlEntryCollection GetByACLPaged(Services.Packages.Security.PackageAccessControlList _PackageAccessControlList, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByACLCount(Services.Packages.Security.PackageAccessControlList _PackageAccessControlList);
		[OperationContract]
		Services.Packages.Security.PackageAccessControlList GetACL(PackageAccessControlEntry _PackageAccessControlEntry);
		[OperationContract]
		void SetACL(PackageAccessControlEntry _PackageAccessControlEntry, Services.Packages.Security.PackageAccessControlList _ACL);
		[OperationContract]
		PackageAccessControlEntryCollection GetEntries(System.String Descriptor, Services.Packages.Security.PackageAccessControlList _PackageAccessControlList);
		[OperationContract]
		PackageAccessControlEntryCollection GetEntriesPaged(System.String Descriptor, Services.Packages.Security.PackageAccessControlList _PackageAccessControlList, long PagingStart, long PagingCount);
		[OperationContract]
		long GetEntriesCount(System.String Descriptor, Services.Packages.Security.PackageAccessControlList _PackageAccessControlList);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.Security.PackageAccessControlEntry type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("8b7122f3-5e0f-351b-bb8a-3261d672eed5")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class PackageAccessControlEntryService : IPackageAccessControlEntryService
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
        public bool Exists(PackageAccessControlEntry _PackageAccessControlEntry)
        {
			return _PackageAccessControlEntry.Exists;
        }
		
		[WebMethod]
		public PackageAccessControlEntry Read(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
		{
			return new PackageAccessControlEntry(__Descriptor, __UserName, __Id);
		}
		
		[WebMethod]
        public PackageAccessControlEntry Reload(PackageAccessControlEntry _PackageAccessControlEntry)
        {
			_PackageAccessControlEntry.Reload();
			return _PackageAccessControlEntry;
        }
		
		[WebMethod]
        public PackageAccessControlEntry Create(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
        {
			return PackageAccessControlEntry.CreatePackageAccessControlEntry(__Descriptor, __UserName, __Id);
        }
        
        [WebMethod]
        public void Delete(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
        {
			PackageAccessControlEntry.DeletePackageAccessControlEntry(__Descriptor, __UserName, __Id);
        }
        
        [WebMethod]
        public void UpdateObject(PackageAccessControlEntry _PackageAccessControlEntry)
        {
			_PackageAccessControlEntry.Update();
        }
		
		[WebMethod]
        public void CreateObject(PackageAccessControlEntry _PackageAccessControlEntry)
        {
			_PackageAccessControlEntry.Create();
        }
        
        [WebMethod]
        public void DeleteObject(PackageAccessControlEntry _PackageAccessControlEntry)
        {
			_PackageAccessControlEntry.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			PackageAccessControlEntry.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			PackageAccessControlEntry.Redo();
        }
		[WebMethod]
		public PackageAccessControlEntryCollection GetByACL(Services.Packages.Security.PackageAccessControlList _PackageAccessControlList)
		{
			return PackageAccessControlEntry.GetByACL( _PackageAccessControlList);
		}
		[WebMethod]
		public PackageAccessControlEntryCollection GetByACLPaged(Services.Packages.Security.PackageAccessControlList _PackageAccessControlList, long PagingStart, long PagingCount)
		{
			return PackageAccessControlEntry.GetByACLPaged( _PackageAccessControlList, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByACLCount(Services.Packages.Security.PackageAccessControlList _PackageAccessControlList)
		{
			return PackageAccessControlEntry.GetByACLCount( _PackageAccessControlList);
		}
		[WebMethod]
		public Services.Packages.Security.PackageAccessControlList GetACL(PackageAccessControlEntry _PackageAccessControlEntry)
		{
			_PackageAccessControlEntry.Reload();
			return _PackageAccessControlEntry.ACL;
		}
		[WebMethod]
		public void SetACL(PackageAccessControlEntry _PackageAccessControlEntry, Services.Packages.Security.PackageAccessControlList _ACL)
		{
			_PackageAccessControlEntry.Reload();
			_PackageAccessControlEntry.ACL = _ACL;
			_PackageAccessControlEntry.Update();
		}
		[WebMethod]
		public PackageAccessControlEntryCollection GetEntries(System.String Descriptor, Services.Packages.Security.PackageAccessControlList _PackageAccessControlList)
		{
			return PackageAccessControlEntry.GetEntries(Descriptor,  _PackageAccessControlList);
		}
		[WebMethod]
		public PackageAccessControlEntryCollection GetEntriesPaged(System.String Descriptor, Services.Packages.Security.PackageAccessControlList _PackageAccessControlList, long PagingStart, long PagingCount)
		{
			return PackageAccessControlEntry.GetEntriesPaged(Descriptor,  _PackageAccessControlList, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetEntriesCount(System.String Descriptor, Services.Packages.Security.PackageAccessControlList _PackageAccessControlList)
		{
			return PackageAccessControlEntry.GetEntriesCount(Descriptor,  _PackageAccessControlList);
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.Security.PackageAccessControlEntry model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("3ac2958d-cfee-4f13-4d87-60e06b74bee1")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class PackageAccessControlEntry : IPackageAccessControlEntry, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<IPackageAccessControlEntryService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<IPackageAccessControlEntryService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<IPackageAccessControlEntryService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.PackageAccessControlEntry"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.PackageAccessControlEntry"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.Security.PackageAccessControlEntry.ProviderType");
				
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

		System.Int32 _Id;
		
		// Key member
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
				if (_Id != value)
					__hasBeenReadOnce = false;
                _Id = value;
            }
		}

		bool _ACLIsLoaded = false;
		Services.Packages.Security.PackageAccessControlList _ACL;
		
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.PackageAccessControlList ACL
		{
            get
            {
				if (!_ACLIsLoaded)
				{
					_ACL = new Services.Packages.Security.PackageAccessControlList(_UserName, _Id);
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
						_Id = _ACL.Id;
						
					}
					else
					{
						_ACL = null;
					}
				}
            }
		}
		
		public static Services.Packages.Security.PackageAccessControlList GetACL(PackageAccessControlEntry _PackageAccessControlEntry)
		{
			return _PackageAccessControlEntry.ACL;
		}

		public static PackageAccessControlEntryCollection GetByACL(Services.Packages.Security.PackageAccessControlList _PackageAccessControlList)
        {
			PackageAccessControlEntryCollection _PackageAccessControlEntryCollection = new PackageAccessControlEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PaAcCoEnGetByACL", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_UserName;
				if (_PackageAccessControlList != null) {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageAccessControlList.UserName);
				} else {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", DBNull.Value);
				}
				command.Parameters.Add(param_UserName);
				DbParameter param_Id;
				if (_PackageAccessControlList != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageAccessControlList.Id);
				} else {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", DBNull.Value);
				}
				command.Parameters.Add(param_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					PackageAccessControlEntry o = new PackageAccessControlEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Id"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _PackageAccessControlEntryCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PackageAccessControlEntryCollection;
        }
        
        public static PackageAccessControlEntryCollection GetByACLPaged(Services.Packages.Security.PackageAccessControlList _PackageAccessControlList, long PagingStart, long PagingCount)
        {
			PackageAccessControlEntryCollection _PackageAccessControlEntryCollection = new PackageAccessControlEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PaAcCoEnGetByACLPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_UserName;
				if (_PackageAccessControlList != null) {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageAccessControlList.UserName);
				} else {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", DBNull.Value);
				}
				command.Parameters.Add(param_UserName);
				DbParameter param_Id;
				if (_PackageAccessControlList != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageAccessControlList.Id);
				} else {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", DBNull.Value);
				}
				command.Parameters.Add(param_Id);
				
                
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
					PackageAccessControlEntry o = new PackageAccessControlEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Id"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _PackageAccessControlEntryCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PackageAccessControlEntryCollection;
        }
        
        public static long GetByACLCount(Services.Packages.Security.PackageAccessControlList _PackageAccessControlList)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PaAcCoEnGetByACLCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_UserName;
				if (_PackageAccessControlList != null) {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageAccessControlList.UserName);
				} else {
				param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", DBNull.Value);
				}
				command.Parameters.Add(param_UserName);
				DbParameter param_Id;
				if (_PackageAccessControlList != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageAccessControlList.Id);
				} else {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", DBNull.Value);
				}
				command.Parameters.Add(param_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		public static PackageAccessControlEntryCollection GetEntries(System.String _Descriptor, Services.Packages.Security.PackageAccessControlList _PackageAccessControlList)
        {
			PackageAccessControlEntryCollection _PackageAccessControlEntryCollection = new PackageAccessControlEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PaAcCoEnGeEn", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Descriptor = ClassConnectionProvider.Escape(_Descriptor);
				
                
                DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), -1);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_PackageAccessControlList_UserName;
				if (_PackageAccessControlList != null) {
				param_PackageAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("PaAcCoLiUsNa", typeof(System.String), 128);
				param_PackageAccessControlList_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageAccessControlList.UserName);
				} else {
				param_PackageAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("PaAcCoLiUsNa", DBNull.Value);
				}
				command.Parameters.Add(param_PackageAccessControlList_UserName);
				DbParameter param_PackageAccessControlList_Id;
				if (_PackageAccessControlList != null) {
				param_PackageAccessControlList_Id = ClassConnectionProvider.GetDatabaseParameter("PaAcCoLiId", typeof(System.Int32), -1);
				param_PackageAccessControlList_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageAccessControlList.Id);
				} else {
				param_PackageAccessControlList_Id = ClassConnectionProvider.GetDatabaseParameter("PaAcCoLiId", DBNull.Value);
				}
				command.Parameters.Add(param_PackageAccessControlList_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					PackageAccessControlEntry o = new PackageAccessControlEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Id"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _PackageAccessControlEntryCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PackageAccessControlEntryCollection;
        }
        
        public static PackageAccessControlEntryCollection GetEntriesPaged(System.String _Descriptor, Services.Packages.Security.PackageAccessControlList _PackageAccessControlList, long PagingStart, long PagingCount)
        {
			PackageAccessControlEntryCollection _PackageAccessControlEntryCollection = new PackageAccessControlEntryCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PaAcCoEnGeEnPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Descriptor = ClassConnectionProvider.Escape(_Descriptor);
				
                
                DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), -1);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_PackageAccessControlList_UserName;
				if (_PackageAccessControlList != null) {
				param_PackageAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("PaAcCoLiUsNa", typeof(System.String), 128);
				param_PackageAccessControlList_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageAccessControlList.UserName);
				} else {
				param_PackageAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("PaAcCoLiUsNa", DBNull.Value);
				}
				command.Parameters.Add(param_PackageAccessControlList_UserName);
				DbParameter param_PackageAccessControlList_Id;
				if (_PackageAccessControlList != null) {
				param_PackageAccessControlList_Id = ClassConnectionProvider.GetDatabaseParameter("PaAcCoLiId", typeof(System.Int32), -1);
				param_PackageAccessControlList_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageAccessControlList.Id);
				} else {
				param_PackageAccessControlList_Id = ClassConnectionProvider.GetDatabaseParameter("PaAcCoLiId", DBNull.Value);
				}
				command.Parameters.Add(param_PackageAccessControlList_Id);
				
                
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
					PackageAccessControlEntry o = new PackageAccessControlEntry();
                
					o.__databaseState = RowState.Initialized;
                    o._Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Id"] == DBNull.Value) { o._ACL = null; o._ACLIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _PackageAccessControlEntryCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PackageAccessControlEntryCollection;
        }
        
        public static long GetEntriesCount(System.String _Descriptor, Services.Packages.Security.PackageAccessControlList _PackageAccessControlList)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PaAcCoEnGeEnCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Descriptor = ClassConnectionProvider.Escape(_Descriptor);
				
                
                DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), -1);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_PackageAccessControlList_UserName;
				if (_PackageAccessControlList != null) {
				param_PackageAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("PaAcCoLiUsNa", typeof(System.String), 128);
				param_PackageAccessControlList_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageAccessControlList.UserName);
				} else {
				param_PackageAccessControlList_UserName = ClassConnectionProvider.GetDatabaseParameter("PaAcCoLiUsNa", DBNull.Value);
				}
				command.Parameters.Add(param_PackageAccessControlList_UserName);
				DbParameter param_PackageAccessControlList_Id;
				if (_PackageAccessControlList != null) {
				param_PackageAccessControlList_Id = ClassConnectionProvider.GetDatabaseParameter("PaAcCoLiId", typeof(System.Int32), -1);
				param_PackageAccessControlList_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageAccessControlList.Id);
				} else {
				param_PackageAccessControlList_Id = ClassConnectionProvider.GetDatabaseParameter("PaAcCoLiId", DBNull.Value);
				}
				command.Parameters.Add(param_PackageAccessControlList_Id);
				
                
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
        
        public PackageAccessControlEntry() {}
        
        public PackageAccessControlEntry(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
        {
			Read(__Descriptor, __UserName, __Id);
        }
        
        #region CRUD
        
        void Exist()
        {
			// sql read - should be changed to specific exist implementation
			using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
			{
				dbconn.Open();
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PaAcCoEnRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
				DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), 128);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				
                
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
        
        public void Read(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].Read(__Descriptor, __UserName, __Id);
					return;
				}

                // Get a service via an algorithm
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "PaAcCoEn");
                // Perfect for read operations, but not for write
                // scalingServices[nextIndex].Read(__Descriptor, __UserName, __Id);
				// return;

				throw new NotImplementedException();
            }

            try
            {
				// sql read
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PaAcCoEnRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					_Descriptor = __Descriptor;
				DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), 128);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(__Descriptor);
				command.Parameters.Add(param_Descriptor);
				_UserName = __UserName;
				DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(__UserName);
				command.Parameters.Add(param_UserName);
				_Id = __Id;
				DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(__Id);
				command.Parameters.Add(param_Id);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Id"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
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
                            failoverServices[n].Read(__Descriptor, __UserName, __Id);
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "PaAcCoEn");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PaAcCoEnRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), 128);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Id"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PaAcCoEnCreate", dbconn);
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
				DbParameter param_ACL_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_ACL_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				if (_ACL == null && _ACLIsLoaded == true) param_ACL_Id.Value = DBNull.Value;
				command.Parameters.Add(param_ACL_Id);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_Descriptor = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Descriptor"], typeof(System.String));
				_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Allow = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Allow"], typeof(System.Boolean));
				_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_ACLIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				if (dr["Id"] == DBNull.Value) { _ACL = null; _ACLIsLoaded = true; }  else _Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
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
        
        static public PackageAccessControlEntry CreatePackageAccessControlEntry(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
        {
            PackageAccessControlEntry o = new PackageAccessControlEntry(__Descriptor, __UserName, __Id);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PaAcCoEnUpdate", dbconn);
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
				DbParameter param_ACL_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_ACL_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				if (_ACL == null && _ACLIsLoaded == true) param_ACL_Id.Value = DBNull.Value;
				command.Parameters.Add(param_ACL_Id);
				

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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PaAcCoEnDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Descriptor = ClassConnectionProvider.GetDatabaseParameter("Descriptor", typeof(System.String), 128);
				param_Descriptor.Value = ClassConnectionProvider.FromValueToSqlModelType(_Descriptor);
				command.Parameters.Add(param_Descriptor);
				DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				
				
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
        
        static public void DeletePackageAccessControlEntry(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
        {
            PackageAccessControlEntry o = new PackageAccessControlEntry(__Descriptor, __UserName, __Id);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(PackageAccessControlEntry _object)
        {
			_ACL = null;
			_ACLIsLoaded = false;
			_Descriptor = _object._Descriptor;
			_UserName = _object._UserName;
			_Allow = _object._Allow;
			_Id = _object._Id;
			
        }
        
        public void CopyWithKeysTo(PackageAccessControlEntry _object)
        {
			_object._ACL = null;
			_object._ACLIsLoaded = false;
			_object._Descriptor = _Descriptor;
			_object._UserName = _UserName;
			_object._Allow = _Allow;
			_object._Id = _Id;
			
        }
        
        static public void CopyWithKeysObject(PackageAccessControlEntry _objectFrom, PackageAccessControlEntry _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(PackageAccessControlEntry _object)
        {
			_ACL = null;
			_ACLIsLoaded = false;
			_Allow = _object._Allow;
			
        }
        
        public void CopyTo(PackageAccessControlEntry _object)
        {
			_object._ACL = null;
			_object._ACLIsLoaded = false;
			_object._Allow = _Allow;
			
        }
        
        static public void CopyObject(PackageAccessControlEntry _objectFrom, PackageAccessControlEntry _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(PackageAccessControlEntry).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(PackageAccessControlEntry).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(PackageAccessControlEntry _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			PackageAccessControlEntryUndoRedoCollection allUndidAndNotRedoneEntries = PackageAccessControlEntryUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			PackageAccessControlEntryUndoRedo _urobject = new PackageAccessControlEntryUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.ACL_UserName = _object._ACL_UserName;
			_urobject.ACL_Id = _object._ACL_Id;
			_urobject.Descriptor = _object._Descriptor;
			_urobject.UserName = _object._UserName;
			_urobject.Allow = _object._Allow;
			_urobject.Id = _object._Id;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(PackageAccessControlEntry).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = PackageAccessControlEntryUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				PackageAccessControlEntryUndoRedoCollection allOldUndoEntries = PackageAccessControlEntryUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			PackageAccessControlEntryUndoRedoCollection firstUndoEntries = PackageAccessControlEntryUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			PackageAccessControlEntryUndoRedo _urobject = firstUndoEntries[0];
			
			PackageAccessControlEntry _object = new PackageAccessControlEntry();
			_object._ACL = null;
			_object._ACLIsLoaded = false;
			_object._ACL_UserName = _urobject.ACL_UserName;
			_object._ACL = null;
			_object._ACLIsLoaded = false;
			_object._ACL_Id = _urobject.ACL_Id;
			_object._Descriptor = _urobject.Descriptor;
			_object._UserName = _urobject.UserName;
			_object._Allow = _urobject.Allow;
			_object._Id = _urobject.Id;
			

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
			PackageAccessControlEntryUndoRedoCollection firstEntryToRedoEntries = PackageAccessControlEntryUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			PackageAccessControlEntryUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			PackageAccessControlEntry _object = new PackageAccessControlEntry();
			_object._ACL = null;
			_object._ACLIsLoaded = false;
			_object._ACL_UserName = _urobject.ACL_UserName;
			_object._ACL = null;
			_object._ACLIsLoaded = false;
			_object._ACL_Id = _urobject.ACL_Id;
			_object._Descriptor = _urobject.Descriptor;
			_object._UserName = _urobject.UserName;
			_object._Allow = _urobject.Allow;
			_object._Id = _urobject.Id;
			

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
    /// Defines the contract for the PackageAccessControlEntryCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("6807be36-f80e-08db-4eca-ef2af6e1ac13")]
    public interface IPackageAccessControlEntryCollection : IEnumerable<PackageAccessControlEntry>
    {
        int IndexOf(PackageAccessControlEntry item);
        void Insert(int index, PackageAccessControlEntry item);
        void RemoveAt(int index);
        PackageAccessControlEntry this[int index] { get; set; }
        void Add(PackageAccessControlEntry item);
        void Clear();
        bool Contains(PackageAccessControlEntry item);
        void CopyTo(PackageAccessControlEntry[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(PackageAccessControlEntry item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.Security.PackageAccessControlEntry
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("cfc2f1ac-b968-23af-0e22-3e88fe3aca47")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class PackageAccessControlEntryCollection : IPackageAccessControlEntryCollection, IList<PackageAccessControlEntry>, IHierarchicalEnumerable
    {
        List<PackageAccessControlEntry> _list = new List<PackageAccessControlEntry>();
        
        public static implicit operator List<PackageAccessControlEntry>(PackageAccessControlEntryCollection collection)
        {
            return collection._list;
        }

        #region IList<PackageAccessControlEntry> Members

        public int IndexOf(PackageAccessControlEntry item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, PackageAccessControlEntry item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public PackageAccessControlEntry this[int index]
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

        #region ICollection<PackageAccessControlEntry> Members

        public void Add(PackageAccessControlEntry item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(PackageAccessControlEntry item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(PackageAccessControlEntry[] array, int arrayIndex)
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

        public bool Remove(PackageAccessControlEntry item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<PackageAccessControlEntry> Members

        public IEnumerator<PackageAccessControlEntry> GetEnumerator()
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
	/// that share Services.Packages.Security.PackageAccessControlEntry objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Security.Web.PackageAccessControlEntryWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class PackageAccessControlEntryWebService : WebService, IPackageAccessControlEntryService
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
        public bool Exists(PackageAccessControlEntry _PackageAccessControlEntry)
        {
			return _PackageAccessControlEntry.Exists;
        }
		
		[WebMethod]
		public PackageAccessControlEntry Read(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
		{
			return new PackageAccessControlEntry(__Descriptor, __UserName, __Id);
		}
		
		[WebMethod]
        public PackageAccessControlEntry Reload(PackageAccessControlEntry _PackageAccessControlEntry)
        {
			_PackageAccessControlEntry.Reload();
			return _PackageAccessControlEntry;
        }
		
		[WebMethod]
        public PackageAccessControlEntry Create(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
        {
			return PackageAccessControlEntry.CreatePackageAccessControlEntry(__Descriptor, __UserName, __Id);
        }
        
        [WebMethod]
        public void Delete(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
        {
			PackageAccessControlEntry.DeletePackageAccessControlEntry(__Descriptor, __UserName, __Id);
        }
        
        [WebMethod]
        public void UpdateObject(PackageAccessControlEntry _PackageAccessControlEntry)
        {
			_PackageAccessControlEntry.Update();
        }
		
		[WebMethod]
        public void CreateObject(PackageAccessControlEntry _PackageAccessControlEntry)
        {
			_PackageAccessControlEntry.Create();
        }
        
        [WebMethod]
        public void DeleteObject(PackageAccessControlEntry _PackageAccessControlEntry)
        {
			_PackageAccessControlEntry.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			PackageAccessControlEntry.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			PackageAccessControlEntry.Redo();
        }
		[WebMethod]
		public PackageAccessControlEntryCollection GetByACL(Services.Packages.Security.PackageAccessControlList _PackageAccessControlList)
		{
			return PackageAccessControlEntry.GetByACL( _PackageAccessControlList);
		}
		[WebMethod]
		public PackageAccessControlEntryCollection GetByACLPaged(Services.Packages.Security.PackageAccessControlList _PackageAccessControlList, long PagingStart, long PagingCount)
		{
			return PackageAccessControlEntry.GetByACLPaged( _PackageAccessControlList, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByACLCount(Services.Packages.Security.PackageAccessControlList _PackageAccessControlList)
		{
			return PackageAccessControlEntry.GetByACLCount( _PackageAccessControlList);
		}
		[WebMethod]
		public Services.Packages.Security.PackageAccessControlList GetACL(PackageAccessControlEntry _PackageAccessControlEntry)
		{
			_PackageAccessControlEntry.Reload();
			return _PackageAccessControlEntry.ACL;
		}
		[WebMethod]
		public void SetACL(PackageAccessControlEntry _PackageAccessControlEntry, Services.Packages.Security.PackageAccessControlList _ACL)
		{
			_PackageAccessControlEntry.Reload();
			_PackageAccessControlEntry.ACL = _ACL;
			_PackageAccessControlEntry.Update();
		}
		[WebMethod]
		public PackageAccessControlEntryCollection GetEntries(System.String Descriptor, Services.Packages.Security.PackageAccessControlList _PackageAccessControlList)
		{
			return PackageAccessControlEntry.GetEntries(Descriptor,  _PackageAccessControlList);
		}
		[WebMethod]
		public PackageAccessControlEntryCollection GetEntriesPaged(System.String Descriptor, Services.Packages.Security.PackageAccessControlList _PackageAccessControlList, long PagingStart, long PagingCount)
		{
			return PackageAccessControlEntry.GetEntriesPaged(Descriptor,  _PackageAccessControlList, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetEntriesCount(System.String Descriptor, Services.Packages.Security.PackageAccessControlList _PackageAccessControlList)
		{
			return PackageAccessControlEntry.GetEntriesCount(Descriptor,  _PackageAccessControlList);
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="PackageAccessControlEntryWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("172a51cc-856b-94c7-b9b9-eb23e0e9586b")]
    sealed public class PackageAccessControlEntryWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IPackageAccessControlEntryService
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
		public PackageAccessControlEntryWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public PackageAccessControlEntryWebServiceClient()
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
		public bool Exists(PackageAccessControlEntry _PackageAccessControlEntry)
        {
			object[] results = this.Invoke("Exists", new object[] {_PackageAccessControlEntry});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PackageAccessControlEntry Read(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
		{
			object[] results = this.Invoke("Read", new object[] {__Descriptor, __UserName, __Id});
			return ((PackageAccessControlEntry)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PackageAccessControlEntry Reload(PackageAccessControlEntry _PackageAccessControlEntry)
        {
			object[] results = this.Invoke("Reload", new object[] {_PackageAccessControlEntry});
			return ((PackageAccessControlEntry)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PackageAccessControlEntry Create(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
        {
			object[] results = this.Invoke("Create", new object[] {__Descriptor, __UserName, __Id});
			return ((PackageAccessControlEntry)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __Descriptor, System.String __UserName, System.Int32 __Id)
        {
			this.Invoke("Delete", new object[] {__Descriptor, __UserName, __Id});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(PackageAccessControlEntry _PackageAccessControlEntry)
        {
			this.Invoke("UpdateObject", new object[] {_PackageAccessControlEntry});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(PackageAccessControlEntry _PackageAccessControlEntry)
        {
			this.Invoke("CreateObject", new object[] {_PackageAccessControlEntry});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(PackageAccessControlEntry _PackageAccessControlEntry)
        {
			this.Invoke("DeleteObject", new object[] {_PackageAccessControlEntry});
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
		public PackageAccessControlEntryCollection GetByACL(Services.Packages.Security.PackageAccessControlList _PackageAccessControlList) {
			object[] results = this.Invoke("GetByACL", new object[] {_PackageAccessControlList});
			return ((PackageAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByACLPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PackageAccessControlEntryCollection GetByACLPaged(Services.Packages.Security.PackageAccessControlList _PackageAccessControlList, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByACLPaged", new object[] {_PackageAccessControlList,PagingStart,PagingCount});
			return ((PackageAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByACLCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByACLCount(Services.Packages.Security.PackageAccessControlList _PackageAccessControlList) {
			object[] results = this.Invoke("GetByACLCount", new object[] {_PackageAccessControlList});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACL", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.PackageAccessControlList GetACL(PackageAccessControlEntry _PackageAccessControlEntry)
		{
			object[] results = this.Invoke("GetACL", new object[] {_PackageAccessControlEntry});
			return ((Services.Packages.Security.PackageAccessControlList)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACL", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACL(PackageAccessControlEntry _PackageAccessControlEntry, Services.Packages.Security.PackageAccessControlList _ACL)
		{
			this.Invoke("GetACL", new object[] {_PackageAccessControlEntry});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetEntries", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PackageAccessControlEntryCollection GetEntries(System.String Descriptor, Services.Packages.Security.PackageAccessControlList _PackageAccessControlList) {
			object[] results = this.Invoke("GetEntries", new object[] {Descriptor, _PackageAccessControlList});
			return ((PackageAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetEntriesPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PackageAccessControlEntryCollection GetEntriesPaged(System.String Descriptor, Services.Packages.Security.PackageAccessControlList _PackageAccessControlList, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetEntriesPaged", new object[] {Descriptor, _PackageAccessControlList,PagingStart,PagingCount});
			return ((PackageAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetEntriesCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetEntriesCount(System.String Descriptor, Services.Packages.Security.PackageAccessControlList _PackageAccessControlList) {
			object[] results = this.Invoke("GetEntriesCount", new object[] {Descriptor, _PackageAccessControlList});
			return ((long)(results[0]));
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages.Security
