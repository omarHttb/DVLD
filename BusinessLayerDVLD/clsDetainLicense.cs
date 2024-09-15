using DataLayerDVLD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerDVLD
{
    public class clsDetainLicense
    {
        public DateTime DetainDate { get; set; }
        public int DetainID { get; set; }
        public int CreatedById { get; set; }
        public decimal FineFees { get; set; }

        public clsDetainLicense(DateTime detainDate,int detainID,int createdById,decimal fineFees)
        {
            DetainDate = detainDate;
            DetainID = detainID;
            CreatedById = createdById;
            FineFees = fineFees;
        }
        public clsDetainLicense() 
        {
            DetainDate = DateTime.MinValue;
            DetainID = -1;
            CreatedById = -1;
            FineFees = -1;
        }


        public static bool IsLicenseNotDetained(int LicenseID)
        {
            return clsDataDetainLicense.IsLicenseNotDetained(LicenseID);
        }

        public static int DetainNewLicense(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByID, bool IsReleased)
        {
            return clsDataDetainLicense.DetainNewLicense(LicenseID, DetainDate, FineFees, CreatedByID, IsReleased);
        }

        public static decimal GetFineFees(int LicenseID)
        {
            return clsDataDetainLicense.GetFineFees(LicenseID);
        }


        public static clsDetainLicense FindPersonDetainedLicenseInfo(int LicenseID)
        {
            DateTime DetainDate = DateTime.MinValue;
            int DetainID = -1 ,createdByID = -1;
            decimal FineFees = -1;


            if(clsDataDetainLicense.GetDetainedLicenseDetails(LicenseID,ref DetainDate,ref DetainID,ref createdByID,ref FineFees))
            {
                return new clsDetainLicense(DetainDate, DetainID, createdByID, FineFees);
            }
            else
                return null;

        }

        public static bool ReleaseDetainedLicenses(int LicenseID, int ReleaseApplicationID, int UserID, DateTime ReleaseDate)
        {
          return clsDataDetainLicense.ReleaseDetainedLicense(LicenseID, ReleaseApplicationID, UserID, ReleaseDate);
        }


        public static DataTable GetAllDetainedLicenses()
        {
            return clsDataDetainLicense.GetAllDetainedLicenses();
        }

        public static DataTable GetFilteredResult(string FilterSetting, string FilterTxt)
        {
            switch (FilterSetting)
            {
                case "DetainID":
                    return clsDataDetainLicense.GetFilteredDetainID(int.Parse(FilterTxt));

                case "National No":
                    return clsDataDetainLicense.GetFilteredNationalNo(FilterTxt);

                case "FullName":
                    return clsDataDetainLicense.GetFilteredFullName(FilterTxt);

                case "Release Application ID":
                    return clsDataDetainLicense.GetFilteredReleaseApplication(int.Parse(FilterTxt));
                case "IsReleased":
                    return clsDataDetainLicense.GetFilteredReleased();
                case "IsDetained":
                    return clsDataDetainLicense.GetFilteredDetained();
                default:
                    return null;
            }
        }
    }
}
