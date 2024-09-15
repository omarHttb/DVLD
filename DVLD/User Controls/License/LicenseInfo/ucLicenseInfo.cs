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

namespace DVLD.User_Controls.LicenseInfo
{
    public partial class ucLicenseInfo : UserControl
    {

        public int personID { get; set; } = -1;
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        
       clsLicenses _clsLicense = new clsLicenses();
        public ucLicenseInfo()
        {
            InitializeComponent();
        }



        private void ucLicenseInfo_Load(object sender, EventArgs e)
        {
            try
            {
                if(LicenseID != 0) 
                {
                    LoadLicenseInfoByLicenseID();
                }
                else if (ApplicationID != 0)
                {
                    LoadLicenseInfoByAppID();
                }
                else if (personID != 0)
                {
                    LoadLicenseInfoByPersonID();
                }
            }
            catch 
            {
            }
            
        }
        private string IsLicenseDetained(int licenseID)
        {
            if (clsDetainLicense.IsLicenseNotDetained(licenseID))
            {
                return "No";
            }
            else
                return "Yes";
        }

        private void LoadLicenseInfoByLicenseID() 
        {
                
                _clsLicense = clsLicenses.FindLicenseInfoByLicenseID(LicenseID);

                lblDriverID.Text = _clsLicense.DriverID.ToString();
                lblLicenseID.Text = LicenseID.ToString();
                lblIsActive.Text = _clsLicense.IsActive;
                lblIssueDate.Text = _clsLicense.IssueDate.ToString();
                lblExpirationDate.Text = _clsLicense.ExpirationDate.ToString();
                lblLicenseClass.Text = _clsLicense.LicenseClass;
                lblIssueReason.Text = _clsLicense.IssueReason;
                lblIsDetained.Text = IsLicenseDetained(_clsLicense.LicenseID);

                if (_clsLicense.Notes == "")
                {
                    lblNotes.Text = "No Notes";
                }
                else
                {
                    lblNotes.Text = _clsLicense.Notes;
                }
            
        }

        private void LoadLicenseInfoByAppID()
        {

            _clsLicense = clsLicenses.GetPersonLicenseByApplicationID(ApplicationID);

            lblDriverID.Text = _clsLicense.DriverID.ToString();
            lblLicenseID.Text = _clsLicense.LicenseID.ToString();
            lblIsActive.Text = _clsLicense.IsActive;
            lblIssueDate.Text = _clsLicense.IssueDate.ToString();
            lblExpirationDate.Text = _clsLicense.ExpirationDate.ToString();
            lblLicenseClass.Text = _clsLicense.LicenseClass;
            lblIssueReason.Text = _clsLicense.IssueReason;
            lblIsDetained.Text = IsLicenseDetained(_clsLicense.LicenseID);

            if (_clsLicense.Notes == "")
            {
                lblNotes.Text = "No Notes";
            }
            else
            {
                lblNotes.Text = _clsLicense.Notes;
            }

        }
        private void LoadLicenseInfoByPersonID()
        {

            _clsLicense = clsLicenses.FindLicenseInfoByPersonID(personID);

            lblDriverID.Text = _clsLicense.DriverID.ToString();
            lblLicenseID.Text = _clsLicense.LicenseID.ToString();
            lblIsActive.Text = _clsLicense.IsActive;
            lblIssueDate.Text = _clsLicense.IssueDate.ToString();
            lblExpirationDate.Text = _clsLicense.ExpirationDate.ToString();
            lblLicenseClass.Text = _clsLicense.LicenseClass;
            lblIssueReason.Text = _clsLicense.IssueReason;
            lblIsDetained.Text = IsLicenseDetained(_clsLicense.LicenseID);

            if (_clsLicense.Notes == "")
            {
                lblNotes.Text = "No Notes";
            }
            else
            {
                lblNotes.Text = _clsLicense.Notes;
            }

        }


    }
}
