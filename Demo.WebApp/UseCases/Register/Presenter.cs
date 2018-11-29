using Microsoft.AspNetCore.Mvc;
using Demo.Application.UseCases.Register;

namespace Demo.WebApp.UseCases.Register
{
	public sealed class Presenter
	{
		public IActionResult ViewModel { get; private set; }

		public void Populate(RegisterOutput response)
		{
			throw new System.Exception("Populate Register PResnter");
		}
	}
}
