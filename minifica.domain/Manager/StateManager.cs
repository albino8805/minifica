using minifica.data.IRepository;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.domain.Manager
{
    public class StateManager : BaseManager<StateViewModel, State>, IStateManager
    {
        public StateManager(IStateRepository repository) : base(repository) { }

        public override State AddConverter(StateViewModel viewModel)
        {
            return new State()
            {
                Name = viewModel.Name,
                CountryFK = viewModel.CountryFk
            };
        }
        public override State UpdatedConverter(StateViewModel viewModel, State entity)
        {
            entity.Name = viewModel.Name;
            entity.CountryFK = viewModel.CountryFk;
            return entity;
        }
        public override StateViewModel SingleConverter(State entity)
        {
            return new StateViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                CountryFk = entity.CountryFK
            };
        }
        public override List<StateViewModel> CollectionConverter(List<State> entities)
        {
            return entities.Select(p => new StateViewModel()
            {
                Id = p.Id,
                Name = p.Name,
                CountryFk = p.CountryFK
            }).ToList();
        }
    }
}
