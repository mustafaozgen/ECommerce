using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceData.Models
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
