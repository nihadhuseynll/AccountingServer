﻿using AccountingServer.Domain.AppEntities;
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
	}
}
