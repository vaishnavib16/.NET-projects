using Microsoft.EntityFrameworkCore;
using StudentWebApp.Entity;

namespace StudentWebApp.Repository
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String connectionString = @"server=localhost;port=3306;user=root;password=Boku@123;database=StrudentinfoDotNet";
            optionsBuilder.UseMySQL(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(Stu =>
            {
                Stu.HasKey(e => e.Id);

            });
            modelBuilder.Entity<Student>().ToTable("Student");
        }

    }
}
