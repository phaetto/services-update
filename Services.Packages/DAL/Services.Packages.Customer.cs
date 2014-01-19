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
    /// Defines the contract for the Customer class
    /// </summary>
    [ComVisible(true)]
    [Guid("ae32f7e9-38c9-5292-e726-991b7ea7ecf6")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface ICustomer
	{
		bool Exists { get; }
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
		Services.Packages.Customer Partner { get; set; }
		Services.Packages.Security.ModelUser Owner { get; set; }
		Services.Packages.ApiKeyCollection LicensesIssued { get; set; }
		Services.Packages.ApiKeyCollection SearchByCompanyInfoOnCustomer(System.String CompanyInfo);
		Services.Packages.CustomerCollection PartnerCustomers { get; set; }
		Services.Packages.CustomerCollection SearchByNameOnPartners(System.String Name);
		Services.Packages.CustomerCollection SearchByNameAndPaymentOnPartners(System.String Name, System.Boolean IsPaymentAccepted);
		Services.Packages.CustomerUserEntryCollection CustomerUserEntries { get; set; }
		Services.Packages.Security.CustomerAccessControlListCollection ACLs { get; set; }
		Services.Packages.Security.CustomerAccessControlListCollection GetACLs(System.String UserName);

		void Read(System.String __Name);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(Customer _object);
		void CopyWithKeysTo(Customer _object);
		void CopyFrom(Customer _object);
		void CopyTo(Customer _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.Customer type.
    /// </summary>
    [ComVisible(true)]
    [Guid("31546124-44b8-8863-6d70-9c2f2aa43cf5")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface ICustomerService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(Customer _Customer);
		[OperationContract]
        Customer Read(System.String __Name);
        [OperationContract]
        Customer Reload(Customer _Customer);
        [OperationContract]
        Customer Create(System.String __Name);
        [OperationContract]
        void Delete(System.String __Name);
        [OperationContract]
        void UpdateObject(Customer _Customer);
        [OperationContract]
        void CreateObject(Customer _Customer);
        [OperationContract]
        void DeleteObject(Customer _Customer);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		CustomerCollection GetByPartner(Services.Packages.Customer _Customer);
		[OperationContract]
		CustomerCollection GetByPartnerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByPartnerCount(Services.Packages.Customer _Customer);
		[OperationContract]
		Services.Packages.Customer GetPartner(Customer _Customer);
		[OperationContract]
		void SetPartner(Customer _Customer, Services.Packages.Customer _Partner);
		[OperationContract]
		CustomerCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		CustomerCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		Services.Packages.Security.ModelUser GetOwner(Customer _Customer);
		[OperationContract]
		void SetOwner(Customer _Customer, Services.Packages.Security.ModelUser _Owner);
		[OperationContract]
		CustomerCollection SearchByNameAndPartner(System.String Name, System.Boolean IsPartner );
		[OperationContract]
		CustomerCollection SearchByNameAndPartnerPaged(System.String Name, System.Boolean IsPartner , long PagingStart, long PagingCount);
		[OperationContract]
		long SearchByNameAndPartnerCount(System.String Name, System.Boolean IsPartner );
		[OperationContract]
		CustomerCollection SearchByName(System.String Name );
		[OperationContract]
		CustomerCollection SearchByNamePaged(System.String Name , long PagingStart, long PagingCount);
		[OperationContract]
		long SearchByNameCount(System.String Name );
		[OperationContract]
		CustomerCollection SearchByNameAndPartnerPayment(System.String Name, System.Boolean IsPaymentAccepted );
		[OperationContract]
		CustomerCollection SearchByNameAndPartnerPaymentPaged(System.String Name, System.Boolean IsPaymentAccepted , long PagingStart, long PagingCount);
		[OperationContract]
		long SearchByNameAndPartnerPaymentCount(System.String Name, System.Boolean IsPaymentAccepted );
		[OperationContract]
		CustomerCollection SearchByNameOnPartners(System.String Name, Services.Packages.Customer _Customer);
		[OperationContract]
		CustomerCollection SearchByNameOnPartnersPaged(System.String Name, Services.Packages.Customer _Customer, long PagingStart, long PagingCount);
		[OperationContract]
		long SearchByNameOnPartnersCount(System.String Name, Services.Packages.Customer _Customer);
		[OperationContract]
		CustomerCollection SearchByNameAndPaymentOnPartners(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer);
		[OperationContract]
		CustomerCollection SearchByNameAndPaymentOnPartnersPaged(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer, long PagingStart, long PagingCount);
		[OperationContract]
		long SearchByNameAndPaymentOnPartnersCount(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer);
		[OperationContract]
		Services.Packages.ApiKeyCollection GetLicensesIssued(Customer _Customer);
		[OperationContract]
		void SetLicensesIssued(Customer _Customer, Services.Packages.ApiKeyCollection _LicensesIssued);
		[OperationContract]
		Services.Packages.CustomerCollection GetPartnerCustomers(Customer _Customer);
		[OperationContract]
		void SetPartnerCustomers(Customer _Customer, Services.Packages.CustomerCollection _PartnerCustomers);
		[OperationContract]
		Services.Packages.CustomerUserEntryCollection GetCustomerUserEntries(Customer _Customer);
		[OperationContract]
		void SetCustomerUserEntries(Customer _Customer, Services.Packages.CustomerUserEntryCollection _CustomerUserEntries);
		[OperationContract]
		Services.Packages.Security.CustomerAccessControlListCollection GetACLs(Customer _Customer);
		[OperationContract]
		void SetACLs(Customer _Customer, Services.Packages.Security.CustomerAccessControlListCollection _ACLs);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.Customer type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("e4bd19d7-109d-723a-8e18-086fd636b2d0")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class CustomerService : ICustomerService
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
        public bool Exists(Customer _Customer)
        {
			return _Customer.Exists;
        }
		
		[WebMethod]
		public Customer Read(System.String __Name)
		{
			return new Customer(__Name);
		}
		
		[WebMethod]
        public Customer Reload(Customer _Customer)
        {
			_Customer.Reload();
			return _Customer;
        }
		
		[WebMethod]
        public Customer Create(System.String __Name)
        {
			return Customer.CreateCustomer(__Name);
        }
        
        [WebMethod]
        public void Delete(System.String __Name)
        {
			Customer.DeleteCustomer(__Name);
        }
        
        [WebMethod]
        public void UpdateObject(Customer _Customer)
        {
			_Customer.Update();
        }
		
		[WebMethod]
        public void CreateObject(Customer _Customer)
        {
			_Customer.Create();
        }
        
        [WebMethod]
        public void DeleteObject(Customer _Customer)
        {
			_Customer.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			Customer.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			Customer.Redo();
        }
		[WebMethod]
		public CustomerCollection GetByPartner(Services.Packages.Customer _Customer)
		{
			return Customer.GetByPartner( _Customer);
		}
		[WebMethod]
		public CustomerCollection GetByPartnerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
		{
			return Customer.GetByPartnerPaged( _Customer, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByPartnerCount(Services.Packages.Customer _Customer)
		{
			return Customer.GetByPartnerCount( _Customer);
		}
		[WebMethod]
		public Services.Packages.Customer GetPartner(Customer _Customer)
		{
			_Customer.Reload();
			return _Customer.Partner;
		}
		[WebMethod]
		public void SetPartner(Customer _Customer, Services.Packages.Customer _Partner)
		{
			_Customer.Reload();
			_Customer.Partner = _Partner;
			_Customer.Update();
		}
		[WebMethod]
		public CustomerCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
		{
			return Customer.GetByOwner( _ModelUser);
		}
		[WebMethod]
		public CustomerCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return Customer.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return Customer.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(Customer _Customer)
		{
			_Customer.Reload();
			return _Customer.Owner;
		}
		[WebMethod]
		public void SetOwner(Customer _Customer, Services.Packages.Security.ModelUser _Owner)
		{
			_Customer.Reload();
			_Customer.Owner = _Owner;
			_Customer.Update();
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPartner(System.String Name, System.Boolean IsPartner )
		{
			return Customer.SearchByNameAndPartner(Name, IsPartner );
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPartnerPaged(System.String Name, System.Boolean IsPartner , long PagingStart, long PagingCount)
		{
			return Customer.SearchByNameAndPartnerPaged(Name, IsPartner , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByNameAndPartnerCount(System.String Name, System.Boolean IsPartner )
		{
			return Customer.SearchByNameAndPartnerCount(Name, IsPartner );
		}
		[WebMethod]
		public CustomerCollection SearchByName(System.String Name )
		{
			return Customer.SearchByName(Name );
		}
		[WebMethod]
		public CustomerCollection SearchByNamePaged(System.String Name , long PagingStart, long PagingCount)
		{
			return Customer.SearchByNamePaged(Name , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByNameCount(System.String Name )
		{
			return Customer.SearchByNameCount(Name );
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPartnerPayment(System.String Name, System.Boolean IsPaymentAccepted )
		{
			return Customer.SearchByNameAndPartnerPayment(Name, IsPaymentAccepted );
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPartnerPaymentPaged(System.String Name, System.Boolean IsPaymentAccepted , long PagingStart, long PagingCount)
		{
			return Customer.SearchByNameAndPartnerPaymentPaged(Name, IsPaymentAccepted , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByNameAndPartnerPaymentCount(System.String Name, System.Boolean IsPaymentAccepted )
		{
			return Customer.SearchByNameAndPartnerPaymentCount(Name, IsPaymentAccepted );
		}
		[WebMethod]
		public CustomerCollection SearchByNameOnPartners(System.String Name, Services.Packages.Customer _Customer)
		{
			return Customer.SearchByNameOnPartners(Name,  _Customer);
		}
		[WebMethod]
		public CustomerCollection SearchByNameOnPartnersPaged(System.String Name, Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
		{
			return Customer.SearchByNameOnPartnersPaged(Name,  _Customer, PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByNameOnPartnersCount(System.String Name, Services.Packages.Customer _Customer)
		{
			return Customer.SearchByNameOnPartnersCount(Name,  _Customer);
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPaymentOnPartners(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer)
		{
			return Customer.SearchByNameAndPaymentOnPartners(Name, IsPaymentAccepted,  _Customer);
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPaymentOnPartnersPaged(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
		{
			return Customer.SearchByNameAndPaymentOnPartnersPaged(Name, IsPaymentAccepted,  _Customer, PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByNameAndPaymentOnPartnersCount(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer)
		{
			return Customer.SearchByNameAndPaymentOnPartnersCount(Name, IsPaymentAccepted,  _Customer);
		}
		[WebMethod]
		public Services.Packages.ApiKeyCollection GetLicensesIssued(Customer _Customer)
		{
			_Customer.Reload();
			return _Customer.LicensesIssued;
		}
		[WebMethod]
		public void SetLicensesIssued(Customer _Customer, Services.Packages.ApiKeyCollection _LicensesIssued)
		{
			_Customer.Reload();
			_Customer.LicensesIssued = _LicensesIssued;
			_Customer.Update();
		}
		[WebMethod]
		public Services.Packages.CustomerCollection GetPartnerCustomers(Customer _Customer)
		{
			_Customer.Reload();
			return _Customer.PartnerCustomers;
		}
		[WebMethod]
		public void SetPartnerCustomers(Customer _Customer, Services.Packages.CustomerCollection _PartnerCustomers)
		{
			_Customer.Reload();
			_Customer.PartnerCustomers = _PartnerCustomers;
			_Customer.Update();
		}
		[WebMethod]
		public Services.Packages.CustomerUserEntryCollection GetCustomerUserEntries(Customer _Customer)
		{
			_Customer.Reload();
			return _Customer.CustomerUserEntries;
		}
		[WebMethod]
		public void SetCustomerUserEntries(Customer _Customer, Services.Packages.CustomerUserEntryCollection _CustomerUserEntries)
		{
			_Customer.Reload();
			_Customer.CustomerUserEntries = _CustomerUserEntries;
			_Customer.Update();
		}
		[WebMethod]
		public Services.Packages.Security.CustomerAccessControlListCollection GetACLs(Customer _Customer)
		{
			_Customer.Reload();
			return _Customer.ACLs;
		}
		[WebMethod]
		public void SetACLs(Customer _Customer, Services.Packages.Security.CustomerAccessControlListCollection _ACLs)
		{
			_Customer.Reload();
			_Customer.ACLs = _ACLs;
			_Customer.Update();
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.Customer model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("f5e92cf3-27ba-a5eb-94a9-41599c622743")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class Customer : ICustomer, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<ICustomerService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<ICustomerService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<ICustomerService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Customer"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.Customer"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.Customer.ProviderType");
				
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

		bool _PartnerIsLoaded = false;
		Services.Packages.Customer _Partner;
		System.String _Partner_Name; 
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Customer Partner
		{
            get
            {
				if (!_PartnerIsLoaded)
				{
					_Partner = new Services.Packages.Customer(_Partner_Name);
					if (_Partner.Exists)
						_PartnerIsLoaded = true;
					else _Partner = null;
				}
                return _Partner;
            }
            set
            {
                _Partner = value;
                _PartnerIsLoaded = true;
                if (_Partner != null)
                {
					if (_Partner.Exists)
					{
						_Partner_Name = _Partner.Name;
						
					}
					else
					{
						_Partner = null;
					}
				}
            }
		}
		
		public static Services.Packages.Customer GetPartner(Customer _Customer)
		{
			return _Customer.Partner;
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
		
		public static Services.Packages.Security.ModelUser GetOwner(Customer _Customer)
		{
			return _Customer.Owner;
		}

		public static CustomerCollection GetByPartner(Services.Packages.Customer _Customer)
        {
			CustomerCollection _CustomerCollection = new CustomerCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuGetByPa", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Name;
				if (_Customer != null) {
				param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 256);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Customer.Name);
				} else {
				param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", DBNull.Value);
				}
				command.Parameters.Add(param_Name);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					Customer o = new Customer();
                
					o.__databaseState = RowState.Initialized;
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
				o._PartnerIsLoaded = false; if (dr["Partner_Name"] == DBNull.Value) { o._Partner = null; o._PartnerIsLoaded = true; }  else o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerCollection;
        }
        
        public static CustomerCollection GetByPartnerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
        {
			CustomerCollection _CustomerCollection = new CustomerCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuGetByPaPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Name;
				if (_Customer != null) {
				param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 256);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Customer.Name);
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
					Customer o = new Customer();
                
					o.__databaseState = RowState.Initialized;
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
				o._PartnerIsLoaded = false; if (dr["Partner_Name"] == DBNull.Value) { o._Partner = null; o._PartnerIsLoaded = true; }  else o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerCollection;
        }
        
        public static long GetByPartnerCount(Services.Packages.Customer _Customer)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuGetByPaCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                DbParameter param_Name;
				if (_Customer != null) {
				param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 256);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Customer.Name);
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

		public static CustomerCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
        {
			CustomerCollection _CustomerCollection = new CustomerCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuGetByOw", dbconn);
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
					Customer o = new Customer();
                
					o.__databaseState = RowState.Initialized;
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
				o._PartnerIsLoaded = false; if (dr["Partner_Name"] == DBNull.Value) { o._Partner = null; o._PartnerIsLoaded = true; }  else o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerCollection;
        }
        
        public static CustomerCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			CustomerCollection _CustomerCollection = new CustomerCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuGetByOwPaged", dbconn);
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
					Customer o = new Customer();
                
					o.__databaseState = RowState.Initialized;
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
				o._PartnerIsLoaded = false; if (dr["Partner_Name"] == DBNull.Value) { o._Partner = null; o._PartnerIsLoaded = true; }  else o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerCollection;
        }
        
        public static long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuGetByOwCount", dbconn);
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

		public static CustomerCollection SearchByNameAndPartner(System.String _Name, System.Boolean _IsPartner)
        {
			CustomerCollection _CustomerCollection = new CustomerCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuSeByNaAnPa", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_IsPartner = ClassConnectionProvider.GetDatabaseParameter("IsPartner", typeof(System.Boolean), -1);
				param_IsPartner.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsPartner);
				command.Parameters.Add(param_IsPartner);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					Customer o = new Customer();
                
					o.__databaseState = RowState.Initialized;
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
				o._PartnerIsLoaded = false; if (dr["Partner_Name"] == DBNull.Value) { o._Partner = null; o._PartnerIsLoaded = true; }  else o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerCollection;
        }
        
        public static CustomerCollection SearchByNameAndPartnerPaged(System.String _Name, System.Boolean _IsPartner, long PagingStart, long PagingCount)
        {
			CustomerCollection _CustomerCollection = new CustomerCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuSeByNaAnPaPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_IsPartner = ClassConnectionProvider.GetDatabaseParameter("IsPartner", typeof(System.Boolean), -1);
				param_IsPartner.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsPartner);
				command.Parameters.Add(param_IsPartner);
				
                
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
					Customer o = new Customer();
                
					o.__databaseState = RowState.Initialized;
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
				o._PartnerIsLoaded = false; if (dr["Partner_Name"] == DBNull.Value) { o._Partner = null; o._PartnerIsLoaded = true; }  else o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerCollection;
        }
        
        public static long SearchByNameAndPartnerCount(System.String _Name, System.Boolean _IsPartner)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuSeByNaAnPaCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_IsPartner = ClassConnectionProvider.GetDatabaseParameter("IsPartner", typeof(System.Boolean), -1);
				param_IsPartner.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsPartner);
				command.Parameters.Add(param_IsPartner);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		public static CustomerCollection SearchByName(System.String _Name)
        {
			CustomerCollection _CustomerCollection = new CustomerCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuSeByNa", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					Customer o = new Customer();
                
					o.__databaseState = RowState.Initialized;
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
				o._PartnerIsLoaded = false; if (dr["Partner_Name"] == DBNull.Value) { o._Partner = null; o._PartnerIsLoaded = true; }  else o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerCollection;
        }
        
        public static CustomerCollection SearchByNamePaged(System.String _Name, long PagingStart, long PagingCount)
        {
			CustomerCollection _CustomerCollection = new CustomerCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuSeByNaPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
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
					Customer o = new Customer();
                
					o.__databaseState = RowState.Initialized;
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
				o._PartnerIsLoaded = false; if (dr["Partner_Name"] == DBNull.Value) { o._Partner = null; o._PartnerIsLoaded = true; }  else o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerCollection;
        }
        
        public static long SearchByNameCount(System.String _Name)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuSeByNaCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		public static CustomerCollection SearchByNameAndPartnerPayment(System.String _Name, System.Boolean _IsPaymentAccepted)
        {
			CustomerCollection _CustomerCollection = new CustomerCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuSeByNaAnPaPa", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_IsPaymentAccepted = ClassConnectionProvider.GetDatabaseParameter("IsPaymentAccepted", typeof(System.Boolean), -1);
				param_IsPaymentAccepted.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsPaymentAccepted);
				command.Parameters.Add(param_IsPaymentAccepted);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					Customer o = new Customer();
                
					o.__databaseState = RowState.Initialized;
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
				o._PartnerIsLoaded = false; if (dr["Partner_Name"] == DBNull.Value) { o._Partner = null; o._PartnerIsLoaded = true; }  else o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerCollection;
        }
        
        public static CustomerCollection SearchByNameAndPartnerPaymentPaged(System.String _Name, System.Boolean _IsPaymentAccepted, long PagingStart, long PagingCount)
        {
			CustomerCollection _CustomerCollection = new CustomerCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuSeByNaAnPaPaPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_IsPaymentAccepted = ClassConnectionProvider.GetDatabaseParameter("IsPaymentAccepted", typeof(System.Boolean), -1);
				param_IsPaymentAccepted.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsPaymentAccepted);
				command.Parameters.Add(param_IsPaymentAccepted);
				
                
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
					Customer o = new Customer();
                
					o.__databaseState = RowState.Initialized;
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
				o._PartnerIsLoaded = false; if (dr["Partner_Name"] == DBNull.Value) { o._Partner = null; o._PartnerIsLoaded = true; }  else o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerCollection;
        }
        
        public static long SearchByNameAndPartnerPaymentCount(System.String _Name, System.Boolean _IsPaymentAccepted)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuSeByNaAnPaPaCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_IsPaymentAccepted = ClassConnectionProvider.GetDatabaseParameter("IsPaymentAccepted", typeof(System.Boolean), -1);
				param_IsPaymentAccepted.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsPaymentAccepted);
				command.Parameters.Add(param_IsPaymentAccepted);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		public static CustomerCollection SearchByNameOnPartners(System.String _Name, Services.Packages.Customer _Customer)
        {
			CustomerCollection _CustomerCollection = new CustomerCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuSeByNaOnPa", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_Customer_Name;
				if (_Customer != null) {
				param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("CuNa", typeof(System.String), 256);
				param_Customer_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Customer.Name);
				} else {
				param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("CuNa", DBNull.Value);
				}
				command.Parameters.Add(param_Customer_Name);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					Customer o = new Customer();
                
					o.__databaseState = RowState.Initialized;
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
				o._PartnerIsLoaded = false; if (dr["Partner_Name"] == DBNull.Value) { o._Partner = null; o._PartnerIsLoaded = true; }  else o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerCollection;
        }
        
        public static CustomerCollection SearchByNameOnPartnersPaged(System.String _Name, Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
        {
			CustomerCollection _CustomerCollection = new CustomerCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuSeByNaOnPaPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_Customer_Name;
				if (_Customer != null) {
				param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("CuNa", typeof(System.String), 256);
				param_Customer_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Customer.Name);
				} else {
				param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("CuNa", DBNull.Value);
				}
				command.Parameters.Add(param_Customer_Name);
				
                
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
					Customer o = new Customer();
                
					o.__databaseState = RowState.Initialized;
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
				o._PartnerIsLoaded = false; if (dr["Partner_Name"] == DBNull.Value) { o._Partner = null; o._PartnerIsLoaded = true; }  else o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerCollection;
        }
        
        public static long SearchByNameOnPartnersCount(System.String _Name, Services.Packages.Customer _Customer)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuSeByNaOnPaCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_Customer_Name;
				if (_Customer != null) {
				param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("CuNa", typeof(System.String), 256);
				param_Customer_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Customer.Name);
				} else {
				param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("CuNa", DBNull.Value);
				}
				command.Parameters.Add(param_Customer_Name);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		public static CustomerCollection SearchByNameAndPaymentOnPartners(System.String _Name, System.Boolean _IsPaymentAccepted, Services.Packages.Customer _Customer)
        {
			CustomerCollection _CustomerCollection = new CustomerCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuSeByNaAnPaOnPa", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_IsPaymentAccepted = ClassConnectionProvider.GetDatabaseParameter("IsPaymentAccepted", typeof(System.Boolean), -1);
				param_IsPaymentAccepted.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsPaymentAccepted);
				command.Parameters.Add(param_IsPaymentAccepted);
				DbParameter param_Customer_Name;
				if (_Customer != null) {
				param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("CuNa", typeof(System.String), 256);
				param_Customer_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Customer.Name);
				} else {
				param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("CuNa", DBNull.Value);
				}
				command.Parameters.Add(param_Customer_Name);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					Customer o = new Customer();
                
					o.__databaseState = RowState.Initialized;
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
				o._PartnerIsLoaded = false; if (dr["Partner_Name"] == DBNull.Value) { o._Partner = null; o._PartnerIsLoaded = true; }  else o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerCollection.Add(o);
                }

                dr.Close();
            }
            
            return _CustomerCollection;
        }
        
        public static CustomerCollection SearchByNameAndPaymentOnPartnersPaged(System.String _Name, System.Boolean _IsPaymentAccepted, Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
        {
			CustomerCollection _CustomerCollection = new CustomerCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuSeByNaAnPaOnPaPaged", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_IsPaymentAccepted = ClassConnectionProvider.GetDatabaseParameter("IsPaymentAccepted", typeof(System.Boolean), -1);
				param_IsPaymentAccepted.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsPaymentAccepted);
				command.Parameters.Add(param_IsPaymentAccepted);
				DbParameter param_Customer_Name;
				if (_Customer != null) {
				param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("CuNa", typeof(System.String), 256);
				param_Customer_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Customer.Name);
				} else {
				param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("CuNa", DBNull.Value);
				}
				command.Parameters.Add(param_Customer_Name);
				
                
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
					Customer o = new Customer();
                
					o.__databaseState = RowState.Initialized;
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
				o._PartnerIsLoaded = false; if (dr["Partner_Name"] == DBNull.Value) { o._Partner = null; o._PartnerIsLoaded = true; }  else o._Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _CustomerCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _CustomerCollection;
        }
        
        public static long SearchByNameAndPaymentOnPartnersCount(System.String _Name, System.Boolean _IsPaymentAccepted, Services.Packages.Customer _Customer)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("CuSeByNaAnPaOnPaCount", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                _Name = ClassConnectionProvider.Escape(_Name);
				
                
                DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), -1);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				DbParameter param_IsPaymentAccepted = ClassConnectionProvider.GetDatabaseParameter("IsPaymentAccepted", typeof(System.Boolean), -1);
				param_IsPaymentAccepted.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsPaymentAccepted);
				command.Parameters.Add(param_IsPaymentAccepted);
				DbParameter param_Customer_Name;
				if (_Customer != null) {
				param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("CuNa", typeof(System.String), 256);
				param_Customer_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Customer.Name);
				} else {
				param_Customer_Name = ClassConnectionProvider.GetDatabaseParameter("CuNa", DBNull.Value);
				}
				command.Parameters.Add(param_Customer_Name);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                count = (int)command.ExecuteScalar();
                
                if (count < 0) count = 0;
            }
            
            return count;
        }

		Services.Packages.ApiKeyCollection _LicensesIssued;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.ApiKeyCollection LicensesIssued
		{
            get
            {
				if (_LicensesIssued == null)
					_LicensesIssued = Services.Packages.ApiKey.GetByCustomer(this);
				
				return _LicensesIssued;
            }
            set
            {
				if (this.Exists)
				{
					if (_LicensesIssued != null)
					{
						for(int n = 0; n < _LicensesIssued.Count; ++n)
						{
							_LicensesIssued[n].Customer = null;
							_LicensesIssued[n].Update();
						}
					}
	                
					_LicensesIssued = value;
					
					if (_LicensesIssued != null)
					{
						for(int n = 0; n < _LicensesIssued.Count; ++n)
						{
							_LicensesIssued[n].Customer = this;
							_LicensesIssued[n].Create();
						}
					}
				}
				else
				{
					_LicensesIssued = value;
				}
            }
		}
		
		public void ReloadLicensesIssued()
		{
			_LicensesIssued = Services.Packages.ApiKey.GetByCustomer(this);
		}

		public Services.Packages.ApiKeyCollection SearchByCompanyInfoOnCustomer(System.String CompanyInfo)
		{
			return Services.Packages.ApiKey.SearchByCompanyInfoOnCustomer(CompanyInfo,  this);
		}

		Services.Packages.CustomerCollection _PartnerCustomers;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.CustomerCollection PartnerCustomers
		{
            get
            {
				if (_PartnerCustomers == null)
					_PartnerCustomers = Services.Packages.Customer.GetByPartner(this);
				
				return _PartnerCustomers;
            }
            set
            {
				if (this.Exists)
				{
					if (_PartnerCustomers != null)
					{
						for(int n = 0; n < _PartnerCustomers.Count; ++n)
						{
							_PartnerCustomers[n].Partner = null;
							_PartnerCustomers[n].Update();
						}
					}
	                
					_PartnerCustomers = value;
					
					if (_PartnerCustomers != null)
					{
						for(int n = 0; n < _PartnerCustomers.Count; ++n)
						{
							_PartnerCustomers[n].Partner = this;
							_PartnerCustomers[n].Create();
						}
					}
				}
				else
				{
					_PartnerCustomers = value;
				}
            }
		}
		
		public void ReloadPartnerCustomers()
		{
			_PartnerCustomers = Services.Packages.Customer.GetByPartner(this);
		}

		public Services.Packages.CustomerCollection SearchByNameOnPartners(System.String Name)
		{
			return Services.Packages.Customer.SearchByNameOnPartners(Name,  this);
		}

		public Services.Packages.CustomerCollection SearchByNameAndPaymentOnPartners(System.String Name, System.Boolean IsPaymentAccepted)
		{
			return Services.Packages.Customer.SearchByNameAndPaymentOnPartners(Name, IsPaymentAccepted,  this);
		}

		Services.Packages.CustomerUserEntryCollection _CustomerUserEntries;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.CustomerUserEntryCollection CustomerUserEntries
		{
            get
            {
				if (_CustomerUserEntries == null)
					_CustomerUserEntries = Services.Packages.CustomerUserEntry.GetByCustomer(this);
				
				return _CustomerUserEntries;
            }
            set
            {
				if (this.Exists)
				{
					if (_CustomerUserEntries != null)
					{
						for(int n = 0; n < _CustomerUserEntries.Count; ++n)
						{
							_CustomerUserEntries[n].Customer = null;
							_CustomerUserEntries[n].Update();
						}
					}
	                
					_CustomerUserEntries = value;
					
					if (_CustomerUserEntries != null)
					{
						for(int n = 0; n < _CustomerUserEntries.Count; ++n)
						{
							_CustomerUserEntries[n].Customer = this;
							_CustomerUserEntries[n].Create();
						}
					}
				}
				else
				{
					_CustomerUserEntries = value;
				}
            }
		}
		
		public void ReloadCustomerUserEntries()
		{
			_CustomerUserEntries = Services.Packages.CustomerUserEntry.GetByCustomer(this);
		}

		Services.Packages.Security.CustomerAccessControlListCollection _ACLs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.CustomerAccessControlListCollection ACLs
		{
            get
            {
				if (_ACLs == null)
					_ACLs = Services.Packages.Security.CustomerAccessControlList.GetByCustomer(this);
				
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
							_ACLs[n].Customer = null;
							_ACLs[n].Update();
						}
					}
	                
					_ACLs = value;
					
					if (_ACLs != null)
					{
						for(int n = 0; n < _ACLs.Count; ++n)
						{
							_ACLs[n].Customer = this;
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
			_ACLs = Services.Packages.Security.CustomerAccessControlList.GetByCustomer(this);
		}

		public Services.Packages.Security.CustomerAccessControlListCollection GetACLs(System.String UserName)
		{
			return Services.Packages.Security.CustomerAccessControlList.GetACLs(UserName,  this);
		}

		public bool Exists
        {
            get {
				if (!__hasBeenReadOnce)
					Exist();
				
				return __databaseState == RowState.Initialized;
			}
        }
        
        public Customer() {}
        
        public Customer(System.String __Name)
        {
			Read(__Name);
        }
        
        #region CRUD
        
        void Exist()
        {
			// sql read - should be changed to specific exist implementation
			using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
			{
				dbconn.Open();
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuRead", dbconn);
				command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
				DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 256);
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
        
        public void Read(System.String __Name)
        {
			if (scalingServices != null)
            {
                // Forwarding can be used in any scenario (read & write)
                if (scalingServices.Count == 1)
				{
                    scalingServices[0].Read(__Name);
					return;
				}

                // Get a service via an algorithm
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "Cu");
                // Perfect for read operations, but not for write
                // scalingServices[nextIndex].Read(__Name);
				// return;

				throw new NotImplementedException();
            }

            try
            {
				// sql read
				using (DbConnection dbconn = InstanceConnectionProvider.GetDatabaseConnection(ConnectionString))
				{
					dbconn.Open();
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					_Name = __Name;
				DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 256);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(__Name);
				command.Parameters.Add(param_Name);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
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
				_PartnerIsLoaded = false; if (dr["Partner_Name"] == DBNull.Value) { _Partner = null; _PartnerIsLoaded = true; }  else _Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
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
                            failoverServices[n].Read(__Name);
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "Cu");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 256);
				param_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Name);
				command.Parameters.Add(param_Name);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
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
				_PartnerIsLoaded = false; if (dr["Partner_Name"] == DBNull.Value) { _Partner = null; _PartnerIsLoaded = true; }  else _Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
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
				DbParameter param_Partner_Name = ClassConnectionProvider.GetDatabaseParameter("Partner_Name", typeof(System.String), 256);
				param_Partner_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Partner_Name);
				if (_Partner == null) param_Partner_Name.Value = DBNull.Value;
				else param_Partner_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Partner.Name);
				command.Parameters.Add(param_Partner_Name);
				DbParameter param_Owner_Name = ClassConnectionProvider.GetDatabaseParameter("Owner_Name", typeof(System.String), 128);
				param_Owner_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Owner_Name);
				if (_Owner == null) param_Owner_Name.Value = DBNull.Value;
				else param_Owner_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Owner.Name);
				command.Parameters.Add(param_Owner_Name);
				
                
						InstanceConnectionProvider.OnBeforeExecuted(command);

						DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

						if (dr.Read())
						{
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
				_PartnerIsLoaded = false; if (dr["Partner_Name"] == DBNull.Value) { _Partner = null; _PartnerIsLoaded = true; }  else _Partner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Partner_Name"], typeof(System.String));
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
        
        static public Customer CreateCustomer(System.String __Name)
        {
            Customer o = new Customer(__Name);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
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
				DbParameter param_PartnerHasChanged = ClassConnectionProvider.GetDatabaseParameter("PartnerHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_PartnerIsLoaded));
				command.Parameters.Add(param_PartnerHasChanged);
				DbParameter param_Partner_Name = ClassConnectionProvider.GetDatabaseParameter("Partner_Name", typeof(System.String), 256);
				param_Partner_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Partner_Name);
				if (_Partner == null) param_Partner_Name.Value = DBNull.Value;
				else param_Partner_Name.Value = ClassConnectionProvider.FromValueToSqlModelType(_Partner.Name);
				command.Parameters.Add(param_Partner_Name);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("CuDelete", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Name = ClassConnectionProvider.GetDatabaseParameter("Name", typeof(System.String), 256);
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
        
        static public void DeleteCustomer(System.String __Name)
        {
            Customer o = new Customer(__Name);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(Customer _object)
        {
			_Partner = null;
			_PartnerIsLoaded = false;
			_Owner = null;
			_OwnerIsLoaded = false;
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
			
        }
        
        public void CopyWithKeysTo(Customer _object)
        {
			_object._Partner = null;
			_object._PartnerIsLoaded = false;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
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
			
        }
        
        static public void CopyWithKeysObject(Customer _objectFrom, Customer _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(Customer _object)
        {
			_Partner = null;
			_PartnerIsLoaded = false;
			_Owner = null;
			_OwnerIsLoaded = false;
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
			
        }
        
        public void CopyTo(Customer _object)
        {
			_object._Partner = null;
			_object._PartnerIsLoaded = false;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
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
			
        }
        
        static public void CopyObject(Customer _objectFrom, Customer _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(Customer).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(Customer).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(Customer _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			CustomerUndoRedoCollection allUndidAndNotRedoneEntries = CustomerUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			CustomerUndoRedo _urobject = new CustomerUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.Partner_Name = _object._Partner_Name;
			_urobject.Owner_Name = _object._Owner_Name;
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
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(Customer).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = CustomerUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				CustomerUndoRedoCollection allOldUndoEntries = CustomerUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			CustomerUndoRedoCollection firstUndoEntries = CustomerUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			CustomerUndoRedo _urobject = firstUndoEntries[0];
			
			Customer _object = new Customer();
			_object._Partner = null;
			_object._PartnerIsLoaded = false;
			_object._Partner_Name = _urobject.Partner_Name;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Owner_Name = _urobject.Owner_Name;
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
			CustomerUndoRedoCollection firstEntryToRedoEntries = CustomerUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			CustomerUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			Customer _object = new Customer();
			_object._Partner = null;
			_object._PartnerIsLoaded = false;
			_object._Partner_Name = _urobject.Partner_Name;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Owner_Name = _urobject.Owner_Name;
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
    /// Defines the contract for the CustomerCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("6444a3e9-08e9-1458-26e1-a39f3bf4b236")]
    public interface ICustomerCollection : IEnumerable<Customer>
    {
        int IndexOf(Customer item);
        void Insert(int index, Customer item);
        void RemoveAt(int index);
        Customer this[int index] { get; set; }
        void Add(Customer item);
        void Clear();
        bool Contains(Customer item);
        void CopyTo(Customer[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(Customer item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.Customer
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("fd3cccbd-47ba-af3b-2e17-50f3cee1d62c")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class CustomerCollection : ICustomerCollection, IList<Customer>, IHierarchicalEnumerable
    {
        List<Customer> _list = new List<Customer>();
        
        public static implicit operator List<Customer>(CustomerCollection collection)
        {
            return collection._list;
        }

        #region IList<Customer> Members

        public int IndexOf(Customer item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, Customer item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public Customer this[int index]
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

        #region ICollection<Customer> Members

        public void Add(Customer item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(Customer item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(Customer[] array, int arrayIndex)
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

        public bool Remove(Customer item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<Customer> Members

        public IEnumerator<Customer> GetEnumerator()
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
	/// that share Services.Packages.Customer objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Web.CustomerWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class CustomerWebService : WebService, ICustomerService
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
        public bool Exists(Customer _Customer)
        {
			return _Customer.Exists;
        }
		
		[WebMethod]
		public Customer Read(System.String __Name)
		{
			return new Customer(__Name);
		}
		
		[WebMethod]
        public Customer Reload(Customer _Customer)
        {
			_Customer.Reload();
			return _Customer;
        }
		
		[WebMethod]
        public Customer Create(System.String __Name)
        {
			return Customer.CreateCustomer(__Name);
        }
        
        [WebMethod]
        public void Delete(System.String __Name)
        {
			Customer.DeleteCustomer(__Name);
        }
        
        [WebMethod]
        public void UpdateObject(Customer _Customer)
        {
			_Customer.Update();
        }
		
		[WebMethod]
        public void CreateObject(Customer _Customer)
        {
			_Customer.Create();
        }
        
        [WebMethod]
        public void DeleteObject(Customer _Customer)
        {
			_Customer.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			Customer.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			Customer.Redo();
        }
		[WebMethod]
		public CustomerCollection GetByPartner(Services.Packages.Customer _Customer)
		{
			return Customer.GetByPartner( _Customer);
		}
		[WebMethod]
		public CustomerCollection GetByPartnerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
		{
			return Customer.GetByPartnerPaged( _Customer, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByPartnerCount(Services.Packages.Customer _Customer)
		{
			return Customer.GetByPartnerCount( _Customer);
		}
		[WebMethod]
		public Services.Packages.Customer GetPartner(Customer _Customer)
		{
			_Customer.Reload();
			return _Customer.Partner;
		}
		[WebMethod]
		public void SetPartner(Customer _Customer, Services.Packages.Customer _Partner)
		{
			_Customer.Reload();
			_Customer.Partner = _Partner;
			_Customer.Update();
		}
		[WebMethod]
		public CustomerCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
		{
			return Customer.GetByOwner( _ModelUser);
		}
		[WebMethod]
		public CustomerCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return Customer.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return Customer.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(Customer _Customer)
		{
			_Customer.Reload();
			return _Customer.Owner;
		}
		[WebMethod]
		public void SetOwner(Customer _Customer, Services.Packages.Security.ModelUser _Owner)
		{
			_Customer.Reload();
			_Customer.Owner = _Owner;
			_Customer.Update();
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPartner(System.String Name, System.Boolean IsPartner )
		{
			return Customer.SearchByNameAndPartner(Name, IsPartner );
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPartnerPaged(System.String Name, System.Boolean IsPartner , long PagingStart, long PagingCount)
		{
			return Customer.SearchByNameAndPartnerPaged(Name, IsPartner , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByNameAndPartnerCount(System.String Name, System.Boolean IsPartner )
		{
			return Customer.SearchByNameAndPartnerCount(Name, IsPartner );
		}
		[WebMethod]
		public CustomerCollection SearchByName(System.String Name )
		{
			return Customer.SearchByName(Name );
		}
		[WebMethod]
		public CustomerCollection SearchByNamePaged(System.String Name , long PagingStart, long PagingCount)
		{
			return Customer.SearchByNamePaged(Name , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByNameCount(System.String Name )
		{
			return Customer.SearchByNameCount(Name );
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPartnerPayment(System.String Name, System.Boolean IsPaymentAccepted )
		{
			return Customer.SearchByNameAndPartnerPayment(Name, IsPaymentAccepted );
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPartnerPaymentPaged(System.String Name, System.Boolean IsPaymentAccepted , long PagingStart, long PagingCount)
		{
			return Customer.SearchByNameAndPartnerPaymentPaged(Name, IsPaymentAccepted , PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByNameAndPartnerPaymentCount(System.String Name, System.Boolean IsPaymentAccepted )
		{
			return Customer.SearchByNameAndPartnerPaymentCount(Name, IsPaymentAccepted );
		}
		[WebMethod]
		public CustomerCollection SearchByNameOnPartners(System.String Name, Services.Packages.Customer _Customer)
		{
			return Customer.SearchByNameOnPartners(Name,  _Customer);
		}
		[WebMethod]
		public CustomerCollection SearchByNameOnPartnersPaged(System.String Name, Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
		{
			return Customer.SearchByNameOnPartnersPaged(Name,  _Customer, PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByNameOnPartnersCount(System.String Name, Services.Packages.Customer _Customer)
		{
			return Customer.SearchByNameOnPartnersCount(Name,  _Customer);
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPaymentOnPartners(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer)
		{
			return Customer.SearchByNameAndPaymentOnPartners(Name, IsPaymentAccepted,  _Customer);
		}
		[WebMethod]
		public CustomerCollection SearchByNameAndPaymentOnPartnersPaged(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer, long PagingStart, long PagingCount)
		{
			return Customer.SearchByNameAndPaymentOnPartnersPaged(Name, IsPaymentAccepted,  _Customer, PagingStart, PagingCount);
		}
		[WebMethod]
		public long SearchByNameAndPaymentOnPartnersCount(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer)
		{
			return Customer.SearchByNameAndPaymentOnPartnersCount(Name, IsPaymentAccepted,  _Customer);
		}
		[WebMethod]
		public Services.Packages.ApiKeyCollection GetLicensesIssued(Customer _Customer)
		{
			_Customer.Reload();
			return _Customer.LicensesIssued;
		}
		[WebMethod]
		public void SetLicensesIssued(Customer _Customer, Services.Packages.ApiKeyCollection _LicensesIssued)
		{
			_Customer.Reload();
			_Customer.LicensesIssued = _LicensesIssued;
			_Customer.Update();
		}
		[WebMethod]
		public Services.Packages.CustomerCollection GetPartnerCustomers(Customer _Customer)
		{
			_Customer.Reload();
			return _Customer.PartnerCustomers;
		}
		[WebMethod]
		public void SetPartnerCustomers(Customer _Customer, Services.Packages.CustomerCollection _PartnerCustomers)
		{
			_Customer.Reload();
			_Customer.PartnerCustomers = _PartnerCustomers;
			_Customer.Update();
		}
		[WebMethod]
		public Services.Packages.CustomerUserEntryCollection GetCustomerUserEntries(Customer _Customer)
		{
			_Customer.Reload();
			return _Customer.CustomerUserEntries;
		}
		[WebMethod]
		public void SetCustomerUserEntries(Customer _Customer, Services.Packages.CustomerUserEntryCollection _CustomerUserEntries)
		{
			_Customer.Reload();
			_Customer.CustomerUserEntries = _CustomerUserEntries;
			_Customer.Update();
		}
		[WebMethod]
		public Services.Packages.Security.CustomerAccessControlListCollection GetACLs(Customer _Customer)
		{
			_Customer.Reload();
			return _Customer.ACLs;
		}
		[WebMethod]
		public void SetACLs(Customer _Customer, Services.Packages.Security.CustomerAccessControlListCollection _ACLs)
		{
			_Customer.Reload();
			_Customer.ACLs = _ACLs;
			_Customer.Update();
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="CustomerWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("3285c5f0-4ef2-ebe6-d4d5-ced8844b699f")]
    sealed public class CustomerWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, ICustomerService
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
		public CustomerWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public CustomerWebServiceClient()
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
		public bool Exists(Customer _Customer)
        {
			object[] results = this.Invoke("Exists", new object[] {_Customer});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Customer Read(System.String __Name)
		{
			object[] results = this.Invoke("Read", new object[] {__Name});
			return ((Customer)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Customer Reload(Customer _Customer)
        {
			object[] results = this.Invoke("Reload", new object[] {_Customer});
			return ((Customer)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Customer Create(System.String __Name)
        {
			object[] results = this.Invoke("Create", new object[] {__Name});
			return ((Customer)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.String __Name)
        {
			this.Invoke("Delete", new object[] {__Name});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(Customer _Customer)
        {
			this.Invoke("UpdateObject", new object[] {_Customer});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(Customer _Customer)
        {
			this.Invoke("CreateObject", new object[] {_Customer});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(Customer _Customer)
        {
			this.Invoke("DeleteObject", new object[] {_Customer});
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
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByPartner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection GetByPartner(Services.Packages.Customer _Customer) {
			object[] results = this.Invoke("GetByPartner", new object[] {_Customer});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByPartnerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection GetByPartnerPaged(Services.Packages.Customer _Customer, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByPartnerPaged", new object[] {_Customer,PagingStart,PagingCount});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByPartnerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByPartnerCount(Services.Packages.Customer _Customer) {
			object[] results = this.Invoke("GetByPartnerCount", new object[] {_Customer});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPartner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Customer GetPartner(Customer _Customer)
		{
			object[] results = this.Invoke("GetPartner", new object[] {_Customer});
			return ((Services.Packages.Customer)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPartner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPartner(Customer _Customer, Services.Packages.Customer _Partner)
		{
			this.Invoke("GetPartner", new object[] {_Customer});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByOwner", new object[] {_ModelUser});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByOwnerPaged", new object[] {_ModelUser,PagingStart,PagingCount});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByOwnerCount", new object[] {_ModelUser});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetOwner(Customer _Customer)
		{
			object[] results = this.Invoke("GetOwner", new object[] {_Customer});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetOwner(Customer _Customer, Services.Packages.Security.ModelUser _Owner)
		{
			this.Invoke("GetOwner", new object[] {_Customer});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameAndPartner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection SearchByNameAndPartner(System.String Name, System.Boolean IsPartner ) {
			object[] results = this.Invoke("SearchByNameAndPartner", new object[] {Name, IsPartner});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameAndPartnerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection SearchByNameAndPartnerPaged(System.String Name, System.Boolean IsPartner , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("SearchByNameAndPartnerPaged", new object[] {Name, IsPartner,PagingStart,PagingCount});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameAndPartnerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByNameAndPartnerCount(System.String Name, System.Boolean IsPartner ) {
			object[] results = this.Invoke("SearchByNameAndPartnerCount", new object[] {Name, IsPartner});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByName", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection SearchByName(System.String Name ) {
			object[] results = this.Invoke("SearchByName", new object[] {Name});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNamePaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection SearchByNamePaged(System.String Name , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("SearchByNamePaged", new object[] {Name,PagingStart,PagingCount});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByNameCount(System.String Name ) {
			object[] results = this.Invoke("SearchByNameCount", new object[] {Name});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameAndPartnerPayment", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection SearchByNameAndPartnerPayment(System.String Name, System.Boolean IsPaymentAccepted ) {
			object[] results = this.Invoke("SearchByNameAndPartnerPayment", new object[] {Name, IsPaymentAccepted});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameAndPartnerPaymentPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection SearchByNameAndPartnerPaymentPaged(System.String Name, System.Boolean IsPaymentAccepted , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("SearchByNameAndPartnerPaymentPaged", new object[] {Name, IsPaymentAccepted,PagingStart,PagingCount});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameAndPartnerPaymentCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByNameAndPartnerPaymentCount(System.String Name, System.Boolean IsPaymentAccepted ) {
			object[] results = this.Invoke("SearchByNameAndPartnerPaymentCount", new object[] {Name, IsPaymentAccepted});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameOnPartners", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection SearchByNameOnPartners(System.String Name, Services.Packages.Customer _Customer) {
			object[] results = this.Invoke("SearchByNameOnPartners", new object[] {Name, _Customer});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameOnPartnersPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection SearchByNameOnPartnersPaged(System.String Name, Services.Packages.Customer _Customer, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("SearchByNameOnPartnersPaged", new object[] {Name, _Customer,PagingStart,PagingCount});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameOnPartnersCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByNameOnPartnersCount(System.String Name, Services.Packages.Customer _Customer) {
			object[] results = this.Invoke("SearchByNameOnPartnersCount", new object[] {Name, _Customer});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameAndPaymentOnPartners", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection SearchByNameAndPaymentOnPartners(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer) {
			object[] results = this.Invoke("SearchByNameAndPaymentOnPartners", new object[] {Name, IsPaymentAccepted, _Customer});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameAndPaymentOnPartnersPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public CustomerCollection SearchByNameAndPaymentOnPartnersPaged(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("SearchByNameAndPaymentOnPartnersPaged", new object[] {Name, IsPaymentAccepted, _Customer,PagingStart,PagingCount});
			return ((CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SearchByNameAndPaymentOnPartnersCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long SearchByNameAndPaymentOnPartnersCount(System.String Name, System.Boolean IsPaymentAccepted, Services.Packages.Customer _Customer) {
			object[] results = this.Invoke("SearchByNameAndPaymentOnPartnersCount", new object[] {Name, IsPaymentAccepted, _Customer});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetLicensesIssued", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.ApiKeyCollection GetLicensesIssued(Customer _Customer)
		{
			object[] results = this.Invoke("GetLicensesIssued", new object[] {_Customer});
			return ((Services.Packages.ApiKeyCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetLicensesIssued", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetLicensesIssued(Customer _Customer, Services.Packages.ApiKeyCollection _LicensesIssued)
		{
			this.Invoke("GetLicensesIssued", new object[] {_Customer});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPartnerCustomers", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.CustomerCollection GetPartnerCustomers(Customer _Customer)
		{
			object[] results = this.Invoke("GetPartnerCustomers", new object[] {_Customer});
			return ((Services.Packages.CustomerCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPartnerCustomers", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPartnerCustomers(Customer _Customer, Services.Packages.CustomerCollection _PartnerCustomers)
		{
			this.Invoke("GetPartnerCustomers", new object[] {_Customer});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetCustomerUserEntries", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.CustomerUserEntryCollection GetCustomerUserEntries(Customer _Customer)
		{
			object[] results = this.Invoke("GetCustomerUserEntries", new object[] {_Customer});
			return ((Services.Packages.CustomerUserEntryCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetCustomerUserEntries", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetCustomerUserEntries(Customer _Customer, Services.Packages.CustomerUserEntryCollection _CustomerUserEntries)
		{
			this.Invoke("GetCustomerUserEntries", new object[] {_Customer});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.CustomerAccessControlListCollection GetACLs(Customer _Customer)
		{
			object[] results = this.Invoke("GetACLs", new object[] {_Customer});
			return ((Services.Packages.Security.CustomerAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACLs(Customer _Customer, Services.Packages.Security.CustomerAccessControlListCollection _ACLs)
		{
			this.Invoke("GetACLs", new object[] {_Customer});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages
