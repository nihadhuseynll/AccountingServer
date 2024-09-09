using AccountingServer.Domain.Abstractions;
using AccountingServer.Domain.Repositories;
using AccountingServer.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingServer.Persistance.Repositories
{
	public class CommandRepository<T> : ICommandRepository<T>
		where T : Entity
	{
		private CompanyDbContext _context;
		public DbSet<T> Entity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public void SetDbContextInstance(DbContext context)
		{
			_context = (CompanyDbContext)context;
			Entity = _context.Set<T>();
		}

		public Task AddAsync(T entity)
		{
			throw new NotImplementedException();
		}

		public Task AddRangeAsync(IEnumerable<T> entities)
		{
			throw new NotImplementedException();
		}

		public void Remove(T entity)
		{
			throw new NotImplementedException();
		}

		public Task RemoveById(string id)
		{
			throw new NotImplementedException();
		}

		public void RemoveRange(IEnumerable<T> entities)
		{
			throw new NotImplementedException();
		}

		public void Update(T entity)
		{
			throw new NotImplementedException();
		}

		public void UpdateRange(IEnumerable<T> entities)
		{
			throw new NotImplementedException();
		}
	}
}
