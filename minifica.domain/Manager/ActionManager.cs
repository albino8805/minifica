using minifica.data.IRepository;
using minifica.data.ViewModels;
using minifica.domain.IManager;
using ActionEntity = minifica.data.Models.Action;

namespace minifica.domain.Manager
{
    public class ActionManager: BaseManager<ActionViewModel, ActionEntity>, IActionManager
    {
        public ActionManager(IActionRepository repository) : base(repository) { }

        public override ActionEntity AddConverter(ActionViewModel viewModel)
        {
            return new ActionEntity()
            {
                Name = viewModel.Name,
                Active = true
            };
        }

        public override List<ActionViewModel> CollectionConverter(List<ActionEntity> entities)
        {
            return entities.Select(m => new ActionViewModel()
            {
                Id = m.Id,
                Name = m.Name,
                Active = m.Active
            }).ToList();
        }

        public override ActionEntity UpdatedConverter(ActionViewModel viewModel, ActionEntity entity)
        {
            entity.Name = viewModel.Name;

            return entity;
        }

        public override ActionViewModel SingleConverter(ActionEntity entity)
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
