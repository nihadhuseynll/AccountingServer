using AccountingServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using AccountingServer.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingServer.Presentation.Controllers
{
	public sealed class UCAFsController : ApiController
	{
		public UCAFsController(IMediator mediator) : base(mediator)
		{
		}
		[HttpPost("[action]")]
		public async Task<IActionResult> CreateUCAF(CreateUCAFRequest request)
		{
			CreateUCAFResponse response = await _mediator.Send(request);
			return Ok(response);
		}
	}
}
