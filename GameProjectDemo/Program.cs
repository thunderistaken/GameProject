using GameProjectDemo.Abstract;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager();
            GameManager gameManager = new GameManager();
            CampaignManager campaignManager = new CampaignManager();
            SaleManager saleManager = new SaleManager();

            Gamer gamer1 = new Gamer()
            {
                Id = 01,
                FirstName = "Eray",
                LastName = "Karaman",
                BirthDay = new DateTime(2001, 05, 04),
                NationalIdentity ="12345678910"
            };

            Gamer gamer2 = new Gamer()
            {
                Id = 01,
                FirstName = "Deneme",
                LastName = "DenemeSoyad",
                BirthDay = new DateTime(2011, 08, 09),
                NationalIdentity = "7978978798978"
            };

            Game game1 = new Game()
            {
                GameId = 123,
                GameName = "F1 2021",
                GameCategory = 5,
                GamePrice = 90.50
            };
            Game game2 = new Game()
            {
                GameId = 223,
                GameName = "BF5",
                GameCategory = 1,
                GamePrice = 120
            };

            Campaign campaign1 = new Campaign()
            {
                CampaignId =1,
                CampaignName = "Yarış oyunları indirimi",
                CampaignDiscount = 50
            };
            Campaign campaign2 = new Campaign()
            {
                CampaignId = 1,
                CampaignName = "Savaş Oyunları İndirimi",
                CampaignDiscount = 35
            };

            gamerManager.Add(gamer1);
            gameManager.Add(game1);
            campaignManager.Add(campaign1);
            saleManager.Sale(game1, gamer1, campaign1);
            Console.WriteLine("*********************************************");
            gamerManager.Add(gamer2);
            gameManager.Add(game2);
            campaignManager.Add(campaign2);
            saleManager.Sale(game2, gamer2, campaign2);














        }
    }
}
