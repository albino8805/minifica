using minifica.data.IRepository;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minifica.domain.Manager
{
    public class CountryManager : BaseManager<CountryViewModel, Country>, ICountryManager
    {
        public CountryManager(ICountryRepository repository) : base(repository) { }

        public override Country AddConverter(CountryViewModel viewModel)
        {
            return new Country()
            {
                Name = viewModel.Name
            };
        }
        public override Country UpdatedConverter(CountryViewModel viewModel, Country entity)
        {
            entity.Name = viewModel.Name;
            return entity;
        }
        public override CountryViewModel SingleConverter(Country entity)
        {
            return new CountryViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
            };
        }
        public override List<CountryViewModel> CollectionConverter(List<Country> entities)
        {
            return entities.Select(p => new CountryViewModel()
            {
                Id=p.Id,
                Name=p.Name
            }).ToList();
        }
    }
}
