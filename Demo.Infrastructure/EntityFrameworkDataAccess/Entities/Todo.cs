using System;
namespace Demo.Infrastructure.EntityFrameworkDataAccess.Entities
{
	public class Todo
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public string Name { get; set; }
	}
}
