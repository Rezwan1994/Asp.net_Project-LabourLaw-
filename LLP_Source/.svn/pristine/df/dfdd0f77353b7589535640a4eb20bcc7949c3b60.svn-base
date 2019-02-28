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
	public partial class ChatUserDataAccess : BaseDataAccess
	{
		#region Constants
		private const string INSERTCHATUSER = "InsertChatUser";
		private const string UPDATECHATUSER = "UpdateChatUser";
		private const string DELETECHATUSER = "DeleteChatUser";
		private const string GETCHATUSERBYID = "GetChatUserById";
		private const string GETALLCHATUSER = "GetAllChatUser";
		private const string GETPAGEDCHATUSER = "GetPagedChatUser";
		private const string GETCHATUSERMAXIMUMID = "GetChatUserMaximumId";
		private const string GETCHATUSERROWCOUNT = "GetChatUserRowCount";	
		private const string GETCHATUSERBYQUERY = "GetChatUserByQuery";
		#endregion
		
		#region Constructors
		public ChatUserDataAccess(ClientContext context) : base(context) { }
		public ChatUserDataAccess(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
				
		#region AddCommonParams Method
        /// <summary>
        /// Add common parameters before calling a procedure
        /// </summary>
        /// <param name="cmd">command object, where parameters will be added</param>
        /// <param name="chatUserObject"></param>
		private void AddCommonParams(SqlCommand cmd, ChatUserBase chatUserObject)
		{	
			AddParameter(cmd, pGuid(ChatUserBase.Property_ChatUserId, chatUserObject.ChatUserId));
			AddParameter(cmd, pNVarChar(ChatUserBase.Property_Name, 50, chatUserObject.Name));
			AddParameter(cmd, pNVarChar(ChatUserBase.Property_Email, 50, chatUserObject.Email));
			AddParameter(cmd, pNVarChar(ChatUserBase.Property_Phone, 50, chatUserObject.Phone));
			AddParameter(cmd, pDateTime(ChatUserBase.Property_JoinDate, chatUserObject.JoinDate));
			AddParameter(cmd, pDateTime(ChatUserBase.Property_ChatEnd, chatUserObject.ChatEnd));
			AddParameter(cmd, pNVarChar(ChatUserBase.Property_Ip, 50, chatUserObject.Ip));
			AddParameter(cmd, pNVarChar(ChatUserBase.Property_UserAgent, chatUserObject.UserAgent));
			AddParameter(cmd, pGuid(ChatUserBase.Property_EmployeeId, chatUserObject.EmployeeId));
		}
		#endregion
		
		#region Insert Method
		/// <summary>
        /// Inserts ChatUser
        /// </summary>
        /// <param name="chatUserObject">Object to be inserted</param>
        /// <returns>Number of rows affected</returns>
		public long Insert(ChatUserBase chatUserObject)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(INSERTCHATUSER);
	
				AddParameter(cmd, pInt32Out(ChatUserBase.Property_Id));
				AddCommonParams(cmd, chatUserObject);
			
				long result = InsertRecord(cmd);
				if (result > 0)
				{
					chatUserObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;
					chatUserObject.Id = (Int32)GetOutParameter(cmd, ChatUserBase.Property_Id);
				}
				return result;
			}
			catch(SqlException x)
			{
				throw new ObjectInsertException(chatUserObject, x);
			}
		}
		#endregion
		
		#region Update Method
		/// <summary>
        /// Updates ChatUser
        /// </summary>
        /// <param name="chatUserObject">Object to be updated</param>
        /// <returns>Number of rows affected</returns>
		public long Update(ChatUserBase chatUserObject)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(UPDATECHATUSER);
				
				AddParameter(cmd, pInt32(ChatUserBase.Property_Id, chatUserObject.Id));
				AddCommonParams(cmd, chatUserObject);
	
				long result = UpdateRecord(cmd);
				if (result > 0)
					chatUserObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;
				return result;
			}
			catch(SqlException x)
			{
				throw new ObjectUpdateException(chatUserObject, x);
			}
		}
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Deletes ChatUser
        /// </summary>
        /// <param name="Id">Id of the ChatUser object that will be deleted</param>
        /// <returns>Number of rows affected</returns>
		public long Delete(Int32 _Id)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(DELETECHATUSER);	
				
				AddParameter(cmd, pInt32(ChatUserBase.Property_Id, _Id));
				 
				return DeleteRecord(cmd);
			}
			catch(SqlException x)
			{
				throw new ObjectDeleteException(typeof(ChatUser), _Id, x);
			}
			
		}
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieves ChatUser object using it's Id
        /// </summary>
        /// <param name="Id">The Id of the ChatUser object to retrieve</param>
        /// <returns>ChatUser object, null if not found</returns>
		public ChatUser Get(Int32 _Id)
		{
			using( SqlCommand cmd = GetSPCommand(GETCHATUSERBYID))
			{
				AddParameter( cmd, pInt32(ChatUserBase.Property_Id, _Id));

				return GetObject(cmd);
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieves all ChatUser objects 
        /// </summary>
        /// <returns>A list of ChatUser objects</returns>
		public ChatUserList GetAll()
		{
			using( SqlCommand cmd = GetSPCommand(GETALLCHATUSER))
			{
				return GetList(cmd, ALL_AVAILABLE_RECORDS);
			}
		}
		
		
		/// <summary>
        /// Retrieves all ChatUser objects by PageRequest
        /// </summary>
        /// <returns>A list of ChatUser objects</returns>
		public ChatUserList GetPaged(PagedRequest request)
		{
			using( SqlCommand cmd = GetSPCommand(GETPAGEDCHATUSER))
			{
				AddParameter( cmd, pInt32Out("TotalRows") );
			 	AddParameter( cmd, pInt32("PageIndex", request.PageIndex) );
				AddParameter( cmd, pInt32("RowPerPage", request.RowPerPage) );
				AddParameter(cmd, pNVarChar("WhereClause", 4000, request.WhereClause) );
				AddParameter(cmd, pNVarChar("SortColumn", 128, request.SortColumn) );
				AddParameter(cmd, pNVarChar("SortOrder", 4, request.SortOrder) );
				
				ChatUserList _ChatUserList = GetList(cmd, ALL_AVAILABLE_RECORDS);
				request.TotalRows = Convert.ToInt32(GetOutParameter(cmd, "TotalRows"));
				return _ChatUserList;
			}
		}
		
		/// <summary>
        /// Retrieves all ChatUser objects by query String
        /// </summary>
        /// <returns>A list of ChatUser objects</returns>
		public ChatUserList GetByQuery(String query)
		{
			using( SqlCommand cmd = GetSPCommand(GETCHATUSERBYQUERY))
			{
				AddParameter(cmd, pNVarChar("Query", 4000, query) );
				return GetList(cmd, ALL_AVAILABLE_RECORDS);;
			}
		}
		
		#endregion
		
		
		#region Get ChatUser Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of ChatUser
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			Int32 _MaximumId = 0; 
			using( SqlCommand cmd = GetSPCommand(GETCHATUSERMAXIMUMID))
			{
				SqlDataReader reader;
				_MaximumId = (Int32) SelectRecords(cmd, out reader);
				reader.Close();
				reader.Dispose();
			}
			return _MaximumId;
		}
		
		#endregion
		
		#region Get ChatUser Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of ChatUser
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			Int32 _ChatUserRowCount = 0; 
			using( SqlCommand cmd = GetSPCommand(GETCHATUSERROWCOUNT))
			{
				SqlDataReader reader;
				_ChatUserRowCount = (Int32) SelectRecords(cmd, out reader);
				reader.Close();
				reader.Dispose();
			}
			return _ChatUserRowCount;
		}
		
		#endregion
	
		#region Fill Methods
		/// <summary>
        /// Fills ChatUser object
        /// </summary>
        /// <param name="chatUserObject">The object to be filled</param>
        /// <param name="reader">The reader to use to fill a single object</param>
        /// <param name="start">The ordinal position from which to start reading the reader</param>
		protected void FillObject(ChatUserBase chatUserObject, SqlDataReader reader, int start)
		{
			
				chatUserObject.Id = reader.GetInt32( start + 0 );			
				chatUserObject.ChatUserId = reader.GetGuid( start + 1 );			
				chatUserObject.Name = reader.GetString( start + 2 );			
				if(!reader.IsDBNull(3)) chatUserObject.Email = reader.GetString( start + 3 );			
				chatUserObject.Phone = reader.GetString( start + 4 );			
				chatUserObject.JoinDate = reader.GetDateTime( start + 5 );			
				if(!reader.IsDBNull(6)) chatUserObject.ChatEnd = reader.GetDateTime( start + 6 );			
				chatUserObject.Ip = reader.GetString( start + 7 );			
				chatUserObject.UserAgent = reader.GetString( start + 8 );			
				chatUserObject.EmployeeId = reader.GetGuid( start + 9 );			
			FillBaseObject(chatUserObject, reader, (start + 10));

			
			chatUserObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;	
		}
		
		/// <summary>
        /// Fills ChatUser object
        /// </summary>
        /// <param name="chatUserObject">The object to be filled</param>
        /// <param name="reader">The reader to use to fill a single object</param>
		protected void FillObject(ChatUserBase chatUserObject, SqlDataReader reader)
		{
			FillObject(chatUserObject, reader, 0);
		}
		
		/// <summary>
        /// Retrieves ChatUser object from SqlCommand, after database query
        /// </summary>
        /// <param name="cmd">The command object to use for query</param>
        /// <returns>ChatUser object</returns>
		private ChatUser GetObject(SqlCommand cmd)
		{
			SqlDataReader reader;
			long rows = SelectRecords(cmd, out reader);

			using(reader)
			{
				if(reader.Read())
				{
					ChatUser chatUserObject= new ChatUser();
					FillObject(chatUserObject, reader);
					return chatUserObject;
				}
				else
				{
					return null;
				}				
			}
		}
		
		/// <summary>
        /// Retrieves list of ChatUser objects from SqlCommand, after database query
        /// number of rows retrieved and returned depends upon the rows field value
        /// </summary>
        /// <param name="cmd">The command object to use for query</param>
        /// <param name="rows">Number of rows to process</param>
        /// <returns>A list of ChatUser objects</returns>
		private ChatUserList GetList(SqlCommand cmd, long rows)
		{
			// Select multiple records
			SqlDataReader reader;
			long result = SelectRecords(cmd, out reader);

			//ChatUser list
			ChatUserList list = new ChatUserList();

			using( reader )
			{
				// Read rows until end of result or number of rows specified is reached
				while( reader.Read() && rows-- != 0 )
				{
					ChatUser chatUserObject = new ChatUser();
					FillObject(chatUserObject, reader);

					list.Add(chatUserObject);
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
