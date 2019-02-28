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
	public partial class ELMAH_ErrorDataAccess 
	{
		#region Constants
		private const string DELETEELMAH_ERRORBY = "DeleteELMAH_ErrorBy";
		#endregion
		
		#region Override Methods
		/// <summary>
        /// adds relation between ELMAH and Error
        /// </summary>
        /// <param name="parentID"></param>
        /// <param name="childID"></param>
        /// <returns></returns>
      	public override long Add(long parentID, long childID)
        {
			throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// adds relation between ELMAH and Error
        /// </summary>
        /// <param name="parentID"></param>
        /// <param name="childID"></param>
        /// <returns></returns>
      	public override long Remove(long parentID, long childID)
        {
			throw new Exception("The method or operation is not implemented.");
        }
		#endregion
	}	
}
