using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Explanation = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 20;
            product2.Explanation = "Diyarbakır Karbuuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("- - - - - - - - - -");
            }

            Console.WriteLine("----------Methods------------");

            //Encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product2);
            sepetManager.Add(product1);

            sepetManager.AddAlternaitve("Armut", "Yeşil Armut", 15, 10);
            sepetManager.AddAlternaitve("Elma", "Yeşil Elma", 10, 5);
        }
    }
}