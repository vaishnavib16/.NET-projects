using Microsoft.EntityFrameworkCore;
using MVCStudentManagement.Models;

namespace MVCStudentManagement.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Student> students {  get; set; }

    }
}
