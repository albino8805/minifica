using minifica.data.IRepository;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.domain.Manager
{
    internal class ProfileManager : BaseManager<ProfileViewModel, Profile>, IProfileManager
    {
        public ProfileManager(IProfileRepository repository) : base(repository) { }

        public override Profile AddConverter(ProfileViewModel viewModel)
        {
            return new Profile()
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Active = viewModel.Active,
                CreatedAt = viewModel.CreatedAt,
                UpdatedAt = viewModel.UpdatedAt
            };
        }

        public override List<ProfileViewModel> CollectionConverter(List<Profile> entities)
        {
            return entities.Select(m => new ProfileViewModel()
            {
                Id = m.Id,
                Name = m.Name,
                Active = m.Active,
                CreatedAt= m.CreatedAt,
                UpdatedAt = m.UpdatedAt,
            }).ToList();
        }

        public override Profile UpdatedConverter(ProfileViewModel viewModel, Profile entity)
        {
            entity.Name = viewModel.Name;
            entity.Active = viewModel.Active;
            entity.CreatedAt = viewModel.CreatedAt;
            entity.UpdatedAt = viewModel.UpdatedAt;

            return entity;
        }

        public override ProfileViewModel SingleConverter(Profile entity)
        {
            return new ProfileViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Active = entity.Active,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt
            };
        }
    }
}
