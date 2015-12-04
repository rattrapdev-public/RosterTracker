using System;

namespace RosterTracker
{
	public class AngularTutorialModule : Nancy.NancyModule
	{
		public AngularTutorialModule ()
			: base("/test/angular")
		{
			Get ["/FirstHelloWorld"] = _ => View ["Views/Test/Angular/FirstHelloWorld"];
		}
	}
}

