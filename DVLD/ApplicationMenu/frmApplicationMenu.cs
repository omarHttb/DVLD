using DVLD.ManageApplicationTypes;
using DVLD.ManageTestTypes;
using DVLD.NewDrivingLicense;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmApplicationMenu : Form
    {
        public frmApplicationMenu()
        {
            InitializeComponent();
        }

        private void btnManageApplicationTypes_Click(object sender, EventArgs e)
        {
           frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
       }

        private void btnManageTestTypes_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not implemented yet");
        }

        private void BtnApplications_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not implemented yet");

        }

        private void btnDrivingLicense_Click(object sender, EventArgs e)
        {

            pnlDrivingLicenseServiceMenu.Visible = true;
        }

        private void btnLocalLicense_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingLicense frm = new frmNewLocalDrivingLicense();    

            frm.ShowDialog();
        }
    }
}
