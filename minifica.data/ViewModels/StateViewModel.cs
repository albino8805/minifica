using minifica.data.Models;

namespace minifica.data.ViewModels
{
    public class State : BaseEntity
    {
        public string Name { get; set; }

        public string CountryFk { get; set; }
    }
}
