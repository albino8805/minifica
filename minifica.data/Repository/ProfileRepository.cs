using minifica.data.IRepository;
using minifica.data.Models;

namespace minifica.data.Repository
{
    internal class ProfileRepository : BaseRepository<Profile>, IProfileRepository
    {
        public ProfileRepository(MinificaContext context) : base(context) { }
    }
}
