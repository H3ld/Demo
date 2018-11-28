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
		public void Should_Âdd_New_Todo()
		{
			// Arrage
			Todo valid = new Todo((Name)"Add me to the Collection");
			TodoCollection collection = new TodoCollection();

			// Act
			collection.Add(valid);

			// Assert
			Assert.True(collection.Contains(valid));
		}
	}
}