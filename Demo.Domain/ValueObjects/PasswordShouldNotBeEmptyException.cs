using System;

namespace Demo.Domain.ValueObjects
{
	public class PasswordShouldNotBeEmptyException : Exception
	{
		public PasswordShouldNotBeEmptyException() : base("The Password should not be emtpy") { }
		public PasswordShouldNotBeEmptyException(string message) : base(message) { }
	}
}