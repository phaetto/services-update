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
    /// Defines the contract for the Purchase class
    /// </summary>
    [ComVisible(true)]
    [Guid("6423ae68-e2a1-9fc8-5255-9b4cda5b4c90")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IPurchase
	{
		bool Exists { get; }
		System.Int32 Id { get; set; }
		System.DateTime CreationDate { get; set; }
		Services.Packages.ApiKey ApiKey { get; set; }
		Services.Packages.Security.ModelUser Client { get; set; }
		Services.Packages.Security.ModelUser Owner { get; set; }
		Services.Packages.PurchaseLineCollection OrderLines { get; set; }
		Services.Packages.Security.PurchaseAccessControlListCollection ACLs { get; set; }
		Services.Packages.Security.PurchaseAccessControlListCollection GetACLs(System.String UserName);

		void Read(System.Int32 __Id);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(Purchase _object);
		void CopyWithKeysTo(Purchase _object);
		void CopyFrom(Purchase _object);
		void CopyTo(Purchase _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.Purchase type.
    /// </summary>
    [ComVisible(true)]
    [Guid("26edc0bb-e5ff-ee06-3201-cfb1ef45a5b2")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IPurchaseService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(Purchase _Purchase);
		[OperationContract]
        Purchase Read(System.Int32 __Id);
        [OperationContract]
        Purchase Reload(Purchase _Purchase);
        [OperationContract]
        Purchase Create(System.Int32 __Id);
        [OperationContract]
        void Delete(System.Int32 __Id);
        [OperationContract]
        void UpdateObject(Purchase _Purchase);
        [OperationContract]
        void CreateObject(Purchase _Purchase);
        [OperationContract]
        void DeleteObject(Purchase _Purchase);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		PurchaseCollection GetByApiKey(Services.Packages.ApiKey _ApiKey);
		[OperationContract]
		PurchaseCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey);
		[OperationContract]
		Services.Packages.ApiKey GetApiKey(Purchase _Purchase);
		[OperationContract]
		void SetApiKey(Purchase _Purchase, Services.Packages.ApiKey _ApiKey);
		[OperationContract]
		PurchaseCollection GetByClient(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		PurchaseCollection GetByClientPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByClientCount(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		Services.Packages.Security.ModelUser GetClient(Purchase _Purchase);
		[OperationContract]
		void SetClient(Purchase _Purchase, Services.Packages.Security.ModelUser _Client);
		[OperationContract]
		PurchaseCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		PurchaseCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		Services.Packages.Security.ModelUser GetOwner(Purchase _Purchase);
		[OperationContract]
		void SetOwner(Purchase _Purchase, Services.Packages.Security.ModelUser _Owner);
		[OperationContract]
		PurchaseCollection GetAll(System.String dummy );
		[OperationContract]
		PurchaseCollection GetAllPaged(System.String dummy , long PagingStart, long PagingCount);
		[OperationContract]
		long GetAllCount(System.String dummy );
		[OperationContract]
		Services.Packages.PurchaseLineCollection GetOrderLines(Purchase _Purchase);
		[OperationContract]
		void SetOrderLines(Purchase _Purchase, Services.Packages.PurchaseLineCollection _OrderLines);
		[OperationContract]
		Services.Packages.Security.PurchaseAccessControlListCollection GetACLs(Purchase _Purchase);
		[OperationContract]
		void SetACLs(Purchase _Purchase, Services.Packages.Security.PurchaseAccessControlListCollection _ACLs);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.Purchase type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("f61d3ddb-26ff-fd02-92f3-c87d369f68d9")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class PurchaseService : IPurchaseService
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
        public bool Exists(Purchase _Purchase)
        {
			return _Purchase.Exists;
        }
		
		[WebMethod]
		public Purchase Read(System.Int32 __Id)
		{
			return new Purchase(__Id);
		}
		
		[WebMethod]
        public Purchase Reload(Purchase _Purchase)
        {
			_Purchase.Reload();
			return _Purchase;
        }
		
		[WebMethod]
        public Purchase Create(System.Int32 __Id)
        {
			return Purchase.CreatePurchase(__Id);
        }
        
        [WebMethod]
        public void Delete(System.Int32 __Id)
        {
			Purchase.DeletePurchase(__Id);
        }
        
        [WebMethod]
        public void UpdateObject(Purchase _Purchase)
        {
			_Purchase.Update();
        }
		
		[WebMethod]
        public void CreateObject(Purchase _Purchase)
        {
			_Purchase.Create();
        }
        
        [WebMethod]
        public void DeleteObject(Purchase _Purchase)
        {
			_Purchase.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			Purchase.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			Purchase.Redo();
        }
		[WebMethod]
		public PurchaseCollection GetByApiKey(Services.Packages.ApiKey _ApiKey)
		{
			return Purchase.GetByApiKey( _ApiKey);
		}
		[WebMethod]
		public PurchaseCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
		{
			return Purchase.GetByApiKeyPaged( _ApiKey, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey)
		{
			return Purchase.GetByApiKeyCount( _ApiKey);
		}
		[WebMethod]
		public Services.Packages.ApiKey GetApiKey(Purchase _Purchase)
		{
			_Purchase.Reload();
			return _Purchase.ApiKey;
		}
		[WebMethod]
		public void SetApiKey(Purchase _Purchase, Services.Packages.ApiKey _ApiKey)
		{
			_Purchase.Reload();
			_Purchase.ApiKey = _ApiKey;
			_Purchase.Update();
		}
		[WebMethod]
		public PurchaseCollection GetByClient(Services.Packages.Security.ModelUser _ModelUser)
		{
			return Purchase.GetByClient( _ModelUser);
		}
		[WebMethod]
		public PurchaseCollection GetByClientPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return Purchase.GetByClientPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByClientCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return Purchase.GetByClientCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetClient(Purchase _Purchase)
		{
			_Purchase.Reload();
			return _Purchase.Client;
		}
		[WebMethod]
		public void SetClient(Purchase _Purchase, Services.Packages.Security.ModelUser _Client)
		{
			_Purchase.Reload();
			_Purchase.Client = _Client;
			_Purchase.Update();
		}
		[WebMethod]
		public PurchaseCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
		{
			return Purchase.GetByOwner( _ModelUser);
		}
		[WebMethod]
		public PurchaseCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return Purchase.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return Purchase.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(Purchase _Purchase)
		{
			_Purchase.Reload();
			return _Purchase.Owner;
		}
		[WebMethod]
		public void SetOwner(Purchase _Purchase, Services.Packages.Security.ModelUser _Owner)
		{
			_Purchase.Reload();
			_Purchase.Owner = _Owner;
			_Purchase.Update();
		}
		[WebMethod]
		public PurchaseCollection GetAll(System.String dummy )
		{
			return Purchase.GetAll(dummy );
		}
		[WebMethod]
		public PurchaseCollection GetAllPaged(System.String dummy , long PagingStart, long PagingCount)
		{
			return Purchase.GetAllPaged(dummy , PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetAllCount(System.String dummy )
		{
			return Purchase.GetAllCount(dummy );
		}
		[WebMethod]
		public Services.Packages.PurchaseLineCollection GetOrderLines(Purchase _Purchase)
		{
			_Purchase.Reload();
			return _Purchase.OrderLines;
		}
		[WebMethod]
		public void SetOrderLines(Purchase _Purchase, Services.Packages.PurchaseLineCollection _OrderLines)
		{
			_Purchase.Reload();
			_Purchase.OrderLines = _OrderLines;
			_Purchase.Update();
		}
		[WebMethod]
		public Services.Packages.Security.PurchaseAccessControlListCollection GetACLs(Purchase _Purchase)
		{
			_Purchase.Reload();
			return _Purchase.ACLs;
		}
		[WebMethod]
		public void SetACLs(Purchase _Purchase, Services.Packages.Security.PurchaseAccessControlListCollection _ACLs)
		{
			_Purchase.Reload();
			_Purchase.ACLs = _ACLs;
			_Purchase.Update();
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.Purchase model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("174b0179-a5b4-837b-a835-32a01217af0c")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class Purchase : IPurchase, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<IPurchaseService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<IPurchaseService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<IPurchaseService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Purchase"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Purchase"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.Purchase.ProviderType");
				
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

		System.DateTime _CreationDate;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.DateTime CreationDate
		{
            get
            {
                return _CreationDate;
            }
            set
            {
                _CreationDate = value;
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
		
		public static Services.Packages.ApiKey GetApiKey(Purchase _Purchase)
		{
			return _Purchase.ApiKey;
		}

		bool _ClientIsLoaded = false;
		Services.Packages.Security.ModelUser _Client;
		System.String _Client_Name; 
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.ModelUser Client
		{
            get
            {
				if (!_ClientIsLoaded)
				{
					_Client = new Services.Packages.Security.ModelUser(_Client_Name);
					if (_Client.Exists)
						_ClientIsLoaded = true;
					else _Client = null;
				}
                return _Client;
            }
            set
            {
                _Client = value;
                _ClientIsLoaded = true;
                if (_Client != null)
                {
					if (_Client.Exists)
					{
						_Client_Name = _Client.Name;
						
					}
					else
					{
						_Client = null;
					}
				}
            }
		}
		
		public static Services.Packages.Security.ModelUser GetClient(Purchase _Purchase)
		{
			return _Purchase.Client;
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
		
		public static Services.Packages.Security.ModelUser GetOwner(Purchase _Purchase)
		{
			return _Purchase.Owner;
		}

		public static PurchaseCollection GetByApiKey(Services.Packages.ApiKey _ApiKey)
        {
			PurchaseCollection _PurchaseCollection = new PurchaseCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuGetByApKe", dbconn);
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
					Purchase o = new Purchase();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._CreationDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CreationDate"], typeof(System.DateTime));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ClientIsLoaded = false; if (dr["Client_Name"] == DBNull.Value) { o._Client = null; o._ClientIsLoaded = true; }  else o._Client_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Client_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PurchaseCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PurchaseCollection;
        }
        
        public static PurchaseCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
        {
			PurchaseCollection _PurchaseCollection = new PurchaseCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuGetByApKePaged", dbconn);
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
					Purchase o = new Purchase();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._CreationDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CreationDate"], typeof(System.DateTime));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ClientIsLoaded = false; if (dr["Client_Name"] == DBNull.Value) { o._Client = null; o._ClientIsLoaded = true; }  else o._Client_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Client_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PurchaseCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PurchaseCollection;
        }
        
        public static long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuGetByApKeCount", dbconn);
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

		public static PurchaseCollection GetByClient(Services.Packages.Security.ModelUser _ModelUser)
        {
			PurchaseCollection _PurchaseCollection = new PurchaseCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuGetByCl", dbconn);
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
					Purchase o = new Purchase();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._CreationDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CreationDate"], typeof(System.DateTime));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ClientIsLoaded = false; if (dr["Client_Name"] == DBNull.Value) { o._Client = null; o._ClientIsLoaded = true; }  else o._Client_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Client_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PurchaseCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PurchaseCollection;
        }
        
        public static PurchaseCollection GetByClientPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			PurchaseCollection _PurchaseCollection = new PurchaseCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuGetByClPaged", dbconn);
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
					Purchase o = new Purchase();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._CreationDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CreationDate"], typeof(System.DateTime));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ClientIsLoaded = false; if (dr["Client_Name"] == DBNull.Value) { o._Client = null; o._ClientIsLoaded = true; }  else o._Client_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Client_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PurchaseCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PurchaseCollection;
        }
        
        public static long GetByClientCount(Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuGetByClCount", dbconn);
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

		public static PurchaseCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
        {
			PurchaseCollection _PurchaseCollection = new PurchaseCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuGetByOw", dbconn);
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
					Purchase o = new Purchase();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._CreationDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CreationDate"], typeof(System.DateTime));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ClientIsLoaded = false; if (dr["Client_Name"] == DBNull.Value) { o._Client = null; o._ClientIsLoaded = true; }  else o._Client_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Client_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PurchaseCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PurchaseCollection;
        }
        
        public static PurchaseCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			PurchaseCollection _PurchaseCollection = new PurchaseCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuGetByOwPaged", dbconn);
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
					Purchase o = new Purchase();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._CreationDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CreationDate"], typeof(System.DateTime));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ClientIsLoaded = false; if (dr["Client_Name"] == DBNull.Value) { o._Client = null; o._ClientIsLoaded = true; }  else o._Client_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Client_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PurchaseCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PurchaseCollection;
        }
        
        public static long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuGetByOwCount", dbconn);
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

		public static PurchaseCollection GetAll(System.String _dummy)
        {
			PurchaseCollection _PurchaseCollection = new PurchaseCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuGeAl", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _dummy = ClassConnectionProvider.Escape(_dummy);
				
                
                DbParameter param_dummy = ClassConnectionProvider.GetDatabaseParameter("dummy", typeof(System.String), -1);
				param_dummy.Value = ClassConnectionProvider.FromValueToSqlModelType(_dummy);
				command.Parameters.Add(param_dummy);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					Purchase o = new Purchase();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._CreationDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CreationDate"], typeof(System.DateTime));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ClientIsLoaded = false; if (dr["Client_Name"] == DBNull.Value) { o._Client = null; o._ClientIsLoaded = true; }  else o._Client_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Client_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PurchaseCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PurchaseCollection;
        }
        
        public static PurchaseCollection GetAllPaged(System.String _dummy, long PagingStart, long PagingCount)
        {
			PurchaseCollection _PurchaseCollection = new PurchaseCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuGeAlPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _dummy = ClassConnectionProvider.Escape(_dummy);
				
                
                DbParameter param_dummy = ClassConnectionProvider.GetDatabaseParameter("dummy", typeof(System.String), -1);
				param_dummy.Value = ClassConnectionProvider.FromValueToSqlModelType(_dummy);
				command.Parameters.Add(param_dummy);
				
                
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
					Purchase o = new Purchase();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._CreationDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CreationDate"], typeof(System.DateTime));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ClientIsLoaded = false; if (dr["Client_Name"] == DBNull.Value) { o._Client = null; o._ClientIsLoaded = true; }  else o._Client_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Client_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PurchaseCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PurchaseCollection;
        }
        
        public static long GetAllCount(System.String _dummy)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuGeAlCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _dummy = ClassConnectionProvider.Escape(_dummy);
				
                
                DbParameter param_dummy = ClassConnectionProvider.GetDatabaseParameter("dummy", typeof(System.String), -1);
				param_dummy.Value = ClassConnectionProvider.FromValueToSqlModelType(_dummy);
				command.Parameters.Add(param_dummy);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		Services.Packages.PurchaseLineCollection _OrderLines;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.PurchaseLineCollection OrderLines
		{
            get
            {
				if (_OrderLines == null)
					_OrderLines = Services.Packages.PurchaseLine.GetByPurchaseOrder(this);
				
				return _OrderLines;
            }
            set
            {
				if (this.Exists)
				{
					if (_OrderLines != null)
					{
						for(int n = 0; n < _OrderLines.Count; ++n)
						{
							_OrderLines[n].PurchaseOrder = null;
							_OrderLines[n].Update();
						}
					}
	                
					_OrderLines = value;
					
					if (_OrderLines != null)
					{
						for(int n = 0; n < _OrderLines.Count; ++n)
						{
							_OrderLines[n].PurchaseOrder = this;
							_OrderLines[n].Create();
						}
					}
				}
				else
				{
					_OrderLines = value;
				}
            }
		}
		
		public void ReloadOrderLines()
		{
			_OrderLines = Services.Packages.PurchaseLine.GetByPurchaseOrder(this);
		}

		Services.Packages.Security.PurchaseAccessControlListCollection _ACLs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.PurchaseAccessControlListCollection ACLs
		{
            get
            {
				if (_ACLs == null)
					_ACLs = Services.Packages.Security.PurchaseAccessControlList.GetByPurchase(this);
				
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
							_ACLs[n].Purchase = null;
							_ACLs[n].Update();
						}
					}
	                
					_ACLs = value;
					
					if (_ACLs != null)
					{
						for(int n = 0; n < _ACLs.Count; ++n)
						{
							_ACLs[n].Purchase = this;
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
			_ACLs = Services.Packages.Security.PurchaseAccessControlList.GetByPurchase(this);
		}

		public Services.Packages.Security.PurchaseAccessControlListCollection GetACLs(System.String UserName)
		{
			return Services.Packages.Security.PurchaseAccessControlList.GetACLs(UserName,  this);
		}

		public bool Exists
        {
            get {
				if (!__hasBeenReadOnce)
					Exist();
				
				return __databaseState == RowState.Initialized;
			}
        }
        
        public Purchase() {}
        
        public Purchase(System.Int32 __Id)
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
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuRead", dbconn);
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
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "Pu");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuRead", dbconn);
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
				_CreationDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CreationDate"], typeof(System.DateTime));
				_ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { _ApiKey = null; _ApiKeyIsLoaded = true; }  else _ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				_ClientIsLoaded = false; if (dr["Client_Name"] == DBNull.Value) { _Client = null; _ClientIsLoaded = true; }  else _Client_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Client_Name"], typeof(System.String));
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "Pu");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_CreationDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CreationDate"], typeof(System.DateTime));
				_ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { _ApiKey = null; _ApiKeyIsLoaded = true; }  else _ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				_ClientIsLoaded = false; if (dr["Client_Name"] == DBNull.Value) { _Client = null; _ClientIsLoaded = true; }  else _Client_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Client_Name"], typeof(System.String));
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
					//*
					if (IsUndoRedoSupported) MarkUndo(this, true, false, false);
					//*/

					// sql create
					using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
					{
						dbconn.Open();
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_CreationDate = ClassConnectionProvider.GetDatabaseParameter("CreationDate", typeof(System.DateTime), -1);
				param_CreationDate.Value = ClassConnectionProvider.FromValueToSqlModelType(_CreationDate);
				command.Parameters.Add(param_CreationDate);
				DbParameter param_ApiKey_Id = ClassConnectionProvider.GetDatabaseParameter("ApiKey_Id", typeof(System.Guid), -1);
				param_ApiKey_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey_Id);
				if (_ApiKey == null) param_ApiKey_Id.Value = DBNull.Value;
				else param_ApiKey_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey.Id);
				command.Parameters.Add(param_ApiKey_Id);
				DbParameter param_Client_Name = ClassConnectionProvider.GetDatabaseParameter("Client_Name", typeof(System.String), 128);
				param_Client_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Client_Name);
				if (_Client == null) param_Client_Name.Value = DBNull.Value;
				else param_Client_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Client.Name);
				command.Parameters.Add(param_Client_Name);
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
				_CreationDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CreationDate"], typeof(System.DateTime));
				_ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { _ApiKey = null; _ApiKeyIsLoaded = true; }  else _ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				_ClientIsLoaded = false; if (dr["Client_Name"] == DBNull.Value) { _Client = null; _ClientIsLoaded = true; }  else _Client_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Client_Name"], typeof(System.String));
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
        
        static public Purchase CreatePurchase(System.Int32 __Id)
        {
            Purchase o = new Purchase(__Id);
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
				//*
				if (IsUndoRedoSupported) MarkUndo(this, false, false, true);
				//*/
				
				// sql update
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				DbParameter param_CreationDate = ClassConnectionProvider.GetDatabaseParameter("CreationDate", typeof(System.DateTime), -1);
				param_CreationDate.Value = ClassConnectionProvider.FromValueToSqlModelType(_CreationDate);
				command.Parameters.Add(param_CreationDate);
				DbParameter param_ApiKeyHasChanged = ClassConnectionProvider.GetDatabaseParameter("ApiKeyHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_ApiKeyIsLoaded));
				command.Parameters.Add(param_ApiKeyHasChanged);
				DbParameter param_ApiKey_Id = ClassConnectionProvider.GetDatabaseParameter("ApiKey_Id", typeof(System.Guid), -1);
				param_ApiKey_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey_Id);
				if (_ApiKey == null) param_ApiKey_Id.Value = DBNull.Value;
				else param_ApiKey_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey.Id);
				command.Parameters.Add(param_ApiKey_Id);
				DbParameter param_ClientHasChanged = ClassConnectionProvider.GetDatabaseParameter("ClientHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_ClientIsLoaded));
				command.Parameters.Add(param_ClientHasChanged);
				DbParameter param_Client_Name = ClassConnectionProvider.GetDatabaseParameter("Client_Name", typeof(System.String), 128);
				param_Client_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Client_Name);
				if (_Client == null) param_Client_Name.Value = DBNull.Value;
				else param_Client_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Client.Name);
				command.Parameters.Add(param_Client_Name);
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
				//*
				if (IsUndoRedoSupported) MarkUndo(this, false, true, false);
				//*/

				// sql-delete
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuDelete", dbconn);
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
        
        static public void DeletePurchase(System.Int32 __Id)
        {
            Purchase o = new Purchase(__Id);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(Purchase _object)
        {
			_ApiKey = null;
			_ApiKeyIsLoaded = false;
			_Client = null;
			_ClientIsLoaded = false;
			_Owner = null;
			_OwnerIsLoaded = false;
			_Id = _object._Id;
			_CreationDate = _object._CreationDate;
			
        }
        
        public void CopyWithKeysTo(Purchase _object)
        {
			_object._ApiKey = null;
			_object._ApiKeyIsLoaded = false;
			_object._Client = null;
			_object._ClientIsLoaded = false;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Id = _Id;
			_object._CreationDate = _CreationDate;
			
        }
        
        static public void CopyWithKeysObject(Purchase _objectFrom, Purchase _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(Purchase _object)
        {
			_ApiKey = null;
			_ApiKeyIsLoaded = false;
			_Client = null;
			_ClientIsLoaded = false;
			_Owner = null;
			_OwnerIsLoaded = false;
			_CreationDate = _object._CreationDate;
			
        }
        
        public void CopyTo(Purchase _object)
        {
			_object._ApiKey = null;
			_object._ApiKeyIsLoaded = false;
			_object._Client = null;
			_object._ClientIsLoaded = false;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._CreationDate = _CreationDate;
			
        }
        
        static public void CopyObject(Purchase _objectFrom, Purchase _objectTo)
        {
			_objectFrom.CopyTo(_objectTo);
        }
        
        #endregion

		#region Undo / Redo functionality

		//*
		private static bool isUndoRedoSupported = false;
		private static bool isUndoRedoSupportedHasBeenLoaded = false;
		private static long undoRedoMaximumObjects = -1;
		public static bool IsUndoRedoSupported
		{
			get {
				if (!isUndoRedoSupportedHasBeenLoaded) {
					// Load options undo entity once
					isUndoRedoSupportedHasBeenLoaded = true;

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(Purchase).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(Purchase).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(Purchase _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			PurchaseUndoRedoCollection allUndidAndNotRedoneEntries = PurchaseUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			PurchaseUndoRedo _urobject = new PurchaseUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.ApiKey_Id = _object._ApiKey_Id;
			_urobject.Client_Name = _object._Client_Name;
			_urobject.Owner_Name = _object._Owner_Name;
			_urobject.Id = _object._Id;
			_urobject.CreationDate = _object._CreationDate;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(Purchase).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = PurchaseUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				PurchaseUndoRedoCollection allOldUndoEntries = PurchaseUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			PurchaseUndoRedoCollection firstUndoEntries = PurchaseUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			PurchaseUndoRedo _urobject = firstUndoEntries[0];
			
			Purchase _object = new Purchase();
			_object._ApiKey = null;
			_object._ApiKeyIsLoaded = false;
			_object._ApiKey_Id = _urobject.ApiKey_Id;
			_object._Client = null;
			_object._ClientIsLoaded = false;
			_object._Client_Name = _urobject.Client_Name;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Owner_Name = _urobject.Owner_Name;
			_object._Id = _urobject.Id;
			_object._CreationDate = _urobject.CreationDate;
			

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
			PurchaseUndoRedoCollection firstEntryToRedoEntries = PurchaseUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			PurchaseUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			Purchase _object = new Purchase();
			_object._ApiKey = null;
			_object._ApiKeyIsLoaded = false;
			_object._ApiKey_Id = _urobject.ApiKey_Id;
			_object._Client = null;
			_object._ClientIsLoaded = false;
			_object._Client_Name = _urobject.Client_Name;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Owner_Name = _urobject.Owner_Name;
			_object._Id = _urobject.Id;
			_object._CreationDate = _urobject.CreationDate;
			

			_urobject.IsUndone = false;
			_urobject.Update();

			// Do the opposite action
			if (_urobject.IsDeletedUndoCreates)
				_object.Delete(); // Delete again
			else if (_urobject.IsCreatedUndoDeletes || _urobject.IsUpdatedUndoUpdates)
				_object.Create(); // Create or update again
        }

		//*/ // Undo redo enabled

		/*
		
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
    /// Defines the contract for the PurchaseCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("9d70e9af-563d-9491-bdf0-940b1c88b792")]
    public interface IPurchaseCollection : IEnumerable<Purchase>
    {
        int IndexOf(Purchase item);
        void Insert(int index, Purchase item);
        void RemoveAt(int index);
        Purchase this[int index] { get; set; }
        void Add(Purchase item);
        void Clear();
        bool Contains(Purchase item);
        void CopyTo(Purchase[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(Purchase item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.Purchase
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("ee38f599-8efa-36fe-c199-4dcaf362ea7b")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class PurchaseCollection : IPurchaseCollection, IList<Purchase>, IHierarchicalEnumerable
    {
        List<Purchase> _list = new List<Purchase>();
        
        public static implicit operator List<Purchase>(PurchaseCollection collection)
        {
            return collection._list;
        }

        #region IList<Purchase> Members

        public int IndexOf(Purchase item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, Purchase item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public Purchase this[int index]
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

        #region ICollection<Purchase> Members

        public void Add(Purchase item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(Purchase item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(Purchase[] array, int arrayIndex)
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

        public bool Remove(Purchase item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<Purchase> Members

        public IEnumerator<Purchase> GetEnumerator()
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
	/// that share Services.Packages.Purchase objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Web.PurchaseWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class PurchaseWebService : WebService, IPurchaseService
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
        public bool Exists(Purchase _Purchase)
        {
			return _Purchase.Exists;
        }
		
		[WebMethod]
		public Purchase Read(System.Int32 __Id)
		{
			return new Purchase(__Id);
		}
		
		[WebMethod]
        public Purchase Reload(Purchase _Purchase)
        {
			_Purchase.Reload();
			return _Purchase;
        }
		
		[WebMethod]
        public Purchase Create(System.Int32 __Id)
        {
			return Purchase.CreatePurchase(__Id);
        }
        
        [WebMethod]
        public void Delete(System.Int32 __Id)
        {
			Purchase.DeletePurchase(__Id);
        }
        
        [WebMethod]
        public void UpdateObject(Purchase _Purchase)
        {
			_Purchase.Update();
        }
		
		[WebMethod]
        public void CreateObject(Purchase _Purchase)
        {
			_Purchase.Create();
        }
        
        [WebMethod]
        public void DeleteObject(Purchase _Purchase)
        {
			_Purchase.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			Purchase.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			Purchase.Redo();
        }
		[WebMethod]
		public PurchaseCollection GetByApiKey(Services.Packages.ApiKey _ApiKey)
		{
			return Purchase.GetByApiKey( _ApiKey);
		}
		[WebMethod]
		public PurchaseCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
		{
			return Purchase.GetByApiKeyPaged( _ApiKey, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey)
		{
			return Purchase.GetByApiKeyCount( _ApiKey);
		}
		[WebMethod]
		public Services.Packages.ApiKey GetApiKey(Purchase _Purchase)
		{
			_Purchase.Reload();
			return _Purchase.ApiKey;
		}
		[WebMethod]
		public void SetApiKey(Purchase _Purchase, Services.Packages.ApiKey _ApiKey)
		{
			_Purchase.Reload();
			_Purchase.ApiKey = _ApiKey;
			_Purchase.Update();
		}
		[WebMethod]
		public PurchaseCollection GetByClient(Services.Packages.Security.ModelUser _ModelUser)
		{
			return Purchase.GetByClient( _ModelUser);
		}
		[WebMethod]
		public PurchaseCollection GetByClientPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return Purchase.GetByClientPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByClientCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return Purchase.GetByClientCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetClient(Purchase _Purchase)
		{
			_Purchase.Reload();
			return _Purchase.Client;
		}
		[WebMethod]
		public void SetClient(Purchase _Purchase, Services.Packages.Security.ModelUser _Client)
		{
			_Purchase.Reload();
			_Purchase.Client = _Client;
			_Purchase.Update();
		}
		[WebMethod]
		public PurchaseCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
		{
			return Purchase.GetByOwner( _ModelUser);
		}
		[WebMethod]
		public PurchaseCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return Purchase.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return Purchase.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(Purchase _Purchase)
		{
			_Purchase.Reload();
			return _Purchase.Owner;
		}
		[WebMethod]
		public void SetOwner(Purchase _Purchase, Services.Packages.Security.ModelUser _Owner)
		{
			_Purchase.Reload();
			_Purchase.Owner = _Owner;
			_Purchase.Update();
		}
		[WebMethod]
		public PurchaseCollection GetAll(System.String dummy )
		{
			return Purchase.GetAll(dummy );
		}
		[WebMethod]
		public PurchaseCollection GetAllPaged(System.String dummy , long PagingStart, long PagingCount)
		{
			return Purchase.GetAllPaged(dummy , PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetAllCount(System.String dummy )
		{
			return Purchase.GetAllCount(dummy );
		}
		[WebMethod]
		public Services.Packages.PurchaseLineCollection GetOrderLines(Purchase _Purchase)
		{
			_Purchase.Reload();
			return _Purchase.OrderLines;
		}
		[WebMethod]
		public void SetOrderLines(Purchase _Purchase, Services.Packages.PurchaseLineCollection _OrderLines)
		{
			_Purchase.Reload();
			_Purchase.OrderLines = _OrderLines;
			_Purchase.Update();
		}
		[WebMethod]
		public Services.Packages.Security.PurchaseAccessControlListCollection GetACLs(Purchase _Purchase)
		{
			_Purchase.Reload();
			return _Purchase.ACLs;
		}
		[WebMethod]
		public void SetACLs(Purchase _Purchase, Services.Packages.Security.PurchaseAccessControlListCollection _ACLs)
		{
			_Purchase.Reload();
			_Purchase.ACLs = _ACLs;
			_Purchase.Update();
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="PurchaseWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("4dcebc43-ca2e-239b-6fb6-59c41170671f")]
    sealed public class PurchaseWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IPurchaseService
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
		public PurchaseWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public PurchaseWebServiceClient()
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
		public bool Exists(Purchase _Purchase)
        {
			object[] results = this.Invoke("Exists", new object[] {_Purchase});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Purchase Read(System.Int32 __Id)
		{
			object[] results = this.Invoke("Read", new object[] {__Id});
			return ((Purchase)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Purchase Reload(Purchase _Purchase)
        {
			object[] results = this.Invoke("Reload", new object[] {_Purchase});
			return ((Purchase)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Purchase Create(System.Int32 __Id)
        {
			object[] results = this.Invoke("Create", new object[] {__Id});
			return ((Purchase)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.Int32 __Id)
        {
			this.Invoke("Delete", new object[] {__Id});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(Purchase _Purchase)
        {
			this.Invoke("UpdateObject", new object[] {_Purchase});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(Purchase _Purchase)
        {
			this.Invoke("CreateObject", new object[] {_Purchase});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(Purchase _Purchase)
        {
			this.Invoke("DeleteObject", new object[] {_Purchase});
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
		public PurchaseCollection GetByApiKey(Services.Packages.ApiKey _ApiKey) {
			object[] results = this.Invoke("GetByApiKey", new object[] {_ApiKey});
			return ((PurchaseCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByApiKeyPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByApiKeyPaged", new object[] {_ApiKey,PagingStart,PagingCount});
			return ((PurchaseCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByApiKeyCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey) {
			object[] results = this.Invoke("GetByApiKeyCount", new object[] {_ApiKey});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.ApiKey GetApiKey(Purchase _Purchase)
		{
			object[] results = this.Invoke("GetApiKey", new object[] {_Purchase});
			return ((Services.Packages.ApiKey)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetApiKey(Purchase _Purchase, Services.Packages.ApiKey _ApiKey)
		{
			this.Invoke("GetApiKey", new object[] {_Purchase});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByClient", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseCollection GetByClient(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByClient", new object[] {_ModelUser});
			return ((PurchaseCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByClientPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseCollection GetByClientPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByClientPaged", new object[] {_ModelUser,PagingStart,PagingCount});
			return ((PurchaseCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByClientCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByClientCount(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByClientCount", new object[] {_ModelUser});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetClient", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetClient(Purchase _Purchase)
		{
			object[] results = this.Invoke("GetClient", new object[] {_Purchase});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetClient", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetClient(Purchase _Purchase, Services.Packages.Security.ModelUser _Client)
		{
			this.Invoke("GetClient", new object[] {_Purchase});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByOwner", new object[] {_ModelUser});
			return ((PurchaseCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByOwnerPaged", new object[] {_ModelUser,PagingStart,PagingCount});
			return ((PurchaseCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByOwnerCount", new object[] {_ModelUser});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetOwner(Purchase _Purchase)
		{
			object[] results = this.Invoke("GetOwner", new object[] {_Purchase});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetOwner(Purchase _Purchase, Services.Packages.Security.ModelUser _Owner)
		{
			this.Invoke("GetOwner", new object[] {_Purchase});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAll", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseCollection GetAll(System.String dummy ) {
			object[] results = this.Invoke("GetAll", new object[] {dummy});
			return ((PurchaseCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseCollection GetAllPaged(System.String dummy , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetAllPaged", new object[] {dummy,PagingStart,PagingCount});
			return ((PurchaseCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetAllCount(System.String dummy ) {
			object[] results = this.Invoke("GetAllCount", new object[] {dummy});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetOrderLines", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.PurchaseLineCollection GetOrderLines(Purchase _Purchase)
		{
			object[] results = this.Invoke("GetOrderLines", new object[] {_Purchase});
			return ((Services.Packages.PurchaseLineCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetOrderLines", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetOrderLines(Purchase _Purchase, Services.Packages.PurchaseLineCollection _OrderLines)
		{
			this.Invoke("GetOrderLines", new object[] {_Purchase});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.PurchaseAccessControlListCollection GetACLs(Purchase _Purchase)
		{
			object[] results = this.Invoke("GetACLs", new object[] {_Purchase});
			return ((Services.Packages.Security.PurchaseAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACLs(Purchase _Purchase, Services.Packages.Security.PurchaseAccessControlListCollection _ACLs)
		{
			this.Invoke("GetACLs", new object[] {_Purchase});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages
