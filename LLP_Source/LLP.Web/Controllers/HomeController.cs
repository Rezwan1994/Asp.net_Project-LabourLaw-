﻿using LLP.Entities;
using LLP.Framework;
using LLP.Framework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Security;

namespace LLP.Web.Controllers
{
    public class HomeController : BaseController
    {
     
        [HttpGet]
        public ActionResult Index()
        {
            if (Request.Url.AbsolutePath.ToLower() == "/home/index")
                return RedirectPermanent("/");
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection Form)
        {
            TempData["value"] = Request["search"];
            if (TempData["value"].ToString().Length > 0)
                return RedirectToAction("Search", "Home");
            return View("Index");
        }
        public ActionResult list(string search)
        {
            List<string> allsearch = new List<string>();
            List<int> allid = new List<int>();
            allsearch = _Util.Facade.ChapterFacade.GetAllChapterName().Where(x => x.Name.ToUpper().Contains(search)).Select(x => x.Name).ToList();

            return new JsonResult { Data = allsearch, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public ActionResult Search()
        {
           

            return View(_Util.Facade.ChapterFacade.GetAllChapterName());
        }

        public ActionResult Registration()
        {
            GlobalSetting fb = _Util.Facade.globalSettingFacade.GetAllApi().Where(x => x.SearchKey == "FbApiKey").FirstOrDefault();
            GlobalSetting gl = _Util.Facade.globalSettingFacade.GetAllApi().Where(x => x.SearchKey == "GmailApiKey").FirstOrDefault();

            ViewBag.facebookId = fb.Value.ToString();
            ViewBag.gmailLoginkey = gl.Value.ToString();
            return View();
        }

        public ActionResult TreePartialView(string searchText)
        {
            List<Chapter> chapterList = new List<Chapter>();
            List<ChapterContent> cpList = new List<ChapterContent>();

           // chapterList = _Util.Facade.ChapterFacade.GetAllChapterName();

            //if (searchText != null)
           // {
                //
                chapterList = _Util.Facade.ChapterFacade.GeChapterName(searchText);
                cpList = _Util.Facade.ChapterContentFacade.GetContentName(searchText);
              
                BookChapter bk = new BookChapter();
                bk.ChapterList = chapterList;
                bk.ContentList = cpList;
                return View(bk);
           // }
            //else
            //{
          
            //    cpList = _Util.Facade.ChapterContentFacade.GetAllChapterName();
            //    BookChapter bk = new BookChapter();
            //    bk.ChapterList = chapterList;
            //    bk.ContentList = cpList;
            //    return View(bk);
            //}
         
        }

        public ActionResult TreePartialView2(string searchText)
        {
            List<Chapter> chapterList = new List<Chapter>();
            List<ChapterContent> cpList = new List<ChapterContent>();

            // chapterList = _Util.Facade.ChapterFacade.GetAllChapterName();

            //if (searchText != null)
            // {
            //
            chapterList = _Util.Facade.ChapterFacade.GeChapterName(searchText);
            cpList = _Util.Facade.ChapterContentFacade.GetContentName(searchText);

            BookChapter bk = new BookChapter();
            bk.ChapterList = chapterList;
            bk.ContentList = cpList;
            return View(bk);
            // }
            //else
            //{

            //    cpList = _Util.Facade.ChapterContentFacade.GetAllChapterName();
            //    BookChapter bk = new BookChapter();
            //    bk.ChapterList = chapterList;
            //    bk.ContentList = cpList;
            //    return View(bk);
            //}

        }

        public ActionResult Login()
        {

            return View();
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            //Session.Remove("UserName");
            return RedirectToAction("Index","Home");
        }
        public ActionResult UserChecking(UserLogin Content)
        {

            bool result = false;
            string Messege = "";
            try
            {
                if (_Util.Facade.UserLoginFacade.GetAllUserName().Where(x => x.EmailAddress == Content.EmailAddress && x.Password == Content.Password && x.IsActive == true).Count() > 0)
                {
                    FormsAuthentication.SetAuthCookie(Content.EmailAddress, false);
                    //Session["UserName"] = Content.EmailAddress;
                    result = true;

                }
                else
                {
                    result = false;


                }

            }
            catch (Exception ex)
            {

            }


            // return RedirectToAction("Dashboard");
            return Json(new { result = result, Messege = Messege });
        }

        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public ActionResult SaveUser(UserLogin Content)
        {
            

      

            bool result = false;
            string Messege = "";
            try
            {
                if (Content.Id > 0)
                {
                    Content.LastUpdatedBy = Content.UserId.ToString();
                    Content.LastUpdatedDate = DateTime.Now;
                    _Util.Facade.UserLoginFacade.UpdateUser(Content);

           
                   


                }
                else
                {
                    if(_Util.Facade.UserLoginFacade.GetAllUserName().Where(x => x.EmailAddress == Content.EmailAddress).Count() > 0)
                    {
                        Messege = "Email Already Exist";
                        result = false;
                    }
                    else
                    {
                        Content.UserId = Guid.NewGuid();
                        Content.LastUpdatedBy = Content.UserId.ToString();
                        Content.LastUpdatedDate = DateTime.Now;
                       _Util.Facade.UserLoginFacade.InsertUser(Content);
                        result = true;
                        BuildEmailTemplate(Content.Id);
                        Messege = TempData["Link"].ToString();
                  
                    }
                
                  
                }
     
            }
            catch (Exception ex)
            {

            }
        
   
            // return RedirectToAction("Dashboard");
            return Json(new { result = result , Messege = Messege});


        }


        public ActionResult GoogleLogin(UserLogin Content)
        { 
            bool result = false;
            string Messege = "";
            string url = "";
            try
            {
                UserLogin userObj = _Util.Facade.UserLoginFacade.GetUserEmail(Content.EmailAddress);
                if (userObj != null)
                {
                    userObj.LastUpdatedBy = Content.UserId.ToString();
                    userObj.LastUpdatedDate = DateTime.Now;
                    _Util.Facade.UserLoginFacade.UpdateUser(Content);
                    Session["UserName"] = Content.EmailAddress;
                    result = true;
                    url = "/User/Index";
                    return Json(new { result = result, url = url });
                }
                else
                {
                    Content.UserId = Guid.NewGuid();
                    Content.IsActive = true;
                    Content.Password = CreatePassword(8);
                    Content.LastUpdatedBy = Content.UserId.ToString();
                    Content.LastUpdatedDate = DateTime.Now;
                    _Util.Facade.UserLoginFacade.InsertUser(Content);
                    Session["UserName"] = Content.EmailAddress;
                    result = true;
                    url = "/User/Index";
                    return Json(new { result = result, url = url });
                }

            }
            catch (Exception ex)
            {

            }


            // return RedirectToAction("Dashboard");
            return Json(new { result = result, Messege = Messege });


        }


        public ActionResult Confirm()
        {
            if (Request.QueryString["regId"] != null)
            {
                EncryptionDeycryption salt = new EncryptionDeycryption();
                string code = HttpUtility.HtmlDecode(Request.QueryString["regId"].ToString());
                string result = DESEncryptionDecryption.DecryptCipherTextToPlainText(code);
         
                string[] resultsplit = result.Split('#');
                if (resultsplit.Length > 0)
                {
                    string userId = "";
                    string email = "";
                    for (int icount = 0; icount < resultsplit.Length; icount++)
                    {
                        if (userId == "")
                        {
                            userId = resultsplit[icount];
                         
                        }
                        else 
                        {
                            email = resultsplit[icount];
                        }
                    }
                    UserLogin Data = _Util.Facade.UserLoginFacade.GetAllUserName().Where(x => x.Id ==Convert.ToInt32( userId)).FirstOrDefault();
                    if(Data.IsActive == false)
                    {
                       
                        Data.IsActive = true;
                        UserPermission up = new UserPermission();
                        up.CompanyId = Guid.NewGuid();
                        up.PermissionGroupId = 1;
                        up.UserId = Data.UserId;
                        _Util.Facade.permissionFacade.InsertUserPermission(up);


                    }
                    else
                    {

                    }
            
                
                    ViewBag.regID = userId;
                }
        

            }
          
            return View();
        }
 

        public JsonResult RegisterConfirm(int regId)
        {
            string msg = "";
            UserLogin Data = _Util.Facade.UserLoginFacade.GetAllUserName().Where(x => x.Id == regId).FirstOrDefault();
            if(Data.IsActive == false)
            {
                Data.IsActive = true;
                _Util.Facade.UserLoginFacade.UpdateUser(Data);
             
            }
            else
            {
                msg = "Your Email Is already Verified!";
            }
      
            return Json(msg, JsonRequestBehavior.AllowGet);
        }
        public void BuildEmailTemplate(int regID)
        {
            string ActivationLink = "{0}##{1}";
     
            var regInfo = _Util.Facade.UserLoginFacade.GetAllUserName().Where(x => x.Id == regID).FirstOrDefault();

            EncryptionDeycryption salt = new EncryptionDeycryption();
             ActivationLink = string.Format("?regId={0}",
               HttpUtility.UrlEncode(
                    DESEncryptionDecryption.EncryptPlainTextToCipherText(string.Format(ActivationLink, regID, regInfo.EmailAddress))));
            if(regID>0)
            {
                VerifyEmail ver = new VerifyEmail();
                ver.Name = regInfo.UserName;
                ver.ToEmail = regInfo.EmailAddress;
                ver.EmailVerificationLink = AppConfig.SiteDomain + "/Home/Confirm" + ActivationLink;
                TempData["Link"] = ver.EmailVerificationLink;
         
                if(_Util.Facade.MailFacade.SendEmailVerify(ver) == true)
                {
                    _Util.Facade.MailFacade.SendSuccessEmail(ver);
                }
            }
        
        
        }
     

        //public void BuildEmailTemplate(string subjectText, string bodyText, string sendTo)
        //{
        //    string from, to, bcc, cc, subject, body;
        //    from = "YourEmail@gmail.com";
        //    to = sendTo.Trim();
        //    bcc = "";
        //    cc = "";
        //    subject = subjectText;
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append(bodyText);
        //    body = sb.ToString();
        //    MailMessage mail = new MailMessage();
        //    mail.From = new MailAddress(from);
        //    mail.To.Add(new MailAddress(to));
        //    if (!string.IsNullOrEmpty(bcc))
        //    {
        //        mail.Bcc.Add(new MailAddress(bcc));
        //    }
        //    if (!string.IsNullOrEmpty(cc))
        //    {
        //        mail.CC.Add(new MailAddress(cc));
        //    }
        //    mail.Subject = subject;
        //    mail.Body = body;
        //    mail.IsBodyHtml = true;
        //    SendEmail(mail);
        //}
       
        public JsonResult Login_By_Fb(UserLogin content)
        {
            bool result = false;
            string msg = "";
            try
            {
                //email query 
                UserLogin user = _Util.Facade.UserLoginFacade.GetUserEmail(content.EmailAddress);
                if (user != null)
                {
                    _Util.Facade.UserLoginFacade.UpdateUser(content);
                    if(user.IsActive == false)
                    {
                        result = false;
                        msg = "Invalid User. Please contact with administration...";
                    }
                    else
                    {
                        result = true;
                    }
                    
                }
                else
                {
                    content.Password = CreatePassword(5);
                    content.UserId = Guid.NewGuid();
                    content.LastUpdatedBy = content.UserId.ToString();
                    content.LastUpdatedDate = DateTime.Now;
                    result =  _Util.Facade.UserLoginFacade.InsertUser(content);
                    
                }
                //if no record insert and return true// password// email send with new and congration. 
                //if record with active status return true
                //if record with non activ status retur false
         
                Session["UserName"] = content.UserName;
            
            }
            catch (Exception ex)
            {

            }
            return Json(new { result = result, msg = msg });
        }
        //public static void SendEmail(MailMessage mail)
        //{
        //    SmtpClient client = new SmtpClient();
        //    client.Host = "smtp.gmail.com";
        //    client.Port = 587;
        //    client.EnableSsl = true;
        //    client.UseDefaultCredentials = false;
        //    client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //    client.Credentials = new System.Net.NetworkCredential("rezwan.aiub10@gmail.com", "Rezwan10");
        //    try
        //    {
        //        client.Send(mail);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public ActionResult SearchInbook(string search)
        {
            List<string> searchtitle = new List<string>();
            searchtitle = _Util.Facade.ChapterContentFacade.GetAllChapterName().Where(x=>x.CpContent.ToLower().Contains(search.ToLower())).Select(x=>x.Title).ToList();


            return new JsonResult { Data = searchtitle, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public ActionResult ShowContentbyTitle(string  title)
        {
           
            ChapterContent coo = new ChapterContent();
            foreach(ChapterContent cp in _Util.Facade.ChapterContentFacade.GetAllChapterName())
             {
                if(cp.Title == title)
                {
                    coo = cp;
                }
               
            }
            return View(coo);

        }


        public ActionResult English()
        {
            HttpCookie Cookie = new HttpCookie("__Lng");
            Cookie.Value = "En-US";
            Cookie.Expires = DateTime.UtcNow.AddDays(30);
            Response.Cookies.Add(Cookie);

            return Redirect(Request.UrlReferrer.ToString());
        }


        public ActionResult Bangla()
        {
            HttpCookie Cookie = new HttpCookie("__Lng");
            Cookie.Value = "Bn-BGD";
            Cookie.Expires = DateTime.UtcNow.AddDays(30);
            Response.Cookies.Add(Cookie);

            return Redirect(Request.UrlReferrer.ToString());
        }

        public ActionResult TitleDetails(int ChapterNo, string ChapterName)
        {
            //int title = Convert.ToInt32( Request["Title"]);
            Chapter ch = _Util.Facade.ChapterFacade.GetChapter(ChapterNo);
            string chapterNo = ch.ChapterNo;
            return View(_Util.Facade.ChapterContentFacade.GetChapterContent(chapterNo));
        }

        public ActionResult Chat()
        {
            return View();
        }
    }
}