
namespace XycloneDesigns.Apis.ETenders.Models
{
    public class TenderItem : Model
	{
		public string? Description { get; set; }
		public string? Classification { get; set; }
		public Classification? Classifications { get; set; }
		public string? Id { get; set; }
		public string? ItemId { get; set; }
		public int Quantity { get; set; }
		public string? Unit { get; set; }
	}
}