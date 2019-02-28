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
	public partial class LookupManager
	{
	
		/// <summary>
        /// Update Lookup Object.
        /// Data manipulation processing for: new, deleted, updated Lookup
        /// </summary>
        /// <param name="lookupObject"></param>
        /// <returns></returns>
        public bool Update(Lookup lookupObject)
        {
			bool success = false;
			
			success = UpdateBase(lookupObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of Lookup Object.
        /// </summary>
        /// <param name="lookupObject"></param>
        /// <returns></returns>
        public void FillChilds(Lookup lookupObject)
        {
			///Fill external information of Childs of LookupObject
        }
	}	
}
