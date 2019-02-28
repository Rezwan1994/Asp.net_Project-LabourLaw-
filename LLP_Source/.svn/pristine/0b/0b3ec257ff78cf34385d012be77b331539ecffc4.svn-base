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
	public partial class ChatUserManager : BaseManager
	{
	
		#region Constructors
		public ChatUserManager(ClientContext context) : base(context) { }
		public ChatUserManager(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
		
		#region Insert Method		
		/// <summary>
        /// Insert new chatUser.
        /// data manipulation for insertion of ChatUser
        /// </summary>
        /// <param name="chatUserObject"></param>
        /// <returns></returns>
        private bool Insert(ChatUser chatUserObject)
        {
            // new chatUser
            using (ChatUserDataAccess data = new ChatUserDataAccess(ClientContext))
            {
                // insert to chatUserObject
                Int32 _Id = data.Insert(chatUserObject);
                // if successful, process
                if (_Id > 0)
                {
                    chatUserObject.Id = _Id;
                    return true;
                }
                else
                    return false;
            }
        }
		#endregion
		
		#region Update Method
		
		/// <summary>
        /// Update base of ChatUser Object.
        /// Data manipulation processing for: new, deleted, updated ChatUser
        /// </summary>
        /// <param name="chatUserObject"></param>
        /// <returns></returns>
        public bool UpdateBase(ChatUser chatUserObject)
        {
            // use of switch for different types of DML
            switch (chatUserObject.RowState)
            {
                // insert new rows
                case BaseBusinessEntity.RowStateEnum.NewRow:
                    return Insert(chatUserObject);
                // delete rows
                case BaseBusinessEntity.RowStateEnum.DeletedRow:
                    return Delete(chatUserObject.Id);
            }
            // update rows
            using (ChatUserDataAccess data = new ChatUserDataAccess(ClientContext))
            {
                return (data.Update(chatUserObject) > 0);
            }
        }
		
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Delete operation for ChatUser
        /// <param name="_Id"></param>
        /// <returns></returns>
        private bool Delete(Int32 _Id)
        {
            using (ChatUserDataAccess data = new ChatUserDataAccess(ClientContext))
            {
                // return if code > 0
                return (data.Delete(_Id) > 0);
            }
        }
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieve ChatUser data using unique ID
        /// </summary>
        /// <param name="_Id"></param>
        /// <returns>ChatUser Object</returns>
        public ChatUser Get(Int32 _Id)
        {
            using (ChatUserDataAccess data = new ChatUserDataAccess(ClientContext))
            {
                return data.Get(_Id);
            }
        }
		
		
		/// <summary>
        /// Retrieve detail information for a ChatUser .
        /// Detail child data includes:
        /// last updated on:
        /// change description:
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="fillChild"></param>
        /// <returns></returns>
        public ChatUser Get(Int32 _Id, bool fillChild)
        {
            ChatUser chatUserObject;
            chatUserObject = Get(_Id);
            
            if (chatUserObject != null && fillChild)
            {
                // populate child data for a chatUserObject
                FillChatUserWithChilds(chatUserObject, fillChild);
            }

            return chatUserObject;
        }
		
		/// <summary>
        /// populates a ChatUser with its child entities
        /// </summary>
        /// <param name="chatUser"></param>
		/// <param name="fillChilds"></param>
        private void FillChatUserWithChilds(ChatUser chatUserObject, bool fillChilds)
        {
            // populate child data for a chatUserObject
            if (chatUserObject != null)
            {
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieve list of ChatUser.
        /// no parameters required to be passed in.
        /// </summary>
        /// <returns>List of ChatUser</returns>
        public ChatUserList GetAll()
        {
            using (ChatUserDataAccess data = new ChatUserDataAccess(ClientContext))
            {
                return data.GetAll();
            }
        }
		
		/// <summary>
        /// Retrieve list of ChatUser.
        /// </summary>
        /// <param name="fillChild"></param>
        /// <returns>List of ChatUser</returns>
        public ChatUserList GetAll(bool fillChild)
        {
			ChatUserList chatUserList = new ChatUserList();
            using (ChatUserDataAccess data = new ChatUserDataAccess(ClientContext))
            {
                chatUserList = data.GetAll();
            }
			if (fillChild)
            {
				foreach (ChatUser chatUserObject in chatUserList)
                {
					FillChatUserWithChilds(chatUserObject, fillChild);
				}
			}
			return chatUserList;
        }
		
		/// <summary>
        /// Retrieve list of ChatUser  by PageRequest.
        /// <param name="request"></param>
        /// </summary>
        /// <returns>List of ChatUser</returns>
        public ChatUserList GetPaged(PagedRequest request)
        {
            using (ChatUserDataAccess data = new ChatUserDataAccess(ClientContext))
            {
                return data.GetPaged(request);
            }
        }
		
		/// <summary>
        /// Retrieve list of ChatUser  by query String.
        /// <param name="query"></param>
        /// </summary>
        /// <returns>List of ChatUser</returns>
        public ChatUserList GetByQuery(String query)
        {
            using (ChatUserDataAccess data = new ChatUserDataAccess(ClientContext))
            {
                return data.GetByQuery(query);
            }
        }
		#region Get ChatUser Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of ChatUser
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			using (ChatUserDataAccess data = new ChatUserDataAccess(ClientContext))
            {
                return data.GetMaxId();
            }
		}
		
		#endregion
		
		#region Get ChatUser Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of ChatUser
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			using (ChatUserDataAccess data = new ChatUserDataAccess(ClientContext))
            {
                return data.GetRowCount();
            }
		}
		
		#endregion
	
		
		#endregion
	}	
}
