using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerDVLD
{
    public class clsDataUser
    {
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT     " +
                "   Users.UserID as 'User ID', " +
                "Users.PersonID as 'Person ID',  " +
                "(People.FirstName+' ' + People.SecondName+' ' + People.ThirdName +' ' + People.LastName) as 'Full name' ," +
                "Users.UserName as 'User Name', Users.IsActive as 'User Active'\r\n" +
                "FROM         " +
                "   Users INNER JOIN\r\n                        " +
                " People ON Users.PersonID = People.PersonID ";

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
    }
}
