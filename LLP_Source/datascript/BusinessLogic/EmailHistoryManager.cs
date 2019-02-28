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
    /// Business logic processing for EmailHistory.
    /// </summary>    
	public partial class EmailHistoryManager
	{
	
		/// <summary>
        /// Update EmailHistory Object.
        /// Data manipulation processing for: new, deleted, updated EmailHistory
        /// </summary>
        /// <param name="emailHistoryObject"></param>
        /// <returns></returns>
        public bool Update(EmailHistory emailHistoryObject)
        {
			bool success = false;
			
			success = UpdateBase(emailHistoryObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of EmailHistory Object.
        /// </summary>
        /// <param name="emailHistoryObject"></param>
        /// <returns></returns>
        public void FillChilds(EmailHistory emailHistoryObject)
        {
			///Fill external information of Childs of EmailHistoryObject
        }
	}	
}
