using HospitalRecordingSystem.DAL;
using HospitalRecordingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HospitalRecordingSystem.BLL
{
    public class PharmacistController
    {
        PharmacistManagement pharmacistManagement = new PharmacistManagement();
        public bool IsExistsPatientEmail(Pharmacist pharmacist)
        {

            if (pharmacistManagement.IsExistsMemberEmail(pharmacist))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddPharmacist(Pharmacist pharmacist)
        {
            if (pharmacistManagement.AddPharmacist(pharmacist))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SignUpControl(Pharmacist pharmacist)
        {

            try
            {
                MailAddress mainFormat = new MailAddress(pharmacist.PharmacistEmail);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool PasswordLengthControl(Pharmacist pharmacist)
        {
            var regexItem = new Regex("^[a-zA-Z0-9_-]{8,16}$");

            if (regexItem.IsMatch(pharmacist.PharmacistPassword))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isNullPatient(Pharmacist pharmacist)
        {
            if (!string.IsNullOrWhiteSpace(pharmacist.PharmacistFirstName) && !string.IsNullOrWhiteSpace(pharmacist.PharmacistLastName))
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
