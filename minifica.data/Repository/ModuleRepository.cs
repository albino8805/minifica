using minifica.data.IRepository;
using minifica.data.Models;

namespace minifica.data.Repository
{
    public class ModuleRepository: BaseRepository<Module>, IModuleRepository
    {
        public ModuleRepository(MinificaContext context) : base(context) { }
    }
}
