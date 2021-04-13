using GamingApp.Abstract;
using GamingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " is added to the gaming platform with a price of $" + game.GamePrice);
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " is deleted from the gaming platform");
        }
    }
}
