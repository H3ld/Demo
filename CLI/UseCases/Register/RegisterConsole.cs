using Demo.Application.UseCases.Register;
using System;
using System.Collections.Generic;
using System.Text;

namespace CLI.UseCases.Register
{
	public class RegisterConsole
	{
		private readonly IRegisterUseCase _registerUseCase;
		private readonly Presenter _presenter;

		public RegisterConsole(IRegisterUseCase useCase, Presenter presenter)
		{
			_registerUseCase = useCase;
			_presenter = presenter;
		}

		public async void Register()
		{
			Console.WriteLine("\nEnter Username:\n");
			var username = Console.ReadLine();
			Console.WriteLine("\nEnter Password:\n");
			var password = Console.ReadLine();

			var registerOutput = await _registerUseCase.Execute(username, password);
		}
	}
}
