using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebSeriveAssignment3.Models;

namespace WebSeriveAssignment3.DataAccessLayer
{
    public class DAL
    {

        private readonly string connectionString;

        public DAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ICAStoreDBConnectionString"].ConnectionString;
        }


        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Customer";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Customer customer = new Customer();

                    customer.Id = (int)reader["Id"];
                    customer.Name = reader["Name"] as string;
                    customer.UserName = reader["UserName"] as string;
                    customer.Address = reader["Address"] as string;
                    customer.PhoneNumber = (int)reader["PhoneNumber"];
                    customer.Email = reader["Email"] as string;

                    customers.Add(customer);
                }

                reader.Close();
            }

            return customers;
        }
    }
}