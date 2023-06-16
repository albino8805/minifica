using minifica.data.IRepository;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.domain.Manager
{
    public class SchoolManager : BaseManager<SchoolViewModel, School>, ISchoolManager
    {
        public SchoolManager(ISchoolRepository repository) : base(repository) { }

        public override School AddConverter(SchoolViewModel viewModel)
        {
            return new School()
            {
                Active = viewModel.Active,
                Name = viewModel.Name,
                Phone = viewModel.Phone,
                Email = viewModel.Email,
                PartnerFK = viewModel.PartnerFK,
                Street = viewModel.Street,
                ExternalNumber = viewModel.ExternalNumber,
                InternalNumber = viewModel.InternalNumber,
                NeighbourhoodFK = viewModel.NeighbourhoodFK,
                PostalCode = viewModel.PostalCode,
                CreatedAt = viewModel.CreatedAt,
                UpdatedAt = viewModel.UpdatedAt,
                CreatedBy = viewModel.CreatedBy,
                UpdatedBy = viewModel.UpdatedBy,
                Code = viewModel.Code
            };
        }

        public override List<SchoolViewModel> CollectionConverter(List<School> entities)
        {
            return entities.Select(m => new SchoolViewModel()
            {
                Id = m.Id,
                Active = m.Active,
                Name = m.Name,
                Phone = m.Phone,
                Email = m.Email,
                PartnerFK = m.PartnerFK,
                Street = m.Street,
                ExternalNumber = m.ExternalNumber,
                InternalNumber = m.InternalNumber,
                NeighbourhoodFK = m.NeighbourhoodFK,
                PostalCode = m.PostalCode,
                CreatedAt = m.CreatedAt,
                UpdatedAt = m.UpdatedAt,
                CreatedBy = m.CreatedBy,
                UpdatedBy = m.UpdatedBy,
                Code=m.Code
            }).ToList();
        }

        public override School UpdatedConverter(SchoolViewModel viewModel, School entity)
        {
            entity.Active = viewModel.Active;
            entity.Name = viewModel.Name;
            entity.Phone = viewModel.Phone;
            entity.Email = viewModel.Email;
            entity.PartnerFK = viewModel.PartnerFK;
            entity.Street = viewModel.Street;
            entity.ExternalNumber = viewModel.ExternalNumber;
            entity.InternalNumber = viewModel.InternalNumber;
            entity.NeighbourhoodFK = viewModel.NeighbourhoodFK;
            entity.PostalCode = viewModel.PostalCode;
            entity.CreatedAt = viewModel.CreatedAt;
            entity.UpdatedAt = viewModel.UpdatedAt;
            entity.CreatedBy = viewModel.CreatedBy;
            entity.UpdatedBy = viewModel.UpdatedBy;
            entity.Code = viewModel.Code;

            return entity;
        }

        public override SchoolViewModel SingleConverter(School entity)
        {
            return new SchoolViewModel()
            {
                Id = entity.Id,
                Active = entity.Active,
                Name = entity.Name,
                Phone = entity.Phone,
                Email = entity.Email,
                PartnerFK = entity.PartnerFK,
                Street = entity.Street,
                ExternalNumber = entity.ExternalNumber,
                InternalNumber = entity.InternalNumber,
                NeighbourhoodFK = entity.NeighbourhoodFK,
                PostalCode = entity.PostalCode,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
                CreatedBy = entity.CreatedBy,
                UpdatedBy = entity.UpdatedBy,
                Code = entity.Code
            };
        }
    }
}
