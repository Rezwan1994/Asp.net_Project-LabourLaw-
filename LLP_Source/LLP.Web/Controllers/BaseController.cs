﻿using LLP.Entities;
using LLP.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LLP.Web.Controllers
{
    public class BaseController : Controller
    {
        #region Util
        private WebUtil __Util;

        protected WebUtil _Util
        {
            get
            {
                if (null == __Util)
                    __Util = new WebUtil();
                return __Util;
            }
        }
        private static WebUtil __staticUtil;
        protected static WebUtil _staticUtill
        {
            get
            {
                if (null == __staticUtil)
                    __staticUtil = new WebUtil();
                return __staticUtil;
            }
        }

        public bool IsPermitted(int Id)
        {
            if (string.IsNullOrWhiteSpace((User.Identity.Name)))
            {
                return false;
            }
            UserLogin us = _Util.Facade.UserLoginFacade.GetAllUserName().Where(x => x.EmailAddress == User.Identity.Name).FirstOrDefault();
            return _Util.Facade.permissionFacade.IsPermitted(Id, us.UserId);
        }
        #endregion 

    }
}