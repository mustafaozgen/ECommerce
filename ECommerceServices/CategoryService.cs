using ECommerceData;
using ECommerceData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerceServices
{
    public class CategoryService : ICategory
    {
        private ECommerceContext _context;



        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Category;
        }

        public Category GetCategory(int id)
        {
            return GetAllCategories().FirstOrDefault(asset => asset.Id == id);
        }


    }
}
