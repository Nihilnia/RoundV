using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_manyToMany
{
    internal class ShopContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlite("Data Source = Shop.db")
                .LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                .HasKey(prm => new { prm.ProductID, prm.CategoryID });

            modelBuilder.Entity<ProductCategory>()
                .HasOne(pc => pc.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(pc => pc.ProductID);

            modelBuilder.Entity<ProductCategory>()
                .HasOne(ctg => ctg.Category)
                .WithMany(c => c.ProductCategories)
                .HasForeignKey(ctg => ctg.CategoryID);
        }
    }
}
