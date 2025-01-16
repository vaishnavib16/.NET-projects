using Microsoft.EntityFrameworkCore;
using MovieWebApp.Entity;


namespace MovieWebApp.Repository
{
    public class MovieContext : DbContext
    {
        DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionstring = @"server=localhost;port=3306;user=root;password=Boku@123;database=MoviesWebApp";

            optionsBuilder.UseMySQL(connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasKey(p=> p.Id);
            });
            modelBuilder.Entity<Movie>().ToTable("Movies");
        }
    }
}
