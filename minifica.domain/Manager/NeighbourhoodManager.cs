using minifica.data.IRepository;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minifica.domain.Manager
{
    public class NeighbourhoodManager : BaseManager<NeighbourhoodViewModel, Neighbourhood>, INeighbourhoodManager
    {
        public NeighbourhoodManager(INeighbourhoodRepository repository) : base(repository) { }

        public override Neighbourhood AddConverter(NeighbourhoodViewModel viewModel)
        {
            return new Neighbourhood()
            {
                Name = viewModel.Name,
                TownFK = viewModel.TownFk
            };
        }
        public override Neighbourhood UpdatedConverter(NeighbourhoodViewModel viewModel, Neighbourhood entity)
        {
            entity.Name = viewModel.Name;
            entity.TownFK = viewModel.TownFk;
            return entity;
        }
        public override NeighbourhoodViewModel SingleConverter(Neighbourhood entity)
        {
            return new NeighbourhoodViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                TownFk = entity.TownFK
            };
        }
        public override List<NeighbourhoodViewModel> CollectionConverter(List<Neighbourhood> entities)
        {
            return entities.Select(p => new NeighbourhoodViewModel()
            {
                Id = p.Id,
                Name = p.Name,
                TownFk = p.TownFK
            }).ToList();
        }
    }
}
