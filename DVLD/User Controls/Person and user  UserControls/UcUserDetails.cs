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

namespace DVLD.UserControls
{
    public partial class UcUserDetails : UserControl
    {
        clsUsers _clsUsers = new clsUsers();
        public UcUserDetails()
        {
            InitializeComponent();
        }
        public static int UserID = -1;

        private void UcUserDetails_Load(object sender, EventArgs e)
        {
                _LoadUserInformation(); 


        }

        private void _LoadUserInformation()
        {
            if(UserID != -1) 
            {
               _clsUsers =  clsUsers.FindUserById(UserID);
                lblIsActive.Text = _clsUsers.isActiveString;
                lblUserName.Text = _clsUsers.UserName;
                lblUserID.Text = UserID.ToString();
                
            }
        }
 

        private void lblUserID_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
