using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minifica.data.Models
{
    public class ModuleAction : BaseEntity
    {
        [Required]
        [ForeignKey("ModuleFKNavigation")]
        public int ModuleFK { get; set; }

        [Required]
        [ForeignKey("ActionFKNavigation")]
        public int ActionFK { get; set; }

        [Required]
        [ForeignKey("ProfileFKNavigation")]
        public int ProfileFK { get; set; }

        public virtual Module ModuleFKNavigation { get; set; } = null!;

        public virtual Action ActionFKNavigation { get; set; } = null!;

        public virtual Profile ProfileFKNavigation { get; set; } = null!;
    }
}
