using BusinessLayerDVLD;
using DVLD.License.Driver_License_Info;
using DVLD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.User_Controls.License.SearchForLicenseInfo
{
    public partial class UcSearchForLicense : UserControl
    {
        // Define a public event that will be triggered on button click
        public event EventHandler LicenseFoundClick;

        public string IsDetained { get; set; } = "";
        public string IsActive { get; set; } = "";
        public int LicenseID { get; set; } = -1;
        public int DriverID { get; set; } = -1;
        public int PersonId { get; set; } = -1;
        public string NationalNo { get; set; } = "";
        public int LicenseClassID { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        
       
        clsLicenses _clsLicenses = new clsLicenses();
        clsPeople _clsPeople = new clsPeople();
        public UcSearchForLicense()
        {
            InitializeComponent();

        }

        private string isLicenseDetained(int LicenseID)
        {


            if (clsDetainLicense.IsLicenseNotDetained(LicenseID))
            {
                return "No";
            }
            else
                return "Yes";
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _clsLicenses = clsLicenses.FindLicenseInfoByLicenseID(Convert.ToInt32(txtFilter.Text));
            if(_clsLicenses == null ) 
            {
                PbPerson.Image = Resources._360_F_65772719_A1UV5kLi5nCEWI0BNLLiFaBPEkUbv5Fv;
                MessageBox.Show("License Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //License Info
            lblClass.Text = _clsLicenses.LicenseClass;
            lblIsActive.Text = _clsLicenses.IsActive;
            lblLicenseID.Text = txtFilter.Text;
            lblExpirationDate.Text = _clsLicenses.ExpirationDate.ToString();
            lblIssueDate.Text = _clsLicenses.IssueDate.ToString(); 
            lblIssueReason.Text = _clsLicenses.IssueReason;
            lblDriverID.Text = _clsLicenses.DriverID.ToString();
            lblIsDetained.Text = isLicenseDetained(int.Parse(txtFilter.Text));
            if (_clsLicenses.Notes != "")
            {
                lblNotes.Text = _clsLicenses.Notes;
            }
            else
                lblNotes.Text = "No Notes";
            // Person Info
            PersonId = clsDrivers.GetPersonIDByDriverID(_clsLicenses.DriverID);

            _clsPeople = clsPeople.FindPersonById(PersonId);
            lblFullName.Text = _clsPeople.FullName;
            lblDateOfBirth.Text = _clsPeople.DateOfBirth.ToString();
            if (_clsPeople.Gender == 0)
            {
                lblGender.Text = "Male";
            }
            else
            {
                lblGender.Text = "Female";
            }
            lblNationalNo.Text = _clsPeople.NationalNo;
            NationalNo = _clsPeople.NationalNo;

            if (_clsPeople.ImagePath != "")
            {
                PbPerson.Image = new Bitmap("C:\\Users\\omar hattab\\Pictures\\DVLD Images\\" + _clsPeople.ImagePath);

            }



            //Utility

            IsDetained = lblIsDetained.Text;
            IsActive = lblIsActive.Text;
            LicenseID = _clsLicenses.LicenseID;
            DriverID = _clsLicenses.DriverID;
            LicenseClassID = _clsLicenses.LicenseClassID;
            ExpirationDate = _clsLicenses.ExpirationDate;
            Notes = _clsLicenses.Notes;
            // Trigger the custom event
            LicenseFoundClick?.Invoke(this, EventArgs.Empty);

            
        }

        public void LoadByLicenseId(int licenseID)
        {
            _clsLicenses = clsLicenses.FindLicenseInfoByLicenseID(licenseID);

            lblClass.Text = _clsLicenses.LicenseClass;
            lblIsActive.Text = _clsLicenses.IsActive;
            lblLicenseID.Text = licenseID.ToString();
            lblExpirationDate.Text = _clsLicenses.ExpirationDate.ToString();
            lblIssueDate.Text = _clsLicenses.IssueDate.ToString();
            lblIssueReason.Text = _clsLicenses.IssueReason;
            lblDriverID.Text = _clsLicenses.DriverID.ToString();
            lblIsDetained.Text = isLicenseDetained(licenseID);
            txtFilter.Text = licenseID.ToString();  
            if (_clsLicenses.Notes != "")
            {
                lblNotes.Text = _clsLicenses.Notes;
            }
            else
                lblNotes.Text = "No Notes";
            // Person Info
            PersonId = clsDrivers.GetPersonIDByDriverID(_clsLicenses.DriverID);

            _clsPeople = clsPeople.FindPersonById(PersonId);
            lblFullName.Text = _clsPeople.FullName;
            lblDateOfBirth.Text = _clsPeople.DateOfBirth.ToString();
            if (_clsPeople.Gender == 0)
            {
                lblGender.Text = "Male";
            }
            else
            {
                lblGender.Text = "Female";
            }
            lblNationalNo.Text = _clsPeople.NationalNo;
            NationalNo = _clsPeople.NationalNo;

            if (_clsPeople.ImagePath != "")
            {
                PbPerson.Image = new Bitmap("C:\\Users\\omar hattab\\Pictures\\DVLD Images\\" + _clsPeople.ImagePath);

            }



            //Utility

            IsDetained = lblIsDetained.Text;
            IsActive = lblIsActive.Text;
            LicenseID = _clsLicenses.LicenseID;
            DriverID = _clsLicenses.DriverID;
            LicenseClassID = _clsLicenses.LicenseClassID;
            ExpirationDate = _clsLicenses.ExpirationDate;
            Notes = _clsLicenses.Notes;

            btnSearch.Enabled = false;
            txtFilter.Enabled = false;

        }

        public void ChangeToDetained()
        {
            lblIsDetained.Text = "Yes";
        }
        public void ChangeToReleased()
        {
            lblIsDetained.Text = "No";
        }

    }
}
