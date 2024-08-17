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

namespace DVLD.ManageTestTypes
{
    public partial class frmUpdateTestType : Form
    {
        public frmUpdateTestType(int testID,string TestTitle,string TestDescription,decimal fees )
        {
            InitializeComponent();
            lbliD.Text = testID.ToString();
            txtTitle.Text = TestTitle;
            txtDescription.Text = TestDescription;
            txtFees.Text = fees.ToString();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (clsManageTestTypes.UpdateTestTypes(Convert.ToInt32(lbliD.Text), txtTitle.Text
                , txtDescription.Text, Convert.ToDecimal(txtFees.Text)))
            {
                MessageBox.Show("Test type updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
