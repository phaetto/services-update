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

namespace Services.Packages.Log
{
	/// <summary>
    /// Defines the contract for the ApplicationException class
    /// </summary>
    [ComVisible(true)]
    [Guid("26c49c8b-b239-e1f7-a8de-199c75a5042d")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IApplicationException
	{
		bool Exists { get; }
		System.Int32 Id { get; set; }
		System.String Message { get; set; }
		System.String Source { get; set; }
		System.String StackTrace { get; set; }
		System.String Page { get; set; }
		System.DateTime OnDate { get; set; }
		System.Boolean IsSolved { get; set; }
		Services.Packages.ApiKey ApiKey { get; set; }
		Services.Packages.Log.ApplicationException ParentException { get; set; }
		Services.Packages.Security.ModelUser Owner { get; set; }
		Services.Packages.Log.ApplicationExceptionCollection InnerExceptions { get; set; }
		Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection ACLs { get; set; }
		Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection GetACLs(System.String UserName);

		void Read(System.Int32 __Id);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(ApplicationException _object);
		void CopyWithKeysTo(ApplicationException _object);
		void CopyFrom(ApplicationException _object);
		void CopyTo(ApplicationException _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.Log.ApplicationException type.
    /// </summary>
    [ComVisible(true)]
    [Guid("1b1ce6fa-cae0-bd55-c72b-d93faa039006")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IApplicationExceptionService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(ApplicationException _ApplicationException);
		[OperationContract]
        ApplicationException Read(System.Int32 __Id);
        [OperationContract]
        ApplicationException Reload(ApplicationException _ApplicationException);
        [OperationContract]
        ApplicationException Create(System.Int32 __Id);
        [OperationContract]
        void Delete(System.Int32 __Id);
        [OperationContract]
        void UpdateObject(ApplicationException _ApplicationException);
        [OperationContract]
        void CreateObject(ApplicationException _ApplicationException);
        [OperationContract]
        void DeleteObject(ApplicationException _ApplicationException);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		ApplicationExceptionCollection GetByApiKey(Services.Packages.ApiKey _ApiKey);
		[OperationContract]
		ApplicationExceptionCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey);
		[OperationContract]
		Services.Packages.ApiKey GetApiKey(ApplicationException _ApplicationException);
		[OperationContract]
		void SetApiKey(ApplicationException _ApplicationException, Services.Packages.ApiKey _ApiKey);
		[OperationContract]
		ApplicationExceptionCollection GetByParentException(Services.Packages.Log.ApplicationException _ApplicationException);
		[OperationContract]
		ApplicationExceptionCollection GetByParentExceptionPaged(Services.Packages.Log.ApplicationException _ApplicationException, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByParentExceptionCount(Services.Packages.Log.ApplicationException _ApplicationException);
		[OperationContract]
		Services.Packages.Log.ApplicationException GetParentException(ApplicationException _ApplicationException);
		[OperationContract]
		void SetParentException(ApplicationException _ApplicationException, Services.Packages.Log.ApplicationException _ParentException);
		[OperationContract]
		ApplicationExceptionCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		ApplicationExceptionCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		Services.Packages.Security.ModelUser GetOwner(ApplicationException _ApplicationException);
		[OperationContract]
		void SetOwner(ApplicationException _ApplicationException, Services.Packages.Security.ModelUser _Owner);
		[OperationContract]
		ApplicationExceptionCollection SearchByName(System.String Message );
		[OperationContract]
		ApplicationExceptionCollection SearchByNamePaged(System.String Message , long PagingStart, long PagingCount);
		[OperationContract]
		long SearchByNameCount(System.String Message );
		[OperationContract]
		ApplicationExceptionCollection SearchByNameSolved(System.String Message, System.Boolean IsSolved );
		[OperationContract]
		ApplicationExceptionCollection SearchByNameSolvedPaged(System.String Message, System.Boolean IsSolved , long PagingStart, long PagingCount);
		[OperationContract]
		long SearchByNameSolvedCount(System.String Message, System.Boolean IsSolved );
		[OperationContract]
		ApplicationExceptionCollection SearchByNameOnApiKey(System.String Message, Services.Packages.ApiKey _ApiKey);
		[OperationContract]
		ApplicationExceptionCollection SearchByNameOnApiKeyPaged(System.String Message, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount);
		[OperationContract]
		long SearchByNameOnApiKeyCount(System.String Message, Services.Packages.ApiKey _ApiKey);
		[OperationContract]
		ApplicationExceptionCollection SearchByNameSolvedOnApiKey(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey);
		[OperationContract]
		ApplicationExceptionCollection SearchByNameSolvedOnApiKeyPaged(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount);
		[OperationContract]
		long SearchByNameSolvedOnApiKeyCount(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey);
		[OperationContract]
		Services.Packages.Log.ApplicationExceptionCollection GetInnerExceptions(ApplicationException _ApplicationException);
		[OperationContract]
		void SetInnerExceptions(ApplicationException _ApplicationException, Services.Packages.Log.ApplicationExceptionCollection _InnerExceptions);
		[OperationContract]
		Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection GetACLs(ApplicationException _ApplicationException);
		[OperationContract]
		void SetACLs(ApplicationException _ApplicationException, Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection _ACLs);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.Log.ApplicationException type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("37dff1c0-cc32-2477-59d6-3f07b028bf14")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class ApplicationExceptionService : IApplicationExceptionService
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
        public bool Exists(ApplicationException _ApplicationException)
        {
			return _ApplicationException.Exists;
        }
		
		[WebMethod]
		public ApplicationException Read(System.Int32 __Id)
		{
			return new ApplicationException(__Id);
		}
		
		[WebMethod]
        public ApplicationException Reload(ApplicationException _ApplicationException)
        {
			_ApplicationException.Reload();
			return _ApplicationException;
        }
		
		[WebMethod]
        public ApplicationException Create(System.Int32 __Id)
        {
			return ApplicationException.CreateApplicationException(__Id);
        }
        
        [WebMethod]
        public void Delete(System.Int32 __Id)
        {
			ApplicationException.DeleteApplicationException(__Id);
        }
        
        [WebMethod]
        public void UpdateObject(ApplicationException _ApplicationException)
        {
			_ApplicationException.Update();
        }
		
		[WebMethod]
        public void CreateObject(ApplicationException _ApplicationException)
        {
			_ApplicationException.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ApplicationException _ApplicationException)
        {
			_ApplicationException.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			ApplicationException.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			ApplicationException.Redo();
        }
		[WebMethod]
		public ApplicationExceptionCollection GetByApiKey(Services.Packages.ApiKey _ApiKey)
		{
			return ApplicationException.GetByApiKey( _ApiKey);
		}
		[WebMethod]
		public ApplicationExceptionCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
		{
			return ApplicationException.GetByApiKeyPaged( _ApiKey, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey)
		{
			return ApplicationException.GetByApiKeyCount( _ApiKey);
		}
		[WebMethod]
		public Services.Packages.ApiKey GetApiKey(ApplicationException _ApplicationException)
		{
			_ApplicationException.Reload();
			return _ApplicationException.ApiKey;
		}
		[WebMethod]
		public void SetApiKey(ApplicationException _ApplicationException, Services.Packages.ApiKey _ApiKey)
		{
			_ApplicationException.Reload();
			_ApplicationException.ApiKey = _ApiKey;
			_ApplicationException.Update();
		}
		[WebMethod]
		public ApplicationExceptionCollection GetByParentException(Services.Packages.Log.ApplicationException _ApplicationException)
		{
			return ApplicationException.GetByParentException( _ApplicationException);
		}
		[WebMethod]
		public ApplicationExceptionCollection GetByParentExceptionPaged(Services.Packages.Log.ApplicationException _ApplicationException, long PagingStart, long PagingCount)
		{
			return ApplicationException.GetByParentExceptionPaged( _ApplicationException, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByParentExceptionCount(Services.Packages.Log.ApplicationException _ApplicationException)
		{
			return ApplicationException.GetByParentExceptionCount( _ApplicationException);
		}
		[WebMethod]
		public Services.Packages.Log.ApplicationException GetParentException(ApplicationException _ApplicationException)
		{
			_ApplicationException.Reload();
			return _ApplicationException.ParentException;
		}
		[WebMethod]
		public void SetParentException(ApplicationException _ApplicationException, Services.Packages.Log.ApplicationException _ParentException)
		{
			_ApplicationException.Reload();
			_ApplicationException.ParentException = _ParentException;
			_ApplicationException.Update();
		}
		[WebMethod]
		public ApplicationExceptionCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ApplicationException.GetByOwner( _ModelUser);
		}
		[WebMethod]
		public ApplicationExceptionCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ApplicationException.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ApplicationException.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(ApplicationException _ApplicationException)
		{
			_ApplicationException.Reload();
			return _ApplicationException.Owner;
		}
		[WebMethod]
		public void SetOwner(ApplicationException _ApplicationException, Services.Packages.Security.ModelUser _Owner)
		{
			_ApplicationException.Reload();
			_ApplicationException.Owner = _Owner;
			_ApplicationException.Update();
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByName(System.String Message )
		{
			return ApplicationException.SearchByName(Message );
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNamePaged(System.String Message , long PagingStart, long PagingCount)
		{
			return ApplicationException.SearchByNamePaged(Message , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByNameCount(System.String Message )
		{
			return ApplicationException.SearchByNameCount(Message );
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameSolved(System.String Message, System.Boolean IsSolved )
		{
			return ApplicationException.SearchByNameSolved(Message, IsSolved );
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameSolvedPaged(System.String Message, System.Boolean IsSolved , long PagingStart, long PagingCount)
		{
			return ApplicationException.SearchByNameSolvedPaged(Message, IsSolved , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByNameSolvedCount(System.String Message, System.Boolean IsSolved )
		{
			return ApplicationException.SearchByNameSolvedCount(Message, IsSolved );
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameOnApiKey(System.String Message, Services.Packages.ApiKey _ApiKey)
		{
			return ApplicationException.SearchByNameOnApiKey(Message,  _ApiKey);
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameOnApiKeyPaged(System.String Message, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
		{
			return ApplicationException.SearchByNameOnApiKeyPaged(Message,  _ApiKey, PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByNameOnApiKeyCount(System.String Message, Services.Packages.ApiKey _ApiKey)
		{
			return ApplicationException.SearchByNameOnApiKeyCount(Message,  _ApiKey);
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameSolvedOnApiKey(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey)
		{
			return ApplicationException.SearchByNameSolvedOnApiKey(Message, IsSolved,  _ApiKey);
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameSolvedOnApiKeyPaged(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
		{
			return ApplicationException.SearchByNameSolvedOnApiKeyPaged(Message, IsSolved,  _ApiKey, PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByNameSolvedOnApiKeyCount(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey)
		{
			return ApplicationException.SearchByNameSolvedOnApiKeyCount(Message, IsSolved,  _ApiKey);
		}
		[WebMethod]
		public Services.Packages.Log.ApplicationExceptionCollection GetInnerExceptions(ApplicationException _ApplicationException)
		{
			_ApplicationException.Reload();
			return _ApplicationException.InnerExceptions;
		}
		[WebMethod]
		public void SetInnerExceptions(ApplicationException _ApplicationException, Services.Packages.Log.ApplicationExceptionCollection _InnerExceptions)
		{
			_ApplicationException.Reload();
			_ApplicationException.InnerExceptions = _InnerExceptions;
			_ApplicationException.Update();
		}
		[WebMethod]
		public Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection GetACLs(ApplicationException _ApplicationException)
		{
			_ApplicationException.Reload();
			return _ApplicationException.ACLs;
		}
		[WebMethod]
		public void SetACLs(ApplicationException _ApplicationException, Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection _ACLs)
		{
			_ApplicationException.Reload();
			_ApplicationException.ACLs = _ACLs;
			_ApplicationException.Update();
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.Log.ApplicationException model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("d411c196-14f7-c02b-4606-5e0dd8b836a5")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class ApplicationException : IApplicationException, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<IApplicationExceptionService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<IApplicationExceptionService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<IApplicationExceptionService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Log.ApplicationException"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Log.ApplicationException"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.Log.ApplicationException.ProviderType");
				
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

		System.String _Message;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String Message
		{
            get
            {
                return _Message;
            }
            set
            {
                _Message = value;
            }
		}

		System.String _Source;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String Source
		{
            get
            {
                return _Source;
            }
            set
            {
                _Source = value;
            }
		}

		System.String _StackTrace;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String StackTrace
		{
            get
            {
                return _StackTrace;
            }
            set
            {
                _StackTrace = value;
            }
		}

		System.String _Page;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String Page
		{
            get
            {
                return _Page;
            }
            set
            {
                _Page = value;
            }
		}

		System.DateTime _OnDate;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.DateTime OnDate
		{
            get
            {
                return _OnDate;
            }
            set
            {
                _OnDate = value;
            }
		}

		System.Boolean _IsSolved;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Boolean IsSolved
		{
            get
            {
                return _IsSolved;
            }
            set
            {
                _IsSolved = value;
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
		
		public static Services.Packages.ApiKey GetApiKey(ApplicationException _ApplicationException)
		{
			return _ApplicationException.ApiKey;
		}

		bool _ParentExceptionIsLoaded = false;
		Services.Packages.Log.ApplicationException _ParentException;
		System.Int32 _ParentException_Id; 
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Log.ApplicationException ParentException
		{
            get
            {
				if (!_ParentExceptionIsLoaded)
				{
					_ParentException = new Services.Packages.Log.ApplicationException(_ParentException_Id);
					if (_ParentException.Exists)
						_ParentExceptionIsLoaded = true;
					else _ParentException = null;
				}
                return _ParentException;
            }
            set
            {
                _ParentException = value;
                _ParentExceptionIsLoaded = true;
                if (_ParentException != null)
                {
					if (_ParentException.Exists)
					{
						_ParentException_Id = _ParentException.Id;
						
					}
					else
					{
						_ParentException = null;
					}
				}
            }
		}
		
		public static Services.Packages.Log.ApplicationException GetParentException(ApplicationException _ApplicationException)
		{
			return _ApplicationException.ParentException;
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
		
		public static Services.Packages.Security.ModelUser GetOwner(ApplicationException _ApplicationException)
		{
			return _ApplicationException.Owner;
		}

		public static ApplicationExceptionCollection GetByApiKey(Services.Packages.ApiKey _ApiKey)
        {
			ApplicationExceptionCollection _ApplicationExceptionCollection = new ApplicationExceptionCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExGetByApKe", dbconn);
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
					ApplicationException o = new ApplicationException();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._Message = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Message"], typeof(System.String));
				o._Source = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Source"], typeof(System.String));
				o._StackTrace = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["StackTrace"], typeof(System.String));
				o._Page = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Page"], typeof(System.String));
				o._OnDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["OnDate"], typeof(System.DateTime));
				o._IsSolved = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsSolved"], typeof(System.Boolean));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ParentExceptionIsLoaded = false; if (dr["ParentException_Id"] == DBNull.Value) { o._ParentException = null; o._ParentExceptionIsLoaded = true; }  else o._ParentException_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ParentException_Id"], typeof(System.Int32));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApplicationExceptionCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ApplicationExceptionCollection;
        }
        
        public static ApplicationExceptionCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
        {
			ApplicationExceptionCollection _ApplicationExceptionCollection = new ApplicationExceptionCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExGetByApKePaged", dbconn);
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
					ApplicationException o = new ApplicationException();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._Message = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Message"], typeof(System.String));
				o._Source = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Source"], typeof(System.String));
				o._StackTrace = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["StackTrace"], typeof(System.String));
				o._Page = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Page"], typeof(System.String));
				o._OnDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["OnDate"], typeof(System.DateTime));
				o._IsSolved = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsSolved"], typeof(System.Boolean));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ParentExceptionIsLoaded = false; if (dr["ParentException_Id"] == DBNull.Value) { o._ParentException = null; o._ParentExceptionIsLoaded = true; }  else o._ParentException_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ParentException_Id"], typeof(System.Int32));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApplicationExceptionCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ApplicationExceptionCollection;
        }
        
        public static long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExGetByApKeCount", dbconn);
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

		public static ApplicationExceptionCollection GetByParentException(Services.Packages.Log.ApplicationException _ApplicationException)
        {
			ApplicationExceptionCollection _ApplicationExceptionCollection = new ApplicationExceptionCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExGetByPaEx", dbconn);
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
					ApplicationException o = new ApplicationException();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._Message = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Message"], typeof(System.String));
				o._Source = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Source"], typeof(System.String));
				o._StackTrace = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["StackTrace"], typeof(System.String));
				o._Page = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Page"], typeof(System.String));
				o._OnDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["OnDate"], typeof(System.DateTime));
				o._IsSolved = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsSolved"], typeof(System.Boolean));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ParentExceptionIsLoaded = false; if (dr["ParentException_Id"] == DBNull.Value) { o._ParentException = null; o._ParentExceptionIsLoaded = true; }  else o._ParentException_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ParentException_Id"], typeof(System.Int32));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApplicationExceptionCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ApplicationExceptionCollection;
        }
        
        public static ApplicationExceptionCollection GetByParentExceptionPaged(Services.Packages.Log.ApplicationException _ApplicationException, long PagingStart, long PagingCount)
        {
			ApplicationExceptionCollection _ApplicationExceptionCollection = new ApplicationExceptionCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExGetByPaExPaged", dbconn);
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
					ApplicationException o = new ApplicationException();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._Message = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Message"], typeof(System.String));
				o._Source = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Source"], typeof(System.String));
				o._StackTrace = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["StackTrace"], typeof(System.String));
				o._Page = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Page"], typeof(System.String));
				o._OnDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["OnDate"], typeof(System.DateTime));
				o._IsSolved = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsSolved"], typeof(System.Boolean));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ParentExceptionIsLoaded = false; if (dr["ParentException_Id"] == DBNull.Value) { o._ParentException = null; o._ParentExceptionIsLoaded = true; }  else o._ParentException_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ParentException_Id"], typeof(System.Int32));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApplicationExceptionCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ApplicationExceptionCollection;
        }
        
        public static long GetByParentExceptionCount(Services.Packages.Log.ApplicationException _ApplicationException)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExGetByPaExCount", dbconn);
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

		public static ApplicationExceptionCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
        {
			ApplicationExceptionCollection _ApplicationExceptionCollection = new ApplicationExceptionCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExGetByOw", dbconn);
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
					ApplicationException o = new ApplicationException();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._Message = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Message"], typeof(System.String));
				o._Source = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Source"], typeof(System.String));
				o._StackTrace = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["StackTrace"], typeof(System.String));
				o._Page = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Page"], typeof(System.String));
				o._OnDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["OnDate"], typeof(System.DateTime));
				o._IsSolved = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsSolved"], typeof(System.Boolean));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ParentExceptionIsLoaded = false; if (dr["ParentException_Id"] == DBNull.Value) { o._ParentException = null; o._ParentExceptionIsLoaded = true; }  else o._ParentException_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ParentException_Id"], typeof(System.Int32));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApplicationExceptionCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ApplicationExceptionCollection;
        }
        
        public static ApplicationExceptionCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			ApplicationExceptionCollection _ApplicationExceptionCollection = new ApplicationExceptionCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExGetByOwPaged", dbconn);
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
					ApplicationException o = new ApplicationException();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._Message = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Message"], typeof(System.String));
				o._Source = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Source"], typeof(System.String));
				o._StackTrace = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["StackTrace"], typeof(System.String));
				o._Page = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Page"], typeof(System.String));
				o._OnDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["OnDate"], typeof(System.DateTime));
				o._IsSolved = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsSolved"], typeof(System.Boolean));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ParentExceptionIsLoaded = false; if (dr["ParentException_Id"] == DBNull.Value) { o._ParentException = null; o._ParentExceptionIsLoaded = true; }  else o._ParentException_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ParentException_Id"], typeof(System.Int32));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApplicationExceptionCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ApplicationExceptionCollection;
        }
        
        public static long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExGetByOwCount", dbconn);
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

		public static ApplicationExceptionCollection SearchByName(System.String _Message)
        {
			ApplicationExceptionCollection _ApplicationExceptionCollection = new ApplicationExceptionCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExSeByNa", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Message = ClassConnectionProvider.Escape(_Message);
				
                
                DbParameter param_Message = ClassConnectionProvider.GetDatabaseParameter("Message", typeof(System.String), -1);
				param_Message.Value = ClassConnectionProvider.FromValueToSqlModelType(_Message);
				command.Parameters.Add(param_Message);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					ApplicationException o = new ApplicationException();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._Message = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Message"], typeof(System.String));
				o._Source = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Source"], typeof(System.String));
				o._StackTrace = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["StackTrace"], typeof(System.String));
				o._Page = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Page"], typeof(System.String));
				o._OnDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["OnDate"], typeof(System.DateTime));
				o._IsSolved = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsSolved"], typeof(System.Boolean));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ParentExceptionIsLoaded = false; if (dr["ParentException_Id"] == DBNull.Value) { o._ParentException = null; o._ParentExceptionIsLoaded = true; }  else o._ParentException_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ParentException_Id"], typeof(System.Int32));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApplicationExceptionCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ApplicationExceptionCollection;
        }
        
        public static ApplicationExceptionCollection SearchByNamePaged(System.String _Message, long PagingStart, long PagingCount)
        {
			ApplicationExceptionCollection _ApplicationExceptionCollection = new ApplicationExceptionCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExSeByNaPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Message = ClassConnectionProvider.Escape(_Message);
				
                
                DbParameter param_Message = ClassConnectionProvider.GetDatabaseParameter("Message", typeof(System.String), -1);
				param_Message.Value = ClassConnectionProvider.FromValueToSqlModelType(_Message);
				command.Parameters.Add(param_Message);
				
                
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
					ApplicationException o = new ApplicationException();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._Message = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Message"], typeof(System.String));
				o._Source = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Source"], typeof(System.String));
				o._StackTrace = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["StackTrace"], typeof(System.String));
				o._Page = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Page"], typeof(System.String));
				o._OnDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["OnDate"], typeof(System.DateTime));
				o._IsSolved = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsSolved"], typeof(System.Boolean));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ParentExceptionIsLoaded = false; if (dr["ParentException_Id"] == DBNull.Value) { o._ParentException = null; o._ParentExceptionIsLoaded = true; }  else o._ParentException_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ParentException_Id"], typeof(System.Int32));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApplicationExceptionCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ApplicationExceptionCollection;
        }
        
        public static long SearchByNameCount(System.String _Message)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExSeByNaCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Message = ClassConnectionProvider.Escape(_Message);
				
                
                DbParameter param_Message = ClassConnectionProvider.GetDatabaseParameter("Message", typeof(System.String), -1);
				param_Message.Value = ClassConnectionProvider.FromValueToSqlModelType(_Message);
				command.Parameters.Add(param_Message);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		public static ApplicationExceptionCollection SearchByNameSolved(System.String _Message, System.Boolean _IsSolved)
        {
			ApplicationExceptionCollection _ApplicationExceptionCollection = new ApplicationExceptionCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExSeByNaSo", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Message = ClassConnectionProvider.Escape(_Message);
				
                
                DbParameter param_Message = ClassConnectionProvider.GetDatabaseParameter("Message", typeof(System.String), -1);
				param_Message.Value = ClassConnectionProvider.FromValueToSqlModelType(_Message);
				command.Parameters.Add(param_Message);
				DbParameter param_IsSolved = ClassConnectionProvider.GetDatabaseParameter("IsSolved", typeof(System.Boolean), -1);
				param_IsSolved.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsSolved);
				command.Parameters.Add(param_IsSolved);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					ApplicationException o = new ApplicationException();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._Message = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Message"], typeof(System.String));
				o._Source = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Source"], typeof(System.String));
				o._StackTrace = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["StackTrace"], typeof(System.String));
				o._Page = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Page"], typeof(System.String));
				o._OnDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["OnDate"], typeof(System.DateTime));
				o._IsSolved = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsSolved"], typeof(System.Boolean));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ParentExceptionIsLoaded = false; if (dr["ParentException_Id"] == DBNull.Value) { o._ParentException = null; o._ParentExceptionIsLoaded = true; }  else o._ParentException_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ParentException_Id"], typeof(System.Int32));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApplicationExceptionCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ApplicationExceptionCollection;
        }
        
        public static ApplicationExceptionCollection SearchByNameSolvedPaged(System.String _Message, System.Boolean _IsSolved, long PagingStart, long PagingCount)
        {
			ApplicationExceptionCollection _ApplicationExceptionCollection = new ApplicationExceptionCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExSeByNaSoPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Message = ClassConnectionProvider.Escape(_Message);
				
                
                DbParameter param_Message = ClassConnectionProvider.GetDatabaseParameter("Message", typeof(System.String), -1);
				param_Message.Value = ClassConnectionProvider.FromValueToSqlModelType(_Message);
				command.Parameters.Add(param_Message);
				DbParameter param_IsSolved = ClassConnectionProvider.GetDatabaseParameter("IsSolved", typeof(System.Boolean), -1);
				param_IsSolved.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsSolved);
				command.Parameters.Add(param_IsSolved);
				
                
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
					ApplicationException o = new ApplicationException();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._Message = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Message"], typeof(System.String));
				o._Source = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Source"], typeof(System.String));
				o._StackTrace = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["StackTrace"], typeof(System.String));
				o._Page = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Page"], typeof(System.String));
				o._OnDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["OnDate"], typeof(System.DateTime));
				o._IsSolved = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsSolved"], typeof(System.Boolean));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ParentExceptionIsLoaded = false; if (dr["ParentException_Id"] == DBNull.Value) { o._ParentException = null; o._ParentExceptionIsLoaded = true; }  else o._ParentException_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ParentException_Id"], typeof(System.Int32));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApplicationExceptionCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ApplicationExceptionCollection;
        }
        
        public static long SearchByNameSolvedCount(System.String _Message, System.Boolean _IsSolved)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExSeByNaSoCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Message = ClassConnectionProvider.Escape(_Message);
				
                
                DbParameter param_Message = ClassConnectionProvider.GetDatabaseParameter("Message", typeof(System.String), -1);
				param_Message.Value = ClassConnectionProvider.FromValueToSqlModelType(_Message);
				command.Parameters.Add(param_Message);
				DbParameter param_IsSolved = ClassConnectionProvider.GetDatabaseParameter("IsSolved", typeof(System.Boolean), -1);
				param_IsSolved.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsSolved);
				command.Parameters.Add(param_IsSolved);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		public static ApplicationExceptionCollection SearchByNameOnApiKey(System.String _Message, Services.Packages.ApiKey _ApiKey)
        {
			ApplicationExceptionCollection _ApplicationExceptionCollection = new ApplicationExceptionCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExSeByNaOnApKe", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Message = ClassConnectionProvider.Escape(_Message);
				
                
                DbParameter param_Message = ClassConnectionProvider.GetDatabaseParameter("Message", typeof(System.String), -1);
				param_Message.Value = ClassConnectionProvider.FromValueToSqlModelType(_Message);
				command.Parameters.Add(param_Message);
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
					ApplicationException o = new ApplicationException();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._Message = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Message"], typeof(System.String));
				o._Source = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Source"], typeof(System.String));
				o._StackTrace = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["StackTrace"], typeof(System.String));
				o._Page = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Page"], typeof(System.String));
				o._OnDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["OnDate"], typeof(System.DateTime));
				o._IsSolved = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsSolved"], typeof(System.Boolean));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ParentExceptionIsLoaded = false; if (dr["ParentException_Id"] == DBNull.Value) { o._ParentException = null; o._ParentExceptionIsLoaded = true; }  else o._ParentException_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ParentException_Id"], typeof(System.Int32));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApplicationExceptionCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ApplicationExceptionCollection;
        }
        
        public static ApplicationExceptionCollection SearchByNameOnApiKeyPaged(System.String _Message, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
        {
			ApplicationExceptionCollection _ApplicationExceptionCollection = new ApplicationExceptionCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExSeByNaOnApKePaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Message = ClassConnectionProvider.Escape(_Message);
				
                
                DbParameter param_Message = ClassConnectionProvider.GetDatabaseParameter("Message", typeof(System.String), -1);
				param_Message.Value = ClassConnectionProvider.FromValueToSqlModelType(_Message);
				command.Parameters.Add(param_Message);
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
					ApplicationException o = new ApplicationException();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._Message = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Message"], typeof(System.String));
				o._Source = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Source"], typeof(System.String));
				o._StackTrace = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["StackTrace"], typeof(System.String));
				o._Page = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Page"], typeof(System.String));
				o._OnDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["OnDate"], typeof(System.DateTime));
				o._IsSolved = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsSolved"], typeof(System.Boolean));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ParentExceptionIsLoaded = false; if (dr["ParentException_Id"] == DBNull.Value) { o._ParentException = null; o._ParentExceptionIsLoaded = true; }  else o._ParentException_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ParentException_Id"], typeof(System.Int32));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApplicationExceptionCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ApplicationExceptionCollection;
        }
        
        public static long SearchByNameOnApiKeyCount(System.String _Message, Services.Packages.ApiKey _ApiKey)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExSeByNaOnApKeCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Message = ClassConnectionProvider.Escape(_Message);
				
                
                DbParameter param_Message = ClassConnectionProvider.GetDatabaseParameter("Message", typeof(System.String), -1);
				param_Message.Value = ClassConnectionProvider.FromValueToSqlModelType(_Message);
				command.Parameters.Add(param_Message);
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

		public static ApplicationExceptionCollection SearchByNameSolvedOnApiKey(System.String _Message, System.Boolean _IsSolved, Services.Packages.ApiKey _ApiKey)
        {
			ApplicationExceptionCollection _ApplicationExceptionCollection = new ApplicationExceptionCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExSeByNaSoOnApKe", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Message = ClassConnectionProvider.Escape(_Message);
				
                
                DbParameter param_Message = ClassConnectionProvider.GetDatabaseParameter("Message", typeof(System.String), -1);
				param_Message.Value = ClassConnectionProvider.FromValueToSqlModelType(_Message);
				command.Parameters.Add(param_Message);
				DbParameter param_IsSolved = ClassConnectionProvider.GetDatabaseParameter("IsSolved", typeof(System.Boolean), -1);
				param_IsSolved.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsSolved);
				command.Parameters.Add(param_IsSolved);
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
					ApplicationException o = new ApplicationException();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._Message = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Message"], typeof(System.String));
				o._Source = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Source"], typeof(System.String));
				o._StackTrace = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["StackTrace"], typeof(System.String));
				o._Page = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Page"], typeof(System.String));
				o._OnDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["OnDate"], typeof(System.DateTime));
				o._IsSolved = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsSolved"], typeof(System.Boolean));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ParentExceptionIsLoaded = false; if (dr["ParentException_Id"] == DBNull.Value) { o._ParentException = null; o._ParentExceptionIsLoaded = true; }  else o._ParentException_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ParentException_Id"], typeof(System.Int32));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApplicationExceptionCollection.Add(o);
                }

                dr.Close();
            }
            
            return _ApplicationExceptionCollection;
        }
        
        public static ApplicationExceptionCollection SearchByNameSolvedOnApiKeyPaged(System.String _Message, System.Boolean _IsSolved, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
        {
			ApplicationExceptionCollection _ApplicationExceptionCollection = new ApplicationExceptionCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExSeByNaSoOnApKePaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Message = ClassConnectionProvider.Escape(_Message);
				
                
                DbParameter param_Message = ClassConnectionProvider.GetDatabaseParameter("Message", typeof(System.String), -1);
				param_Message.Value = ClassConnectionProvider.FromValueToSqlModelType(_Message);
				command.Parameters.Add(param_Message);
				DbParameter param_IsSolved = ClassConnectionProvider.GetDatabaseParameter("IsSolved", typeof(System.Boolean), -1);
				param_IsSolved.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsSolved);
				command.Parameters.Add(param_IsSolved);
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
					ApplicationException o = new ApplicationException();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._Message = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Message"], typeof(System.String));
				o._Source = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Source"], typeof(System.String));
				o._StackTrace = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["StackTrace"], typeof(System.String));
				o._Page = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Page"], typeof(System.String));
				o._OnDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["OnDate"], typeof(System.DateTime));
				o._IsSolved = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsSolved"], typeof(System.Boolean));
				o._ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { o._ApiKey = null; o._ApiKeyIsLoaded = true; }  else o._ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				o._ParentExceptionIsLoaded = false; if (dr["ParentException_Id"] == DBNull.Value) { o._ParentException = null; o._ParentExceptionIsLoaded = true; }  else o._ParentException_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ParentException_Id"], typeof(System.Int32));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _ApplicationExceptionCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _ApplicationExceptionCollection;
        }
        
        public static long SearchByNameSolvedOnApiKeyCount(System.String _Message, System.Boolean _IsSolved, Services.Packages.ApiKey _ApiKey)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("ApExSeByNaSoOnApKeCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Message = ClassConnectionProvider.Escape(_Message);
				
                
                DbParameter param_Message = ClassConnectionProvider.GetDatabaseParameter("Message", typeof(System.String), -1);
				param_Message.Value = ClassConnectionProvider.FromValueToSqlModelType(_Message);
				command.Parameters.Add(param_Message);
				DbParameter param_IsSolved = ClassConnectionProvider.GetDatabaseParameter("IsSolved", typeof(System.Boolean), -1);
				param_IsSolved.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsSolved);
				command.Parameters.Add(param_IsSolved);
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

		Services.Packages.Log.ApplicationExceptionCollection _InnerExceptions;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Log.ApplicationExceptionCollection InnerExceptions
		{
            get
            {
				if (_InnerExceptions == null)
					_InnerExceptions = Services.Packages.Log.ApplicationException.GetByParentException(this);
				
				return _InnerExceptions;
            }
            set
            {
				if (this.Exists)
				{
					if (_InnerExceptions != null)
					{
						for(int n = 0; n < _InnerExceptions.Count; ++n)
						{
							_InnerExceptions[n].ParentException = null;
							_InnerExceptions[n].Update();
						}
					}
	                
					_InnerExceptions = value;
					
					if (_InnerExceptions != null)
					{
						for(int n = 0; n < _InnerExceptions.Count; ++n)
						{
							_InnerExceptions[n].ParentException = this;
							_InnerExceptions[n].Create();
						}
					}
				}
				else
				{
					_InnerExceptions = value;
				}
            }
		}
		
		public void ReloadInnerExceptions()
		{
			_InnerExceptions = Services.Packages.Log.ApplicationException.GetByParentException(this);
		}

		Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection _ACLs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection ACLs
		{
            get
            {
				if (_ACLs == null)
					_ACLs = Services.Packages.Log.Security.ApplicationExceptionAccessControlList.GetByApplicationException(this);
				
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
							_ACLs[n].ApplicationException = null;
							_ACLs[n].Update();
						}
					}
	                
					_ACLs = value;
					
					if (_ACLs != null)
					{
						for(int n = 0; n < _ACLs.Count; ++n)
						{
							_ACLs[n].ApplicationException = this;
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
			_ACLs = Services.Packages.Log.Security.ApplicationExceptionAccessControlList.GetByApplicationException(this);
		}

		public Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection GetACLs(System.String UserName)
		{
			return Services.Packages.Log.Security.ApplicationExceptionAccessControlList.GetACLs(UserName,  this);
		}

		public bool Exists
        {
            get {
				if (!__hasBeenReadOnce)
					Exist();
				
				return __databaseState == RowState.Initialized;
			}
        }
        
        public ApplicationException() {}
        
        public ApplicationException(System.Int32 __Id)
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
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApExRead", dbconn);
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
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "ApEx");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApExRead", dbconn);
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
				_Message = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Message"], typeof(System.String));
				_Source = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Source"], typeof(System.String));
				_StackTrace = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["StackTrace"], typeof(System.String));
				_Page = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Page"], typeof(System.String));
				_OnDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["OnDate"], typeof(System.DateTime));
				_IsSolved = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsSolved"], typeof(System.Boolean));
				_ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { _ApiKey = null; _ApiKeyIsLoaded = true; }  else _ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				_ParentExceptionIsLoaded = false; if (dr["ParentException_Id"] == DBNull.Value) { _ParentException = null; _ParentExceptionIsLoaded = true; }  else _ParentException_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ParentException_Id"], typeof(System.Int32));
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "ApEx");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApExRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_Message = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Message"], typeof(System.String));
				_Source = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Source"], typeof(System.String));
				_StackTrace = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["StackTrace"], typeof(System.String));
				_Page = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Page"], typeof(System.String));
				_OnDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["OnDate"], typeof(System.DateTime));
				_IsSolved = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsSolved"], typeof(System.Boolean));
				_ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { _ApiKey = null; _ApiKeyIsLoaded = true; }  else _ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				_ParentExceptionIsLoaded = false; if (dr["ParentException_Id"] == DBNull.Value) { _ParentException = null; _ParentExceptionIsLoaded = true; }  else _ParentException_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ParentException_Id"], typeof(System.Int32));
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApExCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_Message = ClassConnectionProvider.GetDatabaseParameter("Message", typeof(System.String), 512);
				param_Message.Value = ClassConnectionProvider.FromValueToSqlModelType(_Message);
				command.Parameters.Add(param_Message);
				DbParameter param_Source = ClassConnectionProvider.GetDatabaseParameter("Source", typeof(System.String), 512);
				param_Source.Value = ClassConnectionProvider.FromValueToSqlModelType(_Source);
				command.Parameters.Add(param_Source);
				DbParameter param_StackTrace = ClassConnectionProvider.GetDatabaseParameter("StackTrace", typeof(System.String), -1);
				param_StackTrace.Value = ClassConnectionProvider.FromValueToSqlModelType(_StackTrace);
				command.Parameters.Add(param_StackTrace);
				DbParameter param_Page = ClassConnectionProvider.GetDatabaseParameter("Page", typeof(System.String), -1);
				param_Page.Value = ClassConnectionProvider.FromValueToSqlModelType(_Page);
				command.Parameters.Add(param_Page);
				DbParameter param_OnDate = ClassConnectionProvider.GetDatabaseParameter("OnDate", typeof(System.DateTime), -1);
				param_OnDate.Value = ClassConnectionProvider.FromValueToSqlModelType(_OnDate);
				command.Parameters.Add(param_OnDate);
				DbParameter param_IsSolved = ClassConnectionProvider.GetDatabaseParameter("IsSolved", typeof(System.Boolean), -1);
				param_IsSolved.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsSolved);
				command.Parameters.Add(param_IsSolved);
				DbParameter param_ApiKey_Id = ClassConnectionProvider.GetDatabaseParameter("ApiKey_Id", typeof(System.Guid), -1);
				param_ApiKey_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey_Id);
				if (_ApiKey == null) param_ApiKey_Id.Value = DBNull.Value;
				else param_ApiKey_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey.Id);
				command.Parameters.Add(param_ApiKey_Id);
				DbParameter param_ParentException_Id = ClassConnectionProvider.GetDatabaseParameter("ParentException_Id", typeof(System.Int32), -1);
				param_ParentException_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ParentException_Id);
				if (_ParentException == null) param_ParentException_Id.Value = DBNull.Value;
				else param_ParentException_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ParentException.Id);
				command.Parameters.Add(param_ParentException_Id);
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
				_Message = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Message"], typeof(System.String));
				_Source = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Source"], typeof(System.String));
				_StackTrace = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["StackTrace"], typeof(System.String));
				_Page = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Page"], typeof(System.String));
				_OnDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["OnDate"], typeof(System.DateTime));
				_IsSolved = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsSolved"], typeof(System.Boolean));
				_ApiKeyIsLoaded = false; if (dr["ApiKey_Id"] == DBNull.Value) { _ApiKey = null; _ApiKeyIsLoaded = true; }  else _ApiKey_Id = (System.Guid) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ApiKey_Id"], typeof(System.Guid));
				_ParentExceptionIsLoaded = false; if (dr["ParentException_Id"] == DBNull.Value) { _ParentException = null; _ParentExceptionIsLoaded = true; }  else _ParentException_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ParentException_Id"], typeof(System.Int32));
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
        
        static public ApplicationException CreateApplicationException(System.Int32 __Id)
        {
            ApplicationException o = new ApplicationException(__Id);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApExUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				DbParameter param_Message = ClassConnectionProvider.GetDatabaseParameter("Message", typeof(System.String), 512);
				param_Message.Value = ClassConnectionProvider.FromValueToSqlModelType(_Message);
				command.Parameters.Add(param_Message);
				DbParameter param_Source = ClassConnectionProvider.GetDatabaseParameter("Source", typeof(System.String), 512);
				param_Source.Value = ClassConnectionProvider.FromValueToSqlModelType(_Source);
				command.Parameters.Add(param_Source);
				DbParameter param_StackTrace = ClassConnectionProvider.GetDatabaseParameter("StackTrace", typeof(System.String), -1);
				param_StackTrace.Value = ClassConnectionProvider.FromValueToSqlModelType(_StackTrace);
				command.Parameters.Add(param_StackTrace);
				DbParameter param_Page = ClassConnectionProvider.GetDatabaseParameter("Page", typeof(System.String), -1);
				param_Page.Value = ClassConnectionProvider.FromValueToSqlModelType(_Page);
				command.Parameters.Add(param_Page);
				DbParameter param_OnDate = ClassConnectionProvider.GetDatabaseParameter("OnDate", typeof(System.DateTime), -1);
				param_OnDate.Value = ClassConnectionProvider.FromValueToSqlModelType(_OnDate);
				command.Parameters.Add(param_OnDate);
				DbParameter param_IsSolved = ClassConnectionProvider.GetDatabaseParameter("IsSolved", typeof(System.Boolean), -1);
				param_IsSolved.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsSolved);
				command.Parameters.Add(param_IsSolved);
				DbParameter param_ApiKeyHasChanged = ClassConnectionProvider.GetDatabaseParameter("ApiKeyHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_ApiKeyIsLoaded));
				command.Parameters.Add(param_ApiKeyHasChanged);
				DbParameter param_ApiKey_Id = ClassConnectionProvider.GetDatabaseParameter("ApiKey_Id", typeof(System.Guid), -1);
				param_ApiKey_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey_Id);
				if (_ApiKey == null) param_ApiKey_Id.Value = DBNull.Value;
				else param_ApiKey_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ApiKey.Id);
				command.Parameters.Add(param_ApiKey_Id);
				DbParameter param_ParentExceptionHasChanged = ClassConnectionProvider.GetDatabaseParameter("ParentExceptionHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_ParentExceptionIsLoaded));
				command.Parameters.Add(param_ParentExceptionHasChanged);
				DbParameter param_ParentException_Id = ClassConnectionProvider.GetDatabaseParameter("ParentException_Id", typeof(System.Int32), -1);
				param_ParentException_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ParentException_Id);
				if (_ParentException == null) param_ParentException_Id.Value = DBNull.Value;
				else param_ParentException_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_ParentException.Id);
				command.Parameters.Add(param_ParentException_Id);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("ApExDelete", dbconn);
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
        
        static public void DeleteApplicationException(System.Int32 __Id)
        {
            ApplicationException o = new ApplicationException(__Id);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(ApplicationException _object)
        {
			_ApiKey = null;
			_ApiKeyIsLoaded = false;
			_ParentException = null;
			_ParentExceptionIsLoaded = false;
			_Owner = null;
			_OwnerIsLoaded = false;
			_Id = _object._Id;
			_Message = _object._Message;
			_Source = _object._Source;
			_StackTrace = _object._StackTrace;
			_Page = _object._Page;
			_OnDate = _object._OnDate;
			_IsSolved = _object._IsSolved;
			
        }
        
        public void CopyWithKeysTo(ApplicationException _object)
        {
			_object._ApiKey = null;
			_object._ApiKeyIsLoaded = false;
			_object._ParentException = null;
			_object._ParentExceptionIsLoaded = false;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Id = _Id;
			_object._Message = _Message;
			_object._Source = _Source;
			_object._StackTrace = _StackTrace;
			_object._Page = _Page;
			_object._OnDate = _OnDate;
			_object._IsSolved = _IsSolved;
			
        }
        
        static public void CopyWithKeysObject(ApplicationException _objectFrom, ApplicationException _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(ApplicationException _object)
        {
			_ApiKey = null;
			_ApiKeyIsLoaded = false;
			_ParentException = null;
			_ParentExceptionIsLoaded = false;
			_Owner = null;
			_OwnerIsLoaded = false;
			_Message = _object._Message;
			_Source = _object._Source;
			_StackTrace = _object._StackTrace;
			_Page = _object._Page;
			_OnDate = _object._OnDate;
			_IsSolved = _object._IsSolved;
			
        }
        
        public void CopyTo(ApplicationException _object)
        {
			_object._ApiKey = null;
			_object._ApiKeyIsLoaded = false;
			_object._ParentException = null;
			_object._ParentExceptionIsLoaded = false;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Message = _Message;
			_object._Source = _Source;
			_object._StackTrace = _StackTrace;
			_object._Page = _Page;
			_object._OnDate = _OnDate;
			_object._IsSolved = _IsSolved;
			
        }
        
        static public void CopyObject(ApplicationException _objectFrom, ApplicationException _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(ApplicationException).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(ApplicationException).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(ApplicationException _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			ApplicationExceptionUndoRedoCollection allUndidAndNotRedoneEntries = ApplicationExceptionUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			ApplicationExceptionUndoRedo _urobject = new ApplicationExceptionUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.ApiKey_Id = _object._ApiKey_Id;
			_urobject.ParentException_Id = _object._ParentException_Id;
			_urobject.Owner_Name = _object._Owner_Name;
			_urobject.Id = _object._Id;
			_urobject.Message = _object._Message;
			_urobject.Source = _object._Source;
			_urobject.StackTrace = _object._StackTrace;
			_urobject.Page = _object._Page;
			_urobject.OnDate = _object._OnDate;
			_urobject.IsSolved = _object._IsSolved;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(ApplicationException).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = ApplicationExceptionUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				ApplicationExceptionUndoRedoCollection allOldUndoEntries = ApplicationExceptionUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			ApplicationExceptionUndoRedoCollection firstUndoEntries = ApplicationExceptionUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			ApplicationExceptionUndoRedo _urobject = firstUndoEntries[0];
			
			ApplicationException _object = new ApplicationException();
			_object._ApiKey = null;
			_object._ApiKeyIsLoaded = false;
			_object._ApiKey_Id = _urobject.ApiKey_Id;
			_object._ParentException = null;
			_object._ParentExceptionIsLoaded = false;
			_object._ParentException_Id = _urobject.ParentException_Id;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Owner_Name = _urobject.Owner_Name;
			_object._Id = _urobject.Id;
			_object._Message = _urobject.Message;
			_object._Source = _urobject.Source;
			_object._StackTrace = _urobject.StackTrace;
			_object._Page = _urobject.Page;
			_object._OnDate = _urobject.OnDate;
			_object._IsSolved = _urobject.IsSolved;
			

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
			ApplicationExceptionUndoRedoCollection firstEntryToRedoEntries = ApplicationExceptionUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			ApplicationExceptionUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			ApplicationException _object = new ApplicationException();
			_object._ApiKey = null;
			_object._ApiKeyIsLoaded = false;
			_object._ApiKey_Id = _urobject.ApiKey_Id;
			_object._ParentException = null;
			_object._ParentExceptionIsLoaded = false;
			_object._ParentException_Id = _urobject.ParentException_Id;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Owner_Name = _urobject.Owner_Name;
			_object._Id = _urobject.Id;
			_object._Message = _urobject.Message;
			_object._Source = _urobject.Source;
			_object._StackTrace = _urobject.StackTrace;
			_object._Page = _urobject.Page;
			_object._OnDate = _urobject.OnDate;
			_object._IsSolved = _urobject.IsSolved;
			

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
    /// Defines the contract for the ApplicationExceptionCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("83dc124e-cdc6-2dfb-6ef7-c2098b4e0d9e")]
    public interface IApplicationExceptionCollection : IEnumerable<ApplicationException>
    {
        int IndexOf(ApplicationException item);
        void Insert(int index, ApplicationException item);
        void RemoveAt(int index);
        ApplicationException this[int index] { get; set; }
        void Add(ApplicationException item);
        void Clear();
        bool Contains(ApplicationException item);
        void CopyTo(ApplicationException[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(ApplicationException item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.Log.ApplicationException
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("e9a8c56c-bbf2-ab0e-c51f-f02b6e6a4ca1")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class ApplicationExceptionCollection : IApplicationExceptionCollection, IList<ApplicationException>, IHierarchicalEnumerable
    {
        List<ApplicationException> _list = new List<ApplicationException>();
        
        public static implicit operator List<ApplicationException>(ApplicationExceptionCollection collection)
        {
            return collection._list;
        }

        #region IList<ApplicationException> Members

        public int IndexOf(ApplicationException item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, ApplicationException item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public ApplicationException this[int index]
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

        #region ICollection<ApplicationException> Members

        public void Add(ApplicationException item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(ApplicationException item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(ApplicationException[] array, int arrayIndex)
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

        public bool Remove(ApplicationException item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<ApplicationException> Members

        public IEnumerator<ApplicationException> GetEnumerator()
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
	/// that share Services.Packages.Log.ApplicationException objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Log.Web.ApplicationExceptionWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class ApplicationExceptionWebService : WebService, IApplicationExceptionService
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
        public bool Exists(ApplicationException _ApplicationException)
        {
			return _ApplicationException.Exists;
        }
		
		[WebMethod]
		public ApplicationException Read(System.Int32 __Id)
		{
			return new ApplicationException(__Id);
		}
		
		[WebMethod]
        public ApplicationException Reload(ApplicationException _ApplicationException)
        {
			_ApplicationException.Reload();
			return _ApplicationException;
        }
		
		[WebMethod]
        public ApplicationException Create(System.Int32 __Id)
        {
			return ApplicationException.CreateApplicationException(__Id);
        }
        
        [WebMethod]
        public void Delete(System.Int32 __Id)
        {
			ApplicationException.DeleteApplicationException(__Id);
        }
        
        [WebMethod]
        public void UpdateObject(ApplicationException _ApplicationException)
        {
			_ApplicationException.Update();
        }
		
		[WebMethod]
        public void CreateObject(ApplicationException _ApplicationException)
        {
			_ApplicationException.Create();
        }
        
        [WebMethod]
        public void DeleteObject(ApplicationException _ApplicationException)
        {
			_ApplicationException.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			ApplicationException.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			ApplicationException.Redo();
        }
		[WebMethod]
		public ApplicationExceptionCollection GetByApiKey(Services.Packages.ApiKey _ApiKey)
		{
			return ApplicationException.GetByApiKey( _ApiKey);
		}
		[WebMethod]
		public ApplicationExceptionCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
		{
			return ApplicationException.GetByApiKeyPaged( _ApiKey, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey)
		{
			return ApplicationException.GetByApiKeyCount( _ApiKey);
		}
		[WebMethod]
		public Services.Packages.ApiKey GetApiKey(ApplicationException _ApplicationException)
		{
			_ApplicationException.Reload();
			return _ApplicationException.ApiKey;
		}
		[WebMethod]
		public void SetApiKey(ApplicationException _ApplicationException, Services.Packages.ApiKey _ApiKey)
		{
			_ApplicationException.Reload();
			_ApplicationException.ApiKey = _ApiKey;
			_ApplicationException.Update();
		}
		[WebMethod]
		public ApplicationExceptionCollection GetByParentException(Services.Packages.Log.ApplicationException _ApplicationException)
		{
			return ApplicationException.GetByParentException( _ApplicationException);
		}
		[WebMethod]
		public ApplicationExceptionCollection GetByParentExceptionPaged(Services.Packages.Log.ApplicationException _ApplicationException, long PagingStart, long PagingCount)
		{
			return ApplicationException.GetByParentExceptionPaged( _ApplicationException, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByParentExceptionCount(Services.Packages.Log.ApplicationException _ApplicationException)
		{
			return ApplicationException.GetByParentExceptionCount( _ApplicationException);
		}
		[WebMethod]
		public Services.Packages.Log.ApplicationException GetParentException(ApplicationException _ApplicationException)
		{
			_ApplicationException.Reload();
			return _ApplicationException.ParentException;
		}
		[WebMethod]
		public void SetParentException(ApplicationException _ApplicationException, Services.Packages.Log.ApplicationException _ParentException)
		{
			_ApplicationException.Reload();
			_ApplicationException.ParentException = _ParentException;
			_ApplicationException.Update();
		}
		[WebMethod]
		public ApplicationExceptionCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ApplicationException.GetByOwner( _ModelUser);
		}
		[WebMethod]
		public ApplicationExceptionCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return ApplicationException.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return ApplicationException.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(ApplicationException _ApplicationException)
		{
			_ApplicationException.Reload();
			return _ApplicationException.Owner;
		}
		[WebMethod]
		public void SetOwner(ApplicationException _ApplicationException, Services.Packages.Security.ModelUser _Owner)
		{
			_ApplicationException.Reload();
			_ApplicationException.Owner = _Owner;
			_ApplicationException.Update();
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByName(System.String Message )
		{
			return ApplicationException.SearchByName(Message );
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNamePaged(System.String Message , long PagingStart, long PagingCount)
		{
			return ApplicationException.SearchByNamePaged(Message , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByNameCount(System.String Message )
		{
			return ApplicationException.SearchByNameCount(Message );
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameSolved(System.String Message, System.Boolean IsSolved )
		{
			return ApplicationException.SearchByNameSolved(Message, IsSolved );
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameSolvedPaged(System.String Message, System.Boolean IsSolved , long PagingStart, long PagingCount)
		{
			return ApplicationException.SearchByNameSolvedPaged(Message, IsSolved , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByNameSolvedCount(System.String Message, System.Boolean IsSolved )
		{
			return ApplicationException.SearchByNameSolvedCount(Message, IsSolved );
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameOnApiKey(System.String Message, Services.Packages.ApiKey _ApiKey)
		{
			return ApplicationException.SearchByNameOnApiKey(Message,  _ApiKey);
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameOnApiKeyPaged(System.String Message, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
		{
			return ApplicationException.SearchByNameOnApiKeyPaged(Message,  _ApiKey, PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByNameOnApiKeyCount(System.String Message, Services.Packages.ApiKey _ApiKey)
		{
			return ApplicationException.SearchByNameOnApiKeyCount(Message,  _ApiKey);
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameSolvedOnApiKey(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey)
		{
			return ApplicationException.SearchByNameSolvedOnApiKey(Message, IsSolved,  _ApiKey);
		}
		[WebMethod]
		public ApplicationExceptionCollection SearchByNameSolvedOnApiKeyPaged(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount)
		{
			return ApplicationException.SearchByNameSolvedOnApiKeyPaged(Message, IsSolved,  _ApiKey, PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByNameSolvedOnApiKeyCount(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey)
		{
			return ApplicationException.SearchByNameSolvedOnApiKeyCount(Message, IsSolved,  _ApiKey);
		}
		[WebMethod]
		public Services.Packages.Log.ApplicationExceptionCollection GetInnerExceptions(ApplicationException _ApplicationException)
		{
			_ApplicationException.Reload();
			return _ApplicationException.InnerExceptions;
		}
		[WebMethod]
		public void SetInnerExceptions(ApplicationException _ApplicationException, Services.Packages.Log.ApplicationExceptionCollection _InnerExceptions)
		{
			_ApplicationException.Reload();
			_ApplicationException.InnerExceptions = _InnerExceptions;
			_ApplicationException.Update();
		}
		[WebMethod]
		public Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection GetACLs(ApplicationException _ApplicationException)
		{
			_ApplicationException.Reload();
			return _ApplicationException.ACLs;
		}
		[WebMethod]
		public void SetACLs(ApplicationException _ApplicationException, Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection _ACLs)
		{
			_ApplicationException.Reload();
			_ApplicationException.ACLs = _ACLs;
			_ApplicationException.Update();
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="ApplicationExceptionWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("9db89a9f-3b4c-c94e-c6e3-6500522235f8")]
    sealed public class ApplicationExceptionWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IApplicationExceptionService
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
		public ApplicationExceptionWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public ApplicationExceptionWebServiceClient()
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
		public bool Exists(ApplicationException _ApplicationException)
        {
			object[] results = this.Invoke("Exists", new object[] {_ApplicationException});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationException Read(System.Int32 __Id)
		{
			object[] results = this.Invoke("Read", new object[] {__Id});
			return ((ApplicationException)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationException Reload(ApplicationException _ApplicationException)
        {
			object[] results = this.Invoke("Reload", new object[] {_ApplicationException});
			return ((ApplicationException)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationException Create(System.Int32 __Id)
        {
			object[] results = this.Invoke("Create", new object[] {__Id});
			return ((ApplicationException)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.Int32 __Id)
        {
			this.Invoke("Delete", new object[] {__Id});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(ApplicationException _ApplicationException)
        {
			this.Invoke("UpdateObject", new object[] {_ApplicationException});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(ApplicationException _ApplicationException)
        {
			this.Invoke("CreateObject", new object[] {_ApplicationException});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(ApplicationException _ApplicationException)
        {
			this.Invoke("DeleteObject", new object[] {_ApplicationException});
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
		public ApplicationExceptionCollection GetByApiKey(Services.Packages.ApiKey _ApiKey) {
			object[] results = this.Invoke("GetByApiKey", new object[] {_ApiKey});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByApiKeyPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection GetByApiKeyPaged(Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByApiKeyPaged", new object[] {_ApiKey,PagingStart,PagingCount});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByApiKeyCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByApiKeyCount(Services.Packages.ApiKey _ApiKey) {
			object[] results = this.Invoke("GetByApiKeyCount", new object[] {_ApiKey});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.ApiKey GetApiKey(ApplicationException _ApplicationException)
		{
			object[] results = this.Invoke("GetApiKey", new object[] {_ApplicationException});
			return ((Services.Packages.ApiKey)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetApiKey(ApplicationException _ApplicationException, Services.Packages.ApiKey _ApiKey)
		{
			this.Invoke("GetApiKey", new object[] {_ApplicationException});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByParentException", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection GetByParentException(Services.Packages.Log.ApplicationException _ApplicationException) {
			object[] results = this.Invoke("GetByParentException", new object[] {_ApplicationException});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByParentExceptionPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection GetByParentExceptionPaged(Services.Packages.Log.ApplicationException _ApplicationException, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByParentExceptionPaged", new object[] {_ApplicationException,PagingStart,PagingCount});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByParentExceptionCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByParentExceptionCount(Services.Packages.Log.ApplicationException _ApplicationException) {
			object[] results = this.Invoke("GetByParentExceptionCount", new object[] {_ApplicationException});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetParentException", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Log.ApplicationException GetParentException(ApplicationException _ApplicationException)
		{
			object[] results = this.Invoke("GetParentException", new object[] {_ApplicationException});
			return ((Services.Packages.Log.ApplicationException)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetParentException", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetParentException(ApplicationException _ApplicationException, Services.Packages.Log.ApplicationException _ParentException)
		{
			this.Invoke("GetParentException", new object[] {_ApplicationException});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByOwner", new object[] {_ModelUser});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByOwnerPaged", new object[] {_ModelUser,PagingStart,PagingCount});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByOwnerCount", new object[] {_ModelUser});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetOwner(ApplicationException _ApplicationException)
		{
			object[] results = this.Invoke("GetOwner", new object[] {_ApplicationException});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetOwner(ApplicationException _ApplicationException, Services.Packages.Security.ModelUser _Owner)
		{
			this.Invoke("GetOwner", new object[] {_ApplicationException});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByName", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection SearchByName(System.String Message ) {
			object[] results = this.Invoke("SearchByName", new object[] {Message});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNamePaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection SearchByNamePaged(System.String Message , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("SearchByNamePaged", new object[] {Message,PagingStart,PagingCount});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByNameCount(System.String Message ) {
			object[] results = this.Invoke("SearchByNameCount", new object[] {Message});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameSolved", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection SearchByNameSolved(System.String Message, System.Boolean IsSolved ) {
			object[] results = this.Invoke("SearchByNameSolved", new object[] {Message, IsSolved});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameSolvedPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection SearchByNameSolvedPaged(System.String Message, System.Boolean IsSolved , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("SearchByNameSolvedPaged", new object[] {Message, IsSolved,PagingStart,PagingCount});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameSolvedCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByNameSolvedCount(System.String Message, System.Boolean IsSolved ) {
			object[] results = this.Invoke("SearchByNameSolvedCount", new object[] {Message, IsSolved});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameOnApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection SearchByNameOnApiKey(System.String Message, Services.Packages.ApiKey _ApiKey) {
			object[] results = this.Invoke("SearchByNameOnApiKey", new object[] {Message, _ApiKey});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameOnApiKeyPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection SearchByNameOnApiKeyPaged(System.String Message, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("SearchByNameOnApiKeyPaged", new object[] {Message, _ApiKey,PagingStart,PagingCount});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameOnApiKeyCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByNameOnApiKeyCount(System.String Message, Services.Packages.ApiKey _ApiKey) {
			object[] results = this.Invoke("SearchByNameOnApiKeyCount", new object[] {Message, _ApiKey});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameSolvedOnApiKey", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection SearchByNameSolvedOnApiKey(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey) {
			object[] results = this.Invoke("SearchByNameSolvedOnApiKey", new object[] {Message, IsSolved, _ApiKey});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameSolvedOnApiKeyPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public ApplicationExceptionCollection SearchByNameSolvedOnApiKeyPaged(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("SearchByNameSolvedOnApiKeyPaged", new object[] {Message, IsSolved, _ApiKey,PagingStart,PagingCount});
			return ((ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameSolvedOnApiKeyCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByNameSolvedOnApiKeyCount(System.String Message, System.Boolean IsSolved, Services.Packages.ApiKey _ApiKey) {
			object[] results = this.Invoke("SearchByNameSolvedOnApiKeyCount", new object[] {Message, IsSolved, _ApiKey});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetInnerExceptions", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Log.ApplicationExceptionCollection GetInnerExceptions(ApplicationException _ApplicationException)
		{
			object[] results = this.Invoke("GetInnerExceptions", new object[] {_ApplicationException});
			return ((Services.Packages.Log.ApplicationExceptionCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetInnerExceptions", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetInnerExceptions(ApplicationException _ApplicationException, Services.Packages.Log.ApplicationExceptionCollection _InnerExceptions)
		{
			this.Invoke("GetInnerExceptions", new object[] {_ApplicationException});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection GetACLs(ApplicationException _ApplicationException)
		{
			object[] results = this.Invoke("GetACLs", new object[] {_ApplicationException});
			return ((Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACLs(ApplicationException _ApplicationException, Services.Packages.Log.Security.ApplicationExceptionAccessControlListCollection _ACLs)
		{
			this.Invoke("GetACLs", new object[] {_ApplicationException});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages.Log
