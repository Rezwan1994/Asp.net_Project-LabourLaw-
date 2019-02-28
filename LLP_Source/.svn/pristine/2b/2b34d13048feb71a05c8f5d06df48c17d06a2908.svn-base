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
    /// Business logic processing for UserCompany.
    /// </summary>    
	public partial class UserCompanyManager
	{
	
		/// <summary>
        /// Update UserCompany Object.
        /// Data manipulation processing for: new, deleted, updated UserCompany
        /// </summary>
        /// <param name="userCompanyObject"></param>
        /// <returns></returns>
        public bool Update(UserCompany userCompanyObject)
        {
			bool success = false;
			
			success = UpdateBase(userCompanyObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of UserCompany Object.
        /// </summary>
        /// <param name="userCompanyObject"></param>
        /// <returns></returns>
        public void FillChilds(UserCompany userCompanyObject)
        {
			///Fill external information of Childs of UserCompanyObject
        }
	}	
}
