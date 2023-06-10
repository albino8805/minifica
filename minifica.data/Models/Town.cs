using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
