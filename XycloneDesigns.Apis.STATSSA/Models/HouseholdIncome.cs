using XycloneDesigns.Apis.STATSSA.Enums;
using XycloneDesigns.Apis.STATSSA.Structs;

namespace XycloneDesigns.Apis.STATSSA.Models
{
    public class HouseholdIncome : _Model
	{
		public Uncertain<IncomeLevelsMonthly>? HighestIncomeIn { get; set; }
		public Uncertain<Sexes>? HighestIncomeIn_Gender { get; set; }
		public Uncertain<PopulationGroups>? HighestIncomeIn_Race { get; set; }
		public Uncertain<IncomeLevelsMonthlyHousehold>? Income { get; set; }
		public Uncertain<IncomeLevelsMonthlyHousehold>? IncomeAdditional { get; set; }
		public Uncertain<IncomeLevelsMonthlyHousehold>? IncomeReceivedRemittances { get; set; }
	}
}