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
	public partial class ChapterContentDataAccess : BaseDataAccess
	{
		#region Constants
		private const string INSERTCHAPTERCONTENT = "InsertChapterContent";
		private const string UPDATECHAPTERCONTENT = "UpdateChapterContent";
		private const string DELETECHAPTERCONTENT = "DeleteChapterContent";
		private const string GETCHAPTERCONTENTBYID = "GetChapterContentById";
		private const string GETALLCHAPTERCONTENT = "GetAllChapterContent";
		private const string GETPAGEDCHAPTERCONTENT = "GetPagedChapterContent";
		private const string GETCHAPTERCONTENTMAXIMUMID = "GetChapterContentMaximumId";
		private const string GETCHAPTERCONTENTROWCOUNT = "GetChapterContentRowCount";	
		private const string GETCHAPTERCONTENTBYQUERY = "GetChapterContentByQuery";
		#endregion
		
		#region Constructors
		public ChapterContentDataAccess(ClientContext context) : base(context) { }
		public ChapterContentDataAccess(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
				
		#region AddCommonParams Method
        /// <summary>
        /// Add common parameters before calling a procedure
        /// </summary>
        /// <param name="cmd">command object, where parameters will be added</param>
        /// <param name="chapterContentObject"></param>
		private void AddCommonParams(SqlCommand cmd, ChapterContentBase chapterContentObject)
		{	
			AddParameter(cmd, pNVarChar(ChapterContentBase.Property_TitleNo, 50, chapterContentObject.TitleNo));
			AddParameter(cmd, pNVarChar(ChapterContentBase.Property_Title, 500, chapterContentObject.Title));
			AddParameter(cmd, pNVarChar(ChapterContentBase.Property_CpContent, chapterContentObject.CpContent));
			AddParameter(cmd, pInt32(ChapterContentBase.Property_ChapterId, chapterContentObject.ChapterId));
			AddParameter(cmd, pInt32(ChapterContentBase.Property_ParentId, chapterContentObject.ParentId));
			AddParameter(cmd, pNVarChar(ChapterContentBase.Property_PageUrl, 1000, chapterContentObject.PageUrl));
		}
		#endregion
		
		#region Insert Method
		/// <summary>
        /// Inserts ChapterContent
        /// </summary>
        /// <param name="chapterContentObject">Object to be inserted</param>
        /// <returns>Number of rows affected</returns>
		public long Insert(ChapterContentBase chapterContentObject)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(INSERTCHAPTERCONTENT);
	
				AddParameter(cmd, pInt32Out(ChapterContentBase.Property_Id));
				AddCommonParams(cmd, chapterContentObject);
			
				long result = InsertRecord(cmd);
				if (result > 0)
				{
					chapterContentObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;
					chapterContentObject.Id = (Int32)GetOutParameter(cmd, ChapterContentBase.Property_Id);
				}
				return result;
			}
			catch(SqlException x)
			{
				throw new ObjectInsertException(chapterContentObject, x);
			}
		}
		#endregion
		
		#region Update Method
		/// <summary>
        /// Updates ChapterContent
        /// </summary>
        /// <param name="chapterContentObject">Object to be updated</param>
        /// <returns>Number of rows affected</returns>
		public long Update(ChapterContentBase chapterContentObject)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(UPDATECHAPTERCONTENT);
				
				AddParameter(cmd, pInt32(ChapterContentBase.Property_Id, chapterContentObject.Id));
				AddCommonParams(cmd, chapterContentObject);
	
				long result = UpdateRecord(cmd);
				if (result > 0)
					chapterContentObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;
				return result;
			}
			catch(SqlException x)
			{
				throw new ObjectUpdateException(chapterContentObject, x);
			}
		}
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Deletes ChapterContent
        /// </summary>
        /// <param name="Id">Id of the ChapterContent object that will be deleted</param>
        /// <returns>Number of rows affected</returns>
		public long Delete(Int32 _Id)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(DELETECHAPTERCONTENT);	
				
				AddParameter(cmd, pInt32(ChapterContentBase.Property_Id, _Id));
				 
				return DeleteRecord(cmd);
			}
			catch(SqlException x)
			{
				throw new ObjectDeleteException(typeof(ChapterContent), _Id, x);
			}
			
		}
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieves ChapterContent object using it's Id
        /// </summary>
        /// <param name="Id">The Id of the ChapterContent object to retrieve</param>
        /// <returns>ChapterContent object, null if not found</returns>
		public ChapterContent Get(Int32 _Id)
		{
			using( SqlCommand cmd = GetSPCommand(GETCHAPTERCONTENTBYID))
			{
				AddParameter( cmd, pInt32(ChapterContentBase.Property_Id, _Id));

				return GetObject(cmd);
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieves all ChapterContent objects 
        /// </summary>
        /// <returns>A list of ChapterContent objects</returns>
		public ChapterContentList GetAll()
		{
			using( SqlCommand cmd = GetSPCommand(GETALLCHAPTERCONTENT))
			{
				return GetList(cmd, ALL_AVAILABLE_RECORDS);
			}
		}
		
		
		/// <summary>
        /// Retrieves all ChapterContent objects by PageRequest
        /// </summary>
        /// <returns>A list of ChapterContent objects</returns>
		public ChapterContentList GetPaged(PagedRequest request)
		{
			using( SqlCommand cmd = GetSPCommand(GETPAGEDCHAPTERCONTENT))
			{
				AddParameter( cmd, pInt32Out("TotalRows") );
			 	AddParameter( cmd, pInt32("PageIndex", request.PageIndex) );
				AddParameter( cmd, pInt32("RowPerPage", request.RowPerPage) );
				AddParameter(cmd, pNVarChar("WhereClause", 4000, request.WhereClause) );
				AddParameter(cmd, pNVarChar("SortColumn", 128, request.SortColumn) );
				AddParameter(cmd, pNVarChar("SortOrder", 4, request.SortOrder) );
				
				ChapterContentList _ChapterContentList = GetList(cmd, ALL_AVAILABLE_RECORDS);
				request.TotalRows = Convert.ToInt32(GetOutParameter(cmd, "TotalRows"));
				return _ChapterContentList;
			}
		}
		
		/// <summary>
        /// Retrieves all ChapterContent objects by query String
        /// </summary>
        /// <returns>A list of ChapterContent objects</returns>
		public ChapterContentList GetByQuery(String query)
		{
			using( SqlCommand cmd = GetSPCommand(GETCHAPTERCONTENTBYQUERY))
			{
				AddParameter(cmd, pNVarChar("Query", 4000, query) );
				return GetList(cmd, ALL_AVAILABLE_RECORDS);;
			}
		}
		
		#endregion
		
		
		#region Get ChapterContent Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of ChapterContent
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			Int32 _MaximumId = 0; 
			using( SqlCommand cmd = GetSPCommand(GETCHAPTERCONTENTMAXIMUMID))
			{
				SqlDataReader reader;
				_MaximumId = (Int32) SelectRecords(cmd, out reader);
				reader.Close();
				reader.Dispose();
			}
			return _MaximumId;
		}
		
		#endregion
		
		#region Get ChapterContent Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of ChapterContent
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			Int32 _ChapterContentRowCount = 0; 
			using( SqlCommand cmd = GetSPCommand(GETCHAPTERCONTENTROWCOUNT))
			{
				SqlDataReader reader;
				_ChapterContentRowCount = (Int32) SelectRecords(cmd, out reader);
				reader.Close();
				reader.Dispose();
			}
			return _ChapterContentRowCount;
		}
		
		#endregion
	
		#region Fill Methods
		/// <summary>
        /// Fills ChapterContent object
        /// </summary>
        /// <param name="chapterContentObject">The object to be filled</param>
        /// <param name="reader">The reader to use to fill a single object</param>
        /// <param name="start">The ordinal position from which to start reading the reader</param>
		protected void FillObject(ChapterContentBase chapterContentObject, SqlDataReader reader, int start)
		{
			
				chapterContentObject.Id = reader.GetInt32( start + 0 );			
				chapterContentObject.TitleNo = reader.GetString( start + 1 );			
				chapterContentObject.Title = reader.GetString( start + 2 );			
				if(!reader.IsDBNull(3)) chapterContentObject.CpContent = reader.GetString( start + 3 );			
				if(!reader.IsDBNull(4)) chapterContentObject.ChapterId = reader.GetInt32( start + 4 );			
				if(!reader.IsDBNull(5)) chapterContentObject.ParentId = reader.GetInt32( start + 5 );			
				if(!reader.IsDBNull(6)) chapterContentObject.PageUrl = reader.GetString( start + 6 );			
			FillBaseObject(chapterContentObject, reader, (start + 7));

			
			chapterContentObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;	
		}
		
		/// <summary>
        /// Fills ChapterContent object
        /// </summary>
        /// <param name="chapterContentObject">The object to be filled</param>
        /// <param name="reader">The reader to use to fill a single object</param>
		protected void FillObject(ChapterContentBase chapterContentObject, SqlDataReader reader)
		{
			FillObject(chapterContentObject, reader, 0);
		}
		
		/// <summary>
        /// Retrieves ChapterContent object from SqlCommand, after database query
        /// </summary>
        /// <param name="cmd">The command object to use for query</param>
        /// <returns>ChapterContent object</returns>
		private ChapterContent GetObject(SqlCommand cmd)
		{
			SqlDataReader reader;
			long rows = SelectRecords(cmd, out reader);

			using(reader)
			{
				if(reader.Read())
				{
					ChapterContent chapterContentObject= new ChapterContent();
					FillObject(chapterContentObject, reader);
					return chapterContentObject;
				}
				else
				{
					return null;
				}				
			}
		}
		
		/// <summary>
        /// Retrieves list of ChapterContent objects from SqlCommand, after database query
        /// number of rows retrieved and returned depends upon the rows field value
        /// </summary>
        /// <param name="cmd">The command object to use for query</param>
        /// <param name="rows">Number of rows to process</param>
        /// <returns>A list of ChapterContent objects</returns>
		private ChapterContentList GetList(SqlCommand cmd, long rows)
		{
			// Select multiple records
			SqlDataReader reader;
			long result = SelectRecords(cmd, out reader);

			//ChapterContent list
			ChapterContentList list = new ChapterContentList();

			using( reader )
			{
				// Read rows until end of result or number of rows specified is reached
				while( reader.Read() && rows-- != 0 )
				{
					ChapterContent chapterContentObject = new ChapterContent();
					FillObject(chapterContentObject, reader);

					list.Add(chapterContentObject);
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
