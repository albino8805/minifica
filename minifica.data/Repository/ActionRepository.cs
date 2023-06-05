using minifica.data.IRepository;
using minifica.data.Models;

namespace minifica.data.Repository
{
    public class ActionRepository : BaseRepository<Models.Action>, IActionRepository
    {
        public ActionRepository(MinificaContext context) : base(context) { }

    }
}
