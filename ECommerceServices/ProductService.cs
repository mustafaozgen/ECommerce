using ECommerceData;
using ECommerceData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommerceServices
{
    public class ProductService : IProduct
    {
        private ECommerceContext _context;

        public ProductService(ECommerceContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products;
                //.Include(asset => asset.Category)
                //.Include(asset => asset.Title)
                //.Include(asset => asset.Price);
        }

        public Product GetProduct(int id)
        {
            return GetAllProducts().FirstOrDefault(asset => asset.Id == id);
            //return _context.Products
            //    .Include(asset => asset.Title)
            //    .Include(asset => asset.Price)
            //    .FirstOrDefault(asset => asset.Id == id);
        }

        public void Add(Product newProduct)
        {
            _context.Add(newProduct);
            _context.SaveChanges();
        }

        public int GetCategoryId(int id)
        {
            return GetProduct(id).CategoryId;
            //return _context.Products.FirstOrDefault(asset => asset.Id == id).Category;
        }

        public double GetPrice(int id)
        {
            return GetProduct(id).Price;
            //return _context.Products.FirstOrDefault(asset => asset.Id == id).Price;
        }
        public string GetTitle(int id)
        {
            return GetProduct(id).Title;
            //return _context.Products.FirstOrDefault(asset => asset.Id == id).Title;
        }

    }
}
