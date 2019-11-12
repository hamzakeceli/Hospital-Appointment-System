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
    public class PolyclinicsManagement
    {


        SqlConnection sqlConnection;
      
        public PolyclinicsManagement()
        {
            // ConnectionTools.Connection(sqlConnection);
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(ConnectionTools.ConnectionString);
            }
        }

        public DataTable GetPolyclinic(int departmentId)
        {

            ConnectionTools.DatabaseOpen(sqlConnection);

            SqlCommand sqlCommand = new SqlCommand("SP_GetPolyclinics", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@DepartmentId", departmentId);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;

        }

        public List<Polyclinic> GetPolyclinicList(int departmentId)
        {

            ConnectionTools.DatabaseOpen(sqlConnection);

            SqlCommand sqlCommand = new SqlCommand("SP_GetPolyclinics", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@DepartmentId", departmentId);

            List<Polyclinic> polyclinics = new List<Polyclinic>();
            polyclinics.Add(null);

            ConnectionTools.DatabaseOpen(sqlConnection);

            SqlDataReader dr = sqlCommand.ExecuteReader();

            Polyclinic polyclinic = new Polyclinic();

            if (dr.HasRows)
            {
                while (dr.Read())
                {


                    polyclinic.PolyclinicId = Convert.ToInt32(dr["PolyclinicId"].ToString());
                    polyclinic.PolyclinicName = dr["PolyclinicName"].ToString();
                    polyclinic.DepartmentId = Convert.ToInt32(dr["DepartmanId"].ToString());
                    polyclinics.Add(polyclinic);
                }
            }
            sqlConnection.Close();

            return polyclinics;

        }
    }
}
