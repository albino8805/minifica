using Microsoft.AspNetCore.Mvc;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.api.Controllers
{
    public class ProfileController : BaseController<ProfileViewModel, Profile>
    {
        public ProfileController(IProfileManager manager) : base(manager) { }

        [HttpGet]
        public override IActionResult GetAll() => base.GetAll();

        [HttpGet]
        public override IActionResult GetById(int id) => base.GetById(id);

        [HttpPost]
        public override IActionResult Add(ProfileViewModel profile) => base.Add(profile);

        [HttpPatch]
        public override IActionResult Update(int id, ProfileViewModel profile) => base.Update(id, profile);

        [HttpDelete]
        public override IActionResult Delete(int id) => base.Delete(id);
    }
}
