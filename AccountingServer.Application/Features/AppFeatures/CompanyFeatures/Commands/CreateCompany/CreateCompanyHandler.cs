using AccountingServer.Application.Services.AppServices;
using AccountingServer.Domain.AppEntities;
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
			Company company =await _companyService.GetCompanyByName(request.Name);
			if (company != null) throw new Exception("Bu Şirket Adı Daha Önce Kullanılmış.");

			await _companyService.CreateCompany(request);
			return new();
		}
	}
}
