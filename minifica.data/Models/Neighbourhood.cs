using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minifica.data.Models
{
    public class Neighbourhood : BaseEntity
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [ForeignKey("TownFKNavigation")]
        public int TownFK { get; set; }

        public virtual Town TownFKNavigation { get; set; } = null!;
    }
}
