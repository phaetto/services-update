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
    /// Defines the contract for the PurchaseLineAccessControlList class
    /// </summary>
    [ComVisible(true)]
    [Guid("10323404-b611-9a72-f0bb-a95c989f8b66")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IPurchaseLineAccessControlList
	{
		bool Exists { get; }
		System.String UserName { get; set; }
		System.Int32 Id { get; set; }
		Services.Packages.Security.ModelUser User { get; set; }
		Services.Packages.PurchaseLine PurchaseLine { get; set; }
		Services.Packages.Security.PurchaseLineAccessControlEntryCollection ACEs { get; set; }
		Services.Packages.Security.PurchaseLineAccessControlEntryCollection GetEntries(System.String Descriptor);

		void Read(System.String __UserName, System.Int32 __Id);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(PurchaseLineAccessControlList _object);
		void CopyWithKeysTo(PurchaseLineAccessControlList _object);
		void CopyFrom(PurchaseLineAccessControlList _object);
		void CopyTo(PurchaseLineAccessControlList _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.Security.PurchaseLineAccessControlList type.
    /// </summary>
    [ComVisible(true)]
    [Guid("8da777eb-7fc2-5854-3644-6cc7db80dbb2")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IPurchaseLineAccessControlListService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(PurchaseLineAccessControlList _PurchaseLineAccessControlList);
		[OperationContract]
        PurchaseLineAccessControlList Read(System.String __UserName, System.Int32 __Id);
        [OperationContract]
        PurchaseLineAccessControlList Reload(PurchaseLineAccessControlList _PurchaseLineAccessControlList);
        [OperationContract]
        PurchaseLineAccessControlList Create(System.String __UserName, System.Int32 __Id);
        [OperationContract]
        void Delete(System.String __UserName, System.Int32 __Id);
        [OperationContract]
        void UpdateObject(PurchaseLineAccessControlList _PurchaseLineAccessControlList);
        [OperationContract]
        void CreateObject(PurchaseLineAccessControlList _PurchaseLineAccessControlList);
        [OperationContract]
        void DeleteObject(PurchaseLineAccessControlList _PurchaseLineAccessControlList);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		PurchaseLineAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		PurchaseLineAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		Services.Packages.Security.ModelUser GetUser(PurchaseLineAccessControlList _PurchaseLineAccessControlList);
		[OperationContract]
		void SetUser(PurchaseLineAccessControlList _PurchaseLineAccessControlList, Services.Packages.Security.ModelUser _User);
		[OperationContract]
		PurchaseLineAccessControlListCollection GetByPurchaseLine(Services.Packages.PurchaseLine _PurchaseLine);
		[OperationContract]
		PurchaseLineAccessControlListCollection GetByPurchaseLinePaged(Services.Packages.PurchaseLine _PurchaseLine, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByPurchaseLineCount(Services.Packages.PurchaseLine _PurchaseLine);
		[OperationContract]
		Services.Packages.PurchaseLine GetPurchaseLine(PurchaseLineAccessControlList _PurchaseLineAccessControlList);
		[OperationContract]
		void SetPurchaseLine(PurchaseLineAccessControlList _PurchaseLineAccessControlList, Services.Packages.PurchaseLine _PurchaseLine);
		[OperationContract]
		PurchaseLineAccessControlListCollection GetACLs(System.String UserName, Services.Packages.PurchaseLine _PurchaseLine);
		[OperationContract]
		PurchaseLineAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.PurchaseLine _PurchaseLine, long PagingStart, long PagingCount);
		[OperationContract]
		long GetACLsCount(System.String UserName, Services.Packages.PurchaseLine _PurchaseLine);
		[OperationContract]
		Services.Packages.Security.PurchaseLineAccessControlEntryCollection GetACEs(PurchaseLineAccessControlList _PurchaseLineAccessControlList);
		[OperationContract]
		void SetACEs(PurchaseLineAccessControlList _PurchaseLineAccessControlList, Services.Packages.Security.PurchaseLineAccessControlEntryCollection _ACEs);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.Security.PurchaseLineAccessControlList type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("d8d32d0d-c1e5-2069-a6f0-ebeea7acabb0")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class PurchaseLineAccessControlListService : IPurchaseLineAccessControlListService
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
        public bool Exists(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
        {
			return _PurchaseLineAccessControlList.Exists;
        }
		
		[WebMethod]
		public PurchaseLineAccessControlList Read(System.String __UserName, System.Int32 __Id)
		{
			return new PurchaseLineAccessControlList(__UserName, __Id);
		}
		
		[WebMethod]
        public PurchaseLineAccessControlList Reload(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
        {
			_PurchaseLineAccessControlList.Reload();
			return _PurchaseLineAccessControlList;
        }
		
		[WebMethod]
        public PurchaseLineAccessControlList Create(System.String __UserName, System.Int32 __Id)
        {
			return PurchaseLineAccessControlList.CreatePurchaseLineAccessControlList(__UserName, __Id);
        }
        
        [WebMethod]
        public void Delete(System.String __UserName, System.Int32 __Id)
        {
			PurchaseLineAccessControlList.DeletePurchaseLineAccessControlList(__UserName, __Id);
        }
        
        [WebMethod]
        public void UpdateObject(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
        {
			_PurchaseLineAccessControlList.Update();
        }
		
		[WebMethod]
        public void CreateObject(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
        {
			_PurchaseLineAccessControlList.Create();
        }
        
        [WebMethod]
        public void DeleteObject(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
        {
			_PurchaseLineAccessControlList.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			PurchaseLineAccessControlList.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			PurchaseLineAccessControlList.Redo();
        }
		[WebMethod]
		public PurchaseLineAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
		{
			return PurchaseLineAccessControlList.GetByUser( _ModelUser);
		}
		[WebMethod]
		public PurchaseLineAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return PurchaseLineAccessControlList.GetByUserPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return PurchaseLineAccessControlList.GetByUserCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUser(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
		{
			_PurchaseLineAccessControlList.Reload();
			return _PurchaseLineAccessControlList.User;
		}
		[WebMethod]
		public void SetUser(PurchaseLineAccessControlList _PurchaseLineAccessControlList, Services.Packages.Security.ModelUser _User)
		{
			_PurchaseLineAccessControlList.Reload();
			_PurchaseLineAccessControlList.User = _User;
			_PurchaseLineAccessControlList.Update();
		}
		[WebMethod]
		public PurchaseLineAccessControlListCollection GetByPurchaseLine(Services.Packages.PurchaseLine _PurchaseLine)
		{
			return PurchaseLineAccessControlList.GetByPurchaseLine( _PurchaseLine);
		}
		[WebMethod]
		public PurchaseLineAccessControlListCollection GetByPurchaseLinePaged(Services.Packages.PurchaseLine _PurchaseLine, long PagingStart, long PagingCount)
		{
			return PurchaseLineAccessControlList.GetByPurchaseLinePaged( _PurchaseLine, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByPurchaseLineCount(Services.Packages.PurchaseLine _PurchaseLine)
		{
			return PurchaseLineAccessControlList.GetByPurchaseLineCount( _PurchaseLine);
		}
		[WebMethod]
		public Services.Packages.PurchaseLine GetPurchaseLine(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
		{
			_PurchaseLineAccessControlList.Reload();
			return _PurchaseLineAccessControlList.PurchaseLine;
		}
		[WebMethod]
		public void SetPurchaseLine(PurchaseLineAccessControlList _PurchaseLineAccessControlList, Services.Packages.PurchaseLine _PurchaseLine)
		{
			_PurchaseLineAccessControlList.Reload();
			_PurchaseLineAccessControlList.PurchaseLine = _PurchaseLine;
			_PurchaseLineAccessControlList.Update();
		}
		[WebMethod]
		public PurchaseLineAccessControlListCollection GetACLs(System.String UserName, Services.Packages.PurchaseLine _PurchaseLine)
		{
			return PurchaseLineAccessControlList.GetACLs(UserName,  _PurchaseLine);
		}
		[WebMethod]
		public PurchaseLineAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.PurchaseLine _PurchaseLine, long PagingStart, long PagingCount)
		{
			return PurchaseLineAccessControlList.GetACLsPaged(UserName,  _PurchaseLine, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetACLsCount(System.String UserName, Services.Packages.PurchaseLine _PurchaseLine)
		{
			return PurchaseLineAccessControlList.GetACLsCount(UserName,  _PurchaseLine);
		}
		[WebMethod]
		public Services.Packages.Security.PurchaseLineAccessControlEntryCollection GetACEs(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
		{
			_PurchaseLineAccessControlList.Reload();
			return _PurchaseLineAccessControlList.ACEs;
		}
		[WebMethod]
		public void SetACEs(PurchaseLineAccessControlList _PurchaseLineAccessControlList, Services.Packages.Security.PurchaseLineAccessControlEntryCollection _ACEs)
		{
			_PurchaseLineAccessControlList.Reload();
			_PurchaseLineAccessControlList.ACEs = _ACEs;
			_PurchaseLineAccessControlList.Update();
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.Security.PurchaseLineAccessControlList model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("042231cc-2825-850a-e0d9-dacd4aaabe70")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class PurchaseLineAccessControlList : IPurchaseLineAccessControlList, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<IPurchaseLineAccessControlListService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<IPurchaseLineAccessControlListService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<IPurchaseLineAccessControlListService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.PurchaseLineAccessControlList"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Security.PurchaseLineAccessControlList"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.Security.PurchaseLineAccessControlList.ProviderType");
				
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
		
		public static Services.Packages.Security.ModelUser GetUser(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
		{
			return _PurchaseLineAccessControlList.User;
		}

		bool _PurchaseLineIsLoaded = false;
		Services.Packages.PurchaseLine _PurchaseLine;
		
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.PurchaseLine PurchaseLine
		{
            get
            {
				if (!_PurchaseLineIsLoaded)
				{
					_PurchaseLine = new Services.Packages.PurchaseLine(_Id);
					if (_PurchaseLine.Exists)
						_PurchaseLineIsLoaded = true;
					else _PurchaseLine = null;
				}
                return _PurchaseLine;
            }
            set
            {
                _PurchaseLine = value;
                _PurchaseLineIsLoaded = true;
                if (_PurchaseLine != null)
                {
					if (_PurchaseLine.Exists)
					{
						_Id = _PurchaseLine.Id;
						
					}
					else
					{
						_PurchaseLine = null;
					}
				}
            }
		}
		
		public static Services.Packages.PurchaseLine GetPurchaseLine(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
		{
			return _PurchaseLineAccessControlList.PurchaseLine;
		}

		public static PurchaseLineAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
        {
			PurchaseLineAccessControlListCollection _PurchaseLineAccessControlListCollection = new PurchaseLineAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiAcCoLiGetByUs", dbconn);
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
					PurchaseLineAccessControlList o = new PurchaseLineAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._PurchaseLineIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._PurchaseLine = null; o._PurchaseLineIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _PurchaseLineAccessControlListCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PurchaseLineAccessControlListCollection;
        }
        
        public static PurchaseLineAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			PurchaseLineAccessControlListCollection _PurchaseLineAccessControlListCollection = new PurchaseLineAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiAcCoLiGetByUsPaged", dbconn);
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
					PurchaseLineAccessControlList o = new PurchaseLineAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._PurchaseLineIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._PurchaseLine = null; o._PurchaseLineIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _PurchaseLineAccessControlListCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PurchaseLineAccessControlListCollection;
        }
        
        public static long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiAcCoLiGetByUsCount", dbconn);
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

		public static PurchaseLineAccessControlListCollection GetByPurchaseLine(Services.Packages.PurchaseLine _PurchaseLine)
        {
			PurchaseLineAccessControlListCollection _PurchaseLineAccessControlListCollection = new PurchaseLineAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiAcCoLiGetByPuLi", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Id;
				if (_PurchaseLine != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_PurchaseLine.Id);
				} else {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", DBNull.Value);
				}
				command.Parameters.Add(param_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					PurchaseLineAccessControlList o = new PurchaseLineAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._PurchaseLineIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._PurchaseLine = null; o._PurchaseLineIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _PurchaseLineAccessControlListCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PurchaseLineAccessControlListCollection;
        }
        
        public static PurchaseLineAccessControlListCollection GetByPurchaseLinePaged(Services.Packages.PurchaseLine _PurchaseLine, long PagingStart, long PagingCount)
        {
			PurchaseLineAccessControlListCollection _PurchaseLineAccessControlListCollection = new PurchaseLineAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiAcCoLiGetByPuLiPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Id;
				if (_PurchaseLine != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_PurchaseLine.Id);
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
					PurchaseLineAccessControlList o = new PurchaseLineAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._PurchaseLineIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._PurchaseLine = null; o._PurchaseLineIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _PurchaseLineAccessControlListCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PurchaseLineAccessControlListCollection;
        }
        
        public static long GetByPurchaseLineCount(Services.Packages.PurchaseLine _PurchaseLine)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiAcCoLiGetByPuLiCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Id;
				if (_PurchaseLine != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_PurchaseLine.Id);
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

		public static PurchaseLineAccessControlListCollection GetACLs(System.String _UserName, Services.Packages.PurchaseLine _PurchaseLine)
        {
			PurchaseLineAccessControlListCollection _PurchaseLineAccessControlListCollection = new PurchaseLineAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiAcCoLiGeACLs", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UserName = ClassConnectionProvider.Escape(_UserName);
				
                
                DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), -1);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_PurchaseLine_Id;
				if (_PurchaseLine != null) {
				param_PurchaseLine_Id = ClassConnectionProvider.GetDatabaseParameter("PuLiId", typeof(System.Int32), -1);
				param_PurchaseLine_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_PurchaseLine.Id);
				} else {
				param_PurchaseLine_Id = ClassConnectionProvider.GetDatabaseParameter("PuLiId", DBNull.Value);
				}
				command.Parameters.Add(param_PurchaseLine_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					PurchaseLineAccessControlList o = new PurchaseLineAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._PurchaseLineIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._PurchaseLine = null; o._PurchaseLineIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _PurchaseLineAccessControlListCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PurchaseLineAccessControlListCollection;
        }
        
        public static PurchaseLineAccessControlListCollection GetACLsPaged(System.String _UserName, Services.Packages.PurchaseLine _PurchaseLine, long PagingStart, long PagingCount)
        {
			PurchaseLineAccessControlListCollection _PurchaseLineAccessControlListCollection = new PurchaseLineAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiAcCoLiGeACLsPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UserName = ClassConnectionProvider.Escape(_UserName);
				
                
                DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), -1);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_PurchaseLine_Id;
				if (_PurchaseLine != null) {
				param_PurchaseLine_Id = ClassConnectionProvider.GetDatabaseParameter("PuLiId", typeof(System.Int32), -1);
				param_PurchaseLine_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_PurchaseLine.Id);
				} else {
				param_PurchaseLine_Id = ClassConnectionProvider.GetDatabaseParameter("PuLiId", DBNull.Value);
				}
				command.Parameters.Add(param_PurchaseLine_Id);
				
                
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
					PurchaseLineAccessControlList o = new PurchaseLineAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._PurchaseLineIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._PurchaseLine = null; o._PurchaseLineIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _PurchaseLineAccessControlListCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PurchaseLineAccessControlListCollection;
        }
        
        public static long GetACLsCount(System.String _UserName, Services.Packages.PurchaseLine _PurchaseLine)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiAcCoLiGeACLsCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UserName = ClassConnectionProvider.Escape(_UserName);
				
                
                DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), -1);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_PurchaseLine_Id;
				if (_PurchaseLine != null) {
				param_PurchaseLine_Id = ClassConnectionProvider.GetDatabaseParameter("PuLiId", typeof(System.Int32), -1);
				param_PurchaseLine_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_PurchaseLine.Id);
				} else {
				param_PurchaseLine_Id = ClassConnectionProvider.GetDatabaseParameter("PuLiId", DBNull.Value);
				}
				command.Parameters.Add(param_PurchaseLine_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		Services.Packages.Security.PurchaseLineAccessControlEntryCollection _ACEs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.PurchaseLineAccessControlEntryCollection ACEs
		{
            get
            {
				if (_ACEs == null)
					_ACEs = Services.Packages.Security.PurchaseLineAccessControlEntry.GetByACL(this);
				
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
			_ACEs = Services.Packages.Security.PurchaseLineAccessControlEntry.GetByACL(this);
		}

		public Services.Packages.Security.PurchaseLineAccessControlEntryCollection GetEntries(System.String Descriptor)
		{
			return Services.Packages.Security.PurchaseLineAccessControlEntry.GetEntries(Descriptor,  this);
		}

		public bool Exists
        {
            get {
				if (!__hasBeenReadOnce)
					Exist();
				
				return __databaseState == RowState.Initialized;
			}
        }
        
        public PurchaseLineAccessControlList() {}
        
        public PurchaseLineAccessControlList(System.String __UserName, System.Int32 __Id)
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
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuLiAcCoLiRead", dbconn);
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
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "PuLiAcCoLi");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuLiAcCoLiRead", dbconn);
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
				_PurchaseLineIsLoaded = false; if (dr["Id"] == DBNull.Value) { _PurchaseLine = null; _PurchaseLineIsLoaded = true; }  else _Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "PuLiAcCoLi");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuLiAcCoLiRead", dbconn);
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
				_PurchaseLineIsLoaded = false; if (dr["Id"] == DBNull.Value) { _PurchaseLine = null; _PurchaseLineIsLoaded = true; }  else _Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuLiAcCoLiCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_User_Name = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_User_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				if (_User == null && _UserIsLoaded == true) param_User_Name.Value = DBNull.Value;
				command.Parameters.Add(param_User_Name);
				DbParameter param_PurchaseLine_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_PurchaseLine_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				if (_PurchaseLine == null && _PurchaseLineIsLoaded == true) param_PurchaseLine_Id.Value = DBNull.Value;
				command.Parameters.Add(param_PurchaseLine_Id);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_PurchaseLineIsLoaded = false; if (dr["Id"] == DBNull.Value) { _PurchaseLine = null; _PurchaseLineIsLoaded = true; }  else _Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
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
        
        static public PurchaseLineAccessControlList CreatePurchaseLineAccessControlList(System.String __UserName, System.Int32 __Id)
        {
            PurchaseLineAccessControlList o = new PurchaseLineAccessControlList(__UserName, __Id);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuLiAcCoLiUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_UserHasChanged = ClassConnectionProvider.GetDatabaseParameter("UserHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_UserIsLoaded));
				command.Parameters.Add(param_UserHasChanged);
				DbParameter param_User_Name = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_User_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				if (_User == null && _UserIsLoaded == true) param_User_Name.Value = DBNull.Value;
				command.Parameters.Add(param_User_Name);
				DbParameter param_PurchaseLineHasChanged = ClassConnectionProvider.GetDatabaseParameter("PurchaseLineHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_PurchaseLineIsLoaded));
				command.Parameters.Add(param_PurchaseLineHasChanged);
				DbParameter param_PurchaseLine_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_PurchaseLine_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				if (_PurchaseLine == null && _PurchaseLineIsLoaded == true) param_PurchaseLine_Id.Value = DBNull.Value;
				command.Parameters.Add(param_PurchaseLine_Id);
				

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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuLiAcCoLiDelete", dbconn);
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
        
        static public void DeletePurchaseLineAccessControlList(System.String __UserName, System.Int32 __Id)
        {
            PurchaseLineAccessControlList o = new PurchaseLineAccessControlList(__UserName, __Id);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(PurchaseLineAccessControlList _object)
        {
			_User = null;
			_UserIsLoaded = false;
			_PurchaseLine = null;
			_PurchaseLineIsLoaded = false;
			_UserName = _object._UserName;
			_Id = _object._Id;
			
        }
        
        public void CopyWithKeysTo(PurchaseLineAccessControlList _object)
        {
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._PurchaseLine = null;
			_object._PurchaseLineIsLoaded = false;
			_object._UserName = _UserName;
			_object._Id = _Id;
			
        }
        
        static public void CopyWithKeysObject(PurchaseLineAccessControlList _objectFrom, PurchaseLineAccessControlList _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(PurchaseLineAccessControlList _object)
        {
			_User = null;
			_UserIsLoaded = false;
			_PurchaseLine = null;
			_PurchaseLineIsLoaded = false;
			
        }
        
        public void CopyTo(PurchaseLineAccessControlList _object)
        {
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._PurchaseLine = null;
			_object._PurchaseLineIsLoaded = false;
			
        }
        
        static public void CopyObject(PurchaseLineAccessControlList _objectFrom, PurchaseLineAccessControlList _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(PurchaseLineAccessControlList).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(PurchaseLineAccessControlList).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(PurchaseLineAccessControlList _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			PurchaseLineAccessControlListUndoRedoCollection allUndidAndNotRedoneEntries = PurchaseLineAccessControlListUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			PurchaseLineAccessControlListUndoRedo _urobject = new PurchaseLineAccessControlListUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.User_Name = _object._User_Name;
			_urobject.PurchaseLine_Id = _object._PurchaseLine_Id;
			_urobject.UserName = _object._UserName;
			_urobject.Id = _object._Id;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(PurchaseLineAccessControlList).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = PurchaseLineAccessControlListUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				PurchaseLineAccessControlListUndoRedoCollection allOldUndoEntries = PurchaseLineAccessControlListUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			PurchaseLineAccessControlListUndoRedoCollection firstUndoEntries = PurchaseLineAccessControlListUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			PurchaseLineAccessControlListUndoRedo _urobject = firstUndoEntries[0];
			
			PurchaseLineAccessControlList _object = new PurchaseLineAccessControlList();
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._User_Name = _urobject.User_Name;
			_object._PurchaseLine = null;
			_object._PurchaseLineIsLoaded = false;
			_object._PurchaseLine_Id = _urobject.PurchaseLine_Id;
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
			PurchaseLineAccessControlListUndoRedoCollection firstEntryToRedoEntries = PurchaseLineAccessControlListUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			PurchaseLineAccessControlListUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			PurchaseLineAccessControlList _object = new PurchaseLineAccessControlList();
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._User_Name = _urobject.User_Name;
			_object._PurchaseLine = null;
			_object._PurchaseLineIsLoaded = false;
			_object._PurchaseLine_Id = _urobject.PurchaseLine_Id;
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
    /// Defines the contract for the PurchaseLineAccessControlListCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("6b4ef6e0-b3cc-2981-0d87-e7d29465b189")]
    public interface IPurchaseLineAccessControlListCollection : IEnumerable<PurchaseLineAccessControlList>
    {
        int IndexOf(PurchaseLineAccessControlList item);
        void Insert(int index, PurchaseLineAccessControlList item);
        void RemoveAt(int index);
        PurchaseLineAccessControlList this[int index] { get; set; }
        void Add(PurchaseLineAccessControlList item);
        void Clear();
        bool Contains(PurchaseLineAccessControlList item);
        void CopyTo(PurchaseLineAccessControlList[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(PurchaseLineAccessControlList item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.Security.PurchaseLineAccessControlList
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("aafbbc99-d75e-e58d-234d-f70be79cd5fb")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class PurchaseLineAccessControlListCollection : IPurchaseLineAccessControlListCollection, IList<PurchaseLineAccessControlList>, IHierarchicalEnumerable
    {
        List<PurchaseLineAccessControlList> _list = new List<PurchaseLineAccessControlList>();
        
        public static implicit operator List<PurchaseLineAccessControlList>(PurchaseLineAccessControlListCollection collection)
        {
            return collection._list;
        }

        #region IList<PurchaseLineAccessControlList> Members

        public int IndexOf(PurchaseLineAccessControlList item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, PurchaseLineAccessControlList item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public PurchaseLineAccessControlList this[int index]
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

        #region ICollection<PurchaseLineAccessControlList> Members

        public void Add(PurchaseLineAccessControlList item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(PurchaseLineAccessControlList item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(PurchaseLineAccessControlList[] array, int arrayIndex)
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

        public bool Remove(PurchaseLineAccessControlList item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<PurchaseLineAccessControlList> Members

        public IEnumerator<PurchaseLineAccessControlList> GetEnumerator()
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
	/// that share Services.Packages.Security.PurchaseLineAccessControlList objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Security.Web.PurchaseLineAccessControlListWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class PurchaseLineAccessControlListWebService : WebService, IPurchaseLineAccessControlListService
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
        public bool Exists(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
        {
			return _PurchaseLineAccessControlList.Exists;
        }
		
		[WebMethod]
		public PurchaseLineAccessControlList Read(System.String __UserName, System.Int32 __Id)
		{
			return new PurchaseLineAccessControlList(__UserName, __Id);
		}
		
		[WebMethod]
        public PurchaseLineAccessControlList Reload(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
        {
			_PurchaseLineAccessControlList.Reload();
			return _PurchaseLineAccessControlList;
        }
		
		[WebMethod]
        public PurchaseLineAccessControlList Create(System.String __UserName, System.Int32 __Id)
        {
			return PurchaseLineAccessControlList.CreatePurchaseLineAccessControlList(__UserName, __Id);
        }
        
        [WebMethod]
        public void Delete(System.String __UserName, System.Int32 __Id)
        {
			PurchaseLineAccessControlList.DeletePurchaseLineAccessControlList(__UserName, __Id);
        }
        
        [WebMethod]
        public void UpdateObject(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
        {
			_PurchaseLineAccessControlList.Update();
        }
		
		[WebMethod]
        public void CreateObject(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
        {
			_PurchaseLineAccessControlList.Create();
        }
        
        [WebMethod]
        public void DeleteObject(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
        {
			_PurchaseLineAccessControlList.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			PurchaseLineAccessControlList.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			PurchaseLineAccessControlList.Redo();
        }
		[WebMethod]
		public PurchaseLineAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
		{
			return PurchaseLineAccessControlList.GetByUser( _ModelUser);
		}
		[WebMethod]
		public PurchaseLineAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return PurchaseLineAccessControlList.GetByUserPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return PurchaseLineAccessControlList.GetByUserCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUser(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
		{
			_PurchaseLineAccessControlList.Reload();
			return _PurchaseLineAccessControlList.User;
		}
		[WebMethod]
		public void SetUser(PurchaseLineAccessControlList _PurchaseLineAccessControlList, Services.Packages.Security.ModelUser _User)
		{
			_PurchaseLineAccessControlList.Reload();
			_PurchaseLineAccessControlList.User = _User;
			_PurchaseLineAccessControlList.Update();
		}
		[WebMethod]
		public PurchaseLineAccessControlListCollection GetByPurchaseLine(Services.Packages.PurchaseLine _PurchaseLine)
		{
			return PurchaseLineAccessControlList.GetByPurchaseLine( _PurchaseLine);
		}
		[WebMethod]
		public PurchaseLineAccessControlListCollection GetByPurchaseLinePaged(Services.Packages.PurchaseLine _PurchaseLine, long PagingStart, long PagingCount)
		{
			return PurchaseLineAccessControlList.GetByPurchaseLinePaged( _PurchaseLine, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByPurchaseLineCount(Services.Packages.PurchaseLine _PurchaseLine)
		{
			return PurchaseLineAccessControlList.GetByPurchaseLineCount( _PurchaseLine);
		}
		[WebMethod]
		public Services.Packages.PurchaseLine GetPurchaseLine(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
		{
			_PurchaseLineAccessControlList.Reload();
			return _PurchaseLineAccessControlList.PurchaseLine;
		}
		[WebMethod]
		public void SetPurchaseLine(PurchaseLineAccessControlList _PurchaseLineAccessControlList, Services.Packages.PurchaseLine _PurchaseLine)
		{
			_PurchaseLineAccessControlList.Reload();
			_PurchaseLineAccessControlList.PurchaseLine = _PurchaseLine;
			_PurchaseLineAccessControlList.Update();
		}
		[WebMethod]
		public PurchaseLineAccessControlListCollection GetACLs(System.String UserName, Services.Packages.PurchaseLine _PurchaseLine)
		{
			return PurchaseLineAccessControlList.GetACLs(UserName,  _PurchaseLine);
		}
		[WebMethod]
		public PurchaseLineAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.PurchaseLine _PurchaseLine, long PagingStart, long PagingCount)
		{
			return PurchaseLineAccessControlList.GetACLsPaged(UserName,  _PurchaseLine, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetACLsCount(System.String UserName, Services.Packages.PurchaseLine _PurchaseLine)
		{
			return PurchaseLineAccessControlList.GetACLsCount(UserName,  _PurchaseLine);
		}
		[WebMethod]
		public Services.Packages.Security.PurchaseLineAccessControlEntryCollection GetACEs(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
		{
			_PurchaseLineAccessControlList.Reload();
			return _PurchaseLineAccessControlList.ACEs;
		}
		[WebMethod]
		public void SetACEs(PurchaseLineAccessControlList _PurchaseLineAccessControlList, Services.Packages.Security.PurchaseLineAccessControlEntryCollection _ACEs)
		{
			_PurchaseLineAccessControlList.Reload();
			_PurchaseLineAccessControlList.ACEs = _ACEs;
			_PurchaseLineAccessControlList.Update();
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="PurchaseLineAccessControlListWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("b10e7a31-3f5e-18e4-aff8-f69d4137f17a")]
    sealed public class PurchaseLineAccessControlListWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IPurchaseLineAccessControlListService
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
		public PurchaseLineAccessControlListWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public PurchaseLineAccessControlListWebServiceClient()
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
		public bool Exists(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
        {
			object[] results = this.Invoke("Exists", new object[] {_PurchaseLineAccessControlList});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineAccessControlList Read(System.String __UserName, System.Int32 __Id)
		{
			object[] results = this.Invoke("Read", new object[] {__UserName, __Id});
			return ((PurchaseLineAccessControlList)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineAccessControlList Reload(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
        {
			object[] results = this.Invoke("Reload", new object[] {_PurchaseLineAccessControlList});
			return ((PurchaseLineAccessControlList)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineAccessControlList Create(System.String __UserName, System.Int32 __Id)
        {
			object[] results = this.Invoke("Create", new object[] {__UserName, __Id});
			return ((PurchaseLineAccessControlList)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __UserName, System.Int32 __Id)
        {
			this.Invoke("Delete", new object[] {__UserName, __Id});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
        {
			this.Invoke("UpdateObject", new object[] {_PurchaseLineAccessControlList});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
        {
			this.Invoke("CreateObject", new object[] {_PurchaseLineAccessControlList});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
        {
			this.Invoke("DeleteObject", new object[] {_PurchaseLineAccessControlList});
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
		public PurchaseLineAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByUser", new object[] {_ModelUser});
			return ((PurchaseLineAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByUserPaged", new object[] {_ModelUser,PagingStart,PagingCount});
			return ((PurchaseLineAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByUserCount", new object[] {_ModelUser});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetUser(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
		{
			object[] results = this.Invoke("GetUser", new object[] {_PurchaseLineAccessControlList});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetUser(PurchaseLineAccessControlList _PurchaseLineAccessControlList, Services.Packages.Security.ModelUser _User)
		{
			this.Invoke("GetUser", new object[] {_PurchaseLineAccessControlList});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByPurchaseLine", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineAccessControlListCollection GetByPurchaseLine(Services.Packages.PurchaseLine _PurchaseLine) {
			object[] results = this.Invoke("GetByPurchaseLine", new object[] {_PurchaseLine});
			return ((PurchaseLineAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByPurchaseLinePaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineAccessControlListCollection GetByPurchaseLinePaged(Services.Packages.PurchaseLine _PurchaseLine, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByPurchaseLinePaged", new object[] {_PurchaseLine,PagingStart,PagingCount});
			return ((PurchaseLineAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByPurchaseLineCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByPurchaseLineCount(Services.Packages.PurchaseLine _PurchaseLine) {
			object[] results = this.Invoke("GetByPurchaseLineCount", new object[] {_PurchaseLine});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPurchaseLine", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.PurchaseLine GetPurchaseLine(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
		{
			object[] results = this.Invoke("GetPurchaseLine", new object[] {_PurchaseLineAccessControlList});
			return ((Services.Packages.PurchaseLine)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPurchaseLine", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPurchaseLine(PurchaseLineAccessControlList _PurchaseLineAccessControlList, Services.Packages.PurchaseLine _PurchaseLine)
		{
			this.Invoke("GetPurchaseLine", new object[] {_PurchaseLineAccessControlList});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineAccessControlListCollection GetACLs(System.String UserName, Services.Packages.PurchaseLine _PurchaseLine) {
			object[] results = this.Invoke("GetACLs", new object[] {UserName, _PurchaseLine});
			return ((PurchaseLineAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLsPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.PurchaseLine _PurchaseLine, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetACLsPaged", new object[] {UserName, _PurchaseLine,PagingStart,PagingCount});
			return ((PurchaseLineAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLsCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetACLsCount(System.String UserName, Services.Packages.PurchaseLine _PurchaseLine) {
			object[] results = this.Invoke("GetACLsCount", new object[] {UserName, _PurchaseLine});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACEs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.PurchaseLineAccessControlEntryCollection GetACEs(PurchaseLineAccessControlList _PurchaseLineAccessControlList)
		{
			object[] results = this.Invoke("GetACEs", new object[] {_PurchaseLineAccessControlList});
			return ((Services.Packages.Security.PurchaseLineAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACEs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACEs(PurchaseLineAccessControlList _PurchaseLineAccessControlList, Services.Packages.Security.PurchaseLineAccessControlEntryCollection _ACEs)
		{
			this.Invoke("GetACEs", new object[] {_PurchaseLineAccessControlList});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages.Security
