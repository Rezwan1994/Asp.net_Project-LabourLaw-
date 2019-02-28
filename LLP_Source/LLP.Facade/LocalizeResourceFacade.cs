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
    public class LocalizeResourceFacade : BaseFacade
    {
        public LocalizeResourceFacade(ClientContext clientContext)
            : base(clientContext)
        {

        }
        LocalizeResourceDataAccess _LocalizeResourceDataAccess
        {
            get
            {
                return (LocalizeResourceDataAccess)_ClientContext[typeof(LocalizeResourceDataAccess)];
            }
        }

        public bool InsertLocalizeResource(LocalizeResource resource)
        {
            return _LocalizeResourceDataAccess.Insert(resource) > 0;
        }
        public bool UpdateResource(LocalizeResource resource)
        {
            return _LocalizeResourceDataAccess.Update(resource) > 0;
        }
        public bool DeleteResource(int id)
        {
            return _LocalizeResourceDataAccess.Delete(id) > 0;
        }
        public LocalizeResource GetResourceById(int id)
        {
            return _LocalizeResourceDataAccess.Get(id);
        }
        public LocalizeResource GetResourceName(string resourcename)
        {

            string query = string.Format(" UserName ='{0}'", resourcename);
            return _LocalizeResourceDataAccess.GetByQuery(query).FirstOrDefault();
        }

        public List<LocalizeResource> GetAllResourceName()
        {

            return _LocalizeResourceDataAccess.GetAll();
        }
    }
}
