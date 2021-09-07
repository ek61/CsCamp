using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodsDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine("->" + customer.Name + " " + customer.LastName + " has been added \n--------------------------------");
        }

        public void CustomerDel(Customer customer)
        {
            Console.WriteLine("->" + customer.Name + " " + customer.LastName + " has been deleted \n--------------------------------");
        }

        public void CustomerList(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("->" + customer.Name + " "+ customer.LastName);
            }
            Console.WriteLine("Customers have been listed \n--------------------------------");
        }

    }
}
