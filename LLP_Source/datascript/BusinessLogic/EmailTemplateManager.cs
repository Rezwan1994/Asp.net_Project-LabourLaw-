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
    /// Business logic processing for EmailTemplate.
    /// </summary>    
	public partial class EmailTemplateManager
	{
	
		/// <summary>
        /// Update EmailTemplate Object.
        /// Data manipulation processing for: new, deleted, updated EmailTemplate
        /// </summary>
        /// <param name="emailTemplateObject"></param>
        /// <returns></returns>
        public bool Update(EmailTemplate emailTemplateObject)
        {
			bool success = false;
			
			success = UpdateBase(emailTemplateObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of EmailTemplate Object.
        /// </summary>
        /// <param name="emailTemplateObject"></param>
        /// <returns></returns>
        public void FillChilds(EmailTemplate emailTemplateObject)
        {
			///Fill external information of Childs of EmailTemplateObject
        }
	}	
}
