namespace minifica.data.ViewModels
{
    public class PartnerViewModel : BaseViewModel
    {
        public string Name { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Street { get; set; } = null!;

        public string ExternalNumber { get; set; } = null!;

        public string InternalNumber { get; set; } = null!;

        public int NeighbourhoodFK { get; set; }

        public int PostalCode { get; set; }

        public string Password { get; set; } = null!;

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public int CreateBy { get; set; }

        public int UpdateBy { get; set; }

        public string ContactName { get; set; } = null!;

        public string ContactPhone { get; set; } = null!;

        public string ContactEmail { get; set; } = null!;
    }
}
