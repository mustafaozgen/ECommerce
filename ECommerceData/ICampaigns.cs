using ECommerceData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceData
{
    public interface ICampaigns
    {
        IEnumerable<Campaign> GetAllCampaigns();
        Campaign GetCampaign(int id);
        string GetCampaignRate(int id);
    }

}
