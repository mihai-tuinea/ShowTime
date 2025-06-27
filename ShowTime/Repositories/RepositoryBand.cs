using ShowTime.Context;
using ShowTime.Entities;
using ShowTime.Interfaces;

namespace ShowTime.Repositories
{
    public class RepositoryBand : RepositoryBase<Band>, IRepositoryBand
    {
        public RepositoryBand(ShowTimeContext context) : base(context)
        {
        }
    }
}
