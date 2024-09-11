using DataLayerDVLD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerDVLD
{
    public class clsTestsAppointments
    {
        public static DataTable GetAllLdLAppIdTestsAppointments(int LdlAppId,int TestTypeId)
        {
            return clsDataTestsAppointments.GetAllTestAppointments(LdlAppId,TestTypeId);
        }

        public static bool AddNewAppointment(int TestTypeID, int LdlAppID, DateTime AppointmentDate, decimal paidFees,
            int CreatedByUserID, byte IsLocked)
        {
           if( clsDataTestsAppointments.AddNewAppointment(TestTypeID, LdlAppID, AppointmentDate, paidFees,
                CreatedByUserID, IsLocked))
            {
                return true;
            }
           return false;
        }

        public static bool UpdateAppointmentDate(int AppointmentId , DateTime NewAppointmentDate)
        {
            return clsDataTestsAppointments.UpdateAppointmentDate(AppointmentId , NewAppointmentDate);
        }

        public static bool IsLastTestAppointmentLocked(int LdlAppID, int TestTypeID)
        {
           return clsDataTestsAppointments.IsLastTestAppointmentLocked(LdlAppID, TestTypeID);
        }

  
    }
}
