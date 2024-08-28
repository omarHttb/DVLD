﻿using BusinessLayerDVLD;
using DVLD.Properties;
using DVLD.Tests.ScheduleTest;
using DVLD.Tests.TakeTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Tests.VisionTest
{
    public partial class FrmTestAppoinment : Form
    {


        public enum enTestType { VisionTest, WrittenTest , StreetTest }
        enTestType TestType;
        private string IsAppointmentLocked = "";

        public FrmTestAppoinment(int LdAppId,string LicenseClass,int PassedTest,string FullName,enTestType testType)
        {
            InitializeComponent();
            ucApplicationInfo1.LdlAppId = LdAppId;
            ucApplicationInfo1.LicenseClass = LicenseClass;
            ucApplicationInfo1.PassedTest = PassedTest;
            ucApplicationInfo1.FullName = FullName;
            TestType = testType;
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FrmVisionTestAppoinment_Load(object sender, EventArgs e)
        {
            _LoadTestAppointments();
            _LoadTestType();
            IsAppointmentLocked = (string)DgvTestAppointments.CurrentRow.Cells[3].Value;
        }

        public void _LoadTestType()
        {
            switch (TestType)
            {
                case enTestType.VisionTest:
                    lblTestTypeAppointment.Text = "Vision Test Appointments";
                    PbTestPicture.Image = Resources.search;
                    break;
                case enTestType.WrittenTest:
                    lblTestTypeAppointment.Text = "Written Test Appointments";
                    PbTestPicture.Image= Resources.test1;
                break;
                case enTestType.StreetTest:
                    lblTestTypeAppointment.Text = "Street Test Appointments";
                    PbTestPicture.Image = Resources.valet;
                    break;
            }
        }

        private void _LoadTestAppointments()
        {
            DgvTestAppointments.DataSource = clsTestsAppointments.GetAllLdLAppIdTestsAppointments(ucApplicationInfo1.LdlAppId,(int)TestType + 1);
            lblNumberOfRecord.Text = DgvTestAppointments.RowCount.ToString();
        }

        private void BtnScheduleTest_Click(object sender, EventArgs e)
        {
            if (IsAppointmentLocked != "Not Locked")
            {


                switch (TestType)
                {

                    case enTestType.VisionTest:
                        FrmScheduleTest frmSchedule = new FrmScheduleTest(ucApplicationInfo1.LdlAppId, ucApplicationInfo1.LicenseClass, ucApplicationInfo1.FullName, FrmScheduleTest.enTestType.VisionTest);
                        frmSchedule.ShowDialog();
                        break;
                    case enTestType.WrittenTest:
                        FrmScheduleTest frmSchedule1 = new FrmScheduleTest(ucApplicationInfo1.LdlAppId, ucApplicationInfo1.LicenseClass, ucApplicationInfo1.FullName, FrmScheduleTest.enTestType.WrittenTest);
                        frmSchedule1.ShowDialog();
                        break;
                    case enTestType.StreetTest:
                        FrmScheduleTest frmSchedule2 = new FrmScheduleTest(ucApplicationInfo1.LdlAppId, ucApplicationInfo1.LicenseClass, ucApplicationInfo1.FullName, FrmScheduleTest.enTestType.StreetTest);
                        frmSchedule2.ShowDialog();
                        break;
                }
                _LoadTestAppointments();

            }
            else
            {
                MessageBox.Show("Person already has an appointment","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if((string)DgvTestAppointments.CurrentRow.Cells[3].Value == "Locked")
            {
                MessageBox.Show("Appointment is locked therefore cannot be edited", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (TestType)
            {

                case enTestType.VisionTest:
                    FrmScheduleTest frmSchedule = new FrmScheduleTest(ucApplicationInfo1.LdlAppId, 
                        ucApplicationInfo1.LicenseClass, ucApplicationInfo1.FullName, FrmScheduleTest.enTestType.VisionTest,
                        true, (int)DgvTestAppointments.CurrentRow.Cells[0].Value);
                    frmSchedule.ShowDialog();
                    break;
                case enTestType.WrittenTest:
                    FrmScheduleTest frmSchedule1 = new FrmScheduleTest(ucApplicationInfo1.LdlAppId, ucApplicationInfo1.LicenseClass, 
                        ucApplicationInfo1.FullName, FrmScheduleTest.enTestType.WrittenTest
                        , true, (int)DgvTestAppointments.CurrentRow.Cells[0].Value);
                    frmSchedule1.ShowDialog();
                    break;
                case enTestType.StreetTest:
                    FrmScheduleTest frmSchedule2 = new FrmScheduleTest(ucApplicationInfo1.LdlAppId,
                        ucApplicationInfo1.LicenseClass, ucApplicationInfo1.FullName, FrmScheduleTest.enTestType.StreetTest
                        ,true, (int)DgvTestAppointments.CurrentRow.Cells[0].Value);
                    frmSchedule2.ShowDialog();
                    break;
            }
            _LoadTestAppointments();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if ((string)DgvTestAppointments.CurrentRow.Cells[3].Value == "Locked")
            {
                MessageBox.Show("Test already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (TestType)
            {
                case enTestType.VisionTest:
                    frmTakeTest frmTakeTest = new frmTakeTest(ucApplicationInfo1.LdlAppId, (int)DgvTestAppointments.CurrentRow.Cells[0].Value
                       , ucApplicationInfo1.LicenseClass, ucApplicationInfo1.FullName, frmTakeTest.enTestType.VisionTest
                       , (DateTime)DgvTestAppointments.CurrentRow.Cells[1].Value);
                    frmTakeTest.ShowDialog();
                    break;
                case enTestType.WrittenTest:
                    frmTakeTest frmTakeTest1 = new frmTakeTest(ucApplicationInfo1.LdlAppId, (int)DgvTestAppointments.CurrentRow.Cells[0].Value
                       , ucApplicationInfo1.LicenseClass, ucApplicationInfo1.FullName, frmTakeTest.enTestType.WrittenTest
                       , (DateTime)DgvTestAppointments.CurrentRow.Cells[1].Value);
                    frmTakeTest1.ShowDialog();
                    break;
                case enTestType.StreetTest:
                    frmTakeTest frmTakeTest2 = new frmTakeTest(ucApplicationInfo1.LdlAppId, (int)DgvTestAppointments.CurrentRow.Cells[0].Value
                       , ucApplicationInfo1.LicenseClass, ucApplicationInfo1.FullName, frmTakeTest.enTestType.StreetTest
                       , (DateTime)DgvTestAppointments.CurrentRow.Cells[1].Value);
                    frmTakeTest2.ShowDialog();
                    break;
            }
            _LoadTestAppointments();

        }
    }
}
