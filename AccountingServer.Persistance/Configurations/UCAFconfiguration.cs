using AccountingServer.Domain.CompanyEntities;
using AccountingServer.Persistance.Constans;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountingServer.Persistance.Configurations
{
	public sealed class UCAFconfiguration : IEntityTypeConfiguration<UCAF>
	{
		public void Configure(EntityTypeBuilder<UCAF> builder)
		{
			builder.ToTable(TableNames.UCAF);	
			builder.HasKey(t => t.Id);
		}
	}
}
