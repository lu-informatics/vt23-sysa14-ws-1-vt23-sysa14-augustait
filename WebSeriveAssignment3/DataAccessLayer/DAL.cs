using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebSeriveAssignment3.DataAccessLayer
{
    public class DAL
    {
        public static List<Customer> GetCustomers()
        {
            var customers = new List<Customer>();
            using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
            {
                connection.Open();
                string query = "SELECT Name, CustomerID, UserName, Address, PhoneNumber, Email FROM Employee";                
                         var command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var customer = new Customer();
                    customer.Name = reader["Name"] as string;
                    customer.Id = (int)reader["CustomerID"];
                    customer.UserName = reader["UserName"] as string;
                    customer.Address = reader["Address"] as string;
                    customer.PhoneNumber = (int)reader["PhoneNumber"];
                    customer.Email = reader["Email"] as string;                
                    customers.Add(customer);
                }
            }
            return customers;
        }
 }



}