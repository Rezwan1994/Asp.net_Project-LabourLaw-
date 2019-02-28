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
    /// Business logic processing for UserBranch.
    /// </summary>    
	public partial class UserBranchManager
	{
	
		/// <summary>
        /// Update UserBranch Object.
        /// Data manipulation processing for: new, deleted, updated UserBranch
        /// </summary>
        /// <param name="userBranchObject"></param>
        /// <returns></returns>
        public bool Update(UserBranch userBranchObject)
        {
			bool success = false;
			
			success = UpdateBase(userBranchObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of UserBranch Object.
        /// </summary>
        /// <param name="userBranchObject"></param>
        /// <returns></returns>
        public void FillChilds(UserBranch userBranchObject)
        {
			///Fill external information of Childs of UserBranchObject
        }
	}	
}
