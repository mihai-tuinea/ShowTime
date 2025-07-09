using Microsoft.EntityFrameworkCore;
using ShowTime.Context;
using ShowTime.Entities;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories.Implementations
{
    public class FestivalRepository(ShowTimeContext context) : BaseRepository<Festival>(context), IFestivalRepository
    {
        public override async Task<Festival> GetByIdAsync(Guid id)
        {
            return await _dbSet
                .Include(f => f.FestivalBands)
                .FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}
