using System;

using System.Data.SqlClient;

namespace Zjazd_1

{

    class Program

    {

        static void Main(string[] args)

        {

            string connectionString = ;

            using SqlConnection conn = new SqlConnection(connectionString);



            conn.Open();

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

            CRUD crud = new CRUD();

            crud.Read(conn);

            crud.Create(5, "Slask", conn);

            crud.conn.Close();

        }

    }
}
    