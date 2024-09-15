using BusinessLayerDVLD;
using DVLD.License.Driver_License_Info;
using DVLD.User_Controls.LicenseInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.License.Replace_License_For_Lost_or_damaged
{
    public partial class frmReplaceLicenseLostOrDamaged : Form
    {
        public frmReplaceLicenseLostOrDamaged()
        {
            InitializeComponent();
        }
        private decimal ReplaceForDamagedFee = clsManageApplicationTypes.GetApplicationFees(4);
        private decimal ReplaceForLostFee = clsManageApplicationTypes.GetApplicationFees(3);

        clsApplications _clsApplications = new clsApplications();

        private void frmReplaceLicenseLostOrDamaged_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = DateTime.Now.ToString();
            lblCreatedByID.Text = GlobalProperties.LoggedInUserName;
            lblApplicationFees.Text = ReplaceForDamagedFee.ToString();
            llShowLicenssehistory.Enabled = false;
            llShowNewLicenseInfo.Enabled = false;
            btnIssueReplacement.Enabled = false;
            ucSearchForLicense1.LicenseFoundClick += LicenseFoundClick;


        }

        private void llShowLicenssehistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(ucSearchForLicense1.PersonId);
            frm.ShowDialog();
        }

        private void lblShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(ucSearchForLicense1.PersonId,int.Parse(lblLostOrDamagedAppID.Text));
            frm.ShowDialog();
        }
        private void LicenseFoundClick(object sender, EventArgs e)
        {
            if (ucSearchForLicense1.IsActive != "Active")
            {
                btnIssueReplacement.Enabled = false;
                llShowLicenssehistory.Enabled= true;
                lblOldLicenseID.Text = ucSearchForLicense1.LicenseID.ToString();


            }
            else
            {
                btnIssueReplacement.Enabled = true;
            }

        }

        private void RbDamaged_CheckedChanged(object sender, EventArgs e)
        {
            lblApplicationFees.Text = ReplaceForDamagedFee.ToString();
        }

        private void RbLost_CheckedChanged(object sender, EventArgs e)
        {
            lblApplicationFees.Text = ReplaceForLostFee.ToString();    
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        byte IssueReason()
        {
            if(RbDamaged.Checked)
            {
                return 3;
            }
            else if (RbLost.Checked)
            {
                return 4;
            }
            return 3;
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
             _clsApplications.ApplicantPersonID = ucSearchForLicense1.PersonId;
             _clsApplications.ApplicationDate = DateTime.Now;
             
             if(RbLost.Checked)
             {
                 _clsApplications.ApplicationTypeID = 3;
             }
             else if(RbDamaged.Checked)
             {
                 _clsApplications.ApplicationTypeID = 4;
             }
             _clsApplications.ApplicationStatus = 3;
             _clsApplications.LastStatusDate = DateTime.Now;
             _clsApplications.PaidFees = Convert.ToDecimal(lblApplicationFees.Text);
             _clsApplications.CreatedUserById = GlobalProperties.LoggedInUserID;
             _clsApplications.Save();
             
             
             lblLostOrDamagedAppID.Text = _clsApplications.ApplicationID.ToString();
             clsLicenses.SetLicenseActiveOrNot(Convert.ToInt32(lblOldLicenseID.Text), false);
             
             lblReplacedLicenseID.Text = clsLicenses.AddNewLicense(_clsApplications.ApplicationID, ucSearchForLicense1.DriverID, ucSearchForLicense1.LicenseClassID,
                 DateTime.Now, ucSearchForLicense1.ExpirationDate, ucSearchForLicense1.Notes, Convert.ToDecimal(lblApplicationFees.Text), true, IssueReason()
               , GlobalProperties.LoggedInUserID).ToString();
             
             MessageBox.Show("License Replaced Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
             btnIssueReplacement.Enabled = false;
             
             llShowNewLicenseInfo.Enabled = true;
             llShowLicenssehistory.Enabled = true;
        }
    }
}
