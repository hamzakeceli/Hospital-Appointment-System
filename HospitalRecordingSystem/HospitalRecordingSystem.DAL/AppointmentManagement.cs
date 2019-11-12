using HospitalRecordingSystem.Entities;
using HospitalRecordingSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRecordingSystem.DAL
{
    public class AppointmentManagement
    {
        SqlConnection sqlConnection;

        public AppointmentManagement()
        {
            // ConnectionTools.Connection(sqlConnection);
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(ConnectionTools.ConnectionString);
            }
        }

        public DataTable GetAllAppointmentsTimes()
        {

            ConnectionTools.DatabaseOpen(sqlConnection);

            SqlCommand sqlCommand = new SqlCommand("SP_GetAllRendezvousTimes", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;

        }

        public List<Session> GetDoctorAppointmentTimeId(int DoctorId,DateTime SessionDate)
        {
            
            List<Session> SessionsList = new List<Session>();
            SqlCommand sqlCommand = new SqlCommand("SP_GetRendezvousTimeId", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@DoctorId", DoctorId);
            sqlCommand.Parameters.AddWithValue("@SessionDate", SessionDate);

            ConnectionTools.DatabaseOpen(sqlConnection);
            SqlDataReader dr = sqlCommand.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Session session = new Session
                    {
                        SessionId = Convert.ToInt32(dr["SessionId"].ToString()),
                        RendezvousTimeId = Convert.ToInt32(dr["RendezvousTimeId"].ToString()),
                        DoctorId = Convert.ToInt32(dr["DoctorId"].ToString()),
                        SessionDate = Convert.ToDateTime(dr["SessionDate"].ToString()),
                    };

                    SessionsList.Add(session);
                }
            }
            sqlConnection.Close();

            return SessionsList;

        }
        public DataTable GetPatientAppointmentHistory(int patientId)
        {

            ConnectionTools.DatabaseOpen(sqlConnection);

            SqlCommand sqlCommand = new SqlCommand("SP_GetAllPatientAppointment", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@PatientId", patientId);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;

        }


        public bool AddCompleteAppointment(Session session, Patient patient)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_AddRendezvous", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@SessionDate", session.SessionDate);
            sqlCommand.Parameters.AddWithValue("@RendezvousTimeId", session.RendezvousTimeId);
            sqlCommand.Parameters.AddWithValue("@DoctorId ", session.DoctorId);
            sqlCommand.Parameters.AddWithValue("@PatientId ", patient.PatientId);
            ConnectionTools.DatabaseOpen(sqlConnection);
            bool isAdded = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isAdded;
        }

        public bool DeletePatientAppointment(int sessionId,int patientId)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_DeletePatientAppointment", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@SessionId", sessionId);
            sqlCommand.Parameters.AddWithValue("@PatientId", patientId);
            
            ConnectionTools.DatabaseOpen(sqlConnection);
            bool isDeleted = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isDeleted;
        }

        public List<Session> GetAllSessions(int DoctorId)
        {

            List<Session> SessionsList = new List<Session>();
            SqlCommand sqlCommand = new SqlCommand("SP_GetAllSessions", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@DoctorId", DoctorId);
            ConnectionTools.DatabaseOpen(sqlConnection);
            SqlDataReader dr = sqlCommand.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Session session = new Session
                    {
                        SessionId = Convert.ToInt32(dr["SessionId"].ToString()),
                        RendezvousTimeId = Convert.ToInt32(dr["RendezvousTimeId"].ToString()),
                        DoctorId = Convert.ToInt32(dr["DoctorId"].ToString()),
                        SessionDate = Convert.ToDateTime(dr["SessionDate"].ToString()),
                    };


                    SessionsList.Add(session);
                }
            }
            sqlConnection.Close();

            return SessionsList;

        }

        //public List<AppointmentTime> GetAllAppointmentsTimes()
        //{
        //    AppointmentTime appointmentTime = new AppointmentTime();
        //    SqlCommand sqlCommand = new SqlCommand("SP_GetAllRendezvousTimes", sqlConnection);
        //    sqlCommand.CommandType = CommandType.StoredProcedure;


        //    ConnectionTools.DatabaseOpen(sqlConnection);
        //    SqlDataReader dr = sqlCommand.ExecuteReader();

        //    List<AppointmentTime> appointmentTimeList = new List<AppointmentTime>();

        //    if (dr.HasRows)
        //    {
        //        while (dr.Read())
        //        {
        //            appointmentTime.RendezvousTimeId = Convert.ToInt32(dr["RendezvousTimeId"].ToString());
        //            appointmentTime.RendezvousTime = (dr["RendezvousTime"].ToString());
        //            appointmentTimeList.Add(appointmentTime);                        
        //        }
        //    }
        //    sqlConnection.Close();

        //    return appointmentTimeList;
        //}
    }
}
