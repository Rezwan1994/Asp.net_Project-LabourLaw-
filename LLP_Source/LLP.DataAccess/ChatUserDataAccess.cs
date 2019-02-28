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
	public partial class ChatUserDataAccess
	{

        public ChatUserDataAccess() { }

        public List<ChatUser> GetChatlist(string Date)
        {

            List<ChatUser> Chat = new List<ChatUser>();
            string SqlQuery = @"select * from ChatUser where joindate ='" + Date + "'";
            using (SqlCommand cmd = GetSQLCommand(string.Format(SqlQuery)))
            {
                DataSet dsResult = GetDataSet(cmd);
                DataTable dt = dsResult.Tables[0];

                try
                {

                    Chat = (from DataRow dr in dt.Rows
                            select new ChatUser()
                            {
                                ChatUserId = new Guid(dr.ToStringDataRow("ChatUserId")),
                                Name = dr.ToStringDataRow("Name"),
                                JoinDate = Convert.ToDateTime(dr.ToStringDataRow("JoinDate")),
                                EmployeeId = new Guid(dr.ToStringDataRow("EmployeeId"))


                            }).ToList();
                }
                catch (Exception ex)
                {
                    return null;
                }
                return Chat;
            }




        }
    }	
}
