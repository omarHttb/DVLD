using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerDVLD
{
    public class clsDataTakeTest
    {
        public static decimal GetTestAppointmentFees(int testAppointmentID)
        {

            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"select PaidFees from TestAppointments where TestAppointmentID = @testAppointmentID"
                  ;
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@testAppointmentID", testAppointmentID);


            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return (decimal)reader["PaidFees"];
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
            return 0;

        }

        public static int TakeTest(int TestAppointmentID,byte TestResult,string Notes,int CreatedByUserID)
        {
            //this function will return the new contact id if succeeded and -1 if not.

            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"
            update TestAppointments
            set IsLocked = 1
            where TestAppointmentID = @TestAppointmentIDdd;

            INSERT INTO [dbo].[Tests]
           ([TestAppointmentID]
           ,[TestResult]
           ,[Notes]
           ,[CreatedByUserID])
     VALUES
           ( @TestAppointmentID
           ,@TestResult
           ,@Notes
           ,@CreatedByUserID)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestAppointmentIDdd", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
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
                throw new Exception(ex.Message);
            }
        }

        // get last test result
        public static byte GetLastTestResult(int LdlAppID,int TestTypeID)
        {

            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"
SELECT    top 1    TestAppointments.TestTypeID, Tests.TestResult
FROM            TestAppointments INNER JOIN
                         Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID INNER JOIN
                         LocalDrivingLicenseApplications ON TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
						 where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LdlAppID and TestTypeID = @TestTypeID
                         order by TestAppointments.TestAppointmentID desc";
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@LdlAppID", LdlAppID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // Read the TestResult as a boolean
                    bool testResult = (bool)reader["TestResult"];
                    // Convert the boolean to a byte (1 for true, 0 for false)
                    return testResult ? (byte)1 : (byte)0;
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
            return 0;

        }
    }
}
