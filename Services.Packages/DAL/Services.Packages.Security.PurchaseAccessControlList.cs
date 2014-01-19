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
    /// Defines the contract for the PurchaseAccessControlList class
    /// </summary>
    [ComVisible(true)]
    [Guid("a151bfaa-5002-ad96-ee49-412a5e57cd52")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IPurchaseAccessControlList
	{
		bool Exists { get; }
		System.String UserName { get; set; }
		System.Int32 Id { get; set; }
		Services.Packages.Security.ModelUser User { get; set; }
		Services.Packages.Purchase Purchase { get; set; }
		Services.Packages.Security.PurchaseAccessControlEntryCollection ACEs { get; set; }
		Services.Packages.Security.PurchaseAccessControlEntryCollection GetEntries(System.String Descriptor);

		void Read(System.String __UserName, System.Int32 __Id);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(PurchaseAccessControlList _object);
		void CopyWithKeysTo(PurchaseAccessControlList _object);
		void CopyFrom(PurchaseAccessControlList _object);
		void CopyTo(PurchaseAccessControlList _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.Security.PurchaseAccessControlList type.
    /// </summary>
    [ComVisible(true)]
    [Guid("429502c7-497a-3933-fff4-913bd562c1de")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IPurchaseAccessControlListService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(PurchaseAccessControlList _PurchaseAccessControlList);
		[OperationContract]
        PurchaseAccessControlList Read(System.String __UserName, System.Int32 __Id);
        [OperationContract]
        PurchaseAccessControlList Reload(PurchaseAccessControlList _PurchaseAccessControlList);
        [OperationContract]
        PurchaseAccessControlList Create(System.String __UserName, System.Int32 __Id);
        [OperationContract]
        void Delete(System.String __UserName, System.Int32 __Id);
        [OperationContract]
        void UpdateObject(PurchaseAccessControlList _PurchaseAccessControlList);
        [OperationContract]
        void CreateObject(PurchaseAccessControlList _PurchaseAccessControlList);
        [OperationContract]
        void DeleteObject(PurchaseAccessControlList _PurchaseAccessControlList);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		PurchaseAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		PurchaseAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		Services.Packages.Security.ModelUser GetUser(PurchaseAccessControlList _PurchaseAccessControlList);
		[OperationContract]
		void SetUser(PurchaseAccessControlList _PurchaseAccessControlList, Services.Packages.Security.ModelUser _User);
		[OperationContract]
		PurchaseAccessControlListCollection GetByPurchase(Services.Packages.Purchase _Purchase);
		[OperationContract]
		PurchaseAccessControlListCollection GetByPurchasePaged(Services.Packages.Purchase _Purchase, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByPurchaseCount(Services.Packages.Purchase _Purchase);
		[OperationContract]
		Services.Packages.Purchase GetPurchase(PurchaseAccessControlList _PurchaseAccessControlList);
		[OperationContract]
		void SetPurchase(PurchaseAccessControlList _PurchaseAccessControlList, Services.Packages.Purchase _Purchase);
		[OperationContract]
		PurchaseAccessControlListCollection GetACLs(System.String UserName, Services.Packages.Purchase _Purchase);
		[OperationContract]
		PurchaseAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.Purchase _Purchase, long PagingStart, long PagingCount);
		[OperationContract]
		long GetACLsCount(System.String UserName, Services.Packages.Purchase _Purchase);
		[OperationContract]
		Services.Packages.Security.PurchaseAccessControlEntryCollection GetACEs(PurchaseAccessControlList _PurchaseAccessControlList);
		[OperationContract]
		void SetACEs(PurchaseAccessControlList _PurchaseAccessControlList, Services.Packages.Security.PurchaseAccessControlEntryCollection _ACEs);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.Security.PurchaseAccessControlList type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("8a5c646f-eeeb-301e-0ed4-fa5264d51b47")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class PurchaseAccessControlListService : IPurchaseAccessControlListService
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
        public bool Exists(PurchaseAccessControlList _PurchaseAccessControlList)
        {
			return _PurchaseAccessControlList.Exists;
        }
		
		[WebMethod]
		public PurchaseAccessControlList Read(System.String __UserName, System.Int32 __Id)
		{
			return new PurchaseAccessControlList(__UserName, __Id);
		}
		
		[WebMethod]
        public PurchaseAccessControlList Reload(PurchaseAccessControlList _PurchaseAccessControlList)
        {
			_PurchaseAccessControlList.Reload();
			return _PurchaseAccessControlList;
        }
		
		[WebMethod]
        public PurchaseAccessControlList Create(System.String __UserName, System.Int32 __Id)
        {
			return PurchaseAccessControlList.CreatePurchaseAccessControlList(__UserName, __Id);
        }
        
        [WebMethod]
        public void Delete(System.String __UserName, System.Int32 __Id)
        {
			PurchaseAccessControlList.DeletePurchaseAccessControlList(__UserName, __Id);
        }
        
        [WebMethod]
        public void UpdateObject(PurchaseAccessControlList _PurchaseAccessControlList)
        {
			_PurchaseAccessControlList.Update();
        }
		
		[WebMethod]
        public void CreateObject(PurchaseAccessControlList _PurchaseAccessControlList)
        {
			_PurchaseAccessControlList.Create();
        }
        
        [WebMethod]
        public void DeleteObject(PurchaseAccessControlList _PurchaseAccessControlList)
        {
			_PurchaseAccessControlList.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			PurchaseAccessControlList.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			PurchaseAccessControlList.Redo();
        }
		[WebMethod]
		public PurchaseAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
		{
			return PurchaseAccessControlList.GetByUser( _ModelUser);
		}
		[WebMethod]
		public PurchaseAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return PurchaseAccessControlList.GetByUserPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return PurchaseAccessControlList.GetByUserCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUser(PurchaseAccessControlList _PurchaseAccessControlList)
		{
			_PurchaseAccessControlList.Reload();
			return _PurchaseAccessControlList.User;
		}
		[WebMethod]
		public void SetUser(PurchaseAccessControlList _PurchaseAccessControlList, Services.Packages.Security.ModelUser _User)
		{
			_PurchaseAccessControlList.Reload();
			_PurchaseAccessControlList.User = _User;
			_PurchaseAccessControlList.Update();
		}
		[WebMethod]
		public PurchaseAccessControlListCollection GetByPurchase(Services.Packages.Purchase _Purchase)
		{
			return PurchaseAccessControlList.GetByPurchase( _Purchase);
		}
		[WebMethod]
		public PurchaseAccessControlListCollection GetByPurchasePaged(Services.Packages.Purchase _Purchase, long PagingStart, long PagingCount)
		{
			return PurchaseAccessControlList.GetByPurchasePaged( _Purchase, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByPurchaseCount(Services.Packages.Purchase _Purchase)
		{
			return PurchaseAccessControlList.GetByPurchaseCount( _Purchase);
		}
		[WebMethod]
		public Services.Packages.Purchase GetPurchase(PurchaseAccessControlList _PurchaseAccessControlList)
		{
			_PurchaseAccessControlList.Reload();
			return _PurchaseAccessControlList.Purchase;
		}
		[WebMethod]
		public void SetPurchase(PurchaseAccessControlList _PurchaseAccessControlList, Services.Packages.Purchase _Purchase)
		{
			_PurchaseAccessControlList.Reload();
			_PurchaseAccessControlList.Purchase = _Purchase;
			_PurchaseAccessControlList.Update();
		}
		[WebMethod]
		public PurchaseAccessControlListCollection GetACLs(System.String UserName, Services.Packages.Purchase _Purchase)
		{
			return PurchaseAccessControlList.GetACLs(UserName,  _Purchase);
		}
		[WebMethod]
		public PurchaseAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.Purchase _Purchase, long PagingStart, long PagingCount)
		{
			return PurchaseAccessControlList.GetACLsPaged(UserName,  _Purchase, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetACLsCount(System.String UserName, Services.Packages.Purchase _Purchase)
		{
			return PurchaseAccessControlList.GetACLsCount(UserName,  _Purchase);
		}
		[WebMethod]
		public Services.Packages.Security.PurchaseAccessControlEntryCollection GetACEs(PurchaseAccessControlList _PurchaseAccessControlList)
		{
			_PurchaseAccessControlList.Reload();
			return _PurchaseAccessControlList.ACEs;
		}
		[WebMethod]
		public void SetACEs(PurchaseAccessControlList _PurchaseAccessControlList, Services.Packages.Security.PurchaseAccessControlEntryCollection _ACEs)
		{
			_PurchaseAccessControlList.Reload();
			_PurchaseAccessControlList.ACEs = _ACEs;
			_PurchaseAccessControlList.Update();
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.Security.PurchaseAccessControlList model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("c73febb8-019b-617b-8c17-a20ebf5ad78b")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class PurchaseAccessControlList : IPurchaseAccessControlList, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<IPurchaseAccessControlListService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<IPurchaseAccessControlListService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<IPurchaseAccessControlListService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.PurchaseAccessControlList"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.PurchaseAccessControlList"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.Security.PurchaseAccessControlList.ProviderType");
				
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

		bool _UserIsLoaded = false;
		Services.Packages.Security.ModelUser _User;
		
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.ModelUser User
		{
            get
            {
				if (!_UserIsLoaded)
				{
					_User = new Services.Packages.Security.ModelUser(_UserName);
					if (_User.Exists)
						_UserIsLoaded = true;
					else _User = null;
				}
                return _User;
            }
            set
            {
                _User = value;
                _UserIsLoaded = true;
                if (_User != null)
                {
					if (_User.Exists)
					{
						_UserName = _User.Name;
						
					}
					else
					{
						_User = null;
					}
				}
            }
		}
		
		public static Services.Packages.Security.ModelUser GetUser(PurchaseAccessControlList _PurchaseAccessControlList)
		{
			return _PurchaseAccessControlList.User;
		}

		bool _PurchaseIsLoaded = false;
		Services.Packages.Purchase _Purchase;
		
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Purchase Purchase
		{
            get
            {
				if (!_PurchaseIsLoaded)
				{
					_Purchase = new Services.Packages.Purchase(_Id);
					if (_Purchase.Exists)
						_PurchaseIsLoaded = true;
					else _Purchase = null;
				}
                return _Purchase;
            }
            set
            {
                _Purchase = value;
                _PurchaseIsLoaded = true;
                if (_Purchase != null)
                {
					if (_Purchase.Exists)
					{
						_Id = _Purchase.Id;
						
					}
					else
					{
						_Purchase = null;
					}
				}
            }
		}
		
		public static Services.Packages.Purchase GetPurchase(PurchaseAccessControlList _PurchaseAccessControlList)
		{
			return _PurchaseAccessControlList.Purchase;
		}

		public static PurchaseAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
        {
			PurchaseAccessControlListCollection _PurchaseAccessControlListCollection = new PurchaseAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuAcCoLiGetByUs", dbconn);
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
					PurchaseAccessControlList o = new PurchaseAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._PurchaseIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._Purchase = null; o._PurchaseIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _PurchaseAccessControlListCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PurchaseAccessControlListCollection;
        }
        
        public static PurchaseAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			PurchaseAccessControlListCollection _PurchaseAccessControlListCollection = new PurchaseAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuAcCoLiGetByUsPaged", dbconn);
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
					PurchaseAccessControlList o = new PurchaseAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._PurchaseIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._Purchase = null; o._PurchaseIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _PurchaseAccessControlListCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PurchaseAccessControlListCollection;
        }
        
        public static long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuAcCoLiGetByUsCount", dbconn);
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

		public static PurchaseAccessControlListCollection GetByPurchase(Services.Packages.Purchase _Purchase)
        {
			PurchaseAccessControlListCollection _PurchaseAccessControlListCollection = new PurchaseAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuAcCoLiGetByPu", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Id;
				if (_Purchase != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Purchase.Id);
				} else {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", DBNull.Value);
				}
				command.Parameters.Add(param_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					PurchaseAccessControlList o = new PurchaseAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._PurchaseIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._Purchase = null; o._PurchaseIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _PurchaseAccessControlListCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PurchaseAccessControlListCollection;
        }
        
        public static PurchaseAccessControlListCollection GetByPurchasePaged(Services.Packages.Purchase _Purchase, long PagingStart, long PagingCount)
        {
			PurchaseAccessControlListCollection _PurchaseAccessControlListCollection = new PurchaseAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuAcCoLiGetByPuPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Id;
				if (_Purchase != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Purchase.Id);
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
					PurchaseAccessControlList o = new PurchaseAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._PurchaseIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._Purchase = null; o._PurchaseIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _PurchaseAccessControlListCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PurchaseAccessControlListCollection;
        }
        
        public static long GetByPurchaseCount(Services.Packages.Purchase _Purchase)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuAcCoLiGetByPuCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Id;
				if (_Purchase != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Purchase.Id);
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

		public static PurchaseAccessControlListCollection GetACLs(System.String _UserName, Services.Packages.Purchase _Purchase)
        {
			PurchaseAccessControlListCollection _PurchaseAccessControlListCollection = new PurchaseAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuAcCoLiGeACLs", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UserName = ClassConnectionProvider.Escape(_UserName);
				
                
                DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), -1);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_Purchase_Id;
				if (_Purchase != null) {
				param_Purchase_Id = ClassConnectionProvider.GetDatabaseParameter("PuId", typeof(System.Int32), -1);
				param_Purchase_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Purchase.Id);
				} else {
				param_Purchase_Id = ClassConnectionProvider.GetDatabaseParameter("PuId", DBNull.Value);
				}
				command.Parameters.Add(param_Purchase_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					PurchaseAccessControlList o = new PurchaseAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._PurchaseIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._Purchase = null; o._PurchaseIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _PurchaseAccessControlListCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PurchaseAccessControlListCollection;
        }
        
        public static PurchaseAccessControlListCollection GetACLsPaged(System.String _UserName, Services.Packages.Purchase _Purchase, long PagingStart, long PagingCount)
        {
			PurchaseAccessControlListCollection _PurchaseAccessControlListCollection = new PurchaseAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuAcCoLiGeACLsPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UserName = ClassConnectionProvider.Escape(_UserName);
				
                
                DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), -1);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_Purchase_Id;
				if (_Purchase != null) {
				param_Purchase_Id = ClassConnectionProvider.GetDatabaseParameter("PuId", typeof(System.Int32), -1);
				param_Purchase_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Purchase.Id);
				} else {
				param_Purchase_Id = ClassConnectionProvider.GetDatabaseParameter("PuId", DBNull.Value);
				}
				command.Parameters.Add(param_Purchase_Id);
				
                
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
					PurchaseAccessControlList o = new PurchaseAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._PurchaseIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._Purchase = null; o._PurchaseIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _PurchaseAccessControlListCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PurchaseAccessControlListCollection;
        }
        
        public static long GetACLsCount(System.String _UserName, Services.Packages.Purchase _Purchase)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuAcCoLiGeACLsCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UserName = ClassConnectionProvider.Escape(_UserName);
				
                
                DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), -1);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_Purchase_Id;
				if (_Purchase != null) {
				param_Purchase_Id = ClassConnectionProvider.GetDatabaseParameter("PuId", typeof(System.Int32), -1);
				param_Purchase_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Purchase.Id);
				} else {
				param_Purchase_Id = ClassConnectionProvider.GetDatabaseParameter("PuId", DBNull.Value);
				}
				command.Parameters.Add(param_Purchase_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		Services.Packages.Security.PurchaseAccessControlEntryCollection _ACEs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.PurchaseAccessControlEntryCollection ACEs
		{
            get
            {
				if (_ACEs == null)
					_ACEs = Services.Packages.Security.PurchaseAccessControlEntry.GetByACL(this);
				
				return _ACEs;
            }
            set
            {
				if (this.Exists)
				{
					if (_ACEs != null)
					{
						for(int n = 0; n < _ACEs.Count; ++n)
						{
							_ACEs[n].ACL = null;
							_ACEs[n].Update();
						}
					}
	                
					_ACEs = value;
					
					if (_ACEs != null)
					{
						for(int n = 0; n < _ACEs.Count; ++n)
						{
							_ACEs[n].ACL = this;
							_ACEs[n].Create();
						}
					}
				}
				else
				{
					_ACEs = value;
				}
            }
		}
		
		public void ReloadACEs()
		{
			_ACEs = Services.Packages.Security.PurchaseAccessControlEntry.GetByACL(this);
		}

		public Services.Packages.Security.PurchaseAccessControlEntryCollection GetEntries(System.String Descriptor)
		{
			return Services.Packages.Security.PurchaseAccessControlEntry.GetEntries(Descriptor,  this);
		}

		public bool Exists
        {
            get {
				if (!__hasBeenReadOnce)
					Exist();
				
				return __databaseState == RowState.Initialized;
			}
        }
        
        public PurchaseAccessControlList() {}
        
        public PurchaseAccessControlList(System.String __UserName, System.Int32 __Id)
        {
			Read(__UserName, __Id);
        }
        
        #region CRUD
        
        void Exist()
        {
			// sql read - should be changed to specific exist implementation
			using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
			{
				dbconn.Open();
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuAcCoLiRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
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
        
        public void Read(System.String __UserName, System.Int32 __Id)
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].Read(__UserName, __Id);
					return;
				}

                // Get a service via an algorithm
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "PuAcCoLi");
                // Perfect for read operations, but not for write
                // scalingServices[nextIndex].Read(__UserName, __Id);
				// return;

				throw new NotImplementedException();
            }

            try
            {
				// sql read
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuAcCoLiRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
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
						_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_PurchaseIsLoaded = false; if (dr["Id"] == DBNull.Value) { _Purchase = null; _PurchaseIsLoaded = true; }  else _Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
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
                            failoverServices[n].Read(__UserName, __Id);
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "PuAcCoLi");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuAcCoLiRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
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
						_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_PurchaseIsLoaded = false; if (dr["Id"] == DBNull.Value) { _Purchase = null; _PurchaseIsLoaded = true; }  else _Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuAcCoLiCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_User_Name = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_User_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				if (_User == null && _UserIsLoaded == true) param_User_Name.Value = DBNull.Value;
				command.Parameters.Add(param_User_Name);
				DbParameter param_Purchase_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Purchase_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				if (_Purchase == null && _PurchaseIsLoaded == true) param_Purchase_Id.Value = DBNull.Value;
				command.Parameters.Add(param_Purchase_Id);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_PurchaseIsLoaded = false; if (dr["Id"] == DBNull.Value) { _Purchase = null; _PurchaseIsLoaded = true; }  else _Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
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
        
        static public PurchaseAccessControlList CreatePurchaseAccessControlList(System.String __UserName, System.Int32 __Id)
        {
            PurchaseAccessControlList o = new PurchaseAccessControlList(__UserName, __Id);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuAcCoLiUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_UserHasChanged = ClassConnectionProvider.GetDatabaseParameter("UserHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_UserIsLoaded));
				command.Parameters.Add(param_UserHasChanged);
				DbParameter param_User_Name = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_User_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				if (_User == null && _UserIsLoaded == true) param_User_Name.Value = DBNull.Value;
				command.Parameters.Add(param_User_Name);
				DbParameter param_PurchaseHasChanged = ClassConnectionProvider.GetDatabaseParameter("PurchaseHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_PurchaseIsLoaded));
				command.Parameters.Add(param_PurchaseHasChanged);
				DbParameter param_Purchase_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Purchase_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				if (_Purchase == null && _PurchaseIsLoaded == true) param_Purchase_Id.Value = DBNull.Value;
				command.Parameters.Add(param_Purchase_Id);
				

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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuAcCoLiDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
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
        
        static public void DeletePurchaseAccessControlList(System.String __UserName, System.Int32 __Id)
        {
            PurchaseAccessControlList o = new PurchaseAccessControlList(__UserName, __Id);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(PurchaseAccessControlList _object)
        {
			_User = null;
			_UserIsLoaded = false;
			_Purchase = null;
			_PurchaseIsLoaded = false;
			_UserName = _object._UserName;
			_Id = _object._Id;
			
        }
        
        public void CopyWithKeysTo(PurchaseAccessControlList _object)
        {
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._Purchase = null;
			_object._PurchaseIsLoaded = false;
			_object._UserName = _UserName;
			_object._Id = _Id;
			
        }
        
        static public void CopyWithKeysObject(PurchaseAccessControlList _objectFrom, PurchaseAccessControlList _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(PurchaseAccessControlList _object)
        {
			_User = null;
			_UserIsLoaded = false;
			_Purchase = null;
			_PurchaseIsLoaded = false;
			
        }
        
        public void CopyTo(PurchaseAccessControlList _object)
        {
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._Purchase = null;
			_object._PurchaseIsLoaded = false;
			
        }
        
        static public void CopyObject(PurchaseAccessControlList _objectFrom, PurchaseAccessControlList _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(PurchaseAccessControlList).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(PurchaseAccessControlList).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(PurchaseAccessControlList _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			PurchaseAccessControlListUndoRedoCollection allUndidAndNotRedoneEntries = PurchaseAccessControlListUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			PurchaseAccessControlListUndoRedo _urobject = new PurchaseAccessControlListUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.User_Name = _object._User_Name;
			_urobject.Purchase_Id = _object._Purchase_Id;
			_urobject.UserName = _object._UserName;
			_urobject.Id = _object._Id;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(PurchaseAccessControlList).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = PurchaseAccessControlListUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				PurchaseAccessControlListUndoRedoCollection allOldUndoEntries = PurchaseAccessControlListUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			PurchaseAccessControlListUndoRedoCollection firstUndoEntries = PurchaseAccessControlListUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			PurchaseAccessControlListUndoRedo _urobject = firstUndoEntries[0];
			
			PurchaseAccessControlList _object = new PurchaseAccessControlList();
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._User_Name = _urobject.User_Name;
			_object._Purchase = null;
			_object._PurchaseIsLoaded = false;
			_object._Purchase_Id = _urobject.Purchase_Id;
			_object._UserName = _urobject.UserName;
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
			PurchaseAccessControlListUndoRedoCollection firstEntryToRedoEntries = PurchaseAccessControlListUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			PurchaseAccessControlListUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			PurchaseAccessControlList _object = new PurchaseAccessControlList();
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._User_Name = _urobject.User_Name;
			_object._Purchase = null;
			_object._PurchaseIsLoaded = false;
			_object._Purchase_Id = _urobject.Purchase_Id;
			_object._UserName = _urobject.UserName;
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
    /// Defines the contract for the PurchaseAccessControlListCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("f9ba6387-42fa-d866-e464-33a54ee0d529")]
    public interface IPurchaseAccessControlListCollection : IEnumerable<PurchaseAccessControlList>
    {
        int IndexOf(PurchaseAccessControlList item);
        void Insert(int index, PurchaseAccessControlList item);
        void RemoveAt(int index);
        PurchaseAccessControlList this[int index] { get; set; }
        void Add(PurchaseAccessControlList item);
        void Clear();
        bool Contains(PurchaseAccessControlList item);
        void CopyTo(PurchaseAccessControlList[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(PurchaseAccessControlList item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.Security.PurchaseAccessControlList
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("ea824ad9-f923-6d42-e8fb-fed44c1070b4")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class PurchaseAccessControlListCollection : IPurchaseAccessControlListCollection, IList<PurchaseAccessControlList>, IHierarchicalEnumerable
    {
        List<PurchaseAccessControlList> _list = new List<PurchaseAccessControlList>();
        
        public static implicit operator List<PurchaseAccessControlList>(PurchaseAccessControlListCollection collection)
        {
            return collection._list;
        }

        #region IList<PurchaseAccessControlList> Members

        public int IndexOf(PurchaseAccessControlList item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, PurchaseAccessControlList item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public PurchaseAccessControlList this[int index]
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

        #region ICollection<PurchaseAccessControlList> Members

        public void Add(PurchaseAccessControlList item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(PurchaseAccessControlList item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(PurchaseAccessControlList[] array, int arrayIndex)
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

        public bool Remove(PurchaseAccessControlList item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<PurchaseAccessControlList> Members

        public IEnumerator<PurchaseAccessControlList> GetEnumerator()
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
	/// that share Services.Packages.Security.PurchaseAccessControlList objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Security.Web.PurchaseAccessControlListWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class PurchaseAccessControlListWebService : WebService, IPurchaseAccessControlListService
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
        public bool Exists(PurchaseAccessControlList _PurchaseAccessControlList)
        {
			return _PurchaseAccessControlList.Exists;
        }
		
		[WebMethod]
		public PurchaseAccessControlList Read(System.String __UserName, System.Int32 __Id)
		{
			return new PurchaseAccessControlList(__UserName, __Id);
		}
		
		[WebMethod]
        public PurchaseAccessControlList Reload(PurchaseAccessControlList _PurchaseAccessControlList)
        {
			_PurchaseAccessControlList.Reload();
			return _PurchaseAccessControlList;
        }
		
		[WebMethod]
        public PurchaseAccessControlList Create(System.String __UserName, System.Int32 __Id)
        {
			return PurchaseAccessControlList.CreatePurchaseAccessControlList(__UserName, __Id);
        }
        
        [WebMethod]
        public void Delete(System.String __UserName, System.Int32 __Id)
        {
			PurchaseAccessControlList.DeletePurchaseAccessControlList(__UserName, __Id);
        }
        
        [WebMethod]
        public void UpdateObject(PurchaseAccessControlList _PurchaseAccessControlList)
        {
			_PurchaseAccessControlList.Update();
        }
		
		[WebMethod]
        public void CreateObject(PurchaseAccessControlList _PurchaseAccessControlList)
        {
			_PurchaseAccessControlList.Create();
        }
        
        [WebMethod]
        public void DeleteObject(PurchaseAccessControlList _PurchaseAccessControlList)
        {
			_PurchaseAccessControlList.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			PurchaseAccessControlList.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			PurchaseAccessControlList.Redo();
        }
		[WebMethod]
		public PurchaseAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
		{
			return PurchaseAccessControlList.GetByUser( _ModelUser);
		}
		[WebMethod]
		public PurchaseAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return PurchaseAccessControlList.GetByUserPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return PurchaseAccessControlList.GetByUserCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUser(PurchaseAccessControlList _PurchaseAccessControlList)
		{
			_PurchaseAccessControlList.Reload();
			return _PurchaseAccessControlList.User;
		}
		[WebMethod]
		public void SetUser(PurchaseAccessControlList _PurchaseAccessControlList, Services.Packages.Security.ModelUser _User)
		{
			_PurchaseAccessControlList.Reload();
			_PurchaseAccessControlList.User = _User;
			_PurchaseAccessControlList.Update();
		}
		[WebMethod]
		public PurchaseAccessControlListCollection GetByPurchase(Services.Packages.Purchase _Purchase)
		{
			return PurchaseAccessControlList.GetByPurchase( _Purchase);
		}
		[WebMethod]
		public PurchaseAccessControlListCollection GetByPurchasePaged(Services.Packages.Purchase _Purchase, long PagingStart, long PagingCount)
		{
			return PurchaseAccessControlList.GetByPurchasePaged( _Purchase, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByPurchaseCount(Services.Packages.Purchase _Purchase)
		{
			return PurchaseAccessControlList.GetByPurchaseCount( _Purchase);
		}
		[WebMethod]
		public Services.Packages.Purchase GetPurchase(PurchaseAccessControlList _PurchaseAccessControlList)
		{
			_PurchaseAccessControlList.Reload();
			return _PurchaseAccessControlList.Purchase;
		}
		[WebMethod]
		public void SetPurchase(PurchaseAccessControlList _PurchaseAccessControlList, Services.Packages.Purchase _Purchase)
		{
			_PurchaseAccessControlList.Reload();
			_PurchaseAccessControlList.Purchase = _Purchase;
			_PurchaseAccessControlList.Update();
		}
		[WebMethod]
		public PurchaseAccessControlListCollection GetACLs(System.String UserName, Services.Packages.Purchase _Purchase)
		{
			return PurchaseAccessControlList.GetACLs(UserName,  _Purchase);
		}
		[WebMethod]
		public PurchaseAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.Purchase _Purchase, long PagingStart, long PagingCount)
		{
			return PurchaseAccessControlList.GetACLsPaged(UserName,  _Purchase, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetACLsCount(System.String UserName, Services.Packages.Purchase _Purchase)
		{
			return PurchaseAccessControlList.GetACLsCount(UserName,  _Purchase);
		}
		[WebMethod]
		public Services.Packages.Security.PurchaseAccessControlEntryCollection GetACEs(PurchaseAccessControlList _PurchaseAccessControlList)
		{
			_PurchaseAccessControlList.Reload();
			return _PurchaseAccessControlList.ACEs;
		}
		[WebMethod]
		public void SetACEs(PurchaseAccessControlList _PurchaseAccessControlList, Services.Packages.Security.PurchaseAccessControlEntryCollection _ACEs)
		{
			_PurchaseAccessControlList.Reload();
			_PurchaseAccessControlList.ACEs = _ACEs;
			_PurchaseAccessControlList.Update();
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="PurchaseAccessControlListWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("00ca6ffd-211a-764c-8567-e236ced612ab")]
    sealed public class PurchaseAccessControlListWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IPurchaseAccessControlListService
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
		public PurchaseAccessControlListWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public PurchaseAccessControlListWebServiceClient()
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
		public bool Exists(PurchaseAccessControlList _PurchaseAccessControlList)
        {
			object[] results = this.Invoke("Exists", new object[] {_PurchaseAccessControlList});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseAccessControlList Read(System.String __UserName, System.Int32 __Id)
		{
			object[] results = this.Invoke("Read", new object[] {__UserName, __Id});
			return ((PurchaseAccessControlList)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseAccessControlList Reload(PurchaseAccessControlList _PurchaseAccessControlList)
        {
			object[] results = this.Invoke("Reload", new object[] {_PurchaseAccessControlList});
			return ((PurchaseAccessControlList)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseAccessControlList Create(System.String __UserName, System.Int32 __Id)
        {
			object[] results = this.Invoke("Create", new object[] {__UserName, __Id});
			return ((PurchaseAccessControlList)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __UserName, System.Int32 __Id)
        {
			this.Invoke("Delete", new object[] {__UserName, __Id});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(PurchaseAccessControlList _PurchaseAccessControlList)
        {
			this.Invoke("UpdateObject", new object[] {_PurchaseAccessControlList});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(PurchaseAccessControlList _PurchaseAccessControlList)
        {
			this.Invoke("CreateObject", new object[] {_PurchaseAccessControlList});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(PurchaseAccessControlList _PurchaseAccessControlList)
        {
			this.Invoke("DeleteObject", new object[] {_PurchaseAccessControlList});
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
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByUser", new object[] {_ModelUser});
			return ((PurchaseAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByUserPaged", new object[] {_ModelUser,PagingStart,PagingCount});
			return ((PurchaseAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByUserCount", new object[] {_ModelUser});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetUser(PurchaseAccessControlList _PurchaseAccessControlList)
		{
			object[] results = this.Invoke("GetUser", new object[] {_PurchaseAccessControlList});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetUser(PurchaseAccessControlList _PurchaseAccessControlList, Services.Packages.Security.ModelUser _User)
		{
			this.Invoke("GetUser", new object[] {_PurchaseAccessControlList});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByPurchase", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseAccessControlListCollection GetByPurchase(Services.Packages.Purchase _Purchase) {
			object[] results = this.Invoke("GetByPurchase", new object[] {_Purchase});
			return ((PurchaseAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByPurchasePaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseAccessControlListCollection GetByPurchasePaged(Services.Packages.Purchase _Purchase, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByPurchasePaged", new object[] {_Purchase,PagingStart,PagingCount});
			return ((PurchaseAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByPurchaseCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByPurchaseCount(Services.Packages.Purchase _Purchase) {
			object[] results = this.Invoke("GetByPurchaseCount", new object[] {_Purchase});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPurchase", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Purchase GetPurchase(PurchaseAccessControlList _PurchaseAccessControlList)
		{
			object[] results = this.Invoke("GetPurchase", new object[] {_PurchaseAccessControlList});
			return ((Services.Packages.Purchase)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPurchase", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPurchase(PurchaseAccessControlList _PurchaseAccessControlList, Services.Packages.Purchase _Purchase)
		{
			this.Invoke("GetPurchase", new object[] {_PurchaseAccessControlList});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseAccessControlListCollection GetACLs(System.String UserName, Services.Packages.Purchase _Purchase) {
			object[] results = this.Invoke("GetACLs", new object[] {UserName, _Purchase});
			return ((PurchaseAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLsPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.Purchase _Purchase, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetACLsPaged", new object[] {UserName, _Purchase,PagingStart,PagingCount});
			return ((PurchaseAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLsCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetACLsCount(System.String UserName, Services.Packages.Purchase _Purchase) {
			object[] results = this.Invoke("GetACLsCount", new object[] {UserName, _Purchase});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACEs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.PurchaseAccessControlEntryCollection GetACEs(PurchaseAccessControlList _PurchaseAccessControlList)
		{
			object[] results = this.Invoke("GetACEs", new object[] {_PurchaseAccessControlList});
			return ((Services.Packages.Security.PurchaseAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACEs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACEs(PurchaseAccessControlList _PurchaseAccessControlList, Services.Packages.Security.PurchaseAccessControlEntryCollection _ACEs)
		{
			this.Invoke("GetACEs", new object[] {_PurchaseAccessControlList});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages.Security
