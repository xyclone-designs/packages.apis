using XycloneDesigns.Apis.STATSSA.Enums;
using XycloneDesigns.Apis.STATSSA.Models;
using XycloneDesigns.Apis.STATSSA.Structs;

namespace XycloneDesigns.Apis.STATSSA.Tables
{
	[SQLite.Table(SQL.Table)]
    public class RecordsHousehold : Records
	{
		public new static class SQL
		{
			public const string Table = "records_household";

			public const string Column_Number = "number";
			public const string Column_Province = "province";
			public const string Column_CouncilCodeDistrict = "councilcodedistrict";
			public const string Column_CouncilCodeMagisterial = "councilcodemagisterial";
			public const string Column_CouncilCodeTransitionalLocalRural = "councilcodetransitionallocalrural";
			public const string Column_Dwelling = "dwelling";
			public const string Column_DwellingsOwned = "dwellingsowned";
			public const string Column_FacilitiesToilet = "facilitiestoilet";
			public const string Column_FacilitiesTelephone = "facilitiestelephone";
			public const string Column_FacilitiesRefuseDisposal = "facilitiesrefusedisposal";
			public const string Column_HeadOf_Age = "headof_age";
			public const string Column_HeadOf_Education = "headof_education";
			public const string Column_HeadOf_EmploymentStatus = "headof_employmentstatus";
			public const string Column_HeadOf_IncomeLevel = "headof_incomelevel";
			public const string Column_HeadOf_Occupation = "headof_occupation";
			public const string Column_HeadOf_Race = "headof_race";
			public const string Column_HeadOf_Sex = "headof_sex";
			public const string Column_HighestIncomeIn = "highestincomein";
			public const string Column_HighestIncomeIn_Gender = "highestincomein_gender";
			public const string Column_HighestIncomeIn_Race = "highestincomein_race";
			public const string Column_HouseholdSize = "householdsize";
			public const string Column_Income = "income";
			public const string Column_IncomeAdditional = "incomeadditional";
			public const string Column_IncomeReceivedRemittances = "incomereceivedremittances";
			public const string Column_Migrant = "migrant";
			public const string Column_NumberOf_MigrantWorkers = "numberof_migrantworkers";
			public const string Column_NumberOf_HouseholdsSharingOneRoom = "numberof_householdssharingoneroom";
			public const string Column_QuestionType = "questiontype";
			public const string Column_Rooms = "rooms";
			public const string Column_SourceOfWater = "sourceofwater";
			public const string Column_SourceOfFuelCooking = "sourceoffuelcooking";
			public const string Column_SourceOfFuelHeating = "sourceoffuelheating";
			public const string Column_SourceOfFuelLighting = "sourceoffuellighting";
			public const string Column_Urban = "urban";
		}

		[SQLite.Column(SQL.Column_Number)] public int? Number { get; set; }
		[SQLite.Column(SQL.Column_Province)] public int? Province
		{
			get => _Province?.ToInt(_ => (int?)_);
			set => _Province = Uncertain.From<Provinces>(value);
		}
		[SQLite.Column(SQL.Column_CouncilCodeDistrict)] public int? CouncilCodeDistrict { get; set; }
		[SQLite.Column(SQL.Column_CouncilCodeMagisterial)] public int? CouncilCodeMagisterial { get; set; }
		[SQLite.Column(SQL.Column_CouncilCodeTransitionalLocalRural)] public int? CouncilCodeTransitionalLocalRural { get; set; }
		[SQLite.Column(SQL.Column_Dwelling)] public int? Dwelling
		{
			get => _Dwelling?.ToInt(_ => (int?)_);
			set => _Dwelling = Uncertain.From<TypeDwelling>(value);
		}
		[SQLite.Column(SQL.Column_DwellingsOwned)] public int? DwellingsOwned
		{ 
			get => _DwellingsOwned?.ToInt();
			set => _DwellingsOwned = Uncertain.From<bool>(value); 
		}
		[SQLite.Column(SQL.Column_FacilitiesToilet)] public int? FacilitiesToilet
		{
			get => _FacilitiesToilet?.ToInt(_ => (int?)_);
			set => _FacilitiesToilet = Uncertain.From<FacilitiesToilet>(value);
		}
		[SQLite.Column(SQL.Column_FacilitiesTelephone)] public int? FacilitiesTelephone
		{
			get => _FacilitiesTelephone?.ToInt(_ => (int?)_);
			set => _FacilitiesTelephone = Uncertain.From<FacilitiesTelephone>(value);
		}
		[SQLite.Column(SQL.Column_FacilitiesRefuseDisposal)] public int? FacilitiesRefuseDisposal
		{
			get => _FacilitiesRefuseDisposal?.ToInt(_ => (int?)_);
			set => _FacilitiesRefuseDisposal = Uncertain.From<FacilitiesRefuseDisposal>(value);
		}
		[SQLite.Column(SQL.Column_HeadOf_Age)] public int? HeadOf_Age
		{
			get => _HeadOf_Age?.ToInt(_ => (int?)_);
			set => _HeadOf_Age = Uncertain.From<int>(value);
		}
		[SQLite.Column(SQL.Column_HeadOf_Education)] public int? HeadOf_Education
		{
			get => _HeadOf_Education?.ToInt(_ => (int?)_);
			set => _HeadOf_Education = Uncertain.From<EducationLevels>(value);
		}
		[SQLite.Column(SQL.Column_HeadOf_EmploymentStatus)] public int? HeadOf_EmploymentStatus
		{
			get => _HeadOf_EmploymentStatus?.ToInt(_ => (int?)_);
			set => _HeadOf_EmploymentStatus = Uncertain.From<EmploymentStatuses>(value);
		}
		[SQLite.Column(SQL.Column_HeadOf_IncomeLevel)] public int? HeadOf_IncomeLevel
		{
			get => _HeadOf_IncomeLevel?.ToInt(_ => (int?)_);
			set => _HeadOf_IncomeLevel = Uncertain.From<IncomeLevelsMonthly>(value);
		}
		[SQLite.Column(SQL.Column_HeadOf_Occupation)] public int? HeadOf_Occupation { get; set; }
		[SQLite.Column(SQL.Column_HeadOf_Race)] public int? HeadOf_Race
		{
			get => _HeadOf_Race?.ToInt(_ => (int?)_);
			set => _HeadOf_Race = Uncertain.From<PopulationGroups>(value);
		}
		[SQLite.Column(SQL.Column_HeadOf_Sex)] public int? HeadOf_Sex
		{
			get => _HeadOf_Sex?.ToInt(_ => (int?)_);
			set => _HeadOf_Sex = Uncertain.From<Sexes>(value);
		}
		[SQLite.Column(SQL.Column_HighestIncomeIn)] public int? HighestIncomeIn
		{
			get => _HighestIncomeIn?.ToInt(_ => (int?)_);
			set => _HighestIncomeIn = Uncertain.From<IncomeLevelsMonthly>(value);
		}
		[SQLite.Column(SQL.Column_HighestIncomeIn_Gender)] public int? HighestIncomeIn_Gender
		{
			get => _HighestIncomeIn_Gender?.ToInt(_ => (int?)_);
			set => _HighestIncomeIn_Gender = Uncertain.From<Sexes>(value);
		}
		[SQLite.Column(SQL.Column_HighestIncomeIn_Race)] public int? HighestIncomeIn_Race 
		{
			get => _HighestIncomeIn_Race ?.ToInt(_ => (int?)_);
			set => _HighestIncomeIn_Race  = Uncertain.From<PopulationGroups>(value);
		}
		[SQLite.Column(SQL.Column_HouseholdSize)] public int? HouseholdSize
		{
			get => _HouseholdSize?.ToInt(_ => _);
			set => _HouseholdSize = Uncertain.From<int>(value);
		}
		[SQLite.Column(SQL.Column_Income)] public int? Income
		{
			get => _Income?.ToInt(_ => (int?)_);
			set => _Income = Uncertain.From<IncomeLevelsMonthlyHousehold>(value);
		}
		[SQLite.Column(SQL.Column_IncomeAdditional)] public int? IncomeAdditional
		{
			get => _IncomeAdditional?.ToInt(_ => (int?)_);
			set => _IncomeAdditional = Uncertain.From<IncomeLevelsMonthlyHousehold>(value);
		}
		[SQLite.Column(SQL.Column_IncomeReceivedRemittances)] public int? IncomeReceivedRemittances
		{
			get => _IncomeReceivedRemittances?.ToInt(_ => (int?)_);
			set => _IncomeReceivedRemittances = Uncertain.From<IncomeLevelsMonthlyHousehold>(value);
		}
		[SQLite.Column(SQL.Column_Migrant)] public int? Migrant
		{
			get => _Migrant?.ToInt();
			set => _Migrant = Uncertain.From<bool>(value);
		}
		[SQLite.Column(SQL.Column_NumberOf_MigrantWorkers)] public int? NumberOf_MigrantWorkers
		{
			get => _NumberOf_MigrantWorkers?.ToInt(_ => (int?)_);
			set => _NumberOf_MigrantWorkers = Uncertain.From<int>(value);
		}
		[SQLite.Column(SQL.Column_NumberOf_HouseholdsSharingOneRoom)] public int? NumberOf_HouseholdsSharingOneRoom
		{
			get => _NumberOf_HouseholdsSharingOneRoom?.ToInt(_ => (int?)_);
			set => _NumberOf_HouseholdsSharingOneRoom = Uncertain.From<int>(value);
		}
		[SQLite.Column(SQL.Column_QuestionType)] public int? QuestionType { get; set; }
		[SQLite.Column(SQL.Column_Rooms)] public int? Rooms
		{
			get => _Rooms?.ToInt(_ => _);
			set => _Rooms = Uncertain.From<int>(value);
		}
		[SQLite.Column(SQL.Column_SourceOfWater)] public int? SourceOfWater
		{
			get => _SourceOfWater?.ToInt(_ => (int?)_);
			set => _SourceOfWater = Uncertain.From<SourceOfWater>(value);
		}
		[SQLite.Column(SQL.Column_SourceOfFuelCooking)] public int? SourceOfFuelCooking
		{
			get => _SourceOfFuelCooking?.ToInt(_ => (int?)_);
			set => _SourceOfFuelCooking = Uncertain.From<SourceOfFuel>(value);
		}
		[SQLite.Column(SQL.Column_SourceOfFuelHeating)] public int? SourceOfFuelHeating
		{
			get => _SourceOfFuelHeating?.ToInt(_ => (int?)_);
			set => _SourceOfFuelHeating = Uncertain.From<SourceOfFuel>(value);
		}
		[SQLite.Column(SQL.Column_SourceOfFuelLighting)] public int? SourceOfFuelLighting
		{
			get => _SourceOfFuelLighting?.ToInt(_ => (int?)_);
			set => _SourceOfFuelLighting = Uncertain.From<SourceOfFuel>(value);
		}
		[SQLite.Column(SQL.Column_Urban)] public int? Urban
		{
			get => _Urban?.ToInt();
			set => _Urban = Uncertain.From<bool>(value);
		}

		public Uncertain<Provinces>? _Province;
		public Uncertain<bool>? _DwellingsOwned;
		public Uncertain<TypeDwelling>? _Dwelling;
		public Uncertain<FacilitiesToilet>? _FacilitiesToilet;
		public Uncertain<FacilitiesTelephone>? _FacilitiesTelephone;
		public Uncertain<FacilitiesRefuseDisposal>? _FacilitiesRefuseDisposal;
		public Uncertain<int>? _HeadOf_Age;
		public Uncertain<EducationLevels>? _HeadOf_Education;
		public Uncertain<EmploymentStatuses>? _HeadOf_EmploymentStatus;
		public Uncertain<IncomeLevelsMonthly>? _HeadOf_IncomeLevel;
		public Uncertain<PopulationGroups>? _HeadOf_Race;
		public Uncertain<Sexes>? _HeadOf_Sex;
		public Uncertain<IncomeLevelsMonthly>? _HighestIncomeIn;
		public Uncertain<Sexes>? _HighestIncomeIn_Gender;
		public Uncertain<PopulationGroups>? _HighestIncomeIn_Race;
		public Uncertain<int>? _HouseholdSize;
		public Uncertain<IncomeLevelsMonthlyHousehold>? _Income;
		public Uncertain<IncomeLevelsMonthlyHousehold>? _IncomeAdditional;
		public Uncertain<IncomeLevelsMonthlyHousehold>? _IncomeReceivedRemittances;
		public Uncertain<bool>? _Migrant;
		public Uncertain<int>? _NumberOf_MigrantWorkers;
		public Uncertain<int>? _NumberOf_HouseholdsSharingOneRoom;
		public Uncertain<TypeQuestionnaireHouseholds>? _QuestionType;
		public Uncertain<int>? _Rooms;
		public Uncertain<SourceOfWater>? _SourceOfWater;
		public Uncertain<SourceOfFuel>? _SourceOfFuelCooking;
		public Uncertain<SourceOfFuel>? _SourceOfFuelHeating;
		public Uncertain<SourceOfFuel>? _SourceOfFuelLighting;
		public Uncertain<bool>? _Urban;

		public RecordHousehold ToModel()
		{
			return new RecordHousehold
			{
				Dwelling = new Dwellings
				{
					Owned = Uncertain.From<bool>(DwellingsOwned),
					Dwelling = Uncertain.From<TypeDwelling>(Dwelling),
					Migrants = Uncertain.From<bool>(Migrant),
					NumberOf_MigrantWorkers = Uncertain.From<int>(NumberOf_MigrantWorkers),
					NumberOf_HouseholdsSharingOneRoom = Uncertain.From<int>(NumberOf_HouseholdsSharingOneRoom),
				},
				HouseholdIncome = new HouseholdIncome
				{					
					HighestIncomeIn = Uncertain.From<IncomeLevelsMonthly>(HighestIncomeIn),
					HighestIncomeIn_Gender = Uncertain.From<Sexes>(HighestIncomeIn_Gender),
					HighestIncomeIn_Race = Uncertain.From<PopulationGroups>(HighestIncomeIn_Race),
					Income = Uncertain.From<IncomeLevelsMonthlyHousehold>(Income),
					IncomeAdditional = Uncertain.From<IncomeLevelsMonthlyHousehold>(IncomeAdditional),
					IncomeReceivedRemittances = Uncertain.From<IncomeLevelsMonthlyHousehold>(IncomeReceivedRemittances),
				},
				Household = new Household
				{
					FacilitiesToilet = Uncertain.From<FacilitiesToilet>(FacilitiesToilet),
					FacilitiesTelephone = Uncertain.From<FacilitiesTelephone>(FacilitiesTelephone),
					FacilitiesRefuseDisposal = Uncertain.From<FacilitiesRefuseDisposal>(FacilitiesRefuseDisposal),
					Rooms = Uncertain.From<int>(Rooms),
					Size = Uncertain.From<int>(HouseholdSize),
					SourceOfWater = Uncertain.From<SourceOfWater>(SourceOfWater),
					SourceOfFuelCooking = Uncertain.From<SourceOfFuel>(SourceOfFuelCooking),
					SourceOfFuelHeating = Uncertain.From<SourceOfFuel>(SourceOfFuelHeating),
					SourceOfFuelLighting = Uncertain.From<SourceOfFuel>(SourceOfFuelLighting),

					HeadOf = new Personhood
					{
						Age = Uncertain.From<int>(HeadOf_Age),
						Education = Uncertain.From<EducationLevels>(HeadOf_Education),
						Gender = Uncertain.From<Sexes>(HeadOf_Sex),
						IncomeLevel = Uncertain.From<IncomeLevelsMonthly>(HeadOf_IncomeLevel),
						Occupation = HeadOf_Occupation,
						Race = Uncertain.From<PopulationGroups>(HeadOf_Race),
						StatusEmployment = Uncertain.From<EmploymentStatuses>(HeadOf_EmploymentStatus),
					},
				},
				Metadata = new Metadata
				{
					TypeQuestionnaire = Uncertain.From<TypeQuestionnaireHouseholds>(QuestionType),
				},
				Location = new Location
				{
					Province = Uncertain.From<Provinces>(Province),
					CouncilCodeDistrict = CouncilCodeDistrict,
					CouncilCodeMagisterial = CouncilCodeMagisterial,
					CouncilCodeTransitionalLocalRural = CouncilCodeTransitionalLocalRural,
				},
			};
		}
		public void FromModel(RecordHousehold record)
		{
			HighestIncomeIn = record.HouseholdIncome?.HighestIncomeIn?.ToInt(_ => (int?)_);
			HighestIncomeIn_Gender = record.HouseholdIncome?.HighestIncomeIn_Gender?.ToInt(_ => (int?)_);
			HighestIncomeIn_Race = record.HouseholdIncome?.HighestIncomeIn_Race?.ToInt(_ => (int?)_);
			Income = record.HouseholdIncome?.Income?.ToInt(_ => (int?)_);
			IncomeAdditional = record.HouseholdIncome?.IncomeAdditional?.ToInt(_ => (int?)_);
			IncomeReceivedRemittances = record.HouseholdIncome?.IncomeReceivedRemittances?.ToInt(_ => (int?)_);

			Dwelling = record.Dwelling?.Dwelling?.ToInt(_ => (int?)_);
			DwellingsOwned = record.Dwelling?.Owned?.ToInt();
			Migrant = record.Dwelling?.Migrants?.ToInt();
			NumberOf_MigrantWorkers = record.Dwelling?.NumberOf_MigrantWorkers?.ToInt(_ => (int?)_);
			NumberOf_HouseholdsSharingOneRoom = record.Dwelling?.NumberOf_HouseholdsSharingOneRoom?.ToInt(_ => (int?)_);
			
			CouncilCodeDistrict = record.Location?.CouncilCodeDistrict;
			CouncilCodeMagisterial = record.Location?.CouncilCodeMagisterial;
			CouncilCodeTransitionalLocalRural = record.Location?.CouncilCodeTransitionalLocalRural;
			Province = record.Location?.Province?.ToInt(_ => (int?)_);
			Urban = record.Location?.Urban?.ToInt(_ => _);

			QuestionType = record.Metadata?.TypeQuestionnaire?.ToInt(_ => (int?)_);

			FacilitiesToilet = record.Household?.FacilitiesToilet?.ToInt(_ => (int?)_);
			FacilitiesTelephone = record.Household?.FacilitiesTelephone?.ToInt(_ => (int?)_);
			FacilitiesRefuseDisposal = record.Household?.FacilitiesRefuseDisposal?.ToInt(_ => (int?)_);
			Rooms = record.Household?.Rooms?.ToInt(_ => _);
			HouseholdSize = record.Household?.Size?.ToInt(_ => _);
			SourceOfWater = record.Household?.SourceOfWater?.ToInt(_ => (int?)_);
			SourceOfFuelCooking = record.Household?.SourceOfFuelCooking?.ToInt(_ => (int?)_);
			SourceOfFuelHeating = record.Household?.SourceOfFuelHeating?.ToInt(_ => (int?)_);
			SourceOfFuelLighting = record.Household?.SourceOfFuelLighting?.ToInt(_ => (int?)_);

			HeadOf_Age = record.Household?.HeadOf?.Age?.ToInt(_ => (int?)_);
			HeadOf_Education = record.Household?.HeadOf?.Education?.ToInt(_ => (int?)_);
			HeadOf_Sex = record.Household?.HeadOf?.Gender?.ToInt(_ => (int?)_);
			HeadOf_IncomeLevel = record.Household?.HeadOf?.IncomeLevel?.ToInt(_ => (int?)_);
			HeadOf_Occupation = record.Household?.HeadOf?.Occupation;
			HeadOf_Race = record.Household?.HeadOf?.Race?.ToInt(_ => (int?)_);
			HeadOf_EmploymentStatus = record.Household?.HeadOf?.StatusEmployment?.ToInt(_ => (int?)_);
		}
	}
}