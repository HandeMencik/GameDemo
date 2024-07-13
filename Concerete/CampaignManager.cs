using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concerete
{
    public class CampaignManager : ICampaign
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi:  "+ campaign.CampaignName);
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi:  "+ campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi:  "+ campaign.CampaignName);
        }
    }
}
