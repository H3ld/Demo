using System;

namespace Demo.Domain.ValueObjects
{
	public sealed class Name
	{
		private string _text;

		public Name(string name)
		{
			if (String.IsNullOrWhiteSpace(name) || String.IsNullOrEmpty(name))
				throw new NameShouldNotBeEmptyException();

			_text = name;
		}

		public static explicit operator string(Name name)
		{
			return name._text;
		}

		public static explicit operator Name(string text)
		{
			return new Name(text);
		}

		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
			{ return false; }
			else if (ReferenceEquals(this, obj))
			{ return true; }
			else if (obj is string)
			{ return obj.ToString() == _text; }
			else { return ((Name)obj)._text == _text; }
			
		}
		public override int GetHashCode()
		{
			return _text.GetHashCode();
		} 

	}
}
