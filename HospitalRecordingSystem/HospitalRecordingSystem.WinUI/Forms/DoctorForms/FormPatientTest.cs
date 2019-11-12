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

namespace HospitalRecordingSystem.WinUI.Forms.DoctorForms
{
    public partial class FormPatientTest : Form
    {
        Doctor doctor;
        Patient patient;
        public FormPatientTest(Doctor getDoctor,Patient getPatient)
        {
            InitializeComponent();
            doctor = getDoctor;
            patient = getPatient;
        }
        AppointmentController appointmentController = new AppointmentController();
        ExaminationController examinationController = new ExaminationController();
        string shortDate;
        int SessionTimeId=0;
        private void FormPatientTest_Load(object sender, EventArgs e)
        {
            mtcSessions.MinDate = DateTime.Today;
            mtcSessions.MaxDate = DateTime.Today.AddDays(14);
            CreateSession(DateTime.Today);
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
                    button.Width = 65;
                    button.Height = 65;
                    button.Enabled = true;
                    button.Left = button.Width * j;
                    button.Top = button.Height * i;
                    button.Text = rows[i * timeCount / 3 + j].ItemArray[1].ToString();
                    button.Tag = rows[i * timeCount / 3 + j].ItemArray[0].ToString();
                    button.Click += GetPatient;

                    foreach (var item in sessionsList)
                    {
                        if (Convert.ToInt32(button.Tag) == item.RendezvousTimeId)
                        {

                            button.Enabled = false;
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
            //MessageBox.Show(id.ToString());
        }
        private void mtcSessions_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            mtcSessions.MaxSelectionCount = 1;
            shortDate = mtcSessions.SelectionRange.Start.ToShortDateString();
            // MessageBox.Show(shortDate);
            CreateSession(Convert.ToDateTime(shortDate));
        }
        private void btnSaveAppointment_Click(object sender, EventArgs e)
        {
            if (SessionTimeId == 0)
            {
                MessageBox.Show("Lütfen bir seans seçiniz.");
            }
            else
            {
                Session session = new Session()
                {
                    RendezvousTimeId = SessionTimeId,
                    DoctorId = doctor.DoctorId,
                    SessionDate = Convert.ToDateTime(shortDate)
                };
                if (appointmentController.AddAppointment(session, patient))
                {
                    MessageBox.Show("Kayıt başarılı.");
                }
                else
                {
                    MessageBox.Show("Kayıt anında bir hata oluştu.");
                }
            }  
        }

      
    }
}

