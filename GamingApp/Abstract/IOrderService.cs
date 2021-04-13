using GamingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp.Abstract
{
    public interface IOrderService
    {
        void AddToTheCart(Game game, Customer customer);
        void DeleteFromTheCart(Game game , Customer customer);
    }
}
