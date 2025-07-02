using Microsoft.EntityFrameworkCore;
using ShowTime.Context;
using ShowTime.Entities;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories.Implementations
{
    public class BandRepository(ShowTimeContext context) : BaseRepository<Band>(context), IBandRepository
    {
        public override async Task<Band> GetByIdAsync(Guid id)
        {
            return await _dbSet.Include(band => band.Festivals).FirstOrDefaultAsync(band => band.Id == id);
        }
    }
}
