using AccountingServer.Domain.CompanyEntities;
using AccountingServer.Domain.Repositories.UCAFRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingServer.Persistance.Repositories.UCAFRepositories
{
	public sealed class UCAFQueryRepository : QueryRepository<UCAF> , IUCAFQueryRepository
	{
	}
}
