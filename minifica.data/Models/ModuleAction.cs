using System.ComponentModel.DataAnnotations.Schema;

namespace minifica.data.Models
{
    public class ModuleAction : BaseEntity
    {
		[ForeignKey("ModuleFKNavigation")]
		public int ModuleFK { get; set; }

        public int ActionFK { get; set; }

        public int ProfileFK { get; set; }

        public virtual Module ModuleFKNavigation { get; set; } = null!;

        public virtual Action ActionFKNavigation { get; set; } = null!;

        public virtual Profile ProfileFKNavigation { get; set; } = null!;
    }
}
