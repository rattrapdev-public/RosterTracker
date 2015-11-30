using System;
using Nancy.ViewEngines.Razor;
using System.Collections.Generic;

namespace RosterTracker
{
	public class RazorConfig : IRazorConfiguration
	{
		#region IRazorConfiguration implementation

		public IEnumerable<string> GetAssemblyNames ()
		{
			yield return "Rattrap.RosterTracker";
		}

		public IEnumerable<string> GetDefaultNamespaces ()
		{
			yield return "Rattrap.RosterTracker.Application.Players";
		}

		public bool AutoIncludeModelNamespace {
			get {
				return false;
			}
		}

		#endregion
	}
}

