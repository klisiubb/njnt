using Microsoft.EntityFrameworkCore;
namespace projekt_njnt.Models
{
    public class dbContext:DbContext
    {
        public dbContext(DbContextOptions options) : base(options)
        {
        }

        //public DbSet<Set> Name { get; set; }
    }
}
