using minifica.data.IRepository;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.domain.Manager
{
    public class SchoolBillingInformationManager : BaseManager<SchoolBillingInformationViewModel, SchoolBillingInformation>, ISchoolBillingInformationManager
    {
        public SchoolBillingInformationManager(ISchoolBillingInformationRepository repository) : base(repository) { }

        public override SchoolBillingInformation AddConverter(SchoolBillingInformationViewModel viewModel)
        {
            return new SchoolBillingInformation()
            {
                Active = viewModel.Active,
                RFC=viewModel.RFC,
                Name = viewModel.Name,
                Street = viewModel.Street,
                ExternalNumber = viewModel.ExternalNumber,
                InternalNumber = viewModel.InternalNumber,
                NeighbourhoodFK = viewModel.NeighbourhoodFK,
                PostalCode = viewModel.PostalCode,
                CreatedAt = viewModel.CreatedAt,
                UpdatedAt = viewModel.UpdatedAt,
                CreatedBy = viewModel.CreatedBy,
                UpdatedBy = viewModel.UpdatedBy
            };
        }

        public override List<SchoolBillingInformationViewModel> CollectionConverter(List<SchoolBillingInformation> entities)
        {
            return entities.Select(m => new SchoolBillingInformationViewModel()
            {
                Id = m.Id,
                Active = m.Active,
                RFC = m.RFC,
                Name = m.Name,
                Street = m.Street,
                ExternalNumber = m.ExternalNumber,
                InternalNumber = m.InternalNumber,
                NeighbourhoodFK = m.NeighbourhoodFK,
                PostalCode = m.PostalCode,
                CreatedAt = m.CreatedAt,
                UpdatedAt = m.UpdatedAt,
                CreatedBy = m.CreatedBy,
                UpdatedBy = m.UpdatedBy
            }).ToList();
        }

        public override SchoolBillingInformation UpdatedConverter(SchoolBillingInformationViewModel viewModel, SchoolBillingInformation entity)
        {
            entity.Active = viewModel.Active;
            entity.RFC = viewModel.RFC;
            entity.Name = viewModel.Name;
            entity.Street = viewModel.Street;
            entity.ExternalNumber = viewModel.ExternalNumber;
            entity.InternalNumber = viewModel.InternalNumber;
            entity.NeighbourhoodFK = viewModel.NeighbourhoodFK;
            entity.PostalCode = viewModel.PostalCode;
            entity.CreatedAt = viewModel.CreatedAt;
            entity.UpdatedAt = viewModel.UpdatedAt;
            entity.CreatedBy = viewModel.CreatedBy;
            entity.UpdatedBy = viewModel.UpdatedBy;

            return entity;
        }

        public override SchoolBillingInformationViewModel SingleConverter(SchoolBillingInformation entity)
        {
            return new SchoolBillingInformationViewModel()
            {
                Id = entity.Id,
                Active = entity.Active,
                RFC = entity.RFC,
                Name = entity.Name,
                Street = entity.Street,
                ExternalNumber = entity.ExternalNumber,
                InternalNumber = entity.InternalNumber,
                NeighbourhoodFK = entity.NeighbourhoodFK,
                PostalCode = entity.PostalCode,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
                CreatedBy = entity.CreatedBy,
                UpdatedBy = entity.UpdatedBy
            };
        }
    }
}
