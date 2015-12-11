using System;

namespace RosterTracker
{
	public class AngularTutorialModule : Nancy.NancyModule
	{
		public AngularTutorialModule ()
			: base("/test/angular")
		{
			Get ["/FirstHelloWorld"] = _ => View ["Views/Test/Angular/FirstHelloWorld"];
			Get ["/FirstAppExpanded"] = _ => View ["Views/Test/Angular/FirstAppExpanded"];
			Get ["/AngularExpressions"] = _ => View ["Views/Test/Angular/AngularExpressions"];
			Get ["/FirstController"] = _ => View ["Views/Test/Angular/FirstController"];
			Get ["/Filters"] = _ => View ["Views/Test/Angular/Filters"];
			Get ["/Tables"] = _ => View ["Views/Test/Angular/Tables"];
			Get ["/HtmlDom"] = _ => View ["Views/Test/Angular/HtmlDom"];
			Get ["/Modules"] = _ => View ["Views/Test/Angular/Modules"];
			Get ["/Forms"] = _ => View ["Views/Test/Angular/Forms"];
			Get ["/Includes"] = _ => View ["Views/Test/Angular/Includes"];
			Get ["/Ajax"] = _ => View ["Views/Test/Angular/Ajax"];
			Get ["/Views"] = _ => View ["Views/Test/Angular/Views"];
			Get ["/Scopes"] = _ => View ["Views/Test/Angular/Scopes"];
			Get ["/Services"] = _ => View ["Views/Test/Angular/Services"];
			Get ["/DependencyInjection"] = _ => View ["Views/Test/Angular/DependencyInjection"];
		}
	}
}

