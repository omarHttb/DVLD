using DataLayerDVLD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessLayerDVLD
{
    public class clsInternationalLicense
    {

        public int DriverID { get; set; }
        public DateTime IssueDate {  get; set; }
        public DateTime ExpirationDate {  get; set; }
        public bool IsActive { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int CreatedByID { get; set; }

        public clsInternationalLicense(int driverID,DateTime issueDate,DateTime expirationDate,bool isActive,
            int issuedUsingLocalLicenseID,int applicationID, int createdByID)
        {
            DriverID = driverID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            ApplicationID = applicationID;
            CreatedByID = createdByID;

        }
        public clsInternationalLicense() { }

        public static int AddNewInternationalLicense(int ApplicationID, int DriverID,
            int LocalLicenseId,
            DateTime IssueDate, DateTime ExpirationDate, bool isActive, int CreatedByUserID)
        {
            return clsDataInternationalLicense.AddNewInternationalLicense(ApplicationID, DriverID, 
                LocalLicenseId,IssueDate, ExpirationDate, isActive, CreatedByUserID);
        }
        public static bool IsInternationalLicenseActiveOrAvailable(int LicenseId)
        {
            return clsDataInternationalLicense.IsInternationalLicenseActiveOrAvailable(LicenseId);
        }

        public static clsInternationalLicense FindInternationalLicenseInfoByInternationalLicenseID(int InternationalLicenseID)
        {
            //int InternationalLicenseID, ref int DriverID,
            //ref DateTime IssueDate, ref DateTime ExpirationDate, ref int ApplicationID, ref int CreatedByID
            //, ref string IsActive, ref int IssuedUsingLocalLicenseID
            int DriverID = -1, ApplicationID = -1, IssuedUsingLocalLicenseID = -1,createdByID = -1;
            DateTime IssueDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;
            bool IsActive = false;

            if (clsDataInternationalLicense.GetPersonInternationalLicenseByInternationalLicenseID(InternationalLicenseID, ref DriverID,
                ref IssueDate, ref ExpirationDate, ref ApplicationID, ref IsActive, ref IssuedUsingLocalLicenseID,ref createdByID))
                return new clsInternationalLicense(DriverID, IssueDate, ExpirationDate, IsActive, IssuedUsingLocalLicenseID, 
                    ApplicationID, createdByID); 
            else
                return null;

        }
        public static DataTable GetAllPersonInternationalLicense(int PersonID)
        {

            return clsDataInternationalLicense.GetAllPersonInternationalLicense(PersonID);
        }

        public static DataTable GetAllInternationalLicense()
        {
            return clsDataInternationalLicense.GetAllInternationalLicense();    
        }

        public static DataTable GetFilteredResult(string FilterSetting, string FilterTxt)
        {
            switch (FilterSetting)
            {
                case "InternationalLicenseID":
                    return clsDataInternationalLicense.GetFilteredInternationalLicenseID(FilterTxt);

                case "DriverID":
                    return clsDataInternationalLicense.GetFilteredInternationalDriverID(FilterTxt);

                case "LocalLicenseID":
                    return clsDataInternationalLicense.GetFilteredInternationalLocalDrivingLicenseID(FilterTxt);

                case "ApplicationID":
                    return clsDataInternationalLicense.GetFilteredInternationalLicenseApplicationID(FilterTxt);
                default:
                    return null;
            }
        }
    }
}
