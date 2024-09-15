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

namespace DVLD.User_Controls.License
{
    public partial class UcShowInternationalLicenseInfo : UserControl
    {
        clsPeople _clsPeople = new clsPeople();
        clsInternationalLicense _clsInternationalLicense = new clsInternationalLicense();
        int PersonID = -1;
        string NationalNo = "";
        int InternationaLicenseID = -1; 

        public UcShowInternationalLicenseInfo()
        {
            InitializeComponent();

        }




        private void UcShowInternationalLicenseInfo_Load(object sender, EventArgs e)
        {

            
        }
    }
}
