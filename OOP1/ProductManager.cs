﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) 
        {
            Console.WriteLine(product.Name + "has been added");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.Name + "has been updated");
        }
    }
}
