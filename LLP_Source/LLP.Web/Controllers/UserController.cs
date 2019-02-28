﻿using LLP.Entities;
using LLP.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LLP.Web.Controllers
{
    public class UserController : BaseController
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Test()
        //{
        //    List<LocalizeResource> lr = new List<LocalizeResource>();
        //    List<ChapterContent> cp = new List<ChapterContent>();
        //    Test tt = new Test();
        //    lr = _Util.Facade.ResourceFacade.GetAllResourceName();
        //    cp = _Util.Facade.ChapterContentFacade.GetAllChapterName();
        //    tt.contentlist = cp;
        //    tt.resourcelist = lr;
        //    int j = 0;
        //    // for(int i=0; i<lr.Count();i++)
        //   for (int i = 1; i < cp.Count(); i++)
        //   // for (int i = 4239; i < 4934; i++)
        //    {

        //        LocalizeResource li = _Util.Facade.ResourceFacade.GetAllResourceName();
        //        ChapterContent cc = _Util.Facade.ChapterContentFacade.GetAllChapterName().Where(x => x.Id == i).FirstOrDefault();
        //        if (li != null)
        //        {
        //            lr[i].ResourceName = Guid.NewGuid().ToString();
        //            _Util.Facade.ResourceFacade.UpdateResource(lr[i]);
        //            cp[i].CpContent = lr[j].ResourceName;
        //        _Util.Facade.ChapterContentFacade.UpdateChapter(cp[i]);
        //        j++;
        //    }

        //    if (cc != null)
        //    {
        //        cc.CpContent = lr[i].ResourceName;
        //        _Util.Facade.ChapterContentFacade.UpdateChapter(cc);
        //    }
        //    if (cc != null)
        //    {
        //        LocalizeResource lt = _Util.Facade.ResourceFacade.GetAllResourceName().Where(x => x.Id == z).FirstOrDefault();
        //        cc.CpContent = lt.ResourceName;
        //        _Util.Facade.ChapterContentFacade.UpdateChapter(cc);
        //        z++;
        //    }
        //}
        //    return View();
        //}

        public ActionResult DashBoard()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UserLogin()
        {
            UserLogin em = _Util.Facade.UserLoginFacade.GetAllUserName().Where(x => x.EmailAddress == Session["UserName"].ToString()).FirstOrDefault();

            return View(em);
        }

        public JsonResult UpdateUser(UserLogin user)
        {
            bool result = false;
            try
            {
                _Util.Facade.UserLoginFacade.UpdateUser(user);
                result = true;
            }
            catch (Exception ex)
            {

            }
            // return RedirectToAction("Dashboard");
            return Json(result);
        }
    }
}