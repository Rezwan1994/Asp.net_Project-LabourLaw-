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
    /// Business logic processing for CompanyBranch.
    /// </summary>    
	public partial class CompanyBranchManager
	{
	
		/// <summary>
        /// Update CompanyBranch Object.
        /// Data manipulation processing for: new, deleted, updated CompanyBranch
        /// </summary>
        /// <param name="companyBranchObject"></param>
        /// <returns></returns>
        public bool Update(CompanyBranch companyBranchObject)
        {
			bool success = false;
			
			success = UpdateBase(companyBranchObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of CompanyBranch Object.
        /// </summary>
        /// <param name="companyBranchObject"></param>
        /// <returns></returns>
        public void FillChilds(CompanyBranch companyBranchObject)
        {
			///Fill external information of Childs of CompanyBranchObject
        }
	}	
}
