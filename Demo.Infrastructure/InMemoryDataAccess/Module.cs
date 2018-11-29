using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace Demo.Infrastructure.InMemoryDataAccess
{
	class Module : Autofac.Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<Context>()
				.As<Context>()
				.SingleInstance();

			builder.RegisterAssemblyTypes(typeof(InfrastructureException).Assembly)
				.Where(type => type.Namespace.Contains("InMemoryDataAccess"))
				.AsImplementedInterfaces()
				.InstancePerLifetimeScope();
		}
	}
}
