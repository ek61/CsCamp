using GameHomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);

    }
}
