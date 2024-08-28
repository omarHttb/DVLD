using DataLayerDVLD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerDVLD
{
    public class clsManageApplicationTypes
    {
        public static DataTable GetAllApplicationTypes()
        {
            return clsDataManageApplicationTypes.GetAllApplicationTypes();
        }

        public static bool UpdateApplicationType(int ApplicationTypeID,string ApplicationTypeTitle
            ,decimal ApplicationFees)
        {
            return clsDataManageApplicationTypes.UpdateApplicationType(ApplicationTypeID,
                ApplicationTypeTitle, ApplicationFees);
        }

        public static decimal GetApplicationFees(int ApplicationIdType)
        {
            return clsDataManageApplicationTypes.GetApplicationFees(ApplicationIdType);
        }

    }
}
