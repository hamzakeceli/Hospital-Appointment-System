using HospitalRecordingSystem.BLL;
using HospitalRecordingSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalRecordingSystem.WinUI.Forms.DoctorForms
{
    public partial class FormPatientRecipe : Form
    {
        Patient patient; 
        public FormPatientRecipe(Patient getPatient)
        {
            InitializeComponent();
            patient = getPatient;
        }
        RecipeController recipeController = new RecipeController();
        RecipeDetailController recipeDetailController = new RecipeDetailController();
        public string recipeNoSub;
        
        
        private void FormPatientRecipe_Load(object sender, EventArgs e)
        {
            
            cmbMedicineName.DataSource = recipeDetailController.GetAllMedicine();
            cmbMedicineName.DisplayMember = "DrugName";
            cmbMedicineName.ValueMember = "DrugId";

            string now = (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds.ToString();
            MD5 md5hash = MD5.Create();
            string recipeNo = GetMd5Hash(md5hash, now);
            recipeNoSub = recipeNo.Substring(2, 7);
            lblRecipeNo.Text = string.Format("Reçete Numarası : {0}", recipeNoSub);
            Recipe recipe = new Recipe()
            {
                RecipeNumber = recipeNoSub,
                PatientId = patient.PatientId
            };
            if (recipeController.AddRecipe(recipe))
            {
                MessageBox.Show("Reçete oluşturuldu");
            }
            else
            {
                MessageBox.Show("Reçete oluşturulamadı.");
                this.Close();
            }

        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        
        private void btnMedicineAdd_Click(object sender, EventArgs e)
        {
            Recipe recipe = new Recipe()
            {
                RecipeNumber = recipeNoSub
            };
            recipe = recipeController.GetRecipe(recipe);
            int medicineId = Convert.ToInt32(cmbMedicineName.SelectedValue);
            if (recipeDetailController.AddRecipeDetail(recipe, medicineId))
            {
                lstMedicineList.Items.Add(cmbMedicineName.Text);
                MessageBox.Show("İlaç eklendi");

            }
            else
            {
                MessageBox.Show("İlaç eklenemedi");
            }

        }
    }
}
