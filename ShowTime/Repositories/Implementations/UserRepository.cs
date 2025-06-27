using ShowTime.Context;
using ShowTime.Entities;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories.Implementations
{
    public class UserRepository(ShowTimeContext context) : BaseRepository<User>(context), IUserRepository
    {
    }
}
