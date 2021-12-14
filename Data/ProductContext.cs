using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MattNyce.Models;

namespace MattNyce.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Product>()
                .Property(p => p.Quantity)
                .HasColumnType("int");
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Gaming PC",
                    Price = 1699,
                    Quantity = 5
                },
                new Product
                {
                    Id = 2,
                    Name = "Gaming Laptop",
                    Price = 1499,
                    Quantity = 10
                },
                new Product
                {
                    Id = 3,
                    Name = "Gaming Console",
                    Price = 699,
                    Quantity = 15
                }
                );
        }
        
        

    }
}