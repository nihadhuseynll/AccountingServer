using AccountingServer.Domain.CompanyEntities;
using AccountingServer.Domain.Repositories.UCAFRepositories;

namespace AccountingServer.Persistance.Repositories.UCAFRepositories
{
	public sealed class UCAFCommandRepository : CommandRepository<UCAF> ,IUCAFCommandRepository
	{
	}
}
