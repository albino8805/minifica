using minifica.data.IRepository;
using minifica.data.Models;

namespace minifica.data.Repository
{
    public class UserRepository: BaseRepository<User>, IUserRepository
    {
        public UserRepository(MinificaContext context) : base(context) { }
    }
}
