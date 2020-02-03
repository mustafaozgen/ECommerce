using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class SepetDetay
    {
        public ProductDetailModel product { get; set; }
        public int Quantity { get; set; }

        public double subTotal
        {
            get
            {
                return (this.product.Price * this.Quantity );
            }
        }



    }
}
