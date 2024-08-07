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

namespace DVLD
{

    
    
    public partial class FrmPeopleManagementForm : Form
    {
        private string _FilterChoice;

        public FrmPeopleManagementForm()
        {
            InitializeComponent();
        }
        
        private void _refreshgContactList()
        {
            DGVAllPeople.DataSource = clsPeople.GetAllPeople();
           
            LblNumberOfPeople.Text = DGVAllPeople.Rows.Count.ToString();
        }

        private void PeopleManagementForm_Load(object sender, EventArgs e)
        {
            _refreshgContactList();
            CbFilter.SelectedIndex = 0; 

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAddUpdatePerson frm = new FrmAddUpdatePerson();  

            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdatePerson frm = new FrmAddUpdatePerson((int)DGVAllPeople.CurrentRow.Cells[0].Value,true);
            frm.ShowDialog();
            _refreshgContactList();

        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this person?", "Delete",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2)== DialogResult.OK)
            {
                clsPeople.DeletePerson((int)DGVAllPeople.CurrentRow.Cells[0].Value);
                _refreshgContactList();

            }

        }

        private void DGVAllPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CbFilter.SelectedIndex == 0) 
            {
                _refreshgContactList();
                txtFilter.Visible = false;
            }
            else 
            {
                txtFilter.Visible=true;

            }

            FilterSetting();
            
        }

        private void FilterSetting()
        {
            switch(CbFilter.SelectedIndex)
            {
                case 0 :
                    break;
                case 1:
                    _FilterChoice = "PersonID";
                    break;
                case 2:
                     _FilterChoice = "NationalNo";
                    break;
                case 3:
                     _FilterChoice = "FirstName";
                     break;
                case 4:
                     _FilterChoice = "SecondName";
                    break;  
                case 5:
                     _FilterChoice = "ThirdName";
                    break;
                case 6:
                     _FilterChoice = "LastName";
                    break;
                case 7:
                    _FilterChoice = "Country";
                    break;
                case 8:
                    _FilterChoice = "Phone";
                    break;
                case 9:
                    _FilterChoice = "Email";
                    break;
            }

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {


            DGVAllPeople.DataSource = clsFilterBy.GetFilteredResult(_FilterChoice,txtFilter.Text);

            LblNumberOfPeople.Text = DGVAllPeople.Rows.Count.ToString();

        }



        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {

            // if filter is person id then only input it accepts is number
            if (CbFilter.SelectedIndex == 1)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void toolStripMenuViewInfo_Click(object sender, EventArgs e)
        {
            frmPersonInfo frm = new frmPersonInfo((int)DGVAllPeople.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            
        }
    }
}
