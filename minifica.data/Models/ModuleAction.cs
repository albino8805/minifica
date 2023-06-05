using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace minifica.data.Models
{
    public class ModuleAction : BaseEntity
    {
        public int ModuleFK { get; set; }

        public int ActionFK { get; set; }

        public int ProfileFK { get; set; }

        public virtual Module ModuleFKNavigation { get; set; } = null!;

        public virtual data.Models.Action ActionFKNavigation { get; set; } = null!;

        public virtual Profile ProfileFKNavigation { get; set; } = null!;
    }
}
