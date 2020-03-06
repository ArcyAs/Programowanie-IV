using System;

using System.Data.SqlClient;

 

namespace Zjazd_1

{

    public class CRUD

    {

        public void Create(int id, string regionDescription, SqlConnection conn)

        {

            string sql = "INSERT INTO Region(RegionID, 'RegionDescription') VALUES(@regionName)";

            var command = new SqlCommand(sql, conn);

            command.Parameters.AddWithValue("regionName", regionDescription);

            command.Parameters.AddWithValue("id", id);

            int x = command.ExecuteNonQuery();

            if (x>0)

            {

                Console.WriteLine("Wpisano");

            }

        }

 

        public void Read(SqlConnection conn)

        {

            SqlCommand command = new SqlCommand

            {

                CommandText = "SELECT * FROM Customers",

                Connection = conn

            };

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())

            {

                Console.WriteLine(reader["CompanyName"]);

            }

        }

 

        public void Update(int id, string NewName, SqlConnection conn)

        {

            string sql = "UPDATE Region WHERE id = @id SET RegionDescription = @regionName";

            var command = new SqlCommand(sql, conn);

            command.Parameters.AddWithValue("id", id);

            command.Parameters.AddWithValue("regionName", newName);

 

            int x = command.ExecuteNonQuery();

            if (x>0)

            {

                Console.WriteLine("Zmieniono");

            }

        }



        public void Delete();

    }

}