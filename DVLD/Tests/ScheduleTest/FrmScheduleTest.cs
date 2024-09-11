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

namespace DVLD.Tests.ScheduleTest
{
    public partial class FrmScheduleTest : Form
    {


        public enum enTestType { VisionTest, WrittenTest, StreetTest }
        enTestType TestType;

        private decimal _TotalFees = -1;
        private bool IsEditMode = false;
        int AppointmentId = -1;
        bool IsRetakeTest = false;
        clsApplications _clsApplications = new clsApplications();

        public FrmScheduleTest(int DlAppId,string DrivingClass,string FullName,enTestType testType,bool isRetakeTest
            , int trial)
        {
            InitializeComponent();
            TestType = testType;
            lblDlAppId.Text = DlAppId.ToString();
            lblDrivingClass.Text = DrivingClass.ToString();
            lblFullName.Text = FullName.ToString();
            IsRetakeTest = isRetakeTest;
            LblTrials.Text = trial.ToString();

        }
        public FrmScheduleTest(int DlAppId, string DrivingClass, string FullName, enTestType testType
            ,bool isEditMode,int appointmentId, int trial)
        {
            InitializeComponent();
            TestType = testType;
            lblDlAppId.Text = DlAppId.ToString();
            lblDrivingClass.Text = DrivingClass.ToString();
            lblFullName.Text = FullName.ToString();
            GbRetakeTestInfo.Enabled = false;
            IsEditMode = isEditMode;
            AppointmentId = appointmentId;
            LblTrials.Text = trial.ToString();
        }

        private void FrmScheduleTest_Load(object sender, EventArgs e)
        {
            _LoadTestType();
            DtAppointmentDate.MinDate = DateTime.Now;
            isRetakeTest();
            CalculateTotalFees();


        }

        private void ShowErrorMessage()
        {
            MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
        }
        private void ShowSccuessMessage()
        {
            MessageBox.Show("Appointment Added Successfully", "Success", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
        }

        public void CalculateTotalFees()
        {
            _TotalFees = decimal.Parse(lblFees.Text) + decimal.Parse(lblRAppFees.Text);
            lblTotalFees.Text = _TotalFees.ToString();
        }

        public void _LoadTestType()
        {
            switch (TestType)
            {
                case enTestType.VisionTest:
                    PbTestPicture.Image = Resources.search;
                    GbScheduleTest.Text = "Vision Test";
                    lblFees.Text = clsManageTestTypes.GetTestTypeFees(1).ToString();

                    break;
                case enTestType.WrittenTest:
                    PbTestPicture.Image = Resources.test1;
                    GbScheduleTest.Text = "Written Test";
                    lblFees.Text = clsManageTestTypes.GetTestTypeFees(2).ToString();

                    break;
                case enTestType.StreetTest:
                    PbTestPicture.Image = Resources.valet;
                    GbScheduleTest.Text = "Street Test";
                    lblFees.Text = clsManageTestTypes.GetTestTypeFees(3).ToString();
                    break;
            }
        }

        private void isRetakeTest()
        {
            if(IsRetakeTest == true)
            {
                GbRetakeTestInfo.Enabled = true;
                lblScheduleTest.Text = "Schedule Retake Test";
                lblRAppFees.Text = clsManageApplicationTypes.GetApplicationFees(8).ToString();
                return;
            }
            GbRetakeTestInfo.Enabled = false;
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void AddRetakeTestApplication()
        {
            _clsApplications.LastStatusDate = DateTime.Now;
            _clsApplications.PaidFees = Convert.ToDecimal( lblRAppFees.Text);
            _clsApplications.ApplicationTypeID = 8;
            _clsApplications.CreatedUserById = GlobalProperties.LoggedInUserID;
            _clsApplications.ApplicantPersonID = clsLocalDrivingLicenseApplication.GetPersonIdFromLocalDrivingLicenseAppID(int.Parse(lblDlAppId.Text));
            _clsApplications.ApplicationDate = DateTime.Now;
            _clsApplications.ApplicationStatus = 1;
            _clsApplications.Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsEditMode == false)
                {
                    if (IsRetakeTest == true)
                    {
                        AddRetakeTestApplication();
                    }
                    // add new mode
                   if (clsTestsAppointments.AddNewAppointment((int)TestType + 1, Int32.Parse(lblDlAppId.Text),
                       DtAppointmentDate.Value, _TotalFees , GlobalProperties.LoggedInUserID, 0))
                   {
                                
                     ShowSccuessMessage();
                   }
                   else
                   {
                    ShowErrorMessage();
                   }
                 
                }

                //edit mode
                else
                {
                    if(clsTestsAppointments.UpdateAppointmentDate(AppointmentId, DtAppointmentDate.Value))
                        MessageBox.Show("Appointment Updated Successfully", "Success", MessageBoxButtons.OK
                           , MessageBoxIcon.Information);
                    else
                    {
                        ShowErrorMessage();
                    }
                }
                this.Close();
            }
            
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
