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

namespace DVLD.ManageApplicationTypes
{
    public partial class frmManageApplicationTypes : Form
    {
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void _RefreshApplicationTypesData()
        {
            DgvApplicationTypes.DataSource = clsManageApplicationTypes.GetAllApplicationTypes();

            lblNumberOfRecords.Text = DgvApplicationTypes.RowCount.ToString();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _RefreshApplicationTypesData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdateApplicationType frm = new FrmUpdateApplicationType(
                (int)DgvApplicationTypes.CurrentRow.Cells[0].Value,
                (string)DgvApplicationTypes.CurrentRow.Cells[1].Value,
                (decimal)DgvApplicationTypes.CurrentRow.Cells[2].Value);
            frm.ShowDialog();
            _RefreshApplicationTypesData();

        }

        private void frmManageApplicationTypes_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

 
        //(int) DgvAllUsers.CurrentRow.Cells[0].Value, (int) DgvAllUsers.CurrentRow.Cells[1].Value
    }
}
