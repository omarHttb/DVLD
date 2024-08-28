using BusinessLayerDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.NewDrivingLicense
{
    public partial class frmNewLocalDrivingLicense : Form
    {
        clsApplications _clsApplications = new clsApplications();   
        clsLocalDrivingLicenseApplication _clsLocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();

        public frmNewLocalDrivingLicense()
        {
            InitializeComponent();
            _LoadLicenseClasses();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblFees.Text = clsManageApplicationTypes.GetApplicationFees(1).ToString();
            lblCreatedBy.Text = GlobalProperties.LoggedInUserName;
        }

        public frmNewLocalDrivingLicense(string NationalNo,int LocalDLApplicationId,int passedTest)
        {
           InitializeComponent();
           _LoadLicenseClasses();
           lblMode.Text = "Update Local Driving License Application";

            lblDate.Text = clsLocalDrivingLicenseApplication.GetLocalApplicationDate(LocalDLApplicationId).ToString();
            lblFees.Text = "15";
            lblCreatedBy.Text = GlobalProperties.LoggedInUserName;

            ucSearchForPerson1.NationalNo = NationalNo;
            ucSearchForPerson1.UpdateModeByNationalNo();
            ucSearchForPerson1.LoadPersonInfo();

           lblApplicationID.Text = LocalDLApplicationId.ToString();
           cbLicensesClasses.SelectedIndex = clsLocalDrivingLicenseApplication.GetLicenseClassFromLLdAppId(LocalDLApplicationId) - 1 ;

           BtnSave.Enabled = true;
           btnNextPage.Enabled = false;
           TcLocalDrivingLicenseApplication.SelectTab(1);

           _clsLocalDrivingLicenseApplication.IsUpdateMode = true;

            if(passedTest > 0 )
            {
                cbLicensesClasses.Enabled = false;
                BtnSave.Enabled = false ;
                lblMode.Text = "Cant Edit because application is in progress";
            }
        }


       
        // close form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadLicenseClasses()
        {
            DataTable dt = clsApplications.GetAllApplicationLicenseClass();

            foreach (DataRow dr in dt.Rows)
            {
                cbLicensesClasses.Items.Add(dr[1]);
            }

            cbLicensesClasses.SelectedIndex = 2;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (ucSearchForPerson1.PersonID == -1)
            {
                MessageBox.Show("No person information detected", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
               
                    TcLocalDrivingLicenseApplication.SelectTab(1);
                    BtnSave.Enabled = true;

            }
        }

        private bool _CheckAgeUnder18()
        {
            if(ucSearchForPerson1.Age < 21)
                return true;
            else
                return false;
        }

        private bool _CheckIfPersonEligableForLicenseClass()
        {
            if(_CheckAgeUnder18())
            {
                if (cbLicensesClasses.SelectedIndex != 0 && cbLicensesClasses.SelectedIndex != 2)
                {
                    MessageBox.Show("Person is under 21 therefore he is not eligable for this " +
                        "license class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return true;
                }
                return false;
            }
            return false;
        }

        // checks if person has more than one application with the same licenes class
        // or if user application with same license class is cancelled 
        private bool _IsPersonHasMoreThanOneApplicationOfSameLicenseClassOrApplicationCancelled()
        {
            // if user has canclled application then it will return false
            if(clsLocalDrivingLicenseApplication.DoesPersonHaveActiveLocalApplicationWithSameLicenseClass(
                ucSearchForPerson1.PersonID, cbLicensesClasses.SelectedIndex + 1)
                && 
                clsLocalDrivingLicenseApplication.IsPersonApplicationCanceled(ucSearchForPerson1.PersonID,
                    cbLicensesClasses.SelectedIndex + 1) != 2)
            {


                MessageBox.Show("Person already has an application of the same kind", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return true;

            }
            return false;
        }

        private bool _SaveApplication()
        {
            if (_clsLocalDrivingLicenseApplication.IsUpdateMode == false)
            {
                _clsApplications.Save();
                _clsLocalDrivingLicenseApplication.ApplicationID = _clsApplications.ApplicationID;


            }
            else
            {
                _clsLocalDrivingLicenseApplication.LocalLicensesID = Convert.ToInt32( lblApplicationID.Text);
            }

             _clsLocalDrivingLicenseApplication.LicenseClassID = cbLicensesClasses.SelectedIndex + 1;


            if (_clsLocalDrivingLicenseApplication.Save())
            {
              lblApplicationID.Text = _clsLocalDrivingLicenseApplication.LocalLicensesID.ToString();
              lblMode.Text = "Update Local Driving License Application";
              _clsLocalDrivingLicenseApplication.IsUpdateMode = true;
               return true;
             }
            
                 return false;
        }
        

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
            if(_CheckIfPersonEligableForLicenseClass())
            {
                    return;
            }

            if(_IsPersonHasMoreThanOneApplicationOfSameLicenseClassOrApplicationCancelled())
            {
               return;
            }

             if(lblMode.Text != "Update Local Driving License Application")
                {
                       
                       _clsApplications.ApplicationDate = DateTime.Now;
                       _clsApplications.ApplicationTypeID = 1;
                       _clsApplications.ApplicationStatus = 1;
                       _clsApplications.PaidFees = Convert.ToDecimal( lblFees.Text);
                       _clsApplications.CreatedUserById = GlobalProperties.LoggedInUserID;
                       _clsApplications.ApplicantPersonID = ucSearchForPerson1.PersonID;
                }
                _clsApplications.LastStatusDate = DateTime.Now;


                if (_SaveApplication())
                {

                    MessageBox.Show("Application Saved Successfully", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Something went wrong ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            } 
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
