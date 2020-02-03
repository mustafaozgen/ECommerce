using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class DeliveryCostCalculator
    {
        public double costPerDelivery { get; set; }
        public double costPerProduct { get; set; }
        public double fixedCost { get; set; }
        public DeliveryCostCalculator(double costPerDelivery, double costPerProduct, double fixedCost)
        {
            this.costPerDelivery = costPerDelivery;
            this.costPerProduct = costPerProduct;
            this.fixedCost = fixedCost;
        }

        public double CalculateFor(Sepet sepet)
        {

            return (costPerDelivery * 2) + (costPerProduct * 3) + fixedCost;
        }

    }
}
