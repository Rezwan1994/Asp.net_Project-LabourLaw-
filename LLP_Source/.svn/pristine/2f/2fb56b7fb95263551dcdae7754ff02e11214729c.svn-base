using LLP.DataAccess;
using LLP.Entities;
using LLP.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLP.Facade
{
    public class ChatFacade :BaseFacade
    {

        public ChatFacade(ClientContext clientContext)
            : base(clientContext)
        {

        }
        public ChatFacade() 
        {

        }
        ChatMessageDataAccess _ChatMessageDataAccess
        {
            get
            {
                // return (ChatMessageDataAccess)_ClientContext[typeof(ChatMessageDataAccess)];
                return new ChatMessageDataAccess();
            }
        }
        ChatUserDataAccess _ChatUserDataAccess
        {
            get
            {
                return new ChatUserDataAccess();
            }
        }

        public bool InsertChatMessage(ChatMessage chatMessage)
        {
            return _ChatMessageDataAccess.Insert(chatMessage) > 0;
        }
        public bool UpdateChatMessage(ChatMessage chatMessage)
        {
            return _ChatMessageDataAccess.Update(chatMessage) > 0;
        }
        public bool DeleteChatMessage(int id)
        {
            return _ChatMessageDataAccess.Delete(id) > 0;
        }

        public bool InsertChatUser(ChatUser chatUser)
        {
            return _ChatUserDataAccess.Insert(chatUser) > 0;
        }

        public ChatUser getbyEmail(string email)
        {
            return _ChatUserDataAccess.GetByQuery(string.Format(" Email ='{0}'", email)).FirstOrDefault();
        }
        public ChatUser getbyUserID(Guid UserID)
        {
            return _ChatUserDataAccess.GetByQuery(string.Format(" ChatUserId ='{0}'", UserID)).FirstOrDefault();
        }
        public List<ChatUser> GetAllChatUserName()
        {

            return _ChatUserDataAccess.GetAll();
        }
        public List<ChatUser> GetChatUserByTime(string Date)
        {
            return _ChatUserDataAccess.GetChatlist(Date);
        }
        public ChatMessage GetAllBySenderId(Guid SenderID)
        {

            return _ChatMessageDataAccess.GetReadDateBySenderId(SenderID);
        }
        public List<ChatMessage> GetAllbysenderIdAndReceiverId(Guid SenderId,Guid ReceiverId)
        {

            return _ChatMessageDataAccess.GetAllbysenderId(SenderId, ReceiverId);
        }

        public ChatMessage GetSenderIdByRecieverId(Guid recieverId)
        {

            return _ChatMessageDataAccess.GetSenderIdByRecieverId(recieverId);
        }
        public UserLogin GetAllFromUserLogin(Guid SenderId)
        {

            return _ChatMessageDataAccess.GetAllFromUserLogin(SenderId);
        }

    }
}
