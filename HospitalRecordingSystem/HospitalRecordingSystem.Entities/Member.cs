using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRecordingSystem.Entities
{
    public class Member
    {
        public int RoleId { get; set; }
        public string MemberEmail { get; set; }
        public string MemberPassword { get; set; }
    }
}
