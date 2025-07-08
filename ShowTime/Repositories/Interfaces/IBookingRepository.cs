using ShowTime.Entities;

namespace ShowTime.Repositories.Interfaces
{
    public interface IBookingRepository : IBaseRepository<Booking>
    {
        Task<IEnumerable<Booking>> GetBookingsByUserIdAsync(Guid userId);
    }
}
