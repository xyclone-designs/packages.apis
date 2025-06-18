using XycloneDesigns.Apis.STATSSA.Enums;
using XycloneDesigns.Apis.STATSSA.Structs;

namespace XycloneDesigns.Apis.STATSSA.Models
{
    public class Disabilities : _Model
	{
		public Uncertain<bool>? Sight { get; set; }
		public Uncertain<bool>? Hearing { get; set; }
		public Uncertain<bool>? Physical { get; set; }
		public Uncertain<bool>? Mental { get; set; }
		public Uncertain<TypeDisability>? Type { get; set; }
	}
}