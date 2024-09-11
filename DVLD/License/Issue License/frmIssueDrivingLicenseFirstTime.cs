using BusinessLayerDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.License
{
    public partial class frmIssueDrivingLicenseFirstTime : Form
    {
        string NationalNumber = "";
        public frmIssueDrivingLicenseFirstTime(int ldlAppId, string LicenseClass, int PassedTest, string FullName
            ,string nationalNumber)
        {
            InitializeComponent();
            ucApplicationInfo1.LdlAppId = ldlAppId;
            ucApplicationInfo1.LicenseClass = LicenseClass;
            ucApplicationInfo1.PassedTest = PassedTest;
            ucApplicationInfo1.FullName = FullName;
            NationalNumber = nationalNumber;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
          
            int PersonID = clsPeople.GetPersonIDByNationalNumber(NationalNumber);
            int LicenseClassID = clsLocalDrivingLicenseApplication.GetLicenseClassFromLLdAppId(ucApplicationInfo1.LdlAppId);
            decimal PaidFees = clsLicenses.GetLicenseClassFees(LicenseClassID);
            int driverID = clsDrivers.AddNewDriver(PersonID, GlobalProperties.LoggedInUserID, DateTime.Now);


            int LicenseID =  clsLicenses.AddNewLicense(ucApplicationInfo1.ApplicattionID,driverID,LicenseClassID,DateTime.Now,
                DateTime.Now.AddYears(10),txtNotes.Text,PaidFees,true,1,GlobalProperties.LoggedInUserID);

            MessageBox.Show("License Issued Successfully with LicenseID = " + LicenseID , "Success",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
            btnIssue.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
