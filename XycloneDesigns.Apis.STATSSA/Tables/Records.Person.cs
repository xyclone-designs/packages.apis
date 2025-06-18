using XycloneDesigns.Apis.STATSSA.Enums;
using XycloneDesigns.Apis.STATSSA.Models;
using XycloneDesigns.Apis.STATSSA.Structs;

namespace XycloneDesigns.Apis.STATSSA.Tables
{
	[SQLite.Table(SQL.Table)]
	public class RecordsPerson : Records
	{
		public new static class SQL
		{
			public const string Table = "records_person";

			public const string Column_Age = "age";
			public const string Column_AgeOfMotherAtFirstBorn = "ageofmotheratfirstborn";
			public const string Column_ChildrenBorn = "childrenborn";
			public const string Column_ChildrenAlive = "childrenalive";
			public const string Column_Citizenship = "citizenship";
			public const string Column_CouncilCodeDistrict = "councilcodedistrict";
			public const string Column_CouncilCodeMagisterial = "councilcodemagisterial";
			public const string Column_CouncilCodeTransitionalLocalRural = "councilcodetransitionallocalrural";
			public const string Column_CountryBirth = "countrybirth";
			public const string Column_CountryCitizenOther = "countrycitizenother";
			public const string Column_CountryCitizenSouthAfrica = "countrycitizensouthafrica";
			public const string Column_Disability = "disability";
			public const string Column_DisabilitySight = "disabilitysight";
			public const string Column_DisabilityHearing = "disabilityhearing";
			public const string Column_DisabilityPhysical = "disabilityphysical";
			public const string Column_DisabilityMental = "disabilitymental";
			public const string Column_FullOrPartTime = "fullorparttime";
			public const string Column_EmploymentMagisterialCode = "employmentmagisterialcode";
			public const string Column_HighestSchoolClass1 = "highestschoolclass1";
			public const string Column_HighestSchoolClass2 = "highestschoolclass2";
			public const string Column_HighestQualification1 = "highestqualification1";
			public const string Column_HighestQualification2 = "highestqualification2";
			public const string Column_Income = "income";
			public const string Column_IndustryCode = "industrycode";
			public const string Column_IsAliveMother = "isalivemother";
			public const string Column_IsAliveFather = "isalivefather";
			public const string Column_Language1 = "language1";
			public const string Column_Language2 = "language2";
			public const string Column_MaritalStatus = "maritalstatus";
			public const string Column_MigrantWorker = "migrantworker";
			public const string Column_NumberBirthsLast12Months = "numberbirthslast12months";
			public const string Column_NumberHousehold = "numberhousehold";
			public const string Column_NumberPerson = "numberperson";
			public const string Column_OccupationCode = "occupationcode";
			public const string Column_OccupationCodePrevious = "occupationcodeprevious";
			public const string Column_Province = "province";
			public const string Column_PreviousResidenceMagesterialCode = "previousresidencemagesterialcode";
			public const string Column_Race = "race";
			public const string Column_Relationship = "relationship";
			public const string Column_Religion = "religion";
			public const string Column_TypeInstitution = "typeinstitution";
			public const string Column_TypeQuestionnaire = "typequestionnaire";
			public const string Column_Sex = "sex";
			public const string Column_StatusEmployment = "statusemployment";
			public const string Column_StatusStudying = "statusstudying";
			public const string Column_StatusWork = "statuswork";
			public const string Column_Urban = "urban";
			public const string Column_UsualResidenceMagesterialCode = "usualresidencemagesterialcode";
			public const string Column_UsualResidencePlaceOf = "usualresidenceplaceof";
			public const string Column_UsualResidenceYearMoved = "usualresidenceyearmoved";
		}

		[SQLite.Column(SQL.Column_Age)] public int? Age { get; set; }
		[SQLite.Column(SQL.Column_AgeOfMotherAtFirstBorn)] public int? AgeOfMotherAtFirstBorn { get; set; }
		[SQLite.Column(SQL.Column_ChildrenBorn)] public int? ChildrenBorn { get; set; }
		[SQLite.Column(SQL.Column_ChildrenAlive)] public int? ChildrenAlive { get; set; }
		[SQLite.Column(SQL.Column_Citizenship)] public int? Citizenship { get; set; }
		[SQLite.Column(SQL.Column_CouncilCodeDistrict)] public int? CouncilCodeDistrict { get; set; }
		[SQLite.Column(SQL.Column_CouncilCodeMagisterial)] public int? CouncilCodeMagisterial { get; set; }
		[SQLite.Column(SQL.Column_CouncilCodeTransitionalLocalRural)] public int? CouncilCodeTransitionalLocalRural { get; set; }
		[SQLite.Column(SQL.Column_CountryBirth)] public int? CountryBirth { get; set; }
		[SQLite.Column(SQL.Column_CountryCitizenOther)] public int? CountryCitizenOther { get; set; }
		[SQLite.Column(SQL.Column_CountryCitizenSouthAfrica)] public int? CountryCitizenSouthAfrica { get; set; }
		[SQLite.Column(SQL.Column_Disability)] public int? Disability { get; set; }
		[SQLite.Column(SQL.Column_DisabilitySight)] public int? DisabilitySight { get;set; }
		[SQLite.Column(SQL.Column_DisabilityHearing)] public int? DisabilityHearing { get;set; }
		[SQLite.Column(SQL.Column_DisabilityPhysical)] public int? DisabilityPhysical { get;set; }
		[SQLite.Column(SQL.Column_DisabilityMental)] public int? DisabilityMental { get;set; }
		[SQLite.Column(SQL.Column_FullOrPartTime)] public int? FullOrPartTime { get;set; }
		[SQLite.Column(SQL.Column_EmploymentMagisterialCode)] public int? EmploymentMagisterialCode { get; set; }
		[SQLite.Column(SQL.Column_HighestSchoolClass1)] public int? HighestSchoolClass1 { get; set; }
		[SQLite.Column(SQL.Column_HighestSchoolClass2)] public int? HighestSchoolClass2 { get; set; }
		[SQLite.Column(SQL.Column_HighestQualification1)] public int? HighestQualification1 { get; set; }
		[SQLite.Column(SQL.Column_HighestQualification2)] public int? HighestQualification2 { get; set; }
		[SQLite.Column(SQL.Column_Income)] public int? Income { get; set; }
		[SQLite.Column(SQL.Column_IndustryCode)] public int? IndustryCode { get; set; }
		[SQLite.Column(SQL.Column_IsAliveMother)] public int? IsAliveMother { get; set; }
		[SQLite.Column(SQL.Column_IsAliveFather)] public int? IsAliveFather { get; set; }
		[SQLite.Column(SQL.Column_Language1)] public int? Language1 { get; set; }
		[SQLite.Column(SQL.Column_Language2)] public int? Language2 { get; set; }
		[SQLite.Column(SQL.Column_MaritalStatus)] public int? MaritalStatus { get; set; }
		[SQLite.Column(SQL.Column_MigrantWorker)] public int? MigrantWorker { get; set; }
		[SQLite.Column(SQL.Column_NumberBirthsLast12Months)] public int? NumberBirthsLast12Months { get; set; }
		[SQLite.Column(SQL.Column_NumberHousehold)] public int? NumberHousehold { get; set; }
		[SQLite.Column(SQL.Column_NumberPerson)] public int? NumberPerson { get; set; }
		[SQLite.Column(SQL.Column_OccupationCode)] public int? OccupationCode { get; set; }
		[SQLite.Column(SQL.Column_OccupationCodePrevious)] public int? OccupationCodePrevious { get; set; }
		[SQLite.Column(SQL.Column_Province)] public int? Province { get; set; }
		[SQLite.Column(SQL.Column_PreviousResidenceMagesterialCode)] public int? PreviousResidenceMagesterialCode { get; set; }
		[SQLite.Column(SQL.Column_Race)] public int? Race { get; set; }
		[SQLite.Column(SQL.Column_Relationship)] public int? Relationship { get; set; }
		[SQLite.Column(SQL.Column_Religion)] public int? Religion { get; set; }
		[SQLite.Column(SQL.Column_TypeInstitution)] public int? TypeInstitution { get; set; }
		[SQLite.Column(SQL.Column_TypeQuestionnaire)] public int? TypeQuestionnaire { get; set; }
		[SQLite.Column(SQL.Column_Sex)] public int? Sex { get; set; }
		[SQLite.Column(SQL.Column_StatusEmployment)] public int? StatusEmployment { get; set; }
		[SQLite.Column(SQL.Column_StatusStudying)] public int? StatusStudying { get; set; }
		[SQLite.Column(SQL.Column_StatusWork)] public int? StatusWork { get; set; }
		[SQLite.Column(SQL.Column_Urban)] public int? Urban { get; set; }
		[SQLite.Column(SQL.Column_UsualResidenceMagesterialCode)] public int? UsualResidenceMagesterialCode { get; set; }
		[SQLite.Column(SQL.Column_UsualResidencePlaceOf)] public int? UsualResidencePlaceOf { get; set; }
		[SQLite.Column(SQL.Column_UsualResidenceYearMoved)] public int? UsualResidenceYearMoved { get; set; }

		public RecordPerson ToModel()
		{
			return new RecordPerson
			{
				Location = new Location
				{
					CouncilCodeDistrict = CouncilCodeDistrict,
					CouncilCodeMagisterial = CouncilCodeMagisterial,
					CouncilCodeTransitionalLocalRural = CouncilCodeTransitionalLocalRural,
					Province = Uncertain.From<Provinces>(Province),
					Urban = Uncertain.From<int>(Urban),
				},
				Disabilities = new Disabilities
				{
					Type = Uncertain.From<TypeDisability>(Disability),
					Sight = Uncertain.From<bool>(DisabilitySight),
					Hearing = Uncertain.From<bool>(DisabilityHearing),
					Physical = Uncertain.From<bool>(DisabilityPhysical),
					Mental = Uncertain.From<bool>(DisabilityMental),
				},
				Metadata = new Metadata
				{
					TypeInstitution = Uncertain.From<TypeInstitution>(TypeInstitution),
					TypeQuestionnaire = Uncertain.From<TypeQuestionnaireHouseholds>(TypeQuestionnaire),
				},
				Motherhood = new Motherhood
				{
					AgeAtFirstBorn = Uncertain.From<int>(AgeOfMotherAtFirstBorn),
					ChildrenBorn = Uncertain.From<int>(ChildrenBorn),
					ChildrenAlive = Uncertain.From<int>(ChildrenAlive),
					NumberBirthsLast12Months = Uncertain.From<int>(NumberBirthsLast12Months),
				},
				Personhood = new Personhood
				{
					Age = Uncertain.From<int>(Age),
					Citizenship = Uncertain.From<CitizenshipStatus>(Citizenship),
					CountryBirth = Uncertain.From<Countries>(CountryBirth),
					CountryCitizenOther = Uncertain.From<Countries>(CountryCitizenOther),
					CountryCitizenSouthAfrica = Uncertain.From<Countries>(CountryCitizenSouthAfrica),
					HighestSchoolClass1 = Uncertain.From<EducationLevels>(HighestSchoolClass1),
					HighestSchoolClass2 = Uncertain.From<EducationLevels>(HighestSchoolClass2),
					HighestQualification1 = Uncertain.From<EducationFields>(HighestQualification1),
					HighestQualification2 = Uncertain.From<EducationFields>(HighestQualification2),
					IsAliveMother = Uncertain.From<bool>(IsAliveMother),
					IsAliveFather = Uncertain.From<bool>(IsAliveFather),
					Language1 = Uncertain.From<Languages>(Language1),
					Language2 = Uncertain.From<Languages>(Language2),
					MaritalStatus = Uncertain.From<MaritalStatuses>(MaritalStatus),
					Race = Uncertain.From<PopulationGroups>(Race),
					Religion = Uncertain.From<Religions>(Religion),
					Gender = Uncertain.From<Sexes>(Sex),
					StatusEmployment = Uncertain.From<EmploymentStatuses>(StatusEmployment),
					StatusStudying = Uncertain.From<StatusStudying>(StatusStudying),
					StatusWork = Uncertain.From<StatusWork>(StatusWork),
				},
				Occupation = new Occupation
				{
					Code = OccupationCode,
					CodeEmploymentMagisterial = EmploymentMagisterialCode,
					CodeIndustry = IndustryCode,
					CodePrevious = OccupationCodePrevious,
					FullOrPartTime = Uncertain.From<bool>(FullOrPartTime),
					Income = Uncertain.From<IncomeLevelsMonthly>(Income),
					IsMigrantWorker = Uncertain.From<bool>(MigrantWorker),
				},
				Residence = new Residence
				{
					PreviousMagesterialCode = PreviousResidenceMagesterialCode,
					UsualMagesterialCode = UsualResidenceMagesterialCode,
					UsualPlaceOf = Uncertain.From<UsualResidence>(UsualResidencePlaceOf),
					UsualYearMoved = Uncertain.From<int>(UsualResidenceYearMoved),
				},
			};
		}
		public void FromModel(RecordPerson record)
		{
			CouncilCodeDistrict = record.Location?.CouncilCodeDistrict;
			CouncilCodeMagisterial = record.Location?.CouncilCodeMagisterial;
			CouncilCodeTransitionalLocalRural= record.Location?.CouncilCodeTransitionalLocalRural;
			Province = record.Location?.Province?.ToInt(_ => (int?)_);
			Urban = record.Location?.Urban?.ToInt(_ => _);

			Disability = record.Disabilities?.Type?.ToInt(_ => (int?)_);
			DisabilitySight = record.Disabilities?.Sight?.ToInt();
			DisabilityHearing = record.Disabilities?.Hearing?.ToInt();
			DisabilityPhysical = record.Disabilities?.Physical?.ToInt();
			DisabilityMental = record.Disabilities?.Mental?.ToInt();

			TypeInstitution = record.Metadata?.TypeInstitution?.ToInt(_ => (int?)_);
			TypeQuestionnaire = record.Metadata?.TypeQuestionnaire?.ToInt(_ => (int?)_);

			AgeOfMotherAtFirstBorn = record.Motherhood?.AgeAtFirstBorn?.ToInt(_ => _);
			ChildrenBorn = record.Motherhood?.ChildrenBorn?.ToInt(_ => _);
			ChildrenAlive = record.Motherhood?.ChildrenAlive?.ToInt(_ => _);
			NumberBirthsLast12Months = record.Motherhood?.NumberBirthsLast12Months?.ToInt(_ => _);

			Age = record.Personhood?.Age?.ToInt(_ => _);
			Citizenship = record.Personhood?.Citizenship?.ToInt(_ => (int?)_);
			CountryBirth = record.Personhood?.CountryBirth?.ToInt(_ => (int?)_);
			CountryCitizenOther = record.Personhood?.CountryCitizenOther?.ToInt(_ => (int?)_);
			CountryCitizenSouthAfrica = record.Personhood?.CountryCitizenSouthAfrica?.ToInt(_ => (int?)_);
			HighestSchoolClass1 = record.Personhood?.HighestSchoolClass1?.ToInt(_ => (int?)_);
			HighestSchoolClass2 = record.Personhood?.HighestSchoolClass2?.ToInt(_ => (int?)_);
			HighestQualification1 = record.Personhood?.HighestQualification1?.ToInt(_ => (int?)_);
			HighestQualification2 = record.Personhood?.HighestQualification2?.ToInt(_ => (int?)_);
			IsAliveMother = record.Personhood?.IsAliveMother?.ToInt();
			IsAliveFather = record.Personhood?.IsAliveFather?.ToInt();
			Language1 = record.Personhood?.Language1?.ToInt(_ => (int?)_);
			Language2 = record.Personhood?.Language2?.ToInt(_ => (int?)_);
			MaritalStatus = record.Personhood?.MaritalStatus?.ToInt(_ => (int?)_);
			Race = record.Personhood?.Race?.ToInt(_ => (int?)_);
			Religion = record.Personhood?.Religion?.ToInt(_ => (int?)_);
			Sex = record.Personhood?.Gender?.ToInt(_ => (int?)_);
			StatusEmployment = record.Personhood?.StatusEmployment?.ToInt(_ => (int?)_);
			StatusStudying = record.Personhood?.StatusStudying?.ToInt(_ => (int?)_);
			StatusWork = record.Personhood?.StatusWork?.ToInt(_ => (int?)_);

			OccupationCode = record.Occupation?.Code;
			EmploymentMagisterialCode = record.Occupation?.CodeEmploymentMagisterial;
			IndustryCode = record.Occupation?.CodeIndustry;
			OccupationCodePrevious = record.Occupation?.CodePrevious;
			FullOrPartTime = record.Occupation?.FullOrPartTime?.ToInt();
			Income = record.Occupation?.Income?.ToInt(_ => (int?)_);
			MigrantWorker = record.Occupation?.IsMigrantWorker?.ToInt();

			PreviousResidenceMagesterialCode = record.Residence?.PreviousMagesterialCode;
			UsualResidenceMagesterialCode = record.Residence?.UsualMagesterialCode;
			UsualResidencePlaceOf = record.Residence?.UsualPlaceOf?.ToInt(_ => (int?)_);
			UsualResidenceYearMoved = record.Residence?.UsualYearMoved?.ToInt(_ => _);
		}
	}
}