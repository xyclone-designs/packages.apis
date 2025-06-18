using XycloneDesigns.Apis.STATSSA.Enums;
using XycloneDesigns.Apis.STATSSA.Models;
using XycloneDesigns.Apis.STATSSA.Structs;

namespace XycloneDesigns.Apis.STATSSA.Tables
{
	[SQLite.Table(SQL.Table)]
    public class RecordsHouseholdAgricultural : RecordsHousehold
	{
		public new static class SQL 
		{
			public const string Table = "records_householdagricultural";

			public const string Column_LivestockProduction = "livestockproduction";
			public const string Column_Poultry = "poultry";
			public const string Column_VegetableProduction = "vegetableproduction";
			public const string Column_OtherCrops = "othercrops";
			public const string Column_FodderGrazingPastureGrassForAnimals = "foddergrazingpasturegrassforanimals";
			public const string Column_OtherAgriculturalActivies = "otheragriculturalactivies";
			public const string Column_NoAgriculturalActivies = "noagriculturalactivies";
			public const string Column_Cattle = "cattle";
			public const string Column_Sheep = "sheep";
			public const string Column_Goats = "goats";
			public const string Column_Pigs = "pigs";
			public const string Column_OtherLivestocks = "otherlivestocks";
			public const string Column_Farmland = "farmland";
			public const string Column_BackyardOrSchool = "backyardorschool";
			public const string Column_CommunalOrTribalLand = "communalortriballand";
			public const string Column_OtherPlaceOfAgriculturalActivies = "otherplaceofagriculturalactivies";
		}

		[SQLite.Column(SQL.Column_LivestockProduction)] public int? LivestockProduction { get; set; }
		[SQLite.Column(SQL.Column_Poultry)] public int? Poultry { get; set; }
		[SQLite.Column(SQL.Column_VegetableProduction)] public int? VegetableProduction { get; set; }
		[SQLite.Column(SQL.Column_OtherCrops)] public int? OtherCrops { get; set; }
		[SQLite.Column(SQL.Column_FodderGrazingPastureGrassForAnimals)] public int? FodderGrazingPastureGrassForAnimals { get; set; }
		[SQLite.Column(SQL.Column_OtherAgriculturalActivies)] public int? OtherAgriculturalActivies { get; set; }
		[SQLite.Column(SQL.Column_NoAgriculturalActivies)] public int? NoAgriculturalActivies { get; set; }
		[SQLite.Column(SQL.Column_Cattle)] public int? Cattle { get; set; }
		[SQLite.Column(SQL.Column_Sheep)] public int? Sheep { get; set; }
		[SQLite.Column(SQL.Column_Goats)] public int? Goats { get; set; }
		[SQLite.Column(SQL.Column_Pigs)] public int? Pigs { get; set; }
		[SQLite.Column(SQL.Column_OtherLivestocks)] public int? OtherLivestocks { get; set; }
		[SQLite.Column(SQL.Column_Farmland)] public int? Farmland { get; set; }
		[SQLite.Column(SQL.Column_BackyardOrSchool)] public int? BackyardOrSchool { get; set; }
		[SQLite.Column(SQL.Column_CommunalOrTribalLand)] public int? CommunalOrTribalLand { get; set; }
		[SQLite.Column(SQL.Column_OtherPlaceOfAgriculturalActivies)] public int? OtherPlaceOfAgriculturalActivies { get; set; }

		public Uncertain<LivestockCounts>? _Cattle;
		public Uncertain<LivestockCounts>? _Sheep;
		public Uncertain<LivestockCounts>? _Goats;
		public Uncertain<LivestockCounts>? _Pigs;
		public Uncertain<LivestockCounts>? _OtherLivestocks;

		public new RecordHousehold ToModel()
		{
			RecordHousehold _base = base.ToModel();

			_base.Land = new Land
			{
				LivestockProduction = LivestockProduction,
				Poultry = Poultry,
				VegetableProduction = VegetableProduction,
				OtherCrops = OtherCrops,
				FodderGrazingPastureGrassForAnimals = FodderGrazingPastureGrassForAnimals,
				OtherAgriculturalActivies = OtherAgriculturalActivies,
				NoAgriculturalActivies = NoAgriculturalActivies,
				Cattle = Uncertain.From<LivestockCounts>(Cattle),
				Sheep = Uncertain.From<LivestockCounts>(Sheep),
				Goats = Uncertain.From<LivestockCounts>(Goats),
				Pigs = Uncertain.From<LivestockCounts>(Pigs),
				OtherLivestocks = Uncertain.From<LivestockCounts>(OtherLivestocks),
				Farmland = Farmland,
				BackyardOrSchool = BackyardOrSchool,
				CommunalOrTribalLand = CommunalOrTribalLand,
				OtherPlaceOfAgriculturalActivies = OtherPlaceOfAgriculturalActivies,
			};

			return _base;
		}
		public new void FromModel(RecordHousehold record)
		{
			base.FromModel(record);

			LivestockProduction = record.Land?.LivestockProduction;
			Poultry = record.Land?.Poultry;
			VegetableProduction = record.Land?.VegetableProduction;
			OtherCrops = record.Land?.OtherCrops;
			FodderGrazingPastureGrassForAnimals = record.Land?.FodderGrazingPastureGrassForAnimals;
			OtherAgriculturalActivies = record.Land?.OtherAgriculturalActivies;
			NoAgriculturalActivies = record.Land?.NoAgriculturalActivies;
			Cattle = record.Land?.Cattle?.ToInt(_ => (int?)_);
			Sheep = record.Land?.Sheep?.ToInt(_ => (int?)_);
			Goats = record.Land?.Goats?.ToInt(_ => (int?)_);
			Pigs = record.Land?.Pigs?.ToInt(_ => (int?)_);
			OtherLivestocks = record.Land?.OtherLivestocks?.ToInt(_ => (int?)_);
			Farmland = record.Land?.Farmland;
			BackyardOrSchool = record.Land?.BackyardOrSchool;
			CommunalOrTribalLand = record.Land?.CommunalOrTribalLand;
			OtherPlaceOfAgriculturalActivies = record.Land?.OtherPlaceOfAgriculturalActivies;
		}
	}
}