using minifica.data.IRepository;
using minifica.data.Models;
using ActionEntity = minifica.data.Models.Action;

namespace minifica.data.Repository
{
    public class ActionRepository : BaseRepository<ActionEntity>, IActionRepository
    {
        public ActionRepository(MinificaContext context) : base(context) { }

    }
}
