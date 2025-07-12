using Newtonsoft.Json;

using System.Text.Json.Serialization;

namespace XycloneDesigns.Apis.ETenders.Models
{
    public class Address : Model
	{
		public class Json
		{
			public const string CountryName = "countryName";
			public const string Locality = "locality";
			public const string PostalCode = "postalCode";
			public const string Region = "region";
			public const string StreetAddress = "streetAddress";
		}

		[JsonProperty(Json.CountryName), JsonPropertyName(Json.CountryName)] public string? CountryName { get; set; }
		[JsonProperty(Json.Locality), JsonPropertyName(Json.Locality)] public string? Locality { get; set; }
		[JsonProperty(Json.PostalCode), JsonPropertyName(Json.PostalCode)] public string? PostalCode { get; set; }
		[JsonProperty(Json.Region), JsonPropertyName(Json.Region)] public string? Region { get; set; }
		[JsonProperty(Json.StreetAddress), JsonPropertyName(Json.StreetAddress)] public string? StreetAddress { get; set; }
	}
}