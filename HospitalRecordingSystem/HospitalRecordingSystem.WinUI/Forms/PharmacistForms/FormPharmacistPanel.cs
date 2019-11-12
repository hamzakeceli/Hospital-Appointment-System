using HospitalAppointmentSystem.WinUI.Forms;
using HospitalRecordingSystem.BLL;
using HospitalRecordingSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalRecordingSystem.WinUI.Forms
{
    public partial class FormPharmacistPanel : Form
    {

        public FormPharmacistPanel()
        {
            InitializeComponent();
        }
        RecipeController recipeController = new RecipeController();
        private void btnRecipeNumberQuery_Click(object sender, EventArgs e)
        {
            Recipe recipe = new Recipe
            {
                RecipeNumber = txtRecipeNumber.Text
            };
            if (recipeController.IsExistsRepice(recipe))
            {
                recipe = recipeController.GetRecipe(recipe);
                FormPharmacistRecipeDetails formPharmacistRecipeDetails = new FormPharmacistRecipeDetails(recipe);
                formPharmacistRecipeDetails.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı reçeti numarası girişi!");
            }

        }

        private void FormPharmacistPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
