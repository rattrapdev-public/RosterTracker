using System;
using System.Collections.Generic;
using Rattrap.RosterTracker.Application.Players;

namespace Rattrap.RosterTracker.Mocks
{
	public class MockPlayerApplicationService  : IPlayerApplicationService
	{
		public MockPlayerApplicationService() 
		{
		}

		public IEnumerable<PlayerSummaryPresentationObject> GetRosterSummary ()
		{
			var playerRoster = new List<PlayerSummaryPresentationObject> {
				new PlayerSummaryPresentationObject (Guid.NewGuid (), "Jameel McKay", 1, 81, 225, Year.Senior),
				new PlayerSummaryPresentationObject (Guid.NewGuid (), "Abdel Nader", 2, 78, 225, Year.Senior),
				new PlayerSummaryPresentationObject (Guid.NewGuid (), "Hallice Cooke", 3, 75, 190, Year.Sophomore),
				new PlayerSummaryPresentationObject (Guid.NewGuid (), "Wes Greder", 4, 77, 185, Year.Freshman),
				new PlayerSummaryPresentationObject (Guid.NewGuid (), "Simeon Carter", 0, 80, 215, Year.Freshman),
				new PlayerSummaryPresentationObject (Guid.NewGuid (), "Monte Morris", 11, 75, 175, Year.Junior),
				new PlayerSummaryPresentationObject (Guid.NewGuid (), "Nick Weiler-Babb", 12, 77, 205, Year.Sophomore),
				new PlayerSummaryPresentationObject (Guid.NewGuid (), "Nazareth Mitrou-Long", 15, 76, 208, Year.Senior),
				new PlayerSummaryPresentationObject (Guid.NewGuid (), "Matt Thomas", 21, 76, 197, Year.Junior),
				new PlayerSummaryPresentationObject (Guid.NewGuid (), "Jordan Ashton", 23, 76, 195, Year.Junior),
				new PlayerSummaryPresentationObject (Guid.NewGuid (), "Stuart Nezlek", 24, 82, 245, Year.Junior),
				new PlayerSummaryPresentationObject (Guid.NewGuid (), "Deonte Burton", 30, 76, 250, Year.Junior),
				new PlayerSummaryPresentationObject (Guid.NewGuid (), "Georges Niang", 31, 80, 230, Year.Senior),
				new PlayerSummaryPresentationObject (Guid.NewGuid (), "Brady Ernst", 33, 81, 215, Year.Freshman)
			};

			return playerRoster;
		}
	}
}

