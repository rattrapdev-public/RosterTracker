using System.Collections.Generic;

namespace Rattrap.RosterTracker.Application.Players
{
	public interface IPlayerApplicationService
	{
		IEnumerable<PlayerSummaryPresentationObject> GetRosterSummary();
	}
}

