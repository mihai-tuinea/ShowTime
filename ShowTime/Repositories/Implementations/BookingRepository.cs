using Microsoft.EntityFrameworkCore;
using ShowTime.Context;
using ShowTime.Entities;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories.Implementations
{
    public class BookingRepository(ShowTimeContext context) : BaseRepository<Booking>(context), IBookingRepository
    {
        public override async Task<IEnumerable<Booking>> GetAllAsync()
        {
            return await _context.Bookings
                .Include(booking => booking.Festival)
                .ToListAsync();
        }
    }
}
