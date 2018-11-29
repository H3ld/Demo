using System;
using Demo.Domain.ValueObjects;
using Xunit;
using Demo.Domain.Users;
using Demo.Domain.Tasks;

namespace Demo.Domain.Tests
{
	public class UserTest
	{

		[Fact]
		public void Should_Create_User()
		{
			// Arrage
			var name = (Name)"Alexander Held";
			var pass = (Password)"supersecret";

			// Act
			var output = new User(name, pass);

			// Assert
			Assert.Equal(name, output.Name);
			Assert.Equal(pass, output.Password);
			Assert.IsType<Guid>(output.Id);
			Assert.NotNull(output);
		}


		[Fact]
		public void Should_Assign_Todo()
		{
			// Arrage
			Todo todo = new Todo((Name)"Need buy more Stuff on Amazon");
			User user = new User((Name)"Alexander Held", (Password)"supersecret");

			// Act
			user.AssignTodo(todo);

			// Assert
			Assert.Equal(1, user.AssignedTodo.GetReadOnly().Count) ;
		}


		[Fact]
		public void Should_Remove_Todo()
		{
			// Arrage
			Todo todo1 = new Todo((Name)"Need buy more Stuff on Amazon");
			Todo todo2 = new Todo((Name)"Need buy much more Stuff on Amazon");

			User user = new User((Name)"Alexander Held",(Password)"supersecret");
			user.AssignTodo(todo1);
			user.AssignTodo(todo2);

			// Act
			user.RemoveTodo(todo1);

			// Assert
			Assert.Equal(1, user.AssignedTodo.Count);

			// Check that still works when already removed why-ever
			user.RemoveTodo(todo1);
		}
	}
}
