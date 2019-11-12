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
    public class ExaminationController
    {
        ExaminationManagement examinationManagement = new ExaminationManagement();

        public Patient GetPatient(int rendezvousTimeId, int doctorId, DateTime date)
        {
            return examinationManagement.GetPatient(rendezvousTimeId, doctorId, date);
        }
        public DataTable GetAllDiognosis()
        {
            return examinationManagement.GetAllDiognosis();
        }
        public int GetSessionId(int rendezvousTimeId, int doctorId, DateTime date)
        {
            return examinationManagement.GetSessionId(rendezvousTimeId, doctorId, date);
        }
        public bool AddExamination(int sessionId, int patientId, int diognosisId, int recipeId, int exaStatus)
        {
            return examinationManagement.AddExamination(sessionId, patientId, diognosisId, recipeId, exaStatus);
        }
        public bool AddExaminationAddExaminationForExaStatuZero(int sessionId, int patientId, int diognosisId,int exaStatus)
        {
            return examinationManagement.AddExaminationForExaStatuZero(sessionId, patientId, diognosisId,exaStatus);
        }
        public DataTable GetAllCompleteExaminations(int doctorId)
        {
            return examinationManagement.GetAllCompleteExaminations(doctorId);
        }
        public List<int> GetRendezvousTimeIdForExamination(int doctorId,DateTime date)
        {
            return examinationManagement.GetRendezvousTimeIdForExamination(doctorId, date);
        }

    }
}
