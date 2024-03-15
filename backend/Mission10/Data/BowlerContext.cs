using Microsoft.EntityFrameworkCore;
using Mission10.Data;


namespace Mission10.data
{
    public class BowlerContext : DbContext
    {
        public BowlerContext(DbContextOptions<BowlerContext>options) : base(options) { }
        public DbSet<Bowler> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }
    }

}
