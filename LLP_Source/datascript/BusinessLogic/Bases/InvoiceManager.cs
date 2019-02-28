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
    /// Business logic processing for Invoice.
    /// </summary>    
	public partial class InvoiceManager : BaseManager
	{
	
		#region Constructors
		public InvoiceManager(ClientContext context) : base(context) { }
		public InvoiceManager(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
		
		#region Insert Method		
		/// <summary>
        /// Insert new invoice.
        /// data manipulation for insertion of Invoice
        /// </summary>
        /// <param name="invoiceObject"></param>
        /// <returns></returns>
        private bool Insert(Invoice invoiceObject)
        {
            // new invoice
            using (InvoiceDataAccess data = new InvoiceDataAccess(ClientContext))
            {
                // insert to invoiceObject
                Int32 _Id = data.Insert(invoiceObject);
                // if successful, process
                if (_Id > 0)
                {
                    invoiceObject.Id = _Id;
                    return true;
                }
                else
                    return false;
            }
        }
		#endregion
		
		#region Update Method
		
		/// <summary>
        /// Update base of Invoice Object.
        /// Data manipulation processing for: new, deleted, updated Invoice
        /// </summary>
        /// <param name="invoiceObject"></param>
        /// <returns></returns>
        public bool UpdateBase(Invoice invoiceObject)
        {
            // use of switch for different types of DML
            switch (invoiceObject.RowState)
            {
                // insert new rows
                case BaseBusinessEntity.RowStateEnum.NewRow:
                    return Insert(invoiceObject);
                // delete rows
                case BaseBusinessEntity.RowStateEnum.DeletedRow:
                    return Delete(invoiceObject.Id);
            }
            // update rows
            using (InvoiceDataAccess data = new InvoiceDataAccess(ClientContext))
            {
                return (data.Update(invoiceObject) > 0);
            }
        }
		
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Delete operation for Invoice
        /// <param name="_Id"></param>
        /// <returns></returns>
        private bool Delete(Int32 _Id)
        {
            using (InvoiceDataAccess data = new InvoiceDataAccess(ClientContext))
            {
                // return if code > 0
                return (data.Delete(_Id) > 0);
            }
        }
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieve Invoice data using unique ID
        /// </summary>
        /// <param name="_Id"></param>
        /// <returns>Invoice Object</returns>
        public Invoice Get(Int32 _Id)
        {
            using (InvoiceDataAccess data = new InvoiceDataAccess(ClientContext))
            {
                return data.Get(_Id);
            }
        }
		
		
		/// <summary>
        /// Retrieve detail information for a Invoice .
        /// Detail child data includes:
        /// last updated on:
        /// change description:
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="fillChild"></param>
        /// <returns></returns>
        public Invoice Get(Int32 _Id, bool fillChild)
        {
            Invoice invoiceObject;
            invoiceObject = Get(_Id);
            
            if (invoiceObject != null && fillChild)
            {
                // populate child data for a invoiceObject
                FillInvoiceWithChilds(invoiceObject, fillChild);
            }

            return invoiceObject;
        }
		
		/// <summary>
        /// populates a Invoice with its child entities
        /// </summary>
        /// <param name="invoice"></param>
		/// <param name="fillChilds"></param>
        private void FillInvoiceWithChilds(Invoice invoiceObject, bool fillChilds)
        {
            // populate child data for a invoiceObject
            if (invoiceObject != null)
            {
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieve list of Invoice.
        /// no parameters required to be passed in.
        /// </summary>
        /// <returns>List of Invoice</returns>
        public InvoiceList GetAll()
        {
            using (InvoiceDataAccess data = new InvoiceDataAccess(ClientContext))
            {
                return data.GetAll();
            }
        }
		
		/// <summary>
        /// Retrieve list of Invoice.
        /// </summary>
        /// <param name="fillChild"></param>
        /// <returns>List of Invoice</returns>
        public InvoiceList GetAll(bool fillChild)
        {
			InvoiceList invoiceList = new InvoiceList();
            using (InvoiceDataAccess data = new InvoiceDataAccess(ClientContext))
            {
                invoiceList = data.GetAll();
            }
			if (fillChild)
            {
				foreach (Invoice invoiceObject in invoiceList)
                {
					FillInvoiceWithChilds(invoiceObject, fillChild);
				}
			}
			return invoiceList;
        }
		
		/// <summary>
        /// Retrieve list of Invoice  by PageRequest.
        /// <param name="request"></param>
        /// </summary>
        /// <returns>List of Invoice</returns>
        public InvoiceList GetPaged(PagedRequest request)
        {
            using (InvoiceDataAccess data = new InvoiceDataAccess(ClientContext))
            {
                return data.GetPaged(request);
            }
        }
		
		/// <summary>
        /// Retrieve list of Invoice  by query String.
        /// <param name="query"></param>
        /// </summary>
        /// <returns>List of Invoice</returns>
        public InvoiceList GetByQuery(String query)
        {
            using (InvoiceDataAccess data = new InvoiceDataAccess(ClientContext))
            {
                return data.GetByQuery(query);
            }
        }
		#region Get Invoice Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of Invoice
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			using (InvoiceDataAccess data = new InvoiceDataAccess(ClientContext))
            {
                return data.GetMaxId();
            }
		}
		
		#endregion
		
		#region Get Invoice Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of Invoice
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			using (InvoiceDataAccess data = new InvoiceDataAccess(ClientContext))
            {
                return data.GetRowCount();
            }
		}
		
		#endregion
	
		
		#endregion
	}	
}
