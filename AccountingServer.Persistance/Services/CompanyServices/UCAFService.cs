using AccountingServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using AccountingServer.Application.Services.CompanyServices;
using AccountingServer.Domain;
using AccountingServer.Domain.CompanyEntities;
using AccountingServer.Domain.Repositories.UCAFRepositories;
using AccountingServer.Persistance.Context;
using AutoMapper;

namespace AccountingServer.Persistance.Services.CompanyServices
{
	public sealed class UCAFService : IUCAFService
	{
		private readonly IUCAFCommandRepository _UCAFCommandRepository;
		private readonly IContextService _contextService;
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;
		private CompanyDbContext _context;

		public UCAFService(IUCAFCommandRepository uCAFCommandRepository, IContextService contextService, IUnitOfWork unitOfWork, IMapper mapper)
		{
			_UCAFCommandRepository = uCAFCommandRepository;
			_contextService = contextService;
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task CreateUCAFAsync(CreateUCAFRequest request)
		{
			_context =(CompanyDbContext)_contextService.CreateDbContextInstance(request.CompanyId);
			_UCAFCommandRepository.SetDbContextInstance(_context);
			_unitOfWork.SetDbContextInstance(_context);

			UCAF UCAF = _mapper.Map<UCAF>(request);

			UCAF.Id = Guid.NewGuid().ToString();

		    await _UCAFCommandRepository.AddAsync(UCAF);
			await _unitOfWork.SaveChangesAsync();	
		}
	}
}
