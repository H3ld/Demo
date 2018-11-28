using System;
using Demo.Domain.ValueObjects;
using Xunit;
using Demo.Domain.Users;

namespace Demo.Domain.Tests
{
	public class UserTest
	{

		[Fact]
		public void Should_Create_User()
		{
			// Arrage
			var name = (Name)"Alexander Held";

			// Act
			var output = new User(name);

			// Assert
			Assert.Equal(name, output.Name);
			Assert.IsType<Guid>(output.Id);
			Assert.NotNull(output);
		}
	}
}
