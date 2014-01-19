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
    /// Defines the contract for the PurchaseLineUndoRedo class
    /// </summary>
    [ComVisible(true)]
    [Guid("3fe83cdc-d115-cb3c-a117-3ad2609f284c")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IPurchaseLineUndoRedo
	{
		bool Exists { get; }
		System.Int64 UndoRedoId { get; set; }
		System.Boolean IsCreatedUndoDeletes { get; set; }
		System.Boolean IsDeletedUndoCreates { get; set; }
		System.Boolean IsUpdatedUndoUpdates { get; set; }
		System.Boolean IsUndone { get; set; }
		System.Int32 Id { get; set; }
		System.String ProductKey { get; set; }
		System.String ProductDescription { get; set; }
		System.Double PricePurchased { get; set; }
		System.Double RecurrentFeePurchased { get; set; }
		System.Boolean IsPaid { get; set; }
		System.Int32 PurchaseOrder_Id { get; set; }
		System.String Owner_Name { get; set; }

		void Read(System.Int64 __UndoRedoId);
		void Reload();
        void Create();
        void Update();
        void Delete();
		void CopyWithKeysFrom(PurchaseLineUndoRedo _object);
		void CopyWithKeysTo(PurchaseLineUndoRedo _object);
		void CopyFrom(PurchaseLineUndoRedo _object);
		void CopyTo(PurchaseLineUndoRedo _object);

	}
	
	/// <summary>
    /// Defines the contract for all the service-based types which can
    /// apply servicing on Services.Packages.PurchaseLineUndoRedo type.
    /// </summary>
    [ComVisible(true)]
    [Guid("c1ed5114-8ca7-f497-84c7-ce252289232d")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ServiceContract(Namespace="http://services.msd.com")]
    public interface IPurchaseLineUndoRedoService
    {
		string Uri { get; set; }

		[OperationContract]
        bool Exists(PurchaseLineUndoRedo _PurchaseLineUndoRedo);
		[OperationContract]
        PurchaseLineUndoRedo Read(System.Int64 __UndoRedoId);
        [OperationContract]
        PurchaseLineUndoRedo Reload(PurchaseLineUndoRedo _PurchaseLineUndoRedo);
        [OperationContract]
        PurchaseLineUndoRedo Create(System.Int64 __UndoRedoId);
        [OperationContract]
        void Delete(System.Int64 __UndoRedoId);
        [OperationContract]
        void UpdateObject(PurchaseLineUndoRedo _PurchaseLineUndoRedo);
        [OperationContract]
        void CreateObject(PurchaseLineUndoRedo _PurchaseLineUndoRedo);
        [OperationContract]
        void DeleteObject(PurchaseLineUndoRedo _PurchaseLineUndoRedo);
        [OperationContract]
        void Undo();
        [OperationContract]
        void Redo();
		[OperationContract]
		PurchaseLineUndoRedoCollection GetAllFilterByIsUndone(System.Boolean IsUndone );
		[OperationContract]
		PurchaseLineUndoRedoCollection GetAllFilterByIsUndonePaged(System.Boolean IsUndone , long PagingStart, long PagingCount);
		[OperationContract]
		long GetAllFilterByIsUndoneCount(System.Boolean IsUndone );
		[OperationContract]
		PurchaseLineUndoRedoCollection GetAllFilterByIsUndoneOppositeOrder(System.Boolean IsUndone );
		[OperationContract]
		PurchaseLineUndoRedoCollection GetAllFilterByIsUndoneOppositeOrderPaged(System.Boolean IsUndone , long PagingStart, long PagingCount);
		[OperationContract]
		long GetAllFilterByIsUndoneOppositeOrderCount(System.Boolean IsUndone );
		[OperationContract]
		PurchaseLineUndoRedoCollection GetAllWithNoFilterOppositeSorting(System.Boolean dummy );
		[OperationContract]
		PurchaseLineUndoRedoCollection GetAllWithNoFilterOppositeSortingPaged(System.Boolean dummy , long PagingStart, long PagingCount);
		[OperationContract]
		long GetAllWithNoFilterOppositeSortingCount(System.Boolean dummy );
		[OperationContract]
		PurchaseLineUndoRedoCollection GetAllWithNoFilter(System.Boolean dummy );
		[OperationContract]
		PurchaseLineUndoRedoCollection GetAllWithNoFilterPaged(System.Boolean dummy , long PagingStart, long PagingCount);
		[OperationContract]
		long GetAllWithNoFilterCount(System.Boolean dummy );

    }
    
    /// <summary>
    /// WCF and default implementation of a service object for Services.Packages.PurchaseLineUndoRedo type.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("d86a069c-b599-f57b-ee3e-c17e7419200d")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        UseSynchronizationContext=false,
        IncludeExceptionDetailInFaults = true,
        AddressFilterMode=AddressFilterMode.Any,
        Namespace="http://services.msd.com")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    sealed public class PurchaseLineUndoRedoService : IPurchaseLineUndoRedoService
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
        public bool Exists(PurchaseLineUndoRedo _PurchaseLineUndoRedo)
        {
			return _PurchaseLineUndoRedo.Exists;
        }
		
		[WebMethod]
		public PurchaseLineUndoRedo Read(System.Int64 __UndoRedoId)
		{
			return new PurchaseLineUndoRedo(__UndoRedoId);
		}
		
		[WebMethod]
        public PurchaseLineUndoRedo Reload(PurchaseLineUndoRedo _PurchaseLineUndoRedo)
        {
			_PurchaseLineUndoRedo.Reload();
			return _PurchaseLineUndoRedo;
        }
		
		[WebMethod]
        public PurchaseLineUndoRedo Create(System.Int64 __UndoRedoId)
        {
			return PurchaseLineUndoRedo.CreatePurchaseLineUndoRedo(__UndoRedoId);
        }
        
        [WebMethod]
        public void Delete(System.Int64 __UndoRedoId)
        {
			PurchaseLineUndoRedo.DeletePurchaseLineUndoRedo(__UndoRedoId);
        }
        
        [WebMethod]
        public void UpdateObject(PurchaseLineUndoRedo _PurchaseLineUndoRedo)
        {
			_PurchaseLineUndoRedo.Update();
        }
		
		[WebMethod]
        public void CreateObject(PurchaseLineUndoRedo _PurchaseLineUndoRedo)
        {
			_PurchaseLineUndoRedo.Create();
        }
        
        [WebMethod]
        public void DeleteObject(PurchaseLineUndoRedo _PurchaseLineUndoRedo)
        {
			_PurchaseLineUndoRedo.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			PurchaseLineUndoRedo.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			PurchaseLineUndoRedo.Redo();
        }
		[WebMethod]
		public PurchaseLineUndoRedoCollection GetAllFilterByIsUndone(System.Boolean IsUndone )
		{
			return PurchaseLineUndoRedo.GetAllFilterByIsUndone(IsUndone );
		}
		[WebMethod]
		public PurchaseLineUndoRedoCollection GetAllFilterByIsUndonePaged(System.Boolean IsUndone , long PagingStart, long PagingCount)
		{
			return PurchaseLineUndoRedo.GetAllFilterByIsUndonePaged(IsUndone , PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetAllFilterByIsUndoneCount(System.Boolean IsUndone )
		{
			return PurchaseLineUndoRedo.GetAllFilterByIsUndoneCount(IsUndone );
		}
		[WebMethod]
		public PurchaseLineUndoRedoCollection GetAllFilterByIsUndoneOppositeOrder(System.Boolean IsUndone )
		{
			return PurchaseLineUndoRedo.GetAllFilterByIsUndoneOppositeOrder(IsUndone );
		}
		[WebMethod]
		public PurchaseLineUndoRedoCollection GetAllFilterByIsUndoneOppositeOrderPaged(System.Boolean IsUndone , long PagingStart, long PagingCount)
		{
			return PurchaseLineUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(IsUndone , PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetAllFilterByIsUndoneOppositeOrderCount(System.Boolean IsUndone )
		{
			return PurchaseLineUndoRedo.GetAllFilterByIsUndoneOppositeOrderCount(IsUndone );
		}
		[WebMethod]
		public PurchaseLineUndoRedoCollection GetAllWithNoFilterOppositeSorting(System.Boolean dummy )
		{
			return PurchaseLineUndoRedo.GetAllWithNoFilterOppositeSorting(dummy );
		}
		[WebMethod]
		public PurchaseLineUndoRedoCollection GetAllWithNoFilterOppositeSortingPaged(System.Boolean dummy , long PagingStart, long PagingCount)
		{
			return PurchaseLineUndoRedo.GetAllWithNoFilterOppositeSortingPaged(dummy , PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetAllWithNoFilterOppositeSortingCount(System.Boolean dummy )
		{
			return PurchaseLineUndoRedo.GetAllWithNoFilterOppositeSortingCount(dummy );
		}
		[WebMethod]
		public PurchaseLineUndoRedoCollection GetAllWithNoFilter(System.Boolean dummy )
		{
			return PurchaseLineUndoRedo.GetAllWithNoFilter(dummy );
		}
		[WebMethod]
		public PurchaseLineUndoRedoCollection GetAllWithNoFilterPaged(System.Boolean dummy , long PagingStart, long PagingCount)
		{
			return PurchaseLineUndoRedo.GetAllWithNoFilterPaged(dummy , PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetAllWithNoFilterCount(System.Boolean dummy )
		{
			return PurchaseLineUndoRedo.GetAllWithNoFilterCount(dummy );
		}

    }
	
	/// <summary>
    /// Provides the implementation of Services.Packages.PurchaseLineUndoRedo model that acts as DAL for
    /// a database table.
    /// </summary>
    [ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("076ce98c-7346-500f-a5f4-bb4d0316a917")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class PurchaseLineUndoRedo : IPurchaseLineUndoRedo, IHierarchyData, global::Platform.Runtime.Data.IModelHierachyData
    {
		#region Servicing support

		// Synchronized replication
        [NonSerialized]
        static List<IPurchaseLineUndoRedoService> replicationServices = null;
        
        // Scaling proxy objects (using 1 object you get forwarding)
        [NonSerialized]
        static List<IPurchaseLineUndoRedoService> scalingServices = null;
		// static IServiceSelectionAlgorithm serviceSelectionAlgorithm = null;

        // Failover scenario
        [NonSerialized]
        static List<IPurchaseLineUndoRedoService> failoverServices = null;

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
				
				if (global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.PurchaseLineUndoRedo"] != null)
					classConnectionString = global::System.Configuration.ConfigurationManager.ConnectionStrings["Services.Packages.PurchaseLineUndoRedo"].ConnectionString;
				
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
				
				classSqlProviderType = global::Platform.Runtime.Sql.GetProviderConfiguration("Services.Packages.PurchaseLineUndoRedo.ProviderType");
				
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

		System.Int32 _Id;
		
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

		System.Int32 _PurchaseOrder_Id;
		
		[DataMember]
        [global::System.ComponentModel.Bindable(true)]
		public System.Int32 PurchaseOrder_Id
		{
            get
            {
                return _PurchaseOrder_Id;
            }
            set
            {
                _PurchaseOrder_Id = value;
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

		public static PurchaseLineUndoRedoCollection GetAllFilterByIsUndone(System.Boolean _IsUndone)
        {
			PurchaseLineUndoRedoCollection _PurchaseLineUndoRedoCollection = new PurchaseLineUndoRedoCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiUnReGeAlFiByIsUn", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                
                
                DbParameter param_IsUndone = ClassConnectionProvider.GetDatabaseParameter("IsUndone", typeof(System.Boolean), -1);
				param_IsUndone.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsUndone);
				command.Parameters.Add(param_IsUndone);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					PurchaseLineUndoRedo o = new PurchaseLineUndoRedo();
                
					o.__databaseState = RowState.Initialized;
                    o._UndoRedoId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoId"], typeof(System.Int64));
				o._IsCreatedUndoDeletes = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsCreatedUndoDeletes"], typeof(System.Boolean));
				o._IsDeletedUndoCreates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsDeletedUndoCreates"], typeof(System.Boolean));
				o._IsUpdatedUndoUpdates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUpdatedUndoUpdates"], typeof(System.Boolean));
				o._IsUndone = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUndone"], typeof(System.Boolean));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._ProductKey = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductKey"], typeof(System.String));
				o._ProductDescription = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductDescription"], typeof(System.String));
				o._PricePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PricePurchased"], typeof(System.Double));
				o._RecurrentFeePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["RecurrentFeePurchased"], typeof(System.Double));
				o._IsPaid = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaid"], typeof(System.Boolean));
				o._PurchaseOrder_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PurchaseOrder_Id"], typeof(System.Int32));
				o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PurchaseLineUndoRedoCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PurchaseLineUndoRedoCollection;
        }
        
        public static PurchaseLineUndoRedoCollection GetAllFilterByIsUndonePaged(System.Boolean _IsUndone, long PagingStart, long PagingCount)
        {
			PurchaseLineUndoRedoCollection _PurchaseLineUndoRedoCollection = new PurchaseLineUndoRedoCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiUnReGeAlFiByIsUnPaged", dbconn);
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
					PurchaseLineUndoRedo o = new PurchaseLineUndoRedo();
                
					o.__databaseState = RowState.Initialized;
                    o._UndoRedoId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoId"], typeof(System.Int64));
				o._IsCreatedUndoDeletes = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsCreatedUndoDeletes"], typeof(System.Boolean));
				o._IsDeletedUndoCreates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsDeletedUndoCreates"], typeof(System.Boolean));
				o._IsUpdatedUndoUpdates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUpdatedUndoUpdates"], typeof(System.Boolean));
				o._IsUndone = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUndone"], typeof(System.Boolean));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._ProductKey = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductKey"], typeof(System.String));
				o._ProductDescription = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductDescription"], typeof(System.String));
				o._PricePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PricePurchased"], typeof(System.Double));
				o._RecurrentFeePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["RecurrentFeePurchased"], typeof(System.Double));
				o._IsPaid = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaid"], typeof(System.Boolean));
				o._PurchaseOrder_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PurchaseOrder_Id"], typeof(System.Int32));
				o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PurchaseLineUndoRedoCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PurchaseLineUndoRedoCollection;
        }
        
        public static long GetAllFilterByIsUndoneCount(System.Boolean _IsUndone)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiUnReGeAlFiByIsUnCount", dbconn);
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

		public static PurchaseLineUndoRedoCollection GetAllFilterByIsUndoneOppositeOrder(System.Boolean _IsUndone)
        {
			PurchaseLineUndoRedoCollection _PurchaseLineUndoRedoCollection = new PurchaseLineUndoRedoCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiUnReGeAlFiByIsUnOpOr", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                
                
                DbParameter param_IsUndone = ClassConnectionProvider.GetDatabaseParameter("IsUndone", typeof(System.Boolean), -1);
				param_IsUndone.Value = ClassConnectionProvider.FromValueToSqlModelType(_IsUndone);
				command.Parameters.Add(param_IsUndone);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					PurchaseLineUndoRedo o = new PurchaseLineUndoRedo();
                
					o.__databaseState = RowState.Initialized;
                    o._UndoRedoId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoId"], typeof(System.Int64));
				o._IsCreatedUndoDeletes = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsCreatedUndoDeletes"], typeof(System.Boolean));
				o._IsDeletedUndoCreates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsDeletedUndoCreates"], typeof(System.Boolean));
				o._IsUpdatedUndoUpdates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUpdatedUndoUpdates"], typeof(System.Boolean));
				o._IsUndone = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUndone"], typeof(System.Boolean));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._ProductKey = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductKey"], typeof(System.String));
				o._ProductDescription = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductDescription"], typeof(System.String));
				o._PricePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PricePurchased"], typeof(System.Double));
				o._RecurrentFeePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["RecurrentFeePurchased"], typeof(System.Double));
				o._IsPaid = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaid"], typeof(System.Boolean));
				o._PurchaseOrder_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PurchaseOrder_Id"], typeof(System.Int32));
				o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PurchaseLineUndoRedoCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PurchaseLineUndoRedoCollection;
        }
        
        public static PurchaseLineUndoRedoCollection GetAllFilterByIsUndoneOppositeOrderPaged(System.Boolean _IsUndone, long PagingStart, long PagingCount)
        {
			PurchaseLineUndoRedoCollection _PurchaseLineUndoRedoCollection = new PurchaseLineUndoRedoCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiUnReGeAlFiByIsUnOpOrPaged", dbconn);
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
					PurchaseLineUndoRedo o = new PurchaseLineUndoRedo();
                
					o.__databaseState = RowState.Initialized;
                    o._UndoRedoId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoId"], typeof(System.Int64));
				o._IsCreatedUndoDeletes = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsCreatedUndoDeletes"], typeof(System.Boolean));
				o._IsDeletedUndoCreates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsDeletedUndoCreates"], typeof(System.Boolean));
				o._IsUpdatedUndoUpdates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUpdatedUndoUpdates"], typeof(System.Boolean));
				o._IsUndone = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUndone"], typeof(System.Boolean));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._ProductKey = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductKey"], typeof(System.String));
				o._ProductDescription = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductDescription"], typeof(System.String));
				o._PricePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PricePurchased"], typeof(System.Double));
				o._RecurrentFeePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["RecurrentFeePurchased"], typeof(System.Double));
				o._IsPaid = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaid"], typeof(System.Boolean));
				o._PurchaseOrder_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PurchaseOrder_Id"], typeof(System.Int32));
				o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PurchaseLineUndoRedoCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PurchaseLineUndoRedoCollection;
        }
        
        public static long GetAllFilterByIsUndoneOppositeOrderCount(System.Boolean _IsUndone)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiUnReGeAlFiByIsUnOpOrCount", dbconn);
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

		public static PurchaseLineUndoRedoCollection GetAllWithNoFilterOppositeSorting(System.Boolean _dummy)
        {
			PurchaseLineUndoRedoCollection _PurchaseLineUndoRedoCollection = new PurchaseLineUndoRedoCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiUnReGeAlWiNoFiOpSo", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                
                
                DbParameter param_dummy = ClassConnectionProvider.GetDatabaseParameter("dummy", typeof(System.Boolean), -1);
				param_dummy.Value = ClassConnectionProvider.FromValueToSqlModelType(_dummy);
				command.Parameters.Add(param_dummy);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					PurchaseLineUndoRedo o = new PurchaseLineUndoRedo();
                
					o.__databaseState = RowState.Initialized;
                    o._UndoRedoId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoId"], typeof(System.Int64));
				o._IsCreatedUndoDeletes = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsCreatedUndoDeletes"], typeof(System.Boolean));
				o._IsDeletedUndoCreates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsDeletedUndoCreates"], typeof(System.Boolean));
				o._IsUpdatedUndoUpdates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUpdatedUndoUpdates"], typeof(System.Boolean));
				o._IsUndone = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUndone"], typeof(System.Boolean));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._ProductKey = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductKey"], typeof(System.String));
				o._ProductDescription = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductDescription"], typeof(System.String));
				o._PricePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PricePurchased"], typeof(System.Double));
				o._RecurrentFeePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["RecurrentFeePurchased"], typeof(System.Double));
				o._IsPaid = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaid"], typeof(System.Boolean));
				o._PurchaseOrder_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PurchaseOrder_Id"], typeof(System.Int32));
				o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PurchaseLineUndoRedoCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PurchaseLineUndoRedoCollection;
        }
        
        public static PurchaseLineUndoRedoCollection GetAllWithNoFilterOppositeSortingPaged(System.Boolean _dummy, long PagingStart, long PagingCount)
        {
			PurchaseLineUndoRedoCollection _PurchaseLineUndoRedoCollection = new PurchaseLineUndoRedoCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiUnReGeAlWiNoFiOpSoPaged", dbconn);
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
					PurchaseLineUndoRedo o = new PurchaseLineUndoRedo();
                
					o.__databaseState = RowState.Initialized;
                    o._UndoRedoId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoId"], typeof(System.Int64));
				o._IsCreatedUndoDeletes = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsCreatedUndoDeletes"], typeof(System.Boolean));
				o._IsDeletedUndoCreates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsDeletedUndoCreates"], typeof(System.Boolean));
				o._IsUpdatedUndoUpdates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUpdatedUndoUpdates"], typeof(System.Boolean));
				o._IsUndone = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUndone"], typeof(System.Boolean));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._ProductKey = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductKey"], typeof(System.String));
				o._ProductDescription = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductDescription"], typeof(System.String));
				o._PricePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PricePurchased"], typeof(System.Double));
				o._RecurrentFeePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["RecurrentFeePurchased"], typeof(System.Double));
				o._IsPaid = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaid"], typeof(System.Boolean));
				o._PurchaseOrder_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PurchaseOrder_Id"], typeof(System.Int32));
				o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PurchaseLineUndoRedoCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PurchaseLineUndoRedoCollection;
        }
        
        public static long GetAllWithNoFilterOppositeSortingCount(System.Boolean _dummy)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiUnReGeAlWiNoFiOpSoCount", dbconn);
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

		public static PurchaseLineUndoRedoCollection GetAllWithNoFilter(System.Boolean _dummy)
        {
			PurchaseLineUndoRedoCollection _PurchaseLineUndoRedoCollection = new PurchaseLineUndoRedoCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiUnReGeAlWiNoFi", dbconn);
                command.CommandType = global::System.Data.CommandType.StoredProcedure;
                
                
                
                DbParameter param_dummy = ClassConnectionProvider.GetDatabaseParameter("dummy", typeof(System.Boolean), -1);
				param_dummy.Value = ClassConnectionProvider.FromValueToSqlModelType(_dummy);
				command.Parameters.Add(param_dummy);
				
                
                ClassConnectionProvider.OnBeforeExecuted(command);

                DbDataReader dr = command.ExecuteReader(global::System.Data.CommandBehavior.CloseConnection);

                while (dr.Read())
                {
					PurchaseLineUndoRedo o = new PurchaseLineUndoRedo();
                
					o.__databaseState = RowState.Initialized;
                    o._UndoRedoId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoId"], typeof(System.Int64));
				o._IsCreatedUndoDeletes = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsCreatedUndoDeletes"], typeof(System.Boolean));
				o._IsDeletedUndoCreates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsDeletedUndoCreates"], typeof(System.Boolean));
				o._IsUpdatedUndoUpdates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUpdatedUndoUpdates"], typeof(System.Boolean));
				o._IsUndone = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUndone"], typeof(System.Boolean));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._ProductKey = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductKey"], typeof(System.String));
				o._ProductDescription = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductDescription"], typeof(System.String));
				o._PricePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PricePurchased"], typeof(System.Double));
				o._RecurrentFeePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["RecurrentFeePurchased"], typeof(System.Double));
				o._IsPaid = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaid"], typeof(System.Boolean));
				o._PurchaseOrder_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PurchaseOrder_Id"], typeof(System.Int32));
				o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PurchaseLineUndoRedoCollection.Add(o);
                }

                dr.Close();
            }
            
            return _PurchaseLineUndoRedoCollection;
        }
        
        public static PurchaseLineUndoRedoCollection GetAllWithNoFilterPaged(System.Boolean _dummy, long PagingStart, long PagingCount)
        {
			PurchaseLineUndoRedoCollection _PurchaseLineUndoRedoCollection = new PurchaseLineUndoRedoCollection();
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiUnReGeAlWiNoFiPaged", dbconn);
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
					PurchaseLineUndoRedo o = new PurchaseLineUndoRedo();
                
					o.__databaseState = RowState.Initialized;
                    o._UndoRedoId = (System.Int64) global::Platform.Runtime.Utilities.FromSqlToValue(dr["UndoRedoId"], typeof(System.Int64));
				o._IsCreatedUndoDeletes = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsCreatedUndoDeletes"], typeof(System.Boolean));
				o._IsDeletedUndoCreates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsDeletedUndoCreates"], typeof(System.Boolean));
				o._IsUpdatedUndoUpdates = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUpdatedUndoUpdates"], typeof(System.Boolean));
				o._IsUndone = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsUndone"], typeof(System.Boolean));
				o._Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				o._ProductKey = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductKey"], typeof(System.String));
				o._ProductDescription = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductDescription"], typeof(System.String));
				o._PricePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PricePurchased"], typeof(System.Double));
				o._RecurrentFeePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["RecurrentFeePurchased"], typeof(System.Double));
				o._IsPaid = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaid"], typeof(System.Boolean));
				o._PurchaseOrder_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PurchaseOrder_Id"], typeof(System.Int32));
				o._Owner_Name = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Owner_Name"], typeof(System.String));
				
                    
                    _PurchaseLineUndoRedoCollection.Add(o);
                    
                    --PagingCount;
                }

                dr.Close();
            }
            
            return _PurchaseLineUndoRedoCollection;
        }
        
        public static long GetAllWithNoFilterCount(System.Boolean _dummy)
        {
			long count = 0;
			// sql read
			using (DbConnection dbconn = ClassConnectionProvider.GetDatabaseConnection(ClassConnectionString))
            {
				dbconn.Open();
                DbCommand command = ClassConnectionProvider.GetDatabaseCommand("PuLiUnReGeAlWiNoFiCount", dbconn);
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
        
        public PurchaseLineUndoRedo() {}
        
        public PurchaseLineUndoRedo(System.Int64 __UndoRedoId)
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
				DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuLiUnReRead", dbconn);
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
                // int nextIndex = serviceSelectionAlgorithm.Pick(scalingServices, "PuLiUnRe");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuLiUnReRead", dbconn);
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
				_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_ProductKey = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductKey"], typeof(System.String));
				_ProductDescription = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductDescription"], typeof(System.String));
				_PricePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PricePurchased"], typeof(System.Double));
				_RecurrentFeePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["RecurrentFeePurchased"], typeof(System.Double));
				_IsPaid = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaid"], typeof(System.Boolean));
				_PurchaseOrder_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PurchaseOrder_Id"], typeof(System.Int32));
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
                // int nextIndex = serviceSelectionAlgorithm.GetNext(scalingServices, "PuLiUnRe");
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuLiUnReRead", dbconn);
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
				_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_ProductKey = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductKey"], typeof(System.String));
				_ProductDescription = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductDescription"], typeof(System.String));
				_PricePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PricePurchased"], typeof(System.Double));
				_RecurrentFeePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["RecurrentFeePurchased"], typeof(System.Double));
				_IsPaid = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaid"], typeof(System.Boolean));
				_PurchaseOrder_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PurchaseOrder_Id"], typeof(System.Int32));
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
						DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuLiUnReCreate", dbconn);
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
				DbParameter param_PurchaseOrder_Id = ClassConnectionProvider.GetDatabaseParameter("PurchaseOrder_Id", typeof(System.Int32), -1);
				param_PurchaseOrder_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_PurchaseOrder_Id);
				command.Parameters.Add(param_PurchaseOrder_Id);
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
				_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["Id"], typeof(System.Int32));
				_ProductKey = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductKey"], typeof(System.String));
				_ProductDescription = (System.String) global::Platform.Runtime.Utilities.FromSqlToValue(dr["ProductDescription"], typeof(System.String));
				_PricePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PricePurchased"], typeof(System.Double));
				_RecurrentFeePurchased = (System.Double) global::Platform.Runtime.Utilities.FromSqlToValue(dr["RecurrentFeePurchased"], typeof(System.Double));
				_IsPaid = (System.Boolean) global::Platform.Runtime.Utilities.FromSqlToValue(dr["IsPaid"], typeof(System.Boolean));
				_PurchaseOrder_Id = (System.Int32) global::Platform.Runtime.Utilities.FromSqlToValue(dr["PurchaseOrder_Id"], typeof(System.Int32));
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
        
        static public PurchaseLineUndoRedo CreatePurchaseLineUndoRedo(System.Int64 __UndoRedoId)
        {
            PurchaseLineUndoRedo o = new PurchaseLineUndoRedo(__UndoRedoId);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuLiUnReUpdate", dbconn);
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
				DbParameter param_PurchaseOrder_Id = ClassConnectionProvider.GetDatabaseParameter("PurchaseOrder_Id", typeof(System.Int32), -1);
				param_PurchaseOrder_Id.Value = ClassConnectionProvider.FromValueToSqlModelType(_PurchaseOrder_Id);
				command.Parameters.Add(param_PurchaseOrder_Id);
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
					DbCommand command = InstanceConnectionProvider.GetDatabaseCommand("PuLiUnReDelete", dbconn);
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
        
        static public void DeletePurchaseLineUndoRedo(System.Int64 __UndoRedoId)
        {
            PurchaseLineUndoRedo o = new PurchaseLineUndoRedo(__UndoRedoId);
            if (o.Exists) o.Delete();
        }
        
        #endregion
        
        #region Copying instances
        
        public void CopyWithKeysFrom(PurchaseLineUndoRedo _object)
        {
			_UndoRedoId = _object._UndoRedoId;
			_IsCreatedUndoDeletes = _object._IsCreatedUndoDeletes;
			_IsDeletedUndoCreates = _object._IsDeletedUndoCreates;
			_IsUpdatedUndoUpdates = _object._IsUpdatedUndoUpdates;
			_IsUndone = _object._IsUndone;
			_Id = _object._Id;
			_ProductKey = _object._ProductKey;
			_ProductDescription = _object._ProductDescription;
			_PricePurchased = _object._PricePurchased;
			_RecurrentFeePurchased = _object._RecurrentFeePurchased;
			_IsPaid = _object._IsPaid;
			_PurchaseOrder_Id = _object._PurchaseOrder_Id;
			_Owner_Name = _object._Owner_Name;
			
        }
        
        public void CopyWithKeysTo(PurchaseLineUndoRedo _object)
        {
			_object._UndoRedoId = _UndoRedoId;
			_object._IsCreatedUndoDeletes = _IsCreatedUndoDeletes;
			_object._IsDeletedUndoCreates = _IsDeletedUndoCreates;
			_object._IsUpdatedUndoUpdates = _IsUpdatedUndoUpdates;
			_object._IsUndone = _IsUndone;
			_object._Id = _Id;
			_object._ProductKey = _ProductKey;
			_object._ProductDescription = _ProductDescription;
			_object._PricePurchased = _PricePurchased;
			_object._RecurrentFeePurchased = _RecurrentFeePurchased;
			_object._IsPaid = _IsPaid;
			_object._PurchaseOrder_Id = _PurchaseOrder_Id;
			_object._Owner_Name = _Owner_Name;
			
        }
        
        static public void CopyWithKeysObject(PurchaseLineUndoRedo _objectFrom, PurchaseLineUndoRedo _objectTo)
        {
			_objectFrom.CopyWithKeysTo(_objectTo);
        }
        
        public void CopyFrom(PurchaseLineUndoRedo _object)
        {
			_IsCreatedUndoDeletes = _object._IsCreatedUndoDeletes;
			_IsDeletedUndoCreates = _object._IsDeletedUndoCreates;
			_IsUpdatedUndoUpdates = _object._IsUpdatedUndoUpdates;
			_IsUndone = _object._IsUndone;
			_Id = _object._Id;
			_ProductKey = _object._ProductKey;
			_ProductDescription = _object._ProductDescription;
			_PricePurchased = _object._PricePurchased;
			_RecurrentFeePurchased = _object._RecurrentFeePurchased;
			_IsPaid = _object._IsPaid;
			_PurchaseOrder_Id = _object._PurchaseOrder_Id;
			_Owner_Name = _object._Owner_Name;
			
        }
        
        public void CopyTo(PurchaseLineUndoRedo _object)
        {
			_object._IsCreatedUndoDeletes = _IsCreatedUndoDeletes;
			_object._IsDeletedUndoCreates = _IsDeletedUndoCreates;
			_object._IsUpdatedUndoUpdates = _IsUpdatedUndoUpdates;
			_object._IsUndone = _IsUndone;
			_object._Id = _Id;
			_object._ProductKey = _ProductKey;
			_object._ProductDescription = _ProductDescription;
			_object._PricePurchased = _PricePurchased;
			_object._RecurrentFeePurchased = _RecurrentFeePurchased;
			_object._IsPaid = _IsPaid;
			_object._PurchaseOrder_Id = _PurchaseOrder_Id;
			_object._Owner_Name = _Owner_Name;
			
        }
        
        static public void CopyObject(PurchaseLineUndoRedo _objectFrom, PurchaseLineUndoRedo _objectTo)
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

                    Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(PurchaseLineUndoRedo).FullName);
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

                Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions options = new Platform.Module.UndoRedo.Services.Packages.UndoRedoOptions(typeof(PurchaseLineUndoRedo).FullName);
                if (!options.Exists)
				{
                    undoRedoMaximumObjects = options.ItemsAllowed = 1000;
				}

                options.IsEnabled = isUndoRedoSupported;
                options.Update();
			}
		}
		
		static void MarkUndo(PurchaseLineUndoRedo _object, bool IsCreatedUndoDeletes, bool IsDeletedUndoCreates, bool IsUpdatedUndoUpdates)
        {
			// Delete already undone entries (steps that have been undone but not redone)
			PurchaseLineUndoRedoUndoRedoCollection allUndidAndNotRedoneEntries = PurchaseLineUndoRedoUndoRedo.GetAllFilterByIsUndone(true);
			for(int n = 0; n < allUndidAndNotRedoneEntries.Count; ++n)
				allUndidAndNotRedoneEntries[n].Delete();

			// Create one undo entry
			PurchaseLineUndoRedoUndoRedo _urobject = new PurchaseLineUndoRedoUndoRedo();
			// Enumerate all properties and add them to the UndoRedo object
			_urobject.UndoRedoId = _object._UndoRedoId;
			_urobject.IsCreatedUndoDeletes = _object._IsCreatedUndoDeletes;
			_urobject.IsDeletedUndoCreates = _object._IsDeletedUndoCreates;
			_urobject.IsUpdatedUndoUpdates = _object._IsUpdatedUndoUpdates;
			_urobject.IsUndone = _object._IsUndone;
			_urobject.Id = _object._Id;
			_urobject.ProductKey = _object._ProductKey;
			_urobject.ProductDescription = _object._ProductDescription;
			_urobject.PricePurchased = _object._PricePurchased;
			_urobject.RecurrentFeePurchased = _object._RecurrentFeePurchased;
			_urobject.IsPaid = _object._IsPaid;
			_urobject.PurchaseOrder_Id = _object._PurchaseOrder_Id;
			_urobject.Owner_Name = _object._Owner_Name;
			
			_urobject.IsCreatedUndoDeletes = IsCreatedUndoDeletes;
            _urobject.IsDeletedUndoCreates = IsDeletedUndoCreates;
            _urobject.IsUpdatedUndoUpdates = IsUpdatedUndoUpdates;
            _urobject.Create();

			// Add this to all groups if needed
			Platform.Module.UndoRedo.Services.Packages.Grouping.GroupEntry(typeof(PurchaseLineUndoRedo).FullName, _urobject.UndoRedoId);

			// Check if we have too many - if yes delete the oldest entry
			long count = PurchaseLineUndoRedoUndoRedo.GetAllWithNoFilterCount(true) - undoRedoMaximumObjects;
			if (count > 0)
			{
				PurchaseLineUndoRedoUndoRedoCollection allOldUndoEntries = PurchaseLineUndoRedoUndoRedo.GetAllWithNoFilterOppositeSortingPaged(true, 0, count);
				for(int n = 0; n < allOldUndoEntries.Count; ++n)
					allOldUndoEntries[n].Delete();
			}
        }

		static public void Undo()
        {
			// Load the last undo, and execute it
			PurchaseLineUndoRedoUndoRedoCollection firstUndoEntries = PurchaseLineUndoRedoUndoRedo.GetAllFilterByIsUndonePaged(false, 0, 1);
			if (firstUndoEntries.Count < 1)
				return;

			PurchaseLineUndoRedoUndoRedo _urobject = firstUndoEntries[0];
			
			PurchaseLineUndoRedo _object = new PurchaseLineUndoRedo();
			_object._UndoRedoId = _urobject.UndoRedoId;
			_object._IsCreatedUndoDeletes = _urobject.IsCreatedUndoDeletes;
			_object._IsDeletedUndoCreates = _urobject.IsDeletedUndoCreates;
			_object._IsUpdatedUndoUpdates = _urobject.IsUpdatedUndoUpdates;
			_object._IsUndone = _urobject.IsUndone;
			_object._Id = _urobject.Id;
			_object._ProductKey = _urobject.ProductKey;
			_object._ProductDescription = _urobject.ProductDescription;
			_object._PricePurchased = _urobject.PricePurchased;
			_object._RecurrentFeePurchased = _urobject.RecurrentFeePurchased;
			_object._IsPaid = _urobject.IsPaid;
			_object._PurchaseOrder_Id = _urobject.PurchaseOrder_Id;
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
			PurchaseLineUndoRedoUndoRedoCollection firstEntryToRedoEntries = PurchaseLineUndoRedoUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(true, 0, 1);
			if (firstEntryToRedoEntries.Count < 1)
				return;

			PurchaseLineUndoRedoUndoRedo _urobject = firstEntryToRedoEntries[0];
			
			PurchaseLineUndoRedo _object = new PurchaseLineUndoRedo();
			_object._UndoRedoId = _urobject.UndoRedoId;
			_object._IsCreatedUndoDeletes = _urobject.IsCreatedUndoDeletes;
			_object._IsDeletedUndoCreates = _urobject.IsDeletedUndoCreates;
			_object._IsUpdatedUndoUpdates = _urobject.IsUpdatedUndoUpdates;
			_object._IsUndone = _urobject.IsUndone;
			_object._Id = _urobject.Id;
			_object._ProductKey = _urobject.ProductKey;
			_object._ProductDescription = _urobject.ProductDescription;
			_object._PricePurchased = _urobject.PricePurchased;
			_object._RecurrentFeePurchased = _urobject.RecurrentFeePurchased;
			_object._IsPaid = _urobject.IsPaid;
			_object._PurchaseOrder_Id = _urobject.PurchaseOrder_Id;
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
    /// Defines the contract for the PurchaseLineUndoRedoCollection class
    /// </summary>
    [ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [Guid("5a360cf3-5035-5fb3-d6f7-d368ca187f6b")]
    public interface IPurchaseLineUndoRedoCollection : IEnumerable<PurchaseLineUndoRedo>
    {
        int IndexOf(PurchaseLineUndoRedo item);
        void Insert(int index, PurchaseLineUndoRedo item);
        void RemoveAt(int index);
        PurchaseLineUndoRedo this[int index] { get; set; }
        void Add(PurchaseLineUndoRedo item);
        void Clear();
        bool Contains(PurchaseLineUndoRedo item);
        void CopyTo(PurchaseLineUndoRedo[] array, int arrayIndex);
        int Count { get; }
        bool IsReadOnly { get; }
        bool Remove(PurchaseLineUndoRedo item);
    }

    /// <summary>
    /// Provides the implementation of the class that represents a list of Services.Packages.PurchaseLineUndoRedo
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("3898c1a6-1b1d-29e6-f619-33a4fa2df2d7")]
    [DataContract]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    [Serializable]
    public class PurchaseLineUndoRedoCollection : IPurchaseLineUndoRedoCollection, IList<PurchaseLineUndoRedo>, IHierarchicalEnumerable
    {
        List<PurchaseLineUndoRedo> _list = new List<PurchaseLineUndoRedo>();
        
        public static implicit operator List<PurchaseLineUndoRedo>(PurchaseLineUndoRedoCollection collection)
        {
            return collection._list;
        }

        #region IList<PurchaseLineUndoRedo> Members

        public int IndexOf(PurchaseLineUndoRedo item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, PurchaseLineUndoRedo item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public PurchaseLineUndoRedo this[int index]
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

        #region ICollection<PurchaseLineUndoRedo> Members

        public void Add(PurchaseLineUndoRedo item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(PurchaseLineUndoRedo item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(PurchaseLineUndoRedo[] array, int arrayIndex)
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

        public bool Remove(PurchaseLineUndoRedo item)
        {
            return _list.Remove(item);
        }

        #endregion

        #region IEnumerable<PurchaseLineUndoRedo> Members

        public IEnumerator<PurchaseLineUndoRedo> GetEnumerator()
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
	/// that share Services.Packages.PurchaseLineUndoRedo objects.
	/// </summary>
    /// <example>
    /// You can use that in the header of an asmx file like this:
    /// <%@ WebService Language="C#" Class="Services.Packages.Web.PurchaseLineUndoRedoWebService" %>
    /// </example>
	[WebService(Namespace="http://services.msd.com")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	[ComVisible(false)]
    sealed public class PurchaseLineUndoRedoWebService : WebService, IPurchaseLineUndoRedoService
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
        public bool Exists(PurchaseLineUndoRedo _PurchaseLineUndoRedo)
        {
			return _PurchaseLineUndoRedo.Exists;
        }
		
		[WebMethod]
		public PurchaseLineUndoRedo Read(System.Int64 __UndoRedoId)
		{
			return new PurchaseLineUndoRedo(__UndoRedoId);
		}
		
		[WebMethod]
        public PurchaseLineUndoRedo Reload(PurchaseLineUndoRedo _PurchaseLineUndoRedo)
        {
			_PurchaseLineUndoRedo.Reload();
			return _PurchaseLineUndoRedo;
        }
		
		[WebMethod]
        public PurchaseLineUndoRedo Create(System.Int64 __UndoRedoId)
        {
			return PurchaseLineUndoRedo.CreatePurchaseLineUndoRedo(__UndoRedoId);
        }
        
        [WebMethod]
        public void Delete(System.Int64 __UndoRedoId)
        {
			PurchaseLineUndoRedo.DeletePurchaseLineUndoRedo(__UndoRedoId);
        }
        
        [WebMethod]
        public void UpdateObject(PurchaseLineUndoRedo _PurchaseLineUndoRedo)
        {
			_PurchaseLineUndoRedo.Update();
        }
		
		[WebMethod]
        public void CreateObject(PurchaseLineUndoRedo _PurchaseLineUndoRedo)
        {
			_PurchaseLineUndoRedo.Create();
        }
        
        [WebMethod]
        public void DeleteObject(PurchaseLineUndoRedo _PurchaseLineUndoRedo)
        {
			_PurchaseLineUndoRedo.Delete();
        }
		
		[WebMethod]
        public void Undo()
        {
			PurchaseLineUndoRedo.Undo();
        }
        
        [WebMethod]
        public void Redo()
        {
			PurchaseLineUndoRedo.Redo();
        }
		[WebMethod]
		public PurchaseLineUndoRedoCollection GetAllFilterByIsUndone(System.Boolean IsUndone )
		{
			return PurchaseLineUndoRedo.GetAllFilterByIsUndone(IsUndone );
		}
		[WebMethod]
		public PurchaseLineUndoRedoCollection GetAllFilterByIsUndonePaged(System.Boolean IsUndone , long PagingStart, long PagingCount)
		{
			return PurchaseLineUndoRedo.GetAllFilterByIsUndonePaged(IsUndone , PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetAllFilterByIsUndoneCount(System.Boolean IsUndone )
		{
			return PurchaseLineUndoRedo.GetAllFilterByIsUndoneCount(IsUndone );
		}
		[WebMethod]
		public PurchaseLineUndoRedoCollection GetAllFilterByIsUndoneOppositeOrder(System.Boolean IsUndone )
		{
			return PurchaseLineUndoRedo.GetAllFilterByIsUndoneOppositeOrder(IsUndone );
		}
		[WebMethod]
		public PurchaseLineUndoRedoCollection GetAllFilterByIsUndoneOppositeOrderPaged(System.Boolean IsUndone , long PagingStart, long PagingCount)
		{
			return PurchaseLineUndoRedo.GetAllFilterByIsUndoneOppositeOrderPaged(IsUndone , PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetAllFilterByIsUndoneOppositeOrderCount(System.Boolean IsUndone )
		{
			return PurchaseLineUndoRedo.GetAllFilterByIsUndoneOppositeOrderCount(IsUndone );
		}
		[WebMethod]
		public PurchaseLineUndoRedoCollection GetAllWithNoFilterOppositeSorting(System.Boolean dummy )
		{
			return PurchaseLineUndoRedo.GetAllWithNoFilterOppositeSorting(dummy );
		}
		[WebMethod]
		public PurchaseLineUndoRedoCollection GetAllWithNoFilterOppositeSortingPaged(System.Boolean dummy , long PagingStart, long PagingCount)
		{
			return PurchaseLineUndoRedo.GetAllWithNoFilterOppositeSortingPaged(dummy , PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetAllWithNoFilterOppositeSortingCount(System.Boolean dummy )
		{
			return PurchaseLineUndoRedo.GetAllWithNoFilterOppositeSortingCount(dummy );
		}
		[WebMethod]
		public PurchaseLineUndoRedoCollection GetAllWithNoFilter(System.Boolean dummy )
		{
			return PurchaseLineUndoRedo.GetAllWithNoFilter(dummy );
		}
		[WebMethod]
		public PurchaseLineUndoRedoCollection GetAllWithNoFilterPaged(System.Boolean dummy , long PagingStart, long PagingCount)
		{
			return PurchaseLineUndoRedo.GetAllWithNoFilterPaged(dummy , PagingStart, PagingCount);
		}
		[WebMethod]
		public long GetAllWithNoFilterCount(System.Boolean dummy )
		{
			return PurchaseLineUndoRedo.GetAllWithNoFilterCount(dummy );
		}

	}
	
	/// <summary>
	/// The WebService client service
	/// </summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.Web.Services.WebServiceBindingAttribute(Name="PurchaseLineUndoRedoWebServiceSoap", Namespace="http://services.msd.com")]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(MarshalByRefObject))]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
    [Guid("678aaa95-c6e3-3cd8-350c-314ea0a7868c")]
    sealed public class PurchaseLineUndoRedoWebServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol, IPurchaseLineUndoRedoService
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
		public PurchaseLineUndoRedoWebServiceClient(string url)
		{
			this.Url = url;
		}
		
		/// <summary>
        /// Initializes a web service client without a specific service url.
        /// If the GlobalUrl value is set, is been used as the Url.
        /// </summary>
		public PurchaseLineUndoRedoWebServiceClient()
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
		public bool Exists(PurchaseLineUndoRedo _PurchaseLineUndoRedo)
        {
			object[] results = this.Invoke("Exists", new object[] {_PurchaseLineUndoRedo});
			return ((bool)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Read", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineUndoRedo Read(System.Int64 __UndoRedoId)
		{
			object[] results = this.Invoke("Read", new object[] {__UndoRedoId});
			return ((PurchaseLineUndoRedo)(results[0]));
		}
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Reload", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineUndoRedo Reload(PurchaseLineUndoRedo _PurchaseLineUndoRedo)
        {
			object[] results = this.Invoke("Reload", new object[] {_PurchaseLineUndoRedo});
			return ((PurchaseLineUndoRedo)(results[0]));
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Create", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineUndoRedo Create(System.Int64 __UndoRedoId)
        {
			object[] results = this.Invoke("Create", new object[] {__UndoRedoId});
			return ((PurchaseLineUndoRedo)(results[0]));
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/Delete", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Delete(System.Int64 __UndoRedoId)
        {
			this.Invoke("Delete", new object[] {__UndoRedoId});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/UpdateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateObject(PurchaseLineUndoRedo _PurchaseLineUndoRedo)
        {
			this.Invoke("UpdateObject", new object[] {_PurchaseLineUndoRedo});
			return;
        }
		
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/CreateObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void CreateObject(PurchaseLineUndoRedo _PurchaseLineUndoRedo)
        {
			this.Invoke("CreateObject", new object[] {_PurchaseLineUndoRedo});
			return;
        }
        
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/DeleteObject", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteObject(PurchaseLineUndoRedo _PurchaseLineUndoRedo)
        {
			this.Invoke("DeleteObject", new object[] {_PurchaseLineUndoRedo});
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
		public PurchaseLineUndoRedoCollection GetAllFilterByIsUndone(System.Boolean IsUndone ) {
			object[] results = this.Invoke("GetAllFilterByIsUndone", new object[] {IsUndone});
			return ((PurchaseLineUndoRedoCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllFilterByIsUndonePaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineUndoRedoCollection GetAllFilterByIsUndonePaged(System.Boolean IsUndone , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetAllFilterByIsUndonePaged", new object[] {IsUndone,PagingStart,PagingCount});
			return ((PurchaseLineUndoRedoCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllFilterByIsUndoneCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetAllFilterByIsUndoneCount(System.Boolean IsUndone ) {
			object[] results = this.Invoke("GetAllFilterByIsUndoneCount", new object[] {IsUndone});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllFilterByIsUndoneOppositeOrder", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineUndoRedoCollection GetAllFilterByIsUndoneOppositeOrder(System.Boolean IsUndone ) {
			object[] results = this.Invoke("GetAllFilterByIsUndoneOppositeOrder", new object[] {IsUndone});
			return ((PurchaseLineUndoRedoCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllFilterByIsUndoneOppositeOrderPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineUndoRedoCollection GetAllFilterByIsUndoneOppositeOrderPaged(System.Boolean IsUndone , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetAllFilterByIsUndoneOppositeOrderPaged", new object[] {IsUndone,PagingStart,PagingCount});
			return ((PurchaseLineUndoRedoCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllFilterByIsUndoneOppositeOrderCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetAllFilterByIsUndoneOppositeOrderCount(System.Boolean IsUndone ) {
			object[] results = this.Invoke("GetAllFilterByIsUndoneOppositeOrderCount", new object[] {IsUndone});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllWithNoFilterOppositeSorting", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineUndoRedoCollection GetAllWithNoFilterOppositeSorting(System.Boolean dummy ) {
			object[] results = this.Invoke("GetAllWithNoFilterOppositeSorting", new object[] {dummy});
			return ((PurchaseLineUndoRedoCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllWithNoFilterOppositeSortingPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineUndoRedoCollection GetAllWithNoFilterOppositeSortingPaged(System.Boolean dummy , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetAllWithNoFilterOppositeSortingPaged", new object[] {dummy,PagingStart,PagingCount});
			return ((PurchaseLineUndoRedoCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllWithNoFilterOppositeSortingCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetAllWithNoFilterOppositeSortingCount(System.Boolean dummy ) {
			object[] results = this.Invoke("GetAllWithNoFilterOppositeSortingCount", new object[] {dummy});
			return ((long)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllWithNoFilter", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineUndoRedoCollection GetAllWithNoFilter(System.Boolean dummy ) {
			object[] results = this.Invoke("GetAllWithNoFilter", new object[] {dummy});
			return ((PurchaseLineUndoRedoCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllWithNoFilterPaged", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public PurchaseLineUndoRedoCollection GetAllWithNoFilterPaged(System.Boolean dummy , long PagingStart, long PagingCount) {
			object[] results = this.Invoke("GetAllWithNoFilterPaged", new object[] {dummy,PagingStart,PagingCount});
			return ((PurchaseLineUndoRedoCollection)(results[0]));
		}
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://services.msd.com/GetAllWithNoFilterCount", RequestNamespace="http://services.msd.com", ResponseNamespace="http://services.msd.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public long GetAllWithNoFilterCount(System.Boolean dummy ) {
			object[] results = this.Invoke("GetAllWithNoFilterCount", new object[] {dummy});
			return ((long)(results[0]));
		}

	}
	
	
} // namespace Web

} // namespace Services.Packages
