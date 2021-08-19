using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Entities
{
    public class Campaign:IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public double CampaignDiscount { get; set; }

    }
}
