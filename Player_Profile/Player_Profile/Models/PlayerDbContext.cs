using Microsoft.EntityFrameworkCore;

namespace Player_Profile.Models
{
    public class PlayerDbContext : DbContext
    {
        public PlayerDbContext(DbContextOptions<PlayerDbContext> options) : base(options) { }
        public DbSet<CricketPlayer> CricketPlayers { get; set; }
        public DbSet<FootballPlayer> FootballPlayers { get; set; }
        public DbSet<TennisPlayer> TennisPlayers { get; set; }
        public DbSet<PokerPlayer> PokerPlayers { get; set; }
    }
}
