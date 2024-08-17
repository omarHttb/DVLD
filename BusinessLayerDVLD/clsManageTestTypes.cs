using DataLayerDVLD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerDVLD
{
    public class clsManageTestTypes
    {
        public static DataTable GetAllTestTypes()
        {
            return clsDataManageTestTypes.GetAllTestTypes(); 
        }

        public static bool UpdateTestTypes(int TestTypeID, string TestTypeTitle, string TestTypeDescription,
             decimal TestTypeFees)
        {
            return clsDataManageTestTypes.UpdateTestType(TestTypeID, TestTypeTitle, TestTypeDescription,
                TestTypeFees);
        }
    }
}
