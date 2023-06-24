using minifica.data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minifica.data.ViewModels
{
    public class NeighbourhoodViewModel : BaseViewModel
    {
        public string Name { get; set; }

        public int TownFk { get; set; }
    }
}
