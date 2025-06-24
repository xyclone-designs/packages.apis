using System.Collections.Generic;

using XycloneDesigns.Apis.General.Models;

namespace XycloneDesigns.Apis.IEC.Models
{
	public class Ward : Model
    {
		public string? Id { get; set; }
		public Municipality? Municipality { get; set; }
		public Province? Province { get; set; }
		public List<VotingDistrict>? VotingDistricts { get; set; }
	}
}