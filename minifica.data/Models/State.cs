using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minifica.data.Models
{
    public class State : BaseEntity
    {
        public string Name { get; set; }

        public string CountryFk { get; set; }
    }
}
