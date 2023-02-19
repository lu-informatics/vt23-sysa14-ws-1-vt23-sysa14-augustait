using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace WebSeriveAssignment3.Models
{
    public class Store
    {
        public int StoreID { get; set; }
        public string RegionName { get; set; }
        public string StoreName { get; set; }
        public string City { get; set; }
        public string StoreAddress { get; set; }
    }
}

