using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerDVLD
{
    public class clsDataLicenses
    {
        public static int AddNewLicense(int ApplicationID, int DriverID,int LicenseClass ,DateTime IssueDate
            ,DateTime ExpirationDate,string Notes, decimal PaidFees,bool isActive,byte IssueReason,int CreatedByUserID)
        {
            //this function will return the new contact id if succeeded and -1 if not.

            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"
            update Applications set ApplicationStatus = 3 where ApplicationID = @ApplicationID;
INSERT INTO [dbo].[Licenses]
           ([ApplicationID]
           ,[DriverID]
           ,[LicenseClass]
           ,[IssueDate]
           ,[ExpirationDate]
           ,[Notes]
           ,[PaidFees]
           ,[IsActive]
           ,[IssueReason]
           ,[CreatedByUserID])
     VALUES
           (@ApplicationID
           ,@DriverID
           ,@LicenseClass
           ,@IssueDate
           ,@ExpirationDate
           ,@Notes
           ,@PaidFees
           ,@IsActive
           ,@IssueReason
           ,@CreatedByUserID);
SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", isActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            if (Notes != "")
            {
                command.Parameters.AddWithValue("@Notes", Notes);
            }
            else
                command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
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

        public static decimal GetLicenseClassFees(int LicenseID)
        {

            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"select ClassFees from LicenseClasses where LicenseClassID = @LicenseID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return (decimal)reader["ClassFees"];
                }
                reader.Close();
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

        public static bool GetPersonLicenseByLicenseID( int LicenseID, ref int DriverID,
            ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref string IssueReason
            , ref string IsActive, ref string LicenseClass)
        {

            bool isFound = false;
            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);


            string query = @"
                SELECT        Licenses.LicenseID, Licenses.DriverID, Licenses.IssueDate, Licenses.ExpirationDate,
                Licenses.Notes, 
                case 
                when IsActive = 0 then 'Not Active'
                when IsActive = 1 then 'Active'
                end as isActive
                ,
                case 
                when IssueReason = 1 then 'First Time'
                when IssueReason = 2 then 'Renew'
                when IssueReason = 3 then 'Replacement for Damaged'
                when issueReason = 4 then 'Replacement for Lost'
                end as issueReason
                , 
                LicenseClasses.ClassName
                FROM            Licenses INNER JOIN
                Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN
                LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID where LicenseID = @LicenseID;";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

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
                    IsActive = (string)reader["IsActive"];
                    IssueReason = (string)reader["IssueReason"];
                    LicenseClass = (string)reader["ClassName"];

                    if (reader["Notes"] != DBNull.Value)
                    {
                        Notes = (string)reader["Notes"];

                    }
                    else
                    {
                        Notes = "";
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

        public static bool GetPersonLicenseByPersonID(int PersonID, ref int LicenseID, ref int DriverID,
            ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref string IssueReason
            , ref string IsActive, ref string LicenseClass)
        {

            bool isFound = false;
            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);


            string query = @"
                SELECT        Licenses.LicenseID, Licenses.DriverID, Licenses.IssueDate, Licenses.ExpirationDate,
                Licenses.Notes, 
                case 
                when IsActive = 0 then 'Not Active'
                when IsActive = 1 then 'Active'
                end as isActive
                ,
                case 
                when IssueReason = 1 then 'First Time'
                when IssueReason = 2 then 'Renew'
                when IssueReason = 3 then 'Replacement for Damaged'
                when issueReason = 4 then 'Replacement for Lost'
                end as issueReason
                , 
                LicenseClasses.ClassName
                FROM            Licenses INNER JOIN
                Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN
                LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID where PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    LicenseID = (int)reader["LicenseID"];
                    DriverID = (int)reader["DriverID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (string)reader["IsActive"];
                    IssueReason = (string)reader["IssueReason"];
                    LicenseClass = (string)reader["ClassName"];

                    if (reader["Notes"] != DBNull.Value)
                    {
                        Notes = (string)reader["Notes"];

                    }
                    else
                    {
                        Notes = "";
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
        public static DataTable GetAllPersonLocalLicense(int PersonID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"SELECT        Applications.ApplicationID as 'App.ID', Licenses.LicenseID as 'Lic.ID', 
                   LicenseClasses.ClassName as 'Class Name',
                   Licenses.IssueDate as 'Issue Date', Licenses.ExpirationDate as 'Expiration Date', 
                   case 
                   when IsActive = 0 then 'Not Active'
                   when IsActive = 1 then 'Active'
                   end as 'Is Active'
                   FROM            Applications INNER JOIN
                   Licenses ON Applications.ApplicationID = Licenses.ApplicationID INNER JOIN
                   LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID where ApplicantPersonID = @PersonID
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




    }
}
