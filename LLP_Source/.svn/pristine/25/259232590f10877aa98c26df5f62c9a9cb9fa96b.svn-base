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
	public partial class ChapterManager : BaseManager
	{
	
		#region Constructors
		public ChapterManager(ClientContext context) : base(context) { }
		public ChapterManager(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
		
		#region Insert Method		
		/// <summary>
        /// Insert new chapter.
        /// data manipulation for insertion of Chapter
        /// </summary>
        /// <param name="chapterObject"></param>
        /// <returns></returns>
        private bool Insert(Chapter chapterObject)
        {
            // new chapter
            using (ChapterDataAccess data = new ChapterDataAccess(ClientContext))
            {
                // insert to chapterObject
                Int32 _Id = data.Insert(chapterObject);
                // if successful, process
                if (_Id > 0)
                {
                    chapterObject.Id = _Id;
                    return true;
                }
                else
                    return false;
            }
        }
		#endregion
		
		#region Update Method
		
		/// <summary>
        /// Update base of Chapter Object.
        /// Data manipulation processing for: new, deleted, updated Chapter
        /// </summary>
        /// <param name="chapterObject"></param>
        /// <returns></returns>
        public bool UpdateBase(Chapter chapterObject)
        {
            // use of switch for different types of DML
            switch (chapterObject.RowState)
            {
                // insert new rows
                case BaseBusinessEntity.RowStateEnum.NewRow:
                    return Insert(chapterObject);
                // delete rows
                case BaseBusinessEntity.RowStateEnum.DeletedRow:
                    return Delete(chapterObject.Id);
            }
            // update rows
            using (ChapterDataAccess data = new ChapterDataAccess(ClientContext))
            {
                return (data.Update(chapterObject) > 0);
            }
        }
		
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Delete operation for Chapter
        /// <param name="_Id"></param>
        /// <returns></returns>
        private bool Delete(Int32 _Id)
        {
            using (ChapterDataAccess data = new ChapterDataAccess(ClientContext))
            {
                // return if code > 0
                return (data.Delete(_Id) > 0);
            }
        }
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieve Chapter data using unique ID
        /// </summary>
        /// <param name="_Id"></param>
        /// <returns>Chapter Object</returns>
        public Chapter Get(Int32 _Id)
        {
            using (ChapterDataAccess data = new ChapterDataAccess(ClientContext))
            {
                return data.Get(_Id);
            }
        }
		
		
		/// <summary>
        /// Retrieve detail information for a Chapter .
        /// Detail child data includes:
        /// last updated on:
        /// change description:
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="fillChild"></param>
        /// <returns></returns>
        public Chapter Get(Int32 _Id, bool fillChild)
        {
            Chapter chapterObject;
            chapterObject = Get(_Id);
            
            if (chapterObject != null && fillChild)
            {
                // populate child data for a chapterObject
                FillChapterWithChilds(chapterObject, fillChild);
            }

            return chapterObject;
        }
		
		/// <summary>
        /// populates a Chapter with its child entities
        /// </summary>
        /// <param name="chapter"></param>
		/// <param name="fillChilds"></param>
        private void FillChapterWithChilds(Chapter chapterObject, bool fillChilds)
        {
            // populate child data for a chapterObject
            if (chapterObject != null)
            {
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieve list of Chapter.
        /// no parameters required to be passed in.
        /// </summary>
        /// <returns>List of Chapter</returns>
        public ChapterList GetAll()
        {
            using (ChapterDataAccess data = new ChapterDataAccess(ClientContext))
            {
                return data.GetAll();
            }
        }
		
		/// <summary>
        /// Retrieve list of Chapter.
        /// </summary>
        /// <param name="fillChild"></param>
        /// <returns>List of Chapter</returns>
        public ChapterList GetAll(bool fillChild)
        {
			ChapterList chapterList = new ChapterList();
            using (ChapterDataAccess data = new ChapterDataAccess(ClientContext))
            {
                chapterList = data.GetAll();
            }
			if (fillChild)
            {
				foreach (Chapter chapterObject in chapterList)
                {
					FillChapterWithChilds(chapterObject, fillChild);
				}
			}
			return chapterList;
        }
		
		/// <summary>
        /// Retrieve list of Chapter  by PageRequest.
        /// <param name="request"></param>
        /// </summary>
        /// <returns>List of Chapter</returns>
        public ChapterList GetPaged(PagedRequest request)
        {
            using (ChapterDataAccess data = new ChapterDataAccess(ClientContext))
            {
                return data.GetPaged(request);
            }
        }
		
		/// <summary>
        /// Retrieve list of Chapter  by query String.
        /// <param name="query"></param>
        /// </summary>
        /// <returns>List of Chapter</returns>
        public ChapterList GetByQuery(String query)
        {
            using (ChapterDataAccess data = new ChapterDataAccess(ClientContext))
            {
                return data.GetByQuery(query);
            }
        }
		#region Get Chapter Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of Chapter
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			using (ChapterDataAccess data = new ChapterDataAccess(ClientContext))
            {
                return data.GetMaxId();
            }
		}
		
		#endregion
		
		#region Get Chapter Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of Chapter
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			using (ChapterDataAccess data = new ChapterDataAccess(ClientContext))
            {
                return data.GetRowCount();
            }
		}
		
		#endregion
	
		
		#endregion
	}	
}
