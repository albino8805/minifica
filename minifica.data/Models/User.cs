using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minifica.data.Models
{
    public class User : BaseEntity
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(300)]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(300)]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Password { get; set; } = null!;

        [Required]
        [ForeignKey("ProfileFKNavigation")]
        public int ProfileFK { get; set; }

        [Required]
        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        [Required]
        public int CreateBy { get; set; }

        public int UpdateBy { get; set; }

        public virtual Profile ProfileFKNavigation { get; set; } = null!;
    }
}
