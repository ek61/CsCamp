using GameHomeWork.Abstract;
using GameHomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Concrete
{
    class SalesManager : ISalesService
    {
        public void DiscountedSale(Sales sales, Player player, Game game, Campaign campaign)
        {
            Console.WriteLine("#" + sales.Id + "# " + player.FirstName + " " + player.LastName + " " + game.Name
                + " adlı oyunu %" + campaign.DiscountRate + " indirim ile aldı");
        }

        public void Sale(Sales sales, Player player, Game game)
        {
            Console.WriteLine("#" + sales.Id + "# " + player.FirstName + " " + player.LastName + " " + game.Name
                + " adlı oyunu aldı");
        }
    }
}
