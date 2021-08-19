using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class SaleManager : ISaleManager
    {
        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            double campaignPrice = game.GamePrice - (game.GamePrice * (campaign.CampaignDiscount / 100));
            Console.WriteLine(game.GameName +  " Oyunu " + gamer.FirstName + " adlı kişiye " + campaign.CampaignName + " kampanyası fırsatıyla " + game.GamePrice + " yerine " + campaignPrice + " fiyatına satıldı");
        }
    }
}
