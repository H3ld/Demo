using Demo.Application.Repositories;
using Demo.Domain.Tasks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure.EntityFrameworkDataAccess.Repositories
{
	//public class TodoRepo : IRepository<Todo>
	//{
	//	private readonly Context context;

	//	public async Task Add(Todo entity)
	//	{
	//		await context.AddAsync(entity);
	//		await context.SaveChangesAsync();
	//	}

	//	public async Task<Todo> Find(Predicate<Todo> predicate)
	//	{
	//		var result = await context.Todo.FindAsync(predicate);
	//		return await Task.FromResult(result);
	//	}

	//	public Task<Todo> Get(Guid guid)
	//	{
	//		throw new NotImplementedException();
	//	}

	//	public Task Remove(Todo entity)
	//	{
	//		throw new NotImplementedException();
	//	}
	//}
}
