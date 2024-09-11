using DataLayerDVLD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerDVLD
{
    public class clsDetainLicense
    {
        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsDataDetainLicense.IsLicenseDetained(LicenseID);
        }
        
    }
}
