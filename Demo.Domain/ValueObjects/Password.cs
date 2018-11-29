using System;

namespace Demo.Domain.ValueObjects
{
	public sealed class Password
	{
		private string _text;

		public Password(string password)
		{
			if (String.IsNullOrWhiteSpace(password) || String.IsNullOrEmpty(password))
				throw new NameShouldNotBeEmptyException();

			_text = password;
		}

		public static explicit operator string(Password name)
		{
			return name._text;
		}

		public static explicit operator Password(string text)
		{
			return new Password(text);
		}

		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
			{ return false; }
			else if (ReferenceEquals(this, obj))
			{ return true; }
			else if (obj is string)
			{ return obj.ToString() == _text; }
			else { return ((Password)obj)._text == _text; }
			
		}
		public override int GetHashCode()
		{
			return _text.GetHashCode();
		} 
	}
}
