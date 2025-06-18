using XycloneDesigns.Apis.STATSSA.Enums;
using XycloneDesigns.Apis.STATSSA.Structs;

namespace XycloneDesigns.Apis.STATSSA.Models
{
    public class Motherhood : _Model
	{
		public Uncertain<int>? AgeAtFirstBorn { get; set; }
		public Uncertain<int>? ChildrenBorn { get; set; }
		public Uncertain<int>? ChildrenAlive { get; set; }
		public Uncertain<int>? NumberBirthsLast12Months { get; set; }
	}
}