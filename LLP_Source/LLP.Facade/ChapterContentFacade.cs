﻿using LLP.DataAccess;
using LLP.Entities;
using LLP.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LLP.Facade
{
   
    public class ChapterContentFacade : BaseFacade
    {
        public ChapterContentFacade(ClientContext clientContext)
            : base(clientContext)
        {

        }
        ChapterContentDataAccess _ChapterDataAccess
        {
            get
            {
                return (ChapterContentDataAccess)_ClientContext[typeof(ChapterContentDataAccess)];
            }
        }

        public bool InsertChapter(ChapterContent chapter)
        {
            return _ChapterDataAccess.Insert(chapter) > 0;
        }
        public bool UpdateChapter(ChapterContent chapter)
        {
            return _ChapterDataAccess.Update(chapter) > 0;
        }
        public bool DeleteChapter(int id)
        {
            return _ChapterDataAccess.Delete(id) > 0;
        }
        public ChapterContent GetChapterById(int id)
        {
            return _ChapterDataAccess.Get(id);
        }
        public ChapterContent GetChapterName(string chaptername)
        {

            string query = string.Format(" Title ='{0}'", chaptername);
            return _ChapterDataAccess.GetByQuery(query).FirstOrDefault();
        }

        public List<ChapterContent> GetAllChapterName()
        {

            return _ChapterDataAccess.GetAll();
        }
        public List<ChapterContent> GetContentName(string SearchText)
        {
            return _ChapterDataAccess.GetContentName(SearchText);
        }
        public List<ChapterContent> GetContentCountRule()
        {
            return _ChapterDataAccess.GetContentCountRule();
        }
        public List<ChapterContent> GetContentCountAct()
        {
            return _ChapterDataAccess.GetContentCountAct();
        }
        public List<ChapterContent> GetAllChapterContent(int? PageNumber, int? UnitPerPage, string SearchText)
        {
            return _ChapterDataAccess.GetAllChapterContent(Convert.ToInt32(PageNumber), Convert.ToInt32(UnitPerPage), SearchText);
        }
        public List<ChapterContent> GetAllChapterContentAct(int? PageNumber, int? UnitPerPage, string SearchText)
        {
            return _ChapterDataAccess.GetAllChapterContent2(Convert.ToInt32(PageNumber), Convert.ToInt32(UnitPerPage), SearchText);
        }

        public List<ChapterContent> GetChapterContent(string ch)
        {
            return _ChapterDataAccess.GetChapterContent(ch);
        }


    }
    
}
