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
    public partial class FormAdminPanel : Form
    {
        public FormAdminPanel()
        {
            InitializeComponent();
        }

        DepartmentController departmentController = new DepartmentController();
        HospitalController hospitalController = new HospitalController();
        PolyclinicController polyclinicsController = new PolyclinicController();
        DoctorController doctorController = new DoctorController();
        PharmacistController pharmacistController = new PharmacistController();
        private void FormAdminPanel_Load(object sender, EventArgs e)
        {
            cmbDoctorSignUpDepartment.DataSource = departmentController.GetDepartment();
            cmbDoctorSignUpDepartment.DisplayMember = "DepartmentName";
            cmbDoctorSignUpDepartment.ValueMember = "DepartmentId";

            cmbDoctorSignUpHospital.DataSource = hospitalController.GetHospital();
            cmbDoctorSignUpHospital.DisplayMember = "HospitalName";
            cmbDoctorSignUpHospital.ValueMember = "HospitalId";

        }

        private void btnSelectDoctorSignUp_Click(object sender, EventArgs e)
        {
            pnlDoctorSignUp.Visible = true;
            pnlPharmacistSignUp.Visible = false;
        }

        private void btnSelectPharmacistSignUp_Click(object sender, EventArgs e)
        {
            pnlDoctorSignUp.Visible = false;
            pnlPharmacistSignUp.Visible = true;
        }

        private void btnPharmacistSignUp_Click(object sender, EventArgs e)
        {
            Pharmacist pharmacist =  new Pharmacist
            {
                PharmacistFirstName = txtPharmacistSignUpName.Text,
                PharmacistLastName = txtPharmacistSignUpSurname.Text,
                PharmacistEmail = txtPharmacistSignUpEmail.Text,
                PharmacistPassword = txtPharmacistSignUpPassword.Text
            };

            if (pharmacistController.isNullPatient(pharmacist))
            {
                MessageBox.Show("Ad ve Soyad alanı boş geçilemez");
            }
            else if (!pharmacistController.SignUpControl(pharmacist))
            {
                MessageBox.Show("Email biçimi geçersiz");
            }
            else if (!pharmacistController.PasswordLengthControl(pharmacist))
            {
                MessageBox.Show("Parolanız 8-16 Karakter uzunluğunda olmalı. Özel karakter içermemeli !");
            }
            else
            {
                if (pharmacistController.IsExistsPatientEmail(pharmacist))
                {
                    if (pharmacistController.AddPharmacist(pharmacist))
                    {
                        MessageBox.Show("Kayıt başarılıdır.");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt başarısız.");
                    }
                }
                else
                {
                    MessageBox.Show("Kayıtlı email hesabı.");
                }
            }
        }

        private void btnDoctorSignUp_Click(object sender, EventArgs e)
        {
            string selectedDepartmantId;
            string selectedPolyclinicId;
            int Polynclinic;

            Doctor doctor = new Doctor();
            if (cmbDoctorSignUpDepartment.SelectedValue == null)
            {
                MessageBox.Show("Departman Boş geçilemez");
            }
            else
            {
                selectedDepartmantId = cmbDoctorSignUpDepartment.SelectedValue.ToString();
                if (cmbDoctorSignUpPolyclinic.SelectedValue == null)
                {
                    doctor.PolyclinicId = null;
                }
                else
                {
                    selectedPolyclinicId = cmbDoctorSignUpPolyclinic.SelectedValue.ToString();
                    doctor.PolyclinicId = Convert.ToInt32(selectedPolyclinicId);
                }


                doctor.DoctorFirstName = txtDoctorSignUpName.Text;
                doctor.DoctortLastName = txtDoctorSignUpSurname.Text;
                doctor.DoctorEmail = txtDoctorignUpEmail.Text;
                doctor.DoctorPassword = txtDoctorSignUpPassword.Text;
                
                doctor.DepartmentId = Convert.ToInt32(selectedDepartmantId);


            }

            if (doctorController.isNullPatient(doctor))
            {
                MessageBox.Show("Ad ve Soyad alanı boş geçilemez");
            }
            else if (!doctorController.SignUpControl(doctor))
            {
                MessageBox.Show("Email biçimi geçersiz");
            }
            else if (!doctorController.PasswordLengthControl(doctor))
            {
                MessageBox.Show("Parolanız 8-16 Karakter uzunluğunda olmalı. Özel karakter içermemeli !");
            }
            else
            {
                if (doctorController.IsExistsPatientEmail(doctor))
                {
                    if (doctorController.AddDoctor(doctor))
                    {
                        MessageBox.Show("Kayıt başarılıdır.");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt başarısız.");
                    }
                }
                else
                {
                    MessageBox.Show("Kayıtlı email hesabı.");
                }
            }




        }

        private void cmbDoctorSignUpPolyclinic_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbDoctorSignUpDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(cmbDoctorSignUpDepartment.SelectedValue.ToString());
            int deparmentId;
                
           bool isCheckt = int.TryParse(cmbDoctorSignUpDepartment.SelectedValue.ToString(),out deparmentId);
            if (isCheckt)
            {
                cmbDoctorSignUpPolyclinic.DataSource = polyclinicsController.GetPolyclinic(deparmentId);
                cmbDoctorSignUpPolyclinic.DisplayMember = "PolyclinicName";
                cmbDoctorSignUpPolyclinic.ValueMember = "PolyclinicId";
               
            }
          
        }
    }
}
