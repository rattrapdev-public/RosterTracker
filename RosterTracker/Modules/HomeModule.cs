using System;

namespace RosterTracker
{
	public class HomeModule : Nancy.NancyModule
	{
		public HomeModule ()
			:base ("/")
		{
			Get [""] = parameters => View["Views/Home"];
		}
	}
}

