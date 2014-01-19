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
    /// Defines the contract for the CustomerUndoRedo class
    /// </summary>
    [ComVisible(true)]
    [Guid("05243d2f-c67b-18c2-e838-9ca277f856c8")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface ICustomerUndoRedo
	{
		bool Exists { get; }
		System.Int64 UndoRedoId { get; set; }
		System.Boolean IsCreatedUndoDeletes { get; set; }
		System.Boolean IsDeletedUndoCreates { get; set; }
		System.Boolean IsUpdatedUndoUpdates { get; set; }
		System.Boolean IsUndone { get; set; }
		System.String Name { get; set; }
		System.String FullNameOfResponsible { get; set; }
		System.String EmailOfResponsible { get; set; }
		System.String Description { get; set; }
		System.Boolean IsPartner { get; set; }
		System.String CompanyName { get; set; }
		System.String VATNo { get; set; }
		System.String Phone { get; set; }
		System.String Address { get; set; }
		System.String PostCode { get; set; }
		System.String City { get; set; }
		System.String Country { get; set; }
		System.String InvoiceAddress { get; set; }
		System.String InvoicePostCode { get; set; }
		System.String InvoiceCity { get; set; }
		System.String InvoiceCountry { get; set; }
		System.Boolean IsPaymentAccepted { get; set; }
		System.DateTime LastPaymentDate { get; set; }
		System.String Partner_Name { get; set; }
		System.String Owner_Name { get; set; }

		void Read(System.Int64 __UndoRedoId);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(CustomerUndoRedo _object);
		void CopyWithKeysTo(CustomerUndoRedo _object);
		void CopyFrom(CustomerUndoRedo _object);
		void CopyTo(CustomerUndoRedo _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.CustomerUndoRedo type.
    /// </summary>
    [ComVisible(true)]
    [Guid("32333df3-ad83-48ef-40fc-9052576ee909")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface ICustomerUndoRedoService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(CustomerUndoRedo _CustomerUndoRedo);
		[OperationContract]
        CustomerUndoRedo Read(System.Int64 __UndoRedoId);
        [OperationContract]
        CustomerUndoRedo Reload(CustomerUndoRedo _CustomerUndoRedo);
        [OperationContract]
        CustomerUndoRedo Create(System.Int64 __UndoRedoId);
        [OperationContract]
        void Delete(System.Int64 __UndoRedoId);
        [OperationContract]
        void UpdateObject(CustomerUndoRedo _CustomerUndoRedo);
        [OperationContract]
        void CreateObject(CustomerUndoRedo _CustomerUndoRedo);
        [OperationContract]
        void DeleteObject(CustomerUndoRedo _CustomerUndoRedo);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		CustomerUndoRedoCollection GetAllFilterByIsUndone(System.Boolean IsUndone );
		[OperationContract]
		CustomerUndoRedoCollection GetAllFilterByIsUndonePaged(System.Boolean IsUndone , long PagingStart, long PagingCount);
		[OperationContract]
		long GetAllFilterByIsUndoneCount(System.Boolean IsUndone );
		[OperationContract]
		CustomerUndoRedoCollection GetAllFilterByIsUndoneOppositeOrder(System.Boolean IsUndone );
		[OperationContract]
		CustomerUndoRedoCollection GetAllFilterByIsUndoneOppositeOrderPaged(System.Boolean IsUndone , long PagingStart, long PagingCount);
		[OperationContract]
		long GetAllFilterByIsUndoneOppositeOrderCount(System.Boolean IsUndone );
		[OperationContract]
		CustomerUndoRedoCollection GetAllWithNoFilterOppositeSorting(System.Boolean dummy );
		[OperationContract]
		CustomerUndoRedoCollection GetAllWithNoFilterOppositeSortingPaged(System.Boolean dummy , long PagingStart, long PagingCount);
		[OperationContract]
		long GetAllWithNoFilterOppositeSortingCount(System.Boolean dummy );
		[OperationContract]
		CustomerUndoRedoCollection GetAllWithNoFilter(System.Boolean dummy );
		[OperationContract]
		CustomerUndoRedoCollection GetAllWithNoFilterPaged(System.Boolean dummy , long PagingStart, long PagingCount);
		[OperationContract]
		long GetAllWithNoFilterCount(System.Boolean dummy );

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.CustomerUndoRedo type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("8e30a910-ee07-38d7-9e42-8b1b7c7c0dbf")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class CustomerUndoRedoService : ICustomerUndoRedoService
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
        public bool Exists(CustomerUndoRedo _CustomerUndoRedo)
        {
			return _CustomerUndoRedo.Exists;
        }
		
		[WebMethod]
		public CustomerUndoRedo Read(System.Int64 __UndoRedoId)
		{
			return new CustomerUndoRedo(__UndoRedoId);
		}
		
		[WebMethod]
        public CustomerUndoRedo Reload(CustomerUndoRedo _CustomerUndoRedo)
        {
			_CustomerUndoRedo.Reload();
			return _CustomerUndoRedo;
        }
		
		[WebMethod]
        public CustomerUndoRedo Create(System.Int64 __UndoRedoId)
        {
			return CustomerUndoRedo.CreateCustomerUndoRedo(__UndoRedoId);
        }
        
        [WebMethod]
        public void Delete(System.Int64 __UndoRedoId)
        {
			CustomerUndoRedo.DeleteCustomerUndoRedo(__UndoRedoId);
        }
        
        [WebMethod]
        public void UpdateObject(CustomerUndoRedo _CustomerUndoRedo)
        {
			_CustomerUndoRedo.Update();
        }
		
		[WebMethod]
        public void CreateObject(CustomerUndoRedo _CustomerUndoRedo)
        {
			_CustomerUndoRedo.Create();
        }
        
        [WebMethod]
        public void DeleteObject(CustomerUndoRedo _CustomerUndoRedo)
        {
			_CustomerUndoRedo.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			CustomerUndoRedo.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			CustomerUndoRedo.Redo();
        }
		[WebMethod]
		public CustomerUndoRedoCollection GetAllFilterByIsUndone(System.Boolean IsUndone )
		{
			return CustomerUndoRedo.GetAllFilterByIsUndone(IsUndone );
		}
		[WebMethod]
		public CustomerUndoRedoCollection GetAllFilterByIsUndonePaged(System.Boolean IsUndone , long PagingStart, long PagingCount)
		{
			return CustomerUndoRedo.GetAllFilterByIsUndonePaged(IsUndone , PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetAllFilterByIsUndoneCount(System.Boolean IsUndone )
		{
			return CustomerUndoRedo.GetAllFilterByIsUndoneCount(IsUndone );
		}
		[WebMethod]
		public CustomerUndoRedoCollection GetAllFilterByIsUndoneOppositeOrder(System.Boolean IsUndone )
		{
			return CustomerUndoRedo.GetAllFilterByIsUndoneOppositeOrder(IsUndone );
		}
		[WebMethod]
		public CustomerUndoRedoCollection GetAllFilterByIsUndoneOppositeOrderPaged(System.Boolean IsUndone , long PagingStart, long PagingCount)
		{
			return CustomerUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(IsUndone , PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetAllFilterByIsUndoneOppositeOrderCount(System.Boolean IsUndone )
		{
			return CustomerUndoRedo.GetAllFilterByIsUndoneOppositeOrderCount(IsUndone );
		}
		[WebMethod]
		public CustomerUndoRedoCollection GetAllWithNoFilterOppositeSorting(System.Boolean dummy )
		{
			return CustomerUndoRedo.GetAllWithNoFilterOppositeSorting(dummy );
		}
		[WebMethod]
		public CustomerUndoRedoCollection GetAllWithNoFilterOppositeSortingPaged(System.Boolean dummy , long PagingStart, long PagingCount)
		{
			return CustomerUndoRedo.GetAllWithNoFilterOppositeSortingPaged(dummy , PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetAllWithNoFilterOppositeSortingCount(System.Boolean dummy )
		{
			return CustomerUndoRedo.GetAllWithNoFilterOppositeSortingCount(dummy );
		}
		[WebMethod]
		public CustomerUndoRedoCollection GetAllWithNoFilter(System.Boolean dummy )
		{
			return CustomerUndoRedo.GetAllWithNoFilter(dummy );
		}
		[WebMethod]
		public CustomerUndoRedoCollection GetAllWithNoFilterPaged(System.Boolean dummy , long PagingStart, long PagingCount)
		{
			return CustomerUndoRedo.GetAllWithNoFilterPaged(dummy , PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetAllWithNoFilterCount(System.Boolean dummy )
		{
			return CustomerUndoRedo.GetAllWithNoFilterCount(dummy );
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.CustomerUndoRedo model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("a636db8e-2664-82ae-4ddb-c57e3670c07a")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class CustomerUndoRedo : ICustomerUndoRedo, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<ICustomerUndoRedoService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<ICustomerUndoRedoService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<ICustomerUndoRedoService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.CustomerUndoRedo"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.CustomerUndoRedo"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.CustomerUndoRedo.ProviderType");
				
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


		System.Int64 _UndoRedoId;
		
		// Key member
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Int64 UndoRedoId
		{
            get
            {
                return _UndoRedoId;
            }
            set
            {
				if (_UndoRedoId != value)
					__hasBeenReadOnce = false;
                _UndoRedoId = value;
            }
		}

		System.Boolean _IsCreatedUndoDeletes;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Boolean IsCreatedUndoDeletes
		{
            get
            {
                return _IsCreatedUndoDeletes;
            }
            set
            {
                _IsCreatedUndoDeletes = value;
            }
		}

		System.Boolean _IsDeletedUndoCreates;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Boolean IsDeletedUndoCreates
		{
            get
            {
                return _IsDeletedUndoCreates;
            }
            set
            {
                _IsDeletedUndoCreates = value;
            }
		}

		System.Boolean _IsUpdatedUndoUpdates;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Boolean IsUpdatedUndoUpdates
		{
            get
            {
                return _IsUpdatedUndoUpdates;
            }
            set
            {
                _IsUpdatedUndoUpdates = value;
            }
		}

		System.Boolean _IsUndone;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Boolean IsUndone
		{
            get
            {
                return _IsUndone;
            }
            set
            {
                _IsUndone = value;
            }
		}

		System.String _Name;
		
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
                _Name = value;
            }
		}

		System.String _FullNameOfResponsible;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String FullNameOfResponsible
		{
            get
            {
                return _FullNameOfResponsible;
            }
            set
            {
                _FullNameOfResponsible = value;
            }
		}

		System.String _EmailOfResponsible;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String EmailOfResponsible
		{
            get
            {
                return _EmailOfResponsible;
            }
            set
            {
                _EmailOfResponsible = value;
            }
		}

		System.String _Description;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String Description
		{
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
            }
		}

		System.Boolean _IsPartner;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Boolean IsPartner
		{
            get
            {
                return _IsPartner;
            }
            set
            {
                _IsPartner = value;
            }
		}

		System.String _CompanyName;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String CompanyName
		{
            get
            {
                return _CompanyName;
            }
            set
            {
                _CompanyName = value;
            }
		}

		System.String _VATNo;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String VATNo
		{
            get
            {
                return _VATNo;
            }
            set
            {
                _VATNo = value;
            }
		}

		System.String _Phone;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String Phone
		{
            get
            {
                return _Phone;
            }
            set
            {
                _Phone = value;
            }
		}

		System.String _Address;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String Address
		{
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
            }
		}

		System.String _PostCode;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String PostCode
		{
            get
            {
                return _PostCode;
            }
            set
            {
                _PostCode = value;
            }
		}

		System.String _City;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String City
		{
            get
            {
                return _City;
            }
            set
            {
                _City = value;
            }
		}

		System.String _Country;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String Country
		{
            get
            {
                return _Country;
            }
            set
            {
                _Country = value;
            }
		}

		System.String _InvoiceAddress;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String InvoiceAddress
		{
            get
            {
                return _InvoiceAddress;
            }
            set
            {
                _InvoiceAddress = value;
            }
		}

		System.String _InvoicePostCode;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String InvoicePostCode
		{
            get
            {
                return _InvoicePostCode;
            }
            set
            {
                _InvoicePostCode = value;
            }
		}

		System.String _InvoiceCity;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String InvoiceCity
		{
            get
            {
                return _InvoiceCity;
            }
            set
            {
                _InvoiceCity = value;
            }
		}

		System.String _InvoiceCountry;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String InvoiceCountry
		{
            get
            {
                return _InvoiceCountry;
            }
            set
            {
                _InvoiceCountry = value;
            }
		}

		System.Boolean _IsPaymentAccepted;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Boolean IsPaymentAccepted
		{
            get
            {
                return _IsPaymentAccepted;
            }
            set
            {
                _IsPaymentAccepted = value;
            }
		}

		System.DateTime _LastPaymentDate;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.DateTime LastPaymentDate
		{
            get
            {
                return _LastPaymentDate;
            }
            set
            {
                _LastPaymentDate = value;
            }
		}

		System.String _Partner_Name;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String Partner_Name
		{
            get
            {
                return _Partner_Name;
            }
            set
            {
                _Partner_Name = value;
            }
		}

		System.String _Owner_Name;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String Owner_Name
		{
            get
            {
                return _Owner_Name;
            }
            set
            {
                _Owner_Name = value;
            }
		}

		public static CustomerUndoRedoCollection GetAllFilterByIsUndone(System.Boolean _IsUndone)
        {
			CustomerUndoRedoCollection _CustomerUndoRedoCollection = new CustomerUndoRedoCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUnReGeAlFiByIsUn", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                
                
                DbParameter param_IsUndone = ClassConnectionProvider.GetDatabaseParameter("IsUndone", typeof(System.Boolean), -1);
				param_IsUndone.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsUndone);
				command.Parameters.Add(param_IsUndone);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					CustomerUndoRedo o = new CustomerUndoRedo();
                
					o.__databaseState = RowState.Initialized;
                    o._UndoRedoId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoId"], typeof(System.Int64));
				o._IsCreatedUndoDeletes = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsCreatedUndoDeletes"], typeof(System.Boolean));
				o._IsDeletedUndoCreates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsDeletedUndoCreates"], typeof(System.Boolean));
				o._IsUpdatedUndoUpdates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUpdatedUndoUpdates"], typeof(System.Boolean));
				o._IsUndone = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUndone"], typeof(System.Boolean));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._FullNameOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FullNameOfResponsible"], typeof(System.String));
				o._EmailOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["EmailOfResponsible"], typeof(System.String));
				o._Description = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Description"], typeof(System.String));
				o._IsPartner = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPartner"], typeof(System.Boolean));
				o._CompanyName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyName"], typeof(System.String));
				o._VATNo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VATNo"], typeof(System.String));
				o._Phone = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Phone"], typeof(System.String));
				o._Address = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Address"], typeof(System.String));
				o._PostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PostCode"], typeof(System.String));
				o._City = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["City"], typeof(System.String));
				o._Country = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Country"], typeof(System.String));
				o._InvoiceAddress = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceAddress"], typeof(System.String));
				o._InvoicePostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoicePostCode"], typeof(System.String));
				o._InvoiceCity = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCity"], typeof(System.String));
				o._InvoiceCountry = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCountry"], typeof(System.String));
				o._IsPaymentAccepted = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaymentAccepted"], typeof(System.Boolean));
				o._LastPaymentDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["LastPaymentDate"], typeof(System.DateTime));
				o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerUndoRedoCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerUndoRedoCollection;
        }
        
        public static CustomerUndoRedoCollection GetAllFilterByIsUndonePaged(System.Boolean _IsUndone, long PagingStart, long PagingCount)
        {
			CustomerUndoRedoCollection _CustomerUndoRedoCollection = new CustomerUndoRedoCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUnReGeAlFiByIsUnPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                
                
                DbParameter param_IsUndone = ClassConnectionProvider.GetDatabaseParameter("IsUndone", typeof(System.Boolean), -1);
				param_IsUndone.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsUndone);
				command.Parameters.Add(param_IsUndone);
				
                
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
					CustomerUndoRedo o = new CustomerUndoRedo();
                
					o.__databaseState = RowState.Initialized;
                    o._UndoRedoId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoId"], typeof(System.Int64));
				o._IsCreatedUndoDeletes = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsCreatedUndoDeletes"], typeof(System.Boolean));
				o._IsDeletedUndoCreates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsDeletedUndoCreates"], typeof(System.Boolean));
				o._IsUpdatedUndoUpdates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUpdatedUndoUpdates"], typeof(System.Boolean));
				o._IsUndone = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUndone"], typeof(System.Boolean));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._FullNameOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FullNameOfResponsible"], typeof(System.String));
				o._EmailOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["EmailOfResponsible"], typeof(System.String));
				o._Description = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Description"], typeof(System.String));
				o._IsPartner = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPartner"], typeof(System.Boolean));
				o._CompanyName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyName"], typeof(System.String));
				o._VATNo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VATNo"], typeof(System.String));
				o._Phone = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Phone"], typeof(System.String));
				o._Address = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Address"], typeof(System.String));
				o._PostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PostCode"], typeof(System.String));
				o._City = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["City"], typeof(System.String));
				o._Country = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Country"], typeof(System.String));
				o._InvoiceAddress = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceAddress"], typeof(System.String));
				o._InvoicePostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoicePostCode"], typeof(System.String));
				o._InvoiceCity = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCity"], typeof(System.String));
				o._InvoiceCountry = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCountry"], typeof(System.String));
				o._IsPaymentAccepted = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaymentAccepted"], typeof(System.Boolean));
				o._LastPaymentDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["LastPaymentDate"], typeof(System.DateTime));
				o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerUndoRedoCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerUndoRedoCollection;
        }
        
        public static long GetAllFilterByIsUndoneCount(System.Boolean _IsUndone)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUnReGeAlFiByIsUnCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                
                
                DbParameter param_IsUndone = ClassConnectionProvider.GetDatabaseParameter("IsUndone", typeof(System.Boolean), -1);
				param_IsUndone.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsUndone);
				command.Parameters.Add(param_IsUndone);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		public static CustomerUndoRedoCollection GetAllFilterByIsUndoneOppositeOrder(System.Boolean _IsUndone)
        {
			CustomerUndoRedoCollection _CustomerUndoRedoCollection = new CustomerUndoRedoCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUnReGeAlFiByIsUnOpOr", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                
                
                DbParameter param_IsUndone = ClassConnectionProvider.GetDatabaseParameter("IsUndone", typeof(System.Boolean), -1);
				param_IsUndone.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsUndone);
				command.Parameters.Add(param_IsUndone);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					CustomerUndoRedo o = new CustomerUndoRedo();
                
					o.__databaseState = RowState.Initialized;
                    o._UndoRedoId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoId"], typeof(System.Int64));
				o._IsCreatedUndoDeletes = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsCreatedUndoDeletes"], typeof(System.Boolean));
				o._IsDeletedUndoCreates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsDeletedUndoCreates"], typeof(System.Boolean));
				o._IsUpdatedUndoUpdates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUpdatedUndoUpdates"], typeof(System.Boolean));
				o._IsUndone = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUndone"], typeof(System.Boolean));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._FullNameOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FullNameOfResponsible"], typeof(System.String));
				o._EmailOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["EmailOfResponsible"], typeof(System.String));
				o._Description = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Description"], typeof(System.String));
				o._IsPartner = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPartner"], typeof(System.Boolean));
				o._CompanyName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyName"], typeof(System.String));
				o._VATNo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VATNo"], typeof(System.String));
				o._Phone = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Phone"], typeof(System.String));
				o._Address = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Address"], typeof(System.String));
				o._PostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PostCode"], typeof(System.String));
				o._City = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["City"], typeof(System.String));
				o._Country = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Country"], typeof(System.String));
				o._InvoiceAddress = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceAddress"], typeof(System.String));
				o._InvoicePostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoicePostCode"], typeof(System.String));
				o._InvoiceCity = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCity"], typeof(System.String));
				o._InvoiceCountry = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCountry"], typeof(System.String));
				o._IsPaymentAccepted = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaymentAccepted"], typeof(System.Boolean));
				o._LastPaymentDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["LastPaymentDate"], typeof(System.DateTime));
				o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerUndoRedoCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerUndoRedoCollection;
        }
        
        public static CustomerUndoRedoCollection GetAllFilterByIsUndoneOppositeOrderPaged(System.Boolean _IsUndone, long PagingStart, long PagingCount)
        {
			CustomerUndoRedoCollection _CustomerUndoRedoCollection = new CustomerUndoRedoCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUnReGeAlFiByIsUnOpOrPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                
                
                DbParameter param_IsUndone = ClassConnectionProvider.GetDatabaseParameter("IsUndone", typeof(System.Boolean), -1);
				param_IsUndone.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsUndone);
				command.Parameters.Add(param_IsUndone);
				
                
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
					CustomerUndoRedo o = new CustomerUndoRedo();
                
					o.__databaseState = RowState.Initialized;
                    o._UndoRedoId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoId"], typeof(System.Int64));
				o._IsCreatedUndoDeletes = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsCreatedUndoDeletes"], typeof(System.Boolean));
				o._IsDeletedUndoCreates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsDeletedUndoCreates"], typeof(System.Boolean));
				o._IsUpdatedUndoUpdates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUpdatedUndoUpdates"], typeof(System.Boolean));
				o._IsUndone = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUndone"], typeof(System.Boolean));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._FullNameOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FullNameOfResponsible"], typeof(System.String));
				o._EmailOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["EmailOfResponsible"], typeof(System.String));
				o._Description = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Description"], typeof(System.String));
				o._IsPartner = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPartner"], typeof(System.Boolean));
				o._CompanyName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyName"], typeof(System.String));
				o._VATNo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VATNo"], typeof(System.String));
				o._Phone = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Phone"], typeof(System.String));
				o._Address = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Address"], typeof(System.String));
				o._PostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PostCode"], typeof(System.String));
				o._City = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["City"], typeof(System.String));
				o._Country = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Country"], typeof(System.String));
				o._InvoiceAddress = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceAddress"], typeof(System.String));
				o._InvoicePostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoicePostCode"], typeof(System.String));
				o._InvoiceCity = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCity"], typeof(System.String));
				o._InvoiceCountry = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCountry"], typeof(System.String));
				o._IsPaymentAccepted = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaymentAccepted"], typeof(System.Boolean));
				o._LastPaymentDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["LastPaymentDate"], typeof(System.DateTime));
				o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerUndoRedoCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerUndoRedoCollection;
        }
        
        public static long GetAllFilterByIsUndoneOppositeOrderCount(System.Boolean _IsUndone)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUnReGeAlFiByIsUnOpOrCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                
                
                DbParameter param_IsUndone = ClassConnectionProvider.GetDatabaseParameter("IsUndone", typeof(System.Boolean), -1);
				param_IsUndone.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsUndone);
				command.Parameters.Add(param_IsUndone);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		public static CustomerUndoRedoCollection GetAllWithNoFilterOppositeSorting(System.Boolean _dummy)
        {
			CustomerUndoRedoCollection _CustomerUndoRedoCollection = new CustomerUndoRedoCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUnReGeAlWiNoFiOpSo", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                
                
                DbParameter param_dummy = ClassConnectionProvider.GetDatabaseParameter("dummy", typeof(System.Boolean), -1);
				param_dummy.Value = ClassConnectionProvider.FromValueToSqlModelType(_dummy);
				command.Parameters.Add(param_dummy);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					CustomerUndoRedo o = new CustomerUndoRedo();
                
					o.__databaseState = RowState.Initialized;
                    o._UndoRedoId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoId"], typeof(System.Int64));
				o._IsCreatedUndoDeletes = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsCreatedUndoDeletes"], typeof(System.Boolean));
				o._IsDeletedUndoCreates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsDeletedUndoCreates"], typeof(System.Boolean));
				o._IsUpdatedUndoUpdates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUpdatedUndoUpdates"], typeof(System.Boolean));
				o._IsUndone = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUndone"], typeof(System.Boolean));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._FullNameOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FullNameOfResponsible"], typeof(System.String));
				o._EmailOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["EmailOfResponsible"], typeof(System.String));
				o._Description = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Description"], typeof(System.String));
				o._IsPartner = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPartner"], typeof(System.Boolean));
				o._CompanyName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyName"], typeof(System.String));
				o._VATNo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VATNo"], typeof(System.String));
				o._Phone = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Phone"], typeof(System.String));
				o._Address = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Address"], typeof(System.String));
				o._PostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PostCode"], typeof(System.String));
				o._City = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["City"], typeof(System.String));
				o._Country = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Country"], typeof(System.String));
				o._InvoiceAddress = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceAddress"], typeof(System.String));
				o._InvoicePostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoicePostCode"], typeof(System.String));
				o._InvoiceCity = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCity"], typeof(System.String));
				o._InvoiceCountry = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCountry"], typeof(System.String));
				o._IsPaymentAccepted = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaymentAccepted"], typeof(System.Boolean));
				o._LastPaymentDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["LastPaymentDate"], typeof(System.DateTime));
				o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerUndoRedoCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerUndoRedoCollection;
        }
        
        public static CustomerUndoRedoCollection GetAllWithNoFilterOppositeSortingPaged(System.Boolean _dummy, long PagingStart, long PagingCount)
        {
			CustomerUndoRedoCollection _CustomerUndoRedoCollection = new CustomerUndoRedoCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUnReGeAlWiNoFiOpSoPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                
                
                DbParameter param_dummy = ClassConnectionProvider.GetDatabaseParameter("dummy", typeof(System.Boolean), -1);
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
					CustomerUndoRedo o = new CustomerUndoRedo();
                
					o.__databaseState = RowState.Initialized;
                    o._UndoRedoId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoId"], typeof(System.Int64));
				o._IsCreatedUndoDeletes = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsCreatedUndoDeletes"], typeof(System.Boolean));
				o._IsDeletedUndoCreates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsDeletedUndoCreates"], typeof(System.Boolean));
				o._IsUpdatedUndoUpdates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUpdatedUndoUpdates"], typeof(System.Boolean));
				o._IsUndone = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUndone"], typeof(System.Boolean));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._FullNameOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FullNameOfResponsible"], typeof(System.String));
				o._EmailOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["EmailOfResponsible"], typeof(System.String));
				o._Description = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Description"], typeof(System.String));
				o._IsPartner = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPartner"], typeof(System.Boolean));
				o._CompanyName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyName"], typeof(System.String));
				o._VATNo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VATNo"], typeof(System.String));
				o._Phone = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Phone"], typeof(System.String));
				o._Address = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Address"], typeof(System.String));
				o._PostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PostCode"], typeof(System.String));
				o._City = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["City"], typeof(System.String));
				o._Country = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Country"], typeof(System.String));
				o._InvoiceAddress = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceAddress"], typeof(System.String));
				o._InvoicePostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoicePostCode"], typeof(System.String));
				o._InvoiceCity = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCity"], typeof(System.String));
				o._InvoiceCountry = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCountry"], typeof(System.String));
				o._IsPaymentAccepted = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaymentAccepted"], typeof(System.Boolean));
				o._LastPaymentDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["LastPaymentDate"], typeof(System.DateTime));
				o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerUndoRedoCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerUndoRedoCollection;
        }
        
        public static long GetAllWithNoFilterOppositeSortingCount(System.Boolean _dummy)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUnReGeAlWiNoFiOpSoCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                
                
                DbParameter param_dummy = ClassConnectionProvider.GetDatabaseParameter("dummy", typeof(System.Boolean), -1);
				param_dummy.Value = ClassConnectionProvider.FromValueToSqlModelType(_dummy);
				command.Parameters.Add(param_dummy);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		public static CustomerUndoRedoCollection GetAllWithNoFilter(System.Boolean _dummy)
        {
			CustomerUndoRedoCollection _CustomerUndoRedoCollection = new CustomerUndoRedoCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUnReGeAlWiNoFi", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                
                
                DbParameter param_dummy = ClassConnectionProvider.GetDatabaseParameter("dummy", typeof(System.Boolean), -1);
				param_dummy.Value = ClassConnectionProvider.FromValueToSqlModelType(_dummy);
				command.Parameters.Add(param_dummy);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					CustomerUndoRedo o = new CustomerUndoRedo();
                
					o.__databaseState = RowState.Initialized;
                    o._UndoRedoId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoId"], typeof(System.Int64));
				o._IsCreatedUndoDeletes = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsCreatedUndoDeletes"], typeof(System.Boolean));
				o._IsDeletedUndoCreates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsDeletedUndoCreates"], typeof(System.Boolean));
				o._IsUpdatedUndoUpdates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUpdatedUndoUpdates"], typeof(System.Boolean));
				o._IsUndone = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUndone"], typeof(System.Boolean));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._FullNameOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FullNameOfResponsible"], typeof(System.String));
				o._EmailOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["EmailOfResponsible"], typeof(System.String));
				o._Description = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Description"], typeof(System.String));
				o._IsPartner = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPartner"], typeof(System.Boolean));
				o._CompanyName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyName"], typeof(System.String));
				o._VATNo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VATNo"], typeof(System.String));
				o._Phone = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Phone"], typeof(System.String));
				o._Address = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Address"], typeof(System.String));
				o._PostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PostCode"], typeof(System.String));
				o._City = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["City"], typeof(System.String));
				o._Country = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Country"], typeof(System.String));
				o._InvoiceAddress = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceAddress"], typeof(System.String));
				o._InvoicePostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoicePostCode"], typeof(System.String));
				o._InvoiceCity = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCity"], typeof(System.String));
				o._InvoiceCountry = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCountry"], typeof(System.String));
				o._IsPaymentAccepted = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaymentAccepted"], typeof(System.Boolean));
				o._LastPaymentDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["LastPaymentDate"], typeof(System.DateTime));
				o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerUndoRedoCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerUndoRedoCollection;
        }
        
        public static CustomerUndoRedoCollection GetAllWithNoFilterPaged(System.Boolean _dummy, long PagingStart, long PagingCount)
        {
			CustomerUndoRedoCollection _CustomerUndoRedoCollection = new CustomerUndoRedoCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUnReGeAlWiNoFiPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                
                
                DbParameter param_dummy = ClassConnectionProvider.GetDatabaseParameter("dummy", typeof(System.Boolean), -1);
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
					CustomerUndoRedo o = new CustomerUndoRedo();
                
					o.__databaseState = RowState.Initialized;
                    o._UndoRedoId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoId"], typeof(System.Int64));
				o._IsCreatedUndoDeletes = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsCreatedUndoDeletes"], typeof(System.Boolean));
				o._IsDeletedUndoCreates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsDeletedUndoCreates"], typeof(System.Boolean));
				o._IsUpdatedUndoUpdates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUpdatedUndoUpdates"], typeof(System.Boolean));
				o._IsUndone = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUndone"], typeof(System.Boolean));
				o._Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				o._FullNameOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FullNameOfResponsible"], typeof(System.String));
				o._EmailOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["EmailOfResponsible"], typeof(System.String));
				o._Description = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Description"], typeof(System.String));
				o._IsPartner = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPartner"], typeof(System.Boolean));
				o._CompanyName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyName"], typeof(System.String));
				o._VATNo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VATNo"], typeof(System.String));
				o._Phone = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Phone"], typeof(System.String));
				o._Address = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Address"], typeof(System.String));
				o._PostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PostCode"], typeof(System.String));
				o._City = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["City"], typeof(System.String));
				o._Country = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Country"], typeof(System.String));
				o._InvoiceAddress = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceAddress"], typeof(System.String));
				o._InvoicePostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoicePostCode"], typeof(System.String));
				o._InvoiceCity = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCity"], typeof(System.String));
				o._InvoiceCountry = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCountry"], typeof(System.String));
				o._IsPaymentAccepted = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaymentAccepted"], typeof(System.Boolean));
				o._LastPaymentDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["LastPaymentDate"], typeof(System.DateTime));
				o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerUndoRedoCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerUndoRedoCollection;
        }
        
        public static long GetAllWithNoFilterCount(System.Boolean _dummy)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuUnReGeAlWiNoFiCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                
                
                DbParameter param_dummy = ClassConnectionProvider.GetDatabaseParameter("dummy", typeof(System.Boolean), -1);
				param_dummy.Value = ClassConnectionProvider.FromValueToSqlModelType(_dummy);
				command.Parameters.Add(param_dummy);
				
                
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
        
        public CustomerUndoRedo() {}
        
        public CustomerUndoRedo(System.Int64 __UndoRedoId)
        {
			Read(__UndoRedoId);
        }
        
        #region CRUD
        
        void Exist()
        {
			// sql read - should be changed to specific exist implementation
			using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
			{
				dbconn.Open();
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUnReRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
				DbParameter param_UndoRedoId = ClassConnectionProvider.GetDatabaseParameter("UndoRedoId", typeof(System.Int64), -1);
				param_UndoRedoId.Value = ClassConnectionProvider.FromValueToSqlModelType(_UndoRedoId);
				command.Parameters.Add(param_UndoRedoId);
				
                
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
        
        public void Read(System.Int64 __UndoRedoId)
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].Read(__UndoRedoId);
					return;
				}

                // Get a service via an algorithm
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "CuUnRe");
                // Perfect for read operations, but not for write
                // scalingServices[nextIndex].Read(__UndoRedoId);
				// return;

				throw new NotImplementedException();
            }

            try
            {
				// sql read
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUnReRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					_UndoRedoId = __UndoRedoId;
				DbParameter param_UndoRedoId = ClassConnectionProvider.GetDatabaseParameter("UndoRedoId", typeof(System.Int64), -1);
				param_UndoRedoId.Value = ClassConnectionProvider.FromValueToSqlModelType(__UndoRedoId);
				command.Parameters.Add(param_UndoRedoId);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_UndoRedoId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoId"], typeof(System.Int64));
				_IsCreatedUndoDeletes = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsCreatedUndoDeletes"], typeof(System.Boolean));
				_IsDeletedUndoCreates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsDeletedUndoCreates"], typeof(System.Boolean));
				_IsUpdatedUndoUpdates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUpdatedUndoUpdates"], typeof(System.Boolean));
				_IsUndone = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUndone"], typeof(System.Boolean));
				_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				_FullNameOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FullNameOfResponsible"], typeof(System.String));
				_EmailOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["EmailOfResponsible"], typeof(System.String));
				_Description = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Description"], typeof(System.String));
				_IsPartner = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPartner"], typeof(System.Boolean));
				_CompanyName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyName"], typeof(System.String));
				_VATNo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VATNo"], typeof(System.String));
				_Phone = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Phone"], typeof(System.String));
				_Address = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Address"], typeof(System.String));
				_PostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PostCode"], typeof(System.String));
				_City = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["City"], typeof(System.String));
				_Country = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Country"], typeof(System.String));
				_InvoiceAddress = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceAddress"], typeof(System.String));
				_InvoicePostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoicePostCode"], typeof(System.String));
				_InvoiceCity = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCity"], typeof(System.String));
				_InvoiceCountry = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCountry"], typeof(System.String));
				_IsPaymentAccepted = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaymentAccepted"], typeof(System.Boolean));
				_LastPaymentDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["LastPaymentDate"], typeof(System.DateTime));
				_Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				_Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
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
                            failoverServices[n].Read(__UndoRedoId);
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "CuUnRe");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUnReRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_UndoRedoId = ClassConnectionProvider.GetDatabaseParameter("UndoRedoId", typeof(System.Int64), -1);
				param_UndoRedoId.Value = ClassConnectionProvider.FromValueToSqlModelType(_UndoRedoId);
				command.Parameters.Add(param_UndoRedoId);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_UndoRedoId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoId"], typeof(System.Int64));
				_IsCreatedUndoDeletes = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsCreatedUndoDeletes"], typeof(System.Boolean));
				_IsDeletedUndoCreates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsDeletedUndoCreates"], typeof(System.Boolean));
				_IsUpdatedUndoUpdates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUpdatedUndoUpdates"], typeof(System.Boolean));
				_IsUndone = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUndone"], typeof(System.Boolean));
				_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				_FullNameOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FullNameOfResponsible"], typeof(System.String));
				_EmailOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["EmailOfResponsible"], typeof(System.String));
				_Description = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Description"], typeof(System.String));
				_IsPartner = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPartner"], typeof(System.Boolean));
				_CompanyName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyName"], typeof(System.String));
				_VATNo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VATNo"], typeof(System.String));
				_Phone = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Phone"], typeof(System.String));
				_Address = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Address"], typeof(System.String));
				_PostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PostCode"], typeof(System.String));
				_City = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["City"], typeof(System.String));
				_Country = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Country"], typeof(System.String));
				_InvoiceAddress = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceAddress"], typeof(System.String));
				_InvoicePostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoicePostCode"], typeof(System.String));
				_InvoiceCity = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCity"], typeof(System.String));
				_InvoiceCountry = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCountry"], typeof(System.String));
				_IsPaymentAccepted = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaymentAccepted"], typeof(System.Boolean));
				_LastPaymentDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["LastPaymentDate"], typeof(System.DateTime));
				_Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				_Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUnReCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_IsCreatedUndoDeletes = ClassConnectionProvider.GetDatabaseParameter("IsCreatedUndoDeletes", typeof(System.Boolean), -1);
				param_IsCreatedUndoDeletes.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsCreatedUndoDeletes);
				command.Parameters.Add(param_IsCreatedUndoDeletes);
				DbParameter param_IsDeletedUndoCreates = ClassConnectionProvider.GetDatabaseParameter("IsDeletedUndoCreates", typeof(System.Boolean), -1);
				param_IsDeletedUndoCreates.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsDeletedUndoCreates);
				command.Parameters.Add(param_IsDeletedUndoCreates);
				DbParameter param_IsUpdatedUndoUpdates = ClassConnectionProvider.GetDatabaseParameter("IsUpdatedUndoUpdates", typeof(System.Boolean), -1);
				param_IsUpdatedUndoUpdates.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsUpdatedUndoUpdates);
				command.Parameters.Add(param_IsUpdatedUndoUpdates);
				DbParameter param_IsUndone = ClassConnectionProvider.GetDatabaseParameter("IsUndone", typeof(System.Boolean), -1);
				param_IsUndone.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsUndone);
				command.Parameters.Add(param_IsUndone);
				DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 256);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_FullNameOfResponsible = ClassConnectionProvider.GetDatabaseParameter("FullNameOfResponsible", typeof(System.String), 512);
				param_FullNameOfResponsible.Value = ClassConnectionProvider.FromValueToSqlModelType(_FullNameOfResponsible);
				command.Parameters.Add(param_FullNameOfResponsible);
				DbParameter param_EmailOfResponsible = ClassConnectionProvider.GetDatabaseParameter("EmailOfResponsible", typeof(System.String), 256);
				param_EmailOfResponsible.Value = ClassConnectionProvider.FromValueToSqlModelType(_EmailOfResponsible);
				command.Parameters.Add(param_EmailOfResponsible);
				DbParameter param_Description = ClassConnectionProvider.GetDatabaseParameter("Description", typeof(System.String), 256);
				param_Description.Value = ClassConnectionProvider.FromValueToSqlModelType(_Description);
				command.Parameters.Add(param_Description);
				DbParameter param_IsPartner = ClassConnectionProvider.GetDatabaseParameter("IsPartner", typeof(System.Boolean), -1);
				param_IsPartner.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsPartner);
				command.Parameters.Add(param_IsPartner);
				DbParameter param_CompanyName = ClassConnectionProvider.GetDatabaseParameter("CompanyName", typeof(System.String), 256);
				param_CompanyName.Value = ClassConnectionProvider.FromValueToSqlModelType(_CompanyName);
				command.Parameters.Add(param_CompanyName);
				DbParameter param_VATNo = ClassConnectionProvider.GetDatabaseParameter("VATNo", typeof(System.String), 256);
				param_VATNo.Value = ClassConnectionProvider.FromValueToSqlModelType(_VATNo);
				command.Parameters.Add(param_VATNo);
				DbParameter param_Phone = ClassConnectionProvider.GetDatabaseParameter("Phone", typeof(System.String), 128);
				param_Phone.Value = ClassConnectionProvider.FromValueToSqlModelType(_Phone);
				command.Parameters.Add(param_Phone);
				DbParameter param_Address = ClassConnectionProvider.GetDatabaseParameter("Address", typeof(System.String), 256);
				param_Address.Value = ClassConnectionProvider.FromValueToSqlModelType(_Address);
				command.Parameters.Add(param_Address);
				DbParameter param_PostCode = ClassConnectionProvider.GetDatabaseParameter("PostCode", typeof(System.String), 64);
				param_PostCode.Value = ClassConnectionProvider.FromValueToSqlModelType(_PostCode);
				command.Parameters.Add(param_PostCode);
				DbParameter param_City = ClassConnectionProvider.GetDatabaseParameter("City", typeof(System.String), 128);
				param_City.Value = ClassConnectionProvider.FromValueToSqlModelType(_City);
				command.Parameters.Add(param_City);
				DbParameter param_Country = ClassConnectionProvider.GetDatabaseParameter("Country", typeof(System.String), 256);
				param_Country.Value = ClassConnectionProvider.FromValueToSqlModelType(_Country);
				command.Parameters.Add(param_Country);
				DbParameter param_InvoiceAddress = ClassConnectionProvider.GetDatabaseParameter("InvoiceAddress", typeof(System.String), 256);
				param_InvoiceAddress.Value = ClassConnectionProvider.FromValueToSqlModelType(_InvoiceAddress);
				command.Parameters.Add(param_InvoiceAddress);
				DbParameter param_InvoicePostCode = ClassConnectionProvider.GetDatabaseParameter("InvoicePostCode", typeof(System.String), 64);
				param_InvoicePostCode.Value = ClassConnectionProvider.FromValueToSqlModelType(_InvoicePostCode);
				command.Parameters.Add(param_InvoicePostCode);
				DbParameter param_InvoiceCity = ClassConnectionProvider.GetDatabaseParameter("InvoiceCity", typeof(System.String), 128);
				param_InvoiceCity.Value = ClassConnectionProvider.FromValueToSqlModelType(_InvoiceCity);
				command.Parameters.Add(param_InvoiceCity);
				DbParameter param_InvoiceCountry = ClassConnectionProvider.GetDatabaseParameter("InvoiceCountry", typeof(System.String), 256);
				param_InvoiceCountry.Value = ClassConnectionProvider.FromValueToSqlModelType(_InvoiceCountry);
				command.Parameters.Add(param_InvoiceCountry);
				DbParameter param_IsPaymentAccepted = ClassConnectionProvider.GetDatabaseParameter("IsPaymentAccepted", typeof(System.Boolean), -1);
				param_IsPaymentAccepted.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsPaymentAccepted);
				command.Parameters.Add(param_IsPaymentAccepted);
				DbParameter param_LastPaymentDate = ClassConnectionProvider.GetDatabaseParameter("LastPaymentDate", typeof(System.DateTime), -1);
				param_LastPaymentDate.Value = ClassConnectionProvider.FromValueToSqlModelType(_LastPaymentDate);
				command.Parameters.Add(param_LastPaymentDate);
				DbParameter param_Partner_Name = ClassConnectionProvider.GetDatabaseParameter("Partner_Name", typeof(System.String), -1);
				param_Partner_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Partner_Name);
				command.Parameters.Add(param_Partner_Name);
				DbParameter param_Owner_Name = ClassConnectionProvider.GetDatabaseParameter("Owner_Name", typeof(System.String), -1);
				param_Owner_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Owner_Name);
				command.Parameters.Add(param_Owner_Name);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
							_UndoRedoId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoId"], typeof(System.Int64));
				_IsCreatedUndoDeletes = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsCreatedUndoDeletes"], typeof(System.Boolean));
				_IsDeletedUndoCreates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsDeletedUndoCreates"], typeof(System.Boolean));
				_IsUpdatedUndoUpdates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUpdatedUndoUpdates"], typeof(System.Boolean));
				_IsUndone = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUndone"], typeof(System.Boolean));
				_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Name"], typeof(System.String));
				_FullNameOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["FullNameOfResponsible"], typeof(System.String));
				_EmailOfResponsible = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["EmailOfResponsible"], typeof(System.String));
				_Description = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Description"], typeof(System.String));
				_IsPartner = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPartner"], typeof(System.Boolean));
				_CompanyName = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["CompanyName"], typeof(System.String));
				_VATNo = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["VATNo"], typeof(System.String));
				_Phone = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Phone"], typeof(System.String));
				_Address = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Address"], typeof(System.String));
				_PostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PostCode"], typeof(System.String));
				_City = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["City"], typeof(System.String));
				_Country = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Country"], typeof(System.String));
				_InvoiceAddress = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceAddress"], typeof(System.String));
				_InvoicePostCode = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoicePostCode"], typeof(System.String));
				_InvoiceCity = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCity"], typeof(System.String));
				_InvoiceCountry = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["InvoiceCountry"], typeof(System.String));
				_IsPaymentAccepted = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaymentAccepted"], typeof(System.Boolean));
				_LastPaymentDate = (System.DateTime) global::Platform.Runtime.Utilities.FromSqlToValue(dr["LastPaymentDate"], typeof(System.DateTime));
				_Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				_Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
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
        
        static public CustomerUndoRedo CreateCustomerUndoRedo(System.Int64 __UndoRedoId)
        {
            CustomerUndoRedo o = new CustomerUndoRedo(__UndoRedoId);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUnReUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_UndoRedoId = ClassConnectionProvider.GetDatabaseParameter("UndoRedoId", typeof(System.Int64), -1);
				param_UndoRedoId.Value = ClassConnectionProvider.FromValueToSqlModelType(_UndoRedoId);
				command.Parameters.Add(param_UndoRedoId);
				DbParameter param_IsCreatedUndoDeletes = ClassConnectionProvider.GetDatabaseParameter("IsCreatedUndoDeletes", typeof(System.Boolean), -1);
				param_IsCreatedUndoDeletes.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsCreatedUndoDeletes);
				command.Parameters.Add(param_IsCreatedUndoDeletes);
				DbParameter param_IsDeletedUndoCreates = ClassConnectionProvider.GetDatabaseParameter("IsDeletedUndoCreates", typeof(System.Boolean), -1);
				param_IsDeletedUndoCreates.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsDeletedUndoCreates);
				command.Parameters.Add(param_IsDeletedUndoCreates);
				DbParameter param_IsUpdatedUndoUpdates = ClassConnectionProvider.GetDatabaseParameter("IsUpdatedUndoUpdates", typeof(System.Boolean), -1);
				param_IsUpdatedUndoUpdates.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsUpdatedUndoUpdates);
				command.Parameters.Add(param_IsUpdatedUndoUpdates);
				DbParameter param_IsUndone = ClassConnectionProvider.GetDatabaseParameter("IsUndone", typeof(System.Boolean), -1);
				param_IsUndone.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsUndone);
				command.Parameters.Add(param_IsUndone);
				DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 256);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_FullNameOfResponsible = ClassConnectionProvider.GetDatabaseParameter("FullNameOfResponsible", typeof(System.String), 512);
				param_FullNameOfResponsible.Value = ClassConnectionProvider.FromValueToSqlModelType(_FullNameOfResponsible);
				command.Parameters.Add(param_FullNameOfResponsible);
				DbParameter param_EmailOfResponsible = ClassConnectionProvider.GetDatabaseParameter("EmailOfResponsible", typeof(System.String), 256);
				param_EmailOfResponsible.Value = ClassConnectionProvider.FromValueToSqlModelType(_EmailOfResponsible);
				command.Parameters.Add(param_EmailOfResponsible);
				DbParameter param_Description = ClassConnectionProvider.GetDatabaseParameter("Description", typeof(System.String), 256);
				param_Description.Value = ClassConnectionProvider.FromValueToSqlModelType(_Description);
				command.Parameters.Add(param_Description);
				DbParameter param_IsPartner = ClassConnectionProvider.GetDatabaseParameter("IsPartner", typeof(System.Boolean), -1);
				param_IsPartner.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsPartner);
				command.Parameters.Add(param_IsPartner);
				DbParameter param_CompanyName = ClassConnectionProvider.GetDatabaseParameter("CompanyName", typeof(System.String), 256);
				param_CompanyName.Value = ClassConnectionProvider.FromValueToSqlModelType(_CompanyName);
				command.Parameters.Add(param_CompanyName);
				DbParameter param_VATNo = ClassConnectionProvider.GetDatabaseParameter("VATNo", typeof(System.String), 256);
				param_VATNo.Value = ClassConnectionProvider.FromValueToSqlModelType(_VATNo);
				command.Parameters.Add(param_VATNo);
				DbParameter param_Phone = ClassConnectionProvider.GetDatabaseParameter("Phone", typeof(System.String), 128);
				param_Phone.Value = ClassConnectionProvider.FromValueToSqlModelType(_Phone);
				command.Parameters.Add(param_Phone);
				DbParameter param_Address = ClassConnectionProvider.GetDatabaseParameter("Address", typeof(System.String), 256);
				param_Address.Value = ClassConnectionProvider.FromValueToSqlModelType(_Address);
				command.Parameters.Add(param_Address);
				DbParameter param_PostCode = ClassConnectionProvider.GetDatabaseParameter("PostCode", typeof(System.String), 64);
				param_PostCode.Value = ClassConnectionProvider.FromValueToSqlModelType(_PostCode);
				command.Parameters.Add(param_PostCode);
				DbParameter param_City = ClassConnectionProvider.GetDatabaseParameter("City", typeof(System.String), 128);
				param_City.Value = ClassConnectionProvider.FromValueToSqlModelType(_City);
				command.Parameters.Add(param_City);
				DbParameter param_Country = ClassConnectionProvider.GetDatabaseParameter("Country", typeof(System.String), 256);
				param_Country.Value = ClassConnectionProvider.FromValueToSqlModelType(_Country);
				command.Parameters.Add(param_Country);
				DbParameter param_InvoiceAddress = ClassConnectionProvider.GetDatabaseParameter("InvoiceAddress", typeof(System.String), 256);
				param_InvoiceAddress.Value = ClassConnectionProvider.FromValueToSqlModelType(_InvoiceAddress);
				command.Parameters.Add(param_InvoiceAddress);
				DbParameter param_InvoicePostCode = ClassConnectionProvider.GetDatabaseParameter("InvoicePostCode", typeof(System.String), 64);
				param_InvoicePostCode.Value = ClassConnectionProvider.FromValueToSqlModelType(_InvoicePostCode);
				command.Parameters.Add(param_InvoicePostCode);
				DbParameter param_InvoiceCity = ClassConnectionProvider.GetDatabaseParameter("InvoiceCity", typeof(System.String), 128);
				param_InvoiceCity.Value = ClassConnectionProvider.FromValueToSqlModelType(_InvoiceCity);
				command.Parameters.Add(param_InvoiceCity);
				DbParameter param_InvoiceCountry = ClassConnectionProvider.GetDatabaseParameter("InvoiceCountry", typeof(System.String), 256);
				param_InvoiceCountry.Value = ClassConnectionProvider.FromValueToSqlModelType(_InvoiceCountry);
				command.Parameters.Add(param_InvoiceCountry);
				DbParameter param_IsPaymentAccepted = ClassConnectionProvider.GetDatabaseParameter("IsPaymentAccepted", typeof(System.Boolean), -1);
				param_IsPaymentAccepted.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsPaymentAccepted);
				command.Parameters.Add(param_IsPaymentAccepted);
				DbParameter param_LastPaymentDate = ClassConnectionProvider.GetDatabaseParameter("LastPaymentDate", typeof(System.DateTime), -1);
				param_LastPaymentDate.Value = ClassConnectionProvider.FromValueToSqlModelType(_LastPaymentDate);
				command.Parameters.Add(param_LastPaymentDate);
				DbParameter param_Partner_Name = ClassConnectionProvider.GetDatabaseParameter("Partner_Name", typeof(System.String), -1);
				param_Partner_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Partner_Name);
				command.Parameters.Add(param_Partner_Name);
				DbParameter param_Owner_Name = ClassConnectionProvider.GetDatabaseParameter("Owner_Name", typeof(System.String), -1);
				param_Owner_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Owner_Name);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUnReDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_UndoRedoId = ClassConnectionProvider.GetDatabaseParameter("UndoRedoId", typeof(System.Int64), -1);
				param_UndoRedoId.Value = ClassConnectionProvider.FromValueToSqlModelType(_UndoRedoId);
				command.Parameters.Add(param_UndoRedoId);
				
				
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
        
        static public void DeleteCustomerUndoRedo(System.Int64 __UndoRedoId)
        {
            CustomerUndoRedo o = new CustomerUndoRedo(__UndoRedoId);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(CustomerUndoRedo _object)
        {
			_UndoRedoId = _object._UndoRedoId;
			_IsCreatedUndoDeletes = _object._IsCreatedUndoDeletes;
			_IsDeletedUndoCreates = _object._IsDeletedUndoCreates;
			_IsUpdatedUndoUpdates = _object._IsUpdatedUndoUpdates;
			_IsUndone = _object._IsUndone;
			_Name = _object._Name;
			_FullNameOfResponsible = _object._FullNameOfResponsible;
			_EmailOfResponsible = _object._EmailOfResponsible;
			_Description = _object._Description;
			_IsPartner = _object._IsPartner;
			_CompanyName = _object._CompanyName;
			_VATNo = _object._VATNo;
			_Phone = _object._Phone;
			_Address = _object._Address;
			_PostCode = _object._PostCode;
			_City = _object._City;
			_Country = _object._Country;
			_InvoiceAddress = _object._InvoiceAddress;
			_InvoicePostCode = _object._InvoicePostCode;
			_InvoiceCity = _object._InvoiceCity;
			_InvoiceCountry = _object._InvoiceCountry;
			_IsPaymentAccepted = _object._IsPaymentAccepted;
			_LastPaymentDate = _object._LastPaymentDate;
			_Partner_Name = _object._Partner_Name;
			_Owner_Name = _object._Owner_Name;
			
        }
        
        public void CopyWithKeysTo(CustomerUndoRedo _object)
        {
			_object._UndoRedoId = _UndoRedoId;
			_object._IsCreatedUndoDeletes = _IsCreatedUndoDeletes;
			_object._IsDeletedUndoCreates = _IsDeletedUndoCreates;
			_object._IsUpdatedUndoUpdates = _IsUpdatedUndoUpdates;
			_object._IsUndone = _IsUndone;
			_object._Name = _Name;
			_object._FullNameOfResponsible = _FullNameOfResponsible;
			_object._EmailOfResponsible = _EmailOfResponsible;
			_object._Description = _Description;
			_object._IsPartner = _IsPartner;
			_object._CompanyName = _CompanyName;
			_object._VATNo = _VATNo;
			_object._Phone = _Phone;
			_object._Address = _Address;
			_object._PostCode = _PostCode;
			_object._City = _City;
			_object._Country = _Country;
			_object._InvoiceAddress = _InvoiceAddress;
			_object._InvoicePostCode = _InvoicePostCode;
			_object._InvoiceCity = _InvoiceCity;
			_object._InvoiceCountry = _InvoiceCountry;
			_object._IsPaymentAccepted = _IsPaymentAccepted;
			_object._LastPaymentDate = _LastPaymentDate;
			_object._Partner_Name = _Partner_Name;
			_object._Owner_Name = _Owner_Name;
			
        }
        
        static public void CopyWithKeysObject(CustomerUndoRedo _objectFrom, CustomerUndoRedo _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(CustomerUndoRedo _object)
        {
			_IsCreatedUndoDeletes = _object._IsCreatedUndoDeletes;
			_IsDeletedUndoCreates = _object._IsDeletedUndoCreates;
			_IsUpdatedUndoUpdates = _object._IsUpdatedUndoUpdates;
			_IsUndone = _object._IsUndone;
			_Name = _object._Name;
			_FullNameOfResponsible = _object._FullNameOfResponsible;
			_EmailOfResponsible = _object._EmailOfResponsible;
			_Description = _object._Description;
			_IsPartner = _object._IsPartner;
			_CompanyName = _object._CompanyName;
			_VATNo = _object._VATNo;
			_Phone = _object._Phone;
			_Address = _object._Address;
			_PostCode = _object._PostCode;
			_City = _object._City;
			_Country = _object._Country;
			_InvoiceAddress = _object._InvoiceAddress;
			_InvoicePostCode = _object._InvoicePostCode;
			_InvoiceCity = _object._InvoiceCity;
			_InvoiceCountry = _object._InvoiceCountry;
			_IsPaymentAccepted = _object._IsPaymentAccepted;
			_LastPaymentDate = _object._LastPaymentDate;
			_Partner_Name = _object._Partner_Name;
			_Owner_Name = _object._Owner_Name;
			
        }
        
        public void CopyTo(CustomerUndoRedo _object)
        {
			_object._IsCreatedUndoDeletes = _IsCreatedUndoDeletes;
			_object._IsDeletedUndoCreates = _IsDeletedUndoCreates;
			_object._IsUpdatedUndoUpdates = _IsUpdatedUndoUpdates;
			_object._IsUndone = _IsUndone;
			_object._Name = _Name;
			_object._FullNameOfResponsible = _FullNameOfResponsible;
			_object._EmailOfResponsible = _EmailOfResponsible;
			_object._Description = _Description;
			_object._IsPartner = _IsPartner;
			_object._CompanyName = _CompanyName;
			_object._VATNo = _VATNo;
			_object._Phone = _Phone;
			_object._Address = _Address;
			_object._PostCode = _PostCode;
			_object._City = _City;
			_object._Country = _Country;
			_object._InvoiceAddress = _InvoiceAddress;
			_object._InvoicePostCode = _InvoicePostCode;
			_object._InvoiceCity = _InvoiceCity;
			_object._InvoiceCountry = _InvoiceCountry;
			_object._IsPaymentAccepted = _IsPaymentAccepted;
			_object._LastPaymentDate = _LastPaymentDate;
			_object._Partner_Name = _Partner_Name;
			_object._Owner_Name = _Owner_Name;
			
        }
        
        static public void CopyObject(CustomerUndoRedo _objectFrom, CustomerUndoRedo _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(CustomerUndoRedo).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(CustomerUndoRedo).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(CustomerUndoRedo _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			CustomerUndoRedoUndoRedoCollection allUndidAndNotRedoneEntries = CustomerUndoRedoUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			CustomerUndoRedoUndoRedo _urobject = new CustomerUndoRedoUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.UndoRedoId = _object._UndoRedoId;
			_urobject.IsCreatedUndoDeletes = _object._IsCreatedUndoDeletes;
			_urobject.IsDeletedUndoCreates = _object._IsDeletedUndoCreates;
			_urobject.IsUpdatedUndoUpdates = _object._IsUpdatedUndoUpdates;
			_urobject.IsUndone = _object._IsUndone;
			_urobject.Name = _object._Name;
			_urobject.FullNameOfResponsible = _object._FullNameOfResponsible;
			_urobject.EmailOfResponsible = _object._EmailOfResponsible;
			_urobject.Description = _object._Description;
			_urobject.IsPartner = _object._IsPartner;
			_urobject.CompanyName = _object._CompanyName;
			_urobject.VATNo = _object._VATNo;
			_urobject.Phone = _object._Phone;
			_urobject.Address = _object._Address;
			_urobject.PostCode = _object._PostCode;
			_urobject.City = _object._City;
			_urobject.Country = _object._Country;
			_urobject.InvoiceAddress = _object._InvoiceAddress;
			_urobject.InvoicePostCode = _object._InvoicePostCode;
			_urobject.InvoiceCity = _object._InvoiceCity;
			_urobject.InvoiceCountry = _object._InvoiceCountry;
			_urobject.IsPaymentAccepted = _object._IsPaymentAccepted;
			_urobject.LastPaymentDate = _object._LastPaymentDate;
			_urobject.Partner_Name = _object._Partner_Name;
			_urobject.Owner_Name = _object._Owner_Name;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(CustomerUndoRedo).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = CustomerUndoRedoUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				CustomerUndoRedoUndoRedoCollection allOldUndoEntries = CustomerUndoRedoUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			CustomerUndoRedoUndoRedoCollection firstUndoEntries = CustomerUndoRedoUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			CustomerUndoRedoUndoRedo _urobject = firstUndoEntries[0];
			
			CustomerUndoRedo _object = new CustomerUndoRedo();
			_object._UndoRedoId = _urobject.UndoRedoId;
			_object._IsCreatedUndoDeletes = _urobject.IsCreatedUndoDeletes;
			_object._IsDeletedUndoCreates = _urobject.IsDeletedUndoCreates;
			_object._IsUpdatedUndoUpdates = _urobject.IsUpdatedUndoUpdates;
			_object._IsUndone = _urobject.IsUndone;
			_object._Name = _urobject.Name;
			_object._FullNameOfResponsible = _urobject.FullNameOfResponsible;
			_object._EmailOfResponsible = _urobject.EmailOfResponsible;
			_object._Description = _urobject.Description;
			_object._IsPartner = _urobject.IsPartner;
			_object._CompanyName = _urobject.CompanyName;
			_object._VATNo = _urobject.VATNo;
			_object._Phone = _urobject.Phone;
			_object._Address = _urobject.Address;
			_object._PostCode = _urobject.PostCode;
			_object._City = _urobject.City;
			_object._Country = _urobject.Country;
			_object._InvoiceAddress = _urobject.InvoiceAddress;
			_object._InvoicePostCode = _urobject.InvoicePostCode;
			_object._InvoiceCity = _urobject.InvoiceCity;
			_object._InvoiceCountry = _urobject.InvoiceCountry;
			_object._IsPaymentAccepted = _urobject.IsPaymentAccepted;
			_object._LastPaymentDate = _urobject.LastPaymentDate;
			_object._Partner_Name = _urobject.Partner_Name;
			_object._Owner_Name = _urobject.Owner_Name;
			

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
			CustomerUndoRedoUndoRedoCollection firstEntryToRedoEntries = CustomerUndoRedoUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			CustomerUndoRedoUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			CustomerUndoRedo _object = new CustomerUndoRedo();
			_object._UndoRedoId = _urobject.UndoRedoId;
			_object._IsCreatedUndoDeletes = _urobject.IsCreatedUndoDeletes;
			_object._IsDeletedUndoCreates = _urobject.IsDeletedUndoCreates;
			_object._IsUpdatedUndoUpdates = _urobject.IsUpdatedUndoUpdates;
			_object._IsUndone = _urobject.IsUndone;
			_object._Name = _urobject.Name;
			_object._FullNameOfResponsible = _urobject.FullNameOfResponsible;
			_object._EmailOfResponsible = _urobject.EmailOfResponsible;
			_object._Description = _urobject.Description;
			_object._IsPartner = _urobject.IsPartner;
			_object._CompanyName = _urobject.CompanyName;
			_object._VATNo = _urobject.VATNo;
			_object._Phone = _urobject.Phone;
			_object._Address = _urobject.Address;
			_object._PostCode = _urobject.PostCode;
			_object._City = _urobject.City;
			_object._Country = _urobject.Country;
			_object._InvoiceAddress = _urobject.InvoiceAddress;
			_object._InvoicePostCode = _urobject.InvoicePostCode;
			_object._InvoiceCity = _urobject.InvoiceCity;
			_object._InvoiceCountry = _urobject.InvoiceCountry;
			_object._IsPaymentAccepted = _urobject.IsPaymentAccepted;
			_object._LastPaymentDate = _urobject.LastPaymentDate;
			_object._Partner_Name = _urobject.Partner_Name;
			_object._Owner_Name = _urobject.Owner_Name;
			

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
    /// Defines the contract for the CustomerUndoRedoCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("ce92924f-c8c7-04c0-66fa-944021d4cbc3")]
    public interface ICustomerUndoRedoCollection : IEnumerable<CustomerUndoRedo>
    {
        int IndexOf(CustomerUndoRedo item);
        void Insert(int index, CustomerUndoRedo item);
        void RemoveAt(int index);
        CustomerUndoRedo this[int index] { get; set; }
        void Add(CustomerUndoRedo item);
        void Clear();
        bool Contains(CustomerUndoRedo item);
        void CopyTo(CustomerUndoRedo[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(CustomerUndoRedo item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.CustomerUndoRedo
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("7cc3d0ee-4238-e9a5-faae-402c2958022d")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class CustomerUndoRedoCollection : ICustomerUndoRedoCollection, IList<CustomerUndoRedo>, IHierarchicalEnumerable
    {
        List<CustomerUndoRedo> _list = new List<CustomerUndoRedo>();
        
        public static implicit operator List<CustomerUndoRedo>(CustomerUndoRedoCollection collection)
        {
            return collection._list;
        }

        #region IList<CustomerUndoRedo> Members

        public int IndexOf(CustomerUndoRedo item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, CustomerUndoRedo item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public CustomerUndoRedo this[int index]
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

        #region ICollection<CustomerUndoRedo> Members

        public void Add(CustomerUndoRedo item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(CustomerUndoRedo item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(CustomerUndoRedo[] array, int arrayIndex)
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

        public bool Remove(CustomerUndoRedo item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<CustomerUndoRedo> Members

        public IEnumerator<CustomerUndoRedo> GetEnumerator()
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
	/// that share Services.Packages.CustomerUndoRedo objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Web.CustomerUndoRedoWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class CustomerUndoRedoWebService : WebService, ICustomerUndoRedoService
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
        public bool Exists(CustomerUndoRedo _CustomerUndoRedo)
        {
			return _CustomerUndoRedo.Exists;
        }
		
		[WebMethod]
		public CustomerUndoRedo Read(System.Int64 __UndoRedoId)
		{
			return new CustomerUndoRedo(__UndoRedoId);
		}
		
		[WebMethod]
        public CustomerUndoRedo Reload(CustomerUndoRedo _CustomerUndoRedo)
        {
			_CustomerUndoRedo.Reload();
			return _CustomerUndoRedo;
        }
		
		[WebMethod]
        public CustomerUndoRedo Create(System.Int64 __UndoRedoId)
        {
			return CustomerUndoRedo.CreateCustomerUndoRedo(__UndoRedoId);
        }
        
        [WebMethod]
        public void Delete(System.Int64 __UndoRedoId)
        {
			CustomerUndoRedo.DeleteCustomerUndoRedo(__UndoRedoId);
        }
        
        [WebMethod]
        public void UpdateObject(CustomerUndoRedo _CustomerUndoRedo)
        {
			_CustomerUndoRedo.Update();
        }
		
		[WebMethod]
        public void CreateObject(CustomerUndoRedo _CustomerUndoRedo)
        {
			_CustomerUndoRedo.Create();
        }
        
        [WebMethod]
        public void DeleteObject(CustomerUndoRedo _CustomerUndoRedo)
        {
			_CustomerUndoRedo.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			CustomerUndoRedo.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			CustomerUndoRedo.Redo();
        }
		[WebMethod]
		public CustomerUndoRedoCollection GetAllFilterByIsUndone(System.Boolean IsUndone )
		{
			return CustomerUndoRedo.GetAllFilterByIsUndone(IsUndone );
		}
		[WebMethod]
		public CustomerUndoRedoCollection GetAllFilterByIsUndonePaged(System.Boolean IsUndone , long PagingStart, long PagingCount)
		{
			return CustomerUndoRedo.GetAllFilterByIsUndonePaged(IsUndone , PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetAllFilterByIsUndoneCount(System.Boolean IsUndone )
		{
			return CustomerUndoRedo.GetAllFilterByIsUndoneCount(IsUndone );
		}
		[WebMethod]
		public CustomerUndoRedoCollection GetAllFilterByIsUndoneOppositeOrder(System.Boolean IsUndone )
		{
			return CustomerUndoRedo.GetAllFilterByIsUndoneOppositeOrder(IsUndone );
		}
		[WebMethod]
		public CustomerUndoRedoCollection GetAllFilterByIsUndoneOppositeOrderPaged(System.Boolean IsUndone , long PagingStart, long PagingCount)
		{
			return CustomerUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(IsUndone , PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetAllFilterByIsUndoneOppositeOrderCount(System.Boolean IsUndone )
		{
			return CustomerUndoRedo.GetAllFilterByIsUndoneOppositeOrderCount(IsUndone );
		}
		[WebMethod]
		public CustomerUndoRedoCollection GetAllWithNoFilterOppositeSorting(System.Boolean dummy )
		{
			return CustomerUndoRedo.GetAllWithNoFilterOppositeSorting(dummy );
		}
		[WebMethod]
		public CustomerUndoRedoCollection GetAllWithNoFilterOppositeSortingPaged(System.Boolean dummy , long PagingStart, long PagingCount)
		{
			return CustomerUndoRedo.GetAllWithNoFilterOppositeSortingPaged(dummy , PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetAllWithNoFilterOppositeSortingCount(System.Boolean dummy )
		{
			return CustomerUndoRedo.GetAllWithNoFilterOppositeSortingCount(dummy );
		}
		[WebMethod]
		public CustomerUndoRedoCollection GetAllWithNoFilter(System.Boolean dummy )
		{
			return CustomerUndoRedo.GetAllWithNoFilter(dummy );
		}
		[WebMethod]
		public CustomerUndoRedoCollection GetAllWithNoFilterPaged(System.Boolean dummy , long PagingStart, long PagingCount)
		{
			return CustomerUndoRedo.GetAllWithNoFilterPaged(dummy , PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetAllWithNoFilterCount(System.Boolean dummy )
		{
			return CustomerUndoRedo.GetAllWithNoFilterCount(dummy );
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="CustomerUndoRedoWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("eacc1181-3fea-c6f7-1a31-4069916d6079")]
    sealed public class CustomerUndoRedoWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, ICustomerUndoRedoService
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
		public CustomerUndoRedoWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public CustomerUndoRedoWebServiceClient()
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
		public bool Exists(CustomerUndoRedo _CustomerUndoRedo)
        {
			object[] results = this.Invoke("Exists", new object[] {_CustomerUndoRedo});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUndoRedo Read(System.Int64 __UndoRedoId)
		{
			object[] results = this.Invoke("Read", new object[] {__UndoRedoId});
			return ((CustomerUndoRedo)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUndoRedo Reload(CustomerUndoRedo _CustomerUndoRedo)
        {
			object[] results = this.Invoke("Reload", new object[] {_CustomerUndoRedo});
			return ((CustomerUndoRedo)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUndoRedo Create(System.Int64 __UndoRedoId)
        {
			object[] results = this.Invoke("Create", new object[] {__UndoRedoId});
			return ((CustomerUndoRedo)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.Int64 __UndoRedoId)
        {
			this.Invoke("Delete", new object[] {__UndoRedoId});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(CustomerUndoRedo _CustomerUndoRedo)
        {
			this.Invoke("UpdateObject", new object[] {_CustomerUndoRedo});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(CustomerUndoRedo _CustomerUndoRedo)
        {
			this.Invoke("CreateObject", new object[] {_CustomerUndoRedo});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(CustomerUndoRedo _CustomerUndoRedo)
        {
			this.Invoke("DeleteObject", new object[] {_CustomerUndoRedo});
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
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllFilterByIsUndone", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUndoRedoCollection GetAllFilterByIsUndone(System.Boolean IsUndone ) {
			object[] results = this.Invoke("GetAllFilterByIsUndone", new object[] {IsUndone});
			return ((CustomerUndoRedoCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllFilterByIsUndonePaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUndoRedoCollection GetAllFilterByIsUndonePaged(System.Boolean IsUndone , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetAllFilterByIsUndonePaged", new object[] {IsUndone,PagingStart,PagingCount});
			return ((CustomerUndoRedoCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllFilterByIsUndoneCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetAllFilterByIsUndoneCount(System.Boolean IsUndone ) {
			object[] results = this.Invoke("GetAllFilterByIsUndoneCount", new object[] {IsUndone});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllFilterByIsUndoneOppositeOrder", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUndoRedoCollection GetAllFilterByIsUndoneOppositeOrder(System.Boolean IsUndone ) {
			object[] results = this.Invoke("GetAllFilterByIsUndoneOppositeOrder", new object[] {IsUndone});
			return ((CustomerUndoRedoCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllFilterByIsUndoneOppositeOrderPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUndoRedoCollection GetAllFilterByIsUndoneOppositeOrderPaged(System.Boolean IsUndone , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetAllFilterByIsUndoneOppositeOrderPaged", new object[] {IsUndone,PagingStart,PagingCount});
			return ((CustomerUndoRedoCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllFilterByIsUndoneOppositeOrderCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetAllFilterByIsUndoneOppositeOrderCount(System.Boolean IsUndone ) {
			object[] results = this.Invoke("GetAllFilterByIsUndoneOppositeOrderCount", new object[] {IsUndone});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllWithNoFilterOppositeSorting", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUndoRedoCollection GetAllWithNoFilterOppositeSorting(System.Boolean dummy ) {
			object[] results = this.Invoke("GetAllWithNoFilterOppositeSorting", new object[] {dummy});
			return ((CustomerUndoRedoCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllWithNoFilterOppositeSortingPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUndoRedoCollection GetAllWithNoFilterOppositeSortingPaged(System.Boolean dummy , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetAllWithNoFilterOppositeSortingPaged", new object[] {dummy,PagingStart,PagingCount});
			return ((CustomerUndoRedoCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllWithNoFilterOppositeSortingCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetAllWithNoFilterOppositeSortingCount(System.Boolean dummy ) {
			object[] results = this.Invoke("GetAllWithNoFilterOppositeSortingCount", new object[] {dummy});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllWithNoFilter", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUndoRedoCollection GetAllWithNoFilter(System.Boolean dummy ) {
			object[] results = this.Invoke("GetAllWithNoFilter", new object[] {dummy});
			return ((CustomerUndoRedoCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllWithNoFilterPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerUndoRedoCollection GetAllWithNoFilterPaged(System.Boolean dummy , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetAllWithNoFilterPaged", new object[] {dummy,PagingStart,PagingCount});
			return ((CustomerUndoRedoCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllWithNoFilterCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetAllWithNoFilterCount(System.Boolean dummy ) {
			object[] results = this.Invoke("GetAllWithNoFilterCount", new object[] {dummy});
			return ((long)(results[0]));
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages
