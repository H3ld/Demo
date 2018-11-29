using Demo.Domain.Users;

namespace Demo.Application.Repositories
{
	public interface IUserRepository : IReadOnlyRepository<User>, IWriteOnlyRepository<User>
	{
	}
}
