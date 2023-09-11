using Microsoft.EntityFrameworkCore;

namespace StudentCrud_EntityFramework.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
