using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerDVLD
{
    public class clsDataFilterByUser
    {
        public static DataTable GetFilteredResultByUserID(string TxtFilter)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT   " +
                "    Users.UserID as 'User ID', Users.PersonID as 'Person ID', " +
                " (People.FirstName+' ' + People.SecondName+' ' + People.ThirdName +' ' + People.LastName) as 'Full name' ," +
                " Users.UserName as 'User Name', Users.IsActive as 'User Active'FROM     " +
                "  Users INNER JOIN People ON Users.PersonID = People.PersonID WHERE UserID = @TxtFilter ";




            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TxtFilter", TxtFilter);


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
        public static DataTable GetFilteredResultByPersonID(string TxtFilter)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT   " +
                "    Users.UserID as 'User ID', Users.PersonID as 'Person ID', " +
                " (People.FirstName+' ' + People.SecondName+' ' + People.ThirdName +' ' + People.LastName) as 'Full name' ," +
                " Users.UserName as 'User Name', Users.IsActive as 'User Active'FROM     " +
                "  Users INNER JOIN People ON Users.PersonID = People.PersonID WHERE Users.PersonID = @TxtFilter ";




            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TxtFilter", TxtFilter );


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
        public static DataTable GetFilteredResultByUserName(string TxtFilter)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT   " +
                "    Users.UserID as 'User ID', Users.PersonID as 'Person ID', " +
                " (People.FirstName+' ' + People.SecondName+' ' + People.ThirdName +' ' + People.LastName) as 'Full name' ," +
                " Users.UserName as 'User Name', Users.IsActive as 'User Active'FROM     " +
                "  Users INNER JOIN People ON Users.PersonID = People.PersonID WHERE Users.UserName like @TxtFilter ";




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


        public static DataTable GetFilteredResultByFullName(string TxtFilter)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT   " +
                "    Users.UserID as 'User ID', Users.PersonID as 'Person ID', " +
                " (People.FirstName+' ' + People.SecondName+' ' + People.ThirdName +' ' + People.LastName) as 'Full name' ," +
                " Users.UserName as 'User Name', Users.IsActive as 'User Active'FROM     " +
                "  Users INNER JOIN People ON Users.PersonID = People.PersonID WHERE (People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName)  like @TxtFilter ";




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

        public static DataTable GetFilteredResultByActive(string TxtFilter)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT   " +
                "    Users.UserID as 'User ID', Users.PersonID as 'Person ID', " +
                " (People.FirstName+' ' + People.SecondName+' ' + People.ThirdName +' ' + People.LastName) as 'Full name' ," +
                " Users.UserName as 'User Name', Users.IsActive as 'User Active'FROM     " +
                "  Users INNER JOIN People ON Users.PersonID = People.PersonID WHERE IsActive = @TxtFilter ";




            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TxtFilter", TxtFilter );


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
