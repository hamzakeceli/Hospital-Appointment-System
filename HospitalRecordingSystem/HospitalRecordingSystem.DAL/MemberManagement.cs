using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HospitalRecordingSystem.Entities;
using HospitalRecordingSystem.Helpers;


namespace HospitalRecordingSystem.DAL
{
    public class MemberManagement
    {
        SqlConnection sqlConnection;

        public MemberManagement()
        {
            // ConnectionTools.Connection(sqlConnection);
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(ConnectionTools.ConnectionString);
            }
        }

        public Member GetMember(string email)
        {
            Member member = new Member();
            SqlCommand sqlCommand = new SqlCommand("SP_GetMember",sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Email", email);

             ConnectionTools.DatabaseOpen(sqlConnection);
           
            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    member.MemberEmail = dr["MemberEmail"].ToString();
                    member.MemberPassword = dr["MemberPassword"].ToString();
                    member.RoleId = Convert.ToInt32(dr["RoleId"].ToString());
                }
            }
            sqlConnection.Close();

            return member;

        }
    }
}
