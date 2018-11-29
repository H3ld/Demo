using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure
{
	public sealed class InfrastructureException : Exception
	{
		public InfrastructureException() : base("Infrasructure Exeption") { }
		public InfrastructureException(string msg) : base(msg) { }
	}
}
