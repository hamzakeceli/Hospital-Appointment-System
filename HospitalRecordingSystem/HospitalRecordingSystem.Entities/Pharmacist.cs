using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRecordingSystem.Entities
{
    public class Pharmacist
    {
        public int PharmacistId { get; set; }
        public string PharmacistFirstName { get; set; }
        public string PharmacistLastName { get; set; }
        public string PharmacistEmail { get; set; }
        public string PharmacistPassword { get; set; }
    }
}
