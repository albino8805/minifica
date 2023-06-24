using Microsoft.AspNetCore.Mvc;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NeighbourhoodController : BaseController<NeighbourhoodViewModel, Neighbourhood>
    {
        private readonly INeighbourhoodManager _manager;

        public NeighbourhoodController(INeighbourhoodManager manager) : base(manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public override IActionResult GetAll() => base.GetAll();

        [HttpGet("{id}")]
        public override IActionResult GetById(int id) => base.GetById(id);

        [HttpPost]
        public override IActionResult Add(NeighbourhoodViewModel neighbourhood) => base.Add(neighbourhood);

        [HttpPatch("{id}")]
        public override IActionResult Update(int id, NeighbourhoodViewModel neighbourhood) => base.Update(id, neighbourhood);

        [HttpDelete("{id}")]
        public override IActionResult Delete(int id) => base.Delete(id);
    }
}
