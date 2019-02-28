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
	public partial class LocalizeResourceManager
	{
	
		/// <summary>
        /// Update LocalizeResource Object.
        /// Data manipulation processing for: new, deleted, updated LocalizeResource
        /// </summary>
        /// <param name="localizeResourceObject"></param>
        /// <returns></returns>
        public bool Update(LocalizeResource localizeResourceObject)
        {
			bool success = false;
			
			success = UpdateBase(localizeResourceObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of LocalizeResource Object.
        /// </summary>
        /// <param name="localizeResourceObject"></param>
        /// <returns></returns>
        public void FillChilds(LocalizeResource localizeResourceObject)
        {
			///Fill external information of Childs of LocalizeResourceObject
        }
	}	
}
