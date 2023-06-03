using Microsoft.AspNetCore.Mvc;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.api.Controllers
{
    public class ModuleController : BaseController<ModuleViewModel, Module>
    {
        private readonly IModuleManager _manager;

        public ModuleController(IModuleManager manager) : base(manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public override IActionResult GetAll() => base.GetAll();

        [HttpGet]
        public override IActionResult GetById(int id) => base.GetById(id);

        [HttpPost]
        public override IActionResult Add(ModuleViewModel module) => base.Add(module);

        [HttpPatch]
        public override IActionResult Update(int id, ModuleViewModel module) => base.Update(id, module);

        [HttpDelete]
        public override IActionResult Delete(int id) => base.Delete(id);
    }
}
