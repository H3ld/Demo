using Demo.Application.Repositories;
using Demo.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure.InMemoryDataAccess.Repositories
{
	class UserRepository : IUserRepository
	{
		private readonly Context _context;

		public UserRepository(Context context)
		{
			_context = context;
		}

		public async Task Add(User item)
		{
			_context.Users.Add(item);
			await Task.CompletedTask;
		}

		public async Task<bool> Contains(User item)
		{
			var contains = _context.Users.Contains(item);
			return await Task.FromResult(contains);
		}

		public async Task<User> Get(Guid guid)
		{
			User user = _context.Users
				.Where(u => u.Id == guid)
				.SingleOrDefault();

			return await Task.FromResult(user);
		}

		public async Task<IList<User>> GetAll()
		{
			List<User> users = new List<User>(_context.Users);
			return await Task.FromResult(users);
		}

		public async Task Remove(User guid)
		{
			// guid means actually user here
			_context.Users.Remove(guid);
			await Task.CompletedTask;
		}

		public async Task Update(User item)
		{
			// due to lack of time i add it the dirty way
			var old = _context.Users.Single(user => user.Id == item.Id);

			if (old.Name != item.Name ||
				old.Password != item.Password)
			{ _context.Users.Remove(old); }

			await Task.CompletedTask;
		}
	}
}
