using BusinessLayerDVLD;
using DVLD.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD.Login
{
    public partial class frmLogin : Form
    {
        private string FilePath = @"G:\windowsForms\DVLD PROJ\DVLD\RememberMe.txt";
        public frmLogin()
        {
            InitializeComponent();
            LoadCredentials();
        }

        private bool CheckUserName()
        {
            if (clsUsers.IsUserNameExist(txtUserNameLogin.Text.Trim()))
            {
                return true;
            }
            return false;
        }
        private bool CheckPassword()
        {
            if (clsUsers.GetPassword(txtUserNameLogin.Text) == TxtPasswordLogin.Text.Trim())
            {
                return true;
            }
            else
                return false;

        }

        private bool IsUserActive()
        {
            if (clsUsers.IsUserActive(txtUserNameLogin.Text.Trim()) == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChkRmemeberMe.Checked)
                {
                    SaveCredentials(txtUserNameLogin.Text, TxtPasswordLogin.Text);
                }
                else
                {
                    ClearCredentials();
                }

                if (!CheckUserName())
                {
                    MessageBox.Show("User name does not exist", "Login error", MessageBoxButtons.OK
                                    , MessageBoxIcon.Error);
                    return;
                }

                if (!IsUserActive())
                {
                    MessageBox.Show("User is not active", "Login error", MessageBoxButtons.OK
                                    , MessageBoxIcon.Error);
                    return;
                }

                if (CheckPassword())
                {
                    MainForm frm = new MainForm(txtUserNameLogin.Text.Trim());

                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("invalid password", "Login error", MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Rememberme logic
        private void SaveCredentials(string username, string password)
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                writer.WriteLine(username);
                writer.WriteLine(password);
            }
        }

        private void ClearCredentials()
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                writer.Write(""); // Clear the contents by writing an empty string
            }
        }

        private void LoadCredentials()
        {
            if (File.Exists(FilePath))
            {
                string[] lines = File.ReadAllLines(FilePath);
                if (lines.Length == 2)
                {
                    txtUserNameLogin.Text = lines[0];
                    TxtPasswordLogin.Text = lines[1];
                    ChkRmemeberMe.Checked = true;
                }
            }

        }


    }
}