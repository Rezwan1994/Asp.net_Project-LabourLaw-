using LLP.Facade;
using LLP.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LLP.Web.App_Start
{
  
    public class WebUtil
    {
        private const string CONTEXT_FACADE = "HS.Facade.TheFacade";
        private readonly HttpContext _Context = HttpContext.Current;
        private SessionHelper _SessionUtil;

        public WebUtil()
        {

        }
        public SessionHelper SessionUtil
        {
            get
            {
                if (null == _SessionUtil)
                    _SessionUtil = new SessionHelper();
                return _SessionUtil;
            }
        }
        public Client Client
        {
            get { return SessionUtil.GetClient(); }
        }


        public TheFacade Facade
        {
            get
            {
                var facade = _Context.Items[CONTEXT_FACADE] as TheFacade;
                if (null == facade)
                {
                    facade = new TheFacade(Client);
                    _Context.Items[CONTEXT_FACADE] = facade;
                }

                return facade;
            }
        }
    }
    
}