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
	public partial class CompanyBranchManager : BaseManager
	{
	
		#region Constructors
		public CompanyBranchManager(ClientContext context) : base(context) { }
		public CompanyBranchManager(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
		
		#region Insert Method		
		/// <summary>
        /// Insert new companyBranch.
        /// data manipulation for insertion of CompanyBranch
        /// </summary>
        /// <param name="companyBranchObject"></param>
        /// <returns></returns>
        private bool Insert(CompanyBranch companyBranchObject)
        {
            // new companyBranch
            using (CompanyBranchDataAccess data = new CompanyBranchDataAccess(ClientContext))
            {
                // insert to companyBranchObject
                Int32 _Id = data.Insert(companyBranchObject);
                // if successful, process
                if (_Id > 0)
                {
                    companyBranchObject.Id = _Id;
                    return true;
                }
                else
                    return false;
            }
        }
		#endregion
		
		#region Update Method
		
		/// <summary>
        /// Update base of CompanyBranch Object.
        /// Data manipulation processing for: new, deleted, updated CompanyBranch
        /// </summary>
        /// <param name="companyBranchObject"></param>
        /// <returns></returns>
        public bool UpdateBase(CompanyBranch companyBranchObject)
        {
            // use of switch for different types of DML
            switch (companyBranchObject.RowState)
            {
                // insert new rows
                case BaseBusinessEntity.RowStateEnum.NewRow:
                    return Insert(companyBranchObject);
                // delete rows
                case BaseBusinessEntity.RowStateEnum.DeletedRow:
                    return Delete(companyBranchObject.Id);
            }
            // update rows
            using (CompanyBranchDataAccess data = new CompanyBranchDataAccess(ClientContext))
            {
                return (data.Update(companyBranchObject) > 0);
            }
        }
		
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Delete operation for CompanyBranch
        /// <param name="_Id"></param>
        /// <returns></returns>
        private bool Delete(Int32 _Id)
        {
            using (CompanyBranchDataAccess data = new CompanyBranchDataAccess(ClientContext))
            {
                // return if code > 0
                return (data.Delete(_Id) > 0);
            }
        }
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieve CompanyBranch data using unique ID
        /// </summary>
        /// <param name="_Id"></param>
        /// <returns>CompanyBranch Object</returns>
        public CompanyBranch Get(Int32 _Id)
        {
            using (CompanyBranchDataAccess data = new CompanyBranchDataAccess(ClientContext))
            {
                return data.Get(_Id);
            }
        }
		
		
		/// <summary>
        /// Retrieve detail information for a CompanyBranch .
        /// Detail child data includes:
        /// last updated on:
        /// change description:
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="fillChild"></param>
        /// <returns></returns>
        public CompanyBranch Get(Int32 _Id, bool fillChild)
        {
            CompanyBranch companyBranchObject;
            companyBranchObject = Get(_Id);
            
            if (companyBranchObject != null && fillChild)
            {
                // populate child data for a companyBranchObject
                FillCompanyBranchWithChilds(companyBranchObject, fillChild);
            }

            return companyBranchObject;
        }
		
		/// <summary>
        /// populates a CompanyBranch with its child entities
        /// </summary>
        /// <param name="companyBranch"></param>
		/// <param name="fillChilds"></param>
        private void FillCompanyBranchWithChilds(CompanyBranch companyBranchObject, bool fillChilds)
        {
            // populate child data for a companyBranchObject
            if (companyBranchObject != null)
            {
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieve list of CompanyBranch.
        /// no parameters required to be passed in.
        /// </summary>
        /// <returns>List of CompanyBranch</returns>
        public CompanyBranchList GetAll()
        {
            using (CompanyBranchDataAccess data = new CompanyBranchDataAccess(ClientContext))
            {
                return data.GetAll();
            }
        }
		
		/// <summary>
        /// Retrieve list of CompanyBranch.
        /// </summary>
        /// <param name="fillChild"></param>
        /// <returns>List of CompanyBranch</returns>
        public CompanyBranchList GetAll(bool fillChild)
        {
			CompanyBranchList companyBranchList = new CompanyBranchList();
            using (CompanyBranchDataAccess data = new CompanyBranchDataAccess(ClientContext))
            {
                companyBranchList = data.GetAll();
            }
			if (fillChild)
            {
				foreach (CompanyBranch companyBranchObject in companyBranchList)
                {
					FillCompanyBranchWithChilds(companyBranchObject, fillChild);
				}
			}
			return companyBranchList;
        }
		
		/// <summary>
        /// Retrieve list of CompanyBranch  by PageRequest.
        /// <param name="request"></param>
        /// </summary>
        /// <returns>List of CompanyBranch</returns>
        public CompanyBranchList GetPaged(PagedRequest request)
        {
            using (CompanyBranchDataAccess data = new CompanyBranchDataAccess(ClientContext))
            {
                return data.GetPaged(request);
            }
        }
		
		/// <summary>
        /// Retrieve list of CompanyBranch  by query String.
        /// <param name="query"></param>
        /// </summary>
        /// <returns>List of CompanyBranch</returns>
        public CompanyBranchList GetByQuery(String query)
        {
            using (CompanyBranchDataAccess data = new CompanyBranchDataAccess(ClientContext))
            {
                return data.GetByQuery(query);
            }
        }
		#region Get CompanyBranch Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of CompanyBranch
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			using (CompanyBranchDataAccess data = new CompanyBranchDataAccess(ClientContext))
            {
                return data.GetMaxId();
            }
		}
		
		#endregion
		
		#region Get CompanyBranch Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of CompanyBranch
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			using (CompanyBranchDataAccess data = new CompanyBranchDataAccess(ClientContext))
            {
                return data.GetRowCount();
            }
		}
		
		#endregion
	
		
		#endregion
	}	
}
