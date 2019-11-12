﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRecordingSystem.Entities
{
    public class Session
    {
        public int SessionId { get; set; }
        public int RendezvousTimeId { get; set; }
        public int DoctorId { get; set; }
        public DateTime SessionDate { get; set; }
    }
}
