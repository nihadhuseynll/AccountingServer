using AccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using AccountingServer.Domain.AppEntities;
using AutoMapper;

namespace AccountingServer.Persistance.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<CreateCompanyRequest,Company>().ReverseMap();	
		}
	}
}
