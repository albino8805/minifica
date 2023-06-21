using Microsoft.AspNetCore.Mvc;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TownController : BaseController<TownViewModel, Town>
    {
        private readonly ITownManager _manager;

        public TownController(ITownManager manager) : base(manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public override IActionResult GetAll() => base.GetAll();

        [HttpGet("{id}")]
        public override IActionResult GetById(int id) => base.GetById(id);

        [HttpPost]
        public override IActionResult Add(TownViewModel town) => base.Add(town);

        [HttpPatch("{id}")]
        public override IActionResult Update(int id, TownViewModel town) => base.Update(id, town);

        [HttpDelete("{id}")]
        public override IActionResult Delete(int id) => base.Delete(id);
    }
}
