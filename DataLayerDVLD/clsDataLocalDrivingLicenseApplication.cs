using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerDVLD
{
    public class clsDataLocalDrivingLicenseApplication
    {

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = 
          @"select LocalDrivingLicenseApplicationID as 'L.D.L App ID', ClassName as 'Driving Class', NationalNo
          ,FullName as 'Full name', ApplicationDate as 'Application Date' , PassedTestCount as 'Passed Tests', Status
          from LocalDrivingLicenseApplications_View";

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
        public static int AddLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID)
        {
            //this function will return the new contact id if succeeded and -1 if not.

            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[LocalDrivingLicenseApplications]
           ([ApplicationID]
           ,[LicenseClassID])
     VALUES
           (@ApplicationID,
            @LicenseClassID)
            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
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

        //Does Person Have Active Local App lication With Same License Class
        //this is for local applications, if yes then do not create a new application otherwise create
        public static bool DoesPersonHaveActiveLocalApplicationWithSameLicenseClass(int PersonID,int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"SELECT        Applications.ApplicantPersonID, LocalDrivingLicenseApplications.LicenseClassID
                             FROM            LocalDrivingLicenseApplications INNER JOIN
                         Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID where ApplicantPersonID = @PersonID and LicenseClassID = @LicenseClassID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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

        public static bool UpdateLocalDrivingLicensesClass(int LocalDrivingLicenseApplicationID,int LicenseClassID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"UPDATE [dbo].[LocalDrivingLicenseApplications]
                    set
                    [LicenseClassID] = @LicenseClassID
                    WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;

"
            ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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

        // filter by national no
        public static DataTable GetLDlAppPersonNationalNO(string NationalNo)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query =
          @"select LocalDrivingLicenseApplicationID as 'L.D.L App ID', ClassName as 'Driving Class', NationalNo
          ,FullName as 'Full name', ApplicationDate as 'Application Date' , PassedTestCount as 'Passed Tests', Status
          from LocalDrivingLicenseApplications_View where NationalNo = @NationalNo";

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

        //filter by application id
        public static DataTable GetLDlAppPersonAppID(string LdlAppID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query =
          @"select LocalDrivingLicenseApplicationID as 'L.D.L App ID', ClassName as 'Driving Class', NationalNo
          ,FullName as 'Full name', ApplicationDate as 'Application Date' , PassedTestCount as 'Passed Tests', Status
          from LocalDrivingLicenseApplications_View where LocalDrivingLicenseApplicationID = @LdlAppID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LdlAppID", LdlAppID);

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

        
        public static DataTable GetLDLAppPersonFullName(string FullName)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query =
          @"select LocalDrivingLicenseApplicationID as 'L.D.L App ID', ClassName as 'Driving Class', NationalNo
          ,FullName as 'Full name', ApplicationDate as 'Application Date' , PassedTestCount as 'Passed Tests', Status
          from LocalDrivingLicenseApplications_View where FullName like @FullName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FullName","%" + FullName+ "%");

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

        public static DataTable GetLDLAppPersonStatus(string Status)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query =
          @"select LocalDrivingLicenseApplicationID as 'L.D.L App ID', ClassName as 'Driving Class', NationalNo
          ,FullName as 'Full name', ApplicationDate as 'Application Date' , PassedTestCount as 'Passed Tests', Status
          from LocalDrivingLicenseApplications_View where Status = @Status";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Status", Status);

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

        // cancel local driving license applicatoin
        public static bool CancelLocalDrivingLicenseApplication(int LLdAppID,DateTime LastStatusUpdate)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"
            UPDATE Applications
            SET ApplicationStatus = 2,
            LastStatusDate = @LastStatusUpdate
    WHERE ApplicationID IN (SELECT ApplicationID FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID  = @LLdAppID);
"
            ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LLdAppID", LLdAppID);
            command.Parameters.AddWithValue("@LastStatusUpdate", LastStatusUpdate);

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

        // check if person application return 2 then it is cancelled
        // if it is cancelled then you can create new application with new 
        // vehicle license class type
        
        public static byte IsPersonApplicationCanceled(int PersonID,int LicenseClassID)
        {

            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"SELECT       ApplicationStatus
                             FROM            LocalDrivingLicenseApplications INNER JOIN
                         Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID where ApplicantPersonID = @PersonID  and LicenseClassID = @LicenseClassID"
                  ;
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return (byte)reader["ApplicationStatus"];
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

        public static int GetLicenseClassFromLLDAppId(int LLDId)
        {

            SqlConnection conn = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"select LicenseClassID from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LLDId"
                  ;
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@LLDId", LLDId);



            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return (int)reader["LicenseClassID"];
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
