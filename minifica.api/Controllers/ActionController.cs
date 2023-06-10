using Microsoft.AspNetCore.Mvc;
using minifica.data.ViewModels;
using minifica.domain.IManager;
using ActionEntity = minifica.data.Models.Action;

namespace minifica.api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ActionController : BaseController<ActionViewModel, ActionEntity>
    {
        public ActionController(IActionManager manager) : base(manager) { }

        [HttpGet]
        public override IActionResult GetAll() => base.GetAll();

        [HttpGet("{id}")]
        public override IActionResult GetById(int id) => base.GetById(id);

        [HttpPost]
        public override IActionResult Add(ActionViewModel action) => base.Add(action);

        [HttpPatch]
        public override IActionResult Update(int id, ActionViewModel action) => base.Update(id, action);

        [HttpDelete]
        public override IActionResult Delete(int id) => base.Delete(id);
    }
}
