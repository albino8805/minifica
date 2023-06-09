using minifica.data.IRepository;
using minifica.data.Models;

namespace minifica.data.Repository
{
    public class ModuleActionRepository : BaseRepository<ModuleAction>, IModuleActionRepository
    {
        public ModuleActionRepository(MinificaContext context) : base(context) { }
    }
}
