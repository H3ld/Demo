﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.EntityFrameworkDataAccess.Entities
{
	public class User
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Password { get; set; }


	}
}
