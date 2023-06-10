using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minifica.data.Models
{
    public class Partner : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(300)]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Street { get; set; } = null!;

        [Required]
        [MaxLength(10)]
        public string ExternalNumber { get; set; } = null!;

        [MaxLength(10)]
        public string InternalNumber { get; set; } = null!;

        [Required]
        [ForeignKey("NeighbourhoodFKNavigation")]
        public int NeighbourhoodFK { get; set; }

        [Required]
        public int PostalCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; } = null!;

        [Required]
        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        [Required]
        public int CreateBy { get; set; }

        public int UpdateBy { get; set; }

        [Required]
        [MaxLength(100)]
        public string ContactName { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        public string ContactPhone { get; set; } = null!;

        [Required]
        [MaxLength(300)]
        public string ContactEmail { get; set; } = null!;

        public virtual Neighbourhood NeighbourhoodFKNavigation { get; set; } = null!;
    }
}
