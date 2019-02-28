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
	public partial class InvoiceManager
	{
	
		/// <summary>
        /// Update Invoice Object.
        /// Data manipulation processing for: new, deleted, updated Invoice
        /// </summary>
        /// <param name="invoiceObject"></param>
        /// <returns></returns>
        public bool Update(Invoice invoiceObject)
        {
			bool success = false;
			
			success = UpdateBase(invoiceObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of Invoice Object.
        /// </summary>
        /// <param name="invoiceObject"></param>
        /// <returns></returns>
        public void FillChilds(Invoice invoiceObject)
        {
			///Fill external information of Childs of InvoiceObject
        }
	}	
}
