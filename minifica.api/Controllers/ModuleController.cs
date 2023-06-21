using Microsoft.AspNetCore.Mvc;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ModuleController : BaseController<ModuleViewModel, Module>
    {
        private readonly IModuleManager _manager;

        public ModuleController(IModuleManager manager) : base(manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public override IActionResult GetAll() => base.GetAll();

		[HttpGet("{id}")]
		public override IActionResult GetById(int id) => base.GetById(id);

        [HttpPost]
        public override IActionResult Add(ModuleViewModel module) => base.Add(module);

        [HttpPatch("{id}")]
        public override IActionResult Update(int id, ModuleViewModel module) => base.Update(id, module);

        [HttpDelete("{id}")]
        public override IActionResult Delete(int id) => base.Delete(id);
    }
}
