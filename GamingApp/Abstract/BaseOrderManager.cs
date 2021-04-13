using GamingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp.Abstract
{
    public abstract class BaseOrderManager : IOrderService
    {
        public virtual void AddToTheCart(Game game, Customer customer)
        {
            Console.WriteLine(customer.FirstName+ " " + customer.LastName+", " + game.GameName + " is added to your cart with a price of $" + game.GamePrice);
        }

        public void DeleteFromTheCart(Game game, Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + ", " + game.GameName + " is deleted from your cart");
        }
    }
}
