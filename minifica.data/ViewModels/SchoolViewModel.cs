namespace minifica.data.ViewModels
{
    public class SchoolViewModel : BaseViewModel
    {
        public string Name { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Email { get; set; } = null!;

        public int PartnerFK { get; set; }

        public string Street { get; set; } = null!;

        public string ExternalNumber { get; set; } = null!;

        public string InternalNumber { get; set; } = null!;

        public int NeighbourhoodFK { get; set; }

        public int PostalCode { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public int CreatedBy { get; set; }

        public int UpdatedBy { get; set; }

        public string Code { get; set; } = null!;
    }
}
