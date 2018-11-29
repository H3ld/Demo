using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Autofac;
using Demo.Domain.Tasks;
using Demo.Domain.Users;

namespace Demo.Infrastructure.InMemoryDataAccess
{
	class Context
	{
		public Collection<User> Users { get; set; }
		public Collection<Todo> Todo { get; set; }

		public Context()
		{
			Users = new Collection<User>();
			Todo = new Collection<Todo>();
		}
	}
}
