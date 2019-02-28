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
   public class GlobalSettingFacade : BaseFacade
    {
        public GlobalSettingFacade(ClientContext clientContext)
            : base(clientContext)
        {

        }
        GlobalSettingDataAccess _GlobalSettingDataAccess
        {
            get
            {
                return (GlobalSettingDataAccess)_ClientContext[typeof(GlobalSettingDataAccess)];
            }
        }

  
    

        public List<GlobalSetting> GetAllApi()
        {

            return _GlobalSettingDataAccess.GetAll();
        }
   
      
     

    }
}
