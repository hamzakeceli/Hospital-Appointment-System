using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRecordingSystem.Entities
{
    public class Appointment
    {
        public int RendezvousId { get; set; }
        public int SessionId { get; set; }
        public int PatientId { get; set; }
    }
}
