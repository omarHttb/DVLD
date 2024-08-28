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

        public FrmScheduleTest(int DlAppId,string DrivingClass,string FullName,enTestType testType)
        {
            InitializeComponent();
            TestType = testType;
            lblDlAppId.Text = DlAppId.ToString();
            lblDrivingClass.Text = DrivingClass.ToString();
            lblFullName.Text = FullName.ToString();
            GbRetakeTestInfo.Enabled = false;
        }
        public FrmScheduleTest(int DlAppId, string DrivingClass, string FullName, enTestType testType
            ,bool isEditMode,int appointmentId)
        {
            InitializeComponent();
            TestType = testType;
            lblDlAppId.Text = DlAppId.ToString();
            lblDrivingClass.Text = DrivingClass.ToString();
            lblFullName.Text = FullName.ToString();
            GbRetakeTestInfo.Enabled = false;
            IsEditMode = isEditMode;
            AppointmentId = appointmentId;
        }

        private void FrmScheduleTest_Load(object sender, EventArgs e)
        {
            _LoadTestType();
            CalculateTotalFees();
            DtAppointmentDate.MinDate = DateTime.Now;
        }

        public void CalculateTotalFees()
        {
            _TotalFees = decimal.Parse(lblFees.Text + decimal.Parse(lblRAppFees.Text));
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsEditMode == false)
                {
                    // add new mode
                    switch (TestType)
                    {


                        case enTestType.VisionTest:
                            if (clsTestsAppointments.AddNewAppointment(1, Int32.Parse(lblDlAppId.Text), DtAppointmentDate.Value, _TotalFees
                                , GlobalProperties.LoggedInUserID, 0))
                            {
                                ShowSccuessMessage();
                            }
                            else
                            {
                                ShowErrorMessage();
                            }
                            break;
                        case enTestType.WrittenTest:
                            if (clsTestsAppointments.AddNewAppointment(2, Int32.Parse(lblDlAppId.Text), DtAppointmentDate.Value, _TotalFees
                                , GlobalProperties.LoggedInUserID, 0))
                            {
                                ShowSccuessMessage();
                            }
                            else
                            {
                                ShowErrorMessage();
                            }
                            break;
                        case enTestType.StreetTest:
                            if (clsTestsAppointments.AddNewAppointment(3, Int32.Parse(lblDlAppId.Text), DtAppointmentDate.Value, _TotalFees
                                , GlobalProperties.LoggedInUserID, 0))
                            {
                                ShowSccuessMessage();
                            }
                            else
                            {
                                ShowErrorMessage();
                            }
                            break;
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
            }

                catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
