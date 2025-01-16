using Microsoft.EntityFrameworkCore;
using ProductWebApp.Entity;

namespace ProductWebApp.Repository
{
    public class ProductContext : DbContext
    {
         public DbSet<Product> Products {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionstring = @"server=localhost;port=3306;user=root;password=Boku@123;database=ProductWebAppDB;";
            optionsBuilder.UseMySQL(connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.Id);
            });

            modelBuilder.Entity<Product>().ToTable("Products");
        }
    }
}
