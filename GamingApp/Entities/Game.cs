using GamingApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp.Entities
{
    public class Game : IEntities
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
    }
}
