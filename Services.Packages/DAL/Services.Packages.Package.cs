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
    /// Defines the contract for the Package class
    /// </summary>
    [ComVisible(true)]
    [Guid("73cf0336-4868-a0b2-5fea-70ed9b5317df")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IPackage
	{
		bool Exists { get; }
		System.Int32 Id { get; set; }
		System.String PackageName { get; set; }
		System.String VersionLabel { get; set; }
		System.DateTime UploadDate { get; set; }
		Services.Packages.ApiKey ApiKey { get; set; }
		Services.Packages.Security.ModelUser Owner { get; set; }
		Services.Packages.Security.PackageAccessControlListCollection ACLs { get; set; }
		Services.Packages.Security.PackageAccessControlListCollection GetACLs(System.String UserName);

		void Read(System.Int32 __Id);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(Package _object);
		void CopyWithKeysTo(Package _object);
		void CopyFrom(Package _object);
		void CopyTo(Package _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.Package type.
    /// </summary>
    [ComVisible(true)]
    [Guid("b05c8d0b-4da7-0d0b-0f01-946e100ca591")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IPackageService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(Package _Package);
		[OperationContract]
        Package Read(System.Int32 __Id);
        [OperationContract]
        Package Reload(Package _Package);
        [OperationContract]
        Package Create(System.Int32 __Id);
        [OperationContract]
        void Delete(System.Int32 __Id);
        [OperationContract]
        void UpdateObject(Package _Package);
        [OperationContract]
        void CreateObject(Package _Package);
        [OperationContract]
        void DeleteObject(Package _Package);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		PackageCollection GetByApiKey(Services.Packages.ApiKey _ApiKey);
		[OperationContract]
		PackageCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey);
		[OperationContract]
		Services.Packages.ApiKey GetApiKey(Package _Package);
		[OperationContract]
		void SetApiKey(Package _Package, Services.Packages.ApiKey _ApiKey);
		[OperationContract]
		PackageCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		PackageCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		Services.Packages.Security.ModelUser GetOwner(Package _Package);
		[OperationContract]
		void SetOwner(Package _Package, Services.Packages.Security.ModelUser _Owner);
		[OperationContract]
		PackageCollection SearchByPackageName(System.String PackageName );
		[OperationContract]
		PackageCollection SearchByPackageNamePaged(System.String PackageName , long PagingStart, long PagingCount);
		[OperationContract]
		long SearchByPackageNameCount(System.String PackageName );
		[OperationContract]
		PackageCollection SearchByPackageNameForApiKey(System.String PackageName, Services.Packages.ApiKey _ApiKey);
		[OperationContract]
		PackageCollection SearchByPackageNameForApiKeyPaged(System.String PackageName, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount);
		[OperationContract]
		long SearchByPackageNameForApiKeyCount(System.String PackageName, Services.Packages.ApiKey _ApiKey);
		[OperationContract]
		Services.Packages.Security.PackageAccessControlListCollection GetACLs(Package _Package);
		[OperationContract]
		void SetACLs(Package _Package, Services.Packages.Security.PackageAccessControlListCollection _ACLs);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.Package type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("924abd21-4eca-1b11-e3ae-774bb814c5b5")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class PackageService : IPackageService
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
        public bool Exists(Package _Package)
        {
			return _Package.Exists;
        }
		
		[WebMethod]
		public Package Read(System.Int32 __Id)
		{
			return new Package(__Id);
		}
		
		[WebMethod]
        public Package Reload(Package _Package)
        {
			_Package.Reload();
			return _Package;
        }
		
		[WebMethod]
        public Package Create(System.Int32 __Id)
        {
			return Package.CreatePackage(__Id);
        }
        
        [WebMethod]
        public void Delete(System.Int32 __Id)
        {
			Package.DeletePackage(__Id);
        }
        
        [WebMethod]
        public void UpdateObject(Package _Package)
        {
			_Package.Update();
        }
		
		[WebMethod]
        public void CreateObject(Package _Package)
        {
			_Package.Create();
        }
        
        [WebMethod]
        public void DeleteObject(Package _Package)
        {
			_Package.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			Package.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			Package.Redo();
        }
		[WebMethod]
		public PackageCollection GetByApiKey(Services.Packages.ApiKey _ApiKey)
		{
			return Package.GetByApiKey( _ApiKey);
		}
		[WebMethod]
		public PackageCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
		{
			return Package.GetByApiKeyPaged( _ApiKey, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey)
		{
			return Package.GetByApiKeyCount( _ApiKey);
		}
		[WebMethod]
		public Services.Packages.ApiKey GetApiKey(Package _Package)
		{
			_Package.Reload();
			return _Package.ApiKey;
		}
		[WebMethod]
		public void SetApiKey(Package _Package, Services.Packages.ApiKey _ApiKey)
		{
			_Package.Reload();
			_Package.ApiKey = _ApiKey;
			_Package.Update();
		}
		[WebMethod]
		public PackageCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
		{
			return Package.GetByOwner( _ModelUser);
		}
		[WebMethod]
		public PackageCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return Package.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return Package.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(Package _Package)
		{
			_Package.Reload();
			return _Package.Owner;
		}
		[WebMethod]
		public void SetOwner(Package _Package, Services.Packages.Security.ModelUser _Owner)
		{
			_Package.Reload();
			_Package.Owner = _Owner;
			_Package.Update();
		}
		[WebMethod]
		public PackageCollection SearchByPackageName(System.String PackageName )
		{
			return Package.SearchByPackageName(PackageName );
		}
		[WebMethod]
		public PackageCollection SearchByPackageNamePaged(System.String PackageName , long PagingStart, long PagingCount)
		{
			return Package.SearchByPackageNamePaged(PackageName , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByPackageNameCount(System.String PackageName )
		{
			return Package.SearchByPackageNameCount(PackageName );
		}
		[WebMethod]
		public PackageCollection SearchByPackageNameForApiKey(System.String PackageName, Services.Packages.ApiKey _ApiKey)
		{
			return Package.SearchByPackageNameForApiKey(PackageName,  _ApiKey);
		}
		[WebMethod]
		public PackageCollection SearchByPackageNameForApiKeyPaged(System.String PackageName, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
		{
			return Package.SearchByPackageNameForApiKeyPaged(PackageName,  _ApiKey, PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByPackageNameForApiKeyCount(System.String PackageName, Services.Packages.ApiKey _ApiKey)
		{
			return Package.SearchByPackageNameForApiKeyCount(PackageName,  _ApiKey);
		}
		[WebMethod]
		public Services.Packages.Security.PackageAccessControlListCollection GetACLs(Package _Package)
		{
			_Package.Reload();
			return _Package.ACLs;
		}
		[WebMethod]
		public void SetACLs(Package _Package, Services.Packages.Security.PackageAccessControlListCollection _ACLs)
		{
			_Package.Reload();
			_Package.ACLs = _ACLs;
			_Package.Update();
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.Package model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("ae4a06d0-1b41-e87d-f7c1-6466b4439053")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class Package : IPackage, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<IPackageService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<IPackageService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<IPackageService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Package"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Package"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.Package.ProviderType");
				
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

		System.String _PackageName;
		
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
                _PackageName = value;
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

		System.DateTime _UploadDate;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.DateTime UploadDate
		{
            get
            {
                return _UploadDate;
            }
            set
            {
                _UploadDate = value;
            }
		}

		bool _ApiKeyIsLoaded = false;
		Services.Packages.ApiKey _ApiKey;
		System.Guid _ApiKey_Id; 
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.ApiKey ApiKey
		{
            get
            {
				if (!_ApiKeyIsLoaded)
				{
					_ApiKey = new Services.Packages.ApiKey(_ApiKey_Id);
					if (_ApiKey.Exists)
						_ApiKeyIsLoaded = true;
					else _ApiKey = null;
				}
                return _ApiKey;
            }
            set
            {
                _ApiKey = value;
                _ApiKeyIsLoaded = true;
                if (_ApiKey != null)
                {
					if (_ApiKey.Exists)
					{
						_ApiKey_Id = _ApiKey.Id;
						
					}
					else
					{
						_ApiKey = null;
					}
				}
            }
		}
		
		public static Services.Packages.ApiKey GetApiKey(Package _Package)
		{
			return _Package.ApiKey;
		}

		bool _OwnerIsLoaded = false;
		Services.Packages.Security.ModelUser _Owner;
		System.String _Owner_Name; 
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.ModelUser Owner
		{
            get
            {
				if (!_OwnerIsLoaded)
				{
					_Owner = new Services.Packages.Security.ModelUser(_Owner_Name);
					if (_Owner.Exists)
						_OwnerIsLoaded = true;
					else _Owner = null;
				}
                return _Owner;
            }
            set
            {
                _Owner = value;
                _OwnerIsLoaded = true;
                if (_Owner != null)
                {
					if (_Owner.Exists)
					{
						_Owner_Name = _Owner.Name;
						
					}
					else
					{
						_Owner = null;
					}
				}
            }
		}
		
		public static Services.Packages.Security.ModelUser GetOwner(Package _Package)
		{
			return _Package.Owner;
		}

		public static PackageCollection GetByApiKey(Services.Packages.ApiKey _ApiKey)
        {
			PackageCollection _PackageCollection = new PackageCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PaGetByApKe", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Id;
				if (_ApiKey != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Guid), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey.Id);
				} else {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", DBNull.Value);
				}
				command.Parameters.Add(param_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					Package o = new Package();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._PackageName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PackageName"], typeof(System.String));
				o._VersionLabel = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VersionLabel"], typeof(System.String));
				o._UploadDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UploadDate"], typeof(System.DateTime));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PackageCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PackageCollection;
        }
        
        public static PackageCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
        {
			PackageCollection _PackageCollection = new PackageCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PaGetByApKePaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Id;
				if (_ApiKey != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Guid), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey.Id);
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
					Package o = new Package();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._PackageName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PackageName"], typeof(System.String));
				o._VersionLabel = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VersionLabel"], typeof(System.String));
				o._UploadDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UploadDate"], typeof(System.DateTime));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PackageCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PackageCollection;
        }
        
        public static long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PaGetByApKeCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Id;
				if (_ApiKey != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Guid), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey.Id);
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

		public static PackageCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
        {
			PackageCollection _PackageCollection = new PackageCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PaGetByOw", dbconn);
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
					Package o = new Package();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._PackageName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PackageName"], typeof(System.String));
				o._VersionLabel = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VersionLabel"], typeof(System.String));
				o._UploadDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UploadDate"], typeof(System.DateTime));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PackageCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PackageCollection;
        }
        
        public static PackageCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			PackageCollection _PackageCollection = new PackageCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PaGetByOwPaged", dbconn);
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
					Package o = new Package();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._PackageName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PackageName"], typeof(System.String));
				o._VersionLabel = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VersionLabel"], typeof(System.String));
				o._UploadDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UploadDate"], typeof(System.DateTime));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PackageCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PackageCollection;
        }
        
        public static long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PaGetByOwCount", dbconn);
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

		public static PackageCollection SearchByPackageName(System.String _PackageName)
        {
			PackageCollection _PackageCollection = new PackageCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PaSeByPaNa", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _PackageName = ClassConnectionProvider.Escape(_PackageName);
				
                
                DbParameter param_PackageName = ClassConnectionProvider.GetDatabaseParameter("PackageName", typeof(System.String), -1);
				param_PackageName.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageName);
				command.Parameters.Add(param_PackageName);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					Package o = new Package();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._PackageName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PackageName"], typeof(System.String));
				o._VersionLabel = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VersionLabel"], typeof(System.String));
				o._UploadDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UploadDate"], typeof(System.DateTime));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PackageCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PackageCollection;
        }
        
        public static PackageCollection SearchByPackageNamePaged(System.String _PackageName, long PagingStart, long PagingCount)
        {
			PackageCollection _PackageCollection = new PackageCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PaSeByPaNaPaged", dbconn);
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
					Package o = new Package();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._PackageName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PackageName"], typeof(System.String));
				o._VersionLabel = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VersionLabel"], typeof(System.String));
				o._UploadDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UploadDate"], typeof(System.DateTime));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PackageCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PackageCollection;
        }
        
        public static long SearchByPackageNameCount(System.String _PackageName)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PaSeByPaNaCount", dbconn);
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

		public static PackageCollection SearchByPackageNameForApiKey(System.String _PackageName, Services.Packages.ApiKey _ApiKey)
        {
			PackageCollection _PackageCollection = new PackageCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PaSeByPaNaFoApKe", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _PackageName = ClassConnectionProvider.Escape(_PackageName);
				
                
                DbParameter param_PackageName = ClassConnectionProvider.GetDatabaseParameter("PackageName", typeof(System.String), -1);
				param_PackageName.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageName);
				command.Parameters.Add(param_PackageName);
				DbParameter param_ApiKey_Id;
				if (_ApiKey != null) {
				param_ApiKey_Id = ClassConnectionProvider.GetDatabaseParameter("ApKeId", typeof(System.Guid), -1);
				param_ApiKey_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey.Id);
				} else {
				param_ApiKey_Id = ClassConnectionProvider.GetDatabaseParameter("ApKeId", DBNull.Value);
				}
				command.Parameters.Add(param_ApiKey_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					Package o = new Package();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._PackageName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PackageName"], typeof(System.String));
				o._VersionLabel = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VersionLabel"], typeof(System.String));
				o._UploadDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UploadDate"], typeof(System.DateTime));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PackageCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PackageCollection;
        }
        
        public static PackageCollection SearchByPackageNameForApiKeyPaged(System.String _PackageName, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
        {
			PackageCollection _PackageCollection = new PackageCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PaSeByPaNaFoApKePaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _PackageName = ClassConnectionProvider.Escape(_PackageName);
				
                
                DbParameter param_PackageName = ClassConnectionProvider.GetDatabaseParameter("PackageName", typeof(System.String), -1);
				param_PackageName.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageName);
				command.Parameters.Add(param_PackageName);
				DbParameter param_ApiKey_Id;
				if (_ApiKey != null) {
				param_ApiKey_Id = ClassConnectionProvider.GetDatabaseParameter("ApKeId", typeof(System.Guid), -1);
				param_ApiKey_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey.Id);
				} else {
				param_ApiKey_Id = ClassConnectionProvider.GetDatabaseParameter("ApKeId", DBNull.Value);
				}
				command.Parameters.Add(param_ApiKey_Id);
				
                
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
					Package o = new Package();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._PackageName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PackageName"], typeof(System.String));
				o._VersionLabel = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VersionLabel"], typeof(System.String));
				o._UploadDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UploadDate"], typeof(System.DateTime));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PackageCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PackageCollection;
        }
        
        public static long SearchByPackageNameForApiKeyCount(System.String _PackageName, Services.Packages.ApiKey _ApiKey)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PaSeByPaNaFoApKeCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _PackageName = ClassConnectionProvider.Escape(_PackageName);
				
                
                DbParameter param_PackageName = ClassConnectionProvider.GetDatabaseParameter("PackageName", typeof(System.String), -1);
				param_PackageName.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageName);
				command.Parameters.Add(param_PackageName);
				DbParameter param_ApiKey_Id;
				if (_ApiKey != null) {
				param_ApiKey_Id = ClassConnectionProvider.GetDatabaseParameter("ApKeId", typeof(System.Guid), -1);
				param_ApiKey_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey.Id);
				} else {
				param_ApiKey_Id = ClassConnectionProvider.GetDatabaseParameter("ApKeId", DBNull.Value);
				}
				command.Parameters.Add(param_ApiKey_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		Services.Packages.Security.PackageAccessControlListCollection _ACLs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.PackageAccessControlListCollection ACLs
		{
            get
            {
				if (_ACLs == null)
					_ACLs = Services.Packages.Security.PackageAccessControlList.GetByPackage(this);
				
				return _ACLs;
            }
            set
            {
				if (this.Exists)
				{
					if (_ACLs != null)
					{
						for(int n = 0; n < _ACLs.Count; ++n)
						{
							_ACLs[n].Package = null;
							_ACLs[n].Update();
						}
					}
	                
					_ACLs = value;
					
					if (_ACLs != null)
					{
						for(int n = 0; n < _ACLs.Count; ++n)
						{
							_ACLs[n].Package = this;
							_ACLs[n].Create();
						}
					}
				}
				else
				{
					_ACLs = value;
				}
            }
		}
		
		public void ReloadACLs()
		{
			_ACLs = Services.Packages.Security.PackageAccessControlList.GetByPackage(this);
		}

		public Services.Packages.Security.PackageAccessControlListCollection GetACLs(System.String UserName)
		{
			return Services.Packages.Security.PackageAccessControlList.GetACLs(UserName,  this);
		}

		public bool Exists
        {
            get {
				if (!__hasBeenReadOnce)
					Exist();
				
				return __databaseState == RowState.Initialized;
			}
        }
        
        public Package() {}
        
        public Package(System.Int32 __Id)
        {
			Read(__Id);
        }
        
        #region CRUD
        
        void Exist()
        {
			// sql read - should be changed to specific exist implementation
			using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
			{
				dbconn.Open();
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PaRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
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
        
        public void Read(System.Int32 __Id)
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].Read(__Id);
					return;
				}

                // Get a service via an algorithm
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "Pa");
                // Perfect for read operations, but not for write
                // scalingServices[nextIndex].Read(__Id);
				// return;

				throw new NotImplementedException();
            }

            try
            {
				// sql read
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PaRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					_Id = __Id;
				DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(__Id);
				command.Parameters.Add(param_Id);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_PackageName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PackageName"], typeof(System.String));
				_VersionLabel = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VersionLabel"], typeof(System.String));
				_UploadDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UploadDate"], typeof(System.DateTime));
				_ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { _ApiKey = null; _ApiKeyIsLoaded = true; }  else _ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				_OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { _Owner = null; _OwnerIsLoaded = true; }  else _Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
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
                            failoverServices[n].Read(__Id);
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "Pa");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PaRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_PackageName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PackageName"], typeof(System.String));
				_VersionLabel = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VersionLabel"], typeof(System.String));
				_UploadDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UploadDate"], typeof(System.DateTime));
				_ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { _ApiKey = null; _ApiKeyIsLoaded = true; }  else _ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				_OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { _Owner = null; _OwnerIsLoaded = true; }  else _Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PaCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_PackageName = ClassConnectionProvider.GetDatabaseParameter("PackageName", typeof(System.String), 1024);
				param_PackageName.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageName);
				command.Parameters.Add(param_PackageName);
				DbParameter param_VersionLabel = ClassConnectionProvider.GetDatabaseParameter("VersionLabel", typeof(System.String), 1024);
				param_VersionLabel.Value = ClassConnectionProvider.FromValueToSqlModelType(_VersionLabel);
				command.Parameters.Add(param_VersionLabel);
				DbParameter param_UploadDate = ClassConnectionProvider.GetDatabaseParameter("UploadDate", typeof(System.DateTime), -1);
				param_UploadDate.Value = ClassConnectionProvider.FromValueToSqlModelType(_UploadDate);
				command.Parameters.Add(param_UploadDate);
				DbParameter param_ApiKey_Id = ClassConnectionProvider.GetDatabaseParameter("ApiKey_Id", typeof(System.Guid), -1);
				param_ApiKey_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey_Id);
				if (_ApiKey == null) param_ApiKey_Id.Value = DBNull.Value;
				else param_ApiKey_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey.Id);
				command.Parameters.Add(param_ApiKey_Id);
				DbParameter param_Owner_Name = ClassConnectionProvider.GetDatabaseParameter("Owner_Name", typeof(System.String), 128);
				param_Owner_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Owner_Name);
				if (_Owner == null) param_Owner_Name.Value = DBNull.Value;
				else param_Owner_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Owner.Name);
				command.Parameters.Add(param_Owner_Name);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_PackageName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PackageName"], typeof(System.String));
				_VersionLabel = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VersionLabel"], typeof(System.String));
				_UploadDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UploadDate"], typeof(System.DateTime));
				_ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { _ApiKey = null; _ApiKeyIsLoaded = true; }  else _ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				_OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { _Owner = null; _OwnerIsLoaded = true; }  else _Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
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
        
        static public Package CreatePackage(System.Int32 __Id)
        {
            Package o = new Package(__Id);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PaUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				DbParameter param_PackageName = ClassConnectionProvider.GetDatabaseParameter("PackageName", typeof(System.String), 1024);
				param_PackageName.Value = ClassConnectionProvider.FromValueToSqlModelType(_PackageName);
				command.Parameters.Add(param_PackageName);
				DbParameter param_VersionLabel = ClassConnectionProvider.GetDatabaseParameter("VersionLabel", typeof(System.String), 1024);
				param_VersionLabel.Value = ClassConnectionProvider.FromValueToSqlModelType(_VersionLabel);
				command.Parameters.Add(param_VersionLabel);
				DbParameter param_UploadDate = ClassConnectionProvider.GetDatabaseParameter("UploadDate", typeof(System.DateTime), -1);
				param_UploadDate.Value = ClassConnectionProvider.FromValueToSqlModelType(_UploadDate);
				command.Parameters.Add(param_UploadDate);
				DbParameter param_ApiKeyHasChanged = ClassConnectionProvider.GetDatabaseParameter("ApiKeyHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_ApiKeyIsLoaded));
				command.Parameters.Add(param_ApiKeyHasChanged);
				DbParameter param_ApiKey_Id = ClassConnectionProvider.GetDatabaseParameter("ApiKey_Id", typeof(System.Guid), -1);
				param_ApiKey_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey_Id);
				if (_ApiKey == null) param_ApiKey_Id.Value = DBNull.Value;
				else param_ApiKey_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey.Id);
				command.Parameters.Add(param_ApiKey_Id);
				DbParameter param_OwnerHasChanged = ClassConnectionProvider.GetDatabaseParameter("OwnerHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_OwnerIsLoaded));
				command.Parameters.Add(param_OwnerHasChanged);
				DbParameter param_Owner_Name = ClassConnectionProvider.GetDatabaseParameter("Owner_Name", typeof(System.String), 128);
				param_Owner_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Owner_Name);
				if (_Owner == null) param_Owner_Name.Value = DBNull.Value;
				else param_Owner_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Owner.Name);
				command.Parameters.Add(param_Owner_Name);
				

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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PaDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
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
        
        static public void DeletePackage(System.Int32 __Id)
        {
            Package o = new Package(__Id);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(Package _object)
        {
			_ApiKey = null;
			_ApiKeyIsLoaded = false;
			_Owner = null;
			_OwnerIsLoaded = false;
			_Id = _object._Id;
			_PackageName = _object._PackageName;
			_VersionLabel = _object._VersionLabel;
			_UploadDate = _object._UploadDate;
			
        }
        
        public void CopyWithKeysTo(Package _object)
        {
			_object._ApiKey = null;
			_object._ApiKeyIsLoaded = false;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Id = _Id;
			_object._PackageName = _PackageName;
			_object._VersionLabel = _VersionLabel;
			_object._UploadDate = _UploadDate;
			
        }
        
        static public void CopyWithKeysObject(Package _objectFrom, Package _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(Package _object)
        {
			_ApiKey = null;
			_ApiKeyIsLoaded = false;
			_Owner = null;
			_OwnerIsLoaded = false;
			_PackageName = _object._PackageName;
			_VersionLabel = _object._VersionLabel;
			_UploadDate = _object._UploadDate;
			
        }
        
        public void CopyTo(Package _object)
        {
			_object._ApiKey = null;
			_object._ApiKeyIsLoaded = false;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._PackageName = _PackageName;
			_object._VersionLabel = _VersionLabel;
			_object._UploadDate = _UploadDate;
			
        }
        
        static public void CopyObject(Package _objectFrom, Package _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(Package).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(Package).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(Package _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			PackageUndoRedoCollection allUndidAndNotRedoneEntries = PackageUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			PackageUndoRedo _urobject = new PackageUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.ApiKey_Id = _object._ApiKey_Id;
			_urobject.Owner_Name = _object._Owner_Name;
			_urobject.Id = _object._Id;
			_urobject.PackageName = _object._PackageName;
			_urobject.VersionLabel = _object._VersionLabel;
			_urobject.UploadDate = _object._UploadDate;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(Package).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = PackageUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				PackageUndoRedoCollection allOldUndoEntries = PackageUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			PackageUndoRedoCollection firstUndoEntries = PackageUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			PackageUndoRedo _urobject = firstUndoEntries[0];
			
			Package _object = new Package();
			_object._ApiKey = null;
			_object._ApiKeyIsLoaded = false;
			_object._ApiKey_Id = _urobject.ApiKey_Id;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Owner_Name = _urobject.Owner_Name;
			_object._Id = _urobject.Id;
			_object._PackageName = _urobject.PackageName;
			_object._VersionLabel = _urobject.VersionLabel;
			_object._UploadDate = _urobject.UploadDate;
			

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
			PackageUndoRedoCollection firstEntryToRedoEntries = PackageUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			PackageUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			Package _object = new Package();
			_object._ApiKey = null;
			_object._ApiKeyIsLoaded = false;
			_object._ApiKey_Id = _urobject.ApiKey_Id;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Owner_Name = _urobject.Owner_Name;
			_object._Id = _urobject.Id;
			_object._PackageName = _urobject.PackageName;
			_object._VersionLabel = _urobject.VersionLabel;
			_object._UploadDate = _urobject.UploadDate;
			

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
    /// Defines the contract for the PackageCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("decbdf45-8409-bd15-7c40-ccf8d6c054fa")]
    public interface IPackageCollection : IEnumerable<Package>
    {
        int IndexOf(Package item);
        void Insert(int index, Package item);
        void RemoveAt(int index);
        Package this[int index] { get; set; }
        void Add(Package item);
        void Clear();
        bool Contains(Package item);
        void CopyTo(Package[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(Package item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.Package
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("0a9ede3c-f6c2-064f-3f61-9b08eaaa679f")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class PackageCollection : IPackageCollection, IList<Package>, IHierarchicalEnumerable
    {
        List<Package> _list = new List<Package>();
        
        public static implicit operator List<Package>(PackageCollection collection)
        {
            return collection._list;
        }

        #region IList<Package> Members

        public int IndexOf(Package item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, Package item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public Package this[int index]
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

        #region ICollection<Package> Members

        public void Add(Package item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(Package item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(Package[] array, int arrayIndex)
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

        public bool Remove(Package item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<Package> Members

        public IEnumerator<Package> GetEnumerator()
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
	/// that share Services.Packages.Package objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Web.PackageWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class PackageWebService : WebService, IPackageService
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
        public bool Exists(Package _Package)
        {
			return _Package.Exists;
        }
		
		[WebMethod]
		public Package Read(System.Int32 __Id)
		{
			return new Package(__Id);
		}
		
		[WebMethod]
        public Package Reload(Package _Package)
        {
			_Package.Reload();
			return _Package;
        }
		
		[WebMethod]
        public Package Create(System.Int32 __Id)
        {
			return Package.CreatePackage(__Id);
        }
        
        [WebMethod]
        public void Delete(System.Int32 __Id)
        {
			Package.DeletePackage(__Id);
        }
        
        [WebMethod]
        public void UpdateObject(Package _Package)
        {
			_Package.Update();
        }
		
		[WebMethod]
        public void CreateObject(Package _Package)
        {
			_Package.Create();
        }
        
        [WebMethod]
        public void DeleteObject(Package _Package)
        {
			_Package.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			Package.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			Package.Redo();
        }
		[WebMethod]
		public PackageCollection GetByApiKey(Services.Packages.ApiKey _ApiKey)
		{
			return Package.GetByApiKey( _ApiKey);
		}
		[WebMethod]
		public PackageCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
		{
			return Package.GetByApiKeyPaged( _ApiKey, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey)
		{
			return Package.GetByApiKeyCount( _ApiKey);
		}
		[WebMethod]
		public Services.Packages.ApiKey GetApiKey(Package _Package)
		{
			_Package.Reload();
			return _Package.ApiKey;
		}
		[WebMethod]
		public void SetApiKey(Package _Package, Services.Packages.ApiKey _ApiKey)
		{
			_Package.Reload();
			_Package.ApiKey = _ApiKey;
			_Package.Update();
		}
		[WebMethod]
		public PackageCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
		{
			return Package.GetByOwner( _ModelUser);
		}
		[WebMethod]
		public PackageCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return Package.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return Package.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(Package _Package)
		{
			_Package.Reload();
			return _Package.Owner;
		}
		[WebMethod]
		public void SetOwner(Package _Package, Services.Packages.Security.ModelUser _Owner)
		{
			_Package.Reload();
			_Package.Owner = _Owner;
			_Package.Update();
		}
		[WebMethod]
		public PackageCollection SearchByPackageName(System.String PackageName )
		{
			return Package.SearchByPackageName(PackageName );
		}
		[WebMethod]
		public PackageCollection SearchByPackageNamePaged(System.String PackageName , long PagingStart, long PagingCount)
		{
			return Package.SearchByPackageNamePaged(PackageName , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByPackageNameCount(System.String PackageName )
		{
			return Package.SearchByPackageNameCount(PackageName );
		}
		[WebMethod]
		public PackageCollection SearchByPackageNameForApiKey(System.String PackageName, Services.Packages.ApiKey _ApiKey)
		{
			return Package.SearchByPackageNameForApiKey(PackageName,  _ApiKey);
		}
		[WebMethod]
		public PackageCollection SearchByPackageNameForApiKeyPaged(System.String PackageName, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
		{
			return Package.SearchByPackageNameForApiKeyPaged(PackageName,  _ApiKey, PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByPackageNameForApiKeyCount(System.String PackageName, Services.Packages.ApiKey _ApiKey)
		{
			return Package.SearchByPackageNameForApiKeyCount(PackageName,  _ApiKey);
		}
		[WebMethod]
		public Services.Packages.Security.PackageAccessControlListCollection GetACLs(Package _Package)
		{
			_Package.Reload();
			return _Package.ACLs;
		}
		[WebMethod]
		public void SetACLs(Package _Package, Services.Packages.Security.PackageAccessControlListCollection _ACLs)
		{
			_Package.Reload();
			_Package.ACLs = _ACLs;
			_Package.Update();
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="PackageWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("d905231e-e749-4bac-f18c-32014e841136")]
    sealed public class PackageWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IPackageService
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
		public PackageWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public PackageWebServiceClient()
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
		public bool Exists(Package _Package)
        {
			object[] results = this.Invoke("Exists", new object[] {_Package});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Package Read(System.Int32 __Id)
		{
			object[] results = this.Invoke("Read", new object[] {__Id});
			return ((Package)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Package Reload(Package _Package)
        {
			object[] results = this.Invoke("Reload", new object[] {_Package});
			return ((Package)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Package Create(System.Int32 __Id)
        {
			object[] results = this.Invoke("Create", new object[] {__Id});
			return ((Package)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.Int32 __Id)
        {
			this.Invoke("Delete", new object[] {__Id});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(Package _Package)
        {
			this.Invoke("UpdateObject", new object[] {_Package});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(Package _Package)
        {
			this.Invoke("CreateObject", new object[] {_Package});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(Package _Package)
        {
			this.Invoke("DeleteObject", new object[] {_Package});
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
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PackageCollection GetByApiKey(Services.Packages.ApiKey _ApiKey) {
			object[] results = this.Invoke("GetByApiKey", new object[] {_ApiKey});
			return ((PackageCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByApiKeyPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PackageCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByApiKeyPaged", new object[] {_ApiKey,PagingStart,PagingCount});
			return ((PackageCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByApiKeyCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey) {
			object[] results = this.Invoke("GetByApiKeyCount", new object[] {_ApiKey});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.ApiKey GetApiKey(Package _Package)
		{
			object[] results = this.Invoke("GetApiKey", new object[] {_Package});
			return ((Services.Packages.ApiKey)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetApiKey(Package _Package, Services.Packages.ApiKey _ApiKey)
		{
			this.Invoke("GetApiKey", new object[] {_Package});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PackageCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByOwner", new object[] {_ModelUser});
			return ((PackageCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PackageCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByOwnerPaged", new object[] {_ModelUser,PagingStart,PagingCount});
			return ((PackageCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByOwnerCount", new object[] {_ModelUser});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetOwner(Package _Package)
		{
			object[] results = this.Invoke("GetOwner", new object[] {_Package});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetOwner(Package _Package, Services.Packages.Security.ModelUser _Owner)
		{
			this.Invoke("GetOwner", new object[] {_Package});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByPackageName", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PackageCollection SearchByPackageName(System.String PackageName ) {
			object[] results = this.Invoke("SearchByPackageName", new object[] {PackageName});
			return ((PackageCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByPackageNamePaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PackageCollection SearchByPackageNamePaged(System.String PackageName , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("SearchByPackageNamePaged", new object[] {PackageName,PagingStart,PagingCount});
			return ((PackageCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByPackageNameCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByPackageNameCount(System.String PackageName ) {
			object[] results = this.Invoke("SearchByPackageNameCount", new object[] {PackageName});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByPackageNameForApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PackageCollection SearchByPackageNameForApiKey(System.String PackageName, Services.Packages.ApiKey _ApiKey) {
			object[] results = this.Invoke("SearchByPackageNameForApiKey", new object[] {PackageName, _ApiKey});
			return ((PackageCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByPackageNameForApiKeyPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PackageCollection SearchByPackageNameForApiKeyPaged(System.String PackageName, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("SearchByPackageNameForApiKeyPaged", new object[] {PackageName, _ApiKey,PagingStart,PagingCount});
			return ((PackageCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByPackageNameForApiKeyCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByPackageNameForApiKeyCount(System.String PackageName, Services.Packages.ApiKey _ApiKey) {
			object[] results = this.Invoke("SearchByPackageNameForApiKeyCount", new object[] {PackageName, _ApiKey});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.PackageAccessControlListCollection GetACLs(Package _Package)
		{
			object[] results = this.Invoke("GetACLs", new object[] {_Package});
			return ((Services.Packages.Security.PackageAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACLs(Package _Package, Services.Packages.Security.PackageAccessControlListCollection _ACLs)
		{
			this.Invoke("GetACLs", new object[] {_Package});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages
