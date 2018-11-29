using Demo.Domain.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Application.Repositories
{
	public interface ITodoRepository : IReadOnlyRepository<Todo>,IWriteOnlyRepository<Todo>
	{
	}
}
