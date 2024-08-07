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

namespace DVLD.Users
{
    public partial class frmUsersManagement : Form
    {

        private string _FilterChoice;
        public frmUsersManagement()
        {
            InitializeComponent();
        }
        private void _FilterSetting()
        {
            switch (CbFilter.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    _FilterChoice = "UserID";
                    break;
                case 2:
                    _FilterChoice = "UserName";
                    break;
                case 3:
                    _FilterChoice = "PersonID";
                    break;
                case 4:
                    _FilterChoice = "FullName";
                    break;
                case 5:
                    if(rbIsActive.Checked) 
                    {
                        _FilterChoice = "1";
                    }
                    else if(rbNotActive.Checked) 
                    {
                        _FilterChoice = "0";
                    }
                    break;
            }

        }

        private void _LoadAllUsers() 
        {


            DgvAllUsers.DataSource = clsUsers.GetAllUsers();

            lblNumberOfUsers.Text = DgvAllUsers.RowCount.ToString();

            
        }

        private void frmUsersManagement_Load(object sender, EventArgs e)
        {
            CbFilter.SelectedIndex = 0;
            _LoadAllUsers();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CbFilter.SelectedIndex == 0) 
            {
                // all is not visible
                txtFilter.Visible = false;
                rbNotActive.Visible = false;
                rbIsActive.Visible = false;
                _LoadAllUsers();
            }
            else if (CbFilter.SelectedIndex== 5)
            {
                // only shows radio button
                rbNotActive.Visible = true;
                rbIsActive.Visible = true;
                txtFilter.Visible = false;   
            }
            else
            {

                // only shows text boxx
                txtFilter.Visible = true;
                rbNotActive.Visible = false;
                rbIsActive.Visible = false;

            }
            _FilterSetting();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            //DGVAllPeople.DataSource = clsFilterByPeople.GetFilteredResult(_FilterChoice, txtFilter.Text);

            //LblNumberOfPeople.Text = DGVAllPeople.Rows.Count.ToString();

            DgvAllUsers.DataSource = clsFilterByUser.GetFilteredResult(_FilterChoice, txtFilter.Text);
            lblNumberOfUsers.Text = DgvAllUsers.RowCount.ToString();
        }

        private void rbIsActive_CheckedChanged(object sender, EventArgs e)
        {
            _FilterSetting();

            DgvAllUsers.DataSource = clsFilterByUser.GetFilteredResult(_FilterChoice, "1");
            lblNumberOfUsers.Text = DgvAllUsers.RowCount.ToString();

        }

        private void rbNotActive_CheckedChanged(object sender, EventArgs e)
        {
            _FilterSetting();

            DgvAllUsers.DataSource = clsFilterByUser.GetFilteredResult(_FilterChoice, "0");
            lblNumberOfUsers.Text = DgvAllUsers.RowCount.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented Yet");
        }
    }
}
