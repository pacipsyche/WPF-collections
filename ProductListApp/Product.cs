﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductListApp
{
    public class Product
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string ImagePath { get; set; }
    }
}
