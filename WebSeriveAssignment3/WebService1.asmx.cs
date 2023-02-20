using System;
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
     


        [WebMethod(Description = "Returns a list of all Customers")]
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = DataAccessLayer.DAL.GetAllCustomers();
            return customers;
        }

        [WebMethod(Description = "Returns a list of all Products")]
        public List<Product> GetProducts()
        {
            List<Product> products = DataAccessLayer.DAL.GetAllProducts();
            return products;
        }

        [WebMethod(Description = "Returns a list of all stores")]
        public List<Store> GetStores()
        {
            List<Store> stores = DataAccessLayer.DAL.GetAllStores();
            return stores;
        }

        [WebMethod(Description = "Returns a list of all Product Categories")]
        public List<ProductCategory> GetCategories()
        {
            List<ProductCategory> categories = DataAccessLayer.DAL.GetAllProductCategories();
            return categories;
        }

        [WebMethod(Description = "Returns a list of all orders")]
        public List<Order> GetOrders()
        {
            List<Order> orders = DataAccessLayer.DAL.GetAllOrders();
            return orders;
        }



      /*  [WebMethod(Description = "Returns all products from chosen category")]
        public static Product product(int CategoryID)
        {
            DAL dataAccess = new DAL();
            Product product = dataAccess.GetProductsFromCatgeory(CategoryID);
            return product;
        } */
    }
}


