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
      public int ApplicationID {  get; set; }
      public int ApplicantPersonID { get; set; }
      public DateTime ApplicationDate { get; set; }
      public int ApplicationTypeID { get; set; }
      public int ApplicationStatus { get; set; }
      public DateTime LastStatusDate { get; set; }
      public int CreatedById { get; set; }
      public decimal PaidFees { get; set; }
      
        


        public static DataTable GetAllApplicationLicenseClass()
        {
            return clsDataApplications.GetAllApplicationLicenseClass();
        }

        private  bool AddApplication()
        {
            ApplicationID = clsDataApplications.AddApplication(ApplicantPersonID, ApplicationDate, ApplicationTypeID,
                ApplicationStatus, LastStatusDate, PaidFees, CreatedById);

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

 
    }
}
