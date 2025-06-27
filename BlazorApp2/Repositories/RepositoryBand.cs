using BlazorApp2.Context;
using BlazorApp2.Entities;
using BlazorApp2.Interfaces;

namespace BlazorApp2.Repositories
{
    public class RepositoryBand :RepositoryBase<Band>, IRepositoryBand
    {
        public RepositoryBand(ShowTimeContext context) : base(context)
        {
        }
    }
}
