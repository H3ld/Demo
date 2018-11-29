using Demo.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.UseCases.Register
{
	public interface IRegisterUseCase
	{
		Task<RegisterOutput> Execute(string username, string password);
	}
}
