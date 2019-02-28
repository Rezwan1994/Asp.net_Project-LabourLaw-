using LLP.Entities;
using LLP.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LLP.Web.Controllers
{
    public class ChatHubController : BaseController
    {
        // GET: ChatHub
        public ActionResult Index()
        {
            return View();
        }

        //public ChatUser GetId(string email)
        //{
        //    return _Util.Facade.chatFacade.getbyEmail(email);
        //}
        public bool InsertUser(ChatUser chatUser)
        {
            return _Util.Facade.chatFacade.InsertChatUser(chatUser);
        }


        [HttpPost]
        public JsonResult StoreInfoToChatUser(string userName, string email, string phoneNo)
        {
            bool isExist = false;
            //var id = Context.ConnectionId;
            Guid userid = Guid.NewGuid();
            Guid employeeid = Guid.NewGuid();
            // ChatUser chatusr = obj.GetId(userName);
            ChatFacade chatfacade = new ChatFacade();
            ChatUser chatusr1 = new ChatUser();

            chatusr1 = chatfacade.getbyEmail(email);

            if (chatusr1 == null)
            {
                ChatUser chatusr = new ChatUser();

                chatusr.ChatUserId = userid;
                Session["UserId"] = userid;
                chatusr.Name = userName;
                chatusr.Email = email;
                chatusr.EmployeeId = employeeid;
                Session["EmployeeId"] = employeeid;
                chatusr.Ip = "sjhdgfsj";
                chatusr.JoinDate = DateTime.Now;
                chatusr.Phone = phoneNo;
                chatusr.UserAgent = "Habib";

                chatfacade.InsertChatUser(chatusr);
                // obj.InsertUser(chatusr);
            }
            else
            {
                isExist = true;
                Session["UserId"] = chatusr1.ChatUserId;
                Session["EmployeeId"] = chatusr1.EmployeeId;
            }
            return Json(new { isExist = isExist }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult StoreInfoToChatMessage(string message, Guid userId)
        {
            bool result = false, isExist = false;

            ChatMessage chatMessage = new ChatMessage();
            chatMessage.SenderId = userId;
            chatMessage.RecieverId = new Guid();
            chatMessage.Message = message;
            chatMessage.SendDate = DateTime.Now;
            chatMessage.ReadDate = null;
            _Util.Facade.chatFacade.InsertChatMessage(chatMessage);

            if (_Util.Facade.chatFacade.GetAllBySenderId(userId).ReadDate != null)
            {
                result = true;
            }
            if (_Util.Facade.chatFacade.getbyUserID(userId) != null)
            {
                isExist = true;
            }


            return Json(new { result = result, isExist = isExist }, JsonRequestBehavior.AllowGet);
        }



        public JsonResult GetReadDateBySenderId(Guid senderId)
        {

            ChatMessage cm = _Util.Facade.chatFacade.GetAllBySenderId(senderId);
            DateTime date = cm.ReadDate.Value;
            Session["ReadDate"] = date;
            return Json(JsonRequestBehavior.AllowGet);
        }



        [HttpGet]
        public JsonResult GetIdByEmail(string userName, string email, string phoneNo)
        {
           ChatUser chtuser = _Util.Facade.chatFacade.getbyEmail(email) ;

            string id ="";
            string SenderId;
            try
            {
                id = chtuser.ChatUserId.ToString();
            }
            catch(Exception ex)
            {
                id = "";
            }
            try
            {
                SenderId = _Util.Facade.chatFacade.GetSenderIdByRecieverId(new Guid(id)).SenderId.ToString();
            }
           catch(Exception ex)
            {
                SenderId = ""; 
            }
            return Json(new { Id = id,SenderId = SenderId }, JsonRequestBehavior.AllowGet);
        }



        public JsonResult GetAllBySenderIdAndReceiverId(Guid SenderId,Guid ReceiverId)
        {
            List<ChatMessage> Chat = new List<ChatMessage>();
            List<ChatMessage> Chat1 = new List<ChatMessage>();
            bool readDate = false;
            Chat = _Util.Facade.chatFacade.GetAllbysenderIdAndReceiverId(SenderId, ReceiverId).ToList();
            if (Chat.Count != 0)
            {
                readDate = true;
                    
                 //Chat.Where(x => x.SenderId == SenderId).FirstOrDefault().ReadDate.HasValue ? readDate.ToString() : "";
            }
            return Json(new {Chat = Chat, readDate = readDate},JsonRequestBehavior.AllowGet);
        }

        
        //public JsonResult SendUpdateUserChat(string AdminId, string AdminName, string ClientID)
        //{

        //    ChatFacade cf = new ChatFacade();
        //    cf.SendUpdateUserChat(AdminId, AdminName, ClientID);


        //    return Json( JsonRequestBehavior.AllowGet);
        //}
        public ActionResult Loader()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetSenderIdByRecieverId(string ClientId)
        {

            string SenderId;
            string Name;
            try
            {
                SenderId = _Util.Facade.chatFacade.GetSenderIdByRecieverId(new Guid(ClientId)).SenderId.ToString();
            }
            catch (Exception ex)
            {
                SenderId = "";
            }
            try
            {
                Name = _Util.Facade.chatFacade.GetAllFromUserLogin(new Guid(SenderId)).UserName.ToString();
            }
            catch (Exception ex)
            {
                Name = "";
            }
            return Json(new { Name = Name, SenderId = SenderId }, JsonRequestBehavior.AllowGet);
        }


    }




}