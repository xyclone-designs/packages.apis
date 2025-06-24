using System;

namespace XycloneDesigns.Apis.General.Models
{
	public class Country : Model
	{
		public string? Capital { get; set; }
		public string? Code { get; set; }
		public string? Name { get; set; }
		public int? Population { get; set; }
		public decimal? SquareKms { get; set; }
		public Uri? UrlCoatOfArms { get; set; }
		public Uri? UrlWebsite { get; set; }
	}
}