using BusinessLayerDVLD;
using DVLD.UserControls;
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
    public partial class frmAddUser : Form
    {

        clsUsers _User = new clsUsers();

        //for checking if same username as original when updating
        //this is for that there cant be 2 users with the same UserName system
        string CheckIfSameUserNameAsOriginal = "";

        public frmAddUser()
        {
            InitializeComponent();
        }


        public frmAddUser(int PersonID,int UserID ,string UserName,string IsActiveOrNot)
        {
            InitializeComponent();
            clsUsers.Mode = clsUsers._enMode.UpdateMode;
            ucSearchForPerson1.PersonID = PersonID;
            _User.UserID = UserID;
            _EditMode();
            txtUserName.Text = UserName;
            CheckIfSameUserNameAsOriginal = UserName;
            if (IsActiveOrNot == "Active")
            {
                ChkActive.Checked = true;
            }
            else
            {
                ChkActive.Checked = false;
            }
        }

        private void _EditMode()
        {
            BtnSave.Enabled = true;
            TcNewUser.SelectTab(1);
            ucSearchForPerson1.UpdateModeByPersonId();

            ucSearchForPerson1.LoadPersonInfo();
            lblMode.Text = "Update User";
            LblUserID.Text = _User.UserID.ToString();
            TxtPassword.Text = clsUsers.GetPassword(_User.UserID);
            TxtConfirmPassword.Text = TxtPassword.Text;
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {

            if (ucSearchForPerson1.PersonID == -1)
            {
                MessageBox.Show("No person information detected","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (clsUsers.isUserExist(ucSearchForPerson1.PersonID) == true )
            {
                if (lblMode.Text != "Update User")
                {
                    MessageBox.Show("User Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    TcNewUser.SelectTab(1);
                    BtnSave.Enabled = true;

                }
            }
            else
            {
                TcNewUser.SelectTab(1);
                BtnSave.Enabled = true;

            }
        }


        // Validating 
        //________________________________________________________________________________________________
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                EpAddNewUser.SetError(txtUserName, "please type user name");


            }
            else
            {
                EpAddNewUser.SetError(txtUserName, "");

            }
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                EpAddNewUser.SetError(TxtPassword, "please type password");

            }
            else
            {
                EpAddNewUser.SetError(TxtPassword, "");

            }
        }

        private void TxtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (TxtConfirmPassword.Text != TxtPassword.Text && TxtConfirmPassword.Text != "")
            {
                EpAddNewUser.SetError(TxtConfirmPassword, "field does not match password");
            }
            else
            {
                EpAddNewUser.SetError(TxtConfirmPassword, "");

            }
        }
        // Validating  end
        //________________________________________________________________________________________________
    
        private short CheckActiveOrNot()
        {
            if (ChkActive.Checked == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public bool IsUserNameExist()
        {
            if (lblMode.Text == "Update User")
            {
                // if username is the same as the current one then error wont show
                if (txtUserName.Text == CheckIfSameUserNameAsOriginal)
                {
                    return false;
                }
                else if (clsUsers.IsUserNameExist(txtUserName.Text))
                {
                    return true;
                }

            }
            else if(clsUsers.IsUserNameExist(txtUserName.Text))
            {
                return true;
            }
            return false;
        }
        

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(IsUserNameExist()) 
                {

                    MessageBox.Show("User name already exist , please choose another user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (TxtPassword.Text != "" && TxtConfirmPassword.Text != "" && txtUserName.Text != "")
                {
                    _User.UserName = txtUserName.Text;

                    _User.Password = TxtPassword.Text;
                    _User.PersonID = ucSearchForPerson1.PersonID;

                    _User.IsActive = CheckActiveOrNot();

                    if(!_User.Save())
                    {
                        MessageBox.Show("Something Went Wrong");
                    }
                    else
                    {
                        if(lblMode.Text != "Update User")
                        MessageBox.Show("User Added Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        else
                        {
                        MessageBox.Show("User Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    LblUserID.Text = _User.UserID.ToString();
                    lblMode.Text = "Update User";
                    ucSearchForPerson1.UpdateModeByPersonId();

                    

                }
                else
                {
                    MessageBox.Show("Some Fields are empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
