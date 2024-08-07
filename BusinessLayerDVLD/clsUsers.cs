using DataLayerDVLD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerDVLD
{
    public class clsUsers
    {
        public static DataTable GetAllUsers()
        {
           return clsDataUser.GetAllUsers();
        }
    }
}
