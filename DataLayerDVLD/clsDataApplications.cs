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
    public class clsDataApplications
    {
        public static DataTable GetAllApplicationLicenseClass()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "SELECT * FROM LicenseClasses";

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

        public static int AddApplication(int ApplicantPersonID,DateTime ApplicationDate
            ,int ApplicationTypeID,int ApplicationStatus,DateTime LastStatusDate
            ,decimal PaidFees,int CreatedByUserID)
        {
            //this function will return the new contact id if succeeded and -1 if not.

            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[Applications]
           ([ApplicantPersonID]
           ,[ApplicationDate]
           ,[ApplicationTypeID]
           ,[ApplicationStatus]
           ,[LastStatusDate]
           ,[PaidFees]
           ,[CreatedByUserID])
     VALUES
           (@ApplicantPersonID
           ,@ApplicationDate
           ,@ApplicationTypeID
           ,@ApplicationStatus
           ,@LastStatusDate 
           ,@PaidFees
           ,@CreatedByUserID)
SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
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
        

        public static bool GetApplicationBasicInfo(int LdlAppId, ref int AppId,ref int ApplicationTypeId,ref int ApplicantPersonId,ref DateTime ApplicationDate,
         ref  byte ApplicationStatus,ref DateTime LastStatusDate,ref decimal PaidFees,ref int CreatedByUserId)
        {

            bool isFound = false;
            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"SELECT  Applications.ApplicationID , Applications.ApplicantPersonID
				, Applications.ApplicationTypeID
				,Applications.ApplicationDate, Applications.ApplicationStatus
				, Applications.LastStatusDate, Applications.PaidFees
                ,Applications.CreatedByUserID
            FROM           
                Applications INNER JOIN                        
                LocalDrivingLicenseApplications ON Applications.ApplicationID = 
                LocalDrivingLicenseApplications.ApplicationID where LocalDrivingLicenseApplicationID = @LdlAppId";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@LdlAppId", LdlAppId);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    AppId = (int)reader["ApplicationID"];
                    ApplicationTypeId = (int)reader["ApplicationTypeID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserId = (int)reader["CreatedByUserID"];
                    ApplicantPersonId = (int)reader["ApplicantPersonID"];
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

        public static int GetPersonIdFromApplicationID(int AppID)
        {

            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"select ApplicantPersonID from Applications where ApplicationID = @AppID "
               ;
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@AppID", AppID);



            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return (int)reader["ApplicantPersonID"];
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


    }
}
