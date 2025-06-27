using ShowTime.Context;
using ShowTime.Entities;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories.Implementations
{
    public class BookingRepository(ShowTimeContext context) : BaseRepository<Booking>(context), IBookingRepository
    {
    }
}
