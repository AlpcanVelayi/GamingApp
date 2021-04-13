using GamingApp.Abstract;
using GamingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " is added to the gaming platform with a discount %" + campaign.Discount );
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " is deleted from the gaming platform");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " has been updated to the gaming platform with a discount %" + campaign.Discount); 
        }
    }
}
