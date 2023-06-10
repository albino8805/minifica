using minifica.data.IRepository;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.domain.Manager
{
    public class PartnerManager : BaseManager<PartnerViewModel, Partner>, IPartnerManager
    {
        public PartnerManager(IPartnerRepository repository) : base(repository) { }

        public override Partner AddConverter(PartnerViewModel viewModel)
        {
            return new Partner()
            {
                Id = viewModel.Id,
                Active = viewModel.Active,
                Name = viewModel.Name,
                LastName = viewModel.LastName,
                Phone = viewModel.Phone,
                Email = viewModel.Email,
                Street = viewModel.Street,
                ExternalNumber = viewModel.ExternalNumber,
                InternalNumber = viewModel.InternalNumber,
                NeighbourhoodFK = viewModel.NeighbourhoodFK,
                PostalCode = viewModel.PostalCode,
                Password = viewModel.Password,
                CreateAt = viewModel.CreateAt,
                UpdateAt = viewModel.UpdateAt,
                CreateBy = viewModel.CreateBy,
                UpdateBy = viewModel.UpdateBy,
                ContactName = viewModel.ContactName,
                ContactPhone = viewModel.ContactPhone,
                ContactEmail = viewModel.ContactEmail
            };
        }

        public override List<PartnerViewModel> CollectionConverter(List<Partner> entities)
        {
            return entities.Select(p => new PartnerViewModel()
            {
                Id = p.Id,
                Active = p.Active,
                Name = p.Name,
                LastName = p.LastName,
                Phone = p.Phone,
                Email = p.Email,
                Street = p.Street,
                ExternalNumber = p.ExternalNumber,
                InternalNumber = p.InternalNumber,
                NeighbourhoodFK = p.NeighbourhoodFK,
                PostalCode = p.PostalCode,
                Password = p.Password,
                CreateAt = p.CreateAt,
                UpdateAt = p.UpdateAt,
                CreateBy = p.CreateBy,
                UpdateBy = p.UpdateBy,
                ContactName = p.ContactName,
                ContactPhone = p.ContactPhone,
                ContactEmail = p.ContactEmail
            }).ToList();
        }

        public override Partner UpdatedConverter(PartnerViewModel viewModel, Partner entity)
        {
            entity.Active = viewModel.Active;
            entity.Name = viewModel.Name;
            entity.LastName = viewModel.LastName;
            entity.Phone = viewModel.Phone;
            entity.Email = viewModel.Email;
            entity.Street = viewModel.Street;
            entity.ExternalNumber = viewModel.ExternalNumber;
            entity.InternalNumber = viewModel.InternalNumber;
            entity.NeighbourhoodFK = viewModel.NeighbourhoodFK;
            entity.PostalCode = viewModel.PostalCode;
            entity.Password = viewModel.Password;
            entity.CreateAt = viewModel.CreateAt;
            entity.UpdateAt = viewModel.UpdateAt;
            entity.CreateBy = viewModel.CreateBy;
            entity.UpdateBy = viewModel.UpdateBy;
            entity.ContactName = viewModel.ContactName;
            entity.ContactPhone = viewModel.ContactPhone;
            entity.ContactEmail = viewModel.ContactEmail;

            return entity;
        }

        public override PartnerViewModel SingleConverter(Partner entity)
        {
            return new PartnerViewModel()
            {
                Id = entity.Id,
                Active = entity.Active,
                Name = entity.Name,
                LastName = entity.LastName,
                Phone = entity.Phone,
                Email = entity.Email,
                Street = entity.Street,
                ExternalNumber = entity.ExternalNumber,
                InternalNumber = entity.InternalNumber,
                NeighbourhoodFK = entity.NeighbourhoodFK,
                PostalCode = entity.PostalCode,
                Password = entity.Password,
                CreateAt = entity.CreateAt,
                UpdateAt = entity.UpdateAt,
                CreateBy = entity.CreateBy,
                UpdateBy = entity.UpdateBy,
                ContactName = entity.ContactName,
                ContactPhone = entity.ContactPhone,
                ContactEmail = entity.ContactEmail
            };
        }
    }
}
