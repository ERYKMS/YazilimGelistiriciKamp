﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " ekldeni.");
        }

        public void Update(Product product) {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

    }
}