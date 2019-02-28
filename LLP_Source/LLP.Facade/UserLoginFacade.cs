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
    public class UserLoginFacade : BaseFacade
    {
        public UserLoginFacade(ClientContext clientContext)
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

        public bool InsertUser(UserLogin user)
        {
            return _UserLoginDataAccess.Insert(user) > 0;
        }
        public bool UpdateUser(UserLogin user)
        {
            return _UserLoginDataAccess.Update(user) > 0;
        }
        public bool DeleteUser(int id)
        {
            return _UserLoginDataAccess.Delete(id) > 0;
        }
        public UserLogin GetUserById(int id)
        {
            return _UserLoginDataAccess.Get(id);
        }
        public UserLogin GetUserName(string user)
        {

            string query = string.Format(" UserName ='{0}'", user);
            return _UserLoginDataAccess.GetByQuery(query).FirstOrDefault();
        }
        public UserLogin GetUserEmail(string email)
        {

            string query = string.Format(" EmailAddress ='{0}'", email);
            return _UserLoginDataAccess.GetByQuery(query).FirstOrDefault();
        }

        public List<UserLogin> GetAllUserName()
        {

            return _UserLoginDataAccess.GetAll();
        }
        public List<UserLogin> GetAllUserName(int PageNumber, int UnitPerPage, string SearchText)
        {

            return _UserLoginDataAccess.GetAllUserName(PageNumber, UnitPerPage, SearchText);
        }
    }
}
