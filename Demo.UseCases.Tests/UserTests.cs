using Demo.Application.Repositories;
using Demo.Application.UseCases.Register;
using Demo.Domain.Users;
using Demo.Domain.ValueObjects;
using Moq;
using System;
using Xunit;

namespace Demo.UseCases.Tests
{
	public class UserTests
	{
		[Fact]
		public async void Should_Register_New_User()
		{
			// Arrange
			var valid = new User((Name)"Alexander Held", (Password)"supersecret");
			var userRepository = new Mock<IUserRepository>();
			var todoRepository = new Mock<ITodoRepository>();

			var register = new RegisterUseCase(userRepository.Object, todoRepository.Object);

			// Act
			var output = await register.Execute("Alexander Held", "supersecret");

			// Assert
			Assert.Equal(valid.Name, output.UserOutput.Name);
			Assert.Equal(valid.GetAssociatedTasks(), output.UserOutput.AssociatedTodos.GetReadOnly());
			Assert.NotNull(valid);
			Assert.IsType<User>(valid);
		}
	}
}
