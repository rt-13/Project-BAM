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

		[HttpGet("/ispinvalid/{cardnumber}/{pin}")]
		public IActionResult ValidatedUserPin(string cardNumber, string pin)
		{
			return Ok(this._accountService.IsPinValid(cardNumber, Convert.ToInt32(pin)));
		}
	}
}
