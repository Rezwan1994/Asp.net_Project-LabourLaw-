using System;
using System.Data;
using System.Data.SqlClient;

using LLP.Framework;
using LLP.Framework.DataAccess;
using LLP.Framework.Exceptions;
using LLP.Entities;
using LLP.Entities.Bases;
using LLP.Entities.List;

namespace LLP.DataAccess
{
	public partial class EmployeeDataAccess : BaseDataAccess
	{
		#region Constants
		private const string INSERTEMPLOYEE = "InsertEmployee";
		private const string UPDATEEMPLOYEE = "UpdateEmployee";
		private const string DELETEEMPLOYEE = "DeleteEmployee";
		private const string GETEMPLOYEEBYID = "GetEmployeeById";
		private const string GETALLEMPLOYEE = "GetAllEmployee";
		private const string GETPAGEDEMPLOYEE = "GetPagedEmployee";
		private const string GETEMPLOYEEMAXIMUMID = "GetEmployeeMaximumId";
		private const string GETEMPLOYEEROWCOUNT = "GetEmployeeRowCount";	
		private const string GETEMPLOYEEBYQUERY = "GetEmployeeByQuery";
		#endregion
		
		#region Constructors
		public EmployeeDataAccess(ClientContext context) : base(context) { }
		public EmployeeDataAccess(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
				
		#region AddCommonParams Method
        /// <summary>
        /// Add common parameters before calling a procedure
        /// </summary>
        /// <param name="cmd">command object, where parameters will be added</param>
        /// <param name="employeeObject"></param>
		private void AddCommonParams(SqlCommand cmd, EmployeeBase employeeObject)
		{	
			AddParameter(cmd, pGuid(EmployeeBase.Property_EmployeeId, employeeObject.EmployeeId));
			AddParameter(cmd, pGuid(EmployeeBase.Property_UserId, employeeObject.UserId));
			AddParameter(cmd, pNVarChar(EmployeeBase.Property_Title, 50, employeeObject.Title));
			AddParameter(cmd, pNVarChar(EmployeeBase.Property_FirstName, 250, employeeObject.FirstName));
			AddParameter(cmd, pNVarChar(EmployeeBase.Property_LastName, 250, employeeObject.LastName));
			AddParameter(cmd, pNVarChar(EmployeeBase.Property_Email, 50, employeeObject.Email));
			AddParameter(cmd, pNVarChar(EmployeeBase.Property_Street, 500, employeeObject.Street));
			AddParameter(cmd, pNVarChar(EmployeeBase.Property_City, 50, employeeObject.City));
			AddParameter(cmd, pNVarChar(EmployeeBase.Property_State, 50, employeeObject.State));
			AddParameter(cmd, pNVarChar(EmployeeBase.Property_ZipCode, 50, employeeObject.ZipCode));
			AddParameter(cmd, pNVarChar(EmployeeBase.Property_Country, 50, employeeObject.Country));
			AddParameter(cmd, pNVarChar(EmployeeBase.Property_Phone, 50, employeeObject.Phone));
			AddParameter(cmd, pNVarChar(EmployeeBase.Property_SSN, 50, employeeObject.SSN));
			AddParameter(cmd, pBool(EmployeeBase.Property_IsActive, employeeObject.IsActive));
			AddParameter(cmd, pBool(EmployeeBase.Property_IsDeleted, employeeObject.IsDeleted));
			AddParameter(cmd, pBool(EmployeeBase.Property_IsInstaller, employeeObject.IsInstaller));
			AddParameter(cmd, pBool(EmployeeBase.Property_IsSalesPerson, employeeObject.IsSalesPerson));
			AddParameter(cmd, pBool(EmployeeBase.Property_IsServiceCall, employeeObject.IsServiceCall));
			AddParameter(cmd, pDateTime(EmployeeBase.Property_HireDate, employeeObject.HireDate));
			AddParameter(cmd, pNVarChar(EmployeeBase.Property_ProfilePicture, 250, employeeObject.ProfilePicture));
			AddParameter(cmd, pNVarChar(EmployeeBase.Property_Session, 50, employeeObject.Session));
			AddParameter(cmd, pNVarChar(EmployeeBase.Property_JobTitle, 100, employeeObject.JobTitle));
			AddParameter(cmd, pNVarChar(EmployeeBase.Property_PlaceOfBirth, 100, employeeObject.PlaceOfBirth));
			AddParameter(cmd, pNVarChar(EmployeeBase.Property_SalesCommissionStructure, 100, employeeObject.SalesCommissionStructure));
			AddParameter(cmd, pNVarChar(EmployeeBase.Property_TechCommissionStructure, 100, employeeObject.TechCommissionStructure));
			AddParameter(cmd, pBool(EmployeeBase.Property_RecruitmentProcess, employeeObject.RecruitmentProcess));
			AddParameter(cmd, pBool(EmployeeBase.Property_Recruited, employeeObject.Recruited));
			AddParameter(cmd, pDateTime(EmployeeBase.Property_CreatedDate, employeeObject.CreatedDate));
			AddParameter(cmd, pNVarChar(EmployeeBase.Property_Status, 50, employeeObject.Status));
			AddParameter(cmd, pNVarChar(EmployeeBase.Property_LastUpdatedBy, 250, employeeObject.LastUpdatedBy));
			AddParameter(cmd, pDateTime(EmployeeBase.Property_LastUpdatedDate, employeeObject.LastUpdatedDate));
		}
		#endregion
		
		#region Insert Method
		/// <summary>
        /// Inserts Employee
        /// </summary>
        /// <param name="employeeObject">Object to be inserted</param>
        /// <returns>Number of rows affected</returns>
		public long Insert(EmployeeBase employeeObject)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(INSERTEMPLOYEE);
	
				AddParameter(cmd, pInt32Out(EmployeeBase.Property_Id));
				AddCommonParams(cmd, employeeObject);
			
				long result = InsertRecord(cmd);
				if (result > 0)
				{
					employeeObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;
					employeeObject.Id = (Int32)GetOutParameter(cmd, EmployeeBase.Property_Id);
				}
				return result;
			}
			catch(SqlException x)
			{
				throw new ObjectInsertException(employeeObject, x);
			}
		}
		#endregion
		
		#region Update Method
		/// <summary>
        /// Updates Employee
        /// </summary>
        /// <param name="employeeObject">Object to be updated</param>
        /// <returns>Number of rows affected</returns>
		public long Update(EmployeeBase employeeObject)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(UPDATEEMPLOYEE);
				
				AddParameter(cmd, pInt32(EmployeeBase.Property_Id, employeeObject.Id));
				AddCommonParams(cmd, employeeObject);
	
				long result = UpdateRecord(cmd);
				if (result > 0)
					employeeObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;
				return result;
			}
			catch(SqlException x)
			{
				throw new ObjectUpdateException(employeeObject, x);
			}
		}
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Deletes Employee
        /// </summary>
        /// <param name="Id">Id of the Employee object that will be deleted</param>
        /// <returns>Number of rows affected</returns>
		public long Delete(Int32 _Id)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(DELETEEMPLOYEE);	
				
				AddParameter(cmd, pInt32(EmployeeBase.Property_Id, _Id));
				 
				return DeleteRecord(cmd);
			}
			catch(SqlException x)
			{
				throw new ObjectDeleteException(typeof(Employee), _Id, x);
			}
			
		}
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieves Employee object using it's Id
        /// </summary>
        /// <param name="Id">The Id of the Employee object to retrieve</param>
        /// <returns>Employee object, null if not found</returns>
		public Employee Get(Int32 _Id)
		{
			using( SqlCommand cmd = GetSPCommand(GETEMPLOYEEBYID))
			{
				AddParameter( cmd, pInt32(EmployeeBase.Property_Id, _Id));

				return GetObject(cmd);
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieves all Employee objects 
        /// </summary>
        /// <returns>A list of Employee objects</returns>
		public EmployeeList GetAll()
		{
			using( SqlCommand cmd = GetSPCommand(GETALLEMPLOYEE))
			{
				return GetList(cmd, ALL_AVAILABLE_RECORDS);
			}
		}
		
		
		/// <summary>
        /// Retrieves all Employee objects by PageRequest
        /// </summary>
        /// <returns>A list of Employee objects</returns>
		public EmployeeList GetPaged(PagedRequest request)
		{
			using( SqlCommand cmd = GetSPCommand(GETPAGEDEMPLOYEE))
			{
				AddParameter( cmd, pInt32Out("TotalRows") );
			 	AddParameter( cmd, pInt32("PageIndex", request.PageIndex) );
				AddParameter( cmd, pInt32("RowPerPage", request.RowPerPage) );
				AddParameter(cmd, pNVarChar("WhereClause", 4000, request.WhereClause) );
				AddParameter(cmd, pNVarChar("SortColumn", 128, request.SortColumn) );
				AddParameter(cmd, pNVarChar("SortOrder", 4, request.SortOrder) );
				
				EmployeeList _EmployeeList = GetList(cmd, ALL_AVAILABLE_RECORDS);
				request.TotalRows = Convert.ToInt32(GetOutParameter(cmd, "TotalRows"));
				return _EmployeeList;
			}
		}
		
		/// <summary>
        /// Retrieves all Employee objects by query String
        /// </summary>
        /// <returns>A list of Employee objects</returns>
		public EmployeeList GetByQuery(String query)
		{
			using( SqlCommand cmd = GetSPCommand(GETEMPLOYEEBYQUERY))
			{
				AddParameter(cmd, pNVarChar("Query", 4000, query) );
				return GetList(cmd, ALL_AVAILABLE_RECORDS);;
			}
		}
		
		#endregion
		
		
		#region Get Employee Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of Employee
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			Int32 _MaximumId = 0; 
			using( SqlCommand cmd = GetSPCommand(GETEMPLOYEEMAXIMUMID))
			{
				SqlDataReader reader;
				_MaximumId = (Int32) SelectRecords(cmd, out reader);
				reader.Close();
				reader.Dispose();
			}
			return _MaximumId;
		}
		
		#endregion
		
		#region Get Employee Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of Employee
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			Int32 _EmployeeRowCount = 0; 
			using( SqlCommand cmd = GetSPCommand(GETEMPLOYEEROWCOUNT))
			{
				SqlDataReader reader;
				_EmployeeRowCount = (Int32) SelectRecords(cmd, out reader);
				reader.Close();
				reader.Dispose();
			}
			return _EmployeeRowCount;
		}
		
		#endregion
	
		#region Fill Methods
		/// <summary>
        /// Fills Employee object
        /// </summary>
        /// <param name="employeeObject">The object to be filled</param>
        /// <param name="reader">The reader to use to fill a single object</param>
        /// <param name="start">The ordinal position from which to start reading the reader</param>
		protected void FillObject(EmployeeBase employeeObject, SqlDataReader reader, int start)
		{
			
				employeeObject.Id = reader.GetInt32( start + 0 );			
				employeeObject.EmployeeId = reader.GetGuid( start + 1 );			
				employeeObject.UserId = reader.GetGuid( start + 2 );			
				if(!reader.IsDBNull(3)) employeeObject.Title = reader.GetString( start + 3 );			
				if(!reader.IsDBNull(4)) employeeObject.FirstName = reader.GetString( start + 4 );			
				if(!reader.IsDBNull(5)) employeeObject.LastName = reader.GetString( start + 5 );			
				if(!reader.IsDBNull(6)) employeeObject.Email = reader.GetString( start + 6 );			
				if(!reader.IsDBNull(7)) employeeObject.Street = reader.GetString( start + 7 );			
				if(!reader.IsDBNull(8)) employeeObject.City = reader.GetString( start + 8 );			
				if(!reader.IsDBNull(9)) employeeObject.State = reader.GetString( start + 9 );			
				if(!reader.IsDBNull(10)) employeeObject.ZipCode = reader.GetString( start + 10 );			
				if(!reader.IsDBNull(11)) employeeObject.Country = reader.GetString( start + 11 );			
				if(!reader.IsDBNull(12)) employeeObject.Phone = reader.GetString( start + 12 );			
				if(!reader.IsDBNull(13)) employeeObject.SSN = reader.GetString( start + 13 );			
				employeeObject.IsActive = reader.GetBoolean( start + 14 );			
				employeeObject.IsDeleted = reader.GetBoolean( start + 15 );			
				employeeObject.IsInstaller = reader.GetBoolean( start + 16 );			
				employeeObject.IsSalesPerson = reader.GetBoolean( start + 17 );			
				employeeObject.IsServiceCall = reader.GetBoolean( start + 18 );			
				if(!reader.IsDBNull(19)) employeeObject.HireDate = reader.GetDateTime( start + 19 );			
				if(!reader.IsDBNull(20)) employeeObject.ProfilePicture = reader.GetString( start + 20 );			
				if(!reader.IsDBNull(21)) employeeObject.Session = reader.GetString( start + 21 );			
				if(!reader.IsDBNull(22)) employeeObject.JobTitle = reader.GetString( start + 22 );			
				if(!reader.IsDBNull(23)) employeeObject.PlaceOfBirth = reader.GetString( start + 23 );			
				if(!reader.IsDBNull(24)) employeeObject.SalesCommissionStructure = reader.GetString( start + 24 );			
				if(!reader.IsDBNull(25)) employeeObject.TechCommissionStructure = reader.GetString( start + 25 );			
				if(!reader.IsDBNull(26)) employeeObject.RecruitmentProcess = reader.GetBoolean( start + 26 );			
				if(!reader.IsDBNull(27)) employeeObject.Recruited = reader.GetBoolean( start + 27 );			
				if(!reader.IsDBNull(28)) employeeObject.CreatedDate = reader.GetDateTime( start + 28 );			
				if(!reader.IsDBNull(29)) employeeObject.Status = reader.GetString( start + 29 );			
				if(!reader.IsDBNull(30)) employeeObject.LastUpdatedBy = reader.GetString( start + 30 );			
				if(!reader.IsDBNull(31)) employeeObject.LastUpdatedDate = reader.GetDateTime( start + 31 );			
			FillBaseObject(employeeObject, reader, (start + 32));

			
			employeeObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;	
		}
		
		/// <summary>
        /// Fills Employee object
        /// </summary>
        /// <param name="employeeObject">The object to be filled</param>
        /// <param name="reader">The reader to use to fill a single object</param>
		protected void FillObject(EmployeeBase employeeObject, SqlDataReader reader)
		{
			FillObject(employeeObject, reader, 0);
		}
		
		/// <summary>
        /// Retrieves Employee object from SqlCommand, after database query
        /// </summary>
        /// <param name="cmd">The command object to use for query</param>
        /// <returns>Employee object</returns>
		private Employee GetObject(SqlCommand cmd)
		{
			SqlDataReader reader;
			long rows = SelectRecords(cmd, out reader);

			using(reader)
			{
				if(reader.Read())
				{
					Employee employeeObject= new Employee();
					FillObject(employeeObject, reader);
					return employeeObject;
				}
				else
				{
					return null;
				}				
			}
		}
		
		/// <summary>
        /// Retrieves list of Employee objects from SqlCommand, after database query
        /// number of rows retrieved and returned depends upon the rows field value
        /// </summary>
        /// <param name="cmd">The command object to use for query</param>
        /// <param name="rows">Number of rows to process</param>
        /// <returns>A list of Employee objects</returns>
		private EmployeeList GetList(SqlCommand cmd, long rows)
		{
			// Select multiple records
			SqlDataReader reader;
			long result = SelectRecords(cmd, out reader);

			//Employee list
			EmployeeList list = new EmployeeList();

			using( reader )
			{
				// Read rows until end of result or number of rows specified is reached
				while( reader.Read() && rows-- != 0 )
				{
					Employee employeeObject = new Employee();
					FillObject(employeeObject, reader);

					list.Add(employeeObject);
				}
				
				// Close the reader in order to receive output parameters
				// Output parameters are not available until reader is closed.
				reader.Close();
			}

			return list;
		}
		
		#endregion
	}	
}
