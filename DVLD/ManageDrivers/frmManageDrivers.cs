using BusinessLayerDVLD;
using DVLD.License.Driver_License_Info;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.ManageDrivers
{
    public partial class frmManageDrivers : Form
    {

        private string filter = "";
        public frmManageDrivers()
        {
            InitializeComponent();
        }

        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            LoadDrivers();
            cbFilter.SelectedIndex = 0;
        }
        private void LoadDrivers() 
        {
            DgvDrivers.DataSource = clsDrivers.GetAllDrivers();
            lblRecords.Text = DgvDrivers.RowCount.ToString();   
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
//            Full Name
//National No
//Person ID
//Driver ID
            if(cbFilter.SelectedIndex == 0)
            {
                TxtFilter.Enabled = false;  
            }
            else
                TxtFilter.Enabled=true;
            switch (cbFilter.SelectedIndex)
            {
                case 0:
                    filter = "";
                    LoadDrivers();
                    
                    break;
                case 1:
                    filter = "FullName";
                        break;
                case 2:
                    filter = "NationalNo";
                    break;
                case 3:
                    filter = "PersonID";
                    break;
                case 4:
                    filter = "DriverID";
                    break;
            }
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            DgvDrivers.DataSource = clsDrivers.GetFilteredResult(filter,TxtFilter.Text);
            lblRecords.Text= DgvDrivers.RowCount.ToString();    
        }

        private void showLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory((int)DgvDrivers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();   
        }
    }

    
}
