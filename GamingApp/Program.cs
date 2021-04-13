using GamingApp.Abstract;
using GamingApp.Adapters;
using GamingApp.Concrete;
using GamingApp.Entities;
using System;

namespace GamingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new CustomerCheckManager());
            Customer customer1 = new Customer() {Id = 1, FirstName = "Alpcan", LastName = "Velayi", BirthDate = new DateTime(1995,06,22), NationalityId = "12345678900", NickName = "Cimcim" };

            Game game1 = new Game() {Id = 1, GameName = "Remnant", GamePrice = 49.99 };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            Campaign campaign1 = new Campaign() { Id = 1, CampaignName = "Summer Discount", Discount = 35 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            BaseOrderManager baseOrderManager = new OrderManager(campaign1);
            baseOrderManager.AddToTheCart(game1, customer1);
            
        }
    }
}
