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
    public class ExaminationManagement
    {
        SqlConnection sqlConnection;
        public ExaminationManagement()
        {
            // ConnectionTools.Connection(sqlConnection);
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(ConnectionTools.ConnectionString);
            }
        }
        public Patient GetPatient(int rendezvousTimeId, int doctorId, DateTime date)
        {
            Patient patient = new Patient();
            SqlCommand sqlCommand = new SqlCommand("SP_GetRendezvousPatient", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@rendezvousTimeId", rendezvousTimeId);
            sqlCommand.Parameters.AddWithValue("@doctorId", doctorId);
            sqlCommand.Parameters.AddWithValue("@sessionDate", date);

            ConnectionTools.DatabaseOpen(sqlConnection);

            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    patient.PatientId = Convert.ToInt32(dr["PatientId"].ToString());
                    patient.PatientEmail = dr["PatientEmail"].ToString();
                    patient.PatientFirstName = dr["PatientFirstName"].ToString();
                    patient.PatientLastName = dr["PatientLastName"].ToString();

                }
            }
            sqlConnection.Close();

            return patient;
        }

        public DataTable GetAllDiognosis()
        {
            SqlCommand sqlCommand = new SqlCommand("SP_GetAllDiagnosis", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            ConnectionTools.DatabaseOpen(sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        public int GetSessionId (int rendezvousTimeId, int doctorId , DateTime date)
        {
            int sessionId = 0;

            
            SqlCommand sqlCommand = new SqlCommand("SP_GetSessionId", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@rendezvousTimeId", rendezvousTimeId);
            sqlCommand.Parameters.AddWithValue("@doctorId", doctorId);
            sqlCommand.Parameters.AddWithValue("@sessionDate", date);

            ConnectionTools.DatabaseOpen(sqlConnection);

            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    sessionId = Convert.ToInt32(dr["SessionId"]);

                }
            }
            sqlConnection.Close();
            return sessionId;
        }
        public bool AddExamination(int sessionId,int patientId,int diognosisId,int recipeId,int exaStatus)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_InsertExaminations", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@sessionId", sessionId);
            sqlCommand.Parameters.AddWithValue("@patientId", patientId);
            sqlCommand.Parameters.AddWithValue("@diognosisId", diognosisId);
            sqlCommand.Parameters.AddWithValue("@recipeId", recipeId);
            sqlCommand.Parameters.AddWithValue("@exaStatu", exaStatus);
            ConnectionTools.DatabaseOpen(sqlConnection);
            bool isAdded = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isAdded;
        }
        public bool AddExaminationForExaStatuZero(int sessionId, int patientId, int diognosisId,int exaStatus)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_InsertExaminationsForExaStatuZero", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@sessionId", sessionId);
            sqlCommand.Parameters.AddWithValue("@patientId", patientId);
            sqlCommand.Parameters.AddWithValue("@diognosisId", diognosisId);
            sqlCommand.Parameters.AddWithValue("@exaStatu", exaStatus);
            ConnectionTools.DatabaseOpen(sqlConnection);
            bool isAdded = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isAdded;
        }



        public DataTable GetAllCompleteExaminations(int doctorId)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_GetAllCompleteExaminations", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@doctorId", doctorId);
            ConnectionTools.DatabaseOpen(sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        public List<int> GetRendezvousTimeIdForExamination(int doctorId,DateTime date)
        {

            List<int> SessionsList = new List<int>();
            SqlCommand sqlCommand = new SqlCommand("SP_GetRendezvousTimeIdForExamination", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@doctorId", doctorId);
            sqlCommand.Parameters.AddWithValue("@sessionDate", date);
            ConnectionTools.DatabaseOpen(sqlConnection);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int temp = Convert.ToInt32(dr["RendezvousTimeId"]);

                    SessionsList.Add(temp);
                }
            }
            sqlConnection.Close();

            return SessionsList;

        }

    }

}
