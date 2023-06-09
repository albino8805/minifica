using minifica.data.IRepository;
using minifica.data.Models;

namespace minifica.data.Repository
{
    public class StateRepository : BaseRepository<State>, IStateRepository
    {
        public StateRepository(MinificaContext context) : base(context) { }
    }
}
