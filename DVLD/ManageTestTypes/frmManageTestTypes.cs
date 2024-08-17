using BusinessLayerDVLD;
using DVLD.ManageApplicationTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.ManageTestTypes
{
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
            _RefreshTestTypes();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _RefreshTestTypes()
        {
            DgvTestTypes.DataSource = clsManageTestTypes.GetAllTestTypes();
            lblNumberOfRecords.Text = DgvTestTypes.RowCount.ToString();
            DgvTestTypes.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvTestTypes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmUpdateApplicationType frm = new FrmUpdateApplicationType(
            //    (int)DgvApplicationTypes.CurrentRow.Cells[0].Value,
            //    (string)DgvApplicationTypes.CurrentRow.Cells[1].Value,
            //    (decimal)DgvApplicationTypes.CurrentRow.Cells[2].Value);
            //frm.ShowDialog();
            //_RefreshApplicationTypesData();
            frmUpdateTestType frm = new frmUpdateTestType((int)DgvTestTypes.CurrentRow.Cells[0].Value,
                (string)DgvTestTypes.CurrentRow.Cells[1].Value,(string)DgvTestTypes.CurrentRow.Cells[2].Value,
                (decimal)DgvTestTypes.CurrentRow.Cells[3].Value);
            frm.ShowDialog();
            _RefreshTestTypes();
        }
    }
}
