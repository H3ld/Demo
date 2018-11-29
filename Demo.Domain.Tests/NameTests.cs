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
				() => new Password(empty));
			Assert.Throws<NameShouldNotBeEmptyException>(
				() => new Password(whitespace));
		}

		[Fact]
		public void Should_Create_Explicit_String()
		{
			// Arrage
			string valid = "Reply Accessor on talent.io";

			// Act
			Password output = new Password(valid);

			// Assert
			Assert.Equal(valid, (string)output);
			Assert.NotNull(output);
		}

		[Fact]
		public void Should_Create_Explicit_Name()
		{
			// Arrange
			string text = "Hallo Frau Grünbaum";
			Password valid = new Password(text);
			
			// Act
			var output = (Password)text;

			// Assert
			Assert.Equal(valid, output);
			Assert.NotNull(output);
		}
	}
}
