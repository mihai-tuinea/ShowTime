using Microsoft.EntityFrameworkCore;
using ShowTime.Context;
using ShowTime.Entities;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories.Implementations
{
    public class BandRepository(ShowTimeContext context) : BaseRepository<Band>(context), IBandRepository
    {
    }
}
