using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerDVLD
{
    public class clsDataInternationalLicense
    {
        public static int AddNewInternationalLicense(int ApplicationID, int DriverID, 
            int LocalLicenseId,
            DateTime IssueDate, DateTime ExpirationDate, bool isActive,  int CreatedByUserID)
        {
            //this function will return the new contact id if succeeded and -1 if not.

            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"
          INSERT INTO [dbo].[InternationalLicenses]
           ([ApplicationID]
           ,[DriverID]
           ,[IssuedUsingLocalLicenseID]
           ,[IssueDate]
           ,[ExpirationDate]
           ,[IsActive]
           ,[CreatedByUserID])
     VALUES
           (@ApplicationID
           ,@DriverID
           ,@IssuedUsingLocalLicenseID
           ,@IssueDate
           ,@ExpirationDate
           ,@IsActive
           ,@CreatedByUserID);
SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", LocalLicenseId);
            command.Parameters.AddWithValue("@IsActive", isActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);



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

        public static bool IsInternationalLicenseActiveOrAvailable(int LicenseID)
        {

            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"select IsActive from InternationalLicenses where IssuedUsingLocalLicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return (bool)reader["IsActive"];
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

        public static bool GetPersonInternationalLicenseByInternationalLicenseID(int InternationalLicenseID, ref int DriverID,
            ref DateTime IssueDate, ref DateTime ExpirationDate, ref int ApplicationID
            , ref bool IsActive, ref int IssuedUsingLocalLicenseID,ref int CreatedById)
        {

            bool isFound = false;
            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);


            string query = @"
                    select * from InternationalLicenses where InternationalLicenseID = @InternationalLicenseID;";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    DriverID = (int)reader["DriverID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    CreatedById = (int)reader["CreatedById"];
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

        public static DataTable GetAllPersonInternationalLicense(int PersonID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"SELECT        InternationalLicenseID 'as Int.License ID', Applications.ApplicationID as 'App.ID',
            IssuedUsingLocalLicenseID as 'L.License ID',
            IssueDate as 'Issue Date', ExpirationDate as'Expiration Date',
            case 
            when IsActive = 0 then 'Yes'
            when IsActive = 1 then 'No'
            end as 'Is Active'
            From InternationalLicenses INNER JOIN
            Applications ON InternationalLicenses.ApplicationID = Applications.ApplicationID where ApplicantPersonID = @PersonID
                   ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

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
        public static DataTable GetAllInternationalLicense()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"SELECT        InternationalLicenseID as 'Int.License ID', Applications.ApplicationID as 'App.ID',
             DriverID as 'Driver ID',IssuedUsingLocalLicenseID as 'L.License ID',
            IssueDate as 'Issue Date', ExpirationDate as'Expiration Date',
            case 
            when IsActive = 0 then 'No'
            when IsActive = 1 then 'Yes'
            end as 'Is Active'
            From InternationalLicenses INNER JOIN
            Applications ON InternationalLicenses.ApplicationID = Applications.ApplicationID;
                   ";

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
        // Filter
        public static DataTable GetFilteredInternationalDriverID(string DriverID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);


            string query = @"SELECT        InternationalLicenseID as 'Int.License ID', Applications.ApplicationID as 'App.ID',
             DriverID as 'Driver ID',IssuedUsingLocalLicenseID as 'L.License ID',
            IssueDate as 'Issue Date', ExpirationDate as'Expiration Date',
            case 
            when IsActive = 0 then 'No'
            when IsActive = 1 then 'Yes'
            end as 'Is Active'
            From InternationalLicenses INNER JOIN
            Applications ON InternationalLicenses.ApplicationID = Applications.ApplicationID where DriverID = @DriverID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

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
        public static DataTable GetFilteredInternationalLicenseID(string InternationalLicenseID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);


            string query = @"SELECT        InternationalLicenseID as 'Int.License ID', Applications.ApplicationID as 'App.ID',
             DriverID as 'Driver ID',IssuedUsingLocalLicenseID as 'L.License ID',
            IssueDate as 'Issue Date', ExpirationDate as'Expiration Date',
            case 
            when IsActive = 0 then 'No'
            when IsActive = 1 then 'Yes'
            end as 'Is Active'
            From InternationalLicenses INNER JOIN
            Applications ON InternationalLicenses.ApplicationID = Applications.ApplicationID where 
            InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

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
        public static DataTable GetFilteredInternationalLocalDrivingLicenseID(string IssuedUsingLocalLicenseID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);


            string query = @"SELECT        InternationalLicenseID as 'Int.License ID', Applications.ApplicationID as 'App.ID',
             DriverID as 'Driver ID',IssuedUsingLocalLicenseID as 'L.License ID',
            IssueDate as 'Issue Date', ExpirationDate as'Expiration Date',
            case 
            when IsActive = 0 then 'No'
            when IsActive = 1 then 'Yes'
            end as 'Is Active'
            From InternationalLicenses INNER JOIN
            Applications ON InternationalLicenses.ApplicationID = Applications.ApplicationID where 
            IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);

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

        public static DataTable GetFilteredInternationalLicenseApplicationID(string ApplicationID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);


            string query = @"SELECT        InternationalLicenseID as 'Int.License ID', Applications.ApplicationID as 'App.ID',
             DriverID as 'Driver ID',IssuedUsingLocalLicenseID as 'L.License ID',
            IssueDate as 'Issue Date', ExpirationDate as'Expiration Date',
            case 
            when IsActive = 0 then 'No'
            when IsActive = 1 then 'Yes'
            end as 'Is Active'
            From InternationalLicenses INNER JOIN
            Applications ON InternationalLicenses.ApplicationID = Applications.ApplicationID where 
            Applications.ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
