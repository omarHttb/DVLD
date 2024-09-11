using BusinessLayerDVLD;
using DVLD.License.Driver_License_Info;
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
        
       
        clsLicenses _clsLicenses = new clsLicenses();
        clsPeople _clsPeople = new clsPeople();
        public UcSearchForLicense()
        {
            InitializeComponent();

        }

        private string isLicenseDetained()
        {
            if (clsDetainLicense.IsLicenseDetained(Convert.ToInt32( txtFilter.Text)))
            {
                return "Yes";
            }
            else
                return "No";
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            _clsLicenses = clsLicenses.FindLicenseInfoByLicenseID(Convert.ToInt32(txtFilter.Text));
            if(_clsLicenses == null ) 
            {
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
            lblIsDetained.Text = isLicenseDetained();
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

            // Trigger the custom event
            LicenseFoundClick?.Invoke(this, EventArgs.Empty);
        }

        
    }
}
