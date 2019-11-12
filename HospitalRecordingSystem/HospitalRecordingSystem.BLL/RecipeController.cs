using HospitalRecordingSystem.DAL;
using HospitalRecordingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRecordingSystem.BLL
{
    public class RecipeController
    {
        RecipeManagement recipeManagement = new RecipeManagement();

        public bool IsExistsRepice(Recipe recipe)
        {
            if (recipeManagement.IsExistsRepice(recipe))
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
            return recipeManagement.GetRecipe(recipe);
        }
        public bool AddRecipe(Recipe recipe)
        {
            if (recipeManagement.AddRecipe(recipe))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
