using Xunit;
using System;
using Demo.Domain.ValueObjects;

namespace Demo.Domain.Tests
{
	public class NameTests
	{
		[Fact]
		public void ShouldNotCreateEmptyName()
		{
			// Arrange
			string empty = String.Empty;
			string whitespace = " ";

			// Assert
			Assert.Throws<NameShouldNotBeEmptyException>(
				() => new Name(empty));
			Assert.Throws<NameShouldNotBeEmptyException>(
				() => new Name(whitespace));
		}

		[Fact]
		public void Should_Create_Explicit_String()
		{
			// Arrage
			string valid = "Reply Accessor on talent.io";

			// Act
			Name output = new Name(valid);

			// Assert
			Assert.Equal(valid, (string)output);
			Assert.NotNull(output);
		}

		[Fact]
		public void Should_Create_Explicit_Name()
		{
			// Arrange
			string text = "Hallo Frau Grünbaum";
			Name valid = new Name(text);
			
			// Act
			var output = (Name)text;

			// Assert
			Assert.Equal(valid, output);
			Assert.NotNull(output);
		}
	}
}
