﻿using BusinessLayerDVLD;
using DVLD.License.International;
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
    public partial class frmLicenseHistory : Form
    {
        public frmLicenseHistory(string NationalNo)
        {
            InitializeComponent();
            ucSearchForPerson1.NationalNo = NationalNo;
            ucSearchForPerson1.UpdateModeByNationalNo();

            ucSearchForPerson1.LoadPersonInfo();
        }

        public frmLicenseHistory(int PersonID)
        {
            InitializeComponent();
            ucSearchForPerson1.PersonID = PersonID;
            ucSearchForPerson1.UpdateModeByPersonId();

            ucSearchForPerson1.LoadPersonInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            LoadAllLocalAndInternationalLicense();
        }
        
        private void LoadAllLocalAndInternationalLicense()
        {
            DgvAllLocalLicense.DataSource = clsLicenses.GetAllPersonLocalLicense(ucSearchForPerson1.PersonID);
            lblRecords.Text =  DgvAllLocalLicense.RowCount.ToString();
            DgvInternationalLicenses.DataSource = clsInternationalLicense.GetAllPersonInternationalLicense(ucSearchForPerson1.PersonID);
            lblInternationalLicenseRecord.Text = DgvInternationalLicenses.RowCount.ToString();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

                frmDriverLicenseInfo frm = new frmDriverLicenseInfo(ucSearchForPerson1.PersonID, (int)DgvAllLocalLicense.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(ucSearchForPerson1.PersonID, (int)DgvInternationalLicenses.
                CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
