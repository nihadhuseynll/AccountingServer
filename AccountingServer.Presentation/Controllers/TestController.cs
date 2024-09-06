using AccountingServer.Presentation.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace AccountingServer.Presentation.Controllers
{
	public sealed class TestController : ApiController
	{
		[HttpGet]
		public IActionResult Get()
		{
			return Ok("İşlem Başarılı.");
		}
	}
}
