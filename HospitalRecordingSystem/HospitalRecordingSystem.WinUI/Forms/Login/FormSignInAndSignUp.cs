using HospitalRecordingSystem.BLL;
using HospitalRecordingSystem.Entities;
using HospitalRecordingSystem.WinUI.Forms.DoctorForms;
using HospitalRecordingSystem.WinUI.Forms.PatientForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace HospitalRecordingSystem.WinUI.Forms
{
    public partial class FormSignInAndSignUp : Form
    {
        public FormSignInAndSignUp()
        {
            InitializeComponent();
        }
        
        MemberController memberController = new MemberController();
        PatientController patientController = new PatientController();
        private void FormSignInAndSignUp_Load(object sender, EventArgs e)
        {

        }
        private void btnSelectSıgnIn_Click(object sender, EventArgs e)
        {
            pnlSignUp.Visible = false;
            pnlSingIn.Visible = true;
        }
        private void btnSelectSignUp_Click(object sender, EventArgs e)
        {
            pnlSignUp.Visible = true;
            pnlSingIn.Visible = false;
        }

        

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            
            Member member = new Member
            {
                MemberEmail = txtSignInEmail.Text,
                MemberPassword = txtSignInPassword.Text                
            };

            int roleId  =  memberController.GetMemberRoleId(member);
            bool result =  memberController.GetMemberControl(member);

            if (result)
            {
                

                switch (roleId)
                {
                    case (int)EnumRoles.Admin:
                        {
                            FormAdminPanel formAdminPanel = new FormAdminPanel();
                            formAdminPanel.Show();
                        }break;
                        
                    case (int)EnumRoles.Doctor:
                        {
                            FormDoctorPanel formDoctorPanel = new FormDoctorPanel(member);
                            formDoctorPanel.Show();
                        }
                        break;
                    case (int)EnumRoles.Patient:
                        {
                            FormPatientPanel formPatientPanel = new FormPatientPanel(member);
                            formPatientPanel.Show();
                        }
                        break;
                    case (int)EnumRoles.Pharmacist:
                        {
                            FormPharmacistPanel formPharmacistPanel = new FormPharmacistPanel();
                            formPharmacistPanel.Show();
                        }
                        break;

                    default:
                        MessageBox.Show("Böyle bir kullanıcı kayıtlı değil!");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
           
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient
            {
                PatientFirstName = txtSignUpName.Text,
                PatientLastName = txtSignUpSurname.Text,
                PatientEmail = txtSignUpEmail.Text,
                PatientPassword = txtSignUpPassword.Text
            };

            if (patientController.isNullPatient(patient))
            {
                MessageBox.Show("Ad ve Soyad alanı boş geçilemez");
            }
            else if (!patientController.SignUpControl(patient))
            {
                MessageBox.Show("Email biçimi geçersiz");
            }
            else if (!patientController.PasswordLengthControl(patient))
            {
                MessageBox.Show("Parolanız 8-16 Karakter uzunluğunda olmalı. Özel karakter içermemeli !");
            }
            else
            {               
                if (patientController.IsExistsPatientEmail(patient))
                {
                    if (patientController.AddPatient(patient))
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
    }
}
