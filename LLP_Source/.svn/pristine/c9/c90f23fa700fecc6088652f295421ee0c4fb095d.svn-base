using System;
using System.Data;
using System.Data.SqlClient;

using LLP.Framework;
using LLP.Framework.Exceptions;
using LLP.Entities;
using System.Linq;
using LLP.Entities.Bases;
using LLP.Entities.List;
using System.Collections.Generic;

namespace LLP.DataAccess
{
	public partial class ChapterDataAccess
	{
        public List<Chapter> GetChapterName(string SearchText)
        {

            List<Chapter> chapter = new List<Chapter>();
            string SqlQuery = @"select * from Chapter 
                                ";

            if (!string.IsNullOrWhiteSpace(SearchText))
            {
                SqlQuery += " where chapterno in (select chapterid from chaptercontent where title like '%{0}%') ";
            }

            using (SqlCommand cmd = GetSQLCommand(string.Format(SqlQuery, SearchText)))
            {
                DataSet dsResult = GetDataSet(cmd);
                DataTable dt = dsResult.Tables[0];
                try
                {

                    chapter = (from DataRow dr in dt.Rows
                               select new Chapter()
                               {
                                   Name = dr.ToStringDataRow("Name"),
                                   Type = dr.ToStringDataRow("Type"),
                                   ChapterNo = dr.ToStringDataRow("ChapterNo"),
                                   Id = dr.ToIntDataRow("Id"),
                                   Description = dr.ToStringDataRow("Description")
                                   

                               }).ToList();
                }
                catch (Exception ex)
                {
                    return null;
                }
                return chapter;
            }


        }

        public List<Chapter> GetAllChapter(int PageNumber, int UnitPerPage, string SearchText)
        {
            string searchTextQuery = "";

            if (!string.IsNullOrWhiteSpace(SearchText))
            {
                searchTextQuery = " Name like '%" + SearchText + "%'";
            }

            List<Chapter> content = new List<Chapter>();
            string rawQuery = @"  
                                declare @pagesize int
                                declare @pageno int 
                                set @pagesize = " + UnitPerPage + @"
                                set @pageno = " + PageNumber + @"
                                declare @pagestart int
                                set @pagestart=(@pageno-1)* @pagesize  
                                select  TOP (@pagesize) * FROM Chapter
                                where Type ='Rule'AND
                                Name like'%" + SearchText + @"%'AND Id NOT IN(Select TOP (@pagestart) Id from Chapter)
                                select Count(Id) As TotalCount from Chapter";




            using (SqlCommand cmd = GetSQLCommand(rawQuery))
            {
                DataSet dsResult = GetDataSet(cmd);
                DataTable dt = dsResult.Tables[0];
                try
                {
                    content = (from DataRow dr in dt.Rows
                               select new Chapter()
                               {
                                   Name = dr.ToStringDataRow("Name"),
                                   Type = dr.ToStringDataRow("Type"),
                                   ChapterNo = dr.ToStringDataRow("ChapterNo"),
                                   Id = dr.ToIntDataRow("Id"),
                                   Description = dr.ToStringDataRow("Description")


                               }).ToList();
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            return content;
        }
        public List<Chapter> GetAllChapterAct(int PageNumber, int UnitPerPage, string SearchText)
        {
            string searchTextQuery = "";

            if (!string.IsNullOrWhiteSpace(SearchText))
            {
                searchTextQuery = " Name like '%" + SearchText + "%'";
            }

            List<Chapter> content = new List<Chapter>();
            string rawQuery = @"  
                                declare @pagesize int
                                declare @SearchText nvarchar(50)
                                declare @pageno int
                                  
                                set @pagesize =" + UnitPerPage + @"

                                set @pageno = " + PageNumber + @"

                                declare @pagestart int
                                set @pagestart = (@pageno - 1) * @pagesize

                                select TOP(@pagesize) * FROM Chapter


                                where Type = 'Act'

                                AND Name like '%" + SearchText + @"%' 
                                AND Id NOT IN(Select TOP(@pagestart) Id from Chapter 
                                where
                                Name like '%" + SearchText + @"%' and Type = 'Act')

                                order by id asc";




            using (SqlCommand cmd = GetSQLCommand(rawQuery))
            {
                DataSet dsResult = GetDataSet(cmd);
                DataTable dt = dsResult.Tables[0];
                try
                {
                    content = (from DataRow dr in dt.Rows
                               select new Chapter()
                               {
                                   Name = dr.ToStringDataRow("Name"),
                                   Type = dr.ToStringDataRow("Type"),
                                   ChapterNo = dr.ToStringDataRow("ChapterNo"),
                                   Id = dr.ToIntDataRow("Id"),
                                   Description = dr.ToStringDataRow("Description")


                               }).ToList();
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            return content;
        }

        public Chapter GetChapter(int chapterNo)
        {
            string SqlQuery = @"select * from Chapter where ChapterNo = '" + chapterNo + "'";

            Chapter chapter = new Chapter();
            using (SqlCommand cmd = GetSQLCommand(SqlQuery))
            {
                DataSet dsResult = GetDataSet(cmd);
                DataTable dt = dsResult.Tables[0];

       
                try
                {
                    chapter = (from DataRow dr in dt.Rows
                               select new Chapter()
                               {
                                   Name = dr.ToStringDataRow("Name"),
                                   Type = dr.ToStringDataRow("Type"),
                                   ChapterNo = dr.ToStringDataRow("ChapterNo"),
                                   Id = dr.ToIntDataRow("Id"),
                                   Description = dr.ToStringDataRow("Description")


                               }).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            return chapter;
        }
      
    }	
}
