


using C__RIWI.src.Domain.Entities;
using C__RIWI.src.Domain.Repositories.Abstract_Repositories;

namespace C__RIWI.src.Domain.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
       public UserRepository(AppDBContext context) : base(context)
       {}
    }
}