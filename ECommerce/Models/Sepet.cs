using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class Sepet
    {
        public List<SepetDetay> sepetDetayList = new List<SepetDetay>();
        public double Total
        {
            get
            {
                return this.sepetDetayList.Sum(i => i.subTotal);
            }


        }
    }
}
