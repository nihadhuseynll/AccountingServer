using AccountingServer.Domain.Abstractions;
using AccountingServer.Domain.AppEntities;
using AccountingServer.Domain.AppEntities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AccountingServer.Persistance.Context
{
	public sealed class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
	{
		public AppDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Company> Companies { get; set; }	
		public DbSet<UserAndCompanyRelationship> UserAndCompanyRelationships { get; set;}

		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			var entries = ChangeTracker.Entries<Entity>();

			foreach (var entry in entries)
			{
				if(entry.State == EntityState.Added)
				{
					entry.Property(p => p.CreatedDate)
						.CurrentValue = DateTime.Now;
				}
				if(entry.State == EntityState.Modified)
				{
					entry.Property(p => p.UpdatedDate)
						.CurrentValue = DateTime.Now;
				}
			}
			return base.SaveChangesAsync(cancellationToken);
		}


	}
}
