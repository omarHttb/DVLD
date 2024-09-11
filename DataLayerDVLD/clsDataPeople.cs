using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerDVLD
{
    public class clsDataPeople
    {

        public static bool GetPersonByNationalNo(ref int ID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
           ref DateTime DateOfBirth, ref int Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID,
           ref string ImagePath)
        {

            bool isFound = false;
            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "select * from People where NationalNo = @NationalNo;";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    Gender = (byte)reader["Gendor"];
                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    ID = (int)reader["PersonID"];

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        ImagePath = "";
                    }
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

        public static bool GetPersonByID( ref int ID,ref string NationalNo,ref string FirstName,ref string SecondName,ref string ThirdName,ref string LastName,
           ref DateTime DateOfBirth, ref int Gender,ref string Address, ref string Phone,ref  string Email,ref int NationalityCountryID,
           ref string ImagePath)
        {

            bool isFound = false;
            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "select * from People where PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    Gender = (byte)reader["Gendor"];
                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    NationalNo = (string)reader["NationalNo"];

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        ImagePath = "";
                    }
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
        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = " SELECT  " +
                "[PersonID]\r\n      " +
                ",[NationalNo]\r\n   " +
                "   ,[FirstName]\r\n     " +
                " ,[SecondName]\r\n     " +
                " ,[ThirdName]\r\n    " +
                "  ,[LastName]\r\n\t " +
                " ,Countries.CountryName as Country\r\n  " +
                "    ,[DateOfBirth],\r\n    " +
                "   CASE \r\n    " +
                "    WHEN Gendor = 0 THEN 'Male'\r\n  " +
                "      WHEN Gendor = 1 THEN 'Female'\r\n   " +
                "     ELSE 'Unknown'  -- in case there are other values\r\n  " +
                "  END as gender\r\n   " +
                "   ,[Phone]\r\n    " +
                "  ,[Email]\r\n " +
                "  \r\n  FROM people   join Countries   on People.NationalityCountryID = Countries.CountryID \r\n";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                
                if(reader.HasRows)
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



        public static int AddNewPerson(string NationalNo,string FirstName,string SecondName , string ThirdName, string LastName,
            DateTime DateOfBirth, int Gender,string Address, string Phone, string Email, int NationalityCountryID,
            string ImagePath)
        {
            //this function will return the new contact id if succeeded and -1 if not.

            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[People]
           ([NationalNo]
           ,[FirstName]
           ,[SecondName]
           ,[ThirdName]
           ,[LastName]
           ,[DateOfBirth]
           ,[Gendor]
           ,[Address]
           ,[Phone]
           ,[Email]
           ,[NationalityCountryID]
           ,[ImagePath])
     VALUES
           (@NationalNo
           ,@FirstName
           ,@SecondName
           ,@ThirdName
           ,@LastName
           ,@DateOfBirth
           ,@Gender
           ,@Address
           ,@Phone
           ,@Email
           ,@NationalityCountryID
           ,@ImagePath)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            if (Email != "")
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
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
                //Console.WriteLine("Error: " + ex.Message);

            }
            finally
            {
                connection.Close(); 
            }

            return -1;
        }

        public static bool IsNationalNoFound(string NationalNo)
        {


            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "select NationalNo from People where NationalNo = @NationalNo";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

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
        public static bool IsPersonIDFound(string PersonID)
        {


            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "select PersonID from People where PersonID = @PersonID";


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
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return false;
        }

        public static bool UpdatePerson(int ID ,string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
            DateTime DateOfBirth, int Gender, string Address, string Phone, string Email, int NationalityCountryID,
            string ImagePath)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"UPDATE [dbo].[People]
    SET [NationalNo] = @NationalNo
      ,[FirstName] = @FirstName
      ,[SecondName] = @SecondName
      ,[ThirdName] = @ThirdName
      ,[LastName] = @LastName
      ,[DateOfBirth] = @DateOfBirth
      ,[Gendor] = @Gender
      ,[Address] = @Address
      ,[Phone] = @Phone
      ,[Email] = @Email
      ,[NationalityCountryID] = @NationalityCountryID
      ,[ImagePath] = @ImagePath
 WHERE People.PersonID = @PersonId";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@PersonId", ID);
            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            if (Email != "")
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

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

        public static bool DeleteContact(int PersonId)
        {

            int RowsAffected = 0;
            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"delete from People where People.PersonID = @PersonId";



            SqlCommand command = new SqlCommand(query, conn);


            command.Parameters.AddWithValue("@PersonId", PersonId);

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

        public static int GetPersonIdByInternationalNumber(string NationalNo)
        {

            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"select PersonID from People where NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

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
                //Console.WriteLine("Error: " + ex.Message);

            }
            finally
            {
                connection.Close();
            }

            return -1;
        }

    }
}
