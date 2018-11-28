using Demo.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain.Users
{
	public sealed class User : IEntity
	{
		public Guid Id { get; private set; }

		public Name Name { get; private set; }

		public TodoCollection AssociatedTasks { get; private set; }

		public User(Name name)
		{
			Id = Guid.NewGuid();
			Name = name;
			AssociatedTasks = new TodoCollection();
		}
	}
}
