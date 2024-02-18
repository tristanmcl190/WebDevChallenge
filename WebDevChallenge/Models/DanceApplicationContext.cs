using Microsoft.EntityFrameworkCore;

namespace WebDevChallenge.Models
{
    public class DanceApplicationContext : DbContext
    {
        public DanceApplicationContext(DbContextOptions<DanceApplicationContext> options) : base (options)
        { 
        }

        public DbSet<Application> Applications { get; set; }
    }
}
