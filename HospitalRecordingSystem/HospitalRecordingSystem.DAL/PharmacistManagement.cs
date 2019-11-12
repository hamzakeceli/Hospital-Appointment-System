using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalRecordingSystem.Helpers;
using HospitalRecordingSystem.Entities;

namespace HospitalRecordingSystem.DAL
{
    public class PharmacistManagement
    {
        SqlConnection sqlConnection;
        public PharmacistManagement()
        {
            // ConnectionTools.Connection(sqlConnection);
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(ConnectionTools.ConnectionString);
            }
        }

        public bool AddPharmacist(Pharmacist pharmacist)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_AddPharmacistAndMembers", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@FirstName", pharmacist.PharmacistFirstName);
            sqlCommand.Parameters.AddWithValue("@LastName", pharmacist.PharmacistLastName);
            sqlCommand.Parameters.AddWithValue("@Email", pharmacist.PharmacistEmail);
            sqlCommand.Parameters.AddWithValue("@Password", pharmacist.PharmacistPassword);
          

            bool isAdded = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isAdded;
        }

        public bool IsExistsMemberEmail(Pharmacist pharmacist)
        {
            //üyeler tablosunda varsa ekleme yapma yoksa ekleme yap.
            SqlCommand IsExistsMemberEmail = new SqlCommand("IsExistMemberEmail", sqlConnection);
            IsExistsMemberEmail.CommandType = CommandType.StoredProcedure;
            IsExistsMemberEmail.Parameters.AddWithValue("@memberEmail", pharmacist.PharmacistEmail);

            ConnectionTools.DatabaseOpen(sqlConnection);

            int rowAffected = (int)IsExistsMemberEmail.ExecuteScalar();

            if (rowAffected != 0)
            {
                sqlConnection.Close();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
