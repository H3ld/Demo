using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Application.UseCases.Register
{
	public sealed class RegisterOutput
	{
		public UserOutput UserOutput { get; private set; }

		public RegisterOutput(UserOutput userOutput)
		{
			UserOutput = userOutput;
		}
	}
}
