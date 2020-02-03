using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class ShoppingCart
    {
        public List<int> ProductsIdList { get; set; }


        public ShoppingCart()
        {
            this.ProductsIdList = new List<int>();
        }
    }
}
