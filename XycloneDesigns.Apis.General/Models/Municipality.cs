using System;

namespace XycloneDesigns.Apis.General.Models
{
	public partial class Municipality : Model
	{
		public string? AddressEmail { get; set; }
		public string? AddressPostal { get; set; }
		public string? AddressStreet { get; set; }
		public string? Category { get; set; }
		public string? GeoLevel { get; set; }
		public string? GeoCode { get; set; }
		public bool? IsDisestablished { get; set; }
		public string? MiifCategory { get; set; }
		public string? Name { get; set; }
		public string? NameLong { get; set; }
		public string? NumberFax { get; set; }
		public string? NumberPhone { get; set; }
		public Province? Province { get; set; }
		public int? Population { get; set; }
		public decimal? SquareKms { get; set; }
		public Uri? UrlLogo { get; set; }
		public Uri? UrlWebsite { get; set; }
	}
}