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
    /// Business logic processing for PasswordReset.
    /// </summary>    
	public partial class PasswordResetManager : BaseManager
	{
	
		#region Constructors
		public PasswordResetManager(ClientContext context) : base(context) { }
		public PasswordResetManager(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
		
		#region Insert Method		
		/// <summary>
        /// Insert new passwordReset.
        /// data manipulation for insertion of PasswordReset
        /// </summary>
        /// <param name="passwordResetObject"></param>
        /// <returns></returns>
        private bool Insert(PasswordReset passwordResetObject)
        {
            // new passwordReset
            using (PasswordResetDataAccess data = new PasswordResetDataAccess(ClientContext))
            {
                // insert to passwordResetObject
                Int32 _Id = data.Insert(passwordResetObject);
                // if successful, process
                if (_Id > 0)
                {
                    passwordResetObject.Id = _Id;
                    return true;
                }
                else
                    return false;
            }
        }
		#endregion
		
		#region Update Method
		
		/// <summary>
        /// Update base of PasswordReset Object.
        /// Data manipulation processing for: new, deleted, updated PasswordReset
        /// </summary>
        /// <param name="passwordResetObject"></param>
        /// <returns></returns>
        public bool UpdateBase(PasswordReset passwordResetObject)
        {
            // use of switch for different types of DML
            switch (passwordResetObject.RowState)
            {
                // insert new rows
                case BaseBusinessEntity.RowStateEnum.NewRow:
                    return Insert(passwordResetObject);
                // delete rows
                case BaseBusinessEntity.RowStateEnum.DeletedRow:
                    return Delete(passwordResetObject.Id);
            }
            // update rows
            using (PasswordResetDataAccess data = new PasswordResetDataAccess(ClientContext))
            {
                return (data.Update(passwordResetObject) > 0);
            }
        }
		
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Delete operation for PasswordReset
        /// <param name="_Id"></param>
        /// <returns></returns>
        private bool Delete(Int32 _Id)
        {
            using (PasswordResetDataAccess data = new PasswordResetDataAccess(ClientContext))
            {
                // return if code > 0
                return (data.Delete(_Id) > 0);
            }
        }
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieve PasswordReset data using unique ID
        /// </summary>
        /// <param name="_Id"></param>
        /// <returns>PasswordReset Object</returns>
        public PasswordReset Get(Int32 _Id)
        {
            using (PasswordResetDataAccess data = new PasswordResetDataAccess(ClientContext))
            {
                return data.Get(_Id);
            }
        }
		
		
		/// <summary>
        /// Retrieve detail information for a PasswordReset .
        /// Detail child data includes:
        /// last updated on:
        /// change description:
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="fillChild"></param>
        /// <returns></returns>
        public PasswordReset Get(Int32 _Id, bool fillChild)
        {
            PasswordReset passwordResetObject;
            passwordResetObject = Get(_Id);
            
            if (passwordResetObject != null && fillChild)
            {
                // populate child data for a passwordResetObject
                FillPasswordResetWithChilds(passwordResetObject, fillChild);
            }

            return passwordResetObject;
        }
		
		/// <summary>
        /// populates a PasswordReset with its child entities
        /// </summary>
        /// <param name="passwordReset"></param>
		/// <param name="fillChilds"></param>
        private void FillPasswordResetWithChilds(PasswordReset passwordResetObject, bool fillChilds)
        {
            // populate child data for a passwordResetObject
            if (passwordResetObject != null)
            {
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieve list of PasswordReset.
        /// no parameters required to be passed in.
        /// </summary>
        /// <returns>List of PasswordReset</returns>
        public PasswordResetList GetAll()
        {
            using (PasswordResetDataAccess data = new PasswordResetDataAccess(ClientContext))
            {
                return data.GetAll();
            }
        }
		
		/// <summary>
        /// Retrieve list of PasswordReset.
        /// </summary>
        /// <param name="fillChild"></param>
        /// <returns>List of PasswordReset</returns>
        public PasswordResetList GetAll(bool fillChild)
        {
			PasswordResetList passwordResetList = new PasswordResetList();
            using (PasswordResetDataAccess data = new PasswordResetDataAccess(ClientContext))
            {
                passwordResetList = data.GetAll();
            }
			if (fillChild)
            {
				foreach (PasswordReset passwordResetObject in passwordResetList)
                {
					FillPasswordResetWithChilds(passwordResetObject, fillChild);
				}
			}
			return passwordResetList;
        }
		
		/// <summary>
        /// Retrieve list of PasswordReset  by PageRequest.
        /// <param name="request"></param>
        /// </summary>
        /// <returns>List of PasswordReset</returns>
        public PasswordResetList GetPaged(PagedRequest request)
        {
            using (PasswordResetDataAccess data = new PasswordResetDataAccess(ClientContext))
            {
                return data.GetPaged(request);
            }
        }
		
		/// <summary>
        /// Retrieve list of PasswordReset  by query String.
        /// <param name="query"></param>
        /// </summary>
        /// <returns>List of PasswordReset</returns>
        public PasswordResetList GetByQuery(String query)
        {
            using (PasswordResetDataAccess data = new PasswordResetDataAccess(ClientContext))
            {
                return data.GetByQuery(query);
            }
        }
		#region Get PasswordReset Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of PasswordReset
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			using (PasswordResetDataAccess data = new PasswordResetDataAccess(ClientContext))
            {
                return data.GetMaxId();
            }
		}
		
		#endregion
		
		#region Get PasswordReset Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of PasswordReset
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			using (PasswordResetDataAccess data = new PasswordResetDataAccess(ClientContext))
            {
                return data.GetRowCount();
            }
		}
		
		#endregion
	
		
		#endregion
	}	
}
