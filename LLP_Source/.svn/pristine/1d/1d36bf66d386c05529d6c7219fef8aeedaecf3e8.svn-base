using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using LLP.Framework;
using LLP.Framework.Exceptions;
using LLP.Entities;
using LLP.Entities.Bases;
using LLP.Entities.List;
using System.Collections.Generic;

namespace LLP.DataAccess
{
	public partial class UserLoginDataAccess
	{
        public List<UserLogin> GetAllUserName(int PageNumber, int UnitPerPage, string SearchText)
        {
            string searchTextQuery = "";

            if (!string.IsNullOrWhiteSpace(SearchText))
            {
                searchTextQuery = " UserName like '%" + SearchText + "%'";
            }

            List<UserLogin> content = new List<UserLogin>();
            string rawQuery = @"    declare @pagesize int
                                declare @pageno int 
                                set @pagesize = " + UnitPerPage + @"
                                set @pageno = " + PageNumber + @"
                                declare @pagestart int
                                set @pagestart=(@pageno-1)* @pagesize  
                                select  TOP (@pagesize) * FROM UserLogin
                                where 
                                UserName like'%" + SearchText + @"%'AND Id NOT IN(Select TOP (@pagestart) Id from UserLogin)
                                select Count(Id) As TotalCount from UserLogin";




            using (SqlCommand cmd = GetSQLCommand(rawQuery))
            {
                DataSet dsResult = GetDataSet(cmd);
                DataTable dt = dsResult.Tables[0];
                try
                {
                    content = (from DataRow dr in dt.Rows
                               select new UserLogin()
                               {
                                   Id = dr.ToIntDataRow("Id"),
                                   UserId = new Guid( dr.ToStringDataRow("UserId")),
                                   UserName = dr.ToStringDataRow("UserName"),
                                   Password = dr.ToStringDataRow("Password"),
                                   EmailAddress = dr.ToStringDataRow("EmailAddress"),
                                   IsActive = bool.Parse(dr.ToStringDataRow("IsActive")),
                                   
                                   IsDeleted = bool.Parse(dr.ToStringDataRow("IsDeleted")),
                             
                                 

                               }).ToList();
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            return content;
        }

    }	
}
