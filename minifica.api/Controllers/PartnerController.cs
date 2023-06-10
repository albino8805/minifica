using Microsoft.AspNetCore.Mvc;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartnerController : BaseController<PartnerViewModel, Partner>
    {
        public PartnerController(IPartnerManager manager) : base(manager) { }

        [HttpGet]
        public override IActionResult GetAll() => base.GetAll();

        [HttpGet("{id}")]
        public override IActionResult GetById(int id) => base.GetById(id);

        [HttpPost]
        public override IActionResult Add(PartnerViewModel partner) => base.Add(partner);

        [HttpPatch]
        public override IActionResult Update(int id, PartnerViewModel partner) => base.Update(id, partner);

        [HttpDelete]
        public override IActionResult Delete(int id) => base.Delete(id);
    }
}
