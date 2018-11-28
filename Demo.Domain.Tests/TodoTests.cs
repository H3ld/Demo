using System;
using Xunit;
using Demo.Domain.Tasks;
using Demo.Domain.ValueObjects;

namespace Demo.Domain.Tests
{
	public class TodoTests
	{
		[Fact]
		public void Task_ShouldCreateWithString()
		{
			// Arrange
			Name name = new Name("Check Mail");

			// Arrange
			var output = new Todo(name);

			// Assert
			Assert.IsType<Guid>(output.Id);
			Assert.Equal(name, output.Name);
			Assert.NotNull(output);
		}
	}
}
