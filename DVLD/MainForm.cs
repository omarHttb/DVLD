using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DVLD.Users;

namespace DVLD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           FrmPeopleManagementForm frm = new FrmPeopleManagementForm();

            frm.ShowDialog();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("not implemented yet");

        }

        private void BtnApplication_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not implemented yet");
        }

        private void BtnDrivers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not implemented yet");

        }

        private void button2_Click(object sender, EventArgs e)
        {
           frmUsersManagement frmUsersManagement = new frmUsersManagement();
            frmUsersManagement.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
    }
}
