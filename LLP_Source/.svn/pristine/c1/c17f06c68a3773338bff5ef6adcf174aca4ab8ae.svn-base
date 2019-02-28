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
    /// Business logic processing for Chapter.
    /// </summary>    
	public partial class ChapterManager
	{
	
		/// <summary>
        /// Update Chapter Object.
        /// Data manipulation processing for: new, deleted, updated Chapter
        /// </summary>
        /// <param name="chapterObject"></param>
        /// <returns></returns>
        public bool Update(Chapter chapterObject)
        {
			bool success = false;
			
			success = UpdateBase(chapterObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of Chapter Object.
        /// </summary>
        /// <param name="chapterObject"></param>
        /// <returns></returns>
        public void FillChilds(Chapter chapterObject)
        {
			///Fill external information of Childs of ChapterObject
        }
	}	
}
