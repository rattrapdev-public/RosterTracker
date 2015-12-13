using System;
using Nancy;
using Rattrap.RosterTracker.Application.Players;

namespace RosterTracker
{
	public class RosterModule : NancyModule
	{
		public RosterModule (IPlayerApplicationService playerApplicationService)
			: base("players")
		{
			Get [""] = _ => 
			{
				var roster = playerApplicationService.GetRosterSummary();
				return View["views/RosterSummary", roster];
			};
			Get ["/interactive"] = _ => View ["views/InteractiveRoster"];
		}
	}
}

