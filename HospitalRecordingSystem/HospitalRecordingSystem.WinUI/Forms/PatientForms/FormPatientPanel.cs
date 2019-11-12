using HospitalRecordingSystem.Entities;
using System;
using HospitalRecordingSystem.BLL;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalRecordingSystem.WinUI.Forms.PatientForms
{
    public partial class FormPatientPanel : Form
    {
        Member memberPatient;
        PatientController patientController = new PatientController();
        HospitalController hospitalController = new HospitalController();
        DepartmentController departmentController = new DepartmentController();
        PolyclinicController polyclinicController = new PolyclinicController();
        DoctorController doctorController = new DoctorController();
        AppointmentController appointmentController = new AppointmentController();
        Patient patient;
        Session session;
        

        public FormPatientPanel(Member member)
        {
            InitializeComponent();
            memberPatient = member;

        }

        private void FormPatientPanel_Load(object sender, EventArgs e)
        {
            pnlGetAnAppointment.Visible = true;
            pnlAppointmentList.Visible = false;
            patient = patientController.GetPatient(memberPatient); 
            lblPatientNameAndSurname.Text = string.Format("Hoşgeldiniz {0} {1}", patient.PatientFirstName, patient.PatientLastName);

            cmbAppointmentHospitalName.DataSource = hospitalController.GetHospital();
            cmbAppointmentHospitalName.DisplayMember = "HospitalName";
            cmbAppointmentHospitalName.ValueMember = "HospitalId";

            cmbAppointmentDepartmentName.DataSource = departmentController.GetDepartment();
            cmbAppointmentDepartmentName.DisplayMember = "DepartmentName";
            cmbAppointmentDepartmentName.ValueMember = "DepartmentId";

            pnlAnAppointmentInfos.Visible = false;

            dgvGetAllAppointments.DataSource = appointmentController.GetPatientAppointmentHistory(patient.PatientId);
            dgvGetAllAppointments.Columns["PatientId"].Visible = false;
            dgvGetAllAppointments.Columns["SessionId"].Visible = false;
            //cmbAppointmentPolyclinicName.SelectedItem = null;
            //cmbAppointmentPolyclinicName.Text = "Seçiniz....";
        }

        private void BtnGetAnAppointment_Click(object sender, EventArgs e)
        {
            pnlGetAnAppointment.Visible = true;
            pnlAppointmentList.Visible = false;
        }

        private void BtnAllAppointments_Click(object sender, EventArgs e)
        {
            dgvGetAllAppointments.DataSource = appointmentController.GetPatientAppointmentHistory(patient.PatientId);
            pnlGetAnAppointment.Visible = false;
            pnlAppointmentList.Visible = true;
        }

        public void BtnGetDoctorSession_Click(object sender, EventArgs e)
        {
            int selectedDoctorId = Convert.ToInt32(dgvDoctorList.CurrentRow.Cells["DoctorId"].Value);
            FormSessions formSessions = new FormSessions(selectedDoctorId);
            if (formSessions.ShowDialog() == DialogResult.OK)
            {
                lblAppointmentPatientName.Text = string.Format("{0} {1}", patient.PatientFirstName, patient.PatientLastName);
                lblAppointmentPatientDate.Text = formSessions.shortDate;
                lblAppointmentPatientSession.Text = formSessions.SessionTimeName;
                lblAppointmentPatientDoctorName.Text = dgvDoctorList.CurrentRow.Cells["AD"].Value.ToString() + dgvDoctorList.CurrentRow.Cells["SOYAD"].Value.ToString();
                lblAppointmentPatientHospitalName.Text = cmbAppointmentHospitalName.GetItemText(cmbAppointmentHospitalName.SelectedItem);
                lblAppointmentPatientDepartmentName.Text = cmbAppointmentDepartmentName.GetItemText(cmbAppointmentDepartmentName.SelectedItem);
                if (cmbAppointmentPolyclinicName.SelectedItem != null)
                {
                    lblAppointmentPatientPolyclinicName.Text = cmbAppointmentPolyclinicName.GetItemText(cmbAppointmentPolyclinicName.SelectedItem);
                }
                else
                {
                    lblAppointmentPatientPolyclinicName.Text = string.Empty;
                }
                pnlAnAppointmentInfos.Visible = true;

                session = formSessions.session;
            }
           
            
        }

        private void cmbAppointmentDepartmentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int deparmentId;

            bool isCheckt = int.TryParse(cmbAppointmentDepartmentName.SelectedValue.ToString(), out deparmentId);
            if (isCheckt)
            {

                cmbAppointmentPolyclinicName.DataSource = polyclinicController.GetPolyclinic(deparmentId);
                cmbAppointmentPolyclinicName.DisplayMember = "PolyclinicName";
                cmbAppointmentPolyclinicName.ValueMember = "PolyclinicId";
            }

            if (cmbAppointmentPolyclinicName.SelectedValue == null)
            {
                btnDoctorsPolyclinicQuery.Enabled = false;
            }
            else
            {
                btnDoctorsPolyclinicQuery.Enabled = true;
            }
        }
        private void btnDoctorsDepartmantQuery_Click(object sender, EventArgs e)
        {
            int selectedDepartmantId = Convert.ToInt32(cmbAppointmentDepartmentName.SelectedValue);
            
            dgvDoctorList.DataSource = doctorController.GetDoctorsDepartmanId(selectedDepartmantId);
            dgvDoctorList.Columns["DoctorId"].Visible = false;
            dgvDoctorList.Columns["PolyclinicId"].Visible = false;
            dgvDoctorList.Columns["DepartmentId"].Visible = false;

        }

        private void btnDoctorsPolyclinicQuery_Click(object sender, EventArgs e)
        {
            int selectedDepartmantId = Convert.ToInt32(cmbAppointmentDepartmentName.SelectedValue);
            int selectedpolyclinictId = Convert.ToInt32(cmbAppointmentPolyclinicName.SelectedValue);           
            dgvDoctorList.DataSource = doctorController.GetDoctorsDepartmanIdAndPolyclinicId(selectedDepartmantId, selectedpolyclinictId);
            dgvDoctorList.Columns["DoctorId"].Visible = false;
            dgvDoctorList.Columns["PolyclinicId"].Visible = false;
            dgvDoctorList.Columns["DepartmentId"].Visible = false;
        }

        private void btnComplateAppointment_Click(object sender, EventArgs e)
        {
            
           bool result = appointmentController.AddAppointment(session, patient);
            if (result)
            {
                MessageBox.Show("kayıt başarılı");
                pnlAnAppointmentInfos.Visible = false;
            }
            else
            {
                MessageBox.Show("kayıt başarısız!!!!");
            }
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {

            
            int sessionId = Convert.ToInt32(dgvGetAllAppointments.CurrentRow.Cells["SessionId"].Value.ToString());
            
            DateTime dateControl = Convert.ToDateTime(dgvGetAllAppointments.CurrentRow.Cells["TARİH"].Value.ToString());
            if(dateControl < DateTime.Today)
            {
                MessageBox.Show("Geçmişini Silemezsin...");
            }
            else
            {
                bool result = appointmentController.DeletePatientAppointment(sessionId, patient.PatientId);
                if (result)
                {
                    MessageBox.Show("Silme işlemi başarılı");
                    dgvGetAllAppointments.DataSource = appointmentController.GetPatientAppointmentHistory(patient.PatientId);
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız!!!!");
                }
            }
            
            
        }
    }
}
