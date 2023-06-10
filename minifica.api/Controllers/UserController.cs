using Microsoft.AspNetCore.Mvc;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.IManager;

namespace minifica.api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : BaseController<UserViewModel, User>
    {
        public UserController(IUserManager manager) : base(manager) { }

        [HttpGet]
        public override IActionResult GetAll() => base.GetAll();

		[HttpGet("{id}")]
		public override IActionResult GetById(int id) => base.GetById(id);

        [HttpPost]
        public override IActionResult Add(UserViewModel user) => base.Add(user);

        [HttpPatch]
        public override IActionResult Update(int id, UserViewModel user) => base.Update(id, user);

        [HttpDelete]
        public override IActionResult Delete(int id) => base.Delete(id);
    }
}
