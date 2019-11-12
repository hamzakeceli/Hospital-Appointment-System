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
    public class RecipeManagement
    {
        SqlConnection sqlConnection;
        public RecipeManagement()
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(ConnectionTools.ConnectionString);
            }
        }

        
        public bool IsExistsRepice(Recipe recipe)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_IsExistRecipe", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@recipeNumber", recipe.RecipeNumber);

            ConnectionTools.DatabaseOpen(sqlConnection);

            int rowAffected = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            if (rowAffected == 1)
            {  
                return true;
            }
            else
            { 
                return false;
            }

        }
        public Recipe GetRecipe(Recipe recipe)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_GetRecipe", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@recipeNumber", recipe.RecipeNumber);
            ConnectionTools.DatabaseOpen(sqlConnection);

            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    recipe.RecipeId = Convert.ToInt32(dr["RecipeId"]);
                    recipe.RecipeNumber = dr["RecipeNumber"].ToString();
                    recipe.PatientId = Convert.ToInt32(dr["PatientId"]);
                }
            }
            sqlConnection.Close();

            return recipe;
        }
        public bool AddRecipe(Recipe recipe)
        {
            SqlCommand sqlCommand = new SqlCommand("SP_InsertRecipe", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@recipeNumber", recipe.RecipeNumber);
            sqlCommand.Parameters.AddWithValue("@patientId", recipe.PatientId);
            ConnectionTools.DatabaseOpen(sqlConnection);
            bool isAdded = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isAdded;
        }



    }
}
