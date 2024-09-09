﻿using AccountingServer.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingServer.Domain.Repositories
{
	public interface IRepository<T>
		where T : Entity
	{
		void SetDbContextInstance(DbContext context);
		DbSet<T> Entity { get; set; }
	}
}
