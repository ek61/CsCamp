using GameHomeWork.Abstract;
using GameHomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("->" + game.Name + " has been added \n-------------------------------------");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("->" + game.Name + " has been deleted \n-------------------------------------");
        }

        public void Update(Game game)
        {
            Console.WriteLine("->" + game.Name + " has been updated \n-------------------------------------");
        }
    }
}
