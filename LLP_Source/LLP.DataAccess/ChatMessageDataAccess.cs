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
    public partial class ChatMessageDataAccess
    {

        public ChatMessageDataAccess() { }

        public ChatMessage GetReadDateBySenderId(Guid SenderID)
        {

            List<ChatMessage> Chat = new List<ChatMessage>();
            string SqlQuery = @"select * from ChatMessage where SenderId = '" + SenderID + "'";
            using (SqlCommand cmd = GetSQLCommand(string.Format(SqlQuery)))
            {
                DataSet dsResult = GetDataSet(cmd);
                DataTable dt = dsResult.Tables[0];

                try
                {

                    Chat = (from DataRow dr in dt.Rows
                            select new ChatMessage()
                            {
                                SenderId = new Guid(dr.ToStringDataRow("SenderId")),
                                RecieverId = new Guid(dr.ToStringDataRow("RecieverId")),
                                Message = dr.ToStringDataRow("Message"),
                                Id = dr.ToIntDataRow("Id"),
                                SendDate = Convert.ToDateTime(dr.ToStringDataRow("SendDate")),
                                ReadDate = Convert.ToDateTime(dr.ToStringDataRow("ReadDate"))

                            }).ToList();
                }
                catch (Exception ex)
                {
                    return null;
                }
                return Chat.FirstOrDefault();
            }




        }

        public List<ChatMessage> GetAllbysenderId(Guid SenderID, Guid ReceiverId)
        {
            string SqlQuery = @"select cm.*,cu.Name,ul.UserName from ChatMessage cm left join ChatUser cu on cm.SenderId = cu.ChatUserId left join UserLogin ul on cm.SenderId = ul.UserId where SenderId = '" + SenderID + "' AND RecieverId= '" + ReceiverId + "' or SenderId = '" + ReceiverId + "' AND RecieverId = '" + SenderID + "' order by SendDate asc";

            List<ChatMessage> Chat = new List<ChatMessage>();
            using (SqlCommand cmd = GetSQLCommand(string.Format(SqlQuery)))
            {
                DataSet dsResult = GetDataSet(cmd);
                DataTable dt = dsResult.Tables[0];

                try
                {

                    Chat = (from DataRow dr in dt.Rows
                            select new ChatMessage()
                            {
                                SenderId = new Guid(dr.ToStringDataRow("SenderId")),
                                RecieverId = new Guid(dr.ToStringDataRow("RecieverId")),
                                Message = dr.ToStringDataRow("Message"),
                                Id = dr.ToIntDataRow("Id"),
                                Name = dr.ToStringDataRow("Name")
                                //SendDate = Convert.ToDateTime(dr.ToStringDataRow("SendDate")),
                                //ReadDate = Convert.ToDateTime(dr.ToStringDataRow("ReadDate"))

                            }).ToList();
                }
                catch (Exception ex)
                {
                    return null;
                }
                return Chat;

            }
        }

        public ChatMessage GetSenderIdByRecieverId(Guid ReceiverId)
        {

            List<ChatMessage> Chat = new List<ChatMessage>();
            string SqlQuery = @"select * from ChatMessage where RecieverId = '" + ReceiverId + "'";
            using (SqlCommand cmd = GetSQLCommand(string.Format(SqlQuery)))
            {
                DataSet dsResult = GetDataSet(cmd);
                DataTable dt = dsResult.Tables[0];

                try
                {

                    Chat = (from DataRow dr in dt.Rows
                            select new ChatMessage()
                            {
                                SenderId = new Guid(dr.ToStringDataRow("SenderId")),
                                RecieverId = new Guid(dr.ToStringDataRow("RecieverId")),
                                Message = dr.ToStringDataRow("Message"),
                                Id = dr.ToIntDataRow("Id"),
                                SendDate = Convert.ToDateTime(dr.ToStringDataRow("SendDate")),
                                ReadDate = Convert.ToDateTime(dr.ToStringDataRow("ReadDate"))

                            }).ToList();
                }
                catch (Exception ex)
                {
                    return null;
                }
                return Chat.FirstOrDefault();
            }



        }


        public UserLogin GetAllFromUserLogin(Guid SenderId)
        {

            List<UserLogin> Chat = new List<UserLogin>();
            string SqlQuery = @"select * from UserLogin where UserId = '" + SenderId + "'";
            using (SqlCommand cmd = GetSQLCommand(string.Format(SqlQuery)))
            {
                DataSet dsResult = GetDataSet(cmd);
                DataTable dt = dsResult.Tables[0];

                try
                {

                    Chat = (from DataRow dr in dt.Rows
                            select new UserLogin()
                            {
                                UserName = dr.ToStringDataRow("UserName"),
                                EmailAddress = dr.ToStringDataRow("EmailAddress"),


                            }).ToList();
                }
                catch (Exception ex)
                {
                    return null;
                }
                return Chat.FirstOrDefault();
            }

        }





    }
}
