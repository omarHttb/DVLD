using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace DataLayerDVLD
{
    public class clsDataTestsAppointments
    {
        public static DataTable GetAllTestAppointments(int LdlAppId,int TestTypeId)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query =
        @"select TestAppointmentID as 'Appointment ID', AppointmentDate as 'Appointment Date' , PaidFees 'Paid Fees',

            case 
                when  islocked = 1 then 'Locked'
                when IsLocked = 0 then 'Not Locked'
            end as 'Is Locked'
                   
            from TestAppointments where LocalDrivingLicenseApplicationID = @LdlAppId and TestTypeID = @TestTypeId";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LdlAppId", LdlAppId);
            command.Parameters.AddWithValue("@TestTypeId", TestTypeId);

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

        public static bool AddNewAppointment(int TestTypeID, int LdlAppID, DateTime AppointmentDate, decimal paidFees,
            int CreatedByUserID, byte IsLocked)
        {
            //this function will return the new contact id if succeeded and -1 if not.

            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[TestAppointments]
           ([TestTypeID]
           ,[LocalDrivingLicenseApplicationID]
           ,[AppointmentDate]
           ,[PaidFees]
           ,[CreatedByUserID]
           ,[IsLocked])
     VALUES
            (@TestTypeID
           ,@LocalDrivingLicenseApplicationID
           ,@AppointmentDate
           ,@PaidFees
           ,@CreatedByUserID
           ,@IsLocked)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LdlAppID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool UpdateAppointmentDate(int AppointmentId , DateTime NewAppointmentDate)
        {
            //this function will return the new contact id if succeeded and -1 if not.

            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"UPDATE [dbo].[TestAppointments]
             SET 
      
            [AppointmentDate] = @NewAppointmentDate
      
                 WHERE TestAppointmentID = @AppointmentId
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppointmentId", AppointmentId);
            command.Parameters.AddWithValue("@NewAppointmentDate", NewAppointmentDate);




            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
