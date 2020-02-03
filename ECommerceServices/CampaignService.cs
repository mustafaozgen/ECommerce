using ECommerceData;
using ECommerceData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerceServices
{
    public class CampaignService : ICampaigns
    {
        private ECommerceContext _context;
        public IEnumerable<Campaign> GetAllCampaigns()
        {
            return _context.Campaigns;
        }

        public Campaign GetCampaign(int id)
        {
            return GetAllCampaigns().FirstOrDefault(asset => asset.Id == id);
        }

        public string GetCampaignRate(int id)
        {
            return GetCampaignRate(id);
        }
    }
}
