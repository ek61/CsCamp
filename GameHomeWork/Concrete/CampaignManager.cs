using GameHomeWork.Abstract;
using GameHomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("->" + campaign.Name + " has been added \n-------------------------------------");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("->" + campaign.Name + " has been deleted \n-------------------------------------");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("->" + campaign.Name + " has been updated \n-------------------------------------");
        }
    }
}
