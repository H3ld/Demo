using System;

namespace Demo.Domain.ValueObjects
{
	public class NameShouldNotBeEmptyException : Exception
	{
		public NameShouldNotBeEmptyException() : base("The Name should not be emtpy") { }
		public NameShouldNotBeEmptyException(string message) : base(message) { }
	}
}