using AccountingServer.Domain;
using AccountingServer.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingServer.Persistance
{
	public class UnitOfWork : IUnitOfWork
	{
		private CompanyDbContext _context;
		public void SetDbContextInstance(DbContext context)
		{
			_context = (CompanyDbContext)context;
		}
		public async Task<int> SaveChangesAsync()
		{
		    int count = await _context.SaveChangesAsync();
			return count;
		}
	}
}
