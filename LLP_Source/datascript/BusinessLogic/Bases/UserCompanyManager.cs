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
	public partial class UserCompanyManager : BaseManager
	{
	
		#region Constructors
		public UserCompanyManager(ClientContext context) : base(context) { }
		public UserCompanyManager(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
		
		#region Insert Method		
		/// <summary>
        /// Insert new userCompany.
        /// data manipulation for insertion of UserCompany
        /// </summary>
        /// <param name="userCompanyObject"></param>
        /// <returns></returns>
        private bool Insert(UserCompany userCompanyObject)
        {
            // new userCompany
            using (UserCompanyDataAccess data = new UserCompanyDataAccess(ClientContext))
            {
                // insert to userCompanyObject
                Int32 _Id = data.Insert(userCompanyObject);
                // if successful, process
                if (_Id > 0)
                {
                    userCompanyObject.Id = _Id;
                    return true;
                }
                else
                    return false;
            }
        }
		#endregion
		
		#region Update Method
		
		/// <summary>
        /// Update base of UserCompany Object.
        /// Data manipulation processing for: new, deleted, updated UserCompany
        /// </summary>
        /// <param name="userCompanyObject"></param>
        /// <returns></returns>
        public bool UpdateBase(UserCompany userCompanyObject)
        {
            // use of switch for different types of DML
            switch (userCompanyObject.RowState)
            {
                // insert new rows
                case BaseBusinessEntity.RowStateEnum.NewRow:
                    return Insert(userCompanyObject);
                // delete rows
                case BaseBusinessEntity.RowStateEnum.DeletedRow:
                    return Delete(userCompanyObject.Id);
            }
            // update rows
            using (UserCompanyDataAccess data = new UserCompanyDataAccess(ClientContext))
            {
                return (data.Update(userCompanyObject) > 0);
            }
        }
		
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Delete operation for UserCompany
        /// <param name="_Id"></param>
        /// <returns></returns>
        private bool Delete(Int32 _Id)
        {
            using (UserCompanyDataAccess data = new UserCompanyDataAccess(ClientContext))
            {
                // return if code > 0
                return (data.Delete(_Id) > 0);
            }
        }
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieve UserCompany data using unique ID
        /// </summary>
        /// <param name="_Id"></param>
        /// <returns>UserCompany Object</returns>
        public UserCompany Get(Int32 _Id)
        {
            using (UserCompanyDataAccess data = new UserCompanyDataAccess(ClientContext))
            {
                return data.Get(_Id);
            }
        }
		
		
		/// <summary>
        /// Retrieve detail information for a UserCompany .
        /// Detail child data includes:
        /// last updated on:
        /// change description:
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="fillChild"></param>
        /// <returns></returns>
        public UserCompany Get(Int32 _Id, bool fillChild)
        {
            UserCompany userCompanyObject;
            userCompanyObject = Get(_Id);
            
            if (userCompanyObject != null && fillChild)
            {
                // populate child data for a userCompanyObject
                FillUserCompanyWithChilds(userCompanyObject, fillChild);
            }

            return userCompanyObject;
        }
		
		/// <summary>
        /// populates a UserCompany with its child entities
        /// </summary>
        /// <param name="userCompany"></param>
		/// <param name="fillChilds"></param>
        private void FillUserCompanyWithChilds(UserCompany userCompanyObject, bool fillChilds)
        {
            // populate child data for a userCompanyObject
            if (userCompanyObject != null)
            {
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieve list of UserCompany.
        /// no parameters required to be passed in.
        /// </summary>
        /// <returns>List of UserCompany</returns>
        public UserCompanyList GetAll()
        {
            using (UserCompanyDataAccess data = new UserCompanyDataAccess(ClientContext))
            {
                return data.GetAll();
            }
        }
		
		/// <summary>
        /// Retrieve list of UserCompany.
        /// </summary>
        /// <param name="fillChild"></param>
        /// <returns>List of UserCompany</returns>
        public UserCompanyList GetAll(bool fillChild)
        {
			UserCompanyList userCompanyList = new UserCompanyList();
            using (UserCompanyDataAccess data = new UserCompanyDataAccess(ClientContext))
            {
                userCompanyList = data.GetAll();
            }
			if (fillChild)
            {
				foreach (UserCompany userCompanyObject in userCompanyList)
                {
					FillUserCompanyWithChilds(userCompanyObject, fillChild);
				}
			}
			return userCompanyList;
        }
		
		/// <summary>
        /// Retrieve list of UserCompany  by PageRequest.
        /// <param name="request"></param>
        /// </summary>
        /// <returns>List of UserCompany</returns>
        public UserCompanyList GetPaged(PagedRequest request)
        {
            using (UserCompanyDataAccess data = new UserCompanyDataAccess(ClientContext))
            {
                return data.GetPaged(request);
            }
        }
		
		/// <summary>
        /// Retrieve list of UserCompany  by query String.
        /// <param name="query"></param>
        /// </summary>
        /// <returns>List of UserCompany</returns>
        public UserCompanyList GetByQuery(String query)
        {
            using (UserCompanyDataAccess data = new UserCompanyDataAccess(ClientContext))
            {
                return data.GetByQuery(query);
            }
        }
		#region Get UserCompany Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of UserCompany
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			using (UserCompanyDataAccess data = new UserCompanyDataAccess(ClientContext))
            {
                return data.GetMaxId();
            }
		}
		
		#endregion
		
		#region Get UserCompany Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of UserCompany
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			using (UserCompanyDataAccess data = new UserCompanyDataAccess(ClientContext))
            {
                return data.GetRowCount();
            }
		}
		
		#endregion
	
		
		#endregion
	}	
}
