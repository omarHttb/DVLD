﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DVLD.Users;
using DVLD.Login;
using BusinessLayerDVLD;
using DVLD.ManageApplicationTypes;
using DVLD.ManageTestTypes;
using DVLD.NewDrivingLicense;
using DVLD.LocalApplicationFiles.ManageLocalApplications;
using DVLD.ManageDrivers;
using DVLD.License.International;
using DVLD.InternationalLicense;
using DVLD.License.Renew_Local_Driving_License;
using DVLD.License.Replace_License_For_Lost_or_damaged;
using DVLD.Detain;
using DVLD.Detain.Release_Detain_License;
using DVLD.Detain.ManageDetainedLicense;

namespace DVLD
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(string UserName)
        {
            InitializeComponent();
            lblLoggedInUser.Text = UserName;
     
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            clsUsers _clsUsers = clsUsers.GetUserIdAndPersonIdByUserName(lblLoggedInUser.Text);

            GlobalProperties.LoggedInUserID = _clsUsers.UserID;
            GlobalProperties.LoggedInPersonID = _clsUsers.PersonID;
            GlobalProperties.LoggedInUserName = lblLoggedInUser.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           FrmPeopleManagementForm frm = new FrmPeopleManagementForm();

            frm.ShowDialog();
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            frmUsersManagement frmUsersManagement = new frmUsersManagement();
            frmUsersManagement.ShowDialog();
        }



        private void BtnDrivers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not implemented yet");

        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }



        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frmUserDetails = new frmUserDetails(GlobalProperties.LoggedInUserID,GlobalProperties.LoggedInPersonID);
            frmUserDetails.ShowDialog();
        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmChangePassword frmChangePassword = new FrmChangePassword(GlobalProperties.LoggedInUserID, GlobalProperties.LoggedInPersonID);
            frmChangePassword.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }





        private void btnManageApplicationTypes_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.Show();
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet");
        }

        private void BtnApplications_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet");

        }

        private void btnDrivingLicense_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet");

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            FrmAddUpdatePerson frm = new FrmAddUpdatePerson();
            frm.ShowDialog();
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser frm = new frmAddUser();

            frm.ShowDialog();
        }

        private void btnManageApplicationTypes_Click_1(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm =new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void btnManageTestTypes_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();

            frm.ShowDialog();
        }

        private void btnRetakeTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not implemented");
        }

        private void btnLocalLicense_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingLicense frm = new frmNewLocalDrivingLicense();
            frm.ShowDialog();
        }

        private void BtnManageLDLApplication_Click(object sender, EventArgs e)
        {
            FrmManageLocalDrivingLicenseApplication frm = new FrmManageLocalDrivingLicenseApplication();    
            frm.ShowDialog();
        }

        private void btnManageGDLApplication_Click(object sender, EventArgs e)
        {
            frmManageInternationalLicense frm = new frmManageInternationalLicense();
            frm.ShowDialog();
        }

        private void BtnDrivers_Click_1(object sender, EventArgs e)
        {
            frmManageDrivers frm = new frmManageDrivers();  
            frm.ShowDialog();
        }

        private void btnNewGlobalLicenses_Click(object sender, EventArgs e)
        {
            frmIssueInternationalLicense frm = new frmIssueInternationalLicense();
            frm.ShowDialog();
        }

        private void btnRenweLicense_Click(object sender, EventArgs e)
        {
            frmRenewLocalDrivingLicense frmRenewLocalDrivingLicense = new frmRenewLocalDrivingLicense();
            frmRenewLocalDrivingLicense.ShowDialog();
        }

        private void BtnReplacementOfLostOrDamagedLicenses_Click(object sender, EventArgs e)
        {
            frmReplaceLicenseLostOrDamaged frm = new frmReplaceLicenseLostOrDamaged();
            frm.ShowDialog();
        }

        private void btnDetainLicense_Click_1(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
        }

        private void BtnRelaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmManageDetainedLicense frmManageDetainedLicense = new frmManageDetainedLicense();
            frmManageDetainedLicense.ShowDialog();
        }
    }
}
