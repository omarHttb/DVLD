using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerDVLD
{
    public class clsDataDetainLicense
    {
        public static bool IsLicenseNotDetained(int LicenseID)
        {

            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"select IsReleased from DetainedLicenses where LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                   return (bool)reader["IsReleased"];
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
            return true;

        }

        public static int DetainNewLicense(int LicenseID, DateTime DetainDate,decimal FineFees,int CreatedByID,bool IsReleased)
        {
            //this function will return the new detain id if succeeded and -1 if not.

            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[DetainedLicenses]
           ([LicenseID]
           ,[DetainDate]
           ,[FineFees]
           ,[CreatedByUserID]
           ,[IsReleased])  
     VALUES
           (@LicenseID
           ,@DetainDate
           ,@FineFees
           ,@CreatedByUserID
           ,@IsReleased)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
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

        public static decimal GetFineFees(int LicenseID)
        {

            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"select top 1 FineFees from DetainedLicenses where LicenseID = @LicenseID order by DetainDate desc";
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return (decimal)reader["FineFees"];
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
        public static bool GetDetainedLicenseDetails(int LicenseID, ref DateTime DetainDate,ref int DetainID,ref int CreatedbyId
            ,ref decimal FineFees)
        {

            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"select top 1 DetainID , DetainDate,CreatedByUserID , FineFees FROM DetainedLicenses where LicenseID = @LicenseID order by DetainDate desc ";
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    FineFees = (decimal)reader["FineFees"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    DetainID = (int)reader["DetainID"];
                    CreatedbyId = (int)reader["CreatedByUserID"];
                    return true;
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
            return false;

        }

        public static bool ReleaseDetainedLicense(int LicenseID,int ReleaseApplicationID,int UserID,DateTime ReleaseDate)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"update DetainedLicenses set IsReleased = 1, ReleaseDate  = @ReleaseDate, 
                             ReleasedByUserID = @ReleasedByUserId , ReleaseApplicationID = @ReleaseApplicationID 
                             where LicenseID = @LicenseID;
"
            ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            command.Parameters.AddWithValue("@ReleasedByUserId", UserID);
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

        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);
            string query = @"select DetainID as 'Detain.ID',DetainedLicenses.LicenseID as 'License.ID',
                             case 
                             when IsReleased = 1 then 'Yes'
                             when IsReleased = 0 then 'No'
                             end as 'Is Released',
                             FineFees as 'Fine Fees',
                             ReleaseDate as 'Release Date',
                             NationalNo as 'N.No',
                             FirstName + ' ' + SecondName + ' ' + ThirdName + ' ' + LastName as 'Full Name',
                             DetainedLicenses.ReleaseApplicationID as 'Release.App.ID'       
                             FROM            
                                Drivers INNER JOIN
                                People ON Drivers.PersonID = People.PersonID INNER JOIN
                                Licenses ON Drivers.DriverID = Licenses.DriverID INNER JOIN
                                DetainedLicenses ON Licenses.LicenseID = DetainedLicenses.LicenseID";

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

        //Filter  Filter Filter Filter Filter Filter Filter Filter Filter Filter Filter Filter Filter Filter Filter Filter Filter

        public static DataTable GetFilteredDetainID(int DetainID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);


            string query = @"select DetainID as 'Detain.ID',DetainedLicenses.LicenseID as 'License.ID',
                         case 
                         when IsReleased = 1 then 'Yes'
                         when IsReleased = 0 then 'No'
                         end as 'Is Released',
                         FineFees as 'Fine Fees',
                         ReleaseDate as 'Release Date',
                         NationalNo as 'N.No',
                         FirstName + ' ' + SecondName + ' ' + ThirdName + ' ' + LastName as 'Full Name',
                         DetainedLicenses.ReleaseApplicationID as 'Release.App.ID'       
                         FROM            Drivers INNER JOIN
                         People ON Drivers.PersonID = People.PersonID INNER JOIN
                         Licenses ON Drivers.DriverID = Licenses.DriverID INNER JOIN
                         DetainedLicenses ON Licenses.LicenseID = DetainedLicenses.LicenseID where DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);

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
        public static DataTable GetFilteredNationalNo(string NationalNo)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);


            string query = @"select DetainID as 'Detain.ID',DetainedLicenses.LicenseID as 'License.ID',
                         case 
                         when IsReleased = 1 then 'Yes'
                         when IsReleased = 0 then 'No'
                         end as 'Is Released',
                         FineFees as 'Fine Fees',
                         ReleaseDate as 'Release Date',
                         NationalNo as 'N.No',
                         FirstName + ' ' + SecondName + ' ' + ThirdName + ' ' + LastName as 'Full Name',
                         DetainedLicenses.ReleaseApplicationID as 'Release.App.ID'       
                         FROM            Drivers INNER JOIN
                         People ON Drivers.PersonID = People.PersonID INNER JOIN
                         Licenses ON Drivers.DriverID = Licenses.DriverID INNER JOIN
                         DetainedLicenses ON Licenses.LicenseID = DetainedLicenses.LicenseID where NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

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

        public static DataTable GetFilteredFullName(string FullName)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);


            string query = @"select DetainID as 'Detain.ID',DetainedLicenses.LicenseID as 'License.ID',
case 
when IsReleased = 1 then 'Yes'
when IsReleased = 0 then 'No'
end as 'Is Released',
FineFees as 'Fine Fees',
ReleaseDate as 'Release Date',
NationalNo as 'N.No',
FirstName + ' ' + SecondName + ' ' + ThirdName + ' ' + LastName as FullName,
DetainedLicenses.ReleaseApplicationID as 'Release.App.ID'       
FROM            Drivers INNER JOIN
                         People ON Drivers.PersonID = People.PersonID INNER JOIN
                         Licenses ON Drivers.DriverID = Licenses.DriverID INNER JOIN
                         
DetainedLicenses ON Licenses.LicenseID = DetainedLicenses.LicenseID where (People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName)  like @FullName;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FullName",'%' + FullName + '%');

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


        public static DataTable GetFilteredReleaseApplication(int ReleaseApplication)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);


            string query = @"select DetainID as 'Detain.ID',DetainedLicenses.LicenseID as 'License.ID',
                         case 
                         when IsReleased = 1 then 'Yes'
                         when IsReleased = 0 then 'No'
                         end as 'Is Released',
                         FineFees as 'Fine Fees',
                         ReleaseDate as 'Release Date',
                         NationalNo as 'N.No',
                         FirstName + ' ' + SecondName + ' ' + ThirdName + ' ' + LastName as 'Full Name',
                         DetainedLicenses.ReleaseApplicationID as 'Release.App.ID'       
                         FROM            Drivers INNER JOIN
                         People ON Drivers.PersonID = People.PersonID INNER JOIN
                         Licenses ON Drivers.DriverID = Licenses.DriverID INNER JOIN
    DetainedLicenses ON Licenses.LicenseID = DetainedLicenses.LicenseID where DetainedLicenses.ReleaseApplicationID = @ReleaseApplication";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ReleaseApplication", ReleaseApplication);

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

        public static DataTable GetFilteredReleased()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);


            string query = @"select DetainID as 'Detain.ID',DetainedLicenses.LicenseID as 'License.ID',
case 
when IsReleased = 1 then 'Yes'
when IsReleased = 0 then 'No'
end as 'Is Released',
FineFees as 'Fine Fees',
ReleaseDate as 'Release Date',
NationalNo as 'N.No',
FirstName + ' ' + SecondName + ' ' + ThirdName + ' ' + LastName as FullName,
DetainedLicenses.ReleaseApplicationID as 'Release.App.ID'       
FROM            Drivers INNER JOIN
                         People ON Drivers.PersonID = People.PersonID INNER JOIN
                         Licenses ON Drivers.DriverID = Licenses.DriverID INNER JOIN
                         DetainedLicenses ON Licenses.LicenseID = DetainedLicenses.LicenseID where IsReleased = 1";


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
        public static DataTable GetFilteredDetained()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);


            string query = @"select DetainID as 'Detain.ID',DetainedLicenses.LicenseID as 'License.ID',
case 
when IsReleased = 1 then 'Yes'
when IsReleased = 0 then 'No'
end as 'Is Released',
FineFees as 'Fine Fees',
ReleaseDate as 'Release Date',
NationalNo as 'N.No',
FirstName + ' ' + SecondName + ' ' + ThirdName + ' ' + LastName as FullName,
DetainedLicenses.ReleaseApplicationID as 'Release.App.ID'       
FROM            Drivers INNER JOIN
                         People ON Drivers.PersonID = People.PersonID INNER JOIN
                         Licenses ON Drivers.DriverID = Licenses.DriverID INNER JOIN
                         DetainedLicenses ON Licenses.LicenseID = DetainedLicenses.LicenseID where IsReleased = 0";


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
