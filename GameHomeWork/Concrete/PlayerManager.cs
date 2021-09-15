using GameHomeWork.Abstract;
using GameHomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Concrete
{
    public class PlayerManager : IPlayerService
    {
        public void Add(Player player)
        {
            Console.WriteLine("->" + player.FirstName + " " + player.LastName + " has been added \n--------------------------------");
        }

        public void Delete(Player player)
        {
            Console.WriteLine("->" + player.FirstName + " " + player.LastName + " has been deleted \n--------------------------------");
        }

        public void Update(Player player)
        {
            Console.WriteLine("->" + player.FirstName + " " + player.LastName + " has been updated \n--------------------------------");
        }
    }
}