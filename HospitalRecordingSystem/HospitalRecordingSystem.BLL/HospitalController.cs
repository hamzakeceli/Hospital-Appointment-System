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
    public class HospitalController
    {

        HospitalManagement hospitalManagement = new HospitalManagement();
        List<Hospital> hospitals;


        public DataTable GetHospital()
        {


            return hospitalManagement.GetHospital();
        }
    }
}
