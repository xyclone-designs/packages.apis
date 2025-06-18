using XycloneDesigns.Apis.STATSSA.Enums;
using XycloneDesigns.Apis.STATSSA.Structs;

namespace XycloneDesigns.Apis.STATSSA.Models
{
    public class Personhood : _Model
	{
		public Uncertain<int>? Age { get; set; }
		public Uncertain<CitizenshipStatus>? Citizenship { get; set; }
		public Uncertain<Countries>? CountryBirth { get; set; }
		public Uncertain<Countries>? CountryCitizenOther { get; set; }
		public Uncertain<Countries>? CountryCitizenSouthAfrica { get; set; }
		public Uncertain<EducationLevels>? Education { get; set; }
		public Uncertain<Sexes>? Gender { get; set; }
		public Uncertain<EducationLevels>? HighestSchoolClass1 { get; set; }
		public Uncertain<EducationLevels>? HighestSchoolClass2 { get; set; }
		public Uncertain<EducationFields>? HighestQualification1 { get; set; }
		public Uncertain<EducationFields>? HighestQualification2 { get; set; }
		public Uncertain<IncomeLevelsMonthly>? IncomeLevel { get; set; }
		public Uncertain<bool>? IsAliveMother { get; set; }
		public Uncertain<bool>? IsAliveFather { get; set; }
		public Uncertain<Languages>? Language1 { get; set; }
		public Uncertain<Languages>? Language2 { get; set; }
		public Uncertain<MaritalStatuses>? MaritalStatus { get; set; }
		public Uncertain<bool>? Migrant { get; set; }
		public int? Occupation { get; set; }
		public Uncertain<PopulationGroups>? Race { get; set; }
		public Uncertain<Religions>? Religion { get; set; }
		public Uncertain<EmploymentStatuses>? StatusEmployment { get; set; }
		public Uncertain<StatusStudying>? StatusStudying { get; set; }
		public Uncertain<StatusWork>? StatusWork { get; set; }
	}
}