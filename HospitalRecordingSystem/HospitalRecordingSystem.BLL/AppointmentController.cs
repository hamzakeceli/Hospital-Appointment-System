using HospitalRecordingSystem.DAL;
using HospitalRecordingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRecordingSystem.BLL
{
    public class AppointmentController
    {
        AppointmentManagement appointmentManagement = new AppointmentManagement();

        //public List<AppointmentTime> GetAllAppointmentsTimes()
        //{
        //    return appointmentManagement.GetAllAppointmentsTimes();
        //}

        public DataTable GetPatientAppointmentHistory(int patientId)
        {

            return appointmentManagement.GetPatientAppointmentHistory(patientId);
        }


        public bool AddAppointment(Session session, Patient patient)
        {
            if (appointmentManagement.AddCompleteAppointment(session,patient))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeletePatientAppointment(int sessionId,int patientId)
        {
            if (appointmentManagement.DeletePatientAppointment(sessionId, patientId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable GetAllAppointmentsTimes()
        {

            return appointmentManagement.GetAllAppointmentsTimes();
        }

        public List<Session> GetAllSessions(int DoctorId)
        {
            return appointmentManagement.GetAllSessions(DoctorId);
        }

        public List<Session> GetDoctorSessions(int DoctorId, DateTime SessionDate)
        {
            return appointmentManagement.GetDoctorAppointmentTimeId(DoctorId, SessionDate);
        }

        public Session GetPatientCurrentSession(Session session)
        {
            return session;
        }

    }
}
