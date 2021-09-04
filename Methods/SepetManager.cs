
using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi : " + product.Name);
        }

        public void AddAlternaitve(string productName, string explanation, double price, int stockNumber)
        {
            Console.WriteLine("Sepete Eklendi : " + productName);
        }
    }
}