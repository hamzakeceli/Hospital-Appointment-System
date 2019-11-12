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
    public class HospitalManagement
    {
        SqlConnection sqlConnection;

        public HospitalManagement()
        {
            
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(ConnectionTools.ConnectionString);
            }
        }


        public DataTable GetHospital()
        {
            List<Hospital> hospitals = new List<Hospital>();
            ConnectionTools.DatabaseOpen(sqlConnection);

            SqlCommand sqlCommand = new SqlCommand("SP_GetHospitals",sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
           
                    
            sqlConnection.Close();

            return dataTable;

        }



    }
}
