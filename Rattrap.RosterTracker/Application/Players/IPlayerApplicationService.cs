using System;
using System.Collections.Generic;

namespace Rattrap.RosterTracker
{
	public interface IPlayerApplicationService
	{
		IEnumerable<PlayerSummaryPresentationObject> GetRosterSummary();
	}
}

