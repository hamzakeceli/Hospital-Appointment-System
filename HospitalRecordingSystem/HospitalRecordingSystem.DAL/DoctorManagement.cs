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
    public class DoctorManagement
    {
        SqlConnection sqlConnection;
        public DoctorManagement()
        {    
            // ConnectionTools.Connection(sqlConnection);
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(ConnectionTools.ConnectionString);
            }
        }
        public Doctor GetDoctor(Member member)
        {
            Doctor doctor = new Doctor();
            SqlCommand sqlCommand = new SqlCommand("SP_GetDoctor", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@memberEmail", member.MemberEmail);

            ConnectionTools.DatabaseOpen(sqlConnection);

            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    doctor.DoctorId = Convert.ToInt32(dr["DoctorId"].ToString());
                    doctor.DoctorEmail = dr["DoctorEmail"].ToString();
                    doctor.DoctorFirstName = dr["DoctorFirstName"].ToString();
                    doctor.DoctortLastName = dr["DoctorLastName"].ToString();

                }
            }
            sqlConnection.Close();

            return doctor;
        }

        public bool AddDoctor(Doctor doctor)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_AddDoctorAndMembers", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@FirstName", doctor.DoctorFirstName);
            sqlCommand.Parameters.AddWithValue("@LastName", doctor.DoctortLastName);
            sqlCommand.Parameters.AddWithValue("@Email", doctor.DoctorEmail);
            sqlCommand.Parameters.AddWithValue("@Password", doctor.DoctorPassword);
            sqlCommand.Parameters.AddWithValue("@DepartmantId", doctor.DepartmentId);
            sqlCommand.Parameters.AddWithValue("@PolyclinicId", doctor.PolyclinicId);

            bool isAdded = sqlCommand.ExecuteNonQuery() > 0 ;
            sqlConnection.Close();
            return isAdded;
        }

        public DataTable GetDoctors(int departmantId)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_GetDoctorsPolyclinicIsNull", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@DepartmanId", departmantId);
          //  sqlCommand.Parameters.AddWithValue("@PolyclinicId", doctor.PolyclinicId);

            ConnectionTools.DatabaseOpen(sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        public DataTable GetDoctors(int departmantId,int polyclinicId)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_GetDoctors", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@DepartmanId", departmantId);
            sqlCommand.Parameters.AddWithValue("@PolyclinicId", polyclinicId);

            ConnectionTools.DatabaseOpen(sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }


        public bool IsExistsMemberEmail(Doctor doctor)
        {
            //üyeler tablosunda varsa ekleme yapma yoksa ekleme yap.
            SqlCommand IsExistsMemberEmail = new SqlCommand("IsExistMemberEmail", sqlConnection);
            IsExistsMemberEmail.CommandType = CommandType.StoredProcedure;
            IsExistsMemberEmail.Parameters.AddWithValue("@memberEmail", doctor.DoctorEmail);

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
