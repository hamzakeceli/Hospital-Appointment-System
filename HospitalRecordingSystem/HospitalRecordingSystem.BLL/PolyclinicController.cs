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
    public class PolyclinicController
    {
        PolyclinicsManagement PolyclinicManagement = new PolyclinicsManagement();


            public DataTable GetPolyclinic(int departmentId)
            {
            
                return PolyclinicManagement.GetPolyclinic(departmentId);
            }

    //    public List<Polyclinic> GetPolyclinicList(int departmentId)
    //    {

    //        return PolyclinicManagement.GetPolyclinicList(departmentId);
    //    }

    }
}
