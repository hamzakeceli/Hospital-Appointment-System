using System;
using HospitalRecordingSystem.DAL;
using HospitalRecordingSystem.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace HospitalRecordingSystem.BLL
{
    
    public class PatientController
    {
        PatientManagement patientManagement = new PatientManagement();

        public Patient GetPatient(Member member)
        {
            return patientManagement.GetPatient(member);
        }

        public bool IsExistsPatientEmail(Patient patient)
        {

            if (patientManagement.IsExistsMemberEmail(patient))
            {
                return true;
            }
            else
            {
                return false;
            }   
         }


        public bool AddPatient(Patient patient)
        {
            if (patientManagement.AddPatient(patient))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SignUpControl(Patient patient)
        {

            try
            {
                MailAddress mainFormat = new MailAddress(patient.PatientEmail);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool PasswordLengthControl(Patient patient)
        {
            var regexItem = new Regex("^[a-zA-Z0-9_-]{8,16}$");

            if (regexItem.IsMatch(patient.PatientPassword)) {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isNullPatient (Patient patient)
        {
            if(!string.IsNullOrWhiteSpace(patient.PatientFirstName) && !string.IsNullOrWhiteSpace(patient.PatientLastName))
            {
                return false;
            }
            else
            {
                return true;
            }         
        }

    }





}

