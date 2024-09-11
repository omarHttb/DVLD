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

        private void frmDriverLicenseInfo_Load(object sender, EventArgs e)
        {
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
