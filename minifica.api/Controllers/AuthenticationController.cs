using Microsoft.AspNetCore.Mvc;
using minifica.data.Models;
using minifica.data.ViewModels;
using minifica.domain.Helpers;
using minifica.domain.IManager;

namespace minifica.api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthenticationController : ControllerBase
	{
		private IAuthenticationManager _manager;

		public AuthenticationController(IAuthenticationManager authenticationManager) {
			_manager = authenticationManager;
		}

		[HttpPost]
		public IActionResult Post(AuthenticationViewModel authentication)
		{
			var result = new JsonMessageResult();

			try
			{

				result.Success = 1;
				result.Detail = new { Login = _manager.ValidateUser(authentication) };
			}
			catch (Exception ex)
			{
				result.Success = 0;
				result.Detail = new { Error = ex.Message };
			}

			return Ok(result);
		}
	}
}
