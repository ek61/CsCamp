using GameHomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Abstract
{
    public interface ISalesService
    {
        void Sale(Sales sales, Player player, Game game);
        void DiscountedSale(Sales sales, Player player, Game game, Campaign campaign);
    }
}
