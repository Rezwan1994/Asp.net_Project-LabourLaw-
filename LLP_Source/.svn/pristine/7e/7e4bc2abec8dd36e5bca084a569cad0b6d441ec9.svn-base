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
    /// Business logic processing for Lookup.
    /// </summary>    
	public partial class LookupManager : BaseManager
	{
	
		#region Constructors
		public LookupManager(ClientContext context) : base(context) { }
		public LookupManager(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
		
		#region Insert Method		
		/// <summary>
        /// Insert new lookup.
        /// data manipulation for insertion of Lookup
        /// </summary>
        /// <param name="lookupObject"></param>
        /// <returns></returns>
        private bool Insert(Lookup lookupObject)
        {
            // new lookup
            using (LookupDataAccess data = new LookupDataAccess(ClientContext))
            {
                // insert to lookupObject
                Int32 _Id = data.Insert(lookupObject);
                // if successful, process
                if (_Id > 0)
                {
                    lookupObject.Id = _Id;
                    return true;
                }
                else
                    return false;
            }
        }
		#endregion
		
		#region Update Method
		
		/// <summary>
        /// Update base of Lookup Object.
        /// Data manipulation processing for: new, deleted, updated Lookup
        /// </summary>
        /// <param name="lookupObject"></param>
        /// <returns></returns>
        public bool UpdateBase(Lookup lookupObject)
        {
            // use of switch for different types of DML
            switch (lookupObject.RowState)
            {
                // insert new rows
                case BaseBusinessEntity.RowStateEnum.NewRow:
                    return Insert(lookupObject);
                // delete rows
                case BaseBusinessEntity.RowStateEnum.DeletedRow:
                    return Delete(lookupObject.Id);
            }
            // update rows
            using (LookupDataAccess data = new LookupDataAccess(ClientContext))
            {
                return (data.Update(lookupObject) > 0);
            }
        }
		
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Delete operation for Lookup
        /// <param name="_Id"></param>
        /// <returns></returns>
        private bool Delete(Int32 _Id)
        {
            using (LookupDataAccess data = new LookupDataAccess(ClientContext))
            {
                // return if code > 0
                return (data.Delete(_Id) > 0);
            }
        }
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieve Lookup data using unique ID
        /// </summary>
        /// <param name="_Id"></param>
        /// <returns>Lookup Object</returns>
        public Lookup Get(Int32 _Id)
        {
            using (LookupDataAccess data = new LookupDataAccess(ClientContext))
            {
                return data.Get(_Id);
            }
        }
		
		
		/// <summary>
        /// Retrieve detail information for a Lookup .
        /// Detail child data includes:
        /// last updated on:
        /// change description:
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="fillChild"></param>
        /// <returns></returns>
        public Lookup Get(Int32 _Id, bool fillChild)
        {
            Lookup lookupObject;
            lookupObject = Get(_Id);
            
            if (lookupObject != null && fillChild)
            {
                // populate child data for a lookupObject
                FillLookupWithChilds(lookupObject, fillChild);
            }

            return lookupObject;
        }
		
		/// <summary>
        /// populates a Lookup with its child entities
        /// </summary>
        /// <param name="lookup"></param>
		/// <param name="fillChilds"></param>
        private void FillLookupWithChilds(Lookup lookupObject, bool fillChilds)
        {
            // populate child data for a lookupObject
            if (lookupObject != null)
            {
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieve list of Lookup.
        /// no parameters required to be passed in.
        /// </summary>
        /// <returns>List of Lookup</returns>
        public LookupList GetAll()
        {
            using (LookupDataAccess data = new LookupDataAccess(ClientContext))
            {
                return data.GetAll();
            }
        }
		
		/// <summary>
        /// Retrieve list of Lookup.
        /// </summary>
        /// <param name="fillChild"></param>
        /// <returns>List of Lookup</returns>
        public LookupList GetAll(bool fillChild)
        {
			LookupList lookupList = new LookupList();
            using (LookupDataAccess data = new LookupDataAccess(ClientContext))
            {
                lookupList = data.GetAll();
            }
			if (fillChild)
            {
				foreach (Lookup lookupObject in lookupList)
                {
					FillLookupWithChilds(lookupObject, fillChild);
				}
			}
			return lookupList;
        }
		
		/// <summary>
        /// Retrieve list of Lookup  by PageRequest.
        /// <param name="request"></param>
        /// </summary>
        /// <returns>List of Lookup</returns>
        public LookupList GetPaged(PagedRequest request)
        {
            using (LookupDataAccess data = new LookupDataAccess(ClientContext))
            {
                return data.GetPaged(request);
            }
        }
		
		/// <summary>
        /// Retrieve list of Lookup  by query String.
        /// <param name="query"></param>
        /// </summary>
        /// <returns>List of Lookup</returns>
        public LookupList GetByQuery(String query)
        {
            using (LookupDataAccess data = new LookupDataAccess(ClientContext))
            {
                return data.GetByQuery(query);
            }
        }
		#region Get Lookup Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of Lookup
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			using (LookupDataAccess data = new LookupDataAccess(ClientContext))
            {
                return data.GetMaxId();
            }
		}
		
		#endregion
		
		#region Get Lookup Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of Lookup
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			using (LookupDataAccess data = new LookupDataAccess(ClientContext))
            {
                return data.GetRowCount();
            }
		}
		
		#endregion
	
		
		#endregion
	}	
}
