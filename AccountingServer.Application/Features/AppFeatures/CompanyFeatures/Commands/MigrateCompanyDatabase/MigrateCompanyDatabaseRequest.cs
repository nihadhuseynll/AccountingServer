using MediatR;

namespace AccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase
{
	public sealed class MigrateCompanyDatabaseRequest : IRequest<MigrateCompanyDatabaseResponse>
	{
	}
}
