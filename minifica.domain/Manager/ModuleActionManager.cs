using minifica.data.IRepository;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.domain.Manager
{
    public class ModuleActionManager : BaseManager<ModuleActionViewModel, ModuleAction>, IModuleActionManager
    {
        public ModuleActionManager(IModuleActionRepository repository) : base(repository) { }

        public override ModuleAction AddConverter(ModuleActionViewModel viewModel)
        {
            return new ModuleAction()
            {
                Id = viewModel.Id,
                ModuleFK = viewModel.ModuleFK,
                ActionFK = viewModel.ActionFK,
                ProfileFK = viewModel.ProfileFK,
                Active = viewModel.Active
            };
        }

        public override List<ModuleActionViewModel> CollectionConverter(List<ModuleAction> entities)
        {
            return entities.Select(m => new ModuleActionViewModel()
            {
                Id = m.Id,
                ModuleFK= m.ModuleFK,
                ActionFK = m.ActionFK,
                ProfileFK = m.ProfileFK,
                Active = m.Active
            }).ToList();
        }

        public override ModuleAction UpdatedConverter(ModuleActionViewModel viewModel, ModuleAction entity)
        {
            entity.ModuleFK = viewModel.ModuleFK;
            entity.ActionFK = viewModel.ActionFK;
            entity.ProfileFK = viewModel.ProfileFK;
            entity.Active = viewModel.Active;

            return entity;
        }

        public override ModuleActionViewModel SingleConverter(ModuleAction entity)
        {
            return new ModuleActionViewModel()
            {
                Id = entity.Id,
                ModuleFK = entity.ModuleFK,
                ActionFK = entity.ActionFK,
                ProfileFK = entity.ProfileFK,
                Active = entity.Active
            };
        }
    }
}
