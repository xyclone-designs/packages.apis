
namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Address : Model
	{
		public string? CountryName { get; set; }
		public string? Locality { get; set; }
		public string? PostalCode { get; set; }
		public string? Region { get; set; }
		public string? StreetAddress { get; set; }
	}
}