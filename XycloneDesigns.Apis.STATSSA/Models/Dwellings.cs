using XycloneDesigns.Apis.STATSSA.Enums;
using XycloneDesigns.Apis.STATSSA.Structs;

namespace XycloneDesigns.Apis.STATSSA.Models
{
    public class Dwellings : _Model
	{
		public Uncertain<TypeDwelling>? Dwelling { get; set; }
		public Uncertain<bool>? Owned { get; set; }

		public Uncertain<bool>? Migrants { get; set; }
		public Uncertain<int>? NumberOf_MigrantWorkers { get; set; }
		public Uncertain<int>? NumberOf_HouseholdsSharingOneRoom { get; set; }
	}
}