using DataLayerDVLD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BusinessLayerDVLD.clsPeople;

namespace BusinessLayerDVLD
{
    public class clsCountries
    {
        public int ID { get; set; }
        public int NationalitiyCountryId { get; set; }
        public string CountryName { get; set; }

        public clsCountries(int id, 
           int nationalityCountryId,
           string countryName)
        {
            ID = id;
          NationalitiyCountryId   = nationalityCountryId ;
            CountryName = countryName;  


        }

        public static DataTable GetAllCountries()
        {
           return clsDataCountries.GetAllCountries();
        }


        public static clsCountries FindCountryPerson(int ID)
        {

            string countryName = "";

            int nationalityCountryId = -1;

            if (clsDataCountries.GetPersonCountry(ref ID,ref nationalityCountryId, ref countryName))

                return new clsCountries(ID, nationalityCountryId, countryName);

                
            else
                return null;

        }
    }
}
