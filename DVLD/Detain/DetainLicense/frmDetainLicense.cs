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

namespace DVLD.Detain
{
    public partial class frmDetainLicense : Form
    {
        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            llLicenseHistory.Enabled = false;
            lblDetainDate.Text = DateTime.Now.ToString();
            lblCreatedBy.Text = GlobalProperties.LoggedInUserName;
            ucSearchForLicense1.LicenseFoundClick += LicenseFoundClick;
            btnDetain.Enabled = false;
            
        }
        private void LicenseFoundClick(object sender, EventArgs e)
        {
    
            llLicenseHistory.Enabled= true;
            lblLicenseID.Text = ucSearchForLicense1.LicenseID.ToString();
            if(ucSearchForLicense1.IsDetained == "Yes")
            {
                MessageBox.Show("License is already Detained","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDetain.Enabled = false;
            }
            else
            {
                btnDetain.Enabled = true;
            }

        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if(txtFineFees.Text == "")
            {
                MessageBox.Show("Fine fees Cannot be empty","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            clsDetainLicense.DetainNewLicense(ucSearchForLicense1.LicenseID,DateTime.Now,Convert.ToDecimal( txtFineFees.Text),
                GlobalProperties.LoggedInUserID,false);
            ucSearchForLicense1.ChangeToDetained();

            MessageBox.Show("License is Detained. \n To Release License please visit the DVLD Center and pay the fees", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDetain.Enabled = false;

        }

        private void llLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(ucSearchForLicense1.PersonId);
            frm.ShowDialog();
        }

        private void txtFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }
    }
}
