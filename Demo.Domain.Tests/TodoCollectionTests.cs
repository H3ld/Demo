using Demo.Domain.Tasks;
using Demo.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo.Domain.Tests
{
	public class TodoCollectionTests
	{
		[Fact]
		public void Should_Add_New_Todo()
		{
			// Arrage
			Todo valid = new Todo((Name)"Add me to the Collection");
			TodoCollection collection = new TodoCollection();

			// Act
			collection.Add(valid);

			// Assert
			Assert.True(collection.Contains(valid));
		}

		[Fact]
		public void Should_Remove_Todo()
		{
			// Arrage
			Todo valid = new Todo((Name)"Add me to the Collection");
			TodoCollection collection = new TodoCollection();

			// Act
			collection.Add(valid);
			collection.Remove(valid);

			// Assert
			Assert.False(collection.Contains(valid));
		}

		[Fact]
		public void Should_Get_ReadOnly()
		{
			// Arrage
			Todo valid = new Todo((Name)"Add me to the Collection");
			TodoCollection collection = new TodoCollection();

			// Act
			var readOnly = collection.GetReadOnly();

			// Assert
			Assert.IsAssignableFrom<IReadOnlyCollection<Todo>>(readOnly);
		}

		[Fact]
		public void Should_Contain_Todo()
		{
			// Arrage
			var todo1 = new Todo((Name)"Add me to the Collection");

			TodoCollection collection = new TodoCollection();

			// Act
			collection.Add(todo1);

			// Assert
			Assert.True(collection.Contains(todo1));
		}

		[Fact]
		public void Should_Count_Todo()
		{
			// Arrage
			var todo1 = new Todo((Name)"Add me to the Collection");
			var todo2 = new Todo((Name)" am on that list too");

			TodoCollection collection = new TodoCollection();

			// Act
			collection.Add(todo1);
			collection.Add(todo2);

			// Assert
			Assert.True(collection.Count == 2);
		}

		[Fact]
		public void Should_AddRange_Todo()
		{
			// Arrage
			var todo1 = new Todo((Name)"Add me to the Collection");
			var todo2 = new Todo((Name)" am on that list too");

			TodoCollection collection = new TodoCollection();

			// Act
			collection.AddRange(todo1, todo2);

			// Assert
			Assert.True(collection.Contains(todo1));
			Assert.True(collection.Contains(todo2));
			Assert.False(collection.Contains(new Todo((Name)"I'm not on that collletion")));
		}


		[Fact]
		public void Should_ContainsRange_Todo()
		{
			// Arrage
			var valid = new List<Todo>
			{
				new Todo((Name)"Add me to the Collection"),
				new Todo((Name)") am on that list too"),
			};

			Todo shouldError = new Todo((Name)"ERROR");

			TodoCollection collection = new TodoCollection();

			// Act
			valid.ForEach(t => collection.Add(t));

			// Assert
			Assert.True(collection.CointainsRange(valid[1], valid[0]));
			Assert.False(collection.CointainsRange(valid[1], valid[0], shouldError));
		}


		[Fact]
		public void Should_Only_Add_New_Todo()
		{
			// Arrage
			var todo1 = new Todo((Name)"Add me to the Collection");
			var todo2 = new Todo((Name)" am on that list too");

			TodoCollection collection = new TodoCollection();

			// Act
			collection.AddRange(todo1, todo2, todo1, todo1);
			collection.Add(todo1);
			collection.Add(todo2);

			// Assert
			Assert.Equal(2, collection.Count);
		}
	}
}