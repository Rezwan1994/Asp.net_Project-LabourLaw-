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
	public partial class ChapterDataAccess : BaseDataAccess
	{
		#region Constants
		private const string INSERTCHAPTER = "InsertChapter";
		private const string UPDATECHAPTER = "UpdateChapter";
		private const string DELETECHAPTER = "DeleteChapter";
		private const string GETCHAPTERBYID = "GetChapterById";
		private const string GETALLCHAPTER = "GetAllChapter";
		private const string GETPAGEDCHAPTER = "GetPagedChapter";
		private const string GETCHAPTERMAXIMUMID = "GetChapterMaximumId";
		private const string GETCHAPTERROWCOUNT = "GetChapterRowCount";	
		private const string GETCHAPTERBYQUERY = "GetChapterByQuery";
		#endregion
		
		#region Constructors
		public ChapterDataAccess(ClientContext context) : base(context) { }
		public ChapterDataAccess(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
				
		#region AddCommonParams Method
        /// <summary>
        /// Add common parameters before calling a procedure
        /// </summary>
        /// <param name="cmd">command object, where parameters will be added</param>
        /// <param name="chapterObject"></param>
		private void AddCommonParams(SqlCommand cmd, ChapterBase chapterObject)
		{	
			AddParameter(cmd, pNVarChar(ChapterBase.Property_ChapterNo, 50, chapterObject.ChapterNo));
			AddParameter(cmd, pNVarChar(ChapterBase.Property_Name, 500, chapterObject.Name));
			AddParameter(cmd, pNVarChar(ChapterBase.Property_Type, 50, chapterObject.Type));
			AddParameter(cmd, pNVarChar(ChapterBase.Property_Description, chapterObject.Description));
			AddParameter(cmd, pNVarChar(ChapterBase.Property_PageUrl, 1000, chapterObject.PageUrl));
		}
		#endregion
		
		#region Insert Method
		/// <summary>
        /// Inserts Chapter
        /// </summary>
        /// <param name="chapterObject">Object to be inserted</param>
        /// <returns>Number of rows affected</returns>
		public long Insert(ChapterBase chapterObject)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(INSERTCHAPTER);
	
				AddParameter(cmd, pInt32Out(ChapterBase.Property_Id));
				AddCommonParams(cmd, chapterObject);
			
				long result = InsertRecord(cmd);
				if (result > 0)
				{
					chapterObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;
					chapterObject.Id = (Int32)GetOutParameter(cmd, ChapterBase.Property_Id);
				}
				return result;
			}
			catch(SqlException x)
			{
				throw new ObjectInsertException(chapterObject, x);
			}
		}
		#endregion
		
		#region Update Method
		/// <summary>
        /// Updates Chapter
        /// </summary>
        /// <param name="chapterObject">Object to be updated</param>
        /// <returns>Number of rows affected</returns>
		public long Update(ChapterBase chapterObject)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(UPDATECHAPTER);
				
				AddParameter(cmd, pInt32(ChapterBase.Property_Id, chapterObject.Id));
				AddCommonParams(cmd, chapterObject);
	
				long result = UpdateRecord(cmd);
				if (result > 0)
					chapterObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;
				return result;
			}
			catch(SqlException x)
			{
				throw new ObjectUpdateException(chapterObject, x);
			}
		}
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Deletes Chapter
        /// </summary>
        /// <param name="Id">Id of the Chapter object that will be deleted</param>
        /// <returns>Number of rows affected</returns>
		public long Delete(Int32 _Id)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(DELETECHAPTER);	
				
				AddParameter(cmd, pInt32(ChapterBase.Property_Id, _Id));
				 
				return DeleteRecord(cmd);
			}
			catch(SqlException x)
			{
				throw new ObjectDeleteException(typeof(Chapter), _Id, x);
			}
			
		}
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieves Chapter object using it's Id
        /// </summary>
        /// <param name="Id">The Id of the Chapter object to retrieve</param>
        /// <returns>Chapter object, null if not found</returns>
		public Chapter Get(Int32 _Id)
		{
			using( SqlCommand cmd = GetSPCommand(GETCHAPTERBYID))
			{
				AddParameter( cmd, pInt32(ChapterBase.Property_Id, _Id));

				return GetObject(cmd);
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieves all Chapter objects 
        /// </summary>
        /// <returns>A list of Chapter objects</returns>
		public ChapterList GetAll()
		{
			using( SqlCommand cmd = GetSPCommand(GETALLCHAPTER))
			{
				return GetList(cmd, ALL_AVAILABLE_RECORDS);
			}
		}
		
		
		/// <summary>
        /// Retrieves all Chapter objects by PageRequest
        /// </summary>
        /// <returns>A list of Chapter objects</returns>
		public ChapterList GetPaged(PagedRequest request)
		{
			using( SqlCommand cmd = GetSPCommand(GETPAGEDCHAPTER))
			{
				AddParameter( cmd, pInt32Out("TotalRows") );
			 	AddParameter( cmd, pInt32("PageIndex", request.PageIndex) );
				AddParameter( cmd, pInt32("RowPerPage", request.RowPerPage) );
				AddParameter(cmd, pNVarChar("WhereClause", 4000, request.WhereClause) );
				AddParameter(cmd, pNVarChar("SortColumn", 128, request.SortColumn) );
				AddParameter(cmd, pNVarChar("SortOrder", 4, request.SortOrder) );
				
				ChapterList _ChapterList = GetList(cmd, ALL_AVAILABLE_RECORDS);
				request.TotalRows = Convert.ToInt32(GetOutParameter(cmd, "TotalRows"));
				return _ChapterList;
			}
		}
		
		/// <summary>
        /// Retrieves all Chapter objects by query String
        /// </summary>
        /// <returns>A list of Chapter objects</returns>
		public ChapterList GetByQuery(String query)
		{
			using( SqlCommand cmd = GetSPCommand(GETCHAPTERBYQUERY))
			{
				AddParameter(cmd, pNVarChar("Query", 4000, query) );
				return GetList(cmd, ALL_AVAILABLE_RECORDS);;
			}
		}
		
		#endregion
		
		
		#region Get Chapter Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of Chapter
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			Int32 _MaximumId = 0; 
			using( SqlCommand cmd = GetSPCommand(GETCHAPTERMAXIMUMID))
			{
				SqlDataReader reader;
				_MaximumId = (Int32) SelectRecords(cmd, out reader);
				reader.Close();
				reader.Dispose();
			}
			return _MaximumId;
		}
		
		#endregion
		
		#region Get Chapter Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of Chapter
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			Int32 _ChapterRowCount = 0; 
			using( SqlCommand cmd = GetSPCommand(GETCHAPTERROWCOUNT))
			{
				SqlDataReader reader;
				_ChapterRowCount = (Int32) SelectRecords(cmd, out reader);
				reader.Close();
				reader.Dispose();
			}
			return _ChapterRowCount;
		}
		
		#endregion
	
		#region Fill Methods
		/// <summary>
        /// Fills Chapter object
        /// </summary>
        /// <param name="chapterObject">The object to be filled</param>
        /// <param name="reader">The reader to use to fill a single object</param>
        /// <param name="start">The ordinal position from which to start reading the reader</param>
		protected void FillObject(ChapterBase chapterObject, SqlDataReader reader, int start)
		{
			
				chapterObject.Id = reader.GetInt32( start + 0 );			
				if(!reader.IsDBNull(1)) chapterObject.ChapterNo = reader.GetString( start + 1 );			
				if(!reader.IsDBNull(2)) chapterObject.Name = reader.GetString( start + 2 );			
				if(!reader.IsDBNull(3)) chapterObject.Type = reader.GetString( start + 3 );			
				if(!reader.IsDBNull(4)) chapterObject.Description = reader.GetString( start + 4 );			
				if(!reader.IsDBNull(5)) chapterObject.PageUrl = reader.GetString( start + 5 );			
			FillBaseObject(chapterObject, reader, (start + 6));

			
			chapterObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;	
		}
		
		/// <summary>
        /// Fills Chapter object
        /// </summary>
        /// <param name="chapterObject">The object to be filled</param>
        /// <param name="reader">The reader to use to fill a single object</param>
		protected void FillObject(ChapterBase chapterObject, SqlDataReader reader)
		{
			FillObject(chapterObject, reader, 0);
		}
		
		/// <summary>
        /// Retrieves Chapter object from SqlCommand, after database query
        /// </summary>
        /// <param name="cmd">The command object to use for query</param>
        /// <returns>Chapter object</returns>
		private Chapter GetObject(SqlCommand cmd)
		{
			SqlDataReader reader;
			long rows = SelectRecords(cmd, out reader);

			using(reader)
			{
				if(reader.Read())
				{
					Chapter chapterObject= new Chapter();
					FillObject(chapterObject, reader);
					return chapterObject;
				}
				else
				{
					return null;
				}				
			}
		}
		
		/// <summary>
        /// Retrieves list of Chapter objects from SqlCommand, after database query
        /// number of rows retrieved and returned depends upon the rows field value
        /// </summary>
        /// <param name="cmd">The command object to use for query</param>
        /// <param name="rows">Number of rows to process</param>
        /// <returns>A list of Chapter objects</returns>
		private ChapterList GetList(SqlCommand cmd, long rows)
		{
			// Select multiple records
			SqlDataReader reader;
			long result = SelectRecords(cmd, out reader);

			//Chapter list
			ChapterList list = new ChapterList();

			using( reader )
			{
				// Read rows until end of result or number of rows specified is reached
				while( reader.Read() && rows-- != 0 )
				{
					Chapter chapterObject = new Chapter();
					FillObject(chapterObject, reader);

					list.Add(chapterObject);
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
