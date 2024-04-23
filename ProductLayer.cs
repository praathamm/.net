﻿using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;
namespace ConsoleApp8
{
    public class Productlayer
    {
        private string _connectionString;
        public Productlayer(IConfiguration iconfiguration)
        {
            _connectionString = iconfiguration.GetConnectionString("Default");
        }

        public void Products()
        {
            SqlConnection con = new SqlConnection(_connectionString);
            // Pass the connection to the command object, so the command object knows on which
            // connection to execute the command
            SqlCommand cmd = new SqlCommand("Select * from Product", con);
            // Open the connection. Otherwise you get a runtime error. An open connection is
            // required to execute the command            
            con.Open();
            Console.WriteLine("connected");
            SqlDataReader rdr = cmd.ExecuteReader(); //returns object of sqldatareder
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Console.WriteLine("{0} {1} {2} {3}", rdr["Id"], rdr["Name"], rdr["Price"], rdr["Qty"]);
                }
            }

        }
    }
}