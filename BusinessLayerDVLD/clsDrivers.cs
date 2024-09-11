using DataLayerDVLD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerDVLD
{
    public class clsDrivers
    {
        public static int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            return clsDataDrivers.AddNewDriver(PersonID, CreatedByUserID, CreatedDate);
        }

        public static DataTable GetAllDrivers()
        {
            return clsDataDrivers.GetAllDrivers();
        }

        //filter
        public static DataTable GetFilteredResult(string FilterSetting, string FilterTxt)
        {
            switch (FilterSetting)
            {
                case "PersonID":
                    return clsDataDrivers.GetFilteredDriversPersonID(FilterTxt);

                case "FullName":
                    return clsDataDrivers.GetFilteredDriversFullName(FilterTxt);

                case "NationalNo":
                    return clsDataDrivers.GetFilteredDriversNationalNo(FilterTxt);

                case "DriverID":
                    return clsDataDrivers.GetFilteredDriversDriverID(FilterTxt);
                default:
                    return null;
            }
        }

        public static int GetPersonIDByDriverID(int DriverID)
        {
            return clsDataDrivers.GetPersonIdByDriverID(DriverID);
        }
    }
}
