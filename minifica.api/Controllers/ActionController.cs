using Microsoft.AspNetCore.Mvc;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.api.Controllers
{
    public class ActionController : BaseController<ActionViewModel, data.Models.Action>
    {
        public ActionController(IActionManager manager) : base(manager) { }

        [HttpGet]
        public override IActionResult GetAll() => base.GetAll();

        [HttpGet]
        public override IActionResult GetById(int id) => base.GetById(id);

        [HttpPost]
        public override IActionResult Add(ActionViewModel action) => base.Add(action);

        [HttpPatch]
        public override IActionResult Update(int id, ActionViewModel action) => base.Update(id, action);

        [HttpDelete]
        public override IActionResult Delete(int id) => base.Delete(id);
    }
}
