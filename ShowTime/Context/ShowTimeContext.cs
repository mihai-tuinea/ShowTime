using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShowTime.Entities;

namespace ShowTime.Context
{
    public class ShowTimeContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ShowTimeContext(DbContextOptions<ShowTimeContext> options) : base(options)
        {
        }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Festival> Festivals { get; set; }
        public DbSet<FestivalBand> FestivalBands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FestivalBand>()
                .HasKey(fb => new { fb.FestivalId, fb.BandId });

            modelBuilder.Entity<FestivalBand>()
                .HasOne(fb => fb.Festival)
                .WithMany(f => f.FestivalBands)
                .HasForeignKey(fb => fb.FestivalId);

            modelBuilder.Entity<FestivalBand>()
                .HasOne(fb => fb.Band)
                .WithMany(b => b.FestivalBands)
                .HasForeignKey(fb => fb.BandId);

            base.OnModelCreating(modelBuilder);
        }
        // public DbSet<Member> Members { get; set; }
    }
}
