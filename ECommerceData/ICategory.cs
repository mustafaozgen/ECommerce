using ECommerceData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceData
{
    public interface ICategory
    {
        IEnumerable<Category> GetAllCategories();
        Category GetCategory(int id);
      
    }
}
