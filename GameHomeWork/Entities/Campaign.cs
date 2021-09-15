using GameHomeWork.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Entities
{
    public class Campaign: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DiscountRate { get; set; }
    }
}
