using Microsoft.AspNetCore.Mvc;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StateController : BaseController<StateViewModel, State>
    {
        private readonly IStateManager _manager;

        public StateController(IStateManager manager) : base(manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public override IActionResult GetAll() => base.GetAll();

		[HttpGet("{id}")]
		public override IActionResult GetById(int id) => base.GetById(id);

        [HttpPost]
        public override IActionResult Add(StateViewModel state) => base.Add(state);

        [HttpPatch("{id}")]
        public override IActionResult Update(int id, StateViewModel state) => base.Update(id, state);

        [HttpDelete("{id}")]
        public override IActionResult Delete(int id) => base.Delete(id);
    }
}
