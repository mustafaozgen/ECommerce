using ECommerceData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class ProductIndexListingModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        //public int CategoryId { get; set; }

    }
}
