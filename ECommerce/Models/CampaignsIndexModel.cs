﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class CampaignsIndexModel
    {
        public IEnumerable<CampaignsIndexListingModel> Campaigns { get; set; }
    }
}
