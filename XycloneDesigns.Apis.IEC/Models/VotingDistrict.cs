using XycloneDesigns.Apis.General.Models;

namespace XycloneDesigns.Apis.IEC.Models
{
	public class VotingDistrict : Model
	{
		public string? Id { get; set; }
		public Municipality? Municipality { get; set; }
		public Province? Province { get; set; }
		public Ward? Ward { get; set; }
	}
}