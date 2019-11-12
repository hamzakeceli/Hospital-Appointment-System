using HospitalRecordingSystem.DAL;
using HospitalRecordingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HospitalRecordingSystem.BLL
{
    public class DoctorController
    {
        DoctorManagement doctorManagement = new DoctorManagement();

        public Doctor GetDoctor(Member member)
        {
            return doctorManagement.GetDoctor(member);
        }

        public DataTable GetDoctorsDepartmanId(int departmanId)
        {
            return doctorManagement.GetDoctors(departmanId);
        }

        public DataTable GetDoctorsDepartmanIdAndPolyclinicId(int departmanId,int polyclinicId)
        {
            return doctorManagement.GetDoctors(departmanId, polyclinicId);
        }

        public bool IsExistsPatientEmail(Doctor doctor)
        {

            if (doctorManagement.IsExistsMemberEmail(doctor))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddDoctor(Doctor doctor)
        {
            if (doctorManagement.AddDoctor(doctor))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SignUpControl(Doctor doctor)
        {

            try
            {
                MailAddress mainFormat = new MailAddress(doctor.DoctorEmail);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool PasswordLengthControl(Doctor doctor)
        {
            var regexItem = new Regex("^[a-zA-Z0-9_-]{8,16}$");

            if (regexItem.IsMatch(doctor.DoctorPassword))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isNullPatient(Doctor doctor)
        {
            if (!string.IsNullOrWhiteSpace(doctor.DoctorFirstName) && !string.IsNullOrWhiteSpace(doctor.DoctortLastName))
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
