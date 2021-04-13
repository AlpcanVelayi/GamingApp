using GamingApp.Abstract;
using GamingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp.Concrete
{
    public class OrderManager : BaseOrderManager
    {
        private Campaign _campaign;

        public OrderManager(Campaign campaign)
        {
            _campaign = campaign;
        }
        public override void AddToTheCart(Game game, Customer customer)
        {

            Console.WriteLine(customer.FirstName + " "+customer.LastName+" added " + game.GameName+ " to the cart with a price of $" + game.GamePrice*(100-_campaign.Discount)/100 );
        }
    }
}
