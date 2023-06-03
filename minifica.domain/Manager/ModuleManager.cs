using minifica.data.IRepository;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.domain.Manager
{
    public class ModuleManager: BaseManager<ModuleViewModel, Module>, IModuleManager
    {
        public ModuleManager(IModuleRepository repository) : base(repository) { }

        public override Module AddConverter(ModuleViewModel viewModel)
        {
            return new Module()
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description,
                Active = viewModel.Active
            };
        }

        public override List<ModuleViewModel> CollectionConverter(List<Module> entities)
        {
            return entities.Select(m=> new ModuleViewModel()
            {
                Id = m.Id,
                Name = m.Name,
                Description = m.Description,
                Active = m.Active
            }).ToList();
        }

        public override Module UpdatedConverter(ModuleViewModel viewModel, Module entity)
        {
            entity.Name = viewModel.Name;
            entity.Description = viewModel.Description;
            entity.Active = viewModel.Active;

            return entity;
        }

        public override ModuleViewModel SingleConverter(Module entity)
        {
            return new ModuleViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                Active = entity.Active
            };
        }
    }
}
