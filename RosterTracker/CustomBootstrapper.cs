
using Nancy.Bootstrappers.Autofac;
using Nancy;
using Autofac;
using Rattrap.RosterTracker.Mocks;
using Rattrap.RosterTracker.Application.Players;

namespace RosterTracker
{
	public class CustomBootstrapper : AutofacNancyBootstrapper
	{
		protected override void ApplicationStartup (ILifetimeScope container, Nancy.Bootstrapper.IPipelines pipelines)
		{
			base.ApplicationStartup (container, pipelines);

			var builder = new ContainerBuilder ();
			builder.RegisterType<MockPlayerApplicationService> ().As<IPlayerApplicationService>();
			builder.Update (container.ComponentRegistry);

			StaticConfiguration.DisableErrorTraces = false;
		}
	}
}

