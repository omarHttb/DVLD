using DataLayerDVLD;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerDVLD
{
    public class clsFilterByPeople
    {

        public static DataTable GetFilteredResult(string FilterSetting,string FilterTxt)
        {
            switch (FilterSetting)
            {
                case "PersonID":
                    return clsDataFilterByPeople.GetFilteredResultByPersonId(FilterTxt);

                case "Country":
                    return clsDataFilterByPeople.GetFilteredResultByCountry(FilterTxt);

                case "FirstName":
                    return clsDataFilterByPeople.GetFilteredResultByFirstName(FilterTxt);

                case "SecondName":
                    return clsDataFilterByPeople.GetFilteredResultBySecondName(FilterTxt);

                case "ThirdName":
                    return clsDataFilterByPeople.GetFilteredResultByThirdName(FilterTxt);

                case "LastName":
                    return clsDataFilterByPeople.GetFilteredResultByLastName(FilterTxt);

                case "Phone":
                    return clsDataFilterByPeople.GetFilteredResultByPhone(FilterTxt);

                case "Email":
                    return clsDataFilterByPeople.GetFilteredResultByEmail(FilterTxt);

                case "NationalNo":
                    return clsDataFilterByPeople.GetFilteredResultByNationalitiyNumber(FilterTxt);

                default:
                    return null;
            }
        }
    }
}
