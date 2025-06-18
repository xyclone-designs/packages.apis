using XycloneDesigns.Apis.STATSSA.Enums;
using XycloneDesigns.Apis.STATSSA.Structs;

namespace XycloneDesigns.Apis.STATSSA.Models
{
	public class Land : _Model
	{
		public int? LivestockProduction { get; set; }
		public int? Poultry { get; set; }
		public int? VegetableProduction { get; set; }
		public int? OtherCrops { get; set; }
		public int? FodderGrazingPastureGrassForAnimals { get; set; }
		public int? OtherAgriculturalActivies { get; set; }
		public int? NoAgriculturalActivies { get; set; }
		public Uncertain<LivestockCounts>? Cattle { get; set; }
		public Uncertain<LivestockCounts>? Sheep { get; set; }
		public Uncertain<LivestockCounts>? Goats { get; set; }
		public Uncertain<LivestockCounts>? Pigs { get; set; }
		public Uncertain<LivestockCounts>? OtherLivestocks { get; set; }
		public int? Farmland { get; set; }
		public int? BackyardOrSchool { get; set; }
		public int? CommunalOrTribalLand { get; set; }
		public int? OtherPlaceOfAgriculturalActivies { get; set; }	
	}
}