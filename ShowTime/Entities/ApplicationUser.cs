using Microsoft.AspNetCore.Identity;

namespace ShowTime.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ICollection<Booking> Bookings { get; set; } = [];
    }
}
