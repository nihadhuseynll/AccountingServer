using AccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using AccountingServer.Application.Services.AppServices;
using AccountingServer.Domain.AppEntities;
using AccountingServer.Persistance.Context;
using AutoMapper;

namespace AccountingServer.Persistance.Services.AppServices
{
	public sealed class CompanyService : ICompanyService
	{
		private readonly AppDbContext _context;
		private readonly IMapper _mapper;

		public CompanyService(AppDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task CreateCompany(CreateCompanyRequest request)
		{
			Company company = _mapper.Map<Company>(request);
			await _context.Set<Company>().AddAsync(company);
			await _context.SaveChangesAsync();
		}
	}
}
