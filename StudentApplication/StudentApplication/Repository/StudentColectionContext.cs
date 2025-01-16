using Microsoft.EntityFrameworkCore;
using StudentApplication.Models;
namespace StudentApplication.Repository
{
    public class StudentColectionContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionstring = @"server=localhost;port=3306;user=root;password=root;database=StudentDotNet;";
            optionsBuilder.UseMySQL(connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.id);
            });
            modelBuilder.Entity<Student>().ToTable("Students");
            
        }
    }
}
