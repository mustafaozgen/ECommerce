using ECommerceData.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ECommerceData
{
    public class ECommerceContext : DbContext
    {
       
        public ECommerceContext(DbContextOptions options) : base (options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Campaign> Orders { get; set; }
        public DbSet<Campaign> OrderItems { get; set; }
        public IEnumerable<Category> Category { get; set; }
    }
}
