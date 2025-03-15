using Microsoft.EntityFrameworkCore;

namespace Mission10_Nemet.Data
{
    public class BowlerDbContext : DbContext
    {
        public BowlerDbContext(DbContextOptions<BowlerDbContext> options) : base(options)
        {
        }
        // Add a DbSet for the Bowler entity Bowler.cs
        public DbSet<Bowler> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }

    }

}
