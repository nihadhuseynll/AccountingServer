using AccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using AccountingServer.Application.Services.AppServices;
using AccountingServer.Domain.AppEntities;
using AccountingServer.Persistance.Context;
using AutoMapper;
using Azure.Core;
using Microsoft.EntityFrameworkCore;

namespace AccountingServer.Persistance.Services.AppServices
{
	public sealed class CompanyService : ICompanyService
	{
		private static readonly Func<AppDbContext,string,Task<Company?>>
			GetCompanyNameByCompiled = EF.CompileAsyncQuery((AppDbContext context,string name)=>
			context.Set<Company>().FirstOrDefault(x=>x.Name == name));

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
			company.Id = Guid.NewGuid().ToString();
			await _context.Set<Company>().AddAsync(company);
			await _context.SaveChangesAsync();
		}

		public async Task<Company> GetCompanyByName(string name)
		{
			return await GetCompanyNameByCompiled(_context, name);	
		}

		public async Task MigrateCompanyDatabases()
		{
			var companies = await _context.Set<Company>().ToListAsync();
			foreach (var company in companies)
			{
				var db = new CompanyDbContext(company);
				db.Database.Migrate();
			}
		}
	}
}
