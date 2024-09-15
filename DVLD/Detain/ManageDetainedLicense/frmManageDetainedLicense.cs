using BusinessLayerDVLD;
using DVLD.Detain.Release_Detain_License;
using DVLD.FrmPeopleManagement;
using DVLD.License.Driver_License_Info;
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
using System.Xml.Linq;

namespace DVLD.Detain.ManageDetainedLicense
{
    public partial class frmManageDetainedLicense : Form
    {
        private string filter = "";

        public frmManageDetainedLicense()
        {
            InitializeComponent();
            CbFilter.SelectedIndex = 0;
            txtFilter.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
        }

        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
        }

        private void frmManageDetainedLicense_Load(object sender, EventArgs e)
        {
            _LoadDetaindAndReleasedLicense();
        }

        private void _LoadDetaindAndReleasedLicense()
        {
            DgvDetainedAndReleased.DataSource = clsDetainLicense.GetAllDetainedLicenses();
            lblNumberOfRecords.Text = DgvDetainedAndReleased.RowCount.ToString();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonInfo frm = new frmPersonInfo(clsPeople.GetPersonIDByNationalNumber((string)DgvDetainedAndReleased.CurrentRow.Cells[5].Value));
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(clsPeople.GetPersonIDByNationalNumber((string)DgvDetainedAndReleased.CurrentRow.Cells[5].Value),
                (int)DgvDetainedAndReleased.CurrentRow.Cells[1].Value,true);
               frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseHistory frm  = new frmLicenseHistory((string)DgvDetainedAndReleased.CurrentRow.Cells[5].Value);
            frm.ShowDialog();
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense((int)DgvDetainedAndReleased.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void CbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (CbFilter.SelectedIndex)
            {
                case 0:
                    txtFilter.Text = "";

                    filter = "";
                    txtFilter.Enabled = false;
                    _LoadDetaindAndReleasedLicense();
                    break;
                case 1:
                    filter = "DetainID";
                    txtFilter.Enabled = true;

                    break;
                case 2:
                    filter = "National No";
                    txtFilter.Enabled = true;

                    break;
                case 3:
                    filter = "FullName";
                    txtFilter.Enabled = true;

                    break;
                case 4:
                    filter = "Release Application ID";
                  
                    txtFilter.Enabled = true;

                    break;
                case 5:
                    filter = "IsReleased";
                    DgvDetainedAndReleased.DataSource = clsDetainLicense.GetFilteredResult(filter, txtFilter.Text);
                    lblNumberOfRecords.Text = DgvDetainedAndReleased.RowCount.ToString();
                    txtFilter.Enabled = false;
                    break;
                case 6:
                    filter = "IsDetained";
                    DgvDetainedAndReleased.DataSource = clsDetainLicense.GetFilteredResult(filter, txtFilter.Text);
                    lblNumberOfRecords.Text = DgvDetainedAndReleased.RowCount.ToString();
                    txtFilter.Enabled = false;
                    break;
            }
        }//                   


        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            DgvDetainedAndReleased.DataSource = clsDetainLicense.GetFilteredResult(filter, txtFilter.Text);
            lblNumberOfRecords.Text = DgvDetainedAndReleased.RowCount.ToString();


        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CbFilter.SelectedIndex == 1 || CbFilter.SelectedIndex == 6)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void CmDETAIN_Opening(object sender, CancelEventArgs e)
        {
            if((string)DgvDetainedAndReleased.CurrentRow.Cells[2].Value == "No")
            {
                releaseLicenseToolStripMenuItem.Enabled = true;
            }
            else
            {
                releaseLicenseToolStripMenuItem.Enabled = false;
            }
        }
    }
}
