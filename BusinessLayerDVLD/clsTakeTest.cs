using DataLayerDVLD;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerDVLD
{
    public class clsTakeTest
    {
        public static decimal TestAppointmentFees(int AppointmenTest)
        {
            return clsDataTakeTest.GetTestAppointmentFees(AppointmenTest);
        }

        public static int TakeTest(int TestAppointmentID, byte TestResult, string Notes, int CreatedByUserID)
        {
            return clsDataTakeTest.TakeTest(TestAppointmentID, TestResult,Notes,CreatedByUserID);
        }
        
        public static int LastTestResult(int LdlAppID, int TestTypeID)
        {
            return clsDataTakeTest.GetLastTestResult(LdlAppID, TestTypeID);
        }
    }
}
