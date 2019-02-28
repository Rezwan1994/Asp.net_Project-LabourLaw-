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
    /// Business logic processing for LocalizeResource.
    /// </summary>    
	public partial class LocalizeResourceManager : BaseManager
	{
	
		#region Constructors
		public LocalizeResourceManager(ClientContext context) : base(context) { }
		public LocalizeResourceManager(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
		
		#region Insert Method		
		/// <summary>
        /// Insert new localizeResource.
        /// data manipulation for insertion of LocalizeResource
        /// </summary>
        /// <param name="localizeResourceObject"></param>
        /// <returns></returns>
        private bool Insert(LocalizeResource localizeResourceObject)
        {
            // new localizeResource
            using (LocalizeResourceDataAccess data = new LocalizeResourceDataAccess(ClientContext))
            {
                // insert to localizeResourceObject
                Int32 _Id = data.Insert(localizeResourceObject);
                // if successful, process
                if (_Id > 0)
                {
                    localizeResourceObject.Id = _Id;
                    return true;
                }
                else
                    return false;
            }
        }
		#endregion
		
		#region Update Method
		
		/// <summary>
        /// Update base of LocalizeResource Object.
        /// Data manipulation processing for: new, deleted, updated LocalizeResource
        /// </summary>
        /// <param name="localizeResourceObject"></param>
        /// <returns></returns>
        public bool UpdateBase(LocalizeResource localizeResourceObject)
        {
            // use of switch for different types of DML
            switch (localizeResourceObject.RowState)
            {
                // insert new rows
                case BaseBusinessEntity.RowStateEnum.NewRow:
                    return Insert(localizeResourceObject);
                // delete rows
                case BaseBusinessEntity.RowStateEnum.DeletedRow:
                    return Delete(localizeResourceObject.Id);
            }
            // update rows
            using (LocalizeResourceDataAccess data = new LocalizeResourceDataAccess(ClientContext))
            {
                return (data.Update(localizeResourceObject) > 0);
            }
        }
		
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Delete operation for LocalizeResource
        /// <param name="_Id"></param>
        /// <returns></returns>
        private bool Delete(Int32 _Id)
        {
            using (LocalizeResourceDataAccess data = new LocalizeResourceDataAccess(ClientContext))
            {
                // return if code > 0
                return (data.Delete(_Id) > 0);
            }
        }
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieve LocalizeResource data using unique ID
        /// </summary>
        /// <param name="_Id"></param>
        /// <returns>LocalizeResource Object</returns>
        public LocalizeResource Get(Int32 _Id)
        {
            using (LocalizeResourceDataAccess data = new LocalizeResourceDataAccess(ClientContext))
            {
                return data.Get(_Id);
            }
        }
		
		
		/// <summary>
        /// Retrieve detail information for a LocalizeResource .
        /// Detail child data includes:
        /// last updated on:
        /// change description:
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="fillChild"></param>
        /// <returns></returns>
        public LocalizeResource Get(Int32 _Id, bool fillChild)
        {
            LocalizeResource localizeResourceObject;
            localizeResourceObject = Get(_Id);
            
            if (localizeResourceObject != null && fillChild)
            {
                // populate child data for a localizeResourceObject
                FillLocalizeResourceWithChilds(localizeResourceObject, fillChild);
            }

            return localizeResourceObject;
        }
		
		/// <summary>
        /// populates a LocalizeResource with its child entities
        /// </summary>
        /// <param name="localizeResource"></param>
		/// <param name="fillChilds"></param>
        private void FillLocalizeResourceWithChilds(LocalizeResource localizeResourceObject, bool fillChilds)
        {
            // populate child data for a localizeResourceObject
            if (localizeResourceObject != null)
            {
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieve list of LocalizeResource.
        /// no parameters required to be passed in.
        /// </summary>
        /// <returns>List of LocalizeResource</returns>
        public LocalizeResourceList GetAll()
        {
            using (LocalizeResourceDataAccess data = new LocalizeResourceDataAccess(ClientContext))
            {
                return data.GetAll();
            }
        }
		
		/// <summary>
        /// Retrieve list of LocalizeResource.
        /// </summary>
        /// <param name="fillChild"></param>
        /// <returns>List of LocalizeResource</returns>
        public LocalizeResourceList GetAll(bool fillChild)
        {
			LocalizeResourceList localizeResourceList = new LocalizeResourceList();
            using (LocalizeResourceDataAccess data = new LocalizeResourceDataAccess(ClientContext))
            {
                localizeResourceList = data.GetAll();
            }
			if (fillChild)
            {
				foreach (LocalizeResource localizeResourceObject in localizeResourceList)
                {
					FillLocalizeResourceWithChilds(localizeResourceObject, fillChild);
				}
			}
			return localizeResourceList;
        }
		
		/// <summary>
        /// Retrieve list of LocalizeResource  by PageRequest.
        /// <param name="request"></param>
        /// </summary>
        /// <returns>List of LocalizeResource</returns>
        public LocalizeResourceList GetPaged(PagedRequest request)
        {
            using (LocalizeResourceDataAccess data = new LocalizeResourceDataAccess(ClientContext))
            {
                return data.GetPaged(request);
            }
        }
		
		/// <summary>
        /// Retrieve list of LocalizeResource  by query String.
        /// <param name="query"></param>
        /// </summary>
        /// <returns>List of LocalizeResource</returns>
        public LocalizeResourceList GetByQuery(String query)
        {
            using (LocalizeResourceDataAccess data = new LocalizeResourceDataAccess(ClientContext))
            {
                return data.GetByQuery(query);
            }
        }
		#region Get LocalizeResource Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of LocalizeResource
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			using (LocalizeResourceDataAccess data = new LocalizeResourceDataAccess(ClientContext))
            {
                return data.GetMaxId();
            }
		}
		
		#endregion
		
		#region Get LocalizeResource Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of LocalizeResource
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			using (LocalizeResourceDataAccess data = new LocalizeResourceDataAccess(ClientContext))
            {
                return data.GetRowCount();
            }
		}
		
		#endregion
	
		
		#endregion
	}	
}
