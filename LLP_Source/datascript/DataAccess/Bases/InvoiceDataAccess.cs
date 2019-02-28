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
	public partial class InvoiceDataAccess : BaseDataAccess
	{
		#region Constants
		private const string INSERTINVOICE = "InsertInvoice";
		private const string UPDATEINVOICE = "UpdateInvoice";
		private const string DELETEINVOICE = "DeleteInvoice";
		private const string GETINVOICEBYID = "GetInvoiceById";
		private const string GETALLINVOICE = "GetAllInvoice";
		private const string GETPAGEDINVOICE = "GetPagedInvoice";
		private const string GETINVOICEMAXIMUMID = "GetInvoiceMaximumId";
		private const string GETINVOICEROWCOUNT = "GetInvoiceRowCount";	
		private const string GETINVOICEBYQUERY = "GetInvoiceByQuery";
		#endregion
		
		#region Constructors
		public InvoiceDataAccess(ClientContext context) : base(context) { }
		public InvoiceDataAccess(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
				
		#region AddCommonParams Method
        /// <summary>
        /// Add common parameters before calling a procedure
        /// </summary>
        /// <param name="cmd">command object, where parameters will be added</param>
        /// <param name="invoiceObject"></param>
		private void AddCommonParams(SqlCommand cmd, InvoiceBase invoiceObject)
		{	
			AddParameter(cmd, pNVarChar(InvoiceBase.Property_InvoiceId, 15, invoiceObject.InvoiceId));
			AddParameter(cmd, pGuid(InvoiceBase.Property_CustomerId, invoiceObject.CustomerId));
			AddParameter(cmd, pGuid(InvoiceBase.Property_CompanyId, invoiceObject.CompanyId));
			AddParameter(cmd, pDouble(InvoiceBase.Property_Amount, invoiceObject.Amount));
			AddParameter(cmd, pDouble(InvoiceBase.Property_Tax, invoiceObject.Tax));
			AddParameter(cmd, pNVarChar(InvoiceBase.Property_DiscountCode, 50, invoiceObject.DiscountCode));
			AddParameter(cmd, pDouble(InvoiceBase.Property_DiscountAmount, invoiceObject.DiscountAmount));
			AddParameter(cmd, pDouble(InvoiceBase.Property_TotalAmount, invoiceObject.TotalAmount));
			AddParameter(cmd, pNVarChar(InvoiceBase.Property_Status, 50, invoiceObject.Status));
			AddParameter(cmd, pDateTime(InvoiceBase.Property_InvoiceDate, invoiceObject.InvoiceDate));
			AddParameter(cmd, pDateTime(InvoiceBase.Property_CreatedDate, invoiceObject.CreatedDate));
			AddParameter(cmd, pNVarChar(InvoiceBase.Property_CreatedBy, 50, invoiceObject.CreatedBy));
			AddParameter(cmd, pBool(InvoiceBase.Property_IsEstimate, invoiceObject.IsEstimate));
			AddParameter(cmd, pBool(InvoiceBase.Property_IsBill, invoiceObject.IsBill));
			AddParameter(cmd, pNVarChar(InvoiceBase.Property_BillingAddress, invoiceObject.BillingAddress));
			AddParameter(cmd, pDateTime(InvoiceBase.Property_DueDate, invoiceObject.DueDate));
			AddParameter(cmd, pNVarChar(InvoiceBase.Property_Terms, 50, invoiceObject.Terms));
			AddParameter(cmd, pNVarChar(InvoiceBase.Property_ShippingAddress, invoiceObject.ShippingAddress));
			AddParameter(cmd, pNVarChar(InvoiceBase.Property_ShippingVia, 50, invoiceObject.ShippingVia));
			AddParameter(cmd, pDateTime(InvoiceBase.Property_ShippingDate, invoiceObject.ShippingDate));
			AddParameter(cmd, pNVarChar(InvoiceBase.Property_TrackingNo, 50, invoiceObject.TrackingNo));
			AddParameter(cmd, pDouble(InvoiceBase.Property_ShippingCost, invoiceObject.ShippingCost));
			AddParameter(cmd, pDouble(InvoiceBase.Property_Discountpercent, invoiceObject.Discountpercent));
			AddParameter(cmd, pDouble(InvoiceBase.Property_BalanceDue, invoiceObject.BalanceDue));
			AddParameter(cmd, pDouble(InvoiceBase.Property_Deposit, invoiceObject.Deposit));
			AddParameter(cmd, pNVarChar(InvoiceBase.Property_Message, invoiceObject.Message));
			AddParameter(cmd, pNVarChar(InvoiceBase.Property_TaxType, 50, invoiceObject.TaxType));
			AddParameter(cmd, pDateTime(InvoiceBase.Property_LastUpdatedDate, invoiceObject.LastUpdatedDate));
			AddParameter(cmd, pDouble(InvoiceBase.Property_Balance, invoiceObject.Balance));
			AddParameter(cmd, pNVarChar(InvoiceBase.Property_Memo, 500, invoiceObject.Memo));
			AddParameter(cmd, pNVarChar(InvoiceBase.Property_InvoiceFor, 50, invoiceObject.InvoiceFor));
			AddParameter(cmd, pDouble(InvoiceBase.Property_LateFee, invoiceObject.LateFee));
			AddParameter(cmd, pDouble(InvoiceBase.Property_LateAmount, invoiceObject.LateAmount));
			AddParameter(cmd, pDateTime(InvoiceBase.Property_InstallDate, invoiceObject.InstallDate));
			AddParameter(cmd, pNVarChar(InvoiceBase.Property_Description, invoiceObject.Description));
			AddParameter(cmd, pNVarChar(InvoiceBase.Property_DiscountType, 50, invoiceObject.DiscountType));
			AddParameter(cmd, pNVarChar(InvoiceBase.Property_BillingCycle, 50, invoiceObject.BillingCycle));
		}
		#endregion
		
		#region Insert Method
		/// <summary>
        /// Inserts Invoice
        /// </summary>
        /// <param name="invoiceObject">Object to be inserted</param>
        /// <returns>Number of rows affected</returns>
		public long Insert(InvoiceBase invoiceObject)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(INSERTINVOICE);
	
				AddParameter(cmd, pInt32Out(InvoiceBase.Property_Id));
				AddCommonParams(cmd, invoiceObject);
			
				long result = InsertRecord(cmd);
				if (result > 0)
				{
					invoiceObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;
					invoiceObject.Id = (Int32)GetOutParameter(cmd, InvoiceBase.Property_Id);
				}
				return result;
			}
			catch(SqlException x)
			{
				throw new ObjectInsertException(invoiceObject, x);
			}
		}
		#endregion
		
		#region Update Method
		/// <summary>
        /// Updates Invoice
        /// </summary>
        /// <param name="invoiceObject">Object to be updated</param>
        /// <returns>Number of rows affected</returns>
		public long Update(InvoiceBase invoiceObject)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(UPDATEINVOICE);
				
				AddParameter(cmd, pInt32(InvoiceBase.Property_Id, invoiceObject.Id));
				AddCommonParams(cmd, invoiceObject);
	
				long result = UpdateRecord(cmd);
				if (result > 0)
					invoiceObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;
				return result;
			}
			catch(SqlException x)
			{
				throw new ObjectUpdateException(invoiceObject, x);
			}
		}
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Deletes Invoice
        /// </summary>
        /// <param name="Id">Id of the Invoice object that will be deleted</param>
        /// <returns>Number of rows affected</returns>
		public long Delete(Int32 _Id)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(DELETEINVOICE);	
				
				AddParameter(cmd, pInt32(InvoiceBase.Property_Id, _Id));
				 
				return DeleteRecord(cmd);
			}
			catch(SqlException x)
			{
				throw new ObjectDeleteException(typeof(Invoice), _Id, x);
			}
			
		}
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieves Invoice object using it's Id
        /// </summary>
        /// <param name="Id">The Id of the Invoice object to retrieve</param>
        /// <returns>Invoice object, null if not found</returns>
		public Invoice Get(Int32 _Id)
		{
			using( SqlCommand cmd = GetSPCommand(GETINVOICEBYID))
			{
				AddParameter( cmd, pInt32(InvoiceBase.Property_Id, _Id));

				return GetObject(cmd);
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieves all Invoice objects 
        /// </summary>
        /// <returns>A list of Invoice objects</returns>
		public InvoiceList GetAll()
		{
			using( SqlCommand cmd = GetSPCommand(GETALLINVOICE))
			{
				return GetList(cmd, ALL_AVAILABLE_RECORDS);
			}
		}
		
		
		/// <summary>
        /// Retrieves all Invoice objects by PageRequest
        /// </summary>
        /// <returns>A list of Invoice objects</returns>
		public InvoiceList GetPaged(PagedRequest request)
		{
			using( SqlCommand cmd = GetSPCommand(GETPAGEDINVOICE))
			{
				AddParameter( cmd, pInt32Out("TotalRows") );
			 	AddParameter( cmd, pInt32("PageIndex", request.PageIndex) );
				AddParameter( cmd, pInt32("RowPerPage", request.RowPerPage) );
				AddParameter(cmd, pNVarChar("WhereClause", 4000, request.WhereClause) );
				AddParameter(cmd, pNVarChar("SortColumn", 128, request.SortColumn) );
				AddParameter(cmd, pNVarChar("SortOrder", 4, request.SortOrder) );
				
				InvoiceList _InvoiceList = GetList(cmd, ALL_AVAILABLE_RECORDS);
				request.TotalRows = Convert.ToInt32(GetOutParameter(cmd, "TotalRows"));
				return _InvoiceList;
			}
		}
		
		/// <summary>
        /// Retrieves all Invoice objects by query String
        /// </summary>
        /// <returns>A list of Invoice objects</returns>
		public InvoiceList GetByQuery(String query)
		{
			using( SqlCommand cmd = GetSPCommand(GETINVOICEBYQUERY))
			{
				AddParameter(cmd, pNVarChar("Query", 4000, query) );
				return GetList(cmd, ALL_AVAILABLE_RECORDS);;
			}
		}
		
		#endregion
		
		
		#region Get Invoice Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of Invoice
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			Int32 _MaximumId = 0; 
			using( SqlCommand cmd = GetSPCommand(GETINVOICEMAXIMUMID))
			{
				SqlDataReader reader;
				_MaximumId = (Int32) SelectRecords(cmd, out reader);
				reader.Close();
				reader.Dispose();
			}
			return _MaximumId;
		}
		
		#endregion
		
		#region Get Invoice Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of Invoice
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			Int32 _InvoiceRowCount = 0; 
			using( SqlCommand cmd = GetSPCommand(GETINVOICEROWCOUNT))
			{
				SqlDataReader reader;
				_InvoiceRowCount = (Int32) SelectRecords(cmd, out reader);
				reader.Close();
				reader.Dispose();
			}
			return _InvoiceRowCount;
		}
		
		#endregion
	
		#region Fill Methods
		/// <summary>
        /// Fills Invoice object
        /// </summary>
        /// <param name="invoiceObject">The object to be filled</param>
        /// <param name="reader">The reader to use to fill a single object</param>
        /// <param name="start">The ordinal position from which to start reading the reader</param>
		protected void FillObject(InvoiceBase invoiceObject, SqlDataReader reader, int start)
		{
			
				invoiceObject.Id = reader.GetInt32( start + 0 );			
				invoiceObject.InvoiceId = reader.GetString( start + 1 );			
				invoiceObject.CustomerId = reader.GetGuid( start + 2 );			
				invoiceObject.CompanyId = reader.GetGuid( start + 3 );			
				invoiceObject.Amount = reader.GetDouble( start + 4 );			
				if(!reader.IsDBNull(5)) invoiceObject.Tax = reader.GetDouble( start + 5 );			
				if(!reader.IsDBNull(6)) invoiceObject.DiscountCode = reader.GetString( start + 6 );			
				if(!reader.IsDBNull(7)) invoiceObject.DiscountAmount = reader.GetDouble( start + 7 );			
				if(!reader.IsDBNull(8)) invoiceObject.TotalAmount = reader.GetDouble( start + 8 );			
				invoiceObject.Status = reader.GetString( start + 9 );			
				if(!reader.IsDBNull(10)) invoiceObject.InvoiceDate = reader.GetDateTime( start + 10 );			
				invoiceObject.CreatedDate = reader.GetDateTime( start + 11 );			
				invoiceObject.CreatedBy = reader.GetString( start + 12 );			
				invoiceObject.IsEstimate = reader.GetBoolean( start + 13 );			
				if(!reader.IsDBNull(14)) invoiceObject.IsBill = reader.GetBoolean( start + 14 );			
				if(!reader.IsDBNull(15)) invoiceObject.BillingAddress = reader.GetString( start + 15 );			
				if(!reader.IsDBNull(16)) invoiceObject.DueDate = reader.GetDateTime( start + 16 );			
				if(!reader.IsDBNull(17)) invoiceObject.Terms = reader.GetString( start + 17 );			
				if(!reader.IsDBNull(18)) invoiceObject.ShippingAddress = reader.GetString( start + 18 );			
				if(!reader.IsDBNull(19)) invoiceObject.ShippingVia = reader.GetString( start + 19 );			
				if(!reader.IsDBNull(20)) invoiceObject.ShippingDate = reader.GetDateTime( start + 20 );			
				if(!reader.IsDBNull(21)) invoiceObject.TrackingNo = reader.GetString( start + 21 );			
				if(!reader.IsDBNull(22)) invoiceObject.ShippingCost = reader.GetDouble( start + 22 );			
				if(!reader.IsDBNull(23)) invoiceObject.Discountpercent = reader.GetDouble( start + 23 );			
				if(!reader.IsDBNull(24)) invoiceObject.BalanceDue = reader.GetDouble( start + 24 );			
				if(!reader.IsDBNull(25)) invoiceObject.Deposit = reader.GetDouble( start + 25 );			
				if(!reader.IsDBNull(26)) invoiceObject.Message = reader.GetString( start + 26 );			
				if(!reader.IsDBNull(27)) invoiceObject.TaxType = reader.GetString( start + 27 );			
				if(!reader.IsDBNull(28)) invoiceObject.LastUpdatedDate = reader.GetDateTime( start + 28 );			
				if(!reader.IsDBNull(29)) invoiceObject.Balance = reader.GetDouble( start + 29 );			
				if(!reader.IsDBNull(30)) invoiceObject.Memo = reader.GetString( start + 30 );			
				if(!reader.IsDBNull(31)) invoiceObject.InvoiceFor = reader.GetString( start + 31 );			
				if(!reader.IsDBNull(32)) invoiceObject.LateFee = reader.GetDouble( start + 32 );			
				if(!reader.IsDBNull(33)) invoiceObject.LateAmount = reader.GetDouble( start + 33 );			
				if(!reader.IsDBNull(34)) invoiceObject.InstallDate = reader.GetDateTime( start + 34 );			
				if(!reader.IsDBNull(35)) invoiceObject.Description = reader.GetString( start + 35 );			
				if(!reader.IsDBNull(36)) invoiceObject.DiscountType = reader.GetString( start + 36 );			
				if(!reader.IsDBNull(37)) invoiceObject.BillingCycle = reader.GetString( start + 37 );			
			FillBaseObject(invoiceObject, reader, (start + 38));

			
			invoiceObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;	
		}
		
		/// <summary>
        /// Fills Invoice object
        /// </summary>
        /// <param name="invoiceObject">The object to be filled</param>
        /// <param name="reader">The reader to use to fill a single object</param>
		protected void FillObject(InvoiceBase invoiceObject, SqlDataReader reader)
		{
			FillObject(invoiceObject, reader, 0);
		}
		
		/// <summary>
        /// Retrieves Invoice object from SqlCommand, after database query
        /// </summary>
        /// <param name="cmd">The command object to use for query</param>
        /// <returns>Invoice object</returns>
		private Invoice GetObject(SqlCommand cmd)
		{
			SqlDataReader reader;
			long rows = SelectRecords(cmd, out reader);

			using(reader)
			{
				if(reader.Read())
				{
					Invoice invoiceObject= new Invoice();
					FillObject(invoiceObject, reader);
					return invoiceObject;
				}
				else
				{
					return null;
				}				
			}
		}
		
		/// <summary>
        /// Retrieves list of Invoice objects from SqlCommand, after database query
        /// number of rows retrieved and returned depends upon the rows field value
        /// </summary>
        /// <param name="cmd">The command object to use for query</param>
        /// <param name="rows">Number of rows to process</param>
        /// <returns>A list of Invoice objects</returns>
		private InvoiceList GetList(SqlCommand cmd, long rows)
		{
			// Select multiple records
			SqlDataReader reader;
			long result = SelectRecords(cmd, out reader);

			//Invoice list
			InvoiceList list = new InvoiceList();

			using( reader )
			{
				// Read rows until end of result or number of rows specified is reached
				while( reader.Read() && rows-- != 0 )
				{
					Invoice invoiceObject = new Invoice();
					FillObject(invoiceObject, reader);

					list.Add(invoiceObject);
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
