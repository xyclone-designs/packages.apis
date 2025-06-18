using XycloneDesigns.Apis.STATSSA.Enums;
using XycloneDesigns.Apis.STATSSA.Structs;

namespace XycloneDesigns.Apis.STATSSA.Models
{
    public class Residence : _Model
	{
		public int? PreviousMagesterialCode { get; set; }
		public int? UsualMagesterialCode { get; set; }
		public Uncertain<UsualResidence>? UsualPlaceOf { get; set; }
		public Uncertain<int>? UsualYearMoved { get; set; }
	}
}