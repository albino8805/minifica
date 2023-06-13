using minifica.data.IRepository;
using minifica.data.Models;

namespace minifica.data.Repository
{
    public class TownRepository : BaseRepository<Town>, ITownRepository
    {
        public TownRepository(MinificaContext context) : base(context) { }
    }
}
