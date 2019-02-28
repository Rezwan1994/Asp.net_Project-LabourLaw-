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
    public class SecurityFacade: BaseFacade
    {
        public SecurityFacade(ClientContext clientContext)
            : base(clientContext)
        {

        }
        UserLoginDataAccess _UserLoginDataAccess
        {
            get
            {
                return (UserLoginDataAccess)_ClientContext[typeof(UserLoginDataAccess)];
            }
        } 

        public bool InsertUserLogin(UserLogin userLogin)
        {
            return _UserLoginDataAccess.Insert(userLogin) > 0;
        }
        public bool UpdateUserLogin(UserLogin userLogin)
        {
            return _UserLoginDataAccess.Update(userLogin) > 0;
        }
        public bool DeleteUserLogin(int id)
        {
            return _UserLoginDataAccess.Delete(id) > 0;
        }
        public UserLogin GetUserById(int id)
        {
            return _UserLoginDataAccess.Get(id);
        }
        public UserLogin GetUserByUsername(string username)
        {
             
            string query = string.Format(" UserName ='{0}'", username);
            return _UserLoginDataAccess.GetByQuery(query).FirstOrDefault();
        }
    }
}
