using AccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using AccountingServer.Domain.AppEntities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
