using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

/*
 * High performance automated object model
 * Created by an automatic tool
 * Defines the module Services.Packages
 * */

namespace Platform.Module
{	
    namespace Interop.Services.Packages
    {
        [ComVisible(true)]
        [Guid("a5f6399b-059a-cf0b-bab4-f4f9f4f364a7")]
        [InterfaceType(ComInterfaceType.InterfaceIsDual)]
        public interface ISqlConnection
        {
            string ConnectionString { get; set; }
        }

        [ClassInterface(ClassInterfaceType.None)]
        [Guid("94a850b6-ded3-f6f5-b859-8c1e79358f67")]
        [ComVisible(true)]
        public class SqlConnection : ISqlConnection
        {
            public string ConnectionString
            {
                get { return Platform.Module.Packages.ConnectionString; }
                set { Platform.Module.Packages.ModuleConnectionString = value; }
            }
        }
    }
    
    [System.Runtime.InteropServices.ComVisible(false)]
    public static class Packages
    {
		// IConfiguration
		static string moduleConnectionString = null;
		
		static public string ModuleConnectionString
        {
            get {
				if (!String.IsNullOrEmpty(moduleConnectionString))
					return moduleConnectionString;
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Platform.Module.Packages"] != null)
					moduleConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Platform.Module.Packages"].ConnectionString;
				
				return moduleConnectionString;
			}
			set
			{
				moduleConnectionString = value;
			}
        }
        
        static public string ConnectionString
        {
            get {
				if (!String.IsNullOrEmpty(ModuleConnectionString))
					return ModuleConnectionString;
				
				return Platform.Runtime.Sql.ConnectionString;
			}
        }
        
        static Platform.Runtime.SqlProviderType moduleSqlProviderType = Platform.Runtime.SqlProviderType.NotSpecified;
		
		static public Platform.Runtime.SqlProviderType ModuleSqlProviderType
        {
            get {
				if (moduleSqlProviderType != Platform.Runtime.SqlProviderType.NotSpecified)
					return moduleSqlProviderType;
				
				moduleSqlProviderType = Platform.Runtime.Sql.GetProviderConfiguration("Platform.Module.Packages.ProviderType");
				
				return moduleSqlProviderType;
			}
			set
			{
				moduleSqlProviderType = value;
			}
        }
        
        static public Platform.Runtime.SqlProviderType SqlProviderType
        {
            get {
				if (ModuleSqlProviderType != Platform.Runtime.SqlProviderType.NotSpecified)
					return ModuleSqlProviderType;
				
				return Platform.Runtime.Sql.GlobalProviderType;
			}
        }

		private static global::Platform.Runtime.IConnectionProvider moduleConnectionProvider;

		public static global::Platform.Runtime.IConnectionProvider ModuleConnectionProvider {
            get
            {
				if (String.IsNullOrEmpty(ModuleConnectionString)
					|| ModuleSqlProviderType == Platform.Runtime.SqlProviderType.NotSpecified)
					return null;

                if (moduleConnectionProvider == null)
                {
                    moduleConnectionProvider = Platform.Runtime.Sql.CreateProvider(ModuleSqlProviderType, ModuleConnectionString);
                }

                return moduleConnectionProvider;
            }
        }

		public static global::Platform.Runtime.IConnectionProvider ConnectionProvider {
            get
            {
				if (String.IsNullOrEmpty(ModuleConnectionString)
					|| ModuleSqlProviderType == Platform.Runtime.SqlProviderType.NotSpecified)
					return Platform.Runtime.Sql.GlobalConnectionProvider;

                return ModuleConnectionProvider;
            }
        }
		
        public const string Xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Platform module=\"Services.Packages\" uri=\"services.msd.com\"><Entities><!--\n\t\tServices.Packages model\n\t\t--><!-- Package --><Entity namespace=\"Services.Packages\" name=\"Package\" securable=\"true\" undoRedoable=\"false\"><Field name=\"Id\" type=\"System.Int32\" key=\"true\" sort=\"desc\" identity=\"true\" /><Field name=\"PackageName\" type=\"System.String\" size=\"1024\" /><Field name=\"VersionLabel\" type=\"System.String\" size=\"1024\" /><Field name=\"UploadDate\" type=\"System.DateTime\" /><Relation namespace=\"Services.Packages\" entity=\"ApiKey\" name=\"ApiKey\" parentName=\"PackagesUploaded\" /><Search name=\"SearchByPackageName\"><Field name=\"PackageName\" type=\"System.String\" /><Filter><Field name=\"PackageName\" /><Like /><Variable name=\"PackageName\" /></Filter><Order><Field name=\"UploadDate\" sort=\"desc\" /></Order></Search><RelatedSearch name=\"SearchByPackageNameForApiKey\" namespace=\"Services.Packages\" entity=\"ApiKey\"><Field name=\"PackageName\" type=\"System.String\" /><Filter><Field name=\"PackageName\" /><Like /><Variable name=\"PackageName\" /></Filter><Order><Field name=\"UploadDate\" sort=\"desc\" /></Order></RelatedSearch></Entity><Entity namespace=\"Services.Packages\" name=\"LocalPackage\" securable=\"false\" undoRedoable=\"false\"><Field name=\"PackageName\" type=\"System.String\" size=\"1024\" key=\"true\" /><Field name=\"Id\" type=\"System.Int32\" /><Field name=\"VersionLabel\" type=\"System.String\" size=\"1024\" /><Search name=\"SearchByPackageName\"><Field name=\"PackageName\" type=\"System.String\" /><Filter><Field name=\"PackageName\" /><Like /><Variable name=\"PackageName\" /></Filter></Search></Entity><!-- Licenses --><Entity namespace=\"Services.Packages\" name=\"ApiKey\" securable=\"true\" undoRedoable=\"false\"><Field name=\"Id\" type=\"System.Guid\" key=\"true\" sort=\"asc\" /><Field name=\"CompanyInfo\" type=\"System.String\" size=\"1024\" /><Field name=\"IssueDate\" type=\"System.DateTime\" /><Field name=\"FromDate\" type=\"System.DateTime\" /><Field name=\"ToDate\" type=\"System.DateTime\" /><Field name=\"IsTest\" type=\"System.Boolean\" /><Relation namespace=\"Services.Packages\" entity=\"Customer\" name=\"Customer\" parentName=\"LicensesIssued\" /><Search name=\"SearchByCompanyInfo\"><Field name=\"CompanyInfo\" type=\"System.String\" /><Filter><Field name=\"CompanyInfo\" /><Like /><Variable name=\"CompanyInfo\" /></Filter><Order><Field name=\"IssueDate\" sort=\"desc\" /></Order></Search><RelatedSearch name=\"SearchByCompanyInfoOnCustomer\" namespace=\"Services.Packages\" entity=\"Customer\"><Field name=\"CompanyInfo\" type=\"System.String\" /><Filter><Field name=\"CompanyInfo\" /><Like /><Variable name=\"CompanyInfo\" /></Filter><Order><Field name=\"IssueDate\" sort=\"desc\" /></Order></RelatedSearch></Entity><!-- Log --><Entity namespace=\"Services.Packages.Log\" name=\"ApplicationException\" securable=\"true\" undoRedoable=\"false\"><Field name=\"Id\" type=\"System.Int32\" key=\"true\" sort=\"asc\" identity=\"true\" /><Field name=\"Message\" type=\"System.String\" size=\"512\" /><Field name=\"Source\" type=\"System.String\" size=\"512\" /><Field name=\"StackTrace\" type=\"System.String\" /><Field name=\"Page\" type=\"System.String\" /><Field name=\"OnDate\" type=\"System.DateTime\" /><Field name=\"IsSolved\" type=\"System.Boolean\" /><Relation namespace=\"Services.Packages\" entity=\"ApiKey\" name=\"ApiKey\" parentName=\"ApplicationExceptionsLogged\" /><Relation namespace=\"Services.Packages.Log\" entity=\"ApplicationException\" name=\"ParentException\" parentName=\"InnerExceptions\" /><Search name=\"SearchByName\"><Field name=\"Message\" type=\"System.String\" /><Filter><Field name=\"Message\" /><Like /><Variable name=\"Message\" /></Filter><Order><Field name=\"OnDate\" sort=\"desc\" /></Order></Search><RelatedSearch name=\"SearchByNameOnApiKey\" namespace=\"Services.Packages\" entity=\"ApiKey\"><Field name=\"Message\" type=\"System.String\" /><Filter><Field name=\"Message\" /><Like /><Variable name=\"Message\" /></Filter><Order><Field name=\"OnDate\" sort=\"desc\" /></Order></RelatedSearch><Search name=\"SearchByNameSolved\"><Field name=\"Message\" type=\"System.String\" /><Field name=\"IsSolved\" type=\"System.Boolean\" /><Filter><Field name=\"Message\" /><Like /><Variable name=\"Message\" /><And /><Field name=\"IsSolved\" /><Equal /><Variable name=\"IsSolved\" /></Filter><Order><Field name=\"OnDate\" sort=\"desc\" /></Order></Search><RelatedSearch name=\"SearchByNameSolvedOnApiKey\" namespace=\"Services.Packages\" entity=\"ApiKey\"><Field name=\"Message\" type=\"System.String\" /><Field name=\"IsSolved\" type=\"System.Boolean\" /><Filter><Field name=\"Message\" /><Like /><Variable name=\"Message\" /><And /><Field name=\"IsSolved\" /><Equal /><Variable name=\"IsSolved\" /></Filter><Order><Field name=\"OnDate\" sort=\"desc\" /></Order></RelatedSearch></Entity><!-- Customer --><Entity namespace=\"Services.Packages\" name=\"Customer\" securable=\"true\"><Field name=\"Name\" type=\"System.String\" size=\"256\" sort=\"asc\" key=\"true\" /><!-- Info for customer --><Field name=\"FullNameOfResponsible\" type=\"System.String\" size=\"512\" /><Field name=\"EmailOfResponsible\" type=\"System.String\" size=\"256\" /><Field name=\"Description\" type=\"System.String\" size=\"256\" /><Field name=\"IsPartner\" type=\"System.Boolean\" /><Field name=\"CompanyName\" type=\"System.String\" size=\"256\" /><Field name=\"VATNo\" type=\"System.String\" size=\"256\" /><Field name=\"Phone\" type=\"System.String\" size=\"128\" /><Field name=\"Address\" type=\"System.String\" size=\"256\" /><Field name=\"PostCode\" type=\"System.String\" size=\"64\" /><Field name=\"City\" type=\"System.String\" size=\"128\" /><Field name=\"Country\" type=\"System.String\" size=\"256\" /><Field name=\"InvoiceAddress\" type=\"System.String\" size=\"256\" /><Field name=\"InvoicePostCode\" type=\"System.String\" size=\"64\" /><Field name=\"InvoiceCity\" type=\"System.String\" size=\"128\" /><Field name=\"InvoiceCountry\" type=\"System.String\" size=\"256\" /><Field name=\"IsPaymentAccepted\" type=\"System.Boolean\" /><Field name=\"LastPaymentDate\" type=\"System.DateTime\" /><Relation namespace=\"Services.Packages\" entity=\"Customer\" name=\"Partner\" parentName=\"PartnerCustomers\" /><Search name=\"SearchByNameAndPartner\"><Field name=\"Name\" type=\"System.String\" /><Field name=\"IsPartner\" type=\"System.Boolean\" /><Filter><Field name=\"Name\" /><Like /><Variable name=\"Name\" /><And /><Field name=\"IsPartner\" /><Like /><Variable name=\"IsPartner\" /></Filter><Order><Field name=\"Name\" sort=\"asc\" /></Order></Search><Search name=\"SearchByName\"><Field name=\"Name\" type=\"System.String\" /><Filter><Field name=\"Name\" /><Like /><Variable name=\"Name\" /></Filter><Order><Field name=\"Name\" sort=\"asc\" /></Order></Search><Search name=\"SearchByNameAndPartnerPayment\"><Field name=\"Name\" type=\"System.String\" /><Field name=\"IsPaymentAccepted\" type=\"System.Boolean\" /><Filter><Field name=\"Name\" /><Like /><Variable name=\"Name\" /><And /><Field name=\"IsPaymentAccepted\" /><Equal /><Variable name=\"IsPaymentAccepted\" /></Filter><Order><Field name=\"LastPaymentDate\" sort=\"asc\" /></Order></Search><RelatedSearch name=\"SearchByNameOnPartners\" namespace=\"Services.Packages\" entity=\"Customer\"><Field name=\"Name\" type=\"System.String\" /><Filter><Field name=\"Name\" /><Like /><Variable name=\"Name\" /></Filter><Order><Field name=\"IsPaymentAccepted\" sort=\"desc\" /><Field name=\"LastPaymentDate\" sort=\"asc\" /></Order></RelatedSearch><RelatedSearch name=\"SearchByNameAndPaymentOnPartners\" namespace=\"Services.Packages\" entity=\"Customer\"><Field name=\"Name\" type=\"System.String\" /><Field name=\"IsPaymentAccepted\" type=\"System.Boolean\" /><Filter><Field name=\"Name\" /><Like /><Variable name=\"Name\" /><And /><Field name=\"IsPaymentAccepted\" /><Equal /><Variable name=\"IsPaymentAccepted\" /></Filter><Order><Field name=\"LastPaymentDate\" sort=\"asc\" /></Order></RelatedSearch></Entity><Entity namespace=\"Services.Packages\" name=\"CustomerUserEntry\" securable=\"true\" undoRedoable=\"false\"><Field name=\"Id\" type=\"System.Int32\" key=\"true\" sort=\"asc\" identity=\"true\" /><Relation namespace=\"Services.Packages.Security\" entity=\"ModelUser\" name=\"UserLogin\" parentName=\"CustomerUserEntries\" /><Relation namespace=\"Services.Packages\" entity=\"Customer\" name=\"Customer\" parentName=\"CustomerUserEntries\" /></Entity><!-- Purchasing --><Entity namespace=\"Services.Packages\" name=\"Purchase\" securable=\"true\"><Field name=\"Id\" type=\"System.Int32\" key=\"true\" sort=\"desc\" identity=\"true\" /><Field name=\"CreationDate\" type=\"System.DateTime\" /><Relation namespace=\"Services.Packages\" entity=\"ApiKey\" name=\"ApiKey\" parentName=\"Orders\" /><Relation namespace=\"Services.Packages.Security\" entity=\"ModelUser\" name=\"Client\" parentName=\"Purchases\" /><Search name=\"GetAll\"><Field name=\"dummy\" type=\"System.String\" /></Search></Entity><Entity namespace=\"Services.Packages\" name=\"PurchaseLine\" securable=\"true\"><Field name=\"Id\" type=\"System.Int32\" key=\"true\" sort=\"asc\" identity=\"true\" /><Field name=\"ProductKey\" type=\"System.String\" size=\"256\" /><Field name=\"ProductDescription\" type=\"System.String\" /><Field name=\"PricePurchased\" type=\"System.Double\" /><Field name=\"RecurrentFeePurchased\" type=\"System.Double\" /><Field name=\"IsPaid\" type=\"System.Boolean\" /><Relation namespace=\"Services.Packages\" entity=\"Purchase\" name=\"PurchaseOrder\" parentName=\"OrderLines\" /></Entity></Entities></Platform>";
        
        // MS Sql Server code
        public const string SqlServerSql = "%sqlserver_sql";
        public const string SqlServerLogic = "%sqlserver_logic";
        public const string SqlServerUninstallLogic = "%sqlserver_uninstall_logic";
        public const string SqlServerAttachLogic = "%sqlserver_attach_logic";
        public const string SqlServerAttachDatabase = "%sqlserver_attach_db";
        public const string SqlServerInstallUpdateDecoupled = "%sqlserver_installupdatedecoupled_db";
        
        // MySql code
        public const string MySqlSql = "%mysql_sql";
        public const string MySqlLogic = "%mysql_logic";
        public const string MySqlUninstallLogic = "%mysql_uninstall_logic";
        public const string MySqlAttachLogic = "%mysql_attach_logic";
        public const string MySqlAttachDatabase = "%mysql_attach_db";
        public const string MySqlInstallUpdateDecoupled = "%mysql_installupdatedecoupled_db";
        
        // Oracle code
        public const string OracleSql = "%oracle_sql";
        public const string OracleLogic = "%oracle_logic";
        public const string OracleUninstallLogic = "%oracle_uninstall_logic";
        public const string OracleAttachLogic = "%oracle_attach_logic";
        public const string OracleAttachDatabase = "%oracle_attach_db";
        public const string OracleInstallUpdateDecoupled = "%oracle_installupdatedecoupled_db";
        
        public static readonly Type[] Types = new Type [] { typeof(global::Services.Packages.Package), typeof(global::Services.Packages.LocalPackage), typeof(global::Services.Packages.ApiKey), typeof(global::Services.Packages.Log.ApplicationException), typeof(global::Services.Packages.Customer), typeof(global::Services.Packages.CustomerUserEntry), typeof(global::Services.Packages.Purchase), typeof(global::Services.Packages.PurchaseLine), typeof(global::Services.Packages.Security.ModelUser), typeof(global::Services.Packages.Security.ModelSession), typeof(global::Services.Packages.Security.ModelUserRights), typeof(global::Services.Packages.Security.Securable), typeof(global::Services.Packages.Security.IPRegistered), typeof(global::Services.Packages.Security.IPSessionRegistration), typeof(global::Services.Packages.Security.PackageAccessControlList), typeof(global::Services.Packages.Security.PackageAccessControlEntry), typeof(global::Services.Packages.Security.ApiKeyAccessControlList), typeof(global::Services.Packages.Security.ApiKeyAccessControlEntry), typeof(global::Services.Packages.Log.Security.ApplicationExceptionAccessControlList), typeof(global::Services.Packages.Log.Security.ApplicationExceptionAccessControlEntry), typeof(global::Services.Packages.Security.CustomerAccessControlList), typeof(global::Services.Packages.Security.CustomerAccessControlEntry), typeof(global::Services.Packages.Security.CustomerUserEntryAccessControlList), typeof(global::Services.Packages.Security.CustomerUserEntryAccessControlEntry), typeof(global::Services.Packages.Security.PurchaseAccessControlList), typeof(global::Services.Packages.Security.PurchaseAccessControlEntry), typeof(global::Services.Packages.Security.PurchaseLineAccessControlList), typeof(global::Services.Packages.Security.PurchaseLineAccessControlEntry), typeof(global::Services.Packages.Security.Security.ModelUserAccessControlList), typeof(global::Services.Packages.Security.Security.ModelUserAccessControlEntry), typeof(global::Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions), typeof(global::Platform.Module.UndoRedo.Services.Packages.UndoRedoGroup), typeof(global::Services.Packages.CustomerUndoRedo), typeof(global::Services.Packages.PurchaseUndoRedo), typeof(global::Services.Packages.PurchaseLineUndoRedo) };
        public static readonly Type[] Interfaces = new Type [] { typeof(global::Services.Packages.IPackage), typeof(global::Services.Packages.ILocalPackage), typeof(global::Services.Packages.IApiKey), typeof(global::Services.Packages.Log.IApplicationException), typeof(global::Services.Packages.ICustomer), typeof(global::Services.Packages.ICustomerUserEntry), typeof(global::Services.Packages.IPurchase), typeof(global::Services.Packages.IPurchaseLine), typeof(global::Services.Packages.Security.IModelUser), typeof(global::Services.Packages.Security.IModelSession), typeof(global::Services.Packages.Security.IModelUserRights), typeof(global::Services.Packages.Security.ISecurable), typeof(global::Services.Packages.Security.IIPRegistered), typeof(global::Services.Packages.Security.IIPSessionRegistration), typeof(global::Services.Packages.Security.IPackageAccessControlList), typeof(global::Services.Packages.Security.IPackageAccessControlEntry), typeof(global::Services.Packages.Security.IApiKeyAccessControlList), typeof(global::Services.Packages.Security.IApiKeyAccessControlEntry), typeof(global::Services.Packages.Log.Security.IApplicationExceptionAccessControlList), typeof(global::Services.Packages.Log.Security.IApplicationExceptionAccessControlEntry), typeof(global::Services.Packages.Security.ICustomerAccessControlList), typeof(global::Services.Packages.Security.ICustomerAccessControlEntry), typeof(global::Services.Packages.Security.ICustomerUserEntryAccessControlList), typeof(global::Services.Packages.Security.ICustomerUserEntryAccessControlEntry), typeof(global::Services.Packages.Security.IPurchaseAccessControlList), typeof(global::Services.Packages.Security.IPurchaseAccessControlEntry), typeof(global::Services.Packages.Security.IPurchaseLineAccessControlList), typeof(global::Services.Packages.Security.IPurchaseLineAccessControlEntry), typeof(global::Services.Packages.Security.Security.IModelUserAccessControlList), typeof(global::Services.Packages.Security.Security.IModelUserAccessControlEntry), typeof(global::Platform.Module.UndoRedo.Services.Packages.IUndoRedoOptions), typeof(global::Platform.Module.UndoRedo.Services.Packages.IUndoRedoGroup), typeof(global::Services.Packages.ICustomerUndoRedo), typeof(global::Services.Packages.IPurchaseUndoRedo), typeof(global::Services.Packages.IPurchaseLineUndoRedo) };
        public static readonly Type[] ServiceTypes = new Type [] { typeof(global::Services.Packages.PackageService), typeof(global::Services.Packages.LocalPackageService), typeof(global::Services.Packages.ApiKeyService), typeof(global::Services.Packages.Log.ApplicationExceptionService), typeof(global::Services.Packages.CustomerService), typeof(global::Services.Packages.CustomerUserEntryService), typeof(global::Services.Packages.PurchaseService), typeof(global::Services.Packages.PurchaseLineService), typeof(global::Services.Packages.Security.ModelUserService), typeof(global::Services.Packages.Security.ModelSessionService), typeof(global::Services.Packages.Security.ModelUserRightsService), typeof(global::Services.Packages.Security.SecurableService), typeof(global::Services.Packages.Security.IPRegisteredService), typeof(global::Services.Packages.Security.IPSessionRegistrationService), typeof(global::Services.Packages.Security.PackageAccessControlListService), typeof(global::Services.Packages.Security.PackageAccessControlEntryService), typeof(global::Services.Packages.Security.ApiKeyAccessControlListService), typeof(global::Services.Packages.Security.ApiKeyAccessControlEntryService), typeof(global::Services.Packages.Log.Security.ApplicationExceptionAccessControlListService), typeof(global::Services.Packages.Log.Security.ApplicationExceptionAccessControlEntryService), typeof(global::Services.Packages.Security.CustomerAccessControlListService), typeof(global::Services.Packages.Security.CustomerAccessControlEntryService), typeof(global::Services.Packages.Security.CustomerUserEntryAccessControlListService), typeof(global::Services.Packages.Security.CustomerUserEntryAccessControlEntryService), typeof(global::Services.Packages.Security.PurchaseAccessControlListService), typeof(global::Services.Packages.Security.PurchaseAccessControlEntryService), typeof(global::Services.Packages.Security.PurchaseLineAccessControlListService), typeof(global::Services.Packages.Security.PurchaseLineAccessControlEntryService), typeof(global::Services.Packages.Security.Security.ModelUserAccessControlListService), typeof(global::Services.Packages.Security.Security.ModelUserAccessControlEntryService), typeof(global::Platform.Module.UndoRedo.Services.Packages.UndoRedoOptionsService), typeof(global::Platform.Module.UndoRedo.Services.Packages.UndoRedoGroupService), typeof(global::Services.Packages.CustomerUndoRedoService), typeof(global::Services.Packages.PurchaseUndoRedoService), typeof(global::Services.Packages.PurchaseLineUndoRedoService) };
        public static readonly Type[] ServiceInterfaces = new Type [] { typeof(global::Services.Packages.IPackageService), typeof(global::Services.Packages.ILocalPackageService), typeof(global::Services.Packages.IApiKeyService), typeof(global::Services.Packages.Log.IApplicationExceptionService), typeof(global::Services.Packages.ICustomerService), typeof(global::Services.Packages.ICustomerUserEntryService), typeof(global::Services.Packages.IPurchaseService), typeof(global::Services.Packages.IPurchaseLineService), typeof(global::Services.Packages.Security.IModelUserService), typeof(global::Services.Packages.Security.IModelSessionService), typeof(global::Services.Packages.Security.IModelUserRightsService), typeof(global::Services.Packages.Security.ISecurableService), typeof(global::Services.Packages.Security.IIPRegisteredService), typeof(global::Services.Packages.Security.IIPSessionRegistrationService), typeof(global::Services.Packages.Security.IPackageAccessControlListService), typeof(global::Services.Packages.Security.IPackageAccessControlEntryService), typeof(global::Services.Packages.Security.IApiKeyAccessControlListService), typeof(global::Services.Packages.Security.IApiKeyAccessControlEntryService), typeof(global::Services.Packages.Log.Security.IApplicationExceptionAccessControlListService), typeof(global::Services.Packages.Log.Security.IApplicationExceptionAccessControlEntryService), typeof(global::Services.Packages.Security.ICustomerAccessControlListService), typeof(global::Services.Packages.Security.ICustomerAccessControlEntryService), typeof(global::Services.Packages.Security.ICustomerUserEntryAccessControlListService), typeof(global::Services.Packages.Security.ICustomerUserEntryAccessControlEntryService), typeof(global::Services.Packages.Security.IPurchaseAccessControlListService), typeof(global::Services.Packages.Security.IPurchaseAccessControlEntryService), typeof(global::Services.Packages.Security.IPurchaseLineAccessControlListService), typeof(global::Services.Packages.Security.IPurchaseLineAccessControlEntryService), typeof(global::Services.Packages.Security.Security.IModelUserAccessControlListService), typeof(global::Services.Packages.Security.Security.IModelUserAccessControlEntryService), typeof(global::Platform.Module.UndoRedo.Services.Packages.IUndoRedoOptionsService), typeof(global::Platform.Module.UndoRedo.Services.Packages.IUndoRedoGroupService), typeof(global::Services.Packages.ICustomerUndoRedoService), typeof(global::Services.Packages.IPurchaseUndoRedoService), typeof(global::Services.Packages.IPurchaseLineUndoRedoService) };
    }
}
