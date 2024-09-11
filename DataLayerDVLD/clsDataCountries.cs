using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerDVLD
{
    public class clsDataCountries
    {

        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT * FROM Countries";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dt;

        }


        public static bool GetPersonCountry(ref int ID,ref int NationalityCountryID,ref string CountryName)
        {

            bool isFound = false;
            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT       " +
                "  Countries.CountryName , People.NationalityCountryID\r\nFROM      " +
                "      People INNER JOIN\r\n      " +
                "   Countries ON People.NationalityCountryID = Countries.CountryID\r\n\t\t\t\t\t\t " +
                "where PersonID = @PersonID ;";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
 
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    CountryName = (string)reader["CountryName"];
                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isFound;
        }

    }
}
