using AccountingServer.Domain.Abstractions;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingServer.Domain.Repositories
{
	public interface ICommandRepository<T> : IRepository<T>
		where T : Entity
	{
		Task AddAsync(T entity);
		Task AddRangeAsync(IEnumerable<T> entities);	
		void Update(T entity);
		void UpdateRange(IEnumerable<T> entities);
		Task RemoveById(string id);
		void Remove(T entity);
		void RemoveRange(IEnumerable<T> entities);	
	}
}
