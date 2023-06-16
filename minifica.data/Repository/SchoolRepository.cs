using minifica.data.IRepository;
using minifica.data.Models;

namespace minifica.data.Repository
{
    public class SchoolRepository: BaseRepository<School>, ISchoolRepository
    {
        public SchoolRepository(MinificaContext context): base(context) { }
    }
}
