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
    public class EmployeeFacade : BaseFacade
    {
        public EmployeeFacade(ClientContext clientContext)
            : base(clientContext)
        {

        }
        EmployeeDataAccess _EmployeeDataAccess
        {
            get
            {
                return (EmployeeDataAccess)_ClientContext[typeof(EmployeeDataAccess)];
            }
        }

        public bool InsertEmployee(Employee employee)
        {
            return _EmployeeDataAccess.Insert(employee) > 0;
        }
        public bool UpdateEmployee(Employee employee)
        {
            return _EmployeeDataAccess.Update(employee) > 0;
        }
        public bool DeleteEmployee(int id)
        {
            return _EmployeeDataAccess.Delete(id) > 0;
        }
        public Employee GetEmployeeById(int id)
        {
            return _EmployeeDataAccess.Get(id);
        }
        public Employee GetEmployeeName(string employeename)
        {

            string query = string.Format(" UserName ='{0}'", employeename);
            return _EmployeeDataAccess.GetByQuery(query).FirstOrDefault();
        }

        public List<Employee> GetAllEmployeeName()
        {

            return _EmployeeDataAccess.GetAll();
        }
        //public List<Employee> GetAllEmployeeName(int PageNumber, int UnitPerPage, string SearchText)
        //{

        //    return _EmployeeDataAccess.GetAllEmployeeName(PageNumber, UnitPerPage, SearchText);
        //}
    }
}
