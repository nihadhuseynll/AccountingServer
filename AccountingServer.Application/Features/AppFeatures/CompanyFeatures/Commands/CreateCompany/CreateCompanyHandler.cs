﻿using AccountingServer.Application.Services.AppServices;
using MediatR;

namespace AccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany
{
	public sealed class CreateCompanyHandler : IRequestHandler<CreateCompanyRequest, CreateCompanyResponse>
	{
		private readonly ICompanyService _companyService;

		public CreateCompanyHandler(ICompanyService companyService)
		{
			_companyService = companyService;
		}

		public async Task<CreateCompanyResponse> Handle(CreateCompanyRequest request, CancellationToken cancellationToken)
		{
			await _companyService.CreateCompany(request);
			return new();
		}
	}
}
