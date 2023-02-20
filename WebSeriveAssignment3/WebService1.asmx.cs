﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebSeriveAssignment3.DataAccessLayer;
using WebSeriveAssignment3.Models;

namespace WebSeriveAssignment3
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://ics.lu.se/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
   
    public class WebService1 : System.Web.Services.WebService
    {
        DAL dataAccess = new DAL();


        [WebMethod(Description = "Returns a list of all Customers")]
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = dataAccess.GetAllCustomers();
            return customers;
        }

        [WebMethod(Description = "Returns a list of all Products")]
        public List<Product> GetProducts()
        {
            List<Product> products = dataAccess.GetAllProducts();
            return products;
        }

        [WebMethod(Description = "Returns a list of all stores")]
        public List<Store> GetStores()
        {
            List<Store> stores = dataAccess.GetAllStores();
            return stores;
        }

        [WebMethod(Description = "Returns a list of all Product Categories")]
        public List<ProductCategory> GetCategories()
        {
            List<ProductCategory> categories = dataAccess.GetAllProductCategories();
            return categories;
        }

        [WebMethod(Description = "Returns a list of all orders")]
        public List<Order> GetOrders()
        {
            List<Order> orders = dataAccess.GetAllOrders();
            return orders;
        }

      [WebMethod(Description = "Returns all products from chosen category")]
        public List<Product> GetProductsFromCategory(int categoryID)
        {
           List <Product> products = DAL.GetProductsFromCatgeory(categoryID);
            return products;
        }

        [WebMethod(Description = "Returns a customer by ID")]
        public Customer GetCustomerByID(int customerID)
        {
            Customer customer = DAL.GetCustomerByID(customerID);
            return customer;
        }

        [WebMethod(Description = "Returns the product with the highest price")]
        public Product GetProductPriceHighest(int price)
        {
            Product product = DAL.GetProductPriceHighest(price);
            return product;
        }

        [WebMethod(Description = "Returns all orders from a customer")]
        public List<Order> GetOrdersFromCustomer(int customerID)
        {
           List <Order> orders = DAL.GetOrdersFromCustomer(customerID);
            return orders;
        }
    }
}


