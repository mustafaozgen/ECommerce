using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceData.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }        
        public int CategoryId { get; set; }
    }
}
