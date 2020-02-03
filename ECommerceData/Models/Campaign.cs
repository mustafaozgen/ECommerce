using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceData.Models
{

    public class Campaign
    {
        public int Id { get; set; }
        public float DiscountRate { get; set; }
        public int MinimumProductQuantity { get; set; }
        public string DiscountType { get; set; }

        public virtual Category Category { get; set; }
    }
}
