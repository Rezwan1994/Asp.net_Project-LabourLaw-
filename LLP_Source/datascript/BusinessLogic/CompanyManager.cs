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
    /// Business logic processing for Company.
    /// </summary>    
	public partial class CompanyManager
	{
	
		/// <summary>
        /// Update Company Object.
        /// Data manipulation processing for: new, deleted, updated Company
        /// </summary>
        /// <param name="companyObject"></param>
        /// <returns></returns>
        public bool Update(Company companyObject)
        {
			bool success = false;
			
			success = UpdateBase(companyObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of Company Object.
        /// </summary>
        /// <param name="companyObject"></param>
        /// <returns></returns>
        public void FillChilds(Company companyObject)
        {
			///Fill external information of Childs of CompanyObject
        }
	}	
}
