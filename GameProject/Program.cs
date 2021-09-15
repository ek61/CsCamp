using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Emir";
            gamer1.LastName = "ÇELİK";
            gamer1.TcNo = "12345678910";
            gamer1.BirthDay = new DateTime(2002, 03, 06);
        }
    }
}
