using System;
using Nancy.Bootstrappers.Autofac;
using Nancy;

namespace RosterTracker
{
	public class CustomBootstrapper : AutofacNancyBootstrapper
	{
		public CustomBootstrapper ()
		{
		}

		protected override void ApplicationStartup (Autofac.ILifetimeScope container, Nancy.Bootstrapper.IPipelines pipelines)
		{
			base.ApplicationStartup (container, pipelines);

			StaticConfiguration.DisableErrorTraces = false;
		}
	}
}

