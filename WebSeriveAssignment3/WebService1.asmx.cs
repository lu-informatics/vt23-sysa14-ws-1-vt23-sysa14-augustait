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
            DAL dataAccess = new DAL();
            List<Customer> customers = dataAccess.GetAllCustomers();
            return customers;
        }
    }
}

