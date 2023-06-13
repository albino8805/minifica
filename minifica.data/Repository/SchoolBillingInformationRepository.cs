using minifica.data.IRepository;
using minifica.data.Models;

namespace minifica.data.Repository
{
    public class SchoolBillingInformationRepository : BaseRepository<SchoolBillingInformation>, ISchoolBillingInformationRepository
    {
        public SchoolBillingInformationRepository(MinificaContext context) : base(context) { }
    }
}
