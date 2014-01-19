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
    /// Defines the contract for the PurchaseLine class
    /// </summary>
    [ComVisible(true)]
    [Guid("544c2e32-cd5c-819c-aaac-62f4eef71aa8")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IPurchaseLine
	{
		bool Exists { get; }
		System.Int32 Id { get; set; }
		System.String ProductKey { get; set; }
		System.String ProductDescription { get; set; }
		System.Double PricePurchased { get; set; }
		System.Double RecurrentFeePurchased { get; set; }
		System.Boolean IsPaid { get; set; }
		Services.Packages.Purchase PurchaseOrder { get; set; }
		Services.Packages.Security.ModelUser Owner { get; set; }
		Services.Packages.Security.PurchaseLineAccessControlListCollection ACLs { get; set; }
		Services.Packages.Security.PurchaseLineAccessControlListCollection GetACLs(System.String UserName);

		void Read(System.Int32 __Id);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(PurchaseLine _object);
		void CopyWithKeysTo(PurchaseLine _object);
		void CopyFrom(PurchaseLine _object);
		void CopyTo(PurchaseLine _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.PurchaseLine type.
    /// </summary>
    [ComVisible(true)]
    [Guid("f7befe16-07a8-1465-3b36-c3ca42cfedb1")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IPurchaseLineService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(PurchaseLine _PurchaseLine);
		[OperationContract]
        PurchaseLine Read(System.Int32 __Id);
        [OperationContract]
        PurchaseLine Reload(PurchaseLine _PurchaseLine);
        [OperationContract]
        PurchaseLine Create(System.Int32 __Id);
        [OperationContract]
        void Delete(System.Int32 __Id);
        [OperationContract]
        void UpdateObject(PurchaseLine _PurchaseLine);
        [OperationContract]
        void CreateObject(PurchaseLine _PurchaseLine);
        [OperationContract]
        void DeleteObject(PurchaseLine _PurchaseLine);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		PurchaseLineCollection GetByPurchaseOrder(Services.Packages.Purchase _Purchase);
		[OperationContract]
		PurchaseLineCollection GetByPurchaseOrderPaged(Services.Packages.Purchase _Purchase, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByPurchaseOrderCount(Services.Packages.Purchase _Purchase);
		[OperationContract]
		Services.Packages.Purchase GetPurchaseOrder(PurchaseLine _PurchaseLine);
		[OperationContract]
		void SetPurchaseOrder(PurchaseLine _PurchaseLine, Services.Packages.Purchase _PurchaseOrder);
		[OperationContract]
		PurchaseLineCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		PurchaseLineCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount);
		[OperationContract]
		long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser);
		[OperationContract]
		Services.Packages.Security.ModelUser GetOwner(PurchaseLine _PurchaseLine);
		[OperationContract]
		void SetOwner(PurchaseLine _PurchaseLine, Services.Packages.Security.ModelUser _Owner);
		[OperationContract]
		Services.Packages.Security.PurchaseLineAccessControlListCollection GetACLs(PurchaseLine _PurchaseLine);
		[OperationContract]
		void SetACLs(PurchaseLine _PurchaseLine, Services.Packages.Security.PurchaseLineAccessControlListCollection _ACLs);

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.PurchaseLine type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("da718b15-4c7a-38ff-7d45-b50e076fe062")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class PurchaseLineService : IPurchaseLineService
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
        public bool Exists(PurchaseLine _PurchaseLine)
        {
			return _PurchaseLine.Exists;
        }
		
		[WebMethod]
		public PurchaseLine Read(System.Int32 __Id)
		{
			return new PurchaseLine(__Id);
		}
		
		[WebMethod]
        public PurchaseLine Reload(PurchaseLine _PurchaseLine)
        {
			_PurchaseLine.Reload();
			return _PurchaseLine;
        }
		
		[WebMethod]
        public PurchaseLine Create(System.Int32 __Id)
        {
			return PurchaseLine.CreatePurchaseLine(__Id);
        }
        
        [WebMethod]
        public void Delete(System.Int32 __Id)
        {
			PurchaseLine.DeletePurchaseLine(__Id);
        }
        
        [WebMethod]
        public void UpdateObject(PurchaseLine _PurchaseLine)
        {
			_PurchaseLine.Update();
        }
		
		[WebMethod]
        public void CreateObject(PurchaseLine _PurchaseLine)
        {
			_PurchaseLine.Create();
        }
        
        [WebMethod]
        public void DeleteObject(PurchaseLine _PurchaseLine)
        {
			_PurchaseLine.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			PurchaseLine.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			PurchaseLine.Redo();
        }
		[WebMethod]
		public PurchaseLineCollection GetByPurchaseOrder(Services.Packages.Purchase _Purchase)
		{
			return PurchaseLine.GetByPurchaseOrder( _Purchase);
		}
		[WebMethod]
		public PurchaseLineCollection GetByPurchaseOrderPaged(Services.Packages.Purchase _Purchase, long PagingStart, long PagingCount)
		{
			return PurchaseLine.GetByPurchaseOrderPaged( _Purchase, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByPurchaseOrderCount(Services.Packages.Purchase _Purchase)
		{
			return PurchaseLine.GetByPurchaseOrderCount( _Purchase);
		}
		[WebMethod]
		public Services.Packages.Purchase GetPurchaseOrder(PurchaseLine _PurchaseLine)
		{
			_PurchaseLine.Reload();
			return _PurchaseLine.PurchaseOrder;
		}
		[WebMethod]
		public void SetPurchaseOrder(PurchaseLine _PurchaseLine, Services.Packages.Purchase _PurchaseOrder)
		{
			_PurchaseLine.Reload();
			_PurchaseLine.PurchaseOrder = _PurchaseOrder;
			_PurchaseLine.Update();
		}
		[WebMethod]
		public PurchaseLineCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
		{
			return PurchaseLine.GetByOwner( _ModelUser);
		}
		[WebMethod]
		public PurchaseLineCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return PurchaseLine.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return PurchaseLine.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(PurchaseLine _PurchaseLine)
		{
			_PurchaseLine.Reload();
			return _PurchaseLine.Owner;
		}
		[WebMethod]
		public void SetOwner(PurchaseLine _PurchaseLine, Services.Packages.Security.ModelUser _Owner)
		{
			_PurchaseLine.Reload();
			_PurchaseLine.Owner = _Owner;
			_PurchaseLine.Update();
		}
		[WebMethod]
		public Services.Packages.Security.PurchaseLineAccessControlListCollection GetACLs(PurchaseLine _PurchaseLine)
		{
			_PurchaseLine.Reload();
			return _PurchaseLine.ACLs;
		}
		[WebMethod]
		public void SetACLs(PurchaseLine _PurchaseLine, Services.Packages.Security.PurchaseLineAccessControlListCollection _ACLs)
		{
			_PurchaseLine.Reload();
			_PurchaseLine.ACLs = _ACLs;
			_PurchaseLine.Update();
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.PurchaseLine model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("362dd6fa-2d7a-2aa8-c838-18250ad13fda")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class PurchaseLine : IPurchaseLine, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<IPurchaseLineService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<IPurchaseLineService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<IPurchaseLineService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.PurchaseLine"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.PurchaseLine"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.PurchaseLine.ProviderType");
				
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

		System.String _ProductKey;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String ProductKey
		{
            get
            {
                return _ProductKey;
            }
            set
            {
                _ProductKey = value;
            }
		}

		System.String _ProductDescription;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.String ProductDescription
		{
            get
            {
                return _ProductDescription;
            }
            set
            {
                _ProductDescription = value;
            }
		}

		System.Double _PricePurchased;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Double PricePurchased
		{
            get
            {
                return _PricePurchased;
            }
            set
            {
                _PricePurchased = value;
            }
		}

		System.Double _RecurrentFeePurchased;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Double RecurrentFeePurchased
		{
            get
            {
                return _RecurrentFeePurchased;
            }
            set
            {
                _RecurrentFeePurchased = value;
            }
		}

		System.Boolean _IsPaid;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Boolean IsPaid
		{
            get
            {
                return _IsPaid;
            }
            set
            {
                _IsPaid = value;
            }
		}

		bool _PurchaseOrderIsLoaded = false;
		Services.Packages.Purchase _PurchaseOrder;
		System.Int32 _PurchaseOrder_Id; 
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Purchase PurchaseOrder
		{
            get
            {
				if (!_PurchaseOrderIsLoaded)
				{
					_PurchaseOrder = new Services.Packages.Purchase(_PurchaseOrder_Id);
					if (_PurchaseOrder.Exists)
						_PurchaseOrderIsLoaded = true;
					else _PurchaseOrder = null;
				}
                return _PurchaseOrder;
            }
            set
            {
                _PurchaseOrder = value;
                _PurchaseOrderIsLoaded = true;
                if (_PurchaseOrder != null)
                {
					if (_PurchaseOrder.Exists)
					{
						_PurchaseOrder_Id = _PurchaseOrder.Id;
						
					}
					else
					{
						_PurchaseOrder = null;
					}
				}
            }
		}
		
		public static Services.Packages.Purchase GetPurchaseOrder(PurchaseLine _PurchaseLine)
		{
			return _PurchaseLine.PurchaseOrder;
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
		
		public static Services.Packages.Security.ModelUser GetOwner(PurchaseLine _PurchaseLine)
		{
			return _PurchaseLine.Owner;
		}

		public static PurchaseLineCollection GetByPurchaseOrder(Services.Packages.Purchase _Purchase)
        {
			PurchaseLineCollection _PurchaseLineCollection = new PurchaseLineCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiGetByPuOr", dbconn);
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
					PurchaseLine o = new PurchaseLine();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._ProductKey = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductKey"], typeof(System.String));
				o._ProductDescription = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductDescription"], typeof(System.String));
				o._PricePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PricePurchased"], typeof(System.Double));
				o._RecurrentFeePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["RecurrentFeePurchased"], typeof(System.Double));
				o._IsPaid = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaid"], typeof(System.Boolean));
				o._PurchaseOrderIsLoaded = false; if (dr["PurchaseOrder_Id"] == DBNull.Value) { o._PurchaseOrder = null; o._PurchaseOrderIsLoaded = true; }  else o._PurchaseOrder_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PurchaseOrder_Id"], typeof(System.Int32));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PurchaseLineCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PurchaseLineCollection;
        }
        
        public static PurchaseLineCollection GetByPurchaseOrderPaged(Services.Packages.Purchase _Purchase, long PagingStart, long PagingCount)
        {
			PurchaseLineCollection _PurchaseLineCollection = new PurchaseLineCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiGetByPuOrPaged", dbconn);
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
					PurchaseLine o = new PurchaseLine();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._ProductKey = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductKey"], typeof(System.String));
				o._ProductDescription = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductDescription"], typeof(System.String));
				o._PricePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PricePurchased"], typeof(System.Double));
				o._RecurrentFeePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["RecurrentFeePurchased"], typeof(System.Double));
				o._IsPaid = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaid"], typeof(System.Boolean));
				o._PurchaseOrderIsLoaded = false; if (dr["PurchaseOrder_Id"] == DBNull.Value) { o._PurchaseOrder = null; o._PurchaseOrderIsLoaded = true; }  else o._PurchaseOrder_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PurchaseOrder_Id"], typeof(System.Int32));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PurchaseLineCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PurchaseLineCollection;
        }
        
        public static long GetByPurchaseOrderCount(Services.Packages.Purchase _Purchase)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiGetByPuOrCount", dbconn);
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

		public static PurchaseLineCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
        {
			PurchaseLineCollection _PurchaseLineCollection = new PurchaseLineCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiGetByOw", dbconn);
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
					PurchaseLine o = new PurchaseLine();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._ProductKey = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductKey"], typeof(System.String));
				o._ProductDescription = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductDescription"], typeof(System.String));
				o._PricePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PricePurchased"], typeof(System.Double));
				o._RecurrentFeePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["RecurrentFeePurchased"], typeof(System.Double));
				o._IsPaid = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaid"], typeof(System.Boolean));
				o._PurchaseOrderIsLoaded = false; if (dr["PurchaseOrder_Id"] == DBNull.Value) { o._PurchaseOrder = null; o._PurchaseOrderIsLoaded = true; }  else o._PurchaseOrder_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PurchaseOrder_Id"], typeof(System.Int32));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PurchaseLineCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PurchaseLineCollection;
        }
        
        public static PurchaseLineCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
        {
			PurchaseLineCollection _PurchaseLineCollection = new PurchaseLineCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiGetByOwPaged", dbconn);
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
					PurchaseLine o = new PurchaseLine();
                
					o.__databaseState = RowState.Initialized;
                    o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._ProductKey = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductKey"], typeof(System.String));
				o._ProductDescription = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductDescription"], typeof(System.String));
				o._PricePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PricePurchased"], typeof(System.Double));
				o._RecurrentFeePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["RecurrentFeePurchased"], typeof(System.Double));
				o._IsPaid = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaid"], typeof(System.Boolean));
				o._PurchaseOrderIsLoaded = false; if (dr["PurchaseOrder_Id"] == DBNull.Value) { o._PurchaseOrder = null; o._PurchaseOrderIsLoaded = true; }  else o._PurchaseOrder_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PurchaseOrder_Id"], typeof(System.Int32));
				o._OwnerIsLoaded = false; if (dr["Owner_Name"] == DBNull.Value) { o._Owner = null; o._OwnerIsLoaded = true; }  else o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PurchaseLineCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PurchaseLineCollection;
        }
        
        public static long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
        {
			long count = 0;
            
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiGetByOwCount", dbconn);
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

		Services.Packages.Security.PurchaseLineAccessControlListCollection _ACLs;
		
		[System.Xml.Serialization.XmlIgnoreAttribute]
		public Services.Packages.Security.PurchaseLineAccessControlListCollection ACLs
		{
            get
            {
				if (_ACLs == null)
					_ACLs = Services.Packages.Security.PurchaseLineAccessControlList.GetByPurchaseLine(this);
				
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
							_ACLs[n].PurchaseLine = null;
							_ACLs[n].Update();
						}
					}
	                
					_ACLs = value;
					
					if (_ACLs != null)
					{
						for(int n = 0; n < _ACLs.Count; ++n)
						{
							_ACLs[n].PurchaseLine = this;
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
			_ACLs = Services.Packages.Security.PurchaseLineAccessControlList.GetByPurchaseLine(this);
		}

		public Services.Packages.Security.PurchaseLineAccessControlListCollection GetACLs(System.String UserName)
		{
			return Services.Packages.Security.PurchaseLineAccessControlList.GetACLs(UserName,  this);
		}

		public bool Exists
        {
            get {
				if (!__hasBeenReadOnce)
					Exist();
				
				return __databaseState == RowState.Initialized;
			}
        }
        
        public PurchaseLine() {}
        
        public PurchaseLine(System.Int32 __Id)
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
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuLiRead", dbconn);
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
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "PuLi");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuLiRead", dbconn);
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
				_ProductKey = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductKey"], typeof(System.String));
				_ProductDescription = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductDescription"], typeof(System.String));
				_PricePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PricePurchased"], typeof(System.Double));
				_RecurrentFeePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["RecurrentFeePurchased"], typeof(System.Double));
				_IsPaid = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaid"], typeof(System.Boolean));
				_PurchaseOrderIsLoaded = false; if (dr["PurchaseOrder_Id"] == DBNull.Value) { _PurchaseOrder = null; _PurchaseOrderIsLoaded = true; }  else _PurchaseOrder_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PurchaseOrder_Id"], typeof(System.Int32));
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "PuLi");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuLiRead", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				
                
					InstanceConnectionProvider.OnBeforeExecuted(command);

					DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

					if (dr.Read())
					{
						_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_ProductKey = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductKey"], typeof(System.String));
				_ProductDescription = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductDescription"], typeof(System.String));
				_PricePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PricePurchased"], typeof(System.Double));
				_RecurrentFeePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["RecurrentFeePurchased"], typeof(System.Double));
				_IsPaid = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaid"], typeof(System.Boolean));
				_PurchaseOrderIsLoaded = false; if (dr["PurchaseOrder_Id"] == DBNull.Value) { _PurchaseOrder = null; _PurchaseOrderIsLoaded = true; }  else _PurchaseOrder_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PurchaseOrder_Id"], typeof(System.Int32));
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuLiCreate", dbconn);
						command.CommandType = global::System.Data.CommandType.StoredProcedure;
	                
						DbParameter param_ProductKey = ClassConnectionProvider.GetDatabaseParameter("ProductKey", typeof(System.String), 256);
				param_ProductKey.Value = ClassConnectionProvider.FromValueToSqlModelType(_ProductKey);
				command.Parameters.Add(param_ProductKey);
				DbParameter param_ProductDescription = ClassConnectionProvider.GetDatabaseParameter("ProductDescription", typeof(System.String), -1);
				param_ProductDescription.Value = ClassConnectionProvider.FromValueToSqlModelType(_ProductDescription);
				command.Parameters.Add(param_ProductDescription);
				DbParameter param_PricePurchased = ClassConnectionProvider.GetDatabaseParameter("PricePurchased", typeof(System.Double), -1);
				param_PricePurchased.Value = ClassConnectionProvider.FromValueToSqlModelType(_PricePurchased);
				command.Parameters.Add(param_PricePurchased);
				DbParameter param_RecurrentFeePurchased = ClassConnectionProvider.GetDatabaseParameter("RecurrentFeePurchased", typeof(System.Double), -1);
				param_RecurrentFeePurchased.Value = ClassConnectionProvider.FromValueToSqlModelType(_RecurrentFeePurchased);
				command.Parameters.Add(param_RecurrentFeePurchased);
				DbParameter param_IsPaid = ClassConnectionProvider.GetDatabaseParameter("IsPaid", typeof(System.Boolean), -1);
				param_IsPaid.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsPaid);
				command.Parameters.Add(param_IsPaid);
				DbParameter param_PurchaseOrder_Id = ClassConnectionProvider.GetDatabaseParameter("PurchaseOrder_Id", typeof(System.Int32), -1);
				param_PurchaseOrder_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_PurchaseOrder_Id);
				if (_PurchaseOrder == null) param_PurchaseOrder_Id.Value = DBNull.Value;
				else param_PurchaseOrder_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_PurchaseOrder.Id);
				command.Parameters.Add(param_PurchaseOrder_Id);
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
				_ProductKey = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductKey"], typeof(System.String));
				_ProductDescription = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductDescription"], typeof(System.String));
				_PricePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PricePurchased"], typeof(System.Double));
				_RecurrentFeePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["RecurrentFeePurchased"], typeof(System.Double));
				_IsPaid = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaid"], typeof(System.Boolean));
				_PurchaseOrderIsLoaded = false; if (dr["PurchaseOrder_Id"] == DBNull.Value) { _PurchaseOrder = null; _PurchaseOrderIsLoaded = true; }  else _PurchaseOrder_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PurchaseOrder_Id"], typeof(System.Int32));
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
        
        static public PurchaseLine CreatePurchaseLine(System.Int32 __Id)
        {
            PurchaseLine o = new PurchaseLine(__Id);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuLiUpdate", dbconn);
					command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
					DbParameter param_Id = ClassConnectionProvider.GetDatabaseParameter("Id", typeof(System.Int32), -1);
				param_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_Id);
				command.Parameters.Add(param_Id);
				DbParameter param_ProductKey = ClassConnectionProvider.GetDatabaseParameter("ProductKey", typeof(System.String), 256);
				param_ProductKey.Value = ClassConnectionProvider.FromValueToSqlModelType(_ProductKey);
				command.Parameters.Add(param_ProductKey);
				DbParameter param_ProductDescription = ClassConnectionProvider.GetDatabaseParameter("ProductDescription", typeof(System.String), -1);
				param_ProductDescription.Value = ClassConnectionProvider.FromValueToSqlModelType(_ProductDescription);
				command.Parameters.Add(param_ProductDescription);
				DbParameter param_PricePurchased = ClassConnectionProvider.GetDatabaseParameter("PricePurchased", typeof(System.Double), -1);
				param_PricePurchased.Value = ClassConnectionProvider.FromValueToSqlModelType(_PricePurchased);
				command.Parameters.Add(param_PricePurchased);
				DbParameter param_RecurrentFeePurchased = ClassConnectionProvider.GetDatabaseParameter("RecurrentFeePurchased", typeof(System.Double), -1);
				param_RecurrentFeePurchased.Value = ClassConnectionProvider.FromValueToSqlModelType(_RecurrentFeePurchased);
				command.Parameters.Add(param_RecurrentFeePurchased);
				DbParameter param_IsPaid = ClassConnectionProvider.GetDatabaseParameter("IsPaid", typeof(System.Boolean), -1);
				param_IsPaid.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsPaid);
				command.Parameters.Add(param_IsPaid);
				DbParameter param_PurchaseOrderHasChanged = ClassConnectionProvider.GetDatabaseParameter("PurchaseOrderHasChanged", ClassConnectionProvider.FromValueToSqlModelType(_PurchaseOrderIsLoaded));
				command.Parameters.Add(param_PurchaseOrderHasChanged);
				DbParameter param_PurchaseOrder_Id = ClassConnectionProvider.GetDatabaseParameter("PurchaseOrder_Id", typeof(System.Int32), -1);
				param_PurchaseOrder_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_PurchaseOrder_Id);
				if (_PurchaseOrder == null) param_PurchaseOrder_Id.Value = DBNull.Value;
				else param_PurchaseOrder_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_PurchaseOrder.Id);
				command.Parameters.Add(param_PurchaseOrder_Id);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuLiDelete", dbconn);
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
        
        static public void DeletePurchaseLine(System.Int32 __Id)
        {
            PurchaseLine o = new PurchaseLine(__Id);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(PurchaseLine _object)
        {
			_PurchaseOrder = null;
			_PurchaseOrderIsLoaded = false;
			_Owner = null;
			_OwnerIsLoaded = false;
			_Id = _object._Id;
			_ProductKey = _object._ProductKey;
			_ProductDescription = _object._ProductDescription;
			_PricePurchased = _object._PricePurchased;
			_RecurrentFeePurchased = _object._RecurrentFeePurchased;
			_IsPaid = _object._IsPaid;
			
        }
        
        public void CopyWithKeysTo(PurchaseLine _object)
        {
			_object._PurchaseOrder = null;
			_object._PurchaseOrderIsLoaded = false;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Id = _Id;
			_object._ProductKey = _ProductKey;
			_object._ProductDescription = _ProductDescription;
			_object._PricePurchased = _PricePurchased;
			_object._RecurrentFeePurchased = _RecurrentFeePurchased;
			_object._IsPaid = _IsPaid;
			
        }
        
        static public void CopyWithKeysObject(PurchaseLine _objectFrom, PurchaseLine _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(PurchaseLine _object)
        {
			_PurchaseOrder = null;
			_PurchaseOrderIsLoaded = false;
			_Owner = null;
			_OwnerIsLoaded = false;
			_ProductKey = _object._ProductKey;
			_ProductDescription = _object._ProductDescription;
			_PricePurchased = _object._PricePurchased;
			_RecurrentFeePurchased = _object._RecurrentFeePurchased;
			_IsPaid = _object._IsPaid;
			
        }
        
        public void CopyTo(PurchaseLine _object)
        {
			_object._PurchaseOrder = null;
			_object._PurchaseOrderIsLoaded = false;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._ProductKey = _ProductKey;
			_object._ProductDescription = _ProductDescription;
			_object._PricePurchased = _PricePurchased;
			_object._RecurrentFeePurchased = _RecurrentFeePurchased;
			_object._IsPaid = _IsPaid;
			
        }
        
        static public void CopyObject(PurchaseLine _objectFrom, PurchaseLine _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(PurchaseLine).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(PurchaseLine).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(PurchaseLine _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			PurchaseLineUndoRedoCollection allUndidAndNotRedoneEntries = PurchaseLineUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			PurchaseLineUndoRedo _urobject = new PurchaseLineUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.PurchaseOrder_Id = _object._PurchaseOrder_Id;
			_urobject.Owner_Name = _object._Owner_Name;
			_urobject.Id = _object._Id;
			_urobject.ProductKey = _object._ProductKey;
			_urobject.ProductDescription = _object._ProductDescription;
			_urobject.PricePurchased = _object._PricePurchased;
			_urobject.RecurrentFeePurchased = _object._RecurrentFeePurchased;
			_urobject.IsPaid = _object._IsPaid;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(PurchaseLine).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = PurchaseLineUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				PurchaseLineUndoRedoCollection allOldUndoEntries = PurchaseLineUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			PurchaseLineUndoRedoCollection firstUndoEntries = PurchaseLineUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			PurchaseLineUndoRedo _urobject = firstUndoEntries[0];
			
			PurchaseLine _object = new PurchaseLine();
			_object._PurchaseOrder = null;
			_object._PurchaseOrderIsLoaded = false;
			_object._PurchaseOrder_Id = _urobject.PurchaseOrder_Id;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Owner_Name = _urobject.Owner_Name;
			_object._Id = _urobject.Id;
			_object._ProductKey = _urobject.ProductKey;
			_object._ProductDescription = _urobject.ProductDescription;
			_object._PricePurchased = _urobject.PricePurchased;
			_object._RecurrentFeePurchased = _urobject.RecurrentFeePurchased;
			_object._IsPaid = _urobject.IsPaid;
			

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
			PurchaseLineUndoRedoCollection firstEntryToRedoEntries = PurchaseLineUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			PurchaseLineUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			PurchaseLine _object = new PurchaseLine();
			_object._PurchaseOrder = null;
			_object._PurchaseOrderIsLoaded = false;
			_object._PurchaseOrder_Id = _urobject.PurchaseOrder_Id;
			_object._Owner = null;
			_object._OwnerIsLoaded = false;
			_object._Owner_Name = _urobject.Owner_Name;
			_object._Id = _urobject.Id;
			_object._ProductKey = _urobject.ProductKey;
			_object._ProductDescription = _urobject.ProductDescription;
			_object._PricePurchased = _urobject.PricePurchased;
			_object._RecurrentFeePurchased = _urobject.RecurrentFeePurchased;
			_object._IsPaid = _urobject.IsPaid;
			

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
    /// Defines the contract for the PurchaseLineCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("63dfb1be-4086-c92d-fe86-7a6251570ccc")]
    public interface IPurchaseLineCollection : IEnumerable<PurchaseLine>
    {
        int IndexOf(PurchaseLine item);
        void Insert(int index, PurchaseLine item);
        void RemoveAt(int index);
        PurchaseLine this[int index] { get; set; }
        void Add(PurchaseLine item);
        void Clear();
        bool Contains(PurchaseLine item);
        void CopyTo(PurchaseLine[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(PurchaseLine item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.PurchaseLine
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("6ccf6155-b7a2-e736-e247-114234da2eab")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class PurchaseLineCollection : IPurchaseLineCollection, IList<PurchaseLine>, IHierarchicalEnumerable
    {
        List<PurchaseLine> _list = new List<PurchaseLine>();
        
        public static implicit operator List<PurchaseLine>(PurchaseLineCollection collection)
        {
            return collection._list;
        }

        #region IList<PurchaseLine> Members

        public int IndexOf(PurchaseLine item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, PurchaseLine item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public PurchaseLine this[int index]
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

        #region ICollection<PurchaseLine> Members

        public void Add(PurchaseLine item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(PurchaseLine item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(PurchaseLine[] array, int arrayIndex)
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

        public bool Remove(PurchaseLine item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<PurchaseLine> Members

        public IEnumerator<PurchaseLine> GetEnumerator()
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
	/// that share Services.Packages.PurchaseLine objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Web.PurchaseLineWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class PurchaseLineWebService : WebService, IPurchaseLineService
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
        public bool Exists(PurchaseLine _PurchaseLine)
        {
			return _PurchaseLine.Exists;
        }
		
		[WebMethod]
		public PurchaseLine Read(System.Int32 __Id)
		{
			return new PurchaseLine(__Id);
		}
		
		[WebMethod]
        public PurchaseLine Reload(PurchaseLine _PurchaseLine)
        {
			_PurchaseLine.Reload();
			return _PurchaseLine;
        }
		
		[WebMethod]
        public PurchaseLine Create(System.Int32 __Id)
        {
			return PurchaseLine.CreatePurchaseLine(__Id);
        }
        
        [WebMethod]
        public void Delete(System.Int32 __Id)
        {
			PurchaseLine.DeletePurchaseLine(__Id);
        }
        
        [WebMethod]
        public void UpdateObject(PurchaseLine _PurchaseLine)
        {
			_PurchaseLine.Update();
        }
		
		[WebMethod]
        public void CreateObject(PurchaseLine _PurchaseLine)
        {
			_PurchaseLine.Create();
        }
        
        [WebMethod]
        public void DeleteObject(PurchaseLine _PurchaseLine)
        {
			_PurchaseLine.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			PurchaseLine.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			PurchaseLine.Redo();
        }
		[WebMethod]
		public PurchaseLineCollection GetByPurchaseOrder(Services.Packages.Purchase _Purchase)
		{
			return PurchaseLine.GetByPurchaseOrder( _Purchase);
		}
		[WebMethod]
		public PurchaseLineCollection GetByPurchaseOrderPaged(Services.Packages.Purchase _Purchase, long PagingStart, long PagingCount)
		{
			return PurchaseLine.GetByPurchaseOrderPaged( _Purchase, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByPurchaseOrderCount(Services.Packages.Purchase _Purchase)
		{
			return PurchaseLine.GetByPurchaseOrderCount( _Purchase);
		}
		[WebMethod]
		public Services.Packages.Purchase GetPurchaseOrder(PurchaseLine _PurchaseLine)
		{
			_PurchaseLine.Reload();
			return _PurchaseLine.PurchaseOrder;
		}
		[WebMethod]
		public void SetPurchaseOrder(PurchaseLine _PurchaseLine, Services.Packages.Purchase _PurchaseOrder)
		{
			_PurchaseLine.Reload();
			_PurchaseLine.PurchaseOrder = _PurchaseOrder;
			_PurchaseLine.Update();
		}
		[WebMethod]
		public PurchaseLineCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser)
		{
			return PurchaseLine.GetByOwner( _ModelUser);
		}
		[WebMethod]
		public PurchaseLineCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount)
		{
			return PurchaseLine.GetByOwnerPaged( _ModelUser, PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser)
		{
			return PurchaseLine.GetByOwnerCount( _ModelUser);
		}
		[WebMethod]
		public Services.Packages.Security.ModelUser GetOwner(PurchaseLine _PurchaseLine)
		{
			_PurchaseLine.Reload();
			return _PurchaseLine.Owner;
		}
		[WebMethod]
		public void SetOwner(PurchaseLine _PurchaseLine, Services.Packages.Security.ModelUser _Owner)
		{
			_PurchaseLine.Reload();
			_PurchaseLine.Owner = _Owner;
			_PurchaseLine.Update();
		}
		[WebMethod]
		public Services.Packages.Security.PurchaseLineAccessControlListCollection GetACLs(PurchaseLine _PurchaseLine)
		{
			_PurchaseLine.Reload();
			return _PurchaseLine.ACLs;
		}
		[WebMethod]
		public void SetACLs(PurchaseLine _PurchaseLine, Services.Packages.Security.PurchaseLineAccessControlListCollection _ACLs)
		{
			_PurchaseLine.Reload();
			_PurchaseLine.ACLs = _ACLs;
			_PurchaseLine.Update();
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="PurchaseLineWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("564fdb06-7d8f-badc-a863-37f4b245d871")]
    sealed public class PurchaseLineWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IPurchaseLineService
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
		public PurchaseLineWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public PurchaseLineWebServiceClient()
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
		public bool Exists(PurchaseLine _PurchaseLine)
        {
			object[] results = this.Invoke("Exists", new object[] {_PurchaseLine});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLine Read(System.Int32 __Id)
		{
			object[] results = this.Invoke("Read", new object[] {__Id});
			return ((PurchaseLine)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLine Reload(PurchaseLine _PurchaseLine)
        {
			object[] results = this.Invoke("Reload", new object[] {_PurchaseLine});
			return ((PurchaseLine)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLine Create(System.Int32 __Id)
        {
			object[] results = this.Invoke("Create", new object[] {__Id});
			return ((PurchaseLine)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.Int32 __Id)
        {
			this.Invoke("Delete", new object[] {__Id});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(PurchaseLine _PurchaseLine)
        {
			this.Invoke("UpdateObject", new object[] {_PurchaseLine});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(PurchaseLine _PurchaseLine)
        {
			this.Invoke("CreateObject", new object[] {_PurchaseLine});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(PurchaseLine _PurchaseLine)
        {
			this.Invoke("DeleteObject", new object[] {_PurchaseLine});
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
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByPurchaseOrder", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineCollection GetByPurchaseOrder(Services.Packages.Purchase _Purchase) {
			object[] results = this.Invoke("GetByPurchaseOrder", new object[] {_Purchase});
			return ((PurchaseLineCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByPurchaseOrderPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineCollection GetByPurchaseOrderPaged(Services.Packages.Purchase _Purchase, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByPurchaseOrderPaged", new object[] {_Purchase,PagingStart,PagingCount});
			return ((PurchaseLineCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByPurchaseOrderCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByPurchaseOrderCount(Services.Packages.Purchase _Purchase) {
			object[] results = this.Invoke("GetByPurchaseOrderCount", new object[] {_Purchase});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetPurchaseOrder", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Purchase GetPurchaseOrder(PurchaseLine _PurchaseLine)
		{
			object[] results = this.Invoke("GetPurchaseOrder", new object[] {_PurchaseLine});
			return ((Services.Packages.Purchase)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetPurchaseOrder", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetPurchaseOrder(PurchaseLine _PurchaseLine, Services.Packages.Purchase _PurchaseOrder)
		{
			this.Invoke("GetPurchaseOrder", new object[] {_PurchaseLine});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineCollection GetByOwner(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByOwner", new object[] {_ModelUser});
			return ((PurchaseLineCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineCollection GetByOwnerPaged(Services.Packages.Security.ModelUser _ModelUser, long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetByOwnerPaged", new object[] {_ModelUser,PagingStart,PagingCount});
			return ((PurchaseLineCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetByOwnerCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetByOwnerCount(Services.Packages.Security.ModelUser _ModelUser) {
			object[] results = this.Invoke("GetByOwnerCount", new object[] {_ModelUser});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.ModelUser GetOwner(PurchaseLine _PurchaseLine)
		{
			object[] results = this.Invoke("GetOwner", new object[] {_PurchaseLine});
			return ((Services.Packages.Security.ModelUser)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetOwner", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetOwner(PurchaseLine _PurchaseLine, Services.Packages.Security.ModelUser _Owner)
		{
			this.Invoke("GetOwner", new object[] {_PurchaseLine});
			return;
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public Services.Packages.Security.PurchaseLineAccessControlListCollection GetACLs(PurchaseLine _PurchaseLine)
		{
			object[] results = this.Invoke("GetACLs", new object[] {_PurchaseLine});
			return ((Services.Packages.Security.PurchaseLineAccessControlListCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/SetACLs", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void SetACLs(PurchaseLine _PurchaseLine, Services.Packages.Security.PurchaseLineAccessControlListCollection _ACLs)
		{
			this.Invoke("GetACLs", new object[] {_PurchaseLine});
			return;
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages
