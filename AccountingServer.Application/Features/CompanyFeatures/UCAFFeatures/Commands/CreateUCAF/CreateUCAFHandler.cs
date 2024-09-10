using AccountingServer.Application.Services.CompanyServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF
{
	public sealed class CreateUCAFHandler : IRequestHandler<CreateUCAFRequest, CreateUCAFResponse>
	{
		private readonly IUCAFService _uCAFService;

		public CreateUCAFHandler(IUCAFService uCAFService)
		{
			_uCAFService = uCAFService;
		}

		public async Task<CreateUCAFResponse> Handle(CreateUCAFRequest request, CancellationToken cancellationToken)
		{
			await _uCAFService.CreateUCAFAsync(request);
			return new CreateUCAFResponse();	
		}
	}
}
