using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Demo.Application.Repositories;
using Demo.Domain.Users;
using Demo.Domain.ValueObjects;

namespace Demo.Application.UseCases.Register
{
	public class RegisterUseCase : IRegisterUseCase
	{
		private readonly IUserRepository _userRepo;
		private readonly ITodoRepository _todoRepository;

		public RegisterUseCase(IUserRepository userRepository, ITodoRepository todoRepository)
		{
			_userRepo = userRepository;
			todoRepository = todoRepository;
		}

		public async Task<RegisterOutput> Execute(string username, string password)
		{
			// Repository add User
			var user = new User((Name)username, (Password)password);
			await _userRepo.Add(user);

			var output = new RegisterOutput(new UserOutput(user));

			// Return RegisterOutput
			return output;
		}
	}
}
