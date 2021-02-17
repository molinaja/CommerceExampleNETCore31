﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogDomain
{
    public class Product
    {
        public int productID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public ProductInStock stock { get; set; }

    }
}
