using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataLayerDVLD
{
    public class clsDataFilterByPeople
    {
        public static DataTable GetFilteredResultByCountry(string TxtFilter)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT  \r\n          " +
                "        [PersonID]\r\n             " +
                "    ,[NationalNo]\r\n              " +
                "   ,[FirstName]\r\n             " +
                "    ,[SecondName]\r\n            " +
                "     ,[ThirdName]\r\n            " +
                "     ,[LastName]\r\n              " +
                "   ,Countries.CountryName as Country\r\n      " +
                "           ,[DateOfBirth],\r\n            " +
                "      CASE  \r\n              " +
                "    WHEN Gendor = 0 THEN 'Male'\r\n      " +
                "            WHEN Gendor = 1 THEN 'Female'\r\n     " +
                "             ELSE 'Unknown'  \r\n         " +
                "         END as gender\r\n                " +
                "  ,[Phone]   \r\n                  ,[Email]\r\n    " +
                "              FROM people  " +
                " join Countries   on People.NationalityCountryID = Countries.CountryID\r\n\t\t\t\t " +
                " where CountryName like @TxtFilter";




            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TxtFilter", "%" + TxtFilter + "%");


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

        public static DataTable GetFilteredResultByFirstName(string TxtFilter)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT  \r\n          " +
                "        [PersonID]\r\n             " +
                "    ,[NationalNo]\r\n              " +
                "   ,[FirstName]\r\n             " +
                "    ,[SecondName]\r\n            " +
                "     ,[ThirdName]\r\n            " +
                "     ,[LastName]\r\n              " +
                "   ,Countries.CountryName as Country\r\n      " +
                "           ,[DateOfBirth],\r\n            " +
                "      CASE  \r\n              " +
                "    WHEN Gendor = 0 THEN 'Male'\r\n      " +
                "            WHEN Gendor = 1 THEN 'Female'\r\n     " +
                "             ELSE 'Unknown'  \r\n         " +
                "         END as gender\r\n                " +
                "  ,[Phone]   \r\n                  ,[Email]\r\n    " +
                "              FROM people  " +
                " join Countries   on People.NationalityCountryID = Countries.CountryID\r\n\t\t\t\t " +
                " where FirstName like @TxtFilter";




            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TxtFilter", "%" + TxtFilter + "%");


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

        public static DataTable GetFilteredResultBySecondName(string TxtFilter)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT  \r\n          " +
                "        [PersonID]\r\n             " +
                "    ,[NationalNo]\r\n              " +
                "   ,[FirstName]\r\n             " +
                "    ,[SecondName]\r\n            " +
                "     ,[ThirdName]\r\n            " +
                "     ,[LastName]\r\n              " +
                "   ,Countries.CountryName as Country\r\n      " +
                "           ,[DateOfBirth],\r\n            " +
                "      CASE  \r\n              " +
                "    WHEN Gendor = 0 THEN 'Male'\r\n      " +
                "            WHEN Gendor = 1 THEN 'Female'\r\n     " +
                "             ELSE 'Unknown'  \r\n         " +
                "         END as gender\r\n                " +
                "  ,[Phone]   \r\n                  ,[Email]\r\n    " +
                "              FROM people  " +
                " join Countries   on People.NationalityCountryID = Countries.CountryID\r\n\t\t\t\t " +
                " where SecondName like @TxtFilter";




            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TxtFilter", "%" + TxtFilter + "%");


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
        public static DataTable GetFilteredResultByThirdName(string TxtFilter)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT  \r\n          " +
                "        [PersonID]\r\n             " +
                "    ,[NationalNo]\r\n              " +
                "   ,[FirstName]\r\n             " +
                "    ,[SecondName]\r\n            " +
                "     ,[ThirdName]\r\n            " +
                "     ,[LastName]\r\n              " +
                "   ,Countries.CountryName as Country\r\n      " +
                "           ,[DateOfBirth],\r\n            " +
                "      CASE  \r\n              " +
                "    WHEN Gendor = 0 THEN 'Male'\r\n      " +
                "            WHEN Gendor = 1 THEN 'Female'\r\n     " +
                "             ELSE 'Unknown'  \r\n         " +
                "         END as gender\r\n                " +
                "  ,[Phone]   \r\n                  ,[Email]\r\n    " +
                "              FROM people  " +
                " join Countries   on People.NationalityCountryID = Countries.CountryID\r\n\t\t\t\t " +
                " where ThirdName like @TxtFilter";




            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TxtFilter", "%" + TxtFilter + "%");


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

        public static DataTable GetFilteredResultByLastName(string TxtFilter)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT  \r\n          " +
                "        [PersonID]\r\n             " +
                "    ,[NationalNo]\r\n              " +
                "   ,[FirstName]\r\n             " +
                "    ,[SecondName]\r\n            " +
                "     ,[ThirdName]\r\n            " +
                "     ,[LastName]\r\n              " +
                "   ,Countries.CountryName as Country\r\n      " +
                "           ,[DateOfBirth],\r\n            " +
                "      CASE  \r\n              " +
                "    WHEN Gendor = 0 THEN 'Male'\r\n      " +
                "            WHEN Gendor = 1 THEN 'Female'\r\n     " +
                "             ELSE 'Unknown'  \r\n         " +
                "         END as gender\r\n                " +
                "  ,[Phone]   \r\n                  ,[Email]\r\n    " +
                "              FROM people  " +
                " join Countries   on People.NationalityCountryID = Countries.CountryID\r\n\t\t\t\t " +
                " where LastName like @TxtFilter";




            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TxtFilter", "%" + TxtFilter + "%");


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
        public static DataTable GetFilteredResultByNationalitiyNumber(string TxtFilter)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT  \r\n          " +
                "        [PersonID]\r\n             " +
                "    ,[NationalNo]\r\n              " +
                "   ,[FirstName]\r\n             " +
                "    ,[SecondName]\r\n            " +
                "     ,[ThirdName]\r\n            " +
                "     ,[LastName]\r\n              " +
                "   ,Countries.CountryName as Country\r\n      " +
                "           ,[DateOfBirth],\r\n            " +
                "      CASE  \r\n              " +
                "    WHEN Gendor = 0 THEN 'Male'\r\n      " +
                "            WHEN Gendor = 1 THEN 'Female'\r\n     " +
                "             ELSE 'Unknown'  \r\n         " +
                "         END as gender\r\n                " +
                "  ,[Phone]   \r\n                  ,[Email]\r\n    " +
                "              FROM people  " +
                " join Countries   on People.NationalityCountryID = Countries.CountryID\r\n\t\t\t\t " +
                " where NationalNo like @TxtFilter";




            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TxtFilter", "%" + TxtFilter + "%");


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
        public static DataTable GetFilteredResultByPersonId(string TxtFilter)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT  \r\n          " +
                "        [PersonID]\r\n             " +
                "    ,[NationalNo]\r\n              " +
                "   ,[FirstName]\r\n             " +
                "    ,[SecondName]\r\n            " +
                "     ,[ThirdName]\r\n            " +
                "     ,[LastName]\r\n              " +
                "   ,Countries.CountryName as Country\r\n      " +
                "           ,[DateOfBirth],\r\n            " +
                "      CASE  \r\n              " +
                "    WHEN Gendor = 0 THEN 'Male'\r\n      " +
                "            WHEN Gendor = 1 THEN 'Female'\r\n     " +
                "             ELSE 'Unknown'  \r\n         " +
                "         END as gender\r\n                " +
                "  ,[Phone]   \r\n                  ,[Email]\r\n    " +
                "              FROM people  " +
                " join Countries   on People.NationalityCountryID = Countries.CountryID\r\n\t\t\t\t " +
                " where PersonID like @TxtFilter";




            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TxtFilter", "%" + TxtFilter + "%");


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
        public static DataTable GetFilteredResultByPhone(string TxtFilter)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT  \r\n          " +
                "        [PersonID]\r\n             " +
                "    ,[NationalNo]\r\n              " +
                "   ,[FirstName]\r\n             " +
                "    ,[SecondName]\r\n            " +
                "     ,[ThirdName]\r\n            " +
                "     ,[LastName]\r\n              " +
                "   ,Countries.CountryName as Country\r\n      " +
                "           ,[DateOfBirth],\r\n            " +
                "      CASE  \r\n              " +
                "    WHEN Gendor = 0 THEN 'Male'\r\n      " +
                "            WHEN Gendor = 1 THEN 'Female'\r\n     " +
                "             ELSE 'Unknown'  \r\n         " +
                "         END as gender\r\n                " +
                "  ,[Phone]   \r\n                  ,[Email]\r\n    " +
                "              FROM people  " +
                " join Countries   on People.NationalityCountryID = Countries.CountryID\r\n\t\t\t\t " +
                " where Phone like @TxtFilter";




            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TxtFilter", "%" + TxtFilter + "%");


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
        public static DataTable GetFilteredResultByEmail(string TxtFilter)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT  \r\n          " +
                "        [PersonID]\r\n             " +
                "    ,[NationalNo]\r\n              " +
                "   ,[FirstName]\r\n             " +
                "    ,[SecondName]\r\n            " +
                "     ,[ThirdName]\r\n            " +
                "     ,[LastName]\r\n              " +
                "   ,Countries.CountryName as Country\r\n      " +
                "           ,[DateOfBirth],\r\n            " +
                "      CASE  \r\n              " +
                "    WHEN Gendor = 0 THEN 'Male'\r\n      " +
                "            WHEN Gendor = 1 THEN 'Female'\r\n     " +
                "             ELSE 'Unknown'  \r\n         " +
                "         END as gender\r\n                " +
                "  ,[Phone]   \r\n                 " +
                " ,[Email]\r\n    " +
                "              FROM people  " +
                " join Countries   on People.NationalityCountryID = Countries.CountryID\r\n\t\t\t\t " +
                " where Email like @TxtFilter";




            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TxtFilter", "%" + TxtFilter + "%");


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
    }
}
