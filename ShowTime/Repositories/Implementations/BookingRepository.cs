using Microsoft.EntityFrameworkCore;
using ShowTime.Context;
using ShowTime.Entities;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories.Implementations
{
    public class BookingRepository(ShowTimeContext context) : BaseRepository<Booking>(context), IBookingRepository
    {
        public async Task<IEnumerable<Booking>> GetBookingsByUserIdAsync(Guid userId)
        {
            return await _context.Bookings
                .Where(b => b.ApplicationUserId == userId)
                .ToListAsync();
        }
    }
}
