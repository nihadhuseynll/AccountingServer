using AccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using AccountingServer.Domain.AppEntities;

namespace AccountingServer.Application.Services.AppServices
{
	public interface ICompanyService
	{
		Task CreateCompany(CreateCompanyRequest request);
		Task MigrateCompanyDatabases();
		Task<Company?> GetCompanyByName(string name);
	}
}
