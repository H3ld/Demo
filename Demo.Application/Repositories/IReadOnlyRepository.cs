using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Application.Repositories
{
	public interface IReadOnlyRepository<T> where T : class
	{
		Task<IList<T>> GetAll();
		Task<bool> Contains(T item);
		Task<T> Get(Guid guid);
	}
}
