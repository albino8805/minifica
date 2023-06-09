using minifica.data.IRepository;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.domain.Manager
{
    public class UserManager : BaseManager<UserViewModel, User>, IUserManager
    {
        public UserManager(IUserRepository repository) : base(repository) { }

        public override User AddConverter(UserViewModel viewModel)
        {
            return new User()
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Active = viewModel.Active,
                LastName = viewModel.LastName,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Password = viewModel.Password,
                ProfileFK = viewModel.ProfileFK,
                CreateAt = viewModel.CreateAt,
                UpdateAt = viewModel.UpdateAt,
                CreateBy = viewModel.CreateBy,
                UpdateBy = viewModel.UpdateBy
            };
        }

        public override List<UserViewModel> CollectionConverter(List<User> entities)
        {
            return entities.Select(u => new UserViewModel()
            {
                Id = u.Id,
                Name = u.Name,
                Active = u.Active,
                LastName = u.LastName,
                Email = u.Email,
                Phone = u.Phone,
                Password = u.Password,
                ProfileFK = u.ProfileFK,
                CreateAt = u.CreateAt,
                UpdateAt = u.UpdateAt,
                CreateBy = u.CreateBy,
                UpdateBy = u.UpdateBy
            }).ToList();
        }

        public override User UpdatedConverter(UserViewModel viewModel, User entity)
        {
            entity.Name = viewModel.Name;
            entity.Active = viewModel.Active;
            entity.LastName = viewModel.LastName;
            entity.Email = viewModel.Email;
            entity.Phone = viewModel.Phone;
            entity.Password = viewModel.Password;
            entity.ProfileFK = viewModel.ProfileFK;
            entity.CreateAt = viewModel.CreateAt;
            entity.UpdateAt = viewModel.UpdateAt;
            entity.CreateBy = viewModel.CreateBy;
            entity.UpdateBy = viewModel.UpdateBy;

            return entity;
        }

        public override UserViewModel SingleConverter(User entity)
        {
            return new UserViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Active = entity.Active,
                LastName = entity.LastName,
                Email = entity.Email,
                Phone = entity.Phone,
                Password = entity.Password,
                ProfileFK = entity.ProfileFK,
                CreateAt = entity.CreateAt,
                UpdateAt = entity.UpdateAt,
                CreateBy = entity.CreateBy,
                UpdateBy = entity.UpdateBy
            };
        }
    }
}
