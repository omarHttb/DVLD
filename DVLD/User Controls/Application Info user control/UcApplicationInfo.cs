using BusinessLayerDVLD;
using DVLD.FrmPeopleManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Application_Info_user_control
{

    
    public partial class UcApplicationInfo : UserControl
    {

        public int LdlAppId = -1;
        public string LicenseClass { get; set; }
        public int PassedTest { get; set; }
        public string FullName { get; set; }

        clsApplications _clsApplications = new clsApplications();

        public UcApplicationInfo()
        {
            InitializeComponent();

        }

        private void UcApplicationInfo_Load(object sender, EventArgs e)
        {
            lblDLAppId.Text = LdlAppId.ToString();
            LblAppliedForLicense.Text = LicenseClass;
            LblPassedTest.Text = PassedTest.ToString() + "/3";
            lblApplicantName.Text = FullName;
            LoadApplicationInformation();
        }

        private void LoadApplicationInformation()
        {
            if (LdlAppId != -1)
            {
                _clsApplications = clsApplications.GetApplicationBasicInfo(LdlAppId);

                lblAppId.Text = _clsApplications.ApplicationID.ToString();
                lblStatus.Text = StatusName(_clsApplications.ApplicationStatus);
                lblFees.Text = _clsApplications.PaidFees.ToString();
                LblType.Text = _clsApplications.ApplicationTypeID.ToString();
                lblDate.Text = _clsApplications.ApplicationDate.ToString();
                lblStatusDate.Text = _clsApplications.LastStatusDate.ToString();
                lblCreatedBy.Text = clsUsers.GetUserNameByUserId(_clsApplications.CreatedUserById);
            }
        }

        private string StatusName(byte Status)
        {
            switch (Status)
            {
                case 1:
                    return "New";
                case 2:
                    return "Cancelled";
                case 3:
                    return "Completed";
                default:
                    return "Null";
            }
        }

        private void lblViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonInfo frm = new frmPersonInfo(_clsApplications.ApplicantPersonID);
            frm.ShowDialog();
        }
    }
}
