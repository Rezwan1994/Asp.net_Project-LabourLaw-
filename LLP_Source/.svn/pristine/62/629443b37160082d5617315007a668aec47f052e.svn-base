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
    /// Business logic processing for Language.
    /// </summary>    
	public partial class LanguageManager
	{
	
		/// <summary>
        /// Update Language Object.
        /// Data manipulation processing for: new, deleted, updated Language
        /// </summary>
        /// <param name="languageObject"></param>
        /// <returns></returns>
        public bool Update(Language languageObject)
        {
			bool success = false;
			
			success = UpdateBase(languageObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of Language Object.
        /// </summary>
        /// <param name="languageObject"></param>
        /// <returns></returns>
        public void FillChilds(Language languageObject)
        {
			///Fill external information of Childs of LanguageObject
        }
	}	
}
