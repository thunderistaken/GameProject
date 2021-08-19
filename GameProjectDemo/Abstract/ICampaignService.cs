using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Del(Campaign campaign);
        void Update(Campaign campaign);
    }
}
