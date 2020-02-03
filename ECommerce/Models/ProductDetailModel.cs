using ECommerceData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class ProductDetailModel
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        public CategoryModel Category = new CategoryModel();

   
    }
}
