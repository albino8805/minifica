using Microsoft.AspNetCore.Mvc;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolBillingInformationController : BaseController<SchoolBillingInformationViewModel, SchoolBillingInformation>
    {
        public SchoolBillingInformationController(ISchoolBillingInformationManager manager) : base(manager) { }

        [HttpGet]
        public override IActionResult GetAll() => base.GetAll();

        [HttpGet("{id}")]
        public override IActionResult GetById(int id) => base.GetById(id);

        [HttpPost]
        public override IActionResult Add(SchoolBillingInformationViewModel schoolBillingInformation) => base.Add(schoolBillingInformation);

        [HttpPatch("{id}")]
        public override IActionResult Update(int id, SchoolBillingInformationViewModel schoolBillingInformation) => base.Update(id, schoolBillingInformation);

        [HttpDelete]
        public override IActionResult Delete(int id) => base.Delete(id);
    }
}
