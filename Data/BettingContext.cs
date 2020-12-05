using Betting.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Betting.Data
{
    public class BettingContext : DbContext
    {
        public BettingContext()
        {
        }

        public BettingContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<Bet> Bets { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<PlayerStatistic> PlayersStatistics { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Town> Towns { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Betting;Integrated Security=True;");
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerStatistic>(entity =>
            {
                entity.HasKey(sc => new { sc.PlayerId, sc.GameId });
            });

            modelBuilder.Entity<Color>(e =>
                 e.HasMany<Team>(color => color.PrimaryKitTeam).WithOne(team => team.PrimaryKitColor).OnDelete(DeleteBehavior.NoAction));

            modelBuilder.Entity<Color>(e =>
                e.HasMany<Team>(color => color.SecondaryKitTeam).WithOne(team => team.SecondaryKitColor).OnDelete(DeleteBehavior.NoAction));

            modelBuilder.Entity<Team>(e =>
                e.HasMany(t => t.HomeGame).WithOne(g => g.HomeTeam).OnDelete(DeleteBehavior.NoAction));

            modelBuilder.Entity<Team>(e =>
                e.HasMany(t => t.AwayGame).WithOne(g => g.AwayTeam).OnDelete(DeleteBehavior.NoAction));
        }
    }
}
