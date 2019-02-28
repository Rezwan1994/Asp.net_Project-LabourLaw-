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
	public partial class UserPermissionDataAccess
	{
            public bool IsPermitted(int Id, Guid UserId)
            {
                List<UserPermission> permission = new List<UserPermission>();
                string SqlQuery = @"Select * into #FilterPermission from(
                                Select PGM.permissionId from PermissionGroupMap PGM
                                LEFT JOIN UserPermission UP ON UP.PermissionGroupId = PGM.PermissionGroupId
                                WHERE UserId='" + UserId + @"' 
                                Union
                                Select PermissionId from UserPermission
                                where UserId='" + UserId + @"' AND PermissionId is NOT NULL) #FilterPermission
                                Select * from #FilterPermission where PermissionId in('" + Id + @"')
                                Drop Table #FilterPermission";

                using (SqlCommand cmd = GetSQLCommand(SqlQuery))
                {
                    DataSet dsResult = GetDataSet(cmd);
                    DataTable dt = dsResult.Tables[0];
                    try
                    {
                        permission = (from DataRow dr in dt.Rows
                                      select new UserPermission()
                                      {
                                          PermissionId = dr.ToIntDataRow("PermissionId")
                                      }).ToList();
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }

                if (permission.Count != 0)
                {
                    return true;
                }
                return false;
            }

            public List<Permission> GetChackedParmission(int parmissionId)
            {
            List<Permission> permission = new List<Permission>();
            string SqlQuery = @"select p.Id,p.DisplayText, p.Name,
                                 CASE  
                                      WHEN pgm.PermissionId IS NOT NULL THEN 1   
                                      ELSE 0    
                                  END Selected from  Permission p
                                left join PermissionGroupMap pgm on  pgm.PermissionId=p.Id AND pgm.PermissionGroupId ='" + parmissionId + @"' 
                                left join PermissionGroup pg on pg.Id = pgm.PermissionGroupId ";

            using (SqlCommand cmd = GetSQLCommand(SqlQuery))
            {
                DataSet dsResult = GetDataSet(cmd);
                DataTable dt = dsResult.Tables[0];
                try
                {
                    permission = (from DataRow dr in dt.Rows
                                  select new Permission()
                                  {
                                      Id = dr.ToIntDataRow("Id"),
                                      Selected = dr.ToIntDataRow("Selected"), 
                                      Name = dr.ToStringDataRow("Name"),
                                      DisplayText = dr.ToStringDataRow("DisplayText")
                                   
                                  }).ToList();
                }
                catch (Exception ex)
                {
                    return null;
                }
            }

            return permission;
        }
    }

   
}	
