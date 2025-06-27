using Microsoft.EntityFrameworkCore;
using BlazorApp2.Entities;

namespace BlazorApp2.Context
{
    public class ShowTimeContext : DbContext
    {
        public ShowTimeContext(DbContextOptions<ShowTimeContext> options) : base(options)
        {
        }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Festival> Festivals { get; set; }
        // public DbSet<FavoriteFestival> FavoriteFestivals { get; set; }
        // public DbSet<FestivalBand> FestivalBands { get; set; }
        // public DbSet<Member> Members { get; set; }
        // public DbSet<User> Users { get; set; }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ShowTime;Trusted_Connection=True;");
        }
        */
    }
}
