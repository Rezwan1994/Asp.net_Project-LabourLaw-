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
    /// Business logic processing for ChapterContent.
    /// </summary>    
	public partial class ChapterContentManager
	{
	
		/// <summary>
        /// Update ChapterContent Object.
        /// Data manipulation processing for: new, deleted, updated ChapterContent
        /// </summary>
        /// <param name="chapterContentObject"></param>
        /// <returns></returns>
        public bool Update(ChapterContent chapterContentObject)
        {
			bool success = false;
			
			success = UpdateBase(chapterContentObject);
		
			return success;
        }
		
		/// <summary>
        /// Fill External Childs of ChapterContent Object.
        /// </summary>
        /// <param name="chapterContentObject"></param>
        /// <returns></returns>
        public void FillChilds(ChapterContent chapterContentObject)
        {
			///Fill external information of Childs of ChapterContentObject
        }
	}	
}
