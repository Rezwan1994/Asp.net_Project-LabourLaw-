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
	public partial class ChapterContentManager : BaseManager
	{
	
		#region Constructors
		public ChapterContentManager(ClientContext context) : base(context) { }
		public ChapterContentManager(SqlTransaction transaction, ClientContext context) : base(transaction, context) { }
        #endregion
		
		#region Insert Method		
		/// <summary>
        /// Insert new chapterContent.
        /// data manipulation for insertion of ChapterContent
        /// </summary>
        /// <param name="chapterContentObject"></param>
        /// <returns></returns>
        private bool Insert(ChapterContent chapterContentObject)
        {
            // new chapterContent
            using (ChapterContentDataAccess data = new ChapterContentDataAccess(ClientContext))
            {
                // insert to chapterContentObject
                Int32 _Id = data.Insert(chapterContentObject);
                // if successful, process
                if (_Id > 0)
                {
                    chapterContentObject.Id = _Id;
                    return true;
                }
                else
                    return false;
            }
        }
		#endregion
		
		#region Update Method
		
		/// <summary>
        /// Update base of ChapterContent Object.
        /// Data manipulation processing for: new, deleted, updated ChapterContent
        /// </summary>
        /// <param name="chapterContentObject"></param>
        /// <returns></returns>
        public bool UpdateBase(ChapterContent chapterContentObject)
        {
            // use of switch for different types of DML
            switch (chapterContentObject.RowState)
            {
                // insert new rows
                case BaseBusinessEntity.RowStateEnum.NewRow:
                    return Insert(chapterContentObject);
                // delete rows
                case BaseBusinessEntity.RowStateEnum.DeletedRow:
                    return Delete(chapterContentObject.Id);
            }
            // update rows
            using (ChapterContentDataAccess data = new ChapterContentDataAccess(ClientContext))
            {
                return (data.Update(chapterContentObject) > 0);
            }
        }
		
		#endregion
		
		#region Delete Method
		/// <summary>
        /// Delete operation for ChapterContent
        /// <param name="_Id"></param>
        /// <returns></returns>
        private bool Delete(Int32 _Id)
        {
            using (ChapterContentDataAccess data = new ChapterContentDataAccess(ClientContext))
            {
                // return if code > 0
                return (data.Delete(_Id) > 0);
            }
        }
		#endregion
		
		#region Get By Id Method
		/// <summary>
        /// Retrieve ChapterContent data using unique ID
        /// </summary>
        /// <param name="_Id"></param>
        /// <returns>ChapterContent Object</returns>
        public ChapterContent Get(Int32 _Id)
        {
            using (ChapterContentDataAccess data = new ChapterContentDataAccess(ClientContext))
            {
                return data.Get(_Id);
            }
        }
		
		
		/// <summary>
        /// Retrieve detail information for a ChapterContent .
        /// Detail child data includes:
        /// last updated on:
        /// change description:
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="fillChild"></param>
        /// <returns></returns>
        public ChapterContent Get(Int32 _Id, bool fillChild)
        {
            ChapterContent chapterContentObject;
            chapterContentObject = Get(_Id);
            
            if (chapterContentObject != null && fillChild)
            {
                // populate child data for a chapterContentObject
                FillChapterContentWithChilds(chapterContentObject, fillChild);
            }

            return chapterContentObject;
        }
		
		/// <summary>
        /// populates a ChapterContent with its child entities
        /// </summary>
        /// <param name="chapterContent"></param>
		/// <param name="fillChilds"></param>
        private void FillChapterContentWithChilds(ChapterContent chapterContentObject, bool fillChilds)
        {
            // populate child data for a chapterContentObject
            if (chapterContentObject != null)
            {
			}
		}
		#endregion
		
		#region GetAll Method
		/// <summary>
        /// Retrieve list of ChapterContent.
        /// no parameters required to be passed in.
        /// </summary>
        /// <returns>List of ChapterContent</returns>
        public ChapterContentList GetAll()
        {
            using (ChapterContentDataAccess data = new ChapterContentDataAccess(ClientContext))
            {
                return data.GetAll();
            }
        }
		
		/// <summary>
        /// Retrieve list of ChapterContent.
        /// </summary>
        /// <param name="fillChild"></param>
        /// <returns>List of ChapterContent</returns>
        public ChapterContentList GetAll(bool fillChild)
        {
			ChapterContentList chapterContentList = new ChapterContentList();
            using (ChapterContentDataAccess data = new ChapterContentDataAccess(ClientContext))
            {
                chapterContentList = data.GetAll();
            }
			if (fillChild)
            {
				foreach (ChapterContent chapterContentObject in chapterContentList)
                {
					FillChapterContentWithChilds(chapterContentObject, fillChild);
				}
			}
			return chapterContentList;
        }
		
		/// <summary>
        /// Retrieve list of ChapterContent  by PageRequest.
        /// <param name="request"></param>
        /// </summary>
        /// <returns>List of ChapterContent</returns>
        public ChapterContentList GetPaged(PagedRequest request)
        {
            using (ChapterContentDataAccess data = new ChapterContentDataAccess(ClientContext))
            {
                return data.GetPaged(request);
            }
        }
		
		/// <summary>
        /// Retrieve list of ChapterContent  by query String.
        /// <param name="query"></param>
        /// </summary>
        /// <returns>List of ChapterContent</returns>
        public ChapterContentList GetByQuery(String query)
        {
            using (ChapterContentDataAccess data = new ChapterContentDataAccess(ClientContext))
            {
                return data.GetByQuery(query);
            }
        }
		#region Get ChapterContent Maximum Id Method
		/// <summary>
        /// Retrieves Get Maximum Id of ChapterContent
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetMaxId()
		{
			using (ChapterContentDataAccess data = new ChapterContentDataAccess(ClientContext))
            {
                return data.GetMaxId();
            }
		}
		
		#endregion
		
		#region Get ChapterContent Row Count Method
		/// <summary>
        /// Retrieves Get Total Rows of ChapterContent
        /// </summary>
        /// <returns>Int32 type object</returns>
		public Int32 GetRowCount()
		{
			using (ChapterContentDataAccess data = new ChapterContentDataAccess(ClientContext))
            {
                return data.GetRowCount();
            }
		}
		
		#endregion
	
		
		#endregion
	}	
}
