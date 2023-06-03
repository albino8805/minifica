using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minifica.data.Models
{
    public class Module : BaseEntity
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
