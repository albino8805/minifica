using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minifica.data.Models
{
    public class State : BaseEntity
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [ForeignKey("CountryFKNavigation")]
        public int CountryFK { get; set; }

        public virtual Country CountryFKNavigation { get; set; } = null!;
    }
}
