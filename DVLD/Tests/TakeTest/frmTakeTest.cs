using BusinessLayerDVLD;
using DVLD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Tests.TakeTest
{
    public partial class frmTakeTest : Form
    {
            public enum enTestType { VisionTest, WrittenTest, StreetTest }
            enTestType TestType;
            int AppointmentID = -1;

        public frmTakeTest( int LdlAppID,int appointmentId, string DrivingClass, string FullName, enTestType testType,DateTime AppointmentDate)
        {
            InitializeComponent();
            lblDlAppId.Text = LdlAppID.ToString();
            lblDrivingClass.Text = DrivingClass.ToString();
            lblFees.Text = clsTakeTest.TestAppointmentFees(appointmentId).ToString();
            lblFullName.Text = FullName.ToString();
            TestType = testType;
            lblTestDate.Text = AppointmentDate.ToString();
             AppointmentID = appointmentId;
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            _LoadTestType();
        }
        public void _LoadTestType()
        {
            switch (TestType)
            {
                case enTestType.VisionTest:
                    PbTestPicture.Image = Resources.search;
                    GbScheduledTest.Text = "Vision Test";             
                    break;
                case enTestType.WrittenTest:
                    PbTestPicture.Image = Resources.test1;
                    GbScheduledTest.Text = "Written Test";
                    break;
                case enTestType.StreetTest:
                    PbTestPicture.Image = Resources.valet;
                    GbScheduledTest.Text = "Street Test";     
                    break;
            }
        }

        private byte TestPassOrFail()
        {
            if(RbPass.Checked)
            {
                return 1;
            }
            else if(RbFail.Checked)
            {
                return 0;
            }
            return 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you you want to save this test result? what is done cant be undone", "Save Result",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                lblTestID.Text = clsTakeTest.TakeTest(AppointmentID, TestPassOrFail(),
                txtNotes.Text, GlobalProperties.LoggedInUserID).ToString();
                btnSave.Enabled = false;
            }
            else
            {
                return;
            }
       
        }
    }
}
