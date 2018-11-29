namespace Demo.WebApp
{
	using Autofac;
	public class Module : Autofac.Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterAssemblyTypes(typeof(Startup).Assembly)
				.AsSelf()
				.InstancePerLifetimeScope();
		}
	}
}
