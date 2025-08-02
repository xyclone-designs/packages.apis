using System.Collections.Generic;

using XycloneDesigns.Apis.General.Models;

namespace XycloneDesigns.Apis.IEC.Models
{
	public class VotingDistrict : Model
	{
		public List<Ballot>? Ballots { get; set; }
		public Country? Country { get; set; }
		public District? District { get; set; }
		public string? Id { get; set; }
		public Municipality? Municipality { get; set; }
		public Province? Province { get; set; }
		public Ward? Ward { get; set; }
	}
}