using DataLayerDVLD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerDVLD
{
    public class clsLocalDrivingLicenseApplication
    {
        public int LocalLicensesID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }    
        public bool IsUpdateMode { get; set; }

        private  bool _AddLocalDrivingLicenseApplication()
        {
            LocalLicensesID = clsDataLocalDrivingLicenseApplication.AddLocalDrivingLicenseApplication(ApplicationID, LicenseClassID); 
            return LocalLicensesID != -1;
        }

        private bool _UpdateLocalDrivingLicensesClass()
        {
            if(clsDataLocalDrivingLicenseApplication.UpdateLocalDrivingLicensesClass(LocalLicensesID, LicenseClassID))
                return true;
                else
                return false;
        }

        public bool Save()
        {
            switch (IsUpdateMode)
            {
                case false:
                    if (_AddLocalDrivingLicenseApplication())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case true:
                    if(_UpdateLocalDrivingLicensesClass())
                        return true;
                    else
                    {
                        return false;
                    }
            }
            return false;
        }

        public static bool DoesPersonHaveActiveLocalApplicationWithSameLicenseClass(int PersonID,int LicensesClassID)
        {
            if(clsDataLocalDrivingLicenseApplication.DoesPersonHaveActiveLocalApplicationWithSameLicenseClass(
                PersonID, LicensesClassID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
