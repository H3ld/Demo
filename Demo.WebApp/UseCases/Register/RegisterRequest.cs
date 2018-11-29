using System.ComponentModel.DataAnnotations;

namespace Demo.WebApp.UseCases.Register
{
	public sealed class RegisterRequest
	{
		[Required]
		[StringLength(100)]
		public string Username { get; set; }

		[Required]
		[StringLength(100)]
		public string Password { get; set; }
	}
}
