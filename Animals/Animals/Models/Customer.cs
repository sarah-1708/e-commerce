﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Lastname { get; set; }

        public string Firstname { get; set; }
        public ICollection<Cart>? Carts { get; set; }
     


    }
}
