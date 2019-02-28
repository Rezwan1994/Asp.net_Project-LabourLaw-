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
	public partial class ELMAH_ErrorDataAccess : BaseRelationData
	{
		#region Constants
		private const string INSERTELMAH_ERROR = "InsertELMAH_Error";
		private const string UPDATEELMAH_ERROR = "UpdateELMAH_Error";
		private const string DELETEELMAH_ERROR = "DeleteELMAH_Error";
		private const string GETELMAH_ERRORBYERRORID = "GetELMAH_ErrorByErrorId";
		private const string GETALLELMAH_ERROR = "GetAllELMAH_Error";
		#endregion
		
		#region Constructors
		public ELMAH_ErrorDataAccess(ClientContext context) : base(context) { }
		public ELMAH_ErrorDataAccess(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
				
		#region AddCommonParams Method
        /// <summary>
        /// Add common parameters before calling a procedure
        /// </summary>
        /// <param name="cmd">command object, where parameters will be added</param>
        /// <param name="eLMAH_ErrorObject"></param>
		private void AddCommonParams(SqlCommand cmd, ELMAH_ErrorBase eLMAH_ErrorObject)
		{	
			AddParameter(cmd, pNVarChar(ELMAH_ErrorBase.Property_Application, 60, eLMAH_ErrorObject.Application));
			AddParameter(cmd, pNVarChar(ELMAH_ErrorBase.Property_Host, 50, eLMAH_ErrorObject.Host));
			AddParameter(cmd, pNVarChar(ELMAH_ErrorBase.Property_Type, 100, eLMAH_ErrorObject.Type));
			AddParameter(cmd, pNVarChar(ELMAH_ErrorBase.Property_Source, 60, eLMAH_ErrorObject.Source));
			AddParameter(cmd, pNVarChar(ELMAH_ErrorBase.Property_Message, 500, eLMAH_ErrorObject.Message));
			AddParameter(cmd, pNVarChar(ELMAH_ErrorBase.Property_User, 50, eLMAH_ErrorObject.User));
			AddParameter(cmd, pInt32(ELMAH_ErrorBase.Property_StatusCode, eLMAH_ErrorObject.StatusCode));
			AddParameter(cmd, pDateTime(ELMAH_ErrorBase.Property_TimeUtc, eLMAH_ErrorObject.TimeUtc));
			AddParameter(cmd, pInt32(ELMAH_ErrorBase.Property_Sequence, eLMAH_ErrorObject.Sequence));
			AddParameter(cmd, pText(ELMAH_ErrorBase.Property_AllXml, eLMAH_ErrorObject.AllXml));
		}
		#endregion
		
		#region Insert Method
		/// <summary>
        /// Inserts ELMAH_Error
        /// </summary>
        /// <param name="eLMAH_ErrorObject">Object to be inserted</param>
        /// <returns>Number of rows affected</returns>
		public long Insert(ELMAH_ErrorBase eLMAH_ErrorObject)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(INSERTELMAH_ERROR);
	
				AddParameter(cmd, pGuidOut(ELMAH_ErrorBase.Property_ErrorId, eLMAH_ErrorObject.ErrorId));
				AddCommonParams(cmd, eLMAH_ErrorObject);
				AddBaseParametersForInsert(cmd, eLMAH_ErrorObject);
			
				long result = InsertRecord(cmd);
				if (result > 0)
					eLMAH_ErrorObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;
				return (long)GetOutParameter(cmd, ELMAH_ErrorBase.Property_ErrorId);
			}
			catch(SqlException x)
			{
				throw new ObjectInsertException(eLMAH_ErrorObject, x);
			}
		}
		#endregion
		
		#region Update Method
		/// <summary>
        /// Updates ELMAH_Error
        /// </summary>
        /// <param name="eLMAH_ErrorObject">Object to be updated</param>
        /// <returns>Number of rows affected</returns>
		public long Update(ELMAH_ErrorBase eLMAH_ErrorObject)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(UPDATEELMAH_ERROR);
				
				AddParameter(cmd, pGuid(ELMAH_ErrorBase.Property_ErrorId, eLMAH_ErrorObject.ErrorId));
				AddCommonParams(cmd, eLMAH_ErrorObject);
				AddBaseParametersForUpdate(cmd, eLMAH_ErrorObject);
	
				long result = UpdateRecord(cmd);
				if (result > 0)
					eLMAH_ErrorObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;
				return result;
			}
			catch(SqlException x)
			{
				throw new ObjectUpdateException(eLMAH_ErrorObject, x);
			}
		}
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Deletes ELMAH_Error
        /// </summary>
        /// <param name="ErrorId">ErrorId of the ELMAH_Error object that will be deleted</param>
        /// <returns>Number of rows affected</returns>
		public long Delete(Guid _ErrorId)
		{
			try
			{
				SqlCommand cmd = GetSPCommand(DELETEELMAH_ERROR);	
				
				ELMAH_ErrorBase eLMAH_ErrorObject = new ELMAH_ErrorBase();
				eLMAH_ErrorObject.ErrorId = _ErrorId;
				AddParameters(cmd, pGuid(ELMAH_ErrorBase.Property_ErrorId, eLMAH_ErrorObject.ErrorId));
				 
				return DeleteRecord(cmd);
			}
			catch(SqlException x)
			{
				throw new ObjectDeleteException(typeof(ELMAH_Error), _ErrorId, x);
			}
			
		}
		#endregion
		
		#region Get By ErrorId Method
		 /// <summary>
        /// Retrieves ELMAH_Error object using it's ErrorId
        /// </summary>
        /// <param name="ErrorId">The ErrorId of the ELMAH_Error object to retrieve</param>
        /// <returns>ELMAH_Error object, null if not found</returns>
		public ELMAH_Error Get(Guid _ErrorId)
		{
			using( SqlCommand cmd = GetSPCommand(GETELMAH_ERRORBYERRORID))
			{
				ELMAH_ErrorBase eLMAH_ErrorObject = new ELMAH_ErrorBase();
				eLMAH_ErrorObject.ErrorId = _ErrorId;
				
				AddParameters( cmd, pGuid(ELMAH_ErrorBase.Property_ErrorId, eLMAH_ErrorObject.ErrorId));

				return GetObject(cmd);
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieves all ELMAH_Error objects 
        /// </summary>
        /// <returns>A list of ELMAH_Error objects</returns>
		public ELMAH_ErrorList GetAll()
		{
			using( SqlCommand cmd = GetSPCommand(GETALLELMAH_ERROR))
			{
				return GetList(cmd, ALL_AVAILABLE_RECORDS);
			}
		}
		
		#endregion
		
		#region Fill Methods
		/// <summary>
        /// Fills ELMAH_Error object
        /// </summary>
        /// <param name="eLMAH_ErrorObject">The object to be filled</param>
        /// <param name="reader">The reader to use to fill a single object</param>
        /// <param name="start">The ordinal position from which to start reading the reader</param>
		protected void FillObject(ELMAH_ErrorBase eLMAH_ErrorObject, SqlDataReader reader, int start)
		{
			eLMAH_ErrorObject.RowState = BaseBusinessEntity.RowStateEnum.NormalRow;			
			
			eLMAH_ErrorObject.ErrorId = reader.IsDBNull(0) ? Guid.Empty : (Guid)reader.GetValue(start + 0);			
			eLMAH_ErrorObject.Application = reader.IsDBNull(1) ? string.Empty : (String)reader.GetValue(start + 1);			
			eLMAH_ErrorObject.Host = reader.IsDBNull(2) ? string.Empty : (String)reader.GetValue(start + 2);			
			eLMAH_ErrorObject.Type = reader.IsDBNull(3) ? string.Empty : (String)reader.GetValue(start + 3);			
			eLMAH_ErrorObject.Source = reader.IsDBNull(4) ? string.Empty : (String)reader.GetValue(start + 4);			
			eLMAH_ErrorObject.Message = reader.IsDBNull(5) ? string.Empty : (String)reader.GetValue(start + 5);			
			eLMAH_ErrorObject.User = reader.IsDBNull(6) ? string.Empty : (String)reader.GetValue(start + 6);			
			eLMAH_ErrorObject.StatusCode = reader.IsDBNull(7) ? (Int32)0 : (Int32)reader.GetValue(start + 7);			
			eLMAH_ErrorObject.TimeUtc = reader.IsDBNull(8) ? DateTime.MinValue : (DateTime)reader.GetValue(start + 8);			
			eLMAH_ErrorObject.Sequence = reader.IsDBNull(9) ? (Int32)0 : (Int32)reader.GetValue(start + 9);			
			eLMAH_ErrorObject.AllXml = reader.IsDBNull(10) ? string.Empty : (String)reader.GetValue(start + 10);			
			FillBaseObject(eLMAH_ErrorObject, reader, (start + 11));
		}
		
		/// <summary>
        /// Fills ELMAH_Error object
        /// </summary>
        /// <param name="eLMAH_ErrorObject">The object to be filled</param>
        /// <param name="reader">The reader to use to fill a single object</param>
		protected void FillObject(ELMAH_ErrorBase eLMAH_ErrorObject, SqlDataReader reader)
		{
			FillObject(eLMAH_ErrorObject, reader, 0);
		}
		
		/// <summary>
        /// Retrieves ELMAH_Error object from SqlCommand, after database query
        /// </summary>
        /// <param name="cmd">The command object to use for query</param>
        /// <returns>ELMAH_Error object</returns>
		private ELMAH_Error GetObject(SqlCommand cmd)
		{
			SqlDataReader reader;
			long rows = SelectRecords(cmd, out reader);

			using(reader)
			{
				if(reader.Read())
				{
					ELMAH_Error eLMAH_ErrorObject= new ELMAH_Error();
					FillObject(eLMAH_ErrorObject, reader);
					return eLMAH_ErrorObject;
				}
				else
				{
					return null;
				}				
			}
		}
		
		/// <summary>
        /// Retrieves list of ELMAH_Error objects from SqlCommand, after database query
        /// number of rows retrieved and returned depends upon the rows field value
        /// </summary>
        /// <param name="cmd">The command object to use for query</param>
        /// <param name="rows">Number of rows to process</param>
        /// <returns>A list of ELMAH_Error objects</returns>
		private ELMAH_ErrorList GetList(SqlCommand cmd, long rows)
		{
			// Select multiple records
			SqlDataReader reader;
			long result = SelectRecords(cmd, out reader);

			//ELMAH_Error list
			ELMAH_ErrorList list = new ELMAH_ErrorList();

			using( reader )
			{
				// Read rows until end of result or number of rows specified is reached
				while( reader.Read() && rows-- != 0 )
				{
					ELMAH_Error eLMAH_ErrorObject = new ELMAH_Error();
					FillObject(eLMAH_ErrorObject, reader);

					list.Add(eLMAH_ErrorObject);
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
