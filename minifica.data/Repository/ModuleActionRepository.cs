using minifica.data.Models;

namespace minifica.data.Repository
{
    public class ModuleActionRepository : BaseRepository<ModuleAction>
    {
        public ModuleActionRepository(MinificaContext context) : base(context) { }
    }
}
