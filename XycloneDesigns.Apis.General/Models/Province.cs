using System;

namespace XycloneDesigns.Apis.General.Models
{
	public partial class Province : Model
	{
		public string? Capital { get; set; }
		public Country? Country { get; set; }
		public string? Id { get; set; }
		public string? Name { get; set; }
		public int? Population { get; set; }
		public decimal? SquareKms { get; set; }
		public Uri? UrlCoatOfArms { get; set; }
		public Uri? UrlWebsite { get; set; }
	}
}