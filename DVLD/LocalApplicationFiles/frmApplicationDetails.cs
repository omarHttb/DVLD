using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.ManageApplicationTypes
{
    public partial class frmApplicationDetails : Form
    {
        public frmApplicationDetails(int ldlAppId,string LicenseClass,int PassedTest,string FullName)
        {
            InitializeComponent();
            ucApplicationInfo1.LdlAppId = ldlAppId;
            ucApplicationInfo1.LicenseClass = LicenseClass;
            ucApplicationInfo1.PassedTest = PassedTest;
            ucApplicationInfo1.FullName = FullName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
