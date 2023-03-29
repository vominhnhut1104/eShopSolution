﻿using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
    public class Customer
    {
        public int Id { set; get; }
        public string FirstName { set; get; }

        public string LastName { set; get; }
        public string Email { set; get; }

        public bool Gender { set; get; }
        public string Phonenumber { set; get; }

        public decimal Bank { set; get; }

        //
        public List<Order> Orders { get; set; }
    }
}
