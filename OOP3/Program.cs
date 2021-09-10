using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //DwellingCreditManager dwellingCreditManager = new DwellingCreditManager();
            //dwellingCreditManager.Calculate();

            //VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.Calculate();

            //PersonalFinanceCreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            //personalFinanceCreditManager.Calculate();

            ICreditManager dwellingCreditManager = new DwellingCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            AppealManager appealManager = new AppealManager();
            appealManager.Appeal(dwellingCreditManager, databaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() {dwellingCreditManager, vehicleCreditManager };

            //appealManager.KrediOnBilgilendirmesiYap(credits);
        }
    }
}
