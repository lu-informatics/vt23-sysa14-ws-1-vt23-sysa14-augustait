﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSeriveAssignment3.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}