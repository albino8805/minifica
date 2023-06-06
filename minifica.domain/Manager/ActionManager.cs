using minifica.data.IRepository;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.domain.Manager
{
    public class ActionManager: BaseManager<ActionViewModel, data.Models.Action>, IActionManager
    {
        public ActionManager(IActionRepository repository) : base(repository) { }

        public override data.Models.Action AddConverter(ActionViewModel viewModel)
        {
            return new data.Models.Action()
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Active = viewModel.Active
            };
        }

        public override List<ActionViewModel> CollectionConverter(List<data.Models.Action> entities)
        {
            return entities.Select(m => new ActionViewModel()
            {
                Id = m.Id,
                Name = m.Name,
                Active = m.Active
            }).ToList();
        }

        public override data.Models.Action UpdatedConverter(ActionViewModel viewModel, data.Models.Action entity)
        {
            entity.Name = viewModel.Name;
            entity.Active = viewModel.Active;

            return entity;
        }

        public override ActionViewModel SingleConverter(data.Models.Action entity)
        {
            return new ActionViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Active = entity.Active
            };
        }
    }


}
