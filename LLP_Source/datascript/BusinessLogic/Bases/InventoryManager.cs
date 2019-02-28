using System;
using System.Data.SqlClient;

using LLP.Framework;
using LLP.Framework.Exceptions;
using LLP.Entities;
using LLP.Entities.Bases;
using LLP.Entities.List;
using LLP.DataAccess;

namespace LLP.BusinessLogic
{
	/// <summary>
    /// Business logic processing for Inventory.
    /// </summary>    
	public partial class InventoryManager : BaseManager
	{
	
		#region Constructors
		public InventoryManager(ClientContext context) : base(context) { }
		public InventoryManager(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
		
		#region Insert Method		
		/// <summary>
        /// Insert new inventory.
        /// data manipulation for insertion of Inventory
        /// </summary>
        /// <param name="inventoryObject"></param>
        /// <returns></returns>
        private bool Insert(Inventory inventoryObject)
        {
            // new inventory
            using (InventoryDataAccess data = new InventoryDataAccess(ClientContext))
            {
                // insert to inventoryObject
                Int32 _Id = data.Insert(inventoryObject);
                // if successful, process
                if (_Id > 0)
                {
                    inventoryObject.Id = _Id;
                    return true;
                }
                else
                    return false;
            }
        }
		#endregion
		
		#region Update Method
		
		/// <summary>
        /// Update base of Inventory Object.
        /// Data manipulation processing for: new, deleted, updated Inventory
        /// </summary>
        /// <param name="inventoryObject"></param>
        /// <returns></returns>
        public bool UpdateBase(Inventory inventoryObject)
        {
            // use of switch for different types of DML
            switch (inventoryObject.RowState)
            {
                // insert new rows
                case BaseBusinessEntity.RowStateEnum.NewRow:
                    return Insert(inventoryObject);
                // delete rows
                case BaseBusinessEntity.RowStateEnum.DeletedRow:
                    return Delete(inventoryObject.Id);
            }
            // update rows
            using (InventoryDataAccess data = new InventoryDataAccess(ClientContext))
            {
                return (data.Update(inventoryObject) > 0);
            }
        }
		
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Delete operation for Inventory
        /// <param name="_Id"></param>
        /// <returns></returns>
        private bool Delete(Int32 _Id)
        {
            using (InventoryDataAccess data = new InventoryDataAccess(ClientContext))
            {
                // return if code > 0
                return (data.Delete(_Id) > 0);
            }
        }
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieve Inventory data using unique ID
        /// </summary>
        /// <param name="_Id"></param>
        /// <returns>Inventory Object</returns>
        public Inventory Get(Int32 _Id)
        {
            using (InventoryDataAccess data = new InventoryDataAccess(ClientContext))
            {
                return data.Get(_Id);
            }
        }
		
		
		/// <summary>
        /// Retrieve detail information for a Inventory .
        /// Detail child data includes:
        /// last updated on:
        /// change description:
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="fillChild"></param>
        /// <returns></returns>
        public Inventory Get(Int32 _Id, bool fillChild)
        {
            Inventory inventoryObject;
            inventoryObject = Get(_Id);
            
            if (inventoryObject != null && fillChild)
            {
                // populate child data for a inventoryObject
                FillInventoryWithChilds(inventoryObject, fillChild);
            }

            return inventoryObject;
        }
		
		/// <summary>
        /// populates a Inventory with its child entities
        /// </summary>
        /// <param name="inventory"></param>
		/// <param name="fillChilds"></param>
        private void FillInventoryWithChilds(Inventory inventoryObject, bool fillChilds)
        {
            // populate child data for a inventoryObject
            if (inventoryObject != null)
            {
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieve list of Inventory.
        /// no parameters required to be passed in.
        /// </summary>
        /// <returns>List of Inventory</returns>
        public InventoryList GetAll()
        {
            using (InventoryDataAccess data = new InventoryDataAccess(ClientContext))
            {
                return data.GetAll();
            }
        }
		
		/// <summary>
        /// Retrieve list of Inventory.
        /// </summary>
        /// <param name="fillChild"></param>
        /// <returns>List of Inventory</returns>
        public InventoryList GetAll(bool fillChild)
        {
			InventoryList inventoryList = new InventoryList();
            using (InventoryDataAccess data = new InventoryDataAccess(ClientContext))
            {
                inventoryList = data.GetAll();
            }
			if (fillChild)
            {
				foreach (Inventory inventoryObject in inventoryList)
                {
					FillInventoryWithChilds(inventoryObject, fillChild);
				}
			}
			return inventoryList;
        }
		
		/// <summary>
        /// Retrieve list of Inventory  by PageRequest.
        /// <param name="request"></param>
        /// </summary>
        /// <returns>List of Inventory</returns>
        public InventoryList GetPaged(PagedRequest request)
        {
            using (InventoryDataAccess data = new InventoryDataAccess(ClientContext))
            {
                return data.GetPaged(request);
            }
        }
		
		/// <summary>
        /// Retrieve list of Inventory  by query String.
        /// <param name="query"></param>
        /// </summary>
        /// <returns>List of Inventory</returns>
        public InventoryList GetByQuery(String query)
        {
            using (InventoryDataAccess data = new InventoryDataAccess(ClientContext))
            {
                return data.GetByQuery(query);
            }
        }
		#region Get Inventory Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of Inventory
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			using (InventoryDataAccess data = new InventoryDataAccess(ClientContext))
            {
                return data.GetMaxId();
            }
		}
		
		#endregion
		
		#region Get Inventory Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of Inventory
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			using (InventoryDataAccess data = new InventoryDataAccess(ClientContext))
            {
                return data.GetRowCount();
            }
		}
		
		#endregion
	
		
		#endregion
	}	
}
