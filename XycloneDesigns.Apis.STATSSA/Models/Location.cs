using XycloneDesigns.Apis.STATSSA.Enums;
using XycloneDesigns.Apis.STATSSA.Structs;

namespace XycloneDesigns.Apis.STATSSA.Models
{
    public class Location : _Model
	{
		public int? CouncilCodeDistrict { get; set; }
		public int? CouncilCodeMagisterial { get; set; }
		public int? CouncilCodeTransitionalLocalRural { get; set; }
		public Uncertain<Provinces>? Province { get; set; }
		public Uncertain<int>? Urban { get; set; }
	}
}