using minifica.data.IRepository;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.domain.Manager
{
    public class TownManager : BaseManager<TownViewModel, Town>, ITownManager
    {
        public TownManager(ITownRepository repository) : base(repository) { }

        public override Town AddConverter(TownViewModel viewModel)
        {
            return new Town()
            {
                Name = viewModel.Name,
                StateFK = viewModel.StateFk
            };
        }
        public override Town UpdatedConverter(TownViewModel viewModel, Town entity)
        {
            entity.Name = viewModel.Name;
            entity.StateFK = viewModel.StateFk;
            return entity;
        }
        public override TownViewModel SingleConverter(Town entity)
        {
            return new TownViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                StateFk = entity.StateFK
            };
        }
        public override List<TownViewModel> CollectionConverter(List<Town> entities)
        {
            return entities.Select(p => new TownViewModel()
            {
                Id = p.Id,
                Name = p.Name,
                StateFk = p.StateFK
            }).ToList();
        }
    }
}
