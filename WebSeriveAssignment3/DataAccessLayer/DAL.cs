using System;
using System.Collections;
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

        public static List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();

            using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
            {
                connection.Open();

                string query = "SELECT * FROM Customer";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Customer customer = new Customer();

                    customer.Name = reader["Name"] as string;
                    customer.CustomerID = (int)reader["CustomerID"];                  
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
        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
            {
                connection.Open();

                string query = "SELECT * FROM Product";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();

                    product.ProductID = (int)reader["ProductID"];
                    product.ProductName = reader["ProductName"] as string;
                    product.Price = (decimal)reader["Price"];
                    product.CategoryID = (int)reader["CategoryID"];
                
                    products.Add(product);
                }
                reader.Close();
            }
            return products;
        }
        public static List<Store> GetAllStores()
        {
            List<Store> stores = new List<Store>();

            using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
            {
                connection.Open();

                string query = "SELECT * FROM Store";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Store store = new Store();

                    store.SupermarketID = (int)reader["SupermarketID"];
                    store.RegionName = reader["RegionName"] as string;
                    store.StoreName = reader["StoreName"] as string;
                    store.City = reader["City"] as string;
                    store.StoreAddress = reader["StoreAddress"] as string;

                    stores.Add(store);
                }
                reader.Close();
            }
            return stores;
        }
        public static List<ProductCategory> GetAllProductCategories()
        {
            List<ProductCategory> categories = new List<ProductCategory>(); 

            using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
            {
                connection.Open();

                string query = "SELECT * FROM ProductCategory";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ProductCategory category = new ProductCategory();

                    category.CategoryID = (int)reader["CategoryID"];
                    category.CategoryName = reader["CategoryName"] as string;
                  
                    categories.Add(category);
                }
                reader.Close();
            }
            return categories;
        }
        public static List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();

            using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
            {
                connection.Open();

                string query = "SELECT * FROM Order_";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Order order = new Order();

                    order.OrderID = (int)reader["OrderID"];
                    order.OrderDate = reader["OrderDate"] as string;
                    order.SupermarketID = (int)reader["SupermarketID"];
                    order.CustomerID = (int)reader["CustomerID"]; ;
                    order.PaymentMethod = reader["PaymentMethod"] as string;
  
                    orders.Add(order);
                }
                reader.Close();         
    }
            return orders;
        }
        public static List<Product> GetProductsFromCatgeory(int CategoryID)
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
            {
                connection.Open();

                string query = "SELECT ProductName, CategoryID FROM Product WHERE CategoryID = @CategoryID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CategoryID", CategoryID);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.CategoryID = (int)reader["CategoryID"];
                    product.ProductName = reader["ProductName"] as string;

                    products.Add(product);
                }
            }

            return products;
    
        }
        public static Customer GetCustomerByID(int CustomerID)
        {
            Customer customer = null;
            using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
            {
                connection.Open();

                string query = "SELECT * FROM Customer WHERE CustomerID = @CustomerID"; 
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    customer = new Customer();
                    customer.CustomerID = (int)reader["CustomerID"];
                    customer.Name = reader["Name"] as string;
                    customer.UserName = reader["UserName"] as string;
                    customer.Address = reader["Address"] as string;
                    customer.PhoneNumber = (int)reader["PhoneNUmber"];
                    customer.Email = reader["Email"] as string;

                }
            return customer;
    }
        }

        public static Product GetProductPriceHighest()
    {
        Product product = null;
        using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
        {
            connection.Open();

            string query = "SELECT ProductName, Price FROM Product " +
                    "WHERE Price = (SELECT MAX(Price) FROM Product)";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read()) {     
                product = new Product();
                product.Price = (decimal)reader["Price"];
                product.ProductName = reader["ProductName"] as string;
            }
            return product;
        }

    }
        public static List<Order> GetOrdersFromCustomer(int customerID)
        {
            List<Order> orders = new List<Order>();
            using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
            {
                connection.Open();

                string query = "SELECT * FROM Order_ WHERE CustomerID = @CustomerID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", customerID);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Order order = new Order();
                    order.OrderID = (int)reader["OrderID"];
                    order.OrderDate = reader["OrderDate"] as string;
                    order.SupermarketID = (int)reader["SupermarketID"];
                    order.CustomerID = (int)reader["CustomerID"];
                    order.PaymentMethod = reader["PaymentMethod"] as string;
                    orders.Add(order);
                }
            }
            return orders;
        }
   
    public static List<Orderline> GetOrderLinesFromOrder(int OrderID)
    {
        List<Orderline> orderlines = new List<Orderline>();

        using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
        {
            connection.Open();

            string query = "SELECT * FROM Orderline WHERE OrderID = @OrderID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@OrderID", OrderID);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Orderline orderline = new Orderline();
                orderline.OrderID = (int)reader["OrderID"];
                orderline.ProductID = (int)reader["ProductID"];
                orderline.OrderlineNumber = (int)reader["OrderlineNumber"];
                orderline.Quantity = (int)reader["Quantity"];


                orderlines.Add(orderline);
            }
            return orderlines;
        }
    }
}
}






