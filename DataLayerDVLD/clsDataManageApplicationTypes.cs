﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerDVLD
{
    public class clsDataManageApplicationTypes
    {
        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = "select * from ApplicationTypes";

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

        public static bool UpdateApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, 
             decimal ApplicationFees)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataLayerSettings.ConnectionString);

            string query = @"UPDATE [dbo].[ApplicationTypes]
                     SET [ApplicationTypeTitle] = @ApplicationTypeTitle
                    ,[ApplicationFees] = @ApplicationFees
                     WHERE ApplicationTypeID = @ApplicationTypeID"
            ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
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
    }
}
