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
    /// Business logic processing for UserLogin.
    /// </summary>    
	public partial class UserLoginManager
	{
	
		/// <summary>
        /// Update UserLogin Object.
        /// Data manipulation processing for: new, deleted, updated UserLogin
        /// </summary>
        /// <param name="userLoginObject"></param>
        /// <returns></returns>
        public bool Update(UserLogin userLoginObject)
        {
			bool success = false;
			
			success = UpdateBase(userLoginObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of UserLogin Object.
        /// </summary>
        /// <param name="userLoginObject"></param>
        /// <returns></returns>
        public void FillChilds(UserLogin userLoginObject)
        {
			///Fill external information of Childs of UserLoginObject
        }
	}	
}
