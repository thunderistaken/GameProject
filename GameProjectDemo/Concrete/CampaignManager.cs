using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi " + campaign.CampaignName + ". İndirim oranı %" + campaign.CampaignDiscount);

        }

        public void Del(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi " + campaign.CampaignName);

        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi " + campaign.CampaignName + ". İndirim oranı %" + campaign.CampaignDiscount);

        }
    }
}
