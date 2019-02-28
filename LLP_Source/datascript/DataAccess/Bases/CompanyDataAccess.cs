﻿using System;
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
	public partial class CompanyDataAccess : BaseDataAccess
	{
		#region Constants
		private const string INSERTCOMPANY = "InsertCompany";
		private const string UPDATECOMPANY = "UpdateCompany";
		private const string DELETECOMPANY = "DeleteCompany";
		private const string GETCOMPANYBYID = "GetCompanyById";
		private const string GETALLCOMPANY = "GetAllCompany";
		private const string GETPAGEDCOMPANY = "GetPagedCompany";
		private const string GETCOMPANYMAXIMUMID = "GetCompanyMaximumId";
		private const string GETCOMPANYROWCOUNT = "GetCompanyRowCount";	
		private const string GETCOMPANYBYQUERY = "GetCompanyByQuery";
		#endregion
		
		#region Constructors
		public CompanyDataAccess(ClientContext context) : base(context) { }
		public CompanyDataAccess(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
				
		#region AddCommonParams Method
        /// <summary>
        /// Add common parameters before calling a procedure
        /// </summary>
        /// <param name="cmd">command object, where parameters will be added</param>
        /// <param name="companyObject"></param>
		private void AddCommonParams(SqlCommand cmd, CompanyBase companyObject)
		{	
			AddParameter(cmd, pGuid(CompanyBase.Property_CompanyId, companyObject.CompanyId));
			AddParameter(cmd, pNVarChar(CompanyBase.Property_CompanyName, 50, companyObject.CompanyName));
			AddParameter(cmd, pNVarChar(CompanyBase.Property_UserName, 150, companyObject.UserName));
			AddParameter(cmd, pNVarChar(CompanyBase.Property_EmailAdress, 150, companyObject.EmailAdress));
			AddParameter(cmd, pNVarChar(CompanyBase.Property_FirstName, 150, companyObject.FirstName));
			AddParameter(cmd, pNVarChar(CompanyBase.Property_LastName, 150, companyObject.LastName));
			AddParameter(cmd, pNVarChar(CompanyBase.Property_Phone, 50, companyObject.Phone));
			AddParameter(cmd, pNVarChar(CompanyBase.Property_Fax, 50, companyObject.Fax));
			AddParameter(cmd, pNVarChar(CompanyBase.Property_Address, companyObject.Address));
			AddParameter(cmd, pNVarChar(CompanyBase.Property_Street, 500, companyObject.Street));
			AddParameter(cmd, pNVarChar(CompanyBase.Property_City, 50, companyObject.City));
			AddParameter(cmd, pNVarChar(CompanyBase.Property_State, 50, companyObject.State));
			AddParameter(cmd, pNVarChar(CompanyBase.Property_ZipCode, 50, companyObject.ZipCode));
			AddParameter(cmd, pNVarChar(CompanyBase.Property_Website, 50, companyObject.Website));
			AddParameter(cmd, pNVarChar(CompanyBase.Property_CompanyType, 50, companyObject.CompanyType));
			AddParameter(cmd, pNVarChar(CompanyBase.Property_Note, companyObject.Note));
			AddParameter(cmd, pNVarChar(CompanyBase.Property_CompanyLogo, 250, companyObject.CompanyLogo));
		}
		#endregion
		
		#region Insert Method
		/// <summary>
        /// Inserts Company
        /// </summary>
        /// <param name="companyObject">Object to be inserted</param>
        /// <returns>Number of rows affected</returns>
		public long Insert(CompanyBase companyObject)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(INSERTCOMPANY);
	
				AddParameter(cmd, pInt32Out(CompanyBase.Property_Id));
				AddCommonParams(cmd, companyObject);
			
				long result = InsertRecord(cmd);
				if (result > 0)
				{
					companyObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;
					companyObject.Id = (Int32)GetOutParameter(cmd, CompanyBase.Property_Id);
				}
				return result;
			}
			catch(SqlException x)
			{
				throw new ObjectInsertException(companyObject, x);
			}
		}
		#endregion
		
		#region Update Method
		/// <summary>
        /// Updates Company
        /// </summary>
        /// <param name="companyObject">Object to be updated</param>
        /// <returns>Number of rows affected</returns>
		public long Update(CompanyBase companyObject)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(UPDATECOMPANY);
				
				AddParameter(cmd, pInt32(CompanyBase.Property_Id, companyObject.Id));
				AddCommonParams(cmd, companyObject);
	
				long result = UpdateRecord(cmd);
				if (result > 0)
					companyObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;
				return result;
			}
			catch(SqlException x)
			{
				throw new ObjectUpdateException(companyObject, x);
			}
		}
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Deletes Company
        /// </summary>
        /// <param name="Id">Id of the Company object that will be deleted</param>
        /// <returns>Number of rows affected</returns>
		public long Delete(Int32 _Id)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(DELETECOMPANY);	
				
				AddParameter(cmd, pInt32(CompanyBase.Property_Id, _Id));
				 
				return DeleteRecord(cmd);
			}
			catch(SqlException x)
			{
				throw new ObjectDeleteException(typeof(Company), _Id, x);
			}
			
		}
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieves Company object using it's Id
        /// </summary>
        /// <param name="Id">The Id of the Company object to retrieve</param>
        /// <returns>Company object, null if not found</returns>
		public Company Get(Int32 _Id)
		{
			using( SqlCommand cmd = GetSPCommand(GETCOMPANYBYID))
			{
				AddParameter( cmd, pInt32(CompanyBase.Property_Id, _Id));

				return GetObject(cmd);
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieves all Company objects 
        /// </summary>
        /// <returns>A list of Company objects</returns>
		public CompanyList GetAll()
		{
			using( SqlCommand cmd = GetSPCommand(GETALLCOMPANY))
			{
				return GetList(cmd, ALL_AVAILABLE_RECORDS);
			}
		}
		
		
		/// <summary>
        /// Retrieves all Company objects by PageRequest
        /// </summary>
        /// <returns>A list of Company objects</returns>
		public CompanyList GetPaged(PagedRequest request)
		{
			using( SqlCommand cmd = GetSPCommand(GETPAGEDCOMPANY))
			{
				AddParameter( cmd, pInt32Out("TotalRows") );
			 	AddParameter( cmd, pInt32("PageIndex", request.PageIndex) );
				AddParameter( cmd, pInt32("RowPerPage", request.RowPerPage) );
				AddParameter(cmd, pNVarChar("WhereClause", 4000, request.WhereClause) );
				AddParameter(cmd, pNVarChar("SortColumn", 128, request.SortColumn) );
				AddParameter(cmd, pNVarChar("SortOrder", 4, request.SortOrder) );
				
				CompanyList _CompanyList = GetList(cmd, ALL_AVAILABLE_RECORDS);
				request.TotalRows = Convert.ToInt32(GetOutParameter(cmd, "TotalRows"));
				return _CompanyList;
			}
		}
		
		/// <summary>
        /// Retrieves all Company objects by query String
        /// </summary>
        /// <returns>A list of Company objects</returns>
		public CompanyList GetByQuery(String query)
		{
			using( SqlCommand cmd = GetSPCommand(GETCOMPANYBYQUERY))
			{
				AddParameter(cmd, pNVarChar("Query", 4000, query) );
				return GetList(cmd, ALL_AVAILABLE_RECORDS);;
			}
		}
		
		#endregion
		
		
		#region Get Company Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of Company
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			Int32 _MaximumId = 0; 
			using( SqlCommand cmd = GetSPCommand(GETCOMPANYMAXIMUMID))
			{
				SqlDataReader reader;
				_MaximumId = (Int32) SelectRecords(cmd, out reader);
				reader.Close();
				reader.Dispose();
			}
			return _MaximumId;
		}
		
		#endregion
		
		#region Get Company Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of Company
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			Int32 _CompanyRowCount = 0; 
			using( SqlCommand cmd = GetSPCommand(GETCOMPANYROWCOUNT))
			{
				SqlDataReader reader;
				_CompanyRowCount = (Int32) SelectRecords(cmd, out reader);
				reader.Close();
				reader.Dispose();
			}
			return _CompanyRowCount;
		}
		
		#endregion
	
		#region Fill Methods
		/// <summary>
        /// Fills Company object
        /// </summary>
        /// <param name="companyObject">The object to be filled</param>
        /// <param name="reader">The reader to use to fill a single object</param>
        /// <param name="start">The ordinal position from which to start reading the reader</param>
		protected void FillObject(CompanyBase companyObject, SqlDataReader reader, int start)
		{
			
				companyObject.Id = reader.GetInt32( start + 0 );			
				companyObject.CompanyId = reader.GetGuid( start + 1 );			
				if(!reader.IsDBNull(2)) companyObject.CompanyName = reader.GetString( start + 2 );			
				if(!reader.IsDBNull(3)) companyObject.UserName = reader.GetString( start + 3 );			
				if(!reader.IsDBNull(4)) companyObject.EmailAdress = reader.GetString( start + 4 );			
				if(!reader.IsDBNull(5)) companyObject.FirstName = reader.GetString( start + 5 );			
				if(!reader.IsDBNull(6)) companyObject.LastName = reader.GetString( start + 6 );			
				if(!reader.IsDBNull(7)) companyObject.Phone = reader.GetString( start + 7 );			
				if(!reader.IsDBNull(8)) companyObject.Fax = reader.GetString( start + 8 );			
				if(!reader.IsDBNull(9)) companyObject.Address = reader.GetString( start + 9 );			
				if(!reader.IsDBNull(10)) companyObject.Street = reader.GetString( start + 10 );			
				if(!reader.IsDBNull(11)) companyObject.City = reader.GetString( start + 11 );			
				if(!reader.IsDBNull(12)) companyObject.State = reader.GetString( start + 12 );			
				if(!reader.IsDBNull(13)) companyObject.ZipCode = reader.GetString( start + 13 );			
				if(!reader.IsDBNull(14)) companyObject.Website = reader.GetString( start + 14 );			
				if(!reader.IsDBNull(15)) companyObject.CompanyType = reader.GetString( start + 15 );			
				if(!reader.IsDBNull(16)) companyObject.Note = reader.GetString( start + 16 );			
				if(!reader.IsDBNull(17)) companyObject.CompanyLogo = reader.GetString( start + 17 );			
			FillBaseObject(companyObject, reader, (start + 18));

			
			companyObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;	
		}
		
		/// <summary>
        /// Fills Company object
        /// </summary>
        /// <param name="companyObject">The object to be filled</param>
        /// <param name="reader">The reader to use to fill a single object</param>
		protected void FillObject(CompanyBase companyObject, SqlDataReader reader)
		{
			FillObject(companyObject, reader, 0);
		}
		
		/// <summary>
        /// Retrieves Company object from SqlCommand, after database query
        /// </summary>
        /// <param name="cmd">The command object to use for query</param>
        /// <returns>Company object</returns>
		private Company GetObject(SqlCommand cmd)
		{
			SqlDataReader reader;
			long rows = SelectRecords(cmd, out reader);

			using(reader)
			{
				if(reader.Read())
				{
					Company companyObject= new Company();
					FillObject(companyObject, reader);
					return companyObject;
				}
				else
				{
					return null;
				}				
			}
		}
		
		/// <summary>
        /// Retrieves list of Company objects from SqlCommand, after database query
        /// number of rows retrieved and returned depends upon the rows field value
        /// </summary>
        /// <param name="cmd">The command object to use for query</param>
        /// <param name="rows">Number of rows to process</param>
        /// <returns>A list of Company objects</returns>
		private CompanyList GetList(SqlCommand cmd, long rows)
		{
			// Select multiple records
			SqlDataReader reader;
			long result = SelectRecords(cmd, out reader);

			//Company list
			CompanyList list = new CompanyList();

			using( reader )
			{
				// Read rows until end of result or number of rows specified is reached
				while( reader.Read() && rows-- != 0 )
				{
					Company companyObject = new Company();
					FillObject(companyObject, reader);

					list.Add(companyObject);
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
