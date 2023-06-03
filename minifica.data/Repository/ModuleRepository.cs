using minifica.data.IRepository;
using minifica.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minifica.data.Repository
{
    public class ModuleRepository: BaseRepository<Module>, IModuleRepository
    {
        public ModuleRepository(MinificaContext context) : base(context) { }
    }
}
