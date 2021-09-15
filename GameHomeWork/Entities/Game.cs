using GameHomeWork.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Entities
{
    public class Game: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
    }
}
