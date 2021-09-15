using GameHomeWork.Entities;
using System;
using GameHomeWork.Concrete;

namespace GameHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Id = 1;
            player1.FirstName = "Emir";
            player1.LastName = "ÇELİK";
            player1.TcNo = "42592482994";
            player1.DateOfBirth = new DateTime(2002, 03, 06);

            Player player2 = new Player();
            player2.Id = 2;
            player2.FirstName = "Berke";
            player2.LastName = "ASMAKAYA";
            player2.TcNo = "12345678910";
            player2.DateOfBirth = new DateTime(2002, 05, 02);

            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(player2);
            playerManager.Add(player1);
            playerManager.Delete(player1);
            playerManager.Update(player2);


            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.Name = "Spring Campaign";
            campaign1.DiscountRate = 15;

            Campaign campaign2 = new Campaign();
            campaign2.Id = 2;
            campaign2.Name = "Halloween Campaign";
            campaign2.DiscountRate = 25;
            
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Delete(campaign1);
            campaignManager.Update(campaign2);


            Game game1 = new Game();
            game1.Id = 1;
            game1.Name = "Assetto Corsa";
            game1.Cost = 50;

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Update(game1);


            Sales sale1 = new Sales();
            sale1.Id = 1;
            Sales sale2 = new Sales();
            sale2.Id = 2;

            SalesManager salesManager1 = new SalesManager();
            salesManager1.DiscountedSale(sale1, player2, game1, campaign2);
            SalesManager salesManager2 = new SalesManager();
            salesManager2.Sale(sale2, player1, game1);
        }
    }
}
