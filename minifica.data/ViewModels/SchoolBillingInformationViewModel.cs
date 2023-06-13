using minifica.data.Models;

namespace minifica.data.ViewModels
{
    public class SchoolBillingInformationViewModel : BaseViewModel
    {
        public string RFC { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Street { get; set; } = null!;

        public string ExternalNumber { get; set; } = null!;

        public string InternalNumber { get; set; } = null!;

        public int NeighbourhoodFK { get; set; }

        public int PostalCode { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public int CreatedBy { get; set; }

        public int UpdatedBy { get; set; }

        public virtual Neighbourhood NeighbourhoodFKNavigation { get; set; } = null!;
    }
}
