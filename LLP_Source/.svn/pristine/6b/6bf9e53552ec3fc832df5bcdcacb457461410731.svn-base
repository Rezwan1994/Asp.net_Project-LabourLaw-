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
	public partial class InvoiceDetailManager
	{
	
		/// <summary>
        /// Update InvoiceDetail Object.
        /// Data manipulation processing for: new, deleted, updated InvoiceDetail
        /// </summary>
        /// <param name="invoiceDetailObject"></param>
        /// <returns></returns>
        public bool Update(InvoiceDetail invoiceDetailObject)
        {
			bool success = false;
			
			success = UpdateBase(invoiceDetailObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of InvoiceDetail Object.
        /// </summary>
        /// <param name="invoiceDetailObject"></param>
        /// <returns></returns>
        public void FillChilds(InvoiceDetail invoiceDetailObject)
        {
			///Fill external information of Childs of InvoiceDetailObject
        }
	}	
}
