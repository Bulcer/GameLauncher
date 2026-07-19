using GameLauncher.DAL.Entities;
using Microsoft.EntityFrameworkCore;
namespace GameLauncher.DAL;

public class GameLauncherContext : DbContext
{
    public DbSet<Game> Games => Set<Game>();
    public DbSet<User> Users => Set<User>();
    public DbSet<Library> Libraries => Set<Library>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Studio> Studios => Set<Studio>();
    public DbSet<Review> Reviews => Set<Review>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=gamelauncher.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Library>()
            .HasIndex(z => z.UserId)
            .IsUnique();

        modelBuilder.Entity<Review>()
            .HasKey(z => new { z.UserId, z.GameId });
    }
}