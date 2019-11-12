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

namespace HospitalAppointmentSystem.WinUI.Forms
{
    public partial class FormPharmacistRecipeDetails : Form
    {

        Recipe recipeDetails = new Recipe();
        RecipeDetailController RecipeDetailController = new RecipeDetailController();
        public FormPharmacistRecipeDetails(Recipe recipe)
        {
            InitializeComponent();
            recipeDetails = recipe;
        }

        private void FormPharmacistRecipeDetails_Load(object sender, EventArgs e)
        {
            dvgMedicineList.DataSource = RecipeDetailController.GetRecipeDetail(recipeDetails);
           // dvgMedicineList.DefaultCellStyle.Font = new Font("Century Gothic", 16);
          //  DataGridViewColumn column = dvgMedicineList.Columns[2];
        //    column.Width = dvgMedicineList.Width - 9;
            lblPatientNameVariable.Text = dvgMedicineList.CurrentRow.Cells["fullname"].Value.ToString();
            cmbRecipeNumbers.DataSource = RecipeDetailController.GetRecipeDetailList(recipeDetails);
            cmbRecipeNumbers.DisplayMember = "RecipeNumber";
            cmbRecipeNumbers.ValueMember = "RecipeId";
            dvgMedicineList.Columns["RecipeId"].Visible = false;
            dvgMedicineList.Columns["DrugId"].Visible = false;
            dvgMedicineList.Columns["fullname"].Visible = false;

        }

        private void cmbRecipeNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedRecipeId;
            bool isParse = int.TryParse(cmbRecipeNumbers.SelectedValue.ToString(), out selectedRecipeId);
            if (isParse)
            {
                Recipe recipe = new Recipe
                {
                    RecipeId = selectedRecipeId
                };
                dvgMedicineList.DataSource = RecipeDetailController.GetRecipeDetail(recipe);
            }

        }
    }
}
