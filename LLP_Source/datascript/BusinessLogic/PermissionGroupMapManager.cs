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
    /// Business logic processing for PermissionGroupMap.
    /// </summary>    
	public partial class PermissionGroupMapManager
	{
	
		/// <summary>
        /// Update PermissionGroupMap Object.
        /// Data manipulation processing for: new, deleted, updated PermissionGroupMap
        /// </summary>
        /// <param name="permissionGroupMapObject"></param>
        /// <returns></returns>
        public bool Update(PermissionGroupMap permissionGroupMapObject)
        {
			bool success = false;
			
			success = UpdateBase(permissionGroupMapObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of PermissionGroupMap Object.
        /// </summary>
        /// <param name="permissionGroupMapObject"></param>
        /// <returns></returns>
        public void FillChilds(PermissionGroupMap permissionGroupMapObject)
        {
			///Fill external information of Childs of PermissionGroupMapObject
        }
	}	
}
