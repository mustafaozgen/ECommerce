using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class CampaignsIndexListingModel
    {
        public int Id { get; set; }
        public float DiscountRate { get; set; }
        public int MinimumProductQuantity { get; set; }
        public string DiscountType { get; set; }
        public CategoryModel Category { get; set; }

    }
}
