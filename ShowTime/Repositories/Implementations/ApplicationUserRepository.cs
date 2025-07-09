using Microsoft.EntityFrameworkCore;
using ShowTime.Context;
using ShowTime.Entities;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories.Implementations
{
    public class ApplicationUserRepository(ShowTimeContext context) : BaseRepository<ApplicationUser>(context), IApplicationUserRepository
    {
    }
}
