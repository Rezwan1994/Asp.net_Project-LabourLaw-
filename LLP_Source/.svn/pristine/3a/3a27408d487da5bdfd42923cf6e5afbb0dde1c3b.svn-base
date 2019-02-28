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
    /// Business logic processing for InvoiceNote.
    /// </summary>    
	public partial class InvoiceNoteManager : BaseManager
	{
	
		#region Constructors
		public InvoiceNoteManager(ClientContext context) : base(context) { }
		public InvoiceNoteManager(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
		
		#region Insert Method		
		/// <summary>
        /// Insert new invoiceNote.
        /// data manipulation for insertion of InvoiceNote
        /// </summary>
        /// <param name="invoiceNoteObject"></param>
        /// <returns></returns>
        private bool Insert(InvoiceNote invoiceNoteObject)
        {
            // new invoiceNote
            using (InvoiceNoteDataAccess data = new InvoiceNoteDataAccess(ClientContext))
            {
                // insert to invoiceNoteObject
                Int32 _Id = data.Insert(invoiceNoteObject);
                // if successful, process
                if (_Id > 0)
                {
                    invoiceNoteObject.Id = _Id;
                    return true;
                }
                else
                    return false;
            }
        }
		#endregion
		
		#region Update Method
		
		/// <summary>
        /// Update base of InvoiceNote Object.
        /// Data manipulation processing for: new, deleted, updated InvoiceNote
        /// </summary>
        /// <param name="invoiceNoteObject"></param>
        /// <returns></returns>
        public bool UpdateBase(InvoiceNote invoiceNoteObject)
        {
            // use of switch for different types of DML
            switch (invoiceNoteObject.RowState)
            {
                // insert new rows
                case BaseBusinessEntity.RowStateEnum.NewRow:
                    return Insert(invoiceNoteObject);
                // delete rows
                case BaseBusinessEntity.RowStateEnum.DeletedRow:
                    return Delete(invoiceNoteObject.Id);
            }
            // update rows
            using (InvoiceNoteDataAccess data = new InvoiceNoteDataAccess(ClientContext))
            {
                return (data.Update(invoiceNoteObject) > 0);
            }
        }
		
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Delete operation for InvoiceNote
        /// <param name="_Id"></param>
        /// <returns></returns>
        private bool Delete(Int32 _Id)
        {
            using (InvoiceNoteDataAccess data = new InvoiceNoteDataAccess(ClientContext))
            {
                // return if code > 0
                return (data.Delete(_Id) > 0);
            }
        }
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieve InvoiceNote data using unique ID
        /// </summary>
        /// <param name="_Id"></param>
        /// <returns>InvoiceNote Object</returns>
        public InvoiceNote Get(Int32 _Id)
        {
            using (InvoiceNoteDataAccess data = new InvoiceNoteDataAccess(ClientContext))
            {
                return data.Get(_Id);
            }
        }
		
		
		/// <summary>
        /// Retrieve detail information for a InvoiceNote .
        /// Detail child data includes:
        /// last updated on:
        /// change description:
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="fillChild"></param>
        /// <returns></returns>
        public InvoiceNote Get(Int32 _Id, bool fillChild)
        {
            InvoiceNote invoiceNoteObject;
            invoiceNoteObject = Get(_Id);
            
            if (invoiceNoteObject != null && fillChild)
            {
                // populate child data for a invoiceNoteObject
                FillInvoiceNoteWithChilds(invoiceNoteObject, fillChild);
            }

            return invoiceNoteObject;
        }
		
		/// <summary>
        /// populates a InvoiceNote with its child entities
        /// </summary>
        /// <param name="invoiceNote"></param>
		/// <param name="fillChilds"></param>
        private void FillInvoiceNoteWithChilds(InvoiceNote invoiceNoteObject, bool fillChilds)
        {
            // populate child data for a invoiceNoteObject
            if (invoiceNoteObject != null)
            {
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieve list of InvoiceNote.
        /// no parameters required to be passed in.
        /// </summary>
        /// <returns>List of InvoiceNote</returns>
        public InvoiceNoteList GetAll()
        {
            using (InvoiceNoteDataAccess data = new InvoiceNoteDataAccess(ClientContext))
            {
                return data.GetAll();
            }
        }
		
		/// <summary>
        /// Retrieve list of InvoiceNote.
        /// </summary>
        /// <param name="fillChild"></param>
        /// <returns>List of InvoiceNote</returns>
        public InvoiceNoteList GetAll(bool fillChild)
        {
			InvoiceNoteList invoiceNoteList = new InvoiceNoteList();
            using (InvoiceNoteDataAccess data = new InvoiceNoteDataAccess(ClientContext))
            {
                invoiceNoteList = data.GetAll();
            }
			if (fillChild)
            {
				foreach (InvoiceNote invoiceNoteObject in invoiceNoteList)
                {
					FillInvoiceNoteWithChilds(invoiceNoteObject, fillChild);
				}
			}
			return invoiceNoteList;
        }
		
		/// <summary>
        /// Retrieve list of InvoiceNote  by PageRequest.
        /// <param name="request"></param>
        /// </summary>
        /// <returns>List of InvoiceNote</returns>
        public InvoiceNoteList GetPaged(PagedRequest request)
        {
            using (InvoiceNoteDataAccess data = new InvoiceNoteDataAccess(ClientContext))
            {
                return data.GetPaged(request);
            }
        }
		
		/// <summary>
        /// Retrieve list of InvoiceNote  by query String.
        /// <param name="query"></param>
        /// </summary>
        /// <returns>List of InvoiceNote</returns>
        public InvoiceNoteList GetByQuery(String query)
        {
            using (InvoiceNoteDataAccess data = new InvoiceNoteDataAccess(ClientContext))
            {
                return data.GetByQuery(query);
            }
        }
		#region Get InvoiceNote Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of InvoiceNote
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			using (InvoiceNoteDataAccess data = new InvoiceNoteDataAccess(ClientContext))
            {
                return data.GetMaxId();
            }
		}
		
		#endregion
		
		#region Get InvoiceNote Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of InvoiceNote
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			using (InvoiceNoteDataAccess data = new InvoiceNoteDataAccess(ClientContext))
            {
                return data.GetRowCount();
            }
		}
		
		#endregion
	
		
		#endregion
	}	
}
