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
    public class RecipeDetailManagement
    {
        SqlConnection sqlConnection;
        public RecipeDetailManagement()
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(ConnectionTools.ConnectionString);
            }
        }
        public DataTable GetRecipeDetail(Recipe recipe)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_GetRecipeDetail", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@recipeId", recipe.RecipeId);
            
            ConnectionTools.DatabaseOpen(sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }
        public DataTable GetRecipeDetailList(Recipe recipe)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_GetRecipeList", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@recipeNumber", recipe.RecipeNumber);

            ConnectionTools.DatabaseOpen(sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }
        public bool AddRecipeDetail(Recipe recipe , int medicineId)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_InsertRecipeDetails", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@recipeId", recipe.RecipeId);
            sqlCommand.Parameters.AddWithValue("@medicineId", medicineId);
            ConnectionTools.DatabaseOpen(sqlConnection);
            bool isAdded = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isAdded;
        }
        public DataTable GetAllMedicine()
        {
            SqlCommand sqlCommand = new SqlCommand("SP_GetAllMedicine", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            ConnectionTools.DatabaseOpen(sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;

        }
    }
}
