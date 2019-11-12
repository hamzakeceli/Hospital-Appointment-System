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

namespace HospitalRecordingSystem.WinUI.Forms.PatientForms
{
    public partial class FormSessions : Form
    {
        public int GetDoctorId;
        public string shortDate;
        public string SessionTimeName;
        public int SessionTimeId;
        AppointmentController appointmentController;
       public Session session;
        public FormSessions(int doctorId)
        {
            InitializeComponent();
            GetDoctorId = doctorId;
        }

        private void FormSessions_Load(object sender, EventArgs e)
        {
            monthCalendar.MinDate = DateTime.Today;
            monthCalendar.MaxDate = DateTime.Today.AddDays(14);

            shortDate = monthCalendar.SelectionRange.Start.ToShortDateString();
            //MessageBox.Show(GetDoctorId.ToString());

            appointmentController = new AppointmentController();
            CreateSession(DateTime.Today);

        }

        private void btnSelectSession_Click(object sender, EventArgs e)
        {
            session = new Session
            {
                DoctorId = GetDoctorId,
                SessionDate = Convert.ToDateTime(shortDate),
                RendezvousTimeId = SessionTimeId
            };
            
            
           
          //GetDoctorId;
          //shortDate;
          ////SessionTimeId
        }
        public Session GetSession()
        {
          return  appointmentController.GetPatientCurrentSession(session);
        }
            
        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            monthCalendar.MaxSelectionCount = 1;
            shortDate = monthCalendar.SelectionRange.Start.ToShortDateString();
           // MessageBox.Show(shortDate);
            CreateSession(Convert.ToDateTime(shortDate));

            
        }

        ///private void 
        private void CreateSession(DateTime date)
        {
            pnlSessionList.Controls.Clear();
            List<Session> sessionsList = appointmentController.GetDoctorSessions(GetDoctorId, date);

            DataRowCollection rows = appointmentController.GetAllAppointmentsTimes().Rows;
            int timeCount = rows.Count;

            for (int i = 0; i < timeCount / 5; i++)
            {
                for (int j = 0; j < timeCount / 3; j++)
                {
                    Button button = new Button();
                    button.BackColor = Color.FromArgb(26, 177, 136);
                    button.ForeColor = Color.LightGray;
                    button.FlatStyle = FlatStyle.Flat;
                    button.Width = 60;
                    button.Height = 60;
                    button.Left = button.Width * j;
                    button.Top = button.Height * i;
                    button.Text = rows[i * timeCount / 3 + j].ItemArray[1].ToString();
                    button.Tag = rows[i * timeCount / 3 + j].ItemArray[0].ToString();
                    button.Click += GetSessionId;
                    foreach (var item in sessionsList)
                    {
                        if (Convert.ToInt32(button.Tag) == item.RendezvousTimeId)
                        {
                            button.Enabled = false;
                            button.BackColor = Color.LightGray;
                            button.ForeColor = Color.Black;
                           
                        }
                        
                    }
                    
                    pnlSessionList.Controls.Add(button);
                }
            }
        }
        private void GetSessionId(object sender, EventArgs e)
        {
           
            var btn = sender as Button;
            int id = Convert.ToInt32(btn.Tag);
            SessionTimeId = id;
            SessionTimeName = btn.Text;
            //MessageBox.Show(id.ToString());
        }
    }
}
