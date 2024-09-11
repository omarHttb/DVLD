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

namespace DVLD.License.International
{
    public partial class frmIssueInternationalLicense : Form
    {


        int InternationalLicenseID = -1;
        clsApplications _applications = new clsApplications();
        clsInternationalLicense _internationalLicense = new clsInternationalLicense();
        public frmIssueInternationalLicense()
        {
            InitializeComponent();
            lblAppDate.Text = DateTime.Now.ToString();
            lblInternationalIssueDate.Text = DateTime.Now.ToString();
            lblInternationalExpirationDate.Text = DateTime.Now.AddYears(1).ToString();
            lblCreatedBy.Text = GlobalProperties.LoggedInUserName;
            lblFees.Text = clsManageApplicationTypes.GetApplicationFees(6).ToString();
            LLlicenseInfo.Enabled = false;
            LLShowLicenseHistory.Enabled = false;
            btnIssue.Enabled = false;
            ucSearchForLicense1.LicenseFoundClick += LicenseFoundClick;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool InternationalLicenseIssueVerification()
        {
            if (ucSearchForLicense1.LicenseID == -1)
            {
                MessageBox.Show("No License Avaialbe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (ucSearchForLicense1.IsActive == "Not Active")
            {
                MessageBox.Show("License Is Not Active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (ucSearchForLicense1.IsDetained == "Yes")
            {
                MessageBox.Show("License Is Detaiend", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if(clsInternationalLicense.IsInternationalLicenseActiveOrAvailable(ucSearchForLicense1.LicenseID))
            {
                MessageBox.Show("International License Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return true;
            }
            return false;

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            try
            {
                if (InternationalLicenseIssueVerification())
                {
                    return;
                }


                _applications.ApplicantPersonID = ucSearchForLicense1.PersonId;
                _applications.ApplicationDate = DateTime.Now;
                _applications.LastStatusDate = DateTime.Now;
                _applications.PaidFees = clsManageApplicationTypes.GetApplicationFees(6);
                _applications.ApplicationTypeID = 6;
                _applications.ApplicationStatus = 3;
                _applications.CreatedUserById = GlobalProperties.LoggedInUserID;

                _applications.Save();

                InternationalLicenseID = clsInternationalLicense.AddNewInternationalLicense
                   (_applications.ApplicationID, ucSearchForLicense1.DriverID, ucSearchForLicense1.LicenseID
                   , DateTime.Now, DateTime.Now.AddYears(1), true, GlobalProperties.LoggedInUserID);
                
                lblInternationalLicense.Text = InternationalLicenseID.ToString();
                lblInternationalAppId.Text = _applications.ApplicationID.ToString();

                MessageBox.Show("International License Added Successfully with ID number: " + InternationalLicenseID
                    , "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LLlicenseInfo.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LLShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //frmLicenseHistory frm = new frmLicenseHistory(ucSearchForLicense1.NationalNo);
            //frm.ShowDialog();

            
        }

        private void LicenseFoundClick(object sender, EventArgs e)
        {
            btnIssue.Enabled = true;
            LLShowLicenseHistory.Enabled = true;
            lblLocalLicenseID.Text = ucSearchForLicense1.LicenseID.ToString();
        }

        private void LLlicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(_applications.ApplicantPersonID, InternationalLicenseID);
            frm.ShowDialog();
        }
    }
}

