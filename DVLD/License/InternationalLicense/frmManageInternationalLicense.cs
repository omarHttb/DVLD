using BusinessLayerDVLD;
using DVLD.FrmPeopleManagement;
using DVLD.License.Driver_License_Info;
using DVLD.License.International;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.InternationalLicense
{
    public partial class frmManageInternationalLicense : Form
    {
        private string filter  = "";
        public frmManageInternationalLicense()
        {
            InitializeComponent();
            cbFilter.SelectedIndex = 0;
            TxtFilter.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnNewInternationlLicense_Click(object sender, EventArgs e)
        {
            frmIssueInternationalLicense frm = new frmIssueInternationalLicense();
            frm.ShowDialog();
        }

        private void _LoadInternationalLicense()
        {
            DgvInternationalLicenses.DataSource = clsInternationalLicense.GetAllInternationalLicense();
            lblRecords.Text = DgvInternationalLicenses.RowCount.ToString();
        }

        private void frmManageInternationalLicense_Load(object sender, EventArgs e)
        {
            _LoadInternationalLicense();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            frmPersonInfo frm = new frmPersonInfo(clsApplications.GetPersonIdFromApplicationID((int)DgvInternationalLicenses.CurrentRow.Cells[1].Value));
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(clsApplications.GetPersonIdFromApplicationID((int)DgvInternationalLicenses.CurrentRow.Cells[1].Value));
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(
                clsApplications.GetPersonIdFromApplicationID((int)DgvInternationalLicenses.CurrentRow.Cells[1].Value),
                (int)DgvInternationalLicenses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        { 

            DgvInternationalLicenses.DataSource = clsInternationalLicense.GetFilteredResult(filter,TxtFilter.Text);
            lblRecords.Text = DgvInternationalLicenses.RowCount.ToString();
        }
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
           
           e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }
        private void cbFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
 
            if (cbFilter.SelectedIndex == 0)
            {
                TxtFilter.Enabled = false;
            }
            else
                TxtFilter.Enabled = true;
            switch (cbFilter.SelectedIndex)
            {
                case 0:
                    filter = "";
                    _LoadInternationalLicense();

                    break;
                case 1:
                    filter = "InternationalLicenseID";
                    break;
                case 2:
                    filter = "DriverID";
                    break;
                case 3:
                    filter = "LocalLicenseID";
                    break;
                case 4:
                    filter = "ApplicationID";
                    break;
            }
        }


    }
}
