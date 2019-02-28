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
	public partial class EmployeeManager : BaseManager
	{
	
		#region Constructors
		public EmployeeManager(ClientContext context) : base(context) { }
		public EmployeeManager(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
		
		#region Insert Method		
		/// <summary>
        /// Insert new employee.
        /// data manipulation for insertion of Employee
        /// </summary>
        /// <param name="employeeObject"></param>
        /// <returns></returns>
        private bool Insert(Employee employeeObject)
        {
            // new employee
            using (EmployeeDataAccess data = new EmployeeDataAccess(ClientContext))
            {
                // insert to employeeObject
                Int32 _Id = data.Insert(employeeObject);
                // if successful, process
                if (_Id > 0)
                {
                    employeeObject.Id = _Id;
                    return true;
                }
                else
                    return false;
            }
        }
		#endregion
		
		#region Update Method
		
		/// <summary>
        /// Update base of Employee Object.
        /// Data manipulation processing for: new, deleted, updated Employee
        /// </summary>
        /// <param name="employeeObject"></param>
        /// <returns></returns>
        public bool UpdateBase(Employee employeeObject)
        {
            // use of switch for different types of DML
            switch (employeeObject.RowState)
            {
                // insert new rows
                case BaseBusinessEntity.RowStateEnum.NewRow:
                    return Insert(employeeObject);
                // delete rows
                case BaseBusinessEntity.RowStateEnum.DeletedRow:
                    return Delete(employeeObject.Id);
            }
            // update rows
            using (EmployeeDataAccess data = new EmployeeDataAccess(ClientContext))
            {
                return (data.Update(employeeObject) > 0);
            }
        }
		
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Delete operation for Employee
        /// <param name="_Id"></param>
        /// <returns></returns>
        private bool Delete(Int32 _Id)
        {
            using (EmployeeDataAccess data = new EmployeeDataAccess(ClientContext))
            {
                // return if code > 0
                return (data.Delete(_Id) > 0);
            }
        }
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieve Employee data using unique ID
        /// </summary>
        /// <param name="_Id"></param>
        /// <returns>Employee Object</returns>
        public Employee Get(Int32 _Id)
        {
            using (EmployeeDataAccess data = new EmployeeDataAccess(ClientContext))
            {
                return data.Get(_Id);
            }
        }
		
		
		/// <summary>
        /// Retrieve detail information for a Employee .
        /// Detail child data includes:
        /// last updated on:
        /// change description:
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="fillChild"></param>
        /// <returns></returns>
        public Employee Get(Int32 _Id, bool fillChild)
        {
            Employee employeeObject;
            employeeObject = Get(_Id);
            
            if (employeeObject != null && fillChild)
            {
                // populate child data for a employeeObject
                FillEmployeeWithChilds(employeeObject, fillChild);
            }

            return employeeObject;
        }
		
		/// <summary>
        /// populates a Employee with its child entities
        /// </summary>
        /// <param name="employee"></param>
		/// <param name="fillChilds"></param>
        private void FillEmployeeWithChilds(Employee employeeObject, bool fillChilds)
        {
            // populate child data for a employeeObject
            if (employeeObject != null)
            {
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieve list of Employee.
        /// no parameters required to be passed in.
        /// </summary>
        /// <returns>List of Employee</returns>
        public EmployeeList GetAll()
        {
            using (EmployeeDataAccess data = new EmployeeDataAccess(ClientContext))
            {
                return data.GetAll();
            }
        }
		
		/// <summary>
        /// Retrieve list of Employee.
        /// </summary>
        /// <param name="fillChild"></param>
        /// <returns>List of Employee</returns>
        public EmployeeList GetAll(bool fillChild)
        {
			EmployeeList employeeList = new EmployeeList();
            using (EmployeeDataAccess data = new EmployeeDataAccess(ClientContext))
            {
                employeeList = data.GetAll();
            }
			if (fillChild)
            {
				foreach (Employee employeeObject in employeeList)
                {
					FillEmployeeWithChilds(employeeObject, fillChild);
				}
			}
			return employeeList;
        }
		
		/// <summary>
        /// Retrieve list of Employee  by PageRequest.
        /// <param name="request"></param>
        /// </summary>
        /// <returns>List of Employee</returns>
        public EmployeeList GetPaged(PagedRequest request)
        {
            using (EmployeeDataAccess data = new EmployeeDataAccess(ClientContext))
            {
                return data.GetPaged(request);
            }
        }
		
		/// <summary>
        /// Retrieve list of Employee  by query String.
        /// <param name="query"></param>
        /// </summary>
        /// <returns>List of Employee</returns>
        public EmployeeList GetByQuery(String query)
        {
            using (EmployeeDataAccess data = new EmployeeDataAccess(ClientContext))
            {
                return data.GetByQuery(query);
            }
        }
		#region Get Employee Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of Employee
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			using (EmployeeDataAccess data = new EmployeeDataAccess(ClientContext))
            {
                return data.GetMaxId();
            }
		}
		
		#endregion
		
		#region Get Employee Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of Employee
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			using (EmployeeDataAccess data = new EmployeeDataAccess(ClientContext))
            {
                return data.GetRowCount();
            }
		}
		
		#endregion
	
		
		#endregion
	}	
}
