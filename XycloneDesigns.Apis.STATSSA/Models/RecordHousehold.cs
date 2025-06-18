
namespace XycloneDesigns.Apis.STATSSA.Models
{
	public class RecordHousehold : Record
	{
		public Dwellings? Dwelling { get; set; }
		public Household? Household { get; set; }
		public HouseholdIncome? HouseholdIncome { get; set; }
		public Land? Land { get; set; }
		public Location? Location { get; set; }
		public Metadata? Metadata { get; set; }	
	}
}