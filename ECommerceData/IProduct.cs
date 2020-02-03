using ECommerceData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceData
{
    public interface IProduct
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProduct(int id);
        
        void Add(Product newProduct);
        string GetTitle(int id);
        double GetPrice(int id);

        int GetCategoryId(int id);
    }
}
