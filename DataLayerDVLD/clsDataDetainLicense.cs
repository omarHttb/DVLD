using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerDVLD
{
    public class clsDataDetainLicense
    {
        public static bool IsLicenseDetained(int LicenseID)
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
            return false;

        }
    }
}
