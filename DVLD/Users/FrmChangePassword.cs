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
    public partial class FrmChangePassword : Form
    {
        private string _oldPassword;

        public FrmChangePassword(int UserID, int PersonID)
        {
            InitializeComponent();
            UcPersonDetails.PersonID = PersonID;
            UcUserDetails.UserID = UserID;  

        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            _oldPassword = clsUsers.GetPassword(UcUserDetails.UserID);
        }

        private void TxtOldPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(TxtOldPassword.Text)) 
            {
                EpUserPassword.SetError(TxtOldPassword, "field is empty");
            }
            else if ( _oldPassword != TxtOldPassword.Text)
            {
                EpUserPassword.SetError(TxtOldPassword, "password is not the same as current password");

            }
            else 
            {
                EpUserPassword.SetError(TxtOldPassword, "");
            }
        }
        


        private void TxtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(TxtNewPassword.Text))
            {
                EpUserPassword.SetError(TxtNewPassword, "field is empty");
            }
            else
            {
                EpUserPassword.SetError(TxtNewPassword, "");
            }
        }

        private void TxtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(TxtConfirmPassword.Text)) 
            {
                EpUserPassword.SetError(TxtConfirmPassword, "field is empty");

            }
            else if(TxtConfirmPassword.Text != TxtNewPassword.Text) 
            {
                EpUserPassword.SetError(TxtConfirmPassword, "Confirm password does not match new password");

            }
            else
            {
                EpUserPassword.SetError(TxtConfirmPassword, "");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ValidateFields()
        {
            if(TxtConfirmPassword.Text != "" && TxtNewPassword.Text != "" && TxtOldPassword.Text != "")
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {


                if (ValidateFields())
                {
                    if (clsUsers.UpdatePassword(UcUserDetails.UserID, TxtConfirmPassword.Text))
                    {
                        MessageBox.Show("Password Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Some fields are empty", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
