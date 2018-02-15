using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SportStore.Models
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext() : base("SportStoreDb") {
            Database.SetInitializer<ProductDBContext>(new ProductDbInitializer());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
    }
}