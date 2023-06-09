using minifica.data.IRepository;
using minifica.data.Models;

namespace minifica.data.Repository
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(MinificaContext context) : base(context) { }
    }
}
