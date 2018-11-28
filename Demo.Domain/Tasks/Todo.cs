namespace Demo.Domain.Tasks
{
	using Demo.Domain.ValueObjects;
	using System;

	public sealed class Todo : IEntity
	{
		public Guid Id { get; private set; }
		
		public Name Name { get; private set; }

		private Todo() { }

		public Todo(Name name)
		{
			Id = Guid.NewGuid();
			Name = name;
		}
	}
}
