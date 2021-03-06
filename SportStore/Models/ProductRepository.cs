﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SportStore.Models
{
    public class ProductRepository : IRepository
    {
        private ProductDBContext context = new ProductDBContext();

        public IEnumerable<Product> Products => context.Products;

        public async Task<int> SaveProductAsync(Product product)
        {
            if (product.Id == 0)
            {
                context.Products.Add(product);
            }
            else
            {
                Product dbEntry = context.Products.Find(product.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Description = product.Description;
                    dbEntry.Price = product.Price;
                    dbEntry.Category = product.Category;
                }
            }
            return await context.SaveChangesAsync();
        }

        public async Task<Product> DeleteProductAsync(int productID)
        {
            Product dbEntry = context.Products.Find(productID);
            if (dbEntry != null)
            {
                context.Products.Remove(dbEntry);
            }
            await context.SaveChangesAsync();
            return dbEntry;
        }

        public IEnumerable<Order> Orders => context.Orders.Include("Lines").Include("Lines.Product");

        public async Task<int> SaveOrderAsync(Order order)
        {
            if (order.Id == 0)
                context.Orders.Add(order);

            return await context.SaveChangesAsync();
        }

        public async Task<Order> DeleteOrderAsync(int orderID)
        {
            Order DbEntry = context.Orders.Find(orderID);
            if (DbEntry != null)
                context.Orders.Remove(DbEntry);

            await context.SaveChangesAsync();
            return DbEntry;
        }
    }
}