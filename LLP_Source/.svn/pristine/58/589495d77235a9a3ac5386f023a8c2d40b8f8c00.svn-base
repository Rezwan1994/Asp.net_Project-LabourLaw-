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
    /// Business logic processing for UserPermission.
    /// </summary>    
	public partial class UserPermissionManager
	{
	
		/// <summary>
        /// Update UserPermission Object.
        /// Data manipulation processing for: new, deleted, updated UserPermission
        /// </summary>
        /// <param name="userPermissionObject"></param>
        /// <returns></returns>
        public bool Update(UserPermission userPermissionObject)
        {
			bool success = false;
			
			success = UpdateBase(userPermissionObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of UserPermission Object.
        /// </summary>
        /// <param name="userPermissionObject"></param>
        /// <returns></returns>
        public void FillChilds(UserPermission userPermissionObject)
        {
			///Fill external information of Childs of UserPermissionObject
        }
	}	
}
