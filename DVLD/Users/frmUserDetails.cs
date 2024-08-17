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
    public partial class frmUserDetails : Form
    {


        public frmUserDetails(int UserID,int PersonID)
        {
            InitializeComponent();
            UcUserDetails.UserID = UserID;
            UcPersonDetails.PersonID = PersonID;
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
