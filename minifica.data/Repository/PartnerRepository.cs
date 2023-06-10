using minifica.data.IRepository;
using minifica.data.Models;

namespace minifica.data.Repository
{
    public class PartnerRepository : BaseRepository<Partner>, IPartnerRepository
    {
        public PartnerRepository(MinificaContext context) : base(context) { }
    }
}
