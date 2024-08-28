using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.User_Controls.Tests_and_test_appointments_User_controls
{
    public partial class UcScheduleTest : UserControl
    {

        public int LdlAppId { get; set; }
        public string LicenseClass { get; set; }
        public string FullName { get; set; }

        enum enTestType {VisionTest = 1 , WrittenTest = 2 , StreetTest = 3  }

        enTestType TestType;

        public UcScheduleTest()
        {
            InitializeComponent();
        }


    }
}
