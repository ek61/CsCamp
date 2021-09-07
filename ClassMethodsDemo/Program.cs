using System;

namespace ClassMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Emir";
            customer1.LastName = "ÇELİK";
            customer1.AccountNumber = 10000;

            Customer customer2 = new Customer();
            customer2.Name = "Berke";
            customer2.LastName = "ASMAKAYA";
            customer2.AccountNumber = 10001;

            Customer[] customers = new Customer[] { customer1, customer2 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerAdd (customer1);
            customerManager.CustomerAdd (customer2);
            customerManager.CustomerDel (customer1);
            customerManager.CustomerList(customers);

        }
    }
}
