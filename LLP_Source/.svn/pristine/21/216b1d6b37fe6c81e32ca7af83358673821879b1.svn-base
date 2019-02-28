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
    /// Business logic processing for ChatUser.
    /// </summary>    
	public partial class ChatUserManager
	{
	
		/// <summary>
        /// Update ChatUser Object.
        /// Data manipulation processing for: new, deleted, updated ChatUser
        /// </summary>
        /// <param name="chatUserObject"></param>
        /// <returns></returns>
        public bool Update(ChatUser chatUserObject)
        {
			bool success = false;
			
			success = UpdateBase(chatUserObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of ChatUser Object.
        /// </summary>
        /// <param name="chatUserObject"></param>
        /// <returns></returns>
        public void FillChilds(ChatUser chatUserObject)
        {
			///Fill external information of Childs of ChatUserObject
        }
	}	
}
