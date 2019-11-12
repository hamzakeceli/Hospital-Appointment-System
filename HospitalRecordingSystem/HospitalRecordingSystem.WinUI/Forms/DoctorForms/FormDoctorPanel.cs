using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using HospitalRecordingSystem.Entities;
using System.Windows.Forms;
using HospitalRecordingSystem.BLL;

namespace HospitalRecordingSystem.WinUI.Forms.DoctorForms
{
    public partial class FormDoctorPanel : Form
    {
        Member memberDoctor;
        DoctorController doctorController = new DoctorController();
        AppointmentController appointmentController = new AppointmentController();
        ExaminationController examinationController = new ExaminationController();
        RecipeController recipeController = new RecipeController();
        public FormDoctorPanel(Member member)
        {
            InitializeComponent();
            memberDoctor = member;
        }
        Doctor doctor;
        Patient patient;
        int SessionTimeId;
        string RecipeNumber = string.Empty;
        private void FormDoctorPanel_Load(object sender, EventArgs e)
        {
            doctor = doctorController.GetDoctor(memberDoctor);
            lblWelcome.Text = string.Format("Hoşgeldiniz {0} {1}", doctor.DoctorFirstName, doctor.DoctortLastName);
            pnlTodaysAppointments.Visible = true;
            pnlCompletedAppointments.Visible = false;
            cmbExaminationStatus.DataSource = Enum.GetValues(typeof(EnumExaminationStatus));
            CreateSession(DateTime.Today);
            pnlPatientStatus.Visible = false;
            cmbDiagnosis.DataSource = examinationController.GetAllDiognosis();
            cmbDiagnosis.DisplayMember = "DiagnosisName";
            cmbDiagnosis.ValueMember = "DiagnosisId";
        }
        private void CreateSession(DateTime date)
        {
            pnlSessionList.Controls.Clear();
            List<Session> sessionsList = appointmentController.GetDoctorSessions(doctor.DoctorId, date);
            List<int> completerExaminationList = examinationController.GetRendezvousTimeIdForExamination(doctor.DoctorId,DateTime.Today);

            DataRowCollection rows = appointmentController.GetAllAppointmentsTimes().Rows;
            int timeCount = rows.Count;

            for (int i = 0; i < timeCount / 5; i++)
            {
                for (int j = 0; j < timeCount / 3; j++)
                {
                    Button button = new Button();
                    button.BackColor = Color.FromArgb(26, 177, 136);              
                    button.FlatStyle = FlatStyle.Flat;
                    button.ForeColor = Color.White;
                    button.Width = 80;
                    button.Height = 80;
                    button.Enabled = false;
                    button.Left = button.Width * j;
                    button.Top = button.Height * i;
                    button.Text = rows[i * timeCount / 3 + j].ItemArray[1].ToString();
                    button.Tag = rows[i * timeCount / 3 + j].ItemArray[0].ToString();
                    button.Click += GetPatient;
                    
                    foreach (var item in sessionsList)
                    {

                        if (Convert.ToInt32(button.Tag) == item.RendezvousTimeId)
                        {
                            
                            button.Enabled = true;
                            button.BackColor = Color.FromArgb(67, 81, 89);
                            button.ForeColor = Color.White;
                            foreach (int items in completerExaminationList)
                            {
                                if (string.Equals(button.Tag, items.ToString()))
                                {
                                    button.Enabled = false;
                                }
                            }

                        }
                        
                    }
                    pnlSessionList.Controls.Add(button);
                }
            }
        }
        private void GetPatient(object sender, EventArgs e)
        {

            var btn = sender as Button;
            int id = Convert.ToInt32(btn.Tag);
            SessionTimeId = id;
            patient = examinationController.GetPatient(SessionTimeId, doctor.DoctorId, DateTime.Today);
            lblPatientName.Text = string.Format("{0} {1}", patient.PatientFirstName, patient.PatientLastName); 
            pnlPatientStatus.Visible = true;
            //MessageBox.Show(id.ToString());
        }

        private void btnTodaysAppointments_Click(object sender, EventArgs e)
        {
            pnlTodaysAppointments.Visible = true;
            pnlCompletedAppointments.Visible = false;
        }

        private void btnCompletedAppointments_Click(object sender, EventArgs e)
        {
            dvgCompletedAppointments.DataSource = examinationController.GetAllCompleteExaminations(doctor.DoctorId);
            pnlTodaysAppointments.Visible = false;
            pnlCompletedAppointments.Visible = true;
        }

        private void btnTestRequest_Click(object sender, EventArgs e)
        {
            FormPatientTest formPatientTest = new FormPatientTest(doctor,patient);
            if(formPatientTest.ShowDialog() == DialogResult.OK)
            {
                pnlPatientStatus.Visible = false;
                
            }
            
        }

        private void btnRecipeCreate_Click(object sender, EventArgs e)
        {
            FormPatientRecipe formPatientRecipe = new FormPatientRecipe(patient);
            if (formPatientRecipe.ShowDialog() == DialogResult.OK)
            {
                RecipeNumber = formPatientRecipe.recipeNoSub;
            }
        }

        private void BtnSaveAppointment_Click(object sender, EventArgs e)
        {
            Recipe recipe = new Recipe()
            {
                RecipeNumber = RecipeNumber
            };
            recipe = recipeController.GetRecipe(recipe);


            int sessionId = examinationController.GetSessionId(SessionTimeId, doctor.DoctorId, DateTime.Today);
            int patientId = patient.PatientId;
            int diognosisId = Convert.ToInt32(cmbDiagnosis.SelectedValue);
            int recipeId = recipe.RecipeId;
            int exaStatu = cmbExaminationStatus.SelectedIndex;
            
            if(cmbExaminationStatus.SelectedIndex != 0)
            {

            
            if (RecipeNumber == string.Empty)
            {
                MessageBox.Show("Lütfen reçete yazınız.");
            }
            else
            {
                if (examinationController.AddExamination(sessionId, patientId,diognosisId,recipeId,exaStatu))
                {
                    MessageBox.Show("Muayene işlemi tamamlanmıştır.");
                    pnlPatientStatus.Visible = false;
                    CreateSession(DateTime.Today);
                }
                else
                {
                    MessageBox.Show("Muayene eklerken sorun oluştu.");
                }
            }
            }
            else
            {
                if (examinationController.AddExaminationAddExaminationForExaStatuZero(sessionId, patientId, diognosisId, exaStatu))
                {
                    MessageBox.Show("Muayene işlemi tamamlanmıştır.");
                    pnlPatientStatus.Visible = false;
                    CreateSession(DateTime.Today);
                }
                else
                {
                    MessageBox.Show("Muayene eklerken sorun oluştu.");
                }
            }







        }

    }
}
