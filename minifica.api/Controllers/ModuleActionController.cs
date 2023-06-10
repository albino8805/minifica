using Microsoft.AspNetCore.Mvc;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ModuleActionController : BaseController<ModuleActionViewModel, ModuleAction>
    {
        public ModuleActionController(IModuleActionManager manager) : base(manager) { }

        [HttpGet]
        public override IActionResult GetAll() => base.GetAll();

		[HttpGet("{id}")]
		public override IActionResult GetById(int id) => base.GetById(id);

        [HttpPost]
        public override IActionResult Add(ModuleActionViewModel moduleAction) => base.Add(moduleAction);

        [HttpPatch]
        public override IActionResult Update(int id, ModuleActionViewModel moduleAction) => base.Update(id, moduleAction);

        [HttpDelete]
        public override IActionResult Delete(int id) => base.Delete(id);
    }
}
