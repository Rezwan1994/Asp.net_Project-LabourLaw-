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
    /// Business logic processing for PermissionGroup.
    /// </summary>    
	public partial class PermissionGroupManager
	{
	
		/// <summary>
        /// Update PermissionGroup Object.
        /// Data manipulation processing for: new, deleted, updated PermissionGroup
        /// </summary>
        /// <param name="permissionGroupObject"></param>
        /// <returns></returns>
        public bool Update(PermissionGroup permissionGroupObject)
        {
			bool success = false;
			
			success = UpdateBase(permissionGroupObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of PermissionGroup Object.
        /// </summary>
        /// <param name="permissionGroupObject"></param>
        /// <returns></returns>
        public void FillChilds(PermissionGroup permissionGroupObject)
        {
			///Fill external information of Childs of PermissionGroupObject
        }
	}	
}
