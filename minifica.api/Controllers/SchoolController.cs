using Microsoft.AspNetCore.Mvc;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : BaseController<SchoolViewModel, School>
    {
        public SchoolController(ISchoolManager manager) : base(manager) { }

        [HttpGet]
        public override IActionResult GetAll() => base.GetAll();

        [HttpGet("{id}")]
        public override IActionResult GetById(int id) => base.GetById(id);

        [HttpPost]
        public override IActionResult Add(SchoolViewModel school) => base.Add(school);

        [HttpPatch]
        public override IActionResult Update(int id, SchoolViewModel school) => base.Update(id, school);

        [HttpDelete]
        public override IActionResult Delete(int id) => base.Delete(id);
    }
}
