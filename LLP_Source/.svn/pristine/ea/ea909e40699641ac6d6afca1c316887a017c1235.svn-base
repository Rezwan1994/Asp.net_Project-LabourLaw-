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
	public partial class UserActivityManager : BaseManager
	{
	
		#region Constructors
		public UserActivityManager(ClientContext context) : base(context) { }
		public UserActivityManager(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
		
		#region Insert Method		
		/// <summary>
        /// Insert new userActivity.
        /// data manipulation for insertion of UserActivity
        /// </summary>
        /// <param name="userActivityObject"></param>
        /// <returns></returns>
        private bool Insert(UserActivity userActivityObject)
        {
            // new userActivity
            using (UserActivityDataAccess data = new UserActivityDataAccess(ClientContext))
            {
                // insert to userActivityObject
                Int32 _Id = data.Insert(userActivityObject);
                // if successful, process
                if (_Id > 0)
                {
                    userActivityObject.Id = _Id;
                    return true;
                }
                else
                    return false;
            }
        }
		#endregion
		
		#region Update Method
		
		/// <summary>
        /// Update base of UserActivity Object.
        /// Data manipulation processing for: new, deleted, updated UserActivity
        /// </summary>
        /// <param name="userActivityObject"></param>
        /// <returns></returns>
        public bool UpdateBase(UserActivity userActivityObject)
        {
            // use of switch for different types of DML
            switch (userActivityObject.RowState)
            {
                // insert new rows
                case BaseBusinessEntity.RowStateEnum.NewRow:
                    return Insert(userActivityObject);
                // delete rows
                case BaseBusinessEntity.RowStateEnum.DeletedRow:
                    return Delete(userActivityObject.Id);
            }
            // update rows
            using (UserActivityDataAccess data = new UserActivityDataAccess(ClientContext))
            {
                return (data.Update(userActivityObject) > 0);
            }
        }
		
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Delete operation for UserActivity
        /// <param name="_Id"></param>
        /// <returns></returns>
        private bool Delete(Int32 _Id)
        {
            using (UserActivityDataAccess data = new UserActivityDataAccess(ClientContext))
            {
                // return if code > 0
                return (data.Delete(_Id) > 0);
            }
        }
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieve UserActivity data using unique ID
        /// </summary>
        /// <param name="_Id"></param>
        /// <returns>UserActivity Object</returns>
        public UserActivity Get(Int32 _Id)
        {
            using (UserActivityDataAccess data = new UserActivityDataAccess(ClientContext))
            {
                return data.Get(_Id);
            }
        }
		
		
		/// <summary>
        /// Retrieve detail information for a UserActivity .
        /// Detail child data includes:
        /// last updated on:
        /// change description:
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="fillChild"></param>
        /// <returns></returns>
        public UserActivity Get(Int32 _Id, bool fillChild)
        {
            UserActivity userActivityObject;
            userActivityObject = Get(_Id);
            
            if (userActivityObject != null && fillChild)
            {
                // populate child data for a userActivityObject
                FillUserActivityWithChilds(userActivityObject, fillChild);
            }

            return userActivityObject;
        }
		
		/// <summary>
        /// populates a UserActivity with its child entities
        /// </summary>
        /// <param name="userActivity"></param>
		/// <param name="fillChilds"></param>
        private void FillUserActivityWithChilds(UserActivity userActivityObject, bool fillChilds)
        {
            // populate child data for a userActivityObject
            if (userActivityObject != null)
            {
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieve list of UserActivity.
        /// no parameters required to be passed in.
        /// </summary>
        /// <returns>List of UserActivity</returns>
        public UserActivityList GetAll()
        {
            using (UserActivityDataAccess data = new UserActivityDataAccess(ClientContext))
            {
                return data.GetAll();
            }
        }
		
		/// <summary>
        /// Retrieve list of UserActivity.
        /// </summary>
        /// <param name="fillChild"></param>
        /// <returns>List of UserActivity</returns>
        public UserActivityList GetAll(bool fillChild)
        {
			UserActivityList userActivityList = new UserActivityList();
            using (UserActivityDataAccess data = new UserActivityDataAccess(ClientContext))
            {
                userActivityList = data.GetAll();
            }
			if (fillChild)
            {
				foreach (UserActivity userActivityObject in userActivityList)
                {
					FillUserActivityWithChilds(userActivityObject, fillChild);
				}
			}
			return userActivityList;
        }
		
		/// <summary>
        /// Retrieve list of UserActivity  by PageRequest.
        /// <param name="request"></param>
        /// </summary>
        /// <returns>List of UserActivity</returns>
        public UserActivityList GetPaged(PagedRequest request)
        {
            using (UserActivityDataAccess data = new UserActivityDataAccess(ClientContext))
            {
                return data.GetPaged(request);
            }
        }
		
		/// <summary>
        /// Retrieve list of UserActivity  by query String.
        /// <param name="query"></param>
        /// </summary>
        /// <returns>List of UserActivity</returns>
        public UserActivityList GetByQuery(String query)
        {
            using (UserActivityDataAccess data = new UserActivityDataAccess(ClientContext))
            {
                return data.GetByQuery(query);
            }
        }
		#region Get UserActivity Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of UserActivity
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			using (UserActivityDataAccess data = new UserActivityDataAccess(ClientContext))
            {
                return data.GetMaxId();
            }
		}
		
		#endregion
		
		#region Get UserActivity Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of UserActivity
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			using (UserActivityDataAccess data = new UserActivityDataAccess(ClientContext))
            {
                return data.GetRowCount();
            }
		}
		
		#endregion
	
		
		#endregion
	}	
}
