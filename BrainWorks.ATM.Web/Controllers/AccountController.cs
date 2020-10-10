using BrainWorks.ATM.Service;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BrainWorks.ATM.Web.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		private readonly IAccountService _accountService;

		public AccountController(IAccountService accountService)
		{
			this._accountService = accountService;
		}

		[HttpGet("/ispinvalid/{accountNumber}/{pin}")]
		public IActionResult ValidatedUserPin(string accountNumber, string pin)
		{
			return Ok(this._accountService.IsPinValid(accountNumber, Convert.ToInt32(pin)));
		}
	}
}
