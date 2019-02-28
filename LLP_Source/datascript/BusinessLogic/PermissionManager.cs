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
    /// Business logic processing for Permission.
    /// </summary>    
	public partial class PermissionManager
	{
	
		/// <summary>
        /// Update Permission Object.
        /// Data manipulation processing for: new, deleted, updated Permission
        /// </summary>
        /// <param name="permissionObject"></param>
        /// <returns></returns>
        public bool Update(Permission permissionObject)
        {
			bool success = false;
			
			success = UpdateBase(permissionObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of Permission Object.
        /// </summary>
        /// <param name="permissionObject"></param>
        /// <returns></returns>
        public void FillChilds(Permission permissionObject)
        {
			///Fill external information of Childs of PermissionObject
        }
	}	
}
