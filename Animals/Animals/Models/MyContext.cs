using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{




    public class DbContextAnimals : DbContext
    {
        string DbPath = @"C:\Users\sarah\databaseAnimals.db";

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductPromotion> ProductPromotions { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<ProductCart> ProductCarts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source = {DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>()
    .HasOne<Customer>(ca => ca.Customer)
    .WithMany(c => c.Carts)
    .HasForeignKey(ca => ca.CustomerId);

            modelBuilder.Entity<ProductCart>()
                .HasKey(pc => new { pc.ProductId, pc.CartId });

            modelBuilder.Entity<Product>()
                .HasOne<ProductCategory>(p => p.ProductCategory)
                .WithMany(pc => pc.Products)
                .HasForeignKey(p => p.ProductCategoryId);

            modelBuilder.Entity<ProductPromotion>()
                .HasKey(pp => new { pp.ProductId, pp.PromotionId });

            base.OnModelCreating(modelBuilder);

        }



    }





}
