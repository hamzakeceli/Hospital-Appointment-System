using HospitalRecordingSystem.DAL;
using HospitalRecordingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace HospitalRecordingSystem.BLL
{
    public class MemberController
    {
       
        MemberManagement memberManagement = new MemberManagement(); 
        
        public bool GetMemberControl(Member member)
        {
          Member user = memberManagement.GetMember(member.MemberEmail);
         

           if(user.MemberEmail == member.MemberEmail && user.MemberPassword == member.MemberPassword)
           {
                return true;
           }
           else
           {
                return false;
           }
        }

       
        public int GetMemberRoleId(Member member)
        {
            Member user = memberManagement.GetMember(member.MemberEmail);
            return user.RoleId;
        }


    }
}
