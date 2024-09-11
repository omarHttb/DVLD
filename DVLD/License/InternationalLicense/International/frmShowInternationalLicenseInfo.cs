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

namespace DVLD.License.International
{
    public partial class frmShowInternationalLicenseInfo : Form
    {
        clsPeople _clsPeople = new clsPeople();
        clsInternationalLicense _clsInternationalLicense = new clsInternationalLicense();
        int PersonID = -1;
        string NationalNo = "";
        int InternationaLicenseID = -1;
        public frmShowInternationalLicenseInfo(int personID,int internationaLicenseID)
        {
            InitializeComponent();
            PersonID = personID;
            InternationaLicenseID = internationaLicenseID;
        }
        public frmShowInternationalLicenseInfo(string nationalNo, int internationaLicenseID)
        {
            InitializeComponent();
            NationalNo = nationalNo;
            InternationaLicenseID = internationaLicenseID;
        }

        private void frmShowInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            try
            {
                //person Info
                if (PersonID != -1)
                {
                    _clsPeople = clsPeople.FindPersonById(PersonID);
                }
                else
                {
                    _clsPeople = clsPeople.FindPersonByNationalNumber(NationalNo);
                }

                lblFullName.Text = _clsPeople.FullName;
                if (_clsPeople.Gender == 0)
                {
                    lblGender.Text = "Male";
                }
                else
                {
                    lblGender.Text = "Female";
                }
                lblDateOfBirth.Text = _clsPeople.DateOfBirth.ToString();
                lblNationalNo.Text = _clsPeople.NationalNo;
                if (_clsPeople.ImagePath != "")
                {
                    PbPerson.Image = new Bitmap("C:\\Users\\omar hattab\\Pictures\\DVLD Images\\" + _clsPeople.ImagePath);

                }

                //international license info
                _clsInternationalLicense = clsInternationalLicense.FindInternationalLicenseInfoByInternationalLicenseID(InternationaLicenseID);

                lblApplicationID.Text = _clsInternationalLicense.ApplicationID.ToString();
                lblDriverID.Text = _clsInternationalLicense.DriverID.ToString();
                lblIssueDate.Text = _clsInternationalLicense.IssueDate.ToString();
                lblExpirationDate.Text = _clsInternationalLicense.ExpirationDate.ToString();
                lblIntLicenseID.Text = InternationaLicenseID.ToString();
                lblLicenseID.Text = _clsInternationalLicense.IssuedUsingLocalLicenseID.ToString();
                if (_clsInternationalLicense.IsActive)
                {
                    lblIsActive.Text = "Yes";
                }
                else
                {
                    lblIsActive.Text = "No";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
