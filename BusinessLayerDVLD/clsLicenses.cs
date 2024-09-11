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

        
        public int LicenseID {  get; set; }
        public int DriverID {  get; set; }
        public DateTime IssueDate {  get; set; }
        public DateTime ExpirationDate {  get; set; }
        public string IsActive   {  get; set; }
        public string IssueReason {  get; set; }
        public string LicenseClass { get; set; }
        public string Notes { get; set; }

        public clsLicenses(int licenseID,int driverID,DateTime issueDate,DateTime expirationDate,
            string isActive,string issueReason,string licenseClass,string notes)
        {
            LicenseID = licenseID;
            DriverID = driverID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            IssueReason = issueReason;
            LicenseClass = licenseClass;
            Notes = notes;

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

            int LicenseID = -1,DriverID = -1;
            DateTime IssueDate = DateTime.MinValue,ExpirationDate = DateTime.MinValue;
            string IsActive = "", IssueReason = "",LicenseClass = "",Notes = "";

            if (clsDataLicenses.GetPersonLicenseByPersonID(PersonID, ref LicenseID, ref DriverID, ref IssueDate
                , ref ExpirationDate, ref Notes, ref IssueReason, ref IsActive, ref LicenseClass)) 
                return new clsLicenses(LicenseID,DriverID,IssueDate,ExpirationDate, IsActive, IssueReason
                    ,LicenseClass,Notes);
            else
                return null;

        }

        public static clsLicenses FindLicenseInfoByLicenseID(int LicenseID)
        {

            int  DriverID = -1;
            DateTime IssueDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;
            string IsActive = "", IssueReason = "", LicenseClass = "", Notes = "";

            if (clsDataLicenses.GetPersonLicenseByLicenseID( LicenseID, ref DriverID, ref IssueDate
                , ref ExpirationDate, ref Notes, ref IssueReason, ref IsActive, ref LicenseClass))
                return new clsLicenses(LicenseID, DriverID, IssueDate, ExpirationDate, IsActive, IssueReason
                    , LicenseClass, Notes);
            else
                return null;

        }


        public static DataTable GetAllPersonLocalLicense(int PersonID)
        {

            return clsDataLicenses.GetAllPersonLocalLicense(PersonID);
        }
        

    }
}
