using DataLayerDVLD;
using System;
using System.Collections.Generic;
using System.Data;
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
        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsDataLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();//GO
        }


        // Get  filtered result from Local driving license table view
        public static DataTable GetFilteredResultLDL(string FilterSetting, string FilterTxt)
        {
            switch (FilterSetting)
            {
                case "LdlAppId":
                    return clsDataLocalDrivingLicenseApplication.GetLDlAppPersonAppID(FilterTxt);

                case "NationalNo":
                    return clsDataLocalDrivingLicenseApplication.GetLDlAppPersonNationalNO(FilterTxt);

                case "FullName":
                    return clsDataLocalDrivingLicenseApplication.GetLDLAppPersonFullName(FilterTxt);
                case "Completed":
                case "Cancelled":
                case "New":              
                    // code above mean Complted or cancalled or new 
                    return clsDataLocalDrivingLicenseApplication.GetLDLAppPersonStatus(FilterTxt);
                default:
                    return null;
            }
        }

        public static bool CancelLocalDrivingLiceseApplication(int LLdAppId )
        {
            if (clsDataLocalDrivingLicenseApplication.CancelLocalDrivingLicenseApplication(LLdAppId,DateTime.Now))
                return true;
            else
                return false;
        }

        public static byte IsPersonApplicationCanceled(int PersonID, int LicenseClassID)
        {
            return clsDataLocalDrivingLicenseApplication.IsPersonApplicationCanceled(PersonID, LicenseClassID);
        }

        public static int GetLicenseClassFromLLdAppId(int LdAppId) 
        {
            return clsDataLocalDrivingLicenseApplication.GetLicenseClassFromLLDAppId(LdAppId);
        }
     
    }
}
