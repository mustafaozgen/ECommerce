﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class ProductIndexModel
    {
        public IEnumerable<ProductIndexListingModel> Products { get; set; }
    }
}
