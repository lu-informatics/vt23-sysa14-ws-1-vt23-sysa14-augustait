﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSeriveAssignment3.Models
{
    public class Orderline
    {  
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int OrderlineNumber { get; set; }
        public int Quantity { get; set; }
    }
}

