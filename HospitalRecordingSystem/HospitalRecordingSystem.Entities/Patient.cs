using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRecordingSystem.Entities
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string PatientEmail { get; set; }
        public string PatientPassword { get;set; }
    }
}
