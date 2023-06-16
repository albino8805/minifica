using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minifica.data.Models
{
    public class School : BaseEntity
    {
        [Required]
        [MaxLength(300)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Email { get; set; } = null!;

        [Required]
        public int PartnerFK { get; set; }

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
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        [Required]
        public int CreatedBy { get; set; }

        public int UpdatedBy { get; set; }

        [Required]
        [MaxLength(20)]
        public string Code { get; set; } = null!;

        public virtual Neighbourhood NeighbourhoodFKNavigation { get; set; } = null!;
    }

}
