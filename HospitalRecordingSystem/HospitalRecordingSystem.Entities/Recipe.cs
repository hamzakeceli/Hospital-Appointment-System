using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRecordingSystem.Entities
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string RecipeNumber { get; set; }
        public int PatientId { get; set; }
        
    }
}
