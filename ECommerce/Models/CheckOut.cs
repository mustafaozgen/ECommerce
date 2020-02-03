using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class CheckOut
    {
        private static List<ProductDetailModel> products = new List<ProductDetailModel>();

        public static List<ProductDetailModel> ListProducts
        {
            get
            {
                return products;
            }
        }
        public static void AddProduct(ProductDetailModel product)
        {
            products.Add(product);
        }
    }
}
