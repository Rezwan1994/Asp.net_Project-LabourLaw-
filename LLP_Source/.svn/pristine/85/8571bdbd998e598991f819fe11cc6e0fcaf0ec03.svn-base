using System;
using System.Data.SqlClient;

using LLP.Framework;
using LLP.Framework.Exceptions;
using LLP.Entities;
using LLP.Entities.Bases;
using LLP.Entities.List;
using LLP.DataAccess;

namespace LLP.BusinessLogic
{
	/// <summary>
    /// Business logic processing for Employee.
    /// </summary>    
	public partial class EmployeeManager
	{
	
		/// <summary>
        /// Update Employee Object.
        /// Data manipulation processing for: new, deleted, updated Employee
        /// </summary>
        /// <param name="employeeObject"></param>
        /// <returns></returns>
        public bool Update(Employee employeeObject)
        {
			bool success = false;
			
			success = UpdateBase(employeeObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of Employee Object.
        /// </summary>
        /// <param name="employeeObject"></param>
        /// <returns></returns>
        public void FillChilds(Employee employeeObject)
        {
			///Fill external information of Childs of EmployeeObject
        }
	}	
}
