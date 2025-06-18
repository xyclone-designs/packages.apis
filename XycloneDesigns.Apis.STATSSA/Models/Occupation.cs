using XycloneDesigns.Apis.STATSSA.Enums;
using XycloneDesigns.Apis.STATSSA.Structs;

namespace XycloneDesigns.Apis.STATSSA.Models
{
    public class Occupation : _Model
	{
		public int? Code { get; set; }
		public int? CodeEmploymentMagisterial { get; set; }
		public int? CodeIndustry { get; set; }
		public int? CodePrevious { get; set; }
		public Uncertain<bool>? FullOrPartTime { get; set; }
		public Uncertain<IncomeLevelsMonthly>? Income { get; set; }
		public Uncertain<bool>? IsMigrantWorker { get; set; }
	}
}