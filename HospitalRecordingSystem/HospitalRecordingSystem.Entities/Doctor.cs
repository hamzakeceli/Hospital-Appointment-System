using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRecordingSystem.Entities
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorFirstName { get; set; }
        public string DoctortLastName { get; set; }
        public string DoctorEmail { get; set; }
        public string DoctorPassword { get; set; }
        public int? PolyclinicId { get; set; }
        public int DepartmentId { get; set; }

    }
}
