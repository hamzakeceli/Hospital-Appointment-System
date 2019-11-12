using HospitalRecordingSystem.Helpers.Properties;
using System.Data;
using System.Data.SqlClient;

namespace HospitalRecordingSystem.Helpers
{
    public class ConnectionTools
    {
        
        public static string ConnectionString
        {
            get
            {
                return Configuration.Default.ConnectionPath;
            }
        }

        public static SqlConnection Connection(SqlConnection sqlConnection)
        {
            if(sqlConnection == null)
            {
                sqlConnection = new SqlConnection(ConnectionString);
            }
            return sqlConnection;
        }

        public static void DatabaseOpen(SqlConnection sqlConnection)
        {
            if(sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }


        
    }
}
