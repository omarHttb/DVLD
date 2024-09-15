using BusinessLayerDVLD;
using DVLD.License.Driver_License_Info;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Detain.Release_Detain_License
{
    public partial class frmReleaseDetainedLicense : Form
    {
        clsDetainLicense _clsDetainLicense = new clsDetainLicense(); 
        clsApplications _clsApplication = new clsApplications();
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }

        public frmReleaseDetainedLicense(int LicenseID)
        {
            InitializeComponent();
            ucSearchForLicense1.LoadByLicenseId(LicenseID);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(ucSearchForLicense1.PersonId);
            frm.ShowDialog();
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            ucSearchForLicense1.LicenseFoundClick += LicenseFoundClick;
            lblReleaseBy.Text = GlobalProperties.LoggedInUserName;
            lblReleaseDate.Text = DateTime.Now.ToShortDateString();
            btnReleaseLicense.Enabled = false;
            llLicenseHistory.Enabled =false;
            lblApplicationFees.Text = clsManageApplicationTypes.GetApplicationFees(5).ToString();
            if(ucSearchForLicense1.LicenseID != -1)
            {
                LoadByLicenseID();
            }

        }

        private void LoadByLicenseID()
        {
            btnReleaseLicense.Enabled = true;
            lblLicenseID.Text = ucSearchForLicense1.LicenseID.ToString();
            _clsDetainLicense = clsDetainLicense.FindPersonDetainedLicenseInfo(ucSearchForLicense1.LicenseID);
            lblFineFees.Text = _clsDetainLicense.FineFees.ToString();
            lblTotalFees.Text = (Convert.ToDecimal(lblFineFees.Text) + Convert.ToDecimal(lblApplicationFees.Text)).ToString();
            lblCreatedBy.Text = clsUsers.GetUserNameByUserId(_clsDetainLicense.CreatedById);
            lblDetainDate.Text = _clsDetainLicense.DetainDate.ToString();
            lblDetainID.Text = _clsDetainLicense.DetainID.ToString();
            lblReleaseBy.Text = GlobalProperties.LoggedInUserName;
            lblReleaseDate.Text = DateTime.Now.ToShortDateString();
        }

        private void LicenseFoundClick(object sender, EventArgs e)
        {
            llLicenseHistory.Enabled =true ;
            if(ucSearchForLicense1.IsDetained == "No")
            {
                MessageBox.Show("License is not detained","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnReleaseLicense.Enabled=false;
                lblDetainDate.Text = "???"; 
                lblDetainID.Text = "???";
                lblTotalFees.Text = "???";
                lblFineFees.Text = "???";
                lblCreatedBy.Text = "???";
                lblReleaseApplicationID.Text = "???";
                lblReleaseBy.Text = "???";
                lblReleaseDate.Text = "???";
                lblLicenseID.Text = ucSearchForLicense1.LicenseID.ToString();

            }
            else
            {
                btnReleaseLicense.Enabled = true;
                lblLicenseID.Text = ucSearchForLicense1.LicenseID.ToString();
                _clsDetainLicense = clsDetainLicense.FindPersonDetainedLicenseInfo(ucSearchForLicense1.LicenseID);
                lblFineFees.Text = _clsDetainLicense.FineFees.ToString();
                lblTotalFees.Text = (Convert.ToDecimal(lblFineFees.Text) + Convert.ToDecimal(lblApplicationFees.Text)).ToString();
                lblCreatedBy.Text = clsUsers.GetUserNameByUserId(_clsDetainLicense.CreatedById);
                lblDetainDate.Text = _clsDetainLicense.DetainDate.ToString();
                lblDetainID.Text = _clsDetainLicense.DetainID.ToString();
                lblReleaseBy.Text = GlobalProperties.LoggedInUserName;
                lblReleaseDate.Text = DateTime.Now.ToShortDateString();
                ;
            }
  

        }

        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            try
            {
                _clsApplication.PaidFees = Convert.ToDecimal(lblApplicationFees.Text);
                _clsApplication.ApplicationStatus = 3;
                _clsApplication.ApplicantPersonID = ucSearchForLicense1.PersonId;
                _clsApplication.ApplicationDate = DateTime.Now;
                _clsApplication.ApplicationTypeID = 5;
                _clsApplication.LastStatusDate = DateTime.Now;  
                _clsApplication.CreatedUserById = GlobalProperties.LoggedInUserID;

                _clsApplication.Save();

                if (clsDetainLicense.ReleaseDetainedLicenses(ucSearchForLicense1.LicenseID, _clsApplication.ApplicationID,
                    GlobalProperties.LoggedInUserID, DateTime.Now))
                {
                    MessageBox.Show("License is Released", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnReleaseLicense.Enabled = false;
                    ucSearchForLicense1.ChangeToReleased();
                }

                else
                {
                    MessageBox.Show("something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
