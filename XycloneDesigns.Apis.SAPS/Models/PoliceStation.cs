using XycloneDesigns.Apis.General.Models;

namespace XycloneDesigns.Apis.SAPS.Models
{
	public class PoliceStation : Model
	{
		public District? District { get; set; }
		public Municipality? Municipality { get; set; }
		public string? Name { get; set; }
		public Province? Province { get; set; }
	}
}