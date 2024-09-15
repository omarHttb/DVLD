using BusinessLayerDVLD;
using DVLD.License.Driver_License_Info;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.License.Renew_Local_Driving_License
{
    public partial class frmRenewLocalDrivingLicense : Form
    {
        clsApplications _clsApplications = new clsApplications();
        clsLicenses _clsLicenses = new clsLicenses();
        public frmRenewLocalDrivingLicense()
        {
            InitializeComponent();
            LLlicenseInfo.Enabled = false;
            LLShowLicenseHistory.Enabled = false;
            ucSearchForLicense1.LicenseFoundClick += LicenseFoundClick;

        }

        private void LLShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           frmLicenseHistory frm = new frmLicenseHistory(ucSearchForLicense1.PersonId);
            frm.ShowDialog();
        }

        private void LLlicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(ucSearchForLicense1.PersonId,int.Parse( lblRenewLocalLicenseApplication.Text));
            frm.ShowDialog();
        }

        private void ucSearchForLicense1_Load(object sender, EventArgs e)
        {
            lblAppDate.Text = DateTime.Now.ToString();
            lblIssueDate.Text = DateTime.Now.ToString();
            lblExpirationDate.Text = DateTime.Now.AddYears(10).ToString();
            lblCreatedBy.Text = GlobalProperties.LoggedInUserName;
            lblApplicationFees.Text = clsManageApplicationTypes.GetApplicationFees(2).ToString();
            //lblApplicationFees.Text = clsLicenses.GetLicenseClassFees().ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsExpirationDateBeforeCurrentDate()
        {
            if (ucSearchForLicense1.ExpirationDate > DateTime.Now)
            {
                MessageBox.Show("This License is not expired yet,\n it will expire on: "+ucSearchForLicense1.ExpirationDate
                    
                   , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void LicenseFoundClick(object sender, EventArgs e)
        {
            if(IsExpirationDateBeforeCurrentDate())
            {
                btnRenew.Enabled = false;

            }
            else
            {
                btnRenew.Enabled = true;
            }

            LLShowLicenseHistory.Enabled = true;
            lblLicenseFees.Text = clsLicenses.GetLicenseClassFees(ucSearchForLicense1.LicenseClassID).ToString();
            lblTotalFees.Text = (Convert.ToDecimal(lblApplicationFees.Text)+ Convert.ToDecimal(lblLicenseFees.Text)).ToString();
            lblOldLicenseID.Text = ucSearchForLicense1.LicenseID.ToString();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            _clsApplications.ApplicantPersonID = ucSearchForLicense1.PersonId;
            _clsApplications.ApplicationDate = DateTime.Now;
            _clsApplications.ApplicationTypeID = 2;
            _clsApplications.ApplicationStatus = 3;
            _clsApplications.LastStatusDate = DateTime.Now;
            _clsApplications.PaidFees = Convert.ToDecimal(lblTotalFees.Text);
            _clsApplications.CreatedUserById = GlobalProperties.LoggedInUserID;
            _clsApplications.Save();
            lblRenewLocalLicenseApplication.Text = _clsApplications.ApplicationID.ToString();

            clsLicenses.SetLicenseActiveOrNot(Convert.ToInt32( lblOldLicenseID.Text),false);

           lblRenewedLicenseID.Text =  clsLicenses.AddNewLicense(_clsApplications.ApplicationID, ucSearchForLicense1.DriverID,
                ucSearchForLicense1.LicenseClassID, DateTime.Now, DateTime.Now.AddYears(10).Date, TxtNotes.Text,
                Convert.ToDecimal(lblTotalFees.Text), true, 2, GlobalProperties.LoggedInUserID).ToString();
            MessageBox.Show("License Renewed Successfully " 

                                ,"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRenew.Enabled = false;   

            LLlicenseInfo.Enabled = true;

        }
    }
}
