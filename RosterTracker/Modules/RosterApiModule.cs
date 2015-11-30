﻿using Rattrap.RosterTracker;
using System.Collections.Generic;
using Nancy;
using Newtonsoft.Json;

namespace RosterTracker
{
	public class RosterApiModule : NancyModule
	{
		public RosterApiModule (IPlayerApplicationService applicationService)
			: base("/api/players")
		{
			Get [""] = _ => 
			{
				IEnumerable<PlayerSummaryPresentationObject> rosterSummary = applicationService.GetRosterSummary();
				return Response.AsJson(JsonConvert.SerializeObject(rosterSummary));
			};
		}
	}
}
