using AccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using AccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase;
using AccountingServer.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AccountingServer.Presentation.Controllers
{
	public class CompaniesController : ApiController
	{
		public CompaniesController(IMediator mediator) : base(mediator)
		{
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> CreateCompany(CreateCompanyRequest request)
		{
		    CreateCompanyResponse response =await _mediator.Send(request);
			return Ok(response);
		}
		[HttpGet("[action]")]
		public async Task<IActionResult> MigrateCompanyDatabases()
		{
			MigrateCompanyDatabaseRequest request = new MigrateCompanyDatabaseRequest();
			MigrateCompanyDatabaseResponse response = await _mediator.Send(request);
			return Ok(response);
		}
	}
}
