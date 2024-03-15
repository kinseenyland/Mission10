using Microsoft.EntityFrameworkCore;

namespace Mission10API.Data
{
    public class BowlerContext : DbContext
    {
        public BowlerContext(DbContextOptions<BowlerContext> options) : base(options) { }

        public DbSet<Bowler> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //Seed data
        {
            modelBuilder.Entity<Team>().HasData(

                new Team { TeamID = 1, TeamName = "Marlins" },
                new Team { TeamID = 2, TeamName = "Sharks" },
                new Team { TeamID = 3, TeamName = "Terrapins" },
                new Team { TeamID = 4, TeamName = "Barracudas" },
                new Team { TeamID = 5, TeamName = "Dolphins" },
                new Team { TeamID = 6, TeamName = "Orcas" },
                new Team { TeamID = 7, TeamName = "Manatees" },
                new Team { TeamID = 8, TeamName = "Swordfish" },
                new Team { TeamID = 9, TeamName = "Huckleberrys" },
                new Team { TeamID = 10, TeamName = "MintJuleps" }
            );
        }
    }
}
