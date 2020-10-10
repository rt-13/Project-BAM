using BrainWorks.ATM.Service;
using Microsoft.AspNetCore.Mvc;

namespace BrainWorks.ATM.Web
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserService _userService;
		public UserController(IUserService userService)
		{
			this._userService = userService;
		}

		[HttpGet]
		public IActionResult GetAllUsers()
		{
			return Ok(this._userService.GetAllUsers());
		}
	}
}
