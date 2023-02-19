using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSeriveAssignment3.Models;

namespace WebSeriveAssignment3.Models
{
    public class Order
    {   
        public int OrderID { get; set; }
        public string OrderDate { get; set; }
        public int SupermarketID  { get; set; }
        public int CustomerID { get; set; }
        public string PaymentMethod { get; set; }
    }
}
