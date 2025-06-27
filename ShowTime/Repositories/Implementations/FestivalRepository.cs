using ShowTime.Context;
using ShowTime.Entities;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories.Implementations
{
    public class FestivalRepository(ShowTimeContext context) : BaseRepository<Festival>(context), IFestivalRepository
    {
    }
}
