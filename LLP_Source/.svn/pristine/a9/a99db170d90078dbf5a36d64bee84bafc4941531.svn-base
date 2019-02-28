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
	public partial class ChatMessageDataAccess : BaseDataAccess
	{
		#region Constants
		private const string INSERTCHATMESSAGE = "InsertChatMessage";
		private const string UPDATECHATMESSAGE = "UpdateChatMessage";
		private const string DELETECHATMESSAGE = "DeleteChatMessage";
		private const string GETCHATMESSAGEBYID = "GetChatMessageById";
		private const string GETALLCHATMESSAGE = "GetAllChatMessage";
		private const string GETPAGEDCHATMESSAGE = "GetPagedChatMessage";
		private const string GETCHATMESSAGEMAXIMUMID = "GetChatMessageMaximumId";
		private const string GETCHATMESSAGEROWCOUNT = "GetChatMessageRowCount";	
		private const string GETCHATMESSAGEBYQUERY = "GetChatMessageByQuery";
		#endregion
		
		#region Constructors
		public ChatMessageDataAccess(ClientContext context) : base(context) { }
		public ChatMessageDataAccess(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
				
		#region AddCommonParams Method
        /// <summary>
        /// Add common parameters before calling a procedure
        /// </summary>
        /// <param name="cmd">command object, where parameters will be added</param>
        /// <param name="chatMessageObject"></param>
		private void AddCommonParams(SqlCommand cmd, ChatMessageBase chatMessageObject)
		{	
			AddParameter(cmd, pGuid(ChatMessageBase.Property_SenderId, chatMessageObject.SenderId));
			AddParameter(cmd, pGuid(ChatMessageBase.Property_RecieverId, chatMessageObject.RecieverId));
			AddParameter(cmd, pNVarChar(ChatMessageBase.Property_Message, chatMessageObject.Message));
			AddParameter(cmd, pDateTime(ChatMessageBase.Property_SendDate, chatMessageObject.SendDate));
			AddParameter(cmd, pDateTime(ChatMessageBase.Property_ReadDate, chatMessageObject.ReadDate));
		}
		#endregion
		
		#region Insert Method
		/// <summary>
        /// Inserts ChatMessage
        /// </summary>
        /// <param name="chatMessageObject">Object to be inserted</param>
        /// <returns>Number of rows affected</returns>
		public long Insert(ChatMessageBase chatMessageObject)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(INSERTCHATMESSAGE);
	
				AddParameter(cmd, pInt32Out(ChatMessageBase.Property_Id));
				AddCommonParams(cmd, chatMessageObject);
			
				long result = InsertRecord(cmd);
				if (result > 0)
				{
					chatMessageObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;
					chatMessageObject.Id = (Int32)GetOutParameter(cmd, ChatMessageBase.Property_Id);
				}
				return result;
			}
			catch(SqlException x)
			{
				throw new ObjectInsertException(chatMessageObject, x);
			}
		}
		#endregion
		
		#region Update Method
		/// <summary>
        /// Updates ChatMessage
        /// </summary>
        /// <param name="chatMessageObject">Object to be updated</param>
        /// <returns>Number of rows affected</returns>
		public long Update(ChatMessageBase chatMessageObject)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(UPDATECHATMESSAGE);
				
				AddParameter(cmd, pInt32(ChatMessageBase.Property_Id, chatMessageObject.Id));
				AddCommonParams(cmd, chatMessageObject);
	
				long result = UpdateRecord(cmd);
				if (result > 0)
					chatMessageObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;
				return result;
			}
			catch(SqlException x)
			{
				throw new ObjectUpdateException(chatMessageObject, x);
			}
		}
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Deletes ChatMessage
        /// </summary>
        /// <param name="Id">Id of the ChatMessage object that will be deleted</param>
        /// <returns>Number of rows affected</returns>
		public long Delete(Int32 _Id)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(DELETECHATMESSAGE);	
				
				AddParameter(cmd, pInt32(ChatMessageBase.Property_Id, _Id));
				 
				return DeleteRecord(cmd);
			}
			catch(SqlException x)
			{
				throw new ObjectDeleteException(typeof(ChatMessage), _Id, x);
			}
			
		}
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieves ChatMessage object using it's Id
        /// </summary>
        /// <param name="Id">The Id of the ChatMessage object to retrieve</param>
        /// <returns>ChatMessage object, null if not found</returns>
		public ChatMessage Get(Int32 _Id)
		{
			using( SqlCommand cmd = GetSPCommand(GETCHATMESSAGEBYID))
			{
				AddParameter( cmd, pInt32(ChatMessageBase.Property_Id, _Id));

				return GetObject(cmd);
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieves all ChatMessage objects 
        /// </summary>
        /// <returns>A list of ChatMessage objects</returns>
		public ChatMessageList GetAll()
		{
			using( SqlCommand cmd = GetSPCommand(GETALLCHATMESSAGE))
			{
				return GetList(cmd, ALL_AVAILABLE_RECORDS);
			}
		}
		
		
		/// <summary>
        /// Retrieves all ChatMessage objects by PageRequest
        /// </summary>
        /// <returns>A list of ChatMessage objects</returns>
		public ChatMessageList GetPaged(PagedRequest request)
		{
			using( SqlCommand cmd = GetSPCommand(GETPAGEDCHATMESSAGE))
			{
				AddParameter( cmd, pInt32Out("TotalRows") );
			 	AddParameter( cmd, pInt32("PageIndex", request.PageIndex) );
				AddParameter( cmd, pInt32("RowPerPage", request.RowPerPage) );
				AddParameter(cmd, pNVarChar("WhereClause", 4000, request.WhereClause) );
				AddParameter(cmd, pNVarChar("SortColumn", 128, request.SortColumn) );
				AddParameter(cmd, pNVarChar("SortOrder", 4, request.SortOrder) );
				
				ChatMessageList _ChatMessageList = GetList(cmd, ALL_AVAILABLE_RECORDS);
				request.TotalRows = Convert.ToInt32(GetOutParameter(cmd, "TotalRows"));
				return _ChatMessageList;
			}
		}
		
		/// <summary>
        /// Retrieves all ChatMessage objects by query String
        /// </summary>
        /// <returns>A list of ChatMessage objects</returns>
		public ChatMessageList GetByQuery(String query)
		{
			using( SqlCommand cmd = GetSPCommand(GETCHATMESSAGEBYQUERY))
			{
				AddParameter(cmd, pNVarChar("Query", 4000, query) );
				return GetList(cmd, ALL_AVAILABLE_RECORDS);;
			}
		}
		
		#endregion
		
		
		#region Get ChatMessage Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of ChatMessage
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			Int32 _MaximumId = 0; 
			using( SqlCommand cmd = GetSPCommand(GETCHATMESSAGEMAXIMUMID))
			{
				SqlDataReader reader;
				_MaximumId = (Int32) SelectRecords(cmd, out reader);
				reader.Close();
				reader.Dispose();
			}
			return _MaximumId;
		}
		
		#endregion
		
		#region Get ChatMessage Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of ChatMessage
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			Int32 _ChatMessageRowCount = 0; 
			using( SqlCommand cmd = GetSPCommand(GETCHATMESSAGEROWCOUNT))
			{
				SqlDataReader reader;
				_ChatMessageRowCount = (Int32) SelectRecords(cmd, out reader);
				reader.Close();
				reader.Dispose();
			}
			return _ChatMessageRowCount;
		}
		
		#endregion
	
		#region Fill Methods
		/// <summary>
        /// Fills ChatMessage object
        /// </summary>
        /// <param name="chatMessageObject">The object to be filled</param>
        /// <param name="reader">The reader to use to fill a single object</param>
        /// <param name="start">The ordinal position from which to start reading the reader</param>
		protected void FillObject(ChatMessageBase chatMessageObject, SqlDataReader reader, int start)
		{
			
				chatMessageObject.Id = reader.GetInt32( start + 0 );			
				chatMessageObject.SenderId = reader.GetGuid( start + 1 );			
				chatMessageObject.RecieverId = reader.GetGuid( start + 2 );			
				chatMessageObject.Message = reader.GetString( start + 3 );			
				chatMessageObject.SendDate = reader.GetDateTime( start + 4 );			
				if(!reader.IsDBNull(5)) chatMessageObject.ReadDate = reader.GetDateTime( start + 5 );			
			FillBaseObject(chatMessageObject, reader, (start + 6));

			
			chatMessageObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;	
		}
		
		/// <summary>
        /// Fills ChatMessage object
        /// </summary>
        /// <param name="chatMessageObject">The object to be filled</param>
        /// <param name="reader">The reader to use to fill a single object</param>
		protected void FillObject(ChatMessageBase chatMessageObject, SqlDataReader reader)
		{
			FillObject(chatMessageObject, reader, 0);
		}
		
		/// <summary>
        /// Retrieves ChatMessage object from SqlCommand, after database query
        /// </summary>
        /// <param name="cmd">The command object to use for query</param>
        /// <returns>ChatMessage object</returns>
		private ChatMessage GetObject(SqlCommand cmd)
		{
			SqlDataReader reader;
			long rows = SelectRecords(cmd, out reader);

			using(reader)
			{
				if(reader.Read())
				{
					ChatMessage chatMessageObject= new ChatMessage();
					FillObject(chatMessageObject, reader);
					return chatMessageObject;
				}
				else
				{
					return null;
				}				
			}
		}
		
		/// <summary>
        /// Retrieves list of ChatMessage objects from SqlCommand, after database query
        /// number of rows retrieved and returned depends upon the rows field value
        /// </summary>
        /// <param name="cmd">The command object to use for query</param>
        /// <param name="rows">Number of rows to process</param>
        /// <returns>A list of ChatMessage objects</returns>
		private ChatMessageList GetList(SqlCommand cmd, long rows)
		{
			// Select multiple records
			SqlDataReader reader;
			long result = SelectRecords(cmd, out reader);

			//ChatMessage list
			ChatMessageList list = new ChatMessageList();

			using( reader )
			{
				// Read rows until end of result or number of rows specified is reached
				while( reader.Read() && rows-- != 0 )
				{
					ChatMessage chatMessageObject = new ChatMessage();
					FillObject(chatMessageObject, reader);

					list.Add(chatMessageObject);
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
