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
    public partial class FrmUpdateApplicationType : Form
    {
        public FrmUpdateApplicationType(int ApplicationID, string ApplicationType, decimal Fees)
        {
            InitializeComponent();
            lbliD.Text = ApplicationID.ToString();
            txtTitle.Text = ApplicationType;
            txtFees.Text = Fees.ToString();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {

                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (clsManageApplicationTypes.UpdateApplicationType(Convert.ToInt32(lbliD.Text), txtTitle.Text
                ,Convert.ToDecimal(txtFees.Text)))
            {
                MessageBox.Show("Application type updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtFees_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbliD_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
