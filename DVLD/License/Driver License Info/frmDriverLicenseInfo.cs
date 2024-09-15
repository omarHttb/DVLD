using BusinessLayerDVLD;
using DVLD.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.License.Driver_License_Info
{
    public partial class frmDriverLicenseInfo : Form
    {

        
        public frmDriverLicenseInfo(string NationalNo)
        {
            InitializeComponent();
            UcPersonDetails.PersonID = clsPeople.GetPersonIDByNationalNumber(NationalNo);
            ucLicenseInfo1.personID = UcPersonDetails.PersonID;
        }

        public frmDriverLicenseInfo(int PersonID)
        {
            InitializeComponent();
            UcPersonDetails.PersonID = PersonID;
            ucLicenseInfo1.personID = PersonID;

        }
        public frmDriverLicenseInfo(string NationalNo,int ApplicationID)
        {
            InitializeComponent();
            UcPersonDetails.PersonID = clsPeople.GetPersonIDByNationalNumber(NationalNo);
            ucLicenseInfo1.ApplicationID = ApplicationID;
        }

        public frmDriverLicenseInfo(int PersonID,int ApplicationID)
        {
            InitializeComponent();
            UcPersonDetails.PersonID = PersonID;
            ucLicenseInfo1.ApplicationID = ApplicationID;
        }
        public frmDriverLicenseInfo(int PersonID, int LicenseID,bool ShowByLicense)
        {
            InitializeComponent();
            UcPersonDetails.PersonID = PersonID;
            ucLicenseInfo1.LicenseID = LicenseID;
        }

        private void frmDriverLicenseInfo_Load(object sender, EventArgs e)
        {
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
