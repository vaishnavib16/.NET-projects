using Microsoft.EntityFrameworkCore;
using ProductApplication.Models;

namespace ProductApplication.Repository
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String connectionstring = @"server=localhost;post=3306;user=root;password=Boku@123;database=ProductDotNetDB;";
            optionsBuilder.UseMySQL(connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(p =>
            {
                p.HasKey(p => p.Id);

            });
            modelBuilder.Entity<Product>().ToTable("products");
        }
    }
}
