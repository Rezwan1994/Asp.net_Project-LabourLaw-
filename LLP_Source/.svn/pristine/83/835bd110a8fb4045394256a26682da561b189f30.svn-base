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
    /// Business logic processing for UserActivity.
    /// </summary>    
	public partial class UserActivityManager
	{
	
		/// <summary>
        /// Update UserActivity Object.
        /// Data manipulation processing for: new, deleted, updated UserActivity
        /// </summary>
        /// <param name="userActivityObject"></param>
        /// <returns></returns>
        public bool Update(UserActivity userActivityObject)
        {
			bool success = false;
			
			success = UpdateBase(userActivityObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of UserActivity Object.
        /// </summary>
        /// <param name="userActivityObject"></param>
        /// <returns></returns>
        public void FillChilds(UserActivity userActivityObject)
        {
			///Fill external information of Childs of UserActivityObject
        }
	}	
}
