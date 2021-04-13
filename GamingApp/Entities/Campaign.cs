using GamingApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp.Entities
{
    public class Campaign : IEntities
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double Discount { get; set; }
    }
}
