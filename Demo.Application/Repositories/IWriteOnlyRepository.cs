using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Repositories
{
	public interface IWriteOnlyRepository<T> where T : class
	{
		Task Add(T item);
		Task Update(T item);
		Task Remove(T guid);
	}
}
