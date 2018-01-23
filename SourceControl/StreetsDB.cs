using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControl
{
    class StreetsDB
    {
        /// <summary>
        /// Adds the street to the database.
        /// </summary>
        /// <param name="street"></param>
        /// <returns></returns>
        public static bool AddStreet(Street street)
        {
            SqlConnection connection = DBHelper.GetConnection();

            SqlCommand addStreetCmd = new SqlCommand();
            addStreetCmd.Connection = connection;
            addStreetCmd.CommandText = @"INSERT INTO Streets(StreetName)
                                       VALUES(@StreetName)";
            addStreetCmd.Parameters.AddWithValue("@StreetName", street.StreetName);

            try
            {
                connection.Open();
                int rowsAffected = addStreetCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Street> GetAllStreets()
        {
            // Get all streets from DB
            // Step 1: Establish a connection
            SqlConnection connection = DBHelper.GetConnection();

            // step2: Prepare Query (command object)
            SqlCommand sqlQuery = new SqlCommand();
            sqlQuery.Connection = connection;
            sqlQuery.CommandText = @"SELECT StreetName
                                     FROM Streets";

            try
            {
                // Step 3: Open connection
                connection.Open();

                // step 4: Executre query and get results
                SqlDataReader reader = sqlQuery.ExecuteReader();

                List<Street> streetList = new List<Street>();

                while (reader.Read())
                {
                    Street street = new Street();
                    street.StreetName = reader["StreetName"] as string;

                    streetList.Add(street);
                }
                return streetList;
            }
            finally
            {
                // step 6: close connection
                connection.Close();
            }
        }

        public static List<Street> DeleteStreets()
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = @"DELETE FROM Streets
                                    WHERE StreetName = ";

            try
            {
                con.Open();

                SqlDataReader r = command.ExecuteReader();

                List<Street> list = new List<Street>();

                while (r.Read())
                {
                    Street st = new Street();

                    st.StreetName = (string)r["StreetName"];
                    
                }
                return list;
            }
            finally
            {
                con.Dispose();

            }
        }
    }
}
