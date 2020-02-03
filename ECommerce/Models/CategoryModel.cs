using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ParentCategoryId { get; set; }
        public CampaignsIndexListingModel CampaigneModel{get;set;}

    }
}
