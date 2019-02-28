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
	public partial class UserBranchManager : BaseManager
	{
	
		#region Constructors
		public UserBranchManager(ClientContext context) : base(context) { }
		public UserBranchManager(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
		
		#region Insert Method		
		/// <summary>
        /// Insert new userBranch.
        /// data manipulation for insertion of UserBranch
        /// </summary>
        /// <param name="userBranchObject"></param>
        /// <returns></returns>
        private bool Insert(UserBranch userBranchObject)
        {
            // new userBranch
            using (UserBranchDataAccess data = new UserBranchDataAccess(ClientContext))
            {
                // insert to userBranchObject
                Int32 _Id = data.Insert(userBranchObject);
                // if successful, process
                if (_Id > 0)
                {
                    userBranchObject.Id = _Id;
                    return true;
                }
                else
                    return false;
            }
        }
		#endregion
		
		#region Update Method
		
		/// <summary>
        /// Update base of UserBranch Object.
        /// Data manipulation processing for: new, deleted, updated UserBranch
        /// </summary>
        /// <param name="userBranchObject"></param>
        /// <returns></returns>
        public bool UpdateBase(UserBranch userBranchObject)
        {
            // use of switch for different types of DML
            switch (userBranchObject.RowState)
            {
                // insert new rows
                case BaseBusinessEntity.RowStateEnum.NewRow:
                    return Insert(userBranchObject);
                // delete rows
                case BaseBusinessEntity.RowStateEnum.DeletedRow:
                    return Delete(userBranchObject.Id);
            }
            // update rows
            using (UserBranchDataAccess data = new UserBranchDataAccess(ClientContext))
            {
                return (data.Update(userBranchObject) > 0);
            }
        }
		
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Delete operation for UserBranch
        /// <param name="_Id"></param>
        /// <returns></returns>
        private bool Delete(Int32 _Id)
        {
            using (UserBranchDataAccess data = new UserBranchDataAccess(ClientContext))
            {
                // return if code > 0
                return (data.Delete(_Id) > 0);
            }
        }
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieve UserBranch data using unique ID
        /// </summary>
        /// <param name="_Id"></param>
        /// <returns>UserBranch Object</returns>
        public UserBranch Get(Int32 _Id)
        {
            using (UserBranchDataAccess data = new UserBranchDataAccess(ClientContext))
            {
                return data.Get(_Id);
            }
        }
		
		
		/// <summary>
        /// Retrieve detail information for a UserBranch .
        /// Detail child data includes:
        /// last updated on:
        /// change description:
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="fillChild"></param>
        /// <returns></returns>
        public UserBranch Get(Int32 _Id, bool fillChild)
        {
            UserBranch userBranchObject;
            userBranchObject = Get(_Id);
            
            if (userBranchObject != null && fillChild)
            {
                // populate child data for a userBranchObject
                FillUserBranchWithChilds(userBranchObject, fillChild);
            }

            return userBranchObject;
        }
		
		/// <summary>
        /// populates a UserBranch with its child entities
        /// </summary>
        /// <param name="userBranch"></param>
		/// <param name="fillChilds"></param>
        private void FillUserBranchWithChilds(UserBranch userBranchObject, bool fillChilds)
        {
            // populate child data for a userBranchObject
            if (userBranchObject != null)
            {
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieve list of UserBranch.
        /// no parameters required to be passed in.
        /// </summary>
        /// <returns>List of UserBranch</returns>
        public UserBranchList GetAll()
        {
            using (UserBranchDataAccess data = new UserBranchDataAccess(ClientContext))
            {
                return data.GetAll();
            }
        }
		
		/// <summary>
        /// Retrieve list of UserBranch.
        /// </summary>
        /// <param name="fillChild"></param>
        /// <returns>List of UserBranch</returns>
        public UserBranchList GetAll(bool fillChild)
        {
			UserBranchList userBranchList = new UserBranchList();
            using (UserBranchDataAccess data = new UserBranchDataAccess(ClientContext))
            {
                userBranchList = data.GetAll();
            }
			if (fillChild)
            {
				foreach (UserBranch userBranchObject in userBranchList)
                {
					FillUserBranchWithChilds(userBranchObject, fillChild);
				}
			}
			return userBranchList;
        }
		
		/// <summary>
        /// Retrieve list of UserBranch  by PageRequest.
        /// <param name="request"></param>
        /// </summary>
        /// <returns>List of UserBranch</returns>
        public UserBranchList GetPaged(PagedRequest request)
        {
            using (UserBranchDataAccess data = new UserBranchDataAccess(ClientContext))
            {
                return data.GetPaged(request);
            }
        }
		
		/// <summary>
        /// Retrieve list of UserBranch  by query String.
        /// <param name="query"></param>
        /// </summary>
        /// <returns>List of UserBranch</returns>
        public UserBranchList GetByQuery(String query)
        {
            using (UserBranchDataAccess data = new UserBranchDataAccess(ClientContext))
            {
                return data.GetByQuery(query);
            }
        }
		#region Get UserBranch Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of UserBranch
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			using (UserBranchDataAccess data = new UserBranchDataAccess(ClientContext))
            {
                return data.GetMaxId();
            }
		}
		
		#endregion
		
		#region Get UserBranch Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of UserBranch
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			using (UserBranchDataAccess data = new UserBranchDataAccess(ClientContext))
            {
                return data.GetRowCount();
            }
		}
		
		#endregion
	
		
		#endregion
	}	
}
