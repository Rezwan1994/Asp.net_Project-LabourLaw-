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
	public partial class InvoiceNoteManager
	{
	
		/// <summary>
        /// Update InvoiceNote Object.
        /// Data manipulation processing for: new, deleted, updated InvoiceNote
        /// </summary>
        /// <param name="invoiceNoteObject"></param>
        /// <returns></returns>
        public bool Update(InvoiceNote invoiceNoteObject)
        {
			bool success = false;
			
			success = UpdateBase(invoiceNoteObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of InvoiceNote Object.
        /// </summary>
        /// <param name="invoiceNoteObject"></param>
        /// <returns></returns>
        public void FillChilds(InvoiceNote invoiceNoteObject)
        {
			///Fill external information of Childs of InvoiceNoteObject
        }
	}	
}
