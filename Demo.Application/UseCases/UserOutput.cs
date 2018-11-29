using System;
using System.Collections.Generic;
using System.Text;
using Demo.Domain;
using Demo.Domain.ValueObjects;

namespace Demo.Application.UseCases
{
	public sealed class UserOutput
	{
		public Guid UserId { get; }
		public Name Name { get; } 
		public TodoCollection AssociatedTodos { get; }

		public UserOutput(Domain.Users.User user)
		{
			UserId = user.Id;
			Name = user.Name;
			AssociatedTodos = user.AssignedTodo;
		}
	}
}
