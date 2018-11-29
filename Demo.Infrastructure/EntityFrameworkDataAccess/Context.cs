using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Demo.Domain.Tasks;
using Demo.Domain.Users;

namespace Demo.Infrastructure.EntityFrameworkDataAccess
{
	public class Context: DbContext
	{
		public Context(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Entities.User> Users { get; set; }
		public DbSet<Entities.Todo> Todo { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Entities.User>()
				.ToTable("User");

			modelBuilder.Entity<Entities.Todo>()
				.ToTable("Todo");

		}
	}
}
