using DataLayerDVLD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessLayerDVLD
{
    public class clsApplications
    {
      public int LocalAppId { get; set; }
      public int ApplicationID {  get; set; }
      public int ApplicantPersonID { get; set; }
      public DateTime ApplicationDate { get; set; }
      public int ApplicationTypeID { get; set; }
      public byte ApplicationStatus { get; set; }
      public DateTime LastStatusDate { get; set; }
      public int CreatedUserById { get; set; }
      public decimal PaidFees { get; set; }
      
      
        public clsApplications(int ldlAppId,  int appId,  int applicationTypeId, int applicantPersonId, DateTime applicationDate,
          byte applicationStatus,  DateTime lastStatusDate,  decimal paidFees,  int createdByUserId)
        {
            LocalAppId = ldlAppId;
            ApplicationID = appId;
            ApplicationDate = applicationDate;
            ApplicationStatus = applicationStatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            ApplicationTypeID = applicationTypeId;
            CreatedUserById = createdByUserId;
            ApplicantPersonID = applicantPersonId;

        }
        public clsApplications()
        {
            LocalAppId = 0;
            ApplicationID = 0;
            ApplicationStatus = 0;
            ApplicantPersonID = 0;
            ApplicationDate = DateTime.MinValue;
            ApplicationTypeID = 0;
            CreatedUserById = 0;
            PaidFees  =0;
            LastStatusDate = DateTime.MinValue;

        }


        public static DataTable GetAllApplicationLicenseClass()
        {
            return clsDataApplications.GetAllApplicationLicenseClass();
        }

        private  bool AddApplication()
        {
            ApplicationID = clsDataApplications.AddApplication(ApplicantPersonID, ApplicationDate, ApplicationTypeID,
                ApplicationStatus, LastStatusDate, PaidFees, CreatedUserById);

            return ApplicationID != -1;
        }

        public bool Save()
        {
            if(AddApplication())
            {
                return true;
            }
            return false;
        }

        public static clsApplications GetApplicationBasicInfo(int LdlAppid)
        {
            int appId = 0, applicationTypeId = 0,  createdByUserId = 0 , ApplicantPersonId = 0;
            decimal PaidFees = 0;
            DateTime applicationDate = DateTime.MinValue, lastStatusDate = DateTime.MinValue;
            byte applicationStatus = 0;

            if (clsDataApplications.GetApplicationBasicInfo(LdlAppid, ref appId,ref applicationTypeId,ref ApplicantPersonId, ref applicationDate
                ,ref applicationStatus,ref lastStatusDate,ref PaidFees,ref createdByUserId))
            {
                return new clsApplications(LdlAppid, appId, applicationTypeId, ApplicantPersonId, applicationDate, applicationStatus
                    , lastStatusDate, PaidFees, createdByUserId);
            }
            else
                return null;
        }

 
    }
}
