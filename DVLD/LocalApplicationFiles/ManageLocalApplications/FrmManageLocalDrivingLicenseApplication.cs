using BusinessLayerDVLD;
using DVLD.NewDrivingLicense;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD.LocalApplicationFiles.ManageLocalApplications
{

    public partial class FrmManageLocalDrivingLicenseApplication : Form
    {
        private string _FilterChoice = "";

        public FrmManageLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            _loadAllLocalDrivingLicenseApplication();
            CbFilter.SelectedIndex = 0;
            MenuItemDeleteApp.Enabled = false;
            MenuItemIssueLicenseFirstTime.Enabled = false;
            MenuItemShowLicense.Enabled = false;
            schedualWrittenTestToolStripMenuItem.Enabled = false;
            scheduleStreetTestToolStripMenuItem.Enabled = false;
        }
//        None
//L.D.L.AppID
//National No.	
//Full Name
//Status
        private void _FilterSetting()
        {
            switch (CbFilter.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    _FilterChoice = "LdlAppId";
                    break;
                case 2:
                    _FilterChoice = "NationalNo";
                    break;
                case 3:
                    _FilterChoice = "FullName";
                    break;
                case 4:
                    if (rbCompleted.Checked)
                    {
                        _FilterChoice = "Completed";
                    }
                    else if (RbCancelled.Checked)
                    {
                        _FilterChoice = "Cancelled";
                    }
                    else if(RbNew.Checked)
                    {
                        _FilterChoice = "New";       
                    }
                    break;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _loadAllLocalDrivingLicenseApplication()
        {
            DvgLocalDrvingLicenseApplication.DataSource = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
            lblNumberOfRecords.Text = DvgLocalDrvingLicenseApplication.RowCount.ToString();
        }

        private void BtnAddLocalApplication_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingLicense frm = new frmNewLocalDrivingLicense();    
            frm.ShowDialog();
        }

        private void CbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterSetting();

            if (CbFilter.SelectedIndex == 4) 
            {
                rbCompleted.Visible = true;
                RbNew.Visible = true;
                RbCancelled.Visible = true;
                TxtFilter.Visible = false;
                TxtFilter.Enabled = true;


            }
            else if(CbFilter.SelectedIndex == 0)
            {
                rbCompleted.Visible = false;
                RbNew.Visible = false;
                RbCancelled.Visible = false;
                TxtFilter.Visible = true;
                TxtFilter.Enabled = false;
                _loadAllLocalDrivingLicenseApplication();
            }
            else
            {
                rbCompleted.Visible = false;
                RbNew.Visible = false;
                RbCancelled.Visible = false;
                TxtFilter.Visible = true;
                TxtFilter.Enabled = true;

            }
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            if (TxtFilter.Text != "")
            {


                if (CbFilter.SelectedIndex != 0)
                {
                    DvgLocalDrvingLicenseApplication.DataSource = clsLocalDrivingLicenseApplication.GetFilteredResultLDL(
                        _FilterChoice, TxtFilter.Text);
                    lblNumberOfRecords.Text = DvgLocalDrvingLicenseApplication.RowCount.ToString();
                }
            }
            else
            {
                _loadAllLocalDrivingLicenseApplication();

            }

        }

        private void RbNew_CheckedChanged(object sender, EventArgs e)
        {
            _FilterSetting();

            if (RbNew.Checked) 
            {
                DvgLocalDrvingLicenseApplication.DataSource = clsLocalDrivingLicenseApplication.GetFilteredResultLDL(
                       _FilterChoice, RbNew.Text);
                lblNumberOfRecords.Text = DvgLocalDrvingLicenseApplication.RowCount.ToString();

            }
        }

        private void rbCompleted_CheckedChanged(object sender, EventArgs e)
        {
            _FilterSetting();

            if (rbCompleted.Checked)
            {
                DvgLocalDrvingLicenseApplication.DataSource = clsLocalDrivingLicenseApplication.GetFilteredResultLDL(
                       _FilterChoice, rbCompleted.Text);
                lblNumberOfRecords.Text = DvgLocalDrvingLicenseApplication.RowCount.ToString();

            }
        }

        private void RbCancelled_CheckedChanged(object sender, EventArgs e)
        {
            _FilterSetting();
            if (RbCancelled.Checked)
            {
                DvgLocalDrvingLicenseApplication.DataSource = clsLocalDrivingLicenseApplication.GetFilteredResultLDL(
                       _FilterChoice, RbCancelled.Text);
                    lblNumberOfRecords.Text = DvgLocalDrvingLicenseApplication.RowCount.ToString();

            }
        }

        private void MenuItemCancelApp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Cancel this Application?", "Cancel",
   MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                clsLocalDrivingLicenseApplication.CancelLocalDrivingLiceseApplication((int)DvgLocalDrvingLicenseApplication.CurrentRow.Cells
                    [0].Value);
                _loadAllLocalDrivingLicenseApplication();
            }
        }

        private void MenuItemDeleteApp_Click(object sender, EventArgs e)
        {

        }

        // update licenes class for person
        private void MenuItemEditApplication_Click(object sender, EventArgs e)
        {
            
            frmNewLocalDrivingLicense frm = new frmNewLocalDrivingLicense(
                (string)DvgLocalDrvingLicenseApplication.CurrentRow.Cells[2].Value ,
                (int)DvgLocalDrvingLicenseApplication.CurrentRow.Cells[0].Value);

            frm.ShowDialog();
            _loadAllLocalDrivingLicenseApplication();

        }

       
    }
}
