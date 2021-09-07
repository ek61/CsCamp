using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.Name = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 10;

            Product product2 = new Product { Id = 2, CategoryId = 4,
                Name = "Kalem", UnitsInStock = 7, UnitPrice = 10};

            ProductManager productManager = new ProductManager();
            productManager.Add(product2);

        }
    }
}
