using AccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingServer.Application.Services.AppServices
{
	public interface ICompanyService
	{
		Task CreateCompany(CreateCompanyRequest request);
	}
}
