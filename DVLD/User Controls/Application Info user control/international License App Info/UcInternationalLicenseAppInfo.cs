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

namespace DVLD.User_Controls.Application_Info_user_control.international_License_App_Info
{
    public partial class UcInternationalLicenseAppInfo : UserControl
    {
        public UcInternationalLicenseAppInfo()
        {
            InitializeComponent();
        }

        private void UcInternationalLicenseAppInfo_Load(object sender, EventArgs e)
        {
            lblAppDate.Text = DateTime.Now.ToString();
            lblIssueDate.Text = DateTime.Now.ToString();
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToString();
            lblCreatedBy.Text = GlobalProperties.LoggedInUserName;
            lblFees.Text = clsManageApplicationTypes.GetApplicationFees(6).ToString();
        }
        
        public void LoadLocalLicensesID(string LocalLicenseId)
        {
        }
        private void LoadInternationalLicensesID()
        {

        }
        private void LoadInternationalApplicationID()
        {

        }


    }
}
