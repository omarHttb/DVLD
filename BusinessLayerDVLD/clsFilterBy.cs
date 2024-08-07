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
    public class clsFilterBy
    {

        public static DataTable GetFilteredResult(string FilterSetting,string FilterTxt)
        {
            switch (FilterSetting) 
            {
                case "PersonID":
                   return clsDataFilterBy.GetFilteredResultByPersonId(FilterTxt); 
                    
                case "Country":
                    return clsDataFilterBy.GetFilteredResultByCountry(FilterTxt); 
                    
                case "FirstName":
                    return clsDataFilterBy.GetFilteredResultByFirstName(FilterTxt);
                   
                case "SecondName":
                    return clsDataFilterBy.GetFilteredResultBySecondName(FilterTxt);
                    
                case "ThirdName":
                    return clsDataFilterBy.GetFilteredResultByThirdName(FilterTxt);
                   
                case "LastName":
                    return clsDataFilterBy.GetFilteredResultByLastName(FilterTxt);
                   
                case "Phone" :
                    return clsDataFilterBy.GetFilteredResultByPhone(FilterTxt);
                   
                case "Email":
                    return clsDataFilterBy.GetFilteredResultByEmail(FilterTxt);
                   
                case "NationalNo":
                    return clsDataFilterBy.GetFilteredResultByNationalitiyNumber(FilterTxt);

                 default:
                    return null;
            }
        }
    }
}
