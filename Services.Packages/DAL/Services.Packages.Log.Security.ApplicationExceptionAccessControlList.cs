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

namespace Services.Packages.Log.Security
{
	/// <summary>
    /// Defines the contract for the ApplicationExceptionAccessControlList class
    /// </summary>
    [ComVisible(true)]
    [Guid("efb9ca64-2568-9c36-c053-94b11a223234")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IApplicationExceptionAccessControlList
	{
		bool Exists { get; }
		System.String UserName { get; set; }
		System.Int32 Id { get; set; }
		Services.Packages.Security.ModelUser User { get; set; }
		Services.Packages.Log.ApplicationException ApplicationException { get; set; }
		Services.Packages.Log.Security.ApplicationExceptionAccessControlEntryCollection ACEs { get; set; }
		Services.Packages.Log.Security.ApplicationExceptionAccessControlEntryCollection GetEntries(System.String Descriptor);

		void Read(System.String __UserName, System.Int32 __Id);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(ApplicationExceptionAccessControlList _object);
		void CopyWithKeysTo(ApplicationExceptionAccessControlList _object);
		void CopyFrom(ApplicationExceptionAccessControlList _object);
		void CopyTo(ApplicationExceptionAccessControlList _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.Log.Security.ApplicationExceptionAccessControlList type.
    /// </summary>
    [ComVisible(true)]
    [Guid("3ce29980-a4a8-6155-2e83-177eca2412b8")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IApplicationExceptionAccessControlListService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList);
		[OperationContract]
        ApplicationExceptionAccessControlList Read(System.String __UserName, System.Int32 __Id);
        [OperationContract]
        ApplicationExceptionAccessControlList Reload(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList);
        [OperationContract]
        ApplicationExceptionAccessControlList Create(System.String __UserName, System.Int32 __Id);
        [OperationContract]
        void Delete(System.String __UserName, System.Int32 __Id);
        [OperationContract]
        void UpdateObject(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList);
        [OperationContract]
        void CreateObject(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList);
        [OperationContract]
        void DeleteObject(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		ApplicationExceptionAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		ApplicationExceptionAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		Services.Packages.Security.ModelUser GetUser(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList);
		[OperationContract]
		void SetUser(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList, Services.Packages.Security.ModelUser _User);
		[OperationContract]
		ApplicationExceptionAccessControlListCollection GetByApplicationException(Services.Packages.Log.ApplicationException _ApplicationException);
		[OperationContract]
		ApplicationExceptionAccessControlListCollection GetByApplicationExceptionPaged(Services.Packages.Log.ApplicationException _ApplicationException, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByApplicationExceptionCount(Services.Packages.Log.ApplicationException _ApplicationException);
		[OperationContract]
		Services.Packages.Log.ApplicationException GetApplicationException(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList);
		[OperationContract]
		void SetApplicationException(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList, Services.Packages.Log.ApplicationException _ApplicationException);
		[OperationContract]
		ApplicationExceptionAccessControlListCollection GetACLs(System.String UserName, Services.Packages.Log.ApplicationException _ApplicationException);
		[OperationContract]
		ApplicationExceptionAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.Log.ApplicationException _ApplicationException, long PagingStart, long PagingCount);
		[OperationContract]
		long GetACLsCount(System.String UserName, Services.Packages.Log.ApplicationException _ApplicationException);
		[OperationContract]
		Services.Packages.Log.Security.ApplicationExceptionAccessControlEntryCollection GetACEs(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList);
		[OperationContract]
		void SetACEs(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList, Services.Packages.Log.Security.ApplicationExceptionAccessControlEntryCollection _ACEs);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.Log.Security.ApplicationExceptionAccessControlList type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("41cd98e4-b566-de36-aea4-26deade53dae")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class ApplicationExceptionAccessControlListService : IApplicationExceptionAccessControlListService
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
        public bool Exists(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
        {
			return _ApplicationExceptionAccessControlList.Exists;
        }
		
		[WebMethod]
		public ApplicationExceptionAccessControlList Read(System.String __UserName, System.Int32 __Id)
		{
			return new ApplicationExceptionAccessControlList(__UserName, __Id);
		}
		
		[WebMethod]
        public ApplicationExceptionAccessControlList Reload(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
        {
			_ApplicationExceptionAccessControlList.Reload();
			return _ApplicationExceptionAccessControlList;
        }
		
		[WebMethod]
        public ApplicationExceptionAccessControlList Create(System.String __UserName, System.Int32 __Id)
        {
			return ApplicationExceptionAccessControlList.CreateApplicationExceptionAccessControlList(__UserName, __Id);
        }
        
        [WebMethod]
        public void Delete(System.String __UserName, System.Int32 __Id)
        {
			ApplicationExceptionAccessControlList.DeleteApplicationExceptionAccessControlList(__UserName, __Id);
        }
        
        [WebMethod]
        public void UpdateObject(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
        {
			_ApplicationExceptionAccessControlList.Update();
        }
		
		[WebMethod]
        public void CreateObject(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
        {
			_ApplicationExceptionAccessControlList.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
        {
			_ApplicationExceptionAccessControlList.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			ApplicationExceptionAccessControlList.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			ApplicationExceptionAccessControlList.Redo();
        }
		[WebMethod]
		public ApplicationExceptionAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ApplicationExceptionAccessControlList.GetByUser( _ModelUser);
		}
		[WebMethod]
		public ApplicationExceptionAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ApplicationExceptionAccessControlList.GetByUserPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ApplicationExceptionAccessControlList.GetByUserCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUser(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
		{
			_ApplicationExceptionAccessControlList.Reload();
			return _ApplicationExceptionAccessControlList.User;
		}
		[WebMethod]
		public void SetUser(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList, Services.Packages.Security.ModelUser _User)
		{
			_ApplicationExceptionAccessControlList.Reload();
			_ApplicationExceptionAccessControlList.User = _User;
			_ApplicationExceptionAccessControlList.Update();
		}
		[WebMethod]
		public ApplicationExceptionAccessControlListCollection GetByApplicationException(Services.Packages.Log.ApplicationException _ApplicationException)
		{
			return ApplicationExceptionAccessControlList.GetByApplicationException( _ApplicationException);
		}
		[WebMethod]
		public ApplicationExceptionAccessControlListCollection GetByApplicationExceptionPaged(Services.Packages.Log.ApplicationException _ApplicationException, long PagingStart, long PagingCount)
		{
			return ApplicationExceptionAccessControlList.GetByApplicationExceptionPaged( _ApplicationException, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByApplicationExceptionCount(Services.Packages.Log.ApplicationException _ApplicationException)
		{
			return ApplicationExceptionAccessControlList.GetByApplicationExceptionCount( _ApplicationException);
		}
		[WebMethod]
		public Services.Packages.Log.ApplicationException GetApplicationException(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
		{
			_ApplicationExceptionAccessControlList.Reload();
			return _ApplicationExceptionAccessControlList.ApplicationException;
		}
		[WebMethod]
		public void SetApplicationException(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList, Services.Packages.Log.ApplicationException _ApplicationException)
		{
			_ApplicationExceptionAccessControlList.Reload();
			_ApplicationExceptionAccessControlList.ApplicationException = _ApplicationException;
			_ApplicationExceptionAccessControlList.Update();
		}
		[WebMethod]
		public ApplicationExceptionAccessControlListCollection GetACLs(System.String UserName, Services.Packages.Log.ApplicationException _ApplicationException)
		{
			return ApplicationExceptionAccessControlList.GetACLs(UserName,  _ApplicationException);
		}
		[WebMethod]
		public ApplicationExceptionAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.Log.ApplicationException _ApplicationException, long PagingStart, long PagingCount)
		{
			return ApplicationExceptionAccessControlList.GetACLsPaged(UserName,  _ApplicationException, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetACLsCount(System.String UserName, Services.Packages.Log.ApplicationException _ApplicationException)
		{
			return ApplicationExceptionAccessControlList.GetACLsCount(UserName,  _ApplicationException);
		}
		[WebMethod]
		public Services.Packages.Log.Security.ApplicationExceptionAccessControlEntryCollection GetACEs(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
		{
			_ApplicationExceptionAccessControlList.Reload();
			return _ApplicationExceptionAccessControlList.ACEs;
		}
		[WebMethod]
		public void SetACEs(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList, Services.Packages.Log.Security.ApplicationExceptionAccessControlEntryCollection _ACEs)
		{
			_ApplicationExceptionAccessControlList.Reload();
			_ApplicationExceptionAccessControlList.ACEs = _ACEs;
			_ApplicationExceptionAccessControlList.Update();
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.Log.Security.ApplicationExceptionAccessControlList model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("c80141fb-5e7e-c0be-7557-c0e50eb7d19b")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class ApplicationExceptionAccessControlList : IApplicationExceptionAccessControlList, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<IApplicationExceptionAccessControlListService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<IApplicationExceptionAccessControlListService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<IApplicationExceptionAccessControlListService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Log.Security.ApplicationExceptionAccessControlList"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Log.Security.ApplicationExceptionAccessControlList"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.Log.Security.ApplicationExceptionAccessControlList.ProviderType");
				
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
		
		public static Services.Packages.Security.ModelUser GetUser(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
		{
			return _ApplicationExceptionAccessControlList.User;
		}

		bool _ApplicationExceptionIsLoaded = false;
		Services.Packages.Log.ApplicationException _ApplicationException;
		
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Log.ApplicationException ApplicationException
		{
            get
            {
				if (!_ApplicationExceptionIsLoaded)
				{
					_ApplicationException = new Services.Packages.Log.ApplicationException(_Id);
					if (_ApplicationException.Exists)
						_ApplicationExceptionIsLoaded = true;
					else _ApplicationException = null;
				}
                return _ApplicationException;
            }
            set
            {
                _ApplicationException = value;
                _ApplicationExceptionIsLoaded = true;
                if (_ApplicationException != null)
                {
					if (_ApplicationException.Exists)
					{
						_Id = _ApplicationException.Id;
						
					}
					else
					{
						_ApplicationException = null;
					}
				}
            }
		}
		
		public static Services.Packages.Log.ApplicationException GetApplicationException(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
		{
			return _ApplicationExceptionAccessControlList.ApplicationException;
		}

		public static ApplicationExceptionAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
        {
			ApplicationExceptionAccessControlListCollection _ApplicationExceptionAccessControlListCollection = new ApplicationExceptionAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExAcCoLiGetByUs", dbconn);
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
					ApplicationExceptionAccessControlList o = new ApplicationExceptionAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._ApplicationExceptionIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._ApplicationException = null; o._ApplicationExceptionIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _ApplicationExceptionAccessControlListCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ApplicationExceptionAccessControlListCollection;
        }
        
        public static ApplicationExceptionAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			ApplicationExceptionAccessControlListCollection _ApplicationExceptionAccessControlListCollection = new ApplicationExceptionAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExAcCoLiGetByUsPaged", dbconn);
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
					ApplicationExceptionAccessControlList o = new ApplicationExceptionAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._ApplicationExceptionIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._ApplicationException = null; o._ApplicationExceptionIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _ApplicationExceptionAccessControlListCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ApplicationExceptionAccessControlListCollection;
        }
        
        public static long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExAcCoLiGetByUsCount", dbconn);
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

		public static ApplicationExceptionAccessControlListCollection GetByApplicationException(Services.Packages.Log.ApplicationException _ApplicationException)
        {
			ApplicationExceptionAccessControlListCollection _ApplicationExceptionAccessControlListCollection = new ApplicationExceptionAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExAcCoLiGetByApEx", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Id;
				if (_ApplicationException != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApplicationException.Id);
				} else {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", DBNull.Value);
				}
				command.Parameters.Add(param_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					ApplicationExceptionAccessControlList o = new ApplicationExceptionAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._ApplicationExceptionIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._ApplicationException = null; o._ApplicationExceptionIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _ApplicationExceptionAccessControlListCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ApplicationExceptionAccessControlListCollection;
        }
        
        public static ApplicationExceptionAccessControlListCollection GetByApplicationExceptionPaged(Services.Packages.Log.ApplicationException _ApplicationException, long PagingStart, long PagingCount)
        {
			ApplicationExceptionAccessControlListCollection _ApplicationExceptionAccessControlListCollection = new ApplicationExceptionAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExAcCoLiGetByApExPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Id;
				if (_ApplicationException != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApplicationException.Id);
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
					ApplicationExceptionAccessControlList o = new ApplicationExceptionAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._ApplicationExceptionIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._ApplicationException = null; o._ApplicationExceptionIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _ApplicationExceptionAccessControlListCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ApplicationExceptionAccessControlListCollection;
        }
        
        public static long GetByApplicationExceptionCount(Services.Packages.Log.ApplicationException _ApplicationException)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExAcCoLiGetByApExCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Id;
				if (_ApplicationException != null) {
				param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApplicationException.Id);
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

		public static ApplicationExceptionAccessControlListCollection GetACLs(System.String _UserName, Services.Packages.Log.ApplicationException _ApplicationException)
        {
			ApplicationExceptionAccessControlListCollection _ApplicationExceptionAccessControlListCollection = new ApplicationExceptionAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExAcCoLiGeACLs", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UserName = ClassConnectionProvider.Escape(_UserName);
				
                
                DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), -1);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_ApplicationException_Id;
				if (_ApplicationException != null) {
				param_ApplicationException_Id = ClassConnectionProvider.GetDatabaseParameter("ApExId", typeof(System.Int32), -1);
				param_ApplicationException_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApplicationException.Id);
				} else {
				param_ApplicationException_Id = ClassConnectionProvider.GetDatabaseParameter("ApExId", DBNull.Value);
				}
				command.Parameters.Add(param_ApplicationException_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					ApplicationExceptionAccessControlList o = new ApplicationExceptionAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._ApplicationExceptionIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._ApplicationException = null; o._ApplicationExceptionIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _ApplicationExceptionAccessControlListCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ApplicationExceptionAccessControlListCollection;
        }
        
        public static ApplicationExceptionAccessControlListCollection GetACLsPaged(System.String _UserName, Services.Packages.Log.ApplicationException _ApplicationException, long PagingStart, long PagingCount)
        {
			ApplicationExceptionAccessControlListCollection _ApplicationExceptionAccessControlListCollection = new ApplicationExceptionAccessControlListCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExAcCoLiGeACLsPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UserName = ClassConnectionProvider.Escape(_UserName);
				
                
                DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), -1);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_ApplicationException_Id;
				if (_ApplicationException != null) {
				param_ApplicationException_Id = ClassConnectionProvider.GetDatabaseParameter("ApExId", typeof(System.Int32), -1);
				param_ApplicationException_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApplicationException.Id);
				} else {
				param_ApplicationException_Id = ClassConnectionProvider.GetDatabaseParameter("ApExId", DBNull.Value);
				}
				command.Parameters.Add(param_ApplicationException_Id);
				
                
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
					ApplicationExceptionAccessControlList o = new ApplicationExceptionAccessControlList();
                
					o.__databaseState = RowState.Initialized;
                    o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { o._User = null; o._UserIsLoaded = true; }  else o._UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				o._ApplicationExceptionIsLoaded = false; if (dr["Id"] == DBNull.Value) { o._ApplicationException = null; o._ApplicationExceptionIsLoaded = true; }  else o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
                    _ApplicationExceptionAccessControlListCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ApplicationExceptionAccessControlListCollection;
        }
        
        public static long GetACLsCount(System.String _UserName, Services.Packages.Log.ApplicationException _ApplicationException)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExAcCoLiGeACLsCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _UserName = ClassConnectionProvider.Escape(_UserName);
				
                
                DbParameter param_UserName = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), -1);
				param_UserName.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				command.Parameters.Add(param_UserName);
				DbParameter param_ApplicationException_Id;
				if (_ApplicationException != null) {
				param_ApplicationException_Id = ClassConnectionProvider.GetDatabaseParameter("ApExId", typeof(System.Int32), -1);
				param_ApplicationException_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApplicationException.Id);
				} else {
				param_ApplicationException_Id = ClassConnectionProvider.GetDatabaseParameter("ApExId", DBNull.Value);
				}
				command.Parameters.Add(param_ApplicationException_Id);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		Services.Packages.Log.Security.ApplicationExceptionAccessControlEntryCollection _ACEs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Log.Security.ApplicationExceptionAccessControlEntryCollection ACEs
		{
            get
            {
				if (_ACEs == null)
					_ACEs = Services.Packages.Log.Security.ApplicationExceptionAccessControlEntry.GetByACL(this);
				
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
			_ACEs = Services.Packages.Log.Security.ApplicationExceptionAccessControlEntry.GetByACL(this);
		}

		public Services.Packages.Log.Security.ApplicationExceptionAccessControlEntryCollection GetEntries(System.String Descriptor)
		{
			return Services.Packages.Log.Security.ApplicationExceptionAccessControlEntry.GetEntries(Descriptor,  this);
		}

		public bool Exists
        {
            get {
				if (!__hasBeenReadOnce)
					Exist();
				
				return __databaseState == RowState.Initialized;
			}
        }
        
        public ApplicationExceptionAccessControlList() {}
        
        public ApplicationExceptionAccessControlList(System.String __UserName, System.Int32 __Id)
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
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApExAcCoLiRead", dbconn);
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
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "ApExAcCoLi");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApExAcCoLiRead", dbconn);
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
				_ApplicationExceptionIsLoaded = false; if (dr["Id"] == DBNull.Value) { _ApplicationException = null; _ApplicationExceptionIsLoaded = true; }  else _Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "ApExAcCoLi");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApExAcCoLiRead", dbconn);
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
				_ApplicationExceptionIsLoaded = false; if (dr["Id"] == DBNull.Value) { _ApplicationException = null; _ApplicationExceptionIsLoaded = true; }  else _Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
                    
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApExAcCoLiCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_User_Name = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_User_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				if (_User == null && _UserIsLoaded == true) param_User_Name.Value = DBNull.Value;
				command.Parameters.Add(param_User_Name);
				DbParameter param_ApplicationException_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_ApplicationException_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				if (_ApplicationException == null && _ApplicationExceptionIsLoaded == true) param_ApplicationException_Id.Value = DBNull.Value;
				command.Parameters.Add(param_ApplicationException_Id);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_UserIsLoaded = false; if (dr["UserName"] == DBNull.Value) { _User = null; _UserIsLoaded = true; }  else _UserName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UserName"], typeof(System.String));
				_ApplicationExceptionIsLoaded = false; if (dr["Id"] == DBNull.Value) { _ApplicationException = null; _ApplicationExceptionIsLoaded = true; }  else _Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				
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
        
        static public ApplicationExceptionAccessControlList CreateApplicationExceptionAccessControlList(System.String __UserName, System.Int32 __Id)
        {
            ApplicationExceptionAccessControlList o = new ApplicationExceptionAccessControlList(__UserName, __Id);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApExAcCoLiUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_UserHasChanged = ClassConnectionProvider.GetDatabaseParameter("UserHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_UserIsLoaded));
				command.Parameters.Add(param_UserHasChanged);
				DbParameter param_User_Name = ClassConnectionProvider.GetDatabaseParameter("UserName", typeof(System.String), 128);
				param_User_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_UserName);
				if (_User == null && _UserIsLoaded == true) param_User_Name.Value = DBNull.Value;
				command.Parameters.Add(param_User_Name);
				DbParameter param_ApplicationExceptionHasChanged = ClassConnectionProvider.GetDatabaseParameter("ApplicationExceptionHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_ApplicationExceptionIsLoaded));
				command.Parameters.Add(param_ApplicationExceptionHasChanged);
				DbParameter param_ApplicationException_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_ApplicationException_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				if (_ApplicationException == null && _ApplicationExceptionIsLoaded == true) param_ApplicationException_Id.Value = DBNull.Value;
				command.Parameters.Add(param_ApplicationException_Id);
				

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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApExAcCoLiDelete", dbconn);
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
        
        static public void DeleteApplicationExceptionAccessControlList(System.String __UserName, System.Int32 __Id)
        {
            ApplicationExceptionAccessControlList o = new ApplicationExceptionAccessControlList(__UserName, __Id);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(ApplicationExceptionAccessControlList _object)
        {
			_User = null;
			_UserIsLoaded = false;
			_ApplicationException = null;
			_ApplicationExceptionIsLoaded = false;
			_UserName = _object._UserName;
			_Id = _object._Id;
			
        }
        
        public void CopyWithKeysTo(ApplicationExceptionAccessControlList _object)
        {
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._ApplicationException = null;
			_object._ApplicationExceptionIsLoaded = false;
			_object._UserName = _UserName;
			_object._Id = _Id;
			
        }
        
        static public void CopyWithKeysObject(ApplicationExceptionAccessControlList _objectFrom, ApplicationExceptionAccessControlList _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(ApplicationExceptionAccessControlList _object)
        {
			_User = null;
			_UserIsLoaded = false;
			_ApplicationException = null;
			_ApplicationExceptionIsLoaded = false;
			
        }
        
        public void CopyTo(ApplicationExceptionAccessControlList _object)
        {
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._ApplicationException = null;
			_object._ApplicationExceptionIsLoaded = false;
			
        }
        
        static public void CopyObject(ApplicationExceptionAccessControlList _objectFrom, ApplicationExceptionAccessControlList _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(ApplicationExceptionAccessControlList).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(ApplicationExceptionAccessControlList).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(ApplicationExceptionAccessControlList _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			ApplicationExceptionAccessControlListUndoRedoCollection allUndidAndNotRedoneEntries = ApplicationExceptionAccessControlListUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			ApplicationExceptionAccessControlListUndoRedo _urobject = new ApplicationExceptionAccessControlListUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.User_Name = _object._User_Name;
			_urobject.ApplicationException_Id = _object._ApplicationException_Id;
			_urobject.UserName = _object._UserName;
			_urobject.Id = _object._Id;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(ApplicationExceptionAccessControlList).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = ApplicationExceptionAccessControlListUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				ApplicationExceptionAccessControlListUndoRedoCollection allOldUndoEntries = ApplicationExceptionAccessControlListUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			ApplicationExceptionAccessControlListUndoRedoCollection firstUndoEntries = ApplicationExceptionAccessControlListUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			ApplicationExceptionAccessControlListUndoRedo _urobject = firstUndoEntries[0];
			
			ApplicationExceptionAccessControlList _object = new ApplicationExceptionAccessControlList();
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._User_Name = _urobject.User_Name;
			_object._ApplicationException = null;
			_object._ApplicationExceptionIsLoaded = false;
			_object._ApplicationException_Id = _urobject.ApplicationException_Id;
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
			ApplicationExceptionAccessControlListUndoRedoCollection firstEntryToRedoEntries = ApplicationExceptionAccessControlListUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			ApplicationExceptionAccessControlListUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			ApplicationExceptionAccessControlList _object = new ApplicationExceptionAccessControlList();
			_object._User = null;
			_object._UserIsLoaded = false;
			_object._User_Name = _urobject.User_Name;
			_object._ApplicationException = null;
			_object._ApplicationExceptionIsLoaded = false;
			_object._ApplicationException_Id = _urobject.ApplicationException_Id;
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
    /// Defines the contract for the ApplicationExceptionAccessControlListCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("82cddb41-f054-cbcd-6303-8d037d76b349")]
    public interface IApplicationExceptionAccessControlListCollection : IEnumerable<ApplicationExceptionAccessControlList>
    {
        int IndexOf(ApplicationExceptionAccessControlList item);
        void Insert(int index, ApplicationExceptionAccessControlList item);
        void RemoveAt(int index);
        ApplicationExceptionAccessControlList this[int index] { get; set; }
        void Add(ApplicationExceptionAccessControlList item);
        void Clear();
        bool Contains(ApplicationExceptionAccessControlList item);
        void CopyTo(ApplicationExceptionAccessControlList[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(ApplicationExceptionAccessControlList item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.Log.Security.ApplicationExceptionAccessControlList
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("88826945-4923-853a-d90d-cc0ff451d0f6")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class ApplicationExceptionAccessControlListCollection : IApplicationExceptionAccessControlListCollection, IList<ApplicationExceptionAccessControlList>, IHierarchicalEnumerable
    {
        List<ApplicationExceptionAccessControlList> _list = new List<ApplicationExceptionAccessControlList>();
        
        public static implicit operator List<ApplicationExceptionAccessControlList>(ApplicationExceptionAccessControlListCollection collection)
        {
            return collection._list;
        }

        #region IList<ApplicationExceptionAccessControlList> Members

        public int IndexOf(ApplicationExceptionAccessControlList item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, ApplicationExceptionAccessControlList item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public ApplicationExceptionAccessControlList this[int index]
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

        #region ICollection<ApplicationExceptionAccessControlList> Members

        public void Add(ApplicationExceptionAccessControlList item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(ApplicationExceptionAccessControlList item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(ApplicationExceptionAccessControlList[] array, int arrayIndex)
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

        public bool Remove(ApplicationExceptionAccessControlList item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<ApplicationExceptionAccessControlList> Members

        public IEnumerator<ApplicationExceptionAccessControlList> GetEnumerator()
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
	/// that share Services.Packages.Log.Security.ApplicationExceptionAccessControlList objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Log.Security.Web.ApplicationExceptionAccessControlListWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class ApplicationExceptionAccessControlListWebService : WebService, IApplicationExceptionAccessControlListService
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
        public bool Exists(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
        {
			return _ApplicationExceptionAccessControlList.Exists;
        }
		
		[WebMethod]
		public ApplicationExceptionAccessControlList Read(System.String __UserName, System.Int32 __Id)
		{
			return new ApplicationExceptionAccessControlList(__UserName, __Id);
		}
		
		[WebMethod]
        public ApplicationExceptionAccessControlList Reload(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
        {
			_ApplicationExceptionAccessControlList.Reload();
			return _ApplicationExceptionAccessControlList;
        }
		
		[WebMethod]
        public ApplicationExceptionAccessControlList Create(System.String __UserName, System.Int32 __Id)
        {
			return ApplicationExceptionAccessControlList.CreateApplicationExceptionAccessControlList(__UserName, __Id);
        }
        
        [WebMethod]
        public void Delete(System.String __UserName, System.Int32 __Id)
        {
			ApplicationExceptionAccessControlList.DeleteApplicationExceptionAccessControlList(__UserName, __Id);
        }
        
        [WebMethod]
        public void UpdateObject(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
        {
			_ApplicationExceptionAccessControlList.Update();
        }
		
		[WebMethod]
        public void CreateObject(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
        {
			_ApplicationExceptionAccessControlList.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
        {
			_ApplicationExceptionAccessControlList.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			ApplicationExceptionAccessControlList.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			ApplicationExceptionAccessControlList.Redo();
        }
		[WebMethod]
		public ApplicationExceptionAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ApplicationExceptionAccessControlList.GetByUser( _ModelUser);
		}
		[WebMethod]
		public ApplicationExceptionAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ApplicationExceptionAccessControlList.GetByUserPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ApplicationExceptionAccessControlList.GetByUserCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetUser(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
		{
			_ApplicationExceptionAccessControlList.Reload();
			return _ApplicationExceptionAccessControlList.User;
		}
		[WebMethod]
		public void SetUser(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList, Services.Packages.Security.ModelUser _User)
		{
			_ApplicationExceptionAccessControlList.Reload();
			_ApplicationExceptionAccessControlList.User = _User;
			_ApplicationExceptionAccessControlList.Update();
		}
		[WebMethod]
		public ApplicationExceptionAccessControlListCollection GetByApplicationException(Services.Packages.Log.ApplicationException _ApplicationException)
		{
			return ApplicationExceptionAccessControlList.GetByApplicationException( _ApplicationException);
		}
		[WebMethod]
		public ApplicationExceptionAccessControlListCollection GetByApplicationExceptionPaged(Services.Packages.Log.ApplicationException _ApplicationException, long PagingStart, long PagingCount)
		{
			return ApplicationExceptionAccessControlList.GetByApplicationExceptionPaged( _ApplicationException, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByApplicationExceptionCount(Services.Packages.Log.ApplicationException _ApplicationException)
		{
			return ApplicationExceptionAccessControlList.GetByApplicationExceptionCount( _ApplicationException);
		}
		[WebMethod]
		public Services.Packages.Log.ApplicationException GetApplicationException(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
		{
			_ApplicationExceptionAccessControlList.Reload();
			return _ApplicationExceptionAccessControlList.ApplicationException;
		}
		[WebMethod]
		public void SetApplicationException(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList, Services.Packages.Log.ApplicationException _ApplicationException)
		{
			_ApplicationExceptionAccessControlList.Reload();
			_ApplicationExceptionAccessControlList.ApplicationException = _ApplicationException;
			_ApplicationExceptionAccessControlList.Update();
		}
		[WebMethod]
		public ApplicationExceptionAccessControlListCollection GetACLs(System.String UserName, Services.Packages.Log.ApplicationException _ApplicationException)
		{
			return ApplicationExceptionAccessControlList.GetACLs(UserName,  _ApplicationException);
		}
		[WebMethod]
		public ApplicationExceptionAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.Log.ApplicationException _ApplicationException, long PagingStart, long PagingCount)
		{
			return ApplicationExceptionAccessControlList.GetACLsPaged(UserName,  _ApplicationException, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetACLsCount(System.String UserName, Services.Packages.Log.ApplicationException _ApplicationException)
		{
			return ApplicationExceptionAccessControlList.GetACLsCount(UserName,  _ApplicationException);
		}
		[WebMethod]
		public Services.Packages.Log.Security.ApplicationExceptionAccessControlEntryCollection GetACEs(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
		{
			_ApplicationExceptionAccessControlList.Reload();
			return _ApplicationExceptionAccessControlList.ACEs;
		}
		[WebMethod]
		public void SetACEs(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList, Services.Packages.Log.Security.ApplicationExceptionAccessControlEntryCollection _ACEs)
		{
			_ApplicationExceptionAccessControlList.Reload();
			_ApplicationExceptionAccessControlList.ACEs = _ACEs;
			_ApplicationExceptionAccessControlList.Update();
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="ApplicationExceptionAccessControlListWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("d29d8bd2-bb18-0b5a-7336-657bd1bb42fe")]
    sealed public class ApplicationExceptionAccessControlListWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IApplicationExceptionAccessControlListService
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
		public ApplicationExceptionAccessControlListWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public ApplicationExceptionAccessControlListWebServiceClient()
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
		public bool Exists(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
        {
			object[] results = this.Invoke("Exists", new object[] {_ApplicationExceptionAccessControlList});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionAccessControlList Read(System.String __UserName, System.Int32 __Id)
		{
			object[] results = this.Invoke("Read", new object[] {__UserName, __Id});
			return ((ApplicationExceptionAccessControlList)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionAccessControlList Reload(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
        {
			object[] results = this.Invoke("Reload", new object[] {_ApplicationExceptionAccessControlList});
			return ((ApplicationExceptionAccessControlList)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionAccessControlList Create(System.String __UserName, System.Int32 __Id)
        {
			object[] results = this.Invoke("Create", new object[] {__UserName, __Id});
			return ((ApplicationExceptionAccessControlList)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __UserName, System.Int32 __Id)
        {
			this.Invoke("Delete", new object[] {__UserName, __Id});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
        {
			this.Invoke("UpdateObject", new object[] {_ApplicationExceptionAccessControlList});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
        {
			this.Invoke("CreateObject", new object[] {_ApplicationExceptionAccessControlList});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
        {
			this.Invoke("DeleteObject", new object[] {_ApplicationExceptionAccessControlList});
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
		public ApplicationExceptionAccessControlListCollection GetByUser(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByUser", new object[] {_ModelUser});
			return ((ApplicationExceptionAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionAccessControlListCollection GetByUserPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByUserPaged", new object[] {_ModelUser,PagingStart,PagingCount});
			return ((ApplicationExceptionAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByUserCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByUserCount(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByUserCount", new object[] {_ModelUser});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetUser(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
		{
			object[] results = this.Invoke("GetUser", new object[] {_ApplicationExceptionAccessControlList});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetUser", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetUser(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList, Services.Packages.Security.ModelUser _User)
		{
			this.Invoke("GetUser", new object[] {_ApplicationExceptionAccessControlList});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByApplicationException", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionAccessControlListCollection GetByApplicationException(Services.Packages.Log.ApplicationException _ApplicationException) {
			object[] results = this.Invoke("GetByApplicationException", new object[] {_ApplicationException});
			return ((ApplicationExceptionAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByApplicationExceptionPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionAccessControlListCollection GetByApplicationExceptionPaged(Services.Packages.Log.ApplicationException _ApplicationException, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByApplicationExceptionPaged", new object[] {_ApplicationException,PagingStart,PagingCount});
			return ((ApplicationExceptionAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByApplicationExceptionCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByApplicationExceptionCount(Services.Packages.Log.ApplicationException _ApplicationException) {
			object[] results = this.Invoke("GetByApplicationExceptionCount", new object[] {_ApplicationException});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetApplicationException", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Log.ApplicationException GetApplicationException(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
		{
			object[] results = this.Invoke("GetApplicationException", new object[] {_ApplicationExceptionAccessControlList});
			return ((Services.Packages.Log.ApplicationException)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetApplicationException", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetApplicationException(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList, Services.Packages.Log.ApplicationException _ApplicationException)
		{
			this.Invoke("GetApplicationException", new object[] {_ApplicationExceptionAccessControlList});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionAccessControlListCollection GetACLs(System.String UserName, Services.Packages.Log.ApplicationException _ApplicationException) {
			object[] results = this.Invoke("GetACLs", new object[] {UserName, _ApplicationException});
			return ((ApplicationExceptionAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLsPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionAccessControlListCollection GetACLsPaged(System.String UserName, Services.Packages.Log.ApplicationException _ApplicationException, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetACLsPaged", new object[] {UserName, _ApplicationException,PagingStart,PagingCount});
			return ((ApplicationExceptionAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLsCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetACLsCount(System.String UserName, Services.Packages.Log.ApplicationException _ApplicationException) {
			object[] results = this.Invoke("GetACLsCount", new object[] {UserName, _ApplicationException});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACEs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Log.Security.ApplicationExceptionAccessControlEntryCollection GetACEs(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList)
		{
			object[] results = this.Invoke("GetACEs", new object[] {_ApplicationExceptionAccessControlList});
			return ((Services.Packages.Log.Security.ApplicationExceptionAccessControlEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACEs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACEs(ApplicationExceptionAccessControlList _ApplicationExceptionAccessControlList, Services.Packages.Log.Security.ApplicationExceptionAccessControlEntryCollection _ACEs)
		{
			this.Invoke("GetACEs", new object[] {_ApplicationExceptionAccessControlList});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages.Log.Security
