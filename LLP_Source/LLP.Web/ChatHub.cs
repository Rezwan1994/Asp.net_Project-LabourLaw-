using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNet.SignalR.Hubs;
using LLP.Entities;
using LLP.Framework;
using LLP.Framework.Utils;
using LLP.Web.Controllers;
using LLP.Facade;
using LLP.DataAccess;

namespace LLP.Web
{
    [HubName("ChatHub")]
    public class ChatHub : Hub
    {
        #region Data Members

        static List<ChatMessage> ConnectedUsers = new List<ChatMessage>();
        static List<ChatMessage> CurrentMessage = new List<ChatMessage>();
        //ChatHubController obj = new ChatHubController();
        #endregion

        #region Methods

        public void  Connect(string userName, string email,string phoneNo)
        {
            //var id = Context.ConnectionId;
            Guid userid = new Guid(Context.ConnectionId);
            Guid employeeid = Guid.NewGuid();
            // ChatUser chatusr = obj.GetId(userName);
            ChatFacade chatfacade = new ChatFacade();
            ChatUser chatusr1 = new ChatUser();

            chatusr1 = chatfacade.getbyEmail(email);
      
            if(chatusr1==null)
            {
                ChatUser chatusr = new ChatUser();

                chatusr.ChatUserId = userid;
                //HttpContext.Current.Session["UserId"]= userid;
                chatusr.Name = userName;
                chatusr.Email = email;
                chatusr.EmployeeId = employeeid;
               // HttpContext.Current.Session["EmployeeId"] = employeeid;
                chatusr.Ip = GetIPAddress();
                chatusr.JoinDate = DateTime.Today;
                chatusr.Phone = phoneNo;
                chatusr.UserAgent = "Habib";

                chatfacade.InsertChatUser(chatusr);
                // obj.InsertUser(chatusr);

                //    // send to caller
                Clients.Caller.onConnected(chatusr.ChatUserId, chatusr.Name, ConnectedUsers, CurrentMessage);
                //    // send to all except caller client
                Clients.AllExcept(chatusr.ChatUserId.ToString()).onNewUserConnected(chatusr.ChatUserId, chatusr.Name);
                
            }
         

        }


        public string GetIPAddress()
        {
            System.Web.HttpContext context = System.Web.HttpContext.Current;
            string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipAddress))
            {
                string[] addresses = ipAddress.Split(',');
                if (addresses.Length != 0)
                {
                    return addresses[0];
                }
            }

            return context.Request.ServerVariables["REMOTE_ADDR"];
        }



        public void SendMessageToAll(string userName, string message)
        {
            // store last 100 messages in cache
            AddMessageinCache(userName, message);

            // Broad cast message
            Clients.All.messageReceived(userName, message);
        }

        public void SendPrivateMessage(string UserId, string message, string rcvrId)
        {
           // string fromUserId1 = Context.ConnectionId;
            //Console.WriteLine(fromUserId1);
            string fromUserId = UserId;

            var toUserr = rcvrId;
            var toUser = ConnectedUsers.FirstOrDefault(x => x.RecieverId.ToString() == toUserr);
            var fromUser = ConnectedUsers.FirstOrDefault(x => x.SenderId.ToString() == UserId);

            if (toUser == null && fromUser == null)
            {
                ChatFacade chatfac = new ChatFacade();
                ChatMessage cm = new ChatMessage();

                var fromuserName = chatfac.getbyUserID(new Guid(fromUserId)).Name;
                // send to 
                //Clients.Client(fromUserId).sendPrivateMessage(toUserr, fromuserName, message);

                // send to caller user
                //Clients.Caller.sendPrivateMessage(fromUserId, fromuserName, message);

                cm.SenderId = new Guid(fromUserId);
                cm.RecieverId = new Guid(toUserr);
                cm.Message = message;
                cm.SendDate = DateTime.Now;
                cm.ReadDate = null;
                
                chatfac.InsertChatMessage(cm);
            }

        }

        public void sendPrivateMessageForAdmin(string UserId, string message, string ClientID)
        {
            // string fromUserId1 = Context.ConnectionId;
            //Console.WriteLine(fromUserId1);
            string fromUserId = UserId;
            var toUserr = ClientID;
            var toUser = ConnectedUsers.FirstOrDefault(x => x.RecieverId.ToString() == toUserr);
            var fromUser = ConnectedUsers.FirstOrDefault(x => x.SenderId.ToString() == UserId);

            if (toUser == null && fromUser == null)
            {
                ChatFacade chatfac = new ChatFacade();
                ChatMessage cm = new ChatMessage();

                
                // send to 
               // Clients.Client(fromUserId).sendPrivateMessage(toUserr, fromuserName, message);

                // send to caller user
               // Clients.Caller.sendPrivateMessage(fromUserId, fromuserName, message);

                cm.SenderId = new Guid(fromUserId);
                cm.RecieverId = new Guid(toUserr);
                cm.Message = message;
                cm.SendDate = DateTime.Now;
                cm.ReadDate = DateTime.Now;

                chatfac.InsertChatMessage(cm);

                //Clients.All.giveMessageAlert("Message Sent Successfully");
            }

        }


        //public void SendUpdateUserChat(string AdminId, string AdminName, string ClientID)
        //{

        //    ChatMessageDataAccess chatmsgdata = new ChatMessageDataAccess();
        //    chatmsgdata.UpdateUserChat(new Guid(AdminId), AdminName, new Guid(ClientID));

        //}

        public override System.Threading.Tasks.Task OnDisconnected()
        {
            var item = ConnectedUsers.FirstOrDefault(x => x.RecieverId.ToString() == Context.ConnectionId);
            if (item != null)
            {
                ConnectedUsers.Remove(item);
                ChatFacade chatfac = new ChatFacade();
                var toUserName = chatfac.getbyUserID(item.RecieverId).Name;
                var id = Context.ConnectionId;
                Clients.All.onUserDisconnected(id, toUserName);

            }

            return base.OnDisconnected();
        }


        #endregion

        #region private Messages

        private void AddMessageinCache(string userName, string message)
        {
           // CurrentMessage.Add(new ChatMessage { UserName = userName, Message = message });

            if (CurrentMessage.Count > 100)
                CurrentMessage.RemoveAt(0);
        }

        #endregion
    }

}