using Demo.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Infrastructure.EntityFrameworkDataAccess.Repositories
{
	class UserRepository : IReadOnlyRepository<Entities.User>, IWriteOnlyRepository<Entities.User>
	{
		private readonly Context _context;

		public UserRepository(Context context)
		{
			_context = context ?? throw new ArgumentNullException(nameof(context));
		}

		public async Task Add(Entities.User item)
		{
			Entities.User user = new Entities.User()
			{
				Name = item.Name,
				Id = item.Id,
				Password = item.Password
			};

			await _context.Users.AddAsync(user);
			await _context.SaveChangesAsync();
			await Task.CompletedTask;
		}

		public async Task<bool> Contains(Entities.User item)
		{
			var contains = _context.Users.Contains(item);
			return await Task.FromResult(contains);
		}

		public async Task<Entities.User> Get(Guid guid)
		{
			Entities.User user = _context.Users
				.Where(u => u.Id == guid)
				.SingleOrDefault();

			return await Task.FromResult(user);
		}

		public async Task Remove(Entities.User guid)
		{
			// guid means actually user here
			_context.Users.Remove(guid);
			await _context.SaveChangesAsync();
			await Task.CompletedTask;
		}

		public async Task Update(Entities.User item)
		{
			// due to lack of time i add it the dirty way
			throw new NotImplementedException();
		}

		public async Task<IList<Entities.User>> GetAll()
		{
			var asyncuser = _context.Users.ToList();
			return await Task.FromResult(asyncuser);
		}
	}
}
