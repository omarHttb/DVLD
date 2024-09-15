using DataLayerDVLD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerDVLD
{
    public class clsLicenses
    {

        public int ApplicationID { get; set; }
        public int LicenseID {  get; set; }
        public int DriverID {  get; set; }
        public int LicenseClassID { get; set; }
        public DateTime IssueDate {  get; set; }
        public DateTime ExpirationDate {  get; set; }
        public string IsActive   {  get; set; }
        public string IssueReason {  get; set; }
        public string LicenseClass { get; set; }
        public string Notes { get; set; }

        public clsLicenses(int licenseID,int driverID,DateTime issueDate,DateTime expirationDate,
            string isActive,string issueReason,string licenseClass,string notes,int licenseClassID,int applicationID)
        {
            LicenseID = licenseID;
            DriverID = driverID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            IssueReason = issueReason;
            LicenseClass = licenseClass;
            Notes = notes;
            LicenseClassID = licenseClassID;
            ApplicationID = applicationID;
        }
        public clsLicenses() 
        {

            LicenseID = -1;
            DriverID = -1;
            IssueDate = DateTime.MinValue;
            ExpirationDate = DateTime.MinValue;
            IsActive = "";
            IssueReason = "";
            LicenseClass = "";
            Notes = "";
            LicenseID = -1;
        }

        public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate
            , DateTime ExpirationDate, string Notes, decimal PaidFees, bool isActive, byte IssueReason,
            int CreatedByUserID)
        {
            return clsDataLicenses.AddNewLicense(ApplicationID, DriverID, LicenseClass, IssueDate,
                ExpirationDate, Notes,PaidFees ,isActive,
                IssueReason, CreatedByUserID);
        }

        public static decimal GetLicenseClassFees(int LicensesClassID) 
        {
            return clsDataLicenses.GetLicenseClassFees(LicensesClassID);
        }

        public static clsLicenses FindLicenseInfoByPersonID(int PersonID)
        {

            int LicenseID = -1,DriverID = -1, LicenseClassID = -1, ApplicationID = -1;
            DateTime IssueDate = DateTime.MinValue,ExpirationDate = DateTime.MinValue;
            string IsActive = "", IssueReason = "",LicenseClass = "",Notes = "";

            if (clsDataLicenses.GetPersonLicenseByPersonID(PersonID, ref LicenseID, ref DriverID, ref IssueDate
                , ref ExpirationDate, ref Notes, ref IssueReason, ref IsActive, ref LicenseClass,ref LicenseClassID,ref ApplicationID)) 
                return new clsLicenses(LicenseID,DriverID,IssueDate,ExpirationDate, IsActive, IssueReason
                    ,LicenseClass,Notes,LicenseClassID, ApplicationID);
            else
                return null;

        }

        public static clsLicenses FindLicenseInfoByLicenseID(int LicenseID)
        {

            int  DriverID = -1, LicenseClassID = -1,ApplicationID = -1;
            DateTime IssueDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;
            string IsActive = "", IssueReason = "", LicenseClass = "", Notes = "";

            if (clsDataLicenses.GetPersonLicenseByLicenseID( LicenseID, ref DriverID, ref IssueDate
                , ref ExpirationDate, ref Notes, ref IssueReason, ref IsActive, ref LicenseClass,ref LicenseClassID,ref ApplicationID))
                return new clsLicenses(LicenseID, DriverID, IssueDate, ExpirationDate, IsActive, IssueReason
                    , LicenseClass, Notes, LicenseClassID, ApplicationID);
            else
                return null;

        }

        public static clsLicenses GetPersonLicenseByApplicationID(int ApplicationID)
        {

            int DriverID = -1, LicenseClassID = -1, LicenseID = -1;
            DateTime IssueDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;
            string IsActive = "", IssueReason = "", LicenseClass = "", Notes = "";

            if (clsDataLicenses.GetPersonLicenseByApplicationID(ApplicationID ,ref LicenseID, ref DriverID, ref IssueDate
                , ref ExpirationDate, ref Notes, ref IssueReason, ref IsActive, ref LicenseClass, ref LicenseClassID))
                return new clsLicenses(LicenseID, DriverID, IssueDate, ExpirationDate, IsActive, IssueReason
                    , LicenseClass, Notes, LicenseClassID, ApplicationID);
            else
                return null;

        }

        public static DataTable GetAllPersonLocalLicense(int PersonID)
        {

            return clsDataLicenses.GetAllPersonLocalLicense(PersonID);
        }
        
        public static bool SetLicenseActiveOrNot(int LicenseID, bool ActiveOrNot)
        {
            return clsDataLicenses.SetLicenseActiveOrNot(LicenseID, ActiveOrNot);

        }

    }
}
