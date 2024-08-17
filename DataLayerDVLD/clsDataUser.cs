using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Security.Policy;

namespace DataLayerDVLD
{
    public class clsDataUser
    {
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT     Users.UserID as 'User ID'," +
                "Users.PersonID as 'Person ID', " +
                " (People.FirstName+' ' + People.SecondName+' ' + People.ThirdName +' ' + People.LastName) as 'Full name' ," +
                " Users.UserName as 'User Name'," +
                "   case  " +
		        " when IsActive = 1 then 'Active' " +
		        " when IsActive = 0 then 'Not active' " +
		        " end as 'is Active' " +
                " FROM  " +
                " Users INNER JOIN " +
                " People ON Users.PersonID = People.PersonID  ";

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


        public static int AddNewPerson(int PersonID,string UserName,string Password,short IsActive)
        {
            //this function will return the new contact id if succeeded and -1 if not.

            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[Users]
           ([PersonID]
           ,[UserName]
           ,[Password]
           ,[IsActive]
           )
     VALUES
          ( @PersonID, 
           @UserName, 
           @Password,
           @IsActive
                     )
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    return insertedID;
                }
                else
                {
                    return -1;
                }
            }

            catch (Exception ex)
            {
                
            }
            finally
            {
                connection.Close();
            }

            return -1;
        }

        public static bool IsUserExist(int PersonID)
        {

            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"select personID from Users where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    return true;
                }

            }

            catch (Exception ex)
            {
                 
            }
            finally
            {
                connection.Close();
            }

            return false;
        }

        public static bool DeleteUser(int UserID)
        {

            int RowsAffected = 0;
            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"delete  FROM [dbo].[Users] where Users.UserID = @UserID";



            SqlCommand command = new SqlCommand(query, conn);


            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                conn.Open();

                RowsAffected = command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return (RowsAffected > 0);
        }

        public static bool UpdateUser(int UserID,string UserName, string Password, short IsActive)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"UPDATE [dbo].[Users]
                      SET 
                      [UserName] = @UserName
                     ,[Password] = @Password
                     ,[IsActive] = @IsActive
                      WHERE Users.UserID = @userID"
            ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static string GetUserPassword(int UserID)
        {

            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT Password from Users where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return (string)reader["Password"];
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
            return "";
           
        }
        
        public static string GetUserPasswordByUserName(string UserName)
        {

            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT Password from Users where UserName = @UserName";

            SqlCommand command = new SqlCommand(query , conn);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return (string)reader["Password"];
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
            return "";

        }

        public static bool GetUserDetails(int UserID,ref string UserName ,ref string IsActive)
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT UserID , UserName , " +
                " case " +
                " when IsActive = 1 then 'Yes' " +
                " when IsActive = 0 then 'No' " +
                " end as 'Isactive' " +
                " from Users where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    UserName = (string)reader["UserName"];
                    IsActive = (string)reader["Isactive"];
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
        public static int GetUserId(string UserName)
        {

            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT UserID from Users where UserName = @UserName";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return (int)reader["UserID"];
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
            return -1;

        }

        public static int GetPersonID(string UserName)
        {

            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT PersonID from Users where UserName = @UserName";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return (int)reader["PersonID"];
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
            return -1;

        }

        public static bool UpdatePassword(int UserID,string Password)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"update Users set Password = @Password where UserID = @UserID"
            ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }
        public static bool IsUserNameExist(string UserName)
        {


            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "select UserName from Users where UserName = @UserName";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {

                    return true;
                }
            }


            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return false;
        }


        public static string IsUserActive(string UserName)
        {

            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "select case " +
                " when Users.IsActive = 1 then 'yes' " +
                " when Users.IsActive = 0 then 'no' " +
                " end as IsActive " +
                " from Users where UserName = @UserName";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return (string)reader["IsActive"];
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
            return "";

        }

        //kaka
        public static bool GetUserDetailsByUserName(string UserName, ref int UserID,  ref int  PersonID)
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT UserID , PersonID  " +

                " from Users where UserName = @UserName";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    UserID = (int)reader["UserID"];
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

