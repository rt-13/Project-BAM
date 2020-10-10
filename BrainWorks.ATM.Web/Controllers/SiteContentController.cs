using BrainWorks.ATM.Service;
using Microsoft.AspNetCore.Mvc;

namespace BrainWorks.ATM.Web.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SiteContentController : ControllerBase
	{
		private readonly ISiteContentService _siteContentService;
		public SiteContentController(ISiteContentService siteContentService)
		{
			this._siteContentService = siteContentService;
		}

		[HttpGet("/getbyreference/{reference}")]
		public IActionResult GetSiteContents(string reference)
		{
			return Ok(this._siteContentService.GetSiteContentsByReference(reference));
		}
	}
}
