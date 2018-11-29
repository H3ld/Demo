using Demo.Domain.Tasks;
using Demo.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace Demo.Domain.Users
{
	public sealed class User : IEntity
	{
		public Guid Id { get; private set; }

		public Name Name { get; private set; }

		public Password Password { get; private set; }

		public TodoCollection AssignedTodo { get; private set; }

		public User(Name name, Password password)
		{
			Id = Guid.NewGuid();
			Name = name;
			Password = password;
			AssignedTodo = new TodoCollection();
		}

		public IReadOnlyCollection<Todo> GetAssociatedTasks() => AssignedTodo.GetReadOnly();

		public void AssignTodo(Todo todo) => AssignedTodo.Add(todo);

		public void RemoveTodo(Todo todo) => AssignedTodo.Remove(todo);
	}
}
