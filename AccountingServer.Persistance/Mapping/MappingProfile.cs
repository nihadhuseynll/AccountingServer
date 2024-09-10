using AccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using AccountingServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using AccountingServer.Domain.AppEntities;
using AccountingServer.Domain.CompanyEntities;
using AutoMapper;

namespace AccountingServer.Persistance.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<CreateCompanyRequest,Company>().ReverseMap();	
			CreateMap<CreateUCAFRequest,UCAF>().ReverseMap();	
		}
	}
}
