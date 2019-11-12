using HospitalRecordingSystem.DAL;
using HospitalRecordingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRecordingSystem.BLL
{
    public class RecipeDetailController
    {
        RecipeDetailManagement recipeDetailManagement = new RecipeDetailManagement();

        public DataTable GetRecipeDetail(Recipe recipe)
        {
            return recipeDetailManagement.GetRecipeDetail(recipe);
        }
        public DataTable GetRecipeDetailList(Recipe recipe)
        {
            return recipeDetailManagement.GetRecipeDetailList(recipe);
        }
        public bool AddRecipeDetail(Recipe recipe, int medicineId)
        {
            if (recipeDetailManagement.AddRecipeDetail(recipe, medicineId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable GetAllMedicine()
        {
            return recipeDetailManagement.GetAllMedicine();
        }
    }
    
}
