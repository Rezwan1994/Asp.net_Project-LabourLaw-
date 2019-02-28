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
    /// Business logic processing for PasswordReset.
    /// </summary>    
	public partial class PasswordResetManager
	{
	
		/// <summary>
        /// Update PasswordReset Object.
        /// Data manipulation processing for: new, deleted, updated PasswordReset
        /// </summary>
        /// <param name="passwordResetObject"></param>
        /// <returns></returns>
        public bool Update(PasswordReset passwordResetObject)
        {
			bool success = false;
			
			success = UpdateBase(passwordResetObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of PasswordReset Object.
        /// </summary>
        /// <param name="passwordResetObject"></param>
        /// <returns></returns>
        public void FillChilds(PasswordReset passwordResetObject)
        {
			///Fill external information of Childs of PasswordResetObject
        }
	}	
}
