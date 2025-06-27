using ShowTime.Context;
using ShowTime.Entities;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories.Implementations
{
    public class MemberRepository(ShowTimeContext context) : BaseRepository<Member>(context), IMemberRepository
    {
    }
}
