using LLP.DataAccess;
using LLP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LLP.Facade
{
    public class LocalizeFacade : IDisposable
    {
        LanguageDataAccess _LanguageDataAccess
        {
            get
            {
                return new LanguageDataAccess();
            }
        }
        LocalizeResourceDataAccess _LocalizeResourceDataAccess
        {
            get
            {
                return new LocalizeResourceDataAccess();
            }
        }
        public LocalizeFacade()
        {

        }
        public string GetResource(string resourceKey, string languagevalue)
        {
            string result = string.Empty;
            string currentLanguage = languagevalue;
             
            List<LocalizeResource> resources = new List<LocalizeResource>();
            if (System.Web.HttpRuntime.Cache["LanguagePack"] == null)
            {
                resources = _LocalizeResourceDataAccess.GetAll();
                System.Web.HttpRuntime.Cache["LanguagePack"] = resources;
            }
            else
            {
                resources = (List<LocalizeResource>)System.Web.HttpRuntime.Cache["LanguagePack"];
            }


            Language language = new Language();
            if (System.Web.HttpRuntime.Cache["Language"] == null)
            {
                language = _LanguageDataAccess.GetByQuery(" LanguageCulture='" + currentLanguage + "' ").FirstOrDefault();
                System.Web.HttpRuntime.Cache["Language"] = language;
            }
            else
            {
                language = (Language)System.Web.HttpRuntime.Cache["Language"];
                if (language.LanguageCulture != currentLanguage)
                {
                    language = _LanguageDataAccess.GetByQuery(" LanguageCulture='" + currentLanguage + "' ").FirstOrDefault();
                    System.Web.HttpRuntime.Cache["Language"] = language;
                }
            }
            if (resources.Count > 0)
            {
                var res = resources.Where(r => r.ResourceName.Trim().ToLower() == resourceKey.Trim().ToLower() && r.LanguageId == language.Id).FirstOrDefault();
                if (res != null)
                    result = res.ResourceValue.Trim();
                else
                    result = resourceKey;
            }

            return result;

        }
        public string GetResource(string resourceKey)
        {
            string result = string.Empty;
            string currentLanguage = "en-US";
            if (HttpContext.Current.Request.Cookies["__Lng"] != null)
            {
                currentLanguage = HttpContext.Current.Request.Cookies["__Lng"].Value;
            } 
            List<LocalizeResource> resources = new List<LocalizeResource>();
            if (System.Web.HttpRuntime.Cache["LanguagePack"] == null)
            {
                resources = _LocalizeResourceDataAccess.GetAll();
                System.Web.HttpRuntime.Cache["LanguagePack"] = resources;
            }
            else
            {
                resources = (List<LocalizeResource>)System.Web.HttpRuntime.Cache["LanguagePack"];
            }


            Language language = new Language();
            if (System.Web.HttpRuntime.Cache["Language"] == null)
            {
                language = _LanguageDataAccess.GetByQuery(" LanguageCulture='" + currentLanguage + "' ").FirstOrDefault();
                System.Web.HttpRuntime.Cache["Language"] = language;
            }
            else
            {
                language = (Language)System.Web.HttpRuntime.Cache["Language"];
                if (language.LanguageCulture != currentLanguage)
                {
                    language = _LanguageDataAccess.GetByQuery(" LanguageCulture='" + currentLanguage + "' ").FirstOrDefault();
                    System.Web.HttpRuntime.Cache["Language"] = language;
                }
            }
            if (resources.Count > 0)
            {
                var res = resources.Where(r => r.ResourceName.Trim().ToLower() == resourceKey.Trim().ToLower() && r.LanguageId == language.Id).FirstOrDefault();
                if (res != null)
                    result = res.ResourceValue.Trim();
                else
                    result = resourceKey;
            }

            return result;

        }

        /// <summary>
        ///  IDisposable Members
        /// </summary>
        public void Dispose()
        {
        }
    }
}
