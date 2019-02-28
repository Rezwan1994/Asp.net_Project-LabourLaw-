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
    /// Business logic processing for ChatMessage.
    /// </summary>    
	public partial class ChatMessageManager
	{
	
		/// <summary>
        /// Update ChatMessage Object.
        /// Data manipulation processing for: new, deleted, updated ChatMessage
        /// </summary>
        /// <param name="chatMessageObject"></param>
        /// <returns></returns>
        public bool Update(ChatMessage chatMessageObject)
        {
			bool success = false;
			
			success = UpdateBase(chatMessageObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of ChatMessage Object.
        /// </summary>
        /// <param name="chatMessageObject"></param>
        /// <returns></returns>
        public void FillChilds(ChatMessage chatMessageObject)
        {
			///Fill external information of Childs of ChatMessageObject
        }
	}	
}
