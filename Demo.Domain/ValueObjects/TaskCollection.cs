using System;
using System.Collections.Generic;
using System.Text;
using Demo.Domain.Tasks;

namespace Demo.Domain.ValueObjects
{
	public class TodoCollection : ItemCollection<Todo>
	{
		public override bool REMOVES_DOUBLES { get => true; }
	}
}
