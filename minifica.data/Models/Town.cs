using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minifica.data.Models
{
    public class Town : BaseEntity  
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [ForeignKey("StateFKNavigation")]
        public int StateFK { get; set; }

        public virtual State StateFKNavigation { get; set; } = null!;
    }
}
