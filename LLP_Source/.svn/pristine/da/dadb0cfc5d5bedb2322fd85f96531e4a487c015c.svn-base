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
	public partial class InventoryManager
	{
	
		/// <summary>
        /// Update Inventory Object.
        /// Data manipulation processing for: new, deleted, updated Inventory
        /// </summary>
        /// <param name="inventoryObject"></param>
        /// <returns></returns>
        public bool Update(Inventory inventoryObject)
        {
			bool success = false;
			
			success = UpdateBase(inventoryObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of Inventory Object.
        /// </summary>
        /// <param name="inventoryObject"></param>
        /// <returns></returns>
        public void FillChilds(Inventory inventoryObject)
        {
			///Fill external information of Childs of InventoryObject
        }
	}	
}
