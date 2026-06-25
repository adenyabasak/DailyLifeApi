using Microsoft.EntityFrameworkCore;
using DailyLifeApi.Models;

namespace DailyLifeApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Idea> Ideas { get; set; }
        public DbSet<ShoppingItem> ShoppingItems { get; set; }
        public DbSet<WaterTracking> WaterTrackings { get; set; }
        public DbSet<Mood> Moods { get; set; }
    }
}