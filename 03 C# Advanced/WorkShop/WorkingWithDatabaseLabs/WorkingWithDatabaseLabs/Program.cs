﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WorkingWithDatabaseLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            Read();
            Insert();
            Update();
            Delete();
        }

        private static void Delete()
        {
            //
            // First access the connection string.
            // ... This may be autogenerated in Visual Studio.
            //
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            //
            // In a using statement, acquire the SqlConnection as a resource.
            //
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //
                // Open the SqlConnection.
                //
                con.Open();
                //
                // This code uses an SqlCommand based on the SqlConnection.
                //
                using (SqlCommand command = new SqlCommand("Delete from Authors where Name = 'Gaby Willer'", con))
                {
                    var result = command.ExecuteNonQuery();
                }
            }
        }

        private static void Update()
        {
            //
            // First access the connection string.
            // ... This may be autogenerated in Visual Studio.
            //
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            //
            // In a using statement, acquire the SqlConnection as a resource.
            //
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //
                // Open the SqlConnection.
                //
                con.Open();
                //
                // This code uses an SqlCommand based on the SqlConnection.
                //
                using (SqlCommand command = new SqlCommand("Update Authors Set Name = 'Gaby Willer' where name ='Gaby Watson'", con))
                {
                  var result = command.ExecuteNonQuery();
                }
            }
        }

        private static void Insert()
        {
            //
            // First access the connection string.
            // ... This may be autogenerated in Visual Studio.
            //
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            //
            // In a using statement, acquire the SqlConnection as a resource.
            //
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //
                // Open the SqlConnection.
                //
                con.Open();
                //
                // This code uses an SqlCommand based on the SqlConnection.
                //
                using (SqlCommand command = new SqlCommand("insert into Authors values ('Gaby Watson') ", con))
                {
                    var result = command.ExecuteNonQuery();
                }
            }
        }

        static void Read()
        {
            //
            // First access the connection string.
            // ... This may be autogenerated in Visual Studio.
            //
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            //
            // In a using statement, acquire the SqlConnection as a resource.
            //
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //
                // Open the SqlConnection.
                //
                con.Open();
                //
                // This code uses an SqlCommand based on the SqlConnection.
                //
                using (SqlCommand command = new SqlCommand("SELECT * FROM Authors", con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //Console.WriteLine("{0} {1} ",
                        //    reader.GetInt32(0), reader.GetString(1));
                        Console.WriteLine("{0} {1} ",
                           reader["AuthorId"], reader["Name"]);
                    }
                }
            }
        }
    }
}
