using System;

namespace Rattrap.RosterTracker
{
	public class PlayerSummaryPresentationObject
	{
		public PlayerSummaryPresentationObject (Guid id, string name, int jerseyNumber, int height, int weight, Year year)
		{
			this.Id = id;
			this.Name = name;
			this.JerseyNumber = jerseyNumber;
			this.Height = height;
			this.Weight = weight;
			this.Year = year;
		}
		
		public Guid Id { get; set; }
		public string Name { get; set; }
		public int JerseyNumber { get; set; }
		public int Height { get; set; }
		public int Weight { get; set; }
		public Year Year { get; set; }
	}
}

