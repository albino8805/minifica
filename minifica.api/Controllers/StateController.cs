using Microsoft.AspNetCore.Mvc;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.api.Controllers
{
    public class StateController : BaseController<StateViewModel, State>
    {
        private readonly IStateManager _manager;

        public StateController(ICountryManager manager) : base(manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public override IActionResult GetAll() => base.GetAll();

        [HttpGet]
        public override IActionResult GetById(int id) => base.GetById(id);

        [HttpPost]
        public override IActionResult Add(CountryViewModel country) => base.Add(country);

        [HttpPatch]
        public override IActionResult Update(int id, CountryViewModel country) => base.Update(id, country);

        [HttpDelete]
        public override IActionResult Delete(int id) => base.Delete(id);
    }
}
