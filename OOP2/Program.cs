using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.FirstName = "Emir";
            customer1.LastName = "ÇELİK";
            customer1.CustomerNo = "123456";
            customer1.TcNo = "12345678910";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CompanyName = "Sadece";
            customer2.CustomerNo = "123457";
            customer2.TalentNo = "1234567890";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();
        }
    }
}
