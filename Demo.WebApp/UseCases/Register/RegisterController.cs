using Demo.Application.UseCases.Register;
using Microsoft.AspNetCore.Mvc;

namespace Demo.WebApp.UseCases.Register
{
	[Route("")]
	public sealed class RegisterController : Controller
	{
		private readonly IRegisterUseCase _registerUseCase;
		private readonly Presenter _presenter;

		public RegisterController(IRegisterUseCase useCase, Presenter presenter)
		{
			_registerUseCase = useCase;
			_presenter = presenter;
		}

		// GET: /<controller>/
		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}
	}
}
