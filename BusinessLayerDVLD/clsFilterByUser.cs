using DataLayerDVLD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerDVLD
{
    public class clsFilterByUser
    {
        public static DataTable GetFilteredResult(string FilterSetting, string FilterTxt)
        {
            switch (FilterSetting)
            {
                case "PersonID":
                    return clsDataFilterByUser.GetFilteredResultByPersonID(FilterTxt);

                case "UserID":
                    return clsDataFilterByUser.GetFilteredResultByUserID(FilterTxt);

                case "UserName":
                    return clsDataFilterByUser.GetFilteredResultByUserName(FilterTxt);

                case "FullName":
                    return clsDataFilterByUser.GetFilteredResultByFullName(FilterTxt);
                case "1":
                case "0":
                    // code above mean 1 or 0
                    return clsDataFilterByUser.GetFilteredResultByActive(FilterTxt);
                default:
                    return null;
            }
        }
        }
}
