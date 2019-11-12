using HospitalRecordingSystem.Entities;
using HospitalRecordingSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRecordingSystem.DAL
{
    public class PatientManagement
    {
        SqlConnection sqlConnection;

        public PatientManagement()
        {
            sqlConnection = ConnectionTools.Connection(sqlConnection);
            //if (sqlConnection == null)
            //{
            //    sqlConnection = new SqlConnection(ConnectionTools.ConnectionString);
            //}
        }
        public Patient GetPatient(Member member)
        {
            Patient patient = new Patient();
            SqlCommand sqlCommand = new SqlCommand("SP_GetPatient", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@patientEmail", member.MemberEmail);

            ConnectionTools.DatabaseOpen(sqlConnection);

            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    patient.PatientId = Convert.ToInt32(dr["PatientId"]);
                    patient.PatientEmail = dr["PatientEmail"].ToString();
                    patient.PatientFirstName = dr["PatientFirstName"].ToString();
                    patient.PatientLastName = dr["PatientLastName"].ToString();
                    
                }
            }
            sqlConnection.Close();

            return patient;
        }

        public bool AddPatient(Patient patient)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_AddPatientAndMembers", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@FirstName", patient.PatientFirstName);
            sqlCommand.Parameters.AddWithValue("@LastName", patient.PatientLastName);
            sqlCommand.Parameters.AddWithValue("@Email", patient.PatientEmail);
            sqlCommand.Parameters.AddWithValue("@Password", patient.PatientPassword);
            ConnectionTools.DatabaseOpen(sqlConnection);
            bool isAdded = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isAdded;
        }

        //public bool IsExistsPatientEmail(Patient patient)
        //{
        //    // Patient patientRecord = new Patient();
        //    SqlCommand IsExistsPatientEmail = new SqlCommand("IsExistPatientMail", sqlConnection);
        //    IsExistsPatientEmail.CommandType = CommandType.StoredProcedure;
        //    IsExistsPatientEmail.Parameters.AddWithValue("@patientEmail", patient.PatientEmail);

        //    ConnectionTools.DatabaseOpen(sqlConnection);

        //    int rowAffected = (int)IsExistsPatientEmail.ExecuteScalar();

        //    if (rowAffected != 0)
        //    {
        //        sqlConnection.Close();
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}


        public bool IsExistsMemberEmail(Patient patient)
        {
            // Patient patientRecord = new Patient();
            //üyeler tablosunda varsa ekleme yapma yoksa ekleme yap.
            SqlCommand IsExistsMemberEmail = new SqlCommand("IsExistMemberEmail", sqlConnection);
            IsExistsMemberEmail.CommandType = CommandType.StoredProcedure;
            IsExistsMemberEmail.Parameters.AddWithValue("@memberEmail", patient.PatientEmail);

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
