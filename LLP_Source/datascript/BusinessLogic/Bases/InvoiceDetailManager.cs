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
    /// Business logic processing for InvoiceDetail.
    /// </summary>    
	public partial class InvoiceDetailManager : BaseManager
	{
	
		#region Constructors
		public InvoiceDetailManager(ClientContext context) : base(context) { }
		public InvoiceDetailManager(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
		
		#region Insert Method		
		/// <summary>
        /// Insert new invoiceDetail.
        /// data manipulation for insertion of InvoiceDetail
        /// </summary>
        /// <param name="invoiceDetailObject"></param>
        /// <returns></returns>
        private bool Insert(InvoiceDetail invoiceDetailObject)
        {
            // new invoiceDetail
            using (InvoiceDetailDataAccess data = new InvoiceDetailDataAccess(ClientContext))
            {
                // insert to invoiceDetailObject
                Int32 _Id = data.Insert(invoiceDetailObject);
                // if successful, process
                if (_Id > 0)
                {
                    invoiceDetailObject.Id = _Id;
                    return true;
                }
                else
                    return false;
            }
        }
		#endregion
		
		#region Update Method
		
		/// <summary>
        /// Update base of InvoiceDetail Object.
        /// Data manipulation processing for: new, deleted, updated InvoiceDetail
        /// </summary>
        /// <param name="invoiceDetailObject"></param>
        /// <returns></returns>
        public bool UpdateBase(InvoiceDetail invoiceDetailObject)
        {
            // use of switch for different types of DML
            switch (invoiceDetailObject.RowState)
            {
                // insert new rows
                case BaseBusinessEntity.RowStateEnum.NewRow:
                    return Insert(invoiceDetailObject);
                // delete rows
                case BaseBusinessEntity.RowStateEnum.DeletedRow:
                    return Delete(invoiceDetailObject.Id);
            }
            // update rows
            using (InvoiceDetailDataAccess data = new InvoiceDetailDataAccess(ClientContext))
            {
                return (data.Update(invoiceDetailObject) > 0);
            }
        }
		
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Delete operation for InvoiceDetail
        /// <param name="_Id"></param>
        /// <returns></returns>
        private bool Delete(Int32 _Id)
        {
            using (InvoiceDetailDataAccess data = new InvoiceDetailDataAccess(ClientContext))
            {
                // return if code > 0
                return (data.Delete(_Id) > 0);
            }
        }
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieve InvoiceDetail data using unique ID
        /// </summary>
        /// <param name="_Id"></param>
        /// <returns>InvoiceDetail Object</returns>
        public InvoiceDetail Get(Int32 _Id)
        {
            using (InvoiceDetailDataAccess data = new InvoiceDetailDataAccess(ClientContext))
            {
                return data.Get(_Id);
            }
        }
		
		
		/// <summary>
        /// Retrieve detail information for a InvoiceDetail .
        /// Detail child data includes:
        /// last updated on:
        /// change description:
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="fillChild"></param>
        /// <returns></returns>
        public InvoiceDetail Get(Int32 _Id, bool fillChild)
        {
            InvoiceDetail invoiceDetailObject;
            invoiceDetailObject = Get(_Id);
            
            if (invoiceDetailObject != null && fillChild)
            {
                // populate child data for a invoiceDetailObject
                FillInvoiceDetailWithChilds(invoiceDetailObject, fillChild);
            }

            return invoiceDetailObject;
        }
		
		/// <summary>
        /// populates a InvoiceDetail with its child entities
        /// </summary>
        /// <param name="invoiceDetail"></param>
		/// <param name="fillChilds"></param>
        private void FillInvoiceDetailWithChilds(InvoiceDetail invoiceDetailObject, bool fillChilds)
        {
            // populate child data for a invoiceDetailObject
            if (invoiceDetailObject != null)
            {
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieve list of InvoiceDetail.
        /// no parameters required to be passed in.
        /// </summary>
        /// <returns>List of InvoiceDetail</returns>
        public InvoiceDetailList GetAll()
        {
            using (InvoiceDetailDataAccess data = new InvoiceDetailDataAccess(ClientContext))
            {
                return data.GetAll();
            }
        }
		
		/// <summary>
        /// Retrieve list of InvoiceDetail.
        /// </summary>
        /// <param name="fillChild"></param>
        /// <returns>List of InvoiceDetail</returns>
        public InvoiceDetailList GetAll(bool fillChild)
        {
			InvoiceDetailList invoiceDetailList = new InvoiceDetailList();
            using (InvoiceDetailDataAccess data = new InvoiceDetailDataAccess(ClientContext))
            {
                invoiceDetailList = data.GetAll();
            }
			if (fillChild)
            {
				foreach (InvoiceDetail invoiceDetailObject in invoiceDetailList)
                {
					FillInvoiceDetailWithChilds(invoiceDetailObject, fillChild);
				}
			}
			return invoiceDetailList;
        }
		
		/// <summary>
        /// Retrieve list of InvoiceDetail  by PageRequest.
        /// <param name="request"></param>
        /// </summary>
        /// <returns>List of InvoiceDetail</returns>
        public InvoiceDetailList GetPaged(PagedRequest request)
        {
            using (InvoiceDetailDataAccess data = new InvoiceDetailDataAccess(ClientContext))
            {
                return data.GetPaged(request);
            }
        }
		
		/// <summary>
        /// Retrieve list of InvoiceDetail  by query String.
        /// <param name="query"></param>
        /// </summary>
        /// <returns>List of InvoiceDetail</returns>
        public InvoiceDetailList GetByQuery(String query)
        {
            using (InvoiceDetailDataAccess data = new InvoiceDetailDataAccess(ClientContext))
            {
                return data.GetByQuery(query);
            }
        }
		#region Get InvoiceDetail Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of InvoiceDetail
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			using (InvoiceDetailDataAccess data = new InvoiceDetailDataAccess(ClientContext))
            {
                return data.GetMaxId();
            }
		}
		
		#endregion
		
		#region Get InvoiceDetail Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of InvoiceDetail
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			using (InvoiceDetailDataAccess data = new InvoiceDetailDataAccess(ClientContext))
            {
                return data.GetRowCount();
            }
		}
		
		#endregion
	
		
		#endregion
	}	
}
