using minifica.data.IRepository;
using minifica.data.Models;

namespace minifica.data.Repository
{
    public class UserRepository: BaseRepository<User>, IUserRepository
    {
        public UserRepository(MinificaContext context) : base(context) { }

        public User GetByEmail(string email)
        {
            return _context.Users.Where(p => p.Email == email && p.Active == true).FirstOrDefault();
        }
    }
}
