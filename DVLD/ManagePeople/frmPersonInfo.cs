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

namespace DVLD.FrmPeopleManagement
{
    public partial class frmPersonInfo : Form
    {
     
        public frmPersonInfo(int PersonId = -1)
        {
            InitializeComponent();
     
      
                if (PersonId != -1)
                {
                    UcPersonDetails.PersonID = PersonId;
                }
            

        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPersonInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
